using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using Bsdl.FreshTrade.Domain.Basic.Enums;

namespace Bsdl.FreshTrade.Domain.PreInv.Enums
{
    public enum DTODeliveryStatus
    {
        [EnumTitle(Code = "Pik")]
        Picked = 1,

        [EnumTitle(Code = "Dlv")]
        Delivered = 2,
        
        [EnumTitle(Code = "Rel")]
        Released = 3, //for Invoicing
        
        [EnumTitle(Code = "Inv")]
        Invoiced = 4
    }
}
