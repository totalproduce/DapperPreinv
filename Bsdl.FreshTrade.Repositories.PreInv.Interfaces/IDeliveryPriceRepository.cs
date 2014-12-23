using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Bsdl.FreshTrade.Domain.PreInv.Entities;
using Bsdl.FreshTrade.Repositories.Basic.Interfaces;

namespace Bsdl.FreshTrade.Repositories.PreInv.Interfaces
{
    public interface IDeliveryPriceRepository : IRepositoryBase<DTODeliveryPrice>
    {
        List<DTODeliveryPrice> GetDeliveryPriceByDeliveryDetailIDs(List<int> deliveryDetailIds);
        List<DTODeliveryPrice> GetDeliveryPriceByDprRecNos(List<int> recnos);

        void EnqueueForCosting(List<int> deliveryPriceIds);
    }
}
