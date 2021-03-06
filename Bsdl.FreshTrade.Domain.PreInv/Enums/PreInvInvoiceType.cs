﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace Bsdl.FreshTrade.Domain.PreInv.Enums
{
    [DataContract]
    [Flags]
    public enum PreInvInvoiceType
    {
        [EnumMember]
        Invoice = 1,

        [EnumMember]
        CreditNote = 2,

        [EnumMember]
        DebitNote = 4
    }

    public static class PreInvInvoiceTypeExtentions
    {
        public static List<PreInvInvoiceType> GetAsListOfSimpleValues(this PreInvInvoiceType invoiceType)
        {
            var result = new List<PreInvInvoiceType>();
            if ((invoiceType & PreInvInvoiceType.Invoice) != 0)
            {
                result.Add(PreInvInvoiceType.Invoice);
            }
            if ((invoiceType & PreInvInvoiceType.CreditNote) != 0)
            {
                result.Add(PreInvInvoiceType.CreditNote);
            }
            if ((invoiceType & PreInvInvoiceType.DebitNote) != 0)
            {
                result.Add(PreInvInvoiceType.DebitNote);
            }

            return result;
        }

        public static string ConvertToString(this PreInvInvoiceType accountInvoiceType)
        {
            var result = new StringBuilder();
            if ((accountInvoiceType & PreInvInvoiceType.Invoice) != 0)
            {
                result.Append("Invoice");
            }
            if ((accountInvoiceType & PreInvInvoiceType.CreditNote) != 0)
            {
                if (result.Length > 0)
                {
                    result.Append(", ");
                }
                result.Append("Credit Note");
            }
            if ((accountInvoiceType & PreInvInvoiceType.DebitNote) != 0)
            {
                if (result.Length > 0)
                {
                    result.Append(", ");
                }
                result.Append("Debit Note");
            }
            return result.ToString();
        }
    }
}
