using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Bsdl.FreshTrade.Domain.Basic.Exceptions;

namespace Bsdl.FreshTrade.Domain.PreInv.Exceptions
{
    public class AbortEntireProcessing : FreshTradeException
    {
        public AbortEntireProcessing(): base(string.Empty)
        {

        }
    }
}
