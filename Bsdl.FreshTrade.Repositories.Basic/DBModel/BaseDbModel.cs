using System;
using System.Diagnostics;
using System.Linq.Expressions;
using System.Reflection;

namespace Bsdl.FreshTrade.Repositories.Basic.DBModel
{

    /// <summary>
    /// Base interface for any objects with the ID property.
    /// </summary>
    public interface IItemWithKey
    {
        string Key { get; }
    }


    /// <summary>
    /// Marker interface for entities with composite primary key.
    /// </summary>
    public interface ICompositeKey
    {
        string AsString { get; }
    }


    /// <summary>
    /// Base interface for any objects with the Name property.
    /// </summary>
    public interface IItemWithName
    {
        string Name { get; }
    }


    /// <summary>
    /// Base interface for all entity classes. 
    /// </summary>
    public interface IBaseModel : IItemWithKey
    {
        Type EntityTypeRef { get; }
    }

    /// <summary>
    /// Base interface for all entities.
    /// </summary>
    /// <typeparam name="TKey">Type of entity key</typeparam>
    public interface IEntity<TKey> : IBaseModel
    {
        new TKey Key { get; set; }
    }


    /// <summary>
    /// Base interface for all entity classes. Used internally.
    /// </summary>
    internal interface IBaseModelInternal
    {
    }



    /// <summary>
    /// Base class for all entity framework entity classes.
    /// </summary>
    /// <typeparam name="TEntity">Type of entity class</typeparam>
    /// <typeparam name="TKey">Type of entity key</typeparam>
    [DebuggerDisplay("Entity: {GetType().Name}, Key: {Key}")]
    public abstract class BaseDbModel<TEntity, TKey>: IEntity<TKey>, IBaseModelInternal
        where TEntity : BaseDbModel<TEntity, TKey>
    {

        Type IBaseModel.EntityTypeRef
        {
            get { return typeof(TEntity); }
        }

        public virtual TKey Key { get; set; }
        public virtual string KeyAsString { get {return Key.ToString();} }

        string IItemWithKey.Key
        {
            get { return KeyAsString; }
        }

        public abstract TEntity Clone();


        protected virtual void Modify()
        {
        }

        protected void KeyChanged(TKey oldKey)
        {
        }


        protected TRefKey SetKeyVal<TRefEntity, TRefKey>(TRefKey key, TRefEntity entity)
            where TRefEntity : BaseDbModel<TRefEntity, TRefKey>
            where TRefKey : struct
        {
            throw new NotImplementedException();
            //return entity.Key;
        }


        public TEntityRef GetByKeyVal<TEntityRef, TKeyRef>(TKeyRef? key)
            where TEntityRef : BaseDbModel<TEntityRef, TKeyRef>
            where TKeyRef : struct
        {
            if (key == null)
                return null;
            throw new NotImplementedException();
        }

    }

    public static class PropertyHelper<T>
    {
        public static PropertyInfo GetProperty<TValue>(
            Expression<Func<T, TValue>> selector)
        {
            Expression body = selector;
            if (body is LambdaExpression)
            {
                body = ((LambdaExpression)body).Body;
            }
            switch (body.NodeType)
            {
                case ExpressionType.MemberAccess:
                    return (PropertyInfo)((MemberExpression)body).Member;
                default:
                    throw new InvalidOperationException();
            }
        }
    }
}