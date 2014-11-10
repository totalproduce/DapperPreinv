using Bsdl.FreshTrade.Domain.Basic.Exceptions;

namespace Bsdl.FreshTrade.UI.Basic.Exceptions
{
    public sealed class StartupInvaildDbIdException : FreshTradeException
    {
        public StartupInvaildDbIdException()
            : base("The database connection id passed in as a command-line argument is invalid")
        {
        }
    }
}
