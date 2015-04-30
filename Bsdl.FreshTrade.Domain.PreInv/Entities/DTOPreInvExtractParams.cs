using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using Bsdl.FreshTrade.Domain.PreInv.Enums;

namespace Bsdl.FreshTrade.Domain.PreInv.Entities
{
    [DataContract]
    public class DTOPreInvExtractParams
    {
        [DataMember]
        public DTOPreInvExtractAccountParams AccountParams{ get; set; }

        [DataMember]
        public bool IsInterCompanyTransfer { get; set; }

        [DataMember]
        public int CompanyNo { get; set; } /*ACCOUNTS.ACCOMPRECNO NUMBER(5,0)*/

        [DataMember]
        public int CurrencyNo { get; set; }

        [DataMember]
        public DateTime CutOffDeliveryDate { get; set; }

        [DataMember]
        public DateTime TaxPointDate { get; set; }

        [DataMember]
        public PreInvInvoicePeriodType InvoicePeriodType { get; set; }

        [DataMember]
        public PreInvBatchType BatchType { get; set; }

        [DataMember]
        public PreInvInvoiceType InvoiceType { get; set; }

        [DataMember]
        public int SalesOfficeNo { get; set; }
    }
}
