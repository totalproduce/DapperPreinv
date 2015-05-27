using Bsdl.FreshTrade.Domain.Account.Enums;

namespace Bsdl.FreshTrade.Domain.Account.Interfaces
{
    public interface IDTOAccount
    {
        int Id { get; set; }

        string Code { get; set; }

        string Name { get; set; }

        string Address1 { get; set; }

        string Address2 { get; set; }

        string Address3 { get; set; }

        string Address4 { get; set; }

        string PostCode { get; set; }

        string Telephone { get; set; }

        string Fax { get; set; }

        string Vat { get; set; }
    }
}
