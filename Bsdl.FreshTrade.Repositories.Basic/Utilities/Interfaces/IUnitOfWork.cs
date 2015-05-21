using System;
using System.Collections.Generic;
using System.Data;
using Bsdl.FreshTrade.Repositories.Basic.Interfaces;

namespace Bsdl.FreshTrade.Repositories.Basic.Utilities.Interfaces
{
    public interface IUnitOfWork
    {
        int DbID { get; }

        IEnumerable<T> Query<T>(string sql/*, dynamic param = null*/, bool buffered = true, int? commandTimeout = null, CommandType? commandType = null);
        int Execute(string sql, dynamic param = null, int? commandTimeout = null, CommandType? commandType = null, Action<IDbCommand> onCommandCreated = null);
        T GetRepository<T>() where T : IRepositoryBase;

        IEnumerable<long> GenNextSequenceIDs(string sequenceName, int count);
        long GenNextSequenceID(string sequenceName);

        long GetNextIdentity(string tableSequence, int reserveRangeNumber = 1);

        void BeginTransaction();
        void Commit();
        void Rollback();
    }
}
