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
    /// Entity for the HOFCST table
    /// </summary>
    [DataContract]
    public class HOFCST 
    {
      
        [DataMember]            
        public int Hofrecno {get; set;}
      
        [DataMember]            
        public int Currencycode {get; set;}
      
        [DataMember]            
        public int Saloffno {get; set;}
    
       [DataMember]              
        public int? Accrecno {get;set;}

    
       [DataMember]              
        public int Hofinvtocstcode {get;set;}

    
       [DataMember]              
        public int? Invsaloffno {get;set;}

    
       [DataMember]              
        public int? Lstinvout {get;set;}

    
       [DataMember]              
        public string Supplierref {get;set;}

    
       [DataMember]              
        public string Suppref {get;set;}

    
       [DataMember]              
        public short Useuploadhof {get;set;}

    }

/*
result.Hofrecno = item.Hofrecno;
result.Currencycode = item.Currencycode;
result.Saloffno = item.Saloffno;
  result.Accrecno = item.Accrecno;
  result.Hofinvtocstcode = item.Hofinvtocstcode;
  result.Invsaloffno = item.Invsaloffno;
  result.Lstinvout = item.Lstinvout;
  result.Supplierref = item.Supplierref;
  result.Suppref = item.Suppref;
  result.Useuploadhof = item.Useuploadhof;


            
*/  

/*
Hofrecno = item.Hofrecno,
Currencycode = item.Currencycode,
Saloffno = item.Saloffno,
Accrecno = item.Accrecno,
Hofinvtocstcode = item.Hofinvtocstcode,
Invsaloffno = item.Invsaloffno,
Lstinvout = item.Lstinvout,
Supplierref = item.Supplierref,
Suppref = item.Suppref,
Useuploadhof = item.Useuploadhof,


            
*/  

    }

}
