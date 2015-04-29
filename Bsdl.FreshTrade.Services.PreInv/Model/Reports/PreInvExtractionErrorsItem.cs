namespace Bsdl.FreshTrade.Services.PreInv.Model.Reports
{
    public class PreInvExtractionErrorsItem
    {
        public virtual int Id { get; set; }

        public virtual int ExtractSessionId { get; set; }

        public virtual PreInvErrorType Type { get; set; }

        public virtual string CustomerCode { get; set; }

        public virtual string OrderId { get; set; }

        public virtual int? DeliveryId { get; set; }
    }
}
