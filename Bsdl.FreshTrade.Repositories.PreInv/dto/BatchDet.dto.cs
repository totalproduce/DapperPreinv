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
    /// Entity for the BATCHDET table
    /// </summary>
    [DataContract]
    public class BatchDet 
    {
      
        [DataMember]            
        public int Bdtrecno {get; set;}
    
       [DataMember]              
        public int? Bdtbatrecno {get;set;}

    
       [DataMember]              
        public string Bdtcurtotal {get;set;}

    
       [DataMember]              
        public string Bdtedifile {get;set;}

    
       [DataMember]              
        public int? Bdtinvrecno {get;set;}

    }

/*
result.Bdtrecno = item.Bdtrecno;
  result.Bdtbatrecno = item.Bdtbatrecno;
  result.Bdtcurtotal = item.Bdtcurtotal;
  result.Bdtedifile = item.Bdtedifile;
  result.Bdtinvrecno = item.Bdtinvrecno;


            
*/  

/*
Bdtrecno = item.Bdtrecno,
Bdtbatrecno = item.Bdtbatrecno,
Bdtcurtotal = item.Bdtcurtotal,
Bdtedifile = item.Bdtedifile,
Bdtinvrecno = item.Bdtinvrecno,


            
*/  

    }

}
