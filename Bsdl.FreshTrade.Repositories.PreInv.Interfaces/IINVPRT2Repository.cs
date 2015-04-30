using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Bsdl.FreshTrade.Domain.PreInv.Entities;
using Bsdl.FreshTrade.Repositories.Basic.Interfaces;

namespace Bsdl.FreshTrade.Repositories.PreInv.Interfaces
{
    public interface IInvPrt2Repository : IRepositoryBase<DTOInvPrt2>
    {
        List<DTOInvPrt2> GetByExtractSessionID(int extractSessionID);
        void DeleteByExtractSessionID(int extractSessionID);
    }
}
