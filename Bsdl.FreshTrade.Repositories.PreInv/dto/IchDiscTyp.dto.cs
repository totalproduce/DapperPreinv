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
    /// Entity for the ICHDISCTYP table
    /// </summary>
    [DataContract]
    public class IchDiscTyp 
    {
      
        [DataMember]            
        public int Ichrecno {get; set;}
    
       [DataMember]              
        public string Discdedstr {get;set;}

    
       [DataMember]              
        public int? Discgrpglrecno {get;set;}

    }

/*
result.Ichrecno = item.Ichrecno;
  result.Discdedstr = item.Discdedstr;
  result.Discgrpglrecno = item.Discgrpglrecno;


            
*/  

/*
Ichrecno = item.Ichrecno,
Discdedstr = item.Discdedstr,
Discgrpglrecno = item.Discgrpglrecno,


            
*/  

    }

}
