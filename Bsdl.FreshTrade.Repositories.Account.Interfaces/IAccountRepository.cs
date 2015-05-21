using System.Collections.Generic;
using Bsdl.FreshTrade.Domain.Account.Entities;
using Bsdl.FreshTrade.Domain.Account.Enums;
using Bsdl.FreshTrade.Domain.Account.Interfaces;
using Bsdl.FreshTrade.Repositories.Basic.Interfaces;

namespace Bsdl.FreshTrade.Repositories.Account.Interfaces
{
    public interface IAccountRepository : IRepositoryBase<DTOAccount>
    {
        List<DTOAccount> GetAccountByAccClassIDs(List<int> ids);
        Dictionary<int, string> GetLocalAccounts(int salesOfficeNo, List<int> accountClassIds);
        Dictionary<int, string> GetLocalAccounts(int salesOfficeNo, DTOAccountType? accountType, CachingStrategy strategy);
    }
}
