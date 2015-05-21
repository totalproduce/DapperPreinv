using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Runtime.Serialization;
using Bsdl.FreshTrade.Domain.Basic.Enums;
using Bsdl.FreshTrade.Domain.Basic.Exceptions;
using Bsdl.FreshTrade.Domain.Basic.Interfaces;
using Bsdl.FreshTrade.Domain.Basic.Utilities.DataTypeHandling;

namespace Bsdl.FreshTrade.Domain.Basic.Entities
{

    [DataContract]
    public class SearchFieldGeneric : ISearchField
    {
        public SearchFieldGeneric()
        {
        }

        public SearchFieldGeneric(string fieldName)
            : this(string.Empty, fieldName, false, false)
        {
        }

        public SearchFieldGeneric(string displayName, string fieldName)
            : this(displayName, fieldName, false, false)
        {
        }

        public SearchFieldGeneric(string displayName, string fieldName, bool includeLike, bool freeFormatSpecial)
        {
            this.DisplayName = displayName;
            this.FieldName = fieldName;
            this.IncludeLike = includeLike;
            this.FreeFormatSpecial = freeFormatSpecial;
        }

        public string DisplayName { get; private set; }

        public string FieldName { get; private set; }

        public object Value { get; private set; }

        public ISearchField Apply(object dataValue, FieldType fieldType)
        {
            object data = dataValue;

            switch (fieldType)
            {
                case FieldType.AlphaNumeric:
                    if (!AlphaHandling.IsAlpha(data.ToString()))
                    {
                        throw new FreshTradeException("Value should be AlphaNumeric");
                    }
                    break;

                case FieldType.Integer:
                    if (data is Enum)
                    {
                        data = Convert.ToInt32((Enum)data);
                    }
                    else
                    if (!IntegerHandling.IsInteger(Convert.ToString(data)))
                    {
                        throw new FreshTradeException("Value should be Integer");
                    }
                    break;

                case FieldType.Decimal:
                    break;
                case FieldType.Date:
                    break;
                case FieldType.Bool:
                    break;
                case FieldType.List:
                    var tmp = data as IEnumerable;
                    if (tmp == null)
                    {
                        throw new FreshTradeException("Value should support IEnumerable");
                    }
                    break;
                case FieldType.FreeFormat:
                    break;
                default:
                    // error
                    throw new FreshTradeException("Unknown data type");
            }

            this.Value = data;

            return this;
        }

        public bool IncludeLike { get; private set; }

        public bool FreeFormatSpecial { get; private set; }
    }

    public class SearchFieldGeneric<T, R> : SearchFieldGeneric
    {
        public SearchFieldGeneric(Expression<Func<T, R>> fieldRef)
            : base(DelegateHelpers.GetPropertyNameFromExpression(fieldRef))
        {
        }
    }

}
