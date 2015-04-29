using System.Collections.Generic;
using Bsdl.FreshTrade.Domain.PreInv.Entities;
using Bsdl.FreshTrade.Repositories.Basic.Interfaces;

namespace Bsdl.FreshTrade.Repositories.PreInv.Interfaces
{
    public interface IInvTotRepository : IRepositoryBase<DTOInvTot>
    {
        List<DTOInvTot> GetByExtractSessionID(int extractSessionID);
        void DeleteByExtractSessionID(int extractSessionID);
    }
}
