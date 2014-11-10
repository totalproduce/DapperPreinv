namespace Bsdl.FreshTrade.Domain.Basic.Exceptions.DbConnection
{

    /// <summary>
    /// Exception to be raised when the database connections file is empty
    /// </summary>
    public sealed class DatabaseConnectionIdIsNotIntException : FreshTradeDbException
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DatabaseConnectionIdIsNotIntException"/> class.
        /// </summary>
        /// <param name="id">The connection string id</param>
        public DatabaseConnectionIdIsNotIntException(string id)
            : base("The connection id should be an int : " + id)
        {
        }
    }
}
