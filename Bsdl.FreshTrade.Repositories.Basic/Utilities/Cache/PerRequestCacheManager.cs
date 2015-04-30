using System;
using System.Runtime.Caching;
using System.Web;
using Bsdl.FreshTrade.Repositories.Basic.Utilities.Interfaces;

namespace Bsdl.FreshTrade.Repositories.Basic.Utilities.Cache
{
    public class PerRequestCacheManager : ICacheManager
    {

        public object Get(string key)
        {
            return HttpContext.Current.Items[key];
        }

        public void Set(string key, object value)
        {
            HttpContext.Current.Items[key] = value;
        }
    }
}
