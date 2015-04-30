namespace Bsdl.FreshTrade.Domain.Basic.Exceptions.DataAccess
{
    public sealed class DatabaseNoSearchFieldsException : FreshTradeDbException
    {
        public DatabaseNoSearchFieldsException(string className)
            : base("No search field defined in " + className)
        {

        }
    }
}
