using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace Bsdl.FreshTrade.Domain.PreInv.Entities
{
    [DataContract]
    public class DTOExpCha 
    {
      
        [DataMember]            
        public int ExcChaRec {get; set;}
    
       [DataMember]              
        public string Closedisputecode {get;set;}

    
       [DataMember]              
        public string Disputecode {get;set;}

    
       [DataMember]              
        public int? Disputestatus {get;set;}

    
       [DataMember]              
        public int? Dlvdtpdxli {get;set;}

    
       [DataMember]              
        public int? Excapptype {get;set;}

    
       [DataMember]              
        public int? ExcAtrRecNo {get;set;}

    
       [DataMember]              
        public decimal ExcAuthConAmm {get;set;}

    
       [DataMember]              
        public decimal ExcAuthEuroAmm {get;set;}

    
       [DataMember]              
        public decimal ExcAuthRawAmm {get;set;}

    
       [DataMember]              
        public decimal Excauthtobaserate {get;set;}

    
       [DataMember]              
        public decimal Excauthtoeuroamm {get;set;}

    
       [DataMember]              
        public decimal Excchaperrate {get;set;}

    
       [DataMember]              
        public int ExcChgCalc {get;set;}

    
       [DataMember]              
        public short? Excclaimonhold {get;set;}

    
       [DataMember]              
        public DateTime? Excclrdate {get;set;}

    
       [DataMember]              
        public decimal ExcConAmm {get;set;}

    
       [DataMember]              
        public int? ExcCtyNo {get;set;}

    
       [DataMember]              
        public short? Exccurrblkpurch {get;set;}

    
       [DataMember]              
        public int ExcCurrNo {get;set;}

    
       [DataMember]              
        public int? Excdlvordno {get;set;}

    
       [DataMember]              
        public string Excdutyref {get;set;}

    
       [DataMember]              
        public decimal ExcEuroAmm {get;set;}

    
       [DataMember]              
        public int ExcFullyAuth {get;set;}

    
       [DataMember]              
        public int? Exclherecno {get;set;}

    
       [DataMember]              
        public int? Excpackmporrecno {get;set;}

    
       [DataMember]              
        public int? Excporrecno {get;set;}

    
       [DataMember]              
        public short? Excratefixed {get;set;}

    
       [DataMember]              
        public decimal ExcRawAmm {get;set;}

    
       [DataMember]              
        public int? Excrecovfrompl {get;set;}

    
       [DataMember]              
        public int? Excretno {get;set;}

    
       [DataMember]              
        public decimal Excrounddif {get;set;}

    
       [DataMember]              
        public int? Excrthno {get;set;}

    
       [DataMember]              
        public int? Excrthpono {get;set;}

    
       [DataMember]              
        public int? Excsaloff {get;set;}

    
       [DataMember]              
        public int? ExcSenCode {get;set;}

    
       [DataMember]              
        public string Excsenref {get;set;}

    
       [DataMember]              
        public string Excspeto {get;set;}

    
       [DataMember]              
        public decimal ExcToBaseRate {get;set;}

    
       [DataMember]              
        public decimal ExcToEuroExcRate {get;set;}

    
       [DataMember]              
        public decimal Invexchrate {get;set;}

    
       [DataMember]              
        public int? Openchargeid {get;set;}

    
       [DataMember]              
        public bool Triangulated {get;set;}

    }}
