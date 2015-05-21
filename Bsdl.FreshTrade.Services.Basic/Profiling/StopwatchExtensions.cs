using System;
using System.Diagnostics;
using Bsdl.FreshTrade.Server.Basic.Interfaces;

namespace Bsdl.FreshTrade.Services.Basic.Profiling
{
    public static class StopwatchExtensions
    {
        public static long Profile(this ILogger logger, Action action, string actionDesc = "")
        {
            Stopwatch sw = new Stopwatch();
            sw.Reset();
            sw.Start();
            action();
            sw.Stop();
            logger.Debug(String.Format("{0,5}:{1} ms",actionDesc));
            return sw.ElapsedMilliseconds;
        }
    }
}
