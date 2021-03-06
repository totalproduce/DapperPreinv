﻿using System;
using System.Collections.ObjectModel;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.ServiceModel.Description;
using System.ServiceModel.Dispatcher;

namespace Bsdl.FreshTrade.Services.Basic.Utilities.Errors
{
    public class ServiceErrorBehaviorAttribute : Attribute, IServiceBehavior
    {
        private readonly Type _errorHandlerType;

        public ServiceErrorBehaviorAttribute(Type errorHandlerType)
        {
            _errorHandlerType = errorHandlerType;
        }

        #region IServiceBehavior Members
        public void AddBindingParameters(ServiceDescription serviceDescription, ServiceHostBase serviceHostBase, Collection<ServiceEndpoint> endpoints, BindingParameterCollection bindingParameters)
        {
        }

        public void ApplyDispatchBehavior(ServiceDescription serviceDescription, ServiceHostBase serviceHostBase)
        {
            var errorHandler = Activator.CreateInstance(_errorHandlerType) as IErrorHandler;
            if (errorHandler != null)
            {
                foreach (ChannelDispatcherBase dispatcher in serviceHostBase.ChannelDispatchers)
                {
                    var cd = dispatcher as ChannelDispatcher;
                    if (cd != null)
                    {
                        cd.ErrorHandlers.Add(errorHandler);
                    }
                }
            }
        }

        public void Validate(ServiceDescription serviceDescription, ServiceHostBase serviceHostBase)
        {
        }
        #endregion
    }

}