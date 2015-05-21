using System;
using System.Runtime.Serialization;

namespace Bsdl.FreshTrade.Domain.PreInv.Entities
{
    [DataContract]
    public class DTODelAuditRecord
    {
        [DataMember]
        public int DelAudTyp { get; set; }

        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public DateTime? DelAudDate { get; set; }


        [DataMember]
        public int? DelAudDelRecNo { get; set; }


        [DataMember]
        public string DelAudFrom { get; set; }


        [DataMember]
        public int? DelAudGrpNo { get; set; }


        [DataMember]
        public string DelAudTo { get; set; }

        [DataMember]
        public int? DprRecNo { get; set; }


        [DataMember]
        public int? FormNo { get; set; }

        [DataMember]
        public string FormName { get; set; }

        [DataMember]
        public int? LogonNo { get; set; }
    }

}
