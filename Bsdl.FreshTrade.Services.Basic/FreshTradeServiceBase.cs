using System;
using System.ServiceModel.Activation;
using System.Threading;
using System.Web;
using Bsdl.FreshTrade.Domain.Basic.Exceptions;
using Bsdl.FreshTrade.Repositories.Basic;
using Bsdl.FreshTrade.Repositories.Basic.Interfaces;
using Bsdl.FreshTrade.Repositories.Basic.Utilities.DatabaseConnection;
using Bsdl.FreshTrade.Repositories.Basic.Utilities.Interfaces;
using Bsdl.FreshTrade.Server.Basic.Interfaces;
using Bsdl.FreshTrade.Services.Basic.Interfaces;
using Bsdl.FreshTrade.Services.Basic.Utilities.Errors;
using Bsdl.FreshTrade.Services.Basic.Utilities.SessionContext;

namespace Bsdl.FreshTrade.Services.Basic
{
    [ServiceErrorBehavior(typeof(ElmahErrorHandler))]
    [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Required)]
    public class FreshTradeServiceBase : IDisposable, IFreshTradeServiceBase
    {
        private IUnitOfWork _unitOfWorkCurrent;
        private readonly IRepositoryFactory _repositoryFactory;
        private bool _disposed = false;

        #region Helpers

        protected virtual string GetUserSessionID()
        {
            return HttpContext.Current.Session.SessionID;
        }

        protected SessionContext UserSessionContext
        {
            get
            {
                return
                    (SessionContext)InMemorySessionContextStorage.GetSessionContext(GetUserSessionID());
            }
        }

        protected int UserDbID
        {
            get
            {
                var context = UserSessionContext;
                if (context == null)
                {
                    throw new UserSessionInvalidException();
                }
                return context.DbID;
            }
        }

        protected IUnitOfWork UnitOfWorkCurrent
        {
            get
            {
                if (_unitOfWorkCurrent == null)
                {
                    _unitOfWorkCurrent = new UnitOfWork(UserDbID, DatabaseConnectionPool.Instance, _repositoryFactory);
                }
                return _unitOfWorkCurrent;
            }
        }

        protected IUnitOfWork CreateUnitOfWork(int dbID)
        {
            if (_unitOfWorkCurrent != null)
            {
                throw new FreshTradeException("Unit of work already exists");
            }
            _unitOfWorkCurrent = new UnitOfWork(dbID, DatabaseConnectionPool.Instance, _repositoryFactory);
            return _unitOfWorkCurrent;
        }

        #endregion

        public void AssignUnitOfWork(IUnitOfWork unitOfWork)
        {
            if (_unitOfWorkCurrent != null)
            {
                throw new FreshTradeException("Unit of work already exists");
            }
            _unitOfWorkCurrent = unitOfWork;
        }

        public FreshTradeServiceBase(IRepositoryFactory repositoryFactory)
        {
            _repositoryFactory = repositoryFactory;
        }
        #region IDisposable implementation
        protected virtual void Dispose(bool disposing)
        {
            if (!_disposed)
            {
                if (disposing)
                {
                    if (_unitOfWorkCurrent != null)
                    {
                        ((IDisposable)_unitOfWorkCurrent).Dispose();
                    }
                }
            }
            _disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        #endregion

    }
}
