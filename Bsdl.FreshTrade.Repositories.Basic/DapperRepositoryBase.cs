using System.Collections;
using System.Data;
using System.Data.Common;
using System.Diagnostics;
using System.Linq.Expressions;
using Bsdl.FreshTrade.Domain.Basic.Entities;
using Bsdl.FreshTrade.Domain.Basic.Enums;
using Bsdl.FreshTrade.Domain.Basic.Exceptions;
using Bsdl.FreshTrade.Domain.Basic.Exceptions.DataAccess;
using Bsdl.FreshTrade.Domain.Basic.Interfaces;
using Bsdl.FreshTrade.Domain.Basic.Utilities;
using Bsdl.FreshTrade.Domain.Basic.Utilities.DataTypeHandling;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Bsdl.FreshTrade.Repositories.Basic;
using Bsdl.FreshTrade.Repositories.Basic.DBModel;
using Bsdl.FreshTrade.Repositories.Basic.Interfaces;
using Bsdl.FreshTrade.Repositories.Basic.Persistance;
using Bsdl.FreshTrade.Repositories.Basic.Utilities.Cache;
using Bsdl.FreshTrade.Repositories.Basic.Utilities.Interfaces;
using Bsdl.FreshTrade.Server.Basic.Interfaces;
using Bsdl.FreshTrade.Server.Basic.Logger;
using Dapper;
using Oracle.ManagedDataAccess.Client;

namespace Bsdl.FreshTrade.Repositories.Basic
{
    public class DapperRepositoryBase<T> : IRepositoryBase<T>
    {
        protected readonly ICacheManagerFactory _cacheManagerFactory;

        protected readonly ILogger _logger; 
        private readonly IDictionary<string, ValidSearchFieldRecord> _validSearchFields;
        protected bool _allowQueryWithoutFilter = false;
        protected bool _allowToCacheData = true;
        private const string _rowNumFielsName = "ROWNUM";
        private const int _maxParamElementsPerSQLChunk = 1000;
        private const int _maxArrayBindBatch = 64000;

        private Queue<long> _sequencePool = new Queue<long>();
// ReSharper disable StaticFieldInGenericType
        private static readonly ValidSearchFieldRecord _rownumSearchFieldRecord = new ValidSearchFieldRecord(_rowNumFielsName, FieldType.Integer);
// ReSharper restore StaticFieldInGenericType

        #region Helpers
        /// <summary>
        /// Checks that at least one field in the fields list is also in the valid fields list
        /// </summary>
        /// <param name="validFieldList">List of valid fields</param>
        /// <param name="fieldList">List of fields</param>
        /// <returns>true or false</returns>
        protected void EnsureSearchFieldsInValidList(IList<string> fieldList)
        {
            bool result = true;
            bool validFieldDefExists = ((_validSearchFields != null) && (_validSearchFields.Count > 0));
            bool searchFieldsExists = ((fieldList != null) && (fieldList.Count > 0));

            if (
                    (!validFieldDefExists && searchFieldsExists) ||
                    (validFieldDefExists && !searchFieldsExists && !_allowQueryWithoutFilter)
               )
            {
                result = false;
            }

            if (!searchFieldsExists)
            {
                return;
            }

            // Get fields that are in both lists
            if (result)
            {
                if (fieldList.Any(field => !_validSearchFields.ContainsKey(field)))
                {
                    result = false;
                }
            }

            if (!result)
            {
                throw new DatabaseInvalidSearchFieldException();
            }
        }

        private ValidSearchFieldRecord ResolveSearchFieldRecord(string fieldName)
        {
            if (fieldName ==  _rowNumFielsName)
            {
                return _rownumSearchFieldRecord;
            }
            return _validSearchFields[fieldName];
        }

        protected static void CheckSearchFieldDefined(List<string> searchFields, string className)
        {
            if ((searchFields == null) || (searchFields.Count() == 0))
            {
                var ex = new DatabaseNoSearchFieldsException(className);
                //AppError.SetError(ex, Environment.StackTrace, ErrorType.Fatal);
                throw ex;
            }
        }

        protected static bool CheckSearchFieldExistsInSearchCriteria<K, R>(List<ISearchField> searchFields, Expression<Func<K, R>> propRef)
        {
            var requiredFieldName = DelegateHelpers.GetPropertyNameFromExpression(propRef);
            return searchFields.Exists(i => i.FieldName == requiredFieldName);
        }

        protected static ISearchField GetSearchFieldFromSearchCriteria<K, R>(List<ISearchField> searchFields, Expression<Func<K, R>> propRef)
        {
            var requiredFieldName = DelegateHelpers.GetPropertyNameFromExpression(propRef);
            return searchFields.FirstOrDefault(i => i.FieldName == requiredFieldName);
        }

        protected string ConstructQuery(string passMainSqlQuery, IList<ISearchField> searchFields, IList<string> alphaFields, bool includeWhere, uint? topRows)
        {
            IList<ISearchField> searchFieldsCopy;
            if (searchFields != null)
            {
                searchFieldsCopy = searchFields;
            }
            else
            {
                searchFieldsCopy = new List<ISearchField>();
            }
             
            if (searchFieldsCopy.Count() != 0)
            {
                EnsureSearchFieldsInValidList(searchFieldsCopy.Select(s => s.FieldName).ToList());
            }

            var stringBuilder = new StringBuilder();

            stringBuilder.AppendLine(passMainSqlQuery);

            if (topRows.HasValue)
            {
                searchFieldsCopy = searchFieldsCopy.ToList();
                searchFieldsCopy.Add(new SearchFieldGeneric(_rowNumFielsName).Apply(topRows.Value + 1, FieldType.Integer));
            }

            if (searchFieldsCopy.Count > 0)
            {
                foreach (var searchField in searchFieldsCopy)
                {
                    if (searchFieldsCopy.IndexOf(searchField) == 0 && includeWhere)
                    {
                        stringBuilder.Append(" WHERE ");
                    }
                    else
                    {
                        stringBuilder.Append(" AND ");
                    }

                    String formattedSearchField = searchField.Value.ToString();

                    if (searchField.FreeFormatSpecial)
                    {
                        stringBuilder.AppendLine(formattedSearchField);
                    }

                    if (!searchField.FreeFormatSpecial)
                    {
                        string stringSearchField = searchField.FieldName;

                        if (stringSearchField.Contains("."))
                        {
                            string[] words = stringSearchField.Split('.');
                            if (words.Any())
                            {
                                stringSearchField = words.Last();
                            }
                        }

                        // to do - date format,  bool format?
                        var searchFieldRecord = ResolveSearchFieldRecord(stringSearchField);
                        if ((searchFieldRecord.Type == FieldType.AlphaNumeric) && searchField.IncludeLike)
                        {
                            // at the minute we only doing like for alpha fields
                            stringBuilder.AppendLine(searchFieldRecord.DbModelFieldName + " LIKE " + AlphaHandling.FormatToSQLAlpha(formattedSearchField, true));
                        }
                        else
                        {
                            stringBuilder.Append(searchFieldRecord.DbModelFieldName);
                            stringBuilder.Append(IsValuesList(searchField.Value) ? " IN " : " = ");
                            stringBuilder.AppendLine(GetSearchFieldValueAsString(searchFieldRecord.Type, searchField.Value));
                        }
                    }
                }
            }
            return stringBuilder.ToString();
        }

        private static bool IsValuesList(object data)
        {
            return !(data is string) && ((data as IEnumerable) != null);
        }

        protected string GetSearchFieldValueAsString(FieldType type, object data)
        {
            if (!IsValuesList(data))
            {
                if (type == FieldType.AlphaNumeric)
                {
                    return AlphaHandling.FormatToSQLAlpha((string) data, false);
                } 
                if (type == FieldType.Bool)
                {
                    return (bool) data ? "1" : "0";
                }

                return data.ToString();
            }

            var list = data as IEnumerable;
            if (list == null)
            {
                throw new FreshTradeException("Data should support IEnumerable");
            }
            var result = new StringBuilder();
            bool firstItem = true;
            foreach (object item in list)
            {
                var dataStr = GetSearchFieldValueAsString(type, item);
                if (!string.IsNullOrEmpty(dataStr))
                {
                    result.Append(firstItem ? "(" : ",");
                    result.Append(dataStr);
                    firstItem = false;
                }
            }
            if (!firstItem)
            {
                result.Append(")");
            }
            return result.ToString();

        }

        protected string ConstructSimpleQuery(string baseQry, IList<ISearchField> searchFields, bool includeWhere, uint? topRows)
        {
            IList<ISearchField> searchFieldsCopy;
            if (searchFields != null)
            {
                searchFieldsCopy = searchFields;
            }
            else
            {
                searchFieldsCopy = new List<ISearchField>();
            }

            if (searchFieldsCopy.Count() != 0)
            {
                EnsureSearchFieldsInValidList(searchFieldsCopy.Select(s => s.FieldName).ToList());
            }

            if (topRows.HasValue)
            {
                searchFieldsCopy = searchFieldsCopy.ToList();
                searchFieldsCopy.Add(new SearchFieldGeneric(_rowNumFielsName).Apply(topRows.Value + 1, FieldType.Integer));
            }

            var stringBuilder = new StringBuilder();

            stringBuilder.AppendLine(baseQry);

            if (searchFieldsCopy.Count > 0)
            {
                foreach (var searchField in searchFieldsCopy)
                {
                    if ((searchFields.IndexOf(searchField) == 0) && includeWhere)
                    {
                        stringBuilder.Append(" WHERE ");
                    }
                    else
                    {
                        stringBuilder.Append(" AND ");
                    }

                    var searchFieldRecord = ResolveSearchFieldRecord(searchField.FieldName);
                    stringBuilder.Append(searchFieldRecord.DbModelFieldName);
                    stringBuilder.Append(IsValuesList(searchField.Value) ? " IN " : " = ");
                    stringBuilder.AppendLine(GetSearchFieldValueAsString(searchFieldRecord.Type, searchField.Value));
                }
            }
            return stringBuilder.ToString();
        }

        public static List<ISearchField> BuildSingleFieldSearch(ISearchField searchField, FieldType fieldType, object data)
        {
            searchField.Apply(data, fieldType);
            return new List<ISearchField>{searchField};
        }

        protected List<T> GetDataInChunks<K, K2>(Expression<Func<T, K>> fieldRef, List<K2> ids)
        {
            return GetDataInChunksCustom<T, K2>
                (
                    i =>
                    GetData
                    (
                        new List<ISearchField>
                        {
                            new SearchFieldGeneric<T, K>(fieldRef).Apply(i, FieldType.List)
                        }, 
                        CachingStrategy.NoCache
                    ),
                    ids
                );
        }

        protected static List<T2> GetDataInChunksCustom<T2, K>(Func<List<K>, List<T2>> queryExpr, List<K> ids, bool executeWhenEmptyIds = false)
        {
            if ((ids == null) || (ids.Count == 0))
            {
                if (executeWhenEmptyIds) 
                {
                    return queryExpr(ids);
                }
                return new List<T2>();
            }
            bool isSingleChunk = ids.Count <= _maxParamElementsPerSQLChunk;
            List<T2> result = null;
            if (!isSingleChunk)
            {
                result = new List<T2>();
            }
            var currentIndex = 0;
            while (currentIndex < ids.Count)
            {
                List<K> idsRange = null;
                int numberOfElements = 0;
                if (isSingleChunk)
                {
                    idsRange = ids;
                }
                else
                {
                    numberOfElements = ids.Count - currentIndex;
                    if (numberOfElements > _maxParamElementsPerSQLChunk)
                    {
                        numberOfElements = _maxParamElementsPerSQLChunk;
                    }
                    idsRange = ids.GetRange(currentIndex, numberOfElements);
                }

                var data = queryExpr(idsRange);

                if (isSingleChunk)
                {
                    return data;
                }
                result.AddRange(data);

                currentIndex += numberOfElements;
            }
            return result;
        }

        #endregion
        #region Cache Management

        private string CalculateCacheKey(Type objectType, IEnumerable<ISearchField> searchFields)
        {
            var paramsAsStr = string.Empty;
            if (searchFields != null)
            {
                var convertedValues =
                    searchFields
                        .Where
                        (
                            i =>
                            {
                                var type = i.Value.GetType();
                                if (!type.IsPrimitive && !type.Equals(typeof(string)))
                                {
                                    throw new FreshTradeException("Not primitive types cannot be cached");
                                }
                                return true;
                            }
                        )
                        .Select(i => string.Format("{0}~{1}", i.FieldName, i.Value.ToString()))
                        .ToArray();
                paramsAsStr = String.Join("~~", convertedValues);
            }
            return string.Format("{0}~{1}~{2}", UnitOfWorkCurrent.DbID, objectType.FullName, paramsAsStr);
        }

        protected List<K> GetFromCacheInternal<K>(IEnumerable<ISearchField> searchFields, CachingStrategy cacheType, out string key)
        {
            key = CalculateCacheKey(typeof(K), searchFields);
            return GetFromCacheInternal<K>(key, cacheType);
        }

        protected List<K> GetFromCacheInternal<K>(string key, CachingStrategy cacheType)
        {
            var cacheManager = _cacheManagerFactory.Get(cacheType);
            return (List<K>)cacheManager.Get(key);
        }

        protected void PutInCacheInternal<K>(string key, CachingStrategy cacheType, List<K> data)
        {
            if (data != null)
            {
                var container = data as IDataContainer;
                if ((container == null) || container.HasData)
                {
                    var cacheManager = _cacheManagerFactory.Get(cacheType);
                    cacheManager.Set(key, data);
                }
            }
        }
        #endregion

        private readonly IUnitOfWork _unitOfWorkCurrent;

        protected IUnitOfWork UnitOfWorkCurrent
        { 
            get { return _unitOfWorkCurrent; } 
        }

        protected DapperRepositoryBase(IUnitOfWork unitOfWorkCurrent, ICacheManagerFactory cacheManagerFactory, IEnumerable<ISearchFieldDef> validSearchFields)
        {
            _unitOfWorkCurrent = unitOfWorkCurrent;
            _cacheManagerFactory = cacheManagerFactory;
            _logger = LogManager.GetLoggerFor<T>();
            _validSearchFields = validSearchFields.ToDictionary(item => item.FieldName, item => item.SearchFieldRecord);
        }

        protected virtual List<T> GetDataInternal(List<ISearchField> searchFields, CachingStrategy allowFromCache, uint? topRows)
        {
            throw new NotImplementedException("Operation is not implemented");
        }

        public long GetNextSequence()
        {
            if (_sequencePool.Count == 0)
            {
                return ReserveSequenceRangeInternal(1);
            }
            return _sequencePool.Dequeue();
        }

        public void ReserveSequenceRange(int? keyNumber = 1)
        {
            var firstKey = ReserveSequenceRangeInternal(keyNumber);
            for (int i = 0; i < keyNumber; i++)
            {
                _sequencePool.Enqueue(firstKey + i);
            }
        }

        protected virtual long ReserveSequenceRangeInternal(int? keyNumber = 1)
        {
            throw new NotImplementedException(String.Format("Please override in descendants {0} to get right sequence logic",this.GetType().Name));
        }

        public List<T> GetData(List<ISearchField> searchFields, CachingStrategy allowFromCache, bool forceRefresh = false, uint? topRows = null)
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();
            List<T> result;
            string cacheKey = string.Empty;
            if (allowFromCache != CachingStrategy.NoCache && _allowToCacheData && !topRows.HasValue && !forceRefresh)
            {
                result = GetFromCacheInternal<T>(searchFields, allowFromCache, out cacheKey);
                if (result != null)
                {
                    return result;
                }
            }
            result = GetDataInternal(searchFields, allowFromCache, topRows);
            if (allowFromCache != CachingStrategy.NoCache && _allowToCacheData && !topRows.HasValue)
            {
                PutInCacheInternal(cacheKey, allowFromCache, result);
            }
            sw.Stop();
            _logger.Debug(String.Format("GetData: {0,5} ms", sw.ElapsedMilliseconds));
            return result;
        }

        public virtual string GetTableName() {
            throw new Exception("Please override GetTableName method in order to be able to perform CRUD operations");
        }

        public virtual IList<EntityPropDef> GetTableFieldsDefs(){
            throw new Exception("Please override GetTableFieldsDefs method in order to be able to perform CRUD operations");        
        }

        public virtual IBaseModel ToDbModel(T item) {
          throw new Exception("Please specify conversion rules");                
        }

        public virtual T Add(T newItem) 
        {

            IBaseModel newDbItem = ToDbModel(newItem);
            var insertSql = GenSqlScriptHelper.GenInsertSql(GetTableName(), GetTableFieldsDefs(), newDbItem);
            UnitOfWorkCurrent.Execute(insertSql);
            //todo- get last inserted value
            return newItem;
        }

        public virtual void Add(ICollection<T> entities)
        {
            if (entities.Count == 0)
            {
                return;
            }

            var insertSql = GenSqlScriptHelper.GenInsertSql(GetTableName(), GetTableFieldsDefs());
            ExecuteCustomSqlWithArrayBinding
                (
                    insertSql,
                    entities,
                    i => GenSqlScriptHelper.GenInsertParams(GetTableFieldsDefs(), i.Select(ToDbModel).ToList())
                );
        }

        protected void ExecuteCustomSqlWithArrayBinding<K>(string sql, ICollection<K> entities, Func<ICollection<K>, DynamicParameters> initializeParams)
        {
            if (entities.Count == 0)
            {
                return;
            }

            DynamicParameters parameters;
            if (entities.Count <= _maxArrayBindBatch)
            {
                parameters = initializeParams(entities);
                UnitOfWorkCurrent.Execute(sql, parameters, null, null, i => { ((OracleCommand)i).ArrayBindCount = entities.Count(); });
            }
            else
            {
                var currentIndex = 0;
                var entitiesList = entities.ToList();
                while (currentIndex < entitiesList.Count)
                {
                    int numberOfElements = entitiesList.Count - currentIndex;
                    if (numberOfElements > _maxArrayBindBatch)
                    {
                        numberOfElements = _maxArrayBindBatch;
                    }

                    parameters = initializeParams(entitiesList.GetRange(currentIndex, numberOfElements));
                    UnitOfWorkCurrent.Execute(sql, parameters, null, null, i => { ((OracleCommand)i).ArrayBindCount = numberOfElements; });

                    currentIndex += numberOfElements;
                }
            }
        }

        public virtual int Update(T existingItem)
        {

            IBaseModel existingDbItem = ToDbModel(existingItem);
            //todo: support case when some of key fields where modified
            var allCols = GetTableFieldsDefs();
            var updateSql = GenSqlScriptHelper.GenUpdateSql(GetTableName(), allCols.Where(z => !z.IsKey).ToList(), allCols.Where(z => z.IsKey).ToList(), existingDbItem, existingDbItem, false);
            if (!String.IsNullOrEmpty(updateSql))
            {
                return UnitOfWorkCurrent.Execute(updateSql);
            }
            return 0;
        }

        public virtual int Update(T oldItem, T newItem, ICollection<IFieldNameRef> nonKeyFieldsForWhereClause = null)
        {
            IBaseModel oldDbItem = ToDbModel(oldItem);
            IBaseModel newDbItem = ToDbModel(newItem);
            //todo: support case when some of key fields where modified
            var allCols = GetTableFieldsDefs();
            IEnumerable<string> updatedProperyNames;
            if (nonKeyFieldsForWhereClause != null)
            {
                var nonKeyFieldsForWhereNames = nonKeyFieldsForWhereClause.Select(i => i.FieldName).ToList();
                updatedProperyNames = nonKeyFieldsForWhereNames.Select(i => ResolveSearchFieldRecord(i).DbModelFieldName).ToList();
            }
            else
            {
                updatedProperyNames = new List<string>();
            }

            var updateSql = 
                GenSqlScriptHelper.GenUpdateSql
                    (
                        GetTableName(), 
                        allCols.Where(z => !z.IsKey).ToList(),
                        allCols.Where(z => z.IsKey || updatedProperyNames.Contains(z.ColumnName)).ToList(), 
                        oldDbItem, 
                        newDbItem, 
                        true
                    );
            if (!String.IsNullOrEmpty(updateSql))
            {
                return UnitOfWorkCurrent.Execute(updateSql);
            }
            return 0;
        }
        
        private List<object> TransformParamsToArrayBindingFormat(ICollection<IRowUpdateInfo> updateRows)
        {
            if (updateRows == null)
            {
                throw new FreshTradeException("Parameter collection is empty");
            }

            var firstRow = updateRows.First();
            var valuesCount = firstRow.FieldValues.Count; 
            var result = new List<object[]>(valuesCount + 1);//+ key value
            for(int i = 0; i <= valuesCount; i++)
            {
                result.Add(new object[updateRows.Count]);
            }
            int rowNo = 0;
            foreach (var row in updateRows)
            {
                int colNo = 0;
                foreach(var value in row.FieldValues)
                {
                    result[colNo][rowNo] = value;
                    colNo++;
                }
                result[valuesCount][rowNo] = row.KeyValue;
                rowNo ++;
            }
            return result.Cast<object>().ToList();
        }

        public virtual void Update(ICollection<IFieldNameRef> updateFields, ICollection<IRowUpdateInfo> updateRows)
        {
            if ((updateRows.Count == 0) || (updateFields.Count == 0))
            {
                return;
            }

            var allCols = GetTableFieldsDefs();

            var keyPropDefs = allCols.Where(z => z.IsKey).ToList();
            var updatedDTOProperyNames = updateFields.Select(i => i.FieldName).ToList();
            var updatedProperyNames = updatedDTOProperyNames.Select(i => ResolveSearchFieldRecord(i).DbModelFieldName).ToList();

            var updatedCols = allCols.Where(i => updatedProperyNames.Contains(i.ColumnName)).ToList();
            var allInvolvedCols = new List<EntityPropDef>(updatedCols);
            allInvolvedCols.AddRange(keyPropDefs);


            var updateSql = GenSqlScriptHelper.GenUpdateSqlWithArrayBinding(GetTableName(), updatedCols, keyPropDefs);

            ExecuteCustomSqlWithArrayBinding
                (
                    updateSql,
                    updateRows,
                    i => GenSqlScriptHelper.GenInsertParamsByValuesList(allInvolvedCols, TransformParamsToArrayBindingFormat(i))
                );

        }

        private void DetectUpdatedProperties(IEnumerable<EntityPropDef> allProps, List<EntityPropDef> updatedProps, IBaseModel entityOld, IBaseModel entityNew)
        {
            foreach (var propDef in allProps)
            {
                if (!updatedProps.Contains(propDef) && !ObjectHandling.ValueEquality(propDef.GetValue(entityOld), propDef.GetValue(entityNew)))
                {
                    updatedProps.Add(propDef);
                }
            }
        }

        public virtual void Update(ICollection<UpdatePair<T>> items)
        {
            if (items.Count == 0)
            {
                return;
            }

            var allProps = GetTableFieldsDefs();
            var updatedProps = new List<EntityPropDef>();
            var newDbObjects = new List<IBaseModel>();
            foreach (var item in items)
            {
                IBaseModel oldDbItem = ToDbModel(item.Old);
                IBaseModel newDbItem = ToDbModel(item.New);
                newDbObjects.Add(newDbItem);

                DetectUpdatedProperties(allProps, updatedProps, oldDbItem, newDbItem);
            }

            if (updatedProps.Count == 0)
            {
                return;
            }

            var keyPropDefs = allProps.Where(z => z.IsKey).ToList();
            var allInvolvedCols = new List<EntityPropDef>(updatedProps);
            allInvolvedCols.AddRange(keyPropDefs);

            var updateSql = GenSqlScriptHelper.GenUpdateSqlWithArrayBinding(GetTableName(), updatedProps, keyPropDefs);

            ExecuteCustomSqlWithArrayBinding
                (
                    updateSql,
                    newDbObjects,
                    i => GenSqlScriptHelper.GenInsertParams(allInvolvedCols, i)
                );
        }

        public virtual void Delete(T existingItem)
        {
            IBaseModel existingDbItem = ToDbModel(existingItem);
            var keyCols = GetTableFieldsDefs().Where(z => z.IsKey).ToList();
            var deleteSql = GenSqlScriptHelper.GenDeleteSql(GetTableName(), keyCols, existingDbItem);
            UnitOfWorkCurrent.Execute(deleteSql);
        }

        public virtual void Delete(ICollection<T> items)
        {
            if (items.Count == 0)
            {
                return;
            }
            var keyCols = GetTableFieldsDefs().Where(z => z.IsKey).ToList();
            var dbObjects = items.Select(ToDbModel).ToList();
            var deleteSql = GenSqlScriptHelper.GenDeleteSqlWithArrayBinding(GetTableName(), keyCols);

            ExecuteCustomSqlWithArrayBinding
                (
                    deleteSql,
                    dbObjects,
                    i => GenSqlScriptHelper.GenInsertParams(keyCols, i)
                );
        }

        public void Debug(string hint)
        {

            #if ALLOW_DEBUG_DUMP

            var p = new DynamicParameters();
            p.Add("p_tname", value: GetTableName(), dbType: DbType.String, direction: ParameterDirection.Input);
            if (hint.Equals("pre"))
            {
                UnitOfWorkCurrent.Execute("dump_table_to_csv",p, null, CommandType.StoredProcedure, null);
            }

            if (hint.Equals("post"))
            {
                UnitOfWorkCurrent.Execute("dump_table_to_csv2", p, null, CommandType.StoredProcedure, null);
            }

           #endif  

        }
    }

    public class ValidSearchFieldRecord
    {
        public string DbModelFieldName { get; private set; }
        public FieldType Type { get; private set; }

        public ValidSearchFieldRecord(string dbModelFieldName, FieldType type)
        {
            DbModelFieldName = dbModelFieldName;
            Type = type;
        }
    }

    public interface ISearchFieldDef
    {
        string FieldName { get; }
        ValidSearchFieldRecord SearchFieldRecord { get; }
    }

    public class SearchFieldDef<T, R> : ISearchFieldDef
    {
        public string FieldName { get; private set; }
        public ValidSearchFieldRecord SearchFieldRecord  { get; private set; }

        public SearchFieldDef(Expression<Func<T, R>> propRef, string dbModelFieldName, FieldType type)
            : this(DelegateHelpers.GetPropertyNameFromExpression(propRef), dbModelFieldName, type)
        {
        }

        public SearchFieldDef(string fieldName, string dbModelFieldName, FieldType type)
        {
            FieldName = fieldName;
            SearchFieldRecord = new ValidSearchFieldRecord(dbModelFieldName, type);
        }

    }

    public class FieldNameRef<T, R>: IFieldNameRef
    {
        public string FieldName { get; private set; }

        public FieldNameRef(Expression<Func<T, R>> fieldRef)
        {
            FieldName = DelegateHelpers.GetPropertyNameFromExpression(fieldRef);
        }
    }

    public class RowUpdateInfo: IRowUpdateInfo
    {
        public object KeyValue { get; private set; }
        public ICollection<object> FieldValues { get; private set; }

        public RowUpdateInfo(object keyValue, ICollection<object> fieldValues)
        {
            KeyValue = keyValue;
            FieldValues = fieldValues;
        }
    }

}
