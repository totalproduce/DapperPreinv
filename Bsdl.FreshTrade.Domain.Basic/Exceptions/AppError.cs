using System;
using System.Diagnostics;
using Bsdl.FreshTrade.Domain.Basic.Enums;

namespace Bsdl.FreshTrade.Domain.Basic.Exceptions
{

    public class AppError
    {
        private int Depth { get; set; }

        public string ConnectionString { get; set; }

        public int FreshTradeUserId { get; set; }

        public bool Error { get; set; }

        public string ClassName { get; set; }

        public string MethodName { get; set; }

        public string StackTrace { get; set; }

        public string Message { get; set; }

        public ErrorType ErrorType { get; set; }

        public string OracleErrorCode { get; set; }

        public string OracleErrorSql { get; set; }

        public void Clear()
        {
            Error = false;
            ClassName = string.Empty;
            MethodName = String.Empty;

            StackTrace = string.Empty;
            Message = string.Empty;
            ErrorType = 0;
            OracleErrorCode = string.Empty;
            OracleErrorSql = string.Empty;
        }

        public void SetError(string message, string stackTrace, ErrorType errorType)
        {
            Depth++;
            SetError(new Exception(message), stackTrace, errorType, null, null);
        }

        public static void SetError(Exception ex, string stackTrace, ErrorType errorType)
        {
            throw new FreshTradeException("NIY");
            //Depth++;
            //SetError(ex, stackTrace, errorType, null, null);
        }

        public void SetError(Exception ex, string stackTrace, ErrorType errorType, string oracleErrorCode, string oracleErrorSql)
        {
            //Clear();
            var method = new StackTrace().GetFrame(1 + Depth).GetMethod();
            Depth = 0;

            Error = true;
            ClassName = method.ReflectedType.FullName;
            MethodName = method.Name;

            StackTrace = stackTrace;
            if (string.IsNullOrWhiteSpace(StackTrace))
            {
                StackTrace = method.ReflectedType.Name + "." + MethodName + "()";
            }

            Message = ex.Message ?? string.Empty;
            ErrorType = errorType;
            OracleErrorCode = oracleErrorCode ?? string.Empty;
            OracleErrorSql = oracleErrorSql ?? string.Empty;
        }

    }
}
