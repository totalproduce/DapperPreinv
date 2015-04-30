using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Bsdl.FreshTrade.Domain.Account.Entities;
using Bsdl.FreshTrade.Domain.Basic.Entities;
using Bsdl.FreshTrade.Domain.Basic.Enums;
using Bsdl.FreshTrade.Domain.Basic.Exceptions.DataAccess;
using Bsdl.FreshTrade.Repositories.Account.DBModel;
using Bsdl.FreshTrade.Repositories.Account.Interfaces;
using Bsdl.FreshTrade.Repositories.Basic;
using Bsdl.FreshTrade.Repositories.Basic.Interfaces;
using Bsdl.FreshTrade.Repositories.Basic.Utilities.Interfaces;
using Bsdl.FreshTrade.Domain.Basic.Interfaces;

namespace Bsdl.FreshTrade.Repositories.Account.Accounts
{
    public class CustomerCategoryDepencencyRepository : DapperRepositoryBase<DTOCustomerCategoryDependency>, ICustomerCategoryDepencencyRepository
    {
        private const string _sqlQuery = @"SELECT * FROM CSTANREC";

        public CustomerCategoryDepencencyRepository(IUnitOfWork unitOfWorkCurrent, ICacheManagerFactory cacheManagerFactory)
            : base
            (
                unitOfWorkCurrent,
                cacheManagerFactory,
                new List<ISearchFieldDef>
                {
                    new SearchFieldDef<DTOCustomerCategoryDependency, int>(i => i.CategoryNo, CstAnRec.FieldNames.CSDCSARECNO, FieldType.Integer),
                }
            )
        {
        }

        protected override List<DTOCustomerCategoryDependency> GetDataInternal(List<ISearchField> searchFields, CachingStrategy allowFromCache, uint? topRows)
        {
            string query = ConstructSimpleQuery(_sqlQuery, searchFields, true, topRows);

            IEnumerable<CstAnRec> results = null;

            try
            {
                results = UnitOfWorkCurrent.Query<CstAnRec>(query);
            }
            catch (Exception ex)
            {
                throw new DatabaseQueryException("Could not load CstAnRec" + Environment.NewLine + ex.Message, ex);
            }

            return 
                results.Select
                    (
                        i => new DTOCustomerCategoryDependency
                                 {
                                     CustomerId = i.Csdcstcode,
                                     CategoryNo = i.Csdcsarecno
                                 }
                    ).ToList();
        }

        public List<int> GetCustomersByCategories(List<int> ids)
        {
            var result = GetDataInChunks(i => i.CategoryNo, ids);
            return result.Select(i => i.CustomerId).ToList();
        }
    }
}
