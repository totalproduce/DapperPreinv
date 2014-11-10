using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Bsdl.FreshTrade.Domain.PreInv.WideObjects;
using Bsdl.FreshTrade.Repositories.Basic.Interfaces;

namespace Bsdl.FreshTrade.Repositories.PreInv.Reports.Interfaces
{
    public interface IErrorReportRepository : IRepositoryBase<WideErrorReportItem>
    {
        List<WideErrorReportItem> GetByExtractSessionID(int extractSessionID);
    }
}
