using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace Bsdl.FreshTrade.UI.Basic.Utilities
{
    public static class ConfigurationExtentions
    {
        public static bool GetBooleanOrDefault(this NameValueCollection collection, string name, bool defaultValue = false)
        {
            var rawValue = collection[name];
            bool val;
            if (bool.TryParse(rawValue, out val))
            {
                return val;
            }
            return defaultValue;
        }
    }
}
