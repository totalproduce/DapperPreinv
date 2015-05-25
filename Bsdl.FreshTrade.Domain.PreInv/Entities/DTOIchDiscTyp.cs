using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace Bsdl.FreshTrade.Domain.PreInv.Entities
{    
   [DataContract]
    public class DTOIchDiscTyp 
    {
      
        [DataMember]            
        public int IchRecNo {get; set;}
    
       [DataMember]              
        public string DiscDedStr {get;set;}

    
       [DataMember]              
        public int? DiscGrpGlRecNo {get;set;}

    }}
