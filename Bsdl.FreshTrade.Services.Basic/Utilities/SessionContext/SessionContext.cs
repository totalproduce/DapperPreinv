using Bsdl.FreshTrade.Domain.Basic.Interfaces;
using System.Collections.Generic;

namespace Bsdl.FreshTrade.Services.Basic.Utilities.SessionContext
{
    public class SessionContext
    {
        public int DbID { get; set; }
        public IDTOUser FreshTradeUser { get; set; }

        public Dictionary<string, object> Data = new Dictionary<string, object>();
    }
}
