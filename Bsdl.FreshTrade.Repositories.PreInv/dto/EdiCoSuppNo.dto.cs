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
    /// Entity for the COSUPPNO table
    /// </summary>
    [DataContract]
    public class EdiCoSuppNo 
    {
      
        [DataMember]            
        public int Hocode {get; set;}
      
        [DataMember]            
        public int Coglbno {get; set;}
    
       [DataMember]              
        public short? Allowasngeneratepallets {get;set;}

    
       [DataMember]              
        public short? Allownewordersameday {get;set;}

    
       [DataMember]              
        public string AnsiApplicationreceiverscode {get;set;}

    
       [DataMember]              
        public string AnsiElementsepchar {get;set;}

    
       [DataMember]              
        public string AnsiFieldsepchar {get;set;}

    
       [DataMember]              
        public int? AnsiInterchngcontrolno {get;set;}

    
       [DataMember]              
        public string AnsiInterchngreceiverid {get;set;}

    
       [DataMember]              
        public string AnsiInterchngreceiverqual {get;set;}

    
       [DataMember]              
        public string AnsiInterchngsenderid {get;set;}

    
       [DataMember]              
        public string AnsiInterchngsenderqual {get;set;}

    
       [DataMember]              
        public string AnsiProductqualifier {get;set;}

    
       [DataMember]              
        public string AnsiRefid {get;set;}

    
       [DataMember]              
        public string AnsiRefidcode {get;set;}

    
       [DataMember]              
        public string AnsiRepsepchar {get;set;}

    
       [DataMember]              
        public short? AnsiReqacknowledgement {get;set;}

    
       [DataMember]              
        public string AnsiTestorproduction {get;set;}

    
       [DataMember]              
        public int? AnsiTransactionsetcontrolno {get;set;}

    
       [DataMember]              
        public short? Asnincludeweight {get;set;}

    
       [DataMember]              
        public short? Asnoneproductperpallet {get;set;}

    
       [DataMember]              
        public string Asnunbana {get;set;}

    
       [DataMember]              
        public short? Blankildisspaces {get;set;}

    
       [DataMember]              
        public short? Blanktransportid {get;set;}

    
       [DataMember]              
        public string Caselabelprtnm {get;set;}

    
       [DataMember]              
        public string Caselabelprtor {get;set;}

    
       [DataMember]              
        public short? Combinedeliveries {get;set;}

    
       [DataMember]              
        public short? Crossdockupload {get;set;}

    
       [DataMember]              
        public string Duplicateorders {get;set;}

    
       [DataMember]              
        public string Edidbtcdtfileext {get;set;}

    
       [DataMember]              
        public string Edidbtcdtfileprefix {get;set;}

    
       [DataMember]              
        public int? Edidbtcdtformatrecno {get;set;}

    
       [DataMember]              
        public string Edidbtcdttrnformat {get;set;}

    
       [DataMember]              
        public string Edidbtscdts {get;set;}

    
       [DataMember]              
        public string Edidelnotefileext {get;set;}

    
       [DataMember]              
        public string Edidelnotefileprefix {get;set;}

    
       [DataMember]              
        public int? Edidelnoteformatrecno {get;set;}

    
       [DataMember]              
        public string Edidelnotes {get;set;}

    
       [DataMember]              
        public string Edidelnotetrnformat {get;set;}

    
       [DataMember]              
        public string Ediinvoicefileext {get;set;}

    
       [DataMember]              
        public string Ediinvoicefileprefix {get;set;}

    
       [DataMember]              
        public int? Ediinvoiceformatrecno {get;set;}

    
       [DataMember]              
        public string Ediinvoicerouting {get;set;}

    
       [DataMember]              
        public string Ediinvoices {get;set;}

    
       [DataMember]              
        public string Ediinvoicetrnformat {get;set;}

    
       [DataMember]              
        public string Ediorderfileext {get;set;}

    
       [DataMember]              
        public string Ediorderfileprefix {get;set;}

    
       [DataMember]              
        public int? Ediorderformatrecno {get;set;}

    
       [DataMember]              
        public string Ediorders {get;set;}

    
       [DataMember]              
        public string Ediordertrnformat {get;set;}

    
       [DataMember]              
        public string Ediprgorderfileext {get;set;}

    
       [DataMember]              
        public string Ediprgorderfileprefix {get;set;}

    
       [DataMember]              
        public int? Ediprgorderformatrecno {get;set;}

    
       [DataMember]              
        public string Ediprgorders {get;set;}

    
       [DataMember]              
        public string Ediprgordertrnformat {get;set;}

    
       [DataMember]              
        public string Edipricelistfileext {get;set;}

    
       [DataMember]              
        public string Edipricelistfileprefix {get;set;}

    
       [DataMember]              
        public int? Edipricelistformatrecno {get;set;}

    
       [DataMember]              
        public string Edipricelists {get;set;}

    
       [DataMember]              
        public string Edipricelistsout {get;set;}

    
       [DataMember]              
        public string Edipricelisttrnformat {get;set;}

    
       [DataMember]              
        public string Ediremitfileext {get;set;}

    
       [DataMember]              
        public string Ediremitfileprefix {get;set;}

    
       [DataMember]              
        public string Ediremittances {get;set;}

    
       [DataMember]              
        public string Ediremittrnformat {get;set;}

    
       [DataMember]              
        public int? Ediremittrnformatrecno {get;set;}

    
       [DataMember]              
        public short? Ediremoveleadzero {get;set;}

    
       [DataMember]              
        public string Edishipdesc {get;set;}

    
       [DataMember]              
        public string Edishipext {get;set;}

    
       [DataMember]              
        public int? Edishipnxtno {get;set;}

    
       [DataMember]              
        public string Edishipprefix {get;set;}

    
       [DataMember]              
        public int? Edishiprecno {get;set;}

    
       [DataMember]              
        public short? Ediuseshipping {get;set;}

    
       [DataMember]              
        public short? Exclinvprefix {get;set;}

    
       [DataMember]              
        public short? Excludezerogoods {get;set;}

    
       [DataMember]              
        public int? Freewayrealeanpos {get;set;}

    
       [DataMember]              
        public string Lineterminator {get;set;}

    
       [DataMember]              
        public int? Lstcdtout {get;set;}

    
       [DataMember]              
        public int? Lstdelnoteout {get;set;}

    
       [DataMember]              
        public int? Lstinvout {get;set;}

    
       [DataMember]              
        public int? Lstordersout {get;set;}

    
       [DataMember]              
        public int? Lstpricelistout {get;set;}

    
       [DataMember]              
        public string Newadditions {get;set;}

    
       [DataMember]              
        public int? Nxtpredlvtransid {get;set;}

    
       [DataMember]              
        public short? Orderbydlvdate {get;set;}

    
       [DataMember]              
        public int? Ordernolength {get;set;}

    
       [DataMember]              
        public int? Ordernostartposition {get;set;}

    
       [DataMember]              
        public string Palletlabelprtnm {get;set;}

    
       [DataMember]              
        public string Palletlabelprtor {get;set;}

    
       [DataMember]              
        public string Qtychangelog {get;set;}

    
       [DataMember]              
        public string Qtychanges {get;set;}

    
       [DataMember]              
        public int? Retrieveby {get;set;}

    
       [DataMember]              
        public int? Retrievehocode {get;set;}

    
       [DataMember]              
        public short? Showtransportid {get;set;}

    
       [DataMember]              
        public string Supaccno {get;set;}

    
       [DataMember]              
        public short? Supplierrefinorderno {get;set;}

    
       [DataMember]              
        public string Suppref {get;set;}

    
       [DataMember]              
        public string Tradacomidentity {get;set;}

    
       [DataMember]              
        public short? Uploadmissingproducts {get;set;}

    
       [DataMember]              
        public short? Usedepotnoasfileext {get;set;}

    
       [DataMember]              
        public short? Useearlydlvdate {get;set;}

    
       [DataMember]              
        public short? Usetradedunitinild {get;set;}

    
       [DataMember]              
        public short? Vatnbrinfreeway {get;set;}

    
       [DataMember]              
        public short? Writeweeklyorders {get;set;}

    }

/*
result.Hocode = item.Hocode;
result.Coglbno = item.Coglbno;
  result.Allowasngeneratepallets = item.Allowasngeneratepallets;
  result.Allownewordersameday = item.Allownewordersameday;
  result.AnsiApplicationreceiverscode = item.AnsiApplicationreceiverscode;
  result.AnsiElementsepchar = item.AnsiElementsepchar;
  result.AnsiFieldsepchar = item.AnsiFieldsepchar;
  result.AnsiInterchngcontrolno = item.AnsiInterchngcontrolno;
  result.AnsiInterchngreceiverid = item.AnsiInterchngreceiverid;
  result.AnsiInterchngreceiverqual = item.AnsiInterchngreceiverqual;
  result.AnsiInterchngsenderid = item.AnsiInterchngsenderid;
  result.AnsiInterchngsenderqual = item.AnsiInterchngsenderqual;
  result.AnsiProductqualifier = item.AnsiProductqualifier;
  result.AnsiRefid = item.AnsiRefid;
  result.AnsiRefidcode = item.AnsiRefidcode;
  result.AnsiRepsepchar = item.AnsiRepsepchar;
  result.AnsiReqacknowledgement = item.AnsiReqacknowledgement;
  result.AnsiTestorproduction = item.AnsiTestorproduction;
  result.AnsiTransactionsetcontrolno = item.AnsiTransactionsetcontrolno;
  result.Asnincludeweight = item.Asnincludeweight;
  result.Asnoneproductperpallet = item.Asnoneproductperpallet;
  result.Asnunbana = item.Asnunbana;
  result.Blankildisspaces = item.Blankildisspaces;
  result.Blanktransportid = item.Blanktransportid;
  result.Caselabelprtnm = item.Caselabelprtnm;
  result.Caselabelprtor = item.Caselabelprtor;
  result.Combinedeliveries = item.Combinedeliveries;
  result.Crossdockupload = item.Crossdockupload;
  result.Duplicateorders = item.Duplicateorders;
  result.Edidbtcdtfileext = item.Edidbtcdtfileext;
  result.Edidbtcdtfileprefix = item.Edidbtcdtfileprefix;
  result.Edidbtcdtformatrecno = item.Edidbtcdtformatrecno;
  result.Edidbtcdttrnformat = item.Edidbtcdttrnformat;
  result.Edidbtscdts = item.Edidbtscdts;
  result.Edidelnotefileext = item.Edidelnotefileext;
  result.Edidelnotefileprefix = item.Edidelnotefileprefix;
  result.Edidelnoteformatrecno = item.Edidelnoteformatrecno;
  result.Edidelnotes = item.Edidelnotes;
  result.Edidelnotetrnformat = item.Edidelnotetrnformat;
  result.Ediinvoicefileext = item.Ediinvoicefileext;
  result.Ediinvoicefileprefix = item.Ediinvoicefileprefix;
  result.Ediinvoiceformatrecno = item.Ediinvoiceformatrecno;
  result.Ediinvoicerouting = item.Ediinvoicerouting;
  result.Ediinvoices = item.Ediinvoices;
  result.Ediinvoicetrnformat = item.Ediinvoicetrnformat;
  result.Ediorderfileext = item.Ediorderfileext;
  result.Ediorderfileprefix = item.Ediorderfileprefix;
  result.Ediorderformatrecno = item.Ediorderformatrecno;
  result.Ediorders = item.Ediorders;
  result.Ediordertrnformat = item.Ediordertrnformat;
  result.Ediprgorderfileext = item.Ediprgorderfileext;
  result.Ediprgorderfileprefix = item.Ediprgorderfileprefix;
  result.Ediprgorderformatrecno = item.Ediprgorderformatrecno;
  result.Ediprgorders = item.Ediprgorders;
  result.Ediprgordertrnformat = item.Ediprgordertrnformat;
  result.Edipricelistfileext = item.Edipricelistfileext;
  result.Edipricelistfileprefix = item.Edipricelistfileprefix;
  result.Edipricelistformatrecno = item.Edipricelistformatrecno;
  result.Edipricelists = item.Edipricelists;
  result.Edipricelistsout = item.Edipricelistsout;
  result.Edipricelisttrnformat = item.Edipricelisttrnformat;
  result.Ediremitfileext = item.Ediremitfileext;
  result.Ediremitfileprefix = item.Ediremitfileprefix;
  result.Ediremittances = item.Ediremittances;
  result.Ediremittrnformat = item.Ediremittrnformat;
  result.Ediremittrnformatrecno = item.Ediremittrnformatrecno;
  result.Ediremoveleadzero = item.Ediremoveleadzero;
  result.Edishipdesc = item.Edishipdesc;
  result.Edishipext = item.Edishipext;
  result.Edishipnxtno = item.Edishipnxtno;
  result.Edishipprefix = item.Edishipprefix;
  result.Edishiprecno = item.Edishiprecno;
  result.Ediuseshipping = item.Ediuseshipping;
  result.Exclinvprefix = item.Exclinvprefix;
  result.Excludezerogoods = item.Excludezerogoods;
  result.Freewayrealeanpos = item.Freewayrealeanpos;
  result.Lineterminator = item.Lineterminator;
  result.Lstcdtout = item.Lstcdtout;
  result.Lstdelnoteout = item.Lstdelnoteout;
  result.Lstinvout = item.Lstinvout;
  result.Lstordersout = item.Lstordersout;
  result.Lstpricelistout = item.Lstpricelistout;
  result.Newadditions = item.Newadditions;
  result.Nxtpredlvtransid = item.Nxtpredlvtransid;
  result.Orderbydlvdate = item.Orderbydlvdate;
  result.Ordernolength = item.Ordernolength;
  result.Ordernostartposition = item.Ordernostartposition;
  result.Palletlabelprtnm = item.Palletlabelprtnm;
  result.Palletlabelprtor = item.Palletlabelprtor;
  result.Qtychangelog = item.Qtychangelog;
  result.Qtychanges = item.Qtychanges;
  result.Retrieveby = item.Retrieveby;
  result.Retrievehocode = item.Retrievehocode;
  result.Showtransportid = item.Showtransportid;
  result.Supaccno = item.Supaccno;
  result.Supplierrefinorderno = item.Supplierrefinorderno;
  result.Suppref = item.Suppref;
  result.Tradacomidentity = item.Tradacomidentity;
  result.Uploadmissingproducts = item.Uploadmissingproducts;
  result.Usedepotnoasfileext = item.Usedepotnoasfileext;
  result.Useearlydlvdate = item.Useearlydlvdate;
  result.Usetradedunitinild = item.Usetradedunitinild;
  result.Vatnbrinfreeway = item.Vatnbrinfreeway;
  result.Writeweeklyorders = item.Writeweeklyorders;


            
*/  

/*
Hocode = item.Hocode,
Coglbno = item.Coglbno,
Allowasngeneratepallets = item.Allowasngeneratepallets,
Allownewordersameday = item.Allownewordersameday,
AnsiApplicationreceiverscode = item.AnsiApplicationreceiverscode,
AnsiElementsepchar = item.AnsiElementsepchar,
AnsiFieldsepchar = item.AnsiFieldsepchar,
AnsiInterchngcontrolno = item.AnsiInterchngcontrolno,
AnsiInterchngreceiverid = item.AnsiInterchngreceiverid,
AnsiInterchngreceiverqual = item.AnsiInterchngreceiverqual,
AnsiInterchngsenderid = item.AnsiInterchngsenderid,
AnsiInterchngsenderqual = item.AnsiInterchngsenderqual,
AnsiProductqualifier = item.AnsiProductqualifier,
AnsiRefid = item.AnsiRefid,
AnsiRefidcode = item.AnsiRefidcode,
AnsiRepsepchar = item.AnsiRepsepchar,
AnsiReqacknowledgement = item.AnsiReqacknowledgement,
AnsiTestorproduction = item.AnsiTestorproduction,
AnsiTransactionsetcontrolno = item.AnsiTransactionsetcontrolno,
Asnincludeweight = item.Asnincludeweight,
Asnoneproductperpallet = item.Asnoneproductperpallet,
Asnunbana = item.Asnunbana,
Blankildisspaces = item.Blankildisspaces,
Blanktransportid = item.Blanktransportid,
Caselabelprtnm = item.Caselabelprtnm,
Caselabelprtor = item.Caselabelprtor,
Combinedeliveries = item.Combinedeliveries,
Crossdockupload = item.Crossdockupload,
Duplicateorders = item.Duplicateorders,
Edidbtcdtfileext = item.Edidbtcdtfileext,
Edidbtcdtfileprefix = item.Edidbtcdtfileprefix,
Edidbtcdtformatrecno = item.Edidbtcdtformatrecno,
Edidbtcdttrnformat = item.Edidbtcdttrnformat,
Edidbtscdts = item.Edidbtscdts,
Edidelnotefileext = item.Edidelnotefileext,
Edidelnotefileprefix = item.Edidelnotefileprefix,
Edidelnoteformatrecno = item.Edidelnoteformatrecno,
Edidelnotes = item.Edidelnotes,
Edidelnotetrnformat = item.Edidelnotetrnformat,
Ediinvoicefileext = item.Ediinvoicefileext,
Ediinvoicefileprefix = item.Ediinvoicefileprefix,
Ediinvoiceformatrecno = item.Ediinvoiceformatrecno,
Ediinvoicerouting = item.Ediinvoicerouting,
Ediinvoices = item.Ediinvoices,
Ediinvoicetrnformat = item.Ediinvoicetrnformat,
Ediorderfileext = item.Ediorderfileext,
Ediorderfileprefix = item.Ediorderfileprefix,
Ediorderformatrecno = item.Ediorderformatrecno,
Ediorders = item.Ediorders,
Ediordertrnformat = item.Ediordertrnformat,
Ediprgorderfileext = item.Ediprgorderfileext,
Ediprgorderfileprefix = item.Ediprgorderfileprefix,
Ediprgorderformatrecno = item.Ediprgorderformatrecno,
Ediprgorders = item.Ediprgorders,
Ediprgordertrnformat = item.Ediprgordertrnformat,
Edipricelistfileext = item.Edipricelistfileext,
Edipricelistfileprefix = item.Edipricelistfileprefix,
Edipricelistformatrecno = item.Edipricelistformatrecno,
Edipricelists = item.Edipricelists,
Edipricelistsout = item.Edipricelistsout,
Edipricelisttrnformat = item.Edipricelisttrnformat,
Ediremitfileext = item.Ediremitfileext,
Ediremitfileprefix = item.Ediremitfileprefix,
Ediremittances = item.Ediremittances,
Ediremittrnformat = item.Ediremittrnformat,
Ediremittrnformatrecno = item.Ediremittrnformatrecno,
Ediremoveleadzero = item.Ediremoveleadzero,
Edishipdesc = item.Edishipdesc,
Edishipext = item.Edishipext,
Edishipnxtno = item.Edishipnxtno,
Edishipprefix = item.Edishipprefix,
Edishiprecno = item.Edishiprecno,
Ediuseshipping = item.Ediuseshipping,
Exclinvprefix = item.Exclinvprefix,
Excludezerogoods = item.Excludezerogoods,
Freewayrealeanpos = item.Freewayrealeanpos,
Lineterminator = item.Lineterminator,
Lstcdtout = item.Lstcdtout,
Lstdelnoteout = item.Lstdelnoteout,
Lstinvout = item.Lstinvout,
Lstordersout = item.Lstordersout,
Lstpricelistout = item.Lstpricelistout,
Newadditions = item.Newadditions,
Nxtpredlvtransid = item.Nxtpredlvtransid,
Orderbydlvdate = item.Orderbydlvdate,
Ordernolength = item.Ordernolength,
Ordernostartposition = item.Ordernostartposition,
Palletlabelprtnm = item.Palletlabelprtnm,
Palletlabelprtor = item.Palletlabelprtor,
Qtychangelog = item.Qtychangelog,
Qtychanges = item.Qtychanges,
Retrieveby = item.Retrieveby,
Retrievehocode = item.Retrievehocode,
Showtransportid = item.Showtransportid,
Supaccno = item.Supaccno,
Supplierrefinorderno = item.Supplierrefinorderno,
Suppref = item.Suppref,
Tradacomidentity = item.Tradacomidentity,
Uploadmissingproducts = item.Uploadmissingproducts,
Usedepotnoasfileext = item.Usedepotnoasfileext,
Useearlydlvdate = item.Useearlydlvdate,
Usetradedunitinild = item.Usetradedunitinild,
Vatnbrinfreeway = item.Vatnbrinfreeway,
Writeweeklyorders = item.Writeweeklyorders,


            
*/  

    }

}
