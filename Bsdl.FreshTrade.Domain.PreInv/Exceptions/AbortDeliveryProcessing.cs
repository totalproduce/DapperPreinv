using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Bsdl.FreshTrade.Domain.Basic.Exceptions;

namespace Bsdl.FreshTrade.Domain.PreInv.Exceptions
{
    public class AbortDeliveryProcessing: FreshTradeException
    {
        public AbortDeliveryProcessing(): base(string.Empty)
        {
            
        }
    }
}
