namespace Bsdl.FreshTrade.Domain.Basic.Exceptions.DbConnection
{

    /// <summary>
    /// Exception to be thrown when the database connections file can not
    /// be located - either the file does not exist or the path is bad
    /// </summary>
    public sealed class DatabaseConnectionsFileNotFoundException : FreshTradeDbException
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DatabaseConnectionsFileNotFoundException"/> class.
        /// </summary>
        /// <param name="path">The path to the database connections file.</param>
        public DatabaseConnectionsFileNotFoundException(string path)
            : base("The database connections file can not be found at the path: " + path)
        {
        }

    }
}
