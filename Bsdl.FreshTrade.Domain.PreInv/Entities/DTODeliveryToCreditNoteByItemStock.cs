namespace Bsdl.FreshTrade.Domain.PreInv.Entities
{
    public class DTODeliveryToCreditNoteByItemStock
    {
        public int ItemStockRecNo { get; set; }
        public int ItemStockQuantity { get; set; }
        public int DisCdsRefNo { get; set; }

        public int Quantity { get; set; }
        public bool AdjustStock { get; set; }
        public int CdsRefNo { get; set; }
        
        public int OrgDprRecNo { get; set; }
    }
}
