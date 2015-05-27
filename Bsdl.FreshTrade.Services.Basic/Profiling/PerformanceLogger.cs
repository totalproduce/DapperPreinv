using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using Bsdl.FreshTrade.Domain.Basic.Utilities.DataTypeHandling;
using Bsdl.FreshTrade.Server.Basic;
using Bsdl.FreshTrade.Server.Basic.Interfaces;

namespace Bsdl.FreshTrade.Services.Basic.Profiling
{
    public class PerformanceLogger
    {
        private ILogger _logger;
        private readonly Stopwatch _timer;
        private readonly Stack<long> _loops;

        public PerformanceLogger(ILogger logger)
        {
            _timer = new Stopwatch();
            _loops = new Stack<long>();
            _logger = logger;
        }

        public void Start(string message="", bool autoPushTime = true) {
            if (!String.IsNullOrEmpty(message)) _logger.Debug(message);
            _timer.Start();
            if (autoPushTime)
            {
                PushTime(message);
            }
        }

        public void Stop(string message="", bool autoPopTime = true)
        {
            if (autoPopTime)
            {
                PopTime(message);
            }
            if (!String.IsNullOrEmpty(message)) _logger.Debug(message);
            _timer.Stop();
        }

        public void PushTime(string message="") {
            if (!String.IsNullOrEmpty(message)) _logger.Debug(message);
            _loops.Push(_timer.ElapsedMilliseconds);
        }

        public long PopTime(string message="")
        {            
            var ident = new string(' ', _loops.Count);
            long elapsed = _timer.ElapsedMilliseconds - _loops.Pop();
            var elapsedStr = elapsed.ToString().PadRight(5, ' ');
            _logger.Debug(String.Format("{0}ms{1}{1} | {2}",elapsedStr,ident,message));
            return _timer.ElapsedMilliseconds;
        }
    }
}
