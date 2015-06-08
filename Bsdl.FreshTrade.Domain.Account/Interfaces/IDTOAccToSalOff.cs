namespace Bsdl.FreshTrade.Domain.Account.Interfaces
{
    public interface IDTOAccToSalOff
    {
        decimal AcsClaRecNo { get; set; }

        decimal AcsSalOffNo { get; set; }

        decimal? AcsCanNotView { get; set; }

        decimal? AcsArCreditLimit { get; set; }

        decimal? AcsIsMainCst { get; set; }

        string AcsAccCode { get; set; }

        decimal? AccToSalBacsReq { get; set; }
    }
}