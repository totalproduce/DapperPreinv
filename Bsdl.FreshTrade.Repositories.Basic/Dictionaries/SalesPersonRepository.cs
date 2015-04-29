using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Bsdl.FreshTrade.Domain.Basic.Entities;
using Bsdl.FreshTrade.Domain.Basic.Interfaces;
using Bsdl.FreshTrade.Repositories.Basic.DBModel;
using Bsdl.FreshTrade.Repositories.Basic.Interfaces;
using Bsdl.FreshTrade.Repositories.Basic.Utilities.Interfaces;

namespace Bsdl.FreshTrade.Repositories.Basic.Dictionaries
{
    public class SalesPersonRepository : DapperRepositoryBase<DTOSalesPerson>, ISalesPersonRepository
    {
        public SalesPersonRepository(IUnitOfWork unitOfWorkCurrent, ICacheManagerFactory cacheManagerFactory)
            : base(unitOfWorkCurrent, cacheManagerFactory, new List<ISearchFieldDef>())
        {
        }

        protected override List<DTOSalesPerson> GetDataInternal(List<ISearchField> searchFields, CachingStrategy allowFromCache, uint? topRows)
        {
            const string currencyQuery = "SELECT * FROM SMN";

            string query = ConstructSimpleQuery(currencyQuery, searchFields, true, topRows);
            var results = UnitOfWorkCurrent.Query<SalesPerson>(query);

            return 
                results.Select
                (
                    item =>
                    new DTOSalesPerson
                    {
                        No = item.Smnno,
                        Name = item.Smnname
                    }
                ).ToList();
        }
    }
}
