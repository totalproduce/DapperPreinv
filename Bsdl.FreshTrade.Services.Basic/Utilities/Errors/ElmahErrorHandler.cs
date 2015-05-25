using System;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.ServiceModel.Dispatcher;
using System.Web;
using Bsdl.FreshTrade.Domain.Basic.Exceptions;

namespace Bsdl.FreshTrade.Services.Basic.Utilities.Errors
{
    public class ElmahErrorHandler: IErrorHandler
    {
        #region IErrorHandler Members
        public bool HandleError(Exception error)
        {
            return false;
        }

        public void ProvideFault(Exception error, MessageVersion version, ref Message fault)
        {
            if (error == null)
            {
                return;
            }
            if (HttpContext.Current == null) 
            {
                return;
            }
            Elmah.ErrorSignal.FromCurrentContext().Raise(error);
            WrapExceptions(error, version, ref fault);
        }
        #endregion

        private void WrapExceptions(Exception error, MessageVersion version, ref Message fault)
        {
            // don't wrap existing fault exceptions
            if ((error is FaultException)) return;

            var faultException = new FaultException(error.Message);

            // Create message fault
            var messageFault = faultException.CreateMessageFault();

            // Create message using Message Factory method
            fault = Message.CreateMessage(version, messageFault, faultException.Action);
        }
    }
}