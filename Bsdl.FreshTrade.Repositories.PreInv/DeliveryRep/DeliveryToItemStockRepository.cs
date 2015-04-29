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

namespace Bsdl.FreshTrade.Repositories.PreInv.DeliveryRep
{
    public class DeliveryToItemStockRepository : DapperRepositoryBase<DTODeliveryToItemStock>, IDeliveryToItemStockRepository
    {
        private const string _sqlQuery = @"SELECT * FROM DELTOIST";


        public DeliveryToItemStockRepository(IUnitOfWork unitOfWorkCurrent, ICacheManagerFactory cacheManagerFactory)
            : base
                (
                unitOfWorkCurrent,
                cacheManagerFactory,
                new List<ISearchFieldDef>
                    {
                        new SearchFieldDef<DTODeliveryToItemStock, int>(i => i.DeliveryPriceId,
                                                                        DELTOIST.FieldNames.DISDPRRECNO,
                                                                        FieldType.Integer),
                        new SearchFieldDef<DTODeliveryToItemStock, int>(i => i.ItemStockId,
                                                                        DELTOIST.FieldNames.DISISTRECNO,
                                                                        FieldType.Integer)
                    }
                )
        {
        }

        protected override List<DTODeliveryToItemStock> GetDataInternal(List<ISearchField> searchFields,
                                                                        CachingStrategy allowFromCache, uint? topRows)
        {
            string query = ConstructSimpleQuery(_sqlQuery, searchFields, true, topRows);
            var results = UnitOfWorkCurrent.Query<DELTOIST>(query);

            return results
                .Select(item =>
                        new DTODeliveryToItemStock
                            {
                                DeliveryPriceId = item.Disdprrecno,
                                ItemStockId = item.Disistrecno,

                                StockQuantity = item.Disstkqty,
                                CdsRefNo = item.Discdsrefno,
                                Quantity = item.Disqty.HasValue ? item.Disqty.Value : 0
                            })
                .ToList();
        }

        public List<DTODeliveryToItemStock> GetDeliveryToItemStockByDeliveryPriceIDs(List<int> deliveryPriceIds)
        {
            return GetDataInChunks(i => i.DeliveryPriceId, deliveryPriceIds);
        }

    }
}
