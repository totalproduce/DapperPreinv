namespace Bsdl.FreshTrade.Services.PreInv.Model.Reports
{
    public class PreInvErrorType
    {
        public virtual int Id { get; set; }

        public virtual string Reason { get; set; }

        public virtual bool IsCritial { get; set; }
    }
}
