using System.Collections.Generic;

namespace Bsdl.FreshTrade.Services.ReportingDX.Interfaces
{
    public interface IReportsDataProvider
    {
        object GetData(ReportConfiguration configuration, Dictionary<string, string> reportParams);
    }
}
