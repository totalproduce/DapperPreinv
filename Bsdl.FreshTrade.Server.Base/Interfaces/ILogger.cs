using System;

namespace Bsdl.FreshTrade.Server.Basic.Interfaces
{
    public interface ILogger
    {
        void Flush(TimeSpan? maxTimeToWait = null);

        void Debug(string format, params object[] args);
        void Info(string format, params object[] args);
        void Error(string format, params object[] args);
        void Error(Exception exc, string format, params object[] args);
        void Fatal(string format, params object[] args);
    }
}
