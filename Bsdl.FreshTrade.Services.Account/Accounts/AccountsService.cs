using Bsdl.FreshTrade.Domain.Account.Entities;
using Bsdl.FreshTrade.Domain.Account.Enums;
using Bsdl.FreshTrade.Domain.Account.Interfaces;
using Bsdl.FreshTrade.Domain.Basic.Entities;
using Bsdl.FreshTrade.Domain.Basic.Enums;
using Bsdl.FreshTrade.Domain.Basic.Exceptions;
using Bsdl.FreshTrade.Domain.Basic.Interfaces;
using Bsdl.FreshTrade.Domain.PreInv.WideObjects;
using Bsdl.FreshTrade.Repositories.Account.Interfaces;
using Bsdl.FreshTrade.Repositories.Basic.Interfaces;
using Bsdl.FreshTrade.Server.Basic.Interfaces;
using Bsdl.FreshTrade.Services.Account.Interfaces;
using Bsdl.FreshTrade.Services.Basic;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Bsdl.FreshTrade.Services.Account.Accounts
{
    public class AccountsService : FreshTradeServiceBase, IAccountsService
    {
        private IAccountRepository _accountRepository;
        protected IAccountRepository AccountRepository
        {
            get
            {
                if (_accountRepository == null)
                {
                    _accountRepository = UnitOfWorkCurrent.GetRepository<IAccountRepository>();
                }
                return _accountRepository;
            }
        }

        public AccountsService(IRepositoryFactory repositoryFactory)
            : base(repositoryFactory)
        {
        }

        public List<WideAccountInfo> GetAccountsBySalesOffice(int salesOfficeNo, DTOAccountType? accountType = null)
        {
            var searchFields = new List<ISearchField>
            {
                new SearchFieldGeneric<DTOAccount, int>(i => i.AcsSalOffNo).Apply(salesOfficeNo,
                    FieldType.Integer)
            };
            if (accountType.HasValue)
            {
                searchFields.Add(new SearchFieldGeneric<DTOAccount, DTOAccountType>(i => i.Type).Apply((int)accountType, FieldType.Integer));
            }
            var accounts = AccountRepository.GetData(searchFields, CachingStrategy.NoCache);
            var accountLocalCodes = AccountRepository.GetLocalAccounts(salesOfficeNo, accountType, CachingStrategy.NoCache);

            return accounts.Select(i => new WideAccountInfo(i, accountLocalCodes[i.Id])).ToList();
        }
    }    
}
