using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Bsdl.FreshTrade.Domain.Basic.Exceptions;

namespace Bsdl.FreshTrade.Server.Basic
{
    public static class ErrorHelpers
    {
        public static FreshTradeException TranslateErrorMessage(FreshTradeException e)
        {
            //For now
            return e;
        }
    }
}
