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
    /// Entity for the ACCALLVAL table
    /// </summary>
    [DataContract]
    public class AccAllVal 
    {
      
        [DataMember]            
        public int Aavrecno {get; set;}
    
       [DataMember]              
        public decimal? Aavamount {get;set;}

    
       [DataMember]              
        public decimal? Aavbaseamount {get;set;}

    
       [DataMember]              
        public int? Aavcurrecno {get;set;}

    
       [DataMember]              
        public decimal? Aaveuroamount {get;set;}

    }

/*
result.Aavrecno = item.Aavrecno;
  result.Aavamount = item.Aavamount;
  result.Aavbaseamount = item.Aavbaseamount;
  result.Aavcurrecno = item.Aavcurrecno;
  result.Aaveuroamount = item.Aaveuroamount;


            
*/  

/*
Aavrecno = item.Aavrecno,
Aavamount = item.Aavamount,
Aavbaseamount = item.Aavbaseamount,
Aavcurrecno = item.Aavcurrecno,
Aaveuroamount = item.Aaveuroamount,


            
*/  

    }

}
