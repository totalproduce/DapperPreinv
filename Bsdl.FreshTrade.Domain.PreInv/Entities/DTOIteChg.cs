using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using Bsdl.FreshTrade.Domain.PreInv.Enums;

namespace Bsdl.FreshTrade.Domain.PreInv.Entities
{
 [DataContract]
    public class DTOIteChg 
    {
      
        [DataMember]            
        public int IchRecNo {get; set;}
    
       [DataMember]              
        public short? Acsale {get;set;}

    
       [DataMember]              
        public int? CtyNo {get;set;}

    
       [DataMember]              
        public int? Delrecno {get;set;}

    
       [DataMember]              
        public int? DprRecNo {get;set;}

    
       [DataMember]              
        public int? ExcRecNo {get;set;}

    
       [DataMember]              
        public int? IchAcrRecNo {get;set;}

    
       [DataMember]              
        public decimal IchAppAmt {get;set;}

    
       [DataMember]              
        public int? IchAppFac {get;set;}

    
       [DataMember]              
        public int? Ichappmult {get;set;}

    
       [DataMember]              
        public decimal IchAuthAmm {get;set;}

    
       [DataMember]              
        public int? IchChaCalc {get;set;}

    
       [DataMember]              
        public int? Ichchgfor {get;set;}

    
       [DataMember]              
        public short? Ichchngdbyuser {get;set;}

    
       [DataMember]              
        public decimal Ichcostamt {get;set;}

    
       [DataMember]              
        public int? IchDisType {get;set;}

    
       [DataMember]              
        public short? Ichisanauto {get;set;}

    
       [DataMember]              
        public int? Ichistrecno {get;set;}

    
       [DataMember]              
        public bool IchOnPayment {get;set;}

    
       [DataMember]              
        public decimal Ichorgappamt {get;set;}

    
       [DataMember]              
        public int? Ichpackmistrecno {get;set;}

    
       [DataMember]              
        public decimal IchPcntOrRate {get;set;}

    
       [DataMember]              
        public decimal Ichrawappamt {get;set;}

    
       [DataMember]              
        public decimal Ichrawauthamm {get;set;}

    
       [DataMember]
       public EnumDiscTypes? IchRealDisType { get; set; }

    
       [DataMember]              
        public int? Ichretno {get;set;}

    
       [DataMember]              
        public string Ichspeto {get;set;}

    
       [DataMember]              
        public int? Litrecno {get;set;}

    
       [DataMember]              
        public int? Pmorddetrecno {get;set;}

    
       [DataMember]              
        public int? Rebdislitrecno {get;set;}

    
       [DataMember]              
        public int? Tbcpostrecno {get;set;}

       public DTOIchDiscTyp IchDiscTypRecord { get; set; }
    }}
