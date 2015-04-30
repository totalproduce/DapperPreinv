using Bsdl.FreshTrade.Domain.Basic.Entities;
using Bsdl.FreshTrade.Domain.Basic.Enums;
using Bsdl.FreshTrade.Domain.Basic.Exceptions.DataAccess;
using Bsdl.FreshTrade.Domain.Basic.Interfaces;
using Bsdl.FreshTrade.Repositories.Basic.DBModel;
using Bsdl.FreshTrade.Repositories.Basic.Interfaces;
using Bsdl.FreshTrade.Repositories.Basic.Utilities.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Bsdl.FreshTrade.Repositories.Basic.UserRepository
{
    public class UserRepository : DapperRepositoryBase<DTOUser>, IUserRepository
    {
        private const string FreshTradeuserQuerySql = @"   
        SELECT LOGONS.*,
               NVL((SELECT 1 FROM LogToSalOff WHERE LogToSalOff.LogOnNo = Logons.LogOnNo AND LogToSalOff.SalOffNo = -32000), 0) AllSalesOffices
        FROM LOGONS ";

        //private readonly IEventsLogger _eLogger;

        public UserRepository(/*IEventsLogger logger,*/ IUnitOfWork unitOfWorkCurrent,
            ICacheManagerFactory cacheManagerFactory)
            : base
                (
                unitOfWorkCurrent,
                cacheManagerFactory,
                new List<ISearchFieldDef>
                {
                    new SearchFieldDef<DTOUser, string>(u => u.UserName, Logons.FieldNames.LOGONNAME,
                        FieldType.AlphaNumeric),
                    new SearchFieldDef<DTOUser, int>(u => u.Id, Logons.FieldNames.LOGONNO, FieldType.Integer)
                }
                )
        {
            //_eLogger = logger;
        }

        public List<DTOUser> GetData(int dbID, List<ISearchField> searchFields, CachingStrategy allowFromCache)
        {
            return GetData(searchFields, allowFromCache);
        }

        public DTOUser GetUserByNo(int logonNo)
        {
            return GetData
                (
                    new List<ISearchField>
                    {
                        new SearchFieldGeneric<DTOUser, int>(u => u.Id)
                            .Apply(logonNo, FieldType.Integer)
                    },
                    CachingStrategy.PerRequest
                ).FirstOrDefault();
        }

        public DTOUser GetUserByLogonName(int dbID, string logonName)
        {
            ISearchField searchField =
                new SearchFieldGeneric<DTOUser, string>(u => u.UserName)
                    .Apply(logonName, FieldType.AlphaNumeric);

            return GetData
                (
                    dbID,
                    new List<ISearchField> {searchField},
                    CachingStrategy.PerRequest
                ).FirstOrDefault();
        }

        protected override List<DTOUser> GetDataInternal(List<ISearchField> searchFields, CachingStrategy allowFromCache,
            uint? topRows)
        {
            IEnumerable<FreshTradeUserResultLine> results;

            string query = ConstructSimpleQuery(FreshTradeuserQuerySql, searchFields, true, topRows);

            try
            {
                results = UnitOfWorkCurrent.Query<FreshTradeUserResultLine>(query);
            }
            catch (Exception exception)
            {
                var ex =
                    new DatabaseQueryException("Cannot load Fresh Trade users" + Environment.NewLine + exception.Message);
                //AppError.SetError(ex, ex.StackTrace, ErrorType.Sql, exception.Message, query);
                throw ex;
            }

            var data = new List<DTOUser>();
            foreach (FreshTradeUserResultLine freshTradeUserResultLine in results)
            {
                var freshTradeUser = new DTOUser(
                    freshTradeUserResultLine.Logonno.Value,
                    freshTradeUserResultLine.Logonname,
                    freshTradeUserResultLine.Username,
                    freshTradeUserResultLine.Langno.Value,
                    freshTradeUserResultLine.Active == 1,
                    freshTradeUserResultLine.AllSalesOffices);

                data.Add(freshTradeUser);
            }

            return data;
        }

        public class FreshTradeUserResultLine : Logons
        {
            public bool AllSalesOffices { get; set; }
        }
    }
}