
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
    /// Entity for the VATRATES table
    /// </summary>
    [DataContract]
    public class VatRates 
    {
      
        [DataMember]            
        public int Vatrecno {get; set;}
    
       [DataMember]              
        public short Exclfromvatextract {get;set;}

    
       [DataMember]              
        public int? Formno {get;set;}

    
       [DataMember]              
        public short? Intercee {get;set;}

    
       [DataMember]              
        public int? Lstlogonno {get;set;}

    
       [DataMember]              
        public int? Slpltype {get;set;}

    
       [DataMember]              
        public string Vatdesc {get;set;}

    
       [DataMember]              
        public int? Vatganrecno {get;set;}

    
       [DataMember]              
        public decimal? Vatrate {get;set;}

    
       [DataMember]              
        public decimal? Vatrate2 {get;set;}

    }

/*
result.Vatrecno = item.Vatrecno;
  result.Exclfromvatextract = item.Exclfromvatextract;
  result.Formno = item.Formno;
  result.Intercee = item.Intercee;
  result.Lstlogonno = item.Lstlogonno;
  result.Slpltype = item.Slpltype;
  result.Vatdesc = item.Vatdesc;
  result.Vatganrecno = item.Vatganrecno;
  result.Vatrate = item.Vatrate;
  result.Vatrate2 = item.Vatrate2;


            
*/  

/*
Vatrecno = item.Vatrecno,
Exclfromvatextract = item.Exclfromvatextract,
Formno = item.Formno,
Intercee = item.Intercee,
Lstlogonno = item.Lstlogonno,
Slpltype = item.Slpltype,
Vatdesc = item.Vatdesc,
Vatganrecno = item.Vatganrecno,
Vatrate = item.Vatrate,
Vatrate2 = item.Vatrate2,


            
*/  

    }

}
