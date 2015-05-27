using System;
using Bsdl.FreshTrade.Domain.PreInv.Enums;

namespace Bsdl.FreshTrade.Services.PreInv.Model.Reports
{
    /// <summary> PREINVTEMP_INVEXTRACTHED </summary>
    public class PreInvExtractHeader 
    {
        //Id: Extractsessionid
        public virtual int Id { get; set; }

        /// <summary> Companyno </summary>
        public virtual int CompanyNo { get; set; }
        /// <summary> Createddate </summary>
        public virtual DateTime CreatedDate { get; set; }
        /// <summary> Invoiceordertype </summary>
        public virtual string InvoiceOrderType { get; set; }
        /// <summary> Invoiceperiod </summary>
        public virtual PreInvInvoicePeriodType InvoicePeriod { get; set; }
        /// <summary> Invoiceperiodasstr </summary>
        public virtual string InvoicePeriodAsStr { get; set; }
        /// <summary> Invoicetype </summary>
        public virtual PreInvInvoiceType InvoiceType { get; set; }
        /// <summary> Invoicetypename </summary>
        public virtual string InvoiceTypeName { get; set; }
        /// <summary> Isintercompanytransfer </summary>
        public virtual bool IsInterCompanyTransfer { get; set; }
        /// <summary> Lastinvoiceno </summary>
        public virtual int LastInvoiceNo { get; set; }
        /// <summary> Logonno </summary>
        public virtual int UserId { get; set; }
        public string LogonName { get; set; }
        /// <summary> Reqdate </summary>
        public virtual DateTime CutOffDeliveryDate { get; set; }
        /// <summary> Salesofficename </summary>
        public virtual string SalesOfficeName { get; set; }
        /// <summary> Salesofficeno </summary>
        public virtual int SalesOfficeId { get; set; }
        /// <summary> Taxdate </summary>
        public virtual DateTime TaxPointDate { get; set; }

    }
}
