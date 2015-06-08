using System;
using System.Globalization;
using System.Text;

namespace Bsdl.FreshTrade.Repositories.Basic.Persistance
{
    /// <summary>
    /// SQL helper class
    /// Converts C# values to SQL constants.
    /// </summary>
    public static class SqlHelper
    {
        public const string NULL = "NULL";

        public static string ObjToSqlConst(this object obj, bool logMode = false)
        {
            if (obj == null)
                return NULL;
            var type = obj.GetType();
            TypeCode tc = Type.GetTypeCode(type);
            switch (tc)
            {
                //case TypeCode.Empty:
                case TypeCode.Object:
                    var arr = obj as byte[];
                    if (arr != null)
                        return arr.ToSqlConst();
                    goto default;
                case TypeCode.DBNull:
                    return NULL;
                //case TypeCode.Boolean:
                case TypeCode.Char:
                    return ((char)obj).ToSqlConst();
                case TypeCode.SByte:
                    return ((SByte)obj).ToSqlConst();
                case TypeCode.Byte:
                    return ((Byte)obj).ToSqlConst();
                case TypeCode.Int16:
                    return ((Int16)obj).ToSqlConst();
                case TypeCode.UInt16:
                    return ((UInt16)obj).ToSqlConst();
                case TypeCode.Int32:
                    return ((Int32)obj).ToSqlConst();
                case TypeCode.UInt32:
                    return ((UInt32)obj).ToSqlConst();
                case TypeCode.Int64:
                    return ((Int64)obj).ToSqlConst();
                case TypeCode.UInt64:
                    return ((UInt64)obj).ToSqlConst();
                case TypeCode.Single:
                    return ((Single)obj).ToSqlConst();
                case TypeCode.Double:
                    return ((Double)obj).ToSqlConst();
                case TypeCode.Decimal:
                    return ((Decimal)obj).ToSqlConst();
                case TypeCode.DateTime:
                    return ((DateTime)obj).ToSqlConst();
                case TypeCode.String:
                    return ((String)obj).ToSqlConst();
                default:
                    string arrOf = null;
                    if (type.IsArray)
                    {
                        arrOf = "array of ";
                        tc = Type.GetTypeCode(type.GetElementType());
                    }
                    var message = string.Format("ObjToSqlConst does not support '{0}{1}'", arrOf, tc);
                    if (!logMode)
                        throw new ArgumentOutOfRangeException(message);

                    return message;

            }
        }

        public static string ToSqlConst(this char c)
        {
            return ToSqlConst(c.ToString(CultureInfo.InvariantCulture));
        }

        public static string ToSqlConst(this string str)
        {
            return str != null ? "'" + str.Replace("'", "''") + "'" : NULL;
        }

        public static string ToSqlConst(this DateTime? val)
        {
            return val == null ? NULL : val.Value.ToSqlConst();
        }

        public static string ToSqlConst(this DateTime dateTime)
        {
            return dateTime.ToString(@"'TIMESTAMP'\'yyyy-MM-dd HH:mm:ss.fff\'", CultureInfo.InvariantCulture.DateTimeFormat);
        }

        public static string ToSqlConst(this Byte val)
        {
            return val.ToString(CultureInfo.InvariantCulture.NumberFormat);
        }

        public static string ToSqlConst(this SByte val)
        {
            return val.ToString(CultureInfo.InvariantCulture.NumberFormat);
        }

        public static string ToSqlConst(this Int16 val)
        {
            return val.ToString(CultureInfo.InvariantCulture.NumberFormat);
        }

        public static string ToSqlConst(this UInt16 val)
        {
            return val.ToString(CultureInfo.InvariantCulture.NumberFormat);
        }

        public static string ToSqlConst(this Int32 val)
        {
            return val.ToString(CultureInfo.InvariantCulture.NumberFormat);
        }

        public static string ToSqlConst(this UInt32 val)
        {
            return val.ToString(CultureInfo.InvariantCulture.NumberFormat);
        }

        public static string ToSqlConst(this Int64 val)
        {
            return val.ToString(CultureInfo.InvariantCulture.NumberFormat);
        }

        public static string ToSqlConst(this Int64? val)
        {
            return val == null ? NULL : val.Value.ToSqlConst();
        }

        public static string ToSqlConst(this UInt64 val)
        {
            return val.ToString(CultureInfo.InvariantCulture.NumberFormat);
        }

        public static string ToSqlConst(this UInt64? val)
        {
            return val == null ? NULL : val.Value.ToSqlConst();
        }

        public static string ToSqlConst(this Single val)
        {
            return val.ToString(CultureInfo.InvariantCulture.NumberFormat);
        }

        public static string ToSqlConst(this Double val)
        {
            return val.ToString(CultureInfo.InvariantCulture.NumberFormat);
        }

        public static string ToSqlConst(this Decimal val)
        {
            return val.ToString(CultureInfo.InvariantCulture.NumberFormat);
        }

        public static string ToSqlConst(this byte[] val)
        {
            if (val == null)
                return NULL;
            return string.Format("(BLOB, LEN={0} bytes)", val.Length); //only for sql logging
        }

        public static string ToInSqlConst<T>(this T[] items, string fieldName, Func<T, string> itemToSqlFunc)
        {
            if (items == null || items.Length == 0)
                return "(1=0)";
            var sb = new StringBuilder();
            sb.Append('(');
            for (int i0 = 0, n = @items.Length; i0 < n; i0 += 1000)
            {
                if (i0 > 0)
                    sb.Append(" OR ");
                sb.Append(fieldName);
                sb.Append(" IN (");
                for (int i = i0; i < n && i < i0 + 1000; i++)
                {
                    if (i > i0)
                        sb.Append(',');
                    sb.Append(itemToSqlFunc(items[i]));
                }
                sb.Append(')');
            }
            sb.Append(')');
            return sb.ToString();
        }
    }
}
