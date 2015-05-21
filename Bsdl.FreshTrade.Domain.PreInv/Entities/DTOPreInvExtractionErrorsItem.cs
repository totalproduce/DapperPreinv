using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using Bsdl.FreshTrade.Domain.PreInv.Enums;

namespace Bsdl.FreshTrade.Domain.PreInv.Entities
{
    [DataContract]
    public class DTOPreInvExtractionErrorsItem
    {
        [DataMember]
        public int ExtractSessionID { get; set; }

        [DataMember]
        public int? Id { get; set; }

        [DataMember]
        public PreInvExtractionErrorTypes Type { get; set; }

        [DataMember]
        public DTOErrorDescription ErrorDescription { get; set; }

        [DataMember]
        public string CustomerCode { get; set; }

        [DataMember]
        public string OrderNo { get; set; }

        [DataMember]
        public int? DeliveryNo { get; set; }
    }
}
