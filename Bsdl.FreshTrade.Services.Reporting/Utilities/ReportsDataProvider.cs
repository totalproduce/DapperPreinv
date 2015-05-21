using System;
using System.Collections.Generic;
using Autofac;
using Autofac.Integration.Wcf;
using Bsdl.FreshTrade.Domain.Basic.Exceptions;
using Bsdl.FreshTrade.Services.ReportingDX.Interfaces;

namespace Bsdl.FreshTrade.Services.ReportingDX.Utilities
{
    public class ReportsDataProvider : IReportsDataProvider
    {

        public object Resolve(Type serviceType, bool useRootContainer = false)
        {
            if (useRootContainer)
            {
                return AutofacHostFactory.Container.Resolve(serviceType);
            }

            if (AutofacInstanceContext.Current != null)
            {
                return AutofacInstanceContext.Current.OperationLifetime.Resolve(serviceType);
            }
            throw new FreshTradeException("No operation context found");

        }
        public object GetData(ReportConfiguration configuration, Dictionary<string, string> reportParams)
        {
            var serviceType = Type.GetType(configuration.ServiceName);
            if (serviceType == null)
            {
                throw new FreshTradeException("Report DataService was not found");
            }
            var service = Resolve(serviceType);
            var method = serviceType.GetMethod(configuration.MethodName);
            return method.Invoke(service, new object[] { reportParams });
        }
    }
}
