using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bsdl.FreshTrade.Domain.PreInv.Entities
{
    public class DTOHeadOffice
    {
        public int Id { get; set; }

        public int CurrencyNo { get; set; }

        public int SalesOfficeNo { get; set; }

        public int? InvoiceSalesOfficeNo { get; set; }

        public int HeadOfficeAccountClassId { get; set; }
    }
}
