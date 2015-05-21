using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using Bsdl.FreshTrade.Domain.Basic.Exceptions;
using Bsdl.FreshTrade.Domain.Basic.Utilities.DataTypeHandling;
using Bsdl.FreshTrade.Repositories.Basic.Interfaces;
using Bsdl.FreshTrade.Repositories.Basic.Utilities.DatabaseConnection;
using Bsdl.FreshTrade.Repositories.Basic.Utilities.Interfaces;
using Bsdl.FreshTrade.Server.Basic.Interfaces;
using Bsdl.FreshTrade.Server.Basic.Logger;
using Dapper;
using Oracle.ManagedDataAccess.Client;

namespace Bsdl.FreshTrade.Repositories.Basic
{
    public class UnitOfWork : IUnitOfWork, IDisposable
    {
        private readonly ILogger _logger; 
        private readonly IDatabaseConnectionPool _connPool;
        private readonly IRepositoryFactory _repositoryFactory;
        private IDbConnection _connection;
        private IDbTransaction _transaction;
        private bool _disposed = false;
        private int _dbID;

        #region Helpers
        private void EnsureContextInitialized()
        {
            if (_connection == null)
            {
                _connection = _connPool.GetConnection(_dbID);
            }
        }

        #endregion

        public UnitOfWork(int dbID, IDatabaseConnectionPool connPool, IRepositoryFactory repositoryFactory)
        {
            _dbID = dbID;
            _connPool = connPool;
            _repositoryFactory = repositoryFactory;
            _logger = LogManager.GetLoggerFor<UnitOfWork>();
        }

        public int DbID
        {
            get { return _dbID; }
        }

        public IEnumerable<long> GenNextSequenceIDs(string sequenceName, int count)
        {
            string sql = String.Format("SELECT {0}_SEQ.NEXTVAL FROM DUAL CONNECT BY LEVEL <= {1}", sequenceName, count);
            return Query<long>(sql);
        }

        public long GenNextSequenceID(string sequenceName)
        {
            return GenNextSequenceIDs(sequenceName, 1).First();
        }

        public IEnumerable<T> Query<T>(string sql, bool buffered = true, int? commandTimeout = null, CommandType? commandType = null)
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();
            EnsureContextInitialized();
            //TODO: To switch to the recording mode use Query2!
            var result = _connection.Query<T>(sql, null, _transaction, buffered, commandTimeout, commandType);
            sw.Stop();
            _logger.Debug(String.Format("Query: {0,5}ms; buffered: {1}, {2} ",sw.ElapsedMilliseconds, buffered, sql.Left(int.MaxValue).Replace('\n', ' ').Replace('\r', ' ')));
            return result ?? new List<T>();
        }

        public long GetNextIdentity(string tableSequence, int reserveRangeNumber = 1)
        {
            EnsureContextInitialized();
            var sql = String.Format("select sp_WizGetControl ( '{0}',{1}, '') as idNext FROM dual", tableSequence, reserveRangeNumber);
            var result = _connection.Query<long>(sql, null, null, false, null, null).FirstOrDefault();
            return result;
        }

        public int Execute(string sql, dynamic param = null, int? commandTimeout = null, CommandType? commandType = null, Action<IDbCommand> onCommandCreated = null)
        {
            Stopwatch sw = new Stopwatch();
            CommandLogger.Log(sql, param);
            sw.Start();
            EnsureContextInitialized();
            if (_transaction == null)
            {
                throw new FreshTradeException("Unit of work is not in transaction. Execute calls can be performed only in scope of transaction.");
            }
            var result = SqlMapper.Execute(_connection, sql, param, _transaction, commandTimeout, commandType, onCommandCreated);
            sw.Stop();
            _logger.Debug(String.Format("Execute: {0,5}ms; {1} ", sw.ElapsedMilliseconds, sql.Left(100).Replace('\n', ' ').Replace('\r', ' ')));
            return result;
        }

        public T GetRepository<T>() where T : IRepositoryBase
        {
            var parameters = new Dictionary<string, object>
                                 {
                                     {"unitOfWorkCurrent", this}
                                 };
            return _repositoryFactory.GetRepository<T>(parameters);
        }

        public void BeginTransaction()
        {
            EnsureContextInitialized();
            if (_transaction != null)
            {
                throw new FreshTradeException("Unit of work is already in transaction. Nested transactions are not supported.");
            }
            _transaction = _connection.BeginTransaction();
        }

        public void Commit()
        {
            EnsureContextInitialized();
            if (_transaction == null)
            {
                throw new FreshTradeException("Unit of work is already in not in transaction.");
            }
            _transaction.Commit();
            _transaction = null;
        }

        public void Rollback()
        {
            EnsureContextInitialized();
            if (_transaction == null)
            {
                throw new FreshTradeException("Unit of work is already in not in transaction.");
            }
            _transaction.Rollback();
            _transaction = null;
        }

        #region IDisposable implementation
        protected virtual void Dispose(bool disposing)
        {
            if (!_disposed)
            {
                if (disposing)
                {
                    if (_connection != null)
                    {
                        if (_transaction != null)
                        {
                            _transaction.Rollback();
                            _transaction = null;
                        }
                        _connPool.ReleaseConnection(_connection);
                        _connection = null;
                    }
                }
            }
            _disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        #endregion
    }
}
