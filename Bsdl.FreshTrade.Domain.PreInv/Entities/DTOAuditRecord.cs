using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace Bsdl.FreshTrade.Domain.PreInv.Entities
{
  [DataContract]
    public class DTOAuditRecord 
    {
      
        [DataMember]            
        public int AuditRecordNo {get; set;}
    
       [DataMember]              
        public int? AuditActionNo {get;set;}

    
       [DataMember]              
        public string AuditChangedFrom {get;set;}

    
       [DataMember]              
        public string AuditChangedTo {get;set;}

    
       [DataMember]              
        public DateTime? AuditDate {get;set;}

    
       [DataMember]              
        public int? AuditDoneBy {get;set;}

    
       [DataMember]              
        public string AuditFormName {get;set;}

    
       [DataMember]              
        public int? AuditFormNo {get;set;}

    
       [DataMember]              
        public int AuditLinkRecNo1 {get;set;}

    
       [DataMember]              
        public int? AuditLinkRecNo2 {get;set;}

    
       [DataMember]              
        public int? Auditlinkrecno3 {get;set;}

    
       [DataMember]              
        public string Auditrdtuser {get;set;}

    
       [DataMember]              
        public int? AuditTypeNo {get;set;}

    
       [DataMember]              
        public int? Lherecno {get;set;}

    
       [DataMember]              
        public int? Lititeno {get;set;}

    
       [DataMember]              
        public int? Porno {get;set;}

    }}
