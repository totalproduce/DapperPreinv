using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace Bsdl.FreshTrade.Domain.PreInv.Entities
{
    [DataContract]
    public class DTOInvEdi
    {
        [DataMember]
        public int ExtractSessionID { get; set; }

        [DataMember]
        public string Companyname { get; set; }


        [DataMember]
        public string Edifile { get; set; }


        [DataMember]
        public int? Ehheadid { get; set; }


        [DataMember]
        public int? Fileno { get; set; }


        [DataMember]
        public int? Hofclarecno { get; set; }


        [DataMember]
        public string HofCstCode { get; set; }


        [DataMember]
        public string Hofcstname { get; set; }


        [DataMember]
        public short? Newfile { get; set; }


        [DataMember]
        public short? Newtransref { get; set; }


        [DataMember]
        public int? PrcGlbRecNo { get; set; }

    }
}
