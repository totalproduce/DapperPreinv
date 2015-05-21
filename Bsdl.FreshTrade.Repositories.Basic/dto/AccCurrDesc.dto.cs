// <summary>
// This file is generated automatically. Any changes will be lost.
// </summary>

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Runtime.Serialization;

namespace Bsdl.FreshTrade.Repositories.Basic.dto
{
    /// <summary>
    /// Entity for the ACCCURRDESC table
    /// </summary>
    [DataContract]
    public class AccCurrDesc 
    {
      
        [DataMember]            
        public int Curno {get; set;}
    
       [DataMember]              
        public string Curcode {get;set;}

    
       [DataMember]              
        public int? Curdecimalplaces {get;set;}

    
       [DataMember]              
        public string Curdecimalpoint {get;set;}

    
       [DataMember]              
        public int? Curdefbanrecno {get;set;}

    
       [DataMember]              
        public string Curdesc {get;set;}

    
       [DataMember]              
        public string Curextnnumpicture {get;set;}

    
       [DataMember]              
        public string Cursymbol {get;set;}

    
       [DataMember]              
        public short Cursymbolatfront {get;set;}

    
       [DataMember]              
        public string Curthousandseparator {get;set;}

    
       [DataMember]              
        public short Curtriangreq {get;set;}

    
       [DataMember]              
        public string Curunitnumpicture {get;set;}

    }

/*
result.Curno = item.result.Curno;
  result.Curcode = item.result.Curcode;
  result.Curdecimalplaces = item.result.Curdecimalplaces;
  result.Curdecimalpoint = item.result.Curdecimalpoint;
  result.Curdefbanrecno = item.result.Curdefbanrecno;
  result.Curdesc = item.result.Curdesc;
  result.Curextnnumpicture = item.result.Curextnnumpicture;
  result.Cursymbol = item.result.Cursymbol;
  result.Cursymbolatfront = item.result.Cursymbolatfront;
  result.Curthousandseparator = item.result.Curthousandseparator;
  result.Curtriangreq = item.result.Curtriangreq;
  result.Curunitnumpicture = item.result.Curunitnumpicture;


            
*/  

    }

}
