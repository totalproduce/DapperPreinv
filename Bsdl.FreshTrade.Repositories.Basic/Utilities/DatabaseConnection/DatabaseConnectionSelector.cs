using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Threading;
using Bsdl.FreshTrade.Domain.Basic.Exceptions.DbConnection;
using Bsdl.FreshTrade.Repositories.Basic.Utilities.Interfaces;

namespace Bsdl.FreshTrade.Repositories.Basic.Utilities.DatabaseConnection
{
    public class DatabaseConnectionSelector : IDatabaseConnectionSelector
    {
        private IDictionary<int, IDatabaseConnectionConfiguration> _databaseConnections;

        private const string ConfigKey = @"bsdl.siteConnectionsFileLocation";

        #region Helpers

        /// <summary>
        /// Read the application configuration file to get a path to the database connections
        /// file.
        /// Throw DatabaseConnectionsPathNotFound if the setting is not found in the application configuration file
        /// Throw DatabaseConnectionsFileNotFound if the file pointed to is not found
        /// Throw DatabaseConnectionsFileReadError if an error is encountered while reading the file
        /// Throw DatabaseConnectionsFileEmpty if the file is empty
        /// </summary>
        protected void Initialise()
        {
            string configFilePath = ConfigurationManager.AppSettings[ConfigKey];
            if (!File.Exists(configFilePath))
            {
                throw new DatabaseConnectionsFileNotFoundException(configFilePath);
            }

            ReadConfigurationFile(configFilePath);
        }

        private void ReadConfigurationFile(string file)
        {
            _databaseConnections = new Dictionary<int, IDatabaseConnectionConfiguration>();

            StreamReader reader = null;

            try
            {
                reader = new StreamReader(File.OpenRead(file));

                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    line = line.Replace("'", string.Empty);

                    var values = line.Split(',');

                    var connectionConfig = new OracleDatabaseConnectionConfiguration();
                    connectionConfig.Id = int.Parse(values[0]);
                    connectionConfig.Name = values[1];
                    connectionConfig.Host = values[2];
                    connectionConfig.Service = values[3];
                    connectionConfig.Schema = values[4];
                    connectionConfig.EncryptedPassword = values[6];

                    _databaseConnections.Add(connectionConfig.Id, connectionConfig);
                }
            }
            catch (Exception e)
            {
                throw new DatabaseConnectionsFileReadErrorException(file, e);
            }
            finally
            {
                if (reader != null)
                {
                    reader.Close();
                }
            }
        }
        #endregion
        #region Singelton implementation
        private static readonly object _lock = new object();
        private static DatabaseConnectionSelector _instance;
        public static DatabaseConnectionSelector Instance
        {
            get
            {
                if (_instance == null)
                {
                    lock (_lock)
                    {
                        if (_instance == null)
                        {
                            var selector = new DatabaseConnectionSelector();
                            selector.Initialise();
                            Thread.MemoryBarrier();
                            _instance = selector;
                        }
                    }
                }
                return _instance;
            }
        }

        #endregion


        /// <summary>
        /// Gets the connection string for a specified connection id
        /// </summary>
        /// Throw DatabaseConnectionIdNotFound if the id does not exist
        /// <param name="id">the id of the connection to construct</param>
        /// <returns>The connection string</returns>
        public string GetConnectionString(int id)
        {
            IDatabaseConnectionConfiguration configuration;
            if (!_databaseConnections.TryGetValue(id, out configuration))
            {
                throw new DatabaseConnectionIdNotFoundException(id);
            }
            return configuration.GetConnectionString();
        }
    }
}
