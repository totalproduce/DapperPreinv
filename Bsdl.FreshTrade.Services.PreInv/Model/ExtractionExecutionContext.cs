using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Bsdl.FreshTrade.Domain.Account.Entities;
using Bsdl.FreshTrade.Domain.Basic.Exceptions;
using Bsdl.FreshTrade.Domain.PreInv.Entities;
using Bsdl.FreshTrade.Domain.PreInv.Enums;

namespace Bsdl.FreshTrade.Services.PreInv.Model
{
    public class ExtractionExecutionContext
    {
        public PreInvBatchType BatchTypeForAccount { get; set; }

        public DTOAccountClass AccountClass { get; set; }
        public DTOAccountClass AccountClassHof { get; set; }

        public DTOAccount Account { get; set; }
        public DTOAccount AccountHof { get; set; }

        public DTOOrder Order { get; set; }
        public DTODeliveryHead DeliveryHead { get; set; }
        public DTODeliveryDetail DeliveryDetail { get; set; }
        public DTODeliveryPrice DeliveryPrice { get; set; }

        public int? DeliveryPriceCreditRefId { get; set; }
        public DTODeliveryPriceCreditRef DeliveryPriceCreditRef { get; set; }

        public DTOProduct Product { get; set; }

        public DTOVatLink VatLink { get; set; }
        public DTOVatRate VatRate { get; set; }

        public DTOSalesOffice SalesOffice { get; set; }

        public string LocalAccountCode { get; set; } //For Account
        public string HofLocalAccountCode { get; set; } // For Hof

        public int RequiredPriceGroupNo { get; set; }
        public bool IsDeliveryGoodsOnConsignment { get; set; }
        public bool IsEdiCustomer { get; set; }
        public bool CstProdRequired { get; set; }
        public SortedSet<DTODeliveryPriceStatus> AllowedDeliveryPriceStatus { get; set; }
        public int? ProductAnalysisGroup { get; set; }

        // Discount related
        public Dictionary<int, DiscountRecordItem> DiscountRates { get; set; }
        public bool ApplyRebatesToFreeOfChargeGoods { get; set; }
        public bool HasDiscountRates { get; set; }
        public bool HasRebateRates { get; set; }

        // Result details
        public DTOInvTot InvoiceTotal { get; set; }
        public DTOInvTot InvoiceTotalBeforeLastDelivery { get; set; } //For undo in needed.

        #region InvoiceTypeForAccount property
        private PreInvInvoiceType? _invoiceTypeForAccount = null;
        public PreInvInvoiceType InvoiceTypeForAccount
        { 
            get
            {
                if (!_invoiceTypeForAccount.HasValue)
                {
                    throw new FreshTradeException("Invoice Type is not yet initialized at this point");
                }
                return _invoiceTypeForAccount.Value;
            }
            set { _invoiceTypeForAccount = value; } 
        }

        public void ClearInvoiceTypeForAccount()
        {
            _invoiceTypeForAccount = null;
        }

        #endregion

        public ExtractionExecutionContext()
        {
            DiscountRates = new Dictionary<int, DiscountRecordItem>();
        }
    }

    public class DiscountRecordItem
    {
        public bool IsDiscountRate
        {
            get { return Type.HasValue && (Type.Value.GetStage() == EnumDiscTypesStage.OnInvoice); }
        }

        public bool IsOnPaymentRate
        {
            get { return Type.HasValue && (Type.Value.GetStage() == EnumDiscTypesStage.OnPayment); }
        }

        public bool IsRetroRate
        {
            get { return Type.HasValue && (Type.Value.GetStage() == EnumDiscTypesStage.Retro); }
        }

        public decimal Rate { get; set; }
        public EnumDiscTypes? Type { get; set; }
        public int? GLRecNo { get; set; }
        public string DedStr { get; set; }
    }
}
