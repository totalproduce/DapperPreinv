// <summary>
// This file is generated automatically. Any changes will be lost.
// </summary>

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Runtime.Serialization;

namespace Bsdl.FreshTrade.Repositories.PreInv.dto
{
    /// <summary>
    /// Entity for the DELHED table
    /// </summary>
    [DataContract]
    public class DELHED 
    {
      
        [DataMember]            
        public int Dlvordno {get; set;}
    
       [DataMember]              
        public short? Creditcontrolhold {get;set;}

    
       [DataMember]              
        public decimal? Delcredonholdval {get;set;}

    
       [DataMember]              
        public int? Deltransprcmeth {get;set;}

    
       [DataMember]              
        public int? Dlvcomno {get;set;}

    
       [DataMember]              
        public int? Dlvcstsupno {get;set;}

    
       [DataMember]              
        public int? Dlvcurrecno {get;set;}

    
       [DataMember]              
        public DateTime? Dlvdeldate {get;set;}

    
       [DataMember]              
        public int? Dlvdltrecno {get;set;}

    
       [DataMember]              
        public string Dlvediref {get;set;}

    
       [DataMember]              
        public int Dlvfaxsent {get;set;}

    
       [DataMember]              
        public short? Dlvhasopenprc {get;set;}

    
       [DataMember]              
        public int? Dlvisdirect {get;set;}

    
       [DataMember]              
        public short? Dlvismktsale {get;set;}

    
       [DataMember]              
        public int? Dlvnotclosed {get;set;}

    
       [DataMember]              
        public int? Dlvordrecno {get;set;}

    
       [DataMember]              
        public short? Dlvowncollection {get;set;}

    
       [DataMember]              
        public short? Dlvpassed {get;set;}

    
       [DataMember]              
        public string Dlvpodno {get;set;}

    
       [DataMember]              
        public int? Dlvprghedno {get;set;}

    
       [DataMember]              
        public int? Dlvpriority {get;set;}

    
       [DataMember]              
        public int? Dlvprtstat {get;set;}

    
       [DataMember]              
        public short? Dlvrelconfm {get;set;}

    
       [DataMember]              
        public string Dlvrelinv {get;set;}

    
       [DataMember]              
        public int? Dlvrthno {get;set;}

    
       [DataMember]              
        public int? Dlvsaloffno {get;set;}

    
       [DataMember]              
        public string Dlvsaltyp {get;set;}

    
       [DataMember]              
        public DateTime? Dlvshpdate {get;set;}

    
       [DataMember]              
        public int? Dlvstkloc {get;set;}

    
       [DataMember]              
        public string Dlvtime {get;set;}

    
       [DataMember]              
        public int? Dlvtranind {get;set;}

    
       [DataMember]              
        public DateTime? Dlvtransconfdate {get;set;}

    
       [DataMember]              
        public int? Dlvtransship {get;set;}

    
       [DataMember]              
        public int? Dlvtransshiptoloc {get;set;}

    
       [DataMember]              
        public DateTime? Dlvupddate {get;set;}

    
       [DataMember]              
        public string Dlvupdtime {get;set;}

    
       [DataMember]              
        public decimal? Hedsyscalcpals {get;set;}

        /// <summary>
        /// If this sale is a interdepartment sale then this will be the Department Number (DEPARTMENTS.DPTRECNO)
        /// </summary>
    
       [DataMember]              
        public int? Interdeptflag {get;set;}

    
       [DataMember]              
        public string Invoiceref {get;set;}

    
       [DataMember]              
        public int? Invsaloffno {get;set;}

    
       [DataMember]              
        public int? Isopenformore {get;set;}

    
       [DataMember]              
        public int? Logonno {get;set;}

    
       [DataMember]              
        public int? Ordertype {get;set;}

    
       [DataMember]              
        public short? Qcchecked {get;set;}

    
       [DataMember]              
        public int? Qcnarrecno {get;set;}

    
       [DataMember]              
        public int? Supclarecno {get;set;}

    
       [DataMember]              
        public int? Transferflg {get;set;}

    
       [DataMember]              
        public int? Trnsaloffno {get;set;}

    
       [DataMember]              
        public decimal? Userinppals {get;set;}

    }

/*
result.Dlvordno = item.Dlvordno;
  result.Creditcontrolhold = item.Creditcontrolhold;
  result.Delcredonholdval = item.Delcredonholdval;
  result.Deltransprcmeth = item.Deltransprcmeth;
  result.Dlvcomno = item.Dlvcomno;
  result.Dlvcstsupno = item.Dlvcstsupno;
  result.Dlvcurrecno = item.Dlvcurrecno;
  result.Dlvdeldate = item.Dlvdeldate;
  result.Dlvdltrecno = item.Dlvdltrecno;
  result.Dlvediref = item.Dlvediref;
  result.Dlvfaxsent = item.Dlvfaxsent;
  result.Dlvhasopenprc = item.Dlvhasopenprc;
  result.Dlvisdirect = item.Dlvisdirect;
  result.Dlvismktsale = item.Dlvismktsale;
  result.Dlvnotclosed = item.Dlvnotclosed;
  result.Dlvordrecno = item.Dlvordrecno;
  result.Dlvowncollection = item.Dlvowncollection;
  result.Dlvpassed = item.Dlvpassed;
  result.Dlvpodno = item.Dlvpodno;
  result.Dlvprghedno = item.Dlvprghedno;
  result.Dlvpriority = item.Dlvpriority;
  result.Dlvprtstat = item.Dlvprtstat;
  result.Dlvrelconfm = item.Dlvrelconfm;
  result.Dlvrelinv = item.Dlvrelinv;
  result.Dlvrthno = item.Dlvrthno;
  result.Dlvsaloffno = item.Dlvsaloffno;
  result.Dlvsaltyp = item.Dlvsaltyp;
  result.Dlvshpdate = item.Dlvshpdate;
  result.Dlvstkloc = item.Dlvstkloc;
  result.Dlvtime = item.Dlvtime;
  result.Dlvtranind = item.Dlvtranind;
  result.Dlvtransconfdate = item.Dlvtransconfdate;
  result.Dlvtransship = item.Dlvtransship;
  result.Dlvtransshiptoloc = item.Dlvtransshiptoloc;
  result.Dlvupddate = item.Dlvupddate;
  result.Dlvupdtime = item.Dlvupdtime;
  result.Hedsyscalcpals = item.Hedsyscalcpals;
  result.Interdeptflag = item.Interdeptflag;
  result.Invoiceref = item.Invoiceref;
  result.Invsaloffno = item.Invsaloffno;
  result.Isopenformore = item.Isopenformore;
  result.Logonno = item.Logonno;
  result.Ordertype = item.Ordertype;
  result.Qcchecked = item.Qcchecked;
  result.Qcnarrecno = item.Qcnarrecno;
  result.Supclarecno = item.Supclarecno;
  result.Transferflg = item.Transferflg;
  result.Trnsaloffno = item.Trnsaloffno;
  result.Userinppals = item.Userinppals;


            
*/  

/*
Dlvordno = item.Dlvordno,
Creditcontrolhold = item.Creditcontrolhold,
Delcredonholdval = item.Delcredonholdval,
Deltransprcmeth = item.Deltransprcmeth,
Dlvcomno = item.Dlvcomno,
Dlvcstsupno = item.Dlvcstsupno,
Dlvcurrecno = item.Dlvcurrecno,
Dlvdeldate = item.Dlvdeldate,
Dlvdltrecno = item.Dlvdltrecno,
Dlvediref = item.Dlvediref,
Dlvfaxsent = item.Dlvfaxsent,
Dlvhasopenprc = item.Dlvhasopenprc,
Dlvisdirect = item.Dlvisdirect,
Dlvismktsale = item.Dlvismktsale,
Dlvnotclosed = item.Dlvnotclosed,
Dlvordrecno = item.Dlvordrecno,
Dlvowncollection = item.Dlvowncollection,
Dlvpassed = item.Dlvpassed,
Dlvpodno = item.Dlvpodno,
Dlvprghedno = item.Dlvprghedno,
Dlvpriority = item.Dlvpriority,
Dlvprtstat = item.Dlvprtstat,
Dlvrelconfm = item.Dlvrelconfm,
Dlvrelinv = item.Dlvrelinv,
Dlvrthno = item.Dlvrthno,
Dlvsaloffno = item.Dlvsaloffno,
Dlvsaltyp = item.Dlvsaltyp,
Dlvshpdate = item.Dlvshpdate,
Dlvstkloc = item.Dlvstkloc,
Dlvtime = item.Dlvtime,
Dlvtranind = item.Dlvtranind,
Dlvtransconfdate = item.Dlvtransconfdate,
Dlvtransship = item.Dlvtransship,
Dlvtransshiptoloc = item.Dlvtransshiptoloc,
Dlvupddate = item.Dlvupddate,
Dlvupdtime = item.Dlvupdtime,
Hedsyscalcpals = item.Hedsyscalcpals,
Interdeptflag = item.Interdeptflag,
Invoiceref = item.Invoiceref,
Invsaloffno = item.Invsaloffno,
Isopenformore = item.Isopenformore,
Logonno = item.Logonno,
Ordertype = item.Ordertype,
Qcchecked = item.Qcchecked,
Qcnarrecno = item.Qcnarrecno,
Supclarecno = item.Supclarecno,
Transferflg = item.Transferflg,
Trnsaloffno = item.Trnsaloffno,
Userinppals = item.Userinppals,


            
*/  

    }

}
