using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace Bsdl.FreshTrade.Domain.PreInv.Entities
{
    [DataContract]
    public class DTOGLTrans
    {
      
        [DataMember]            
        public int Gltrecno {get; set;}
    
       [DataMember]              
        public int? Glextractbatchid {get;set;}

    
       [DataMember]              
        public string Gltcat {get;set;}

    
       [DataMember]              
        public int? Gltcomno {get;set;}

    
       [DataMember]              
        public decimal Gltcramount {get;set;}

    
       [DataMember]              
        public decimal Gltdbamount {get;set;}

    
       [DataMember]              
        public int? Gltdbno {get;set;}

    
       [DataMember]              
        public int? Gltdbtyp {get;set;}

    
       [DataMember]              
        public int? Gltganrecno {get;set;}

    
       [DataMember]              
        public int Gltorgdbno {get;set;}

    
       [DataMember]              
        public int? Gltperno {get;set;}

    
       [DataMember]              
        public int? Gltsaloffno {get;set;}

    
       [DataMember]              
        public int? Gltyrno {get;set;}

    }
}
