using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Text;

namespace Bsdl.FreshTrade.Domain.Basic.Utilities.DataTypeHandling
{
    public static class DelegateHelpers
    {
        public static string GetPropertyNameFromExpression<T, R>(Expression<Func<T, R>> propRef)
        {
            var member = propRef.Body as MemberExpression;
            if (member == null)
            {
                throw new ArgumentException(string.Format("Expression '{0}' refers to a method, not a property.",
                                                          propRef.ToString()));
            }

            return member.Member.Name;
        }

        public static object GetPropertyAttributeFromExpression<T, R>(Expression<Func<T, R>> propRef, Type attributeType)
        {
            var member = propRef.Body as MemberExpression;
            if (member == null)
            {
                throw new ArgumentException(string.Format("Expression '{0}' refers to a method, not a property.",
                                                          propRef.ToString()));
            }

            return member.Member.GetCustomAttributes(attributeType, true).FirstOrDefault();
        }
    }
}
