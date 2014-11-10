using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bsdl.FreshTrade.Domain.PreInv.Entities
{
    public class DTOCustomerProductInfo
    {
        public int Id { get; set; }

        public int? GroupNo { get; set; }

        public string ClientProductNo { get; set; }

        public string ProductDescription { get; set; }

        public string TradedUnit { get; set; }
        public int? UnitCount { get; set; }
    }
}
