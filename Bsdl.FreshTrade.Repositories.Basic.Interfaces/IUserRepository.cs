using System.Collections.Generic;
using Bsdl.FreshTrade.Domain.Basic.Entities;
using Bsdl.FreshTrade.Domain.Basic.Interfaces;

namespace Bsdl.FreshTrade.Repositories.Basic.Interfaces
{
    public interface IUserRepository : IRepositoryBase<DTOUser>
    {
        List<DTOUser> GetData(int dbID, List<ISearchField> searchFields, CachingStrategy allowFromCache);

        DTOUser GetUserByNo(int logonNo);
        DTOUser GetUserByLogonName(int dbID, string logonName);
    }
}
