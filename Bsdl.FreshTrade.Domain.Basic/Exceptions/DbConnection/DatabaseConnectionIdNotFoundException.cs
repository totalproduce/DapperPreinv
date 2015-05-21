namespace Bsdl.FreshTrade.Domain.Basic.Exceptions.DbConnection
{

    /// <summary>
    /// Exception to be thrown when a database connection string is requested
    /// for a connection id that does not exist
    /// </summary>
    public sealed class DatabaseConnectionIdNotFoundException : FreshTradeDbException
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DatabaseConnectionIdNotFoundException"/> class.
        /// </summary>
        /// <param name="id">The id of the connection that could not be found</param>
        public DatabaseConnectionIdNotFoundException(int id)
            : base("No database connection was defined for the id : " + id)
        {
        }
    }
}
