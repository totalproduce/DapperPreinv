using System;

namespace Bsdl.FreshTrade.Domain.Basic.Exceptions.DataAccess
{
    public sealed class DatabaseQueryException : FreshTradeDbException
    {
        public DatabaseQueryException(string description)
            : base(description)
        {
        }

        public DatabaseQueryException(string message, Exception ex)
            : base(message, ex)
        {
        }

    }
}
