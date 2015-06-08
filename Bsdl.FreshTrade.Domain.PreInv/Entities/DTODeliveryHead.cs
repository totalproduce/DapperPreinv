using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Bsdl.FreshTrade.Domain.PreInv.Enums;

namespace Bsdl.FreshTrade.Domain.PreInv.Entities
{
    public class DTODeliveryHead
    {
        public int Id { get; set; }

        public int? OrderId { get; set; }

        public int? CurrencyNo { get; set; }

        public bool IsInterCompanyTransfer { get; set; }

        public int? SalesOfficeTransferTo { get; set; }

        public int? DeliverySalesOfficeNo { get; set; }

        public int? InvoiceSalesOfficeNo { get; set; }

        public int? TransferFlag { get; set; }

        public int? TranInd { get; set; } //DlvTranInd

        public string PoDNo { get; set; } /*proof of delivery number*/

        public DTODeliveryStatus? DeliveryStatus { get; set; } // Dlvrelinv

        public DateTime? ShipDate { get; set; }

        public DateTime? DeliveryDate { get; set; }

        public int? DeliveryTypeId { get; set; }

        public bool IsInterDepartment { get; set; }

        public bool IsOpenPriceDelivery { get; set; }

        public int? FromStockLocationId { get; set; }
        
        public int? ProgrammeHeadId { get; set; }

        public int? StockLocationId { get; set; }

        public List<DTODeliveryDetail> Details { get; set; }

        public List<DTOCustDiscountRates> CustomerDiscountRates { get; set; }
    }
}
