using Bsdl.FreshTrade.Domain.Basic.Entities;
using Bsdl.FreshTrade.Domain.Basic.Interfaces;
using Bsdl.FreshTrade.Repositories.Basic.DBModel;
using Bsdl.FreshTrade.Repositories.Basic.Interfaces;
using Bsdl.FreshTrade.Repositories.Basic.Utilities.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace Bsdl.FreshTrade.Repositories.Basic.Dictionaries
{
    public class DapperCompanyDicitonaryRepository : DapperRepositoryBase<DTOCompany>, ICompanyDictionaryRepository
    {

        public DapperCompanyDicitonaryRepository(IUnitOfWork unitOfWorkCurrent, ICacheManagerFactory cacheManagerFactory)
            : base(unitOfWorkCurrent, cacheManagerFactory, new List<ISearchFieldDef>())
        {
        }

        protected override List<DTOCompany> GetDataInternal(List<ISearchField> searchFields, CachingStrategy allowFromCache, uint? topRows)
        {
            const string currencyQuery = "SELECT COMPGLBRECNO, COMPANYNAME FROM COMPANY";

            string query = ConstructSimpleQuery(currencyQuery, searchFields, true, topRows);
            var results = UnitOfWorkCurrent.Query<Company>(query);

            return
                results.Select
                (
                    freshTradeCompanyResultLine =>
                    new DTOCompany(freshTradeCompanyResultLine.Compglbrecno, freshTradeCompanyResultLine.Companyname)
                ).ToList();
        }
    }
}
