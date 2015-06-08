using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Bsdl.FreshTrade.Domain.PreInv.Entities;
using Bsdl.FreshTrade.Repositories.Basic.Interfaces;

namespace Bsdl.FreshTrade.Repositories.PreInv.Interfaces
{
    public interface IInvErrRepository : IRepositoryBase<DTOPreInvExtractionErrorsItem>
    {
        void DeleteByExtractSessionID(int extractSessionID);
    }
}
