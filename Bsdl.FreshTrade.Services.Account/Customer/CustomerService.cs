using Bsdl.FreshTrade.Domain.Account.Entities;
using Bsdl.FreshTrade.Domain.Basic.Entities;
using Bsdl.FreshTrade.Domain.Basic.Enums;
using Bsdl.FreshTrade.Domain.Basic.Interfaces;
using Bsdl.FreshTrade.Repositories.Account.Interfaces;
using Bsdl.FreshTrade.Repositories.Basic.Interfaces;
using Bsdl.FreshTrade.Server.Basic.Interfaces;
using Bsdl.FreshTrade.Services.Account.Interfaces;
using System;
using System.Collections.Generic;
using Bsdl.FreshTrade.Services.Basic;

namespace Bsdl.FreshTrade.Services.Account.Customer
{
    public class CustomerService : FreshTradeServiceBase, ICustomerService
    {

        private ICustomerGroupRepository _custGroupRepository;
        protected ICustomerGroupRepository CustGroupRepository
        {
            get
            {
                return _custGroupRepository ??
                       (_custGroupRepository = UnitOfWorkCurrent.GetRepository<ICustomerGroupRepository>());
            }
        }

        private ICustomerCategoryRepository _custCatRepository;
        protected ICustomerCategoryRepository CustCatRepository
        {
            get
            {
                return _custCatRepository ??
                       (_custCatRepository = UnitOfWorkCurrent.GetRepository<ICustomerCategoryRepository>());
            }
        }

        public CustomerService(IRepositoryFactory repositoryFactory)
            : base(repositoryFactory)
        { }

        public List<DTOCustomerGroup> GetCustomerGroups(bool isCustomer)
        {
            return CustGroupRepository.GetData(
                new List<ISearchField>()
                {
                            new SearchFieldGeneric<DTOCustomerGroup, int>(i => i.Type)
                                .Apply(isCustomer ? 1 : 2 , FieldType.Integer)
                },
                CachingStrategy.GlobalCache);
        }

        public List<DTOCustomerCategory> GetCustomerCategoriesByGroup(int custGroupId)
        {
            return CustCatRepository.GetData(
                new List<ISearchField>()                
                {
                            new SearchFieldGeneric<DTOCustomerCategory, int?>(i => i.GroupId)
                                .Apply(custGroupId , FieldType.Integer)
                },
                CachingStrategy.GlobalCache);

        }
    }
}
