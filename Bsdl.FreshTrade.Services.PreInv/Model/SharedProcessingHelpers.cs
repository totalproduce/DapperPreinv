using System.Collections.Generic;
using System.Text;
using Bsdl.FreshTrade.Domain.Account.Entities;
using Bsdl.FreshTrade.Domain.Account.Enums;
using Bsdl.FreshTrade.Domain.Basic.Exceptions;
using Bsdl.FreshTrade.Domain.Basic.Utilities.DataTypeHandling;
using Bsdl.FreshTrade.Domain.PreInv.Entities;
using Bsdl.FreshTrade.Domain.PreInv.Enums;
using Bsdl.FreshTrade.Repositories.Account.Interfaces;
using System;
using System.Linq;
using Bsdl.FreshTrade.Repositories.Basic.Interfaces;
using Bsdl.FreshTrade.Services.PreInv.Model.Interfaces;

namespace Bsdl.FreshTrade.Services.PreInv.Model
{
    public interface ISharedProcessingHelpers
    {
        bool LookupGLCode(DTOGLLookupParams parameters, IExtractionErrorsRegistry errorRegistry);
        int GetGLCode(DTOGLLookupParams parameters, IExtractionErrorsRegistry errorRegistry);
        Dictionary<DTOInvoiceType, PreInvBatchType> GetInvoiceTypeToBatchTypeMapping();
        PreInvInvoicePeriodType GetInvoicePeriodType(int accountInvoicePeriod);

        string GetInvoicePeriodTypeAsString(PreInvInvoicePeriodType accountInvoicePeriod, string dailyOnlyText = "Daily", string dailyAndWeeklyText = "Daily and Weekly");
        EnumPostType GetPostTypeByInvoiceType(PreInvInvoiceType invoiceType);
    }

    public class SharedProcessingHelpers : ISharedProcessingHelpers
    {
        public const int CurrencyCodeBase = 1;
        public const int CurrencyCodeEuro = 2;

        #region Repositories
        private readonly IGLInfoRepository _glInfoRepository;
        #endregion

        #region GL Info Section

        private readonly Dictionary<DTOGLLookupParams, int> _glAccountRefs = new Dictionary<DTOGLLookupParams, int>(new DTOGLLookupParamsComparer());

        public bool LookupGLCode(DTOGLLookupParams parameters, IExtractionErrorsRegistry errorRegistry)
        {
            return GetGLCode(parameters, errorRegistry) != 0;
        }

        public int GetGLCode(DTOGLLookupParams parameters, IExtractionErrorsRegistry errorRegistry)
        {
            int glAccountRef;
            if (_glAccountRefs.TryGetValue(parameters, out glAccountRef))
            {
                return glAccountRef;
            }

            int? value1 = DTOSalesOffice.GetUnsignedSalesOfficeNumber(parameters.SalesOfficeNo), value2 = null, value3 = null;
            Func<DTOGLBrakedOn, int?> criteria1 = i => i.SalesOfficeNo, criteria2 = i => null, criteria3 = i => null;
            bool rebateCalculation = false;

            switch (parameters.LookupType)
            {
                case PreInvGLLookupType.Debtors:
                    {
                        value2 = parameters.AccountGLType;
                        criteria2 = i => i.AccountGLType;
                        break;
                    }
                case PreInvGLLookupType.RebateBalance:
                case PreInvGLLookupType.RebateProfitAndLoss:
                    {
                        value2 = parameters.ProductAnalysisGroup;
                        criteria2 = i => i.ProductLinkNo;

                        value3 = parameters.DiscountRebateGLNo;
                        criteria3 = i => i.DiscountRebateGLGroup;
                        rebateCalculation = true;
                        break;
                    }
                case PreInvGLLookupType.Discount:
                    {
                        value2 = parameters.ProductAnalysisGroup;
                        criteria2 = i => i.ProductLinkNo;
                        break;
                    }
                case PreInvGLLookupType.Sales:
                    {
                        value2 = parameters.AccountGLType;
                        criteria2 = i => i.AccountGLType;

                        value3 = parameters.ProductAnalysisGroup;
                        criteria3 = i => i.ProductLinkNo;
                        break;
                    }
                case PreInvGLLookupType.VAT:
                    {
                        value2 = parameters.VatRecId;
                        criteria2 = i => i.VatRecNo;

                        value3 = parameters.VatType;
                        criteria3 = i => i.VatTypeNo;
                        break;
                    }
                //rest uses only SalesNo parameter
            }
            bool found = false;
            int bestScore = 0;

            var lookupCode = Enums<PreInvGLLookupType>.GetCode(parameters.LookupType);
            if (string.IsNullOrEmpty(lookupCode))
            {
                throw new FreshTradeException("Lookup type is invalid");
            }
            var glData = _glInfoRepository.GetData(null, CachingStrategy.PerRequest).Where(g => g.CrossRefCode == lookupCode).ToList();

            foreach (var glBrakedOn in glData)
            {
                if (glBrakedOn.GlbGanRec > 0)
                {
                    int currentScore = 0, currentRef = -1;

                    bool currentIsExactMatch = true;
                    if (CompareGLParams(value1, criteria1(glBrakedOn), glBrakedOn.GlbGanRec, 3, ref currentScore, ref currentRef, ref currentIsExactMatch, rebateCalculation))
                        continue;

                    if (CompareGLParams(value2, criteria2(glBrakedOn), glBrakedOn.GlbGanRec, 2, ref currentScore, ref currentRef, ref currentIsExactMatch, rebateCalculation))
                        continue;

                    if (CompareGLParams(value3, criteria3(glBrakedOn), glBrakedOn.GlbGanRec, 1, ref currentScore, ref currentRef, ref currentIsExactMatch, rebateCalculation))
                        continue;

                    if (currentScore <= bestScore) continue;

                    glAccountRef = currentRef;
                    bestScore = currentScore;
                    found = true;
                    if (currentIsExactMatch)
                    {
                        break;
                    }
                }
            }

            if (found)
            {
                _glAccountRefs.Add(parameters, glAccountRef);
                return glAccountRef;
            }

            if (errorRegistry != null)
            {
                errorRegistry.RegisterExtractionError(PreInvExtractionErrorTypes.NoNominalLedgerXrefAccountOnFile, lookupCode, string.Format("{0}~{1}~{2}", value1, value2, value3));
            }
            return 0;
        }

        private bool CompareGLParams(int? inData, int? compareData, int recNo, int step,
            ref int currentScore, ref int currentRef, ref bool isExactMatch,
            bool passInNull)
        {
            const int weightBlank = 2;
            const int weightMatch = 3;

            if (!passInNull && !inData.HasValue)
            {
                return false;
            }

            if (!compareData.HasValue)
            {
                currentScore = currentScore + (int)Math.Pow(weightBlank, step);
                currentRef = recNo;
                isExactMatch = false;
            }
            else
            {

                if (inData.HasValue && compareData.Value == inData.Value)
                {
                    currentScore = currentScore + (int)Math.Pow(weightMatch, step);
                    currentRef = recNo;
                }
                else
                {
                    return true;
                }
            }
            return false;
        }
        #endregion

        public SharedProcessingHelpers(IGLInfoRepository glInfoRepository)
        {
            _glInfoRepository = glInfoRepository;
        }

        public Dictionary<DTOInvoiceType, PreInvBatchType> GetInvoiceTypeToBatchTypeMapping()
        {
            var result = new Dictionary<DTOInvoiceType, PreInvBatchType>();
            
            result.Add(DTOInvoiceType.Unknown, PreInvBatchType.PerDelivery);
            result.Add(DTOInvoiceType.PerDeliveryGrossNoSplit, PreInvBatchType.PerDelivery);  // extract Per Delivery gross (don't allow split Orders).
            result.Add(DTOInvoiceType.PerDeliveryGrossAllowSplit, PreInvBatchType.PerDelivery);  // extract Per Delivery gross (allow split Orders).
            result.Add(DTOInvoiceType.PerDeliveryNettNoSplit, PreInvBatchType.PerDelivery);  // extract Per Delivery nett (don't allow split Orders).
            result.Add(DTOInvoiceType.PerDeliveryNettAllowSplit, PreInvBatchType.PerDelivery);  // extract Per Delivery nett (allow split Orders).
            result.Add(DTOInvoiceType.DeliveryNoteInvoice, PreInvBatchType.PerDelivery);  // extract Delivery Note is Invoice.

            result.Add(DTOInvoiceType.CombinedDeliveriesGross, PreInvBatchType.PerOrder);  // extract Combined Deliveries gross.
            result.Add(DTOInvoiceType.CombinedDeliveriesNett, PreInvBatchType.PerOrder);  // extract Combined Deliveries nett.
            result.Add(DTOInvoiceType.PerOrderNettOfRelCredits, PreInvBatchType.PerOrder); // doug 30/10/08  -7788

            result.Add(DTOInvoiceType.CombinedOrdersGross, PreInvBatchType.PerCustomer);  // extract Combined Orders gross.
            result.Add(DTOInvoiceType.CombinedOrdersNett, PreInvBatchType.PerCustomer);  // extract Combined Orders nett.

            return result;
        }

        public PreInvInvoicePeriodType GetInvoicePeriodType(int accountInvoicePeriod)
        {
            return accountInvoicePeriod == 1 ? PreInvInvoicePeriodType.DailyOnly : PreInvInvoicePeriodType.DailyAndWeekly;
        }

        public string GetInvoicePeriodTypeAsString(PreInvInvoicePeriodType accountInvoicePeriod, string dailyOnlyText = "Daily", string dailyAndWeeklyText = "Daily and Weekly")
        {
            return accountInvoicePeriod == PreInvInvoicePeriodType.DailyOnly ? dailyOnlyText : dailyAndWeeklyText;
        }

        public EnumPostType GetPostTypeByInvoiceType(PreInvInvoiceType invoiceType)
        {
            switch (invoiceType)
            {
                case PreInvInvoiceType.Invoice:
                    return EnumPostType.SALESINVPSTRECNO;
                case PreInvInvoiceType.CreditNote:
                    return EnumPostType.SALESCNTPSTRECNO;
                default:
                    return EnumPostType.SALESDNTPSTRECNO;
            }
        }

    }
}
