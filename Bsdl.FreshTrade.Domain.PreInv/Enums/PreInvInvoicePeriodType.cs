using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace Bsdl.FreshTrade.Domain.PreInv.Enums
{
    [DataContract]
    public enum PreInvInvoicePeriodType
    {
        [EnumMember]
        DailyOnly = 1,

        [EnumMember]
        DailyAndWeekly = 2
    }
}
