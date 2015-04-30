namespace Bsdl.FreshTrade.Domain.Account.Enums
{
    public enum DTOInvoiceType
    {
        Unknown = 0,
        PerDeliveryGrossNoSplit = 1,    // extract Per Delivery gross (don't allow split Orders).
        PerDeliveryGrossAllowSplit = 2, // extract Per Delivery gross (allow split Orders).
        PerDeliveryNettNoSplit = 3,     // extract Per Delivery nett (don't allow split Orders).
        PerDeliveryNettAllowSplit = 4,  // extract Per Delivery nett (allow split Orders).
        CombinedDeliveriesGross = 5,    // extract Combined Deliveries gross.
        CombinedDeliveriesNett = 6,     // extract Combined Deliveries nett.
        CombinedOrdersGross = 7,        // extract Combined Orders gross.
        CombinedOrdersNett = 8,         // extract Combined Orders nett.
        DeliveryNoteInvoice = 9,        // extract Delivery Note is Invoice.
        PerOrderNettOfRelCredits = 10   // extract Per Order Nett of Rel Credits ; doug 30/10/08  -7788
    }
}
