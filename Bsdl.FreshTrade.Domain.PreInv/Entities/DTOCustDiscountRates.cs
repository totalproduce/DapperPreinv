using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bsdl.FreshTrade.Domain.PreInv.Entities
{
    public class DTOCustDiscountRates
    {
        public int DeliveryHeadId { get; set; }

        public int DraRecNo { get; set; }
        public int DraPrcRef1 { get; set; }
        public int DraPrcRef2 { get; set; }
        public int DraPrcRef3 { get; set; }
        public int DraPrcRef4 { get; set; }
        public int DraPrcRef5 { get; set; }
        public int DraPrcRef6 { get; set; }
        public int StockLocationId { get; set; }
        public int SalesOfficeNo { get; set; }

        public bool ApplyRebatesToFreeOfChargeGoods { get; set; }

        public int? GetRefByLevel(int levelNo)
        {
            switch (levelNo)
            {
                case 1: return DraPrcRef1;
                case 2: return DraPrcRef2;
                case 3: return DraPrcRef3;
                case 4: return DraPrcRef4;
                case 5: return DraPrcRef5;
                case 6: return DraPrcRef6;
            }
            return null;
        }

    }
}
