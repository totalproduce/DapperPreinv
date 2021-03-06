﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Bsdl.FreshTrade.Domain.PreInv.Entities;
using Bsdl.FreshTrade.Repositories.Basic.Interfaces;

namespace Bsdl.FreshTrade.Repositories.PreInv.Interfaces
{
    public interface IDeliveryDetailRepository: IRepositoryBase<DTODeliveryDetail>
    {
        List<DTODeliveryDetail> GetDeliveryDetailByDeliveryHeadIDs(List<int> deliveryHeadIds);
    }
}
