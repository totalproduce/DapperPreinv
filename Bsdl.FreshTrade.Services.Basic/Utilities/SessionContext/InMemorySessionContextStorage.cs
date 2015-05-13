using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace Bsdl.FreshTrade.Services.Basic.Utilities.SessionContext
{
    public class InMemorySessionContextStorage
    {
        public class InMemorySessionContextItem
        {
            private readonly object _lock = new object();
            private DateTime _lastAccessTime;

            public DateTime LastAccessTime
            { 
                get
                {
                    lock (_lock)
                    {
                        return _lastAccessTime;
                    }
                }
                set
                {
                    lock (_lock)
                    {
                        _lastAccessTime = value;
                    }
                } 
            }


            public object Payload { get; set; }
        }

        private const int _sessionContextTimeoutPeriodSec = 30*60; //30 minutes
        private static readonly ReaderWriterLockSlim _storageLock = new ReaderWriterLockSlim();
        private static Dictionary<string, InMemorySessionContextItem> _storage = new Dictionary<string, InMemorySessionContextItem>();

        #region Helpers
        private static void CleanupSessions()
        {
            //Can be optimized later - if required. Now it is only a quick draft
            DateTime oldestAllowedAccessTime = DateTime.Now.AddSeconds(-1*_sessionContextTimeoutPeriodSec);
            
            _storageLock.EnterWriteLock();
            try
            {
                var sessionContextsToDelete = 
                    _storage
                        .Where(i => i.Value.LastAccessTime < oldestAllowedAccessTime)
                        .Select(i => i.Key)
                        .ToList();

                foreach (var id in sessionContextsToDelete)
                {
                    _storage.Remove(id);
                }
            }
            finally
            {
                _storageLock.ExitWriteLock();
            }
        }

        public static object GetSessionContextInternal(string sessionId)
        {
            InMemorySessionContextItem sessionContext;
            if (!_storage.TryGetValue(sessionId, out sessionContext))
            {
                return null;
            }
            sessionContext.LastAccessTime = DateTime.Now;
            return sessionContext.Payload;
        }
        #endregion

        public static object GetSessionContext(string sessionId)
        {
            _storageLock.EnterReadLock();
            try
            {
                return GetSessionContextInternal(sessionId);
            }
            finally
            {
                _storageLock.ExitReadLock();
            }
        }

        public static void SetSessionContext(string sessionId, object sessionContext)
        {
            CleanupSessions();
            _storageLock.EnterWriteLock();
            try
            {
                _storage.Add
                (
                    sessionId, 
                    new InMemorySessionContextItem { LastAccessTime = DateTime.Now, Payload = sessionContext }
                );
            }
            finally
            {
                _storageLock.ExitWriteLock();
            }
        }

        public static void UpdateSessionContext(string sessionId, Action<object> modifyAction)
        {
            CleanupSessions();
            _storageLock.EnterWriteLock();
            try
            {
                modifyAction(GetSessionContextInternal(sessionId));
            }
            finally
            {
                _storageLock.ExitWriteLock();
            }
        }

    }
}
