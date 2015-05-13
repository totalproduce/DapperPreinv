using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace Bsdl.FreshTrade.Domain.PreInv.Enums
{
    [DataContract]
    public enum PreInvExtractionErrorTypes
    {
        [EnumMember]
        NotAllDeliveriesForOrderReleased = 1,

        [EnumMember]
        DeliveriesForOrderOutsideCutOffDate = 2,

        [EnumMember]
        UnknownDeliveryType = 3,

        [EnumMember]
        UnknownCurrencyTypeForDelivery = 4,

        [EnumMember]
        DeliveryRequiresPOD = 5,

        [EnumMember]
        DeliveryHasPartInvoicedLineItem = 6,

        [EnumMember]
        DeliveryIsNotFullyAllocatedToStock = 7,

        [EnumMember]
        PricedQuantityMismatchedDeliveredQuantity = 8,

        [EnumMember]
        PricedWeightMismatchedDeliveredWeight = 9,

        [EnumMember]
        UnableToGetVATDetails = 10,
//TODO Check missed errors

        [EnumMember]
        DeliveryZeroQuantity = 11, // 11 Delivery has a zero quantity line item.

        [EnumMember]
        DeliveryZeroPiceItem = 12,

        [EnumMember]
        DeliveryZeroWeightItem = 13,

        [EnumMember]
        DeliveryZeroValueItem = 14,

        [EnumMember]
        DeliveryUnallocatedStockItem = 15,

        [EnumMember]
        AdjustmentUndefinedTypeItem = 16,

//[EnumMember]
//UnableLocateCreditedSalesRef = 17, Unable to locate the Credited Sales xRef record.                

        [EnumMember]
        UnableLocateCreditedSalesItem = 18,

        [EnumMember]
        CreditedSalesItemMismatch = 19,

        [EnumMember]
        DeliveryDetailsIsEmpty = 20,

        [EnumMember]
        NoWeightOnProduct = 21,

        [EnumMember]
        NoNominalLedgerXrefAccountOnFile = 23,

        [EnumMember]
        BlankVATRate = 24,

        [EnumMember]
        UnableToLocateVatRecord = 25,
//26 Too many Vat rates for Invoice.                                 
        [EnumMember]
        InvalidVatRecordNo = 27,

        [EnumMember]
        NoAccountRecord = 28,
//29 Unable to locate RePkFeeGrps record.     //     RePkFeeGrps not used in current implementation
        [EnumMember]
        NoAccountClassRecord = 30,

        [EnumMember]
        UnableToLocateDeductionType = 32,

        [EnumMember]
        MismatchedCompNoInDlvdAndHofAccounts = 33,

        [EnumMember]
        SecondVatRatePresentWithNoFirstVatRate = 34,

        [EnumMember]
        MoreThanOneVatExemptRecordForTheSameVatRecord = 35,

        [EnumMember]
        CreditDebitQuantitiesInvalid = 36,

        [EnumMember]
        StandardUnitsFoundButSysPrefIsNotSetToStandardUnits = 40,

        [EnumMember]
        StandardUnitMissing = 41,

        [EnumMember]
        CombinedSOInvoicingButNotAllDeliveriesForThisSO = 42,

//101	Trans-shipment location Home Sales Office not set-up.           // not found
//201	Unable to locate originating AccTrnFil.                         // not found
//202	Unable to locate RePkFeeCsts record.                            // not found
//203	No Re-packing rates for Group.                                  // not found
//204	No Delprice records for originating AccTrnFil.                  // not found
//205	Imbalance between Acctrnfil and Delprice values.                // not found
//206	Unable to locate record.                                        // not found
//207	All Re-packing schemes are cancelled.                           // not found
//301	Posting has a zero price line item.                             // not found
//302	Posting has not been allocated a Description.                   // not found
//303	Unable to find Description No.                                  // not found
        [EnumMember]
        PricelistVATMismatchesSystemDeterminedVAT = 304,
//401	Transfer Owner delivery not fully authorised                    // not found
        [EnumMember]
        InvalidHeadOfficeRecord = 501,

        /*Below are new errors, not originally present in PreInv*/
        [EnumMember]
        DeliveryDateIsEmptyOrInvalid = 31,

        [EnumMember]
        DeliveryDetailReffersToInvalidProduct = 1001
    }
}
