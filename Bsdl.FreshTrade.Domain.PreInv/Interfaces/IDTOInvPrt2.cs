
using Bsdl.FreshTrade.Domain.PreInv.Enums;

namespace Bsdl.FreshTrade.Domain.PreInv.Interfaces
{
    public interface IDTOInvPrt2
    {

        int ExtractSessionID { get; set; }



        int? AllocToInvRecNo { get; set; }



        bool AllowOneLineCancel { get; set; }



        decimal Basecommamt { get; set; }



        decimal BaseGds { get; set; }



        decimal Basehandamt { get; set; }



        decimal BaseOffInvRbt { get; set; }



        decimal BaseOffOnPay { get; set; }



        decimal BaseOnInvDscnt { get; set; }



        decimal BaseVat { get; set; }



        decimal BaseVat1Total { get; set; }



        decimal BaseVat2Total { get; set; }



        int? Basevatonchgs { get; set; }



        bool CancelledLine { get; set; }



        decimal Commperc { get; set; }



        int? DelCdsRefNo { get; set; }



        string DelCltPrdNo { get; set; }



        DTODeliveryPriceStatus? DelInvStatus { get; set; }



        bool DelPrcByWgt { get; set; }



        int? DelPrcPrdNo { get; set; }



        decimal DelPrice { get; set; }



        int? DelQty { get; set; }



        int? DelRecNo { get; set; }



        decimal DelWeight { get; set; }



        string DetAllocNo { get; set; }



        int? DiscToQty { get; set; }



        string Dispcnt { get; set; }



        string InvoiceNo { get; set; }



        int? DlvOrdNo { get; set; }



        int? DprRecNo { get; set; }



        decimal Eurocommamt { get; set; }



        decimal EuroGds { get; set; }



        decimal Eurohandamt { get; set; }



        decimal EuroOffInvRbt { get; set; }



        decimal EuroOffOnPay { get; set; }



        decimal EuroOnInvDscnt { get; set; }



        decimal EuroVat { get; set; }



        decimal EuroVat1Total { get; set; }



        decimal EuroVat2Total { get; set; }



        decimal Eurovatonchgs { get; set; }



        decimal Ext { get; set; }



        decimal Goods { get; set; }



        decimal GrossWgt { get; set; }



        decimal Handrate { get; set; }



        decimal NettWgt { get; set; }



        decimal OffInvOnPay { get; set; }



        decimal OffInvRbt { get; set; }



        decimal OnInvDisPcnt { get; set; }



        decimal OnInvDscnt { get; set; }



        int? PpcNo { get; set; }



        string PrcPrdRef { get; set; }



        string PrdDesc { get; set; }



        int? PrdGlAnl { get; set; }



        string PrdRecDesc { get; set; }



        int? PrgRefNo { get; set; }



        decimal PrtQty { get; set; }



        decimal Rawcommamt { get; set; }



        decimal Rawhandamt { get; set; }



        decimal Rawvatonchgs { get; set; }



        int? Recno { get; set; }



        decimal TareWgt { get; set; }



        string TradedUnit { get; set; }



        int? UnitCount { get; set; }



        string UnitMeasure { get; set; }



        decimal Vat { get; set; }



        decimal Vat1Total { get; set; }



        decimal Vat2Total { get; set; }



        decimal Vatcodechgs { get; set; }



        int? VatLnkRecNo { get; set; }



        decimal Vatratechgs { get; set; }



        int? VatRecNo { get; set; }



        decimal VatVatRate { get; set; }



        decimal VatVatRate2 { get; set; }



        int? VatVeaRecNo { get; set; }


        bool Cancel { get; set; }
    }
}
