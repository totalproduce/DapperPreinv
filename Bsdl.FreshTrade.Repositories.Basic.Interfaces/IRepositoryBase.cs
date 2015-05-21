using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Bsdl.FreshTrade.Domain.Basic.Interfaces;
using Bsdl.FreshTrade.Domain.Basic.Utilities;

namespace Bsdl.FreshTrade.Repositories.Basic.Interfaces
{
    public enum CachingStrategy
    {
        NoCache = 0,
        PerRequest = 1,
        GlobalCache = 2
    }

    public interface IRepositoryBase
    {
    }

    public interface IRepositoryBase<T> : IRepositoryBase
    {
        long GetNextSequence();
        void ReserveSequenceRange(int? keyNumber = 1);
        List<T> GetData(List<ISearchField> searchFields, CachingStrategy allowFromCache, bool forceRefresh = false, uint? topRows = null);
        T Add(T entity);
        void Add(ICollection<T> entities);
        int Update(T entity);
        int Update(T oldItem, T newItem, ICollection<IFieldNameRef> nonKeyFieldsForWhereClause = null);
        void Update(ICollection<UpdatePair<T>> items);
        void Update(ICollection<IFieldNameRef> updateFields, ICollection<IRowUpdateInfo> updateRows);
        void Delete(T entity);
        void Delete(ICollection<T> items);

        void Debug(string hint);
    }

    public interface IFieldNameRef
    {
        string FieldName { get; }
    }

    public interface IRowUpdateInfo
    {
        object KeyValue { get; }
        ICollection<object> FieldValues { get; }
    }
}
