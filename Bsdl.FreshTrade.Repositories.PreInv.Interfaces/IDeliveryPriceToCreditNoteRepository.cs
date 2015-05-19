using System.Collections.Generic;
using Bsdl.FreshTrade.Domain.PreInv.Entities;
using Bsdl.FreshTrade.Repositories.Basic.Interfaces;

namespace Bsdl.FreshTrade.Repositories.PreInv.Interfaces
{
    public interface IDeliveryPriceToCreditNoteRepository : IRepositoryBase<DTODeliveryPriceToCreditNote>
    {
        List<DTODeliveryPriceToCreditNote> GetDeliveryPriceToCreditNoteByDeliveryPriceIDs(List<int> deliveryPriceIds);

        List<DTODeliveryToCreditNoteByItemStock> GetDeliveryToCreditNotesByItemStockRecNos(List<int> deliveryPriceRecNos);

        List<int> CheckRelatedCreditNotes(List<int> deliveryPriceRecNos);

        List<DTODeliveryToCreditNoteByItemStock> GetDeliveryToCreditNoteByItemStock(int deliveryPriceRecNo);
    }
}
