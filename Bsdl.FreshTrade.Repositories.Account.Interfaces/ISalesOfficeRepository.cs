using System.Collections.Generic;
using Bsdl.FreshTrade.Domain.Account.Entities;
using Bsdl.FreshTrade.Domain.Account.Interfaces;
using Bsdl.FreshTrade.Domain.Basic.Interfaces;
using Bsdl.FreshTrade.Repositories.Basic.Interfaces;

namespace Bsdl.FreshTrade.Repositories.Account.Interfaces
{
    public interface ISalesOfficeRepository : IRepositoryBase<DTOSalesOffice>
    {
        DTOSalesOffice GetSalesOfficeByNo(int salOffNo, bool forceRefresh = false);
    }
}
