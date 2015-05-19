using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Caching;
using Bsdl.FreshTrade.Repositories.Basic.Utilities.Interfaces;

namespace Bsdl.FreshTrade.Repositories.Basic.Utilities.Cache
{
    public class CacheManager : ICacheManager
    {
        private const int _expirationAbsoluteTimeoutSec = 60 * 60;

        #region Helpers
        private ObjectCache GetCache()
        {
            return MemoryCache.Default;
        }
        #endregion

        public object Get(string key)
        {
            return GetCache()[key];
        }

        public void Set(string key, object value)
        {
            var policy = new CacheItemPolicy { AbsoluteExpiration = DateTimeOffset.Now.AddSeconds(_expirationAbsoluteTimeoutSec) };
            GetCache().Set(key, value, policy);
        }

    }
}
