namespace Bsdl.FreshTrade.Domain.Basic.Interfaces
{
    public interface IDTOFreshTradeDisplayID
    {
        decimal FreshTradeDisplayUID { get; set; }

        string FreshTradeDisplayName { get; set; }

        decimal FreshTradeDisplayLanguaged { get; set; }

        string FreshTradeDisplayTitle { get; set; }

        decimal FreshTradeDisplayLevel { get; set; } //Primary, Secondary etc

        decimal FreshTradeDisplayModuleNo { get; set; }
    }
}
