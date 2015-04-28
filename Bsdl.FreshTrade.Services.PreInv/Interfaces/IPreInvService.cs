using Bsdl.FreshTrade.Domain.PreInv.Entities;
using Bsdl.FreshTrade.Domain.PreInv.Enums;
using System.Collections.Generic;
using System.ServiceModel;

namespace Bsdl.FreshTrade.Services.PreInv.Interfaces
{
    [ServiceContract(SessionMode = SessionMode.Required)]
    public interface IPreInvService
    {
        [OperationContract]
        DTOPreInvExtractResult Extract(DTOPreInvExtractParams extractParams);

        [OperationContract]
        int? GetProgress();

        [OperationContract]
        Dictionary<string, string> PrepareForPrint(DTOPreInvUpdateParams updateParams);

        [OperationContract]
        PreInvUpdateStatusType Update(DTOPreInvUpdateParams updateParams);

        [OperationContract]
        void CleanUp();

        [OperationContract]
        string GetExportData(DTOPreInvUpdateParams updateParams);

        //Reports Business Service methods
        object GetErrorsReportData(Dictionary<string, string> parameters);

        object GetSummaryReportData(Dictionary<string, string> parameters);

        object GetDetailReportData(Dictionary<string, string> parameters);

    }
}
