using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bsdl.FreshTrade.Domain.PreInv.Entities
{
    public class DTODeliveryToItemStock
    {
        public int DeliveryPriceId { get; set; }

        public int ItemStockId { get; set; }

        public int? StockQuantity { get; set; }
        public int? CdsRefNo { get; set; } // Reference to the return reason

        public int Quantity { get; set; }

    }
}
