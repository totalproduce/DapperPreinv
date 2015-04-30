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
    /// Entity for the PREINVERRORS table
    /// </summary>
    [DataContract]
    public class PreInvError 
    {
      
        [DataMember]            
        public int Errno {get; set;}
    
       [DataMember]              
        public short? Erriscritical {get;set;}

    
       [DataMember]              
        public string Errreason {get;set;}

    }

/*
result.Errno = item.Errno;
  result.Erriscritical = item.Erriscritical;
  result.Errreason = item.Errreason;


            
*/  

/*
Errno = item.Errno,
Erriscritical = item.Erriscritical,
Errreason = item.Errreason,


            
*/  

    }

}
