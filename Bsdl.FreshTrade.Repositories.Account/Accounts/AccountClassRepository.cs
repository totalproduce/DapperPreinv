using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Bsdl.FreshTrade.Domain.Account.Enums;
using Bsdl.FreshTrade.Domain.Basic.Entities;
using Bsdl.FreshTrade.Domain.Basic.Enums;
using Bsdl.FreshTrade.Domain.Basic.Exceptions;
using Bsdl.FreshTrade.Domain.Basic.Exceptions.DataAccess;
using Bsdl.FreshTrade.Domain.Basic.Interfaces;
using Bsdl.FreshTrade.Domain.Basic.Utilities.DataTypeHandling;
using Bsdl.FreshTrade.Repositories.Account.DBModel;
using Bsdl.FreshTrade.Repositories.Account.Interfaces;
using Bsdl.FreshTrade.Repositories.Basic;
using Bsdl.FreshTrade.Domain.Account.Entities;
using Bsdl.FreshTrade.Repositories.Basic.Interfaces;
using Bsdl.FreshTrade.Repositories.Basic.Utilities.Interfaces;

namespace Bsdl.FreshTrade.Repositories.Account.Accounts
{
    public class AccountClassRepository : DapperRepositoryBase<DTOAccountClass>, IAccountClassRepository
    {
        private const string _sqlQuery = @"SELECT * FROM ACCCLASS";

        public AccountClassRepository(IUnitOfWork unitOfWorkCurrent, ICacheManagerFactory cacheManagerFactory)
            : base
            (
                unitOfWorkCurrent,
                cacheManagerFactory,
                new List<ISearchFieldDef>
                {
                    new SearchFieldDef<DTOAccountClass, int>(i => i.Id, AccClass.FieldNames.CLARECNO, FieldType.Integer)
                }
            )
        {
        }

        protected override List<DTOAccountClass> GetDataInternal(List<ISearchField> searchFields, CachingStrategy allowFromCache, uint? topRows)
        {
            string query = ConstructSimpleQuery(_sqlQuery, searchFields, true, topRows);

            var data = new List<DTOAccountClass>();

            IEnumerable<AccClass> results = null;

            try
            {
                results = UnitOfWorkCurrent.Query<AccClass>(query);
            }
            catch (Exception ex)
            {
                throw new DatabaseQueryException("Could not load AccClass" + Environment.NewLine + ex.Message, ex);
            }

            foreach (var item in results)
            {
                if (!item.Clarecno.HasValue)
                {
                    throw new FreshTradeException("CLARECNO cannot be null");
                }
                if (!item.Claaccno.HasValue)
                {
                    throw new FreshTradeException("CLAACCNO cannot be null");
                }

                data.Add
                    (
                        new DTOAccountClass
                            {
                                Id = item.Clarecno.Value,
                                AccountId = item.Claaccno.Value,
                                AccountCode = item.Claacccode,
                                CurrencyNo = item.Clacurrno,
                                AccountStatus =
                                    item.Claactive.HasValue ? Enums<DTOAccountStatusType>.GetValue(item.Claactive.Value) : DTOAccountStatusType.Inactive,
                                Type = Enums<DTOAccountType>.GetValue(item.Claacccstsup)

                            }
                    );
            }

            return data;
        }

        public List<DTOAccountClass> GetAccountClassByIDs(List<int> ids)
        {
            return GetDataInChunks(i => i.Id, ids);
        }

    }
}
