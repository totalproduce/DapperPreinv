using Bsdl.FreshTrade.Domain.Basic.Entities;
using Bsdl.FreshTrade.Domain.Basic.Interfaces;
using Bsdl.FreshTrade.Repositories.Basic.DBModel;
using Bsdl.FreshTrade.Repositories.Basic.Interfaces;
using Bsdl.FreshTrade.Repositories.Basic.Utilities.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace Bsdl.FreshTrade.Repositories.Basic.Dictionaries
{
    public class DapperCurrencyDicitonaryRepository : DapperRepositoryBase<DTOCurrency>, ICurrencyDictionaryRepository
    {

        public DapperCurrencyDicitonaryRepository(IUnitOfWork unitOfWorkCurrent, ICacheManagerFactory cacheManagerFactory)
            : base(unitOfWorkCurrent, cacheManagerFactory, new List<ISearchFieldDef>())
        {
        }

        protected override List<DTOCurrency> GetDataInternal(List<ISearchField> searchFields, CachingStrategy allowFromCache, uint? topRows)
        {
            const string currencyQuery = "SELECT * FROM ACCCURRDESC WHERE (CURNO > 0)";

            string query = ConstructSimpleQuery(currencyQuery, searchFields, false, topRows);
            var results = UnitOfWorkCurrent.Query<AccCurrDesc>(query);

            return 
                results.Select
                (
                    item => 
                    new DTOCurrency
                    {
                        No = item.Curno,
                        Description = item.Curdesc,
                        IsTriangulate = item.Curtriangreq >= 1,
                        DecimalPlaces = item.Curdecimalplaces,
                        CurCode = item.Curcode,
                        CurDecimalPoint = item.Curdecimalpoint,
                        CurDefBanRecNo = item.Curdefbanrecno,
                        CurExtnNumPicture = item.Curextnnumpicture,
                        CurSymbol = item.Cursymbol,
                        CurSymbolAtFront = item.Cursymbolatfront >= 1,
                        CurThousandSeparator = item.Curthousandseparator
                    }
                ).ToList();
        }

    }

}
