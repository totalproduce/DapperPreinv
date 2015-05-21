using System.Runtime.Serialization;
using Bsdl.FreshTrade.Domain.Basic.Interfaces;

namespace Bsdl.FreshTrade.Domain.Basic.Entities
{
    [DataContract]
    public class DTOFreshTradeDisplayID : IDTOFreshTradeDisplayID
    {
        public DTOFreshTradeDisplayID()
        {
        }

        public DTOFreshTradeDisplayID(decimal freshTradeDisplayUId, string freshTradeDisplayName, decimal freshTradeDisplayLanguaged, string freshTradeDisplayTitle, decimal freshTradeDisplayLevel, decimal freshTradeDisplayModuleNo)
        {
            this.FreshTradeDisplayUID = freshTradeDisplayUId;
            this.FreshTradeDisplayName = freshTradeDisplayName;
            this.FreshTradeDisplayLanguaged = freshTradeDisplayLanguaged;
            this.FreshTradeDisplayTitle = freshTradeDisplayTitle;
            this.FreshTradeDisplayLevel = freshTradeDisplayLevel;
            this.FreshTradeDisplayModuleNo = freshTradeDisplayModuleNo;
        }

        [DataMember]
        public decimal FreshTradeDisplayUID { get; set; }

        [DataMember]
        public string FreshTradeDisplayName { get; set; }

        [DataMember]
        public decimal FreshTradeDisplayLanguaged { get; set; }

        [DataMember]
        public string FreshTradeDisplayTitle { get; set; }

        [DataMember]
        public decimal FreshTradeDisplayLevel { get; set; }

        [DataMember]
        public decimal FreshTradeDisplayModuleNo { get; set; }
    }
}
