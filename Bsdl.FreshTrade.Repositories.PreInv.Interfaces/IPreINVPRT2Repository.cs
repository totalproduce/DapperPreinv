using Bsdl.FreshTrade.Domain.PreInv.Entities;
using Bsdl.FreshTrade.Repositories.Basic.Interfaces;
using System.Collections.Generic;

namespace Bsdl.FreshTrade.Repositories.PreInv.Interfaces
{
    public interface IPreInvPrt2Repository : IRepositoryBase<DTOInvPrt2>
    {
        List<DTOInvPrt2> GetInvPrt2ByExtractionSessionId(int extractionSessionId, List<int> recNoList);
        void DeleteByExtractSessionID(int extractSessionID);
    }
}
