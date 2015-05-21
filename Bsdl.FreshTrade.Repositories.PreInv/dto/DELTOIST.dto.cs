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
    /// Entity for the DELTOIST table
    /// </summary>
    [DataContract]
    public class DELTOIST 
    {
      
        [DataMember]            
        public int Disdprrecno {get; set;}
      
        [DataMember]            
        public int Disistrecno {get; set;}
    
       [DataMember]              
        public int? Discdsrefno {get;set;}

    
       [DataMember]              
        public decimal? Disnettvalue {get;set;}

    
       [DataMember]              
        public int? Disqty {get;set;}

    
       [DataMember]              
        public int? Disstkqty {get;set;}

    
       [DataMember]              
        public decimal? Disstkweight {get;set;}

    
       [DataMember]              
        public decimal? Disvalue {get;set;}

    
       [DataMember]              
        public decimal? Disweight {get;set;}

    }

/*
result.Disdprrecno = item.Disdprrecno;
result.Disistrecno = item.Disistrecno;
  result.Discdsrefno = item.Discdsrefno;
  result.Disnettvalue = item.Disnettvalue;
  result.Disqty = item.Disqty;
  result.Disstkqty = item.Disstkqty;
  result.Disstkweight = item.Disstkweight;
  result.Disvalue = item.Disvalue;
  result.Disweight = item.Disweight;


            
*/  

/*
Disdprrecno = item.Disdprrecno,
Disistrecno = item.Disistrecno,
Discdsrefno = item.Discdsrefno,
Disnettvalue = item.Disnettvalue,
Disqty = item.Disqty,
Disstkqty = item.Disstkqty,
Disstkweight = item.Disstkweight,
Disvalue = item.Disvalue,
Disweight = item.Disweight,


            
*/  

    }

}
