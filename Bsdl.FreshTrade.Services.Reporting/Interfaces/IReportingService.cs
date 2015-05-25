using System.Collections.Generic;
using System.ServiceModel;

namespace Bsdl.FreshTrade.Services.ReportingDX.Interfaces
{
    [ServiceContract(SessionMode = SessionMode.Required)]
    public interface IReportingService
    {
        [OperationContract]
        byte[] GetReport(string reportName, Dictionary<string, string> reportParams);
    }
}
