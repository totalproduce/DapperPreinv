using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using Bsdl.FreshTrade.Domain.Basic.Enums;
using Bsdl.FreshTrade.Domain.Basic.Exceptions;

namespace Bsdl.FreshTrade.Domain.Basic.Utilities.DataTypeHandling
{
    /// <summary>
    /// Stores value and title of enum type.
    /// </summary>
    /// <typeparam name="TEnum">Type of enum</typeparam>
    [DebuggerDisplay("{typeof(TEnum).Name}: Value={Value}, Title={Title}")]
    public class EnumItem<TEnum>
    {
        public EnumItem(TEnum value, string title, string code)
        {
            IntValue = Convert.ToInt64(value);
            Value = value;
            Title = title;
            Code = code;
        }

        public Int64 IntValue { get; private set; }
        public TEnum Value { get; private set; }
        public string Code { get; private set; }
        public string Title { get; private set; }
    }

    /// <summary>
    /// Manages the list of enum items.
    /// </summary>
    /// <typeparam name="TEnum">Type of enum</typeparam>
    public class Enums<TEnum> where TEnum : struct
    {
        private static readonly bool HasFlags;
        private static readonly List<EnumItem<TEnum>> EnumItems;
        private static readonly Dictionary<TEnum, EnumItem<TEnum>> ByValueEnumItems;
        private static readonly Dictionary<string, EnumItem<TEnum>> ByCodeEnumItems;

        static Enums()
        {
            HasFlags = typeof(TEnum).GetCustomAttributes(typeof(FlagsAttribute), false).Any();
            EnumItems = BuildEnumItems();
            ByValueEnumItems = EnumItems.ToDictionary(e => e.Value, e => e);
            ByCodeEnumItems = EnumItems.ToDictionary(e => e.Code, e => e);
        }

        /*public IReadOnlyList<EnumItem<TEnum>> Items
        {
            get { return EnumItems; }
        }*/

        public EnumItem<TEnum> this[TEnum value]
        {
            get { return ByValueEnumItems[value]; }
        }

        public EnumItem<TEnum> this[string code]
        {
            get { return ByCodeEnumItems[code]; }
        }

        public static bool TryGetItem(TEnum value, out EnumItem<TEnum> item)
        {
            return ByValueEnumItems.TryGetValue(value, out item);
        }

        public static bool TryGetItem(string code, out EnumItem<TEnum> item)
        {
            return ByCodeEnumItems.TryGetValue(code, out item);
        }

        public static string GetTitle(TEnum? value)
        {
            if (value == null)
                return "(none)";

            EnumItem<TEnum> item;
            if (TryGetItem(value.Value, out item))
                return item.Title;

            if (HasFlags)
            {
                Int64 flags = Convert.ToInt64(value.Value);
                var title = string.Join(", ", EnumItems.Where(e => (e.IntValue & flags) == e.IntValue).Select(e => e.Title));
                if (title != "")
                    return title;
            }

            return typeof(TEnum).Name + ": " + value;
        }

        public static string GetCode(TEnum? value)
        {
            if (value == null)
                return "";
            EnumItem<TEnum> item;
            if (TryGetItem(value.Value, out item))
                return item.Code;
            if (HasFlags)
            {
                Int64 flags = Convert.ToInt64(value.Value);
                var title = string.Join(", ", EnumItems.Where(e => (e.IntValue & flags) != 0).Select(e => e.Code));
                return title;
            }
            return "";
        }

        public static TEnum? GetValueNullable(string code)
        {
            EnumItem<TEnum> item;
            if (code != null && TryGetItem(code, out item))
                return item.Value;
            return null;
        }

        public static TEnum GetValue(string code)
        {
            var result = GetValueNullable(code);
            if (!result.HasValue)
            {
                throw new FreshTradeException(string.Format("Enumarable {0} does not support code {1}", typeof(TEnum).FullName, code));
            }
            return result.Value;
        }

        public static TEnum? GetValueNullable(int? value)
        {
            if (!value.HasValue)
            {
                return null;
            }
            if (Enum.IsDefined(typeof(TEnum), value))
            {
                return (TEnum)Enum.ToObject(typeof(TEnum), value);
            }

            return null;
        }

        public static TEnum GetValue(int value)
        {
            var result = GetValueNullable((int?) value);
            if (!result.HasValue)
            {
                throw new FreshTradeException(string.Format("Enumarable {0} does not support value {1}", typeof(TEnum).FullName, value));
            }
            return result.Value;
        }

        public static string GetTitle(string code)
        {
            EnumItem<TEnum> item;
            if (code != null && TryGetItem(code, out item))
                return item.Title;
            return "(none)";
        }

        private static List<EnumItem<TEnum>> BuildEnumItems()
        {
            var result = new List<EnumItem<TEnum>>();
            var names = Enum.GetNames(typeof(TEnum));
            foreach (var name in names)
            {
                var value = (TEnum)Enum.Parse(typeof(TEnum), name, true);
                
                var attr = typeof(TEnum).GetField(name).GetCustomAttributes(false).OfType<EnumTitleAttribute>().FirstOrDefault();
                var title = attr != null && attr.Title != null ? attr.Title : name;
                var code = attr != null && attr.Code != null ? attr.Code : name;
                var enumItem = new EnumItem<TEnum>(value, title, code);

                result.Add(enumItem);
            }

            return result;
        }
    }
}
