namespace Bsdl.FreshTrade.Domain.Basic.Exceptions.DbConnection
{

    /// <summary>
    /// Exception to be thrown when the application configuration file
    /// does not contain the element for the database connections file.
    /// </summary>
    public sealed class DatabaseConnectionsPathNotFoundException : FreshTradeDbException
    {
        /// <summary>
        ///  Initializes a new instance of the <see cref="DatabaseConnectionsPathNotFoundException"/> class.
        /// </summary>
        public DatabaseConnectionsPathNotFoundException()
            : base("The bsdl.databaseConnectionsPath element was not found in the application configuration file")
        {
        }
    }
}
