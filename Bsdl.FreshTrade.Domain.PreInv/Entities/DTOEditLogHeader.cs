using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace Bsdl.FreshTrade.Domain.PreInv.Entities
{
    [DataContract]
    public class DTOEdiLogHeader
    {

        [DataMember]
        public int Ehheadid { get; set; }

        [DataMember]
        public decimal Ehbaserate { get; set; }


        [DataMember]
        public int? Ehbatchprintno { get; set; }


        [DataMember]
        public int? Ehbatrecno { get; set; }


        [DataMember]
        public int? Ehcompanyno { get; set; }


        [DataMember]
        public int? Ehcurno { get; set; }


        [DataMember]
        public decimal Eheurorate { get; set; }


        [DataMember]
        public int? Ehhocode { get; set; }


        [DataMember]
        public int? Ehsalesoffice { get; set; }


        [DataMember]
        public DateTime? Ehtransdate { get; set; }


        [DataMember]
        public string Ehtransfilename { get; set; }


        [DataMember]
        public string Ehtransformat { get; set; }


        [DataMember]
        public int? Ehtransrecno { get; set; }


        [DataMember]
        public int? Ehtransref { get; set; }


        [DataMember]
        public string Ehtranstype { get; set; }


        [DataMember]
        public short? Ehtriangulate { get; set; }

    }

    //joined invoice details
    public class DTOEdiLogHeaderWide 
    {
        // header
        [DataMember]
        public int EHHeadId { get; set; }

        [DataMember]
        public decimal Ehbaserate { get; set; }


        [DataMember]
        public int? Ehbatchprintno { get; set; }


        [DataMember]
        public int? Ehbatrecno { get; set; }


        [DataMember]
        public int? Ehcompanyno { get; set; }


        [DataMember]
        public int? Ehcurno { get; set; }


        [DataMember]
        public decimal Eheurorate { get; set; }


        [DataMember]
        public int? Ehhocode { get; set; }


        [DataMember]
        public int? Ehsalesoffice { get; set; }


        [DataMember]
        public DateTime? Ehtransdate { get; set; }


        [DataMember]
        public string Ehtransfilename { get; set; }


        [DataMember]
        public string Ehtransformat { get; set; }


        [DataMember]
        public int? Ehtransrecno { get; set; }


        [DataMember]
        public int? Ehtransref { get; set; }


        [DataMember]
        public string Ehtranstype { get; set; }


        [DataMember]
        public short? Ehtriangulate { get; set; }

        // / header

        // detail

        [DataMember]
        public int Eiinvoiceid { get; set; }

        [DataMember]
        public int? Eiatrrecno { get; set; }


        [DataMember]
        public int? Eiheadid { get; set; }


        [DataMember]
        public decimal Eitotaldiscount { get; set; }


        [DataMember]
        public decimal Eitotalgoods { get; set; }


        [DataMember]
        public decimal Eitotalinvoiced { get; set; }


        [DataMember]
        public decimal Eitotalvat { get; set; }

        // /detail
    }

}
