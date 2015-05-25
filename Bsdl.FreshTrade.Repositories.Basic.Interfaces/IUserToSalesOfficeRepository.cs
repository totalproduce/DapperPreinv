using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Bsdl.FreshTrade.Domain.Basic.Entities;

namespace Bsdl.FreshTrade.Repositories.Basic.Interfaces
{
    public interface IUserToSalesOfficeRepository : IRepositoryBase<DTOUserToSalesOffice>
    {
        List<int> GetUserSalesOffices(int userId, bool? canSell, bool? canAccount, bool? canChangeStock);
    }
}
