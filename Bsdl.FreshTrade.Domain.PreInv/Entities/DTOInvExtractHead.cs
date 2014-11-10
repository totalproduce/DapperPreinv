using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Bsdl.FreshTrade.Domain.PreInv.Enums;

namespace Bsdl.FreshTrade.Domain.PreInv.Entities
{
    public class DTOInvExtractHead
    {
        public int ExtractSessionId { get; set; }

        public int UserId { get; set; }
        public int SalesOfficeNo { get; set; }
        public string SalesOfficeName { get; set; }
        public PreInvInvoiceType InvoiceType { get; set; }
        public string InvoiceTypeName { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime CutOffDeliveryDate { get; set; }
        public DateTime TaxPointDate { get; set; }
        public PreInvInvoicePeriodType InvoicePeriod { get; set; }
        public string InvoicePeriodAsStr { get; set; }
        public string InvoiceOrderType { get; set; }
        public bool IsInterCompanyTransfer { get; set; }
        public int CompanyNo { get; set; }
        public int LastInvoiceNo { get; set; }
    }
}
