using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace Bsdl.FreshTrade.Domain.PreInv.Entities
{
    [DataContract]
    public class DTOEdiInv 
    {
      
        [DataMember]            
        public int Coglbno {get; set;}
      
        [DataMember]            
        public string Hofcstcode {get; set;}
      
        [DataMember]            
        public int Hofclarecno {get; set;}
      
        [DataMember]            
        public int Invoiceno {get; set;}
      
        [DataMember]            
        public int Dlvordno {get; set;}
    
       [DataMember]              
        public int? Atrrecno {get;set;}

    
       [DataMember]              
        public int? Clarecno {get;set;}

    
       [DataMember]              
        public int? Cleared {get;set;}

    
       [DataMember]              
        public DateTime? Dlvdeldate {get;set;}

    
       [DataMember]              
        public string Dlvpodno {get;set;}

    
       [DataMember]              
        public DateTime? Dlvshpdate {get;set;}

    
       [DataMember]              
        public int? Ediinvrecno {get;set;}

    
       [DataMember]              
        public string Filetype {get;set;}

    
       [DataMember]              
        public int? Ftdlvordno {get;set;}

    
       [DataMember]              
        public decimal Invamt {get;set;}

    
       [DataMember]              
        public DateTime? Invdate {get;set;}

    
       [DataMember]              
        public decimal Invvatamt {get;set;}

    
       [DataMember]              
        public string Ordcstcode {get;set;}

    
       [DataMember]              
        public DateTime? Orddate {get;set;}

    
       [DataMember]              
        public int? Ordno {get;set;}

    
       [DataMember]              
        public string Ordref {get;set;}

    
       [DataMember]              
        public int? Porrecno {get;set;}

    
       [DataMember]              
        public int? Saloffno {get;set;}

    
       [DataMember]              
        public string Supplieracccode {get;set;}

    
       [DataMember]              
        public int? Supplierclarecno {get;set;}

    
       [DataMember]              
        public int? Uplrecnoin {get;set;}

    
       [DataMember]              
        public int? Uplrecnoout {get;set;}

    }}
