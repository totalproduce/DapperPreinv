using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Bsdl.FreshTrade.Domain.PreInv.Entities;
using Bsdl.FreshTrade.Repositories.Basic.Interfaces;

namespace Bsdl.FreshTrade.Repositories.PreInv.Interfaces
{
    public interface IAccVATRepository : IRepositoryBase<DTOAccVAT>
    {
        List<DTOAccVAT> GetByAtrRecNos(List<int> atrRecNos);
    }
}
