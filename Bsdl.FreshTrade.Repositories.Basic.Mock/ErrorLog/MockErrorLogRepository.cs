using System.IO;
using Bsdl.FreshTrade.Domain.Basic.Exceptions;
using Bsdl.FreshTrade.Repositories.Basic.Interfaces;

namespace Bsdl.FreshTrade.Repositories.Basic.Mock.ErrorLog
{
    public class MockErrorLogRepository : IErrorLogRepository
    {
        private const string ErrorLogFileName = "MockErrorLog.txt";

        public void Add()
        {
            if (!File.Exists(ErrorLogFileName))
            {
                var file = File.Create(ErrorLogFileName);
                file.Close();
            }

            using (StreamWriter w = File.AppendText(ErrorLogFileName))
            {
//                string line = AppError.ClassName.Trim() + "," + AppError.MethodName.Trim() + "," + Globals.FreshTradeUser.UserName + "," + AppError.Message;
                string line = "AppError.StackTrace";
                w.WriteLine(line);
            }

        }

    }
}

