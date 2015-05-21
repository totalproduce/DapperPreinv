using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bsdl.FreshTrade.Domain.PreInv.Entities
{
    public class DTOVatRate
    {
        public int Id { get; set; }

        public decimal? VatRate { get; set; }
        public decimal? VatRate2 { get; set; }
    }
}
