using System;
using Bsdl.FreshTrade.Domain.PreInv.Enums;

namespace Bsdl.FreshTrade.Services.PreInv.Model.Reports
{
    public class PreInvTot
    {
        /// <summary> Extractsessionid </summary>
        public virtual int ExtractSessionId { get; set; }

        /// <summary> Sort1 </summary>
        public virtual string Sort1 { get; set; }
        /// <summary> Invoiceno </summary>
        public virtual string InvoiceNo { get; set; }
        /// <summary> Batchno </summary>
        public virtual int BatchNo { get; set; }
        /// <summary> Invoicetype </summary>
        public virtual PreInvInvoiceType InvoiceType { get; set; }
        /// <summary> Batchtype </summary>
        public virtual PreInvBatchType BatchType { get; set; }

        /// <summary> Hofcstcode </summary>
        public virtual string HofCstCode { get; set; }
        /// <summary> Qtytotal </summary>
        public virtual int QtyTotal { get; set; }
        /// <summary> Goodstotal </summary>
        public virtual decimal GoodsTotal { get; set; }
        /// <summary> Vattotal </summary>
        public virtual decimal VatTotal { get; set; }
        /// <summary> Oninvdscnt </summary>
        public virtual decimal OnInvDscnt { get; set; }
        /// <summary> Rawhandcommamt </summary>
        public virtual decimal RawHandCommAmt { get; set; }
        /// <summary> Rawvatonchgs </summary>
        public virtual decimal RawVatOnChgs { get; set; }

        /// <summary> Invoicetotal </summary>
        public virtual decimal InvoiceTotal { get; set; }
        /// <summary> Curdesc </summary>
        public virtual string CurDesc { get; set; }

        ///// <summary> Accglanl </summary>
        //public virtual int AccGlAnl { get; set; }
        ///// <summary> Accntsaloffno </summary>
        //public virtual int AccntSalOffNo { get; set; }
        ///// <summary> Basegdstotal </summary>
        //public virtual decimal BaseGdsTotal { get; set; }
        ///// <summary> Basehandcommamt </summary>
        //public virtual decimal BaseHandCommAmt { get; set; }
        ///// <summary> Baseoffinvonpay </summary>
        //public virtual decimal BaseOffInvOnPay { get; set; }
        ///// <summary> Baseoffinvrbt </summary>
        //public virtual decimal BaseOffInvRbt { get; set; }
        ///// <summary> Baseoninvdscnt </summary>
        //public virtual decimal BaseOnInvDscnt { get; set; }
        ///// <summary> Baserate </summary>
        //public virtual decimal BaseRate { get; set; }
        ///// <summary> Basevatonchgs </summary>
        //public virtual decimal BaseVatOnChgs { get; set; }
        ///// <summary> Basevattotal </summary>
        //public virtual decimal BaseVatTotal { get; set; }
        ///// <summary> Cancelledinv </summary>
        //public virtual bool? CancelledInv { get; set; }
        ///// <summary> Companyname </summary>
        //public virtual string CompanyName { get; set; }
        ///// <summary> Compoundvatcust </summary>
        //public virtual bool? CompoundVatCust { get; set; }
        ///// <summary> Curno </summary>
        //public virtual int? CurNo { get; set; }
        ///// <summary> Eiinvoiceid </summary>
        //public virtual int? EIInvoiceId { get; set; }
        ///// <summary> Eurogdstotal </summary>
        //public virtual decimal EuroGdsTotal { get; set; }
        ///// <summary> Eurohandcommamt </summary>
        //public virtual decimal EuroHandCommAmt { get; set; }
        ///// <summary> Eurooffinvonpay </summary>
        //public virtual decimal EuroOffInvOnPay { get; set; }
        ///// <summary> Eurooffinvrbt </summary>
        //public virtual decimal EuroOffInvRbt { get; set; }
        ///// <summary> Eurooninvdscnt </summary>
        //public virtual decimal EuroOnInvDscnt { get; set; }
        ///// <summary> Eurorate </summary>
        //public virtual decimal EuroRate { get; set; }
        ///// <summary> Eurovatonchgs </summary>
        //public virtual decimal EuroVatOnChgs { get; set; }
        ///// <summary> Eurovattotal </summary>
        //public virtual decimal EuroVatTotal { get; set; }
        ///// <summary> Finfiscrep1 </summary>
        //public virtual short? FinFiscRep1 { get; set; }
        ///// <summary> Finvatdesc1 </summary>
        //public virtual string FinVatDesc1 { get; set; }
        ///// <summary> Finvatnumber1 </summary>
        //public virtual string FinVatNumber1 { get; set; }
        ///// <summary> Hofclarecno </summary>
        //public virtual int? HofClaRecNo { get; set; }
        ///// <summary> Invdate </summary>
        //public virtual DateTime? InvDate { get; set; }
        ///// <summary> Invrecno </summary>
        //public virtual int InvRecNo { get; set; }
        ///// <summary> Isedicst </summary>
        //public virtual bool? IsEdiCst { get; set; }
        ///// <summary> Isinterdept </summary>
        //public virtual bool? IsInterDept { get; set; }
        ///// <summary> Isseqinvno </summary>
        //public virtual bool? IsSeqInvNo { get; set; }
        ///// <summary> Offinvonpay </summary>
        //public virtual decimal OffInvOnPay { get; set; }
        ///// <summary> Offinvrbt </summary>
        //public virtual decimal OffInvRbt { get; set; }
        ///// <summary> Prcglbrecno </summary>
        //public virtual int PrcGlbRecNo { get; set; }
        ///// <summary> Sort2 </summary>
        //public virtual string Sort2 { get; set; }
        ///// <summary> Sort3 </summary>
        //public virtual string Sort3 { get; set; }
        ///// <summary> Stinvtotal </summary>
        //public virtual string StInvTotal { get; set; }
        ///// <summary> Triangreq </summary>
        //public virtual bool? TriangReq { get; set; }
        ///// <summary> Twovatratescust </summary>
        //public virtual bool TwoVatRatesCust { get; set; }
        ///// <summary> Vatcodechgs </summary>
        //public virtual decimal VatCodeChgs { get; set; }
        ///// <summary> Vatratechgs </summary>
        //public virtual decimal VatRateChgs { get; set; }
        ///// <summary> Writeaccrechg </summary>
        //public virtual bool? WriteAccReChg { get; set; }


        ///// <summary> Avavearec1 </summary>
        //public virtual int? AvaVeaRec1 { get; set; }
        ///// <summary> Avavearec2 </summary>
        //public virtual int? AvaVeaRec2 { get; set; }
        ///// <summary> Avavearec3 </summary>
        //public virtual int? AvaVeaRec3 { get; set; }
        ///// <summary> Basegds1 </summary>
        //public virtual decimal BaseGds1 { get; set; }
        ///// <summary> Basegds2 </summary>
        //public virtual decimal BaseGds2 { get; set; }
        ///// <summary> Basegds3 </summary>
        //public virtual decimal BaseGds3 { get; set; }
        ///// <summary> Basevat1 </summary>
        //public virtual decimal BaseVat1 { get; set; }
        ///// <summary> Basevat12 </summary>
        //public virtual decimal BaseVat12 { get; set; }
        ///// <summary> Basevat1total </summary>
        //public virtual decimal BaseVat1Total { get; set; }
        ///// <summary> Basevat2 </summary>
        //public virtual decimal BaseVat2 { get; set; }
        ///// <summary> Basevat22 </summary>
        //public virtual decimal BaseVat22 { get; set; }
        ///// <summary> Basevat2total </summary>
        //public virtual decimal BaseVat2Total { get; set; }
        ///// <summary> Basevat3 </summary>
        //public virtual decimal BaseVat3 { get; set; }
        ///// <summary> Basevat32 </summary>
        //public virtual decimal BaseVat32 { get; set; }
        ///// <summary> Cde1 </summary>
        //public virtual int Cde1 { get; set; }
        ///// <summary> Cde2 </summary>
        //public virtual int Cde2 { get; set; }
        ///// <summary> Cde3 </summary>
        //public virtual int Cde3 { get; set; }
        ///// <summary> Eurogds1 </summary>
        //public virtual decimal EuroGds1 { get; set; }
        ///// <summary> Eurogds2 </summary>
        //public virtual decimal EuroGds2 { get; set; }
        ///// <summary> Eurogds3 </summary>
        //public virtual decimal EuroGds3 { get; set; }
        ///// <summary> Eurovat1 </summary>
        //public virtual decimal EuroVat1 { get; set; }
        ///// <summary> Eurovat12 </summary>
        //public virtual decimal EuroVat12 { get; set; }
        ///// <summary> Eurovat1total </summary>
        //public virtual decimal EuroVat1Total { get; set; }
        ///// <summary> Eurovat2 </summary>
        //public virtual decimal EuroVat2 { get; set; }
        ///// <summary> Eurovat22 </summary>
        //public virtual decimal EuroVat22 { get; set; }
        ///// <summary> Eurovat2total </summary>
        //public virtual decimal EuroVat2Total { get; set; }
        ///// <summary> Eurovat3 </summary>
        //public virtual decimal EuroVat3 { get; set; }
        ///// <summary> Eurovat32 </summary>
        //public virtual decimal EuroVat32 { get; set; }
        ///// <summary> Gds1 </summary>
        //public virtual decimal Gds1 { get; set; }
        ///// <summary> Gds2 </summary>
        //public virtual decimal Gds2 { get; set; }
        ///// <summary> Gds3 </summary>
        //public virtual decimal Gds3 { get; set; }
        ///// <summary> Rte1 </summary>
        //public virtual decimal Rte1 { get; set; }
        ///// <summary> Rte12 </summary>
        //public virtual decimal Rte12 { get; set; }
        ///// <summary> Rte2 </summary>
        //public virtual decimal Rte2 { get; set; }
        ///// <summary> Rte22 </summary>
        //public virtual decimal Rte22 { get; set; }
        ///// <summary> Rte3 </summary>
        //public virtual decimal Rte3 { get; set; }
        ///// <summary> Rte32 </summary>
        //public virtual decimal Rte32 { get; set; }
        ///// <summary> Vat1 </summary>
        //public virtual decimal Vat1 { get; set; }
        ///// <summary> Vat12 </summary>
        //public virtual decimal Vat12 { get; set; }
        ///// <summary> Vat1total </summary>
        //public virtual decimal Vat1Total { get; set; }
        ///// <summary> Vat2 </summary>
        //public virtual decimal Vat2 { get; set; }
        ///// <summary> Vat22 </summary>
        //public virtual decimal Vat22 { get; set; }
        ///// <summary> Vat2total </summary>
        //public virtual decimal Vat2Total { get; set; }
        ///// <summary> Vat3 </summary>
        //public virtual decimal Vat3 { get; set; }
        ///// <summary> Vat32 </summary>
        //public virtual decimal Vat32 { get; set; }
        ///// <summary> Vatlnkrecno1 </summary>
        //public virtual int? VatLnkRecNo1 { get; set; }
        ///// <summary> Vatlnkrecno2 </summary>
        //public virtual int? VatLnkRecNo2 { get; set; }
        ///// <summary> Vatlnkrecno3 </summary>
        //public virtual int? VatLnkRecNo3 { get; set; }
    }
}
