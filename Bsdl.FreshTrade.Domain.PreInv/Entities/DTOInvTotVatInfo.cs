using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace Bsdl.FreshTrade.Domain.PreInv.Entities
{
    [DataContract]
    public class DTOInvTotVatInfo
    {
        [DataMember]
        public int Cde { get; set; }

        [DataMember]
        public int? AvaVeaRec { get; set; }

        [DataMember]
        public decimal Gds { get; set; }

        [DataMember]
        public decimal EuroGds { get; set; }

        [DataMember]
        public decimal BaseGds { get; set; }

        [DataMember]
        public int? VatLnkRecNo { get; set; }

        [DataMember]
        public decimal Rte { get; set; }

        [DataMember]
        public decimal Vat { get; set; }

        [DataMember]
        public decimal EuroVat { get; set; }

        [DataMember]
        public decimal BaseVat { get; set; }


        [DataMember]
        public decimal Rte2 { get; set; }

        [DataMember]
        public decimal Vat2 { get; set; }

        [DataMember]
        public decimal EuroVat2 { get; set; }

        [DataMember]
        public decimal BaseVat2 { get; set; }
    }
}
