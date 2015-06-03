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
    /// Entity for the DISRATES table
    /// </summary>
    [DataContract]
    public class DisRates 
    {
      
        [DataMember]            
        public int Drarecno {get; set;}
      
        [DataMember]            
        public int Thisseqno {get; set;}
    
       [DataMember]              
        public short? Discinclduty {get;set;}

    
       [DataMember]              
        public int? Disglrecno {get;set;}

    
       [DataMember]              
        public string Thisdedstr {get;set;}

    
       [DataMember]              
        public int Thison {get;set;}

    
       [DataMember]              
        public decimal Thispercrate {get;set;}

    
       [DataMember]              
        public decimal Thisrate {get;set;}

    
       [DataMember]              
        public decimal Thisstndunitrate {get;set;}

    }

/*
result.Drarecno = item.Drarecno;
result.Thisseqno = item.Thisseqno;
  result.Discinclduty = item.Discinclduty;
  result.Disglrecno = item.Disglrecno;
  result.Thisdedstr = item.Thisdedstr;
  result.Thison = item.Thison;
  result.Thispercrate = item.Thispercrate;
  result.Thisrate = item.Thisrate;
  result.Thisstndunitrate = item.Thisstndunitrate;


            
*/  

/*
Drarecno = item.Drarecno,
Thisseqno = item.Thisseqno,
Discinclduty = item.Discinclduty,
Disglrecno = item.Disglrecno,
Thisdedstr = item.Thisdedstr,
Thison = item.Thison,
Thispercrate = item.Thispercrate,
Thisrate = item.Thisrate,
Thisstndunitrate = item.Thisstndunitrate,


            
*/  

    }

}
