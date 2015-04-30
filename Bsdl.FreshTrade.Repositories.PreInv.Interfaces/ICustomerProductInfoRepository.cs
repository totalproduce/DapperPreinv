using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Bsdl.FreshTrade.Domain.PreInv.Entities;
using Bsdl.FreshTrade.Repositories.Basic.Interfaces;

namespace Bsdl.FreshTrade.Repositories.PreInv.Interfaces
{
    public interface ICustomerProductInfoRepository : IRepositoryBase<DTOCustomerProductInfo>
    {
        List<DTOCustomerProductInfo> GetCustomerProductInfosByClientProductNos(List<string> clientProductNos);
    }
}
