using Bsdl.FreshTrade.Domain.PreInv.Enums;
using System.Collections.Generic;

namespace Bsdl.FreshTrade.Domain.PreInv.Entities
{
    public class DTOGLLookupParams
    {
        public PreInvGLLookupType LookupType { get; set; }

        public int? SalesOfficeNo { get; set; }
        
        public int? AccountGLType { get; set; }

        public int? ProductAnalysisGroup { get; set; }

        public int? VatRecId { get; set; }

        public int? VatType { get; set; }

        public int? DiscountRebateGLNo { get; set; }


    }

    public class DTOGLLookupParamsComparer : IEqualityComparer<DTOGLLookupParams>
    {
        public bool Equals(DTOGLLookupParams x, DTOGLLookupParams y)
        {
            return
                (x.LookupType == y.LookupType) &&
                (x.SalesOfficeNo == y.SalesOfficeNo) &&
                (x.AccountGLType == y.AccountGLType) &&
                (x.ProductAnalysisGroup == y.ProductAnalysisGroup) &&
                (x.VatRecId == y.VatRecId) &&
                (x.VatType == y.VatType) &&
                (x.DiscountRebateGLNo == y.DiscountRebateGLNo);
        }

        public int GetHashCode(DTOGLLookupParams item)
        {
            unchecked
            {
                int result = item.LookupType.GetHashCode();
                result = result*7 + (item.SalesOfficeNo ?? 0) + 1;
                result = result*7 + (item.AccountGLType ?? 0) + 1;
                result = result*7 + (item.ProductAnalysisGroup ?? 0) + 1;
                result = result*7 + (item.VatRecId ?? 0) + 1;
                result = result * 7 + (item.VatType ?? 0) + 1;
                result = result * 7 + (item.DiscountRebateGLNo ?? 0) + 1;
                return result;
            }
        }
    }
}
