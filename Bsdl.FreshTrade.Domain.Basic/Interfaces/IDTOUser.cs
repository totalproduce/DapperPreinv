namespace Bsdl.FreshTrade.Domain.Basic.Interfaces
{
    public interface IDTOUser
    {
        int Id { get; set; }

        string UserName { get; set; }

        string Name { get; set; }

        int LanguageNumber { get; set; }

        bool Active { get; set; }

        bool AllSalesOffices { get; set; }
    }
}
