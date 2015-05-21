using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bsdl.FreshTrade.Domain.Basic.Entities
{
    public class DTOUserToSalesOffice
    {
        public int UserId { get; set; }

        public int SalesOfficeNo { get; set; }
        public bool CanSell { get; set; }
        public bool CanAccount { get; set; }
        public bool CanChangeStock { get; set; }
    }
}
