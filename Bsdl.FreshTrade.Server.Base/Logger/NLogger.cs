using System;
using System.Linq;
using System.Threading;
using Bsdl.FreshTrade.Server.Basic.Interfaces;
using NLog.Targets.Wrappers;

namespace Bsdl.FreshTrade.Server.Basic.Logger
{
    internal class NLogger : ILogger
    {
        private readonly NLog.Logger _logger;

        public NLogger(string name)
        {
            _logger = NLog.LogManager.GetLogger(name);
        }

        public void Flush(TimeSpan? maxTimeToWait = null)
        {
            FlushLog(maxTimeToWait);
        }

        public void Debug(string format, params object[] args)
        {
            _logger.Debug(format, args);
        }

        public void Info(string format, params object[] args)
        {
            _logger.Info(format, args);
        }

        public void Error(string format, params object[] args)
        {
            _logger.Error(format, args);
        }

        public void Error(Exception exc, string format, params object[] args)
        {
            _logger.ErrorException(string.Format(format, args), exc);
        }

        public void Fatal(string format, params object[] args)
        {
            _logger.Fatal(format, args);
        }

        public static void FlushLog(TimeSpan? maxTimeToWait = null)
        {
            var config = NLog.LogManager.Configuration;
            if (config == null)
                return;
            var asyncs = config.AllTargets.OfType<AsyncTargetWrapper>().ToArray();
            var countdown = new CountdownEvent(asyncs.Length);
            foreach (var wrapper in asyncs)
            {
                wrapper.Flush(x => countdown.Signal());
            }
            countdown.Wait(maxTimeToWait ?? TimeSpan.FromMilliseconds(500));
        }
    }
}