using Bsdl.FreshTrade.Domain.Basic.Exceptions;

namespace Bsdl.FreshTrade.UI.Basic.Exceptions
{
    public sealed class StartupNoDbIdException : FreshTradeException
    {
        public StartupNoDbIdException()
            : base("The database connection id has not been passed in as a command-line argument")
        {
        }
    }
}
