using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bsdl.FreshTrade.Domain.PreInv.Entities
{
    public class DTOPriceGroupLookupResult
    {
        public int AccountClassId { get; set; }

        public int PriceGroupNo { get; set; }

        public int? PriceGroupSalesOfficeNo { get; set; }
    }
}
