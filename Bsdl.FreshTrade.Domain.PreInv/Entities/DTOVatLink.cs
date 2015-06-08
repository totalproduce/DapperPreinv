using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Bsdl.FreshTrade.Domain.Account.Enums;

namespace Bsdl.FreshTrade.Domain.PreInv.Entities
{
    public class DTOVatLink
    {
        public int Id { get; set; }

        public int? VatRateId { get; set; }
        public int? VatVeaId { get; set; }

        public DTOAccountType? AccountType { get; set; }

        public int? FromCountryNo { get; set; }

        public int? DeliveryTypeId { get; set; }

        public int? DeliveryCountryNo { get; set; }

        public int? SalesOfficeNo { get; set; }

        public int? ProductLevel1Ref { get; set; }
        public int? ProductLevel2Ref { get; set; }
        public int? ProductLevel3Ref { get; set; }
        public int? ProductLevel4Ref { get; set; }
        public int? ProductLevel5Ref { get; set; }
        public int? ProductLevel6Ref { get; set; }

        public int? VatGroupNo { get; set; }

        public int? ChargeType { get; set; }

        public int? VatType { get; set; }
    }
}
