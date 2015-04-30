using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Bsdl.FreshTrade.Domain.PreInv.Enums;

namespace Bsdl.FreshTrade.Domain.PreInv.Entities
{
    public class DTODeliveryDetail
    {
        public int Id { get; set; } //DelRecNo

        public int? DeliveryHeadId { get; set; }

        public int? Quantity { get; set; }

        public decimal WeightInKg { get; set; }

        public bool IsPricedByWeight { get; set; }

        public int? ProductId { get; set; }

        public string ClientProductNo { get; set; }

        public string ClientAllocationNo { get; set; }

        public int? ProgramReferenceNo { get; set; }

        public int? QuantityPer { get; set; }

        public int? PricePer { get; set; }

        public DTODeliveryStatus? DeliveryStatus { get; set; }

        public List<DTODeliveryPrice> Prices { get; set; }

        public List<DTOCustomerProductInfo> CustomerProductInfos { get; set; }
    }
}
