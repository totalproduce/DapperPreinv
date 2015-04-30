using Bsdl.FreshTrade.Domain.Account.Interfaces;

namespace Bsdl.FreshTrade.Domain.Account.Entities
{
    public class DTOAccToSalOff : IDTOAccToSalOff 
    {
        public DTOAccToSalOff()
        {
        }

        public DTOAccToSalOff(decimal acsClaRecNo, decimal acsSalOffNo, decimal? acsCanNotView, decimal? acsArCreditLimit, decimal? acsIsMainCst, string acsAccCode, decimal? accToSalBacsReq)
        {
            this.AcsClaRecNo = acsClaRecNo;
            this.AcsSalOffNo = acsSalOffNo;
            this.AcsCanNotView = acsCanNotView;
            this.AcsArCreditLimit = acsArCreditLimit;
            this.AcsIsMainCst = acsIsMainCst;
            this.AcsAccCode = acsAccCode;
            this.AccToSalBacsReq = accToSalBacsReq;
        }

        public decimal AcsClaRecNo { get; set; }

        public decimal AcsSalOffNo { get; set; }

        public decimal? AcsCanNotView { get; set; }

        public decimal? AcsArCreditLimit { get; set; }

        public decimal? AcsIsMainCst { get; set; }

        public string AcsAccCode { get; set; }

        public decimal? AccToSalBacsReq { get; set; }
    }
}
