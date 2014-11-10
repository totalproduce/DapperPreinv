using System;
using System.Collections.Generic;
using System.Linq;
using Bsdl.FreshTrade.Domain.Basic.Entities;
using Bsdl.FreshTrade.Domain.Basic.Enums;
using Bsdl.FreshTrade.Domain.Basic.Exceptions.DataAccess;
using Bsdl.FreshTrade.Domain.Basic.Interfaces;
using Bsdl.FreshTrade.Domain.PreInv.Entities;
using Bsdl.FreshTrade.Repositories.Basic;
using Bsdl.FreshTrade.Repositories.Basic.DBModel;
using Bsdl.FreshTrade.Repositories.Basic.Interfaces;
using Bsdl.FreshTrade.Repositories.Basic.Persistance;
using Bsdl.FreshTrade.Repositories.Basic.Utilities.Interfaces;
using Bsdl.FreshTrade.Repositories.PreInv.DBModel;
using Bsdl.FreshTrade.Repositories.PreInv.Interfaces;
using Bsdl.FreshTrade.Domain.PreInv.Enums;
using Bsdl.FreshTrade.Domain.Basic.Utilities.DataTypeHandling;

namespace Bsdl.FreshTrade.Repositories.PreInv.TempRep
{
    public class PreInvTotRepository : DapperRepositoryBase<DTOInvTot>, IPreInvTotRepository
    {
        private const string _sqlQuery = @"SELECT * FROM PREINVTEMP_PREINVTOT";

        private const string _sqlDeleteQuery = @"DELETE FROM PREINVTEMP_PREINVTOT WHERE EXTRACTSESSIONID = {0}";

        public PreInvTotRepository(IUnitOfWork unitOfWorkCurrent, ICacheManagerFactory cacheManagerFactory)
            : base
            (
                unitOfWorkCurrent,
                cacheManagerFactory,
                new List<ISearchFieldDef>
                {
                    new SearchFieldDef<DTOInvTot, int>(i => i.ExtractSessionID, PreINVTOT.FieldNames.EXTRACTSESSIONID, FieldType.Integer),
                    new SearchFieldDef<DTOInvTot, string>(i => i.InvoiceNo, PreINVTOT.FieldNames.INVOICENO, FieldType.AlphaNumeric)
                }
            )
        {
        }


        public override IList<EntityPropDef> GetTableFieldsDefs()
        {
            return PreINVTOT.GetPropDefs();
        }

        public override string GetTableName()
        {
            return "PREINVTEMP_PREINVTOT";
        }

        public override IBaseModel ToDbModel(DTOInvTot item)
        {
            //If you correct anything here - check InvTotRepository as well
            DTOInvTotVatInfo
                vatInfo1 = null,
                vatInfo2 = null,
                vatInfo3 = null,
                vatEmpty = new DTOInvTotVatInfo();
            if (item.VatInfo != null)
            {
                var vatInfo = item.VatInfo.Values.ToList();
                if (vatInfo.Count > 0)
                {
                    vatInfo1 = vatInfo[0];
                }
                if (vatInfo.Count > 1)
                {
                    vatInfo2 = vatInfo[1];
                }
                if (vatInfo.Count > 2)
                {
                    vatInfo3 = vatInfo[2];
                }
            }
            vatInfo1 = vatInfo1 ?? vatEmpty;
            vatInfo2 = vatInfo2 ?? vatEmpty;
            vatInfo3 = vatInfo3 ?? vatEmpty;

            //TODO: Fields list is NOT accurate!
            var result = new PreINVTOT();
            result.Extractsessionid = item.ExtractSessionID;
            result.Accglanl = item.AccGlAnl;
            result.Accntsaloffno = item.AccntSalOffNo;
            result.Avavearec1 = vatInfo1.AvaVeaRec;
            result.Avavearec2 = vatInfo2.AvaVeaRec;
            result.Avavearec3 = vatInfo3.AvaVeaRec;
            result.Basegds1 = vatInfo1.BaseGds;
            result.Basegds2 = vatInfo2.BaseGds;
            result.Basegds3 = vatInfo3.BaseGds;
            result.Basegdstotal = item.BaseGdsTotal;
            result.Basehandcommamt = item.Basehandcommamt;
            result.Baseoffinvonpay = item.BaseOffInvOnPay;
            result.Baseoffinvrbt = item.BaseOffInvRbt;
            result.Baseoninvdscnt = item.BaseOnInvDscnt;
            result.Baserate = item.BaseRate;
            result.Basevat1 = vatInfo1.BaseVat;
            result.Basevat12 = vatInfo1.BaseVat2;
            result.Basevat1total = item.BaseVat1Total;
            result.Basevat2 = vatInfo2.BaseVat;
            result.Basevat22 = vatInfo2.BaseVat2;
            result.Basevat2total = item.BaseVat2Total;
            result.Basevat3 = vatInfo3.BaseVat;
            result.Basevat32 = vatInfo3.BaseVat2;
            result.Basevatonchgs = item.BaseVatOnChgs;
            result.Basevattotal = item.BaseVatTotal;
            result.Cancelledinv = (short)(item.CancelledInv ? 1 : 0);
            result.Cde1 = vatInfo1.Cde;
            result.Cde2 = vatInfo2.Cde;
            result.Cde3 = vatInfo3.Cde;
            result.Companyname = item.CompanyName;
            result.Compoundvatcust = (short)(item.CompoundVatCust ? 1 : 0);
            result.Curdesc = item.CurDesc;
            result.Curno = item.CurNo;
            result.Eiinvoiceid = item.EIInvoiceId;
            result.Eurogds1 = vatInfo1.EuroGds;
            result.Eurogds2 = vatInfo2.EuroGds;
            result.Eurogds3 = vatInfo3.EuroGds;
            result.Eurogdstotal = item.EuroGdsTotal;
            result.Eurohandcommamt = item.Eurohandcommamt;
            result.Eurooffinvonpay = item.EuroOffInvOnPay;
            result.Eurooffinvrbt = item.EuroOffInvRbt;
            result.Eurooninvdscnt = item.EuroOnInvDscnt;
            result.Eurorate = item.EuroRate;
            result.Eurovat1 = vatInfo1.EuroVat;
            result.Eurovat12 = vatInfo1.EuroVat2;
            result.Eurovat1total = item.EuroVat1Total;
            result.Eurovat2 = vatInfo2.EuroVat;
            result.Eurovat22 = vatInfo2.EuroVat2;
            result.Eurovat2total = item.EuroVat2Total;
            result.Eurovat3 = vatInfo3.EuroVat;
            result.Eurovat32 = vatInfo3.EuroVat2;
            result.Eurovatonchgs = item.EuroVatOnChgs;
            result.Eurovattotal = item.EuroVatTotal;
            result.Finfiscrep1 = item.Finfiscrep1;
            result.Finvatdesc1 = item.Finvatdesc1;
            result.Finvatnumber1 = item.Finvatnumber1;
            result.Gds1 = vatInfo1.Gds;
            result.Gds2 = vatInfo2.Gds;
            result.Gds3 = vatInfo3.Gds;
            result.Goodstotal = item.GoodsTotal;
            result.Hofclarecno = item.HofClaRecNo;
            result.Hofcstcode = item.HofCstCode;
            result.Invdate = item.InvDate;
            result.Invoiceno = item.InvoiceNo;
            result.Invoicetotal = item.InvoiceTotal;
            result.Invrecno = item.InvRecNo;
            result.Isedicst = (short?)(item.IsEdiCst ? 1 : 0);
            result.Isinterdept = (short)(item.IsInterDept ? 1 : 0);
            result.Isseqinvno = (short?)(item.IsSeqInvNo ? 1 : 0);
            result.Offinvonpay = item.OffInvOnPay;
            result.Offinvrbt = item.OffInvRbt;
            result.Oninvdscnt = item.OnInvDscnt;
            result.Prcglbrecno = item.PrcGlbRecNo;
            result.Qtytotal = item.QtyTotal;
            result.Rawhandcommamt = item.Rawhandcommamt;
            result.Rawvatonchgs = item.RawVatOnChgs;
            result.Rte1 = vatInfo1.Rte;
            result.Rte12 = vatInfo1.Rte2;
            result.Rte2 = vatInfo2.Rte;
            result.Rte22 = vatInfo2.Rte2;
            result.Rte3 = vatInfo3.Rte;
            result.Rte32 = vatInfo3.Rte2;
            result.Sort1 = item.Sort1;
            result.Sort2 = item.Sort2;
            result.Sort3 = item.Sort3;
            result.Stinvtotal = item.StInvTotal;
            result.Triangreq = (short?)(item.TriangReq ? 1 : 0);
            result.Twovatratescust = (short)(item.TwoVatRatesCust ? 1 : 0);
            result.Vat1 = vatInfo1.Vat;
            result.Vat12 = vatInfo1.Vat2;
            result.Vat1total = item.Vat1Total;
            result.Vat2 = vatInfo2.Vat;
            result.Vat22 = vatInfo2.Vat2;
            result.Vat2total = item.Vat2Total;
            result.Vat3 = vatInfo3.Vat;
            result.Vat32 = vatInfo3.Vat2;
            result.Vatcodechgs = item.VatCodeChgs;
            result.Vatlnkrecno1 = vatInfo1.VatLnkRecNo;
            result.Vatlnkrecno2 = vatInfo2.VatLnkRecNo;
            result.Vatlnkrecno3 = vatInfo3.VatLnkRecNo;
            result.Vatratechgs = item.VatRateChgs;
            result.Vattotal = item.VatTotal;
            result.Writeaccrechg = (short?)(item.WriteAccReChg ? 1 : 0);
            result.Invoicetype = (int)item.InvoiceType;
            result.Batchtype = (int)item.BatchType;
            return result;
        }

        protected override List<DTOInvTot> GetDataInternal(List<ISearchField> searchFields, CachingStrategy allowFromCache, uint? topRows)
        {
            string query = ConstructSimpleQuery(_sqlQuery, searchFields, true, topRows);

            var data = new List<DTOInvTot>();

            IEnumerable<PreINVTOT> results = null;

            try
            {
                results = UnitOfWorkCurrent.Query<PreINVTOT>(query);
            }
            catch (Exception ex)
            {
                throw new DatabaseQueryException("Could not load PREINVTEMP_PREINVTOT" + Environment.NewLine + ex.Message, ex);
            }

            if (results != null)
            {
                foreach (var item in results)
                {
                    //If you correct anything here - check InvTotRepository as well
                    var invTot =
                        new DTOInvTot
                        {
                            ExtractSessionID = item.Extractsessionid,
                            AccGlAnl = item.Accglanl,
                            AccntSalOffNo = item.Accntsaloffno,
                            BaseGdsTotal = item.Basegdstotal ?? 0,
                            Basehandcommamt = item.Basehandcommamt ?? 0,
                            BaseOffInvOnPay = item.Baseoffinvonpay ?? 0,
                            BaseOffInvRbt = item.Baseoffinvrbt ?? 0,
                            BaseOnInvDscnt = item.Baseoninvdscnt ?? 0,
                            BaseRate = item.Baserate ?? 0,
                            BaseVat1Total = item.Basevat1total ?? 0,
                            BaseVat2Total = item.Basevat2total ?? 0,
                            BaseVatOnChgs = item.Basevatonchgs ?? 0,
                            BaseVatTotal = item.Basevattotal ?? 0,
                            CancelledInv = item.Cancelledinv > 0,
                            CompanyName = item.Companyname,
                            CompoundVatCust = item.Compoundvatcust > 0,
                            CurDesc = item.Curdesc,
                            CurNo = item.Curno,
                            EIInvoiceId = item.Eiinvoiceid,
                            EuroGdsTotal = item.Eurogdstotal ?? 0,
                            Eurohandcommamt = item.Eurohandcommamt ?? 0,
                            EuroOffInvOnPay = item.Eurooffinvonpay ?? 0,
                            EuroOffInvRbt = item.Eurooffinvrbt ?? 0,
                            EuroOnInvDscnt = item.Eurooninvdscnt ?? 0,
                            EuroRate = item.Eurorate ?? 0,
                            EuroVat1Total = item.Eurovat1total ?? 0,
                            EuroVat2Total = item.Eurovat2total ?? 0,
                            EuroVatOnChgs = item.Eurovatonchgs ?? 0,
                            EuroVatTotal = item.Eurovattotal ?? 0,
                            Finfiscrep1 = item.Finfiscrep1,
                            Finvatdesc1 = item.Finvatdesc1,
                            Finvatnumber1 = item.Finvatnumber1,
                            GoodsTotal = item.Goodstotal ?? 0,
                            HofClaRecNo = item.Hofclarecno,
                            HofCstCode = item.Hofcstcode,
                            InvDate = item.Invdate,
                            InvoiceNo = item.Invoiceno,
                            InvoiceTotal = item.Invoicetotal ?? 0,
                            InvRecNo = item.Invrecno,
                            IsEdiCst = item.Isedicst > 0,
                            IsInterDept = item.Isinterdept > 0,
                            IsSeqInvNo = item.Isseqinvno == 1,
                            OffInvOnPay = item.Offinvonpay ?? 0,
                            OffInvRbt = item.Offinvrbt ?? 0,
                            OnInvDscnt = item.Oninvdscnt ?? 0,
                            PrcGlbRecNo = item.Prcglbrecno,
                            QtyTotal = item.Qtytotal ?? 0,
                            Rawhandcommamt = item.Rawhandcommamt ?? 0,
                            RawVatOnChgs = item.Rawvatonchgs ?? 0,
                            Sort1 = item.Sort1,
                            Sort2 = item.Sort2,
                            Sort3 = item.Sort3,
                            StInvTotal = item.Stinvtotal,
                            TriangReq = item.Triangreq > 0,
                            TwoVatRatesCust = item.Twovatratescust > 0,
                            Vat1Total = item.Vat1total ?? 0,
                            Vat2Total = item.Vat2total ?? 0,
                            VatCodeChgs = item.Vatcodechgs ?? 0,
                            VatRateChgs = item.Vatratechgs ?? 0,
                            VatTotal = item.Vattotal ?? 0,
                            WriteAccReChg = item.Writeaccrechg > 0,
                            InvoiceType = Enums<PreInvInvoiceType>.GetValue(item.Invoicetype),
                            BatchType = Enums<PreInvBatchType>.GetValue(item.Batchtype)
                        };

                    invTot.VatInfo.Add //At least single (with possibly 0 key) item is always in the list
                        (item.Cde1 ?? 0,
                            new DTOInvTotVatInfo
                            {
                                Cde = item.Cde1 ?? 0,
                                AvaVeaRec = item.Avavearec1,
                                Gds = item.Gds1 ?? 0,
                                EuroGds = item.Eurogds1 ?? 0,
                                BaseGds = item.Basegds1 ?? 0,
                                VatLnkRecNo = item.Vatlnkrecno1,

                                Rte = item.Rte1 ?? 0,
                                Vat = item.Vat1 ?? 0,
                                EuroVat = item.Eurovat1 ?? 0,
                                BaseVat = item.Basevat1 ?? 0,

                                Rte2 = item.Rte12 ?? 0,
                                Vat2 = item.Vat12 ?? 0,
                                EuroVat2 = item.Eurovat12 ?? 0,
                                BaseVat2 = item.Basevat12 ?? 0
                            }
                        );

                    if (item.Cde2.HasValue && item.Cde2.Value != 0)
                    {
                        invTot.VatInfo.Add
                            (item.Cde2.Value,
                                new DTOInvTotVatInfo
                                {
                                    Cde = item.Cde2.Value,
                                    AvaVeaRec = item.Avavearec2,
                                    Gds = item.Gds2 ?? 0,
                                    EuroGds = item.Eurogds2 ?? 0,
                                    BaseGds = item.Basegds2 ?? 0,
                                    VatLnkRecNo = item.Vatlnkrecno2,

                                    Rte = item.Rte2 ?? 0,
                                    Vat = item.Vat2 ?? 0,
                                    EuroVat = item.Eurovat2 ?? 0,
                                    BaseVat = item.Basevat2 ?? 0,

                                    Rte2 = item.Rte22 ?? 0,
                                    Vat2 = item.Vat22 ?? 0,
                                    EuroVat2 = item.Eurovat22 ?? 0,
                                    BaseVat2 = item.Basevat22 ?? 0
                                }
                            );
                    }

                    if (item.Cde3.HasValue && item.Cde3.Value != 0)
                    {
                        invTot.VatInfo.Add
                            (item.Cde3.Value,
                                new DTOInvTotVatInfo
                                {
                                    Cde = item.Cde3.Value,
                                    AvaVeaRec = item.Avavearec3,
                                    Gds = item.Gds3 ?? 0,
                                    EuroGds = item.Eurogds3 ?? 0,
                                    BaseGds = item.Basegds3 ?? 0,
                                    VatLnkRecNo = item.Vatlnkrecno3,

                                    Rte = item.Rte3 ?? 0,
                                    Vat = item.Vat3 ?? 0,
                                    EuroVat = item.Eurovat3 ?? 0,
                                    BaseVat = item.Basevat3 ?? 0,

                                    Rte2 = item.Rte32 ?? 0,
                                    Vat2 = item.Vat32 ?? 0,
                                    EuroVat2 = item.Eurovat32 ?? 0,
                                    BaseVat2 = item.Basevat32 ?? 0
                                }
                            );
                    }

                    data.Add(invTot);
                }
            }

            return data;
        }

        public List<DTOInvTot> GetInvTotByExtractionSessionId(int extractionSessionId, List<string> invoiceList)
        {
            return GetDataInChunksCustom
                           (
                                i =>
                                GetData
                                (
                                    new List<ISearchField>
                                    {
                                        new SearchFieldGeneric<DTOInvTot, int>(k => k.ExtractSessionID).Apply(extractionSessionId, FieldType.Integer),
                                        new SearchFieldGeneric<DTOInvTot, string>(k => k.InvoiceNo).Apply(i, FieldType.List)
                                    },
                                    CachingStrategy.NoCache
                                ),
                               invoiceList
                           );
        }

        public void DeleteByExtractSessionID(int extractSessionID)
        {
            string sqlQuery = string.Format(_sqlDeleteQuery, extractSessionID);
            UnitOfWorkCurrent.Execute(sqlQuery);
        }
    }
}
