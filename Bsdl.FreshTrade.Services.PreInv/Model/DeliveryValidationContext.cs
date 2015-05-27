using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bsdl.FreshTrade.Services.PreInv.Model
{
    public class DeliveryValidationContext
    {
        //public IDictionary<string, int> TransMeth { get; set; }
        public int ReleasedCount { get; set; }
        public int NotReleasedCount { get; set; }
        public int NotRequiredDate { get; set; }

        public DeliveryValidationContext()
        {
            //TransMeth = new Dictionary<string, int>();
            ReleasedCount  = 0;
            NotReleasedCount = 0;
            NotRequiredDate = 0;
        }
    }
}
