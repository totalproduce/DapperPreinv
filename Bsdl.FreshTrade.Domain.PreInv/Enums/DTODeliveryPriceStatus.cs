using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Bsdl.FreshTrade.Domain.Basic.Exceptions;

namespace Bsdl.FreshTrade.Domain.PreInv.Enums
{
    public enum DTODeliveryPriceStatus
    {
        NormalDelivery = 1, 
        CreditOnNormalDelivery = 2, 
        DebitOnNormalDelivery = 3, 
        MiscellanousCredit = 7, 
        MiscellanousDebit = 8, 
        InvoicedNormalDelivery = 11, 
        InvoicedCredit = 12, 
        InvoicedDebit = 13, 
        InvoicedMiscCredit = 17, 
        InvoicedMisc = 18
    }

    public static class DTODeliveryPriceStatusExtensions
    {
        public static DTODeliveryPriceStatus ToInvoiced (this DTODeliveryPriceStatus? status)
        {
            if (!status.HasValue)
            {
                throw new FreshTradeException("Status cannot be empty here");
            }
            DTODeliveryPriceStatus result;
            switch (status.Value)
            {
                case DTODeliveryPriceStatus.NormalDelivery:
                    result = DTODeliveryPriceStatus.InvoicedNormalDelivery;
                    break;
                case DTODeliveryPriceStatus.CreditOnNormalDelivery:
                    result = DTODeliveryPriceStatus.InvoicedCredit;
                    break;
                case DTODeliveryPriceStatus.DebitOnNormalDelivery:
                    result = DTODeliveryPriceStatus.InvoicedDebit;
                    break;
                case DTODeliveryPriceStatus.MiscellanousCredit:
                    result = DTODeliveryPriceStatus.InvoicedMiscCredit;
                    break;
                case DTODeliveryPriceStatus.MiscellanousDebit:
                    result = DTODeliveryPriceStatus.InvoicedMisc;
                    break;
                default:
                    {
                        throw new InvalidOperationException();
                    }

            }
           return result;
        }

        public static bool IsInvoiced(this DTODeliveryPriceStatus? status)
        {
            if (!status.HasValue)
            {
                return false;
            }
            return 
                (status == DTODeliveryPriceStatus.InvoicedNormalDelivery) ||
                (status == DTODeliveryPriceStatus.InvoicedCredit) ||
                (status == DTODeliveryPriceStatus.InvoicedDebit) ||
                (status == DTODeliveryPriceStatus.InvoicedMiscCredit) ||
                (status == DTODeliveryPriceStatus.InvoicedMisc);
        }
    }
}
