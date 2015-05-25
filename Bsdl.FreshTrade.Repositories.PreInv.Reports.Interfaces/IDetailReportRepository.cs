using Bsdl.FreshTrade.Domain.PreInv.WideObjects;
using Bsdl.FreshTrade.Repositories.Basic.Interfaces;
using System.Collections.Generic;

namespace Bsdl.FreshTrade.Repositories.PreInv.Reports.Interfaces
{
    public interface IDetailReportRepository : IRepositoryBase<WideDetailReportItem>
    {
        List<WideDetailReportItem> GetByExtractSessionID(int extractSessionID);
        
    }
}
