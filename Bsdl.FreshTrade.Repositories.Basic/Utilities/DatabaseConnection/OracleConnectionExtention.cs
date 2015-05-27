using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Xml.Serialization;
using Bsdl.FreshTrade.Server.Basic.Logger;
using Dapper;

namespace Bsdl.FreshTrade.Repositories.Basic.Utilities.DatabaseConnection
{
    /*This iclass is only required for debugging purposes - it will newer be used in production*/
    public static class OracleConnectionExtention
    {
        private static bool _doRecord = bool.Parse(ConfigurationManager.AppSettings["RecordData"]);

        public static IEnumerable<T> Query2<T>(this IDbConnection cnn, string sql, dynamic param = null, IDbTransaction transaction = null, bool buffered = true, int? commandTimeout = null, CommandType? commandType = null)
        {
            if (_doRecord)
            {
                var result = SqlMapper.Query<T>(cnn, sql, param, transaction, buffered, commandTimeout, commandType);
                SerializationHelper.Serialize((new List<T>((IEnumerable<T>)result)), sql);
                return result;
            }
            if (SerializationHelper.IsRecorded<T>(sql))
            {
                return SerializationHelper.Deserialize<T>(sql);
            }
            else
            {
                return SqlMapper.Query<T>(cnn, sql, param, transaction, buffered, commandTimeout, commandType);
            }
        }
    }

    public static class SerializationHelper
    {
        private static string _destinationFolder = AppDomain.CurrentDomain.BaseDirectory + @"StoredData";
        public static bool _initialized = false;

        public static void Serialize<T>(List<T> data, string sql)
        {
            XmlSerializer serializer = new XmlSerializer(typeof (List<T>));

            if ((!_initialized) && Directory.Exists(_destinationFolder))
            {
                string[] files = Directory.GetFiles(_destinationFolder);
                foreach (var file in files)
                {
                    File.Delete(file);
                }
                Directory.Delete(_destinationFolder);
            }
            Directory.CreateDirectory(_destinationFolder);
            var xmlFileName = string.Format(@"{0}\{1}_{2}_{3}.xml", _destinationFolder, sql.GetHashCode().ToString(),
                                      sql.Length, typeof (T).Name);
            if (!File.Exists(xmlFileName))
            {
                using (
                    var s =
                        File.Open(xmlFileName
                            , FileMode.CreateNew))
                {
                    serializer.Serialize(s, data);
                }
                using (
                    var s =
                        File.Open(
                            string.Format(@"{0}\{1}_{2}_{3}.sql", _destinationFolder, sql.GetHashCode().ToString(),
                                          sql.Length, typeof(T).Name), FileMode.CreateNew))
                {
                    using (StreamWriter writer = new StreamWriter(s))
                    {
                        writer.WriteLine(sql);
                    }
                }
            }
            _initialized = true;
        }

        public static bool IsRecorded<T>(string sql)
        {
            return File.Exists(string.Format(@"{0}\{1}_{2}_{3}.xml", _destinationFolder, sql.GetHashCode().ToString(), sql.Length, typeof(T).Name));
        }

        public static List<T> Deserialize<T>(string sql)
        {
            XmlSerializer serializer = new XmlSerializer(typeof (List<T>));

            Directory.CreateDirectory(_destinationFolder);
            using (
                var s =
                    File.Open(
                        string.Format(@"{0}\{1}_{2}_{3}.xml", _destinationFolder, sql.GetHashCode().ToString(),
                                      sql.Length, typeof (T).Name), FileMode.Open))
            {
                return (List<T>) serializer.Deserialize(s);
            }

        }
    }

    public static class CommandLogger
    {
        private static bool _doRecord = bool.Parse(ConfigurationManager.AppSettings["LogUpdate"] ?? "false");

        public static void Log(string sql, dynamic param = null)
        {
            if (!_doRecord) return;

            var _logger =  LogManager.GetLoggerFor<string>();

            _logger.Info(sql);
            var lParams = param as DynamicParameters;

            if (lParams == null) return;

            var buffer = new StringBuilder().AppendLine();

            foreach (var lPar in lParams.ParameterNames)
            {
                var ldata = lParams[lPar];
                XmlSerializer serializer = new XmlSerializer(ldata.GetType());

                using (StringWriter writer = new StringWriter())
                {
                    serializer.Serialize(writer, ldata);
                    var strData = writer.ToString();
                    if (strData.StartsWith("<?xml version"))
                    {
                        strData = strData.Remove(0, strData.IndexOf(">") + 1).Trim();
                    }
                    if (strData.StartsWith("<ArrayOf"))
                    {
                        strData = strData.Remove(0, strData.IndexOf(">") + 2).Trim();
                        strData = strData.Remove(strData.LastIndexOf("</"));
                    }
                    buffer.AppendLine(strData);
                }

            }

            _logger.Info(buffer.ToString());

        }
    }

}
