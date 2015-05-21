
namespace Bsdl.FreshTrade.Domain.Account.Entities
{
    public class DTOGLBrakedOn
    {

        //GlbGlxrCode
        public string CrossRefCode { get; set; }

        //GlbRecNo
        public int RecNo { get; set; }

        public int? SalesOfficeNo { get; set; }

        //GlbAccIndNo
        public int? AccountGLType { get; set; }

        //GlbPrdLnkNo
        public int? ProductLinkNo { get; set; }

        //GlbDisGLRecNo
        public int? DiscountRebateGLGroup { get; set; }

        //GlbVatRecNo
        public int? VatRecNo { get; set; }

        //GlbVatTypeNo
        public int? VatTypeNo { get; set; }

        public int GlbGanRec { get; set; }

        //public int? GLCodeId { get; set; }
    }
}
