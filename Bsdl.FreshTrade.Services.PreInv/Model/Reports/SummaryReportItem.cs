using System.Collections.Generic;

namespace Bsdl.FreshTrade.Services.PreInv.Model.Reports
{
    public class SummaryReportItem
    {
        public PreInvExtractHeader ExtractHeader { get; set; }
        public string LogonName { get; set; }
        public IList<PreInvTot> InvTot { get; set; }
    }

    public class SummaryReportItemList: List<SummaryReportItem>
    {}
}
