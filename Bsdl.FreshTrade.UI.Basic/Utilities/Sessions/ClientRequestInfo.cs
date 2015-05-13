using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bsdl.FreshTrade.UI.Basic.Utilities.Sessions
{
    public class ClientRequestPerformanceInfo
    {
        public string OperationName { get; set; }
        public long StartedAtTicksIndication { get; set; }
    }

    public class ClientRequestsPerformanceInfo
    {
        private readonly Dictionary<string, ClientRequestPerformanceInfo> _requests = new Dictionary<string, ClientRequestPerformanceInfo>();
        private readonly object _locker = new object();

        public void Put(string messageId, string operationName)
        {
            lock (_locker)
            {
                _requests.Add
                    (
                        messageId,
                        new ClientRequestPerformanceInfo
                        {
                            OperationName = operationName,
                            StartedAtTicksIndication = DateTime.Now.Ticks
                        }
                    );
            }
        }

        public ClientRequestPerformanceInfo Get(string messageId)
        {
            lock (_locker)
            {
                ClientRequestPerformanceInfo result;
                if (_requests.TryGetValue(messageId, out result))
                {
                    _requests.Remove(messageId);
                    return result;
                }
                return null;
            }
        }

    }
}
