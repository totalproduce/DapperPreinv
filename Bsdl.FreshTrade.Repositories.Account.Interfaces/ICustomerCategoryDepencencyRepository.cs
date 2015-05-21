using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Bsdl.FreshTrade.Domain.Account.Entities;
using Bsdl.FreshTrade.Repositories.Basic.Interfaces;

namespace Bsdl.FreshTrade.Repositories.Account.Interfaces
{
    public interface ICustomerCategoryDepencencyRepository : IRepositoryBase<DTOCustomerCategoryDependency>
    {
        List<int> GetCustomersByCategories(List<int> ids);
    }
}
