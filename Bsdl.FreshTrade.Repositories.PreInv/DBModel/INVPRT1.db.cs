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
    /// Entity for the PREINVTEMP_INVPRT1 table
    /// </summary>
    public partial class INVPRT1 : BaseDbModel<INVPRT1, string>
    {
#region tableDefs

       public static List<EntityPropDef> GetPropDefs() {
         var result = new List<EntityPropDef>();

//EntityPropDef(string propName, string columnName, bool isKey, bool isNullable, string refEntityName, PropertyInfo keyPropInfo,
//            int size, int? prec, int? scale)




         result.Add(new EntityPropDef(
         PropertyHelper <INVPRT1>.GetProperty(x => x.Alloctoinvrecno),
         "ALLOCTOINVRECNO", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  126, // int? prec
                   
         null // int? Scale
         ,
         typeof(INVPRT1)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <INVPRT1>.GetProperty(x => x.Allowonelinecancel),
         "ALLOWONELINECANCEL", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  1, // int? prec
                           0  // int? Scale
         ,
         typeof(INVPRT1)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <INVPRT1>.GetProperty(x => x.Allpcode1),
         "ALLPCODE1", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  10, // int? prec
                           0  // int? Scale
         ,
         typeof(INVPRT1)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <INVPRT1>.GetProperty(x => x.Allpcode2),
         "ALLPCODE2", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         12,       // int size   
                  null, // int? prec
                   
         null // int? Scale
         ,
         typeof(INVPRT1)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <INVPRT1>.GetProperty(x => x.Allpcode3),
         "ALLPCODE3", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  1, // int? prec
                           0  // int? Scale
         ,
         typeof(INVPRT1)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <INVPRT1>.GetProperty(x => x.Allpcode4),
         "ALLPCODE4", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  10, // int? prec
                           0  // int? Scale
         ,
         typeof(INVPRT1)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <INVPRT1>.GetProperty(x => x.Allpcode5),
         "ALLPCODE5", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  1, // int? prec
                           0  // int? Scale
         ,
         typeof(INVPRT1)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <INVPRT1>.GetProperty(x => x.Allpcode6),
         "ALLPCODE6", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  10, // int? prec
                           0  // int? Scale
         ,
         typeof(INVPRT1)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <INVPRT1>.GetProperty(x => x.Allpdesc1),
         "ALLPDESC1", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  10, // int? prec
                           0  // int? Scale
         ,
         typeof(INVPRT1)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <INVPRT1>.GetProperty(x => x.Allpdesc2),
         "ALLPDESC2", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         16,       // int size   
                  null, // int? prec
                   
         null // int? Scale
         ,
         typeof(INVPRT1)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <INVPRT1>.GetProperty(x => x.Allpdesc3),
         "ALLPDESC3", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  10, // int? prec
                           0  // int? Scale
         ,
         typeof(INVPRT1)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <INVPRT1>.GetProperty(x => x.Allpdesc4),
         "ALLPDESC4", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         1,       // int size   
                  null, // int? prec
                   
         null // int? Scale
         ,
         typeof(INVPRT1)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <INVPRT1>.GetProperty(x => x.Allpdesc5),
         "ALLPDESC5", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  10, // int? prec
                           0  // int? Scale
         ,
         typeof(INVPRT1)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <INVPRT1>.GetProperty(x => x.Allpdesc6),
         "ALLPDESC6", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  126, // int? prec
                   
         null // int? Scale
         ,
         typeof(INVPRT1)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <INVPRT1>.GetProperty(x => x.Alternateproddesc),
         "ALTERNATEPRODDESC", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         50,       // int size   
                  null, // int? prec
                   
         null // int? Scale
         ,
         typeof(INVPRT1)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <INVPRT1>.GetProperty(x => x.Altproddescreason),
         "ALTPRODDESCREASON", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         14,       // int size   
                  null, // int? prec
                   
         null // int? Scale
         ,
         typeof(INVPRT1)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <INVPRT1>.GetProperty(x => x.Basecommamt),
         "BASECOMMAMT", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  126, // int? prec
                   
         null // int? Scale
         ,
         typeof(INVPRT1)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <INVPRT1>.GetProperty(x => x.Basegds),
         "BASEGDS", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  126, // int? prec
                   
         null // int? Scale
         ,
         typeof(INVPRT1)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <INVPRT1>.GetProperty(x => x.Basehandamt),
         "BASEHANDAMT", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  126, // int? prec
                   
         null // int? Scale
         ,
         typeof(INVPRT1)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <INVPRT1>.GetProperty(x => x.Baseoffinvrbt),
         "BASEOFFINVRBT", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  126, // int? prec
                   
         null // int? Scale
         ,
         typeof(INVPRT1)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <INVPRT1>.GetProperty(x => x.Baseoffonpay),
         "BASEOFFONPAY", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  126, // int? prec
                   
         null // int? Scale
         ,
         typeof(INVPRT1)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <INVPRT1>.GetProperty(x => x.Baseoninvdscnt),
         "BASEONINVDSCNT", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  126, // int? prec
                   
         null // int? Scale
         ,
         typeof(INVPRT1)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <INVPRT1>.GetProperty(x => x.Basevat),
         "BASEVAT", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  126, // int? prec
                   
         null // int? Scale
         ,
         typeof(INVPRT1)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <INVPRT1>.GetProperty(x => x.Basevatonchgs),
         "BASEVATONCHGS", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  126, // int? prec
                   
         null // int? Scale
         ,
         typeof(INVPRT1)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <INVPRT1>.GetProperty(x => x.Bio),
         "BIO", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  126, // int? prec
                   
         null // int? Scale
         ,
         typeof(INVPRT1)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <INVPRT1>.GetProperty(x => x.Cancelledline),
         "CANCELLEDLINE", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  1, // int? prec
                           0  // int? Scale
         ,
         typeof(INVPRT1)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <INVPRT1>.GetProperty(x => x.Commperc),
         "COMMPERC", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  10, // int? prec
                           0  // int? Scale
         ,
         typeof(INVPRT1)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <INVPRT1>.GetProperty(x => x.Delcdsrefno),
         "DELCDSREFNO", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  10, // int? prec
                           0  // int? Scale
         ,
         typeof(INVPRT1)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <INVPRT1>.GetProperty(x => x.Delcltprdno),
         "DELCLTPRDNO", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         255,       // int size   
                  null, // int? prec
                   
         null // int? Scale
         ,
         typeof(INVPRT1)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <INVPRT1>.GetProperty(x => x.Delinvstatus),
         "DELINVSTATUS", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  10, // int? prec
                           0  // int? Scale
         ,
         typeof(INVPRT1)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <INVPRT1>.GetProperty(x => x.Delprcbywgt),
         "DELPRCBYWGT", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  1, // int? prec
                           0  // int? Scale
         ,
         typeof(INVPRT1)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <INVPRT1>.GetProperty(x => x.Delprcprdno),
         "DELPRCPRDNO", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  10, // int? prec
                           0  // int? Scale
         ,
         typeof(INVPRT1)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <INVPRT1>.GetProperty(x => x.Delprcqty),
         "DELPRCQTY", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  10, // int? prec
                           0  // int? Scale
         ,
         typeof(INVPRT1)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <INVPRT1>.GetProperty(x => x.Delprice),
         "DELPRICE", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  126, // int? prec
                   
         null // int? Scale
         ,
         typeof(INVPRT1)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <INVPRT1>.GetProperty(x => x.Delqty),
         "DELQTY", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  10, // int? prec
                           0  // int? Scale
         ,
         typeof(INVPRT1)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <INVPRT1>.GetProperty(x => x.Delrecno),
         "DELRECNO", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  10, // int? prec
                           0  // int? Scale
         ,
         typeof(INVPRT1)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <INVPRT1>.GetProperty(x => x.Delweight),
         "DELWEIGHT", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  126, // int? prec
                   
         null // int? Scale
         ,
         typeof(INVPRT1)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <INVPRT1>.GetProperty(x => x.Detallocno),
         "DETALLOCNO", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         15,       // int size   
                  null, // int? prec
                   
         null // int? Scale
         ,
         typeof(INVPRT1)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <INVPRT1>.GetProperty(x => x.Dlvinvoiceno),
         "DLVINVOICENO", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         40,       // int size   
                  null, // int? prec
                   
         null // int? Scale
         ,
         typeof(INVPRT1)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <INVPRT1>.GetProperty(x => x.Dlvordno),
         "DLVORDNO", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  10, // int? prec
                           0  // int? Scale
         ,
         typeof(INVPRT1)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <INVPRT1>.GetProperty(x => x.Dlvqtynum),
         "DLVQTYNUM", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  126, // int? prec
                   
         null // int? Scale
         ,
         typeof(INVPRT1)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <INVPRT1>.GetProperty(x => x.Dprrecno),
         "DPRRECNO", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  10, // int? prec
                           0  // int? Scale
         ,
         typeof(INVPRT1)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <INVPRT1>.GetProperty(x => x.Eurocommamt),
         "EUROCOMMAMT", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  126, // int? prec
                   
         null // int? Scale
         ,
         typeof(INVPRT1)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <INVPRT1>.GetProperty(x => x.Eurogds),
         "EUROGDS", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  10, // int? prec
                           0  // int? Scale
         ,
         typeof(INVPRT1)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <INVPRT1>.GetProperty(x => x.Eurohandamt),
         "EUROHANDAMT", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  126, // int? prec
                   
         null // int? Scale
         ,
         typeof(INVPRT1)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <INVPRT1>.GetProperty(x => x.Eurooffinvrbt),
         "EUROOFFINVRBT", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  10, // int? prec
                           0  // int? Scale
         ,
         typeof(INVPRT1)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <INVPRT1>.GetProperty(x => x.Eurooffonpay),
         "EUROOFFONPAY", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  126, // int? prec
                   
         null // int? Scale
         ,
         typeof(INVPRT1)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <INVPRT1>.GetProperty(x => x.Eurooninvdscnt),
         "EUROONINVDSCNT", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  10, // int? prec
                           0  // int? Scale
         ,
         typeof(INVPRT1)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <INVPRT1>.GetProperty(x => x.Eurovat),
         "EUROVAT", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  10, // int? prec
                           0  // int? Scale
         ,
         typeof(INVPRT1)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <INVPRT1>.GetProperty(x => x.Eurovatonchgs),
         "EUROVATONCHGS", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  126, // int? prec
                   
         null // int? Scale
         ,
         typeof(INVPRT1)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <INVPRT1>.GetProperty(x => x.Ext),
         "EXT", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  126, // int? prec
                   
         null // int? Scale
         ,
         typeof(INVPRT1)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <INVPRT1>.GetProperty(x => x.Goods),
         "GOODS", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         40,       // int size   
                  null, // int? prec
                   
         null // int? Scale
         ,
         typeof(INVPRT1)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <INVPRT1>.GetProperty(x => x.Grosswgt),
         "GROSSWGT", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  126, // int? prec
                   
         null // int? Scale
         ,
         typeof(INVPRT1)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <INVPRT1>.GetProperty(x => x.Handrate),
         "HANDRATE", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  10, // int? prec
                           0  // int? Scale
         ,
         typeof(INVPRT1)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <INVPRT1>.GetProperty(x => x.Intrastatcode),
         "INTRASTATCODE", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  126, // int? prec
                   
         null // int? Scale
         ,
         typeof(INVPRT1)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <INVPRT1>.GetProperty(x => x.Mergeprdno),
         "MERGEPRDNO", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  126, // int? prec
                   
         null // int? Scale
         ,
         typeof(INVPRT1)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <INVPRT1>.GetProperty(x => x.Nettwgt),
         "NETTWGT", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  126, // int? prec
                   
         null // int? Scale
         ,
         typeof(INVPRT1)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <INVPRT1>.GetProperty(x => x.Offinvonpay),
         "OFFINVONPAY", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  126, // int? prec
                   
         null // int? Scale
         ,
         typeof(INVPRT1)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <INVPRT1>.GetProperty(x => x.Offinvrbt),
         "OFFINVRBT", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  126, // int? prec
                   
         null // int? Scale
         ,
         typeof(INVPRT1)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <INVPRT1>.GetProperty(x => x.Oninvdispcnt),
         "ONINVDISPCNT", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  126, // int? prec
                   
         null // int? Scale
         ,
         typeof(INVPRT1)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <INVPRT1>.GetProperty(x => x.Oninvdscnt),
         "ONINVDSCNT", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  126, // int? prec
                   
         null // int? Scale
         ,
         typeof(INVPRT1)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <INVPRT1>.GetProperty(x => x.Ppcno),
         "PPCNO", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  10, // int? prec
                           0  // int? Scale
         ,
         typeof(INVPRT1)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <INVPRT1>.GetProperty(x => x.Prcprdref),
         "PRCPRDREF", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         255,       // int size   
                  null, // int? prec
                   
         null // int? Scale
         ,
         typeof(INVPRT1)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <INVPRT1>.GetProperty(x => x.Prddesc),
         "PRDDESC", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         255,       // int size   
                  null, // int? prec
                   
         null // int? Scale
         ,
         typeof(INVPRT1)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <INVPRT1>.GetProperty(x => x.Prdglanl),
         "PRDGLANL", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  10, // int? prec
                           0  // int? Scale
         ,
         typeof(INVPRT1)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <INVPRT1>.GetProperty(x => x.Prdrecdesc),
         "PRDRECDESC", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         255,       // int size   
                  null, // int? prec
                   
         null // int? Scale
         ,
         typeof(INVPRT1)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <INVPRT1>.GetProperty(x => x.Prgrefno),
         "PRGREFNO", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  10, // int? prec
                           0  // int? Scale
         ,
         typeof(INVPRT1)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <INVPRT1>.GetProperty(x => x.Prtqty),
         "PRTQTY", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  126, // int? prec
                   
         null // int? Scale
         ,
         typeof(INVPRT1)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <INVPRT1>.GetProperty(x => x.Rawcommamt),
         "RAWCOMMAMT", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  126, // int? prec
                   
         null // int? Scale
         ,
         typeof(INVPRT1)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <INVPRT1>.GetProperty(x => x.Rawhandamt),
         "RAWHANDAMT", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  10, // int? prec
                           0  // int? Scale
         ,
         typeof(INVPRT1)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <INVPRT1>.GetProperty(x => x.Rawvatonchgs),
         "RAWVATONCHGS", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  126, // int? prec
                   
         null // int? Scale
         ,
         typeof(INVPRT1)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <INVPRT1>.GetProperty(x => x.Recno),
         "RECNO", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  10, // int? prec
                           0  // int? Scale
         ,
         typeof(INVPRT1)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <INVPRT1>.GetProperty(x => x.Stcrecno),
         "STCRECNO", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  10, // int? prec
                           0  // int? Scale
         ,
         typeof(INVPRT1)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <INVPRT1>.GetProperty(x => x.Tarewgt),
         "TAREWGT", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  126, // int? prec
                   
         null // int? Scale
         ,
         typeof(INVPRT1)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <INVPRT1>.GetProperty(x => x.Tradedunit),
         "TRADEDUNIT", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         255,       // int size   
                  null, // int? prec
                   
         null // int? Scale
         ,
         typeof(INVPRT1)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <INVPRT1>.GetProperty(x => x.Unitcount),
         "UNITCOUNT", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  10, // int? prec
                           0  // int? Scale
         ,
         typeof(INVPRT1)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <INVPRT1>.GetProperty(x => x.Unitmeasure),
         "UNITMEASURE", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  126, // int? prec
                   
         null // int? Scale
         ,
         typeof(INVPRT1)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <INVPRT1>.GetProperty(x => x.Vat),
         "VAT", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  126, // int? prec
                   
         null // int? Scale
         ,
         typeof(INVPRT1)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <INVPRT1>.GetProperty(x => x.Vatcodechgs),
         "VATCODECHGS", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  126, // int? prec
                   
         null // int? Scale
         ,
         typeof(INVPRT1)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <INVPRT1>.GetProperty(x => x.Vatlnkrecno),
         "VATLNKRECNO", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  126, // int? prec
                   
         null // int? Scale
         ,
         typeof(INVPRT1)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <INVPRT1>.GetProperty(x => x.Vatratechgs),
         "VATRATECHGS", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  126, // int? prec
                   
         null // int? Scale
         ,
         typeof(INVPRT1)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <INVPRT1>.GetProperty(x => x.Vatrecno),
         "VATRECNO", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  10, // int? prec
                           0  // int? Scale
         ,
         typeof(INVPRT1)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <INVPRT1>.GetProperty(x => x.Vatvatrate),
         "VATVATRATE", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  126, // int? prec
                   
         null // int? Scale
         ,
         typeof(INVPRT1)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <INVPRT1>.GetProperty(x => x.Vatvearecno),
         "VATVEARECNO", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  10, // int? prec
                           0  // int? Scale
         ,
         typeof(INVPRT1)
         ));
         return result; 
       }

#endregion     
        private decimal? _fAlloctoinvrecno;
        public decimal? Alloctoinvrecno
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

        private int? _fAllpcode1;
        public int? Allpcode1
        {
            get { return _fAllpcode1; }
            set
            {
                if (_fAllpcode1 != value)
                {
                    Modify();
                    _fAllpcode1 = value;
                }
            }
        }

        private string _fAllpcode2;
        public string Allpcode2
        {
            get { return _fAllpcode2; }
            set
            {
                if (_fAllpcode2 != value)
                {
                    Modify();
                    _fAllpcode2 = value;
                }
            }
        }

        private short? _fAllpcode3;
        public short? Allpcode3
        {
            get { return _fAllpcode3; }
            set
            {
                if (_fAllpcode3 != value)
                {
                    Modify();
                    _fAllpcode3 = value;
                }
            }
        }

        private int? _fAllpcode4;
        public int? Allpcode4
        {
            get { return _fAllpcode4; }
            set
            {
                if (_fAllpcode4 != value)
                {
                    Modify();
                    _fAllpcode4 = value;
                }
            }
        }

        private short? _fAllpcode5;
        public short? Allpcode5
        {
            get { return _fAllpcode5; }
            set
            {
                if (_fAllpcode5 != value)
                {
                    Modify();
                    _fAllpcode5 = value;
                }
            }
        }

        private int? _fAllpcode6;
        public int? Allpcode6
        {
            get { return _fAllpcode6; }
            set
            {
                if (_fAllpcode6 != value)
                {
                    Modify();
                    _fAllpcode6 = value;
                }
            }
        }

        private int? _fAllpdesc1;
        public int? Allpdesc1
        {
            get { return _fAllpdesc1; }
            set
            {
                if (_fAllpdesc1 != value)
                {
                    Modify();
                    _fAllpdesc1 = value;
                }
            }
        }

        private string _fAllpdesc2;
        public string Allpdesc2
        {
            get { return _fAllpdesc2; }
            set
            {
                if (_fAllpdesc2 != value)
                {
                    Modify();
                    _fAllpdesc2 = value;
                }
            }
        }

        private int? _fAllpdesc3;
        public int? Allpdesc3
        {
            get { return _fAllpdesc3; }
            set
            {
                if (_fAllpdesc3 != value)
                {
                    Modify();
                    _fAllpdesc3 = value;
                }
            }
        }

        private string _fAllpdesc4;
        public string Allpdesc4
        {
            get { return _fAllpdesc4; }
            set
            {
                if (_fAllpdesc4 != value)
                {
                    Modify();
                    _fAllpdesc4 = value;
                }
            }
        }

        private int? _fAllpdesc5;
        public int? Allpdesc5
        {
            get { return _fAllpdesc5; }
            set
            {
                if (_fAllpdesc5 != value)
                {
                    Modify();
                    _fAllpdesc5 = value;
                }
            }
        }

        private decimal? _fAllpdesc6;
        public decimal? Allpdesc6
        {
            get { return _fAllpdesc6; }
            set
            {
                if (_fAllpdesc6 != value)
                {
                    Modify();
                    _fAllpdesc6 = value;
                }
            }
        }

        private string _fAlternateproddesc;
        public string Alternateproddesc
        {
            get { return _fAlternateproddesc; }
            set
            {
                if (_fAlternateproddesc != value)
                {
                    Modify();
                    _fAlternateproddesc = value;
                }
            }
        }

        private string _fAltproddescreason;
        public string Altproddescreason
        {
            get { return _fAltproddescreason; }
            set
            {
                if (_fAltproddescreason != value)
                {
                    Modify();
                    _fAltproddescreason = value;
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

        private decimal? _fBasevatonchgs;
        public decimal? Basevatonchgs
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

        private decimal? _fBio;
        public decimal? Bio
        {
            get { return _fBio; }
            set
            {
                if (_fBio != value)
                {
                    Modify();
                    _fBio = value;
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

        private int? _fCommperc;
        public int? Commperc
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

        private int? _fDelprcqty;
        public int? Delprcqty
        {
            get { return _fDelprcqty; }
            set
            {
                if (_fDelprcqty != value)
                {
                    Modify();
                    _fDelprcqty = value;
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

        private decimal? _fDlvqtynum;
        public decimal? Dlvqtynum
        {
            get { return _fDlvqtynum; }
            set
            {
                if (_fDlvqtynum != value)
                {
                    Modify();
                    _fDlvqtynum = value;
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

        private int? _fEurogds;
        public int? Eurogds
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

        private int? _fEurooffinvrbt;
        public int? Eurooffinvrbt
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

        private int? _fEurooninvdscnt;
        public int? Eurooninvdscnt
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

        private int? _fEurovat;
        public int? Eurovat
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

        private string _fGoods;
        public string Goods
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

        private int? _fHandrate;
        public int? Handrate
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

        private decimal? _fIntrastatcode;
        public decimal? Intrastatcode
        {
            get { return _fIntrastatcode; }
            set
            {
                if (_fIntrastatcode != value)
                {
                    Modify();
                    _fIntrastatcode = value;
                }
            }
        }

        private decimal? _fMergeprdno;
        public decimal? Mergeprdno
        {
            get { return _fMergeprdno; }
            set
            {
                if (_fMergeprdno != value)
                {
                    Modify();
                    _fMergeprdno = value;
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

        private int? _fRawhandamt;
        public int? Rawhandamt
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

        private int? _fStcrecno;
        public int? Stcrecno
        {
            get { return _fStcrecno; }
            set
            {
                if (_fStcrecno != value)
                {
                    Modify();
                    _fStcrecno = value;
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

        private decimal? _fUnitmeasure;
        public decimal? Unitmeasure
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

        private decimal? _fVatlnkrecno;
        public decimal? Vatlnkrecno
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


        public override INVPRT1 Clone()
        {
            var obj = new INVPRT1
                {
                    Alloctoinvrecno = Alloctoinvrecno,
                    Allowonelinecancel = Allowonelinecancel,
                    Allpcode1 = Allpcode1,
                    Allpcode2 = Allpcode2,
                    Allpcode3 = Allpcode3,
                    Allpcode4 = Allpcode4,
                    Allpcode5 = Allpcode5,
                    Allpcode6 = Allpcode6,
                    Allpdesc1 = Allpdesc1,
                    Allpdesc2 = Allpdesc2,
                    Allpdesc3 = Allpdesc3,
                    Allpdesc4 = Allpdesc4,
                    Allpdesc5 = Allpdesc5,
                    Allpdesc6 = Allpdesc6,
                    Alternateproddesc = Alternateproddesc,
                    Altproddescreason = Altproddescreason,
                    Basecommamt = Basecommamt,
                    Basegds = Basegds,
                    Basehandamt = Basehandamt,
                    Baseoffinvrbt = Baseoffinvrbt,
                    Baseoffonpay = Baseoffonpay,
                    Baseoninvdscnt = Baseoninvdscnt,
                    Basevat = Basevat,
                    Basevatonchgs = Basevatonchgs,
                    Bio = Bio,
                    Cancelledline = Cancelledline,
                    Commperc = Commperc,
                    Delcdsrefno = Delcdsrefno,
                    Delcltprdno = Delcltprdno,
                    Delinvstatus = Delinvstatus,
                    Delprcbywgt = Delprcbywgt,
                    Delprcprdno = Delprcprdno,
                    Delprcqty = Delprcqty,
                    Delprice = Delprice,
                    Delqty = Delqty,
                    Delrecno = Delrecno,
                    Delweight = Delweight,
                    Detallocno = Detallocno,
                    Dlvinvoiceno = Dlvinvoiceno,
                    Dlvordno = Dlvordno,
                    Dlvqtynum = Dlvqtynum,
                    Dprrecno = Dprrecno,
                    Eurocommamt = Eurocommamt,
                    Eurogds = Eurogds,
                    Eurohandamt = Eurohandamt,
                    Eurooffinvrbt = Eurooffinvrbt,
                    Eurooffonpay = Eurooffonpay,
                    Eurooninvdscnt = Eurooninvdscnt,
                    Eurovat = Eurovat,
                    Eurovatonchgs = Eurovatonchgs,
                    Ext = Ext,
                    Goods = Goods,
                    Grosswgt = Grosswgt,
                    Handrate = Handrate,
                    Intrastatcode = Intrastatcode,
                    Mergeprdno = Mergeprdno,
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
                    Stcrecno = Stcrecno,
                    Tarewgt = Tarewgt,
                    Tradedunit = Tradedunit,
                    Unitcount = Unitcount,
                    Unitmeasure = Unitmeasure,
                    Vat = Vat,
                    Vatcodechgs = Vatcodechgs,
                    Vatlnkrecno = Vatlnkrecno,
                    Vatratechgs = Vatratechgs,
                    Vatrecno = Vatrecno,
                    Vatvatrate = Vatvatrate,
                    Vatvearecno = Vatvearecno,
                };

            return obj;
        }

        public static class FieldNames
        {
// ReSharper disable InconsistentNaming
            public const string  ALLOCTOINVRECNO = "ALLOCTOINVRECNO";
            public const string  ALLOWONELINECANCEL = "ALLOWONELINECANCEL";
            public const string  ALLPCODE1 = "ALLPCODE1";
            public const string  ALLPCODE2 = "ALLPCODE2";
            public const string  ALLPCODE3 = "ALLPCODE3";
            public const string  ALLPCODE4 = "ALLPCODE4";
            public const string  ALLPCODE5 = "ALLPCODE5";
            public const string  ALLPCODE6 = "ALLPCODE6";
            public const string  ALLPDESC1 = "ALLPDESC1";
            public const string  ALLPDESC2 = "ALLPDESC2";
            public const string  ALLPDESC3 = "ALLPDESC3";
            public const string  ALLPDESC4 = "ALLPDESC4";
            public const string  ALLPDESC5 = "ALLPDESC5";
            public const string  ALLPDESC6 = "ALLPDESC6";
            public const string  ALTERNATEPRODDESC = "ALTERNATEPRODDESC";
            public const string  ALTPRODDESCREASON = "ALTPRODDESCREASON";
            public const string  BASECOMMAMT = "BASECOMMAMT";
            public const string  BASEGDS = "BASEGDS";
            public const string  BASEHANDAMT = "BASEHANDAMT";
            public const string  BASEOFFINVRBT = "BASEOFFINVRBT";
            public const string  BASEOFFONPAY = "BASEOFFONPAY";
            public const string  BASEONINVDSCNT = "BASEONINVDSCNT";
            public const string  BASEVAT = "BASEVAT";
            public const string  BASEVATONCHGS = "BASEVATONCHGS";
            public const string  BIO = "BIO";
            public const string  CANCELLEDLINE = "CANCELLEDLINE";
            public const string  COMMPERC = "COMMPERC";
            public const string  DELCDSREFNO = "DELCDSREFNO";
            public const string  DELCLTPRDNO = "DELCLTPRDNO";
            public const string  DELINVSTATUS = "DELINVSTATUS";
            public const string  DELPRCBYWGT = "DELPRCBYWGT";
            public const string  DELPRCPRDNO = "DELPRCPRDNO";
            public const string  DELPRCQTY = "DELPRCQTY";
            public const string  DELPRICE = "DELPRICE";
            public const string  DELQTY = "DELQTY";
            public const string  DELRECNO = "DELRECNO";
            public const string  DELWEIGHT = "DELWEIGHT";
            public const string  DETALLOCNO = "DETALLOCNO";
            public const string  DLVINVOICENO = "DLVINVOICENO";
            public const string  DLVORDNO = "DLVORDNO";
            public const string  DLVQTYNUM = "DLVQTYNUM";
            public const string  DPRRECNO = "DPRRECNO";
            public const string  EUROCOMMAMT = "EUROCOMMAMT";
            public const string  EUROGDS = "EUROGDS";
            public const string  EUROHANDAMT = "EUROHANDAMT";
            public const string  EUROOFFINVRBT = "EUROOFFINVRBT";
            public const string  EUROOFFONPAY = "EUROOFFONPAY";
            public const string  EUROONINVDSCNT = "EUROONINVDSCNT";
            public const string  EUROVAT = "EUROVAT";
            public const string  EUROVATONCHGS = "EUROVATONCHGS";
            public const string  EXT = "EXT";
            public const string  GOODS = "GOODS";
            public const string  GROSSWGT = "GROSSWGT";
            public const string  HANDRATE = "HANDRATE";
            public const string  INTRASTATCODE = "INTRASTATCODE";
            public const string  MERGEPRDNO = "MERGEPRDNO";
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
            public const string  STCRECNO = "STCRECNO";
            public const string  TAREWGT = "TAREWGT";
            public const string  TRADEDUNIT = "TRADEDUNIT";
            public const string  UNITCOUNT = "UNITCOUNT";
            public const string  UNITMEASURE = "UNITMEASURE";
            public const string  VAT = "VAT";
            public const string  VATCODECHGS = "VATCODECHGS";
            public const string  VATLNKRECNO = "VATLNKRECNO";
            public const string  VATRATECHGS = "VATRATECHGS";
            public const string  VATRECNO = "VATRECNO";
            public const string  VATVATRATE = "VATVATRATE";
            public const string  VATVEARECNO = "VATVEARECNO";
 // ReSharper restore InconsistentNaming
        }


    }

}
