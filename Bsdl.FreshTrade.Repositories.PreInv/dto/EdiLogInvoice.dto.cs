// <summary>
// This file is generated automatically. Any changes will be lost.
// </summary>

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Runtime.Serialization;

namespace Bsdl.FreshTrade.Repositories.PreInv.dto
{
    /// <summary>
    /// Entity for the EDILOGINVOICE table
    /// </summary>
    [DataContract]
    public class EdiLogInvoice 
    {
      
        [DataMember]            
        public int Eiinvoiceid {get; set;}
    
       [DataMember]              
        public int? Eiatrrecno {get;set;}

    
       [DataMember]              
        public int? Eiheadid {get;set;}

    
       [DataMember]              
        public decimal? Eitotaldiscount {get;set;}

    
       [DataMember]              
        public decimal? Eitotalgoods {get;set;}

    
       [DataMember]              
        public decimal? Eitotalinvoiced {get;set;}

    
       [DataMember]              
        public decimal? Eitotalvat {get;set;}

    }

/*
result.Eiinvoiceid = item.Eiinvoiceid;
  result.Eiatrrecno = item.Eiatrrecno;
  result.Eiheadid = item.Eiheadid;
  result.Eitotaldiscount = item.Eitotaldiscount;
  result.Eitotalgoods = item.Eitotalgoods;
  result.Eitotalinvoiced = item.Eitotalinvoiced;
  result.Eitotalvat = item.Eitotalvat;


            
*/  

/*
Eiinvoiceid = item.Eiinvoiceid,
Eiatrrecno = item.Eiatrrecno,
Eiheadid = item.Eiheadid,
Eitotaldiscount = item.Eitotaldiscount,
Eitotalgoods = item.Eitotalgoods,
Eitotalinvoiced = item.Eitotalinvoiced,
Eitotalvat = item.Eitotalvat,


            
*/  

    }

}
