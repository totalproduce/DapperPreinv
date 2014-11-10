using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bsdl.FreshTrade.Domain.PreInv.Entities
{
    public class DTOEdiCoSuppNo
    {
        public int HeadOfficeId { get; set; }
        public int CompanyNo { get; set; }

        public bool EdiPrgOrders { get; set; }
        public bool EdiOrders { get; set; }

        public bool EdiInvoices { get; set; }
        public bool EdiDebitCredits { get; set; }

    }
}
