using System.Data;
using Bsdl.FreshTrade.Domain.PreInv.Entities;
using Bsdl.FreshTrade.Domain.PreInv.WideObjects;
using System.Collections.Generic;
using System.ServiceModel;

namespace Bsdl.FreshTrade.Services.PreInv.Reports.Interfaces
{
    [ServiceContract(SessionMode = SessionMode.NotAllowed)]
    public interface IPreInvReportService
    {

        [OperationContract]
        List<DataTable> GenerateReport(string reportName, Dictionary<string, string> reportParams);
    }
}
