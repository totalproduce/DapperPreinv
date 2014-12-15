using Bsdl.FreshTrade.Domain.Account.Entities;
using Bsdl.FreshTrade.Domain.Account.Enums;
using Bsdl.FreshTrade.Domain.Basic.Entities;
using Bsdl.FreshTrade.Domain.Basic.Enums;
using Bsdl.FreshTrade.Domain.Basic.Exceptions;
using Bsdl.FreshTrade.Domain.Basic.Interfaces;
using Bsdl.FreshTrade.Domain.Basic.Utilities.DataTypeHandling;
using Bsdl.FreshTrade.Domain.PreInv.Entities;
using Bsdl.FreshTrade.Domain.PreInv.Enums;
using Bsdl.FreshTrade.Domain.PreInv.Exceptions;
using Bsdl.FreshTrade.Repositories.Account.Interfaces;
using Bsdl.FreshTrade.Repositories.Basic;
using Bsdl.FreshTrade.Repositories.Basic.Interfaces;
using Bsdl.FreshTrade.Repositories.Basic.Utilities.Interfaces;
using Bsdl.FreshTrade.Repositories.PreInv.Interfaces;
using Bsdl.FreshTrade.Server.Basic;
using Bsdl.FreshTrade.Server.Basic.Interfaces;
using Bsdl.FreshTrade.Server.Basic.Logger;
using Bsdl.FreshTrade.Services.Basic.Interfaces;
using Bsdl.FreshTrade.Services.Basic.Profiling;
using Bsdl.FreshTrade.Services.PreInv.Model.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;


namespace Bsdl.FreshTrade.Services.PreInv.Model
{
    public class ExtractionProcessor : IExtractionProcessor, IExtractionErrorsRegistry
    {
        private readonly ILogger _logger;
        private readonly PerformanceLogger stopWatch;
        private const int _defaultCompanyNo = 1; // The default company number in ALL databases should be 1.

        private const string InvPrefix_Normal = "N";
        private const string InvPrefix_InterDept = "X";
        private const string InvPrefix_Transfer = "T";

        static void NullProgressWatcher(int percentage) { }
        private UpdateProgressDelegate _progressDelegate = NullProgressWatcher;

        #region Repositories
        private readonly IPreINVPRTRepository _preInvPrtRepository;
        private readonly IPreInvPrt2Repository _preInvPrt2Repository;
        private readonly IPreInvTotRepository _preInvTotRepository;
        private readonly IInvErrRepository _invErrRepository;
        private readonly IInvExtractHedRepository _invExtractHedRepository;
        private readonly IInvDiscTypRepository _invDiscTypRepository;

        private readonly ISalesPersonRepository _salesPersonRepository;
        private readonly ICompanyDictionaryRepository _companyDictionaryRepository;
        private readonly IErrorDescriptionRepository _errorDescriptionRepository;
        private readonly IUserRepository _userRepository;
        private readonly ISalesOfficeRepository _salesOfficeRepository;
        private readonly IAccToProcessRepository _accToProcessRepository;
        private readonly IAccountClassRepository _accountClassRepository;
        private readonly IAccountRepository _accountRepository;
        private readonly ICustomerCategoryDepencencyRepository _customerCategoryDepencencyRepository;
        private readonly IHeadOfficeRepository _headOfficeRepository;
        private readonly IGLInfoRepository _glInfoRepository;
        private readonly IPriceGroupRepository _priceGroupRepository;
        private readonly IOrderRepository _orderRepository;
        private readonly IDeliveryHeadRepository _deliveryHeadRepository;
        private readonly IDeliveryDetailRepository _deliveryDetailRepository;
        private readonly IDeliveryTypeRepository _deliveryTypeRepository;
        private readonly IDeliveryPriceRepository _deliveryPriceRepository;
        private readonly IDeliveryToItemStockRepository _deliveryToItemStockRepository;
        private readonly IDeliveryPriceToCreditNoteRepository _deliveryToCreditNoteRepository;
        private readonly ICurrencyDictionaryRepository _currencyDictionaryRepository;
        private readonly IProductRepository _productRepository;
        private readonly IStockLocationRepository _stockLocationRepository;
        private readonly IVatLinkRepository _vatLinkRepository;
        private readonly IVatRateRepository _vatRateRepository;
        private readonly ICustomerProductInfoRepository _customerProductInfoRepository;
        private readonly ICurrencyRateRepository _currencyRateRepository;
        private readonly IEdiCoSuppNoRepository _ediCoSuppNoRepository;
        private readonly IPriceListVatCheckRepository _priceListVatCheckRepository;
        private readonly ICustomerDiscountRatesRepository _customerDiscountRatesRepository;
        private readonly IDiscountRatesRepository _discountRatesRepository;
        private readonly IIteChgRepository _iteChgRepository;
        private readonly IIchDiscTypRepository _ichDiscTypRepository;
        private readonly IAccVATRepository _accVATRepository;
        private readonly IProductTranslationRepository _prodTranslationRepository;
        private readonly IAuditRecordRepository _auditRecordRepository;

        #endregion

        private readonly IUnitOfWork _unitOfWorkCurrent;

        private readonly IDictionaryService _dictionaryService;

        private readonly IRequestContextCache<int> _localCache = new RequestContextCache<int>();
        private readonly ISharedProcessingHelpers _sharedProcessingHelpers;
        private readonly SystemPreferences _systemPreferences;
        private int _extractSessionID;
        private IDTOUser _user;
        private List<int> _involvedSalesOffices;
        private Dictionary<int, DTOHeadOffice> _headOfficesForAccounts; /* AccountClassId -> HeadOffice mapping */
        private Dictionary<int, string> _localAccounts; /* AccountClassId -> LocalAccountCode mapping */
        private Dictionary<int, int> _accountClassPriceGroups; /* AccountClassId -> PriceGroupNo mapping */
        private Dictionary<int, int> _productAnalysisGroups; /*AllPRefNo -> PrdGlAnlRecNo mapping*/
        private Dictionary<int, DTOProductStandardUnitRecord> _productStandardUnits; /*AllPRefNo -> StandardUnits mapping*/

        private Dictionary<int, PreInvInvoiceType> _accountPossibleInvoiceTypes = new Dictionary<int, PreInvInvoiceType>();
        //private SortedSet<int> _ordersToSkipForInvoiceRun = new SortedSet<int>();

        private Dictionary<DTOInvoiceType, PreInvBatchType> _invoiceTypeToBatchTypeMapping;
        private ISet<DTOInvoiceType> _allowedNotRelDeliveryInvoiceTypes;
        private Dictionary<int, PreInvInvoiceType> _deliveryTranIndToInvoiceTypeMapping;


        private Dictionary<string, DTOInvTot> _invoiceTotals = new Dictionary<string, DTOInvTot>();

        private List<DTOInvPrt2> _currentDeliveryInvoicePart2Items = new List<DTOInvPrt2>();
        private List<DTOInvDiscTyp> _currentInvoiceDiscTypItems = new List<DTOInvDiscTyp>();

        private ExtractionExecutionContext _context;
        private int _incrementalExtractedRecNo = 0; //incremental count of extracted records
        private int _nextInvoiceNo = 0;


        private DTOPreInvExtractResult _extractResult = new DTOPreInvExtractResult
                                                            {
                                                                Status = PreInvExtractStatusType.OK,
                                                                InvoicePartItems = new List<DTOInvPrt>(),
                                                                InvoicePart2Items = new List<DTOInvPrt2>(),
                                                                InvoiceDiscTypItems = new List<DTOInvDiscTyp>(),
                                                                Errors = new List<DTOPreInvExtractionErrorsItem>()
                                                            };
        #region Helpers

        private enum ValidateDeliveryPriceResult
        {
            Valid = 1,
            InvalidSkipDelivery = 2,
            InvalidContinueWithDelivery = 3
        }

        /*private enum ValidateOrderResult
        {
            Valid = 1,
            InvalidForInvoices = 2,
            InvalidCompletely = 3
        }*/

        private void DetectInvolvedSalesOffices(int salesOfficeNo)
        {
            _involvedSalesOffices = new List<int>();
            var salesOffices = _salesOfficeRepository.GetData(null, CachingStrategy.GlobalCache);
            foreach (var salesOffice in salesOffices)
            {
                if (salesOffice.SalesOfficeNumber == salesOfficeNo)
                {
                    if ((salesOffice.AccountingSalesOfficeNo.HasValue) && (salesOffice.AccountingSalesOfficeNo != 0))
                    {
                        //Utilslib.GetTransMessage(1061), Utilslib.GetTransMessage(1062)+Utilslib.GetTransMessage(1063)+stTmp1+Utilslib.GetTransMessage(1064)+stTmp2+Utilslib.GetTransMessage(1065)
                        throw new FreshTradeException(string.Format("Sorry, cannot proceed as the Accounting Sales Office for {0} is {1}", salesOfficeNo, salesOffice.AccountingSalesOfficeNo));
                    }
                    _involvedSalesOffices.Add(salesOffice.SalesOfficeNumber);
                }
                else
                    if ((salesOffice.AccountingSalesOfficeNo.HasValue) && (salesOffice.AccountingSalesOfficeNo == salesOfficeNo))
                    {
                        _involvedSalesOffices.Add(salesOffice.SalesOfficeNumber);
                    }
            }

            if (!_involvedSalesOffices.Contains(salesOfficeNo))
            {
                //Utilslib.GetTransMessage(1061), Utilslib.GetTransMessage(1062)+Utilslib.GetTransMessage(1063)+stTmp1+Utilslib.GetTransMessage(1064)+stTmp2+Utilslib.GetTransMessage(1065)
                throw new FreshTradeException(string.Format("Sorry, cannot proceed as information about Sales Office {0} is not available", salesOfficeNo));
            }
        }

        private void RaiseSalesOfficeInUseException(DTOSalesOffice salesOffice)
        {
            if (salesOffice.InUse)
            {
                string userName = "Unknown";
                if (salesOffice.UsedBy.HasValue)
                {
                    var user = _userRepository.GetUserByNo(salesOffice.UsedBy.Value);
                    if (user != null)
                    {
                        userName = user.UserName.Trim();
                    }
                }

                throw ErrorHelpers.TranslateErrorMessage(
                    new FreshTradeException(252035668,
                                            string.Format(
                                                "User: {0} is running Pre-Invoicing for this sales office.",
                                                userName)));
            }
            throw ErrorHelpers.TranslateErrorMessage(
                new FreshTradeException(-1, "Concurrent user is running Pre-Invoicing for this sales office."));
        }

        private void SetExtractionInUseFlag(bool inUse, int salesOfficeNo, bool cleanup = false)
        {
            if (!_systemPreferences.SalesOfficeNeedLock) return; //override Locking routine.

            var salesOffice = _salesOfficeRepository.GetSalesOfficeByNo(salesOfficeNo, true);
            DTOSalesOffice modifiedSalesOffice = null;

            if (inUse)
            {
                if (salesOffice.InUse)
                {
                    if (salesOffice.InvoiceGenerationSessionNo != _extractSessionID)
                    {
                        RaiseSalesOfficeInUseException(salesOffice);
                    }
                }
                if (!salesOffice.LastPreInvUpdateOK)
                {
                    throw ErrorHelpers.TranslateErrorMessage(
                        new FreshTradeException(1067, "The last Pre-Invoicing Update was NOT successful. Contact your Wizdom supplier."));
                }
                modifiedSalesOffice = ObjectHandling.CloneDTO(salesOffice);
                modifiedSalesOffice.InUse = true;
                modifiedSalesOffice.UsedBy = _user.Id;
                modifiedSalesOffice.InvoiceGenerationSessionNo = _extractSessionID; //Previous Pre-Invoicing used "liSessionNo = UtilsLib.MReturnUserSessNo()" for obtaining a session No.
            }
            else
            {
                if (salesOffice.InUse)
                {
                    if (salesOffice.InvoiceGenerationSessionNo != _extractSessionID)
                    {
                        if (cleanup)
                        {
                            return;
                        }
                        throw ErrorHelpers.TranslateErrorMessage(
                            new FreshTradeException(4036723, "Unable to de-set the 'UsedBy' flag."));
                    }
                    modifiedSalesOffice = ObjectHandling.CloneDTO(salesOffice);
                    modifiedSalesOffice.InUse = false;
                }
            }

            var lAudit = new List<DTOAuditRecord> 
                        {
                            new DTOAuditRecord
                            {
                                AuditRecordNo = (int)_auditRecordRepository.GetNextSequence(),
                                AuditTypeNo = 33,
                                AuditLinkRecNo1 = salesOfficeNo,
                                AuditLinkRecNo2 = _extractSessionID,
                                AuditChangedFrom = (!inUse).ToString(),
                                AuditChangedTo = (inUse).ToString(),
                                AuditActionNo = 2,
                                AuditDoneBy = _user == null ? (int?)null : _user.Id,
                                AuditFormName = _systemPreferences.FormName,
                                AuditFormNo = _systemPreferences.FormNo,
                                AuditDate = DateTime.Now
                            }
                        };

            if (modifiedSalesOffice != null)
            {
                _unitOfWorkCurrent.BeginTransaction();
                try
                {
                    var updatedCount = _salesOfficeRepository.Update
                        (
                            salesOffice, 
                            modifiedSalesOffice,
                            new IFieldNameRef[]
                                {
                                    new FieldNameRef<DTOSalesOffice, bool>(i => i.InUse), 
                                    new FieldNameRef<DTOSalesOffice, int?>(i => i.InvoiceGenerationSessionNo)
                                }
                        );
                    if (updatedCount == 0)
                    {
                        salesOffice = _salesOfficeRepository.GetSalesOfficeByNo(salesOfficeNo, true);
                        RaiseSalesOfficeInUseException(salesOffice);
                    }
                    _auditRecordRepository.Add(lAudit);
                    _unitOfWorkCurrent.Commit();
                }
                catch (Exception)
                {
                    _unitOfWorkCurrent.Rollback();
                    throw;
                }
            }

        }

        private List<int> DetectInvolvedCustomers(DTOPreInvExtractParams extractParams)
        {
            List<int> preFilteredAccClassIDs = null;
            if (extractParams.AccountParams.FilterType == PreInvExtractAccountFilterType.ByCategory)
            {
                preFilteredAccClassIDs = _customerCategoryDepencencyRepository.GetCustomersByCategories(extractParams.AccountParams.Categories);
                if ((preFilteredAccClassIDs == null) || preFilteredAccClassIDs.Count == 0)
                {
                    return null;
                }
            }
            else
                if (extractParams.AccountParams.FilterType == PreInvExtractAccountFilterType.ByCustomer)
                {
                    if (!extractParams.AccountParams.AccountClassId.HasValue)
                    {
                        throw new FreshTradeException("AccountClassId should be specified");
                    }
                    preFilteredAccClassIDs = new List<int> { extractParams.AccountParams.AccountClassId.Value };
                }
            return _accToProcessRepository.GetAccToProcess(extractParams.CurrencyNo, extractParams.SalesOfficeNo, preFilteredAccClassIDs);
        }

        public void RegisterExtractionError(PreInvExtractionErrorTypes type)
        {
            string customerCode = _context.Account != null ? _context.Account.Code : string.Empty;
            string orderNo = _context.Order != null ? _context.Order.CustomerOrderNo : string.Empty;
            int? deliveryNo = _context.DeliveryHead != null ? (int?)_context.DeliveryHead.Id : null;
            RegisterExtractionError(type, customerCode, orderNo, deliveryNo);
        }

        public void RegisterExtractionError(PreInvExtractionErrorTypes type, string customerCode, string orderNo = null, int? deliveryNo = null)
        {
            var errorDescr = _errorDescriptionRepository.GetData(null, CachingStrategy.GlobalCache).FirstOrDefault(i => i.No == (int)type);
            _extractResult.Errors.Add(new DTOPreInvExtractionErrorsItem
                                          {
                                              ExtractSessionID = _extractSessionID,
                                              Type = type,
                                              ErrorDescription = errorDescr,
                                              CustomerCode = customerCode,
                                              OrderNo = orderNo,
                                              DeliveryNo = deliveryNo
                                          });
            _extractResult.Status = PreInvExtractStatusType.Failed;
        }

        private bool LoadAccountsData(List<int> accToProcess, RequestContextCacheMergeBehaviour mergeBehaviour = RequestContextCacheMergeBehaviour.NotAllow)
        {
            if ((accToProcess == null) || (accToProcess.Count == 0))
            {
                return false;
            }

            var accountClasses = _accountClassRepository.GetAccountClassByIDs(accToProcess);
            if (accountClasses.Count == 0)
            {
                return false;
            }
            _localCache.Put(accountClasses, i => i.Id, mergeBehaviour);

            var accounts = _accountRepository.GetAccountByAccClassIDs(accToProcess);
            if (accounts.Count == 0)
            {
                return false;
            }

            _localCache.Put(accounts, i => i.Id, mergeBehaviour);

            return true;
        }

        private bool LoadOrdersInitialData(List<int> accToProcess)
        {
            var orders = _orderRepository.GetOrdersByAccountClassIDs(accToProcess);
            if (orders.Count == 0)
            {
                return false;
            }
            var deliveryHeads = _deliveryHeadRepository.GetDeliveryHeadByOrderIDs(orders.Select(i => i.Id).ToList());
            if (deliveryHeads.Count == 0)
            {
                return false;
            }
            _localCache.Put(deliveryHeads, i => i.OrderId ?? 0);
            foreach (var order in orders)
            {
                order.Deliveries = _localCache.Get<DTODeliveryHead, int>(order.Id, i => i.Id);
            }
            _localCache.Put(orders, i => i.AccountClassId ?? 0);
            return true;
        }

        private void LoadOrdersFullData(List<int> accToProcess)
        {
            var deliveryHeads = new List<DTODeliveryHead>();
            _localCache.ActionForAllGroups<DTODeliveryHead>((k, d) => deliveryHeads.AddRange(d));

            var deliveryHeadIds = deliveryHeads.Select(i => i.Id).ToList();

            stopWatch.PushTime();
            var deliveryDetails = _deliveryDetailRepository.GetDeliveryDetailByDeliveryHeadIDs(deliveryHeadIds);
            _localCache.Put(deliveryDetails, i => i.DeliveryHeadId ?? 0);
            stopWatch.PopTime(string.Format("Reading DelDet for {0} DelHeds", deliveryHeadIds.Count()));

            var customerDiscountRates = _customerDiscountRatesRepository.GetCustomerDiscountRatesByDeliveryHeadIDs(deliveryHeadIds);
            _localCache.Put(customerDiscountRates, i => i.DeliveryHeadId);

            foreach (var deliveryHead in deliveryHeads)
            {
                deliveryHead.Details = _localCache.Get<DTODeliveryDetail, int>(deliveryHead.Id, i => i.Id);
                deliveryHead.CustomerDiscountRates = _localCache.Get<DTOCustDiscountRates>(deliveryHead.Id);
            }

            var discountRates = _discountRatesRepository.GetDiscountRatesByRecNos(customerDiscountRates.Select(i => i.DraRecNo).Distinct().ToList());
            _localCache.Put(discountRates, i => i.DraRecNo);
            _localCache.SortGroups<DTODiscountRates>(new DiscountRatesOrderingClass());

            var deliveryPrices = _deliveryPriceRepository.GetDeliveryPriceByDeliveryDetailIDs(deliveryDetails.Select(i => i.Id).ToList());
            _localCache.Put(deliveryPrices, i => i.DeliveryDetailId ?? 0);
            foreach (var deliveryDetail in deliveryDetails)
            {
                deliveryDetail.Prices = _localCache.Get<DTODeliveryPrice>(deliveryDetail.Id);
            }

            var customerProductInfos = _customerProductInfoRepository.GetCustomerProductInfosByClientProductNos(deliveryDetails.Select(i => i.ClientProductNo).Distinct().Where(i => !string.IsNullOrEmpty(i)).ToList());
            var groupedCustomerProductInfos = customerProductInfos.GroupBy(i => i.ClientProductNo).ToDictionary(i => i.Key, i => i);
            foreach (var deliveryDetail in deliveryDetails)
            {
                if (!string.IsNullOrEmpty(deliveryDetail.ClientProductNo))
                {
                    deliveryDetail.CustomerProductInfos = groupedCustomerProductInfos[deliveryDetail.ClientProductNo].ToList();
                }
            }

            var deliveryToItemStocks = _deliveryToItemStockRepository.GetDeliveryToItemStockByDeliveryPriceIDs(deliveryPrices.Select(i => i.Id).ToList());
            _localCache.Put(deliveryToItemStocks, i => i.DeliveryPriceId);

            var deliveryPriceIds = deliveryPrices.Select(i => i.Id).ToList();
            var deliveryToCreditNote = _deliveryToCreditNoteRepository.GetDeliveryPriceToCreditNoteByDeliveryPriceIDs(deliveryPriceIds);
            var deliveryToCreditNoteByItemStock = _deliveryToCreditNoteRepository.GetDeliveryToCreditNotesByItemStockRecNos(deliveryPriceIds);
            var groupedDeliveryToCreditNoteByItemStock = deliveryToCreditNoteByItemStock.GroupBy(i => i.OrgDprRecNo).ToDictionary(i => i.Key, i => i);
            //_localCache.Put(deliveryToCreditNote, i => i.CreditNoteDeliveryPriceRefNo);

            //Reading Original Delivery Prices for Credit And Debit Notes
            var cnoDelPrice = _deliveryPriceRepository.GetDeliveryPriceByDprRecNos(deliveryToCreditNote.Select(i => i.OriginalDeliveryPriceRefNo).Distinct().ToList());

            var cnoDelPriceAccVat = _accVATRepository.GetByAtrRecNos(cnoDelPrice.Select(i => i.InvoiceId ?? 0).Distinct().ToList());
            var cnoDelPriceItemCharges = _iteChgRepository.GetItemChargeByDeliveryPriceIds(cnoDelPrice.Select(i => i.Id).ToList());
            var cnoDelPriceItemChargeDiscTyps = _ichDiscTypRepository.GetByItemChargeIds(cnoDelPriceItemCharges.Select(i => i.IchRecNo).ToList());

            var groupedCnoDelPriceAccVat = cnoDelPriceAccVat.GroupBy(i => i.AvaAtrRecNo).ToDictionary(i => i.Key, i => i);
            var groupedCnoDelPriceItemCharges = cnoDelPriceItemCharges.GroupBy(i => i.DprRecNo).ToDictionary(i => i.Key, i => i);
            var groupedCnoDelPriceItemChargeDiscTyps = cnoDelPriceItemChargeDiscTyps.GroupBy(i => i.IchRecNo).ToDictionary(i => i.Key, i => i);


            var relatedCreditNotes = _deliveryToCreditNoteRepository.CheckRelatedCreditNotes(deliveryPriceIds);

            foreach (var deliveryPrice in deliveryPrices)
            {
                deliveryPrice.DeliveryToItemStockRecords = _localCache.Get<DTODeliveryToItemStock>(deliveryPrice.Id);

                var lCdtItem = deliveryToCreditNote.FirstOrDefault(n => n.CreditNoteDeliveryPriceRefNo == deliveryPrice.Id);
                if (lCdtItem != null)
                {
                    deliveryPrice.CreditNoteOriginalDeliveryPrice =
                        cnoDelPrice.FirstOrDefault(o => o.Id == lCdtItem.OriginalDeliveryPriceRefNo);

                    if (deliveryPrice.CreditNoteOriginalDeliveryPrice != null)
                    {
                        if (deliveryPrice.CreditNoteOriginalDeliveryPrice.InvoiceId.HasValue)
                        {
                            IGrouping<int, DTOAccVAT> accVAT;
                            if (groupedCnoDelPriceAccVat.TryGetValue(deliveryPrice.CreditNoteOriginalDeliveryPrice.InvoiceId.Value, out accVAT))
                            {
                                deliveryPrice.CreditNoteOriginalDeliveryPrice.AccVAT = accVAT.FirstOrDefault();
                            }
                        }

                        IGrouping<int?, DTOIteChg> itemCharges;
                        if (groupedCnoDelPriceItemCharges.TryGetValue(deliveryPrice.CreditNoteOriginalDeliveryPrice.Id, out itemCharges))
                        {
                            deliveryPrice.CreditNoteOriginalDeliveryPrice.ItemCharges = itemCharges.ToList();
                            foreach (var itemCharge in itemCharges)
                            {
                                IGrouping<int, DTOIchDiscTyp> ichDiscTyp;
                                if (groupedCnoDelPriceItemChargeDiscTyps.TryGetValue(itemCharge.IchRecNo, out ichDiscTyp))
                                {
                                    itemCharge.IchDiscTypRecord = ichDiscTyp.FirstOrDefault();
                                }
                            }
                        }
                    }
                }

                IGrouping<int, DTODeliveryToCreditNoteByItemStock> group;
                if (groupedDeliveryToCreditNoteByItemStock.TryGetValue(deliveryPrice.Id, out group))
                {
                    deliveryPrice.DeliveryToCreditNoteByItemStock = group.ToList();
                }

                deliveryPrice.HasRelatedCreditNotes = relatedCreditNotes.Contains(deliveryPrice.Id);
            }
        }

        private bool IsMiscCreditDebit(DTODeliveryHead delivery)
        {
            return (delivery.TranInd == 7) || (delivery.TranInd == 8);
        }

        private bool IsEdiCustomer(PreInvInvoiceType invoiceType, DTOAccount account, DTOAccount accountHof)
        {
            bool result = (!string.IsNullOrEmpty(account.ANANumber) || !string.IsNullOrEmpty(accountHof.ANANumber)) &&
                          accountHof.HeadOfficeId.HasValue;
            if (!result)
            {
                return false;
            }
            var ediCoSuppNo = _localCache.GetSingle<DTOEdiCoSuppNo>(accountHof.HeadOfficeId.Value, true);
            if (ediCoSuppNo == null)
            {
                return false;
            }

            if (invoiceType == PreInvInvoiceType.Invoice)
            {
                return ediCoSuppNo.EdiInvoices;
            }
            if (
                    (invoiceType == PreInvInvoiceType.CreditNote) ||
                    (invoiceType == PreInvInvoiceType.DebitNote)
               )
            {
                return ediCoSuppNo.EdiDebitCredits;
            }
            return true; //should never reach this point
        }

        private bool IsSequentialInvoiceNos(PreInvInvoiceType invoiceType, DTOSalesOffice salesOffice)
        {
            if (invoiceType == PreInvInvoiceType.Invoice) //TODO: Think how to handle mixed batches here
            {
                return salesOffice.UseSequentialInvoiceNos;
            }
            return true;
        }

        private string GetPerQtyStr(int? pricePer)
        {
            string perQtyStr = "B";
            switch (pricePer)
            {
                case 1: perQtyStr = "B"; break;
                case 2: perQtyStr = "K"; break;
                case 3: perQtyStr = "E"; break;
                case 4: perQtyStr = "I"; break;
            }
            return perQtyStr;
        }

        private SortedSet<DTOInvoiceType> GetAllowedNotRelDeliveryInvoiceType()
        {
            return new SortedSet<DTOInvoiceType>
                       {
                           DTOInvoiceType.PerDeliveryGrossNoSplit, // extract Per Delivery gross (don't allow split Orders).
                           DTOInvoiceType.PerDeliveryNettNoSplit, // extract Per Delivery nett (don't allow split Orders).
                           DTOInvoiceType.CombinedDeliveriesGross, // extract Combined Deliveries gross.
                           DTOInvoiceType.CombinedDeliveriesNett, // extract Combined Deliveries nett.
                           DTOInvoiceType.PerOrderNettOfRelCredits // doug 30/10/08  -7788
                       };
        }
        private Dictionary<int, PreInvInvoiceType> GetDeliveryTranIndToInvoiceTypeMapping()
        {
            return new Dictionary<int, PreInvInvoiceType>            
            {
                {1, PreInvInvoiceType.Invoice},                                                              // Normal Delivery
                {3, PreInvInvoiceType.Invoice | PreInvInvoiceType.CreditNote},                               // Normal Delivery with Credit
                {4, PreInvInvoiceType.Invoice | PreInvInvoiceType.DebitNote},                                // Normal Delivery with Debit
                {6, PreInvInvoiceType.Invoice | PreInvInvoiceType.CreditNote | PreInvInvoiceType.DebitNote}, // Normal Delivery with Credit and Debit
                {7, PreInvInvoiceType.CreditNote},                                                           // Miscellaneous Credit
                {8, PreInvInvoiceType.DebitNote},                                                            // Miscellaneous Debit
                {10, PreInvInvoiceType.Invoice | PreInvInvoiceType.CreditNote | PreInvInvoiceType.DebitNote} // Per Order Nett of Rel Credits ; doug 30/10/08  -7788
            };
        }

        private SortedSet<DTODeliveryPriceStatus> GetAllowedDeliveryPriceStatus(PreInvInvoiceType paramInvoiceType, DTOInvoiceType accountInvoiceType)
        {
            var result = new SortedSet<DTODeliveryPriceStatus>();
            if ((paramInvoiceType & PreInvInvoiceType.Invoice) != 0)
            {
                if
                (
                    new[]
                    {
                        DTOInvoiceType.PerDeliveryNettNoSplit, //3
                        DTOInvoiceType.PerDeliveryNettAllowSplit, // 4
                        DTOInvoiceType.CombinedDeliveriesNett, // 6
                        DTOInvoiceType.CombinedOrdersNett, // 8
                        DTOInvoiceType.PerOrderNettOfRelCredits // 10
                    }.Contains(accountInvoiceType)
                )
                {
                    result.Add(DTODeliveryPriceStatus.NormalDelivery); //1
                    result.Add(DTODeliveryPriceStatus.CreditOnNormalDelivery); //2
                    result.Add(DTODeliveryPriceStatus.DebitOnNormalDelivery); //3
                }
                else
                {
                    result.Add(DTODeliveryPriceStatus.NormalDelivery); //1
                }
            }
            if ((paramInvoiceType & PreInvInvoiceType.CreditNote) != 0)
            {
                result.Add(DTODeliveryPriceStatus.CreditOnNormalDelivery); //2
                result.Add(DTODeliveryPriceStatus.MiscellanousCredit); //7
            }
            if ((paramInvoiceType & PreInvInvoiceType.DebitNote) != 0)
            {
                result.Add(DTODeliveryPriceStatus.DebitOnNormalDelivery); //3
                result.Add(DTODeliveryPriceStatus.MiscellanousDebit); //8
            }
            return result;
        }

        private void InitializeStatusFilters(DTOPreInvExtractParams extractParams)
        {
            _invoiceTypeToBatchTypeMapping = _sharedProcessingHelpers.GetInvoiceTypeToBatchTypeMapping();
            _allowedNotRelDeliveryInvoiceTypes = GetAllowedNotRelDeliveryInvoiceType();
            _deliveryTranIndToInvoiceTypeMapping = GetDeliveryTranIndToInvoiceTypeMapping();
        }

        private void InitializeLookupDictionaries(DTOPreInvExtractParams extractParams)
        {
            InitializeProductAnalysisGroups();
        }

        private void ValidateAccountRecords(DTOPreInvExtractParams extractParams, List<int> accToProcess)
        {
            var toRemove = new List<int>();
            foreach (var accountClassId in accToProcess)
            {
                var account = _localCache.GetSingle<DTOAccount>(accountClassId, true);
                if (account == null)
                {
                    var accountClass = _localCache.GetSingle<DTOAccountClass>(accountClassId);
                    RegisterExtractionError(PreInvExtractionErrorTypes.NoAccountRecord, accountClass.AccountCode);
                    toRemove.Add(accountClassId);
                    continue;
                }
                if (account.StockHoldLocation.HasValue && (account.StockHoldLocation != 0) &&
                    !extractParams.IsInterCompanyTransfer)
                {
                    toRemove.Add(accountClassId);
                    continue;
                }
                if (
                        (extractParams.InvoicePeriodType == PreInvInvoicePeriodType.DailyOnly) &&
                        (_sharedProcessingHelpers.GetInvoicePeriodType(account.InvoicePeriod) != PreInvInvoicePeriodType.DailyOnly)
                   )
                {
                    toRemove.Add(accountClassId);
                    continue;
                }
                if ((_invoiceTypeToBatchTypeMapping[account.InvoiceType] & extractParams.BatchType) == 0)
                {
                    toRemove.Add(accountClassId);
                    continue;
                }
                if ((account.AccountBelongsToCompanyNo ?? _defaultCompanyNo) != extractParams.CompanyNo)
                {
                    toRemove.Add(accountClassId);
                    continue;
                }
            }

            foreach (var item in toRemove)
            {
                accToProcess.Remove(item);
            }
        }

        private void ValidateDebtors(DTOPreInvExtractParams extractParams, List<int> accToProcess)
        {
            var toRemove = new List<int>();

            foreach (var accountClassId in accToProcess)
            {
                var account = _localCache.GetSingle<DTOAccount>(accountClassId);
                DTOHeadOffice headOffice;
                int? accountGLType = null;
                if (_headOfficesForAccounts.TryGetValue(accountClassId, out headOffice))
                {
                    var accountHof = _localCache.GetSingle<DTOAccount>(headOffice.HeadOfficeAccountClassId);
                    accountGLType = accountHof.GLType;
                }
                else
                {
                    accountGLType = account.GLType;
                }

                if (!_sharedProcessingHelpers.LookupGLCode(new DTOGLLookupParams
                {
                    LookupType = PreInvGLLookupType.Debtors,
                    SalesOfficeNo = extractParams.SalesOfficeNo,
                    AccountGLType = accountGLType
                }, this)
                    )
                {
                    toRemove.Add(accountClassId);
                    continue;
                }
            }

            foreach (var item in toRemove)
            {
                accToProcess.Remove(item);
                _headOfficesForAccounts.Remove(item);
            }
        }

        private void ProcessAccountsHeadOffice(DTOPreInvExtractParams extractParams, List<int> accToProcess)
        {
            var headOffices = _headOfficeRepository.GetData(null, CachingStrategy.GlobalCache);//TODO: clarify caching strategy here
            var headOfficesAccountClasses = new Dictionary<int, int>();
            var headOfficesForAccounts = new Dictionary<int, DTOHeadOffice>();

            foreach (var accountClassId in accToProcess)
            {
                var account = _localCache.GetSingle<DTOAccount>(accountClassId);

                DTOHeadOffice result = null;
                if (extractParams.SalesOfficeNo != DTOSalesOffice.IncludeAllSalesOfficesNo)
                {
                    result = headOffices.Where
                        (i =>
                         (i.Id == account.HeadOfficeId) &&
                         (i.CurrencyNo == extractParams.CurrencyNo) &&
                         (i.SalesOfficeNo == extractParams.SalesOfficeNo)
                        ).FirstOrDefault();
                }
                if (result == null)
                {
                    result = headOffices.Where
                        (i =>
                         (i.Id == account.HeadOfficeId) &&
                         (i.CurrencyNo == extractParams.CurrencyNo) &&
                         (i.SalesOfficeNo == DTOSalesOffice.IncludeAllSalesOfficesNo)
                        ).FirstOrDefault();
                }

                if (result != null)
                {
                    headOfficesForAccounts.Add(accountClassId, result);
                    headOfficesAccountClasses.Add(accountClassId, result.HeadOfficeAccountClassId);
                }
            }

            if (headOfficesAccountClasses.Count != 0)
            {
                LoadAccountsData(headOfficesAccountClasses.Values.Distinct().ToList(), RequestContextCacheMergeBehaviour.SkipIfKeyExist);

                var toRemove = new List<int>();
                foreach (var hofRecord in headOfficesAccountClasses)
                {
                    var accountClassId = hofRecord.Key;
                    var headOfficeAccountClassId = hofRecord.Value;
                    var accountClassHof = _localCache.GetSingle<DTOAccountClass>(headOfficeAccountClassId, true);
                    if (accountClassHof == null)
                    {
                        RegisterExtractionError(PreInvExtractionErrorTypes.NoAccountClassRecord, "HOF.AccClass=" + headOfficeAccountClassId.ToString());
                        toRemove.Add(accountClassId);
                        continue;
                    }
                    if (accountClassHof.Type != DTOAccountType.Customer)
                    {
                        RegisterExtractionError(PreInvExtractionErrorTypes.InvalidHeadOfficeRecord, accountClassHof.AccountCode);
                        toRemove.Add(accountClassId);
                        continue;
                    }
                    var accountHof = _localCache.GetSingle<DTOAccount>(headOfficeAccountClassId, true);
                    if (accountHof == null)
                    {
                        RegisterExtractionError(PreInvExtractionErrorTypes.NoAccountRecord, accountClassHof.AccountCode);
                        toRemove.Add(accountClassId);
                        continue;
                    }
                    if ((accountHof.AccountBelongsToCompanyNo ?? _defaultCompanyNo) != extractParams.CompanyNo)
                    {
                        RegisterExtractionError(PreInvExtractionErrorTypes.MismatchedCompNoInDlvdAndHofAccounts, accountClassHof.AccountCode);
                        toRemove.Add(accountClassId);
                        continue;
                    }

                    //TODO: IsEdiCst is detected here using AccANANumber of original account ang Hof account.
                }

                foreach (var item in toRemove)
                {
                    accToProcess.Remove(item);
                    headOfficesForAccounts.Remove(item);
                    headOfficesAccountClasses.Remove(item);
                }
            }

            _headOfficesForAccounts = headOfficesForAccounts;

            _localAccounts =
                _accountRepository.GetLocalAccounts
                    (
                        extractParams.SalesOfficeNo,
                        accToProcess.Union(headOfficesAccountClasses.Values.Distinct()).Distinct().ToList()
                    );

            var ediCoSuppNos = _ediCoSuppNoRepository.GetByCompanyNo(extractParams.CompanyNo);
            _localCache.Put(ediCoSuppNos, i => i.HeadOfficeId);
        }

        private void DetectPriceListGroups(DTOPreInvExtractParams extractParams, List<int> accToProcess)
        {
            var result = new Dictionary<int, int>();

            const int defaultPriceGroup = -99;

            if (!_systemPreferences.UseAlternativeProductGroups)
            {
                var priceGroups = _priceGroupRepository.GetPriceGroupsByIDs(accToProcess);
                foreach (var accountClassId in accToProcess)
                {
                    var curPriceGroups = priceGroups.Where(i => i.AccountClassId == accountClassId).ToList();
                    if (curPriceGroups.Count == 0)
                    {
                        result.Add(accountClassId, defaultPriceGroup);
                        continue;
                    }
                    //IT WAS AGREED THAT CASE WITH curPriceGroups.Count == 1 CAN BE SUBSTITUTED WITH THE FOLLOWING
                    int selectedPriceGroup = defaultPriceGroup;
                    foreach (var priceGroup in curPriceGroups)
                    {
                        if (priceGroup.PriceGroupSalesOfficeNo == extractParams.SalesOfficeNo)
                        {
                            selectedPriceGroup = priceGroup.PriceGroupNo;
                            break;
                        }
                        if (!priceGroup.PriceGroupSalesOfficeNo.HasValue)
                        {
                            selectedPriceGroup = priceGroup.PriceGroupNo;
                        }
                    }
                    result.Add(accountClassId, selectedPriceGroup);
                }
            }
            else
            {
                var priceGroupsAlt = _priceGroupRepository.GetAlternativePriceGroupsByIDs(accToProcess);
                foreach (var accountClassId in accToProcess)
                {
                    int priceGroupNo;
                    result.Add(accountClassId,
                               priceGroupsAlt.TryGetValue(accountClassId, out priceGroupNo)
                                   ? priceGroupNo
                                   : defaultPriceGroup);
                }
            }
            _accountClassPriceGroups = result;
        }

        private bool IsAllowedInvoiceTypesForDeliveryHead(int? tranInd, PreInvInvoiceType usedInvoiceType, out PreInvInvoiceType allowedInvoiceTypes)
        {
            allowedInvoiceTypes = (PreInvInvoiceType)0;
            if (!tranInd.HasValue)
            {
                return false;
            }

            PreInvInvoiceType allowedInvoiceTypesRaw;
            if (!_deliveryTranIndToInvoiceTypeMapping.TryGetValue(tranInd.Value, out allowedInvoiceTypesRaw))
            {
                return false;
            }
            allowedInvoiceTypes = allowedInvoiceTypesRaw & usedInvoiceType;
            return allowedInvoiceTypes != 0;
        }

        private bool ValidateDeliveryRecord(DTOPreInvExtractParams extractParams, DTODeliveryHead delivery, DeliveryValidationContext deliveryContext, ref bool orderValid)
        {
            if (extractParams.IsInterCompanyTransfer)
            {
                if (delivery.TransferFlag < 1)
                {
                    return false;
                }
                if (!delivery.SalesOfficeTransferTo.HasValue)
                {
                    return false;
                }
                if (delivery.SalesOfficeTransferTo == delivery.DeliverySalesOfficeNo)
                {
                    return false;
                }
                /*IT WAS AGREED TO SKIP THIS VALIDATION FOR NOW.
                 
                var transFlagkey = string.Format("{0}~{1}", delivery.DeliverySalesOfficeNo, delivery.SalesOfficeTransferFrom);
                int transFlag;
                if (!deliveryContext.TransMeth.TryGetValue(transFlagkey, out transFlag))
                {
                    //Clarify what to do with that library:
                    //lReqDlv = ChngOwnLib.GetTransMethPref(SmallInt(tc["Delhed"].DLVSALOFFNO), SmallInt(tc["Delhed"].TRNSALOFFNO),TrnPrefMethDynAr)
                    //if lReqDlv AND SmallInt(TrnPrefMethDynAr["AuthType"]) > 0 then TransFlagSi = SmallInt(TrnPrefMethDynAr["AuthType"])
                    transFlag = _systemPreferences.TransShipmentAuthFlag;
                    deliveryContext.TransMeth[transFlagkey] = transFlag;
                }
                //Validate transhipment authorization using
                //SELECT D.DelDlvOrdNo
                //FROM Deldet as D
                //  INNER JOIN TransferOwer as O ON TROTRANDELRECNO = DELRECNO AND PRICECONF <> !!!transFlag!!!
                //WHERE DELDLVORDNO = !!!Delhed.ID!!!
                //writeInvErr(Smallint(401), strVal(tc["Accounts"].AccCode), strVal(tc["Orders"].OrdCustOrdNo), Longint(tc["Delhed"].DlvOrdNo))
                 
                 */
            }
            else
            {
                if ((delivery.IsInterCompanyTransfer) || (delivery.TransferFlag > 0))
                {
                    return false;
                }
            }

            if (delivery.CurrencyNo != extractParams.CurrencyNo)
            {
                return false;
            }

            PreInvInvoiceType allowedInvoiceTypes;
            if (!IsAllowedInvoiceTypesForDeliveryHead(delivery.TranInd, extractParams.InvoiceType, out allowedInvoiceTypes))
            {
                return false;
            }

            if (extractParams.SalesOfficeNo != DTOSalesOffice.IncludeAllSalesOfficesNo)
            {
                if (delivery.InvoiceSalesOfficeNo.HasValue && (delivery.InvoiceSalesOfficeNo.Value > 0))
                {
                    if (!_involvedSalesOffices.Contains(delivery.InvoiceSalesOfficeNo.Value))
                    {
                        return false;
                    }
                }
                else
                {
                    if (!delivery.DeliverySalesOfficeNo.HasValue || !_involvedSalesOffices.Contains(delivery.DeliverySalesOfficeNo.Value))
                    {
                        return false;
                    }
                }
            }

            if ((allowedInvoiceTypes & PreInvInvoiceType.Invoice) != 0)
            {
                if
                    (
                        (_context.Account.PODRequired) &&
                        (delivery.DeliveryStatus == DTODeliveryStatus.Released) &&
                        (string.IsNullOrWhiteSpace(delivery.PoDNo))
                    )
                {
                    RegisterExtractionError(PreInvExtractionErrorTypes.DeliveryRequiresPOD);
                    orderValid = false;
                    return false;
                }
            }

            if (delivery.DeliveryStatus == DTODeliveryStatus.Released)
            {
                deliveryContext.ReleasedCount++;
                if (_systemPreferences.UseShipDate)
                {
                    if (delivery.ShipDate.HasValue && (delivery.ShipDate.Value > extractParams.CutOffDeliveryDate))
                    {
                        deliveryContext.NotRequiredDate++;
                    }
                }
                else
                {
                    if (delivery.DeliveryDate.HasValue && (delivery.DeliveryDate.Value > extractParams.CutOffDeliveryDate))
                    {
                        deliveryContext.NotRequiredDate++;
                    }
                }

                if (delivery.DeliveryTypeId.HasValue && (delivery.DeliveryTypeId != 0))
                {
                    if (!_deliveryTypeRepository.GetData(null, CachingStrategy.GlobalCache).Exists(i => i.Id == delivery.DeliveryTypeId))
                    {
                        RegisterExtractionError(PreInvExtractionErrorTypes.UnknownDeliveryType);
                        orderValid = false;
                        return false;
                    }
                }

                if (!_currencyDictionaryRepository.GetData(null, CachingStrategy.GlobalCache).Exists(i => i.No == delivery.CurrencyNo))
                {
                    RegisterExtractionError(PreInvExtractionErrorTypes.UnknownCurrencyTypeForDelivery);
                    orderValid = false;
                    return false;
                }

            }
            else
                if (delivery.DeliveryStatus != DTODeliveryStatus.Invoiced)
                {
                    deliveryContext.NotReleasedCount++;
                }

            PreInvInvoiceType accountInvoiceTypes;
            if (_accountPossibleInvoiceTypes.TryGetValue(_context.AccountClass.Id, out accountInvoiceTypes))
            {
                _accountPossibleInvoiceTypes[_context.AccountClass.Id] = accountInvoiceTypes | allowedInvoiceTypes;
            }
            else
            {
                _accountPossibleInvoiceTypes.Add(_context.AccountClass.Id, allowedInvoiceTypes);
            }

            return true;
        }

        private bool ValidateOrderRecord(DTOPreInvExtractParams extractParams, DTOOrder order)
        {
            if ((order.Deliveries == null) || (order.Deliveries.Count == 0))
            {
                return false;
            }

            bool orderValid = true;
            var deliveryContext = new DeliveryValidationContext();
            foreach (var deliveryHead in order.Deliveries)
            {
                _context.DeliveryHead = deliveryHead;
                ValidateDeliveryRecord(extractParams, deliveryHead, deliveryContext, ref orderValid);
                if (!orderValid)
                {
                    return false;
                }
            }
            _context.DeliveryHead = null;
            if (deliveryContext.ReleasedCount == 0)
            {
                return false;
            }

            if ((extractParams.InvoiceType & PreInvInvoiceType.Invoice) != 0)
            {
                /*ValidateOrderResult validationResult =
                    extractParams.InvoiceType == PreInvInvoiceType.Invoice //If this is just invoice run - order failed. Otherwise skipping only invoice loop
                        ? ValidateOrderResult.InvalidCompletely
                        : ValidateOrderResult.InvalidForInvoices;*/

                if (_allowedNotRelDeliveryInvoiceTypes.Contains(_context.Account.InvoiceType))
                {
                    if (deliveryContext.NotReleasedCount != 0)
                    {
                        RegisterExtractionError(PreInvExtractionErrorTypes.NotAllDeliveriesForOrderReleased);
                        return false;
                    }
                    if (deliveryContext.NotRequiredDate != 0)
                    {
                        RegisterExtractionError(PreInvExtractionErrorTypes.DeliveriesForOrderOutsideCutOffDate);
                        return false;
                    }
                }

                if (_context.Account.HeadOfficeId.HasValue && _context.Account.HeadOfficeId.Value > 0)
                {
                    var hofInvSalesOfficeNo = _headOfficesForAccounts[_context.Account.Id].InvoiceSalesOfficeNo;
                    if (hofInvSalesOfficeNo.HasValue && (hofInvSalesOfficeNo > 0))
                    {
                        foreach (var delivery in order.Deliveries)
                        {
                            _context.DeliveryHead = delivery;
                            if (
                                (delivery.DeliveryStatus != DTODeliveryStatus.Invoiced) &&
                                ((_context.Account.InvoiceType == DTOInvoiceType.CombinedDeliveriesGross) ||
                                 (_context.Account.InvoiceType == DTOInvoiceType.CombinedDeliveriesNett)) &&
                                (delivery.InvoiceSalesOfficeNo != hofInvSalesOfficeNo)
                                )
                            {
                                RegisterExtractionError(PreInvExtractionErrorTypes.CombinedSOInvoicingButNotAllDeliveriesForThisSO);
                                return false;
                            }
                        }
                        _context.DeliveryHead = null;
                    }
                }
            }

            return true;
        }

        private void InitializeAccountExecutionContext(int salesOfficeNo, int accountClassId)
        {
            _context = new ExtractionExecutionContext
            {
                AccountClass = _localCache.GetSingle<DTOAccountClass>(accountClassId),
                Account = _localCache.GetSingle<DTOAccount>(accountClassId),
                RequiredPriceGroupNo = _accountClassPriceGroups[accountClassId]
            };

            DTOHeadOffice accountHeadOffice;
            if (_headOfficesForAccounts.TryGetValue(accountClassId, out accountHeadOffice))
            {
                _context.AccountClassHof = _localCache.GetSingle<DTOAccountClass>(accountHeadOffice.HeadOfficeAccountClassId);
                _context.AccountHof = _localCache.GetSingle<DTOAccount>(accountHeadOffice.HeadOfficeAccountClassId);
            }
            else
            {
                _context.AccountClassHof = _context.AccountClass;
                _context.AccountHof = _context.Account;
            }

            _context.LocalAccountCode = _localAccounts[_context.Account.Id];

            string localAccountCode;
            _context.HofLocalAccountCode =
                _localAccounts.TryGetValue(_context.AccountHof.Id, out localAccountCode)
                    ? localAccountCode
                    : _context.AccountHof.Code;

            _context.BatchTypeForAccount = _invoiceTypeToBatchTypeMapping[_context.Account.InvoiceType];

            _context.SalesOffice = _salesOfficeRepository.GetData(null, CachingStrategy.GlobalCache).FirstOrDefault(i => i.SalesOfficeNumber == salesOfficeNo);

        }

        public void InitializeInvoiceTypeSpecificAccountExecutionContext(PreInvInvoiceType invoiceType, int accountClassId)
        {
            _context.IsEdiCustomer = IsEdiCustomer(invoiceType, _context.Account, _context.AccountHof);

            _context.AllowedDeliveryPriceStatus = GetAllowedDeliveryPriceStatus(invoiceType, _context.Account.InvoiceType);
        }

        private void CleanAccountExecutionContext()
        {
            _context = null;
        }


        private bool ValidateDeliveryHeadRecord(DTOPreInvExtractParams extractParams, DTODeliveryHead delivery)
        {
            if (delivery.IsInterDepartment)
            {
                if (!_sharedProcessingHelpers.LookupGLCode(new DTOGLLookupParams
                {
                    LookupType = PreInvGLLookupType.InterDepartment,
                    SalesOfficeNo = extractParams.SalesOfficeNo
                }, this))
                {
                    //_logger.Debug(string.Format("Delivery Head Validation Failed For DelHead {0}. LookupGLCode failed to locate PreInvGLLookupType.InterDepartment", delivery.Id));
                    return false;
                }
            }

            //In original pre-invoicing code - here is quite a lot duplicated checks already performed at ValidateDeliveryRecord

            if (_systemPreferences.UseShipDate)
            {
                if (delivery.ShipDate.HasValue && (delivery.ShipDate.Value > extractParams.CutOffDeliveryDate))
                {
                    //_logger.Debug(string.Format("Delivery Head Validation Failed For DelHead {0}. Ship date {1} > Cut off date {2}", delivery.Id, delivery.ShipDate.Value.ToString(), extractParams.CutOffDeliveryDate.ToString()));
                    return false;
                }
            }
            else
            {
                if (delivery.DeliveryDate.HasValue && (delivery.DeliveryDate.Value > extractParams.CutOffDeliveryDate))
                {
                    //_logger.Debug(string.Format("Delivery Head Validation Failed For DelHead {0}. Delivery date {1} > Cut off date {2}", delivery.Id, delivery.DeliveryDate.Value.ToString(), extractParams.CutOffDeliveryDate.ToString()));
                    return false;
                }
            }

            return true;
        }

        private bool ValidateAccountOrders(DTOPreInvExtractParams extractParams, int accountClassId)
        {
            var orders = _localCache.Get<DTOOrder>(accountClassId);
            if (orders.Count == 0)
            {
                return false;
            }

            InitializeAccountExecutionContext(extractParams.SalesOfficeNo, accountClassId);
            try
            {
                var ordersToRemove = new List<DTOOrder>();
                foreach (var order in orders)
                {
                    _context.Order = order;
                    bool orderValidationResult = ValidateOrderRecord(extractParams, order);
                    /*if (orderValidationResult == ValidateOrderResult.InvalidForInvoices)
                    {
                        //_ordersToSkipForInvoiceRun.Add(order.Id);
                    }*/
                    if (orderValidationResult)
                    {
                        var deliveriesToRemove = new List<DTODeliveryHead>();
                        foreach (var delivery in order.Deliveries)
                        {
                            _context.DeliveryHead = delivery;
                            if (!ValidateDeliveryHeadRecord(extractParams, delivery))
                            {
                                //Validating which orders should be skiped for Invoice Run
                                if (CheckIfSkipedDeliveryEscalatesToScipedOrder(PreInvInvoiceType.Invoice))
                                {
                                    /*if (orderValidationResult)
                                    {
                                        //_ordersToSkipForInvoiceRun.Add(order.Id);
                                    }*/
                                    if (_accountPossibleInvoiceTypes[accountClassId] == PreInvInvoiceType.Invoice)
                                    {
                                        orderValidationResult = false;
                                        break; //Abort to process complete order 
                                    }
                                }
                                //_logger.Debug(string.Format("Removing Delivery ID {0} from Order ID {1} as it is not passed account order validation", delivery.Id, order.Id));
                                _localCache.DeleteItem<DTODeliveryHead>(order.Id, delivery);
                                deliveriesToRemove.Add(delivery);
                            }
                        }
                        _context.DeliveryHead = null;
                        foreach (var delivery in deliveriesToRemove)
                        {
                            order.Deliveries.Remove(delivery);
                        }
                        if (order.Deliveries.Count == 0)
                        {
                            ordersToRemove.Add(order);
                        }
                    }
                    if (!orderValidationResult)
                    {
                        //_logger.Debug(string.Format("Removing Complete Order ID {0} as it is not passed account order validation", order.Id));
                        _localCache.DeleteGroup<DTODeliveryHead>(order.Id);
                        _localCache.DeleteItem<DTOOrder>(accountClassId, order);
                        ordersToRemove.Add(order);
                    }
                }
                _context.Order = null;
                foreach (var order in ordersToRemove)
                {
                    orders.Remove(order);
                }
                if (orders.Count == 0)
                {
                    return false;
                }

            }
            finally
            {
                CleanAccountExecutionContext();
            }
            return true;
        }

        private void InitializeInvoiceTotals(DTOPreInvExtractParams extractParams)
        {
            if (
                    GetInvoiceTotals
                    (
                        _context.BatchTypeForAccount,
                        _context.InvoiceTypeForAccount,
                        _context.AccountClass.AccountCode,
                        _context.Order.Id,
                        _context.DeliveryHead.Id,
                        true
                    )
                )
            {
                if (
                        _context.Account.UseDeliveryDateAsInvoiceDate &&
                        (_context.DeliveryHead.DeliveryDate > _context.InvoiceTotal.InvDate)
                   )
                {
                    _context.InvoiceTotal.InvDate = _context.DeliveryHead.DeliveryDate;
                }
                return;
            }

            bool isPerDelivery = _context.BatchTypeForAccount == PreInvBatchType.PerDelivery;

            // Invoice Number Calculation
            int invoiceNo;
            if (
                    !isPerDelivery ||
                    _context.IsDeliveryGoodsOnConsignment ||
                    IsSequentialInvoiceNos(_context.InvoiceTypeForAccount, _context.SalesOffice) ||
                    _context.DeliveryHead.IsOpenPriceDelivery
               )
            {
                _context.InvoiceTotal.IsSeqInvNo = true;
                invoiceNo = _nextInvoiceNo;
                if (_systemPreferences.AddYearToInvNo)
                {
                    invoiceNo = invoiceNo * 100 + (DateTime.Now.Year % 100);
                }

                if
                    (
                        _systemPreferences.AddSoToInvNo &&
                        DTOSalesOffice.GetUnsignedSalesOfficeNumber(extractParams.SalesOfficeNo) > 0
                    )
                {
                    invoiceNo = invoiceNo * 100 + (extractParams.SalesOfficeNo % 100);
                }
            }
            else
            {
                _context.InvoiceTotal.IsSeqInvNo = false;
                invoiceNo = _context.DeliveryHead.Id;
            }

            string stInvoiceNo;
            if (extractParams.IsInterCompanyTransfer)
            {
                stInvoiceNo = InvPrefix_Transfer + invoiceNo;
            }
            else
            {
                if (_context.DeliveryHead.IsInterDepartment)
                {
                    stInvoiceNo = InvPrefix_InterDept + invoiceNo;
                }
                else
                {
                    stInvoiceNo = InvPrefix_Normal + invoiceNo;
                }
            }

            _context.InvoiceTotal.InvoiceNo = stInvoiceNo; // read last invoice number;

            // Invoice Date Calculation

            DateTime? invoiceDate = extractParams.TaxPointDate; //; karena 03/06/08

            if (_context.AccountHof.UseDeliveryDateAsInvoiceDate)
            {
                invoiceDate = _context.DeliveryHead.DeliveryDate;
            }
            else //TODO: Not per delivery branch does not have this else section. To clarify.
            {
                if (_systemPreferences.UseShipDate)
                {
                    invoiceDate = _context.DeliveryHead.ShipDate;
                }
                else
                {
                    if (isPerDelivery && _systemPreferences.UseDelivDate)
                    {
                        invoiceDate = _context.DeliveryHead.DeliveryDate;
                    }
                }
            }

            _context.InvoiceTotal.InvDate = invoiceDate; // read last invoice number;

        }

        private DTOVatRate GetBestVat(DTOPreInvExtractParams extractParams, out DTOVatLink vatLinkRecord)
        {
            /*Searches the VatLinks database for the 'best' fit with the supplied data
              the 'score' is increased for each field that matches.  If a field in
              Vatlinks is set to DONTCARE (-32000) or is blank then it is ignored in the
              scoring.  If a field does not match then the scoring is abandoned for that record

              Returns the VatRates.VatRecNo and VatExempt.VeaRecNo in two vars*/
            const int VatCalc_DONTCARE = -32000;

            var deliveryType = _context.DeliveryHead.DeliveryTypeId;
            var deliveryCountry = _context.Account.CountryNo;
            var fromStockLoc = _context.DeliveryHead.FromStockLocationId;
            var customerVatType = _context.Account.CustomerVatType;
            var product = _context.Product;
            var forSalesOfficeNo = extractParams.SalesOfficeNo;
            int chargeType = 1;

            int bestScoreSoFar = -1;
            int thisRecordScore = 0;

            vatLinkRecord = null;

            if (!fromStockLoc.HasValue)
            {
                //TODO: Logging {"Problem", "Blank Stock location found in VAT Calculation"}
                return null;
            }

            var stockLocation = _stockLocationRepository.GetData(null, CachingStrategy.GlobalCache).FirstOrDefault(i => i.Id == fromStockLoc.Value);
            if ((stockLocation == null) || !stockLocation.InCountry.HasValue)
            {
                //TODO: Logging {"Problem", "Can not find country for stock location"}
                return null;
            }

            var vatLinks =
                _vatLinkRepository.GetData(null, CachingStrategy.PerRequest) //TODO: discuss CachingStrategy.GlobalCache
                    .Where(i => (i.AccountType == DTOAccountType.Customer) && (i.FromCountryNo == stockLocation.InCountry.Value))
                    .ToList();

            if (vatLinks.Count == 0)
            {
                return null;
            }

            foreach (var vatLink in vatLinks)
            {
                thisRecordScore = 0;
                if (vatLink.DeliveryTypeId != VatCalc_DONTCARE)
                {
                    if (vatLink.DeliveryTypeId != deliveryType)
                    {
                        continue;
                    }
                    thisRecordScore++;
                }
                if (vatLink.DeliveryCountryNo != VatCalc_DONTCARE)
                {
                    if (vatLink.DeliveryCountryNo != deliveryCountry)
                    {
                        continue;
                    }
                    thisRecordScore++;
                }
                if (vatLink.SalesOfficeNo != VatCalc_DONTCARE)
                {
                    if (vatLink.SalesOfficeNo != forSalesOfficeNo)
                    {
                        continue;
                    }
                    thisRecordScore++;
                }
                if (vatLink.ProductLevel1Ref.HasValue)
                {
                    if (vatLink.ProductLevel1Ref != product.Level1Ref)
                    {
                        continue;
                    }
                    thisRecordScore++;
                }
                if (vatLink.ProductLevel2Ref.HasValue)
                {
                    if (vatLink.ProductLevel2Ref != product.Level2Ref)
                    {
                        continue;
                    }
                    thisRecordScore++;
                }
                if (vatLink.ProductLevel3Ref.HasValue)
                {
                    if (vatLink.ProductLevel3Ref != product.Level3Ref)
                    {
                        continue;
                    }
                    thisRecordScore++;
                }
                if (vatLink.ProductLevel4Ref.HasValue)
                {
                    if (vatLink.ProductLevel4Ref != product.Level4Ref)
                    {
                        continue;
                    }
                    thisRecordScore++;
                }
                if (vatLink.ProductLevel5Ref.HasValue)
                {
                    if (vatLink.ProductLevel5Ref != product.Level5Ref)
                    {
                        continue;
                    }
                    thisRecordScore++;
                }
                if (vatLink.ProductLevel6Ref.HasValue)
                {
                    if (vatLink.ProductLevel6Ref != product.Level6Ref)
                    {
                        continue;
                    }
                    thisRecordScore++;
                }
                if (vatLink.VatGroupNo > 0)
                {
                    continue;
                }
                if (vatLink.ChargeType != VatCalc_DONTCARE)
                {
                    if (vatLink.ChargeType != chargeType)
                    {
                        continue;
                    }
                    thisRecordScore++;
                }
                if (vatLink.VatType != VatCalc_DONTCARE)
                {
                    if (vatLink.VatType != customerVatType)
                    {
                        continue;
                    }
                    thisRecordScore++;
                }

                if (thisRecordScore > bestScoreSoFar)
                {
                    vatLinkRecord = vatLink;
                    bestScoreSoFar = thisRecordScore;
                }
            }

            if (vatLinkRecord != null)
            {
                //got a record, so find out the vat rec no and exemption codes
                if (vatLinkRecord.VatRateId.HasValue && (vatLinkRecord.VatRateId != VatCalc_DONTCARE)) // rjs 23/05/01 to allow VatRecNo of 0. Was if VatRecNo > 0.
                {
                    int vatRateId = vatLinkRecord.VatRateId.Value;
                    var varRate = _vatRateRepository.GetData(null, CachingStrategy.PerRequest).FirstOrDefault(i => i.Id == vatRateId); //TODO: Discuss CachingStrategy.GlobalCache
                    if (varRate != null)
                    {
                        if (!varRate.VatRate.HasValue)
                        {
                            RegisterExtractionError(PreInvExtractionErrorTypes.BlankVATRate); //error 24
                            return null;
                        }
                        return varRate;
                    }
                    RegisterExtractionError(PreInvExtractionErrorTypes.UnableToLocateVatRecord);
                    return null;
                }
                else
                {
                    RegisterExtractionError(PreInvExtractionErrorTypes.InvalidVatRecordNo);
                    return null;
                }
            }

            return null;
        }

        private bool CheckPriceListVat()
        {
            if (_context.RequiredPriceGroupNo == 0)
            {
                return true;
            }

            if (!_context.DeliveryHead.DeliveryDate.HasValue || !_context.DeliveryDetail.ProductId.HasValue)
            {
                return false;
            }

            var productVatCheckList = _priceListVatCheckRepository.GetProductsVatByPriceGroupNoAndDate(_context.RequiredPriceGroupNo, _context.DeliveryHead.DeliveryDate.Value);
            var item = productVatCheckList.FirstOrDefault(i => i.ProductId == _context.DeliveryDetail.ProductId);
            if ((item == null) || !item.VatId.HasValue || (item.VatId.Value == 0))
            {
                return true; //Not configured - valid - no check reqd.
            }

            var vatId = item.VatId.Value;

            if (vatId != _context.VatRate.Id)
            {
                RegisterExtractionError(PreInvExtractionErrorTypes.PricelistVATMismatchesSystemDeterminedVAT);
                return false;
            }

            return true;
        }

        private bool DetectDiscountsRates()
        {
            _context.DiscountRates.Clear();

            _context.ApplyRebatesToFreeOfChargeGoods = false;
            _context.HasDiscountRates = false;
            _context.HasRebateRates = false;

            if (!_context.DeliveryHead.DeliveryDate.HasValue)
            {
                RegisterExtractionError(PreInvExtractionErrorTypes.DeliveryDateIsEmptyOrInvalid);
                return false;
            }

            if ((_context.DeliveryHead.CustomerDiscountRates == null) || _context.DeliveryHead.CustomerDiscountRates.Count == 0)
            {
                return true;
            }

            const int DONTCARE = -32000;

            DTOCustDiscountRates bestCustDiscountRate = null;
            int highestMatch = 0;
            foreach (var custDiscountRate in _context.DeliveryHead.CustomerDiscountRates)
            {
                int noMatch = 0;
                bool badMatch = false;
                for (int i = 1; i < 6; i++)
                {
                    var productRef = _context.Product.GetRefByLevel(i);
                    if (productRef.HasValue && (productRef.Value > 0))
                    {
                        var discProductRef = custDiscountRate.GetRefByLevel(i);
                        if (discProductRef == DONTCARE)
                        {
                            noMatch++;
                        }
                        else
                            if (discProductRef == productRef)
                            {
                                noMatch += 2; //Add 2 to force it to the Match
                            }
                            else
                                if (discProductRef > 0)
                                {
                                    badMatch = true;
                                    break;
                                }
                    }
                }

                if (badMatch)
                {
                    continue; //bad match
                }

                if (custDiscountRate.StockLocationId == _context.DeliveryHead.StockLocationId)
                {
                    noMatch += 3; // BRL Changed 29-05-03
                }
                else
                    if (custDiscountRate.StockLocationId != DONTCARE)
                    {
                        continue; //bad match
                    }

                if (custDiscountRate.SalesOfficeNo == _context.DeliveryHead.DeliverySalesOfficeNo)
                {
                    noMatch += 3;
                }
                else
                    if (custDiscountRate.SalesOfficeNo != DONTCARE)
                    {
                        continue; //bad match
                    }

                if (noMatch > highestMatch)
                {
                    bestCustDiscountRate = custDiscountRate;
                    highestMatch = noMatch;
                }
            }

            bool stndUnitRates = false;
            if (bestCustDiscountRate != null)
            {
                var discountRates = _localCache.Get<DTODiscountRates>(bestCustDiscountRate.DraRecNo);
                if ((discountRates == null) || (discountRates.Count == 0))
                {
                    return true;
                }
                discountRates = discountRates.OrderBy(i => i.ThisSeqNo).ToList();

                foreach (var discountRate in discountRates)
                {
                    DiscountRecordItem rateRecord = null;
                    var discountStage = Enums<EnumDiscTypesStage>.GetValue(discountRate.ThisOn);
                    if (Math.Abs(discountRate.ThisRate) > 0.001M)
                    {
                        rateRecord = new DiscountRecordItem
                                         {
                                             Rate = discountRate.ThisRate,
                                             Type = discountStage.Combine(EnumDiscTypesMethod.Ordinary),
                                             GLRecNo = discountRate.DisGlRecNo,
                                             DedStr = discountRate.ThisDedStr
                                         };
                    }
                    else
                        if (Math.Abs(discountRate.ThisPercRate) > 0.001M)
                        {
                            rateRecord = new DiscountRecordItem
                                             {
                                                 Rate = discountRate.ThisPercRate,
                                                 Type = discountStage.Combine(EnumDiscTypesMethod.Percentage),
                                                 GLRecNo = discountRate.DisGlRecNo,
                                                 DedStr = discountRate.ThisDedStr
                                             };
                        }
                        else
                            if (Math.Abs(discountRate.ThisStndUnitRate) > 0.001M)
                            {
                                rateRecord = new DiscountRecordItem
                                                 {
                                                     Rate = discountRate.ThisStndUnitRate,
                                                     Type = discountStage.Combine(EnumDiscTypesMethod.StandardUnitRate),
                                                     GLRecNo = discountRate.DisGlRecNo,
                                                     DedStr = discountRate.ThisDedStr
                                                 };
                            }

                    if (rateRecord != null)
                    {
                        _context.DiscountRates.Add(discountRate.ThisSeqNo, rateRecord);

                        if (rateRecord.IsDiscountRate)
                        {
                            _context.HasDiscountRates = true;
                        }
                        else
                        {
                            _context.HasRebateRates = true;
                        }

                        if (rateRecord.Type.HasValue && (rateRecord.Type.Value.GetMethod() == EnumDiscTypesMethod.StandardUnitRate))
                        {
                            stndUnitRates = true;
                        }
                    }
                }
                _context.ApplyRebatesToFreeOfChargeGoods = bestCustDiscountRate.ApplyRebatesToFreeOfChargeGoods;
            }

            if (stndUnitRates)
            {
                if (!_systemPreferences.StandardUnitsRequired)
                {
                    RegisterExtractionError(PreInvExtractionErrorTypes.StandardUnitsFoundButSysPrefIsNotSetToStandardUnits);
                    return false;
                }
                if ((!_context.Product.Level1Ref.HasValue) || !_productStandardUnits.ContainsKey(_context.Product.Level1Ref.Value))
                {
                    RegisterExtractionError(PreInvExtractionErrorTypes.StandardUnitMissing);
                    return false;
                }
                if (_context.Product.StandardBoxWeightInKg < 0.05M)
                {
                    RegisterExtractionError(PreInvExtractionErrorTypes.NoWeightOnProduct);
                    return false;
                }
            }

            return true;
        }

        private void InitializeProductAnalysisGroups()
        {
            var analysisGroups = _productRepository.GetProductAnalysisGroups(_systemPreferences.ProductAnalysisLevNo);
            if (analysisGroups.Any(analysisGroup => !analysisGroup.Value.HasValue))
            {
                throw ErrorHelpers.TranslateErrorMessage(
                    new FreshTradeException(1024, "GL Analysis by Product Group has been set but not all items have been allocated to an analysis Group."));
            }
            _productAnalysisGroups = analysisGroups.ToDictionary(i => i.Key, i => i.Value.Value);

            if (_systemPreferences.StandardUnitsRequired && _systemPreferences.StandardUnitsLevel.HasValue)
            {
                _productStandardUnits = _productRepository.GetProductStandardUnits(_systemPreferences.StandardUnitsLevel.Value);
            }

        }

        private bool CheckGlXRefs(DTOPreInvExtractParams extractParams)
        {
            if (_context.HasDiscountRates)
            {
                if (!_sharedProcessingHelpers.LookupGLCode(new DTOGLLookupParams
                {
                    LookupType = PreInvGLLookupType.Discount,
                    SalesOfficeNo = extractParams.SalesOfficeNo,
                    ProductAnalysisGroup = _context.ProductAnalysisGroup
                }, this)
                    )
                {
                    return false;
                }
            }
            if (_context.HasRebateRates)
            {
                foreach (var discountRecordItem in _context.DiscountRates.Values)
                {
                    if (!_sharedProcessingHelpers.LookupGLCode(new DTOGLLookupParams
                    {
                        LookupType = PreInvGLLookupType.RebateBalance,
                        SalesOfficeNo = extractParams.SalesOfficeNo,
                        ProductAnalysisGroup = _context.ProductAnalysisGroup,
                        DiscountRebateGLNo = discountRecordItem.GLRecNo
                    }, this)
                        )
                    {
                        return false;
                    }
                    if (!_sharedProcessingHelpers.LookupGLCode(new DTOGLLookupParams
                    {
                        LookupType = PreInvGLLookupType.RebateProfitAndLoss,
                        SalesOfficeNo = extractParams.SalesOfficeNo,
                        ProductAnalysisGroup = _context.ProductAnalysisGroup,
                        DiscountRebateGLNo = discountRecordItem.GLRecNo
                    }, this)
                        )
                    {
                        return false;
                    }
                }

                //PreInvGLLookupType.ChComm & PreInvGLLookupType.ChHand seems to be not used in the previous code. So it is ignored here as well.
            }

            return true;
        }

        private bool ValidateDeliveryDetail(DTOPreInvExtractParams extractParams, DTODeliveryDetail deliveryDetail, out bool hasDelPrice)
        {
            int totalPriceQuantity = 0;
            decimal totalPriceWeightInKg = 0;
            bool hasInvoicedLine = false;
            hasDelPrice = false;
            bool isMiscCreditDebit = IsMiscCreditDebit(_context.DeliveryHead);
            foreach (var deliveryPrice in deliveryDetail.Prices)
            {
                if (!deliveryPrice.DeliveryPriceStatus.HasValue)
                {
                    throw new FreshTradeException("DelPrice has empty DelInvStatus"); //TODO: Decide what to do with NULL
                }
                if (new[]
                        {
                            DTODeliveryPriceStatus.NormalDelivery, // 1, 
                            DTODeliveryPriceStatus.InvoicedNormalDelivery, //11, 
                            DTODeliveryPriceStatus.MiscellanousCredit, // 7, 
                            DTODeliveryPriceStatus.InvoicedMiscCredit, // 17, 
                            DTODeliveryPriceStatus.MiscellanousDebit, // 8, 
                            DTODeliveryPriceStatus.InvoicedMisc // 18
                        }.Contains(deliveryPrice.DeliveryPriceStatus.Value)
                   )
                {
                    totalPriceQuantity += deliveryPrice.Quantity ?? 0;
                    totalPriceWeightInKg += deliveryPrice.WeightInKg;
                }

                if (
                        (deliveryPrice.DeliveryPriceStatus.Value < DTODeliveryPriceStatus.InvoicedNormalDelivery) && //Not yet invoiced
                        (deliveryPrice.Quantity.HasValue && (deliveryPrice.Quantity != 0))
                   )
                {
                    if (
                            !_context.IsDeliveryGoodsOnConsignment &&
                            hasInvoicedLine &&
                            (deliveryPrice.DeliveryPriceStatus.Value == DTODeliveryPriceStatus.NormalDelivery) &&
                            !_context.DeliveryHead.IsOpenPriceDelivery
                       )
                    {
                        RegisterExtractionError(PreInvExtractionErrorTypes.DeliveryHasPartInvoicedLineItem);
                        return false;
                    }

                    if (_context.AllowedDeliveryPriceStatus.Contains(deliveryPrice.DeliveryPriceStatus.Value))
                    {
                        if ((deliveryPrice.Quantity != 0) || (Math.Abs(deliveryPrice.NettValue) > (decimal)0.005))
                        {
                            if (
                                    !isMiscCreditDebit &&
                                    ((deliveryPrice.DeliveryToItemStockRecords == null) || (deliveryPrice.DeliveryToItemStockRecords.Count == 0))
                               )
                            {
                                RegisterExtractionError(PreInvExtractionErrorTypes.DeliveryIsNotFullyAllocatedToStock);
                                return false;
                            }

                            if (!hasDelPrice)
                            {
                                if (
                                        (_context.InvoiceTypeForAccount == PreInvInvoiceType.Invoice) &&
                                        (deliveryPrice.DeliveryPriceStatus == DTODeliveryPriceStatus.NormalDelivery) //1
                                   )
                                {
                                    hasDelPrice = true;
                                }
                                else
                                    if (
                                            (_context.InvoiceTypeForAccount == PreInvInvoiceType.CreditNote) &&
                                            (
                                                (deliveryPrice.DeliveryPriceStatus == DTODeliveryPriceStatus.CreditOnNormalDelivery) || //2
                                                (deliveryPrice.DeliveryPriceStatus == DTODeliveryPriceStatus.MiscellanousCredit)  //7
                                            )
                                       )
                                    {
                                        hasDelPrice = true;
                                    }
                                    else
                                        if (
                                                (_context.InvoiceTypeForAccount == PreInvInvoiceType.DebitNote) &&
                                                (
                                                    (deliveryPrice.DeliveryPriceStatus == DTODeliveryPriceStatus.DebitOnNormalDelivery) || //3
                                                    (deliveryPrice.DeliveryPriceStatus == DTODeliveryPriceStatus.MiscellanousDebit)  //8
                                                )
                                            )
                                        {
                                            hasDelPrice = true;
                                        }
                            }
                        }
                    }
                }
                else
                {
                    if (deliveryPrice.DeliveryPriceStatus.Value == DTODeliveryPriceStatus.InvoicedNormalDelivery) // 11
                    {
                        hasInvoicedLine = true;
                    }
                }
            }

            if (!hasDelPrice)
            {
                return true;
            }

            if (!_context.IsDeliveryGoodsOnConsignment)
            {
                if (totalPriceQuantity != _context.DeliveryDetail.Quantity)
                {
                    RegisterExtractionError(PreInvExtractionErrorTypes.PricedQuantityMismatchedDeliveredQuantity);
                    return false;
                }
                if (_context.DeliveryDetail.IsPricedByWeight && (totalPriceWeightInKg != _context.DeliveryDetail.WeightInKg))
                {
                    RegisterExtractionError(PreInvExtractionErrorTypes.PricedWeightMismatchedDeliveredWeight);
                    return false;
                }
            }

            //if processing Invoices or 'Misc Cdt or Dbt then if get the Vat Rec and Rate
            //then if there are Discount/Rebate records then get the rates.
            if ((_context.InvoiceTypeForAccount == PreInvInvoiceType.Invoice) || isMiscCreditDebit)
            {
                if (_systemPreferences.UserHasVat)
                {
                    DTOVatLink vatLink;
                    _context.VatRate = GetBestVat(extractParams, out vatLink);
                    if (_context.VatRate == null)
                    {
                        RegisterExtractionError(PreInvExtractionErrorTypes.UnableToGetVATDetails);
                        return false;
                    }
                    _context.VatLink = vatLink;
                    if (!_sharedProcessingHelpers.LookupGLCode(new DTOGLLookupParams
                            {
                                LookupType = PreInvGLLookupType.VAT,
                                SalesOfficeNo = extractParams.SalesOfficeNo,
                                VatRecId = vatLink.VatRateId
                            }, this)
                        )
                    {
                        return false;
                    }
                    if (_context.Account.IsTwoVatRatesCustomer)
                    {
                        if (!_sharedProcessingHelpers.LookupGLCode(new DTOGLLookupParams
                        {
                            LookupType = PreInvGLLookupType.VAT,
                            SalesOfficeNo = extractParams.SalesOfficeNo,
                            VatRecId = vatLink.VatRateId,
                            VatType = 2
                        }, this)
                            )
                        {
                            return false;
                        }
                    }
                }
                if (_systemPreferences.NeedsPriceListVatCheck)
                {
                    if (!CheckPriceListVat())
                    {
                        return false;
                    }
                }
                if (!DetectDiscountsRates())
                {
                    return false;
                }
            }

            _context.ProductAnalysisGroup = null;
            if (_systemPreferences.ProductAnalysisLevNo > 0)
            {
                var refValue = _context.Product.GetRefByLevel(_systemPreferences.ProductAnalysisLevNo);
                if (refValue.HasValue)
                {
                    int productAnalysisGroup;
                    if (_productAnalysisGroups.TryGetValue(refValue.Value, out productAnalysisGroup))
                    {
                        _context.ProductAnalysisGroup = productAnalysisGroup;
                    }
                }
            }

            if (!_sharedProcessingHelpers.LookupGLCode(new DTOGLLookupParams
            {
                LookupType = PreInvGLLookupType.Sales,
                SalesOfficeNo = extractParams.SalesOfficeNo,
                AccountGLType = _context.AccountHof.GLType,
                ProductAnalysisGroup = _context.ProductAnalysisGroup
            }, this)
                )
            {
                return false;
            }

            if (!CheckGlXRefs(extractParams))
            {
                return false;
            }

            return true;
        }

        private ValidateDeliveryPriceResult ValidateDeliveryPrice(DTOPreInvExtractParams extractParams, DTODeliveryPrice deliveryPrice)
        {
            const decimal priceTolerance = 0.005M;
            ValidateDeliveryPriceResult errorResult =
                _context.IsDeliveryGoodsOnConsignment
                    ? ValidateDeliveryPriceResult.InvalidContinueWithDelivery
                    : ValidateDeliveryPriceResult.InvalidSkipDelivery;

            var delPrice = _context.DeliveryPrice;
            if (!delPrice.DeliveryPriceStatus.HasValue || !_context.AllowedDeliveryPriceStatus.Contains(delPrice.DeliveryPriceStatus.Value))
            {
                return ValidateDeliveryPriceResult.InvalidContinueWithDelivery;
            }

            if (delPrice.Quantity == 0)
            {
                //Delivery has a zero quantity line item.
                RegisterExtractionError(PreInvExtractionErrorTypes.DeliveryZeroQuantity);
                return errorResult;
            }

            if (
                !(
                    delPrice.Quantity != 0 &&
                    (Math.Abs(delPrice.NettValue) >= priceTolerance || delPrice.FreeOfCharge)
                 )
               )
            {
                return ValidateDeliveryPriceResult.InvalidContinueWithDelivery;
            }


            if ((Math.Abs(delPrice.Price) < 0.0001M) && !delPrice.FreeOfCharge)
            {
                //; "Delivery has a zero price line item."
                RegisterExtractionError(PreInvExtractionErrorTypes.DeliveryZeroPiceItem);
                return errorResult;
            }
            var delDetail = _context.DeliveryDetail;
            if (delDetail.IsPricedByWeight && (Math.Abs(delPrice.PriceWeight) < priceTolerance))
            {
                //; "Delivery has a zero weight line item."
                RegisterExtractionError(PreInvExtractionErrorTypes.DeliveryZeroWeightItem);
                return errorResult;
            }
            if ((Math.Abs(delPrice.NettValue) < priceTolerance) && !delPrice.FreeOfCharge)
            {
                //; "Delivery has a zero value line item."
                RegisterExtractionError(PreInvExtractionErrorTypes.DeliveryZeroWeightItem);
                return errorResult;
            }
            if (delPrice.DeliveryToItemStockRecords.Count == 0)
            {
                //; "Delivery has an unallocated stock line item."
                RegisterExtractionError(PreInvExtractionErrorTypes.DeliveryUnallocatedStockItem);
                return errorResult;
            }
            if (
                    (delPrice.DeliveryPriceStatus.Value == DTODeliveryPriceStatus.CreditOnNormalDelivery) ||
                    (delPrice.DeliveryPriceStatus.Value == DTODeliveryPriceStatus.DebitOnNormalDelivery)
               ) //; must be 'Cdt' or 'Dbt'.
            {
                if (delPrice.DeliveryToItemStockRecords[0].CdsRefNo == 0)
                {
                    RegisterExtractionError(PreInvExtractionErrorTypes.AdjustmentUndefinedTypeItem);
                    return errorResult;
                }

                if (delPrice.CreditNoteOriginalDeliveryPrice == null)
                {
                    //; "Unable to locate the Credited Sales xRef record."
                    RegisterExtractionError(PreInvExtractionErrorTypes.UnableLocateCreditedSalesItem);
                    return errorResult;
                }

                if (delPrice.DeliveryDetailId != delPrice.CreditNoteOriginalDeliveryPrice.DeliveryDetailId)
                {
                    //; "Credited Sales item mismatch."
                    RegisterExtractionError(PreInvExtractionErrorTypes.CreditedSalesItemMismatch);
                    return errorResult;
                }
                if (_context.InvoiceTypeForAccount != PreInvInvoiceType.Invoice)
                {
                    if (!delPrice.CreditNoteOriginalDeliveryPrice.DeliveryPriceStatus.IsInvoiced()) //< 11
                    {
                        return errorResult;
                    }
                }

                if (_systemPreferences.CheckForNonReleasedCredits && deliveryPrice.HasRelatedCreditNotes)
                {
                    if (_context.Account.InvoiceType == DTOInvoiceType.PerOrderNettOfRelCredits)
                    {
                        return ValidateDeliveryPriceResult.InvalidContinueWithDelivery;
                    }
                    return errorResult;
                }
            }
            else
            {
                var creditNoteByItemStock = _context.DeliveryPrice.DeliveryToCreditNoteByItemStock;

                var qtyByItesto = new Dictionary<int, int>();
                var qtyCheck = new Dictionary<int, int>();
                if ((creditNoteByItemStock != null) && (creditNoteByItemStock.Count != 0))
                {
                    foreach (var itemStock in delPrice.DeliveryToItemStockRecords)
                    {
                        if (!qtyByItesto.ContainsKey(itemStock.ItemStockId))
                        {
                            qtyByItesto.Add(itemStock.ItemStockId, itemStock.Quantity);
                            qtyCheck.Add(itemStock.ItemStockId, 0);
                        }
                        else
                        {
                            qtyByItesto[itemStock.ItemStockId] = qtyByItesto[itemStock.ItemStockId] + itemStock.Quantity;
                        }
                    }

                    foreach (var itemCreditStock in creditNoteByItemStock)
                    {
                        if (
                                (itemCreditStock.DisCdsRefNo != itemCreditStock.CdsRefNo) ||
                                (!qtyCheck.ContainsKey(itemCreditStock.ItemStockRecNo))
                           )
                        {
                            RegisterExtractionError(PreInvExtractionErrorTypes.CreditDebitQuantitiesInvalid);
                            return errorResult;
                        }

                        if (
                                (Math.Abs(itemCreditStock.Quantity) > Math.Abs(qtyByItesto[itemCreditStock.ItemStockRecNo])) ||
                                (Math.Abs(itemCreditStock.ItemStockQuantity) > Math.Abs(qtyByItesto[itemCreditStock.ItemStockRecNo]))
                           )
                        {
                            if (!_systemPreferences.DebitsGreaterInPreinv)
                            {
                                RegisterExtractionError(PreInvExtractionErrorTypes.CreditDebitQuantitiesInvalid);
                                return errorResult;
                            }
                            if (itemCreditStock.Quantity < 0)
                            {
                                RegisterExtractionError(PreInvExtractionErrorTypes.CreditDebitQuantitiesInvalid);
                                return errorResult;
                            }
                        }
                        else
                        {
                            if (itemCreditStock.AdjustStock)
                            {
                                qtyCheck[itemCreditStock.ItemStockRecNo] = qtyCheck[itemCreditStock.ItemStockRecNo] +
                                                                           itemCreditStock.Quantity;
                            }
                        }
                    }
                }
                foreach (var item in qtyByItesto)
                {
                    if (!_systemPreferences.DebitsGreaterInPreinv || (qtyCheck[item.Key] < 0))
                    {
                        if (Math.Abs(qtyCheck[item.Key]) > Math.Abs(item.Value))
                        {
                            RegisterExtractionError(PreInvExtractionErrorTypes.CreditDebitQuantitiesInvalid);
                            return errorResult;
                        }
                    }
                }
            }

            if (delPrice.IsPriceAdjustment && delPrice.AdjustedBy.HasValue && delPrice.AdjustedBy > 1)
            {
                // TODO: initialize NuGrossWgt, NuTareWgt, NuNettWgt
            }

            return ValidateDeliveryPriceResult.Valid;
        }

        /*private void UpdateServiceCharge(DTODeliveryDetail deliveryDetail)
        {
            //It was clarified and agreed that this can be skipped.
            //            UnassignLib.unassignServChg(servChgToDo)
            //            servChgToDo.SchRecNoForType = tc["Deldet"].DelRecNo
            //            UnassignLib.unassignWizSysInfo(wizInfo)

            //            wizInfo.SalOffNo = CurSalOffAccs
            //            wizInfo.FormNo = FormNumber
            //            wizInfo.ActionType = ACT_INSSERVCHG_DELDET

            //            if not FinanceLib.ChangeServiceCharges(wizInfo, servChgToDo)
            //            then
            //               msgStop(Utilslib.GetTransMessage(182), wizInfo.ErrorMessage)
            //               {"Logic Error", strErrMsg}
            //               lContDelivLoop = false
            //            endIf
        }*/

        private bool GetInvoiceTotals(PreInvBatchType batchType, PreInvInvoiceType invoiceType, string accountCode, int orderId, int deliveryId, bool createIfNotExists)
        {
            string invoiceTypeCode = ((int)invoiceType).ToString();
            string invoiceKey = invoiceTypeCode + "D" + deliveryId.ToString();
            if (batchType == PreInvBatchType.PerOrder)
            {
                invoiceKey = invoiceTypeCode + "O" + orderId.ToString();
            }
            else
                if (batchType == PreInvBatchType.PerCustomer)
                {
                    invoiceKey = invoiceTypeCode + "C" + accountCode;
                }

            DTOInvTot result;
            if (_invoiceTotals.TryGetValue(invoiceKey, out result))
            {
                _context.InvoiceTotal = result;
                _context.InvoiceTotalBeforeLastDelivery = ObjectHandling.CloneDTO(result, true);
                return true;
            }

            result = new DTOInvTot();
            result.ExtractSessionID = _extractSessionID;
            result.MemStorageKey = invoiceKey;
            result.InvoiceType = invoiceType;
            _context.InvoiceTotal = result;
            _context.InvoiceTotalBeforeLastDelivery = null;

            return false;
        }

        private string TruncateProductDescription(string productDescription)
        {
            return productDescription.Left(50);
        }

        private string GetProductDescriptionTranslation(DTOProduct product)
        {
            if (_context.AccountHof.AccLanguage.HasValue)
            {
                var prodTranslationList = _prodTranslationRepository.GetData
                    (
                        new List<ISearchField>()
                        {
                            new SearchFieldGeneric<DTOProductTranslation, int>(i => i.Language)
                                .Apply(_context.AccountHof.AccLanguage.Value, FieldType.Integer)
                        },
                        CachingStrategy.GlobalCache
                    );
                var prodTranslation = prodTranslationList.FirstOrDefault(pt => pt.ProductNo == product.Id);
                if (prodTranslation != null)
                {
                    return prodTranslation.Description;
                }
            }
            return product.Description;
        }

        private decimal CalcStandardUnitMultiplier(DTOProduct product)
        {
            if (!product.Level1Ref.HasValue)
            {
                return 1.0M; // make StndUnit = qty
            }

            var prodStdUnit = _productStandardUnits[product.Level1Ref.Value].StandardUnit;
            if (prodStdUnit == -1)
            {
                return 1.0M; // make StndUnit = qty
            }

            return Math.Round(product.StandardBoxWeightInKg / prodStdUnit, 3, MidpointRounding.AwayFromZero);
        }

        private bool WriteDetail(DTOPreInvExtractParams extractParams)
        {
            bool allowOneLineCancel = _context.IsDeliveryGoodsOnConsignment;
            bool isMiscCreditDebit = IsMiscCreditDebit(_context.DeliveryHead);

            decimal
                vatRateGds1 = 0,
                vatRateGds2 = 0;
            int?
                vatRecNoGds = null,
                vatVeaRecNoGds = null,
                reqVatLnkRecNo = null;

            if (_systemPreferences.UserHasVat && (_context.VatRate != null) && (_context.VatLink != null))
            {
                vatRateGds1 = _context.VatRate.VatRate ?? 0;
                vatRecNoGds = _context.VatRate.Id;
                vatVeaRecNoGds = _context.VatLink.VatVeaId;
                vatRateGds2 = _context.VatRate.VatRate2 ?? 0;
                reqVatLnkRecNo = _context.VatLink.Id;
            }

            //if DelPrice is Credit or Debit and not Misc Cdt/Dbt then
            //use DelToIst Stk qty for discount and invoice qty total.
            int discToQty = _context.DeliveryPrice.Quantity ?? 0;

            if (
                    (_context.DeliveryPrice.DeliveryPriceStatus == DTODeliveryPriceStatus.CreditOnNormalDelivery) ||
                    (_context.DeliveryPrice.DeliveryPriceStatus == DTODeliveryPriceStatus.DebitOnNormalDelivery)
               )
            {
                if (_context.InvoiceTypeForAccount != PreInvInvoiceType.Invoice)
                {
                    allowOneLineCancel = true;
                }
                discToQty = _context.DeliveryPrice.DeliveryToItemStockRecords.Sum(item => item.StockQuantity ?? 0);
            }

            //if processing Credit or Debit Notes and not Misc Cdt/Dbt then use discount and
            //vat details from the original Delprice else use the vat details from lCheckdeldet().
            if ((_context.InvoiceTypeForAccount != PreInvInvoiceType.Invoice) && !isMiscCreditDebit)
            {
                _context.HasDiscountRates = false;
                _context.HasRebateRates = false;
                _context.DiscountRates.Clear();

                if (_context.DeliveryPrice.CreditNoteOriginalDeliveryPrice.ItemCharges != null)
                {
                    var origItemCharges = _context.DeliveryPrice.CreditNoteOriginalDeliveryPrice.ItemCharges.Where(z => z.CtyNo >= 96 && z.CtyNo <= 98).ToList();
                    foreach (var origItemCharge in origItemCharges)
                    {
                        if (!origItemCharge.IchDisType.HasValue || (origItemCharge.IchDiscTypRecord == null))
                        {
                            RegisterExtractionError(PreInvExtractionErrorTypes.UnableToLocateDeductionType);
                            return false;
                        }

                        var discountRecord =
                            new DiscountRecordItem
                                {
                                    Rate = origItemCharge.IchPcntOrRate,
                                    Type = origItemCharge.IchRealDisType,
                                    GLRecNo = origItemCharge.IchDiscTypRecord.DiscGrpGlRecNo,
                                    DedStr = origItemCharge.IchDiscTypRecord.DiscDedStr
                                };

                        _context.DiscountRates.Add(origItemCharge.IchDisType.Value, discountRecord);

                        if (discountRecord.IsDiscountRate)
                        {
                            _context.HasDiscountRates = true;
                        }
                        else
                        {
                            _context.HasRebateRates = true;
                        }
                    }
                }

                if (_systemPreferences.UserHasVat)
                {
                    var origDelPrice = _context.DeliveryPrice.CreditNoteOriginalDeliveryPrice;
                    vatVeaRecNoGds = null;
                    vatRecNoGds = origDelPrice.VatRecNo;
                    vatRateGds1 = origDelPrice.VatRate;
                    vatRateGds2 = _context.Account.IsTwoVatRatesCustomer ? origDelPrice.VatRate2 : 0;
                    reqVatLnkRecNo = null;
                    if (origDelPrice.AccVAT != null)
                    {
                        reqVatLnkRecNo = origDelPrice.AccVAT.VatLnkRecNo;
                    }
                    if (!origDelPrice.DelVatRate.HasValue) //"0" value does not generate ExtractionError in original code.
                    {
                        RegisterExtractionError(PreInvExtractionErrorTypes.BlankVATRate);
                        return false;
                    }
                    if (!_sharedProcessingHelpers.LookupGLCode(new DTOGLLookupParams
                    {
                        LookupType = PreInvGLLookupType.VAT,
                        SalesOfficeNo = extractParams.SalesOfficeNo,
                        VatRecId = vatRecNoGds
                    }, this)
                        )
                    {
                        return false;
                    }
                    if (_context.Account.IsTwoVatRatesCustomer)
                    {
                        if (!_sharedProcessingHelpers.LookupGLCode(new DTOGLLookupParams
                        {
                            LookupType = PreInvGLLookupType.VAT,
                            SalesOfficeNo = extractParams.SalesOfficeNo,
                            VatRecId = vatRecNoGds,
                            VatType = 2
                        }, this)
                            )
                        {
                            return false;
                        }
                    }
                }
                if (!CheckGlXRefs(extractParams))
                {
                    return false;
                }
            }

            int curNo = _context.DeliveryHead.CurrencyNo ?? SharedProcessingHelpers.CurrencyCodeBase;
            decimal nettValue = _context.DeliveryPrice.NettValue;
            decimal euroNettValue = _dictionaryService.ConvertCurrency(nettValue, curNo, DTOCurrency.EuroCurrencyNo, DTOCurrencyRate.SalesRateUseForCode);
            decimal baseNettValue = _dictionaryService.ConvertCurrency(nettValue, curNo, DTOCurrency.BaseCurrencyNo, DTOCurrencyRate.SalesRateUseForCode);

            decimal
                onInvDscnt = 0,
                euroOnInvDscnt = 0,
                baseOnInvDscnt = 0,
                offInvRbt = 0,
                euroOffInvRbt = 0,
                baseOffInvRbt = 0,
                offInvOnPay = 0,
                euroOffInvOnPay = 0,
                baseOffInvOnPay = 0;

            _incrementalExtractedRecNo++; //incremental count of records.

            if (_context.HasDiscountRates || _context.HasRebateRates)
            {
                var delPriceStatus = _context.DeliveryPrice.DeliveryPriceStatus;
                int nuDrCrMult = (delPriceStatus.HasValue && (delPriceStatus.Value == DTODeliveryPriceStatus.CreditOnNormalDelivery)) ? -1 : 1;
                decimal runningNetBalance = nettValue;
                foreach (var discountRateRecord in _context.DiscountRates)
                {
                    var discountRate = discountRateRecord.Value;

                    if (_context.DeliveryPrice.FreeOfCharge)
                    {
                        if (discountRate.IsDiscountRate)
                        {
                            //if this is a discount and we have a Free of Charge line then we do not do.
                            continue;
                        }
                        if (!_context.ApplyRebatesToFreeOfChargeGoods)
                        {
                            //if this is a Rebate and we have a Free of Charge line then we should only
                            //apply the rebate if the group is flagged to
                            //this does not apply when processing Credit or Debit Notes as they use original Delprice rebate details
                            if (_context.InvoiceTypeForAccount == PreInvInvoiceType.Invoice)
                            {
                                continue;
                            }
                        }
                    }

                    string[] toDoByAr;
                    if (
                            (!string.IsNullOrEmpty(discountRate.DedStr) && (discountRate.DedStr.Length > 1)) && //If string size is > 1 then must be compound.
                            (discountRate.Type.HasValue && (discountRate.Type.Value.GetMethod() == EnumDiscTypesMethod.Percentage)) //percentage allow multiple elements.
                       )
                    {
                        toDoByAr = discountRate.DedStr.Split(',');
                        toDoByAr[0] = discountRateRecord.Key.ToString();
                    }
                    else
                    {
                        //Only one element if a rate (due to the method of calcing)
                        //The First element is always this rate / Perc and must be deducted last
                        toDoByAr = new string[] { discountRateRecord.Key.ToString() };
                    }

                    decimal nuTmp = nettValue;
                    for (int i = 1; i < toDoByAr.Length; i++)
                    {
                        DiscountRecordItem doByArDiscRate;
                        if (!_context.DiscountRates.TryGetValue(int.Parse(toDoByAr[i]), out doByArDiscRate))
                        {
                            continue;
                        }

                        if (!doByArDiscRate.Type.HasValue)
                        {
                            continue;
                        }

                        if (doByArDiscRate.Type.Value.GetMethod() == EnumDiscTypesMethod.Ordinary)
                        {
                            nuTmp -= doByArDiscRate.Rate * discToQty;
                        }
                        else
                            if (doByArDiscRate.Type.Value.GetMethod() == EnumDiscTypesMethod.Percentage)
                            {
                                nuTmp -= (nuTmp * doByArDiscRate.Rate) / 100.0M;
                            }
                            else
                                if (doByArDiscRate.Type.Value.GetMethod() == EnumDiscTypesMethod.StandardUnitRate)
                                {
                                    var nuStdUnits = Math.Round(discToQty * CalcStandardUnitMultiplier(_context.Product), 2, MidpointRounding.AwayFromZero);
                                    nuTmp -= (doByArDiscRate.Rate * nuStdUnits);
                                }
                                else
                                {
                                    return false;
                                }
                        nuTmp = _dictionaryService.RoundCurrency(nuTmp, curNo);
                    }

                    var nuDiscountRate = discountRate.Rate;

                    if (discountRate.Type.HasValue)
                    {
                        if (discountRate.Type.Value.GetMethod() == EnumDiscTypesMethod.Ordinary)
                        {
                            nuTmp = nuDiscountRate * discToQty;
                            //If OnInvDiscount then check we don't give more discount than line value. rjs 22/02/2007.
                            if (discountRate.IsDiscountRate)
                            {
                                if (Math.Abs(runningNetBalance) - Math.Abs(nuTmp) < 0.0M)
                                {
                                    nuTmp = runningNetBalance; //Make discount = balance on delprice.
                                    nuDiscountRate = nuTmp / discToQty; //Make this rate correct for discount qty.
                                }
                                runningNetBalance -= nuTmp; //Update running balance.
                            }
                        }
                        else if (discountRate.Type.Value.GetMethod() == EnumDiscTypesMethod.Percentage)
                        {
                            nuTmp = (nuTmp * nuDiscountRate) / 100.0M;
                            //If OnInvDiscount then check we don't give more discount than line value. rjs 22/02/2007.
                            if (discountRate.IsDiscountRate)
                            {
                                if (nuTmp * nuDrCrMult < 0.0M)
                                {
                                    nuTmp = 0.0M;
                                }
                                runningNetBalance -= nuTmp; //Update running balance.
                            }
                        }
                        else if (discountRate.Type.Value.GetMethod() == EnumDiscTypesMethod.StandardUnitRate)
                        {
                            var nuStdUnits = Math.Round(discToQty * CalcStandardUnitMultiplier(_context.Product), 2,
                                                        MidpointRounding.AwayFromZero);
                            nuTmp = nuDiscountRate * nuStdUnits;
                            //If OnInvDiscount then check we don't give more discount than line value. rjs 22/02/2007.
                            if (discountRate.IsDiscountRate)
                            {
                                if (Math.Abs(runningNetBalance) - Math.Abs(nuTmp) < 0.0M)
                                {
                                    nuTmp = runningNetBalance; //Make discount = balance on delprice.
                                    nuDiscountRate = nuTmp / nuStdUnits; //Make this rate correct for discount qty.
                                }
                                runningNetBalance -= nuTmp; //Update running balance.
                            }
                        }
                        else
                        {
                            return false;
                        }
                    }
                    nuTmp = _dictionaryService.RoundCurrency(nuTmp, curNo);

                    if (Math.Abs(nuTmp) > 0.001M)
                    {
                        decimal euroNuTmp = _dictionaryService.ConvertCurrency(nuTmp, curNo, DTOCurrency.EuroCurrencyNo, DTOCurrencyRate.SalesRateUseForCode);
                        decimal baseNuTmp = _dictionaryService.ConvertCurrency(nuTmp, curNo, DTOCurrency.BaseCurrencyNo, DTOCurrencyRate.SalesRateUseForCode);

                        if (discountRate.IsDiscountRate)
                        {
                            onInvDscnt += nuTmp;
                            euroOnInvDscnt += euroNuTmp;
                            baseOnInvDscnt += baseNuTmp;
                        }
                        else
                            if (discountRate.IsOnPaymentRate)
                            {
                                offInvOnPay += nuTmp;
                                euroOffInvOnPay += euroNuTmp;
                                baseOffInvOnPay += baseNuTmp;
                            }
                            else
                            {
                                offInvRbt += nuTmp;
                                euroOffInvRbt += euroNuTmp;
                                baseOffInvRbt += baseNuTmp;
                            }

                        _currentInvoiceDiscTypItems.Add
                        (
                            new DTOInvDiscTyp
                                {
                                    ExtractSessionID = _extractSessionID,
                                    DlvInvoiceNo = _context.InvoiceTotal.InvoiceNo,
                                    RecNo = _incrementalExtractedRecNo,
                                    DiscSeqNo = discountRateRecord.Key, //Is the Sequence no
                                    DiscTyp = discountRate.Type,
                                    DiscRate = nuDiscountRate,
                                    DiscDetrStr = discountRate.DedStr,
                                    DiscBaseAmt = baseNuTmp,
                                    DiscLoclAmt = nuTmp,
                                    DiscEuroAmt = euroNuTmp,
                                    DiscGlRecNo = discountRate.GLRecNo,
                                }
                        );
                    }
                }
            }

            //add this Delprice values to the Invoice Totals.
            _context.InvoiceTotal.QtyTotal += discToQty;
            _context.InvoiceTotal.GoodsTotal += nettValue;
            _context.InvoiceTotal.OnInvDscnt += onInvDscnt;
            _context.InvoiceTotal.OffInvRbt += offInvRbt;
            _context.InvoiceTotal.OffInvOnPay += offInvOnPay;
            //_context.InvoiceTotal.RawVatOnChgs += 0; //Seems to be always 0 in previous code

            _context.InvoiceTotal.EuroGdsTotal += euroNettValue;
            _context.InvoiceTotal.EuroOnInvDscnt += euroOnInvDscnt;
            _context.InvoiceTotal.EuroOffInvRbt += euroOffInvRbt;
            _context.InvoiceTotal.EuroOffInvOnPay += euroOffInvOnPay;
            //_context.InvoiceTotal.EuroVatOnChgs += 0; //Seems to be always 0 in previous code

            _context.InvoiceTotal.BaseGdsTotal += baseNettValue;
            _context.InvoiceTotal.BaseOnInvDscnt += baseOnInvDscnt;
            _context.InvoiceTotal.BaseOffInvRbt += baseOffInvRbt;
            _context.InvoiceTotal.BaseOffInvOnPay += baseOffInvOnPay;
            //_context.InvoiceTotal.BaseVatOnChgs += 0; //Seems to be always 0 in previous code

            decimal
                vatExt = 0,
                euroVatExt = 0,
                baseVatExt = 0,
                vatExt2 = 0,
                euroVatExt2 = 0,
                baseVatExt2 = 0;

            if (_systemPreferences.UserHasVat)
            {
                vatExt = _dictionaryService.RoundCurrency(vatRateGds1 * (nettValue - onInvDscnt) / 100, curNo);
                euroVatExt = _dictionaryService.RoundCurrency(vatRateGds1 * (euroNettValue - euroOnInvDscnt) / 100, DTOCurrency.EuroCurrencyNo);
                baseVatExt = _dictionaryService.RoundCurrency(vatRateGds1 * (baseNettValue - baseOnInvDscnt) / 100, DTOCurrency.BaseCurrencyNo);



                _context.InvoiceTotal.VatTotal += vatExt;
                _context.InvoiceTotal.EuroVatTotal += euroVatExt;
                _context.InvoiceTotal.BaseVatTotal += baseVatExt;

                _context.InvoiceTotal.Vat1Total += vatExt;
                _context.InvoiceTotal.EuroVat1Total += euroVatExt;
                _context.InvoiceTotal.BaseVat1Total += baseVatExt;

                if (vatRecNoGds.HasValue)
                {
                    DTOInvTotVatInfo vatInfo;
                    if (!_context.InvoiceTotal.VatInfo.TryGetValue(vatRecNoGds.Value, out vatInfo))
                    {
                        vatInfo =
                            new DTOInvTotVatInfo
                                {
                                    Cde = vatRecNoGds.Value,
                                    Rte = vatRateGds1,
                                    Rte2 = vatRateGds2,
                                    AvaVeaRec = vatVeaRecNoGds,
                                    VatLnkRecNo = reqVatLnkRecNo
                                };
                        _context.InvoiceTotal.VatInfo.Add(vatInfo.Cde, vatInfo);
                    }
                    else
                    {
                        if (vatInfo.AvaVeaRec != vatVeaRecNoGds)
                        {
                            RegisterExtractionError(PreInvExtractionErrorTypes.MoreThanOneVatExemptRecordForTheSameVatRecord);
                        }
                    }
                    vatInfo.Vat += vatExt;
                    vatInfo.EuroVat += euroVatExt;
                    vatInfo.BaseVat += baseVatExt;
                    vatInfo.Gds += nettValue - onInvDscnt;
                    vatInfo.EuroGds += euroNettValue - euroOnInvDscnt;
                    vatInfo.BaseGds += baseNettValue - baseOnInvDscnt;

                    if (_context.Account.IsTwoVatRatesCustomer && (vatRateGds2 > 0))
                    {
                        //PreInvExtractionErrorTypes.SecondVatRatePresentWithNoFirstVatRate present in original code, 
                        //seems to be impossible here as it was just inserted/updated.

                        if (_context.Account.IsApplyCompaundVatSale)
                        {
                            vatExt2 = vatRateGds2 * (nettValue - onInvDscnt + vatExt) / 100;
                            euroVatExt2 = vatRateGds2 * (euroNettValue - euroOnInvDscnt + euroVatExt) / 100;
                            baseVatExt2 = vatRateGds2 * (baseNettValue - baseOnInvDscnt + baseVatExt) / 100;
                        }
                        else
                        {
                            vatExt2 = vatRateGds2 * (nettValue - onInvDscnt) / 100;
                            euroVatExt2 = vatRateGds2 * (euroNettValue - euroOnInvDscnt) / 100;
                            baseVatExt2 = vatRateGds2 * (baseNettValue - baseOnInvDscnt) / 100;
                        }

                        vatExt2 = _dictionaryService.RoundCurrency(vatExt2, curNo);
                        euroVatExt2 = _dictionaryService.RoundCurrency(euroVatExt2, DTOCurrency.EuroCurrencyNo);
                        baseVatExt2 = _dictionaryService.RoundCurrency(baseVatExt2, DTOCurrency.BaseCurrencyNo);

                        _context.InvoiceTotal.VatTotal += vatExt2;
                        _context.InvoiceTotal.EuroVatTotal += euroVatExt2;
                        _context.InvoiceTotal.BaseVatTotal += baseVatExt2;

                        _context.InvoiceTotal.Vat2Total += vatExt2;
                        _context.InvoiceTotal.EuroVat2Total += euroVatExt2;
                        _context.InvoiceTotal.BaseVat2Total += baseVatExt2;

                        vatInfo.Vat2 += vatExt2;
                        vatInfo.EuroVat2 += euroVatExt2;
                        vatInfo.BaseVat2 += baseVatExt2;
                    }
                }
            }

            var productDesc = GetProductDescriptionTranslation(_context.Product);
            DTOCustomerProductInfo customerProductInfo = null;

            if (_context.RequiredPriceGroupNo > 0)
            {
                if (!string.IsNullOrEmpty(_context.DeliveryDetail.ClientProductNo))
                {

                    if ((_context.DeliveryDetail.CustomerProductInfos != null) && (_context.DeliveryDetail.CustomerProductInfos.Count > 0))
                    {
                        customerProductInfo =
                            _context.DeliveryDetail.CustomerProductInfos.FirstOrDefault(i => (i.ClientProductNo == _context.DeliveryDetail.ClientProductNo) && (i.GroupNo == _context.RequiredPriceGroupNo));
                    }

                    if (customerProductInfo == null)
                    {
                        //TODO: Place audit message that "Either the customer has been moved to a different price group or the client product has been removed from the price group."
                        return false;
                    }

                    if (!string.IsNullOrEmpty(customerProductInfo.ProductDescription))
                    {
                        productDesc = customerProductInfo.ProductDescription;
                    }
                }
                else
                {
                    if (_context.IsEdiCustomer && string.IsNullOrEmpty(_context.DeliveryDetail.ClientProductNo))
                    {
                        //TODO: Place audit message that "Missing Client Product No. for Product No...."
                        return false;
                    }
                }
            }
            productDesc = TruncateProductDescription(productDesc);
            var allocNo = _context.DeliveryDetail.ClientAllocationNo;
            var tmpReservation = _context.DeliveryDetail.ProgramReferenceNo;
            var qty = _context.DeliveryDetail.IsPricedByWeight
                          ? _context.DeliveryPrice.PriceWeight
                          : _context.DeliveryPrice.Quantity ?? 0;

            var nuDelPrice = _context.DeliveryPrice.Price;

            int? qtyDlvd = null;
            if (_context.DeliveryDetail.QuantityPer > 1)
            {
                if (
                        (_context.DeliveryDetail.QuantityPer >= 3) &&
                        (_context.DeliveryDetail.PricePer == 2)
                   )
                {
                    int qtyFromWeight;
                    if (IntegerHandling.TryConvertToInt32(_context.DeliveryPrice.PriceWeight, out qtyFromWeight))
                    {
                        qtyDlvd = qtyFromWeight;
                    }
                }
            }
            else
            {
                //If by weight then show the equivalent box price as only allows integers.
                if (!_context.DeliveryPrice.Quantity.HasValue || (_context.DeliveryPrice.Quantity < 0.001))
                {
                    nuDelPrice = 0;
                }
                else
                {
                    nuDelPrice = nettValue / _context.DeliveryPrice.Quantity.Value;
                }
            }

            if (!qtyDlvd.HasValue)
            {
                qtyDlvd = _context.DeliveryPrice.Quantity;
            }

            string perQtyStr = GetPerQtyStr(_context.DeliveryDetail.PricePer);
            if (
                    _context.DeliveryPrice.IsPriceAdjustment &&
                    (_context.DeliveryDetail.PricePer != _context.DeliveryPrice.AdjustedBy)
               )
            {
                perQtyStr = GetPerQtyStr(_context.DeliveryPrice.AdjustedBy);
            }

            //TV 12Dec11 BSDL 6397 Need an overall line discount %age for EDI
            //so have to recalculate it since there are potentially more than one
            decimal nuTempPercent = 0.0M;
            if (_context.DeliveryPrice.NettValue != 0)
            {
                nuTempPercent = (onInvDscnt / _context.DeliveryPrice.NettValue) * 100;
                nuTempPercent = decimal.Round(nuTempPercent, 2, MidpointRounding.AwayFromZero);
            }

            int? disCdsRefNo = null;
            if (_context.DeliveryPrice.DeliveryToItemStockRecords != null)
            {
                //TODO: Weird logic in original code, need to clarify with how it should be later
                //It uses just a single(current) delToIst to assign it later to invPrt2.DelCdsRefNo
                DTODeliveryToItemStock delToIst = _context.DeliveryPrice.DeliveryToItemStockRecords.FirstOrDefault();
                if (delToIst != null)
                {
                    disCdsRefNo = delToIst.CdsRefNo;
                }
            }

            var invPrt2 = new DTOInvPrt2();
            invPrt2.ExtractSessionID = _extractSessionID;
            invPrt2.InvoiceNo = _context.InvoiceTotal.InvoiceNo;
            invPrt2.Recno = _incrementalExtractedRecNo;
            invPrt2.DlvOrdNo = _context.DeliveryHead.Id;
            invPrt2.DelRecNo = _context.DeliveryDetail.Id;

            if (customerProductInfo != null)
            {
                invPrt2.PpcNo = customerProductInfo.Id;
                invPrt2.TradedUnit = customerProductInfo.TradedUnit;
                invPrt2.UnitCount = customerProductInfo.UnitCount;
            }
            invPrt2.DelQty = qtyDlvd;
            invPrt2.DelWeight = _context.DeliveryPrice.PriceWeight;
            invPrt2.DelPrice = _context.DeliveryPrice.Price;
            invPrt2.Goods = nettValue;
            invPrt2.Ext = nettValue + vatExt + vatExt2 - onInvDscnt;
            invPrt2.OnInvDscnt = onInvDscnt;

            //TV 12Dec11 BSDL 6397
            invPrt2.OnInvDisPcnt = nuTempPercent;

            invPrt2.OffInvRbt = offInvRbt;
            invPrt2.OffInvOnPay = offInvOnPay;
            invPrt2.DprRecNo = _context.DeliveryPrice.Id;
            invPrt2.DelCdsRefNo = disCdsRefNo;
            invPrt2.EuroGds = euroNettValue;
            invPrt2.EuroOnInvDscnt = euroOnInvDscnt;
            invPrt2.EuroOffInvRbt = euroOffInvRbt;
            invPrt2.EuroOffOnPay = euroOffInvOnPay;
            invPrt2.BaseGds = baseNettValue;
            invPrt2.BaseOnInvDscnt = baseOnInvDscnt;
            invPrt2.BaseOffInvRbt = baseOffInvRbt;
            invPrt2.BaseOffOnPay = baseOffInvOnPay;
            if (_context.DeliveryPrice.CreditNoteOriginalDeliveryPrice != null)
            {
                invPrt2.AllocToInvRecNo = _context.DeliveryPrice.CreditNoteOriginalDeliveryPrice.InvoiceId;
            }
            invPrt2.DetAllocNo = allocNo;
            invPrt2.PrcPrdRef = _context.Product.ProductRef;
            invPrt2.PrdRecDesc = _context.Product.Description;
            invPrt2.PrgRefNo = tmpReservation;
            invPrt2.PrdGlAnl = _context.ProductAnalysisGroup;
            invPrt2.DelPrcPrdNo = _context.DeliveryDetail.ProductId;
            invPrt2.DelCltPrdNo = _context.DeliveryDetail.ClientProductNo;
            invPrt2.PrtQty = qty;
            invPrt2.PrdDesc = productDesc;
            invPrt2.DelPrcByWgt = _context.DeliveryDetail.IsPricedByWeight;
            invPrt2.DelInvStatus = _context.DeliveryPrice.DeliveryPriceStatus;
            invPrt2.AllowOneLineCancel = allowOneLineCancel;
            invPrt2.CancelledLine = false;
            invPrt2.UnitMeasure = perQtyStr;
            invPrt2.DiscToQty = discToQty;

            if (_systemPreferences.UserHasVat)
            {
                invPrt2.VatVatRate = vatRateGds1;
                invPrt2.VatRecNo = vatRecNoGds;
                invPrt2.VatVeaRecNo = vatVeaRecNoGds;
                invPrt2.Vat = vatExt + vatExt2;
                invPrt2.EuroVat = euroVatExt + euroVatExt2;
                invPrt2.BaseVat = baseVatExt + baseVatExt2;
                invPrt2.VatLnkRecNo = reqVatLnkRecNo;
                invPrt2.Vat1Total = vatExt;
                invPrt2.EuroVat1Total = euroVatExt;
                invPrt2.BaseVat1Total = baseVatExt;

                if (_context.Account.IsTwoVatRatesCustomer && (vatRateGds2 > 0))
                {
                    invPrt2.VatVatRate2 = vatRateGds2;
                    invPrt2.Vat2Total = vatExt2;
                    invPrt2.EuroVat2Total = euroVatExt2;
                    invPrt2.BaseVat2Total = baseVatExt2;
                }
            }

            // TODO: initialize NuGrossWgt, NuTareWgt, NuNettWgt
            decimal
                nuGrossWgt = 0,
                nuTareWgt = 0,
                nuNettWgt = 0;

            invPrt2.GrossWgt = nuGrossWgt;
            invPrt2.TareWgt = nuTareWgt;
            invPrt2.NettWgt = nuNettWgt;

            _currentDeliveryInvoicePart2Items.Add(invPrt2);
            return true;
        }

        private void GetDeliverySortKeys(out string sortKey1, out string sortKey2, out string sortKey3)
        {
            const string sortKeySalesPerson = "SALESPERSON";
            const string sortKeyHeadOffice = "HEAD OFFICE";
            const string sortKeyCustomer = "CUSTOMER";

            const string sortStrUnassigned = "UNASSIGNED";
            const string sortStrAllOthers = "All Others";

            sortKey1 = string.Empty;
            sortKey2 = string.Empty;
            sortKey3 = string.Empty;

            if (_systemPreferences.PreInvSortKey1 == sortKeySalesPerson)
            {
                DTOSalesPerson salesPerson = null;
                if (_context.Order.SalesPerson != null)
                {
                    salesPerson = _salesPersonRepository.GetData(null, CachingStrategy.GlobalCache).FirstOrDefault(i => i.No == _context.Order.SalesPerson);
                }
                sortKey1 = salesPerson != null ? salesPerson.Name : sortStrUnassigned;
            }
            else
                if (_systemPreferences.PreInvSortKey1 == sortKeyHeadOffice)
                {
                    sortKey1 =
                        _headOfficesForAccounts.ContainsKey(_context.AccountClass.Id)
                            ? _context.AccountHof.Name.Left(30)
                            : sortStrAllOthers;
                }

            sortKey2 =
                _systemPreferences.PreInvSortKey2 == sortKeyCustomer
                    ? _context.Account.Code
                    : _context.InvoiceTotal.InvoiceNo.PadLeft(8, '0');

            if (_systemPreferences.InvPrtSortKey1 == sortKeySalesPerson)
            {
                DTOSalesPerson salesPerson = null;
                if (_context.Order.SalesPerson != null)
                {
                    salesPerson = _salesPersonRepository.GetData(null, CachingStrategy.GlobalCache).FirstOrDefault(i => i.No == _context.Order.SalesPerson);
                }
                sortKey3 = salesPerson != null ? salesPerson.Name : sortStrUnassigned;
            }
            else
                if (_systemPreferences.InvPrtSortKey1 == sortKeyCustomer)
                {
                    sortKey3 = _context.Account.Code;
                }
                else
                    if (_systemPreferences.InvPrtSortKey1 == sortKeyHeadOffice)
                    {
                        sortKey3 = _context.HofLocalAccountCode.PadRight(8, ' ') + _context.Order.AccountClassId.ToString();
                    }
        }

        private void WriteDeliveryInformation(DTOPreInvExtractParams extractParams)
        {
            string sortStr1, sortStr2, sortStr3;
            GetDeliverySortKeys(out sortStr1, out sortStr2, out sortStr3);

            int curNo = _context.DeliveryHead.CurrencyNo ?? DTOCurrency.BaseCurrencyNo;
            var currency = _currencyDictionaryRepository.GetData(null, CachingStrategy.GlobalCache).First(i => i.No == curNo);

            bool newInvTotal = string.IsNullOrEmpty(_context.InvoiceTotal.Sort1); //If InvoiceTotal is not yet fully initialized. For now we use this as indicatior.
            if (newInvTotal)
            {
                decimal baseRate = 0;
                decimal euroRate = 0;
                if (curNo == DTOCurrency.BaseCurrencyNo)
                {
                    euroRate = _currencyRateRepository.GetRateFromBase(DTOCurrency.EuroCurrencyNo, DTOCurrencyRate.SalesRateUseForCode);
                    baseRate = 1.0m;
                }
                else
                {
                    var currencyRate = _currencyRateRepository.GetRateByCurrencyNo(curNo, DTOCurrencyRate.SalesRateUseForCode);
                    euroRate = currencyRate.RateToEuro;
                    baseRate = currency.IsTriangulate
                        ? _currencyRateRepository.GetRateToBase(DTOCurrency.EuroCurrencyNo, DTOCurrencyRate.SalesRateUseForCode)
                        : currencyRate.RateToBase;
                }

                _context.InvoiceTotal.CurDesc = currency.Description;
                _context.InvoiceTotal.Sort1 = sortStr1;
                _context.InvoiceTotal.Sort2 = sortStr2;
                //_context.InvoiceTotal.InvoiceNo already set
                _context.InvoiceTotal.Sort3 = sortStr3;
                _context.InvoiceTotal.HofCstCode = _context.HofLocalAccountCode;
                _context.InvoiceTotal.PrcGlbRecNo = extractParams.CompanyNo;
                //_context.InvoiceTotal.InvDate already set
                _context.InvoiceTotal.CurNo = curNo;
                _context.InvoiceTotal.EuroRate = euroRate;
                _context.InvoiceTotal.BaseRate = baseRate;
                _context.InvoiceTotal.TriangReq = currency.IsTriangulate;
                _context.InvoiceTotal.HofClaRecNo = _context.AccountClassHof.Id;
                _context.InvoiceTotal.VatCodeChgs = 0; //Seems to be unused value from old code analysis
                _context.InvoiceTotal.VatRateChgs = 0; //Seems to be unused value from old code analysis
                _context.InvoiceTotal.AccntSalOffNo =
                    DTOSalesOffice.GetUnsignedSalesOfficeNumber(extractParams.SalesOfficeNo);
                _context.InvoiceTotal.WriteAccReChg = false; //Assume that repack fee is not logner needed.
                _context.InvoiceTotal.AccGlAnl = _context.AccountHof.GLType;
                _context.InvoiceTotal.IsEdiCst = _context.IsEdiCustomer;
                //_context.InvoiceTotal.IsSeqInvNo already set
                _context.InvoiceTotal.CompanyName =
                    _companyDictionaryRepository.GetData(null, CachingStrategy.GlobalCache).First(i => i.No == extractParams.CompanyNo).Name;
                _context.InvoiceTotal.CancelledInv = false;
                _context.InvoiceTotal.TwoVatRatesCust = _context.Account.IsTwoVatRatesCustomer;
                _context.InvoiceTotal.CompoundVatCust = _context.Account.IsApplyCompaundVatSale;
                _context.InvoiceTotal.BatchType = _invoiceTypeToBatchTypeMapping[_context.Account.InvoiceType];

                if (_context.DeliveryHead.IsInterDepartment)
                {
                    _context.InvoiceTotal.IsInterDept = true;
                }
            }

            string salesOfficeDesc = "Not available";
            int salesOfficeNo = _context.DeliveryHead.InvoiceSalesOfficeNo ?? 0;
            if (salesOfficeNo == 0)
            {
                salesOfficeNo = _context.DeliveryHead.DeliverySalesOfficeNo ?? 0;
            }
            if (salesOfficeNo != 0)
            {
                var salesOffice = _salesOfficeRepository.GetData(null, CachingStrategy.GlobalCache).FirstOrDefault(i => i.SalesOfficeNumber == salesOfficeNo);
                if (salesOffice != null)
                {
                    salesOfficeDesc = string.Format("{0}-{1}", salesOffice.SalesOfficeCode, salesOffice.SalesOfficeDescription);
                }
            }

            var invPrt = new DTOInvPrt();
            invPrt.ExtractSessionID = _extractSessionID;
            invPrt.DlvInvoiceNo = _context.InvoiceTotal.InvoiceNo;
            invPrt.DlvOrdNo = _context.DeliveryHead.Id;
            invPrt.DlvShpDate = _context.DeliveryHead.ShipDate;
            invPrt.DlvDelDate = _context.DeliveryHead.DeliveryDate;
            invPrt.DlvPODNo = _context.DeliveryHead.PoDNo;
            invPrt.OrdRecNo = _context.Order.Id;
            invPrt.OrdCstCode = _context.LocalAccountCode;
            invPrt.OrdCustOrdNo = _context.Order.CustomerOrderNo;
            invPrt.OrdDate = _context.Order.OrderDate;
            invPrt.OrdSmnNo = _context.Order.SalesPerson;
            invPrt.HofCstCode = _context.HofLocalAccountCode;
            invPrt.InvoiceType = _context.Account.InvoiceType;
            invPrt.PrcGlbRecNo = extractParams.CompanyNo;
            invPrt.IsEdiPrg = false; //TODO: THis is for now, change this when appropriate part is implemented (lIsEdiPrgDlv).
            invPrt.CurDesc = currency.Description;
            invPrt.Sort1 = sortStr1;
            invPrt.Sort2 = sortStr2;
            invPrt.InvDate = _context.InvoiceTotal.InvDate;
            invPrt.HofClaRecNo = _context.AccountClassHof.Id;
            invPrt.DelClaRecNo = _context.Order.AccountClassId;
            invPrt.DltRecNo = _context.DeliveryHead.DeliveryTypeId;
            invPrt.DlvPrgHedNo = _context.DeliveryHead.ProgrammeHeadId;
            invPrt.CancelledDlv = false;
            invPrt.DlvSalOffNo = salesOfficeNo;
            invPrt.SalOffDesc = salesOfficeDesc;

            _extractResult.InvoicePartItems.Add(invPrt);

            _context.InvoiceTotal.InvoiceTotal = _context.InvoiceTotal.GoodsTotal + _context.InvoiceTotal.VatTotal - _context.InvoiceTotal.OnInvDscnt;
            if (newInvTotal)
            {
                _invoiceTotals.Add(_context.InvoiceTotal.MemStorageKey, _context.InvoiceTotal);
            }

            /* Following seems to be required for EDI only so it is skipped for now.
                 LGetFinaccDets(dyVatLnkRecNo[arInvRte[1]], tc["Delhed"].DlvOrdNo, FinFiscRep, FinVATNumber, FinVATDesc)
                _invoiceTotals.FinFiscRep1   = FinFiscRep
                _invoiceTotals.FinVATNumber1 = FinVATNumber
                _invoiceTotals.FinVATDesc1   = FinVATDesc
            */

            if (_context.BatchTypeForAccount != PreInvBatchType.PerDelivery)
            {
                if (newInvTotal)
                {
                    _nextInvoiceNo++;
                }
            }
            else
            {
                if (
                        _context.IsDeliveryGoodsOnConsignment ||
                        IsSequentialInvoiceNos(_context.InvoiceTypeForAccount, _context.SalesOffice) ||
                        _context.DeliveryHead.IsOpenPriceDelivery
                   )
                {
                    _nextInvoiceNo++;
                }
            }
        }

        private bool CheckIfSkipedDeliveryEscalatesToScipedOrder(PreInvInvoiceType invoiceType)
        {
            return
                ((invoiceType & PreInvInvoiceType.Invoice) != 0) && //TODO: Consider how to change this
                (_context.DeliveryHead.DeliveryStatus != DTODeliveryStatus.Invoiced) && //Not LisInvd
                (new[]
                     {
                         DTOInvoiceType.PerDeliveryGrossNoSplit,
                         DTOInvoiceType.PerDeliveryNettNoSplit,
                         DTOInvoiceType.CombinedDeliveriesGross,
                         DTOInvoiceType.CombinedDeliveriesNett,
                         DTOInvoiceType.PerOrderNettOfRelCredits
                     }.Contains(_context.Account.InvoiceType)
                );
        }

        private void UndoDeliveryChanges()
        {
            if (_context.InvoiceTotalBeforeLastDelivery != null)
            {
                _invoiceTotals[_context.InvoiceTotal.MemStorageKey] = _context.InvoiceTotalBeforeLastDelivery;
            }

            //There is no need to revert _context.NextInvoiceNo as it is incremented in WriteDeliveryInformation and it will not be called if delivery is not OK

            //Just to make sure nowbody else uses modified object after Undo - cleaning references.
            _context.InvoiceTotal = null;
            _context.InvoiceTotalBeforeLastDelivery = null;
        }

        private void ProcessAccountOrders(DTOPreInvExtractParams extractParams, int accountClassId)
        {
            var orders = _localCache.Get<DTOOrder>(accountClassId);
            if (orders.Count == 0)
            {
                return;
            }
            orders = orders.OrderBy(i => i.CustomerOrderNo).ThenBy(i => i.Id).ToList();

            InitializeAccountExecutionContext(extractParams.SalesOfficeNo, accountClassId);
            try
            {
                var possibleInvoiceTypes = _accountPossibleInvoiceTypes[accountClassId].GetAsListOfSimpleValues();
                foreach (var possibleInvoiceType in possibleInvoiceTypes)
                {
                    _context.InvoiceTypeForAccount = possibleInvoiceType;
                    InitializeInvoiceTypeSpecificAccountExecutionContext(possibleInvoiceType, accountClassId);

                    foreach (var order in orders)
                    {
                        _context.Order = order;
                        /*if (
                                (possibleInvoiceType == PreInvInvoiceType.Invoice) //&&
                                //(_ordersToSkipForInvoiceRun.Contains(order.Id))
                           )
                        {
                            continue; //skipping the order - ititial validation marked whole order as not valid
                        }*/


                        foreach (var delivery in order.Deliveries)
                        {
                            bool deliveryProcessingOK = true;
                            bool atLeastOneDeliveryDetailWritten = false;
                            _context.DeliveryHead = delivery;
                            _context.IsDeliveryGoodsOnConsignment = false;

                            _currentDeliveryInvoicePart2Items.Clear();
                            _currentInvoiceDiscTypItems.Clear();

                            PreInvInvoiceType allowedInvoiceTypes;
                            if (!IsAllowedInvoiceTypesForDeliveryHead(delivery.TranInd, _context.InvoiceTypeForAccount, out allowedInvoiceTypes))
                            {
                                deliveryProcessingOK = false;
                            }

                            if (deliveryProcessingOK)
                            {
                                if (delivery.DeliveryTypeId.HasValue)
                                {
                                    _context.IsDeliveryGoodsOnConsignment =
                                        _deliveryTypeRepository.GetData(null, CachingStrategy.GlobalCache).First(
                                            i => i.Id == delivery.DeliveryTypeId).GoodsOnConsignment;
                                }
                                if ((delivery.Details == null) || (delivery.Details.Count == 0))
                                {
                                    RegisterExtractionError(PreInvExtractionErrorTypes.DeliveryDetailsIsEmpty);
                                    continue;
                                }
                                InitializeInvoiceTotals(extractParams);

                                foreach (var deliveryDetail in delivery.Details)
                                {
                                    _context.DeliveryDetail = deliveryDetail;
                                    if (deliveryDetail.Quantity == 0)
                                    {
                                        continue;
                                    }
                                    if (deliveryDetail.DeliveryStatus != DTODeliveryStatus.Released)
                                    {
                                        if (
                                            !(
                                                 ((deliveryDetail.DeliveryStatus == DTODeliveryStatus.Picked) ||
                                                  (deliveryDetail.DeliveryStatus == DTODeliveryStatus.Delivered)) &&
                                                 (delivery.DeliveryStatus == DTODeliveryStatus.Released)
                                             )
                                            )
                                        {
                                            continue;
                                        }
                                    }

                                    _context.Product =
                                        _productRepository.GetData(null, CachingStrategy.GlobalCache).FirstOrDefault(
                                            i => i.Id == deliveryDetail.ProductId); //TODO: Validate caching strategy
                                    if (_context.Product == null)
                                    {
                                        RegisterExtractionError(
                                            PreInvExtractionErrorTypes.DeliveryDetailReffersToInvalidProduct);
                                        deliveryProcessingOK = false;
                                        break;
                                    }

                                    bool hasDelPrice;
                                    if (!ValidateDeliveryDetail(extractParams, deliveryDetail, out hasDelPrice))
                                    {
                                        deliveryProcessingOK = false;
                                        break;
                                    }
                                    if (deliveryProcessingOK)
                                    {
                                        //UpdateServiceCharge(deliveryDetail);
                                        if (hasDelPrice)
                                        {
                                            foreach (var deliveryPrice in deliveryDetail.Prices)
                                            {
                                                _context.DeliveryPrice = deliveryPrice;
                                                var delPriceValidationResult = ValidateDeliveryPrice(extractParams,
                                                                                                     deliveryPrice);
                                                if (delPriceValidationResult == ValidateDeliveryPriceResult.Valid)
                                                {
                                                    if (WriteDetail(extractParams))
                                                    {
                                                        atLeastOneDeliveryDetailWritten = true;
                                                    }
                                                    else
                                                    {
                                                        if (_context.InvoiceTypeForAccount == PreInvInvoiceType.Invoice)
                                                        {
                                                            throw new AbortEntireProcessing();
                                                        }
                                                        deliveryProcessingOK = false;
                                                        break;
                                                    }
                                                }
                                                if (delPriceValidationResult ==
                                                    ValidateDeliveryPriceResult.InvalidSkipDelivery)
                                                {
                                                    deliveryProcessingOK = false;
                                                    break;
                                                }
                                            }
                                            _context.DeliveryPrice = null;
                                            _context.Product = null;
                                            _context.ProductAnalysisGroup = null;
                                            _context.VatLink = null;
                                            _context.VatRate = null;
                                        }
                                    }
                                    if (!deliveryProcessingOK)
                                    {
                                        break;
                                    }
                                }
                            }
                            _context.DeliveryDetail = null;
                            _context.DiscountRates.Clear();
                            if (!atLeastOneDeliveryDetailWritten)
                            {
                                deliveryProcessingOK = false;
                            }


                            if (deliveryProcessingOK)
                            {
                                if (_currentDeliveryInvoicePart2Items.Count > 0)
                                {
                                    _extractResult.InvoicePart2Items.AddRange(_currentDeliveryInvoicePart2Items);
                                }
                                if (_currentInvoiceDiscTypItems.Count > 0)
                                {
                                    _extractResult.InvoiceDiscTypItems.AddRange(_currentInvoiceDiscTypItems);
                                }
                                _currentDeliveryInvoicePart2Items.Clear();
                                _currentInvoiceDiscTypItems.Clear();
                                WriteDeliveryInformation(extractParams);
                            }
                            else
                            {
                                _currentDeliveryInvoicePart2Items.Clear();
                                _currentInvoiceDiscTypItems.Clear();

                                //stopWatch.PopTime("Throw time");

                                // If don't continue with this Delhed then if have written something
                                // to the extract tables for it then delete all extracted data for this Invoice
                                // and if extracting 'Invoices' + ('Per Delivery' and Cust Type = No Splits) or Cust Type = Per Order
                                // then cancel rest of deliveries for order.
                                if (atLeastOneDeliveryDetailWritten)
                                {
                                    UndoDeliveryChanges();
                                }
                                if (CheckIfSkipedDeliveryEscalatesToScipedOrder(_context.InvoiceTypeForAccount))
                                {
                                    //TODO: Ask if undo of complete order details is needed as lUndoDetail() doesn't do that.
                                    break; //Abort to process complete order 
                                }
                                //Moving to the new delivery head record
                            }

                        }
                        _context.DeliveryHead = null;
                        _context.IsDeliveryGoodsOnConsignment = false;
                        _context.InvoiceTotal = null;
                        _context.InvoiceTotalBeforeLastDelivery = null;
                    }
                    _context.Order = null;
                }
                _context.ClearInvoiceTypeForAccount();
            }
            finally
            {
                CleanAccountExecutionContext();
            }
        }

        #endregion

        public ExtractionProcessor
        (SystemPreferences systemPreferences, IUnitOfWork unitOfWorkCurrent, IDictionaryService dictionaryService)
        {
            _systemPreferences = systemPreferences;
            _unitOfWorkCurrent = unitOfWorkCurrent;
            _dictionaryService = dictionaryService;
            _salesPersonRepository = unitOfWorkCurrent.GetRepository<ISalesPersonRepository>();
            _companyDictionaryRepository = unitOfWorkCurrent.GetRepository<ICompanyDictionaryRepository>();
            _errorDescriptionRepository = unitOfWorkCurrent.GetRepository<IErrorDescriptionRepository>();
            _userRepository = unitOfWorkCurrent.GetRepository<IUserRepository>();
            _salesOfficeRepository = unitOfWorkCurrent.GetRepository<ISalesOfficeRepository>();
            _accToProcessRepository = unitOfWorkCurrent.GetRepository<IAccToProcessRepository>();
            _accountClassRepository = unitOfWorkCurrent.GetRepository<IAccountClassRepository>();
            _accountRepository = unitOfWorkCurrent.GetRepository<IAccountRepository>();
            _customerCategoryDepencencyRepository = unitOfWorkCurrent.GetRepository<ICustomerCategoryDepencencyRepository>();
            _headOfficeRepository = unitOfWorkCurrent.GetRepository<IHeadOfficeRepository>();
            _glInfoRepository = unitOfWorkCurrent.GetRepository<IGLInfoRepository>();
            _priceGroupRepository = unitOfWorkCurrent.GetRepository<IPriceGroupRepository>();
            _orderRepository = unitOfWorkCurrent.GetRepository<IOrderRepository>();
            _deliveryHeadRepository = unitOfWorkCurrent.GetRepository<IDeliveryHeadRepository>();
            _deliveryDetailRepository = unitOfWorkCurrent.GetRepository<IDeliveryDetailRepository>();
            _deliveryTypeRepository = unitOfWorkCurrent.GetRepository<IDeliveryTypeRepository>();
            _deliveryPriceRepository = unitOfWorkCurrent.GetRepository<IDeliveryPriceRepository>();
            _deliveryToItemStockRepository = unitOfWorkCurrent.GetRepository<IDeliveryToItemStockRepository>();
            _deliveryToCreditNoteRepository = unitOfWorkCurrent.GetRepository<IDeliveryPriceToCreditNoteRepository>();
            _currencyDictionaryRepository = unitOfWorkCurrent.GetRepository<ICurrencyDictionaryRepository>();
            _productRepository = unitOfWorkCurrent.GetRepository<IProductRepository>();
            _stockLocationRepository = unitOfWorkCurrent.GetRepository<IStockLocationRepository>();
            _vatLinkRepository = unitOfWorkCurrent.GetRepository<IVatLinkRepository>();
            _vatRateRepository = unitOfWorkCurrent.GetRepository<IVatRateRepository>();
            _customerProductInfoRepository = unitOfWorkCurrent.GetRepository<ICustomerProductInfoRepository>();
            _currencyRateRepository = unitOfWorkCurrent.GetRepository<ICurrencyRateRepository>();
            _preInvPrtRepository = unitOfWorkCurrent.GetRepository<IPreINVPRTRepository>();
            _preInvPrt2Repository = unitOfWorkCurrent.GetRepository<IPreInvPrt2Repository>();
            _preInvTotRepository = unitOfWorkCurrent.GetRepository<IPreInvTotRepository>();
            _invErrRepository = unitOfWorkCurrent.GetRepository<IInvErrRepository>();
            _invExtractHedRepository = unitOfWorkCurrent.GetRepository<IInvExtractHedRepository>();
            _invDiscTypRepository = unitOfWorkCurrent.GetRepository<IInvDiscTypRepository>();
            _ediCoSuppNoRepository = unitOfWorkCurrent.GetRepository<IEdiCoSuppNoRepository>();
            _priceListVatCheckRepository = unitOfWorkCurrent.GetRepository<IPriceListVatCheckRepository>();
            _customerDiscountRatesRepository = unitOfWorkCurrent.GetRepository<ICustomerDiscountRatesRepository>();
            _discountRatesRepository = unitOfWorkCurrent.GetRepository<IDiscountRatesRepository>();
            _iteChgRepository = unitOfWorkCurrent.GetRepository<IIteChgRepository>();
            _ichDiscTypRepository = unitOfWorkCurrent.GetRepository<IIchDiscTypRepository>();
            _accVATRepository = unitOfWorkCurrent.GetRepository<IAccVATRepository>();
            _prodTranslationRepository = unitOfWorkCurrent.GetRepository<IProductTranslationRepository>();
            _auditRecordRepository = _unitOfWorkCurrent.GetRepository<IAuditRecordRepository>();

            _sharedProcessingHelpers = new SharedProcessingHelpers(_glInfoRepository);
            _logger = LogManager.GetLoggerFor<ExtractionProcessor>();
            stopWatch = new PerformanceLogger(_logger);
        }

        public DTOPreInvExtractResult Process(DTOPreInvExtractParams extractParams, int extractSessionID, IDTOUser user)
        {
            _logger.Debug(string.Format("extractParams.CutOffDeliveryDate = {0}", extractParams.CutOffDeliveryDate.ToString()));
            _extractSessionID = extractSessionID;
            _user = user;
            _progressDelegate(0);
            stopWatch.Start();

            stopWatch.PushTime();
            DetectInvolvedSalesOffices(extractParams.SalesOfficeNo);
            stopWatch.PopTime("DetectInvolvedSalesOffices");
            _progressDelegate(2);
            if (extractParams.SalesOfficeNo != DTOSalesOffice.IncludeAllSalesOfficesNo)
            {
                SetExtractionInUseFlag(true, extractParams.SalesOfficeNo);
            }
            var salesOffice = _salesOfficeRepository.GetSalesOfficeByNo(extractParams.SalesOfficeNo, true);
            _nextInvoiceNo = salesOffice.NextInvoiceNo ?? 0;

            bool needUnlockSalesOffice = true;
            try
            {
                stopWatch.PushTime();
                var accToProcess = DetectInvolvedCustomers(extractParams);
                stopWatch.PopTime("DetectInvolvedCustomers");
                _progressDelegate(5);
                if (!LoadAccountsData(accToProcess))
                {
                    _progressDelegate(100);
                    return new DTOPreInvExtractResult { Status = PreInvExtractStatusType.NothingToExtract };
                }

                stopWatch.PushTime();
                InitializeLookupDictionaries(extractParams);
                stopWatch.PopTime("InitializeLookupDictionaries");
                _progressDelegate(10);

                stopWatch.PushTime();
                InitializeStatusFilters(extractParams);
                stopWatch.PopTime("InitializeStatusFilters");

                stopWatch.PushTime();
                ValidateAccountRecords(extractParams, accToProcess);
                stopWatch.PopTime("ValidateAccountRecords");
                _progressDelegate(15);
                if (accToProcess.Count == 0)
                {
                    _progressDelegate(100);
                    return new DTOPreInvExtractResult { Status = PreInvExtractStatusType.NothingToExtract };
                }

                stopWatch.PushTime();
                ProcessAccountsHeadOffice(extractParams, accToProcess);
                stopWatch.PopTime("ProcessAccountsHeadOffice");

                stopWatch.PushTime();
                ValidateDebtors(extractParams, accToProcess);
                stopWatch.PopTime("ValidateDebtors");

                _progressDelegate(20);
                if (accToProcess.Count == 0)
                {
                    _progressDelegate(100);
                    return new DTOPreInvExtractResult { Status = PreInvExtractStatusType.NothingToExtract };
                }

                stopWatch.PushTime();
                DetectPriceListGroups(extractParams, accToProcess);
                stopWatch.PopTime("DetectPriceListGroups");
                _progressDelegate(25);
                if (accToProcess.Count == 0)
                {
                    _progressDelegate(100);
                    return new DTOPreInvExtractResult { Status = PreInvExtractStatusType.NothingToExtract };
                }

                stopWatch.PushTime();
                if (!LoadOrdersInitialData(accToProcess))
                {
                    //Should never happen. It could only be the case if there are any errors in initial query filtering AccClasses.
                    throw new FreshTradeException("No orders found for AccClasses");
                }
                stopWatch.PopTime("LoadOrdersInitialData");
                _progressDelegate(35);

                stopWatch.PushTime();
                var accToRemove = new List<int>();
                for (int i = 0; i < accToProcess.Count; i++)
                {
                    var accountClassId = accToProcess[i];
                    stopWatch.PushTime();
                    if (!ValidateAccountOrders(extractParams, accountClassId))
                    {
                        accToRemove.Add(accountClassId);
                    }
                    stopWatch.PopTime(String.Format(" ValidateAccountOrder {0}", accountClassId));
                    _progressDelegate(35 + Math.Abs(i / accToProcess.Count * 20));
                }
                foreach (var accountToRemove in accToRemove)
                {
                    accToProcess.Remove(accountToRemove);
                }
                stopWatch.PopTime("/ iteration through accToProcess");

                if (accToProcess.Count == 0)
                {
                    _progressDelegate(100);
                    return new DTOPreInvExtractResult { Status = PreInvExtractStatusType.NothingToExtract };
                }

                stopWatch.PushTime();
                LoadOrdersFullData(accToProcess);
                stopWatch.PopTime("LoadOrdersFullData");
                _progressDelegate(65);

                stopWatch.PushTime();
                accToProcess.Sort();
                for (int i = 0; i < accToProcess.Count; i++)
                {
                    var accountClassId = accToProcess[i];
                    stopWatch.PushTime();
                    ProcessAccountOrders(extractParams, accountClassId);
                    stopWatch.PopTime(String.Format(" ProcessAccountOrders {0}", accountClassId));
                    _progressDelegate(65 + Math.Abs(i / accToProcess.Count * 30));
                }

                if ((_invoiceTotals.Count == 0) && (_extractResult.Errors.Count == 0))
                {
                    _progressDelegate(100);
                    return new DTOPreInvExtractResult { Status = PreInvExtractStatusType.NothingToExtract };
                }

                // lRoundVatByRate method implementation
                RoundVatByRate();

                _unitOfWorkCurrent.BeginTransaction();
                try
                {
                    //write everything to DB
                    //todo: reqdate, taxdate, mergetransactions fields
                    _invExtractHedRepository.DeleteByExtractSessionID(_extractSessionID);
                    _preInvTotRepository.DeleteByExtractSessionID(_extractSessionID);
                    _preInvPrtRepository.DeleteByExtractSessionID(_extractSessionID);
                    _preInvPrt2Repository.DeleteByExtractSessionID(_extractSessionID);
                    _invDiscTypRepository.DeleteByExtractSessionID(_extractSessionID);
                    _invErrRepository.DeleteByExtractSessionID(_extractSessionID);

                    _invExtractHedRepository.Add(new DTOInvExtractHead
                                                     {
                                                         ExtractSessionId = _extractSessionID,
                                                         UserId = _user.Id,
                                                         SalesOfficeNo = extractParams.SalesOfficeNo,
                                                         SalesOfficeName = _salesOfficeRepository.GetSalesOfficeByNo(extractParams.SalesOfficeNo).SalesOfficeDescription,
                                                         InvoiceType = extractParams.InvoiceType,
                                                         InvoiceTypeName = extractParams.InvoiceType.ConvertToString(),
                                                         CreatedDate = DateTime.Now,
                                                         CutOffDeliveryDate = extractParams.CutOffDeliveryDate,
                                                         TaxPointDate = extractParams.TaxPointDate,
                                                         InvoicePeriod = extractParams.InvoicePeriodType,
                                                         InvoicePeriodAsStr = _sharedProcessingHelpers.GetInvoicePeriodTypeAsString(extractParams.InvoicePeriodType),
                                                         InvoiceOrderType = extractParams.BatchType.ConvertToString(),
                                                         IsInterCompanyTransfer = extractParams.IsInterCompanyTransfer,
                                                         CompanyNo = extractParams.CompanyNo,
                                                         LastInvoiceNo = _nextInvoiceNo
                                                     });
                    _preInvTotRepository.Add(_invoiceTotals.Values);
                    _preInvPrtRepository.Add(_extractResult.InvoicePartItems);
                    _preInvPrt2Repository.Add(_extractResult.InvoicePart2Items);
                    _invDiscTypRepository.Add(_extractResult.InvoiceDiscTypItems);
                    _invErrRepository.Add(_extractResult.Errors);

                    _unitOfWorkCurrent.Commit();
                    stopWatch.PopTime("accountClassId in accToProcess");
                    needUnlockSalesOffice = false;
                }
                catch (Exception)
                {
                    _unitOfWorkCurrent.Rollback();
                    throw;
                }
            }
            finally
            {
                if (needUnlockSalesOffice && (extractParams.SalesOfficeNo != DTOSalesOffice.IncludeAllSalesOfficesNo))
                {
                    SetExtractionInUseFlag(false, extractParams.SalesOfficeNo);
                }
            }
            stopWatch.Stop("Processing done");
            _progressDelegate(100);

            _extractResult.InvoiceTotalItems = _invoiceTotals.Values.ToList();
            return _extractResult;

        }

        private void RoundVatByRate()
        {
            foreach (var invTotal in _invoiceTotals.Values)
            {
                var numOfVats = invTotal.TwoVatRatesCust ? 2 : 1;

                decimal
                    amVAT = 0,
                    amEuroVAT = 0,
                    amBaseVAT = 0,
                    amVAT1Tot = 0,
                    amEuroVAT1Tot = 0,
                    amBaseVAT1Tot = 0,
                    amVAT2Tot = 0,
                    amEuroVAT2Tot = 0,
                    amBaseVAT2Tot = 0;

                if (!invTotal.CurNo.HasValue)
                {
                    continue;
                }

                var curNo = invTotal.CurNo.Value;

                foreach (var vatInfo in invTotal.VatInfo.Values)
                {
                    for (var j = 1; j <= numOfVats; j++)
                    {
                        if (j == 1)
                        {
                            amVAT = _dictionaryService.RoundCurrency(vatInfo.Vat, curNo);
                            amEuroVAT = _dictionaryService.RoundCurrency(vatInfo.EuroVat, DTOCurrency.EuroCurrencyNo);
                            amBaseVAT = _dictionaryService.RoundCurrency(vatInfo.BaseVat, DTOCurrency.BaseCurrencyNo);

                            vatInfo.Vat = amVAT;
                            vatInfo.EuroVat = amEuroVAT;
                            vatInfo.BaseVat = amBaseVAT;

                            amVAT1Tot += amVAT;
                            amEuroVAT1Tot += amEuroVAT;
                            amBaseVAT1Tot += amBaseVAT;

                        }
                        else
                        {
                            amVAT = _dictionaryService.RoundCurrency(vatInfo.Vat2, curNo);
                            amEuroVAT = _dictionaryService.RoundCurrency(vatInfo.EuroVat2, DTOCurrency.EuroCurrencyNo);
                            amBaseVAT = _dictionaryService.RoundCurrency(vatInfo.BaseVat2, DTOCurrency.BaseCurrencyNo);

                            vatInfo.Vat2 = amVAT;
                            vatInfo.EuroVat2 = amEuroVAT;
                            vatInfo.BaseVat2 = amBaseVAT;

                            amVAT2Tot += amVAT;
                            amEuroVAT2Tot += amEuroVAT;
                            amBaseVAT2Tot += amBaseVAT;

                        }
                    }
                }

                invTotal.VatTotal = amVAT1Tot + amVAT2Tot;
                invTotal.EuroVatTotal = amEuroVAT1Tot + amEuroVAT2Tot;
                invTotal.BaseVatTotal = amBaseVAT1Tot + amBaseVAT2Tot;
                invTotal.Vat1Total = amVAT1Tot;
                invTotal.Vat2Total = amVAT2Tot;
                invTotal.EuroVat1Total = amEuroVAT1Tot;
                invTotal.EuroVat2Total = amEuroVAT2Tot;
                invTotal.BaseVat1Total = amBaseVAT1Tot;
                invTotal.BaseVat2Total = amBaseVAT2Tot;
                invTotal.InvoiceTotal = invTotal.GoodsTotal + amVAT1Tot + amVAT2Tot - invTotal.OnInvDscnt;
            }
        }

        public void SetProgressWatcher(UpdateProgressDelegate progressDelegate)
        {
            _progressDelegate += progressDelegate;
        }

        public void CleanUp(int? salesOfficeNo, int? extractSessionID)
        {
            if (extractSessionID.HasValue)
            {
                _extractSessionID = extractSessionID.Value;
                if (salesOfficeNo.HasValue && (salesOfficeNo != DTOSalesOffice.IncludeAllSalesOfficesNo))
                {
                    SetExtractionInUseFlag(false, salesOfficeNo.Value, true);
                }
                //TODO: Finalize that, clean Temp tables
            }
        }
    }

    public class ExtractionProcessorFactory : IExtractionProcessorFactory
    {
        public IExtractionProcessor GetProcessor(SystemPreferences systemPreferences,
                                                 IUnitOfWork unitOfWorkCurrent,
                                                 IDictionaryService dictionaryService)
        {
            return new ExtractionProcessor(systemPreferences, unitOfWorkCurrent, dictionaryService);
        }
    }
}
