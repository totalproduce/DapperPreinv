using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Bsdl.FreshTrade.Domain.PreInv.Entities;
using Bsdl.FreshTrade.Repositories.Basic.Interfaces;

namespace Bsdl.FreshTrade.Repositories.PreInv.Interfaces
{
    public interface IPriceGroupRepository : IRepositoryBase<DTOPriceGroupLookupResult>
    {
        List<DTOPriceGroupLookupResult> GetPriceGroupsByIDs(List<int> accountClassIds);
        Dictionary<int, int> GetAlternativePriceGroupsByIDs(List<int> accountClassIds);
        string GetPriceGroupDescription(int priceGroupId);
    }
}
