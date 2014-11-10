using System;
using Bsdl.FreshTrade.Repositories.Basic.Interfaces;

namespace Bsdl.FreshTrade.Repositories.Basic.ErrorLog
{
    public class DapperErrorLogRepository : IErrorLogRepository
    {

        
        public void Add()
        {
    //INSERT INTO FRESHTRADEERRORLOG 
    //(ERRRECNO, ERRDATETIME, ERRUSERID, FTERRTYPE, FTERRNUMBER, FTERRMESS, FTCODESTACK, FTERRMETHOD, DBERRCODE, DBERRMESS, SQLSTRING)
    //(SELECT 
    //SP_WIZGETCONTROL('NXTFTERRRECNO', 1, 'CALLING CODE')ERRRECNO,
    //SYSDATE ERRDATETIME, 
    //1 ERRUSERID, 
    //1 FTERRTYPE, 
    //1 FTERRNUMBER, 
    //'' FTERRMESS, 
    //'' FTCODESTACK, 
    //'' FTERRMETHOD, 
    //'' DBERRCODE, 
    //'' DBERRMESS, 
    //'' SQLSTRING 
    //FROM DUAL)


            //if (Globals.FreshTradeUser == null)
            //{
            //    Globals.FreshTradeUser = new FreshTradeUser {Name = string.Empty, UserName = string.Empty};

            //}
            // Use classname and method in StackTrace field
/*AV 2014/05/22            string sql = @"INSERT INTO FRESHTRADEERRORLOG" + 
                            " (ERRRECNO, ERRDATETIME, ERRUSERID, FTERRTYPE, FTERRNUMBER, FTERRMESS, FTCODESTACK, FTERRMETHOD, DBERRCODE, DBERRMESS, SQLSTRING)" +
                            " (SELECT SP_WIZGETCONTROL('NXTFTERRRECNO', 1, 'CALLING CODE') ERRRECNO, " +
                            " SYSDATE ERRDATETIME " + 
                            "," + AppError.FreshTradeUserId.ToString() + 
                            "," + (int)AppError.ErrorType +
                            "," + 0 +
                            ",'" + FixSingleQuote(AppError.Message) + "'" +
                            ",'" + AppError.ClassName + "." + AppError.MethodName + "()'" +
                            ",'" + AppError.MethodName + "'" +
                            "," + 0 +
                            ",'" + AppError.OracleErrorCode + "'" +
                            ",'" + FixSingleQuote(AppError.OracleErrorSql) + "'" +
                            " FROM DUAL)";

            var connection = DatabaseConnectionPool.GetConnection();

            try
            {
                connection.Execute(sql);
            }
            catch (Exception ex)
            {
                throw;
            }
            finally
            {
                DatabaseConnectionPool.ReleaseConnection(connection);
            }*/
        }

        private string FixSingleQuote(string text)
        {
            return text.Replace("'", "''");
        }
    }
}
