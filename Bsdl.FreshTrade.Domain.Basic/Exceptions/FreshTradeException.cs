using System;

namespace Bsdl.FreshTrade.Domain.Basic.Exceptions
{

    public class FreshTradeException : Exception
    {
        public int Code { get; set; }

        public FreshTradeException(string message) : base(message)
        {
        }

        public FreshTradeException(int code, string message)
            : base(message)
        {
            Code = code;
        }

        public FreshTradeException(string message, Exception ex) : base(message, ex)
        {
        }

    }
}
