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
    /// Table to group credit / debit note DELPRICEs into group for transaction generation
    /// </summary>
    [DataContract]
    public class DelPriceCreditRef 
    {
        /// <summary>
        /// Primary Key
        /// </summary>
      
        [DataMember]            
        public int Dprcdtrefno {get; set;}
        /// <summary>
        /// Reference for this group of credit / debit lines
        /// </summary>
    
       [DataMember]              
        public string Creditref {get;set;}

        /// <summary>
        /// Foreign Key - DELHED.DLVORDNO
        /// </summary>
    
       [DataMember]              
        public int Dlvordno {get;set;}

        /// <summary>
        /// Status indicator. 1 = open, 10 = invoiced
        /// </summary>
    
       [DataMember]              
        public int Invstatus {get;set;}

    }

/*
result.Dprcdtrefno = item.Dprcdtrefno;
  result.Creditref = item.Creditref;
  result.Dlvordno = item.Dlvordno;
  result.Invstatus = item.Invstatus;


            
*/  

/*
Dprcdtrefno = item.Dprcdtrefno,
Creditref = item.Creditref,
Dlvordno = item.Dlvordno,
Invstatus = item.Invstatus,


            
*/  

    }

}
