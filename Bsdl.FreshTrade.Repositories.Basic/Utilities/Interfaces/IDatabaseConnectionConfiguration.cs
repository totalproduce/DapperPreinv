namespace Bsdl.FreshTrade.Repositories.Basic.Utilities.Interfaces
{
    /// <summary>
    /// An interface that encapsulates a configuration for a database connection
    /// </summary>
    public interface IDatabaseConnectionConfiguration
    {
        /// <summary>
        /// Gets the Id of the database connection configuration
        /// </summary>
        /// <returns>The id of the connection</returns>
        int GetId();

        /// <summary>
        /// Gets the constructed connection string
        /// </summary>
        /// <returns>The connection string</returns>
        string GetConnectionString();
    }
}
