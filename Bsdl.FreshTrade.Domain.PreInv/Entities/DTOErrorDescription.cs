using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace Bsdl.FreshTrade.Domain.PreInv.Entities
{
    [DataContract]
    public class DTOErrorDescription
    {
        [DataMember]
        public int No { get; set; }

        [DataMember]
        public string Reason { get; set; }

        [DataMember]
        public bool IsCritial { get; set; }
    }
}
