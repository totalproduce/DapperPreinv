using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Bsdl.FreshTrade.Repositories.Basic.Interfaces;

namespace Bsdl.FreshTrade.Repositories.PreInv.Interfaces
{
    public interface IAccToProcessRepository : IRepositoryBase<int>
    {
        List<int> GetAccToProcess(int currencyNo, int salesOfficeNo, List<int> preFilteredAccClassIDs = null);
    }
}
