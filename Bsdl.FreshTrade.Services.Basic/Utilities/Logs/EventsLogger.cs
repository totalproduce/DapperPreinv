using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Security;
using System.Text;
using System.Web;
using Bsdl.FreshTrade.Server.Basic.Interfaces;

namespace Bsdl.FreshTrade.Services.Basic.Utilities.Logs
{
    public class EventsLogger : IEventsLogger
    {
        /*public void Log(string message)
        {
            Elmah.ErrorLog.GetDefault(HttpContext.Current).Log(new Elmah.Error(new Exception(message)));
        }*/

        public void LogException(Exception e)
        {
            Elmah.ErrorSignal.FromCurrentContext().Raise(e);
        }
    }
}
