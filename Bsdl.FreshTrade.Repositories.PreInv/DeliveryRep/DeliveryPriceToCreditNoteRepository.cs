using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Bsdl.FreshTrade.Domain.Basic.Enums;
using Bsdl.FreshTrade.Domain.Basic.Interfaces;
using Bsdl.FreshTrade.Domain.PreInv.Entities;
using Bsdl.FreshTrade.Repositories.Basic;
using Bsdl.FreshTrade.Repositories.Basic.Interfaces;
using Bsdl.FreshTrade.Repositories.Basic.Utilities.Interfaces;
using Bsdl.FreshTrade.Repositories.PreInv.DBModel;
using Bsdl.FreshTrade.Repositories.PreInv.Interfaces;

namespace Bsdl.FreshTrade.Repositories.PreInv.DeliveryRep
{
    public class DeliveryPriceToCreditNoteRepository : DapperRepositoryBase<DTODeliveryPriceToCreditNote>, IDeliveryPriceToCreditNoteRepository
    {
        private const string SqlQuery = @"SELECT * FROM DELTOCDT";

        private const string SqlDeltoCdtByItesto =
            @"SELECT
  S.DisIstRecNo,
  S.DisStkQty,
  S.DisCdsRefNo,
  Adj.CdsAdjustStk,
  Adj.CdsRefNo,
  Ceil
  (
    Case When NVL(P.adjby, NVL(D.qtyper,1)) <> NVL(D.qtyper,1)
    then
      Case When Abs(D.delnettweight) > 0.009
        then S.DisQty / delnettweight
        else S.DisQty 
      end                   
    else S.DisQty
  end 
  )DisQty,
  C.OrgDprRecNo
FROM DelToIst S
  INNER JOIN Delprice P ON S.DisDprRecNo = P.DprRecNo
  INNER JOIN Deldet D ON P.DprDelRecNo = D.DelRecNo
  LEFT OUTER JOIN Cdstkadj Adj ON S.DisCdsRefNo = Adj.CdsRefNo
  INNER JOIN DelTocdt C ON S.DisDprRecNo = C.CdtDprRecNo
WHERE C.OrgDprRecNo ";

        private const string SqlCheckRelatedCreditNotes = "SELECT DPRRECNO FROM CDTNONREL WHERE DPRRECNO ";

        public DeliveryPriceToCreditNoteRepository(IUnitOfWork unitOfWorkCurrent, ICacheManagerFactory cacheManagerFactory)
            : base
                (
                unitOfWorkCurrent,
                cacheManagerFactory,
                new List<ISearchFieldDef>
                {
                        new SearchFieldDef<DTODeliveryPriceToCreditNote, int>(i => i.CreditNoteDeliveryPriceRefNo,
                                                                        DelToCdt.FieldNames.CDTDPRRECNO,
                                                                        FieldType.Integer)
                    }
                )
        {
        }

        protected override List<DTODeliveryPriceToCreditNote> GetDataInternal(List<ISearchField> searchFields,
                                                                        CachingStrategy allowFromCache, uint? topRows)
        {
            string query = ConstructSimpleQuery(SqlQuery, searchFields, true, topRows);
            var results = UnitOfWorkCurrent.Query<DelToCdt>(query);

            return results
                .Select(item =>
                        new DTODeliveryPriceToCreditNote
                            {
                                CreditNoteDeliveryPriceRefNo = item.Cdtdprrecno,
                                OriginalDeliveryPriceRefNo = item.Orgdprrecno.HasValue ? item.Orgdprrecno.Value : 0
                            })
                .ToList();
        }


        public List<DTODeliveryPriceToCreditNote> GetDeliveryPriceToCreditNoteByDeliveryPriceIDs(List<int> deliveryPriceIds)
        {
            return GetDataInChunks(i => i.CreditNoteDeliveryPriceRefNo, deliveryPriceIds);
        }

        public List<DTODeliveryToCreditNoteByItemStock> GetDeliveryToCreditNotesByItemStockRecNos(List<int> deliveryPriceRecNos)
        {

            var results = GetDataInChunksCustom
                          (
                              i =>
                              UnitOfWorkCurrent.Query<DeliveryToCreditNoteByItemStockResultLine>
                              (
                                String.Format("{0} in({1})", SqlDeltoCdtByItesto, String.Join<int>(",", i))                               
                              ).ToList(),
                              deliveryPriceRecNos
                          );
            return results.Select(item => item.ToDTO()).ToList();
        }

        public List<int> CheckRelatedCreditNotes(List<int> deliveryPriceRecNos)
        {
            var results = GetDataInChunksCustom
                          (
                              i =>
                              UnitOfWorkCurrent.Query<int>
                              (
                                String.Format("{0} in({1})", SqlCheckRelatedCreditNotes, String.Join<int>(",", i))
                              ).ToList(),
                              deliveryPriceRecNos
                          );
            return results;
        }

        public List<DTODeliveryToCreditNoteByItemStock> GetDeliveryToCreditNoteByItemStock(int deliveryPriceRecNo)
        {
            string query = String.Format("{0} = {1}",SqlDeltoCdtByItesto,deliveryPriceRecNo);
            var results = UnitOfWorkCurrent.Query<DeliveryToCreditNoteByItemStockResultLine>(query);

            return results.Select(item => item.ToDTO()).ToList();
        }
    }

    public class DeliveryToCreditNoteByItemStockResultLine
    {
        public int DisIstRecNo { get; set; }
        public int DisStkQty { get; set; }
        public int DisCdsRefNo { get; set; }
        public int CdsAdjustStk { get; set; }
        public int CdsRefNo { get; set; }
        public int DisQty { get; set; }
        public int OrgDprRecNo { get; set; }

        public DTODeliveryToCreditNoteByItemStock ToDTO()
        {
            return
                new DTODeliveryToCreditNoteByItemStock
                    {
                        ItemStockRecNo = DisIstRecNo,
                        ItemStockQuantity = DisStkQty,
                        DisCdsRefNo = DisCdsRefNo,
                        AdjustStock = CdsAdjustStk == 1,
                        CdsRefNo = CdsRefNo,
                        Quantity = DisQty,
                        OrgDprRecNo = OrgDprRecNo
                    };
        }
    }
}
