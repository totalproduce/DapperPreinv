using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bsdl.FreshTrade.Repositories.Basic.Utilities.Interfaces
{
    public interface ICacheManager
    {
        object Get(string key);
        void Set(string key, object value);
    }
}
