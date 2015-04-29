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
        Picked,

        [EnumTitle(Code = "Dlv")]
        Delivered,
        
        [EnumTitle(Code = "Rel")]
        Released, //for Invoicing
        
        [EnumTitle(Code = "Inv")]
        Invoiced
    }
}
