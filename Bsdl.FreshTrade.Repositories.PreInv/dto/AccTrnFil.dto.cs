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
    /// Entity for the ACCTRNFIL table
    /// </summary>
    [DataContract]
    public class AccTrnFil 
    {
      
        [DataMember]            
        public int Atrrecno {get; set;}
    
       [DataMember]              
        public int? Atr1099type {get;set;}

    
       [DataMember]              
        public DateTime? Atractpstdate {get;set;}

    
       [DataMember]              
        public int? Atractpstlogon {get;set;}

    
       [DataMember]              
        public decimal? Atramount {get;set;}

    
       [DataMember]              
        public decimal? Atramountwhval {get;set;}

    
       [DataMember]              
        public int? Atrauthbyno {get;set;}

    
       [DataMember]              
        public decimal? Atrbalance {get;set;}

    
       [DataMember]              
        public decimal? Atrbalatlststmt {get;set;}

    
       [DataMember]              
        public decimal? Atrbaseamount {get;set;}

    
       [DataMember]              
        public decimal? Atrbaserate {get;set;}

    
       [DataMember]              
        public int? Atrclarecno {get;set;}

    
       [DataMember]              
        public int? Atrclass {get;set;}

    
       [DataMember]              
        public int? Atrcoglbrecno {get;set;}

    
       [DataMember]              
        public int? Atrcurrecno {get;set;}

    
       [DataMember]              
        public int? Atrdbno {get;set;}

    
       [DataMember]              
        public int? Atrdbtype {get;set;}

    
       [DataMember]              
        public int? Atrdelclarecno {get;set;}

    
       [DataMember]              
        public int Atrdispute {get;set;}

    
       [DataMember]              
        public decimal? Atreuroamount {get;set;}

    
       [DataMember]              
        public decimal? Atreurorate {get;set;}

    
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
        public DateTime? Atrpstdate {get;set;}

    
       [DataMember]              
        public short? Atrpstdatedchq {get;set;}

    
       [DataMember]              
        public DateTime? Atrpstdchqentdate {get;set;}

    
       [DataMember]              
        public int? Atrpsttyp {get;set;}

    
       [DataMember]              
        public int? Atrpurauthbatrec {get;set;}

    
       [DataMember]              
        public string Atrref {get;set;}

    
       [DataMember]              
        public string Atrref2 {get;set;}

    
       [DataMember]              
        public int? Atrsaloffno {get;set;}

    
       [DataMember]              
        public int Atrstatind {get;set;}

    
       [DataMember]              
        public int? Atrtoauthno {get;set;}

    
       [DataMember]              
        public decimal? Atrtopayamt {get;set;}

    
       [DataMember]              
        public DateTime? Atrtopaydate {get;set;}

    
       [DataMember]              
        public short? Atrtriangulate {get;set;}

    
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

    }

/*
result.Atrrecno = item.Atrrecno;
  result.Atr1099type = item.Atr1099type;
  result.Atractpstdate = item.Atractpstdate;
  result.Atractpstlogon = item.Atractpstlogon;
  result.Atramount = item.Atramount;
  result.Atramountwhval = item.Atramountwhval;
  result.Atrauthbyno = item.Atrauthbyno;
  result.Atrbalance = item.Atrbalance;
  result.Atrbalatlststmt = item.Atrbalatlststmt;
  result.Atrbaseamount = item.Atrbaseamount;
  result.Atrbaserate = item.Atrbaserate;
  result.Atrclarecno = item.Atrclarecno;
  result.Atrclass = item.Atrclass;
  result.Atrcoglbrecno = item.Atrcoglbrecno;
  result.Atrcurrecno = item.Atrcurrecno;
  result.Atrdbno = item.Atrdbno;
  result.Atrdbtype = item.Atrdbtype;
  result.Atrdelclarecno = item.Atrdelclarecno;
  result.Atrdispute = item.Atrdispute;
  result.Atreuroamount = item.Atreuroamount;
  result.Atreurorate = item.Atreurorate;
  result.Atrexclfromexport = item.Atrexclfromexport;
  result.Atrfactorclarec = item.Atrfactorclarec;
  result.Atronpayplan = item.Atronpayplan;
  result.Atrourrefno = item.Atrourrefno;
  result.Atrperiodno = item.Atrperiodno;
  result.Atrprdorpan = item.Atrprdorpan;
  result.Atrpstdate = item.Atrpstdate;
  result.Atrpstdatedchq = item.Atrpstdatedchq;
  result.Atrpstdchqentdate = item.Atrpstdchqentdate;
  result.Atrpsttyp = item.Atrpsttyp;
  result.Atrpurauthbatrec = item.Atrpurauthbatrec;
  result.Atrref = item.Atrref;
  result.Atrref2 = item.Atrref2;
  result.Atrsaloffno = item.Atrsaloffno;
  result.Atrstatind = item.Atrstatind;
  result.Atrtoauthno = item.Atrtoauthno;
  result.Atrtopayamt = item.Atrtopayamt;
  result.Atrtopaydate = item.Atrtopaydate;
  result.Atrtriangulate = item.Atrtriangulate;
  result.Atrwhtaxamount = item.Atrwhtaxamount;
  result.Atrwithholdtax = item.Atrwithholdtax;
  result.Atrwithholdtaxrate = item.Atrwithholdtaxrate;
  result.Atryearno = item.Atryearno;
  result.Clrddate = item.Clrddate;
  result.Intcomptrn = item.Intcomptrn;
  result.Invexchrate = item.Invexchrate;
  result.Onholdby = item.Onholdby;
  result.Onholddate = item.Onholddate;
  result.Paymentagentprinted = item.Paymentagentprinted;


            
*/  

/*
Atrrecno = item.Atrrecno,
Atr1099type = item.Atr1099type,
Atractpstdate = item.Atractpstdate,
Atractpstlogon = item.Atractpstlogon,
Atramount = item.Atramount,
Atramountwhval = item.Atramountwhval,
Atrauthbyno = item.Atrauthbyno,
Atrbalance = item.Atrbalance,
Atrbalatlststmt = item.Atrbalatlststmt,
Atrbaseamount = item.Atrbaseamount,
Atrbaserate = item.Atrbaserate,
Atrclarecno = item.Atrclarecno,
Atrclass = item.Atrclass,
Atrcoglbrecno = item.Atrcoglbrecno,
Atrcurrecno = item.Atrcurrecno,
Atrdbno = item.Atrdbno,
Atrdbtype = item.Atrdbtype,
Atrdelclarecno = item.Atrdelclarecno,
Atrdispute = item.Atrdispute,
Atreuroamount = item.Atreuroamount,
Atreurorate = item.Atreurorate,
Atrexclfromexport = item.Atrexclfromexport,
Atrfactorclarec = item.Atrfactorclarec,
Atronpayplan = item.Atronpayplan,
Atrourrefno = item.Atrourrefno,
Atrperiodno = item.Atrperiodno,
Atrprdorpan = item.Atrprdorpan,
Atrpstdate = item.Atrpstdate,
Atrpstdatedchq = item.Atrpstdatedchq,
Atrpstdchqentdate = item.Atrpstdchqentdate,
Atrpsttyp = item.Atrpsttyp,
Atrpurauthbatrec = item.Atrpurauthbatrec,
Atrref = item.Atrref,
Atrref2 = item.Atrref2,
Atrsaloffno = item.Atrsaloffno,
Atrstatind = item.Atrstatind,
Atrtoauthno = item.Atrtoauthno,
Atrtopayamt = item.Atrtopayamt,
Atrtopaydate = item.Atrtopaydate,
Atrtriangulate = item.Atrtriangulate,
Atrwhtaxamount = item.Atrwhtaxamount,
Atrwithholdtax = item.Atrwithholdtax,
Atrwithholdtaxrate = item.Atrwithholdtaxrate,
Atryearno = item.Atryearno,
Clrddate = item.Clrddate,
Intcomptrn = item.Intcomptrn,
Invexchrate = item.Invexchrate,
Onholdby = item.Onholdby,
Onholddate = item.Onholddate,
Paymentagentprinted = item.Paymentagentprinted,


            
*/  

    }

}
