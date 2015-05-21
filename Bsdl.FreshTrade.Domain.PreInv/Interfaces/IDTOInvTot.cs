using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Bsdl.FreshTrade.Domain.PreInv.Entities;

namespace Bsdl.FreshTrade.Domain.PreInv.Interfaces
{
    public interface IDTOInvTot
    {


        int ExtractSessionID { get; set; }


        int? AccGlAnl { get; set; }



        int? AccntSalOffNo { get; set; }


        decimal BaseGdsTotal { get; set; }


        decimal Basehandcommamt { get; set; }



        decimal BaseOffInvOnPay { get; set; }



        decimal BaseOffInvRbt { get; set; }



        decimal BaseOnInvDscnt { get; set; }



        decimal BaseRate { get; set; }



        decimal BaseVat1Total { get; set; }



        decimal BaseVat2Total { get; set; }



        decimal BaseVatOnChgs { get; set; }



        decimal BaseVatTotal { get; set; }



        bool CancelledInv { get; set; }



        string CompanyName { get; set; }



        bool CompoundVatCust { get; set; }



        string CurDesc { get; set; }



        int? CurNo { get; set; }



        int? EIInvoiceId { get; set; }



        decimal EuroGdsTotal { get; set; }



        decimal Eurohandcommamt { get; set; }



        decimal EuroOffInvOnPay { get; set; }



        decimal EuroOffInvRbt { get; set; }



        decimal EuroOnInvDscnt { get; set; }



        decimal EuroRate { get; set; }



        decimal EuroVat1Total { get; set; }



        decimal EuroVat2Total { get; set; }



        decimal EuroVatOnChgs { get; set; }



        decimal EuroVatTotal { get; set; }



        short? Finfiscrep1 { get; set; }



        string Finvatdesc1 { get; set; }



        string Finvatnumber1 { get; set; }



        decimal GoodsTotal { get; set; }



        int? HofClaRecNo { get; set; }



        string HofCstCode { get; set; }



        DateTime? InvDate { get; set; }



        string InvoiceNo { get; set; }



        decimal InvoiceTotal { get; set; }



        int? InvRecNo { get; set; }



        bool IsEdiCst { get; set; }



        bool IsInterDept { get; set; }



        bool IsSeqInvNo { get; set; }



        decimal OffInvOnPay { get; set; }



        decimal OffInvRbt { get; set; }



        decimal OnInvDscnt { get; set; }



        int? PrcGlbRecNo { get; set; }



        int QtyTotal { get; set; }



        decimal Rawhandcommamt { get; set; }



        decimal RawVatOnChgs { get; set; }



        string Sort1 { get; set; }



        string Sort2 { get; set; }



        string Sort3 { get; set; }



        string StInvTotal { get; set; }



        bool TriangReq { get; set; }



        bool TwoVatRatesCust { get; set; }



        decimal Vat1Total { get; set; }



        decimal Vat2Total { get; set; }



        decimal VatCodeChgs { get; set; }



        decimal VatRateChgs { get; set; }



        decimal VatTotal { get; set; }



        bool WriteAccReChg { get; set; }


        bool Cancel { get; set; }

        Dictionary<int, DTOInvTotVatInfo> VatInfo { get; set; }
    }

}

