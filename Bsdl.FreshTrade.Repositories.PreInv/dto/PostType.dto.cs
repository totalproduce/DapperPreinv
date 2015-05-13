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
    /// Entity for the POSTTYPE table
    /// </summary>
    [DataContract]
    public class PostType 
    {
      
        [DataMember]            
        public int Pstrecno {get; set;}
    
       [DataMember]              
        public int Dbtcdtno {get;set;}

    
       [DataMember]              
        public int? Instatementtypes {get;set;}

    
       [DataMember]              
        public string Pstdesc {get;set;}

    
       [DataMember]              
        public string Pstledger {get;set;}

    
       [DataMember]              
        public string Psttype {get;set;}

    
       [DataMember]              
        public short? Purpayind {get;set;}

    
       [DataMember]              
        public short? Restrictind {get;set;}

    
       [DataMember]              
        public short? Turnoverind {get;set;}

    }

/*
result.Pstrecno = item.Pstrecno;
  result.Dbtcdtno = item.Dbtcdtno;
  result.Instatementtypes = item.Instatementtypes;
  result.Pstdesc = item.Pstdesc;
  result.Pstledger = item.Pstledger;
  result.Psttype = item.Psttype;
  result.Purpayind = item.Purpayind;
  result.Restrictind = item.Restrictind;
  result.Turnoverind = item.Turnoverind;


            
*/  

/*
Pstrecno = item.Pstrecno,
Dbtcdtno = item.Dbtcdtno,
Instatementtypes = item.Instatementtypes,
Pstdesc = item.Pstdesc,
Pstledger = item.Pstledger,
Psttype = item.Psttype,
Purpayind = item.Purpayind,
Restrictind = item.Restrictind,
Turnoverind = item.Turnoverind,


            
*/  

    }

}
