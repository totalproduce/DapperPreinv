using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Bsdl.FreshTrade.Domain.Basic.Exceptions;

namespace Bsdl.FreshTrade.Services.PreInv.Model
{
    public enum RequestContextCacheMergeBehaviour
    {
        NotAllow = 1,
        SkipIfKeyExist = 2,
        AddEvenIfKeyExists = 3
    }

    public interface IRequestContextCache<K>
    {
        void Put<T>(IEnumerable<T> data, Func<T, K> getKey, RequestContextCacheMergeBehaviour mergeBehaviour = RequestContextCacheMergeBehaviour.NotAllow);
        List<T> Get<T>(K key);
        List<T> Get<T, S>(K key, Func<T, S> orderBy = null);
        T GetSingle<T>(K key, bool allowEmpty = false);

        void ActionForAllGroups<T>(Action<K, List<T>> action);
        void SortGroups<T>(IComparer<object> comparer);

        void DeleteItem<T>(K key, T item);
        void DeleteGroup<T>(K key);
    }

    public class RequestContextCache<K> : IRequestContextCache<K>
    {
        private readonly Dictionary<Type, Dictionary<K, List<object>>> _storage = new Dictionary<Type, Dictionary<K, List<object>>>();

        public void Put<T>(IEnumerable<T> data, Func<T, K> getKey, RequestContextCacheMergeBehaviour mergeBehaviour = RequestContextCacheMergeBehaviour.NotAllow)
        {
            var type = typeof (T);
            Dictionary<K, List<object>> dataDict;
            bool dataDictCreated = false;
            if (_storage.TryGetValue(type, out dataDict))
            {
                if (mergeBehaviour == RequestContextCacheMergeBehaviour.NotAllow)
                {
                    throw new FreshTradeException(string.Format("RequestContextCache already contains {0} data",
                                                                type.FullName));
                }
            }
            else
            {
                dataDict = new Dictionary<K, List<object>>();
                dataDictCreated = true;
            }
            foreach (var item in data)
            {
                var key = getKey(item);
                List<object> group;
                bool keyFound = true;
                if (!dataDict.TryGetValue(key, out group))
                {
                    group = new List<object>();
                    dataDict.Add(key, group);
                    keyFound = false;
                }
                if (!(keyFound && (mergeBehaviour == RequestContextCacheMergeBehaviour.SkipIfKeyExist)))
                {
                    group.Add(item);
                }
            }
            if (dataDictCreated)
            {
                _storage.Add(type, dataDict);
            }
        }

        public void DeleteItem<T>(K key, T item)
        {
            var type = typeof(T);
            Dictionary<K, List<object>> data;
            if (!_storage.TryGetValue(type, out data))
            {
                throw new FreshTradeException(string.Format("RequestContextCache does not contain {0} data", type.FullName));
            }
            List<object> group;
            if (!data.TryGetValue(key, out group))
            {
                throw new FreshTradeException(string.Format("RequestContextCache for entity {0} does not contain key group data {1}", type.FullName, key.ToString()));
            }
            group.Remove(item);
        }

        public void DeleteGroup<T>(K key)
        {
            var type = typeof(T);
            Dictionary<K, List<object>> data;
            if (!_storage.TryGetValue(type, out data))
            {
                throw new FreshTradeException(string.Format("RequestContextCache does not contain {0} data", type.FullName));
            }
            data.Remove(key);
        }

        public void ActionForAllGroups<T>(Action<K, List<T>> action)
        {
            var type = typeof(T);
            Dictionary<K, List<object>> data;
            if (!_storage.TryGetValue(type, out data))
            {
                throw new FreshTradeException(string.Format("RequestContextCache does not contain {0} data", type.FullName));
            }
            foreach (var group in data)
            {
                action(group.Key, group.Value.Select(i => (T)i).ToList());
            }
        }

        public void SortGroups<T>(IComparer<object> comparer)
        {
            var type = typeof(T);
            Dictionary<K, List<object>> data;
            if (!_storage.TryGetValue(type, out data))
            {
                throw new FreshTradeException(string.Format("RequestContextCache does not contain {0} data", type.FullName));
            }

            foreach (var group in data)
            {
                group.Value.Sort(comparer);
            }
        }

        public List<T> Get<T>(K key)
        {
            return Get<T, int>(key, null);
        }

        public List<T> Get<T, S>(K key, Func<T, S> orderBy = null)
        {
            var type = typeof(T);
            Dictionary<K, List<object>> data; 
            if (!_storage.TryGetValue(type, out data))
            {
                throw new FreshTradeException(string.Format("RequestContextCache does not contain {0} data", type.FullName));
            }
            List<object> group;
            if (!data.TryGetValue(key, out group))
            {
                return null;
            }
            var result = group.Select(i => (T) i);
            if (orderBy != null)
            {
                result = result.OrderBy(orderBy);
            }
            return result.ToList();
        }

        public T GetSingle<T>(K key, bool allowEmpty = false)
        {
            var result = Get<T>(key);
            if ((result == null) || (result.Count == 0))
            {
                if (allowEmpty)
                {
                    return default(T);
                }
                throw new FreshTradeException(string.Format("RequestContextCache does not contain {0} data with key {1}", typeof(T).FullName, key));
            }
            if (result.Count > 1)
            {
                throw new FreshTradeException(string.Format("RequestContextCache contain multiple {0} data with key {1}", typeof(T).FullName, key));
            }
            return result[0];
        }
    }
}
