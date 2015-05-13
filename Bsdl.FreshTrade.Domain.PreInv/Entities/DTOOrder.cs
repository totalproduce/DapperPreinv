using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bsdl.FreshTrade.Domain.PreInv.Entities
{
    public class DTOOrder
    {
        public int Id { get; set; }

        public int? AccountClassId { get; set; }

        public string CustomerOrderNo { get; set; }

        public DateTime? OrderDate { get; set; } 

        public int? SalesPerson { get; set; }

        public List<DTODeliveryHead> Deliveries { get; set; }
    }
}
