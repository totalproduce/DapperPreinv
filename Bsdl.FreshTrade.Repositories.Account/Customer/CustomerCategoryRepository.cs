using System;
using System.Collections.Generic;
using Bsdl.FreshTrade.Domain.Account.Entities;
using Bsdl.FreshTrade.Domain.Basic.Enums;
using Bsdl.FreshTrade.Domain.Basic.Exceptions.DataAccess;
using Bsdl.FreshTrade.Domain.Basic.Interfaces;
using Bsdl.FreshTrade.Repositories.Account.Interfaces;
using Bsdl.FreshTrade.Repositories.Basic;
using Bsdl.FreshTrade.Repositories.Basic.Interfaces;
using Bsdl.FreshTrade.Repositories.Basic.Utilities.Interfaces;

namespace Bsdl.FreshTrade.Repositories.Account.Customer
{
    public class CustomerCategoryRepository : DapperRepositoryBase<DTOCustomerCategory>, ICustomerCategoryRepository
    {
        private const string SqlQuery = @"SELECT * FROM CSTANDES";

        public CustomerCategoryRepository(IUnitOfWork unitOfWorkCurrent, ICacheManagerFactory cacheManagerFactory) 
            : base
            (
            unitOfWorkCurrent,
            cacheManagerFactory,
            new List<ISearchFieldDef>
                {
                    new SearchFieldDef<DTOCustomerCategory, int?>(i => i.GroupId, DBModel.CustomerCategory.FieldNames.CSACSGRECNO, FieldType.Integer)
                }
            )
        {
        }

        protected override List<DTOCustomerCategory> GetDataInternal(List<ISearchField> searchFields, CachingStrategy allowFromCache, uint? topRows)
        {
            string query = ConstructQuery(SqlQuery, searchFields, null, true, topRows);

            var data = new List<DTOCustomerCategory>();

            IEnumerable<DBModel.CustomerCategory> results = null;

            try
            {
                results = UnitOfWorkCurrent.Query<DBModel.CustomerCategory>(query);
            }
            catch (Exception ex)
            {
                throw new DatabaseQueryException("Could not load Customer Groups" + Environment.NewLine + ex.Message, ex);
            }

            foreach (var dbData in results)
            {
                data.Add
                    (
                        new DTOCustomerCategory
                        {
                            Id = dbData.Csarecno,
                            Description = dbData.Csadesc,
                            GroupId = dbData.Csacsgrecno
                        }

                    );
            }

            return data;
        }

    }
}
