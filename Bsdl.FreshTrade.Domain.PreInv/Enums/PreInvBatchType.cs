using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace Bsdl.FreshTrade.Domain.PreInv.Enums
{
    [DataContract]
    [Flags]
    public enum PreInvBatchType
    {
        [EnumMember]
        PerDelivery = 1,

        [EnumMember]
        PerOrder = 2,

        [EnumMember]
        PerCustomer = 4
    }
}
