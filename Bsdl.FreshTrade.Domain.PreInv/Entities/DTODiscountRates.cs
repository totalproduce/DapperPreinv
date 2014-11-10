using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bsdl.FreshTrade.Domain.PreInv.Entities
{
    public class DTODiscountRates
    {
        public int DraRecNo { get; set; }
        public int ThisSeqNo { get; set; }
        public decimal ThisRate { get; set; }
        public decimal ThisPercRate { get; set; }
        public string ThisDedStr { get; set; }
        public int ThisOn { get; set; }
        public decimal ThisStndUnitRate { get; set; }
        public int? DisGlRecNo { get; set; }
    }

    public class DiscountRatesOrderingClass : IComparer<object>
    {
        public int Compare(object x, object y)
        {
            return ((DTODiscountRates)x).ThisSeqNo.CompareTo(((DTODiscountRates)y).ThisSeqNo);
        }
    }
}
