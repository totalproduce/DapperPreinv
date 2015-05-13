namespace Bsdl.FreshTrade.Domain.Basic.Exceptions.DbConnection
{

    /// <summary>
    /// Exception to be raised when the database connections file is empty
    /// </summary>
    public sealed class DatabaseConnectionsFileEmptyException : FreshTradeDbException
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DatabaseConnectionsFileEmptyException"/> class.
        /// </summary>
        /// <param name="path">The path to the configuration file</param>
        public DatabaseConnectionsFileEmptyException(string path)
            : base("The file is empty : " + path)
        {
        }
    }
}
