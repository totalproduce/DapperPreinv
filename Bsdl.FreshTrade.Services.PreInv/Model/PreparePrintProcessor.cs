using Bsdl.FreshTrade.Domain.Account.Entities;
using Bsdl.FreshTrade.Domain.Basic.Entities;
using Bsdl.FreshTrade.Domain.Basic.Exceptions;
using Bsdl.FreshTrade.Domain.Basic.Utilities.DataTypeHandling;
using Bsdl.FreshTrade.Domain.PreInv.Entities;
using Bsdl.FreshTrade.Domain.PreInv.Enums;
using Bsdl.FreshTrade.Domain.PreInv.Utilities;
using Bsdl.FreshTrade.Repositories.Account.Interfaces;
using Bsdl.FreshTrade.Repositories.Basic.Utilities.Interfaces;
using Bsdl.FreshTrade.Repositories.PreInv.Interfaces;
using Bsdl.FreshTrade.Services.Basic.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Bsdl.FreshTrade.Services.PreInv.Model
{
    public class PreparePrintProcessor
    {
        private const string InvPrefix_Normal = "N";
        private const string InvPrefix_InterDept = "X";
        private const string InvPrefix_Transfer = "T";

        private readonly IUnitOfWork _unitOfWorkCurrent;
        private readonly SystemPreferences _systemPreferences;

        private readonly ISalesOfficeRepository _salesOfficeRepository;
        private readonly IInvExtractHedRepository _invExtractHedRepository;
        private readonly IDictionaryService _dictionaryService;

        private readonly IPreInvTotRepository _preInvTotRepository;
        private readonly IPreINVPRTRepository _preInvPrtRepository;
        private readonly IPreInvPrt2Repository _preInvPrt2Repository;
        private readonly IPreInvDiscTypRepository _preInvDiscTypRepository;

        private readonly IInvTotRepository _invTotRepository;
        private readonly IINVPRTRepository _invPrtRepository;
        private readonly IInvPrt2Repository _invPrt2Repository;
        private readonly IInvDiscTypRepository _invDiscTypRepository;

        public PreparePrintProcessor
            (SystemPreferences systemPreferences, IUnitOfWork unitOfWorkCurrent, IDictionaryService dictionaryService)
        {
            _systemPreferences = systemPreferences;
            _unitOfWorkCurrent = unitOfWorkCurrent;

            _salesOfficeRepository = _unitOfWorkCurrent.GetRepository<ISalesOfficeRepository>();
            _invExtractHedRepository = _unitOfWorkCurrent.GetRepository<IInvExtractHedRepository>();
            _dictionaryService = dictionaryService;

            _preInvTotRepository = _unitOfWorkCurrent.GetRepository<IPreInvTotRepository>();
            _preInvPrtRepository = _unitOfWorkCurrent.GetRepository<IPreINVPRTRepository>();
            _preInvPrt2Repository = _unitOfWorkCurrent.GetRepository<IPreInvPrt2Repository>();
            _preInvDiscTypRepository = _unitOfWorkCurrent.GetRepository<IPreInvDiscTypRepository>();


            _invTotRepository = _unitOfWorkCurrent.GetRepository<IInvTotRepository>();
            _invPrtRepository = _unitOfWorkCurrent.GetRepository<IINVPRTRepository>();
            _invPrt2Repository = _unitOfWorkCurrent.GetRepository<IInvPrt2Repository>();
            _invDiscTypRepository = _unitOfWorkCurrent.GetRepository<IInvDiscTypRepository>();
        }

        private DTOInvTotVatInfo RoundVatInfo(DTOInvTotVatInfo vatInfo, int curNo)
        {
            return new DTOInvTotVatInfo
            {
                Cde = vatInfo.Cde,
                AvaVeaRec = vatInfo.AvaVeaRec,
                Rte = vatInfo.Rte,
                Vat = _dictionaryService.RoundCurrency(vatInfo.Vat, curNo),
                Gds = _dictionaryService.RoundCurrency(vatInfo.Gds, curNo),
                EuroVat = _dictionaryService.RoundCurrency(vatInfo.EuroVat, DTOCurrency.EuroCurrencyNo),
                EuroGds = _dictionaryService.RoundCurrency(vatInfo.EuroGds, DTOCurrency.EuroCurrencyNo),
                BaseVat = _dictionaryService.RoundCurrency(vatInfo.BaseVat, DTOCurrency.BaseCurrencyNo),
                BaseGds = _dictionaryService.RoundCurrency(vatInfo.BaseGds, DTOCurrency.BaseCurrencyNo),
                VatLnkRecNo = vatInfo.VatLnkRecNo,
                Rte2 = _dictionaryService.RoundCurrency(vatInfo.Rte2, curNo),
                Vat2 = _dictionaryService.RoundCurrency(vatInfo.Vat2, curNo),
                EuroVat2 = _dictionaryService.RoundCurrency(vatInfo.EuroVat2, DTOCurrency.EuroCurrencyNo),
                BaseVat2 = _dictionaryService.RoundCurrency(vatInfo.BaseVat2, DTOCurrency.BaseCurrencyNo)
            };

        }

        public IDictionary<DTOInvTotGroup, int> GetInvoiceBatchNumbers(IList<DTOInvTot> preInvTotals, int? lastBatchNo)
        {
            int newBatchNo = lastBatchNo ?? 0;
            var result = preInvTotals.GroupBy(i => new DTOInvTotGroup(i.InvoiceType, i.BatchType)).OrderBy(i => i.Key.InvoiceType).ThenBy(i => i.Key.BatchType).ToDictionary(i => i.Key, i => ++newBatchNo);
            return result;
        }

        public Dictionary<string, string> Process(DTOPreInvUpdateParams preparePrintParams, int extractSessionId)
        {
            var lRes = new Dictionary<string, string>();

            if (preparePrintParams.SelectedPreInvTot.Count == 0)
            {
                throw new FreshTradeException("Please select at least one invoice");
            }
            var invExtractHead = _invExtractHedRepository.GetInvExtractHeadByExtractionSessionId(extractSessionId);
            var salesOffice = _salesOfficeRepository.GetSalesOfficeByNo(invExtractHead.SalesOfficeNo, true);
            var preInvTotals = _preInvTotRepository.GetInvTotByExtractionSessionId(extractSessionId, preparePrintParams.SelectedPreInvTot);
            var preInvPart = _preInvPrtRepository.GetInvPrtByExtractionSessionId(extractSessionId, preparePrintParams.SelectedPreInvPrt);
            var preInvPart2 = _preInvPrt2Repository.GetInvPrt2ByExtractionSessionId(extractSessionId, preparePrintParams.SelectedPreInvPrt2);
            var preinvDiscTyp = _preInvDiscTypRepository.GetByExtractSessionID(extractSessionId);

            PreInvTotalCalculator.CalcTotals(preInvTotals, preInvPart2, _systemPreferences.UserHasVat);

            var invTotalList = new List<DTOInvTot>();
            var invDiscTypList = new List<DTOInvDiscTyp>();
            var invPart2List = new List<DTOInvPrt2>();
            var invPartList = new List<DTOInvPrt>();

            var lstInvNo = salesOffice.NextInvoiceNo;
            var curNo = DTOCurrency.BaseCurrencyNo; // Should be read from db Invoice table
            var invBatchNos = GetInvoiceBatchNumbers(preInvTotals, salesOffice.LastBatchNo);

            foreach (var preInvTotal in preInvTotals)
            {
                var invTotal = ObjectHandling.CloneDTO(preInvTotal, false);
                invTotal.BatchNo = invBatchNos[new DTOInvTotGroup(preInvTotal.InvoiceType, preInvTotal.BatchType)];
                invTotal.OriginalInvoiceNo = preInvTotal.InvoiceNo;
                var currInvoiceNo = preInvTotal.InvoiceNo;

                // Logic for Invoice re-numbering
                if (preInvTotal.IsSeqInvNo)
                {
                    // Invoice Number Calculation
                    int invoiceNo = lstInvNo ?? 0;
                    lstInvNo++;

                    if (_systemPreferences.AddYearToInvNo)
                    {
                        invoiceNo = invoiceNo * 100 + (DateTime.Now.Year % 100);
                    }

                    if
                        (
                            _systemPreferences.AddSoToInvNo &&
                            DTOSalesOffice.GetUnsignedSalesOfficeNumber(invExtractHead.SalesOfficeNo) > 0
                        )
                    {
                        invoiceNo = invoiceNo * 100 + (invExtractHead.SalesOfficeNo % 100);
                    }

                    string stInvoiceNo;
                    if (invExtractHead.IsInterCompanyTransfer) // Transfer Invoice
                    {
                        stInvoiceNo = InvPrefix_Transfer + invoiceNo;
                    }
                    else
                    {
                        if (preInvTotal.IsInterDept) //Inter Dept Invoice
                        {
                            stInvoiceNo = InvPrefix_InterDept + invoiceNo;
                        }
                        else
                        {
                            stInvoiceNo = InvPrefix_Normal + invoiceNo;
                        }
                    }

                    invTotal.InvoiceNo = stInvoiceNo;
                }
                else
                {
                    invTotal.InvoiceNo = currInvoiceNo;
                }

                if (currInvoiceNo != invTotal.InvoiceNo)
                {
                    lRes.Add(currInvoiceNo, invTotal.InvoiceNo);
                }

                var invoicePart2List = preInvPart2.Where(ip => ip.InvoiceNo == currInvoiceNo);

                int tmpRecNo = 1;

                foreach (var preInvPrt2 in invoicePart2List)
                {
                    var preinvDiscTypList =
                        preinvDiscTyp.Where(dt => dt.DlvInvoiceNo == currInvoiceNo && dt.RecNo == preInvPrt2.Recno);

                    foreach (var preinvDisctyp in preinvDiscTypList)
                    {
                        var tmp = ObjectHandling.CloneDTO(preinvDisctyp);
                        tmp.DlvInvoiceNo = invTotal.InvoiceNo;
                        tmp.RecNo = tmpRecNo;
                        invDiscTypList.Add(tmp);
                    }

                    var invPart2 = ObjectHandling.CloneDTO(preInvPrt2);
                    invPart2.Recno = tmpRecNo;
                    invPart2.InvoiceNo = invTotal.InvoiceNo;
                    invPart2List.Add(invPart2);

                    tmpRecNo++;

                    #region EDI Staff - not used now
                    /*
                    DTOInvPrt calcInvPart = null;

                    if (preInvTotal.IsEdiCst)
                    {
                        var lMergePrdNo = preInvPrt2.DelCltPrdNo == null ? preInvPrt2.DelCltPrdNo : preInvPrt2.PrcPrdRef;

                        if (
                            (
                            preInvTotal.InvoiceType == PreInvInvoiceType.Invoice  &&
                            (
                                preInvPrt2.DelInvStatus == DTODeliveryPriceStatus.CreditOnNormalDelivery ||
                                preInvPrt2.DelInvStatus == DTODeliveryPriceStatus.DebitOnNormalDelivery
                            )
                            ) ||
                            preparePrintParams.MergeLikePrices
                           )
                        {
                            if (preInvPrt2.DelCltPrdNo == null)
                            {
                                calcInvPart = invPartList.FirstOrDefault(p =>
                                    (
                                        p.DlvOrdNo == preInvPrt2.DlvOrdNo &&
                                        p.DelPrcPrdNo == (preInvPrt2.DelPrcPrdNo ?? -1) &&
                                        p.MergePrdNo == lMergePrdNo &&
                                        p.DelPrice == preInvPrt2.DelPrice
                                        ));
                            }
                            else
                            {
                                calcInvPart = invPartList.FirstOrDefault(p =>(p.DlvOrdNo.ToString() ==  lMergePrdNo));
                            }

                            //todo: 
                            //; If doing EdiCst and this is a credit or debit transaction
                            //; then locate the credit stock adjustment record
                        }


                        if (calcInvPart != null)
                        {
                            //string stQty;
                            //if (preInvPrt2.DelPrcByWgt)
                            //{
                            //    stQty = (preInvPrt2.DelWeight + calcInvPart.DelWeight).ToString();
                            //}
                            //else
                            //{
                            //    stQty = (preInvPrt2.DelQty.HasValue ? preInvPrt2.DelQty.Value : 0 + calcInvPart.DelQty).ToString();
                            //}

                            // !--> tc["InvPrt1"].PrtQty    = stQty // looks not used !
                            calcInvPart.DelQty = preInvPrt2.DelQty.HasValue
                                ? preInvPrt2.DelQty.Value
                                : 0 + calcInvPart.DelQty;
                            calcInvPart.DelWeight = preInvPrt2.DelWeight + calcInvPart.DelWeight;

                            calcInvPart.
                        }

                    }
                    */
                    #endregion

                }

                var invoicePartList = preInvPart.Where(ip => ip.DlvInvoiceNo == currInvoiceNo);

                foreach (var preinvPart in invoicePartList)
                {
                    var invPart = ObjectHandling.CloneDTO(preinvPart);
                    invPart.DlvInvoiceNo = invTotal.InvoiceNo;
                    invPartList.Add(invPart);
                }

                // Invoice Total data
                invTotal.GoodsTotal = _dictionaryService.RoundCurrency(preInvTotal.GoodsTotal, curNo); // + SCHAPPAMT {calculated from Service Charges}
                invTotal.InvoiceTotal = _dictionaryService.RoundCurrency(preInvTotal.InvoiceTotal, curNo); // + SCHAPPAMT + SCHRAWVAT
                invTotal.EuroGdsTotal = _dictionaryService.RoundCurrency(preInvTotal.EuroGdsTotal, DTOCurrency.EuroCurrencyNo); // + SCHEUROAPPAMT
                invTotal.BaseGdsTotal = _dictionaryService.RoundCurrency(preInvTotal.BaseGdsTotal, DTOCurrency.BaseCurrencyNo); // + SCHBASEAPPAMT

                decimal
                    vat1Total = 0,
                    vat2Total = 0,
                    euroVat1Total = 0,
                    euroVat2Total = 0,
                    baseVat1Total = 0,
                    baseVat2Total = 0;

                if (_systemPreferences.UserHasVat)
                {
                    foreach (var vatInfo in preInvTotal.VatInfo)
                    {
                        var roundedVatInfo = RoundVatInfo(vatInfo.Value, curNo);
                        invTotal.VatInfo.Add(vatInfo.Key, roundedVatInfo);
                        vat1Total += roundedVatInfo.Vat;
                        vat2Total += roundedVatInfo.Vat2;
                        euroVat1Total += roundedVatInfo.EuroVat;
                        euroVat2Total += roundedVatInfo.EuroVat2;
                        baseVat1Total += roundedVatInfo.BaseVat;
                        baseVat2Total += roundedVatInfo.BaseVat2;
                    }
                }

                invTotal.Finfiscrep1 = preInvTotal.Finfiscrep1;
                invTotal.Finvatnumber1 = preInvTotal.Finvatnumber1;
                invTotal.Finvatdesc1 = preInvTotal.Finvatdesc1;

                invTotal.Vat1Total = _dictionaryService.RoundCurrency(vat1Total, curNo);
                invTotal.Vat2Total = _dictionaryService.RoundCurrency(vat2Total, curNo);
                invTotal.EuroVat1Total = _dictionaryService.RoundCurrency(euroVat1Total, DTOCurrency.EuroCurrencyNo);
                invTotal.EuroVat2Total = _dictionaryService.RoundCurrency(euroVat2Total, DTOCurrency.EuroCurrencyNo);
                invTotal.BaseVat1Total = _dictionaryService.RoundCurrency(baseVat1Total, DTOCurrency.BaseCurrencyNo);
                invTotal.BaseVat2Total = _dictionaryService.RoundCurrency(baseVat2Total, DTOCurrency.BaseCurrencyNo);

                invTotal.VatTotal = invTotal.Vat1Total + invTotal.Vat2Total;
                invTotal.EuroVatTotal = invTotal.EuroVat1Total + invTotal.EuroVat2Total;
                invTotal.BaseVatTotal = invTotal.BaseVat1Total + invTotal.BaseVat2Total;

                invTotal.InvoiceTotal = invTotal.GoodsTotal + invTotal.VatTotal - invTotal.OnInvDscnt; // OnInvDscnt - was not initialized in the code

                invTotal.StInvTotal = _dictionaryService.CurrencyAsString(invTotal.InvoiceTotal, curNo); 

                invTotalList.Add(invTotal);
            }

            var modifiedExtractHead = ObjectHandling.CloneDTO(invExtractHead);
            modifiedExtractHead.LastInvoiceNo = lstInvNo??0;

            _unitOfWorkCurrent.BeginTransaction();
            try
            {
                _invTotRepository.DeleteByExtractSessionID(extractSessionId);
                _invPrtRepository.DeleteByExtractSessionID(extractSessionId);
                _invPrt2Repository.DeleteByExtractSessionID(extractSessionId);
                _invDiscTypRepository.DeleteByExtractSessionID(extractSessionId);
                _invTotRepository.Add(invTotalList);
                _invPrtRepository.Add(invPartList);
                _invPrt2Repository.Add(invPart2List);
                _invDiscTypRepository.Add(invDiscTypList);
                _invExtractHedRepository.Update(invExtractHead, modifiedExtractHead);
                _unitOfWorkCurrent.Commit();
            }
            catch(Exception)
            {
                _unitOfWorkCurrent.Rollback();
                throw;
            }

            return lRes;
        }
    }
}
