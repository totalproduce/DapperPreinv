using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace Bsdl.FreshTrade.Domain.PreInv.Enums
{
    [DataContract]
    public enum PreInvExtractStatusType
    {
        [EnumMember]
        OK = 1,

        [EnumMember]
        NothingToExtract = 2,

        [EnumMember]
        Failed = 3
    }
}
