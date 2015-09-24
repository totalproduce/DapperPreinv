// <summary>
// This file is generated automatically. Any changes will be lost.
// </summary>

using System;
using System.Collections.Generic;
using System.Globalization;
using Bsdl.FreshTrade.Repositories.Basic.DBModel;
using Bsdl.FreshTrade.Repositories.Basic.Persistance;

namespace Bsdl.FreshTrade.Repositories.PreInv.DBModel
{
    /// <summary>
    /// Entity for the PREINVTEMP_INVPRT2 table
    /// </summary>
    public partial class INVPRT2 : BaseDbModel<INVPRT2, string>
    {
#region tableDefs

       public static List<EntityPropDef> GetPropDefs() {
         var result = new List<EntityPropDef>();

//EntityPropDef(string propName, string columnName, bool isKey, bool isNullable, string refEntityName, PropertyInfo keyPropInfo,
//            int size, int? prec, int? scale)




         result.Add(new EntityPropDef(
         PropertyHelper <INVPRT2>.GetProperty(x => x.Alloctoinvrecno),
         "ALLOCTOINVRECNO", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  10, // int? prec
                           0  // int? Scale
         ,
         typeof(INVPRT2)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <INVPRT2>.GetProperty(x => x.Allowonelinecancel),
         "ALLOWONELINECANCEL", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  1, // int? prec
                           0  // int? Scale
         ,
         typeof(INVPRT2)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <INVPRT2>.GetProperty(x => x.Basecommamt),
         "BASECOMMAMT", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  126, // int? prec
                   
         null // int? Scale
         ,
         typeof(INVPRT2)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <INVPRT2>.GetProperty(x => x.Basegds),
         "BASEGDS", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  126, // int? prec
                   
         null // int? Scale
         ,
         typeof(INVPRT2)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <INVPRT2>.GetProperty(x => x.Basehandamt),
         "BASEHANDAMT", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  126, // int? prec
                   
         null // int? Scale
         ,
         typeof(INVPRT2)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <INVPRT2>.GetProperty(x => x.Baseoffinvrbt),
         "BASEOFFINVRBT", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  126, // int? prec
                   
         null // int? Scale
         ,
         typeof(INVPRT2)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <INVPRT2>.GetProperty(x => x.Baseoffonpay),
         "BASEOFFONPAY", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  126, // int? prec
                   
         null // int? Scale
         ,
         typeof(INVPRT2)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <INVPRT2>.GetProperty(x => x.Baseoninvdscnt),
         "BASEONINVDSCNT", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  126, // int? prec
                   
         null // int? Scale
         ,
         typeof(INVPRT2)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <INVPRT2>.GetProperty(x => x.Basevat),
         "BASEVAT", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  126, // int? prec
                   
         null // int? Scale
         ,
         typeof(INVPRT2)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <INVPRT2>.GetProperty(x => x.Basevat1total),
         "BASEVAT1TOTAL", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  126, // int? prec
                   
         null // int? Scale
         ,
         typeof(INVPRT2)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <INVPRT2>.GetProperty(x => x.Basevat2total),
         "BASEVAT2TOTAL", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  126, // int? prec
                   
         null // int? Scale
         ,
         typeof(INVPRT2)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <INVPRT2>.GetProperty(x => x.Basevatonchgs),
         "BASEVATONCHGS", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  10, // int? prec
                           0  // int? Scale
         ,
         typeof(INVPRT2)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <INVPRT2>.GetProperty(x => x.Cancelledline),
         "CANCELLEDLINE", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  1, // int? prec
                           0  // int? Scale
         ,
         typeof(INVPRT2)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <INVPRT2>.GetProperty(x => x.Commperc),
         "COMMPERC", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  126, // int? prec
                   
         null // int? Scale
         ,
         typeof(INVPRT2)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <INVPRT2>.GetProperty(x => x.Delcdsrefno),
         "DELCDSREFNO", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  10, // int? prec
                           0  // int? Scale
         ,
         typeof(INVPRT2)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <INVPRT2>.GetProperty(x => x.Delcltprdno),
         "DELCLTPRDNO", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         255,       // int size   
                  null, // int? prec
                   
         null // int? Scale
         ,
         typeof(INVPRT2)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <INVPRT2>.GetProperty(x => x.Delinvstatus),
         "DELINVSTATUS", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  10, // int? prec
                           0  // int? Scale
         ,
         typeof(INVPRT2)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <INVPRT2>.GetProperty(x => x.Delprcbywgt),
         "DELPRCBYWGT", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  1, // int? prec
                           0  // int? Scale
         ,
         typeof(INVPRT2)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <INVPRT2>.GetProperty(x => x.Delprcprdno),
         "DELPRCPRDNO", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  10, // int? prec
                           0  // int? Scale
         ,
         typeof(INVPRT2)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <INVPRT2>.GetProperty(x => x.Delprice),
         "DELPRICE", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  126, // int? prec
                   
         null // int? Scale
         ,
         typeof(INVPRT2)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <INVPRT2>.GetProperty(x => x.Delqty),
         "DELQTY", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  10, // int? prec
                           0  // int? Scale
         ,
         typeof(INVPRT2)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <INVPRT2>.GetProperty(x => x.Delrecno),
         "DELRECNO", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  10, // int? prec
                           0  // int? Scale
         ,
         typeof(INVPRT2)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <INVPRT2>.GetProperty(x => x.Delweight),
         "DELWEIGHT", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  126, // int? prec
                   
         null // int? Scale
         ,
         typeof(INVPRT2)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <INVPRT2>.GetProperty(x => x.Detallocno),
         "DETALLOCNO", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         15,       // int size   
                  null, // int? prec
                   
         null // int? Scale
         ,
         typeof(INVPRT2)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <INVPRT2>.GetProperty(x => x.Disctoqty),
         "DISCTOQTY", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  10, // int? prec
                           0  // int? Scale
         ,
         typeof(INVPRT2)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <INVPRT2>.GetProperty(x => x.Dispcnt),
         "DISPCNT", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         20,       // int size   
                  null, // int? prec
                   
         null // int? Scale
         ,
         typeof(INVPRT2)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <INVPRT2>.GetProperty(x => x.Dlvinvoiceno),
         "DLVINVOICENO", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         40,       // int size   
                  null, // int? prec
                   
         null // int? Scale
         ,
         typeof(INVPRT2)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <INVPRT2>.GetProperty(x => x.Dlvordno),
         "DLVORDNO", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  10, // int? prec
                           0  // int? Scale
         ,
         typeof(INVPRT2)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <INVPRT2>.GetProperty(x => x.Dprrecno),
         "DPRRECNO", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  10, // int? prec
                           0  // int? Scale
         ,
         typeof(INVPRT2)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <INVPRT2>.GetProperty(x => x.Eurocommamt),
         "EUROCOMMAMT", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  126, // int? prec
                   
         null // int? Scale
         ,
         typeof(INVPRT2)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <INVPRT2>.GetProperty(x => x.Eurogds),
         "EUROGDS", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  126, // int? prec
                   
         null // int? Scale
         ,
         typeof(INVPRT2)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <INVPRT2>.GetProperty(x => x.Eurohandamt),
         "EUROHANDAMT", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  126, // int? prec
                   
         null // int? Scale
         ,
         typeof(INVPRT2)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <INVPRT2>.GetProperty(x => x.Eurooffinvrbt),
         "EUROOFFINVRBT", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  126, // int? prec
                   
         null // int? Scale
         ,
         typeof(INVPRT2)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <INVPRT2>.GetProperty(x => x.Eurooffonpay),
         "EUROOFFONPAY", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  126, // int? prec
                   
         null // int? Scale
         ,
         typeof(INVPRT2)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <INVPRT2>.GetProperty(x => x.Eurooninvdscnt),
         "EUROONINVDSCNT", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  126, // int? prec
                   
         null // int? Scale
         ,
         typeof(INVPRT2)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <INVPRT2>.GetProperty(x => x.Eurovat),
         "EUROVAT", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  126, // int? prec
                   
         null // int? Scale
         ,
         typeof(INVPRT2)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <INVPRT2>.GetProperty(x => x.Eurovat1total),
         "EUROVAT1TOTAL", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  126, // int? prec
                   
         null // int? Scale
         ,
         typeof(INVPRT2)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <INVPRT2>.GetProperty(x => x.Eurovat2total),
         "EUROVAT2TOTAL", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  126, // int? prec
                   
         null // int? Scale
         ,
         typeof(INVPRT2)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <INVPRT2>.GetProperty(x => x.Eurovatonchgs),
         "EUROVATONCHGS", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  126, // int? prec
                   
         null // int? Scale
         ,
         typeof(INVPRT2)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <INVPRT2>.GetProperty(x => x.Ext),
         "EXT", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  126, // int? prec
                   
         null // int? Scale
         ,
         typeof(INVPRT2)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <INVPRT2>.GetProperty(x => x.Extractsessionid),
         "EXTRACTSESSIONID", // columnName
         false,                    //isKey
         false, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  10, // int? prec
                           0  // int? Scale
         ,
         typeof(INVPRT2)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <INVPRT2>.GetProperty(x => x.Goods),
         "GOODS", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  126, // int? prec
                   
         null // int? Scale
         ,
         typeof(INVPRT2)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <INVPRT2>.GetProperty(x => x.Grosswgt),
         "GROSSWGT", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  126, // int? prec
                   
         null // int? Scale
         ,
         typeof(INVPRT2)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <INVPRT2>.GetProperty(x => x.Handrate),
         "HANDRATE", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  126, // int? prec
                   
         null // int? Scale
         ,
         typeof(INVPRT2)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <INVPRT2>.GetProperty(x => x.Invprtrecno),
         "INVPRTRECNO", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  10, // int? prec
                           0  // int? Scale
         ,
         typeof(INVPRT2)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <INVPRT2>.GetProperty(x => x.Nettwgt),
         "NETTWGT", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  126, // int? prec
                   
         null // int? Scale
         ,
         typeof(INVPRT2)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <INVPRT2>.GetProperty(x => x.Offinvonpay),
         "OFFINVONPAY", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  126, // int? prec
                   
         null // int? Scale
         ,
         typeof(INVPRT2)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <INVPRT2>.GetProperty(x => x.Offinvrbt),
         "OFFINVRBT", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  126, // int? prec
                   
         null // int? Scale
         ,
         typeof(INVPRT2)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <INVPRT2>.GetProperty(x => x.Oninvdispcnt),
         "ONINVDISPCNT", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  126, // int? prec
                   
         null // int? Scale
         ,
         typeof(INVPRT2)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <INVPRT2>.GetProperty(x => x.Oninvdscnt),
         "ONINVDSCNT", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  126, // int? prec
                   
         null // int? Scale
         ,
         typeof(INVPRT2)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <INVPRT2>.GetProperty(x => x.Ppcno),
         "PPCNO", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  10, // int? prec
                           0  // int? Scale
         ,
         typeof(INVPRT2)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <INVPRT2>.GetProperty(x => x.Prcprdref),
         "PRCPRDREF", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         255,       // int size   
                  null, // int? prec
                   
         null // int? Scale
         ,
         typeof(INVPRT2)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <INVPRT2>.GetProperty(x => x.Prddesc),
         "PRDDESC", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         255,       // int size   
                  null, // int? prec
                   
         null // int? Scale
         ,
         typeof(INVPRT2)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <INVPRT2>.GetProperty(x => x.Prdglanl),
         "PRDGLANL", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  10, // int? prec
                           0  // int? Scale
         ,
         typeof(INVPRT2)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <INVPRT2>.GetProperty(x => x.Prdrecdesc),
         "PRDRECDESC", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         255,       // int size   
                  null, // int? prec
                   
         null // int? Scale
         ,
         typeof(INVPRT2)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <INVPRT2>.GetProperty(x => x.Prgrefno),
         "PRGREFNO", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  10, // int? prec
                           0  // int? Scale
         ,
         typeof(INVPRT2)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <INVPRT2>.GetProperty(x => x.Prtqty),
         "PRTQTY", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  126, // int? prec
                   
         null // int? Scale
         ,
         typeof(INVPRT2)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <INVPRT2>.GetProperty(x => x.Rawcommamt),
         "RAWCOMMAMT", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  126, // int? prec
                   
         null // int? Scale
         ,
         typeof(INVPRT2)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <INVPRT2>.GetProperty(x => x.Rawhandamt),
         "RAWHANDAMT", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  126, // int? prec
                   
         null // int? Scale
         ,
         typeof(INVPRT2)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <INVPRT2>.GetProperty(x => x.Rawvatonchgs),
         "RAWVATONCHGS", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  126, // int? prec
                   
         null // int? Scale
         ,
         typeof(INVPRT2)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <INVPRT2>.GetProperty(x => x.Recno),
         "RECNO", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  10, // int? prec
                           0  // int? Scale
         ,
         typeof(INVPRT2)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <INVPRT2>.GetProperty(x => x.Tarewgt),
         "TAREWGT", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  126, // int? prec
                   
         null // int? Scale
         ,
         typeof(INVPRT2)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <INVPRT2>.GetProperty(x => x.Tradedunit),
         "TRADEDUNIT", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         255,       // int size   
                  null, // int? prec
                   
         null // int? Scale
         ,
         typeof(INVPRT2)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <INVPRT2>.GetProperty(x => x.Unitcount),
         "UNITCOUNT", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  10, // int? prec
                           0  // int? Scale
         ,
         typeof(INVPRT2)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <INVPRT2>.GetProperty(x => x.Unitmeasure),
         "UNITMEASURE", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         12,       // int size   
                  null, // int? prec
                   
         null // int? Scale
         ,
         typeof(INVPRT2)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <INVPRT2>.GetProperty(x => x.Vat),
         "VAT", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  126, // int? prec
                   
         null // int? Scale
         ,
         typeof(INVPRT2)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <INVPRT2>.GetProperty(x => x.Vat1total),
         "VAT1TOTAL", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  126, // int? prec
                   
         null // int? Scale
         ,
         typeof(INVPRT2)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <INVPRT2>.GetProperty(x => x.Vat2total),
         "VAT2TOTAL", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  126, // int? prec
                   
         null // int? Scale
         ,
         typeof(INVPRT2)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <INVPRT2>.GetProperty(x => x.Vatcodechgs),
         "VATCODECHGS", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  126, // int? prec
                   
         null // int? Scale
         ,
         typeof(INVPRT2)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <INVPRT2>.GetProperty(x => x.Vatlnkrecno),
         "VATLNKRECNO", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  10, // int? prec
                           0  // int? Scale
         ,
         typeof(INVPRT2)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <INVPRT2>.GetProperty(x => x.Vatratechgs),
         "VATRATECHGS", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  126, // int? prec
                   
         null // int? Scale
         ,
         typeof(INVPRT2)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <INVPRT2>.GetProperty(x => x.Vatrecno),
         "VATRECNO", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  10, // int? prec
                           0  // int? Scale
         ,
         typeof(INVPRT2)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <INVPRT2>.GetProperty(x => x.Vatvatrate),
         "VATVATRATE", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  126, // int? prec
                   
         null // int? Scale
         ,
         typeof(INVPRT2)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <INVPRT2>.GetProperty(x => x.Vatvatrate2),
         "VATVATRATE2", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  126, // int? prec
                   
         null // int? Scale
         ,
         typeof(INVPRT2)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <INVPRT2>.GetProperty(x => x.Vatvearecno),
         "VATVEARECNO", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  10, // int? prec
                           0  // int? Scale
         ,
         typeof(INVPRT2)
         ));
         return result; 
       }

#endregion     
        private int? _fAlloctoinvrecno;
        public int? Alloctoinvrecno
        {
            get { return _fAlloctoinvrecno; }
            set
            {
                if (_fAlloctoinvrecno != value)
                {
                    Modify();
                    _fAlloctoinvrecno = value;
                }
            }
        }

        private short? _fAllowonelinecancel;
        public short? Allowonelinecancel
        {
            get { return _fAllowonelinecancel; }
            set
            {
                if (_fAllowonelinecancel != value)
                {
                    Modify();
                    _fAllowonelinecancel = value;
                }
            }
        }

        private decimal? _fBasecommamt;
        public decimal? Basecommamt
        {
            get { return _fBasecommamt; }
            set
            {
                if (_fBasecommamt != value)
                {
                    Modify();
                    _fBasecommamt = value;
                }
            }
        }

        private decimal? _fBasegds;
        public decimal? Basegds
        {
            get { return _fBasegds; }
            set
            {
                if (_fBasegds != value)
                {
                    Modify();
                    _fBasegds = value;
                }
            }
        }

        private decimal? _fBasehandamt;
        public decimal? Basehandamt
        {
            get { return _fBasehandamt; }
            set
            {
                if (_fBasehandamt != value)
                {
                    Modify();
                    _fBasehandamt = value;
                }
            }
        }

        private decimal? _fBaseoffinvrbt;
        public decimal? Baseoffinvrbt
        {
            get { return _fBaseoffinvrbt; }
            set
            {
                if (_fBaseoffinvrbt != value)
                {
                    Modify();
                    _fBaseoffinvrbt = value;
                }
            }
        }

        private decimal? _fBaseoffonpay;
        public decimal? Baseoffonpay
        {
            get { return _fBaseoffonpay; }
            set
            {
                if (_fBaseoffonpay != value)
                {
                    Modify();
                    _fBaseoffonpay = value;
                }
            }
        }

        private decimal? _fBaseoninvdscnt;
        public decimal? Baseoninvdscnt
        {
            get { return _fBaseoninvdscnt; }
            set
            {
                if (_fBaseoninvdscnt != value)
                {
                    Modify();
                    _fBaseoninvdscnt = value;
                }
            }
        }

        private decimal? _fBasevat;
        public decimal? Basevat
        {
            get { return _fBasevat; }
            set
            {
                if (_fBasevat != value)
                {
                    Modify();
                    _fBasevat = value;
                }
            }
        }

        private decimal? _fBasevat1total;
        public decimal? Basevat1total
        {
            get { return _fBasevat1total; }
            set
            {
                if (_fBasevat1total != value)
                {
                    Modify();
                    _fBasevat1total = value;
                }
            }
        }

        private decimal? _fBasevat2total;
        public decimal? Basevat2total
        {
            get { return _fBasevat2total; }
            set
            {
                if (_fBasevat2total != value)
                {
                    Modify();
                    _fBasevat2total = value;
                }
            }
        }

        private int? _fBasevatonchgs;
        public int? Basevatonchgs
        {
            get { return _fBasevatonchgs; }
            set
            {
                if (_fBasevatonchgs != value)
                {
                    Modify();
                    _fBasevatonchgs = value;
                }
            }
        }

        private short? _fCancelledline;
        public short? Cancelledline
        {
            get { return _fCancelledline; }
            set
            {
                if (_fCancelledline != value)
                {
                    Modify();
                    _fCancelledline = value;
                }
            }
        }

        private decimal? _fCommperc;
        public decimal? Commperc
        {
            get { return _fCommperc; }
            set
            {
                if (_fCommperc != value)
                {
                    Modify();
                    _fCommperc = value;
                }
            }
        }

        private int? _fDelcdsrefno;
        public int? Delcdsrefno
        {
            get { return _fDelcdsrefno; }
            set
            {
                if (_fDelcdsrefno != value)
                {
                    Modify();
                    _fDelcdsrefno = value;
                }
            }
        }

        private string _fDelcltprdno;
        public string Delcltprdno
        {
            get { return _fDelcltprdno; }
            set
            {
                if (_fDelcltprdno != value)
                {
                    Modify();
                    _fDelcltprdno = value;
                }
            }
        }

        private int? _fDelinvstatus;
        public int? Delinvstatus
        {
            get { return _fDelinvstatus; }
            set
            {
                if (_fDelinvstatus != value)
                {
                    Modify();
                    _fDelinvstatus = value;
                }
            }
        }

        private short? _fDelprcbywgt;
        public short? Delprcbywgt
        {
            get { return _fDelprcbywgt; }
            set
            {
                if (_fDelprcbywgt != value)
                {
                    Modify();
                    _fDelprcbywgt = value;
                }
            }
        }

        private int? _fDelprcprdno;
        public int? Delprcprdno
        {
            get { return _fDelprcprdno; }
            set
            {
                if (_fDelprcprdno != value)
                {
                    Modify();
                    _fDelprcprdno = value;
                }
            }
        }

        private decimal? _fDelprice;
        public decimal? Delprice
        {
            get { return _fDelprice; }
            set
            {
                if (_fDelprice != value)
                {
                    Modify();
                    _fDelprice = value;
                }
            }
        }

        private int? _fDelqty;
        public int? Delqty
        {
            get { return _fDelqty; }
            set
            {
                if (_fDelqty != value)
                {
                    Modify();
                    _fDelqty = value;
                }
            }
        }

        private int? _fDelrecno;
        public int? Delrecno
        {
            get { return _fDelrecno; }
            set
            {
                if (_fDelrecno != value)
                {
                    Modify();
                    _fDelrecno = value;
                }
            }
        }

        private decimal? _fDelweight;
        public decimal? Delweight
        {
            get { return _fDelweight; }
            set
            {
                if (_fDelweight != value)
                {
                    Modify();
                    _fDelweight = value;
                }
            }
        }

        private string _fDetallocno;
        public string Detallocno
        {
            get { return _fDetallocno; }
            set
            {
                if (_fDetallocno != value)
                {
                    Modify();
                    _fDetallocno = value;
                }
            }
        }

        private int? _fDisctoqty;
        public int? Disctoqty
        {
            get { return _fDisctoqty; }
            set
            {
                if (_fDisctoqty != value)
                {
                    Modify();
                    _fDisctoqty = value;
                }
            }
        }

        private string _fDispcnt;
        public string Dispcnt
        {
            get { return _fDispcnt; }
            set
            {
                if (_fDispcnt != value)
                {
                    Modify();
                    _fDispcnt = value;
                }
            }
        }

        private string _fDlvinvoiceno;
        public string Dlvinvoiceno
        {
            get { return _fDlvinvoiceno; }
            set
            {
                if (_fDlvinvoiceno != value)
                {
                    Modify();
                    _fDlvinvoiceno = value;
                }
            }
        }

        private int? _fDlvordno;
        public int? Dlvordno
        {
            get { return _fDlvordno; }
            set
            {
                if (_fDlvordno != value)
                {
                    Modify();
                    _fDlvordno = value;
                }
            }
        }

        private int? _fDprrecno;
        public int? Dprrecno
        {
            get { return _fDprrecno; }
            set
            {
                if (_fDprrecno != value)
                {
                    Modify();
                    _fDprrecno = value;
                }
            }
        }

        private decimal? _fEurocommamt;
        public decimal? Eurocommamt
        {
            get { return _fEurocommamt; }
            set
            {
                if (_fEurocommamt != value)
                {
                    Modify();
                    _fEurocommamt = value;
                }
            }
        }

        private decimal? _fEurogds;
        public decimal? Eurogds
        {
            get { return _fEurogds; }
            set
            {
                if (_fEurogds != value)
                {
                    Modify();
                    _fEurogds = value;
                }
            }
        }

        private decimal? _fEurohandamt;
        public decimal? Eurohandamt
        {
            get { return _fEurohandamt; }
            set
            {
                if (_fEurohandamt != value)
                {
                    Modify();
                    _fEurohandamt = value;
                }
            }
        }

        private decimal? _fEurooffinvrbt;
        public decimal? Eurooffinvrbt
        {
            get { return _fEurooffinvrbt; }
            set
            {
                if (_fEurooffinvrbt != value)
                {
                    Modify();
                    _fEurooffinvrbt = value;
                }
            }
        }

        private decimal? _fEurooffonpay;
        public decimal? Eurooffonpay
        {
            get { return _fEurooffonpay; }
            set
            {
                if (_fEurooffonpay != value)
                {
                    Modify();
                    _fEurooffonpay = value;
                }
            }
        }

        private decimal? _fEurooninvdscnt;
        public decimal? Eurooninvdscnt
        {
            get { return _fEurooninvdscnt; }
            set
            {
                if (_fEurooninvdscnt != value)
                {
                    Modify();
                    _fEurooninvdscnt = value;
                }
            }
        }

        private decimal? _fEurovat;
        public decimal? Eurovat
        {
            get { return _fEurovat; }
            set
            {
                if (_fEurovat != value)
                {
                    Modify();
                    _fEurovat = value;
                }
            }
        }

        private decimal? _fEurovat1total;
        public decimal? Eurovat1total
        {
            get { return _fEurovat1total; }
            set
            {
                if (_fEurovat1total != value)
                {
                    Modify();
                    _fEurovat1total = value;
                }
            }
        }

        private decimal? _fEurovat2total;
        public decimal? Eurovat2total
        {
            get { return _fEurovat2total; }
            set
            {
                if (_fEurovat2total != value)
                {
                    Modify();
                    _fEurovat2total = value;
                }
            }
        }

        private decimal? _fEurovatonchgs;
        public decimal? Eurovatonchgs
        {
            get { return _fEurovatonchgs; }
            set
            {
                if (_fEurovatonchgs != value)
                {
                    Modify();
                    _fEurovatonchgs = value;
                }
            }
        }

        private decimal? _fExt;
        public decimal? Ext
        {
            get { return _fExt; }
            set
            {
                if (_fExt != value)
                {
                    Modify();
                    _fExt = value;
                }
            }
        }

        private int _fExtractsessionid;
        public int Extractsessionid
        {
            get { return _fExtractsessionid; }
            set
            {
                if (_fExtractsessionid != value)
                {
                    Modify();
                    _fExtractsessionid = value;
                }
            }
        }

        private decimal? _fGoods;
        public decimal? Goods
        {
            get { return _fGoods; }
            set
            {
                if (_fGoods != value)
                {
                    Modify();
                    _fGoods = value;
                }
            }
        }

        private decimal? _fGrosswgt;
        public decimal? Grosswgt
        {
            get { return _fGrosswgt; }
            set
            {
                if (_fGrosswgt != value)
                {
                    Modify();
                    _fGrosswgt = value;
                }
            }
        }

        private decimal? _fHandrate;
        public decimal? Handrate
        {
            get { return _fHandrate; }
            set
            {
                if (_fHandrate != value)
                {
                    Modify();
                    _fHandrate = value;
                }
            }
        }

        private int? _fInvprtrecno;
        public int? Invprtrecno
        {
            get { return _fInvprtrecno; }
            set
            {
                if (_fInvprtrecno != value)
                {
                    Modify();
                    _fInvprtrecno = value;
                }
            }
        }

        private decimal? _fNettwgt;
        public decimal? Nettwgt
        {
            get { return _fNettwgt; }
            set
            {
                if (_fNettwgt != value)
                {
                    Modify();
                    _fNettwgt = value;
                }
            }
        }

        private decimal? _fOffinvonpay;
        public decimal? Offinvonpay
        {
            get { return _fOffinvonpay; }
            set
            {
                if (_fOffinvonpay != value)
                {
                    Modify();
                    _fOffinvonpay = value;
                }
            }
        }

        private decimal? _fOffinvrbt;
        public decimal? Offinvrbt
        {
            get { return _fOffinvrbt; }
            set
            {
                if (_fOffinvrbt != value)
                {
                    Modify();
                    _fOffinvrbt = value;
                }
            }
        }

        private decimal? _fOninvdispcnt;
        public decimal? Oninvdispcnt
        {
            get { return _fOninvdispcnt; }
            set
            {
                if (_fOninvdispcnt != value)
                {
                    Modify();
                    _fOninvdispcnt = value;
                }
            }
        }

        private decimal? _fOninvdscnt;
        public decimal? Oninvdscnt
        {
            get { return _fOninvdscnt; }
            set
            {
                if (_fOninvdscnt != value)
                {
                    Modify();
                    _fOninvdscnt = value;
                }
            }
        }

        private int? _fPpcno;
        public int? Ppcno
        {
            get { return _fPpcno; }
            set
            {
                if (_fPpcno != value)
                {
                    Modify();
                    _fPpcno = value;
                }
            }
        }

        private string _fPrcprdref;
        public string Prcprdref
        {
            get { return _fPrcprdref; }
            set
            {
                if (_fPrcprdref != value)
                {
                    Modify();
                    _fPrcprdref = value;
                }
            }
        }

        private string _fPrddesc;
        public string Prddesc
        {
            get { return _fPrddesc; }
            set
            {
                if (_fPrddesc != value)
                {
                    Modify();
                    _fPrddesc = value;
                }
            }
        }

        private int? _fPrdglanl;
        public int? Prdglanl
        {
            get { return _fPrdglanl; }
            set
            {
                if (_fPrdglanl != value)
                {
                    Modify();
                    _fPrdglanl = value;
                }
            }
        }

        private string _fPrdrecdesc;
        public string Prdrecdesc
        {
            get { return _fPrdrecdesc; }
            set
            {
                if (_fPrdrecdesc != value)
                {
                    Modify();
                    _fPrdrecdesc = value;
                }
            }
        }

        private int? _fPrgrefno;
        public int? Prgrefno
        {
            get { return _fPrgrefno; }
            set
            {
                if (_fPrgrefno != value)
                {
                    Modify();
                    _fPrgrefno = value;
                }
            }
        }

        private decimal? _fPrtqty;
        public decimal? Prtqty
        {
            get { return _fPrtqty; }
            set
            {
                if (_fPrtqty != value)
                {
                    Modify();
                    _fPrtqty = value;
                }
            }
        }

        private decimal? _fRawcommamt;
        public decimal? Rawcommamt
        {
            get { return _fRawcommamt; }
            set
            {
                if (_fRawcommamt != value)
                {
                    Modify();
                    _fRawcommamt = value;
                }
            }
        }

        private decimal? _fRawhandamt;
        public decimal? Rawhandamt
        {
            get { return _fRawhandamt; }
            set
            {
                if (_fRawhandamt != value)
                {
                    Modify();
                    _fRawhandamt = value;
                }
            }
        }

        private decimal? _fRawvatonchgs;
        public decimal? Rawvatonchgs
        {
            get { return _fRawvatonchgs; }
            set
            {
                if (_fRawvatonchgs != value)
                {
                    Modify();
                    _fRawvatonchgs = value;
                }
            }
        }

        private int? _fRecno;
        public int? Recno
        {
            get { return _fRecno; }
            set
            {
                if (_fRecno != value)
                {
                    Modify();
                    _fRecno = value;
                }
            }
        }

        private decimal? _fTarewgt;
        public decimal? Tarewgt
        {
            get { return _fTarewgt; }
            set
            {
                if (_fTarewgt != value)
                {
                    Modify();
                    _fTarewgt = value;
                }
            }
        }

        private string _fTradedunit;
        public string Tradedunit
        {
            get { return _fTradedunit; }
            set
            {
                if (_fTradedunit != value)
                {
                    Modify();
                    _fTradedunit = value;
                }
            }
        }

        private int? _fUnitcount;
        public int? Unitcount
        {
            get { return _fUnitcount; }
            set
            {
                if (_fUnitcount != value)
                {
                    Modify();
                    _fUnitcount = value;
                }
            }
        }

        private string _fUnitmeasure;
        public string Unitmeasure
        {
            get { return _fUnitmeasure; }
            set
            {
                if (_fUnitmeasure != value)
                {
                    Modify();
                    _fUnitmeasure = value;
                }
            }
        }

        private decimal? _fVat;
        public decimal? Vat
        {
            get { return _fVat; }
            set
            {
                if (_fVat != value)
                {
                    Modify();
                    _fVat = value;
                }
            }
        }

        private decimal? _fVat1total;
        public decimal? Vat1total
        {
            get { return _fVat1total; }
            set
            {
                if (_fVat1total != value)
                {
                    Modify();
                    _fVat1total = value;
                }
            }
        }

        private decimal? _fVat2total;
        public decimal? Vat2total
        {
            get { return _fVat2total; }
            set
            {
                if (_fVat2total != value)
                {
                    Modify();
                    _fVat2total = value;
                }
            }
        }

        private decimal? _fVatcodechgs;
        public decimal? Vatcodechgs
        {
            get { return _fVatcodechgs; }
            set
            {
                if (_fVatcodechgs != value)
                {
                    Modify();
                    _fVatcodechgs = value;
                }
            }
        }

        private int? _fVatlnkrecno;
        public int? Vatlnkrecno
        {
            get { return _fVatlnkrecno; }
            set
            {
                if (_fVatlnkrecno != value)
                {
                    Modify();
                    _fVatlnkrecno = value;
                }
            }
        }

        private decimal? _fVatratechgs;
        public decimal? Vatratechgs
        {
            get { return _fVatratechgs; }
            set
            {
                if (_fVatratechgs != value)
                {
                    Modify();
                    _fVatratechgs = value;
                }
            }
        }

        private int? _fVatrecno;
        public int? Vatrecno
        {
            get { return _fVatrecno; }
            set
            {
                if (_fVatrecno != value)
                {
                    Modify();
                    _fVatrecno = value;
                }
            }
        }

        private decimal? _fVatvatrate;
        public decimal? Vatvatrate
        {
            get { return _fVatvatrate; }
            set
            {
                if (_fVatvatrate != value)
                {
                    Modify();
                    _fVatvatrate = value;
                }
            }
        }

        private decimal? _fVatvatrate2;
        public decimal? Vatvatrate2
        {
            get { return _fVatvatrate2; }
            set
            {
                if (_fVatvatrate2 != value)
                {
                    Modify();
                    _fVatvatrate2 = value;
                }
            }
        }

        private int? _fVatvearecno;
        public int? Vatvearecno
        {
            get { return _fVatvearecno; }
            set
            {
                if (_fVatvearecno != value)
                {
                    Modify();
                    _fVatvearecno = value;
                }
            }
        }


        public override INVPRT2 Clone()
        {
            var obj = new INVPRT2
                {
                    Alloctoinvrecno = Alloctoinvrecno,
                    Allowonelinecancel = Allowonelinecancel,
                    Basecommamt = Basecommamt,
                    Basegds = Basegds,
                    Basehandamt = Basehandamt,
                    Baseoffinvrbt = Baseoffinvrbt,
                    Baseoffonpay = Baseoffonpay,
                    Baseoninvdscnt = Baseoninvdscnt,
                    Basevat = Basevat,
                    Basevat1total = Basevat1total,
                    Basevat2total = Basevat2total,
                    Basevatonchgs = Basevatonchgs,
                    Cancelledline = Cancelledline,
                    Commperc = Commperc,
                    Delcdsrefno = Delcdsrefno,
                    Delcltprdno = Delcltprdno,
                    Delinvstatus = Delinvstatus,
                    Delprcbywgt = Delprcbywgt,
                    Delprcprdno = Delprcprdno,
                    Delprice = Delprice,
                    Delqty = Delqty,
                    Delrecno = Delrecno,
                    Delweight = Delweight,
                    Detallocno = Detallocno,
                    Disctoqty = Disctoqty,
                    Dispcnt = Dispcnt,
                    Dlvinvoiceno = Dlvinvoiceno,
                    Dlvordno = Dlvordno,
                    Dprrecno = Dprrecno,
                    Eurocommamt = Eurocommamt,
                    Eurogds = Eurogds,
                    Eurohandamt = Eurohandamt,
                    Eurooffinvrbt = Eurooffinvrbt,
                    Eurooffonpay = Eurooffonpay,
                    Eurooninvdscnt = Eurooninvdscnt,
                    Eurovat = Eurovat,
                    Eurovat1total = Eurovat1total,
                    Eurovat2total = Eurovat2total,
                    Eurovatonchgs = Eurovatonchgs,
                    Ext = Ext,
                    Extractsessionid = Extractsessionid,
                    Goods = Goods,
                    Grosswgt = Grosswgt,
                    Handrate = Handrate,
                    Invprtrecno = Invprtrecno,
                    Nettwgt = Nettwgt,
                    Offinvonpay = Offinvonpay,
                    Offinvrbt = Offinvrbt,
                    Oninvdispcnt = Oninvdispcnt,
                    Oninvdscnt = Oninvdscnt,
                    Ppcno = Ppcno,
                    Prcprdref = Prcprdref,
                    Prddesc = Prddesc,
                    Prdglanl = Prdglanl,
                    Prdrecdesc = Prdrecdesc,
                    Prgrefno = Prgrefno,
                    Prtqty = Prtqty,
                    Rawcommamt = Rawcommamt,
                    Rawhandamt = Rawhandamt,
                    Rawvatonchgs = Rawvatonchgs,
                    Recno = Recno,
                    Tarewgt = Tarewgt,
                    Tradedunit = Tradedunit,
                    Unitcount = Unitcount,
                    Unitmeasure = Unitmeasure,
                    Vat = Vat,
                    Vat1total = Vat1total,
                    Vat2total = Vat2total,
                    Vatcodechgs = Vatcodechgs,
                    Vatlnkrecno = Vatlnkrecno,
                    Vatratechgs = Vatratechgs,
                    Vatrecno = Vatrecno,
                    Vatvatrate = Vatvatrate,
                    Vatvatrate2 = Vatvatrate2,
                    Vatvearecno = Vatvearecno,
                };

            return obj;
        }

        public static class FieldNames
        {
// ReSharper disable InconsistentNaming
            public const string  ALLOCTOINVRECNO = "ALLOCTOINVRECNO";
            public const string  ALLOWONELINECANCEL = "ALLOWONELINECANCEL";
            public const string  BASECOMMAMT = "BASECOMMAMT";
            public const string  BASEGDS = "BASEGDS";
            public const string  BASEHANDAMT = "BASEHANDAMT";
            public const string  BASEOFFINVRBT = "BASEOFFINVRBT";
            public const string  BASEOFFONPAY = "BASEOFFONPAY";
            public const string  BASEONINVDSCNT = "BASEONINVDSCNT";
            public const string  BASEVAT = "BASEVAT";
            public const string  BASEVAT1TOTAL = "BASEVAT1TOTAL";
            public const string  BASEVAT2TOTAL = "BASEVAT2TOTAL";
            public const string  BASEVATONCHGS = "BASEVATONCHGS";
            public const string  CANCELLEDLINE = "CANCELLEDLINE";
            public const string  COMMPERC = "COMMPERC";
            public const string  DELCDSREFNO = "DELCDSREFNO";
            public const string  DELCLTPRDNO = "DELCLTPRDNO";
            public const string  DELINVSTATUS = "DELINVSTATUS";
            public const string  DELPRCBYWGT = "DELPRCBYWGT";
            public const string  DELPRCPRDNO = "DELPRCPRDNO";
            public const string  DELPRICE = "DELPRICE";
            public const string  DELQTY = "DELQTY";
            public const string  DELRECNO = "DELRECNO";
            public const string  DELWEIGHT = "DELWEIGHT";
            public const string  DETALLOCNO = "DETALLOCNO";
            public const string  DISCTOQTY = "DISCTOQTY";
            public const string  DISPCNT = "DISPCNT";
            public const string  DLVINVOICENO = "DLVINVOICENO";
            public const string  DLVORDNO = "DLVORDNO";
            public const string  DPRRECNO = "DPRRECNO";
            public const string  EUROCOMMAMT = "EUROCOMMAMT";
            public const string  EUROGDS = "EUROGDS";
            public const string  EUROHANDAMT = "EUROHANDAMT";
            public const string  EUROOFFINVRBT = "EUROOFFINVRBT";
            public const string  EUROOFFONPAY = "EUROOFFONPAY";
            public const string  EUROONINVDSCNT = "EUROONINVDSCNT";
            public const string  EUROVAT = "EUROVAT";
            public const string  EUROVAT1TOTAL = "EUROVAT1TOTAL";
            public const string  EUROVAT2TOTAL = "EUROVAT2TOTAL";
            public const string  EUROVATONCHGS = "EUROVATONCHGS";
            public const string  EXT = "EXT";
            public const string  EXTRACTSESSIONID = "EXTRACTSESSIONID";
            public const string  GOODS = "GOODS";
            public const string  GROSSWGT = "GROSSWGT";
            public const string  HANDRATE = "HANDRATE";
            public const string  INVPRTRECNO = "INVPRTRECNO";
            public const string  NETTWGT = "NETTWGT";
            public const string  OFFINVONPAY = "OFFINVONPAY";
            public const string  OFFINVRBT = "OFFINVRBT";
            public const string  ONINVDISPCNT = "ONINVDISPCNT";
            public const string  ONINVDSCNT = "ONINVDSCNT";
            public const string  PPCNO = "PPCNO";
            public const string  PRCPRDREF = "PRCPRDREF";
            public const string  PRDDESC = "PRDDESC";
            public const string  PRDGLANL = "PRDGLANL";
            public const string  PRDRECDESC = "PRDRECDESC";
            public const string  PRGREFNO = "PRGREFNO";
            public const string  PRTQTY = "PRTQTY";
            public const string  RAWCOMMAMT = "RAWCOMMAMT";
            public const string  RAWHANDAMT = "RAWHANDAMT";
            public const string  RAWVATONCHGS = "RAWVATONCHGS";
            public const string  RECNO = "RECNO";
            public const string  TAREWGT = "TAREWGT";
            public const string  TRADEDUNIT = "TRADEDUNIT";
            public const string  UNITCOUNT = "UNITCOUNT";
            public const string  UNITMEASURE = "UNITMEASURE";
            public const string  VAT = "VAT";
            public const string  VAT1TOTAL = "VAT1TOTAL";
            public const string  VAT2TOTAL = "VAT2TOTAL";
            public const string  VATCODECHGS = "VATCODECHGS";
            public const string  VATLNKRECNO = "VATLNKRECNO";
            public const string  VATRATECHGS = "VATRATECHGS";
            public const string  VATRECNO = "VATRECNO";
            public const string  VATVATRATE = "VATVATRATE";
            public const string  VATVATRATE2 = "VATVATRATE2";
            public const string  VATVEARECNO = "VATVEARECNO";
 // ReSharper restore InconsistentNaming
        }


    }

}
