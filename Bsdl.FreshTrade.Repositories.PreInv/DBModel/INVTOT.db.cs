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
    /// Entity for the PREINVTEMP_INVTOT table
    /// </summary>
    public partial class INVTOT : BaseDbModel<INVTOT, string>
    {
#region tableDefs

       public static List<EntityPropDef> GetPropDefs() {
         var result = new List<EntityPropDef>();

//EntityPropDef(string propName, string columnName, bool isKey, bool isNullable, string refEntityName, PropertyInfo keyPropInfo,
//            int size, int? prec, int? scale)




         result.Add(new EntityPropDef(
         PropertyHelper <INVTOT>.GetProperty(x => x.Accglanl),
         "ACCGLANL", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  10, // int? prec
                           0  // int? Scale
         ,
         typeof(INVTOT)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <INVTOT>.GetProperty(x => x.Accntsaloffno),
         "ACCNTSALOFFNO", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  10, // int? prec
                           0  // int? Scale
         ,
         typeof(INVTOT)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <INVTOT>.GetProperty(x => x.Avavearec1),
         "AVAVEAREC1", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  10, // int? prec
                           0  // int? Scale
         ,
         typeof(INVTOT)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <INVTOT>.GetProperty(x => x.Avavearec2),
         "AVAVEAREC2", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  10, // int? prec
                           0  // int? Scale
         ,
         typeof(INVTOT)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <INVTOT>.GetProperty(x => x.Avavearec3),
         "AVAVEAREC3", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  10, // int? prec
                           0  // int? Scale
         ,
         typeof(INVTOT)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <INVTOT>.GetProperty(x => x.Basegds1),
         "BASEGDS1", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  126, // int? prec
                   
         null // int? Scale
         ,
         typeof(INVTOT)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <INVTOT>.GetProperty(x => x.Basegds2),
         "BASEGDS2", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  126, // int? prec
                   
         null // int? Scale
         ,
         typeof(INVTOT)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <INVTOT>.GetProperty(x => x.Basegds3),
         "BASEGDS3", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  126, // int? prec
                   
         null // int? Scale
         ,
         typeof(INVTOT)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <INVTOT>.GetProperty(x => x.Basegdstotal),
         "BASEGDSTOTAL", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  126, // int? prec
                   
         null // int? Scale
         ,
         typeof(INVTOT)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <INVTOT>.GetProperty(x => x.Basehandcommamt),
         "BASEHANDCOMMAMT", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  126, // int? prec
                   
         null // int? Scale
         ,
         typeof(INVTOT)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <INVTOT>.GetProperty(x => x.Baseoffinvonpay),
         "BASEOFFINVONPAY", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  126, // int? prec
                   
         null // int? Scale
         ,
         typeof(INVTOT)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <INVTOT>.GetProperty(x => x.Baseoffinvrbt),
         "BASEOFFINVRBT", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  126, // int? prec
                   
         null // int? Scale
         ,
         typeof(INVTOT)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <INVTOT>.GetProperty(x => x.Baseoninvdscnt),
         "BASEONINVDSCNT", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  126, // int? prec
                   
         null // int? Scale
         ,
         typeof(INVTOT)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <INVTOT>.GetProperty(x => x.Baserate),
         "BASERATE", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  126, // int? prec
                   
         null // int? Scale
         ,
         typeof(INVTOT)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <INVTOT>.GetProperty(x => x.Basevat1),
         "BASEVAT1", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  126, // int? prec
                   
         null // int? Scale
         ,
         typeof(INVTOT)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <INVTOT>.GetProperty(x => x.Basevat12),
         "BASEVAT1_2", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  126, // int? prec
                   
         null // int? Scale
         ,
         typeof(INVTOT)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <INVTOT>.GetProperty(x => x.Basevat1total),
         "BASEVAT1TOTAL", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  126, // int? prec
                   
         null // int? Scale
         ,
         typeof(INVTOT)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <INVTOT>.GetProperty(x => x.Basevat2),
         "BASEVAT2", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  126, // int? prec
                   
         null // int? Scale
         ,
         typeof(INVTOT)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <INVTOT>.GetProperty(x => x.Basevat22),
         "BASEVAT2_2", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  126, // int? prec
                   
         null // int? Scale
         ,
         typeof(INVTOT)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <INVTOT>.GetProperty(x => x.Basevat2total),
         "BASEVAT2TOTAL", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  126, // int? prec
                   
         null // int? Scale
         ,
         typeof(INVTOT)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <INVTOT>.GetProperty(x => x.Basevat3),
         "BASEVAT3", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  126, // int? prec
                   
         null // int? Scale
         ,
         typeof(INVTOT)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <INVTOT>.GetProperty(x => x.Basevat32),
         "BASEVAT3_2", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  126, // int? prec
                   
         null // int? Scale
         ,
         typeof(INVTOT)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <INVTOT>.GetProperty(x => x.Basevatonchgs),
         "BASEVATONCHGS", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  126, // int? prec
                   
         null // int? Scale
         ,
         typeof(INVTOT)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <INVTOT>.GetProperty(x => x.Basevattotal),
         "BASEVATTOTAL", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  126, // int? prec
                   
         null // int? Scale
         ,
         typeof(INVTOT)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <INVTOT>.GetProperty(x => x.Batchno),
         "BATCHNO", // columnName
         false,                    //isKey
         false, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  10, // int? prec
                           0  // int? Scale
         ,
         typeof(INVTOT)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <INVTOT>.GetProperty(x => x.Batchtype),
         "BATCHTYPE", // columnName
         false,                    //isKey
         false, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  5, // int? prec
                           0  // int? Scale
         ,
         typeof(INVTOT)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <INVTOT>.GetProperty(x => x.Cancelledinv),
         "CANCELLEDINV", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  1, // int? prec
                           0  // int? Scale
         ,
         typeof(INVTOT)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <INVTOT>.GetProperty(x => x.Cde1),
         "CDE1", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  10, // int? prec
                           0  // int? Scale
         ,
         typeof(INVTOT)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <INVTOT>.GetProperty(x => x.Cde2),
         "CDE2", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  10, // int? prec
                           0  // int? Scale
         ,
         typeof(INVTOT)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <INVTOT>.GetProperty(x => x.Cde3),
         "CDE3", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  10, // int? prec
                           0  // int? Scale
         ,
         typeof(INVTOT)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <INVTOT>.GetProperty(x => x.Companyname),
         "COMPANYNAME", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         40,       // int size   
                  null, // int? prec
                   
         null // int? Scale
         ,
         typeof(INVTOT)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <INVTOT>.GetProperty(x => x.Compoundvatcust),
         "COMPOUNDVATCUST", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  1, // int? prec
                           0  // int? Scale
         ,
         typeof(INVTOT)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <INVTOT>.GetProperty(x => x.Curdesc),
         "CURDESC", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         50,       // int size   
                  null, // int? prec
                   
         null // int? Scale
         ,
         typeof(INVTOT)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <INVTOT>.GetProperty(x => x.Curno),
         "CURNO", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  10, // int? prec
                           0  // int? Scale
         ,
         typeof(INVTOT)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <INVTOT>.GetProperty(x => x.Eiinvoiceid),
         "EIINVOICEID", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  10, // int? prec
                           0  // int? Scale
         ,
         typeof(INVTOT)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <INVTOT>.GetProperty(x => x.Eurogds1),
         "EUROGDS1", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  126, // int? prec
                   
         null // int? Scale
         ,
         typeof(INVTOT)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <INVTOT>.GetProperty(x => x.Eurogds2),
         "EUROGDS2", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  126, // int? prec
                   
         null // int? Scale
         ,
         typeof(INVTOT)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <INVTOT>.GetProperty(x => x.Eurogds3),
         "EUROGDS3", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  126, // int? prec
                   
         null // int? Scale
         ,
         typeof(INVTOT)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <INVTOT>.GetProperty(x => x.Eurogdstotal),
         "EUROGDSTOTAL", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  126, // int? prec
                   
         null // int? Scale
         ,
         typeof(INVTOT)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <INVTOT>.GetProperty(x => x.Eurohandcommamt),
         "EUROHANDCOMMAMT", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  126, // int? prec
                   
         null // int? Scale
         ,
         typeof(INVTOT)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <INVTOT>.GetProperty(x => x.Eurooffinvonpay),
         "EUROOFFINVONPAY", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  126, // int? prec
                   
         null // int? Scale
         ,
         typeof(INVTOT)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <INVTOT>.GetProperty(x => x.Eurooffinvrbt),
         "EUROOFFINVRBT", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  126, // int? prec
                   
         null // int? Scale
         ,
         typeof(INVTOT)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <INVTOT>.GetProperty(x => x.Eurooninvdscnt),
         "EUROONINVDSCNT", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  126, // int? prec
                   
         null // int? Scale
         ,
         typeof(INVTOT)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <INVTOT>.GetProperty(x => x.Eurorate),
         "EURORATE", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  126, // int? prec
                   
         null // int? Scale
         ,
         typeof(INVTOT)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <INVTOT>.GetProperty(x => x.Eurovat1),
         "EUROVAT1", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  126, // int? prec
                   
         null // int? Scale
         ,
         typeof(INVTOT)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <INVTOT>.GetProperty(x => x.Eurovat12),
         "EUROVAT1_2", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  126, // int? prec
                   
         null // int? Scale
         ,
         typeof(INVTOT)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <INVTOT>.GetProperty(x => x.Eurovat1total),
         "EUROVAT1TOTAL", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  126, // int? prec
                   
         null // int? Scale
         ,
         typeof(INVTOT)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <INVTOT>.GetProperty(x => x.Eurovat2),
         "EUROVAT2", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  126, // int? prec
                   
         null // int? Scale
         ,
         typeof(INVTOT)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <INVTOT>.GetProperty(x => x.Eurovat22),
         "EUROVAT2_2", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  126, // int? prec
                   
         null // int? Scale
         ,
         typeof(INVTOT)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <INVTOT>.GetProperty(x => x.Eurovat2total),
         "EUROVAT2TOTAL", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  126, // int? prec
                   
         null // int? Scale
         ,
         typeof(INVTOT)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <INVTOT>.GetProperty(x => x.Eurovat3),
         "EUROVAT3", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  126, // int? prec
                   
         null // int? Scale
         ,
         typeof(INVTOT)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <INVTOT>.GetProperty(x => x.Eurovat32),
         "EUROVAT3_2", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  126, // int? prec
                   
         null // int? Scale
         ,
         typeof(INVTOT)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <INVTOT>.GetProperty(x => x.Eurovatonchgs),
         "EUROVATONCHGS", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  126, // int? prec
                   
         null // int? Scale
         ,
         typeof(INVTOT)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <INVTOT>.GetProperty(x => x.Eurovattotal),
         "EUROVATTOTAL", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  126, // int? prec
                   
         null // int? Scale
         ,
         typeof(INVTOT)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <INVTOT>.GetProperty(x => x.Extractsessionid),
         "EXTRACTSESSIONID", // columnName
         false,                    //isKey
         false, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  10, // int? prec
                           0  // int? Scale
         ,
         typeof(INVTOT)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <INVTOT>.GetProperty(x => x.Finfiscrep1),
         "FINFISCREP1", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  1, // int? prec
                           0  // int? Scale
         ,
         typeof(INVTOT)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <INVTOT>.GetProperty(x => x.Finvatdesc1),
         "FINVATDESC1", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         255,       // int size   
                  null, // int? prec
                   
         null // int? Scale
         ,
         typeof(INVTOT)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <INVTOT>.GetProperty(x => x.Finvatnumber1),
         "FINVATNUMBER1", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         40,       // int size   
                  null, // int? prec
                   
         null // int? Scale
         ,
         typeof(INVTOT)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <INVTOT>.GetProperty(x => x.Gds1),
         "GDS1", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  126, // int? prec
                   
         null // int? Scale
         ,
         typeof(INVTOT)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <INVTOT>.GetProperty(x => x.Gds2),
         "GDS2", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  126, // int? prec
                   
         null // int? Scale
         ,
         typeof(INVTOT)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <INVTOT>.GetProperty(x => x.Gds3),
         "GDS3", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  126, // int? prec
                   
         null // int? Scale
         ,
         typeof(INVTOT)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <INVTOT>.GetProperty(x => x.Goodstotal),
         "GOODSTOTAL", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  126, // int? prec
                   
         null // int? Scale
         ,
         typeof(INVTOT)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <INVTOT>.GetProperty(x => x.Hofclarecno),
         "HOFCLARECNO", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  10, // int? prec
                           0  // int? Scale
         ,
         typeof(INVTOT)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <INVTOT>.GetProperty(x => x.Hofcstcode),
         "HOFCSTCODE", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         8,       // int size   
                  null, // int? prec
                   
         null // int? Scale
         ,
         typeof(INVTOT)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <INVTOT>.GetProperty(x => x.Invdate),
         "INVDATE", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  null, // int? prec
                   
         null // int? Scale
         ,
         typeof(INVTOT)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <INVTOT>.GetProperty(x => x.Invoiceno),
         "INVOICENO", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         50,       // int size   
                  null, // int? prec
                   
         null // int? Scale
         ,
         typeof(INVTOT)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <INVTOT>.GetProperty(x => x.Invoicetotal),
         "INVOICETOTAL", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  126, // int? prec
                   
         null // int? Scale
         ,
         typeof(INVTOT)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <INVTOT>.GetProperty(x => x.Invoicetype),
         "INVOICETYPE", // columnName
         false,                    //isKey
         false, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  5, // int? prec
                           0  // int? Scale
         ,
         typeof(INVTOT)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <INVTOT>.GetProperty(x => x.Invrecno),
         "INVRECNO", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  10, // int? prec
                           0  // int? Scale
         ,
         typeof(INVTOT)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <INVTOT>.GetProperty(x => x.Isedicst),
         "ISEDICST", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  1, // int? prec
                           0  // int? Scale
         ,
         typeof(INVTOT)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <INVTOT>.GetProperty(x => x.Isinterdept),
         "ISINTERDEPT", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  1, // int? prec
                           0  // int? Scale
         ,
         typeof(INVTOT)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <INVTOT>.GetProperty(x => x.Isseqinvno),
         "ISSEQINVNO", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  1, // int? prec
                           0  // int? Scale
         ,
         typeof(INVTOT)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <INVTOT>.GetProperty(x => x.Offinvonpay),
         "OFFINVONPAY", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  126, // int? prec
                   
         null // int? Scale
         ,
         typeof(INVTOT)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <INVTOT>.GetProperty(x => x.Offinvrbt),
         "OFFINVRBT", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  126, // int? prec
                   
         null // int? Scale
         ,
         typeof(INVTOT)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <INVTOT>.GetProperty(x => x.Oninvdscnt),
         "ONINVDSCNT", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  126, // int? prec
                   
         null // int? Scale
         ,
         typeof(INVTOT)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <INVTOT>.GetProperty(x => x.Originalinvoiceno),
         "ORIGINALINVOICENO", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         50,       // int size   
                  null, // int? prec
                   
         null // int? Scale
         ,
         typeof(INVTOT)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <INVTOT>.GetProperty(x => x.Prcglbrecno),
         "PRCGLBRECNO", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  10, // int? prec
                           0  // int? Scale
         ,
         typeof(INVTOT)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <INVTOT>.GetProperty(x => x.Qtytotal),
         "QTYTOTAL", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  10, // int? prec
                           0  // int? Scale
         ,
         typeof(INVTOT)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <INVTOT>.GetProperty(x => x.Rawhandcommamt),
         "RAWHANDCOMMAMT", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  126, // int? prec
                   
         null // int? Scale
         ,
         typeof(INVTOT)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <INVTOT>.GetProperty(x => x.Rawvatonchgs),
         "RAWVATONCHGS", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  126, // int? prec
                   
         null // int? Scale
         ,
         typeof(INVTOT)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <INVTOT>.GetProperty(x => x.Rte1),
         "RTE1", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  126, // int? prec
                   
         null // int? Scale
         ,
         typeof(INVTOT)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <INVTOT>.GetProperty(x => x.Rte12),
         "RTE1_2", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  126, // int? prec
                   
         null // int? Scale
         ,
         typeof(INVTOT)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <INVTOT>.GetProperty(x => x.Rte2),
         "RTE2", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  126, // int? prec
                   
         null // int? Scale
         ,
         typeof(INVTOT)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <INVTOT>.GetProperty(x => x.Rte22),
         "RTE2_2", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  126, // int? prec
                   
         null // int? Scale
         ,
         typeof(INVTOT)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <INVTOT>.GetProperty(x => x.Rte3),
         "RTE3", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  126, // int? prec
                   
         null // int? Scale
         ,
         typeof(INVTOT)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <INVTOT>.GetProperty(x => x.Rte32),
         "RTE3_2", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  126, // int? prec
                   
         null // int? Scale
         ,
         typeof(INVTOT)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <INVTOT>.GetProperty(x => x.Sort1),
         "SORT1", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         50,       // int size   
                  null, // int? prec
                   
         null // int? Scale
         ,
         typeof(INVTOT)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <INVTOT>.GetProperty(x => x.Sort2),
         "SORT2", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         50,       // int size   
                  null, // int? prec
                   
         null // int? Scale
         ,
         typeof(INVTOT)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <INVTOT>.GetProperty(x => x.Sort3),
         "SORT3", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         50,       // int size   
                  null, // int? prec
                   
         null // int? Scale
         ,
         typeof(INVTOT)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <INVTOT>.GetProperty(x => x.Stinvtotal),
         "STINVTOTAL", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         20,       // int size   
                  null, // int? prec
                   
         null // int? Scale
         ,
         typeof(INVTOT)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <INVTOT>.GetProperty(x => x.Triangreq),
         "TRIANGREQ", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  1, // int? prec
                           0  // int? Scale
         ,
         typeof(INVTOT)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <INVTOT>.GetProperty(x => x.Twovatratescust),
         "TWOVATRATESCUST", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  1, // int? prec
                           0  // int? Scale
         ,
         typeof(INVTOT)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <INVTOT>.GetProperty(x => x.Vat1),
         "VAT1", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  126, // int? prec
                   
         null // int? Scale
         ,
         typeof(INVTOT)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <INVTOT>.GetProperty(x => x.Vat12),
         "VAT1_2", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  126, // int? prec
                   
         null // int? Scale
         ,
         typeof(INVTOT)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <INVTOT>.GetProperty(x => x.Vat1total),
         "VAT1TOTAL", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  126, // int? prec
                   
         null // int? Scale
         ,
         typeof(INVTOT)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <INVTOT>.GetProperty(x => x.Vat2),
         "VAT2", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  126, // int? prec
                   
         null // int? Scale
         ,
         typeof(INVTOT)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <INVTOT>.GetProperty(x => x.Vat22),
         "VAT2_2", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  126, // int? prec
                   
         null // int? Scale
         ,
         typeof(INVTOT)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <INVTOT>.GetProperty(x => x.Vat2total),
         "VAT2TOTAL", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  126, // int? prec
                   
         null // int? Scale
         ,
         typeof(INVTOT)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <INVTOT>.GetProperty(x => x.Vat3),
         "VAT3", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  126, // int? prec
                   
         null // int? Scale
         ,
         typeof(INVTOT)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <INVTOT>.GetProperty(x => x.Vat32),
         "VAT3_2", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  126, // int? prec
                   
         null // int? Scale
         ,
         typeof(INVTOT)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <INVTOT>.GetProperty(x => x.Vatcodechgs),
         "VATCODECHGS", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  126, // int? prec
                   
         null // int? Scale
         ,
         typeof(INVTOT)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <INVTOT>.GetProperty(x => x.Vatlnkrecno1),
         "VATLNKRECNO1", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  10, // int? prec
                           0  // int? Scale
         ,
         typeof(INVTOT)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <INVTOT>.GetProperty(x => x.Vatlnkrecno2),
         "VATLNKRECNO2", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  10, // int? prec
                           0  // int? Scale
         ,
         typeof(INVTOT)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <INVTOT>.GetProperty(x => x.Vatlnkrecno3),
         "VATLNKRECNO3", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  10, // int? prec
                           0  // int? Scale
         ,
         typeof(INVTOT)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <INVTOT>.GetProperty(x => x.Vatratechgs),
         "VATRATECHGS", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  126, // int? prec
                   
         null // int? Scale
         ,
         typeof(INVTOT)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <INVTOT>.GetProperty(x => x.Vattotal),
         "VATTOTAL", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  126, // int? prec
                   
         null // int? Scale
         ,
         typeof(INVTOT)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <INVTOT>.GetProperty(x => x.Writeaccrechg),
         "WRITEACCRECHG", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  1, // int? prec
                           0  // int? Scale
         ,
         typeof(INVTOT)
         ));
         return result; 
       }

#endregion     
        private int? _fAccglanl;
        public int? Accglanl
        {
            get { return _fAccglanl; }
            set
            {
                if (_fAccglanl != value)
                {
                    Modify();
                    _fAccglanl = value;
                }
            }
        }

        private int? _fAccntsaloffno;
        public int? Accntsaloffno
        {
            get { return _fAccntsaloffno; }
            set
            {
                if (_fAccntsaloffno != value)
                {
                    Modify();
                    _fAccntsaloffno = value;
                }
            }
        }

        private int? _fAvavearec1;
        public int? Avavearec1
        {
            get { return _fAvavearec1; }
            set
            {
                if (_fAvavearec1 != value)
                {
                    Modify();
                    _fAvavearec1 = value;
                }
            }
        }

        private int? _fAvavearec2;
        public int? Avavearec2
        {
            get { return _fAvavearec2; }
            set
            {
                if (_fAvavearec2 != value)
                {
                    Modify();
                    _fAvavearec2 = value;
                }
            }
        }

        private int? _fAvavearec3;
        public int? Avavearec3
        {
            get { return _fAvavearec3; }
            set
            {
                if (_fAvavearec3 != value)
                {
                    Modify();
                    _fAvavearec3 = value;
                }
            }
        }

        private decimal? _fBasegds1;
        public decimal? Basegds1
        {
            get { return _fBasegds1; }
            set
            {
                if (_fBasegds1 != value)
                {
                    Modify();
                    _fBasegds1 = value;
                }
            }
        }

        private decimal? _fBasegds2;
        public decimal? Basegds2
        {
            get { return _fBasegds2; }
            set
            {
                if (_fBasegds2 != value)
                {
                    Modify();
                    _fBasegds2 = value;
                }
            }
        }

        private decimal? _fBasegds3;
        public decimal? Basegds3
        {
            get { return _fBasegds3; }
            set
            {
                if (_fBasegds3 != value)
                {
                    Modify();
                    _fBasegds3 = value;
                }
            }
        }

        private decimal? _fBasegdstotal;
        public decimal? Basegdstotal
        {
            get { return _fBasegdstotal; }
            set
            {
                if (_fBasegdstotal != value)
                {
                    Modify();
                    _fBasegdstotal = value;
                }
            }
        }

        private decimal? _fBasehandcommamt;
        public decimal? Basehandcommamt
        {
            get { return _fBasehandcommamt; }
            set
            {
                if (_fBasehandcommamt != value)
                {
                    Modify();
                    _fBasehandcommamt = value;
                }
            }
        }

        private decimal? _fBaseoffinvonpay;
        public decimal? Baseoffinvonpay
        {
            get { return _fBaseoffinvonpay; }
            set
            {
                if (_fBaseoffinvonpay != value)
                {
                    Modify();
                    _fBaseoffinvonpay = value;
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

        private decimal? _fBaserate;
        public decimal? Baserate
        {
            get { return _fBaserate; }
            set
            {
                if (_fBaserate != value)
                {
                    Modify();
                    _fBaserate = value;
                }
            }
        }

        private decimal? _fBasevat1;
        public decimal? Basevat1
        {
            get { return _fBasevat1; }
            set
            {
                if (_fBasevat1 != value)
                {
                    Modify();
                    _fBasevat1 = value;
                }
            }
        }

        private decimal? _fBasevat12;
        public decimal? Basevat12
        {
            get { return _fBasevat12; }
            set
            {
                if (_fBasevat12 != value)
                {
                    Modify();
                    _fBasevat12 = value;
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

        private decimal? _fBasevat2;
        public decimal? Basevat2
        {
            get { return _fBasevat2; }
            set
            {
                if (_fBasevat2 != value)
                {
                    Modify();
                    _fBasevat2 = value;
                }
            }
        }

        private decimal? _fBasevat22;
        public decimal? Basevat22
        {
            get { return _fBasevat22; }
            set
            {
                if (_fBasevat22 != value)
                {
                    Modify();
                    _fBasevat22 = value;
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

        private decimal? _fBasevat3;
        public decimal? Basevat3
        {
            get { return _fBasevat3; }
            set
            {
                if (_fBasevat3 != value)
                {
                    Modify();
                    _fBasevat3 = value;
                }
            }
        }

        private decimal? _fBasevat32;
        public decimal? Basevat32
        {
            get { return _fBasevat32; }
            set
            {
                if (_fBasevat32 != value)
                {
                    Modify();
                    _fBasevat32 = value;
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

        private decimal? _fBasevattotal;
        public decimal? Basevattotal
        {
            get { return _fBasevattotal; }
            set
            {
                if (_fBasevattotal != value)
                {
                    Modify();
                    _fBasevattotal = value;
                }
            }
        }

        private int _fBatchno;
        public int Batchno
        {
            get { return _fBatchno; }
            set
            {
                if (_fBatchno != value)
                {
                    Modify();
                    _fBatchno = value;
                }
            }
        }

        private int _fBatchtype;
        public int Batchtype
        {
            get { return _fBatchtype; }
            set
            {
                if (_fBatchtype != value)
                {
                    Modify();
                    _fBatchtype = value;
                }
            }
        }

        private short? _fCancelledinv;
        public short? Cancelledinv
        {
            get { return _fCancelledinv; }
            set
            {
                if (_fCancelledinv != value)
                {
                    Modify();
                    _fCancelledinv = value;
                }
            }
        }

        private int? _fCde1;
        public int? Cde1
        {
            get { return _fCde1; }
            set
            {
                if (_fCde1 != value)
                {
                    Modify();
                    _fCde1 = value;
                }
            }
        }

        private int? _fCde2;
        public int? Cde2
        {
            get { return _fCde2; }
            set
            {
                if (_fCde2 != value)
                {
                    Modify();
                    _fCde2 = value;
                }
            }
        }

        private int? _fCde3;
        public int? Cde3
        {
            get { return _fCde3; }
            set
            {
                if (_fCde3 != value)
                {
                    Modify();
                    _fCde3 = value;
                }
            }
        }

        private string _fCompanyname;
        public string Companyname
        {
            get { return _fCompanyname; }
            set
            {
                if (_fCompanyname != value)
                {
                    Modify();
                    _fCompanyname = value;
                }
            }
        }

        private short? _fCompoundvatcust;
        public short? Compoundvatcust
        {
            get { return _fCompoundvatcust; }
            set
            {
                if (_fCompoundvatcust != value)
                {
                    Modify();
                    _fCompoundvatcust = value;
                }
            }
        }

        private string _fCurdesc;
        public string Curdesc
        {
            get { return _fCurdesc; }
            set
            {
                if (_fCurdesc != value)
                {
                    Modify();
                    _fCurdesc = value;
                }
            }
        }

        private int? _fCurno;
        public int? Curno
        {
            get { return _fCurno; }
            set
            {
                if (_fCurno != value)
                {
                    Modify();
                    _fCurno = value;
                }
            }
        }

        private int? _fEiinvoiceid;
        public int? Eiinvoiceid
        {
            get { return _fEiinvoiceid; }
            set
            {
                if (_fEiinvoiceid != value)
                {
                    Modify();
                    _fEiinvoiceid = value;
                }
            }
        }

        private decimal? _fEurogds1;
        public decimal? Eurogds1
        {
            get { return _fEurogds1; }
            set
            {
                if (_fEurogds1 != value)
                {
                    Modify();
                    _fEurogds1 = value;
                }
            }
        }

        private decimal? _fEurogds2;
        public decimal? Eurogds2
        {
            get { return _fEurogds2; }
            set
            {
                if (_fEurogds2 != value)
                {
                    Modify();
                    _fEurogds2 = value;
                }
            }
        }

        private decimal? _fEurogds3;
        public decimal? Eurogds3
        {
            get { return _fEurogds3; }
            set
            {
                if (_fEurogds3 != value)
                {
                    Modify();
                    _fEurogds3 = value;
                }
            }
        }

        private decimal? _fEurogdstotal;
        public decimal? Eurogdstotal
        {
            get { return _fEurogdstotal; }
            set
            {
                if (_fEurogdstotal != value)
                {
                    Modify();
                    _fEurogdstotal = value;
                }
            }
        }

        private decimal? _fEurohandcommamt;
        public decimal? Eurohandcommamt
        {
            get { return _fEurohandcommamt; }
            set
            {
                if (_fEurohandcommamt != value)
                {
                    Modify();
                    _fEurohandcommamt = value;
                }
            }
        }

        private decimal? _fEurooffinvonpay;
        public decimal? Eurooffinvonpay
        {
            get { return _fEurooffinvonpay; }
            set
            {
                if (_fEurooffinvonpay != value)
                {
                    Modify();
                    _fEurooffinvonpay = value;
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

        private decimal? _fEurorate;
        public decimal? Eurorate
        {
            get { return _fEurorate; }
            set
            {
                if (_fEurorate != value)
                {
                    Modify();
                    _fEurorate = value;
                }
            }
        }

        private decimal? _fEurovat1;
        public decimal? Eurovat1
        {
            get { return _fEurovat1; }
            set
            {
                if (_fEurovat1 != value)
                {
                    Modify();
                    _fEurovat1 = value;
                }
            }
        }

        private decimal? _fEurovat12;
        public decimal? Eurovat12
        {
            get { return _fEurovat12; }
            set
            {
                if (_fEurovat12 != value)
                {
                    Modify();
                    _fEurovat12 = value;
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

        private decimal? _fEurovat2;
        public decimal? Eurovat2
        {
            get { return _fEurovat2; }
            set
            {
                if (_fEurovat2 != value)
                {
                    Modify();
                    _fEurovat2 = value;
                }
            }
        }

        private decimal? _fEurovat22;
        public decimal? Eurovat22
        {
            get { return _fEurovat22; }
            set
            {
                if (_fEurovat22 != value)
                {
                    Modify();
                    _fEurovat22 = value;
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

        private decimal? _fEurovat3;
        public decimal? Eurovat3
        {
            get { return _fEurovat3; }
            set
            {
                if (_fEurovat3 != value)
                {
                    Modify();
                    _fEurovat3 = value;
                }
            }
        }

        private decimal? _fEurovat32;
        public decimal? Eurovat32
        {
            get { return _fEurovat32; }
            set
            {
                if (_fEurovat32 != value)
                {
                    Modify();
                    _fEurovat32 = value;
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

        private decimal? _fEurovattotal;
        public decimal? Eurovattotal
        {
            get { return _fEurovattotal; }
            set
            {
                if (_fEurovattotal != value)
                {
                    Modify();
                    _fEurovattotal = value;
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

        private short? _fFinfiscrep1;
        public short? Finfiscrep1
        {
            get { return _fFinfiscrep1; }
            set
            {
                if (_fFinfiscrep1 != value)
                {
                    Modify();
                    _fFinfiscrep1 = value;
                }
            }
        }

        private string _fFinvatdesc1;
        public string Finvatdesc1
        {
            get { return _fFinvatdesc1; }
            set
            {
                if (_fFinvatdesc1 != value)
                {
                    Modify();
                    _fFinvatdesc1 = value;
                }
            }
        }

        private string _fFinvatnumber1;
        public string Finvatnumber1
        {
            get { return _fFinvatnumber1; }
            set
            {
                if (_fFinvatnumber1 != value)
                {
                    Modify();
                    _fFinvatnumber1 = value;
                }
            }
        }

        private decimal? _fGds1;
        public decimal? Gds1
        {
            get { return _fGds1; }
            set
            {
                if (_fGds1 != value)
                {
                    Modify();
                    _fGds1 = value;
                }
            }
        }

        private decimal? _fGds2;
        public decimal? Gds2
        {
            get { return _fGds2; }
            set
            {
                if (_fGds2 != value)
                {
                    Modify();
                    _fGds2 = value;
                }
            }
        }

        private decimal? _fGds3;
        public decimal? Gds3
        {
            get { return _fGds3; }
            set
            {
                if (_fGds3 != value)
                {
                    Modify();
                    _fGds3 = value;
                }
            }
        }

        private decimal? _fGoodstotal;
        public decimal? Goodstotal
        {
            get { return _fGoodstotal; }
            set
            {
                if (_fGoodstotal != value)
                {
                    Modify();
                    _fGoodstotal = value;
                }
            }
        }

        private int? _fHofclarecno;
        public int? Hofclarecno
        {
            get { return _fHofclarecno; }
            set
            {
                if (_fHofclarecno != value)
                {
                    Modify();
                    _fHofclarecno = value;
                }
            }
        }

        private string _fHofcstcode;
        public string Hofcstcode
        {
            get { return _fHofcstcode; }
            set
            {
                if (_fHofcstcode != value)
                {
                    Modify();
                    _fHofcstcode = value;
                }
            }
        }

        private DateTime? _fInvdate;
        public DateTime? Invdate
        {
            get { return _fInvdate; }
            set
            {
                if (_fInvdate != value)
                {
                    Modify();
                    _fInvdate = value;
                }
            }
        }

        private string _fInvoiceno;
        public string Invoiceno
        {
            get { return _fInvoiceno; }
            set
            {
                if (_fInvoiceno != value)
                {
                    Modify();
                    _fInvoiceno = value;
                }
            }
        }

        private decimal? _fInvoicetotal;
        public decimal? Invoicetotal
        {
            get { return _fInvoicetotal; }
            set
            {
                if (_fInvoicetotal != value)
                {
                    Modify();
                    _fInvoicetotal = value;
                }
            }
        }

        private int _fInvoicetype;
        public int Invoicetype
        {
            get { return _fInvoicetype; }
            set
            {
                if (_fInvoicetype != value)
                {
                    Modify();
                    _fInvoicetype = value;
                }
            }
        }

        private int? _fInvrecno;
        public int? Invrecno
        {
            get { return _fInvrecno; }
            set
            {
                if (_fInvrecno != value)
                {
                    Modify();
                    _fInvrecno = value;
                }
            }
        }

        private short? _fIsedicst;
        public short? Isedicst
        {
            get { return _fIsedicst; }
            set
            {
                if (_fIsedicst != value)
                {
                    Modify();
                    _fIsedicst = value;
                }
            }
        }

        private short? _fIsinterdept;
        public short? Isinterdept
        {
            get { return _fIsinterdept; }
            set
            {
                if (_fIsinterdept != value)
                {
                    Modify();
                    _fIsinterdept = value;
                }
            }
        }

        private short? _fIsseqinvno;
        public short? Isseqinvno
        {
            get { return _fIsseqinvno; }
            set
            {
                if (_fIsseqinvno != value)
                {
                    Modify();
                    _fIsseqinvno = value;
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

        private string _fOriginalinvoiceno;
        public string Originalinvoiceno
        {
            get { return _fOriginalinvoiceno; }
            set
            {
                if (_fOriginalinvoiceno != value)
                {
                    Modify();
                    _fOriginalinvoiceno = value;
                }
            }
        }

        private int? _fPrcglbrecno;
        public int? Prcglbrecno
        {
            get { return _fPrcglbrecno; }
            set
            {
                if (_fPrcglbrecno != value)
                {
                    Modify();
                    _fPrcglbrecno = value;
                }
            }
        }

        private int? _fQtytotal;
        public int? Qtytotal
        {
            get { return _fQtytotal; }
            set
            {
                if (_fQtytotal != value)
                {
                    Modify();
                    _fQtytotal = value;
                }
            }
        }

        private decimal? _fRawhandcommamt;
        public decimal? Rawhandcommamt
        {
            get { return _fRawhandcommamt; }
            set
            {
                if (_fRawhandcommamt != value)
                {
                    Modify();
                    _fRawhandcommamt = value;
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

        private decimal? _fRte1;
        public decimal? Rte1
        {
            get { return _fRte1; }
            set
            {
                if (_fRte1 != value)
                {
                    Modify();
                    _fRte1 = value;
                }
            }
        }

        private decimal? _fRte12;
        public decimal? Rte12
        {
            get { return _fRte12; }
            set
            {
                if (_fRte12 != value)
                {
                    Modify();
                    _fRte12 = value;
                }
            }
        }

        private decimal? _fRte2;
        public decimal? Rte2
        {
            get { return _fRte2; }
            set
            {
                if (_fRte2 != value)
                {
                    Modify();
                    _fRte2 = value;
                }
            }
        }

        private decimal? _fRte22;
        public decimal? Rte22
        {
            get { return _fRte22; }
            set
            {
                if (_fRte22 != value)
                {
                    Modify();
                    _fRte22 = value;
                }
            }
        }

        private decimal? _fRte3;
        public decimal? Rte3
        {
            get { return _fRte3; }
            set
            {
                if (_fRte3 != value)
                {
                    Modify();
                    _fRte3 = value;
                }
            }
        }

        private decimal? _fRte32;
        public decimal? Rte32
        {
            get { return _fRte32; }
            set
            {
                if (_fRte32 != value)
                {
                    Modify();
                    _fRte32 = value;
                }
            }
        }

        private string _fSort1;
        public string Sort1
        {
            get { return _fSort1; }
            set
            {
                if (_fSort1 != value)
                {
                    Modify();
                    _fSort1 = value;
                }
            }
        }

        private string _fSort2;
        public string Sort2
        {
            get { return _fSort2; }
            set
            {
                if (_fSort2 != value)
                {
                    Modify();
                    _fSort2 = value;
                }
            }
        }

        private string _fSort3;
        public string Sort3
        {
            get { return _fSort3; }
            set
            {
                if (_fSort3 != value)
                {
                    Modify();
                    _fSort3 = value;
                }
            }
        }

        private string _fStinvtotal;
        public string Stinvtotal
        {
            get { return _fStinvtotal; }
            set
            {
                if (_fStinvtotal != value)
                {
                    Modify();
                    _fStinvtotal = value;
                }
            }
        }

        private short? _fTriangreq;
        public short? Triangreq
        {
            get { return _fTriangreq; }
            set
            {
                if (_fTriangreq != value)
                {
                    Modify();
                    _fTriangreq = value;
                }
            }
        }

        private short? _fTwovatratescust;
        public short? Twovatratescust
        {
            get { return _fTwovatratescust; }
            set
            {
                if (_fTwovatratescust != value)
                {
                    Modify();
                    _fTwovatratescust = value;
                }
            }
        }

        private decimal? _fVat1;
        public decimal? Vat1
        {
            get { return _fVat1; }
            set
            {
                if (_fVat1 != value)
                {
                    Modify();
                    _fVat1 = value;
                }
            }
        }

        private decimal? _fVat12;
        public decimal? Vat12
        {
            get { return _fVat12; }
            set
            {
                if (_fVat12 != value)
                {
                    Modify();
                    _fVat12 = value;
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

        private decimal? _fVat2;
        public decimal? Vat2
        {
            get { return _fVat2; }
            set
            {
                if (_fVat2 != value)
                {
                    Modify();
                    _fVat2 = value;
                }
            }
        }

        private decimal? _fVat22;
        public decimal? Vat22
        {
            get { return _fVat22; }
            set
            {
                if (_fVat22 != value)
                {
                    Modify();
                    _fVat22 = value;
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

        private decimal? _fVat3;
        public decimal? Vat3
        {
            get { return _fVat3; }
            set
            {
                if (_fVat3 != value)
                {
                    Modify();
                    _fVat3 = value;
                }
            }
        }

        private decimal? _fVat32;
        public decimal? Vat32
        {
            get { return _fVat32; }
            set
            {
                if (_fVat32 != value)
                {
                    Modify();
                    _fVat32 = value;
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

        private int? _fVatlnkrecno1;
        public int? Vatlnkrecno1
        {
            get { return _fVatlnkrecno1; }
            set
            {
                if (_fVatlnkrecno1 != value)
                {
                    Modify();
                    _fVatlnkrecno1 = value;
                }
            }
        }

        private int? _fVatlnkrecno2;
        public int? Vatlnkrecno2
        {
            get { return _fVatlnkrecno2; }
            set
            {
                if (_fVatlnkrecno2 != value)
                {
                    Modify();
                    _fVatlnkrecno2 = value;
                }
            }
        }

        private int? _fVatlnkrecno3;
        public int? Vatlnkrecno3
        {
            get { return _fVatlnkrecno3; }
            set
            {
                if (_fVatlnkrecno3 != value)
                {
                    Modify();
                    _fVatlnkrecno3 = value;
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

        private decimal? _fVattotal;
        public decimal? Vattotal
        {
            get { return _fVattotal; }
            set
            {
                if (_fVattotal != value)
                {
                    Modify();
                    _fVattotal = value;
                }
            }
        }

        private short? _fWriteaccrechg;
        public short? Writeaccrechg
        {
            get { return _fWriteaccrechg; }
            set
            {
                if (_fWriteaccrechg != value)
                {
                    Modify();
                    _fWriteaccrechg = value;
                }
            }
        }


        public override INVTOT Clone()
        {
            var obj = new INVTOT
                {
                    Accglanl = Accglanl,
                    Accntsaloffno = Accntsaloffno,
                    Avavearec1 = Avavearec1,
                    Avavearec2 = Avavearec2,
                    Avavearec3 = Avavearec3,
                    Basegds1 = Basegds1,
                    Basegds2 = Basegds2,
                    Basegds3 = Basegds3,
                    Basegdstotal = Basegdstotal,
                    Basehandcommamt = Basehandcommamt,
                    Baseoffinvonpay = Baseoffinvonpay,
                    Baseoffinvrbt = Baseoffinvrbt,
                    Baseoninvdscnt = Baseoninvdscnt,
                    Baserate = Baserate,
                    Basevat1 = Basevat1,
                    Basevat12 = Basevat12,
                    Basevat1total = Basevat1total,
                    Basevat2 = Basevat2,
                    Basevat22 = Basevat22,
                    Basevat2total = Basevat2total,
                    Basevat3 = Basevat3,
                    Basevat32 = Basevat32,
                    Basevatonchgs = Basevatonchgs,
                    Basevattotal = Basevattotal,
                    Batchno = Batchno,
                    Batchtype = Batchtype,
                    Cancelledinv = Cancelledinv,
                    Cde1 = Cde1,
                    Cde2 = Cde2,
                    Cde3 = Cde3,
                    Companyname = Companyname,
                    Compoundvatcust = Compoundvatcust,
                    Curdesc = Curdesc,
                    Curno = Curno,
                    Eiinvoiceid = Eiinvoiceid,
                    Eurogds1 = Eurogds1,
                    Eurogds2 = Eurogds2,
                    Eurogds3 = Eurogds3,
                    Eurogdstotal = Eurogdstotal,
                    Eurohandcommamt = Eurohandcommamt,
                    Eurooffinvonpay = Eurooffinvonpay,
                    Eurooffinvrbt = Eurooffinvrbt,
                    Eurooninvdscnt = Eurooninvdscnt,
                    Eurorate = Eurorate,
                    Eurovat1 = Eurovat1,
                    Eurovat12 = Eurovat12,
                    Eurovat1total = Eurovat1total,
                    Eurovat2 = Eurovat2,
                    Eurovat22 = Eurovat22,
                    Eurovat2total = Eurovat2total,
                    Eurovat3 = Eurovat3,
                    Eurovat32 = Eurovat32,
                    Eurovatonchgs = Eurovatonchgs,
                    Eurovattotal = Eurovattotal,
                    Extractsessionid = Extractsessionid,
                    Finfiscrep1 = Finfiscrep1,
                    Finvatdesc1 = Finvatdesc1,
                    Finvatnumber1 = Finvatnumber1,
                    Gds1 = Gds1,
                    Gds2 = Gds2,
                    Gds3 = Gds3,
                    Goodstotal = Goodstotal,
                    Hofclarecno = Hofclarecno,
                    Hofcstcode = Hofcstcode,
                    Invdate = Invdate,
                    Invoiceno = Invoiceno,
                    Invoicetotal = Invoicetotal,
                    Invoicetype = Invoicetype,
                    Invrecno = Invrecno,
                    Isedicst = Isedicst,
                    Isinterdept = Isinterdept,
                    Isseqinvno = Isseqinvno,
                    Offinvonpay = Offinvonpay,
                    Offinvrbt = Offinvrbt,
                    Oninvdscnt = Oninvdscnt,
                    Originalinvoiceno = Originalinvoiceno,
                    Prcglbrecno = Prcglbrecno,
                    Qtytotal = Qtytotal,
                    Rawhandcommamt = Rawhandcommamt,
                    Rawvatonchgs = Rawvatonchgs,
                    Rte1 = Rte1,
                    Rte12 = Rte12,
                    Rte2 = Rte2,
                    Rte22 = Rte22,
                    Rte3 = Rte3,
                    Rte32 = Rte32,
                    Sort1 = Sort1,
                    Sort2 = Sort2,
                    Sort3 = Sort3,
                    Stinvtotal = Stinvtotal,
                    Triangreq = Triangreq,
                    Twovatratescust = Twovatratescust,
                    Vat1 = Vat1,
                    Vat12 = Vat12,
                    Vat1total = Vat1total,
                    Vat2 = Vat2,
                    Vat22 = Vat22,
                    Vat2total = Vat2total,
                    Vat3 = Vat3,
                    Vat32 = Vat32,
                    Vatcodechgs = Vatcodechgs,
                    Vatlnkrecno1 = Vatlnkrecno1,
                    Vatlnkrecno2 = Vatlnkrecno2,
                    Vatlnkrecno3 = Vatlnkrecno3,
                    Vatratechgs = Vatratechgs,
                    Vattotal = Vattotal,
                    Writeaccrechg = Writeaccrechg,
                };

            return obj;
        }

        public static class FieldNames
        {
// ReSharper disable InconsistentNaming
            public const string  ACCGLANL = "ACCGLANL";
            public const string  ACCNTSALOFFNO = "ACCNTSALOFFNO";
            public const string  AVAVEAREC1 = "AVAVEAREC1";
            public const string  AVAVEAREC2 = "AVAVEAREC2";
            public const string  AVAVEAREC3 = "AVAVEAREC3";
            public const string  BASEGDS1 = "BASEGDS1";
            public const string  BASEGDS2 = "BASEGDS2";
            public const string  BASEGDS3 = "BASEGDS3";
            public const string  BASEGDSTOTAL = "BASEGDSTOTAL";
            public const string  BASEHANDCOMMAMT = "BASEHANDCOMMAMT";
            public const string  BASEOFFINVONPAY = "BASEOFFINVONPAY";
            public const string  BASEOFFINVRBT = "BASEOFFINVRBT";
            public const string  BASEONINVDSCNT = "BASEONINVDSCNT";
            public const string  BASERATE = "BASERATE";
            public const string  BASEVAT1 = "BASEVAT1";
            public const string  BASEVAT1_2 = "BASEVAT1_2";
            public const string  BASEVAT1TOTAL = "BASEVAT1TOTAL";
            public const string  BASEVAT2 = "BASEVAT2";
            public const string  BASEVAT2_2 = "BASEVAT2_2";
            public const string  BASEVAT2TOTAL = "BASEVAT2TOTAL";
            public const string  BASEVAT3 = "BASEVAT3";
            public const string  BASEVAT3_2 = "BASEVAT3_2";
            public const string  BASEVATONCHGS = "BASEVATONCHGS";
            public const string  BASEVATTOTAL = "BASEVATTOTAL";
            public const string  BATCHNO = "BATCHNO";
            public const string  BATCHTYPE = "BATCHTYPE";
            public const string  CANCELLEDINV = "CANCELLEDINV";
            public const string  CDE1 = "CDE1";
            public const string  CDE2 = "CDE2";
            public const string  CDE3 = "CDE3";
            public const string  COMPANYNAME = "COMPANYNAME";
            public const string  COMPOUNDVATCUST = "COMPOUNDVATCUST";
            public const string  CURDESC = "CURDESC";
            public const string  CURNO = "CURNO";
            public const string  EIINVOICEID = "EIINVOICEID";
            public const string  EUROGDS1 = "EUROGDS1";
            public const string  EUROGDS2 = "EUROGDS2";
            public const string  EUROGDS3 = "EUROGDS3";
            public const string  EUROGDSTOTAL = "EUROGDSTOTAL";
            public const string  EUROHANDCOMMAMT = "EUROHANDCOMMAMT";
            public const string  EUROOFFINVONPAY = "EUROOFFINVONPAY";
            public const string  EUROOFFINVRBT = "EUROOFFINVRBT";
            public const string  EUROONINVDSCNT = "EUROONINVDSCNT";
            public const string  EURORATE = "EURORATE";
            public const string  EUROVAT1 = "EUROVAT1";
            public const string  EUROVAT1_2 = "EUROVAT1_2";
            public const string  EUROVAT1TOTAL = "EUROVAT1TOTAL";
            public const string  EUROVAT2 = "EUROVAT2";
            public const string  EUROVAT2_2 = "EUROVAT2_2";
            public const string  EUROVAT2TOTAL = "EUROVAT2TOTAL";
            public const string  EUROVAT3 = "EUROVAT3";
            public const string  EUROVAT3_2 = "EUROVAT3_2";
            public const string  EUROVATONCHGS = "EUROVATONCHGS";
            public const string  EUROVATTOTAL = "EUROVATTOTAL";
            public const string  EXTRACTSESSIONID = "EXTRACTSESSIONID";
            public const string  FINFISCREP1 = "FINFISCREP1";
            public const string  FINVATDESC1 = "FINVATDESC1";
            public const string  FINVATNUMBER1 = "FINVATNUMBER1";
            public const string  GDS1 = "GDS1";
            public const string  GDS2 = "GDS2";
            public const string  GDS3 = "GDS3";
            public const string  GOODSTOTAL = "GOODSTOTAL";
            public const string  HOFCLARECNO = "HOFCLARECNO";
            public const string  HOFCSTCODE = "HOFCSTCODE";
            public const string  INVDATE = "INVDATE";
            public const string  INVOICENO = "INVOICENO";
            public const string  INVOICETOTAL = "INVOICETOTAL";
            public const string  INVOICETYPE = "INVOICETYPE";
            public const string  INVRECNO = "INVRECNO";
            public const string  ISEDICST = "ISEDICST";
            public const string  ISINTERDEPT = "ISINTERDEPT";
            public const string  ISSEQINVNO = "ISSEQINVNO";
            public const string  OFFINVONPAY = "OFFINVONPAY";
            public const string  OFFINVRBT = "OFFINVRBT";
            public const string  ONINVDSCNT = "ONINVDSCNT";
            public const string  ORIGINALINVOICENO = "ORIGINALINVOICENO";
            public const string  PRCGLBRECNO = "PRCGLBRECNO";
            public const string  QTYTOTAL = "QTYTOTAL";
            public const string  RAWHANDCOMMAMT = "RAWHANDCOMMAMT";
            public const string  RAWVATONCHGS = "RAWVATONCHGS";
            public const string  RTE1 = "RTE1";
            public const string  RTE1_2 = "RTE1_2";
            public const string  RTE2 = "RTE2";
            public const string  RTE2_2 = "RTE2_2";
            public const string  RTE3 = "RTE3";
            public const string  RTE3_2 = "RTE3_2";
            public const string  SORT1 = "SORT1";
            public const string  SORT2 = "SORT2";
            public const string  SORT3 = "SORT3";
            public const string  STINVTOTAL = "STINVTOTAL";
            public const string  TRIANGREQ = "TRIANGREQ";
            public const string  TWOVATRATESCUST = "TWOVATRATESCUST";
            public const string  VAT1 = "VAT1";
            public const string  VAT1_2 = "VAT1_2";
            public const string  VAT1TOTAL = "VAT1TOTAL";
            public const string  VAT2 = "VAT2";
            public const string  VAT2_2 = "VAT2_2";
            public const string  VAT2TOTAL = "VAT2TOTAL";
            public const string  VAT3 = "VAT3";
            public const string  VAT3_2 = "VAT3_2";
            public const string  VATCODECHGS = "VATCODECHGS";
            public const string  VATLNKRECNO1 = "VATLNKRECNO1";
            public const string  VATLNKRECNO2 = "VATLNKRECNO2";
            public const string  VATLNKRECNO3 = "VATLNKRECNO3";
            public const string  VATRATECHGS = "VATRATECHGS";
            public const string  VATTOTAL = "VATTOTAL";
            public const string  WRITEACCRECHG = "WRITEACCRECHG";
 // ReSharper restore InconsistentNaming
        }


    }

}
