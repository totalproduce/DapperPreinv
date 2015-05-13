using System;
using System.Collections;
using System.Data;
using System.Data.Common;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using Oracle.ManagedDataAccess.Client;
using Oracle.ManagedDataAccess.Types;

namespace Bsdl.FreshTrade.Repositories.Basic.persistance
{

    public static class SqlParam
    {
        public static DbParameter New(string name, object value)
        {
            if (value == null)
                return new OracleParameter(name, DBNull.Value);
            Type type = value.GetType();
            if (type.IsEnum)
            {
                value = Convert.ChangeType(value, Enum.GetUnderlyingType(type));
            }

            var param = new OracleParameter(name, value) { Direction = ParameterDirection.Input };
            return param;
        }

        public static DbParameter New(string name, Type type, ParameterDirection direction)
        {
            var oraDbType = GetOraType(type);
            var param = new OracleParameter(name, oraDbType, direction);
            return param;
        }

        private static Hashtable _oraTypeMap;

        private static OracleDbType GetOraType(Type type)
        {
            type = Nullable.GetUnderlyingType(type) ?? type;
            if (((type == typeof(bool)) || (type == typeof(sbyte))) || (((type == typeof(ushort)) || (type == typeof(uint))) || (type == typeof(ulong))))
            {
                throw new Exception("Type '{0}' is not supported by Oracle DB ");
            }

            var hash = _oraTypeMap;
            if (hash == null)
            {
                var typeOfDbTypeTable = Assembly.GetAssembly(typeof(OracleParameter)).GetTypes().First(t => t.Name == "OraDb_DbTypeTable");
                var fieldInfo = typeOfDbTypeTable.GetField("s_table", BindingFlags.Static | BindingFlags.NonPublic);
                Debug.Assert(fieldInfo != null, "fieldInfo != null");
                hash = (Hashtable)fieldInfo.GetValue(null);
                _oraTypeMap = hash;
            }
            var oraDbType = (OracleDbType)hash[type];
            return oraDbType;
        }

        public static object GetValue(DbParameter dbParameter)
        {
            object value = dbParameter.Value;
            if (value != null)
            {
                if (value is OracleString)
                {
                    var v = (OracleString)value;
                    if (v.IsNull)
                        return null;
                    return v.Value;
                }
                if (value is OracleDecimal)
                {
                    var v = (OracleDecimal)value;
                    if (v.IsNull)
                        return null;
                    return v.Value;
                }
                if (value is OracleTimeStamp)
                {
                    var v = (OracleTimeStamp)value;
                    if (v.IsNull)
                        return null;
                    return v.Value;
                }
                if (value is OracleDate)
                {
                    var v = (OracleDate)value;
                    if (v.IsNull)
                        return null;
                    return v.Value;
                }
                if (value is OracleBinary)
                {
                    var v = (OracleBinary)value;
                    if (v.IsNull)
                        return null;
                    return v.Value;
                }
                var clob = value as OracleClob;
                if (clob != null)
                {
                    var v = clob;
                    if (v.IsNull)
                        return null;
                    return v.Value;
                }
                var blob = value as OracleBlob;
                if (blob != null)
                {
                    var v = blob;
                    if (v.IsNull)
                        return null;
                    return v.Value;
                }
            }
            return value;
        }
    }

}
