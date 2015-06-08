using System.ServiceModel;

namespace Bsdl.FreshTrade.Services.Basic.Interfaces
{
    [ServiceContract]
    public interface IErrorService
    {
        [OperationContract]
        void LogError();
    }
}