using System.Net;
using System.ServiceModel.Dispatcher;
using System.Threading;

namespace Bsdl.FreshTrade.UI.Basic.Utilities.Sessions
{
    using System.ServiceModel;
    using System.ServiceModel.Channels;

    public class CookieManagerMessageInspector : IClientMessageInspector
    {
        const string AspNetHeaderName = "Cookie";

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

        public object BeforeSendRequest(ref Message request, IClientChannel channel)
        {
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
    }
}
