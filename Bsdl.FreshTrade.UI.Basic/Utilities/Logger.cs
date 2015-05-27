using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace Bsdl.FreshTrade.UI.Basic.Utilities
{
	public static class Log
	{
		static readonly log4net.ILog _log;

		static Log()
		{
			log4net.Config.XmlConfigurator.Configure();
			_log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
		}

		public static void Warn(string message)
		{
			_log.Warn(message);
		}
	}
}
