﻿using System;
using Bsdl.FreshTrade.Server.Basic.Interfaces;

namespace Bsdl.FreshTrade.Server.Basic.Logger
{
    internal class LazyLogger : ILogger
    {
        private readonly Lazy<ILogger> _logger;

        public LazyLogger(Func<ILogger> factory)
        {
            Ensure.NotNull(factory, "factory");
            _logger = new Lazy<ILogger>(factory);
        }

        public void Flush(TimeSpan? maxTimeToWait = null)
        {
            _logger.Value.Flush(maxTimeToWait);
        }

        public void Debug(string format, params object[] args)
        {
            _logger.Value.Debug(format, args);
        }

        public void Info(string format, params object[] args)
        {
            _logger.Value.Info(format, args);
        }

        public void Error(string format, params object[] args)
        {
            _logger.Value.Error(format, args);
        }

        public void Error(Exception exc, string format, params object[] args)
        {
            _logger.Value.Error(exc, format, args);
        }

        public void Fatal(string format, params object[] args)
        {
            _logger.Value.Fatal(format, args);
        }
    }
}