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
    /// Entity for the PRDREC table
    /// </summary>
    [DataContract]
    public class Prdrec 
    {
      
        [DataMember]            
        public int Prcprdno {get; set;}
    
       [DataMember]              
        public short? Active {get;set;}

    
       [DataMember]              
        public short? Defaultprd {get;set;}

    
       [DataMember]              
        public string Gtin {get;set;}

    
       [DataMember]              
        public string Gtinchecksum {get;set;}

    
       [DataMember]              
        public int? Innerqty {get;set;}

    
       [DataMember]              
        public string Innertype {get;set;}

    
       [DataMember]              
        public short? Ismiscprod {get;set;}

    
       [DataMember]              
        public short? Istradesalesprd {get;set;}

    
       [DataMember]              
        public int? Maxprcpacpal {get;set;}

    
       [DataMember]              
        public decimal? Maxprcweight {get;set;}

    
       [DataMember]              
        public int? Orderupliftperc {get;set;}

    
       [DataMember]              
        public int? Packitemno {get;set;}

    
       [DataMember]              
        public int? Palpanrecno {get;set;}

    
       [DataMember]              
        public int? Panrecnoinnertype {get;set;}

    
       [DataMember]              
        public string Prcbaseprice {get;set;}

    
       [DataMember]              
        public int Prcboxqty {get;set;}

    
       [DataMember]              
        public decimal Prcchgmult {get;set;}

    
       [DataMember]              
        public short? Prcdescchg {get;set;}

    
       [DataMember]              
        public string Prcdescription {get;set;}

    
       [DataMember]              
        public int Prcglbrecno {get;set;}

    
       [DataMember]              
        public decimal? Prcgrsweight {get;set;}

    
       [DataMember]              
        public string Prcintracode {get;set;}

    
       [DataMember]              
        public string Prcmaxprofit {get;set;}

    
       [DataMember]              
        public string Prcminprofit {get;set;}

    
       [DataMember]              
        public decimal? Prcnominalvalue {get;set;}

    
       [DataMember]              
        public int Prcpacpal {get;set;}

    
       [DataMember]              
        public string Prcprdref {get;set;}

    
       [DataMember]              
        public short Prcpurbywgt {get;set;}

    
       [DataMember]              
        public int? Prcref1 {get;set;}

    
       [DataMember]              
        public int? Prcref2 {get;set;}

    
       [DataMember]              
        public int? Prcref3 {get;set;}

    
       [DataMember]              
        public int? Prcref4 {get;set;}

    
       [DataMember]              
        public int? Prcref5 {get;set;}

    
       [DataMember]              
        public int? Prcref6 {get;set;}

    
       [DataMember]              
        public short? Prcsalbybox {get;set;}

    
       [DataMember]              
        public short? Prcsalbyeach {get;set;}

    
       [DataMember]              
        public short? Prcsalbyinner {get;set;}

    
       [DataMember]              
        public short Prcsalbywgt {get;set;}

    
       [DataMember]              
        public int Prcsampqty {get;set;}

    
       [DataMember]              
        public string Prcshortdesc {get;set;}

    
       [DataMember]              
        public short Prcstkbywgt {get;set;}

    
       [DataMember]              
        public string Prcstreetprice {get;set;}

    
       [DataMember]              
        public int? Prctemperature {get;set;}

    
       [DataMember]              
        public int? Prcvatcode {get;set;}

    
       [DataMember]              
        public decimal Prcweight {get;set;}

    
       [DataMember]              
        public short? Prdtype {get;set;}

    
       [DataMember]              
        public int? Preusagebydecimal {get;set;}

    
       [DataMember]              
        public int? Prodtype {get;set;}

    
       [DataMember]              
        public decimal? Retailunit {get;set;}

    }

/*
result.Prcprdno = item.Prcprdno;
  result.Active = item.Active;
  result.Defaultprd = item.Defaultprd;
  result.Gtin = item.Gtin;
  result.Gtinchecksum = item.Gtinchecksum;
  result.Innerqty = item.Innerqty;
  result.Innertype = item.Innertype;
  result.Ismiscprod = item.Ismiscprod;
  result.Istradesalesprd = item.Istradesalesprd;
  result.Maxprcpacpal = item.Maxprcpacpal;
  result.Maxprcweight = item.Maxprcweight;
  result.Orderupliftperc = item.Orderupliftperc;
  result.Packitemno = item.Packitemno;
  result.Palpanrecno = item.Palpanrecno;
  result.Panrecnoinnertype = item.Panrecnoinnertype;
  result.Prcbaseprice = item.Prcbaseprice;
  result.Prcboxqty = item.Prcboxqty;
  result.Prcchgmult = item.Prcchgmult;
  result.Prcdescchg = item.Prcdescchg;
  result.Prcdescription = item.Prcdescription;
  result.Prcglbrecno = item.Prcglbrecno;
  result.Prcgrsweight = item.Prcgrsweight;
  result.Prcintracode = item.Prcintracode;
  result.Prcmaxprofit = item.Prcmaxprofit;
  result.Prcminprofit = item.Prcminprofit;
  result.Prcnominalvalue = item.Prcnominalvalue;
  result.Prcpacpal = item.Prcpacpal;
  result.Prcprdref = item.Prcprdref;
  result.Prcpurbywgt = item.Prcpurbywgt;
  result.Prcref1 = item.Prcref1;
  result.Prcref2 = item.Prcref2;
  result.Prcref3 = item.Prcref3;
  result.Prcref4 = item.Prcref4;
  result.Prcref5 = item.Prcref5;
  result.Prcref6 = item.Prcref6;
  result.Prcsalbybox = item.Prcsalbybox;
  result.Prcsalbyeach = item.Prcsalbyeach;
  result.Prcsalbyinner = item.Prcsalbyinner;
  result.Prcsalbywgt = item.Prcsalbywgt;
  result.Prcsampqty = item.Prcsampqty;
  result.Prcshortdesc = item.Prcshortdesc;
  result.Prcstkbywgt = item.Prcstkbywgt;
  result.Prcstreetprice = item.Prcstreetprice;
  result.Prctemperature = item.Prctemperature;
  result.Prcvatcode = item.Prcvatcode;
  result.Prcweight = item.Prcweight;
  result.Prdtype = item.Prdtype;
  result.Preusagebydecimal = item.Preusagebydecimal;
  result.Prodtype = item.Prodtype;
  result.Retailunit = item.Retailunit;


            
*/  

/*
Prcprdno = item.Prcprdno,
Active = item.Active,
Defaultprd = item.Defaultprd,
Gtin = item.Gtin,
Gtinchecksum = item.Gtinchecksum,
Innerqty = item.Innerqty,
Innertype = item.Innertype,
Ismiscprod = item.Ismiscprod,
Istradesalesprd = item.Istradesalesprd,
Maxprcpacpal = item.Maxprcpacpal,
Maxprcweight = item.Maxprcweight,
Orderupliftperc = item.Orderupliftperc,
Packitemno = item.Packitemno,
Palpanrecno = item.Palpanrecno,
Panrecnoinnertype = item.Panrecnoinnertype,
Prcbaseprice = item.Prcbaseprice,
Prcboxqty = item.Prcboxqty,
Prcchgmult = item.Prcchgmult,
Prcdescchg = item.Prcdescchg,
Prcdescription = item.Prcdescription,
Prcglbrecno = item.Prcglbrecno,
Prcgrsweight = item.Prcgrsweight,
Prcintracode = item.Prcintracode,
Prcmaxprofit = item.Prcmaxprofit,
Prcminprofit = item.Prcminprofit,
Prcnominalvalue = item.Prcnominalvalue,
Prcpacpal = item.Prcpacpal,
Prcprdref = item.Prcprdref,
Prcpurbywgt = item.Prcpurbywgt,
Prcref1 = item.Prcref1,
Prcref2 = item.Prcref2,
Prcref3 = item.Prcref3,
Prcref4 = item.Prcref4,
Prcref5 = item.Prcref5,
Prcref6 = item.Prcref6,
Prcsalbybox = item.Prcsalbybox,
Prcsalbyeach = item.Prcsalbyeach,
Prcsalbyinner = item.Prcsalbyinner,
Prcsalbywgt = item.Prcsalbywgt,
Prcsampqty = item.Prcsampqty,
Prcshortdesc = item.Prcshortdesc,
Prcstkbywgt = item.Prcstkbywgt,
Prcstreetprice = item.Prcstreetprice,
Prctemperature = item.Prctemperature,
Prcvatcode = item.Prcvatcode,
Prcweight = item.Prcweight,
Prdtype = item.Prdtype,
Preusagebydecimal = item.Preusagebydecimal,
Prodtype = item.Prodtype,
Retailunit = item.Retailunit,


            
*/  

    }

}
