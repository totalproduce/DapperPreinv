using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using Bsdl.FreshTrade.Domain.PreInv.Enums;

namespace Bsdl.FreshTrade.Domain.PreInv.Entities
{
    [DataContract]
    public  class DTOInvDiscTyp
 
    {
        [DataMember]
        public int ExtractSessionID { get; set; }

       [DataMember]              
        public decimal DiscBaseAmt {get;set;}

    
       [DataMember]              
        public string DiscDetrStr {get;set;}

    
       [DataMember]              
        public decimal DiscEuroAmt {get;set;}

    
       [DataMember]              
        public int? DiscGlRecNo {get;set;}

    
       [DataMember]              
        public decimal DiscLoclAmt {get;set;}

    
       [DataMember]              
        public decimal DiscRate {get;set;}

    
       [DataMember]              
        public int? DiscSeqNo {get;set;}

    
       [DataMember]              
       public EnumDiscTypes? DiscTyp { get; set; }

    
       [DataMember]              
        public string DlvInvoiceNo {get;set;}

    
       [DataMember]              
        public int? Ichrecno {get;set;}

    
       [DataMember]              
        public int? RecNo {get;set;}

    }}
