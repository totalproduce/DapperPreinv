using Bsdl.FreshTrade.Domain.Basic.Exceptions;

namespace Bsdl.FreshTrade.UI.Basic.Exceptions
{
    public sealed class StartupInvalidUserException : FreshTradeException
    {
        public StartupInvalidUserException()
            : base("Invalid user")
        {
        }
    }
}
