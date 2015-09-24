using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Bsdl.FreshTrade.Domain.Basic.Entities;
using Bsdl.FreshTrade.Domain.Basic.Enums;
using Bsdl.FreshTrade.Domain.Basic.Exceptions.DataAccess;
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

namespace Bsdl.FreshTrade.Repositories.PreInv.TempRep
{
    public class PreInvPrt2Repository : DapperRepositoryBase<DTOInvPrt2>, IPreInvPrt2Repository
    {
        private const string _sqlQuery = @"SELECT * FROM PREINVTEMP_PREINVPRT2";

        private const string _sqlDeleteQuery = @"DELETE FROM PREINVTEMP_PREINVPRT2 WHERE EXTRACTSESSIONID = {0}";

        public PreInvPrt2Repository(IUnitOfWork unitOfWorkCurrent, ICacheManagerFactory cacheManagerFactory)
            : base
            (
                unitOfWorkCurrent,
                cacheManagerFactory,
                new List<ISearchFieldDef>
                {
                     new SearchFieldDef<DTOInvPrt2, int>(i => i.ExtractSessionID, PreINVPRT2.FieldNames.EXTRACTSESSIONID, FieldType.Integer),
                     new SearchFieldDef<DTOInvPrt2, int?>(i => i.DelRecNo, PreINVPRT2.FieldNames.DELRECNO, FieldType.Integer),
                     new SearchFieldDef<DTOInvPrt2, int?>(i => i.Recno, PreINVPRT2.FieldNames.RECNO, FieldType.Integer)
                }
            )
        {
        }


        public override IList<EntityPropDef> GetTableFieldsDefs()
        {
            return PreINVPRT2.GetPropDefs();
        }

        public override string GetTableName()
        {
            return "PREINVTEMP_PREINVPRT2";
        }

        public override IBaseModel ToDbModel(DTOInvPrt2 item)
        {
            var result = new PreINVPRT2();
            result.Extractsessionid = item.ExtractSessionID;
            result.Invprtrecno = item.InvPrtRecNo;
            result.Alloctoinvrecno = item.AllocToInvRecNo;
            result.Allowonelinecancel = item.AllowOneLineCancel ? (short)1 : (short)0;
            result.Basecommamt = item.Basecommamt;
            result.Basegds = item.BaseGds;
            result.Basehandamt = item.Basehandamt;
            result.Baseoffinvrbt = item.BaseOffInvRbt;
            result.Baseoffonpay = item.BaseOffOnPay;
            result.Baseoninvdscnt = item.BaseOnInvDscnt;
            result.Basevat = item.BaseVat;
            result.Basevat1total = item.BaseVat1Total;
            result.Basevat2total = item.BaseVat2Total;
            result.Basevatonchgs = item.Basevatonchgs;
            result.Cancelledline = item.CancelledLine ? (short)1 : (short)0;
            result.Commperc = item.Commperc;
            result.Delcdsrefno = item.DelCdsRefNo;
            result.Delcltprdno = item.DelCltPrdNo;
            result.Delinvstatus = (int?)item.DelInvStatus;
            result.Delprcbywgt = item.DelPrcByWgt ? (short)1 : (short)0;
            result.Delprcprdno = item.DelPrcPrdNo;
            result.Detallocno = item.DetAllocNo;
            result.Disctoqty = item.DiscToQty;
            result.Dispcnt = item.Dispcnt;
            result.Dprrecno = item.DprRecNo;
            result.Eurocommamt = item.Eurocommamt;
            result.Eurogds = item.EuroGds;
            result.Eurohandamt = item.Eurohandamt;
            result.Eurooffinvrbt = item.EuroOffInvRbt;
            result.Eurooffonpay = item.EuroOffOnPay;
            result.Eurooninvdscnt = item.EuroOnInvDscnt;
            result.Eurovat = item.EuroVat;
            result.Eurovat1total = item.EuroVat1Total;
            result.Eurovat2total = item.EuroVat2Total;
            result.Eurovatonchgs = item.Eurovatonchgs;
            result.Grosswgt = item.GrossWgt;
            result.Handrate = item.Handrate;
            result.Nettwgt = item.NettWgt;
            result.Offinvonpay = item.OffInvOnPay;
            result.Offinvrbt = item.OffInvRbt;
            result.Prcprdref = item.PrcPrdRef;
            result.Prddesc = item.PrdDesc;
            result.Prdglanl = item.PrdGlAnl;
            result.Prdrecdesc = item.PrdRecDesc;
            result.Prgrefno = item.PrgRefNo;
            result.Prtqty = item.PrtQty;
            result.Rawcommamt = item.Rawcommamt;
            result.Rawhandamt = item.Rawhandamt;
            result.Rawvatonchgs = item.Rawvatonchgs;
            result.Tarewgt = item.TareWgt;
            result.Tradedunit = item.TradedUnit;
            result.Unitcount = item.UnitCount;
            result.Unitmeasure = item.UnitMeasure;
            result.Vat1total = item.Vat1Total;
            result.Vat2total = item.Vat2Total;
            result.Vatcodechgs = item.Vatcodechgs;
            result.Vatlnkrecno = item.VatLnkRecNo;
            result.Vatratechgs = item.Vatratechgs;
            result.Vatrecno = item.VatRecNo;
            result.Vatvatrate2 = item.VatVatRate2;
            result.Vatvearecno = item.VatVeaRecNo;

            result.Dlvinvoiceno = item.InvoiceNo;

            result.Cancelledline = item.Cancel ? (short)1 : (short)0;
            result.Delprice = item.DelPrice;
            result.Delqty = item.DelQty;
            result.Delrecno = item.DelRecNo;
            result.Delweight = item.DelWeight;
            result.Dlvordno = item.DlvOrdNo;
            result.Ext = item.Ext;
            result.Goods = item.Goods;
            result.Oninvdispcnt = item.OnInvDisPcnt;
            result.Oninvdscnt = item.OnInvDscnt;
            result.Ppcno = item.PpcNo;
            result.Recno = item.Recno;
            result.Vat = item.Vat;
            result.Vatvatrate = item.VatVatRate;

            return result;
        }

        protected override List<DTOInvPrt2> GetDataInternal(List<ISearchField> searchFields, CachingStrategy allowFromCache, uint? topRows)
        {
            string query = ConstructSimpleQuery(_sqlQuery, searchFields, true, topRows);

            var data = new List<DTOInvPrt2>();

            IEnumerable<PreINVPRT2> results = null;

            try
            {
                results = UnitOfWorkCurrent.Query<PreINVPRT2>(query);
            }
            catch (Exception ex)
            {
                throw new DatabaseQueryException("Could not load PREINVTEMP_PREINVPRT" + Environment.NewLine + ex.Message, ex);
            }

            if (results != null)
            {
                foreach (var item in results)
                {
                    data.Add
                        (
                            new DTOInvPrt2
                            {
                                ExtractSessionID = item.Extractsessionid,
                                InvPrtRecNo = item.Invprtrecno,
                                AllocToInvRecNo = item.Alloctoinvrecno,
                                AllowOneLineCancel = item.Allowonelinecancel > 0,
                                Basecommamt = item.Basecommamt ?? 0,
                                BaseGds = item.Basegds ?? 0,
                                Basehandamt = item.Basehandamt ?? 0,
                                BaseOffInvRbt = item.Baseoffinvrbt ?? 0,
                                BaseOffOnPay = item.Baseoffonpay ?? 0,
                                BaseOnInvDscnt = item.Baseoninvdscnt ?? 0,
                                BaseVat = item.Basevat ?? 0,
                                BaseVat1Total = item.Basevat1total ?? 0,
                                BaseVat2Total = item.Basevat2total ?? 0,
                                Basevatonchgs = item.Basevatonchgs,
                                CancelledLine = item.Cancelledline > 0,
                                Commperc = item.Commperc ?? 0,
                                DelCdsRefNo = item.Delcdsrefno,
                                DelCltPrdNo = item.Delcltprdno,
                                DelInvStatus = Enums<DTODeliveryPriceStatus>.GetValueNullable(item.Delinvstatus),
                                DelPrcByWgt = item.Delprcbywgt > 0,
                                DelPrcPrdNo = item.Delprcprdno,
                                DetAllocNo = item.Detallocno,
                                DiscToQty = item.Disctoqty,
                                Dispcnt = item.Dispcnt,
                                DprRecNo = item.Dprrecno,
                                Eurocommamt = item.Eurocommamt ?? 0,
                                EuroGds = item.Eurogds ?? 0,
                                Eurohandamt = item.Eurohandamt ?? 0,
                                EuroOffInvRbt = item.Eurooffinvrbt ?? 0,
                                EuroOffOnPay = item.Eurooffonpay ?? 0,
                                EuroOnInvDscnt = item.Eurooninvdscnt ?? 0,
                                EuroVat = item.Eurovat ?? 0,
                                EuroVat1Total = item.Eurovat1total ?? 0,
                                EuroVat2Total = item.Eurovat2total ?? 0,
                                Eurovatonchgs = item.Eurovatonchgs ?? 0,
                                GrossWgt = item.Grosswgt ?? 0,
                                Handrate = item.Handrate ?? 0,
                                NettWgt = item.Nettwgt ?? 0,
                                OffInvOnPay = item.Offinvonpay ?? 0,
                                OffInvRbt = item.Offinvrbt ?? 0,
                                PrcPrdRef = item.Prcprdref,
                                PrdDesc = item.Prddesc,
                                PrdGlAnl = item.Prdglanl,
                                PrdRecDesc = item.Prdrecdesc,
                                PrgRefNo = item.Prgrefno,
                                PrtQty = item.Prtqty ?? 0,
                                Rawcommamt = item.Rawcommamt ?? 0,
                                Rawhandamt = item.Rawhandamt ?? 0,
                                Rawvatonchgs = item.Rawvatonchgs ?? 0,
                                TareWgt = item.Tarewgt ?? 0,
                                TradedUnit = item.Tradedunit,
                                UnitCount = item.Unitcount,
                                UnitMeasure = item.Unitmeasure,
                                Vat1Total = item.Vat1total ?? 0,
                                Vat2Total = item.Vat2total ?? 0,
                                Vatcodechgs = item.Vatcodechgs ?? 0,
                                VatLnkRecNo = item.Vatlnkrecno,
                                Vatratechgs = item.Vatratechgs ?? 0,
                                VatRecNo = item.Vatrecno,
                                VatVatRate2 = item.Vatvatrate2 ?? 0,
                                VatVeaRecNo = item.Vatvearecno,
                                InvoiceNo = item.Dlvinvoiceno,
                                Cancel = item.Cancelledline > 0,
                                DelPrice = item.Delprice ?? 0,
                                DelQty = item.Delqty,
                                DelRecNo = item.Delrecno,
                                DelWeight = item.Delweight ?? 0,
                                DlvOrdNo = item.Dlvordno,
                                Ext = item.Ext ?? 0,
                                Goods = item.Goods ?? 0,
                                OnInvDisPcnt = item.Oninvdispcnt ?? 0,
                                OnInvDscnt = item.Oninvdscnt ?? 0,
                                PpcNo = item.Ppcno,
                                Recno = item.Recno,
                                Vat = item.Vat ?? 0,
                                VatVatRate = item.Vatvatrate ?? 0                                
                            }
                        );
                }
            }

            return data;
        }

        public List<DTOInvPrt2> GetInvPrt2ByExtractionSessionId(int extractionSessionId, List<int> recNoList)
        {
            return GetDataInChunksCustom
                           (
                                i => GetData
                                (
                                    new List<ISearchField>
                                        {
                                            new SearchFieldGeneric<DTOInvPrt2, int>(k => k.ExtractSessionID).Apply(extractionSessionId, FieldType.Integer),
                                            new SearchFieldGeneric<DTOInvPrt2, int?>(k => k.Recno).Apply(i, FieldType.List)
                                        },
                                    CachingStrategy.NoCache
                                ),
                                recNoList
                            );
        }

        public List<DTOInvPrt2> GetByExtractSessionID(int extractSessionID)
        {
            return GetData(
                    new List<ISearchField> {
                        new SearchFieldGeneric<DTOInvPrt2, int>(i => i.ExtractSessionID).Apply(extractSessionID , FieldType.Integer)
                 }, CachingStrategy.NoCache).ToList();
        }

        public void DeleteByExtractSessionID(int extractSessionID)
        {
            string sqlQuery = string.Format(_sqlDeleteQuery, extractSessionID);
            UnitOfWorkCurrent.Execute(sqlQuery);
        }

    }
}
