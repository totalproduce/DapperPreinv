using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace Bsdl.FreshTrade.Domain.PreInv.Entities
{
    [DataContract]
    public class DTOAccTrnFil 
    {
      
        [DataMember]            
        public int AtrRecNo {get; set;}
    
       [DataMember]              
        public int? Atr1099type {get;set;}

    
       [DataMember]              
        public DateTime? Atractpstdate {get;set;}

    
       [DataMember]              
        public int? Atractpstlogon {get;set;}

    
       [DataMember]              
        public decimal? AtrAmount {get;set;}

    
       [DataMember]              
        public decimal? Atramountwhval {get;set;}

    
       [DataMember]              
        public int? Atrauthbyno {get;set;}

    
       [DataMember]
       public decimal? AtrBalance { get; set; }

    
       [DataMember]              
        public decimal? Atrbalatlststmt {get;set;}

    
       [DataMember]
       public decimal? AtrBaseAmount { get; set; }

    
       [DataMember]
       public decimal? AtrBaseRate { get; set; }

    
       [DataMember]              
        public int? Atrclarecno {get;set;}

    
       [DataMember]              
        public int? Atrclass {get;set;}

    
       [DataMember]              
        public int? AtrCoGlbRecNo {get;set;}

    
       [DataMember]              
        public int? AtrCurRecNo {get;set;}

    
       [DataMember]              
        public int? AtrDbNo {get;set;}

    
       [DataMember]              
        public int? AtrDbType {get;set;}

    
       [DataMember]              
        public int? AtrDelClaRecNo {get;set;}

    
       [DataMember]              
        public int Atrdispute {get;set;}

    
       [DataMember]
       public decimal? AtrEuroAmount { get; set; }

    
       [DataMember]
       public decimal? AtrEuroRate { get; set; }

    
       [DataMember]              
        public int? Atrexclfromexport {get;set;}

    
       [DataMember]              
        public int? Atrfactorclarec {get;set;}

    
       [DataMember]              
        public short? Atronpayplan {get;set;}

    
       [DataMember]              
        public int? Atrourrefno {get;set;}

    
       [DataMember]              
        public int? Atrperiodno {get;set;}

    
       [DataMember]              
        public int? Atrprdorpan {get;set;}

    
       [DataMember]              
        public DateTime? AtrPstDate {get;set;}

    
       [DataMember]              
        public short? Atrpstdatedchq {get;set;}

    
       [DataMember]              
        public DateTime? Atrpstdchqentdate {get;set;}

    
       [DataMember]              
        public int? AtrPstTyp {get;set;}

    
       [DataMember]              
        public int? Atrpurauthbatrec {get;set;}

    
       [DataMember]              
        public string Atrref {get;set;}

    
       [DataMember]              
        public string AtrRef2 {get;set;}

    
       [DataMember]              
        public int? AtrSalOffNo {get;set;}

    
       [DataMember]              
        public int AtrStatInd {get;set;}

    
       [DataMember]              
        public int? Atrtoauthno {get;set;}

    
       [DataMember]
       public decimal? Atrtopayamt { get; set; }

    
       [DataMember]              
        public DateTime? Atrtopaydate {get;set;}

    
       [DataMember]              
        public short? AtrTriangulate {get;set;}

    
       [DataMember]              
        public decimal? Atrwhtaxamount {get;set;}

    
       [DataMember]              
        public short? Atrwithholdtax {get;set;}

    
       [DataMember]              
        public decimal? Atrwithholdtaxrate {get;set;}

    
       [DataMember]              
        public int? Atryearno {get;set;}

    
       [DataMember]              
        public string Clrddate {get;set;}

    
       [DataMember]              
        public int? Intcomptrn {get;set;}

    
       [DataMember]              
        public decimal? Invexchrate {get;set;}

    
       [DataMember]              
        public int? Onholdby {get;set;}

    
       [DataMember]              
        public DateTime? Onholddate {get;set;}

    
       [DataMember]              
        public short? Paymentagentprinted {get;set;}

    }}
