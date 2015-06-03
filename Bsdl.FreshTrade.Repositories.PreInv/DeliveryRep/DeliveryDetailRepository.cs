using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Bsdl.FreshTrade.Domain.Basic.Entities;
using Bsdl.FreshTrade.Domain.Basic.Enums;
using Bsdl.FreshTrade.Domain.Basic.Interfaces;
using Bsdl.FreshTrade.Domain.Basic.Utilities.DataTypeHandling;
using Bsdl.FreshTrade.Domain.PreInv.Entities;
using Bsdl.FreshTrade.Domain.PreInv.Enums;
using Bsdl.FreshTrade.Repositories.Basic;
using Bsdl.FreshTrade.Repositories.Basic.Interfaces;
using Bsdl.FreshTrade.Repositories.Basic.Utilities.Interfaces;
using Bsdl.FreshTrade.Repositories.PreInv.DBModel;
using Bsdl.FreshTrade.Repositories.PreInv.Interfaces;
using Bsdl.FreshTrade.Repositories.Basic.Persistance;
using Bsdl.FreshTrade.Repositories.Basic.DBModel;

namespace Bsdl.FreshTrade.Repositories.PreInv.DeliveryRep
{
    public class DeliveryDetailRepository : DapperRepositoryBase<DTODeliveryDetail>, IDeliveryDetailRepository
    {
        private const string _sqlQuery = "SELECT D.Delrecno, D.Deldlvordno, D.Delqty, D.Delweight, D.Delprcbywgt, D.Delprcprdno, D.Delcltprdno,  D.Qtyper, D.Delpriceper, D.Delstatus, A.DetAllocNo, P.PrgRefNo  \r\n" +
                                        "FROM DELDET D  \r\n" +
                                        "  LEFT JOIN DELALLOC A ON A.DELRECNO = D.DELRECNO \r\n" +
                                        "  LEFT JOIN PRGDETTODDET P ON P.PDESDELRECNO = D.DELRECNO \r\n";

        public DeliveryDetailRepository(IUnitOfWork unitOfWorkCurrent, ICacheManagerFactory cacheManagerFactory)
            : base
            (
                unitOfWorkCurrent, 
                cacheManagerFactory,
                new List<ISearchFieldDef>
                {
                    //new SearchFieldDef<DTODeliveryDetail, int>(i => i.Id, DELDET.FieldNames.DELRECNO, FieldType.Integer),
                    new SearchFieldDef<DTODeliveryDetail, int?>(i => i.DeliveryHeadId, DELDET.FieldNames.DELDLVORDNO, FieldType.Integer)
                }
            )
        {
        }

        public override IList<EntityPropDef> GetTableFieldsDefs()
        {
            return DELDET.GetPropDefs();
        }

        public override string GetTableName()
        {
            return "DELDET";
        }

        public override IBaseModel ToDbModel(DTODeliveryDetail item)
        {
            var result = new DELDET();

            result.Delrecno = item.Id;
            result.Deldlvordno = item.DeliveryHeadId;
            result.Delqty = item.Quantity;
            result.Delweight = item.WeightInKg;
            result.Delprcbywgt = item.IsPricedByWeight ? (short)1 : (short)0; 
            result.Delprcprdno = item.ProductId;
            result.Delcltprdno = item.ClientProductNo;
            result.Qtyper = item.QuantityPer;
            result.Delpriceper = item.PricePer;
            result.Delstatus = Enums<DTODeliveryStatus>.GetCode(item.DeliveryStatus);

            return result;
        }

        protected override List<DTODeliveryDetail> GetDataInternal(List<ISearchField> searchFields, CachingStrategy allowFromCache, uint? topRows)
        {
            string query = ConstructSimpleQuery(_sqlQuery, searchFields, true, topRows);
            var results = UnitOfWorkCurrent.Query<DELDETExt>(query);

            return results
                    .Select(item =>
                        new DTODeliveryDetail
                            {
                                Id = item.Delrecno,
                                DeliveryHeadId = item.Deldlvordno,
                                Quantity = item.Delqty,
                                WeightInKg = item.Delweight ?? 0,
                                IsPricedByWeight = (item.Delprcbywgt ?? 0) > 0,
                                ProductId = item.Delprcprdno,
                                ClientProductNo = item.Delcltprdno,
                                ClientAllocationNo = item.DetAllocNo,
                                ProgramReferenceNo = item.PrgRefNo,
                                QuantityPer = item.Qtyper,
                                PricePer = item.Delpriceper,
                                DeliveryStatus = Enums<DTODeliveryStatus>.GetValueNullable(item.Delstatus)
                            })
                    .ToList();
        }

        public List<DTODeliveryDetail> GetDeliveryDetailByDeliveryHeadIDs(List<int> deliveryHeadIds)
        {
            return GetDataInChunks(i => i.DeliveryHeadId, deliveryHeadIds);
        }

        public class DELDETExt: DELDET
        {
            public string DetAllocNo { get; set; }
            public int PrgRefNo { get; set; }
        }
    }
}
