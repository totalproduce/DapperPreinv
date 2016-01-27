using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Reflection;
using System.Text;
using System.Linq;
using Bsdl.FreshTrade.Domain.Basic.Exceptions;
using Bsdl.FreshTrade.Domain.Basic.Utilities.DataTypeHandling;
using Bsdl.FreshTrade.Repositories.Basic.DBModel;
using Bsdl.FreshTrade.Repositories.Basic.persistance;
using Dapper;
using Oracle.ManagedDataAccess.Client;

namespace Bsdl.FreshTrade.Repositories.Basic.Persistance
{
    /// <summary>
    /// Simple property definition.
    /// </summary>
    public class DataRowPropDef
    {
        public DataRowPropDef(PropertyInfo propInfo, string columnName)
        {
            PropInfo = propInfo;
            ColumnName = columnName;
        }

        public PropertyInfo PropInfo { get; private set; }
        public string ColumnName { get; private set; }
        public string ColumnQuoted { get { return "\"" + ColumnName + "\""; } }

        public string PropName
        {
            get { return PropInfo.Name; }
        }

        public object GetValue(object entity)
        {
            return PropInfo.GetValue(entity, null);
        }
    }

    /// <summary>
    /// Helper calss for generating SQL scripts, such as insert/update/delete.
    /// </summary>
    public static class GenSqlScriptHelper
    {
        private static Dictionary<Type, DbType> _typeToDbTypeMap;

        static GenSqlScriptHelper()
        {
            InitializeDbTypeMapTable();
        }

        public static string GenInsertSql<TBaseEntity>(string tableName, IList<EntityPropDef> propDefs, TBaseEntity entity)
            where TBaseEntity : IBaseModel
        {
            var insertFields = new StringBuilder();
            var insertValues = new StringBuilder();
            foreach (var propDef in propDefs)
            {
                insertFields.Append(", ").Append(propDef.ColumnQuoted);
                object propVal = propDef.GetValue(entity);
                insertValues.Append(", ").Append(propVal.ObjToSqlConst());
            }
            string sql = string.Format(
                "INSERT INTO {0}({1})" + "\r\n" +
                "  VALUES ({2})",
                tableName,
                insertFields.ToString(2, insertFields.Length - 2),
                insertValues.ToString(2, insertValues.Length - 2));
            return sql;
        }

        /*public static string GenInsertSqlWithParams<TBaseEntity>(string tableName, IList<EntityPropDef> propDefs, TBaseEntity entity, out List<DbParameter> parameters)
            where TBaseEntity : IBaseModel
        {
            parameters = new List<DbParameter>();

            var insertFields = new StringBuilder();
            var insertValues = new StringBuilder();
            foreach (var propDef in propDefs)
            {
                insertFields.Append(", ").Append(propDef.ColumnQuoted);
                object propVal = propDef.GetValue(entity);
                string pName = "n_" + propDef.PropInfo.Name;
                insertValues.Append(", :").Append(pName);
                parameters.Add(SqlParam.New(pName, propVal));
            }
            string sql = string.Format(
                "INSERT INTO {0}({1})" + "\r\n" +
                "  VALUES ({2})",
                tableName,
                insertFields.ToString(2, insertFields.Length - 2),
                insertValues.ToString(2, insertValues.Length - 2));

            return sql;
        }*/

        public static string GenInsertSql(string tableName, IList<EntityPropDef> propDefs)
        {

            var insertFields = new StringBuilder();
            var insertValues = new StringBuilder();
            foreach (var propDef in propDefs)
            {
                insertFields.Append(", ").Append(propDef.ColumnQuoted);
                string pName = "n_" + propDef.PropInfo.Name;
                insertValues.Append(", :").Append(pName);
            }
            string sql = string.Format(
                "INSERT INTO {0}({1})" + "\r\n" +
                "  VALUES ({2})",
                tableName,
                insertFields.ToString(2, insertFields.Length - 2),
                insertValues.ToString(2, insertValues.Length - 2));

            return sql;
        }

        public static void GenInsertParam(DynamicParameters parameters, string propName, Type propType, object propValues)
        {
            string pName = "n_" + propName;
            var propVals = propValues;
            var dbType = GetDbType(propType);
            parameters.Add(pName, propVals, DynamicParameters.EnumerableMultiParameter, ParameterDirection.Input, null,
                i =>
                {
                    var param = (OracleParameter)i;
                    param.DbType = dbType;
                }
            );
        }

        public static void GenInsertParam(DynamicParameters parameters, EntityPropDef propDef, IList<IBaseModel> entities)
        {
            GenInsertParam(parameters, propDef.PropInfo.Name, propDef.PropInfo.PropertyType, propDef.GetValues(entities));
        }

        public static DynamicParameters GenInsertParams<TBaseEntity>(IList<EntityPropDef> propDefs, ICollection<TBaseEntity> entities)
        {
            var parameters = new DynamicParameters();
            var baseEntities = entities.Cast<IBaseModel>().ToList();
            foreach (var propDef in propDefs)
            {
                GenInsertParam(parameters, propDef, baseEntities);
            }
            return parameters;
        }

        public static DynamicParameters GenInsertParamsByValuesList(IList<EntityPropDef> propDefs, IList<object> propValues)
        {
            var parameters = new DynamicParameters();
            if (propDefs.Count != propValues.Count)
            {
                throw new FreshTradeException("Property definition count mismatches values count");
            }
            for (int i = 0; i < propDefs.Count; i++)
            {
                GenInsertParam(parameters, propDefs[i].PropInfo.Name, propDefs[i].PropInfo.PropertyType, propValues[i]);
            }
            return parameters;
        }

        private static bool IsValuesList(object data)
        {
            return !(data is string) && ((data as IEnumerable) != null);
        }

        public static void GenStoredProcedureParam(DynamicParameters parameters, string paramName, Type paramType, object paramValues)
        {
            var dbType = GetDbType(paramType);
            bool isArray = IsValuesList(paramValues);
            parameters.Add(paramName, paramValues, isArray ? DynamicParameters.EnumerableMultiParameter : dbType, ParameterDirection.Input, null,
                i =>
                {
                    var param = (OracleParameter) i;
                    if (isArray)
                    {
                        param.CollectionType = OracleCollectionType.PLSQLAssociativeArray;
                        param.Size = i.Size;
                    }
                    param.DbType = dbType;
                }
            );
        }
        /*
        public static string GenInsertSqlWithParams<TBaseEntity>(string tableName, IList<EntityPropDef> propDefs, IList<TBaseEntity> entities)
            where TBaseEntity : IBaseModel
        {
            //parameters = new List<DbParameter>();

            var insertFields = new StringBuilder();
            var sqlText = new StringBuilder();
            //var baseEntities = entities.Cast<IBaseModel>().ToList();
            bool firstValue = true;
            foreach (var propDef in propDefs)
            {
                if (!firstValue)
                {
                    insertFields.Append(", ");
                }
                insertFields.Append(propDef.ColumnQuoted);
                firstValue = false;
            }

            var fieldDefAsStr = insertFields.ToString();
            sqlText.AppendLine("INSERT ALL");

            foreach (var entity in entities)
            {
                sqlText.Append(string.Format("INTO {0} ({1}) VALUES (", tableName, fieldDefAsStr));
                firstValue = true;
                foreach (var propDef in propDefs)
                {
                    object propVal = propDef.GetValue(entity);
                    if (!firstValue)
                    {
                        sqlText.Append(", ");
                    }
                    sqlText.Append(propVal.ObjToSqlConst());
                    firstValue = false;
                }
                sqlText.Append(")\r\n");
            }
            sqlText.Append("SELECT * FROM DUAL");
            return sqlText.ToString();
        }*/

        public static string GenUpdateSql<TBaseEntity>(string tableName, IList<EntityPropDef> propDefs, IList<EntityPropDef> keyPropDefs,
            TBaseEntity entityOld, TBaseEntity entityNew, bool incrementalMode = false)
            where TBaseEntity : IBaseModel
        {
            string sql;
            if (propDefs == null || propDefs.Count == 0)
                throw new Exception("GenUpdateSql: no update fields were specified");
            if (keyPropDefs == null || keyPropDefs.Count == 0)
                throw new Exception("GenUpdateSql: no key fields were specified");

            var assignFields = new StringBuilder();
            foreach (var propDef in propDefs)
            {
                object propValNew = propDef.GetValue(entityNew);
                if (!incrementalMode || !ObjectHandling.ValueEquality(propDef.GetValue(entityOld), propValNew))
                {
                    assignFields.AppendFormat(", {0}={1}", propDef.ColumnQuoted, propValNew.ObjToSqlConst());
                }
            }

            var whereFields = new StringBuilder();
            foreach (var keyPropDef in keyPropDefs)
            {
                object propVal = keyPropDef.GetValue(entityOld);
                whereFields.AppendFormat(" AND {0}={1}", keyPropDef.ColumnQuoted, propVal.ObjToSqlConst());
            }

            if (assignFields.Length > 3) // objects differ
            {

                 sql = string.Format(
                    "UPDATE {0} SET" + "\r\n" +
                    "  {1}" + "\r\n" +
                    "WHERE {2}",
                    tableName,
                    assignFields.ToString(2, assignFields.Length - 2),
                    whereFields.ToString(5, whereFields.Length - 5));

            }
            else
            {
                sql = "";
            }
            return sql;
        }

        public static string GenUpdateSqlWithArrayBinding(string tableName, IList<EntityPropDef> updatedPropDefs, IList<EntityPropDef> keyPropDefs)
        {
            if (keyPropDefs.Count != 1)
            {
                throw new FreshTradeException("Entities with composite keys is not supported for now");
            }
            EntityPropDef keyPropDef = keyPropDefs.First();

            var updateFields = new StringBuilder();
            foreach (var propDef in updatedPropDefs)
            {
                string pName = "n_" + propDef.PropInfo.Name;
                updateFields.Append(string.Format(", {0}=:{1}", propDef.ColumnQuoted, pName));
            }
            string pKeyName = "n_" + keyPropDef.PropInfo.Name;
            var keyFields = string.Format(string.Format("{0}=:{1}", keyPropDef.ColumnQuoted, pKeyName));

            string sql = 
                string.Format
                (
                    "UPDATE {0} SET\r\n" +
                    "{1}\r\n"+
                    "WHERE {2}",
                    tableName,
                    updateFields.ToString(2, updateFields.Length - 2),
                    keyFields
                );

            return sql;
        }

        public static string GenDeleteSqlWithArrayBinding(string tableName, IList<EntityPropDef> keyPropDefs)
        {
            if (keyPropDefs.Count != 1)
            {
                throw new FreshTradeException("Entities with composite keys is not supported for now");
            }

            EntityPropDef keyPropDef = keyPropDefs.First();

            string pKeyName = "n_" + keyPropDef.PropInfo.Name;
            var keyFields = string.Format(string.Format("{0}=:{1}", keyPropDef.ColumnQuoted, pKeyName));

            string sql = string.Format("DELETE FROM {0} WHERE {1}", tableName, keyFields);
            return sql;
        }

        public static string GenUpdateSqlWithParams<TBaseEntity>(string tableName, IList<EntityPropDef> propDefs, IList<EntityPropDef> keyPropDefs,
            TBaseEntity entityOld, TBaseEntity entityNew, out List<DbParameter> parameters)
            where TBaseEntity : IBaseModel
        {
            if (propDefs == null || propDefs.Count == 0)
                throw new Exception("GenUpdateSql: no update fields were specified");
            if (keyPropDefs == null || keyPropDefs.Count == 0)
                throw new Exception("GenUpdateSql: no key fields were specified");

            parameters = new List<DbParameter>(propDefs.Count + keyPropDefs.Count);
            var assignFields = new StringBuilder();
            foreach (var propDef in propDefs)
            {
                object propValNew = propDef.GetValue(entityNew);
                string pName = "n_" + propDef.PropName;
                assignFields.AppendFormat(", {0}=:{1}", propDef.ColumnQuoted, pName);
                parameters.Add(SqlParam.New(pName, propValNew));
            }

            var whereFields = new StringBuilder();
            foreach (var keyPropDef in keyPropDefs)
            {
                object propVal = keyPropDef.GetValue(entityOld);
                string pName = "o_" + keyPropDef.PropName;
                whereFields.AppendFormat(" AND {0}=:{1}", keyPropDef.ColumnQuoted, pName);
                parameters.Add(SqlParam.New(pName, propVal));
            }

            string sql = string.Format(
                "UPDATE {0} SET" + "\r\n" +
                "  {1}" + "\r\n" +
                "WHERE {2}",
                tableName,
                assignFields.ToString(2, assignFields.Length - 2),
                whereFields.ToString(5, whereFields.Length - 5));

            return sql;
        }

        public static string GenInsertOrUpdateSql<TBaseEntity>(string tableName, IList<EntityPropDef> propDefs, IList<EntityPropDef> keyPropDefs,
            IList<EntityPropDef> skipWherePropDefs, TBaseEntity entity)
            where TBaseEntity : IBaseModel
        {
            if (propDefs == null || propDefs.Count == 0)
                throw new Exception("GenUpdateSql: no update fields were specified");
            if (keyPropDefs == null || keyPropDefs.Count == 0)
                throw new Exception("GenUpdateSql: no key fields were specified");
            var keyProps = new HashSet<string>(keyPropDefs.Select(t => t.PropName));
            var skipWhereProps = new HashSet<string>(skipWherePropDefs.Select(t => t.PropName));

            var selectFields = new StringBuilder();
            var insertFields = new StringBuilder();
            var insertValues = new StringBuilder();
            var assignFields = new StringBuilder();
            var whereFields = new StringBuilder();

            foreach (var propDef in propDefs)
            {
                if (propDef.IsDbCalc)
                    continue;
                object propValNew = propDef.GetValue(entity);
                var propSqlValue = propValNew.ObjToSqlConst();

                selectFields.AppendFormat(", {1} as {0}", propDef.ColumnQuoted, propSqlValue);
                insertFields.Append(", ").Append(propDef.ColumnQuoted);
                insertValues.Append(", S.").Append(propDef.ColumnQuoted);
                if (propDef.IsKey || keyProps.Contains(propDef.PropName))
                    continue;
                assignFields.AppendFormat(", {0}=S.{0}", propDef.ColumnQuoted);
                if (skipWhereProps.Contains(propDef.PropName))
                    continue;
                whereFields.AppendFormat(" AND (T.{0}=S.{0}", propDef.ColumnQuoted);
                if (propDef.IsNullable)
                {
                    whereFields.AppendFormat(" OR T.{0} IS NULL AND S.{0} IS NULL", propDef.ColumnQuoted);
                }
                whereFields.Append(")");
            }

            var onFields = new StringBuilder();
            foreach (var keyPropDef in keyPropDefs)
            {
                onFields.AppendFormat(" AND (T.{0}=S.{0}", keyPropDef.ColumnQuoted);
                if (keyPropDef.IsNullable)
                {
                    onFields.AppendFormat(" OR T.{0} IS NULL AND S.{0} IS NULL", keyPropDef.ColumnQuoted);
                }
                onFields.Append(")");
            }

            string sql = string.Format(
                "MERGE INTO {0} T" + "\r\n" +
                "USING (SELECT {1} FROM DUAL) S" + "\r\n" +
                "  ON ({2})" + "\r\n" +
                "WHEN MATCHED THEN" + "\r\n" +
                "  UPDATE SET" + "\r\n" +
                "    {3}" + "\r\n" +
                "  WHERE NOT({4})" + "\r\n" +
                "WHEN NOT MATCHED THEN" + "\r\n" +
                "  INSERT ({5})" + "\r\n" +
                "  VALUES ({6})",
                tableName,
                selectFields.ToString(2, selectFields.Length - 2),
                onFields.ToString(5, onFields.Length - 5),
                assignFields.ToString(2, assignFields.Length - 2),
                whereFields.ToString(5, whereFields.Length - 5),
                insertFields.ToString(2, insertFields.Length - 2),
                insertValues.ToString(2, insertValues.Length - 2)
                );

            return sql;
        }

        public static string GenInsertOrUpdateSqlWithParams<TBaseEntity>(string tableName, IList<EntityPropDef> propDefs, IList<EntityPropDef> keyPropDefs,
            IList<EntityPropDef> skipWherePropDefs, TBaseEntity entity, out List<DbParameter> parameters, string additionalWhereSql)
            where TBaseEntity : IBaseModel
        {
            if (propDefs == null || propDefs.Count == 0)
                throw new Exception("GenUpdateSql: no update fields were specified");
            if (keyPropDefs == null || keyPropDefs.Count == 0)
                throw new Exception("GenUpdateSql: no key fields were specified");
            var keyProps = new HashSet<string>(keyPropDefs.Select(t => t.PropName));
            var skipWhereProps = new HashSet<string>(skipWherePropDefs.Select(t => t.PropName));

            parameters = new List<DbParameter>(propDefs.Count + keyPropDefs.Count);

            var selectFields = new StringBuilder();
            var insertFields = new StringBuilder();
            var insertValues = new StringBuilder();
            var assignFields = new StringBuilder();
            var whereFields = new StringBuilder();

            foreach (var propDef in propDefs)
            {
                if (propDef.IsDbCalc)
                    continue;

                object propValNew = propDef.GetValue(entity);
                string pName = "n_" + propDef.PropName;
                parameters.Add(SqlParam.New(pName, propValNew));

                selectFields.AppendFormat(", :{1} as {0}", propDef.ColumnQuoted, pName);
                insertFields.Append(", ").Append(propDef.ColumnQuoted);
                insertValues.Append(", S.").Append(propDef.ColumnQuoted);
                if (propDef.IsKey || keyProps.Contains(propDef.PropName))
                    continue;
                assignFields.AppendFormat(", {0}=S.{0}", propDef.ColumnQuoted);
                if (skipWhereProps.Contains(propDef.PropName))
                    continue;
                whereFields.AppendFormat(" AND (T.{0}=S.{0}", propDef.ColumnQuoted);
                if (propDef.IsNullable)
                {
                    whereFields.AppendFormat(" OR T.{0} IS NULL AND S.{0} IS NULL", propDef.ColumnQuoted);
                }
                whereFields.Append(")");
            }

            var onFields = new StringBuilder();
            foreach (var keyPropDef in keyPropDefs)
            {
                onFields.AppendFormat(" AND (T.{0}=S.{0}", keyPropDef.ColumnQuoted);
                if (keyPropDef.IsNullable)
                {
                    onFields.AppendFormat(" OR T.{0} IS NULL AND S.{0} IS NULL", keyPropDef.ColumnQuoted);
                }
                onFields.Append(")");
            }

            string sql = string.Format(
                "MERGE INTO {0} T" + "\r\n" +
                "USING (SELECT {1} FROM DUAL) S" + "\r\n" +
                "  ON ({2})" + "\r\n" +
                "WHEN MATCHED THEN" + "\r\n" +
                "  UPDATE SET" + "\r\n" +
                "    {3}" + "\r\n" +
                "  WHERE NOT({4}){7}" + "\r\n" +
                "WHEN NOT MATCHED THEN" + "\r\n" +
                "  INSERT ({5})" + "\r\n" +
                "  VALUES ({6})",
                tableName,
                selectFields.ToString(2, selectFields.Length - 2),
                onFields.ToString(5, onFields.Length - 5),
                assignFields.ToString(2, assignFields.Length - 2),
                whereFields.ToString(5, whereFields.Length - 5),
                insertFields.ToString(2, insertFields.Length - 2),
                insertValues.ToString(2, insertValues.Length - 2),
                additionalWhereSql
                );

            return sql;
        }

        public static string GenDeleteSql<TBaseEntity>(string tableName, IList<EntityPropDef> keyPropDefs, TBaseEntity entityOld)
            where TBaseEntity : IBaseModel
        {
            if (keyPropDefs.Count == 0)
                throw new Exception("GenDeleteSql: no key fields were specified");

            var whereFields = new StringBuilder();
            foreach (var keyPropDef in keyPropDefs)
            {
                object propVal = keyPropDef.GetValue(entityOld);
                whereFields.AppendFormat(" AND {0}={1}", keyPropDef.ColumnQuoted, propVal.ObjToSqlConst());
            }

            string sql = string.Format("DELETE FROM {0} WHERE {1}", tableName, whereFields.ToString(5, whereFields.Length - 5));
            return sql;
        }

        public static string GenDeleteSqlWithParams<TBaseEntity>(string tableName, IList<EntityPropDef> keyPropDefs, TBaseEntity entityOld,
            out List<DbParameter> parameters)
            where TBaseEntity : IBaseModel
        {
            if (keyPropDefs.Count == 0)
                throw new Exception("GenDeleteSql: no key fields were specified");

            parameters = new List<DbParameter>(keyPropDefs.Count);

            var whereFields = new StringBuilder();
            foreach (var keyPropDef in keyPropDefs)
            {
                object propVal = keyPropDef.GetValue(entityOld);
                string pName = "o_" + keyPropDef.PropName;
                whereFields.AppendFormat(" AND {0}=:{1}", keyPropDef.ColumnQuoted, pName);
                parameters.Add(SqlParam.New(pName, propVal));
            }

            string sql = string.Format("delete from {0} where {1}", tableName, whereFields.ToString(5, whereFields.Length - 5));
            return sql;
        }

        public static IList<EntityPropDef> GetChangedProps<TBaseEntity>(IList<EntityPropDef> propDefs, TBaseEntity entityOld, TBaseEntity entityNew)
            where TBaseEntity : IBaseModel
        {
            var changedProps = new List<EntityPropDef>();
            foreach (var propDef in propDefs)
            {
                if (!propDef.CompareValues(entityOld, entityNew))
                    changedProps.Add(propDef);
            }
            return changedProps;
        }

        public static string GenReturningSqlWithParams(IList<EntityPropDef> propDefs, bool addRecExistFlag, out List<DbParameter> parameters)
        {
            parameters = new List<DbParameter>(propDefs.Count);
            if (propDefs.Count == 0 && !addRecExistFlag)
                return null;

            var returnFields = new StringBuilder();
            var returnValues = new StringBuilder();
            foreach (var propDef in propDefs)
            {
                returnFields.Append(", ").Append(propDef.ColumnQuoted);
                string pName = "r_" + propDef.PropInfo.Name;
                returnValues.Append(", :").Append(pName);
                parameters.Add(SqlParam.New(pName, propDef.PropInfo.PropertyType, ParameterDirection.Output));
            }
            if (addRecExistFlag)
            {
                returnFields.Append(", ").Append("'Y'");
                returnValues.Append(", :recordExists");
                DbParameter dbParameter = SqlParam.New("recordExists", typeof(string), ParameterDirection.Output);
                dbParameter.Size = 32;
                parameters.Add(dbParameter);
            }
            string sql = string.Format("RETURNING {0} INTO {1}",
                returnFields.ToString(2, returnFields.Length - 2),
                returnValues.ToString(2, returnValues.Length - 2));

            return sql;
        }

        public static string GenInsertOrUpdateSql2(string tableName, IList<DataRowPropDef> propDefs, IList<DataRowPropDef> keyPropDefs, object entity,
            out List<DbParameter> parameters)
        {
            if (propDefs == null || propDefs.Count == 0)
                throw new Exception("GenUpdateSql: no update fields were specified");
            if (keyPropDefs == null || keyPropDefs.Count == 0)
                throw new Exception("GenUpdateSql: no key fields were specified");

            parameters = new List<DbParameter>(propDefs.Count);
            var keyProps = new HashSet<string>(keyPropDefs.Select(t => t.PropName));

            var selectFields = new StringBuilder();
            var insertFields = new StringBuilder();
            var insertValues = new StringBuilder();
            var assignFields = new StringBuilder();

            foreach (var propDef in propDefs)
            {
                object propValNew = propDef.GetValue(entity);
                DbParameter dbParameter = SqlParam.New(propDef.PropName, propValNew);
                parameters.Add(dbParameter);

                selectFields.AppendFormat(", :{1} as {0}", propDef.ColumnQuoted, propDef.PropName);
                insertFields.Append(", ").Append(propDef.ColumnQuoted);
                insertValues.Append(", S.").Append(propDef.ColumnQuoted);

                if (keyProps.Contains(propDef.PropName))
                    continue;

                assignFields.AppendFormat(", {0}=S.{0}", propDef.ColumnQuoted);
            }

            var onFields = new StringBuilder();
            foreach (var keyPropDef in keyPropDefs)
            {
                onFields.AppendFormat(" AND T.{0}=S.{0}", keyPropDef.ColumnQuoted);
            }

            string sql = string.Format(@"MERGE INTO {0} T 
                                         USING (SELECT {1} FROM DUAL) S
                                         ON ({2})
                                         WHEN MATCHED THEN
                                         UPDATE SET {3}
                                         WHEN NOT MATCHED THEN
                                         INSERT ({4})
                                         VALUES ({5})",
                tableName,
                selectFields.ToString(2, selectFields.Length - 2),
                onFields.ToString(5, onFields.Length - 5),
                assignFields.ToString(2, assignFields.Length - 2),
                insertFields.ToString(2, insertFields.Length - 2),
                insertValues.ToString(2, insertValues.Length - 2));

            return sql;
        }

        public static void InitializeDbTypeMapTable()
        {
            var typeMap = new Dictionary<Type, DbType>();
            typeMap[typeof(byte)] = DbType.Byte;
            typeMap[typeof(sbyte)] = DbType.SByte;
            typeMap[typeof(short)] = DbType.Int16;
            typeMap[typeof(ushort)] = DbType.UInt16;
            typeMap[typeof(int)] = DbType.Int32;
            typeMap[typeof(uint)] = DbType.UInt32;
            typeMap[typeof(long)] = DbType.Int64;
            typeMap[typeof(ulong)] = DbType.UInt64;
            typeMap[typeof(float)] = DbType.Single;
            typeMap[typeof(double)] = DbType.Double;
            typeMap[typeof(decimal)] = DbType.Decimal;
            typeMap[typeof(bool)] = DbType.Boolean;
            typeMap[typeof(string)] = DbType.String;
            typeMap[typeof(char)] = DbType.StringFixedLength;
            typeMap[typeof(Guid)] = DbType.Guid;
            typeMap[typeof(DateTime)] = DbType.DateTime;
            typeMap[typeof(DateTimeOffset)] = DbType.DateTimeOffset;
            typeMap[typeof(byte[])] = DbType.Binary;
            typeMap[typeof(byte?)] = DbType.Byte;
            typeMap[typeof(sbyte?)] = DbType.SByte;
            typeMap[typeof(short?)] = DbType.Int16;
            typeMap[typeof(ushort?)] = DbType.UInt16;
            typeMap[typeof(int?)] = DbType.Int32;
            typeMap[typeof(uint?)] = DbType.UInt32;
            typeMap[typeof(long?)] = DbType.Int64;
            typeMap[typeof(ulong?)] = DbType.UInt64;
            typeMap[typeof(float?)] = DbType.Single;
            typeMap[typeof(double?)] = DbType.Double;
            typeMap[typeof(decimal?)] = DbType.Decimal;
            typeMap[typeof(bool?)] = DbType.Boolean;
            typeMap[typeof(char?)] = DbType.StringFixedLength;
            typeMap[typeof(Guid?)] = DbType.Guid;
            typeMap[typeof(DateTime?)] = DbType.DateTime;
            typeMap[typeof(DateTimeOffset?)] = DbType.DateTimeOffset;

            _typeToDbTypeMap = typeMap;
        }

        public static DbType GetDbType(Type type)
        {
            return _typeToDbTypeMap[type];
        }

    }
}
