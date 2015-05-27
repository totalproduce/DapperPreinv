using Bsdl.FreshTrade.Domain.Basic.Exceptions;
using Bsdl.FreshTrade.Domain.PreInv.Entities;
using Bsdl.FreshTrade.Domain.PreInv.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace Bsdl.FreshTrade.Domain.PreInv.Utilities
{
    public static class PreInvTotalCalculator
    {
        public static void CalcTotals(IEnumerable<IDTOInvTot> invoiceTotals, IEnumerable<IDTOInvPrt2> invoiceDetails, bool hasVat)
        {
            var groups = invoiceDetails.GroupBy(i => i.InvoiceNo).ToDictionary(i => i.Key, i=> i);
            foreach(var invoiceTotal in invoiceTotals)
            {
                IEnumerable<IDTOInvPrt2> groupInvoiceDetails;
                IGrouping<string, IDTOInvPrt2> group;
                if (groups.TryGetValue(invoiceTotal.InvoiceNo, out group))
                {
                    groupInvoiceDetails = group;
                }
                else
                {
                    groupInvoiceDetails = new List<IDTOInvPrt2>();
                }
                CalcTotal(invoiceTotal, groupInvoiceDetails, hasVat);
            }
        }

        public static void CalcTotal(IDTOInvTot invoiceTotal, IEnumerable<IDTOInvPrt2> invoiceDetails, bool hasVat)
        {
            var tmpInvTot = new DTOInvTot();
            foreach (var invDetail in invoiceDetails)
            {
                tmpInvTot.QtyTotal += invDetail.DiscToQty??0;
                tmpInvTot.GoodsTotal += invDetail.Goods;

                tmpInvTot.OnInvDscnt += invDetail.OnInvDscnt;
                tmpInvTot.OffInvRbt += invDetail.OffInvRbt;
                tmpInvTot.OffInvOnPay += invDetail.OffInvOnPay;
                tmpInvTot.EuroGdsTotal += invDetail.EuroGds;
                tmpInvTot.BaseGdsTotal += invDetail.BaseGds;
                tmpInvTot.RawVatOnChgs += invDetail.Rawvatonchgs;
                tmpInvTot.BaseVatOnChgs += invDetail.Basevatonchgs ?? 0;
                tmpInvTot.EuroVatOnChgs += invDetail.Eurovatonchgs;

                tmpInvTot.InvoiceTotal += invDetail.Goods + invDetail.Vat - invDetail.OnInvDscnt;

                tmpInvTot.EuroOnInvDscnt += invDetail.EuroOnInvDscnt;
                tmpInvTot.EuroOffInvRbt += invDetail.EuroOffInvRbt;
                tmpInvTot.EuroOffInvOnPay += invDetail.EuroOffOnPay;
                tmpInvTot.BaseOnInvDscnt += invDetail.BaseOnInvDscnt;
                tmpInvTot.BaseOffInvRbt += invDetail.BaseOffInvRbt;
                tmpInvTot.BaseOffInvOnPay += invDetail.BaseOffOnPay;

                tmpInvTot.Rawhandcommamt += invDetail.Rawhandamt + invDetail.Rawcommamt;

                tmpInvTot.Basehandcommamt += invDetail.Basehandamt + invDetail.Basecommamt;

                tmpInvTot.Eurohandcommamt += invDetail.Eurohandamt + invDetail.Eurocommamt;

                if (hasVat)
                {
                    tmpInvTot.VatTotal += invDetail.Vat;
                    tmpInvTot.EuroVatTotal += invDetail.EuroVat;
                    tmpInvTot.BaseVatTotal += invDetail.BaseVat;
                    tmpInvTot.Vat1Total += invDetail.Vat1Total;
                    tmpInvTot.Vat2Total += invDetail.Vat2Total;
                    tmpInvTot.EuroVat1Total += invDetail.EuroVat1Total;
                    tmpInvTot.EuroVat2Total += invDetail.EuroVat2Total;
                    tmpInvTot.BaseVat1Total += invDetail.BaseVat1Total;
                    tmpInvTot.BaseVat2Total += invDetail.BaseVat2Total;

                    if (invDetail.VatRecNo.HasValue)
                    {
                        DTOInvTotVatInfo vatInfo;
                        if (!tmpInvTot.VatInfo.TryGetValue(invDetail.VatRecNo.Value, out vatInfo))
                        {
                            DTOInvTotVatInfo origVatInfo;
                            if (!invoiceTotal.VatInfo.TryGetValue(invDetail.VatRecNo.Value, out origVatInfo))
                            {
                                throw new FreshTradeException(string.Format("VatInfo is not found for VatRecNo = {0}. Delivery Number = {1}", invDetail.VatRecNo.Value, invDetail.DlvOrdNo.GetValueOrDefault()));
                            }
                            vatInfo =
                                new DTOInvTotVatInfo
                                    {
                                        Cde = origVatInfo.Cde,
                                        AvaVeaRec = origVatInfo.AvaVeaRec,
                                        Gds = 0,
                                        EuroGds = 0,
                                        BaseGds = 0,
                                        VatLnkRecNo = origVatInfo.VatLnkRecNo,

                                        Rte = origVatInfo.Rte,
                                        Vat = 0,
                                        EuroVat = 0,
                                        BaseVat = 0,

                                        Rte2 = origVatInfo.Rte2,
                                        Vat2 = 0,
                                        EuroVat2 = 0,
                                        BaseVat2 = 0
                                    };

                            tmpInvTot.VatInfo.Add(vatInfo.Cde, vatInfo);
                        }

                        vatInfo.Vat += invDetail.Vat1Total;
                        vatInfo.Gds += invDetail.Goods - invDetail.OnInvDscnt;
                        vatInfo.EuroVat += invDetail.EuroVat1Total;
                        vatInfo.EuroGds += invDetail.EuroGds - invDetail.EuroOnInvDscnt;
                        vatInfo.BaseVat += invDetail.BaseVat1Total;
                        vatInfo.BaseGds += invDetail.BaseGds - invDetail.BaseOnInvDscnt;
                        vatInfo.Vat2 += invDetail.Vat2Total;
                        vatInfo.EuroVat2 += invDetail.EuroVat2Total;
                        vatInfo.BaseVat2 += invDetail.BaseVat2Total;
                    }

                }
            }

            invoiceTotal.QtyTotal = tmpInvTot.QtyTotal;
            invoiceTotal.GoodsTotal = tmpInvTot.GoodsTotal;
            invoiceTotal.VatTotal = tmpInvTot.VatTotal;
            invoiceTotal.OnInvDscnt = tmpInvTot.OnInvDscnt;
            invoiceTotal.OffInvRbt = tmpInvTot.OffInvRbt;
            invoiceTotal.OffInvOnPay = tmpInvTot.OffInvOnPay;
            invoiceTotal.InvoiceTotal = tmpInvTot.InvoiceTotal;
            invoiceTotal.EuroOnInvDscnt = tmpInvTot.EuroOnInvDscnt;
            invoiceTotal.EuroOffInvRbt = tmpInvTot.EuroOffInvRbt;
            invoiceTotal.EuroOffInvOnPay = tmpInvTot.EuroOffInvOnPay;
            invoiceTotal.EuroGdsTotal = tmpInvTot.EuroGdsTotal;
            invoiceTotal.EuroVatTotal = tmpInvTot.EuroVatTotal;
            invoiceTotal.BaseOnInvDscnt = tmpInvTot.BaseOnInvDscnt;
            invoiceTotal.BaseOffInvRbt = tmpInvTot.BaseOffInvRbt;
            invoiceTotal.BaseOffInvOnPay = tmpInvTot.BaseOffInvOnPay;
            invoiceTotal.BaseGdsTotal = tmpInvTot.BaseGdsTotal;
            invoiceTotal.BaseVatTotal = tmpInvTot.BaseVatTotal;
            /*;invoiceTotal.RawHandCommAmt  = tmpInvTot.RawHandCommAmt;
            ;invoiceTotal.RawVatOnChgs    = tmpInvTot.RawVatOnChgs;
            ;invoiceTotal.BaseHandCommAmt = tmpInvTot.BaseHandCommAmt;
            ;invoiceTotal.BaseVatOnChgs   = tmpInvTot.BaseVatOnChgs;
            ;invoiceTotal.EuroHandCommAmt = tmpInvTot.EuroHandCommAmt;
            ;invoiceTotal.EuroVatOnChgs   = tmpInvTot.EuroVatOnChgs; */
            invoiceTotal.Vat1Total = tmpInvTot.Vat1Total;
            invoiceTotal.Vat2Total = tmpInvTot.Vat2Total;
            invoiceTotal.EuroVat1Total = tmpInvTot.EuroVat1Total;
            invoiceTotal.EuroVat2Total = tmpInvTot.EuroVat2Total;
            invoiceTotal.BaseVat1Total = tmpInvTot.BaseVat1Total;
            invoiceTotal.BaseVat2Total = tmpInvTot.BaseVat2Total;
            invoiceTotal.VatInfo = tmpInvTot.VatInfo;

            //TODO: Check that against original code
            //invoiceTotal.CancelledInv = invoiceDetails.Where(id => !id.CancelledLine).FirstOrDefault() != null;
        }

    }
}
