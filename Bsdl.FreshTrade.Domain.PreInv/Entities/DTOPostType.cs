using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace Bsdl.FreshTrade.Domain.PreInv.Entities
{
    /// <summary>
    /// Entity for the POSTTYPE table
    /// </summary>
    [DataContract]
    public class DTOPostType 
    {
      
        [DataMember]            
        public int Pstrecno {get; set;}
    
       [DataMember]              
        public int Dbtcdtno {get;set;}

    
       [DataMember]              
        public int? Instatementtypes {get;set;}

    
       [DataMember]              
        public string Pstdesc {get;set;}

    
       [DataMember]              
        public string Pstledger {get;set;}

    
       [DataMember]              
        public string Psttype {get;set;}

    
       [DataMember]              
        public short? Purpayind {get;set;}

    
       [DataMember]              
        public short? Restrictind {get;set;}

    
       [DataMember]              
        public short? Turnoverind {get;set;}

    }}
