using Bsdl.FreshTrade.Domain.Basic.Interfaces;
using Bsdl.FreshTrade.Repositories.Basic.Interfaces;
using Bsdl.FreshTrade.Server.Basic.Interfaces;
using Bsdl.FreshTrade.Server.Basic.Logger;
using Bsdl.FreshTrade.Services.Basic.Interfaces;
using Bsdl.FreshTrade.Services.Basic.Utilities.SessionContext;
using System;
using System.ServiceModel.Web;
using System.Web;

namespace Bsdl.FreshTrade.Services.Basic.Users
{
    public class UserService : FreshTradeServiceBase, IUserService
    {        
        private IUserRepository _userRepository;
        protected IUserRepository UserRepository
        {
            get
            {
                if (_userRepository == null)
                {
                    _userRepository = UnitOfWorkCurrent.GetRepository<IUserRepository>();
                }
                return _userRepository;
            }
        }

        private readonly IEventsLogger _eventsLogger;
        private static readonly ILogger Logger = LogManager.GetLoggerFor<UserService>();


        #region Helpers
        private void InitializeUserSession(int dbID, IDTOUser user)
        {
            InMemorySessionContextStorage.SetSessionContext
            (
                GetUserSessionID(), //OperationContext.Current.SessionId,
                new SessionContext { DbID = dbID, FreshTradeUser = user }
            );
        }

        private void SetSessionIDCookie()
        {
            if (WebOperationContext.Current != null)
            {
                WebOperationContext.Current.OutgoingResponse.Headers.Add
                (
                    "Cookie", // Set-Cookie command does not make to the client (W8,IIS8,VS2013)
                    string.Format("ASP.NET_SessionId={0}", GetUserSessionID())
                );
            }
        }

        private IDTOUser GetUserInternal(string userName, int dbID)
        {
            if (string.IsNullOrWhiteSpace(userName))
            {
                return null;
            }

            CreateUnitOfWork(dbID);

            return UserRepository.GetUserByLogonName(dbID, userName);
        }

        #endregion

        public UserService(IEventsLogger logger, IRepositoryFactory repositoryFactory)
            : base(repositoryFactory)
        {
            _eventsLogger = logger;
        }

        public IDTOUser AuthenticateUser(string userName, int dbID)
        {
            //Logger.Info(String.Format(" -> Trying to authenticate user {0} against dbID {1}",userName,dbID));
            if (string.IsNullOrWhiteSpace(userName))
            {
                return null;
            }

            var user = GetUserInternal(userName, dbID);
            if (user == null)
            {
                return null;
            }

            if (!user.Active)
            {
                return null;
            }

            InitializeUserSession(dbID, user);
            SetSessionIDCookie();
            //Logger.Info(String.Format(" <- Authenticated {0} against dbID {1}", userName, dbID));
            return user;
        }

        public IDTOUser GetUser(string userName)
        {
            return GetUserInternal(userName, UserDbID);
        }


        public void Ping()
        {
            InMemorySessionContextStorage.GetSessionContext(GetUserSessionID()); //Just to refresh LastAccessTime;
        }
    }
}
