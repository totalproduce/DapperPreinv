using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using Bsdl.FreshTrade.Domain.PreInv.Entities;
using Bsdl.FreshTrade.Domain.PreInv.Enums;

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

    }
}
