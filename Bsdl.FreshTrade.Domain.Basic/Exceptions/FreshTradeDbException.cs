using System;

namespace Bsdl.FreshTrade.Domain.Basic.Exceptions
{

    public class FreshTradeDbException : FreshTradeException
    {
        public FreshTradeDbException(string message) : base(message)
        {
        }

        public FreshTradeDbException(string message, Exception ex) : base(message, ex)
        {
        }
    
    }
}
