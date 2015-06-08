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
    /// Entity for the ORDERS table
    /// </summary>
    [DataContract]
    public class Order 
    {
      
        [DataMember]            
        public int Ordrecno {get; set;}
    
       [DataMember]              
        public int? Actcstcode {get;set;}

    
       [DataMember]              
        public int? Ediuplrecno {get;set;}

    
       [DataMember]              
        public short? Isediord {get;set;}

    
       [DataMember]              
        public short? Istradesale {get;set;}

    
       [DataMember]              
        public string Ordaccname {get;set;}

    
       [DataMember]              
        public string Ordclaacccode {get;set;}

    
       [DataMember]              
        public int? Ordcstcode {get;set;}

    
       [DataMember]              
        public string Ordcustordno {get;set;}

    
       [DataMember]              
        public DateTime? Orddate {get;set;}

    
       [DataMember]              
        public DateTime? Ordreqdeldate {get;set;}

    
       [DataMember]              
        public string Ordsaltyp {get;set;}

    
       [DataMember]              
        public int? Ordsmnno {get;set;}

    
       [DataMember]              
        public short? Productionorder {get;set;}

    }

/*
result.Ordrecno = item.Ordrecno;
  result.Actcstcode = item.Actcstcode;
  result.Ediuplrecno = item.Ediuplrecno;
  result.Isediord = item.Isediord;
  result.Istradesale = item.Istradesale;
  result.Ordaccname = item.Ordaccname;
  result.Ordclaacccode = item.Ordclaacccode;
  result.Ordcstcode = item.Ordcstcode;
  result.Ordcustordno = item.Ordcustordno;
  result.Orddate = item.Orddate;
  result.Ordreqdeldate = item.Ordreqdeldate;
  result.Ordsaltyp = item.Ordsaltyp;
  result.Ordsmnno = item.Ordsmnno;
  result.Productionorder = item.Productionorder;


            
*/  

/*
Ordrecno = item.Ordrecno,
Actcstcode = item.Actcstcode,
Ediuplrecno = item.Ediuplrecno,
Isediord = item.Isediord,
Istradesale = item.Istradesale,
Ordaccname = item.Ordaccname,
Ordclaacccode = item.Ordclaacccode,
Ordcstcode = item.Ordcstcode,
Ordcustordno = item.Ordcustordno,
Orddate = item.Orddate,
Ordreqdeldate = item.Ordreqdeldate,
Ordsaltyp = item.Ordsaltyp,
Ordsmnno = item.Ordsmnno,
Productionorder = item.Productionorder,


            
*/  

    }

}
