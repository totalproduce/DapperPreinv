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
    /// Entity for the CDTNONREL table
    /// </summary>
    [DataContract]
    public class CreditNoteToDelivery 
    {
      
        [DataMember]            
        public int Dprrecno {get; set;}
      
        [DataMember]            
        public int Pallocrecno {get; set;}
    
       [DataMember]              
        public int? Dlvordno {get;set;}

    }

/*
result.Dprrecno = item.Dprrecno;
result.Pallocrecno = item.Pallocrecno;
  result.Dlvordno = item.Dlvordno;


            
*/  

/*
Dprrecno = item.Dprrecno,
Pallocrecno = item.Pallocrecno,
Dlvordno = item.Dlvordno,


            
*/  

    }

}
