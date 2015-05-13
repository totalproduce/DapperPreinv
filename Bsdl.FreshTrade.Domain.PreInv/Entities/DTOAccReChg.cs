using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace Bsdl.FreshTrade.Domain.PreInv.Entities
{
  [DataContract]
    public class DTOAccReChg
    {
      
        [DataMember]            
        public int ReChgRecNo {get; set;}
    
       [DataMember]              
        public int? BatRecNo {get;set;}

    
       [DataMember]              
        public int? FromSalOffNo {get;set;}

    
       [DataMember]              
        public int? OrigAtrRecNo {get;set;}

    
       [DataMember]              
        public int? Repackatrrecno {get;set;}

    
       [DataMember]              
        public int? ToSalOffNo {get;set;}

    
       [DataMember]              
        public int? Trnshpatrrecno {get;set;}

    }}
