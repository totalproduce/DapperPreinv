using Bsdl.FreshTrade.Domain.Account.Enums;
using Bsdl.FreshTrade.Domain.Account.Interfaces;

namespace Bsdl.FreshTrade.Domain.Account.Entities
{ // DBModel - Account
    public class DTOAccount : IDTOAccount
    {
        public DTOAccount()
        {
        }

        public int Id { get; set; } /*ClaRecNo*/

        public int AccountId { get; set; } /*AccRecNo*/

        public string Code { get; set; }

        public string Name { get; set; }

        public string Address1 { get; set; }

        public string Address2 { get; set; }

        public string Address3 { get; set; }

        public string Address4 { get; set; }

        public string PostCode { get; set; }

        public string Telephone { get; set; }

        public string Fax { get; set; }

        public string Vat { get; set; }

        public DTOAccountType Type { get; set; }

        public int? StockHoldLocation { get; set; }

        public int InvoicePeriod { get; set; }

        public DTOInvoiceType InvoiceType { get; set; }

        public int? AccountBelongsToCompanyNo { get; set; }

        public bool UseDeliveryDateAsInvoiceDate { get; set; }

        public int? HeadOfficeId { get; set; }

        public bool PartPricedInvoicesAllowed { get; set; }

        public int? GLType { get; set; }

        public bool PODRequired { get; set; }

        public int? CountryNo { get; set; }

        public int? CustomerVatType { get; set; }

        public int? AccArAutoAllocCdts { get; set; }

        public bool IsTwoVatRatesCustomer { get; set; }

        public string ANANumber { get; set; }

        public bool IsApplyCompaundVatSale { get; set; }

        public int? AccLanguage { get; set; }

        public int AcsSalOffNo { get; set; } // need to filter on this field

    }
}
