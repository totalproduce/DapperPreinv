using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Bsdl.FreshTrade.Domain.Basic.Interfaces;
using Bsdl.FreshTrade.Domain.PreInv.Entities;
using Bsdl.FreshTrade.Domain.PreInv.Enums;
using Bsdl.FreshTrade.Services.PreInv.Model.Interfaces;

namespace Bsdl.FreshTrade.Services.PreInv.Mocks
{
    class MockExtractionProcessor : IExtractionProcessor
    {
        public DTOPreInvExtractResult Process(DTOPreInvExtractParams extractParams, int extractSessionID, IDTOUser user)
        {
            var result = new DTOPreInvExtractResult();
            switch (extractParams.SalesOfficeNo)
            {
                case 1:
                    {
                        result.Status = PreInvExtractStatusType.OK;
                        result.Errors = new List<DTOPreInvExtractionErrorsItem>();
                        result.InvoiceTotalItems = new List<DTOInvTot>
                        {
                            new DTOInvTot {
                                HofCstCode = "censored",
                                InvoiceNo = "N211283",
                                IsEdiCst = false,
                                QtyTotal = 1380,
                                GoodsTotal = 16464,
                                VatTotal = 0,
                                InvoiceTotal = 16464
                            },
                            new DTOInvTot {
                                HofCstCode = "censored",
                                InvoiceNo = "N211798",
                                IsEdiCst = false,
                                QtyTotal = 447,
                                GoodsTotal = 5150.50M,
                                VatTotal = 0,
                                InvoiceTotal = 5150.50M
                            },
                            new DTOInvTot {
                                HofCstCode = "censored",
                                InvoiceNo = "N211799",
                                IsEdiCst = false,
                                QtyTotal = 70,
                                GoodsTotal = 972.50M,
                                VatTotal = 0,
                                InvoiceTotal = 972.50M
                            },
                            new DTOInvTot {
                                HofCstCode = "censored",
                                InvoiceNo = "N211829",
                                IsEdiCst = false,
                                QtyTotal = 10,
                                GoodsTotal = 180.00M,
                                VatTotal = 0,
                                InvoiceTotal = 180.00M
                            }
                        };

                        result.InvoicePartItems = new List<DTOInvPrt>() {
                            new DTOInvPrt {
                                OrdCstCode = "censored",
                                DlvInvoiceNo = "N211283",
                                DlvOrdNo = 211283,
                                DlvDelDate = new DateTime(2014,4,14),
                                OrdCustOrdNo = "6959",
                                DlvPODNo = "6959"
                            },
                            new DTOInvPrt {
                                OrdCstCode = "censored",
                                DlvInvoiceNo = "N211798",
                                DlvOrdNo = 211798,
                                DlvDelDate = new DateTime(2014,4,15),
                                OrdCustOrdNo = "6964 charge",
                                DlvPODNo = "6964"
                            },
                            new DTOInvPrt {
                                OrdCstCode = "censored",
                                DlvInvoiceNo = "N211799",
                                DlvOrdNo = 211799,
                                DlvDelDate = new DateTime(2014,4,15),
                                OrdCustOrdNo = "6965 charge",
                                DlvPODNo = "6965"
                            },
                            new DTOInvPrt {
                                OrdCstCode = "censored",
                                DlvInvoiceNo = "N211829",
                                DlvOrdNo = 211829,
                                DlvDelDate = new DateTime(2014,4,16),
                                OrdCustOrdNo = "6966",
                                DlvPODNo = "6966"
                            }
                            
                        };

                        result.InvoicePart2Items = new List<DTOInvPrt2>() {
                            new DTOInvPrt2 {
                                InvoiceNo = "N211283",
                                DlvOrdNo = 211283,
                                PrcPrdRef = "147156",
                                PrdDesc = "Grape India Green 10x500gm Punnet",
                                DelQty = 780,
                                DelPrice = 8.80M,
                                Ext = 6864M
                            },
                            new DTOInvPrt2 {
                                InvoiceNo = "N211798",
                                DlvOrdNo = 211798,
                                PrcPrdRef = "100252",
                                PrdDesc = "Apple France Golden Del 10 x 6. Tray",
                                DelQty = 5,
                                DelPrice = 11M,
                                Ext = 55M
                            }
                            
                        };
                        break;
                    }
                case 2:
                    {
                        result.Status = PreInvExtractStatusType.NothingToExtract;
                        result.Errors = new List<DTOPreInvExtractionErrorsItem>();
                        result.InvoiceTotalItems = new List<DTOInvTot>();
                        result.InvoicePartItems = new List<DTOInvPrt>();
                        result.InvoicePart2Items = new List<DTOInvPrt2>();
                        break;
                    }
                default:
                    {
                        result.Status = PreInvExtractStatusType.Failed;
                        result.Errors = new List<DTOPreInvExtractionErrorsItem>
                        {
                            new DTOPreInvExtractionErrorsItem {
                                OrderNo = "1",
                                CustomerCode = "1",
                                DeliveryNo = 1,
                                Type = PreInvExtractionErrorTypes.AdjustmentUndefinedTypeItem
                            },
                            new DTOPreInvExtractionErrorsItem {
                                OrderNo = "2",
                                CustomerCode = "2",
                                DeliveryNo = 2,
                                Type = PreInvExtractionErrorTypes.CombinedSOInvoicingButNotAllDeliveriesForThisSO
                            },
                            new DTOPreInvExtractionErrorsItem {
                                OrderNo = "3",
                                CustomerCode = "3",
                                DeliveryNo = 3,
                                Type = PreInvExtractionErrorTypes.CreditedSalesItemMismatch
                            },
                            new DTOPreInvExtractionErrorsItem {
                                OrderNo = "4",
                                CustomerCode = "4",
                                DeliveryNo = 4,
                                Type = PreInvExtractionErrorTypes.DeliveriesForOrderOutsideCutOffDate
                            },
                            new DTOPreInvExtractionErrorsItem {
                                OrderNo = "5",
                                CustomerCode = "5",
                                DeliveryNo = 5,
                                Type = PreInvExtractionErrorTypes.DeliveryDetailReffersToInvalidProduct
                            },
                            new DTOPreInvExtractionErrorsItem {
                                OrderNo = "6",
                                CustomerCode = "6",
                                DeliveryNo = 6,
                                Type = PreInvExtractionErrorTypes.DeliveryDetailsIsEmpty
                            },
                            new DTOPreInvExtractionErrorsItem {
                                OrderNo = "7",
                                CustomerCode = "7",
                                DeliveryNo = 7,
                                Type = PreInvExtractionErrorTypes.DeliveryHasPartInvoicedLineItem
                            },
                            new DTOPreInvExtractionErrorsItem {
                                OrderNo = "8",
                                CustomerCode = "8",
                                DeliveryNo = 8,
                                Type = PreInvExtractionErrorTypes.DeliveryIsNotFullyAllocatedToStock
                            },
                            new DTOPreInvExtractionErrorsItem {
                                OrderNo = "9",
                                CustomerCode = "9",
                                DeliveryNo = 9,
                                Type = PreInvExtractionErrorTypes.DeliveryRequiresPOD
                            },
                            new DTOPreInvExtractionErrorsItem {
                                OrderNo = "10",
                                CustomerCode = "10",
                                DeliveryNo = 10,
                                Type = PreInvExtractionErrorTypes.DeliveryUnallocatedStockItem
                            },
                            new DTOPreInvExtractionErrorsItem {
                                OrderNo = "11",
                                CustomerCode = "11",
                                DeliveryNo = 11,
                                Type = PreInvExtractionErrorTypes.DeliveryZeroPiceItem
                            },
                            new DTOPreInvExtractionErrorsItem {
                                OrderNo = "12",
                                CustomerCode = "12",
                                DeliveryNo = 12,
                                Type = PreInvExtractionErrorTypes.DeliveryZeroValueItem
                            },
                            new DTOPreInvExtractionErrorsItem {
                                OrderNo = "13",
                                CustomerCode = "13",
                                DeliveryNo = 13,
                                Type = PreInvExtractionErrorTypes.DeliveryZeroWeightItem
                            },
                            new DTOPreInvExtractionErrorsItem {
                                OrderNo = "14",
                                CustomerCode = "14",
                                DeliveryNo = 14,
                                Type = PreInvExtractionErrorTypes.InvalidHeadOfficeRecord
                            },
                            new DTOPreInvExtractionErrorsItem {
                                OrderNo = "15",
                                CustomerCode = "15",
                                DeliveryNo = 15,
                                Type = PreInvExtractionErrorTypes.InvalidVatRecordNo
                            },
                            new DTOPreInvExtractionErrorsItem {
                                OrderNo = "16",
                                CustomerCode = "16",
                                DeliveryNo = 16,
                                Type = PreInvExtractionErrorTypes.MismatchedCompNoInDlvdAndHofAccounts
                            },
                            new DTOPreInvExtractionErrorsItem {
                                OrderNo = "17",
                                CustomerCode = "17",
                                DeliveryNo = 17,
                                Type = PreInvExtractionErrorTypes.NoAccountClassRecord
                            },
                            new DTOPreInvExtractionErrorsItem {
                                OrderNo = "18",
                                CustomerCode = "18",
                                DeliveryNo = 18,
                                Type = PreInvExtractionErrorTypes.NoAccountRecord
                            },
                            new DTOPreInvExtractionErrorsItem {
                                OrderNo = "19",
                                CustomerCode = "19",
                                DeliveryNo = 19,
                                Type = PreInvExtractionErrorTypes.NotAllDeliveriesForOrderReleased
                            },
                            new DTOPreInvExtractionErrorsItem {
                                OrderNo = "20",
                                CustomerCode = "20",
                                DeliveryNo = 20,
                                Type = PreInvExtractionErrorTypes.PricedQuantityMismatchedDeliveredQuantity
                            },
                            new DTOPreInvExtractionErrorsItem {
                                OrderNo = "21",
                                CustomerCode = "21",
                                DeliveryNo = 21,
                                Type = PreInvExtractionErrorTypes.PricedWeightMismatchedDeliveredWeight
                            },
                            new DTOPreInvExtractionErrorsItem {
                                OrderNo = "22",
                                CustomerCode = "22",
                                DeliveryNo = 22,
                                Type = PreInvExtractionErrorTypes.UnableLocateCreditedSalesItem
                            },
                            new DTOPreInvExtractionErrorsItem {
                                OrderNo = "23",
                                CustomerCode = "23",
                                DeliveryNo = 23,
                                Type = PreInvExtractionErrorTypes.UnableToGetVATDetails
                            },
                            new DTOPreInvExtractionErrorsItem {
                                OrderNo = "24",
                                CustomerCode = "24",
                                DeliveryNo = 24,
                                Type = PreInvExtractionErrorTypes.UnableToLocateVatRecord
                            },
                            new DTOPreInvExtractionErrorsItem {
                                OrderNo = "25",
                                CustomerCode = "25",
                                DeliveryNo = 25,
                                Type = PreInvExtractionErrorTypes.UnknownCurrencyTypeForDelivery
                            },
                            new DTOPreInvExtractionErrorsItem {
                                OrderNo = "26",
                                CustomerCode = "26",
                                DeliveryNo = 26,
                                Type = PreInvExtractionErrorTypes.UnknownDeliveryType
                            }                                
                                
                            };
                        };

                        break;
                    }
            return result;
        }

        public void SetProgressWatcher(UpdateProgressDelegate progressDelegate)
        {          
        }

        public void CleanUp(int? salesOfficeNo, int? extractSessionID)
        {
        }

    }
}
