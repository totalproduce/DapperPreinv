using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using Bsdl.FreshTrade.Domain.PreInv.Enums;

namespace Bsdl.FreshTrade.Domain.PreInv.Entities
{
    [DataContract]
    public class DTOPreInvExtractAccountParams
    {
        [DataMember]
        public PreInvExtractAccountFilterType FilterType { get; set; }

        [DataMember]
        public int? AccountClassId { get; set; }

        [DataMember]
        public List<int> Categories { get; set; } /*CSTANDES.CSARECNO NUMBER(5, 0)*/
    }
}
