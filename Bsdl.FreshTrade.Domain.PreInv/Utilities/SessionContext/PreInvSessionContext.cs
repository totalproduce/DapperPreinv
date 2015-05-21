namespace Bsdl.FreshTrade.Domain.PreInv.Utilities.SessionContext
{
    public class PreInvSessionContext
    {
        public const string PreInvSessionName = "PreInv";

        public int? ExtractSessionID { get; set; }
        public int? SalesOfficeNo { get; set; }
        public int? ExtractionPercentage { get; set; } 
    }
}
