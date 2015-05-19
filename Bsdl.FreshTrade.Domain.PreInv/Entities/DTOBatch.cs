using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace Bsdl.FreshTrade.Domain.PreInv.Entities
{
 [DataContract]
    public class DTOBatch
    {
      
        [DataMember]            
        public int BatRecNo {get; set;}
    
       [DataMember]              
        public short? Batchallocflg {get;set;}

    
       [DataMember]              
        public DateTime? BatchCutOffDate {get;set;}

    
       [DataMember]              
        public string BatchInvPeriod {get;set;}

    
       [DataMember]              
        public string BatchInvType {get;set;}

    
       [DataMember]              
        public short? Batchmarketind {get;set;}

    
       [DataMember]              
        public bool BatchMergeTrans {get;set;}

    
       [DataMember]              
        public string BatchNetUserName {get;set;}

    
       [DataMember]              
        public int? BatchNo {get;set;}

    
       [DataMember]              
        public int? Batchprintno {get;set;}

    
       [DataMember]              
        public int? BatchPstRecNo {get;set;}

    
       [DataMember]              
        public int? BatchSalOffNo {get;set;}

    
       [DataMember]              
        public DateTime? BatchTaxDate {get;set;}

    
       [DataMember]              
        public DateTime? BatchTimeStamp {get;set;}

    
       [DataMember]              
        public int Batchtypeno {get;set;}

    }}
