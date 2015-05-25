using System.Collections.Generic;
using Bsdl.FreshTrade.Repositories.Basic.Interfaces;

namespace Bsdl.FreshTrade.Server.Basic.Interfaces
{
    public interface IRepositoryFactory
    {
        T GetRepository<T>(IDictionary<string, object> parameters) where T : IRepositoryBase;
    }
}
