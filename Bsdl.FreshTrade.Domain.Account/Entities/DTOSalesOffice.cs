using Bsdl.FreshTrade.Domain.Account.Exceptions;
using Bsdl.FreshTrade.Domain.Account.Interfaces;

namespace Bsdl.FreshTrade.Domain.Account.Entities
{
    public class DTOSalesOffice : IDTOSalesOffice
    {
        public const int IncludeAllSalesOfficesNo = -32000;
        internal static decimal MinSalesOfficeId = 1;
        internal static decimal MaxSalesOfficeId = 32767;

        private int _salesOfficeNumber;

        public static int GetUnsignedSalesOfficeNumber(int salesOfficeNo)
        {
            if (salesOfficeNo == IncludeAllSalesOfficesNo)
            {
                return 0;
            }
            return salesOfficeNo;
        }

        public static int? GetUnsignedSalesOfficeNumber(int? salesOfficeNo)
        {
            if (!salesOfficeNo.HasValue)
            {
                return null;
            }
            return GetUnsignedSalesOfficeNumber(salesOfficeNo.Value);
        }

        public static void ValidateSalesOfficeNumber(int salesOfficeNo)
        {
            if (
                    (salesOfficeNo < MinSalesOfficeId || salesOfficeNo > MaxSalesOfficeId) && 
                    (salesOfficeNo != IncludeAllSalesOfficesNo)
               )
            {
                throw new SalesOfficeIdInvalidValueException(salesOfficeNo);
            }
        }

        public int SalesOfficeNumber
        {
            get
            {
                return _salesOfficeNumber;
            }
            set
            {
                ValidateSalesOfficeNumber(value);
                _salesOfficeNumber = value;
            }
        }

        public string SalesOfficeDescription { get; set; }

        public string SalesOfficeCode { get; set; }

        public int? SalesOfficeBusinessUnitNumber { get; set; }

        public int? NextInvoiceNo { get; set; }

        public int? NextCreditNoteNo { get; set; }

        public int? LastBatchNo { get; set; }

        public int? LastInvoiceBatchNo { get; set; }

        public int? LastCreditBatchNo { get; set; }

        public int? LastDebitBatchNo { get; set; }

        public string SalesOfficeCompanyName { get; set; }

        public string SalesOfficeCompanyAddress1 { get; set; }

        public string SalesOfficeCompanyAddress2 { get; set; }

        public string SalesOfficeCompanyAddress3 { get; set; }

        public string SalesOfficeCompanyAddress4 { get; set; }

        public string SalesOfficeCompanyVatNo { get; set; }

        public string SalesOfficeCompanyPhoneNo { get; set; }

        public string SalesOfficeCompanyFaxNo { get; set; }

        public string SalesOfficeCompanyAnaNo { get; set; }

        public int? AccountingSalesOfficeNo { get; set; }

        public bool TaxDateBeforeDeliveryDate { get; set; }

        public bool LastPreInvUpdateOK { get; set; }

        public bool UseSequentialInvoiceNos { get; set; }
        
        public bool InUse { get; set; }

        public int? InvoiceGenerationSessionNo { get; set; }

        public int? UsedBy { get; set; }

        public bool CanSell { get; set; }

        public bool CanAccts { get; set; }

        public bool CanChngStc { get; set; }
    }
}
