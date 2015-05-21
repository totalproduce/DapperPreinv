namespace Bsdl.FreshTrade.Domain.Basic.Exceptions.DataAccess
{
    public sealed class DatabaseInvalidSearchFieldException : FreshTradeDbException
    {
        public DatabaseInvalidSearchFieldException()
            : base("Search field is not in list of valid fields")
        {

        }
    }
}
