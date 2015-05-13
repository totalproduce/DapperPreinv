using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bsdl.FreshTrade.Domain.PreInv.Entities
{
    public class DTODeliveryPriceCreditRef
    {
        public int Id { get; set; }
        public string CreditRef { get; set; }
        public int DeliveryHeadId { get; set; }
        public int InvStatus { get; set; }
    }
}
