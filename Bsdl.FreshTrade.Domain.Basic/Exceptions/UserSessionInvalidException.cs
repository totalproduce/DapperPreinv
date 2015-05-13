using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bsdl.FreshTrade.Domain.Basic.Exceptions
{
    public class UserSessionInvalidException: FreshTradeException
    {
           public UserSessionInvalidException()
            : base("User session is invalid")
        {
        }

    }
}
