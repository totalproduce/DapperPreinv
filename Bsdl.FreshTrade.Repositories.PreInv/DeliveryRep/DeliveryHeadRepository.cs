using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Bsdl.FreshTrade.Domain.Basic.Entities;
using Bsdl.FreshTrade.Domain.Basic.Enums;
using Bsdl.FreshTrade.Domain.Basic.Utilities.DataTypeHandling;
using Bsdl.FreshTrade.Domain.PreInv.Entities;
using Bsdl.FreshTrade.Domain.PreInv.Enums;
using Bsdl.FreshTrade.Repositories.Basic;
using Bsdl.FreshTrade.Repositories.Basic.Interfaces;
using Bsdl.FreshTrade.Repositories.Basic.Utilities.Interfaces;
using Bsdl.FreshTrade.Repositories.PreInv.DBModel;
using Bsdl.FreshTrade.Repositories.PreInv.Interfaces;
using Bsdl.FreshTrade.Domain.Basic.Interfaces;
using Bsdl.FreshTrade.Repositories.Basic.Persistance;
using Bsdl.FreshTrade.Repositories.Basic.DBModel;

namespace Bsdl.FreshTrade.Repositories.PreInv.DeliveryRep
{
    public class DeliveryHeadRepository : DapperRepositoryBase<DTODeliveryHead>, IDeliveryHeadRepository
    {
        private const string _sqlQuery = @"SELECT * FROM DELHED";

        public DeliveryHeadRepository(IUnitOfWork unitOfWorkCurrent, ICacheManagerFactory cacheManagerFactory)
            : base
            (
                unitOfWorkCurrent, 
                cacheManagerFactory,
                new List<ISearchFieldDef>
                {
                    new SearchFieldDef<DTODeliveryHead, int>(i => i.Id, DELHED.FieldNames.DLVORDNO, FieldType.Integer),
                    new SearchFieldDef<DTODeliveryHead, int?>(i => i.OrderId, DELHED.FieldNames.DLVORDRECNO, FieldType.Integer)
                }
            )
        {
        }


        public override IList<EntityPropDef> GetTableFieldsDefs()
        {
            return DELHED.GetPropDefs();
        }

        public override string GetTableName()
        {
            return "DELHED";
        }

        public override IBaseModel ToDbModel(DTODeliveryHead item)
        {
            var result = new DELHED();
            result.Dlvordno = item.Id;
            result.Dlvordrecno = item.OrderId;
            result.Dlvcurrecno = item.CurrencyNo; 
            result.Dlvtransship = item.IsInterCompanyTransfer?(short)1:(short)0;
            result.Trnsaloffno = item.SalesOfficeTransferTo;
            result.Dlvsaloffno = item.DeliverySalesOfficeNo;
            result.Invsaloffno = item.InvoiceSalesOfficeNo;
            result.Transferflg = item.TransferFlag;
            result.Dlvpodno = item.PoDNo;
            result.Dlvtranind = item.TranInd;
            result.Dlvrelinv = Enums<DTODeliveryStatus>.GetCode(item.DeliveryStatus);
            result.Dlvshpdate = item.ShipDate;
            result.Dlvdeldate = item.DeliveryDate;
            result.Dlvdltrecno = item.DeliveryTypeId;
            result.Interdeptflag = item.IsInterDepartment?(short)1:(short)0;
            result.Dlvhasopenprc = item.IsOpenPriceDelivery?(short)1:(short)0;
            result.Dlvstkloc = item.FromStockLocationId;
            result.Dlvprghedno = item.ProgrammeHeadId;
            result.Dlvstkloc = item.StockLocationId;

            return result;
        }

        protected override List<DTODeliveryHead> GetDataInternal(List<ISearchField> searchFields, CachingStrategy allowFromCache, uint? topRows)
        {
            string query = ConstructSimpleQuery(_sqlQuery, searchFields, true, topRows);
            var results = UnitOfWorkCurrent.Query<DELHED>(query);

            return results
                    .Select(item =>
                        new DTODeliveryHead
                            {
                                Id = item.Dlvordno,
                                OrderId = item.Dlvordrecno,
                                CurrencyNo = item.Dlvcurrecno,
                                IsInterCompanyTransfer = (item.Dlvtransship ?? 0) > 0,
                                SalesOfficeTransferTo = item.Trnsaloffno,
                                DeliverySalesOfficeNo = item.Dlvsaloffno,
                                InvoiceSalesOfficeNo = item.Invsaloffno,
                                TransferFlag = item.Transferflg,
                                PoDNo = item.Dlvpodno,
                                TranInd = item.Dlvtranind,
                                DeliveryStatus = Enums<DTODeliveryStatus>.GetValueNullable(item.Dlvrelinv),
                                ShipDate = item.Dlvshpdate,
                                DeliveryDate = item.Dlvdeldate,
                                DeliveryTypeId = item.Dlvdltrecno,
                                IsInterDepartment = (item.Interdeptflag ?? 0) > 0,
                                IsOpenPriceDelivery = (item.Dlvhasopenprc ?? 0) > 0,
                                FromStockLocationId = item.Dlvstkloc,
                                ProgrammeHeadId = item.Dlvprghedno,
                                StockLocationId = item.Dlvstkloc                                
                            })
                    .ToList();
        }

        public List<DTODeliveryHead> GetDeliveryHeadByOrderIDs(List<int> orderIds)
        {
            return GetDataInChunks(i => i.OrderId, orderIds);
        }
    }
}
