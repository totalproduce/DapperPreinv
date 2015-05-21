using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Bsdl.FreshTrade.Domain.Basic.Enums;
using Bsdl.FreshTrade.Domain.Basic.Interfaces;
using Bsdl.FreshTrade.Domain.PreInv.Entities;
using Bsdl.FreshTrade.Repositories.Basic;
using Bsdl.FreshTrade.Repositories.Basic.Interfaces;
using Bsdl.FreshTrade.Repositories.Basic.Utilities.Interfaces;
using Bsdl.FreshTrade.Repositories.PreInv.DBModel;
using Bsdl.FreshTrade.Repositories.PreInv.Interfaces;

namespace Bsdl.FreshTrade.Repositories.PreInv.StockRep
{
    public class StockLocationRepository : DapperRepositoryBase<DTOStockLocation>, IStockLocationRepository
    {
        private const string _sqlQuery = @"SELECT * FROM STOCLOC";

        public StockLocationRepository(IUnitOfWork unitOfWorkCurrent, ICacheManagerFactory cacheManagerFactory)
            : base
            (
                unitOfWorkCurrent,
                cacheManagerFactory,
                new List<ISearchFieldDef>
                {
                    new SearchFieldDef<DTOStockLocation, int>(i => i.Id, StocLoc.FieldNames.STCRECNO, FieldType.Integer)
                }
            )
        {
        }

        protected override List<DTOStockLocation> GetDataInternal(List<ISearchField> searchFields, CachingStrategy allowFromCache, uint? topRows)
        {
            string query = ConstructSimpleQuery(_sqlQuery, searchFields, true, topRows);
            var results = UnitOfWorkCurrent.Query<StocLoc>(query);

            return results
                    .Select(item =>
                        new DTOStockLocation
                        {
                            Id = item.Stcrecno,
                            InCountry = item.Incountry
                        })
                    .ToList();
        }
    }
}
