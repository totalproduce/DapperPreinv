using Bsdl.FreshTrade.Domain.PreInv.Entities;
using Bsdl.FreshTrade.Repositories.Basic.Interfaces;
using System.Collections.Generic;

namespace Bsdl.FreshTrade.Repositories.PreInv.Interfaces
{
    public interface IPreInvDiscTypRepository : IRepositoryBase<DTOInvDiscTyp>
    {
        List<DTOInvDiscTyp> GetByExtractSessionID(int extractSessionID);
        void DeleteByExtractSessionID(int extractSessionID);
    }
}
