using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace Bsdl.FreshTrade.Domain.PreInv.Entities
{
    [DataContract]
    public class DTOAccAllVal 
    {
      
        [DataMember]            
        public int AavRecNo {get; set;}
    
       [DataMember]              
        public decimal AavAmount {get;set;}

    
       [DataMember]              
        public decimal AavBaseAmount {get;set;}

    
       [DataMember]              
        public int? AavCurRecNo {get;set;}

    
       [DataMember]              
        public decimal AavEuroAmount {get;set;}

    }}
