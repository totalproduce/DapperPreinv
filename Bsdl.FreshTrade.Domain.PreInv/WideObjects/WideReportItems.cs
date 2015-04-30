
using System;

namespace Bsdl.FreshTrade.Domain.PreInv.WideObjects
{
    public class WideErrorReportItem
    {
        public int LogRecNo { get; set; }
        public string ErrReason { get; set; }
        public string OrdCstCode { get; set; }
        public string OrdCustOrdNo { get; set; }
        public int DlvOrdNo { get; set; }
        public int ErrIsCritical { get; set; }
        public int ExtractSessionID { get; set; }
    }

    public class WideSummaryReportItem
    {
        public int ExtractSessionID { get; set; }

        public string Sort1 { get; set; }
        public string InvoiceNo { get; set; }
        public int BatchNo { get; set; }
        public int InvoiceType { get; set; }
        public int BatchType { get; set; }
        public string InvoiceTypeAsStr { get; set; }
        public string BatchTypeAsStr { get; set; }
        public string HofCstCode { get; set; }
        public int QtyTotal { get; set; }
        public decimal GoodsTotal { get; set; }
        public decimal VatTotal { get; set; }
        public decimal OnInvDscnt { get; set; }
        public decimal RawHandCommAmt { get; set; }
        public decimal RawVatOnChgs { get; set; }
        public decimal Rebate { get; set; }
        public decimal InvoiceTotal { get; set; }
        public string CurDesc { get; set; }
    }

    public class WideDetailReportItem
    {
        public int ExtractSessionID { get; set; }

        public string Sort1 { get; set; }
        public string InvoiceNo { get; set; }
        public int BatchNo { get; set; }
        public int InvoiceType { get; set; }
        public int BatchType { get; set; }
        public string InvoiceTypeAsStr { get; set; }
        public string BatchTypeAsStr { get; set; }
        public string HofCstCode { get; set; }
        public int QtyTotal { get; set; }
        public decimal GoodsTotal { get; set; }
        public decimal VatTotal { get; set; }
        public decimal OnInvDscntTotal { get; set; }
        public decimal OffInvRbt { get; set; }
        public decimal OffInvOnPay { get; set; }
        public decimal Rebate { get; set; }
        public decimal InvoiceTotal { get; set; }
        public decimal RawHandCommAmt { get; set; }
        public decimal RawVatOnChgsTotal { get; set; }
        public string CurDesc { get; set; }
        public decimal S1TotQtytotal { get; set; }
        public decimal S1TotGoodsTotal { get; set; }
        public decimal S1TotVatTotal { get; set; }
        public decimal S1TotOnInvDscntTotal { get; set; }
        public decimal S1TotRebate { get; set; }
        public decimal S1TotInvoiceTotal { get; set; }
        public decimal S1TotRawHandCommAmt { get; set; }
        public decimal S1TotRawVatOnChgsTotal { get; set; }
        public decimal GtotQtyTotal { get; set; }
        public decimal GtotGoodstotal { get; set; }
        public decimal GtotVattotal { get; set; }
        public decimal GtotOninvdscnttotal { get; set; }
        public decimal GtotRebate { get; set; }
        public decimal GtotInvoicetotal { get; set; }
        public decimal GTotRawHandCommAmt { get; set; }
        public decimal GTotRawVatOnChgsTotal { get; set; }
        public string DlvInvoiceNo { get; set; }
        public string DlvOrdNo { get; set; }
        public DateTime DlvDelDate { get; set; }
        public string DlvPrgHedNo { get; set; }
        public string DlvPodNo { get; set; }
        public string OrdCustOrdNo { get; set; }
        public int DelQty { get; set; }
        public decimal DelPrice { get; set; }
        public decimal Goods { get; set; }
        public decimal Vat { get; set; }
        public decimal OnInvDscnt { get; set; }
        public decimal PrcPrdRef { get; set; }
        public string PrdRecDesc { get; set; }
        public decimal RawHandAmt { get; set; }
        public decimal RawCommAmt { get; set; }
        public decimal CommHandAmt { get; set; }
        public decimal RawVatOnChgs { get; set; }
        public string UnitMeasure { get; set; }
    }

}
