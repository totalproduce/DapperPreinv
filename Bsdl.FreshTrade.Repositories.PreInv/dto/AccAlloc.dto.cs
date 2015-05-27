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
    /// Entity for the ACCALLOC table
    /// </summary>
    [DataContract]
    public class AccAlloc 
    {
      
        [DataMember]            
        public int Acaatrrecnofrom {get; set;}
      
        [DataMember]            
        public int Acaatrrecnoto {get; set;}
      
        [DataMember]            
        public int Acaaavrecno {get; set;}
    
       [DataMember]              
        public int? Acadrcr {get;set;}

    }

/*
result.Acaatrrecnofrom = item.Acaatrrecnofrom;
result.Acaatrrecnoto = item.Acaatrrecnoto;
result.Acaaavrecno = item.Acaaavrecno;
  result.Acadrcr = item.Acadrcr;


            
*/  

/*
Acaatrrecnofrom = item.Acaatrrecnofrom,
Acaatrrecnoto = item.Acaatrrecnoto,
Acaaavrecno = item.Acaaavrecno,
Acadrcr = item.Acadrcr,


            
*/  

    }

}
