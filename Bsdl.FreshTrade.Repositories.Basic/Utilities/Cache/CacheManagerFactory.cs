using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Bsdl.FreshTrade.Domain.Basic.Exceptions;
using Bsdl.FreshTrade.Repositories.Basic.Interfaces;
using Bsdl.FreshTrade.Repositories.Basic.Utilities.Interfaces;

namespace Bsdl.FreshTrade.Repositories.Basic.Utilities.Cache
{
    public class CacheManagerFactory : ICacheManagerFactory
    {
        private readonly object _lock = new object();
        private ICacheManager _inMemoryManager;
        private ICacheManager _perRequestManager;

        public ICacheManager Get(CachingStrategy type)
        {
            lock (_lock)
            {
                if (type == CachingStrategy.GlobalCache)
                {
                    return _inMemoryManager ?? (_inMemoryManager = new CacheManager());
                }
                if (type == CachingStrategy.PerRequest)
                {
                    return _perRequestManager ?? (_perRequestManager = new PerRequestCacheManager());
                }
                throw new FreshTradeException("Strategy is not supported");
            }
        }
    }
}
