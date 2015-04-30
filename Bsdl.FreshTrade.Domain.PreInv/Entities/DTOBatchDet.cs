using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace Bsdl.FreshTrade.Domain.PreInv.Entities
{
    [DataContract]
    public class DTOBatchDet 
    {
      
        [DataMember]            
        public int BdtRecNo {get; set;}
    
       [DataMember]              
        public int? BdtBatRecNo {get;set;}

    
       [DataMember]              
        public string BdtCurTotal {get;set;}

    
       [DataMember]              
        public string BdtEdiFile {get;set;}

    
       [DataMember]              
        public int? BdtInvRecNo {get;set;}
    }
}
