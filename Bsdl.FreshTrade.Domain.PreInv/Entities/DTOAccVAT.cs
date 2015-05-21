using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace Bsdl.FreshTrade.Domain.PreInv.Entities
{
    [DataContract]
    public class DTOAccVAT 
    {
      
        [DataMember]            
        public int AvaAtrRecNo {get; set;}
      
        [DataMember]            
        public int Avavatcde {get; set;}
      
        [DataMember]            
        public int Avaaddkey {get; set;}
      
        [DataMember]            
        public int Avavattypno {get; set;}
    
       [DataMember]              
        public decimal Avabasegoods {get;set;}

    
       [DataMember]              
        public decimal Avabasevat {get;set;}

    
       [DataMember]              
        public decimal Avaeurogoods {get;set;}

    
       [DataMember]              
        public decimal Avaeurovat {get;set;}

    
       [DataMember]              
        public decimal Avagoods {get;set;}

    
       [DataMember]              
        public short Avaisrevcrdr {get;set;}

    
       [DataMember]              
        public DateTime? Avarptdate {get;set;}

    
       [DataMember]              
        public int? Avarptno {get;set;}

    
       [DataMember]              
        public decimal Avavat {get;set;}

    
       [DataMember]              
        public decimal Avavatrate {get;set;}

    
       [DataMember]              
        public int? Avaveano {get;set;}

    
       [DataMember]              
        public short? Exclgoods {get;set;}

    
       [DataMember]              
        public int? VatLnkRecNo {get;set;}

    }}
