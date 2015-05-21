using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace Bsdl.FreshTrade.Domain.PreInv.Entities
{
    [DataContract]
    public class DTOAccAlloc 
    {
      
        [DataMember]            
        public int Acaatrrecnofrom {get; set;}
      
        [DataMember]            
        public int Acaatrrecnoto {get; set;}
      
        [DataMember]            
        public int Acaaavrecno {get; set;}
    
       [DataMember]              
        public int? Acadrcr {get;set;}

    }}
