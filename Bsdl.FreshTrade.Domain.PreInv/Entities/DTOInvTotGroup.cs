using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Bsdl.FreshTrade.Domain.PreInv.Enums;

namespace Bsdl.FreshTrade.Domain.PreInv.Entities
{
    public class DTOInvTotGroup
    {
        public PreInvInvoiceType InvoiceType { get; set; }
        public PreInvBatchType BatchType { get; set; }

        public DTOInvTotGroup (PreInvInvoiceType invoiceType, PreInvBatchType batchType)
        {
            InvoiceType = invoiceType;
            BatchType = batchType;
        }

        public override bool Equals(object obj)
        {
            if ((obj == null) || (GetType() != obj.GetType()))
            {
                return false;
            }

            var group = (DTOInvTotGroup) obj;
            if (group.InvoiceType != InvoiceType)
            {
                return false;
            }
            if (group.BatchType != BatchType)
            {
                return false;
            }

            return true;
        }

        public override int GetHashCode()
        {
            unchecked
            {
                return (int) InvoiceType*397 + (int) BatchType;
            }
        }

    }
}
