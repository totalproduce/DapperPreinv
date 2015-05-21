using Bsdl.FreshTrade.Domain.Basic.Interfaces;
using Bsdl.FreshTrade.Domain.PreInv.Entities;
using Bsdl.FreshTrade.Domain.PreInv.Enums;
using Bsdl.FreshTrade.Repositories.Basic.Utilities.Interfaces;
using Bsdl.FreshTrade.Services.Basic.Interfaces;

namespace Bsdl.FreshTrade.Services.PreInv.Model.Interfaces
{
    public delegate void UpdateProgressDelegate(int percentage);

    public interface IExtractionProcessor
    {
        DTOPreInvExtractResult Process(DTOPreInvExtractParams extractParams, int extractSessionID, IDTOUser user);
        void CleanUp(int? salesOfficeNo, int? extractSessionID);
        void SetProgressWatcher(UpdateProgressDelegate progressDelegate);
    }

    public interface IExtractionProcessorFactory
    {
        IExtractionProcessor GetProcessor(SystemPreferences systemPreferences, IUnitOfWork unitOfWorkCurrent, IDictionaryService dictionaryService); 
    }

    public interface IExtractionErrorsRegistry
    {
        void RegisterExtractionError(PreInvExtractionErrorTypes type);
        void RegisterExtractionError(PreInvExtractionErrorTypes type, string customerCode, string orderNo = null, int? deliveryNo = null);
    }
}
