using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace Bsdl.FreshTrade.Domain.PreInv.Entities
{
    [DataContract]
    public class DTOAccite 
    {
      
        [DataMember]            
        public int AitRecNo {get; set;}
    
       [DataMember]              
        public decimal AitAmount {get;set;}

    
       [DataMember]              
        public int? AitAtrRecNo {get;set;}

    
       [DataMember]              
        public int? Aitautlogno {get;set;}

    
       [DataMember]              
        public decimal AitBaseAmount {get;set;}

    
       [DataMember]              
        public string AitDrCr {get;set;}

    
       [DataMember]              
        public decimal AitEuroAmount {get;set;}

    
       [DataMember]              
        public int? AitGanRecNo {get;set;}

    
       [DataMember]              
        public int? Aitgltrecno {get;set;}

    
       [DataMember]              
        public int? AitIteRecNo {get;set;}

    
       [DataMember]              
        public int? Aititerevno {get;set;}

    
       [DataMember]              
        public int? AitPstRecNo {get;set;}

    
       [DataMember]              
        public int? Aitsaloffno {get;set;}

    
       [DataMember]              
        public int? Bankstmtdetrecno {get;set;}

    }}
