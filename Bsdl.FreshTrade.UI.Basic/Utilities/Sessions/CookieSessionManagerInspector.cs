using System;
using System.Configuration;
using System.IO;
using System.Net;
using System.ServiceModel.Dispatcher;
using System.Threading;
using System.Xml;
using NLog;

namespace Bsdl.FreshTrade.UI.Basic.Utilities.Sessions
{
    using System.ServiceModel;
    using System.ServiceModel.Channels;

    public class CookieManagerMessageInspector : IClientMessageInspector
    {
        const string AspNetHeaderName = "Cookie";
        private const string _logReplyMessageSizeSettingName = "logReplyMessageSize";

        #region Singelton Implementation
        private static CookieManagerMessageInspector _instance;
        private static readonly object _lock = new object();

        private CookieManagerMessageInspector() { }
        public static CookieManagerMessageInspector Instance
        {
            get
            {
                if (_instance == null)
                {
                    lock (_lock)
                    {
                        if (_instance == null)
                        {
                            var temp = new CookieManagerMessageInspector();
                            Thread.MemoryBarrier();
                            _instance = temp;
                        }
                    }
                }
                return _instance;
            }
        }
        #endregion

        public void AfterReceiveReply(ref Message reply, object correlationState)
        {
            var messageSize = CalculateMessageSize(ref reply);
            try
            {
            var httpResponse = reply.Properties[HttpResponseMessageProperty.Name] as HttpResponseMessageProperty;
            if (httpResponse != null)
            {
                string cookie = httpResponse.Headers[AspNetHeaderName];

                if (!string.IsNullOrEmpty(cookie))
                {
                    Globals.UserSession = cookie;
                }
            }
            }
            finally
            {
                LogRequestFinish(reply, messageSize);
            }
        }

        public object BeforeSendRequest(ref Message request, IClientChannel channel)
        {
            LogRequestStart(request);
            // The HTTP request object is made available in the outgoing message only
            // when the Visual Studio Debugger is attacched to the running process
            if (!request.Properties.ContainsKey(HttpRequestMessageProperty.Name))
            {
                request.Properties.Add(HttpRequestMessageProperty.Name,
                    new HttpRequestMessageProperty());
            }

            var httpRequest = (HttpRequestMessageProperty)request.Properties[HttpRequestMessageProperty.Name];
            httpRequest.Headers.Add(HttpRequestHeader.Cookie, Globals.UserSession);

            return null;
        }

        private string ExtractOperationName(Message request)
        {
            var action = request.Headers.Action;
            return string.IsNullOrEmpty(action)
                ? string.Empty
                : action.Substring(action.LastIndexOf("/", StringComparison.InvariantCulture) + 1);
        }

        private readonly ClientRequestsPerformanceInfo _requestsInfo = new ClientRequestsPerformanceInfo();
        private void LogRequestStart(Message request)
        {
            var operationName = ExtractOperationName(request);
            var messageId = request.Headers.MessageId.ToString();
            _requestsInfo.Put(messageId, operationName);
            Log(String.Format("Request Start {0}, MessageId = {1}", operationName, messageId));
        }

        private void LogRequestFinish(Message reply, long? messageSize)
        {
            if (reply.Headers.RelatesTo == null)
            {
                return;
            }
            var messageId = reply.Headers.RelatesTo.ToString();
            var requestInfo = _requestsInfo.Get(messageId);
            if (requestInfo == null)
            {
                return;
            }

            var timetaken = new TimeSpan(DateTime.Now.Ticks - requestInfo.StartedAtTicksIndication);
            var messageSizeText = string.Empty;
            if (messageSize.HasValue)
            {
                messageSizeText = string.Format(", Message Size = {0} bytes", messageSize.Value);
            }

            Log(String.Format("Request End {0}, MessageId = {1}. Total Execution Time: {2} ms{3}", 
                requestInfo.OperationName, messageId, Math.Round(timetaken.TotalMilliseconds, 2), messageSizeText));
        }

        private static long? CalculateMessageSize(ref Message message)
        {
            var logMessageSize = ConfigurationManager.AppSettings.GetBooleanOrDefault(_logReplyMessageSizeSettingName);
            if (!logMessageSize)
            {
                return null;
            }
            var copy = CopyMessage(ref message);

            using (var ms = new MemoryStream())
            {
                using (var writer = XmlDictionaryWriter.CreateBinaryWriter(ms))
                {
                    copy.WriteMessage(writer);
                    return ms.Position;
                }
            }
        }

        private static Message CopyMessage(ref Message original)
        {
            // Create a copy of the original reply to allow default WCF processing
            var buffer = original.CreateBufferedCopy(Int32.MaxValue);
            try
            {
                // Restore the original message 
                original = buffer.CreateMessage();

                // Create a copy to work with
                return buffer.CreateMessage();

            }
            finally
            {
                buffer.Close();
            }
        }

        private void Log(string message)
        {
            LogManager.GetLogger("Default").Debug(message);
        }
    }
}
