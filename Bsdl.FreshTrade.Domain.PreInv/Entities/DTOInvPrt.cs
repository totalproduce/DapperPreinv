using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using Bsdl.FreshTrade.Domain.Account.Enums;

namespace Bsdl.FreshTrade.Domain.PreInv.Entities
{
    [DataContract]
    public class DTOInvPrt
    {
        [DataMember]
        public int ExtractSessionID { get; set; }

        [DataMember]
        public bool CancelledDlv { get; set; }


        [DataMember]
        public string CurDesc { get; set; }


        [DataMember]
        public int? DelClaRecNo { get; set; }


        [DataMember]
        public int? DltRecNo { get; set; }


        [DataMember]
        public DateTime? DlvDelDate { get; set; }


        [DataMember]
        public string DlvInvoiceNo { get; set; }


        [DataMember]
        public int? DlvOrdNo { get; set; }


        [DataMember]
        public string DlvPODNo { get; set; }


        [DataMember]
        public int? DlvPrgHedNo { get; set; }


        [DataMember]
        public int? DlvSalOffNo { get; set; }


        [DataMember]
        public DateTime? DlvShpDate { get; set; }


        [DataMember]
        public int? HofClaRecNo { get; set; }


        [DataMember]
        public string HofCstCode { get; set; }


        [DataMember]
        public DateTime? InvDate { get; set; }


        [DataMember]
        public DTOInvoiceType InvoiceType { get; set; }


        [DataMember]
        public bool IsEdiPrg { get; set; }


        [DataMember]
        public string OrdCstCode { get; set; }


        [DataMember]
        public string OrdCustOrdNo { get; set; }


        [DataMember]
        public DateTime? OrdDate { get; set; }


        [DataMember]
        public int? OrdRecNo { get; set; }


        [DataMember]
        public int? OrdSmnNo { get; set; }


        [DataMember]
        public int? PrcGlbRecNo { get; set; }


        [DataMember]
        public string SalOffDesc { get; set; }


        [DataMember]
        public string Sort1 { get; set; }


        [DataMember]
        public string Sort2 { get; set; }


        [DataMember]
        public string Vatable { get; set; }

        [DataMember]
        public bool Cancel { get; set; }

        // Fields for calculation, No Persistence, to clarify
        /*
        public int DelPrcPrdNo { get; set; }

        public string MergePrdNo { get; set; }

        public decimal DelPrice { get; set; }

        public decimal DelWeight { get; set; }

        public int DelQty { get; set; }
         */ 
    }

}
