using System.Collections.Generic;
using Bsdl.FreshTrade.Domain.PreInv.Entities;
using Bsdl.FreshTrade.Repositories.Basic.Interfaces;

namespace Bsdl.FreshTrade.Repositories.PreInv.Interfaces
{
    public interface IPreInvTotRepository : IRepositoryBase<DTOInvTot>
    {
        List<DTOInvTot> GetInvTotByExtractionSessionId(int extractionSessionID, List<string> invoiceList);
        void DeleteByExtractSessionID(int extractSessionID);
    }
}
