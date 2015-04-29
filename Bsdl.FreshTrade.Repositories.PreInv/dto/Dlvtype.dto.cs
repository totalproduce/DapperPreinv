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
    /// Entity for the DLVTYPE table
    /// </summary>
    [DataContract]
    public class Dlvtype 
    {
      
        [DataMember]            
        public int Dltrecno {get; set;}
    
       [DataMember]              
        public string Capepricemethod {get;set;}

    
       [DataMember]              
        public string Deliverycondition {get;set;}

    
       [DataMember]              
        public string Deliveryconditiondesc {get;set;}

    
       [DataMember]              
        public short Dutycharged {get;set;}

    
       [DataMember]              
        public short Goodsonconsignment {get;set;}

    
       [DataMember]              
        public int? Owncollection {get;set;}

    
       [DataMember]              
        public short? Showinwholesale {get;set;}

    }

/*
result.Dltrecno = item.Dltrecno;
  result.Capepricemethod = item.Capepricemethod;
  result.Deliverycondition = item.Deliverycondition;
  result.Deliveryconditiondesc = item.Deliveryconditiondesc;
  result.Dutycharged = item.Dutycharged;
  result.Goodsonconsignment = item.Goodsonconsignment;
  result.Owncollection = item.Owncollection;
  result.Showinwholesale = item.Showinwholesale;


            
*/  

/*
Dltrecno = item.Dltrecno,
Capepricemethod = item.Capepricemethod,
Deliverycondition = item.Deliverycondition,
Deliveryconditiondesc = item.Deliveryconditiondesc,
Dutycharged = item.Dutycharged,
Goodsonconsignment = item.Goodsonconsignment,
Owncollection = item.Owncollection,
Showinwholesale = item.Showinwholesale,


            
*/  

    }

}
