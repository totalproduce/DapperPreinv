using System.Runtime.Serialization;

namespace Bsdl.FreshTrade.Domain.Account.Enums
{
    [DataContract]
    public enum DTOAccountType
    {
        [EnumMember]
        Customer = 1,

        [EnumMember]
        Supplier = 2,

        [EnumMember]
        Misc = 3,

        [EnumMember]
        SelfCost = 4,

        [EnumMember]
        Factor = 5
    }
}
