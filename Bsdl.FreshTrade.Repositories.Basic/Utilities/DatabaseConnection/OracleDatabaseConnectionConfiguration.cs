using System;
using Bsdl.FreshTrade.Repositories.Basic.Utilities.Interfaces;

namespace Bsdl.FreshTrade.Repositories.Basic.Utilities.DatabaseConnection
{

    /// <summary>
    /// Encapsulate all the data needed to create a database connection
    /// </summary>
    public sealed class OracleDatabaseConnectionConfiguration : IDatabaseConnectionConfiguration
    {
        /// <summary>
        /// Gets or sets the unique Id of the DB connection
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the friendly name 
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the oracle server's host name
        /// </summary>
        public string Host { get; set; }

        /// <summary>
        /// Gets or sets the service name for the oracle server
        /// </summary>
        public string Service { get; set; }

        /// <summary>
        /// Gets or sets the schema name
        /// </summary>
        public string Schema { get; set; }

        /// <summary>
        /// Gets or sets the encrypted password
        /// </summary>
        public string EncryptedPassword { get; set; }

        /// <summary>
        /// Get the id value
        /// </summary>
        /// <returns>The Id</returns>
        public int GetId()
        {
            return Id;
        }

        /// <summary>
        /// Construct a connection string based on all of the fields.
        /// </summary>
        /// <returns>A connection string</returns>
        public string GetConnectionString()
        {
            // "user id=DBNAME;password=UIJUQOXRU;data source=(DESCRIPTION=(ADDRESS=(PROTOCOL=tcp)(HOST=MyComputerName)(PORT=1521))(CONNECT_DATA=(SERVICE_NAME=ORCL)))
            //1,'My Database','MyComputerName','ORCL','DBNAME',,'UIJUQOXRU','N',

            string decryptedPassword = Encryption.Decrypt(EncryptedPassword);

            string connectionString =
                String.Format(
                    "user id={0};password={1};data source=(DESCRIPTION=(ADDRESS=(PROTOCOL=tcp)(HOST={2})(PORT=1521))(CONNECT_DATA=(SERVICE_NAME={3})))",
                        this.Schema,
                        decryptedPassword,
                        this.Host,
                        this.Service);

            return connectionString;
        }
    }
}
