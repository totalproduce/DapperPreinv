using System;

namespace Bsdl.FreshTrade.Domain.Basic.Exceptions.DbConnection
{

    /// <summary>
    /// Exception to be thrown when the database connections file can not be
    /// read for some reason
    /// </summary>
    public sealed class DatabaseConnectionsFileReadErrorException : FreshTradeDbException
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DatabaseConnectionsFileReadErrorException"/> class.
        /// </summary>
        /// <param name="path">The path to the file</param>
        /// <param name="e">The inner exception (if there is one)</param>
        public DatabaseConnectionsFileReadErrorException(string path, Exception e)
            : base("Database connections file is bad : " + path, e)
        {

        }
    }
}
