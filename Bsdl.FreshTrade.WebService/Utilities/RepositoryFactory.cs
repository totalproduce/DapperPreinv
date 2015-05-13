using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Autofac;
using Autofac.Integration.Wcf;
using Bsdl.FreshTrade.Repositories.Basic.Interfaces;
using Bsdl.FreshTrade.Server.Basic.Interfaces;

namespace Bsdl.FreshTrade.WebService.Utilities
{
    public class RepositoryFactory : IRepositoryFactory
    {
        public T GetRepository<T>(IDictionary<string, object> parameters) where T : IRepositoryBase
        {
            return AutofacHostFactory.Container.Resolve<T>(parameters.Select(i => new NamedParameter(i.Key, i.Value)).ToList());
        }
    }
}