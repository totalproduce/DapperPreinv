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
    /// Entity for the DISGRPS table
    /// </summary>
    [DataContract]
    public class DisGrps 
    {
      
        [DataMember]            
        public int Disgrprecno {get; set;}
    
       [DataMember]              
        public short? Applyrebstofoc {get;set;}

    
       [DataMember]              
        public string Discommdesc {get;set;}

    
       [DataMember]              
        public int Discstsup {get;set;}

    
       [DataMember]              
        public string Disdesc {get;set;}

    
       [DataMember]              
        public int? Dishancommvatcode {get;set;}

    
       [DataMember]              
        public string Dishanddesc {get;set;}

    
       [DataMember]              
        public int? Dissaloffno {get;set;}

    
       [DataMember]              
        public short Isactive {get;set;}

    }

/*
result.Disgrprecno = item.Disgrprecno;
  result.Applyrebstofoc = item.Applyrebstofoc;
  result.Discommdesc = item.Discommdesc;
  result.Discstsup = item.Discstsup;
  result.Disdesc = item.Disdesc;
  result.Dishancommvatcode = item.Dishancommvatcode;
  result.Dishanddesc = item.Dishanddesc;
  result.Dissaloffno = item.Dissaloffno;
  result.Isactive = item.Isactive;


            
*/  

/*
Disgrprecno = item.Disgrprecno,
Applyrebstofoc = item.Applyrebstofoc,
Discommdesc = item.Discommdesc,
Discstsup = item.Discstsup,
Disdesc = item.Disdesc,
Dishancommvatcode = item.Dishancommvatcode,
Dishanddesc = item.Dishanddesc,
Dissaloffno = item.Dissaloffno,
Isactive = item.Isactive,


            
*/  

    }

}
