// <summary>
// This file is generated automatically. Any changes will be lost.
// </summary>

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Runtime.Serialization;

namespace Bsdl.FreshTrade.Repositories.Basic.dto
{
    /// <summary>
    /// Entity for the ACCCURRRATE table
    /// </summary>
    [DataContract]
    public class CurrencyRate 
    {
      
        [DataMember]            
        public int Ratcurno {get; set;}
      
        [DataMember]            
        public int Ratusefor {get; set;}
    
       [DataMember]              
        public decimal Ratratefrombase {get;set;}

    
       [DataMember]              
        public decimal Ratratefromeuro {get;set;}

    
       [DataMember]              
        public decimal Ratratetobase {get;set;}

    
       [DataMember]              
        public decimal Ratratetoeuro {get;set;}

    }

/*
result.Ratcurno = item.Ratcurno;
result.Ratusefor = item.Ratusefor;
  result.Ratratefrombase = item.Ratratefrombase;
  result.Ratratefromeuro = item.Ratratefromeuro;
  result.Ratratetobase = item.Ratratetobase;
  result.Ratratetoeuro = item.Ratratetoeuro;


            
*/  

/*
Ratcurno = item.Ratcurno,
Ratusefor = item.Ratusefor,
Ratratefrombase = item.Ratratefrombase,
Ratratefromeuro = item.Ratratefromeuro,
Ratratetobase = item.Ratratetobase,
Ratratetoeuro = item.Ratratetoeuro,


            
*/  

    }

}
