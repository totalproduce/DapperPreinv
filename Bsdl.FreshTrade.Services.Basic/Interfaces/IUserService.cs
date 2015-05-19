using System.ServiceModel;
using Bsdl.FreshTrade.Domain.Basic.Entities;
using Bsdl.FreshTrade.Domain.Basic.Interfaces;

namespace Bsdl.FreshTrade.Services.Basic.Interfaces
{
    [ServiceContract(SessionMode = SessionMode.Required)]
    public interface IUserService
    {
        [OperationContract(IsInitiating = true)]
        [ServiceKnownType(typeof(DTOUser))]
        IDTOUser AuthenticateUser(string userName, int dbID);

        [OperationContract(IsInitiating = false)]
        [ServiceKnownType(typeof(DTOUser))]
        IDTOUser GetUser(string userName);

        [OperationContract]
        void Ping();
    }
}
