using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace Bsdl.FreshTrade.Domain.PreInv.Entities
{
    [DataContract]
    public class DTOEdiLogInvoice 
    {
      
        [DataMember]            
        public int Eiinvoiceid {get; set;}
    
       [DataMember]              
        public int? Eiatrrecno {get;set;}

    
       [DataMember]              
        public int? Eiheadid {get;set;}

    
       [DataMember]              
        public decimal Eitotaldiscount {get;set;}

    
       [DataMember]              
        public decimal Eitotalgoods {get;set;}

    
       [DataMember]              
        public decimal Eitotalinvoiced {get;set;}

    
       [DataMember]              
        public decimal Eitotalvat {get;set;}

    }}
