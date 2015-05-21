using Bsdl.FreshTrade.Repositories.Basic.Interfaces;
using Bsdl.FreshTrade.Server.Basic.Interfaces;
using Bsdl.FreshTrade.Services.Basic.Interfaces;

namespace Bsdl.FreshTrade.Services.Basic.Errors
{
    public class ErrorService : FreshTradeServiceBase, IErrorService
    {
        private readonly IErrorLogRepository _errorRepository;
        public ErrorService(IErrorLogRepository errorRepository, IRepositoryFactory repositoryFactory)
            : base(repositoryFactory)
        {
            _errorRepository = errorRepository;
        }

        public void LogError()
        {
            _errorRepository.Add();
        }
    }
}
