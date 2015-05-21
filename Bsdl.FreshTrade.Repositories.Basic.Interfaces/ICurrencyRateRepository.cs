using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Bsdl.FreshTrade.Domain.Basic.Entities;

namespace Bsdl.FreshTrade.Repositories.Basic.Interfaces
{
    public interface ICurrencyRateRepository: IRepositoryBase<DTOCurrencyRate>
    {
        DTOCurrencyRate GetRateByCurrencyNo(int curNo, int rateUseFor);

        decimal GetRateToEuro(int curNo, int rateUseFor);
        decimal GetRateFromEuro(int curNo, int rateUseFor);

        decimal GetRateToBase(int curNo, int rateUseFor);
        decimal GetRateFromBase(int curNo, int rateUseFor);


    }
}
