using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Bsdl.FreshTrade.Repositories.Basic.Utilities.Interfaces;

namespace Bsdl.FreshTrade.Services.Basic.Interfaces
{
    public interface IFreshTradeServiceBase
    {
        void AssignUnitOfWork(IUnitOfWork unitOfWork);
    }
}
