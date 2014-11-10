using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Bsdl.FreshTrade.Domain.Basic.Enums;
using Bsdl.FreshTrade.Domain.Basic.Interfaces;
using Bsdl.FreshTrade.Domain.Basic.Utilities.DataTypeHandling;
using Bsdl.FreshTrade.Domain.PreInv.Entities;
using Bsdl.FreshTrade.Repositories.Basic;
using Bsdl.FreshTrade.Repositories.Basic.Interfaces;
using Bsdl.FreshTrade.Repositories.Basic.Utilities.Interfaces;
using Bsdl.FreshTrade.Repositories.PreInv.DBModel;
using Bsdl.FreshTrade.Repositories.PreInv.Interfaces;

namespace Bsdl.FreshTrade.Repositories.PreInv.DiscountRep
{
    public class CustomerDiscountRatesRepository : DapperRepositoryBase<DTOCustDiscountRates>, ICustomerDiscountRatesRepository
    {
        private const string _sqlQuery = @"SELECT 
  D.DlvOrdNo,
  P.DraRecNo, P.DraPrcRef1, P.DraPrcRef2, P.DraPrcRef3, P.DraPrcRef4, P.DraPrcRef5, P.DraPrcRef6, P.StartDate, P.FinishDate, P.SchemeCanc, P.DraStcLoc, P.DraTypOf, P.DraSalOffNo,  
  G.APPLYREBSTOFOC
FROM DELHED D
  INNER JOIN ORDERS O on O.ORDRECNO = D.DlvOrdRecNo
  INNER JOIN Discsts C on C.DisCstCode = O.ORDCSTCODE
  INNER JOIN Disgrps G on  C.CstDisGrpRecNo = G.DISGRPRECNO AND G.IsActive = 1
  INNER JOIN DiscPrds P on C.CstDisGrpRecNo = P.DraDisGrpRecNo AND P.SchemeCanc < 1 AND P.DraTypOf = 1 AND P.StartDate <= D.DlvDelDate AND (P.FinishDate Is Null OR P.FinishDate >= D.DlvDelDate)
";

        public CustomerDiscountRatesRepository(IUnitOfWork unitOfWorkCurrent, ICacheManagerFactory cacheManagerFactory)
            : base
            (
                unitOfWorkCurrent,
                cacheManagerFactory,
                new List<ISearchFieldDef>
                {
                    new SearchFieldDef<DTOCustDiscountRates, int>(i => i.DeliveryHeadId, DELHED.FieldNames.DLVORDNO, FieldType.Integer)
                }
            )
        {
        }

        protected override List<DTOCustDiscountRates> GetDataInternal(List<ISearchField> searchFields, CachingStrategy allowFromCache, uint? topRows)
        {
            string query = ConstructSimpleQuery(_sqlQuery, searchFields, true, topRows);
            var results = UnitOfWorkCurrent.Query<CustomerDiscountRatesResultLine>(query);

            return results
                    .Select(item =>
                        new DTOCustDiscountRates
                        {
                            DeliveryHeadId = item.DlvOrdNo,
                            DraRecNo = item.DraRecNo,
                            DraPrcRef1 = item.DraPrcRef1,
                            DraPrcRef2 = item.DraPrcRef2,
                            DraPrcRef3 = item.DraPrcRef3,
                            DraPrcRef4 = item.DraPrcRef4,
                            DraPrcRef5 = item.DraPrcRef5,
                            DraPrcRef6 = item.DraPrcRef6,
                            StockLocationId = item.DraStcLoc,
                            SalesOfficeNo = item.DraSalOffNo,
                            ApplyRebatesToFreeOfChargeGoods = (item.ApplyRebsToFoc??0) > 0
                        })
                    .ToList();
        }

        public List<DTOCustDiscountRates> GetCustomerDiscountRatesByDeliveryHeadIDs(List<int> deliveryHeadIds)
        {
            return GetDataInChunks(i => i.DeliveryHeadId, deliveryHeadIds);
        }

        public class CustomerDiscountRatesResultLine
        {
            public int DlvOrdNo { get; set; }

            public int DraRecNo { get; set; }
            public int DraPrcRef1 { get; set; }
            public int DraPrcRef2 { get; set; }
            public int DraPrcRef3 { get; set; }
            public int DraPrcRef4 { get; set; }
            public int DraPrcRef5 { get; set; }
            public int DraPrcRef6 { get; set; }
            public int DraStcLoc { get; set; }
            public int DraSalOffNo { get; set; }
            
            public short? ApplyRebsToFoc { get; set; }
        }

    }
}
