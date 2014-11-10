using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace Bsdl.FreshTrade.Domain.PreInv.Entities
{
    [DataContract]
    public class DTODelAuditRecord
    {
        [DataMember]
        public int DelAudIntTyp { get; set; }

        [DataMember]
        public int DelAudIntRecno { get; set; }

        [DataMember]
        public DateTime? DelAudIntDate { get; set; }


        [DataMember]
        public int? DelAudIntDelRecNo { get; set; }


        [DataMember]
        public string DelaudIntFrom { get; set; }


        [DataMember]
        public int? DelAudIntGrpNo { get; set; }


        [DataMember]
        public string DelAudIntTo { get; set; }

        [DataMember]
        public int? DprRecNoInt { get; set; }


        [DataMember]
        public int? FormIntNo { get; set; }


        [DataMember]
        public int? LogonIntNo { get; set; }
    }

}
