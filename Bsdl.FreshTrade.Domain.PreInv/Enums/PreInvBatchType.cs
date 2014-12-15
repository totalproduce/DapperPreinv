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

    public static class PreInvBatchTypeExtentions
    {
        public static string ConvertToString(this PreInvBatchType batchType)
        {
            //TODO: decide the grouping of strings
            var result = new StringBuilder();
            if ((batchType & PreInvBatchType.PerCustomer) != 0)
            {
                result.Append("Customer");
            }
            if ((batchType & PreInvBatchType.PerDelivery) != 0)
            {
                if (result.Length > 0)
                {
                    result.Append(", ");
                }
                result.Append("Delivery");
            }
            if ((batchType & PreInvBatchType.PerOrder) != 0)
            {
                if (result.Length > 0)
                {
                    result.Append(", ");
                }
                result.Append("Order");
            }
            return "Per " + result.ToString();
        }
    }

}
