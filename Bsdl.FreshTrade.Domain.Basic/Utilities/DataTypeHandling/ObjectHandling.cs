using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using Bsdl.FreshTrade.Domain.Basic.Exceptions;

namespace Bsdl.FreshTrade.Domain.Basic.Utilities.DataTypeHandling
{
    public interface IDeepClonableDTO<in T>
    {
        void CloneNestedObjects(T source);
        void CleanNestedObjects();
    }

    public static class ObjectHandling
    {
        //TODO: This is slow way to do that - later should be replaced with T4 codegeneration
        public static T CloneDTO<T> (T source, bool deepCloning = false)
        {
            if (source.Equals(default(T)))
            {
                return default(T);
            }
            var newObj = Activator.CreateInstance<T>();
            var fields = newObj.GetType().GetFields(BindingFlags.Public | BindingFlags.Instance);
            foreach (var field in fields)
            {
                var value = field.GetValue(source);
                field.SetValue(newObj, value);
            }
            var props = newObj.GetType().GetProperties(BindingFlags.Public | BindingFlags.Instance);
            foreach (var prop in props)
            {
                var value = prop.GetValue(source, null);
                prop.SetValue(newObj, value, null);
            }

            var deepCloner = newObj as IDeepClonableDTO<T>;
            if (deepCloning)
            {
                if (deepCloner == null)
                {
                    throw new FreshTradeException("This object does not support deep cloning.");
                }
                deepCloner.CloneNestedObjects(source);
            }
            else
            {
                if (deepCloner != null)
                {
                    deepCloner.CleanNestedObjects();
                }
            }

            return newObj;
        }

        //TODO: This is slow way to do that - later should be replaced with T4 codegeneration
        public static void CopyObjectState<T>(T source, T target)
        {
            var fields = source.GetType().GetFields(BindingFlags.Public | BindingFlags.Instance);
            foreach (var field in fields)
            {
                var value = field.GetValue(source);
                field.SetValue(target, value);
            }
            var props = source.GetType().GetProperties(BindingFlags.Public | BindingFlags.Instance);
            foreach (var prop in props)
            {
                var value = prop.GetValue(source, null);
                prop.SetValue(target, value, null);
            }

            var deepCloner = target as IDeepClonableDTO<T>;
            if (deepCloner != null)
            {
                deepCloner.CleanNestedObjects();
            }
        }

        //TODO: This is slow way to compare - think how to improve that
        public static bool ValueEquality(object val1, object val2)
        {
            if (val1 == null)
            {
                return val2 == null;
            }
            if (val2 == null)
            {
                return false;
            }

            if (!(val1 is IConvertible)) throw new ArgumentException("val1 must be IConvertible type");
            if (!(val2 is IConvertible)) throw new ArgumentException("val2 must be IConvertible type");

            // convert val2 to type of val1.
            var raw1 = Convert.ChangeType(val1, val1.GetType());
            var raw2 = Convert.ChangeType(val2, val2.GetType());

            // compare now that same type.
            return raw1.Equals(raw2);
        }
    }
}
