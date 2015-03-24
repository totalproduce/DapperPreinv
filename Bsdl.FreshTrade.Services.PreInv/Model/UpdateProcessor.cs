using System.Text;
using System.Web.Configuration;
using Bsdl.FreshTrade.Domain.Account.Entities;
using Bsdl.FreshTrade.Domain.Account.Enums;
using Bsdl.FreshTrade.Domain.Basic.Exceptions;
using Bsdl.FreshTrade.Domain.Basic.Interfaces;
using Bsdl.FreshTrade.Domain.Basic.Utilities;
using Bsdl.FreshTrade.Domain.Basic.Utilities.DataTypeHandling;
using Bsdl.FreshTrade.Domain.PreInv.Entities;
using Bsdl.FreshTrade.Domain.PreInv.Enums;
using Bsdl.FreshTrade.Repositories.Account.Interfaces;
using Bsdl.FreshTrade.Repositories.Basic;
using Bsdl.FreshTrade.Repositories.Basic.Interfaces;
using Bsdl.FreshTrade.Repositories.Basic.Utilities.Interfaces;
using Bsdl.FreshTrade.Repositories.PreInv.Interfaces;
using Bsdl.FreshTrade.Server.Basic.Interfaces;
using Bsdl.FreshTrade.Server.Basic.Logger;
using Bsdl.FreshTrade.Services.PreInv.Model.Interfaces;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;

namespace Bsdl.FreshTrade.Services.PreInv.Model
{
    public class UpdateProcessor
    {
        private readonly ILogger _logger;
        private const int NumVatFlds = 3;
        //TODO: Check for FormName and FormNo sources.

        // ReSharper disable InconsistentNaming
        private const int AtrStatInd_NewRecord = 100;
        private const int AtrStatInd_NewRecordZeroBalance = 110;
        // ReSharper restore InconsistentNaming

        private readonly IUnitOfWork _unitOfWorkCurrent;

        private readonly ISalesOfficeRepository _salesOfficeRepository;
        private readonly IAccountClassRepository _accountClassRepository;
        private readonly IAccountRepository _accountRepository;
        private readonly IGLInfoRepository _glInfoRepository;
        private readonly ISharedProcessingHelpers _sharedProcessingHelpers;
        private readonly Dictionary<DTOInvoiceType, PreInvBatchType> _invoiceTypeToBatchTypeMapping;
        // ReSharper disable NotAccessedField.Local
        private readonly SystemPreferences _systemPreferences;
        // ReSharper restore NotAccessedField.Local

        private readonly IAcciteRepository _acciteRepository;
        private readonly IInvTotRepository _invTotRepository;
        private readonly IINVPRTRepository _invPrtRepository;
        private readonly IInvPrt2Repository _invPrt2Repository;
        private readonly IInvDiscTypRepository _invDiscTypRepository;
        private readonly IInvExtractHedRepository _invExtractHedRepository;

        private readonly IAccTrnFilRepository _accTrnFilRepository;
        private readonly IAccVATRepository _accVatRepository;
        private readonly IAccAllValRepository _accAllValRepository;
        private readonly IAccAllocRepository _accAllocRepository;
        private readonly IPostTypeRepository _postTypeRepository;
        private readonly IDeliveryPriceRepository _deliveryPriceRepository;
        private readonly IExpChaRepository _expChaRepository;
        private readonly IIteChgRepository _iteChgRepository;
        private readonly IOrderRepository _orderRepository;
        private readonly IDeliveryHeadRepository _deliveryHeadRepository;
        private readonly IDeliveryDetailRepository _deliveryDetailRepository;
        private readonly IAccReChgRepository _accReChgRepository;
        private readonly IBatchRepository _batchRepository;
        private readonly IBatchDetRepository _batchDetRepository;
        private readonly IEdiLogInvoiceRepository _ediLogInvoiceRepository;
        private readonly IAuditRecordRepository _auditRecordRepository;
        private readonly IDelAuditRecordRepository _delAuditRecordRepository;
        private readonly IDelAudToDoRecordRepository _delAudToDoRecordRepository;
        private readonly IINVEDIRepository _invediRepository;
        private readonly IIchDiscTypRepository _ichDiscTypRepository;
        private readonly IDTOUser _user;

        private readonly IRequestContextCache<int> _localCache = new RequestContextCache<int>();
        private UpdateExecutionContext _context;

        public event UpdateProgressDelegate ProgressChanged;

        protected void WriteAccite(
            List<DTOAccite> accites,
            int? liIteRecNo,
            int? liGanRecNo,
            decimal nuLoclAmt,
            decimal nuEuroAmt,
            decimal nuBaseAmt,
            EnumPostType siPstRecNo,
            PreInvInvoiceType stDbtCdt)
        {
            var newAccite = new DTOAccite
            {
                AitRecNo = (int)_acciteRepository.GetNextSequence(),
                AitAtrRecNo = _context.AccTrnFil.AtrRecNo,
                AitIteRecNo = liIteRecNo,
                AitAmount = nuLoclAmt,
                AitEuroAmount = nuEuroAmt,
                AitBaseAmount = nuBaseAmt,
                AitPstRecNo = (int)siPstRecNo,
                AitGanRecNo = liGanRecNo,
                AitDrCr = stDbtCdt == PreInvInvoiceType.CreditNote ? "C" : "D"
            };

            accites.Add(newAccite);

        }

        protected void WriteAccReChg(DTOUpdateInfo updateContext)
        {
            // If a 'Delivered To' customer exists in REPKFEECSTS.DB and the REPKFEERATES.DB
            // has at least one record for the Group record in REPKFEEGRPS.DB then add to
            // the table that is used to generate the journals for the re-packing fees.

            var recordsToProcess = _context.InvTotRecords.Where(z => z.WriteAccReChg && z.InvRecNo > 0).ToList();
            _accReChgRepository.ReserveSequenceRange(recordsToProcess.Count);
            foreach (var invTotRecord in recordsToProcess)
            {
                updateContext.AccReChgAdditions.Add
                (
                    new DTOAccReChg
                    {
                        ReChgRecNo = (int)_accReChgRepository.GetNextSequence(),
                        FromSalOffNo = _context.SalesOffice.SalesOfficeNumber,
                        ToSalOffNo = invTotRecord.AccntSalOffNo,
                        OrigAtrRecNo = invTotRecord.InvRecNo,
                        BatRecNo = -1
                    }
                );
            }
        }

        protected void WriteItechg(DTOUpdateInfo updateContext, int? liExcNo, int siCtyNo, int liNxtIchRecNo)
        {
            //todo: check liExcNo is not supposed to be not null in this context

            updateContext.IteChgAdditions.Add
            (
                new DTOIteChg
                {
                    IchRecNo = liNxtIchRecNo,
                    ExcRecNo = liExcNo,
                    CtyNo = siCtyNo,
                    IchAppAmt = _context.InvDiscTypRecord.DiscBaseAmt,
                    IchChaCalc = 1,
                    IchAppFac = 1,
                    DprRecNo = _context.InvPrt2Record.DprRecNo,
                    IchDisType = _context.InvDiscTypRecord.DiscSeqNo,
                    IchPcntOrRate = _context.InvDiscTypRecord.DiscRate,
                    IchRealDisType = _context.InvDiscTypRecord.DiscTyp,
                    IchOnPayment = _context.InvDiscTypRecord.DiscTyp.HasValue &&
                                   (_context.InvDiscTypRecord.DiscTyp.Value.GetStage() == EnumDiscTypesStage.OnPayment),
                    IchAuthAmm = _context.InvDiscTypRecord.DiscBaseAmt
                }
            );


            updateContext.IchDiscTypAdditions.Add
            (
                new DTOIchDiscTyp
                {
                    IchRecNo = liNxtIchRecNo,
                    DiscDedStr = _context.InvDiscTypRecord.DiscDetrStr,
                    DiscGrpGlRecNo = _context.InvDiscTypRecord.DiscGlRecNo
                }
            );

            updateContext.AuditRecordAdditions.Add
            (
                new DTOAuditRecord
                {
                    AuditRecordNo = (int)_auditRecordRepository.GetNextSequence(),
                    AuditTypeNo = 26,
                    AuditLinkRecNo1 = liNxtIchRecNo,
                    AuditLinkRecNo2 = _context.InvPrt2Record.DprRecNo,
                    AuditChangedFrom = "0.00",
                    AuditChangedTo = _context.InvDiscTypRecord.DiscBaseAmt.ToString("0.00", CultureInfo.InvariantCulture),
                    AuditActionNo = 1,
                    AuditDoneBy = _user.Id,
                    AuditFormName = _systemPreferences.FormName,
                    AuditFormNo = _systemPreferences.FormNo,
                    AuditDate = DateTime.Now
                }
            );
        }


        protected int UpdateBatch(DTOUpdateInfo updateContext, int extractSessionID, bool mergeLikePrices, PreInvInvoiceType invoiceType, PreInvBatchType batchType, ICollection<DTOInvTot> invTot, int batchNo)
        {
            var siPstRecNo = _sharedProcessingHelpers.GetPostTypeByInvoiceType(invoiceType);

            int? batchPstRecNo = null;
            EnumItem<EnumPostType> pstRecNoItem;
            Enums<EnumPostType>.TryGetItem(siPstRecNo, out pstRecNoItem);
            if (pstRecNoItem != null)
            {
                batchPstRecNo = (int)pstRecNoItem.IntValue;
            }

            var batch = new DTOBatch
            {
                BatRecNo = (int)_batchRepository.GetNextSequence(),
                BatchSalOffNo = _context.SalesOffice.SalesOfficeNumber,
                BatchNo = batchNo,
                BatchPstRecNo = batchPstRecNo,
                BatchInvPeriod = _sharedProcessingHelpers.GetInvoicePeriodTypeAsString(_context.InvExtractHead.InvoicePeriod, "Daily", "Daily+Wkly"),
                BatchInvType = batchType.ConvertToString(),
                BatchCutOffDate = _context.InvExtractHead.CutOffDeliveryDate,
                BatchTaxDate = _context.InvExtractHead.TaxPointDate,
                BatchMergeTrans = mergeLikePrices,
                BatchTimeStamp = DateTime.Now, //todo: timezone check offset
                BatchNetUserName = _user.UserName.Left(28)
            };

            updateContext.BatchAdditions.Add(batch);

            var invEdis = _invediRepository.GetByExtractSessionId(extractSessionID);

            foreach (var invTotRecord in invTot)
            {
                if (invTotRecord.IsEdiCst && invTotRecord.EIInvoiceId.HasValue)
                {
                    DTOEdiLogHeaderWide headerRecord = _context.EdiLogRecords.FirstOrDefault(z => z.EHHeadId.Equals(invTotRecord.EIInvoiceId));
                    if (headerRecord == null)
                    {
                        throw new FreshTradeException("Cannot identify the EdiLogHeader record");
                    }
                    _context.EHHeaderAr.Add(headerRecord.EHHeadId, batch.BatRecNo);
                }

                DTOInvEdi invEdi = null;
                if (invTotRecord.IsEdiCst)
                {
                    invEdi = invEdis.Where(i => (i.HofCstCode == invTotRecord.HofCstCode) && (i.PrcGlbRecNo == invTotRecord.PrcGlbRecNo)).FirstOrDefault();
                }

                var batchDet = new DTOBatchDet
                    {
                        BdtRecNo = (int)_batchDetRepository.GetNextSequence(),
                        BdtBatRecNo = batch.BatRecNo,
                        BdtInvRecNo = invTotRecord.InvRecNo,
                        BdtEdiFile = invEdi != null ? invEdi.Edifile : null,
                        BdtCurTotal = invTotRecord.StInvTotal.TrimEnd()
                    };

                updateContext.BatchDetAdditions.Add(batchDet);

            }

            // post validation logic skiipped due to transactional approach

            return batch.BatRecNo;
        }

        private void MarkDeliveryPriceAsInvoiced(DTOUpdateInfo updateContext, DTODeliveryPrice delPrice)
        {
            if (delPrice.DeliveryPriceStatus.IsInvoiced())
            {
                return;
            }
            var newStatus = delPrice.DeliveryPriceStatus.ToInvoiced();
            var delPriceUpdates = updateContext.DeliveryPriceUpdates.FirstOrDefault(x => x.New.Id == delPrice.Id);
            if (delPriceUpdates != null)
            {
                delPriceUpdates.New.DeliveryPriceStatus = newStatus;
            }
            else
            {
                DTODeliveryPrice originalDeliveryPriceRecord = ObjectHandling.CloneDTO(delPrice);
                delPrice.DeliveryPriceStatus = newStatus;
                updateContext.DeliveryPriceUpdates.Add(new UpdatePair<DTODeliveryPrice>(originalDeliveryPriceRecord, delPrice));
            }
        }

        protected void UpdateStatus(DTOUpdateInfo updateContext, List<DTOOrder> allOrders, List<DTOInvPrt> allInvPrtRecords, List<DTODeliveryHead> allAffectedDelHeds, List<DTODeliveryDetail> allAffectedDelDetails, List<DTODeliveryPrice> allDeliveryPrices)
        {
            var orderIds = allInvPrtRecords.Select(z => z.OrdRecNo != null ? z.OrdRecNo.Value : 0).Distinct().ToList();
            var affectedDelHeds = allAffectedDelHeds.Where(i => i.OrderId.HasValue && orderIds.Contains(i.OrderId.Value)).ToList();
            var affectedDelHedIds = affectedDelHeds.Select(z => z.Id).ToList();
            var affectedDelDetails = allAffectedDelDetails.Where(i => i.DeliveryHeadId.HasValue && affectedDelHedIds.Contains(i.DeliveryHeadId.Value)).ToList();

            /*
             Go thru each extracted Delhed and see if this
             Orders rec no exists in the dyn array. If it does
             then the Orders record has already been updated.        }
            */
            foreach (int ordNo in orderIds)
            {
                var delHeds = affectedDelHeds.Where(z => z.OrderId.Equals(ordNo)).ToList();

                bool lAllDelhedsInvoiced = true;
                //Go thru each Delhed for Order.
                foreach (var delHedItem in delHeds)
                {
                    var delDetails = affectedDelDetails.Where(z => z.DeliveryHeadId.Equals(delHedItem.Id)).ToList();
                    // Go thru each Deldet for Delhed.
                    bool lAllDeldetsInvoiced = true;
                    foreach (DTODeliveryDetail delDetail in delDetails)
                    {
                        var delPrices = allDeliveryPrices.Where(z => z.DeliveryDetailId.Equals(delDetail.Id)).ToList();
                        if ((delDetail.Quantity == 0) && (delDetail.DeliveryStatus == DTODeliveryStatus.Released))
                        {
                            UpdateDeliveryDetail(updateContext, delDetail);
                        }
                        else
                        {
                            if (
                                    (delDetail.DeliveryStatus != DTODeliveryStatus.Invoiced) &&
                                    (delDetail.DeliveryStatus != DTODeliveryStatus.Released) &&
                                    (!delHedItem.IsOpenPriceDelivery)
                               )
                            {
                                lAllDeldetsInvoiced = false;
                                lAllDelhedsInvoiced = false;
                            }
                            else
                            {
                                bool lAllDelPricesInvoiced = true;
                                if (
                                        (delDetail.DeliveryStatus == DTODeliveryStatus.Released) ||
                                        ((delDetail.DeliveryStatus == DTODeliveryStatus.Delivered) && delHedItem.IsOpenPriceDelivery)
                                   )
                                {
                                    // Go thru each Delprice for Deldet.
                                    //var delAuditCounts = delPrices.Where(z => !z.DeliveryPriceStatus.IsInvoiced()).Count();
                                    //_delAuditRecordRepository.ReserveSequenceRange(delAuditCounts); These delPrice Autils should be rather seldom, so no need to reserve range here
                                    foreach (DTODeliveryPrice delPriceItem in delPrices)
                                    {
                                        if (
                                              (delPriceItem.Quantity == 0) &&
                                              (Math.Abs(delPriceItem.NettValue) < 0.001M)
                                           )
                                        {
                                            if (!delPriceItem.DeliveryPriceStatus.IsInvoiced()) // < 11
                                            {
                                                updateContext.DelAuditRecordAdditions.Add
                                                    (
                                                        new DTODelAuditRecord
                                                            {
                                                                Id = (int)_delAuditRecordRepository.GetNextSequence(),
                                                                DelAudTyp = 32,
                                                                DelAudFrom = ((int?)delPriceItem.DeliveryPriceStatus).ToString(),
                                                                DelAudTo = ((int?)delPriceItem.DeliveryPriceStatus.ToInvoiced()).ToString(),
                                                                DelAudDelRecNo = delPriceItem.DeliveryDetailId,
                                                                DprRecNo = delPriceItem.Id,
                                                                DelAudDate = DateTime.Now,
                                                                FormNo = _systemPreferences.FormNo,
                                                                FormName = _systemPreferences.FormName,
                                                                LogonNo = _user.Id
                                                            }
                                                    );
                                                MarkDeliveryPriceAsInvoiced(updateContext, delPriceItem);
                                                //No need to add delPriceItem to update list here, as it was alredy taken from update list
                                            }
                                        }
                                        else
                                        {
                                            // ;This code moved to else so zero value delprices would not
                                            // ;trigger a Bad Status (cos they have no invoice number) TV 16Dec99

                                            bool isDelPriceInvoiced = delPriceItem.DeliveryPriceStatus.IsInvoiced();
                                            if (
                                                (((delPriceItem.InvoiceId ?? 0) != 0) && !isDelPriceInvoiced) || // < 11
                                                (((delPriceItem.InvoiceId ?? 0) == 0) && isDelPriceInvoiced) // > 10
                                                )
                                            {
                                                throw new FreshTradeException(String.Format("Bad Status for {0}", delPriceItem.Id));
                                            }
                                            if (!isDelPriceInvoiced) // < 11
                                            {
                                                lAllDelPricesInvoiced = false;
                                                lAllDeldetsInvoiced = false;
                                                lAllDelhedsInvoiced = false;
                                                break;
                                            }
                                        }
                                    } // / DTODeliveryPrice delPriceItem in delPrices
                                }
                                if (lAllDelPricesInvoiced)
                                {
                                    UpdateDeliveryDetail(updateContext, delDetail);
                                }
                            }
                        }
                    } // / DTODeliveryDetail delDetail in delDetails

                    if (lAllDeldetsInvoiced)
                    {
                        DTODeliveryHead newDelHeadItem = ObjectHandling.CloneDTO(delHedItem);
                        newDelHeadItem.DeliveryStatus = DTODeliveryStatus.Invoiced;
                        //todo: to enum and helper method
                        if (delHedItem.TranInd < 10)
                        {
                            newDelHeadItem.TranInd = newDelHeadItem.TranInd + 10;
                        }
                        updateContext.DeliveryHeadUpdates.Add(new UpdatePair<DTODeliveryHead>(delHedItem, newDelHeadItem));

                        DTODeliveryDetail firstDetailInSeq = delDetails.FirstOrDefault(); //SR20090903 delhed status change links to first deldet, not to delhed.
                        if (firstDetailInSeq != null) //Suspicious code, but porting as it was
                        {
                            updateContext.DelAuditRecordAdditions.Add
                            (
                                new DTODelAuditRecord
                                {
                                    Id = (int)_delAuditRecordRepository.GetNextSequence(),
                                    DelAudTyp = 15,
                                    DelAudFrom = ((int?)delHedItem.DeliveryStatus).ToString(),
                                    DelAudTo = ((int?)DTODeliveryStatus.Invoiced).ToString(),
                                    DelAudDelRecNo = firstDetailInSeq.Id,
                                    DprRecNo = null,
                                    DelAudDate = DateTime.Now,
                                    FormNo = _systemPreferences.FormNo,
                                    FormName = _systemPreferences.FormName,
                                    LogonNo = _user.Id
                                }
                            );
                        }
                    }
                } // / delHedItem in invoiceDelHeds

                if (lAllDelhedsInvoiced) //all delheds for Order must be invoiced
                {
                    var order = allOrders.FirstOrDefault(i => i.Id == ordNo);
                    if (order == null)
                    {
                        throw new FreshTradeException(string.Format("Order with OrdRecNo = {0} was not found", ordNo));
                    }
                    if (!order.AccountClassId.HasValue)
                    {
                        throw new FreshTradeException(string.Format("Order with OrdRecNo = {0} has unknown customer", ordNo));
                    }

                    // The code below is telling us that if all the deliveries for this order is invoiced then locate the order 
                    // record number in the Orders table and blank out the Orders.OrdCstCode field. This is done to identify within 
                    // fresh trade that this order has now been invoiced

                    //dynFieldChanges["OrdCstCode"]= String(blank())
                    updateContext.OrderCleanAccountClassID.Add(order);
                }

            } // / int ordNo in invPrtInvoiceNumbers
        }

        private void UpdateDeliveryDetail(DTOUpdateInfo updateContext, DTODeliveryDetail delDetail)
        {
            Debug.Assert(delDetail.DeliveryStatus.HasValue); //Should always be called from context when DeliveryStatus is set
            // 1) Write delaudit record
            updateContext.DelAuditRecordAdditions.Add
                (
                    new DTODelAuditRecord
                        {
                            Id = (int)_delAuditRecordRepository.GetNextSequence(),
                            DelAudTyp = 5,
                            DelAudFrom = ((int?)delDetail.DeliveryStatus).ToString(),
                            DelAudTo = ((int?)DTODeliveryStatus.Invoiced).ToString(),
                            DelAudDelRecNo = delDetail.Id,
                            DprRecNo = null,
                            DelAudDate = DateTime.Now,
                            FormNo = _systemPreferences.FormNo,
                            FormName = _systemPreferences.FormName,
                            LogonNo = _user.Id
                        }
                );
            // 2) Update DelDet
            //updateDelDet(true)
            var newDelDetail = ObjectHandling.CloneDTO(delDetail);
            newDelDetail.DeliveryStatus = DTODeliveryStatus.Invoiced;
            updateContext.DeliveryDetailUpdates.Add(new UpdatePair<DTODeliveryDetail>(delDetail, newDelDetail));
        }

        private void ReserveExpChaKeys(List<DTOInvTot> allInvTotRecord)
        {
            if (!_context.ExpChaKeysReserved)
            {
                int keyCount = allInvTotRecord.Count(i => Math.Abs(i.OnInvDscnt) > 0.001M);
                keyCount += allInvTotRecord.Count(i => ((Math.Abs(i.OffInvRbt) > .001M) || (Math.Abs(i.OffInvOnPay) > .001M)));
                if (keyCount > 0)
                {
                    _expChaRepository.ReserveSequenceRange(keyCount);
                }

                _context.ExpChaKeysReserved = true;
            }
        }

        protected void UpdateItechg(DTOUpdateInfo updateContext, List<DTOInvDiscTyp> allInvDiscTypRecords, List<DTOIteChg> allIteChgItems)
        {
            var invTotRecord = _context.InvTotRecord;
            //If you modify following conditions - please check ReserveExpChaKeys as well
            if (Math.Abs(invTotRecord.OnInvDscnt) > 0.001M)
            {
                _context.LastDscExpRec = WriteExpcha(updateContext, 97, invTotRecord.OnInvDscnt, invTotRecord.EuroOnInvDscnt, invTotRecord.BaseOnInvDscnt);
            }
            else
            {
                _context.LastDscExpRec = null;
            }

            //If you modify following conditions - please check ReserveExpChaKeys as well
            if ((Math.Abs(invTotRecord.OffInvRbt) > .001M) || (Math.Abs(invTotRecord.OffInvOnPay) > .001M))
            {
                _context.LastRbtExpRec = WriteExpcha(updateContext, 98,
                    invTotRecord.OffInvRbt + invTotRecord.OffInvOnPay,
                    invTotRecord.EuroOffInvRbt + invTotRecord.EuroOffInvOnPay,
                    invTotRecord.BaseOffInvRbt + invTotRecord.BaseOffInvOnPay);
            }
            else
            {
                _context.LastRbtExpRec = null;
            }

            foreach (var invPrt2Record in _context.InvPrt2Records)
            {
                decimal nuTotCom = 0;
                decimal nuTotDsc = 0;
                decimal nuTotRbt = 0;
                decimal nuTotNewDsc = 0;
                decimal nuTotNewRbt = 0;
                int? discountGanRecNo = -1;
                _context.InvPrt2Record = invPrt2Record;

                var iteChgItems = allIteChgItems.Where(i => (i.DprRecNo == invPrt2Record.DprRecNo) && (i.CtyNo >= 96) && (i.CtyNo <= 98)).ToList();
                foreach (var iteChgItem in iteChgItems)
                {
                    switch (iteChgItem.CtyNo)
                    {
                        case 96:
                            {
                                nuTotCom = nuTotCom + iteChgItem.IchAppAmt;
                                break;
                            }
                        case 97:
                            {
                                nuTotDsc = nuTotDsc + iteChgItem.IchAppAmt;
                                break;
                            }
                        case 98:
                            {
                                nuTotRbt = nuTotRbt + iteChgItem.IchAppAmt;
                                break;
                            }
                    }

                    updateContext.IteChgDeletions.Add(iteChgItem);

                    var audit = new DTOAuditRecord
                    {
                        AuditRecordNo = (int)_auditRecordRepository.GetNextSequence(),
                        AuditTypeNo = 26,
                        AuditLinkRecNo1 = iteChgItem.IchRecNo,
                        AuditLinkRecNo2 = iteChgItem.DprRecNo.Value,
                        AuditChangedFrom = iteChgItem.IchAppAmt.ToString("0.00", CultureInfo.InvariantCulture),
                        AuditChangedTo = "0.00",
                        AuditActionNo = 2,
                        AuditDoneBy = _user.Id,
                        AuditFormName = _systemPreferences.FormName,
                        AuditFormNo = _systemPreferences.FormNo,
                        AuditDate = DateTime.Now
                    };
                    updateContext.AuditRecordAdditions.Add(audit);
                    //It was agreed to skip BSDLUtils.postAutoCostsRec(blank(), tc["IteChg"].DprRecNo, false) for now
                } // /iteChgItem in iteChgItems

                if (Math.Abs(invPrt2Record.OnInvDscnt) > 0.001M)
                {
                    //; Check we have a 'Discount' GanRecNo.
                    discountGanRecNo = GetDiscountGangRecNo(_context.InvTotRecord.AccntSalOffNo, invPrt2Record.PrdGlAnl);
                    if (discountGanRecNo == null)
                    {
                        throw new FreshTradeException("Should never get here as the array is checked in lUpdate()");
                    }
                }

                var invDiscTypItems = allInvDiscTypRecords.Where(i => (i.DlvInvoiceNo == invTotRecord.InvoiceNo) && (i.RecNo == invPrt2Record.Recno)).ToList();

                var siNoRecsReq = invDiscTypItems.Count();
                if (siNoRecsReq > 0)
                {
                    if (
                        (Math.Abs(invPrt2Record.OffInvRbt) > 0.001M) ||
                        (Math.Abs(invPrt2Record.OffInvOnPay) > 0.001M)
                        )
                    {
                        siNoRecsReq = siNoRecsReq * 2;
                    }

                    //lUpdateAccCntrl("AccIte", siNoRecsReq, liNxtAitRecNo)
                    _acciteRepository.ReserveSequenceRange(siNoRecsReq);
                    _auditRecordRepository.ReserveSequenceRange(invDiscTypItems.Count());

                    foreach (var invDiscTypItem in invDiscTypItems)
                    {
                        // Utilslib.GetWizNxtRecNo(FormName,String("ContIchNo"),1)                        
                        _context.InvDiscTypRecord = invDiscTypItem;
                        var liNxtIchRecNo = (int)_iteChgRepository.GetNextSequence();
                        var baseDscnt = invDiscTypItem.DiscBaseAmt;
                        var toForeign = invDiscTypItem.DiscLoclAmt;
                        var toEuro = invDiscTypItem.DiscEuroAmt;
                        PreInvInvoiceType stCorD = invDiscTypItem.DiscBaseAmt < 0.0M ? PreInvInvoiceType.CreditNote : PreInvInvoiceType.DebitNote;

                        if (invDiscTypItem.DiscTyp.HasValue && (invDiscTypItem.DiscTyp.Value.GetStage() == EnumDiscTypesStage.OnInvoice))
                        {
                            nuTotNewDsc = nuTotNewDsc + baseDscnt;
                            WriteAccite
                                (
                                    updateContext.AcciteAdditions,
                                    liNxtIchRecNo,
                                    discountGanRecNo,
                                    Math.Abs(toForeign),
                                    Math.Abs(toEuro),
                                    Math.Abs(baseDscnt),
                                    EnumPostType.GLREBPROPSTRECNO,
                                    stCorD
                                );
                            WriteItechg(updateContext, _context.LastDscExpRec, 97, liNxtIchRecNo);
                        }
                        else
                        {
                            nuTotNewRbt = nuTotNewRbt + baseDscnt;
                            var rebPlGanRecNo = GetRebPnLGangRecNo(_context.InvTotRecord.AccntSalOffNo, invPrt2Record.PrdGlAnl, invDiscTypItem.DiscGlRecNo);
                            if (rebPlGanRecNo == null)
                            {
                                throw new FreshTradeException("Should never get here as the array is checked in lUpdate().");
                            }

                            // Check we have a 'RebP&L' GanRecNo.
                            WriteAccite(
                                updateContext.AcciteAdditions,
                                liNxtIchRecNo,
                                rebPlGanRecNo,
                                Math.Abs(toForeign),
                                Math.Abs(toEuro),
                                Math.Abs(baseDscnt),
                                EnumPostType.GLREBPROPSTRECNO,
                                stCorD
                                );

                            //  Check we have a 'RebBal' GanRecNo.
                            var rebBalGanRecNo = GetRebBalGangRecNo(_context.InvTotRecord.AccntSalOffNo, invPrt2Record.PrdGlAnl, invDiscTypItem.DiscGlRecNo);
                            if (rebBalGanRecNo == null)
                            {
                                throw new FreshTradeException("Should never get here as the array is checked in lUpdate().");
                            }

                            stCorD = invDiscTypItem.DiscBaseAmt < 0 ? PreInvInvoiceType.DebitNote : PreInvInvoiceType.CreditNote;

                            WriteAccite(
                                updateContext.AcciteAdditions,
                                liNxtIchRecNo,
                                rebBalGanRecNo,
                                Math.Abs(toForeign),
                                Math.Abs(toEuro),
                                Math.Abs(baseDscnt),
                                EnumPostType.GLREBBALPSTRECNO,
                                stCorD
                                );

                            WriteItechg(updateContext, _context.LastRbtExpRec, 98, liNxtIchRecNo);

                        } // / invDiscTypItem.Disctyp in (1, 101, 201)
                    } // / invDiscTypItem in invDiscTypItems
                    _context.InvDiscTypRecord = null;
                }

                if (Math.Abs(nuTotDsc - nuTotNewDsc) > 0.001M)
                {
                    updateContext.DelAuditRecordAdditions.Add
                    (
                        new DTODelAuditRecord
                        {
                            Id = (int)_delAuditRecordRepository.GetNextSequence(),
                            DelAudTyp = 36,
                            DelAudFrom = nuTotDsc.ToString(CultureInfo.InvariantCulture),
                            DelAudTo = nuTotNewDsc.ToString(CultureInfo.InvariantCulture),
                            DelAudDelRecNo = invPrt2Record.DelRecNo,
                            DprRecNo = invPrt2Record.DprRecNo,
                            DelAudDate = DateTime.Now,
                            FormNo = _systemPreferences.FormNo,
                            FormName = _systemPreferences.FormName,
                            LogonNo = _user.Id
                        }
                    );
                }

                if (Math.Abs(nuTotRbt - nuTotNewRbt) > 0.001M)
                {
                    updateContext.DelAuditRecordAdditions.Add
                    (
                        new DTODelAuditRecord
                        {
                            Id = (int)_delAuditRecordRepository.GetNextSequence(),
                            DelAudTyp = 37,
                            DelAudFrom = nuTotRbt.ToString(CultureInfo.InvariantCulture),
                            DelAudTo = nuTotNewRbt.ToString(CultureInfo.InvariantCulture),
                            DelAudDelRecNo = invPrt2Record.DelRecNo,
                            DprRecNo = invPrt2Record.DprRecNo,
                            DelAudDate = DateTime.Now,
                            FormNo = _systemPreferences.FormNo,
                            FormName = _systemPreferences.FormName,
                            LogonNo = _user.Id
                        }
                    );
                }
            } // invPrt2Record in _context.invPrt2Records
            _context.InvPrt2Record = null;
        }

        protected int WriteExpcha(DTOUpdateInfo updateContext, int? siCtyNo, decimal nuRawAmt, decimal nuEuroAmt, decimal nuBaseAmt)
        {
            Debug.Assert(_context.InvTotRecord.CurNo != null, "_context.invTotRecord.CurNo != null");
            var expCha = new DTOExpCha
            {
                ExcChaRec = (int)_expChaRepository.GetNextSequence(),
                ExcCtyNo = siCtyNo,
                ExcCurrNo = _context.InvTotRecord.CurNo.Value,
                ExcToEuroExcRate = _context.InvTotRecord.EuroRate,
                ExcToBaseRate = _context.InvTotRecord.BaseRate,
                Triangulated = _context.InvTotRecord.TriangReq,
                ExcRawAmm = nuRawAmt,
                ExcConAmm = nuBaseAmt,
                ExcEuroAmm = nuEuroAmt,
                ExcAtrRecNo = _context.AccTrnFil.AtrRecNo,
                ExcSenCode = _context.InvPrtRecord.HofClaRecNo,
                ExcChgCalc = 1,
                ExcAuthRawAmm = nuRawAmt,
                ExcAuthConAmm = nuBaseAmt,
                ExcAuthEuroAmm = nuEuroAmt,
                ExcFullyAuth = 2
            };
            updateContext.ExpChaAdditions.Add(expCha);
            return expCha.ExcChaRec;
        }

        protected int? GetDebtorGangRecNo(int? stAccntSalOffNo, int? accGlAnl = null)
        {
            var result = _sharedProcessingHelpers.GetGLCode(new DTOGLLookupParams
             {
                 LookupType = PreInvGLLookupType.Debtors,
                 SalesOfficeNo = stAccntSalOffNo,
                 AccountGLType = accGlAnl
             }, null);
            if (result == 0)
            {
                return null;
            }
            return result;
        }

        protected int? GetDiscountGangRecNo(int? stAccntSalOffNo, int? prdGlAnl = null)
        {
            var result = _sharedProcessingHelpers.GetGLCode(new DTOGLLookupParams
            {
                LookupType = PreInvGLLookupType.Discount,
                SalesOfficeNo = stAccntSalOffNo,
                ProductAnalysisGroup = prdGlAnl
            }, null);
            if (result == 0)
            {
                return null;
            }
            return result;

        }

        protected int? GetRebBalGangRecNo(int? stAccntSalOffNo, int? prdGlAnl = null, int? discGLRecNo = null)
        {
            var result = _sharedProcessingHelpers.GetGLCode(new DTOGLLookupParams
            {
                LookupType = PreInvGLLookupType.RebateBalance,
                SalesOfficeNo = stAccntSalOffNo,
                ProductAnalysisGroup = prdGlAnl,
                DiscountRebateGLNo = discGLRecNo
            }, null);
            if (result == 0)
            {
                return null;
            }
            return result;
        }

        protected int? GetRebPnLGangRecNo(int? stAccntSalOffNo, int? prdGlAnl = null, int? discGLRecNo = null)
        {
            var result = _sharedProcessingHelpers.GetGLCode(new DTOGLLookupParams
            {
                LookupType = PreInvGLLookupType.RebateProfitAndLoss,
                SalesOfficeNo = stAccntSalOffNo,
                ProductAnalysisGroup = prdGlAnl,
                DiscountRebateGLNo = discGLRecNo
            }, null);
            if (result == 0)
            {
                return null;
            }
            return result;
        }

        protected int? GetSalesGanRecNo(int? stAccntSalOffNo, int? accGlAnl = null, int? prdGlAnl = null)
        {
            var result = _sharedProcessingHelpers.GetGLCode(new DTOGLLookupParams
            {
                LookupType = PreInvGLLookupType.Sales,
                SalesOfficeNo = stAccntSalOffNo,
                AccountGLType = accGlAnl,
                ProductAnalysisGroup = prdGlAnl
            }, null);
            if (result == 0)
            {
                return null;
            }
            return result;
        }

        protected int? GetVatGanRecNo(int? stAccntSalOffNo, int? vatRecID = null, int? vatType = null)
        {
            var result = _sharedProcessingHelpers.GetGLCode(new DTOGLLookupParams
            {
                LookupType = PreInvGLLookupType.VAT,
                SalesOfficeNo = stAccntSalOffNo,
                VatRecId = vatRecID,
                VatType = vatType
            }, null);
            if (result == 0)
            {
                return null;
            }
            return result;
        }


        public UpdateProcessor
        (SystemPreferences systemPreferences, IUnitOfWork unitOfWorkCurrent, IDTOUser user)
        {
            _systemPreferences = systemPreferences;
            _unitOfWorkCurrent = unitOfWorkCurrent;
            _salesOfficeRepository = _unitOfWorkCurrent.GetRepository<ISalesOfficeRepository>();
            _accountClassRepository = _unitOfWorkCurrent.GetRepository<IAccountClassRepository>();
            _accountRepository = _unitOfWorkCurrent.GetRepository<IAccountRepository>();
            _glInfoRepository = _unitOfWorkCurrent.GetRepository<IGLInfoRepository>();

            _acciteRepository = _unitOfWorkCurrent.GetRepository<IAcciteRepository>();
            _invTotRepository = _unitOfWorkCurrent.GetRepository<IInvTotRepository>();
            _invPrtRepository = _unitOfWorkCurrent.GetRepository<IINVPRTRepository>();
            _invPrt2Repository = _unitOfWorkCurrent.GetRepository<IInvPrt2Repository>();
            _invDiscTypRepository = _unitOfWorkCurrent.GetRepository<IInvDiscTypRepository>();
            _invExtractHedRepository = _unitOfWorkCurrent.GetRepository<IInvExtractHedRepository>();

            _accTrnFilRepository = _unitOfWorkCurrent.GetRepository<IAccTrnFilRepository>();
            _accVatRepository = _unitOfWorkCurrent.GetRepository<IAccVATRepository>();
            _accAllValRepository = _unitOfWorkCurrent.GetRepository<IAccAllValRepository>();
            _accAllocRepository = _unitOfWorkCurrent.GetRepository<IAccAllocRepository>();
            _postTypeRepository = _unitOfWorkCurrent.GetRepository<IPostTypeRepository>();
            _deliveryPriceRepository = _unitOfWorkCurrent.GetRepository<IDeliveryPriceRepository>();
            _expChaRepository = _unitOfWorkCurrent.GetRepository<IExpChaRepository>();
            _iteChgRepository = _unitOfWorkCurrent.GetRepository<IIteChgRepository>();
            _orderRepository = _unitOfWorkCurrent.GetRepository<IOrderRepository>();
            _deliveryHeadRepository = _unitOfWorkCurrent.GetRepository<IDeliveryHeadRepository>();
            _deliveryDetailRepository = _unitOfWorkCurrent.GetRepository<IDeliveryDetailRepository>();
            _accReChgRepository = _unitOfWorkCurrent.GetRepository<IAccReChgRepository>();
            _batchRepository = _unitOfWorkCurrent.GetRepository<IBatchRepository>();
            _batchDetRepository = _unitOfWorkCurrent.GetRepository<IBatchDetRepository>();
            _ediLogInvoiceRepository = _unitOfWorkCurrent.GetRepository<IEdiLogInvoiceRepository>();
            _auditRecordRepository = _unitOfWorkCurrent.GetRepository<IAuditRecordRepository>();
            _delAuditRecordRepository = _unitOfWorkCurrent.GetRepository<IDelAuditRecordRepository>();
            _invediRepository = _unitOfWorkCurrent.GetRepository<IINVEDIRepository>();
            _ichDiscTypRepository = _unitOfWorkCurrent.GetRepository<IIchDiscTypRepository>();
            _delAudToDoRecordRepository = _unitOfWorkCurrent.GetRepository<IDelAudToDoRecordRepository>();
            _sharedProcessingHelpers = new SharedProcessingHelpers(_glInfoRepository);
            _invoiceTypeToBatchTypeMapping = _sharedProcessingHelpers.GetInvoiceTypeToBatchTypeMapping();

            _user = user;
            _logger = LogManager.GetLoggerFor<UpdateProcessor>();
            ProgressChanged += (x) => { };
        }

        private void ValidateInvTempData
        (
            DTOPreInvUpdateParams updateParams,
            IEnumerable<DTOInvTot> invTotRecords,
            IEnumerable<DTOInvPrt> invPrtRecords,
            IEnumerable<DTOInvPrt2> invPrt2Records
        )
        {
            var realInvTotIds = invTotRecords.Select(i => i.OriginalInvoiceNo).OrderBy(i => i).ToList();
            var requiredInvTotIds = updateParams.SelectedPreInvTot.OrderBy(i => i).ToList();
            var realInvPrtIds = invPrtRecords.Select(i => i.DlvOrdNo).OrderBy(i => i).ToList();
            var requiredInvPrtIds = updateParams.SelectedPreInvPrt.OrderBy(i => i).ToList();
            var realInvPrt2Ids = invPrt2Records.Select(i => i.DelRecNo).OrderBy(i => i).ToList();
            var requiredInvPrt2Ids = updateParams.SelectedPreInvPrt2.OrderBy(i => i).ToList();

            var lstatus = 0;

            if (
                (realInvTotIds.Count != requiredInvTotIds.Count) ||
                (realInvPrtIds.Count != requiredInvPrtIds.Count) ||
                (realInvPrt2Ids.Count != requiredInvPrt2Ids.Count)
                )
            {
                lstatus = 1;
            }
            // comparing each value of the lists
            if
              (
                lstatus == 0 &&
                (realInvTotIds.Where((t, i) => t != requiredInvTotIds[i]).Any())
              )
            {
                lstatus = 2;
            }

            if
              (
                lstatus == 0 &&
                (realInvPrtIds.Where((t, i) => t != requiredInvPrtIds[i]).Any())
              )
            {
                lstatus = 3;
            }

            if
              (
                lstatus == 0 &&
                (realInvPrt2Ids.Where((t, i) => t != requiredInvPrt2Ids[i]).Any())
              )
            {
                lstatus = 4;
            }

            if (lstatus == 0) return; // All is fine
            var ltext = new StringBuilder();
            switch (lstatus)
            {
                case 1:
                    ltext.Append("Count of Update items are not equal ");
                    GetCountDifferenceDescription(ltext, realInvTotIds, requiredInvTotIds, "Invoice");
                    GetCountDifferenceDescription(ltext,
                       realInvPrtIds.Where(i => i.HasValue).Select(i => i.Value).ToList(),
                       requiredInvPrtIds, "Delivery No");
                    GetCountDifferenceDescription(ltext,
                        realInvPrt2Ids.Where(i => i.HasValue).Select(i => i.Value).ToList(),
                        requiredInvPrt2Ids, "Delivery Rec No");
                    break;
                case 2:
                    GetDifferenceDescription(ltext, realInvTotIds, requiredInvTotIds, "Invoice");
                    break;
                case 3:
                    GetDifferenceDescription(ltext,
                       realInvPrtIds.Where(i => i.HasValue).Select(i => i.Value).ToList(),
                       requiredInvPrtIds, "Delivery No");
                    break;
                case 4:
                    GetDifferenceDescription(ltext,
                        realInvPrt2Ids.Where(i => i.HasValue).Select(i => i.Value).ToList(),
                        requiredInvPrt2Ids, "Delivery Rec No");
                    break;
            }
            _logger.Error(ltext.ToString());

            throw new FreshTradeException("Update data differs to the printed data." + Environment.NewLine + ltext);
        }

        private void GetCountDifferenceDescription<T>(StringBuilder ltext, List<T> realIds, List<T> requiredIds, string entityName)
        {
            if (realIds.Count != requiredIds.Count)
            {
                ltext.AppendLine(entityName);
                List<T> difference;
                if (realIds.Count > requiredIds.Count)
                {
                    ltext.Append("real Items are more than required on ");
                    ltext.Append(realIds.Count - requiredIds.Count);
                    difference = realIds.Except(requiredIds).ToList();
                }
                else
                {
                    ltext.Append("required Items are more than real on ");
                    ltext.Append(requiredIds.Count - realIds.Count);
                    difference = requiredIds.Except(realIds).ToList();
                }
                ltext.AppendLine();
                ltext.AppendLine("Items: ");
                ltext.AppendLine(difference.Select(i => i.ToString()).ToList().Aggregate((i, j) => i + "," + j));
            }
        }

        private void GetDifferenceDescription<T>(StringBuilder ltext, List<T> realIds, List<T> requiredIds, string entityName)
        {
            ltext.Append("Content differs for");
            ltext.AppendLine(entityName);
            var difference = realIds.Except(requiredIds).ToList();
            difference.AddRange(requiredIds.Except(realIds).ToList());

            ltext.AppendLine();
            ltext.AppendLine("Items: ");
            ltext.AppendLine(difference.Select(i => i.ToString()).ToList().Aggregate((i, j) => i + "," + j));
        }

        private void StoreDeliveryAudits(DTOUpdateInfo updateInfo)
        {
            _delAuditRecordRepository.Debug("pre");
            _delAuditRecordRepository.Add(updateInfo.DelAuditRecordAdditions);
            _delAuditRecordRepository.Debug("post");

            var delAuditToDoItems = updateInfo.DelAuditRecordAdditions.Where(a => a.DprRecNo > 0)
                .Select(a => new DTODelAudToDo() { DelAuditID = a.Id, UpdateIndicator = true }).ToList();

            _delAudToDoRecordRepository.Debug("pre");
            _delAudToDoRecordRepository.Add(delAuditToDoItems);
            _delAudToDoRecordRepository.Debug("post");

            if (_systemPreferences.UseAutoCosting)
            {
                var delPricesForCostingIds =
                    updateInfo.DelAuditRecordAdditions.Where(
                        a => (a.DelAudTyp == 128) && a.DprRecNo.HasValue && (a.DprRecNo.Value > 0))
                        .Select(i => i.DprRecNo.Value)
                        .ToList();
                _deliveryPriceRepository.EnqueueForCosting(delPricesForCostingIds);
            }
        }

        public PreInvUpdateStatusType Update(DTOPreInvUpdateParams updateParams, int extractSessionID)
        {
            if (updateParams.SelectedPreInvTot.Count == 0)
            {
                throw new FreshTradeException("Please select at least one invoice");
            }

            var updateInfo = new DTOUpdateInfo
            {
                AccAlloc = new List<DTOAccAlloc>(),
                AccTrnFilAdditions = new List<DTOAccTrnFil>(),
                AcciteAdditions = new List<DTOAccite>(),
                AccVatAdditions = new List<DTOAccVAT>(),
                AccReChgAdditions = new List<DTOAccReChg>(),
                BatchAdditions = new List<DTOBatch>(),
                BatchDetAdditions = new List<DTOBatchDet>(),
                AccAllValAdditions = new List<DTOAccAllVal>(),
                ExpChaAdditions = new List<DTOExpCha>(),
                IchDiscTypAdditions = new List<DTOIchDiscTyp>(),
                IteChgAdditions = new List<DTOIteChg>(),


                DeliveryPriceUpdates = new List<UpdatePair<DTODeliveryPrice>>(),
                DeliveryHeadUpdates = new List<UpdatePair<DTODeliveryHead>>(),
                DeliveryDetailUpdates = new List<UpdatePair<DTODeliveryDetail>>(),
                AccTrnFilUpdates = new List<UpdatePair<DTOAccTrnFil>>(),

                AuditRecordAdditions = new List<DTOAuditRecord>(),
                DelAuditRecordAdditions = new List<DTODelAuditRecord>(),
                SalesOfficeUpdate = null,

                IteChgDeletions = new List<DTOIteChg>(),

                OrderCleanAccountClassID = new List<DTOOrder>()

            };
            _context = null;
            _context = new UpdateExecutionContext
            {
                InvBaseDscTot = 0,
                InvBaseOnPTot = 0,
                InvBaseRbtTot = 0,
                dyPstDrCr = _postTypeRepository.GetPstDrCrMapping(),
                EHHeaderAr = new Dictionary<int, int>(),
                EIInvoiceIDs = null,
                EdiLogRecords = null,
                EDIFilesDyAr = new List<Tuple<string, int>>()
            };

            ProgressChanged(0);

            _context.InvExtractHead = _invExtractHedRepository.GetInvExtractHeadByExtractionSessionId(extractSessionID);

            #region TODO: EDI part
            //; if there is EDI information then extract the flat files.
            /*if lIsEdiInv
            then
               if Not lUpdateEdi()
               then
                  LDoEDI = False

                  if msgQuestion(Utilslib.GetTransMessage(1034), Utilslib.GetTransMessage(1035))
            {"EDI file not generated", "Select 'Yes' to Abort the Update.\nSelect 'No' to continue the Update."}
             = "Yes"
                  then
                     return ( false )
                  endIf
               endIf
            endIf*/
            #endregion
            _context.SalesOffice = _salesOfficeRepository.GetSalesOfficeByNo(_context.InvExtractHead.SalesOfficeNo, true);
            if (_context.SalesOffice == null)
            {
                throw new FreshTradeException(String.Format("Can't locate Sales Office <{0}>!", _context.InvExtractHead.SalesOfficeNo));
            }

            _context.InvTotRecords = _invTotRepository.GetByExtractSessionID(extractSessionID);

            //extract EdiLog records for further processing (validation, updateBatch)
            _context.EIInvoiceIDs = _context.InvTotRecords.Where(z => z.IsEdiCst && z.EIInvoiceId != null).Select(z => z.EIInvoiceId != null ? z.EIInvoiceId.Value : 0).ToList();
            _context.EdiLogRecords = _ediLogInvoiceRepository.GetEdiLogHeaderWideRecordsByInvoiceIds(_context.EIInvoiceIDs).ToList();


            ProgressChanged(10);

            // progress logic skipped

            /*
            Go thru Invoice Total file using the sort order index
             so that the InvRecNos are issued in sorted order.
             Write the ACCTRNFIL, ACCVAT, and ACCALLOC records.
             If unable to write the ACCTRNFIL record then abandon the update,
             otherwise carry on and set the SYSTEM LastPreinvUpdateOk to false to
             prevent another run overwriting the extract tables, and NEWRELALL
             and PODMNT from Un-releasing the DELHEDS.
             For each extracted Delhed(Invprt) update the DELHED and DELDET records.*/

            // for:  Go thru each Invoice Total record.
            var accountClassRecordsToProcess = _context.InvTotRecords.Where(y => y.HofClaRecNo != null).Select(z => z.HofClaRecNo != null ? z.HofClaRecNo.Value : 0).Distinct().ToList();
            Dictionary<int, DTOAccountClass> accountClassRecords = _accountClassRepository.GetAccountClassByIDs(accountClassRecordsToProcess).ToDictionary(z => z.Id, t => t);

            var accountsToProcess = _accountRepository.GetAccountByAccClassIDs(accountClassRecordsToProcess).Distinct().ToDictionary(z => z.Id, z => z);

            var allInvPrtRecords = _invPrtRepository.GetByExtractSessionID(extractSessionID);
            var allInvPrt2Records = _invPrt2Repository.GetByExtractSessionID(extractSessionID);
            var allInvDiscTypRecords = _invDiscTypRepository.GetByExtractSessionID(extractSessionID);

            ProgressChanged(20);

            ValidateInvTempData(updateParams, _context.InvTotRecords, allInvPrtRecords, allInvPrt2Records);

            var allAtrRecNos = allInvPrt2Records.Select(i => i.AllocToInvRecNo != null ? i.AllocToInvRecNo.Value : 0).Distinct().ToList();
            allAtrRecNos.Remove(0); //remove 0 key if present
            var allAccTrnFil = _accTrnFilRepository.GetByAtrRecNos(allAtrRecNos);

            var invPrtOrderRecNos = allInvPrtRecords.Select(z => z.OrdRecNo != null ? z.OrdRecNo.Value : 0).Distinct().ToList();
            invPrtOrderRecNos.Remove(0); //remove 0 key if present
            var allOrders = _orderRepository.GetOrdersByIDs(invPrtOrderRecNos);
            var allAffectedDelHeds = _deliveryHeadRepository.GetDeliveryHeadByOrderIDs(invPrtOrderRecNos).ToList();
            var allAffectedDelHedIds = allAffectedDelHeds.Select(z => z.Id).ToList();
            var allAffectedDelDetails = _deliveryDetailRepository.GetDeliveryDetailByDeliveryHeadIDs(allAffectedDelHedIds);
            var allAffectedDelDetailIds = allAffectedDelDetails.Select(z => z.Id).ToList();

            var allDprRecNos = allInvPrt2Records.Select(i => i.DprRecNo != null ? i.DprRecNo.Value : 0).Distinct().ToList();
            allDprRecNos.Remove(0); //remove 0 key if present
            var allDeliveryPrices = _deliveryPriceRepository.GetDeliveryPriceByDeliveryDetailIDs(allAffectedDelDetailIds);
            var allIteChgItems = _iteChgRepository.GetItemChargeByDeliveryPriceIds(allDprRecNos);

            _auditRecordRepository.ReserveSequenceRange(allIteChgItems.Count + allDprRecNos.Count); //In UpdateItechg for each IteChgItems audit record is created; For each delPrice delAudit is created as well
            _context.ExpChaKeysReserved = false;

            _accTrnFilRepository.ReserveSequenceRange(_context.InvTotRecords.Count);

            ProgressChanged(30);

            foreach (DTOInvTot invTot in _context.InvTotRecords)
            {
                _context.InvTotRecord = invTot;

                // check updateParams.InvoiceType => PstRecNo 21/33/22

                _context.siPstRecNo = _sharedProcessingHelpers.GetPostTypeByInvoiceType(invTot.InvoiceType);
                int? accntsaloffno = _context.InvTotRecord.AccntSalOffNo;

                //; this code was added because if you are using the 0 sales office it appears to require a blank
                //; here because glbrkon has a blank
                if (accntsaloffno == 0)
                {
                    accntsaloffno = null;
                }

                int? debtorsGanRecNo = GetDebtorGangRecNo(accntsaloffno, _context.InvTotRecord.AccGlAnl);
                if (debtorsGanRecNo == null)
                {
                    throw new FreshTradeException(String.Format("Error obtaining Debtors Gl Rec No. Bad GL Account Nos. <{0}>",
                                                      _context.InvTotRecord.InvoiceNo));
                }


                // ; set range on INVPRT to invoice#.
                _context.InvPrtRecord = allInvPrtRecords.Where(i => i.DlvInvoiceNo == _context.InvTotRecord.InvoiceNo).FirstOrDefault();
                if (_context.InvPrtRecord == null)
                {
                    throw new FreshTradeException("There is no InvPrt records related to current InvTot");
                }
                // ; set range on InvDiscTyp to invoice#.
                _context.InvPrt2Records = allInvPrt2Records.Where(i => i.InvoiceNo == _context.InvTotRecord.InvoiceNo).ToList();
                if (_context.InvPrt2Records == null)
                {
                    throw new FreshTradeException("There is no InvPrt2 records related to current InvTot");
                }

                //; locate the invoiced customer record.
                _context.InvDiscTypRecords = allInvDiscTypRecords.Where(i => i.DlvInvoiceNo == _context.InvTotRecord.InvoiceNo).ToList();

                if (!accountClassRecords.ContainsKey(_context.InvTotRecord.HofClaRecNo.Value))
                {
                    throw new FreshTradeException(String.Format("Can't find Customer: {0}   ClaRecNo : {1}",
                                                      _context.InvTotRecord.HofCstCode,
                                                      _context.InvTotRecord.HofClaRecNo));
                }

                var accountClassRecord = accountClassRecords[_context.InvTotRecord.HofClaRecNo.Value];

                if (!accountsToProcess.ContainsKey(accountClassRecord.Id))
                {
                    throw new FreshTradeException(String.Format("Can't find Customer : {0}   ClaAccNo : {1}",
                                                      _context.InvTotRecord.HofCstCode,
                                                      accountClassRecord.AccountCode));
                }

                var accountRecord = accountsToProcess[accountClassRecord.Id];
                //_context.BatchTypeForAccount = _invoiceTypeToBatchTypeMapping[accountRecord.InvoiceType];

                var dySalesGanTot = new Dictionary<int, DTOSalesGanTot>();
                var dyVatGanTot = new Dictionary<int, DTOVatGanTot>();

                var dyAutoAllocAmt = new Dictionary<int, DTOAutoAlloc>();

                #region                // Iterate through InvPrt2

                decimal autoAllocTotal = 0.0M;
                foreach (DTOInvPrt2 invPrt2Record in _context.InvPrt2Records)
                {
                    _context.InvPrt2Record = invPrt2Record;

                    //Total Discounts etc for checking.

                    #region invDiscTypRecords loop

                    //LsetRangeNew("InvDiscTyp", String(tc["InvTot"].InvoiceNo, "~", tc["InvPrt2"].RecNo, "~", tc["InvPrt2"].RecNo, "~"))
                    foreach (var invDiscTypRecord in
                        _context.InvDiscTypRecords.Where(z => z.RecNo.Equals(_context.InvPrt2Record.Recno)))
                    {
                        _context.InvDiscTypRecord = invDiscTypRecord;
                        if (invDiscTypRecord.DiscTyp.HasValue)
                        {
                            switch (invDiscTypRecord.DiscTyp.Value.GetStage())
                            {
                                case EnumDiscTypesStage.OnInvoice:
                                    _context.InvBaseDscTot = _context.InvBaseDscTot + invDiscTypRecord.DiscBaseAmt;
                                    break;
                                case EnumDiscTypesStage.OnPayment:
                                    _context.InvBaseOnPTot = _context.InvBaseOnPTot + invDiscTypRecord.DiscBaseAmt;
                                    break;
                                default:
                                    _context.InvBaseRbtTot = _context.InvBaseRbtTot + invDiscTypRecord.DiscBaseAmt;
                                    break;
                            }
                        }

                        if ((Math.Abs(_context.InvPrt2Record.OffInvRbt) > .001M)
                            || (Math.Abs(_context.InvPrt2Record.OffInvOnPay) > .001M))
                        {
                            if (GetRebBalGangRecNo(accntsaloffno,
                                                   _context.InvPrt2Record.PrdGlAnl,
                                                   invDiscTypRecord.DiscGlRecNo) == null)
                            {
                                throw new FreshTradeException("Error obtaining RebBal Gl Rec No");
                            }

                            if (GetRebPnLGangRecNo(accntsaloffno,
                                                   _context.InvPrt2Record.PrdGlAnl,
                                                   invDiscTypRecord.DiscGlRecNo) == null)
                            {
                                throw new FreshTradeException("Error obtaining RebP&L Gl Rec No");
                            }
                        }
                    }
                    _context.InvDiscTypRecord = null;
                    #endregion

                    //store sales by Gan RecNo
                    //  subScrStr = String("Sales~", stAccntSalOffNo, "~", tc["InvTot"].AccGlAnl, "~", tc["InvPrt2"].PrdGlAnl, "~")
                    var salesGanRecNo = GetSalesGanRecNo(accntsaloffno,
                                                         _context.InvTotRecord.AccGlAnl,
                                                         _context.InvPrt2Record.PrdGlAnl);
                    if (salesGanRecNo == null)
                    {
                        throw new FreshTradeException("Error in Sales Gl Rec No.");
                    }

                    if (!dySalesGanTot.ContainsKey(salesGanRecNo.Value))
                    {
                        dySalesGanTot.Add(salesGanRecNo.Value,
                                            new DTOSalesGanTot
                                                {
                                                    Goods = _context.InvPrt2Record.Goods,
                                                    Eurogds = _context.InvPrt2Record.EuroGds,
                                                    Basegds = _context.InvPrt2Record.BaseGds
                                                });
                    }
                    else
                    {
                        var item = dySalesGanTot[salesGanRecNo.Value];
                        item.Goods += _context.InvPrt2Record.Goods;
                        item.Eurogds += _context.InvPrt2Record.EuroGds;
                        item.Basegds += _context.InvPrt2Record.BaseGds;
                    }

                    if (_context.InvPrt2Record.OnInvDscnt > 0.001M)
                    {
                        if (GetDiscountGangRecNo(accntsaloffno, _context.InvPrt2Record.PrdGlAnl) == null)
                        {
                            throw new FreshTradeException("Error obtaining Discount Gl Rec No");
                        }
                    }

                    if ((accountRecord.AccArAutoAllocCdts == 1) && (_context.InvPrt2Record.AllocToInvRecNo > 0)
                        && (Math.Abs(_context.InvPrt2Record.Vat - Math.Round(_context.InvPrt2Record.Vat, 2)) < 0.005M))
                    {
                        var accTrnFil = allAccTrnFil.FirstOrDefault(z => z.AtrRecNo.Equals(_context.InvPrt2Record.AllocToInvRecNo));
                        if (accTrnFil != null)
                        {
                            DTOAutoAlloc item;
                            if (!dyAutoAllocAmt.TryGetValue(_context.InvPrt2Record.AllocToInvRecNo.Value, out item))
                            {
                                item = new DTOAutoAlloc
                                            {
                                                AutoAllocAmt = 0,
                                                AutoAllocBaseAmt = 0,
                                                AutoAllocEuroAmt = 0
                                            };
                                dyAutoAllocAmt.Add(_context.InvPrt2Record.AllocToInvRecNo.Value, item);
                            }
                            item.AutoAllocAmt += _context.InvPrt2Record.Ext;
                            item.AutoAllocEuroAmt += _context.InvPrt2Record.EuroGds + _context.InvPrt2Record.EuroVat - _context.InvPrt2Record.EuroOnInvDscnt;
                            item.AutoAllocBaseAmt += _context.InvPrt2Record.BaseGds + _context.InvPrt2Record.BaseVat - _context.InvPrt2Record.BaseOnInvDscnt;
                            autoAllocTotal += _context.InvPrt2Record.Ext;
                        } // EndIf accTrnFil
                    }
                }

                #endregion

                #region                //Validate EDI file
                if (_context.InvTotRecord.IsEdiCst && _context.InvTotRecord.EIInvoiceId != null)
                {
                    var ediLogRecord = _context.EdiLogRecords.FirstOrDefault(z => z.Eiinvoiceid.Equals(_context.InvTotRecord.EIInvoiceId));
                    if (ediLogRecord == null)
                    {
                        throw new FreshTradeException("Edilog record is expected to be present for this invoice");
                    }
                    if (Math.Abs(Math.Abs(ediLogRecord.Eitotalgoods) - Math.Abs(_context.InvTotRecord.GoodsTotal)) > .005M)
                    {
                        throw new FreshTradeException("EDI Goods total does not match");
                    }
                    if (Math.Abs(Math.Abs(ediLogRecord.Eitotaldiscount) - Math.Abs(_context.InvTotRecord.OnInvDscnt)) > .005M)
                    {
                        throw new FreshTradeException("EDI Discount total does not match");
                    }
                    if (Math.Abs(Math.Abs(ediLogRecord.Eitotalvat) - Math.Abs(_context.InvTotRecord.VatTotal)) > .005M)
                    {
                        throw new FreshTradeException("EDI VAT total does not match");
                    }
                    if (Math.Abs(Math.Abs(ediLogRecord.Eitotalinvoiced) - Math.Abs(_context.InvTotRecord.InvoiceTotal)) > .005M)
                    {
                        throw new FreshTradeException("EDI Invoice total does not match");
                    }
                    _context.EDIFilesDyAr.Add(new Tuple<string, int>(ediLogRecord.Ehtransfilename, ediLogRecord.EHHeadId));
                }
                #endregion

                //todo: locate field source
                var stInvCstRef = _context.InvPrtRecord.DlvPODNo;
                if (string.IsNullOrEmpty(stInvCstRef))
                {
                    stInvCstRef = _context.InvPrtRecord.OrdCustOrdNo ?? "";
                }
                stInvCstRef = stInvCstRef.Left(20);


                //perform series of updates

                #region // 2nd add ACCTRNFIL record to end of table.

                var dyPstDrCrValue = _context.dyPstDrCr[(int)_context.siPstRecNo];
                var newAccTrnFil = new DTOAccTrnFil();
                newAccTrnFil.AtrRecNo = (int)_accTrnFilRepository.GetNextSequence();
                newAccTrnFil.Atrclarecno = _context.InvTotRecord.HofClaRecNo;
                newAccTrnFil.AtrPstTyp = (int)_context.siPstRecNo;
                newAccTrnFil.AtrStatInd = AtrStatInd_NewRecord; //100 - new record
                newAccTrnFil.Atrref = _context.InvTotRecord.InvoiceNo;
                newAccTrnFil.AtrPstDate = _context.InvTotRecord.InvDate;
                newAccTrnFil.AtrCurRecNo = _context.InvTotRecord.CurNo;
                newAccTrnFil.AtrEuroRate = _context.InvTotRecord.EuroRate;
                newAccTrnFil.AtrBaseRate = _context.InvTotRecord.BaseRate;
                newAccTrnFil.AtrAmount = _context.InvTotRecord.InvoiceTotal * dyPstDrCrValue;
                newAccTrnFil.AtrEuroAmount = (_context.InvTotRecord.EuroGdsTotal
                                                    + _context.InvTotRecord.EuroVatTotal
                                                    - _context.InvTotRecord.EuroOnInvDscnt) * dyPstDrCrValue;
                newAccTrnFil.AtrBaseAmount = (_context.InvTotRecord.BaseGdsTotal
                                                    + _context.InvTotRecord.BaseVatTotal
                                                    - _context.InvTotRecord.BaseOnInvDscnt) * dyPstDrCrValue;
                newAccTrnFil.AtrTriangulate = Convert.ToInt16(_context.InvTotRecord.TriangReq);
                newAccTrnFil.AtrBalance = (_context.InvTotRecord.InvoiceTotal - autoAllocTotal) * dyPstDrCrValue;
                if (newAccTrnFil.AtrBalance < .005M)
                {
                    newAccTrnFil.AtrBalance = .0M;
                }
                newAccTrnFil.AtrCoGlbRecNo = _context.InvTotRecord.PrcGlbRecNo;
                newAccTrnFil.AtrDbType = 1;
                newAccTrnFil.AtrDbNo = null;
                newAccTrnFil.AtrDelClaRecNo = _context.InvPrtRecord.DelClaRecNo;
                newAccTrnFil.AtrRef2 = stInvCstRef;
                newAccTrnFil.AtrSalOffNo = _context.InvTotRecord.AccntSalOffNo;
                // Accounting Sales Office No. if there is one.

                newAccTrnFil.Atrdispute = -1; //Default value;
                newAccTrnFil.Clrddate = "-1"; //Default value;

                if ((newAccTrnFil.AtrAmount < .005M) && (newAccTrnFil.AtrBalance < .005M))
                {
                    newAccTrnFil.AtrStatInd = AtrStatInd_NewRecordZeroBalance; // 110 = New record. zero bal
                }
                updateInfo.AccTrnFilAdditions.Add(newAccTrnFil);
                //_accTrnFilRepository.Update(dynFieldChanges);
                _context.AccTrnFil = newAccTrnFil;

                #region some EDI logic

                /*      if lUpdatedOk
      and LDoEDI
      and tc["INVTOT"].IsEdiCst ;lui 20021212
      then
         if tc["INVTOT"].EIInvoiceID <> Blank()
         then
            SQLString = "UPDATE EDILogInvoice\n"
               + "SET EIAtrRecNo = " + String(liAtrRecNo) + "\n"
               + "WHERE EIInvoiceID = " + tc["INVTOT"].EIInvoiceID

            lUpdatedOk = LExecuteSQL("DATA", SQLString, tc["ANSWER"], True)
         endIf
      endIf*/

                #endregion

                _context.InvTotRecord.InvRecNo = _context.AccTrnFil.AtrRecNo; //no persistance

                #endregion

                #region           // 3rd add ACCVAT records to end of table.

                //todo refactor this
                int? vatCode = 0;
                decimal euroGdsAmt = 0;
                decimal baseGdsAmt = 0;
                int? vatVeaRecNo = 0;
                int? reqVatLnkRecNo = 0;
                decimal gdsAmount;
                decimal vatRate = 0;
                decimal baseVatAmt;

                decimal vatTot = 0;
                decimal gdsTot = 0;
                decimal euroVatTot = 0;
                decimal euroGdsTot = 0;
                decimal baseVatTot = 0;
                decimal baseGdsTot = 0;
                //short GanRecMult = 1;
                int? stVatLoopGL = null;

                #region IF HasVat

                if (_systemPreferences.UserHasVat)
                {
                    int siNumOfVats = _context.InvTotRecord.TwoVatRatesCust ? 2 : 1;
                    for (int siTmp = 1; siTmp <= NumVatFlds; siTmp++)
                    {
                        decimal cmpVat = 0;
                        decimal cmpEuroVat = 0;
                        decimal cmpBaseVat = 0;

                        #region siVatLoop

                        if (_context.InvTotRecord.VatInfo == null)
                        {
                            throw new FreshTradeException("User has VAT but InvTotRecord.VatInfo is null");
                        }
                        var vatInfoRecords = _context.InvTotRecord.VatInfo.Values.ToList();
                        for (int siVatLoop = 1; siVatLoop <= siNumOfVats; siVatLoop++)
                        {
                            //bool lIsVatRev = false; Is never set to true in original code!!!
                            decimal vatAmount;
                            decimal euroVatAmt;

                            if (siTmp > vatInfoRecords.Count)
                            {
                                vatCode = null;
                                gdsAmount = 0;
                                euroGdsAmt = 0;
                                baseGdsAmt = 0;
                                vatVeaRecNo = null;
                                reqVatLnkRecNo = null;
                                vatRate = 0;
                                vatAmount = 0;
                                euroVatAmt = 0;
                                baseVatAmt = 0;
                            }
                            else
                            {
                                var vatInfo = vatInfoRecords[siTmp - 1];
                                vatCode = vatInfo.Cde;
                                gdsAmount = vatInfo.Gds;
                                euroGdsAmt = vatInfo.EuroGds;
                                baseGdsAmt = vatInfo.BaseGds;
                                vatVeaRecNo = vatInfo.AvaVeaRec;
                                reqVatLnkRecNo = vatInfo.VatLnkRecNo;
                                if (siVatLoop == 1)
                                {
                                    vatRate = vatInfo.Rte;
                                    vatAmount = vatInfo.Vat;
                                    euroVatAmt = vatInfo.EuroVat;
                                    baseVatAmt = vatInfo.BaseVat;
                                }
                                else
                                {
                                    vatRate = vatInfo.Rte2;
                                    vatAmount = vatInfo.Vat2;
                                    euroVatAmt = vatInfo.EuroVat2;
                                    baseVatAmt = vatInfo.BaseVat2;
                                }
                            }


                            if (Math.Abs(vatAmount + gdsAmount + euroVatAmt + euroGdsAmt + baseVatAmt + baseGdsAmt) >= 0.005M)
                            {
                                DTOAccVAT accVat = new DTOAccVAT();
                                switch (siVatLoop)
                                {
                                    case 1:
                                        stVatLoopGL = null;
                                        cmpVat = vatAmount;
                                        cmpEuroVat = euroVatAmt;
                                        cmpBaseVat = baseVatAmt;
                                        break;

                                    default:
                                        stVatLoopGL = 2;
                                        break;
                                }

                                accVat.AvaAtrRecNo = _context.AccTrnFil.AtrRecNo;
                                accVat.Avavatcde = vatCode.Value;
                                accVat.Avavattypno = siVatLoop;
                                accVat.Avavatrate = vatRate;
                                accVat.Avavat = vatAmount;
                                accVat.Avaeurovat = euroVatAmt;
                                accVat.Avabasevat = baseVatAmt;
                                accVat.Avarptno = 0;
                                accVat.Avaisrevcrdr = 0;//lIsVatRev ? (short) 1 : (short) 0;

                                if ((siVatLoop == 2) && (_context.InvTotRecord.CompoundVatCust))
                                {
                                    accVat.Avagoods = gdsAmount + cmpVat;
                                    accVat.Avaeurogoods = euroGdsAmt + cmpEuroVat;
                                    accVat.Avabasegoods = baseGdsAmt + cmpBaseVat;
                                }
                                else
                                {
                                    accVat.Avagoods = gdsAmount;
                                    accVat.Avaeurogoods = euroGdsAmt;
                                    accVat.Avabasegoods = baseGdsAmt;
                                }

                                /*if (lIsVatRev) //never happen in original code!!!
                                {
                                    accVat.Avaaddkey = 2;
                                }*/

                                if (vatVeaRecNo > 0)
                                {
                                    accVat.Avaveano = vatVeaRecNo;
                                }

                                if (reqVatLnkRecNo > 0)
                                {
                                    accVat.VatLnkRecNo = reqVatLnkRecNo;
                                }

                                updateInfo.AccVatAdditions.Add(accVat);

                            } //endif

                            /*if (lIsVatRev) //never happen in original code!!!
                            {
                                gdsAmount = gdsAmount*-1;
                                euroGdsAmt = euroGdsAmt*-1;
                                baseGdsAmt = baseGdsAmt*-1;
                            }*/

                            if ((siVatLoop == 1) && (Math.Abs(baseGdsAmt) > 0.001M))
                            {
                                gdsTot = gdsTot + gdsAmount;
                                euroGdsTot = euroGdsTot + euroGdsAmt;
                                baseGdsTot = baseGdsTot + baseGdsAmt;
                            }

                            #region Abs(BaseVatAmt) > 0.001M

                            if (Math.Abs(baseVatAmt) > 0.001M)
                            {
                                int? vatGanRecNo = GetVatGanRecNo(accntsaloffno, vatCode, stVatLoopGL);
                                if (vatGanRecNo == null)
                                {
                                    throw new FreshTradeException(String.Format(
                                                                        "Error - Vat Code {0} Unknown Vat G/L Record No. ",
                                                                        vatCode));
                                }


                                /*if (lIsVatRev) //never happen in original code!!!
                                {
                                    GanRecMult = -1;
                                }
                                else
                                {
                                    GanRecMult = 1;
                                }*/

                                DTOVatGanTot vatGanTot;
                                var tempKey = vatGanRecNo.Value; //Convert.ToInt32(GanRecMult*vatGanRecNo);
                                if (!dyVatGanTot.TryGetValue(tempKey, out vatGanTot))
                                {
                                    vatGanTot = new DTOVatGanTot { Vat = 0, EuroVat = 0, BaseVat = 0 };
                                    dyVatGanTot.Add(tempKey, vatGanTot);
                                }
                                vatGanTot.Vat += vatAmount;
                                vatGanTot.EuroVat += euroVatAmt;
                                vatGanTot.BaseVat += baseVatAmt;


                                /*if (lIsVatRev) //never happen in original code!!!
                                {
                                    vatAmount = vatAmount*-1;
                                    euroVatAmt = euroVatAmt*-1;
                                    baseVatAmt = baseVatAmt*-1;
                                }*/

                                vatTot = vatTot + vatAmount;
                                euroVatTot = euroVatTot + euroVatAmt;
                                baseVatTot = baseVatTot + baseVatAmt;
                            } //endif

                            #endregion
                        } //endfor SiVatLoop
                        #endregion
                    } //endfor siTm
                } //end if hasVat
                else
                {
                    gdsAmount = _context.InvTotRecord.GoodsTotal;
                    euroGdsAmt = _context.InvTotRecord.EuroGdsTotal;
                    baseVatAmt = 0;
                    baseGdsAmt = _context.InvTotRecord.BaseGdsTotal;

                    if (Math.Abs(baseGdsAmt) > 0.001M)
                    {
                        gdsTot = gdsTot + gdsAmount;
                        euroGdsTot = euroGdsTot + euroGdsAmt;
                        baseGdsTot = baseGdsTot + baseVatAmt;
                    }
                }

                #endregion

                #endregion

                #region // 4th update ACCCNTRL record and write AccIte records.

                int siNoRecsReq = 1; // 1 for Debtors
                siNoRecsReq = siNoRecsReq + dySalesGanTot.Count; // ; Add the number of Sales Accites.
                siNoRecsReq = siNoRecsReq + dyVatGanTot.Count; // ;Add the number of VAT Accites.

                _acciteRepository.ReserveSequenceRange(siNoRecsReq);

                //; Write the Debtors Control Accite.
                WriteAccite
                    (
                        updateInfo.AcciteAdditions,
                        null,
                        debtorsGanRecNo,
                        Math.Abs(gdsTot + vatTot),
                        Math.Abs(euroGdsTot + euroVatTot),
                        Math.Abs(baseGdsTot + baseVatTot),
                        EnumPostType.GLDEBTORSPSTRECNO,
                        _context.InvTotRecord.InvoiceType
                    );

                //Write the Sales P&L Accites
                if (dySalesGanTot.Count > 0)
                {
                    foreach (KeyValuePair<int, DTOSalesGanTot> entry in dySalesGanTot)
                    {
                        WriteAccite
                            (
                                updateInfo.AcciteAdditions,
                                null,
                                entry.Key,
                                Math.Abs(dySalesGanTot[entry.Key].Goods),
                                Math.Abs(dySalesGanTot[entry.Key].Eurogds),
                                Math.Abs(dySalesGanTot[entry.Key].Basegds),
                                EnumPostType.GLSALESPSTRECNO,
                            // inversion as per original code
                                _context.InvTotRecord.InvoiceType == PreInvInvoiceType.CreditNote ? PreInvInvoiceType.DebitNote : PreInvInvoiceType.CreditNote
                            );
                    }
                }

                //Write the Vat Control Accite
                if (dyVatGanTot.Count > 0)
                {
                    foreach (KeyValuePair<int, DTOVatGanTot> entry in dyVatGanTot)
                    {
                        int liTmpGanNo = entry.Key;
                        PreInvInvoiceType stCorD;
                        switch (_context.InvTotRecord.InvoiceType)
                        {
                            case PreInvInvoiceType.CreditNote:
                                {
                                    if (dyVatGanTot[entry.Key].Vat > 0.009M)
                                    {
                                        stCorD = PreInvInvoiceType.CreditNote;
                                        if (liTmpGanNo < 0)
                                        {
                                            liTmpGanNo = liTmpGanNo * -1;
                                        }
                                    }
                                    else
                                    {
                                        stCorD = PreInvInvoiceType.DebitNote;
                                    }
                                    break;
                                }

                            default:
                                {
                                    if (dyVatGanTot[entry.Key].Vat < 0.009M)
                                    {
                                        stCorD = PreInvInvoiceType.DebitNote;
                                        if (liTmpGanNo < 0)
                                        {
                                            liTmpGanNo = liTmpGanNo * -1;
                                        }
                                    }
                                    else
                                    {
                                        stCorD = PreInvInvoiceType.CreditNote;
                                    }

                                    break;
                                }
                        }

                        WriteAccite
                            (
                                updateInfo.AcciteAdditions,
                                null,
                                liTmpGanNo,
                                Math.Abs(dyVatGanTot[entry.Key].Vat),
                                Math.Abs(dyVatGanTot[entry.Key].EuroVat),
                                Math.Abs(dyVatGanTot[entry.Key].BaseVat),
                                EnumPostType.GLVATPSTRECNO,
                                stCorD
                            );

                    }
                }

                #endregion

                #region // 5th allocate the Credit/Debit Note to the original
                // invoice by entering into the ACCALLOC and ACCALLVAL tables.

                _accAllValRepository.ReserveSequenceRange(siNoRecsReq);

                int liNxtRecNo = (int)_accAllValRepository.GetNextSequence();

                #region dyAutoAllocAmt.size() > 0

                if (dyAutoAllocAmt.Count > 0)
                {
                    foreach (KeyValuePair<int, DTOAutoAlloc> entry in dyAutoAllocAmt)
                    {
                        var accTrnFilOrig = allAccTrnFil.FirstOrDefault(z => z.AtrRecNo.Equals(entry.Key));
                        if (accTrnFilOrig != null)
                        {
                            var accTrnFil = ObjectHandling.CloneDTO(accTrnFilOrig);
                            /*string stTmp = String.Format("To InvRecNo : {0}  From AtrRecNo :{1}",
                                                         accTrnFil.AtrRecNo,
                                                         _context.AccTrnFil.AtrRecNo);*/

                            var accAllVal = new DTOAccAllVal
                                                {
                                                    AavRecNo = liNxtRecNo,
                                                    AavCurRecNo = _context.InvTotRecord.CurNo,
                                                    AavAmount = Math.Abs(entry.Value.AutoAllocAmt),
                                                    AavEuroAmount = Math.Abs(entry.Value.AutoAllocEuroAmt),
                                                    AavBaseAmount = Math.Abs(entry.Value.AutoAllocBaseAmt)
                                                };

                            updateInfo.AccAllValAdditions.Add(accAllVal);

                            int siDrCrTo = _context.siPstRecNo == EnumPostType.SALESCNTPSTRECNO
                                ? -1 //post as credit to the 'allocated to' ACCTRNFIL.
                                : 1; // post as debit  to the 'allocated to' ACCTRNFIL

                            var accAllocMinus = new DTOAccAlloc
                                                    {
                                                        Acaatrrecnofrom = accTrnFil.AtrRecNo,
                                                        Acaatrrecnoto = _context.AccTrnFil.AtrRecNo,
                                                        Acaaavrecno = liNxtRecNo,
                                                        Acadrcr = siDrCrTo * -1
                                                    };
                            updateInfo.AccAlloc.Add(accAllocMinus);

                            var accAllocPlus = new DTOAccAlloc
                                                    {
                                                        Acaatrrecnofrom = _context.AccTrnFil.AtrRecNo,
                                                        Acaatrrecnoto = accTrnFil.AtrRecNo,
                                                        Acaaavrecno = liNxtRecNo,
                                                        Acadrcr = siDrCrTo
                                                    };
                            updateInfo.AccAlloc.Add(accAllocPlus);

                            liNxtRecNo = (int)_accAllValRepository.GetNextSequence();

                            var balAmount = Math.Abs(dyAutoAllocAmt[entry.Key].AutoAllocAmt)
                                            * _context.dyPstDrCr[accTrnFil.AtrPstTyp.Value] * siDrCrTo;
                            accTrnFil.AtrBalance = accTrnFil.AtrBalance + balAmount;
                            if (accTrnFil.AtrBalance.HasValue && (Math.Abs(accTrnFil.AtrBalance.Value) > 0.001M))
                            {
                                accTrnFil.AtrStatInd = AtrStatInd_NewRecord;
                            }
                            else
                            {
                                accTrnFil.AtrStatInd = AtrStatInd_NewRecordZeroBalance;
                            }
                            updateInfo.AccTrnFilUpdates.Add(new UpdatePair<DTOAccTrnFil>(accTrnFilOrig, accTrnFil));
                        } //endIf accTrnFil != null
                    } //end foreeach dyAutoAllocAmt
                }

                #endregion

                #endregion

                #region Delprices processing

                var invPrt2RecordsToDelpriceProcess = _context.InvPrt2Records.Where(z => z.DprRecNo != null).ToList();
                var invPrt2RecordsToDelpriceProcessDrpRecNos = invPrt2RecordsToDelpriceProcess.Select(z => z.DprRecNo ?? 0).ToList();
                invPrt2RecordsToDelpriceProcessDrpRecNos.Remove(0);

                var deliveryPrices = allDeliveryPrices.Where(i => invPrt2RecordsToDelpriceProcessDrpRecNos.Contains(i.Id)).ToDictionary(z => z.Id, z => z);
                foreach (var invPrt2Record in invPrt2RecordsToDelpriceProcess)
                {
                    DTODeliveryPrice deliveryPriceRecord;
                    //; write the details ie invoice# to the DelPrice records.
                    if (!deliveryPrices.TryGetValue(invPrt2Record.DprRecNo.Value, out deliveryPriceRecord))
                    {
                        throw new FreshTradeException(
                            String.Format("Can't find Delivery No : {0} Delprice No : {1} lUpdate.tcDelPrice 1st",
                                          invPrt2Record.DlvOrdNo,
                                          invPrt2Record.DprRecNo));
                    }

                    DTODeliveryPrice originalDeliveryPriceRecord = ObjectHandling.CloneDTO(deliveryPriceRecord);
                    deliveryPriceRecord.DelToEuroRate = _context.InvTotRecord.EuroRate;
                    deliveryPriceRecord.DelToBaseRate = _context.InvTotRecord.BaseRate;
                    deliveryPriceRecord.DelTriangulate = _context.InvTotRecord.TriangReq;
                    deliveryPriceRecord.DelEuroNettVal = invPrt2Record.EuroGds;
                    deliveryPriceRecord.DelEuroVatValue = invPrt2Record.EuroVat;
                    deliveryPriceRecord.DelBaseNettVal = invPrt2Record.BaseGds;
                    deliveryPriceRecord.DelBaseVatValue = invPrt2Record.BaseVat;
                    deliveryPriceRecord.DelVatValue = invPrt2Record.Vat;
                    deliveryPriceRecord.VatRate = invPrt2Record.VatVatRate;
                    deliveryPriceRecord.VatRecNo = invPrt2Record.VatRecNo;
                    deliveryPriceRecord.InvoiceId = _context.AccTrnFil.AtrRecNo;

                    if (_context.InvTotRecord.TwoVatRatesCust)
                    {
                        deliveryPriceRecord.VatRate2 = invPrt2Record.VatVatRate2;
                    }

                    var auditRecord = new DTODelAuditRecord
                        {
                            Id = (int)_delAuditRecordRepository.GetNextSequence(),
                            DelAudTyp = 32,
                            DelAudDelRecNo = originalDeliveryPriceRecord.DeliveryDetailId,
                            DprRecNo = originalDeliveryPriceRecord.Id,
                            DelAudDate = DateTime.Now,
                            FormNo = _systemPreferences.FormNo,
                            FormName = _systemPreferences.FormName,
                            LogonNo = _user.Id
                        };
                    if (!originalDeliveryPriceRecord.DeliveryPriceStatus.IsInvoiced()) // < 11
                    {
                        auditRecord.DelAudFrom = ((int?)originalDeliveryPriceRecord.DeliveryPriceStatus).ToString();
                        auditRecord.DelAudTo = ((int?)originalDeliveryPriceRecord.DeliveryPriceStatus.ToInvoiced()).ToString();
                        deliveryPriceRecord.DeliveryPriceStatus = originalDeliveryPriceRecord.DeliveryPriceStatus.ToInvoiced();

                        updateInfo.DelAuditRecordAdditions.Add
                            (
                                new DTODelAuditRecord
                                    {
                                        Id = (int)_delAuditRecordRepository.GetNextSequence(),
                                        DelAudTyp = 128,
                                        DelAudDelRecNo = originalDeliveryPriceRecord.DeliveryDetailId,
                                        DprRecNo = originalDeliveryPriceRecord.Id,
                                        DelAudDate = DateTime.Now,
                                        FormNo = _systemPreferences.FormNo,
                                        FormName = _systemPreferences.FormName,
                                        LogonNo = _user.Id
                                    }
                            );
                    }
                    else
                    {
                        auditRecord.DelAudFrom = ((int?)originalDeliveryPriceRecord.DeliveryPriceStatus).ToString();
                        auditRecord.DelAudTo = ((int?)originalDeliveryPriceRecord.DeliveryPriceStatus).ToString();
                    }
                    updateInfo.DelAuditRecordAdditions.Add(auditRecord);
                    updateInfo.DeliveryPriceUpdates.Add(new UpdatePair<DTODeliveryPrice>(originalDeliveryPriceRecord, deliveryPriceRecord));
                } // finished with  delprices for invoice invPrt2

                #endregion

                //  Do Expchas, Itechgss and Accites for Discounts, Rebates, Hand+Comm or Repack.
                // while tc["InvPrt2"] is ranged for this Invoice.
                ReserveExpChaKeys(_context.InvTotRecords);
                UpdateItechg(updateInfo, allInvDiscTypRecords, allIteChgItems);

                //if (_context.InvExtractHead.IsInterCompanyTransfer) Not needed here - as this is just a set of keys from AccTrnFilAdditions

                //It was agreed to skip following library call
                //FinanceLib.InterDepartmentContra(liAtrRecNo, stErrMsg)
            } // /foreach invTot in _context.InvTotRecords

            ProgressChanged(50);

            _context.InvTotRecord = null;
            _context.InvPrtRecord = null;
            _context.AccTrnFil = null;
            //LastPreinvUpdateOk is processed below, when real data insert/updates are performed

            UpdateStatus(updateInfo, allOrders, allInvPrtRecords, allAffectedDelHeds, allAffectedDelDetails, allDeliveryPrices);

            WriteAccReChg(updateInfo); //Original if clause is checked inside of the method

            int lastBatchNo = _context.SalesOffice.LastBatchNo ?? 0;

            int?
                lastInvoiceBatchNo = null,
                lastCreditBatchNo = null,
                lastDebitBatchNo = null;

            //var invoiceTypes = (PreInvInvoiceType.Invoice | PreInvInvoiceType.CreditNote | PreInvInvoiceType.DebitNote).GetAsListOfSimpleValues();
            //var batchTypes = (PreInvInvoiceType.Invoice | PreInvInvoiceType.CreditNote | PreInvInvoiceType.DebitNote).GetAsListOfSimpleValues();

            if ((lastBatchNo + 1) != _context.InvTotRecords.Min(i => i.BatchNo))
            {
                throw new FreshTradeException(string.Format("Salesoffice last batch number was modified since extraction. Expected last batch number was {0}.", lastBatchNo));
            }

            var invoiceGroups = _context.InvTotRecords.GroupBy(i => new DTOInvTotGroup(i.InvoiceType, i.BatchType)).OrderBy(i => i.Key.InvoiceType).ThenBy(i => i.Key.BatchType).ToDictionary(i => i.Key, i => i.ToList());
            _batchRepository.ReserveSequenceRange(invoiceGroups.Count);
            _batchDetRepository.ReserveSequenceRange(_context.InvTotRecords.Count);
            foreach (var invoiceGroup in invoiceGroups)
            {
                var newBatchNo = invoiceGroup.Value.First().BatchNo;
                var invoiceType = invoiceGroup.Key.InvoiceType;
                if (invoiceType == PreInvInvoiceType.Invoice)
                {
                    lastInvoiceBatchNo = IntegerHandling.Max(newBatchNo, lastInvoiceBatchNo);
                }
                else
                    if (invoiceType == PreInvInvoiceType.CreditNote)
                    {
                        lastCreditBatchNo = IntegerHandling.Max(newBatchNo, lastCreditBatchNo);
                    }
                    else
                        if (invoiceType == PreInvInvoiceType.DebitNote)
                        {
                            lastDebitBatchNo = IntegerHandling.Max(newBatchNo, lastDebitBatchNo);
                        }
                var liBatRecNo = UpdateBatch(updateInfo, extractSessionID, updateParams.MergeLikePrices, invoiceType, invoiceGroup.Key.BatchType, invoiceGroup.Value, newBatchNo);
            }

            ProgressChanged(70);


            //EDI IS EXCLUDED FOR NOW, SO validate EDI file re: "the following invoice amounts differ" is skipped

            //EDI IS EXCLUDED FOR NOW, SO validate EDI files re: "The following EDI file(s) have uninvoiced amounts:" is skipped

            //IT Was agreed to exclude PalToDprLib.WritePrepalInout(Tc["Invprt2"].DprRecNo) for now

            //Exculded ; Copy the EDI file into the live alias

            //todo: ChngOwnLib.GenerateTransferPurchInv(SalesAtrRecNoLi)

            #region ForEach ElementStr in TransferAtrDynArLo
            /*  It was agreed to exlude hngOwnLib.GenerateTransferPurchInv(SalesAtrRecNoLi)
                if lUpdatedOk
                then
                   ForEach ElementStr in TransferAtrDynArLo
                      SalesAtrRecNoLi = 0
                      Try
                         SalesAtrRecNoLi = LongInt(ElementStr)
                      OnFail
                          ;do nothing
                      EndTry
                      if SalesAtrRecNoLi > 0
                      then
                         lUpdatedOk = ChngOwnLib.GenerateTransferPurchInv(SalesAtrRecNoLi)
                      endif

                   endForEach
                endif
            */
            #endregion

            #region if liSysLastInvNo = LstInvNo
            /* There is no case when this may happen in new code - so it is excluded
               stTmp = "Last Invoice No. for Sales Office <"+ strVal(siReqdSalOffNo) +"> will be incorrect."
               errorLog(peFormWriteError, stTmp)
               UtilsLib.stErrorHandler(true, formName, "lUpdate.LastInvNo", false, stTmp, "", "", false)
               lUpdFinishedOk = false
            */
            #endregion

            var lastInvNo = _context.InvExtractHead.LastInvoiceNo;
            DTOSalesOffice updatedSalesOffice = ObjectHandling.CloneDTO(_context.SalesOffice);
            updateInfo.SalesOfficeUpdate = updatedSalesOffice;
            if (lastInvNo > updatedSalesOffice.NextInvoiceNo)
            {
                updatedSalesOffice.NextInvoiceNo = lastInvNo;
            }
            updatedSalesOffice.LastBatchNo = IntegerHandling.Max(lastBatchNo, lastInvoiceBatchNo, lastCreditBatchNo, lastDebitBatchNo);
            updatedSalesOffice.LastPreInvUpdateOK = true;
            updatedSalesOffice.InUse = false;

            if (lastInvoiceBatchNo.HasValue)
            {
                updatedSalesOffice.LastInvoiceBatchNo = lastInvoiceBatchNo;
            }
            if (lastCreditBatchNo.HasValue)
            {
                updatedSalesOffice.LastCreditBatchNo = lastCreditBatchNo;
            }
            if (lastDebitBatchNo.HasValue)
            {
                updatedSalesOffice.LastDebitBatchNo = lastDebitBatchNo;
            }

            _unitOfWorkCurrent.BeginTransaction();
            try
            {
                // 11 Additions
                _accAllocRepository.Debug("pre");
                _accAllocRepository.Add(updateInfo.AccAlloc);
                _accAllocRepository.Debug("post");

                _accTrnFilRepository.Debug("pre");
                _accTrnFilRepository.Add(updateInfo.AccTrnFilAdditions);
                _accTrnFilRepository.Debug("post");

                _acciteRepository.Debug("pre");
                _acciteRepository.Add(updateInfo.AcciteAdditions);
                _acciteRepository.Debug("post");

                _accVatRepository.Debug("pre");
                _accVatRepository.Add(updateInfo.AccVatAdditions);
                _accVatRepository.Debug("post");

                _accReChgRepository.Debug("pre");
                _accReChgRepository.Add(updateInfo.AccReChgAdditions);
                _accReChgRepository.Debug("post");

                _accAllValRepository.Debug("pre");
                _accAllValRepository.Add(updateInfo.AccAllValAdditions);
                _accAllValRepository.Debug("post");

                _expChaRepository.Debug("pre");
                _expChaRepository.Add(updateInfo.ExpChaAdditions);
                _expChaRepository.Debug("post");

                _batchDetRepository.Debug("pre");
                _batchDetRepository.Add(updateInfo.BatchDetAdditions);
                _batchDetRepository.Debug("post");

                _batchRepository.Debug("pre");
                _batchRepository.Add(updateInfo.BatchAdditions);
                _batchRepository.Debug("post");

                _ichDiscTypRepository.Debug("pre");
                _ichDiscTypRepository.Add(updateInfo.IchDiscTypAdditions);
                _ichDiscTypRepository.Debug("post");

                _iteChgRepository.Debug("pre");
                _iteChgRepository.Add(updateInfo.IteChgAdditions);
                _iteChgRepository.Debug("post");

                //2 audit
                _auditRecordRepository.Debug("pre");
                _auditRecordRepository.Add(updateInfo.AuditRecordAdditions);
                _auditRecordRepository.Debug("post");

                StoreDeliveryAudits(updateInfo);

                //2 updates                
                _deliveryHeadRepository.Debug("pre");
                _deliveryHeadRepository.Update(updateInfo.DeliveryHeadUpdates);
                _deliveryHeadRepository.Debug("post");

                _deliveryDetailRepository.Debug("pre");
                _deliveryDetailRepository.Update(updateInfo.DeliveryDetailUpdates);
                _deliveryDetailRepository.Debug("post");

                _deliveryPriceRepository.Debug("pre");
                _deliveryPriceRepository.Update(updateInfo.DeliveryPriceUpdates);
                _deliveryPriceRepository.Debug("post");

                _accTrnFilRepository.Debug("pre");
                _accTrnFilRepository.Update(updateInfo.AccTrnFilUpdates);
                _accTrnFilRepository.Debug("post");

                _orderRepository.Debug("pre");
                _orderRepository.Update
                (
                    new[] { new FieldNameRef<DTOOrder, int?>(i => i.AccountClassId) },
                    updateInfo.OrderCleanAccountClassID.Select(i => (IRowUpdateInfo)new RowUpdateInfo(i.Id, new object[] { null })).ToList()
                );
                _orderRepository.Debug("post");

                //1 sales office
                _salesOfficeRepository.Update(_context.SalesOffice, updatedSalesOffice);

                _iteChgRepository.Delete(updateInfo.IteChgDeletions);

                ProgressChanged(100);
                _unitOfWorkCurrent.Commit();
                return PreInvUpdateStatusType.OK;
            }
            catch (Exception)
            {
                ProgressChanged(100);
                _unitOfWorkCurrent.Rollback();

                _unitOfWorkCurrent.BeginTransaction();
                try
                {
                    var failedUpdateSalOff = ObjectHandling.CloneDTO(_context.SalesOffice);
                    failedUpdateSalOff.LastPreInvUpdateOK = false;
                    failedUpdateSalOff.InUse = false;
                    _salesOfficeRepository.Update(_context.SalesOffice, failedUpdateSalOff);
                    _unitOfWorkCurrent.Commit();
                }
                catch (Exception)
                {
                    _unitOfWorkCurrent.Rollback();
                }

                throw;
            }
            return PreInvUpdateStatusType.Failed;
        }
    }
}
