using System.Collections.Generic;

namespace Bsdl.FreshTrade.Services.PreInv.Model.Reports
{
    public class DetailReportItem
    {
        public PreInvExtractHeader ExtractHeader { get; set; }
        public string LogonName { get; set; }
        public IList<DetailReportTotalData> InvTotList { get; set; }
    }

    public class DetailReportTotalData
    {
        public PreInvTot InvTot { get; set; }
        public IList<DetailReportInvPrtData> InvPrtList { get; set; }
    }

    public class DetailReportInvPrtData
    {
        public PreInvPrt InvPrt { get; set; }
        public IList<PreInvPrt2> InvPrt2List { get; set; }
    }

    public class DetailReportItemsList : List<DetailReportItem> {}
}
