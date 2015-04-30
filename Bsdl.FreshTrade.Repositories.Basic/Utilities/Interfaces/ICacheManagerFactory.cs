using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Bsdl.FreshTrade.Repositories.Basic.Interfaces;

namespace Bsdl.FreshTrade.Repositories.Basic.Utilities.Interfaces
{
    public interface ICacheManagerFactory
    {
        ICacheManager Get(CachingStrategy type);
    }
}
