using System;

namespace Bsdl.FreshTrade.Server.Basic.Interfaces
{
    public interface IEventsLogger
    {
        //void Log(string message);
        void LogException(Exception e);
    }
}
