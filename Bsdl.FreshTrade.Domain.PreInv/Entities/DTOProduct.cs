using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bsdl.FreshTrade.Domain.PreInv.Entities
{
    public class DTOProduct
    {
        public int Id { get; set; }

        public int? Level1Ref { get; set; }
        public int? Level2Ref { get; set; }
        public int? Level3Ref { get; set; }
        public int? Level4Ref { get; set; }
        public int? Level5Ref { get; set; }
        public int? Level6Ref { get; set; }

        public decimal StandardBoxWeightInKg { get; set; }

        public string Description { get; set; }

        public string ProductRef { get; set; }

        public int? GetRefByLevel(int levelNo)
        {
            switch (levelNo)
            {
                case 1: return Level1Ref;
                case 2: return Level2Ref;
                case 3: return Level3Ref;
                case 4: return Level4Ref;
                case 5: return Level5Ref;
                case 6: return Level6Ref;
            }
            return null;
        }
    }
}
