using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Bsdl.FreshTrade.Domain.PreInv.Entities;
using Bsdl.FreshTrade.Repositories.Basic.Interfaces;

namespace Bsdl.FreshTrade.Repositories.PreInv.Interfaces
{
    public interface IINVPRTRepository : IRepositoryBase<DTOInvPrt>
    {
        List<DTOInvPrt> GetByExtractSessionID(int extractSessionID);
        void DeleteByExtractSessionID(int extractSessionID);
    }
}
