using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using Bsdl.FreshTrade.Domain.Basic.Utilities.DataTypeHandling;

namespace Bsdl.FreshTrade.Domain.PreInv.Enums
{
    public enum EnumDiscTypesStage
    {
        OnInvoice = 1,
        OnPayment = 2, 
        Retro = 3
    }

    public enum EnumDiscTypesMethod
    {
        Ordinary = 1,
        Percentage = 2,
        StandardUnitRate = 3
    }

    public enum EnumDiscTypes
    {
        OnInvoiceRate  = 1,  
        OnInvoicePercent  = 101,
        OnInvoiceLceRate = 201,
        OnPaymentRate = 2,
        OnPaymentPercent = 102,
        OnPaymentLceRate = 202,
        RetroRate  = 3,  
        RetroPercent  = 103,
        RetroLceRate  = 203
    }

    public static class DiscTypesExtensions
    {
        public static EnumDiscTypesStage GetStage(this EnumDiscTypes discTyp)
        {
            return Enums<EnumDiscTypesStage>.GetValue((int)discTyp%100);
        }

        public static EnumDiscTypesMethod GetMethod(this EnumDiscTypes discTyp)
        {
            return Enums<EnumDiscTypesMethod>.GetValue(1+((int)discTyp/100));
        }

        public static EnumDiscTypes Combine(this EnumDiscTypesStage stage, EnumDiscTypesMethod method)
        {
            return Enums<EnumDiscTypes>.GetValue((int)stage + ((int)method - 1) * 100);
        }
    }
}
