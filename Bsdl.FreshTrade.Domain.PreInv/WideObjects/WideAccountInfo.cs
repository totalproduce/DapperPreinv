using Bsdl.FreshTrade.Domain.Account.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Bsdl.FreshTrade.Domain.Basic.Utilities.DataTypeHandling;

namespace Bsdl.FreshTrade.Domain.PreInv.WideObjects
{
    public class WideAccountInfo: DTOAccount
    {
        public WideAccountInfo()
        {
        }

        public WideAccountInfo(DTOAccount account, string localAccountCode)
        {
            ObjectHandling.CopyObjectState<DTOAccount>(account, this);
            LocalAccountCode = localAccountCode;
        }
            
        public string LocalAccountCode { get; set; }
    }
}
