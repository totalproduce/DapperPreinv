namespace Bsdl.FreshTrade.Domain.Account.Interfaces
{
    public interface IDTOSalesOffice
    {
        int SalesOfficeNumber { get; set; }

        string SalesOfficeDescription { get; set; }

        string SalesOfficeCode { get; set; }

        int? SalesOfficeBusinessUnitNumber { get; set; }

        int? NextInvoiceNo { get; set; }

        int? NextCreditNoteNo { get; set; }

        int? LastBatchNo { get; set; }

        int? LastInvoiceBatchNo { get; set; }

        int? LastCreditBatchNo { get; set; }

        string SalesOfficeCompanyName { get; set; }

        string SalesOfficeCompanyAddress1 { get; set; }

        string SalesOfficeCompanyAddress2 { get; set; }

        string SalesOfficeCompanyAddress3 { get; set; }

        string SalesOfficeCompanyAddress4 { get; set; }

        string SalesOfficeCompanyVatNo { get; set; }

        string SalesOfficeCompanyPhoneNo { get; set; }

        string SalesOfficeCompanyFaxNo { get; set; }

        string SalesOfficeCompanyAnaNo { get; set; }

        int? AccountingSalesOfficeNo { get; set; }

        bool TaxDateBeforeDeliveryDate { get; set; }
        
        bool LastPreInvUpdateOK { get; set; }

        bool InUse { get; set; }
        
        int? UsedBy { get; set; }

        bool CanSell { get; set; }

        bool CanAccts { get; set; }

        bool CanChngStc { get; set; }

    }
}
