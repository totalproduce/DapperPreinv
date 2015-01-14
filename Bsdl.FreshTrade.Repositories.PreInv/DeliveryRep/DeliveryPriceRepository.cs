using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using Bsdl.FreshTrade.Domain.Basic.Enums;
using Bsdl.FreshTrade.Domain.Basic.Interfaces;
using Bsdl.FreshTrade.Domain.Basic.Utilities.DataTypeHandling;
using Bsdl.FreshTrade.Domain.PreInv.Entities;
using Bsdl.FreshTrade.Domain.PreInv.Enums;
using Bsdl.FreshTrade.Repositories.Basic;
using Bsdl.FreshTrade.Repositories.Basic.DBModel;
using Bsdl.FreshTrade.Repositories.Basic.Interfaces;
using Bsdl.FreshTrade.Repositories.Basic.Persistance;
using Bsdl.FreshTrade.Repositories.Basic.Utilities.Interfaces;
using Bsdl.FreshTrade.Repositories.PreInv.DBModel;
using Bsdl.FreshTrade.Repositories.PreInv.Interfaces;
using Dapper;

namespace Bsdl.FreshTrade.Repositories.PreInv.DeliveryRep
{
    public class DeliveryPriceRepository : DapperRepositoryBase<DTODeliveryPrice>, IDeliveryPriceRepository
    {
        private const string _sqlQuery = @"SELECT * FROM DELPRICE";

        private const string _sqlEnqueForCostingStoredProcedure = @"FT_AUTOCOSTING.ENQUEUE_DPRRECS_AA";

        public DeliveryPriceRepository(IUnitOfWork unitOfWorkCurrent, ICacheManagerFactory cacheManagerFactory)
            : base
            (
                unitOfWorkCurrent,
                cacheManagerFactory,
                new List<ISearchFieldDef>
                {
                    new SearchFieldDef<DTODeliveryPrice, int>(i => i.Id, DelPrice.FieldNames.DPRRECNO, FieldType.Integer),
                    new SearchFieldDef<DTODeliveryPrice, int?>(i => i.DeliveryDetailId, DelPrice.FieldNames.DPRDELRECNO, FieldType.Integer)
                }
            )
        {
        }

        public override IList<EntityPropDef> GetTableFieldsDefs()
        {
            return DelPrice.GetPropDefs();
        }

        public override string GetTableName()
        {
            return "DELPRICE";
        }

        public override IBaseModel ToDbModel(DTODeliveryPrice item)
        {
            var result = new DelPrice();
            result.Dprrecno = item.Id;
            result.Adjby = item.AdjustedBy;
            result.Delallwkrecno = item.Delallwkrecno;
            result.Delbasenettval = item.DelBaseNettVal;
            result.Delbasevatvalue = item.DelBaseVatValue;
            result.Deleuronettval = item.DelEuroNettVal;
            result.Deleurovatvalue = item.DelEuroVatValue;
            result.Delfreeofchg = item.FreeOfCharge?(short)1:(short)0;
            result.Delinvrecno = item.InvoiceId;
            result.Delinvstatus = (int?)item.DeliveryPriceStatus;
            result.Delisguideprice = item.Delisguideprice ? (short)1 : (short)0;
            result.Delnettvalue = item.NettValue;
            result.Delprccomno = item.Delprccomno;
            result.Delprcqty = item.Quantity;
            result.Delprcweight = item.PriceWeight;
            result.Delprice = item.Price;
            result.Delretailprice = item.Delretailprice;
            result.Deltobaserate = item.DelToBaseRate;
            result.Deltoeurorate = item.DelToEuroRate;
            result.Deltriangulate = item.DelTriangulate ? (short)1 : (short)0;
            result.Delvatrate = item.VatRate;
            result.Delvatrate2 = item.VatRate2;
            result.Delvatrecno = item.VatRecNo;
            result.Delvatvalue = item.DelVatValue;
            result.Dprcreationdate = item.Dprcreationdate;
            result.Dprdelrecno = item.DeliveryDetailId;
            result.Dprisprcccdtdbt = item.Dprisprcccdtdbt ? (short)1 : (short)0;
            result.Dprispriceadjonly = item.IsPriceAdjustment ? (short)1 : (short)0;
            result.Dprmanwgtchg = item.Dprmanwgtchg;
            result.Dprnominalprice = item.Dprnominalprice;
            result.Dprpreas = item.Dprpreas;
            return result;
        }


        protected override List<DTODeliveryPrice> GetDataInternal(List<ISearchField> searchFields, CachingStrategy allowFromCache, uint? topRows)
        {
            string query = ConstructSimpleQuery(_sqlQuery, searchFields, true, topRows);
            var results = UnitOfWorkCurrent.Query<DelPrice>(query);

            return results
                    .Select(item =>
                        new DTODeliveryPrice
                        {
                            Id = item.Dprrecno,
                            DeliveryDetailId = item.Dprdelrecno,
                            Quantity = item.Delprcqty,
                            WeightInKg = item.Delprcweight ?? 0,
                            NettValue = item.Delnettvalue ?? 0,
                            DeliveryPriceStatus = Enums<DTODeliveryPriceStatus>.GetValueNullable(item.Delinvstatus),
                            FreeOfCharge = item.Delfreeofchg.HasValue && item.Delfreeofchg.Value == 1,
                            Price = item.Delprice ?? 0,
                            IsPriceAdjustment = item.Dprispriceadjonly.HasValue && item.Dprispriceadjonly.Value >= 1,
                            AdjustedBy = item.Adjby,
                            InvoiceId = item.Delinvrecno,
                            VatRate = item.Delvatrate,
                            VatRate2 = item.Delvatrate2,
                            VatRecNo = item.Delvatrecno,
                            PriceWeight = item.Delprcweight ?? 0,
                            DelToEuroRate = item.Deltoeurorate ?? 0,
                            DelToBaseRate = item.Deltobaserate ?? 0,
                            DelTriangulate = item.Deltriangulate>0,
                            DelVatValue = item.Delvatvalue ?? 0,
                            DelBaseNettVal = item.Delbasenettval ?? 0,
                            DelBaseVatValue = item.Delbasevatvalue ?? 0,
                            DelEuroNettVal = item.Deleuronettval ?? 0,
                            DelEuroVatValue = item.Deleurovatvalue ?? 0,   
                            Delallwkrecno = item.Delallwkrecno,
                            Delisguideprice = item.Delisguideprice > 0,
                            Delprccomno = item.Delprccomno,
                            Delretailprice = item.Delretailprice ?? 0,
                            Dprcreationdate = item.Dprcreationdate,
                            Dprnominalprice = item.Dprnominalprice ?? 0,
                            Dprmanwgtchg = item.Dprmanwgtchg,
                            Dprisprcccdtdbt = item.Dprisprcccdtdbt > 0,
                            Dprpreas = item.Dprpreas
                        })
                    .ToList();
        }

        public List<DTODeliveryPrice> GetDeliveryPriceByDeliveryDetailIDs(List<int> deliveryDetailIds)
        {
            return GetDataInChunks(i => i.DeliveryDetailId, deliveryDetailIds);
        }

        public List<DTODeliveryPrice> GetDeliveryPriceByDprRecNos(List<int> recnos)
        {
            return GetDataInChunks(i => i.Id, recnos);
        }

        public void EnqueueForCosting(List<int> deliveryPriceIds)
        {
            ExecuteCustomSqlWithArrayBinding
                (
                    _sqlEnqueForCostingStoredProcedure,
                    deliveryPriceIds,
                    i =>
                        {
                            var parameters = new DynamicParameters();
                            GenSqlScriptHelper.GenStoredProcedureParam(parameters, "DPRRECS_IN", typeof(int), i.ToArray());
                            GenSqlScriptHelper.GenStoredProcedureParam(parameters, "COSTCHNGTYPE_IN", typeof(int), 2);
                            return parameters;
                        },
                        CommandType.StoredProcedure
                );
        }

    }
}
