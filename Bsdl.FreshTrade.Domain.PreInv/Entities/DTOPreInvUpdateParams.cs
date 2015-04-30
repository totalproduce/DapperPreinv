using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Bsdl.FreshTrade.Domain.PreInv.Entities
{
    [DataContract]
    public class DTOPreInvUpdateParams
    {
        [DataMember]
        public List<string> SelectedPreInvTot { get; set; }

        [DataMember]
        public List<int> SelectedPreInvPrt { get; set; }

        [DataMember]
        public List<int> SelectedPreInvPrt2 { get; set; }
        
        [DataMember]
        public bool MergeLikePrices { get; set; }

    }
}
