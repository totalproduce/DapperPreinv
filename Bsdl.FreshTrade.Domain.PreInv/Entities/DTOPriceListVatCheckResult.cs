using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bsdl.FreshTrade.Domain.PreInv.Entities
{
    public class DTOPriceListVatCheckResult
    {
        public int ProductId { get; set; }
        public int? VatId { get; set; }
    }
}
