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
    /// Entity for the STOCLOC table
    /// </summary>
    [DataContract]
    public class StocLoc 
    {
      
        [DataMember]            
        public int Stcrecno {get; set;}
    
       [DataMember]              
        public string Aliasfrom {get;set;}

    
       [DataMember]              
        public string Aliasto {get;set;}

    
       [DataMember]              
        public short? Allocareaexpected {get;set;}

    
       [DataMember]              
        public short? Alloclitidtrnshipno {get;set;}

        /// <summary>
        /// Will allow the site to recieve automatically in Purchase Order Entry
        /// </summary>
    
       [DataMember]              
        public short? Allowautorcvinpoentry {get;set;}

    
       [DataMember]              
        public short? Allowfifointshiprcv {get;set;}

    
       [DataMember]              
        public short? Autoallocpick {get;set;}

        /// <summary>
        /// Will allow sales to automatically be status DPT in ORDENTFORPRGDET
        /// </summary>
    
       [DataMember]              
        public short? Autodespatchinordprgdet {get;set;}

        /// <summary>
        /// Ancillaries will be auto-allocated to Stock
        /// </summary>
    
       [DataMember]              
        public short? AutofifoalloconAnc {get;set;}

    
       [DataMember]              
        public short? Autoonerouteperdlv {get;set;}

    
       [DataMember]              
        public short Autopackmeth {get;set;}

    
       [DataMember]              
        public short? Autorcvfifopals {get;set;}

    
       [DataMember]              
        public short? Autorcvonepoperday {get;set;}

    
       [DataMember]              
        public short? Autorcvtrans {get;set;}

    
       [DataMember]              
        public short? Canrepack {get;set;}

    
       [DataMember]              
        public string Capecode {get;set;}

    
       [DataMember]              
        public short Capespan {get;set;}

    
       [DataMember]              
        public string Chepcode {get;set;}

    
       [DataMember]              
        public short? Communicate {get;set;}

    
       [DataMember]              
        public short? Confirmtranshipments {get;set;}

    
       [DataMember]              
        public short? Confsaleout {get;set;}

    
       [DataMember]              
        public short? Consolidatepick {get;set;}

    
       [DataMember]              
        public int? Defloadbayrecno {get;set;}

    
       [DataMember]              
        public int? Defprepackareain {get;set;}

    
       [DataMember]              
        public int? Defprepackareaout {get;set;}

    
       [DataMember]              
        public int? Defsmnno {get;set;}

    
       [DataMember]              
        public int? Deftranbayrecno {get;set;}

    
       [DataMember]              
        public string Delnoterpt {get;set;}

    
       [DataMember]              
        public string Delprinter {get;set;}

    
       [DataMember]              
        public short? Discardallocmsgondlvprt {get;set;}

    
       [DataMember]              
        public short? Dlvnoteshowsancilandpallet {get;set;}

    
       [DataMember]              
        public short? Entaveqcwgt4tship {get;set;}

        /// <summary>
        /// DELLIST FIFO ORDER - LINKED TO LOOKUPS
        /// </summary>
    
       [DataMember]              
        public int? FifoDespOpt {get;set;}

        /// <summary>
        /// ORDER FOR FIFO_DESP_OPT - 1 = ASCENDING 2 = DESCENDING
        /// </summary>
    
       [DataMember]              
        public short? FifoDespOrder {get;set;}

    
       [DataMember]              
        public int? Homesaloffno {get;set;}

    
       [DataMember]              
        public int? Homestcloc {get;set;}

    
       [DataMember]              
        public string Ifcocode {get;set;}

    
       [DataMember]              
        public int? Incountry {get;set;}

    
       [DataMember]              
        public int? Intransitbayrecno {get;set;}

    
       [DataMember]              
        public short? Iscommssite {get;set;}

    
       [DataMember]              
        public int? Isdirstcloc {get;set;}

    
       [DataMember]              
        public short? Isgrowerdirect {get;set;}

    
       [DataMember]              
        public short? Isnonpallet {get;set;}

    
       [DataMember]              
        public short? Istradesaleslocation {get;set;}

    
       [DataMember]              
        public short? Lissplitpick {get;set;}

    
       [DataMember]              
        public string Locarea {get;set;}

    
       [DataMember]              
        public int? Lstdaldelrecno {get;set;}

    
       [DataMember]              
        public int? Lstpalaudrecno {get;set;}

    
       [DataMember]              
        public int Maxsmvtime {get;set;}

    
       [DataMember]              
        public string Modemno {get;set;}

        /// <summary>
        /// Number of PO Labels to print
        /// </summary>
    
       [DataMember]              
        public int? Nopopallab {get;set;}

        /// <summary>
        /// Number of WO Labels to print
        /// </summary>
    
       [DataMember]              
        public int? Nowopallab {get;set;}

    
       [DataMember]              
        public short? Onepalperlotinlotpoent {get;set;}

    
       [DataMember]              
        public short? Onepoperdeldet {get;set;}

    
       [DataMember]              
        public short? Palcust {get;set;}

    
       [DataMember]              
        public short? Palletondel {get;set;}

    
       [DataMember]              
        public short? Palletonpick {get;set;}

    
       [DataMember]              
        public short Palwiz {get;set;}

    
       [DataMember]              
        public string Picklistrpt {get;set;}

    
       [DataMember]              
        public string Pickprinter {get;set;}

    
       [DataMember]              
        public int? Pp2ndclassoutarea {get;set;}

    
       [DataMember]              
        public int? Pp2ndclassoutloc {get;set;}

    
       [DataMember]              
        public int? Ppfirstclassoutloc {get;set;}

    
       [DataMember]              
        public string Prdelnote {get;set;}

    
       [DataMember]              
        public string Prpicklst {get;set;}

    
       [DataMember]              
        public short? Restrictpalstostocloc {get;set;}

    
       [DataMember]              
        public string Stclocdesc {get;set;}

    
       [DataMember]              
        public short Stclocfifo {get;set;}

    
       [DataMember]              
        public string Stoclocananumber {get;set;}

    
       [DataMember]              
        public short? Suppressoverallocmsg {get;set;}

    
       [DataMember]              
        public int? Transhipbayrecno {get;set;}

    
       [DataMember]              
        public short? TshipSplitatnew {get;set;}

    
       [DataMember]              
        public short? Usealternateproddescs {get;set;}

    
       [DataMember]              
        public short? Weighallkgpicks {get;set;}

    }

/*
result.Stcrecno = item.Stcrecno;
  result.Aliasfrom = item.Aliasfrom;
  result.Aliasto = item.Aliasto;
  result.Allocareaexpected = item.Allocareaexpected;
  result.Alloclitidtrnshipno = item.Alloclitidtrnshipno;
  result.Allowautorcvinpoentry = item.Allowautorcvinpoentry;
  result.Allowfifointshiprcv = item.Allowfifointshiprcv;
  result.Autoallocpick = item.Autoallocpick;
  result.Autodespatchinordprgdet = item.Autodespatchinordprgdet;
  result.AutofifoalloconAnc = item.AutofifoalloconAnc;
  result.Autoonerouteperdlv = item.Autoonerouteperdlv;
  result.Autopackmeth = item.Autopackmeth;
  result.Autorcvfifopals = item.Autorcvfifopals;
  result.Autorcvonepoperday = item.Autorcvonepoperday;
  result.Autorcvtrans = item.Autorcvtrans;
  result.Canrepack = item.Canrepack;
  result.Capecode = item.Capecode;
  result.Capespan = item.Capespan;
  result.Chepcode = item.Chepcode;
  result.Communicate = item.Communicate;
  result.Confirmtranshipments = item.Confirmtranshipments;
  result.Confsaleout = item.Confsaleout;
  result.Consolidatepick = item.Consolidatepick;
  result.Defloadbayrecno = item.Defloadbayrecno;
  result.Defprepackareain = item.Defprepackareain;
  result.Defprepackareaout = item.Defprepackareaout;
  result.Defsmnno = item.Defsmnno;
  result.Deftranbayrecno = item.Deftranbayrecno;
  result.Delnoterpt = item.Delnoterpt;
  result.Delprinter = item.Delprinter;
  result.Discardallocmsgondlvprt = item.Discardallocmsgondlvprt;
  result.Dlvnoteshowsancilandpallet = item.Dlvnoteshowsancilandpallet;
  result.Entaveqcwgt4tship = item.Entaveqcwgt4tship;
  result.FifoDespOpt = item.FifoDespOpt;
  result.FifoDespOrder = item.FifoDespOrder;
  result.Homesaloffno = item.Homesaloffno;
  result.Homestcloc = item.Homestcloc;
  result.Ifcocode = item.Ifcocode;
  result.Incountry = item.Incountry;
  result.Intransitbayrecno = item.Intransitbayrecno;
  result.Iscommssite = item.Iscommssite;
  result.Isdirstcloc = item.Isdirstcloc;
  result.Isgrowerdirect = item.Isgrowerdirect;
  result.Isnonpallet = item.Isnonpallet;
  result.Istradesaleslocation = item.Istradesaleslocation;
  result.Lissplitpick = item.Lissplitpick;
  result.Locarea = item.Locarea;
  result.Lstdaldelrecno = item.Lstdaldelrecno;
  result.Lstpalaudrecno = item.Lstpalaudrecno;
  result.Maxsmvtime = item.Maxsmvtime;
  result.Modemno = item.Modemno;
  result.Nopopallab = item.Nopopallab;
  result.Nowopallab = item.Nowopallab;
  result.Onepalperlotinlotpoent = item.Onepalperlotinlotpoent;
  result.Onepoperdeldet = item.Onepoperdeldet;
  result.Palcust = item.Palcust;
  result.Palletondel = item.Palletondel;
  result.Palletonpick = item.Palletonpick;
  result.Palwiz = item.Palwiz;
  result.Picklistrpt = item.Picklistrpt;
  result.Pickprinter = item.Pickprinter;
  result.Pp2ndclassoutarea = item.Pp2ndclassoutarea;
  result.Pp2ndclassoutloc = item.Pp2ndclassoutloc;
  result.Ppfirstclassoutloc = item.Ppfirstclassoutloc;
  result.Prdelnote = item.Prdelnote;
  result.Prpicklst = item.Prpicklst;
  result.Restrictpalstostocloc = item.Restrictpalstostocloc;
  result.Stclocdesc = item.Stclocdesc;
  result.Stclocfifo = item.Stclocfifo;
  result.Stoclocananumber = item.Stoclocananumber;
  result.Suppressoverallocmsg = item.Suppressoverallocmsg;
  result.Transhipbayrecno = item.Transhipbayrecno;
  result.TshipSplitatnew = item.TshipSplitatnew;
  result.Usealternateproddescs = item.Usealternateproddescs;
  result.Weighallkgpicks = item.Weighallkgpicks;


            
*/  

/*
Stcrecno = item.Stcrecno,
Aliasfrom = item.Aliasfrom,
Aliasto = item.Aliasto,
Allocareaexpected = item.Allocareaexpected,
Alloclitidtrnshipno = item.Alloclitidtrnshipno,
Allowautorcvinpoentry = item.Allowautorcvinpoentry,
Allowfifointshiprcv = item.Allowfifointshiprcv,
Autoallocpick = item.Autoallocpick,
Autodespatchinordprgdet = item.Autodespatchinordprgdet,
AutofifoalloconAnc = item.AutofifoalloconAnc,
Autoonerouteperdlv = item.Autoonerouteperdlv,
Autopackmeth = item.Autopackmeth,
Autorcvfifopals = item.Autorcvfifopals,
Autorcvonepoperday = item.Autorcvonepoperday,
Autorcvtrans = item.Autorcvtrans,
Canrepack = item.Canrepack,
Capecode = item.Capecode,
Capespan = item.Capespan,
Chepcode = item.Chepcode,
Communicate = item.Communicate,
Confirmtranshipments = item.Confirmtranshipments,
Confsaleout = item.Confsaleout,
Consolidatepick = item.Consolidatepick,
Defloadbayrecno = item.Defloadbayrecno,
Defprepackareain = item.Defprepackareain,
Defprepackareaout = item.Defprepackareaout,
Defsmnno = item.Defsmnno,
Deftranbayrecno = item.Deftranbayrecno,
Delnoterpt = item.Delnoterpt,
Delprinter = item.Delprinter,
Discardallocmsgondlvprt = item.Discardallocmsgondlvprt,
Dlvnoteshowsancilandpallet = item.Dlvnoteshowsancilandpallet,
Entaveqcwgt4tship = item.Entaveqcwgt4tship,
FifoDespOpt = item.FifoDespOpt,
FifoDespOrder = item.FifoDespOrder,
Homesaloffno = item.Homesaloffno,
Homestcloc = item.Homestcloc,
Ifcocode = item.Ifcocode,
Incountry = item.Incountry,
Intransitbayrecno = item.Intransitbayrecno,
Iscommssite = item.Iscommssite,
Isdirstcloc = item.Isdirstcloc,
Isgrowerdirect = item.Isgrowerdirect,
Isnonpallet = item.Isnonpallet,
Istradesaleslocation = item.Istradesaleslocation,
Lissplitpick = item.Lissplitpick,
Locarea = item.Locarea,
Lstdaldelrecno = item.Lstdaldelrecno,
Lstpalaudrecno = item.Lstpalaudrecno,
Maxsmvtime = item.Maxsmvtime,
Modemno = item.Modemno,
Nopopallab = item.Nopopallab,
Nowopallab = item.Nowopallab,
Onepalperlotinlotpoent = item.Onepalperlotinlotpoent,
Onepoperdeldet = item.Onepoperdeldet,
Palcust = item.Palcust,
Palletondel = item.Palletondel,
Palletonpick = item.Palletonpick,
Palwiz = item.Palwiz,
Picklistrpt = item.Picklistrpt,
Pickprinter = item.Pickprinter,
Pp2ndclassoutarea = item.Pp2ndclassoutarea,
Pp2ndclassoutloc = item.Pp2ndclassoutloc,
Ppfirstclassoutloc = item.Ppfirstclassoutloc,
Prdelnote = item.Prdelnote,
Prpicklst = item.Prpicklst,
Restrictpalstostocloc = item.Restrictpalstostocloc,
Stclocdesc = item.Stclocdesc,
Stclocfifo = item.Stclocfifo,
Stoclocananumber = item.Stoclocananumber,
Suppressoverallocmsg = item.Suppressoverallocmsg,
Transhipbayrecno = item.Transhipbayrecno,
TshipSplitatnew = item.TshipSplitatnew,
Usealternateproddescs = item.Usealternateproddescs,
Weighallkgpicks = item.Weighallkgpicks,


            
*/  

    }

}
