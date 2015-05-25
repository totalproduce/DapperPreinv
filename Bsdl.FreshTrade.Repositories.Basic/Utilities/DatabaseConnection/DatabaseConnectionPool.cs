using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading;
using Bsdl.FreshTrade.Repositories.Basic.Utilities.Interfaces;
using Oracle.ManagedDataAccess.Client;
using System.Data.Common;

namespace Bsdl.FreshTrade.Repositories.Basic.Utilities.DatabaseConnection
{
    public class DatabaseConnectionPool : IDatabaseConnectionPool
    {

        private readonly Dictionary<int, ISet<IDbConnection>> _availableConnections = new Dictionary<int, ISet<IDbConnection>>();
        private readonly Dictionary<IDbConnection, int> _lockedConnections = new Dictionary<IDbConnection, int>();

        private readonly object _lock = new object();

        #region Singelton implementation
        private static readonly object _singeltonLock = new object();
        private static IDatabaseConnectionPool _instance;
        public static IDatabaseConnectionPool Instance
        {
            get
            {
                if (_instance == null)
                {
                    lock (_singeltonLock)
                    {
                        if (_instance == null)
                        {
                            var connPool = new DatabaseConnectionPool();
                            Thread.MemoryBarrier();
                            _instance = connPool;
                        }
                    }
                }
                return _instance;
            }
        }

        #endregion
        /// <summary>
        /// Get an open connection to the database
        /// </summary>
        /// <returns>An open connection</returns>
        public IDbConnection GetConnection(int connectionID)
        {
            lock(_lock)
            {
                IDbConnection result;
                ISet<IDbConnection> neededDbConnections;
                if (_availableConnections.TryGetValue(connectionID, out neededDbConnections))
                {
                    if (neededDbConnections.Count > 0)
                    {
                        result = neededDbConnections.First();
                        neededDbConnections.Remove(result);
                        _lockedConnections.Add(result, connectionID);
                        return result;
                    }
                }
                //No connection available - creating new one
                result = CreateConnection(DatabaseConnectionSelector.Instance.GetConnectionString(connectionID));
                _lockedConnections.Add(result, connectionID);
                return result;
            }
        }

        private IDbConnection CreateConnection(string s)
        {
            var newConnection = new OracleConnection(s);
            newConnection.Open();
            return newConnection;
        }

        /// <summary>
        /// Release a connection back to the pool
        /// </summary>
        /// <param name="connection">The connection to release</param>
        public void ReleaseConnection(IDbConnection connection)
        {
            lock (_lock)
            {
                int connectionID;
                if (_lockedConnections.TryGetValue(connection, out connectionID))
                {
                    //TODO: It worth checking for any unfinished transaction at that point.
                    _lockedConnections.Remove(connection);
                    ISet<IDbConnection> neededDbConnections;
                    if (_availableConnections.TryGetValue(connectionID, out neededDbConnections))
                    {
                        neededDbConnections.Add(connection);
                    }
                    else
                    {
                        neededDbConnections = new HashSet<IDbConnection> { connection };
                        _availableConnections.Add(connectionID, neededDbConnections);
                    }
                }
            }
        }
    }

}
