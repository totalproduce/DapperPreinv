// <summary>
// This file is generated automatically. Any changes will be lost.
// </summary>

using System;
using System.Collections.Generic;
using System.Globalization;
using Bsdl.FreshTrade.Repositories.Basic.DBModel;
using Bsdl.FreshTrade.Repositories.Basic.Persistance;

namespace Bsdl.FreshTrade.Repositories.Account.DBModel
{
    /// <summary>
    /// Entity for the SALOFFNO table
    /// </summary>
    public partial class SalesOfficeResultsLineBase : BaseDbModel<SalesOfficeResultsLineBase, int>
    {
#region tableDefs

       public static List<EntityPropDef> GetPropDefs() {
         var result = new List<EntityPropDef>();

//EntityPropDef(string propName, string columnName, bool isKey, bool isNullable, string refEntityName, PropertyInfo keyPropInfo,
//            int size, int? prec, int? scale)



         result.Add(new EntityPropDef(
         PropertyHelper <SalesOfficeResultsLineBase>.GetProperty(x => x.Saloffno),
         "SALOFFNO", // columnName
         true,                    //isKey
         false, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  5, // int? prec
                           0  // int? Scale
         ,
         typeof(SalesOfficeResultsLineBase)
       ));


         result.Add(new EntityPropDef(
         PropertyHelper <SalesOfficeResultsLineBase>.GetProperty(x => x.Acccode),
         "ACCCODE", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         8,       // int size   
                  null, // int? prec
                   
         null // int? Scale
         ,
         typeof(SalesOfficeResultsLineBase)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <SalesOfficeResultsLineBase>.GetProperty(x => x.Accntsaloffno),
         "ACCNTSALOFFNO", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  5, // int? prec
                           0  // int? Scale
         ,
         typeof(SalesOfficeResultsLineBase)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <SalesOfficeResultsLineBase>.GetProperty(x => x.Agressocostcentreno),
         "AGRESSOCOSTCENTRENO", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         4,       // int size   
                  null, // int? prec
                   
         null // int? Scale
         ,
         typeof(SalesOfficeResultsLineBase)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <SalesOfficeResultsLineBase>.GetProperty(x => x.Bacsalias),
         "BACSALIAS", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         15,       // int size   
                  null, // int? prec
                   
         null // int? Scale
         ,
         typeof(SalesOfficeResultsLineBase)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <SalesOfficeResultsLineBase>.GetProperty(x => x.Banrecno),
         "BANRECNO", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  5, // int? prec
                           0  // int? Scale
         ,
         typeof(SalesOfficeResultsLineBase)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <SalesOfficeResultsLineBase>.GetProperty(x => x.Basecurno),
         "BASECURNO", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  5, // int? prec
                           0  // int? Scale
         ,
         typeof(SalesOfficeResultsLineBase)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <SalesOfficeResultsLineBase>.GetProperty(x => x.Businessunitcode),
         "BUSINESSUNITCODE", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         10,       // int size   
                  null, // int? prec
                   
         null // int? Scale
         ,
         typeof(SalesOfficeResultsLineBase)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <SalesOfficeResultsLineBase>.GetProperty(x => x.Cancchqemail),
         "CANCCHQEMAIL", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         50,       // int size   
                  null, // int? prec
                   
         null // int? Scale
         ,
         typeof(SalesOfficeResultsLineBase)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <SalesOfficeResultsLineBase>.GetProperty(x => x.Canpricetran),
         "CANPRICETRAN", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  1, // int? prec
                           0  // int? Scale
         ,
         typeof(SalesOfficeResultsLineBase)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <SalesOfficeResultsLineBase>.GetProperty(x => x.Canpurchtran),
         "CANPURCHTRAN", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  1, // int? prec
                           0  // int? Scale
         ,
         typeof(SalesOfficeResultsLineBase)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <SalesOfficeResultsLineBase>.GetProperty(x => x.Canrcvpo),
         "CANRCVPO", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  1, // int? prec
                           0  // int? Scale
         ,
         typeof(SalesOfficeResultsLineBase)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <SalesOfficeResultsLineBase>.GetProperty(x => x.Cashexportseqno),
         "CASHEXPORTSEQNO", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  10, // int? prec
                           0  // int? Scale
         ,
         typeof(SalesOfficeResultsLineBase)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <SalesOfficeResultsLineBase>.GetProperty(x => x.Cashtiknoofdaysdisp),
         "CASHTIKNOOFDAYSDISP", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  5, // int? prec
                           0  // int? Scale
         ,
         typeof(SalesOfficeResultsLineBase)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <SalesOfficeResultsLineBase>.GetProperty(x => x.Cdtsurchg),
         "CDTSURCHG", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  126, // int? prec
                   
         null // int? Scale
         ,
         typeof(SalesOfficeResultsLineBase)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <SalesOfficeResultsLineBase>.GetProperty(x => x.Closedayinuse),
         "CLOSEDAYINUSE", // columnName
         false,                    //isKey
         false, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  1, // int? prec
                           0  // int? Scale
         ,
         typeof(SalesOfficeResultsLineBase)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <SalesOfficeResultsLineBase>.GetProperty(x => x.Closedaysession),
         "CLOSEDAYSESSION", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  10, // int? prec
                           0  // int? Scale
         ,
         typeof(SalesOfficeResultsLineBase)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <SalesOfficeResultsLineBase>.GetProperty(x => x.Closedayusedby),
         "CLOSEDAYUSEDBY", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  5, // int? prec
                           0  // int? Scale
         ,
         typeof(SalesOfficeResultsLineBase)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <SalesOfficeResultsLineBase>.GetProperty(x => x.Compadd1),
         "COMPADD1", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         40,       // int size   
                  null, // int? prec
                   
         null // int? Scale
         ,
         typeof(SalesOfficeResultsLineBase)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <SalesOfficeResultsLineBase>.GetProperty(x => x.Compadd2),
         "COMPADD2", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         40,       // int size   
                  null, // int? prec
                   
         null // int? Scale
         ,
         typeof(SalesOfficeResultsLineBase)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <SalesOfficeResultsLineBase>.GetProperty(x => x.Compadd3),
         "COMPADD3", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         40,       // int size   
                  null, // int? prec
                   
         null // int? Scale
         ,
         typeof(SalesOfficeResultsLineBase)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <SalesOfficeResultsLineBase>.GetProperty(x => x.Compadd4),
         "COMPADD4", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         40,       // int size   
                  null, // int? prec
                   
         null // int? Scale
         ,
         typeof(SalesOfficeResultsLineBase)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <SalesOfficeResultsLineBase>.GetProperty(x => x.Companano),
         "COMPANANO", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         13,       // int size   
                  null, // int? prec
                   
         null // int? Scale
         ,
         typeof(SalesOfficeResultsLineBase)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <SalesOfficeResultsLineBase>.GetProperty(x => x.Companycode),
         "COMPANYCODE", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         15,       // int size   
                  null, // int? prec
                   
         null // int? Scale
         ,
         typeof(SalesOfficeResultsLineBase)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <SalesOfficeResultsLineBase>.GetProperty(x => x.Companyname),
         "COMPANYNAME", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         40,       // int size   
                  null, // int? prec
                   
         null // int? Scale
         ,
         typeof(SalesOfficeResultsLineBase)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <SalesOfficeResultsLineBase>.GetProperty(x => x.Compcmbinvstylnm),
         "COMPCMBINVSTYLNM", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         20,       // int size   
                  null, // int? prec
                   
         null // int? Scale
         ,
         typeof(SalesOfficeResultsLineBase)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <SalesOfficeResultsLineBase>.GetProperty(x => x.Compfax),
         "COMPFAX", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         15,       // int size   
                  null, // int? prec
                   
         null // int? Scale
         ,
         typeof(SalesOfficeResultsLineBase)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <SalesOfficeResultsLineBase>.GetProperty(x => x.Compinvstylnm),
         "COMPINVSTYLNM", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         20,       // int size   
                  null, // int? prec
                   
         null // int? Scale
         ,
         typeof(SalesOfficeResultsLineBase)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <SalesOfficeResultsLineBase>.GetProperty(x => x.Compphone),
         "COMPPHONE", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         15,       // int size   
                  null, // int? prec
                   
         null // int? Scale
         ,
         typeof(SalesOfficeResultsLineBase)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <SalesOfficeResultsLineBase>.GetProperty(x => x.Compvatno),
         "COMPVATNO", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         15,       // int size   
                  null, // int? prec
                   
         null // int? Scale
         ,
         typeof(SalesOfficeResultsLineBase)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <SalesOfficeResultsLineBase>.GetProperty(x => x.Compwww),
         "COMPWWW", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         50,       // int size   
                  null, // int? prec
                   
         null // int? Scale
         ,
         typeof(SalesOfficeResultsLineBase)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <SalesOfficeResultsLineBase>.GetProperty(x => x.Contactlogno),
         "CONTACTLOGNO", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  5, // int? prec
                           0  // int? Scale
         ,
         typeof(SalesOfficeResultsLineBase)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <SalesOfficeResultsLineBase>.GetProperty(x => x.Cshbookexppath),
         "CSHBOOKEXPPATH", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         255,       // int size   
                  null, // int? prec
                   
         null // int? Scale
         ,
         typeof(SalesOfficeResultsLineBase)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <SalesOfficeResultsLineBase>.GetProperty(x => x.Cshbookexppathbak),
         "CSHBOOKEXPPATHBAK", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         255,       // int size   
                  null, // int? prec
                   
         null // int? Scale
         ,
         typeof(SalesOfficeResultsLineBase)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <SalesOfficeResultsLineBase>.GetProperty(x => x.Cstclarecno),
         "CSTCLARECNO", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  10, // int? prec
                           0  // int? Scale
         ,
         typeof(SalesOfficeResultsLineBase)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <SalesOfficeResultsLineBase>.GetProperty(x => x.Ddinuse),
         "DDINUSE", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  1, // int? prec
                           0  // int? Scale
         ,
         typeof(SalesOfficeResultsLineBase)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <SalesOfficeResultsLineBase>.GetProperty(x => x.Ddinuseby),
         "DDINUSEBY", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  5, // int? prec
                           0  // int? Scale
         ,
         typeof(SalesOfficeResultsLineBase)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <SalesOfficeResultsLineBase>.GetProperty(x => x.Debtorexppath),
         "DEBTOREXPPATH", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         255,       // int size   
                  null, // int? prec
                   
         null // int? Scale
         ,
         typeof(SalesOfficeResultsLineBase)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <SalesOfficeResultsLineBase>.GetProperty(x => x.Debtorexppathbak),
         "DEBTOREXPPATHBAK", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         255,       // int size   
                  null, // int? prec
                   
         null // int? Scale
         ,
         typeof(SalesOfficeResultsLineBase)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <SalesOfficeResultsLineBase>.GetProperty(x => x.Defpaymenttype),
         "DEFPAYMENTTYPE", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  5, // int? prec
                           0  // int? Scale
         ,
         typeof(SalesOfficeResultsLineBase)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <SalesOfficeResultsLineBase>.GetProperty(x => x.Deliveryprtnm),
         "DELIVERYPRTNM", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         20,       // int size   
                  null, // int? prec
                   
         null // int? Scale
         ,
         typeof(SalesOfficeResultsLineBase)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <SalesOfficeResultsLineBase>.GetProperty(x => x.Deliveryweightprtnm),
         "DELIVERYWEIGHTPRTNM", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         20,       // int size   
                  null, // int? prec
                   
         null // int? Scale
         ,
         typeof(SalesOfficeResultsLineBase)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <SalesOfficeResultsLineBase>.GetProperty(x => x.Dgpextractinuse),
         "DGPEXTRACTINUSE", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  1, // int? prec
                           0  // int? Scale
         ,
         typeof(SalesOfficeResultsLineBase)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <SalesOfficeResultsLineBase>.GetProperty(x => x.Dgpextractinuseby),
         "DGPEXTRACTINUSEBY", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  5, // int? prec
                           0  // int? Scale
         ,
         typeof(SalesOfficeResultsLineBase)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <SalesOfficeResultsLineBase>.GetProperty(x => x.Eancode),
         "EANCODE", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         10,       // int size   
                  null, // int? prec
                   
         null // int? Scale
         ,
         typeof(SalesOfficeResultsLineBase)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <SalesOfficeResultsLineBase>.GetProperty(x => x.Fincono),
         "FINCONO", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         5,       // int size   
                  null, // int? prec
                   
         null // int? Scale
         ,
         typeof(SalesOfficeResultsLineBase)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <SalesOfficeResultsLineBase>.GetProperty(x => x.Finjournal),
         "FINJOURNAL", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         3,       // int size   
                  null, // int? prec
                   
         null // int? Scale
         ,
         typeof(SalesOfficeResultsLineBase)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <SalesOfficeResultsLineBase>.GetProperty(x => x.Finoutputdir),
         "FINOUTPUTDIR", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         35,       // int size   
                  null, // int? prec
                   
         null // int? Scale
         ,
         typeof(SalesOfficeResultsLineBase)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <SalesOfficeResultsLineBase>.GetProperty(x => x.Fyfbusunitcono),
         "FYFBUSUNITCONO", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  5, // int? prec
                           0  // int? Scale
         ,
         typeof(SalesOfficeResultsLineBase)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <SalesOfficeResultsLineBase>.GetProperty(x => x.Gldbkinuse),
         "GLDBKINUSE", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  1, // int? prec
                           0  // int? Scale
         ,
         typeof(SalesOfficeResultsLineBase)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <SalesOfficeResultsLineBase>.GetProperty(x => x.Gldbkusedby),
         "GLDBKUSEDBY", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  5, // int? prec
                           0  // int? Scale
         ,
         typeof(SalesOfficeResultsLineBase)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <SalesOfficeResultsLineBase>.GetProperty(x => x.Imagefilename),
         "IMAGEFILENAME", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         20,       // int size   
                  null, // int? prec
                   
         null // int? Scale
         ,
         typeof(SalesOfficeResultsLineBase)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <SalesOfficeResultsLineBase>.GetProperty(x => x.Intcomchgdbkinuse),
         "INTCOMCHGDBKINUSE", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  1, // int? prec
                           0  // int? Scale
         ,
         typeof(SalesOfficeResultsLineBase)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <SalesOfficeResultsLineBase>.GetProperty(x => x.Intcomtraninuseby),
         "INTCOMTRANINUSEBY", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  5, // int? prec
                           0  // int? Scale
         ,
         typeof(SalesOfficeResultsLineBase)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <SalesOfficeResultsLineBase>.GetProperty(x => x.Intrastatbranchid),
         "INTRASTATBRANCHID", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         3,       // int size   
                  null, // int? prec
                   
         null // int? Scale
         ,
         typeof(SalesOfficeResultsLineBase)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <SalesOfficeResultsLineBase>.GetProperty(x => x.Inuse),
         "INUSE", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  1, // int? prec
                           0  // int? Scale
         ,
         typeof(SalesOfficeResultsLineBase)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <SalesOfficeResultsLineBase>.GetProperty(x => x.Invsessionno),
         "INVSESSIONNO", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  10, // int? prec
                           0  // int? Scale
         ,
         typeof(SalesOfficeResultsLineBase)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <SalesOfficeResultsLineBase>.GetProperty(x => x.Lastbatchno),
         "LASTBATCHNO", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  10, // int? prec
                           0  // int? Scale
         ,
         typeof(SalesOfficeResultsLineBase)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <SalesOfficeResultsLineBase>.GetProperty(x => x.Lastcdtbatchno),
         "LASTCDTBATCHNO", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  10, // int? prec
                           0  // int? Scale
         ,
         typeof(SalesOfficeResultsLineBase)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <SalesOfficeResultsLineBase>.GetProperty(x => x.Lastdbtbatchno),
         "LASTDBTBATCHNO", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  10, // int? prec
                           0  // int? Scale
         ,
         typeof(SalesOfficeResultsLineBase)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <SalesOfficeResultsLineBase>.GetProperty(x => x.Lastinvbatchno),
         "LASTINVBATCHNO", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  10, // int? prec
                           0  // int? Scale
         ,
         typeof(SalesOfficeResultsLineBase)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <SalesOfficeResultsLineBase>.GetProperty(x => x.Lastmancdtbatchno),
         "LASTMANCDTBATCHNO", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  10, // int? prec
                           0  // int? Scale
         ,
         typeof(SalesOfficeResultsLineBase)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <SalesOfficeResultsLineBase>.GetProperty(x => x.Lastmaninvbatchno),
         "LASTMANINVBATCHNO", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  10, // int? prec
                           0  // int? Scale
         ,
         typeof(SalesOfficeResultsLineBase)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <SalesOfficeResultsLineBase>.GetProperty(x => x.Lastpreinvupdateok),
         "LASTPREINVUPDATEOK", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  1, // int? prec
                           0  // int? Scale
         ,
         typeof(SalesOfficeResultsLineBase)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <SalesOfficeResultsLineBase>.GetProperty(x => x.Lmtontradstcksel),
         "LMTONTRADSTCKSEL", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  1, // int? prec
                           0  // int? Scale
         ,
         typeof(SalesOfficeResultsLineBase)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <SalesOfficeResultsLineBase>.GetProperty(x => x.Lotprofitdisp),
         "LOTPROFITDISP", // columnName
         false,                    //isKey
         false, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  5, // int? prec
                           0  // int? Scale
         ,
         typeof(SalesOfficeResultsLineBase)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <SalesOfficeResultsLineBase>.GetProperty(x => x.Lotprofitmeth),
         "LOTPROFITMETH", // columnName
         false,                    //isKey
         false, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  5, // int? prec
                           0  // int? Scale
         ,
         typeof(SalesOfficeResultsLineBase)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <SalesOfficeResultsLineBase>.GetProperty(x => x.Lstgldbkno),
         "LSTGLDBKNO", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  10, // int? prec
                           0  // int? Scale
         ,
         typeof(SalesOfficeResultsLineBase)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <SalesOfficeResultsLineBase>.GetProperty(x => x.Lstintcomchgdbkno),
         "LSTINTCOMCHGDBKNO", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  10, // int? prec
                           0  // int? Scale
         ,
         typeof(SalesOfficeResultsLineBase)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <SalesOfficeResultsLineBase>.GetProperty(x => x.Lstmktbatchno),
         "LSTMKTBATCHNO", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  10, // int? prec
                           0  // int? Scale
         ,
         typeof(SalesOfficeResultsLineBase)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <SalesOfficeResultsLineBase>.GetProperty(x => x.Lstpldbkno),
         "LSTPLDBKNO", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  10, // int? prec
                           0  // int? Scale
         ,
         typeof(SalesOfficeResultsLineBase)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <SalesOfficeResultsLineBase>.GetProperty(x => x.Lstporecovdbkno),
         "LSTPORECOVDBKNO", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  10, // int? prec
                           0  // int? Scale
         ,
         typeof(SalesOfficeResultsLineBase)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <SalesOfficeResultsLineBase>.GetProperty(x => x.Lstprechgdbkno),
         "LSTPRECHGDBKNO", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  10, // int? prec
                           0  // int? Scale
         ,
         typeof(SalesOfficeResultsLineBase)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <SalesOfficeResultsLineBase>.GetProperty(x => x.Lstprepdbkno),
         "LSTPREPDBKNO", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  10, // int? prec
                           0  // int? Scale
         ,
         typeof(SalesOfficeResultsLineBase)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <SalesOfficeResultsLineBase>.GetProperty(x => x.Lstsalaudrecno),
         "LSTSALAUDRECNO", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  10, // int? prec
                           0  // int? Scale
         ,
         typeof(SalesOfficeResultsLineBase)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <SalesOfficeResultsLineBase>.GetProperty(x => x.Lstsldbkno),
         "LSTSLDBKNO", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  10, // int? prec
                           0  // int? Scale
         ,
         typeof(SalesOfficeResultsLineBase)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <SalesOfficeResultsLineBase>.GetProperty(x => x.Lsttshprpkdbkno),
         "LSTTSHPRPKDBKNO", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  10, // int? prec
                           0  // int? Scale
         ,
         typeof(SalesOfficeResultsLineBase)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <SalesOfficeResultsLineBase>.GetProperty(x => x.Lstvatdbkno),
         "LSTVATDBKNO", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  10, // int? prec
                           0  // int? Scale
         ,
         typeof(SalesOfficeResultsLineBase)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <SalesOfficeResultsLineBase>.GetProperty(x => x.Lstwhtaxdbkno),
         "LSTWHTAXDBKNO", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  10, // int? prec
                           0  // int? Scale
         ,
         typeof(SalesOfficeResultsLineBase)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <SalesOfficeResultsLineBase>.GetProperty(x => x.Lusercvdqtyforacr),
         "LUSERCVDQTYFORACR", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  1, // int? prec
                           0  // int? Scale
         ,
         typeof(SalesOfficeResultsLineBase)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <SalesOfficeResultsLineBase>.GetProperty(x => x.Marketordentautoinvprt),
         "MARKETORDENTAUTOINVPRT", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  1, // int? prec
                           0  // int? Scale
         ,
         typeof(SalesOfficeResultsLineBase)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <SalesOfficeResultsLineBase>.GetProperty(x => x.Marketordentcashupdate),
         "MARKETORDENTCASHUPDATE", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  1, // int? prec
                           0  // int? Scale
         ,
         typeof(SalesOfficeResultsLineBase)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <SalesOfficeResultsLineBase>.GetProperty(x => x.Mktsalessettodlv),
         "MKTSALESSETTODLV", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  1, // int? prec
                           0  // int? Scale
         ,
         typeof(SalesOfficeResultsLineBase)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <SalesOfficeResultsLineBase>.GetProperty(x => x.Nextcdtnoteno),
         "NEXTCDTNOTENO", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  10, // int? prec
                           0  // int? Scale
         ,
         typeof(SalesOfficeResultsLineBase)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <SalesOfficeResultsLineBase>.GetProperty(x => x.Nextinvoiceno),
         "NEXTINVOICENO", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  10, // int? prec
                           0  // int? Scale
         ,
         typeof(SalesOfficeResultsLineBase)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <SalesOfficeResultsLineBase>.GetProperty(x => x.Novatforsaloff),
         "NOVATFORSALOFF", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  1, // int? prec
                           0  // int? Scale
         ,
         typeof(SalesOfficeResultsLineBase)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <SalesOfficeResultsLineBase>.GetProperty(x => x.Nxtdailycreditno),
         "NXTDAILYCREDITNO", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  10, // int? prec
                           0  // int? Scale
         ,
         typeof(SalesOfficeResultsLineBase)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <SalesOfficeResultsLineBase>.GetProperty(x => x.Nxtdailyinvoiceno),
         "NXTDAILYINVOICENO", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  10, // int? prec
                           0  // int? Scale
         ,
         typeof(SalesOfficeResultsLineBase)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <SalesOfficeResultsLineBase>.GetProperty(x => x.Nxtquickinvno),
         "NXTQUICKINVNO", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  10, // int? prec
                           0  // int? Scale
         ,
         typeof(SalesOfficeResultsLineBase)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <SalesOfficeResultsLineBase>.GetProperty(x => x.Nxtservinvno),
         "NXTSERVINVNO", // columnName
         false,                    //isKey
         false, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  10, // int? prec
                           0  // int? Scale
         ,
         typeof(SalesOfficeResultsLineBase)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <SalesOfficeResultsLineBase>.GetProperty(x => x.Paymentsetupinuse),
         "PAYMENTSETUPINUSE", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  1, // int? prec
                           0  // int? Scale
         ,
         typeof(SalesOfficeResultsLineBase)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <SalesOfficeResultsLineBase>.GetProperty(x => x.Paymentsetupinusebylogon),
         "PAYMENTSETUPINUSEBYLOGON", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  10, // int? prec
                           0  // int? Scale
         ,
         typeof(SalesOfficeResultsLineBase)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <SalesOfficeResultsLineBase>.GetProperty(x => x.Paymentsetupinusebysess),
         "PAYMENTSETUPINUSEBYSESS", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  10, // int? prec
                           0  // int? Scale
         ,
         typeof(SalesOfficeResultsLineBase)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <SalesOfficeResultsLineBase>.GetProperty(x => x.Paymentsetupinuselocktime),
         "PAYMENTSETUPINUSELOCKTIME", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  null, // int? prec
                   
         null // int? Scale
         ,
         typeof(SalesOfficeResultsLineBase)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <SalesOfficeResultsLineBase>.GetProperty(x => x.Pickfifoprtnm),
         "PICKFIFOPRTNM", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         20,       // int size   
                  null, // int? prec
                   
         null // int? Scale
         ,
         typeof(SalesOfficeResultsLineBase)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <SalesOfficeResultsLineBase>.GetProperty(x => x.Picknonfifoprtnm),
         "PICKNONFIFOPRTNM", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         20,       // int size   
                  null, // int? prec
                   
         null // int? Scale
         ,
         typeof(SalesOfficeResultsLineBase)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <SalesOfficeResultsLineBase>.GetProperty(x => x.Pickprtnm),
         "PICKPRTNM", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         20,       // int size   
                  null, // int? prec
                   
         null // int? Scale
         ,
         typeof(SalesOfficeResultsLineBase)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <SalesOfficeResultsLineBase>.GetProperty(x => x.Pldbkinuse),
         "PLDBKINUSE", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  1, // int? prec
                           0  // int? Scale
         ,
         typeof(SalesOfficeResultsLineBase)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <SalesOfficeResultsLineBase>.GetProperty(x => x.Pldbkusedby),
         "PLDBKUSEDBY", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  5, // int? prec
                           0  // int? Scale
         ,
         typeof(SalesOfficeResultsLineBase)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <SalesOfficeResultsLineBase>.GetProperty(x => x.Porecovdbkinuse),
         "PORECOVDBKINUSE", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  1, // int? prec
                           0  // int? Scale
         ,
         typeof(SalesOfficeResultsLineBase)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <SalesOfficeResultsLineBase>.GetProperty(x => x.Porecovdbkusedby),
         "PORECOVDBKUSEDBY", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  5, // int? prec
                           0  // int? Scale
         ,
         typeof(SalesOfficeResultsLineBase)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <SalesOfficeResultsLineBase>.GetProperty(x => x.Postcode),
         "POSTCODE", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         9,       // int size   
                  null, // int? prec
                   
         null // int? Scale
         ,
         typeof(SalesOfficeResultsLineBase)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <SalesOfficeResultsLineBase>.GetProperty(x => x.Prechgdbkinuse),
         "PRECHGDBKINUSE", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  1, // int? prec
                           0  // int? Scale
         ,
         typeof(SalesOfficeResultsLineBase)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <SalesOfficeResultsLineBase>.GetProperty(x => x.Prechgdbkusedby),
         "PRECHGDBKUSEDBY", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  5, // int? prec
                           0  // int? Scale
         ,
         typeof(SalesOfficeResultsLineBase)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <SalesOfficeResultsLineBase>.GetProperty(x => x.Prepdbkinuse),
         "PREPDBKINUSE", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  1, // int? prec
                           0  // int? Scale
         ,
         typeof(SalesOfficeResultsLineBase)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <SalesOfficeResultsLineBase>.GetProperty(x => x.Prepdbkusedby),
         "PREPDBKUSEDBY", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  5, // int? prec
                           0  // int? Scale
         ,
         typeof(SalesOfficeResultsLineBase)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <SalesOfficeResultsLineBase>.GetProperty(x => x.Purinvauthappbox),
         "PURINVAUTHAPPBOX", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  1, // int? prec
                           0  // int? Scale
         ,
         typeof(SalesOfficeResultsLineBase)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <SalesOfficeResultsLineBase>.GetProperty(x => x.Salbusunitrecno),
         "SALBUSUNITRECNO", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  5, // int? prec
                           0  // int? Scale
         ,
         typeof(SalesOfficeResultsLineBase)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <SalesOfficeResultsLineBase>.GetProperty(x => x.Saloffcode),
         "SALOFFCODE", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         4,       // int size   
                  null, // int? prec
                   
         null // int? Scale
         ,
         typeof(SalesOfficeResultsLineBase)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <SalesOfficeResultsLineBase>.GetProperty(x => x.Saloffddfileno),
         "SALOFFDDFILENO", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  10, // int? prec
                           0  // int? Scale
         ,
         typeof(SalesOfficeResultsLineBase)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <SalesOfficeResultsLineBase>.GetProperty(x => x.Saloffdesc),
         "SALOFFDESC", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         16,       // int size   
                  null, // int? prec
                   
         null // int? Scale
         ,
         typeof(SalesOfficeResultsLineBase)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <SalesOfficeResultsLineBase>.GetProperty(x => x.Sepinvno),
         "SEPINVNO", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  1, // int? prec
                           0  // int? Scale
         ,
         typeof(SalesOfficeResultsLineBase)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <SalesOfficeResultsLineBase>.GetProperty(x => x.Servinvinuse),
         "SERVINVINUSE", // columnName
         false,                    //isKey
         false, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  1, // int? prec
                           0  // int? Scale
         ,
         typeof(SalesOfficeResultsLineBase)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <SalesOfficeResultsLineBase>.GetProperty(x => x.Servinvlogonno),
         "SERVINVLOGONNO", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  5, // int? prec
                           0  // int? Scale
         ,
         typeof(SalesOfficeResultsLineBase)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <SalesOfficeResultsLineBase>.GetProperty(x => x.Servinvsession),
         "SERVINVSESSION", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  10, // int? prec
                           0  // int? Scale
         ,
         typeof(SalesOfficeResultsLineBase)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <SalesOfficeResultsLineBase>.GetProperty(x => x.Singlecomlots),
         "SINGLECOMLOTS", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  1, // int? prec
                           0  // int? Scale
         ,
         typeof(SalesOfficeResultsLineBase)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <SalesOfficeResultsLineBase>.GetProperty(x => x.Sldbkinuse),
         "SLDBKINUSE", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  1, // int? prec
                           0  // int? Scale
         ,
         typeof(SalesOfficeResultsLineBase)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <SalesOfficeResultsLineBase>.GetProperty(x => x.Sldbkusedby),
         "SLDBKUSEDBY", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  5, // int? prec
                           0  // int? Scale
         ,
         typeof(SalesOfficeResultsLineBase)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <SalesOfficeResultsLineBase>.GetProperty(x => x.Smnoncashdesk),
         "SMNONCASHDESK", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  1, // int? prec
                           0  // int? Scale
         ,
         typeof(SalesOfficeResultsLineBase)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <SalesOfficeResultsLineBase>.GetProperty(x => x.StkdissUseextractdt),
         "STKDISS_USEEXTRACTDT", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  1, // int? prec
                           0  // int? Scale
         ,
         typeof(SalesOfficeResultsLineBase)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <SalesOfficeResultsLineBase>.GetProperty(x => x.Supclarecno),
         "SUPCLARECNO", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  10, // int? prec
                           0  // int? Scale
         ,
         typeof(SalesOfficeResultsLineBase)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <SalesOfficeResultsLineBase>.GetProperty(x => x.Supforoversoldstock),
         "SUPFOROVERSOLDSTOCK", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  10, // int? prec
                           0  // int? Scale
         ,
         typeof(SalesOfficeResultsLineBase)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <SalesOfficeResultsLineBase>.GetProperty(x => x.Taxdatebfdlvdate),
         "TAXDATEBFDLVDATE", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  1, // int? prec
                           0  // int? Scale
         ,
         typeof(SalesOfficeResultsLineBase)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <SalesOfficeResultsLineBase>.GetProperty(x => x.TktAllowprcchgaftstkdiss),
         "TKT_ALLOWPRCCHGAFTSTKDISS", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  1, // int? prec
                           0  // int? Scale
         ,
         typeof(SalesOfficeResultsLineBase)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <SalesOfficeResultsLineBase>.GetProperty(x => x.Tktbkmaxno),
         "TKTBKMAXNO", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  10, // int? prec
                           0  // int? Scale
         ,
         typeof(SalesOfficeResultsLineBase)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <SalesOfficeResultsLineBase>.GetProperty(x => x.Tktbkoffset),
         "TKTBKOFFSET", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  10, // int? prec
                           0  // int? Scale
         ,
         typeof(SalesOfficeResultsLineBase)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <SalesOfficeResultsLineBase>.GetProperty(x => x.Tktbksize),
         "TKTBKSIZE", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  10, // int? prec
                           0  // int? Scale
         ,
         typeof(SalesOfficeResultsLineBase)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <SalesOfficeResultsLineBase>.GetProperty(x => x.Tktcashacc),
         "TKTCASHACC", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  10, // int? prec
                           0  // int? Scale
         ,
         typeof(SalesOfficeResultsLineBase)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <SalesOfficeResultsLineBase>.GetProperty(x => x.TktcashaccComm),
         "TKTCASHACC_COMM", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  1, // int? prec
                           0  // int? Scale
         ,
         typeof(SalesOfficeResultsLineBase)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <SalesOfficeResultsLineBase>.GetProperty(x => x.TktcashaccDonthash),
         "TKTCASHACC_DONTHASH", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  1, // int? prec
                           0  // int? Scale
         ,
         typeof(SalesOfficeResultsLineBase)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <SalesOfficeResultsLineBase>.GetProperty(x => x.TktfocreasMand),
         "TKTFOCREAS_MAND", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  1, // int? prec
                           0  // int? Scale
         ,
         typeof(SalesOfficeResultsLineBase)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <SalesOfficeResultsLineBase>.GetProperty(x => x.TkthashtotsMand),
         "TKTHASHTOTS_MAND", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  1, // int? prec
                           0  // int? Scale
         ,
         typeof(SalesOfficeResultsLineBase)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <SalesOfficeResultsLineBase>.GetProperty(x => x.Tktsaleagstnostk),
         "TKTSALEAGSTNOSTK", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  1, // int? prec
                           0  // int? Scale
         ,
         typeof(SalesOfficeResultsLineBase)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <SalesOfficeResultsLineBase>.GetProperty(x => x.Tktwarnofoversell),
         "TKTWARNOFOVERSELL", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  1, // int? prec
                           0  // int? Scale
         ,
         typeof(SalesOfficeResultsLineBase)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <SalesOfficeResultsLineBase>.GetProperty(x => x.Tshprpkdbkinuse),
         "TSHPRPKDBKINUSE", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  1, // int? prec
                           0  // int? Scale
         ,
         typeof(SalesOfficeResultsLineBase)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <SalesOfficeResultsLineBase>.GetProperty(x => x.Tshprpkdbkusedby),
         "TSHPRPKDBKUSEDBY", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  5, // int? prec
                           0  // int? Scale
         ,
         typeof(SalesOfficeResultsLineBase)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <SalesOfficeResultsLineBase>.GetProperty(x => x.Useaddauth),
         "USEADDAUTH", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  1, // int? prec
                           0  // int? Scale
         ,
         typeof(SalesOfficeResultsLineBase)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <SalesOfficeResultsLineBase>.GetProperty(x => x.Usedby),
         "USEDBY", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  5, // int? prec
                           0  // int? Scale
         ,
         typeof(SalesOfficeResultsLineBase)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <SalesOfficeResultsLineBase>.GetProperty(x => x.Usemaninvasmansalentry),
         "USEMANINVASMANSALENTRY", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  1, // int? prec
                           0  // int? Scale
         ,
         typeof(SalesOfficeResultsLineBase)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <SalesOfficeResultsLineBase>.GetProperty(x => x.Useseqinvnos),
         "USESEQINVNOS", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  1, // int? prec
                           0  // int? Scale
         ,
         typeof(SalesOfficeResultsLineBase)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <SalesOfficeResultsLineBase>.GetProperty(x => x.Usetktnumforstkswap),
         "USETKTNUMFORSTKSWAP", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  1, // int? prec
                           0  // int? Scale
         ,
         typeof(SalesOfficeResultsLineBase)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <SalesOfficeResultsLineBase>.GetProperty(x => x.Vatdbkinuse),
         "VATDBKINUSE", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  1, // int? prec
                           0  // int? Scale
         ,
         typeof(SalesOfficeResultsLineBase)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <SalesOfficeResultsLineBase>.GetProperty(x => x.Vatdbkusedby),
         "VATDBKUSEDBY", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  5, // int? prec
                           0  // int? Scale
         ,
         typeof(SalesOfficeResultsLineBase)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <SalesOfficeResultsLineBase>.GetProperty(x => x.Whtaxdbkinuse),
         "WHTAXDBKINUSE", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  1, // int? prec
                           0  // int? Scale
         ,
         typeof(SalesOfficeResultsLineBase)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <SalesOfficeResultsLineBase>.GetProperty(x => x.Whtaxdbkusedby),
         "WHTAXDBKUSEDBY", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  5, // int? prec
                           0  // int? Scale
         ,
         typeof(SalesOfficeResultsLineBase)
         ));
         return result; 
       }

#endregion     
        private int _fSaloffno;
        public int Saloffno
        {
            get { return _fSaloffno; }
            set
            {
                var oldKey = Key;
                if (_fSaloffno != value)
                {
                    Modify();
                    _fSaloffno = value;
                    KeyChanged(oldKey);
                }
            }
        }

        private string _fAcccode;
        public string Acccode
        {
            get { return _fAcccode; }
            set
            {
                if (_fAcccode != value)
                {
                    Modify();
                    _fAcccode = value;
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

        private string _fAgressocostcentreno;
        public string Agressocostcentreno
        {
            get { return _fAgressocostcentreno; }
            set
            {
                if (_fAgressocostcentreno != value)
                {
                    Modify();
                    _fAgressocostcentreno = value;
                }
            }
        }

        private string _fBacsalias;
        public string Bacsalias
        {
            get { return _fBacsalias; }
            set
            {
                if (_fBacsalias != value)
                {
                    Modify();
                    _fBacsalias = value;
                }
            }
        }

        private int? _fBanrecno;
        public int? Banrecno
        {
            get { return _fBanrecno; }
            set
            {
                if (_fBanrecno != value)
                {
                    Modify();
                    _fBanrecno = value;
                }
            }
        }

        private int? _fBasecurno;
        public int? Basecurno
        {
            get { return _fBasecurno; }
            set
            {
                if (_fBasecurno != value)
                {
                    Modify();
                    _fBasecurno = value;
                }
            }
        }

        private string _fBusinessunitcode;
        public string Businessunitcode
        {
            get { return _fBusinessunitcode; }
            set
            {
                if (_fBusinessunitcode != value)
                {
                    Modify();
                    _fBusinessunitcode = value;
                }
            }
        }

        private string _fCancchqemail;
        public string Cancchqemail
        {
            get { return _fCancchqemail; }
            set
            {
                if (_fCancchqemail != value)
                {
                    Modify();
                    _fCancchqemail = value;
                }
            }
        }

        private short? _fCanpricetran;
        public short? Canpricetran
        {
            get { return _fCanpricetran; }
            set
            {
                if (_fCanpricetran != value)
                {
                    Modify();
                    _fCanpricetran = value;
                }
            }
        }

        private short? _fCanpurchtran;
        public short? Canpurchtran
        {
            get { return _fCanpurchtran; }
            set
            {
                if (_fCanpurchtran != value)
                {
                    Modify();
                    _fCanpurchtran = value;
                }
            }
        }

        private short? _fCanrcvpo;
        public short? Canrcvpo
        {
            get { return _fCanrcvpo; }
            set
            {
                if (_fCanrcvpo != value)
                {
                    Modify();
                    _fCanrcvpo = value;
                }
            }
        }

        private int? _fCashexportseqno;
        public int? Cashexportseqno
        {
            get { return _fCashexportseqno; }
            set
            {
                if (_fCashexportseqno != value)
                {
                    Modify();
                    _fCashexportseqno = value;
                }
            }
        }

        private int? _fCashtiknoofdaysdisp;
        public int? Cashtiknoofdaysdisp
        {
            get { return _fCashtiknoofdaysdisp; }
            set
            {
                if (_fCashtiknoofdaysdisp != value)
                {
                    Modify();
                    _fCashtiknoofdaysdisp = value;
                }
            }
        }

        private decimal? _fCdtsurchg;
        public decimal? Cdtsurchg
        {
            get { return _fCdtsurchg; }
            set
            {
                if (_fCdtsurchg != value)
                {
                    Modify();
                    _fCdtsurchg = value;
                }
            }
        }

        private short _fClosedayinuse;
        public short Closedayinuse
        {
            get { return _fClosedayinuse; }
            set
            {
                if (_fClosedayinuse != value)
                {
                    Modify();
                    _fClosedayinuse = value;
                }
            }
        }

        private int? _fClosedaysession;
        public int? Closedaysession
        {
            get { return _fClosedaysession; }
            set
            {
                if (_fClosedaysession != value)
                {
                    Modify();
                    _fClosedaysession = value;
                }
            }
        }

        private int? _fClosedayusedby;
        public int? Closedayusedby
        {
            get { return _fClosedayusedby; }
            set
            {
                if (_fClosedayusedby != value)
                {
                    Modify();
                    _fClosedayusedby = value;
                }
            }
        }

        private string _fCompadd1;
        public string Compadd1
        {
            get { return _fCompadd1; }
            set
            {
                if (_fCompadd1 != value)
                {
                    Modify();
                    _fCompadd1 = value;
                }
            }
        }

        private string _fCompadd2;
        public string Compadd2
        {
            get { return _fCompadd2; }
            set
            {
                if (_fCompadd2 != value)
                {
                    Modify();
                    _fCompadd2 = value;
                }
            }
        }

        private string _fCompadd3;
        public string Compadd3
        {
            get { return _fCompadd3; }
            set
            {
                if (_fCompadd3 != value)
                {
                    Modify();
                    _fCompadd3 = value;
                }
            }
        }

        private string _fCompadd4;
        public string Compadd4
        {
            get { return _fCompadd4; }
            set
            {
                if (_fCompadd4 != value)
                {
                    Modify();
                    _fCompadd4 = value;
                }
            }
        }

        private string _fCompanano;
        public string Companano
        {
            get { return _fCompanano; }
            set
            {
                if (_fCompanano != value)
                {
                    Modify();
                    _fCompanano = value;
                }
            }
        }

        private string _fCompanycode;
        public string Companycode
        {
            get { return _fCompanycode; }
            set
            {
                if (_fCompanycode != value)
                {
                    Modify();
                    _fCompanycode = value;
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

        private string _fCompcmbinvstylnm;
        public string Compcmbinvstylnm
        {
            get { return _fCompcmbinvstylnm; }
            set
            {
                if (_fCompcmbinvstylnm != value)
                {
                    Modify();
                    _fCompcmbinvstylnm = value;
                }
            }
        }

        private string _fCompfax;
        public string Compfax
        {
            get { return _fCompfax; }
            set
            {
                if (_fCompfax != value)
                {
                    Modify();
                    _fCompfax = value;
                }
            }
        }

        private string _fCompinvstylnm;
        public string Compinvstylnm
        {
            get { return _fCompinvstylnm; }
            set
            {
                if (_fCompinvstylnm != value)
                {
                    Modify();
                    _fCompinvstylnm = value;
                }
            }
        }

        private string _fCompphone;
        public string Compphone
        {
            get { return _fCompphone; }
            set
            {
                if (_fCompphone != value)
                {
                    Modify();
                    _fCompphone = value;
                }
            }
        }

        private string _fCompvatno;
        public string Compvatno
        {
            get { return _fCompvatno; }
            set
            {
                if (_fCompvatno != value)
                {
                    Modify();
                    _fCompvatno = value;
                }
            }
        }

        private string _fCompwww;
        public string Compwww
        {
            get { return _fCompwww; }
            set
            {
                if (_fCompwww != value)
                {
                    Modify();
                    _fCompwww = value;
                }
            }
        }

        private int? _fContactlogno;
        public int? Contactlogno
        {
            get { return _fContactlogno; }
            set
            {
                if (_fContactlogno != value)
                {
                    Modify();
                    _fContactlogno = value;
                }
            }
        }

        private string _fCshbookexppath;
        public string Cshbookexppath
        {
            get { return _fCshbookexppath; }
            set
            {
                if (_fCshbookexppath != value)
                {
                    Modify();
                    _fCshbookexppath = value;
                }
            }
        }

        private string _fCshbookexppathbak;
        public string Cshbookexppathbak
        {
            get { return _fCshbookexppathbak; }
            set
            {
                if (_fCshbookexppathbak != value)
                {
                    Modify();
                    _fCshbookexppathbak = value;
                }
            }
        }

        private int? _fCstclarecno;
        public int? Cstclarecno
        {
            get { return _fCstclarecno; }
            set
            {
                if (_fCstclarecno != value)
                {
                    Modify();
                    _fCstclarecno = value;
                }
            }
        }

        private short? _fDdinuse;
        public short? Ddinuse
        {
            get { return _fDdinuse; }
            set
            {
                if (_fDdinuse != value)
                {
                    Modify();
                    _fDdinuse = value;
                }
            }
        }

        private int? _fDdinuseby;
        public int? Ddinuseby
        {
            get { return _fDdinuseby; }
            set
            {
                if (_fDdinuseby != value)
                {
                    Modify();
                    _fDdinuseby = value;
                }
            }
        }

        private string _fDebtorexppath;
        public string Debtorexppath
        {
            get { return _fDebtorexppath; }
            set
            {
                if (_fDebtorexppath != value)
                {
                    Modify();
                    _fDebtorexppath = value;
                }
            }
        }

        private string _fDebtorexppathbak;
        public string Debtorexppathbak
        {
            get { return _fDebtorexppathbak; }
            set
            {
                if (_fDebtorexppathbak != value)
                {
                    Modify();
                    _fDebtorexppathbak = value;
                }
            }
        }

        private int? _fDefpaymenttype;
        public int? Defpaymenttype
        {
            get { return _fDefpaymenttype; }
            set
            {
                if (_fDefpaymenttype != value)
                {
                    Modify();
                    _fDefpaymenttype = value;
                }
            }
        }

        private string _fDeliveryprtnm;
        public string Deliveryprtnm
        {
            get { return _fDeliveryprtnm; }
            set
            {
                if (_fDeliveryprtnm != value)
                {
                    Modify();
                    _fDeliveryprtnm = value;
                }
            }
        }

        private string _fDeliveryweightprtnm;
        public string Deliveryweightprtnm
        {
            get { return _fDeliveryweightprtnm; }
            set
            {
                if (_fDeliveryweightprtnm != value)
                {
                    Modify();
                    _fDeliveryweightprtnm = value;
                }
            }
        }

        private short? _fDgpextractinuse;
        public short? Dgpextractinuse
        {
            get { return _fDgpextractinuse; }
            set
            {
                if (_fDgpextractinuse != value)
                {
                    Modify();
                    _fDgpextractinuse = value;
                }
            }
        }

        private int? _fDgpextractinuseby;
        public int? Dgpextractinuseby
        {
            get { return _fDgpextractinuseby; }
            set
            {
                if (_fDgpextractinuseby != value)
                {
                    Modify();
                    _fDgpextractinuseby = value;
                }
            }
        }

        private string _fEancode;
        public string Eancode
        {
            get { return _fEancode; }
            set
            {
                if (_fEancode != value)
                {
                    Modify();
                    _fEancode = value;
                }
            }
        }

        private string _fFincono;
        public string Fincono
        {
            get { return _fFincono; }
            set
            {
                if (_fFincono != value)
                {
                    Modify();
                    _fFincono = value;
                }
            }
        }

        private string _fFinjournal;
        public string Finjournal
        {
            get { return _fFinjournal; }
            set
            {
                if (_fFinjournal != value)
                {
                    Modify();
                    _fFinjournal = value;
                }
            }
        }

        private string _fFinoutputdir;
        public string Finoutputdir
        {
            get { return _fFinoutputdir; }
            set
            {
                if (_fFinoutputdir != value)
                {
                    Modify();
                    _fFinoutputdir = value;
                }
            }
        }

        private int? _fFyfbusunitcono;
        public int? Fyfbusunitcono
        {
            get { return _fFyfbusunitcono; }
            set
            {
                if (_fFyfbusunitcono != value)
                {
                    Modify();
                    _fFyfbusunitcono = value;
                }
            }
        }

        private short? _fGldbkinuse;
        public short? Gldbkinuse
        {
            get { return _fGldbkinuse; }
            set
            {
                if (_fGldbkinuse != value)
                {
                    Modify();
                    _fGldbkinuse = value;
                }
            }
        }

        private int? _fGldbkusedby;
        public int? Gldbkusedby
        {
            get { return _fGldbkusedby; }
            set
            {
                if (_fGldbkusedby != value)
                {
                    Modify();
                    _fGldbkusedby = value;
                }
            }
        }

        private string _fImagefilename;
        public string Imagefilename
        {
            get { return _fImagefilename; }
            set
            {
                if (_fImagefilename != value)
                {
                    Modify();
                    _fImagefilename = value;
                }
            }
        }

        private short? _fIntcomchgdbkinuse;
        public short? Intcomchgdbkinuse
        {
            get { return _fIntcomchgdbkinuse; }
            set
            {
                if (_fIntcomchgdbkinuse != value)
                {
                    Modify();
                    _fIntcomchgdbkinuse = value;
                }
            }
        }

        private int? _fIntcomtraninuseby;
        public int? Intcomtraninuseby
        {
            get { return _fIntcomtraninuseby; }
            set
            {
                if (_fIntcomtraninuseby != value)
                {
                    Modify();
                    _fIntcomtraninuseby = value;
                }
            }
        }

        private string _fIntrastatbranchid;
        public string Intrastatbranchid
        {
            get { return _fIntrastatbranchid; }
            set
            {
                if (_fIntrastatbranchid != value)
                {
                    Modify();
                    _fIntrastatbranchid = value;
                }
            }
        }

        private short? _fInuse;
        public short? Inuse
        {
            get { return _fInuse; }
            set
            {
                if (_fInuse != value)
                {
                    Modify();
                    _fInuse = value;
                }
            }
        }

        private int? _fInvsessionno;
        public int? Invsessionno
        {
            get { return _fInvsessionno; }
            set
            {
                if (_fInvsessionno != value)
                {
                    Modify();
                    _fInvsessionno = value;
                }
            }
        }

        private int? _fLastbatchno;
        public int? Lastbatchno
        {
            get { return _fLastbatchno; }
            set
            {
                if (_fLastbatchno != value)
                {
                    Modify();
                    _fLastbatchno = value;
                }
            }
        }

        private int? _fLastcdtbatchno;
        public int? Lastcdtbatchno
        {
            get { return _fLastcdtbatchno; }
            set
            {
                if (_fLastcdtbatchno != value)
                {
                    Modify();
                    _fLastcdtbatchno = value;
                }
            }
        }

        private int? _fLastdbtbatchno;
        public int? Lastdbtbatchno
        {
            get { return _fLastdbtbatchno; }
            set
            {
                if (_fLastdbtbatchno != value)
                {
                    Modify();
                    _fLastdbtbatchno = value;
                }
            }
        }

        private int? _fLastinvbatchno;
        public int? Lastinvbatchno
        {
            get { return _fLastinvbatchno; }
            set
            {
                if (_fLastinvbatchno != value)
                {
                    Modify();
                    _fLastinvbatchno = value;
                }
            }
        }

        private int? _fLastmancdtbatchno;
        public int? Lastmancdtbatchno
        {
            get { return _fLastmancdtbatchno; }
            set
            {
                if (_fLastmancdtbatchno != value)
                {
                    Modify();
                    _fLastmancdtbatchno = value;
                }
            }
        }

        private int? _fLastmaninvbatchno;
        public int? Lastmaninvbatchno
        {
            get { return _fLastmaninvbatchno; }
            set
            {
                if (_fLastmaninvbatchno != value)
                {
                    Modify();
                    _fLastmaninvbatchno = value;
                }
            }
        }

        private short? _fLastpreinvupdateok;
        public short? Lastpreinvupdateok
        {
            get { return _fLastpreinvupdateok; }
            set
            {
                if (_fLastpreinvupdateok != value)
                {
                    Modify();
                    _fLastpreinvupdateok = value;
                }
            }
        }

        private short? _fLmtontradstcksel;
        public short? Lmtontradstcksel
        {
            get { return _fLmtontradstcksel; }
            set
            {
                if (_fLmtontradstcksel != value)
                {
                    Modify();
                    _fLmtontradstcksel = value;
                }
            }
        }

        private int _fLotprofitdisp;
        public int Lotprofitdisp
        {
            get { return _fLotprofitdisp; }
            set
            {
                if (_fLotprofitdisp != value)
                {
                    Modify();
                    _fLotprofitdisp = value;
                }
            }
        }

        private int _fLotprofitmeth;
        public int Lotprofitmeth
        {
            get { return _fLotprofitmeth; }
            set
            {
                if (_fLotprofitmeth != value)
                {
                    Modify();
                    _fLotprofitmeth = value;
                }
            }
        }

        private int? _fLstgldbkno;
        public int? Lstgldbkno
        {
            get { return _fLstgldbkno; }
            set
            {
                if (_fLstgldbkno != value)
                {
                    Modify();
                    _fLstgldbkno = value;
                }
            }
        }

        private int? _fLstintcomchgdbkno;
        public int? Lstintcomchgdbkno
        {
            get { return _fLstintcomchgdbkno; }
            set
            {
                if (_fLstintcomchgdbkno != value)
                {
                    Modify();
                    _fLstintcomchgdbkno = value;
                }
            }
        }

        private int? _fLstmktbatchno;
        public int? Lstmktbatchno
        {
            get { return _fLstmktbatchno; }
            set
            {
                if (_fLstmktbatchno != value)
                {
                    Modify();
                    _fLstmktbatchno = value;
                }
            }
        }

        private int? _fLstpldbkno;
        public int? Lstpldbkno
        {
            get { return _fLstpldbkno; }
            set
            {
                if (_fLstpldbkno != value)
                {
                    Modify();
                    _fLstpldbkno = value;
                }
            }
        }

        private int? _fLstporecovdbkno;
        public int? Lstporecovdbkno
        {
            get { return _fLstporecovdbkno; }
            set
            {
                if (_fLstporecovdbkno != value)
                {
                    Modify();
                    _fLstporecovdbkno = value;
                }
            }
        }

        private int? _fLstprechgdbkno;
        public int? Lstprechgdbkno
        {
            get { return _fLstprechgdbkno; }
            set
            {
                if (_fLstprechgdbkno != value)
                {
                    Modify();
                    _fLstprechgdbkno = value;
                }
            }
        }

        private int? _fLstprepdbkno;
        public int? Lstprepdbkno
        {
            get { return _fLstprepdbkno; }
            set
            {
                if (_fLstprepdbkno != value)
                {
                    Modify();
                    _fLstprepdbkno = value;
                }
            }
        }

        private int? _fLstsalaudrecno;
        public int? Lstsalaudrecno
        {
            get { return _fLstsalaudrecno; }
            set
            {
                if (_fLstsalaudrecno != value)
                {
                    Modify();
                    _fLstsalaudrecno = value;
                }
            }
        }

        private int? _fLstsldbkno;
        public int? Lstsldbkno
        {
            get { return _fLstsldbkno; }
            set
            {
                if (_fLstsldbkno != value)
                {
                    Modify();
                    _fLstsldbkno = value;
                }
            }
        }

        private int? _fLsttshprpkdbkno;
        public int? Lsttshprpkdbkno
        {
            get { return _fLsttshprpkdbkno; }
            set
            {
                if (_fLsttshprpkdbkno != value)
                {
                    Modify();
                    _fLsttshprpkdbkno = value;
                }
            }
        }

        private int? _fLstvatdbkno;
        public int? Lstvatdbkno
        {
            get { return _fLstvatdbkno; }
            set
            {
                if (_fLstvatdbkno != value)
                {
                    Modify();
                    _fLstvatdbkno = value;
                }
            }
        }

        private int? _fLstwhtaxdbkno;
        public int? Lstwhtaxdbkno
        {
            get { return _fLstwhtaxdbkno; }
            set
            {
                if (_fLstwhtaxdbkno != value)
                {
                    Modify();
                    _fLstwhtaxdbkno = value;
                }
            }
        }

        private short? _fLusercvdqtyforacr;
        public short? Lusercvdqtyforacr
        {
            get { return _fLusercvdqtyforacr; }
            set
            {
                if (_fLusercvdqtyforacr != value)
                {
                    Modify();
                    _fLusercvdqtyforacr = value;
                }
            }
        }

        private short? _fMarketordentautoinvprt;
        public short? Marketordentautoinvprt
        {
            get { return _fMarketordentautoinvprt; }
            set
            {
                if (_fMarketordentautoinvprt != value)
                {
                    Modify();
                    _fMarketordentautoinvprt = value;
                }
            }
        }

        private short? _fMarketordentcashupdate;
        public short? Marketordentcashupdate
        {
            get { return _fMarketordentcashupdate; }
            set
            {
                if (_fMarketordentcashupdate != value)
                {
                    Modify();
                    _fMarketordentcashupdate = value;
                }
            }
        }

        private short? _fMktsalessettodlv;
        public short? Mktsalessettodlv
        {
            get { return _fMktsalessettodlv; }
            set
            {
                if (_fMktsalessettodlv != value)
                {
                    Modify();
                    _fMktsalessettodlv = value;
                }
            }
        }

        private int? _fNextcdtnoteno;
        public int? Nextcdtnoteno
        {
            get { return _fNextcdtnoteno; }
            set
            {
                if (_fNextcdtnoteno != value)
                {
                    Modify();
                    _fNextcdtnoteno = value;
                }
            }
        }

        private int? _fNextinvoiceno;
        public int? Nextinvoiceno
        {
            get { return _fNextinvoiceno; }
            set
            {
                if (_fNextinvoiceno != value)
                {
                    Modify();
                    _fNextinvoiceno = value;
                }
            }
        }

        private short? _fNovatforsaloff;
        public short? Novatforsaloff
        {
            get { return _fNovatforsaloff; }
            set
            {
                if (_fNovatforsaloff != value)
                {
                    Modify();
                    _fNovatforsaloff = value;
                }
            }
        }

        private int? _fNxtdailycreditno;
        public int? Nxtdailycreditno
        {
            get { return _fNxtdailycreditno; }
            set
            {
                if (_fNxtdailycreditno != value)
                {
                    Modify();
                    _fNxtdailycreditno = value;
                }
            }
        }

        private int? _fNxtdailyinvoiceno;
        public int? Nxtdailyinvoiceno
        {
            get { return _fNxtdailyinvoiceno; }
            set
            {
                if (_fNxtdailyinvoiceno != value)
                {
                    Modify();
                    _fNxtdailyinvoiceno = value;
                }
            }
        }

        private int? _fNxtquickinvno;
        public int? Nxtquickinvno
        {
            get { return _fNxtquickinvno; }
            set
            {
                if (_fNxtquickinvno != value)
                {
                    Modify();
                    _fNxtquickinvno = value;
                }
            }
        }

        private int _fNxtservinvno;
        public int Nxtservinvno
        {
            get { return _fNxtservinvno; }
            set
            {
                if (_fNxtservinvno != value)
                {
                    Modify();
                    _fNxtservinvno = value;
                }
            }
        }

        private short? _fPaymentsetupinuse;
        public short? Paymentsetupinuse
        {
            get { return _fPaymentsetupinuse; }
            set
            {
                if (_fPaymentsetupinuse != value)
                {
                    Modify();
                    _fPaymentsetupinuse = value;
                }
            }
        }

        private int? _fPaymentsetupinusebylogon;
        public int? Paymentsetupinusebylogon
        {
            get { return _fPaymentsetupinusebylogon; }
            set
            {
                if (_fPaymentsetupinusebylogon != value)
                {
                    Modify();
                    _fPaymentsetupinusebylogon = value;
                }
            }
        }

        private int? _fPaymentsetupinusebysess;
        public int? Paymentsetupinusebysess
        {
            get { return _fPaymentsetupinusebysess; }
            set
            {
                if (_fPaymentsetupinusebysess != value)
                {
                    Modify();
                    _fPaymentsetupinusebysess = value;
                }
            }
        }

        private DateTime? _fPaymentsetupinuselocktime;
        public DateTime? Paymentsetupinuselocktime
        {
            get { return _fPaymentsetupinuselocktime; }
            set
            {
                if (_fPaymentsetupinuselocktime != value)
                {
                    Modify();
                    _fPaymentsetupinuselocktime = value;
                }
            }
        }

        private string _fPickfifoprtnm;
        public string Pickfifoprtnm
        {
            get { return _fPickfifoprtnm; }
            set
            {
                if (_fPickfifoprtnm != value)
                {
                    Modify();
                    _fPickfifoprtnm = value;
                }
            }
        }

        private string _fPicknonfifoprtnm;
        public string Picknonfifoprtnm
        {
            get { return _fPicknonfifoprtnm; }
            set
            {
                if (_fPicknonfifoprtnm != value)
                {
                    Modify();
                    _fPicknonfifoprtnm = value;
                }
            }
        }

        private string _fPickprtnm;
        public string Pickprtnm
        {
            get { return _fPickprtnm; }
            set
            {
                if (_fPickprtnm != value)
                {
                    Modify();
                    _fPickprtnm = value;
                }
            }
        }

        private short? _fPldbkinuse;
        public short? Pldbkinuse
        {
            get { return _fPldbkinuse; }
            set
            {
                if (_fPldbkinuse != value)
                {
                    Modify();
                    _fPldbkinuse = value;
                }
            }
        }

        private int? _fPldbkusedby;
        public int? Pldbkusedby
        {
            get { return _fPldbkusedby; }
            set
            {
                if (_fPldbkusedby != value)
                {
                    Modify();
                    _fPldbkusedby = value;
                }
            }
        }

        private short? _fPorecovdbkinuse;
        public short? Porecovdbkinuse
        {
            get { return _fPorecovdbkinuse; }
            set
            {
                if (_fPorecovdbkinuse != value)
                {
                    Modify();
                    _fPorecovdbkinuse = value;
                }
            }
        }

        private int? _fPorecovdbkusedby;
        public int? Porecovdbkusedby
        {
            get { return _fPorecovdbkusedby; }
            set
            {
                if (_fPorecovdbkusedby != value)
                {
                    Modify();
                    _fPorecovdbkusedby = value;
                }
            }
        }

        private string _fPostcode;
        public string Postcode
        {
            get { return _fPostcode; }
            set
            {
                if (_fPostcode != value)
                {
                    Modify();
                    _fPostcode = value;
                }
            }
        }

        private short? _fPrechgdbkinuse;
        public short? Prechgdbkinuse
        {
            get { return _fPrechgdbkinuse; }
            set
            {
                if (_fPrechgdbkinuse != value)
                {
                    Modify();
                    _fPrechgdbkinuse = value;
                }
            }
        }

        private int? _fPrechgdbkusedby;
        public int? Prechgdbkusedby
        {
            get { return _fPrechgdbkusedby; }
            set
            {
                if (_fPrechgdbkusedby != value)
                {
                    Modify();
                    _fPrechgdbkusedby = value;
                }
            }
        }

        private short? _fPrepdbkinuse;
        public short? Prepdbkinuse
        {
            get { return _fPrepdbkinuse; }
            set
            {
                if (_fPrepdbkinuse != value)
                {
                    Modify();
                    _fPrepdbkinuse = value;
                }
            }
        }

        private int? _fPrepdbkusedby;
        public int? Prepdbkusedby
        {
            get { return _fPrepdbkusedby; }
            set
            {
                if (_fPrepdbkusedby != value)
                {
                    Modify();
                    _fPrepdbkusedby = value;
                }
            }
        }

        private short? _fPurinvauthappbox;
        public short? Purinvauthappbox
        {
            get { return _fPurinvauthappbox; }
            set
            {
                if (_fPurinvauthappbox != value)
                {
                    Modify();
                    _fPurinvauthappbox = value;
                }
            }
        }

        private int? _fSalbusunitrecno;
        public int? Salbusunitrecno
        {
            get { return _fSalbusunitrecno; }
            set
            {
                if (_fSalbusunitrecno != value)
                {
                    Modify();
                    _fSalbusunitrecno = value;
                }
            }
        }

        private string _fSaloffcode;
        public string Saloffcode
        {
            get { return _fSaloffcode; }
            set
            {
                if (_fSaloffcode != value)
                {
                    Modify();
                    _fSaloffcode = value;
                }
            }
        }

        private int? _fSaloffddfileno;
        public int? Saloffddfileno
        {
            get { return _fSaloffddfileno; }
            set
            {
                if (_fSaloffddfileno != value)
                {
                    Modify();
                    _fSaloffddfileno = value;
                }
            }
        }

        private string _fSaloffdesc;
        public string Saloffdesc
        {
            get { return _fSaloffdesc; }
            set
            {
                if (_fSaloffdesc != value)
                {
                    Modify();
                    _fSaloffdesc = value;
                }
            }
        }

        private short? _fSepinvno;
        public short? Sepinvno
        {
            get { return _fSepinvno; }
            set
            {
                if (_fSepinvno != value)
                {
                    Modify();
                    _fSepinvno = value;
                }
            }
        }

        private short _fServinvinuse;
        public short Servinvinuse
        {
            get { return _fServinvinuse; }
            set
            {
                if (_fServinvinuse != value)
                {
                    Modify();
                    _fServinvinuse = value;
                }
            }
        }

        private int? _fServinvlogonno;
        public int? Servinvlogonno
        {
            get { return _fServinvlogonno; }
            set
            {
                if (_fServinvlogonno != value)
                {
                    Modify();
                    _fServinvlogonno = value;
                }
            }
        }

        private int? _fServinvsession;
        public int? Servinvsession
        {
            get { return _fServinvsession; }
            set
            {
                if (_fServinvsession != value)
                {
                    Modify();
                    _fServinvsession = value;
                }
            }
        }

        private short? _fSinglecomlots;
        public short? Singlecomlots
        {
            get { return _fSinglecomlots; }
            set
            {
                if (_fSinglecomlots != value)
                {
                    Modify();
                    _fSinglecomlots = value;
                }
            }
        }

        private short? _fSldbkinuse;
        public short? Sldbkinuse
        {
            get { return _fSldbkinuse; }
            set
            {
                if (_fSldbkinuse != value)
                {
                    Modify();
                    _fSldbkinuse = value;
                }
            }
        }

        private int? _fSldbkusedby;
        public int? Sldbkusedby
        {
            get { return _fSldbkusedby; }
            set
            {
                if (_fSldbkusedby != value)
                {
                    Modify();
                    _fSldbkusedby = value;
                }
            }
        }

        private short? _fSmnoncashdesk;
        public short? Smnoncashdesk
        {
            get { return _fSmnoncashdesk; }
            set
            {
                if (_fSmnoncashdesk != value)
                {
                    Modify();
                    _fSmnoncashdesk = value;
                }
            }
        }

        private short? _fStkdissUseextractdt;
        /// <summary>
        /// Are we using a 'Extract Up To Date' in Stock Dissection
        /// </summary>
        public short? StkdissUseextractdt
        {
            get { return _fStkdissUseextractdt; }
            set
            {
                if (_fStkdissUseextractdt != value)
                {
                    Modify();
                    _fStkdissUseextractdt = value;
                }
            }
        }

        private int? _fSupclarecno;
        public int? Supclarecno
        {
            get { return _fSupclarecno; }
            set
            {
                if (_fSupclarecno != value)
                {
                    Modify();
                    _fSupclarecno = value;
                }
            }
        }

        private int? _fSupforoversoldstock;
        public int? Supforoversoldstock
        {
            get { return _fSupforoversoldstock; }
            set
            {
                if (_fSupforoversoldstock != value)
                {
                    Modify();
                    _fSupforoversoldstock = value;
                }
            }
        }

        private short? _fTaxdatebfdlvdate;
        public short? Taxdatebfdlvdate
        {
            get { return _fTaxdatebfdlvdate; }
            set
            {
                if (_fTaxdatebfdlvdate != value)
                {
                    Modify();
                    _fTaxdatebfdlvdate = value;
                }
            }
        }

        private short? _fTktAllowprcchgaftstkdiss;
        public short? TktAllowprcchgaftstkdiss
        {
            get { return _fTktAllowprcchgaftstkdiss; }
            set
            {
                if (_fTktAllowprcchgaftstkdiss != value)
                {
                    Modify();
                    _fTktAllowprcchgaftstkdiss = value;
                }
            }
        }

        private int? _fTktbkmaxno;
        public int? Tktbkmaxno
        {
            get { return _fTktbkmaxno; }
            set
            {
                if (_fTktbkmaxno != value)
                {
                    Modify();
                    _fTktbkmaxno = value;
                }
            }
        }

        private int? _fTktbkoffset;
        public int? Tktbkoffset
        {
            get { return _fTktbkoffset; }
            set
            {
                if (_fTktbkoffset != value)
                {
                    Modify();
                    _fTktbkoffset = value;
                }
            }
        }

        private int? _fTktbksize;
        public int? Tktbksize
        {
            get { return _fTktbksize; }
            set
            {
                if (_fTktbksize != value)
                {
                    Modify();
                    _fTktbksize = value;
                }
            }
        }

        private int? _fTktcashacc;
        public int? Tktcashacc
        {
            get { return _fTktcashacc; }
            set
            {
                if (_fTktcashacc != value)
                {
                    Modify();
                    _fTktcashacc = value;
                }
            }
        }

        private short? _fTktcashaccComm;
        public short? TktcashaccComm
        {
            get { return _fTktcashaccComm; }
            set
            {
                if (_fTktcashaccComm != value)
                {
                    Modify();
                    _fTktcashaccComm = value;
                }
            }
        }

        private short? _fTktcashaccDonthash;
        public short? TktcashaccDonthash
        {
            get { return _fTktcashaccDonthash; }
            set
            {
                if (_fTktcashaccDonthash != value)
                {
                    Modify();
                    _fTktcashaccDonthash = value;
                }
            }
        }

        private short? _fTktfocreasMand;
        public short? TktfocreasMand
        {
            get { return _fTktfocreasMand; }
            set
            {
                if (_fTktfocreasMand != value)
                {
                    Modify();
                    _fTktfocreasMand = value;
                }
            }
        }

        private short? _fTkthashtotsMand;
        public short? TkthashtotsMand
        {
            get { return _fTkthashtotsMand; }
            set
            {
                if (_fTkthashtotsMand != value)
                {
                    Modify();
                    _fTkthashtotsMand = value;
                }
            }
        }

        private short? _fTktsaleagstnostk;
        public short? Tktsaleagstnostk
        {
            get { return _fTktsaleagstnostk; }
            set
            {
                if (_fTktsaleagstnostk != value)
                {
                    Modify();
                    _fTktsaleagstnostk = value;
                }
            }
        }

        private short? _fTktwarnofoversell;
        public short? Tktwarnofoversell
        {
            get { return _fTktwarnofoversell; }
            set
            {
                if (_fTktwarnofoversell != value)
                {
                    Modify();
                    _fTktwarnofoversell = value;
                }
            }
        }

        private short? _fTshprpkdbkinuse;
        public short? Tshprpkdbkinuse
        {
            get { return _fTshprpkdbkinuse; }
            set
            {
                if (_fTshprpkdbkinuse != value)
                {
                    Modify();
                    _fTshprpkdbkinuse = value;
                }
            }
        }

        private int? _fTshprpkdbkusedby;
        public int? Tshprpkdbkusedby
        {
            get { return _fTshprpkdbkusedby; }
            set
            {
                if (_fTshprpkdbkusedby != value)
                {
                    Modify();
                    _fTshprpkdbkusedby = value;
                }
            }
        }

        private short? _fUseaddauth;
        public short? Useaddauth
        {
            get { return _fUseaddauth; }
            set
            {
                if (_fUseaddauth != value)
                {
                    Modify();
                    _fUseaddauth = value;
                }
            }
        }

        private int? _fUsedby;
        public int? Usedby
        {
            get { return _fUsedby; }
            set
            {
                if (_fUsedby != value)
                {
                    Modify();
                    _fUsedby = value;
                }
            }
        }

        private short? _fUsemaninvasmansalentry;
        public short? Usemaninvasmansalentry
        {
            get { return _fUsemaninvasmansalentry; }
            set
            {
                if (_fUsemaninvasmansalentry != value)
                {
                    Modify();
                    _fUsemaninvasmansalentry = value;
                }
            }
        }

        private short? _fUseseqinvnos;
        public short? Useseqinvnos
        {
            get { return _fUseseqinvnos; }
            set
            {
                if (_fUseseqinvnos != value)
                {
                    Modify();
                    _fUseseqinvnos = value;
                }
            }
        }

        private short? _fUsetktnumforstkswap;
        /// <summary>
        /// Use a Ticket Number when performing Stock Swap Transactions
        /// </summary>
        public short? Usetktnumforstkswap
        {
            get { return _fUsetktnumforstkswap; }
            set
            {
                if (_fUsetktnumforstkswap != value)
                {
                    Modify();
                    _fUsetktnumforstkswap = value;
                }
            }
        }

        private short? _fVatdbkinuse;
        public short? Vatdbkinuse
        {
            get { return _fVatdbkinuse; }
            set
            {
                if (_fVatdbkinuse != value)
                {
                    Modify();
                    _fVatdbkinuse = value;
                }
            }
        }

        private int? _fVatdbkusedby;
        public int? Vatdbkusedby
        {
            get { return _fVatdbkusedby; }
            set
            {
                if (_fVatdbkusedby != value)
                {
                    Modify();
                    _fVatdbkusedby = value;
                }
            }
        }

        private short? _fWhtaxdbkinuse;
        public short? Whtaxdbkinuse
        {
            get { return _fWhtaxdbkinuse; }
            set
            {
                if (_fWhtaxdbkinuse != value)
                {
                    Modify();
                    _fWhtaxdbkinuse = value;
                }
            }
        }

        private int? _fWhtaxdbkusedby;
        public int? Whtaxdbkusedby
        {
            get { return _fWhtaxdbkusedby; }
            set
            {
                if (_fWhtaxdbkusedby != value)
                {
                    Modify();
                    _fWhtaxdbkusedby = value;
                }
            }
        }

        public override int Key
        {
            get { return Saloffno; }
            set { Saloffno = value; }
        }

        public override string KeyAsString { get { return Key.ToString(CultureInfo.InvariantCulture); } }


        public override SalesOfficeResultsLineBase Clone()
        {
            var obj = new SalesOfficeResultsLineBase
                {
                    Saloffno = Saloffno,
                    Acccode = Acccode,
                    Accntsaloffno = Accntsaloffno,
                    Agressocostcentreno = Agressocostcentreno,
                    Bacsalias = Bacsalias,
                    Banrecno = Banrecno,
                    Basecurno = Basecurno,
                    Businessunitcode = Businessunitcode,
                    Cancchqemail = Cancchqemail,
                    Canpricetran = Canpricetran,
                    Canpurchtran = Canpurchtran,
                    Canrcvpo = Canrcvpo,
                    Cashexportseqno = Cashexportseqno,
                    Cashtiknoofdaysdisp = Cashtiknoofdaysdisp,
                    Cdtsurchg = Cdtsurchg,
                    Closedayinuse = Closedayinuse,
                    Closedaysession = Closedaysession,
                    Closedayusedby = Closedayusedby,
                    Compadd1 = Compadd1,
                    Compadd2 = Compadd2,
                    Compadd3 = Compadd3,
                    Compadd4 = Compadd4,
                    Companano = Companano,
                    Companycode = Companycode,
                    Companyname = Companyname,
                    Compcmbinvstylnm = Compcmbinvstylnm,
                    Compfax = Compfax,
                    Compinvstylnm = Compinvstylnm,
                    Compphone = Compphone,
                    Compvatno = Compvatno,
                    Compwww = Compwww,
                    Contactlogno = Contactlogno,
                    Cshbookexppath = Cshbookexppath,
                    Cshbookexppathbak = Cshbookexppathbak,
                    Cstclarecno = Cstclarecno,
                    Ddinuse = Ddinuse,
                    Ddinuseby = Ddinuseby,
                    Debtorexppath = Debtorexppath,
                    Debtorexppathbak = Debtorexppathbak,
                    Defpaymenttype = Defpaymenttype,
                    Deliveryprtnm = Deliveryprtnm,
                    Deliveryweightprtnm = Deliveryweightprtnm,
                    Dgpextractinuse = Dgpextractinuse,
                    Dgpextractinuseby = Dgpextractinuseby,
                    Eancode = Eancode,
                    Fincono = Fincono,
                    Finjournal = Finjournal,
                    Finoutputdir = Finoutputdir,
                    Fyfbusunitcono = Fyfbusunitcono,
                    Gldbkinuse = Gldbkinuse,
                    Gldbkusedby = Gldbkusedby,
                    Imagefilename = Imagefilename,
                    Intcomchgdbkinuse = Intcomchgdbkinuse,
                    Intcomtraninuseby = Intcomtraninuseby,
                    Intrastatbranchid = Intrastatbranchid,
                    Inuse = Inuse,
                    Invsessionno = Invsessionno,
                    Lastbatchno = Lastbatchno,
                    Lastcdtbatchno = Lastcdtbatchno,
                    Lastdbtbatchno = Lastdbtbatchno,
                    Lastinvbatchno = Lastinvbatchno,
                    Lastmancdtbatchno = Lastmancdtbatchno,
                    Lastmaninvbatchno = Lastmaninvbatchno,
                    Lastpreinvupdateok = Lastpreinvupdateok,
                    Lmtontradstcksel = Lmtontradstcksel,
                    Lotprofitdisp = Lotprofitdisp,
                    Lotprofitmeth = Lotprofitmeth,
                    Lstgldbkno = Lstgldbkno,
                    Lstintcomchgdbkno = Lstintcomchgdbkno,
                    Lstmktbatchno = Lstmktbatchno,
                    Lstpldbkno = Lstpldbkno,
                    Lstporecovdbkno = Lstporecovdbkno,
                    Lstprechgdbkno = Lstprechgdbkno,
                    Lstprepdbkno = Lstprepdbkno,
                    Lstsalaudrecno = Lstsalaudrecno,
                    Lstsldbkno = Lstsldbkno,
                    Lsttshprpkdbkno = Lsttshprpkdbkno,
                    Lstvatdbkno = Lstvatdbkno,
                    Lstwhtaxdbkno = Lstwhtaxdbkno,
                    Lusercvdqtyforacr = Lusercvdqtyforacr,
                    Marketordentautoinvprt = Marketordentautoinvprt,
                    Marketordentcashupdate = Marketordentcashupdate,
                    Mktsalessettodlv = Mktsalessettodlv,
                    Nextcdtnoteno = Nextcdtnoteno,
                    Nextinvoiceno = Nextinvoiceno,
                    Novatforsaloff = Novatforsaloff,
                    Nxtdailycreditno = Nxtdailycreditno,
                    Nxtdailyinvoiceno = Nxtdailyinvoiceno,
                    Nxtquickinvno = Nxtquickinvno,
                    Nxtservinvno = Nxtservinvno,
                    Paymentsetupinuse = Paymentsetupinuse,
                    Paymentsetupinusebylogon = Paymentsetupinusebylogon,
                    Paymentsetupinusebysess = Paymentsetupinusebysess,
                    Paymentsetupinuselocktime = Paymentsetupinuselocktime,
                    Pickfifoprtnm = Pickfifoprtnm,
                    Picknonfifoprtnm = Picknonfifoprtnm,
                    Pickprtnm = Pickprtnm,
                    Pldbkinuse = Pldbkinuse,
                    Pldbkusedby = Pldbkusedby,
                    Porecovdbkinuse = Porecovdbkinuse,
                    Porecovdbkusedby = Porecovdbkusedby,
                    Postcode = Postcode,
                    Prechgdbkinuse = Prechgdbkinuse,
                    Prechgdbkusedby = Prechgdbkusedby,
                    Prepdbkinuse = Prepdbkinuse,
                    Prepdbkusedby = Prepdbkusedby,
                    Purinvauthappbox = Purinvauthappbox,
                    Salbusunitrecno = Salbusunitrecno,
                    Saloffcode = Saloffcode,
                    Saloffddfileno = Saloffddfileno,
                    Saloffdesc = Saloffdesc,
                    Sepinvno = Sepinvno,
                    Servinvinuse = Servinvinuse,
                    Servinvlogonno = Servinvlogonno,
                    Servinvsession = Servinvsession,
                    Singlecomlots = Singlecomlots,
                    Sldbkinuse = Sldbkinuse,
                    Sldbkusedby = Sldbkusedby,
                    Smnoncashdesk = Smnoncashdesk,
                    StkdissUseextractdt = StkdissUseextractdt,
                    Supclarecno = Supclarecno,
                    Supforoversoldstock = Supforoversoldstock,
                    Taxdatebfdlvdate = Taxdatebfdlvdate,
                    TktAllowprcchgaftstkdiss = TktAllowprcchgaftstkdiss,
                    Tktbkmaxno = Tktbkmaxno,
                    Tktbkoffset = Tktbkoffset,
                    Tktbksize = Tktbksize,
                    Tktcashacc = Tktcashacc,
                    TktcashaccComm = TktcashaccComm,
                    TktcashaccDonthash = TktcashaccDonthash,
                    TktfocreasMand = TktfocreasMand,
                    TkthashtotsMand = TkthashtotsMand,
                    Tktsaleagstnostk = Tktsaleagstnostk,
                    Tktwarnofoversell = Tktwarnofoversell,
                    Tshprpkdbkinuse = Tshprpkdbkinuse,
                    Tshprpkdbkusedby = Tshprpkdbkusedby,
                    Useaddauth = Useaddauth,
                    Usedby = Usedby,
                    Usemaninvasmansalentry = Usemaninvasmansalentry,
                    Useseqinvnos = Useseqinvnos,
                    Usetktnumforstkswap = Usetktnumforstkswap,
                    Vatdbkinuse = Vatdbkinuse,
                    Vatdbkusedby = Vatdbkusedby,
                    Whtaxdbkinuse = Whtaxdbkinuse,
                    Whtaxdbkusedby = Whtaxdbkusedby,
                };

            return obj;
        }

        public static class FieldNames
        {
// ReSharper disable InconsistentNaming
            public const string  SALOFFNO = "SALOFFNO";
            public const string  ACCCODE = "ACCCODE";
            public const string  ACCNTSALOFFNO = "ACCNTSALOFFNO";
            public const string  AGRESSOCOSTCENTRENO = "AGRESSOCOSTCENTRENO";
            public const string  BACSALIAS = "BACSALIAS";
            public const string  BANRECNO = "BANRECNO";
            public const string  BASECURNO = "BASECURNO";
            public const string  BUSINESSUNITCODE = "BUSINESSUNITCODE";
            public const string  CANCCHQEMAIL = "CANCCHQEMAIL";
            public const string  CANPRICETRAN = "CANPRICETRAN";
            public const string  CANPURCHTRAN = "CANPURCHTRAN";
            public const string  CANRCVPO = "CANRCVPO";
            public const string  CASHEXPORTSEQNO = "CASHEXPORTSEQNO";
            public const string  CASHTIKNOOFDAYSDISP = "CASHTIKNOOFDAYSDISP";
            public const string  CDTSURCHG = "CDTSURCHG";
            public const string  CLOSEDAYINUSE = "CLOSEDAYINUSE";
            public const string  CLOSEDAYSESSION = "CLOSEDAYSESSION";
            public const string  CLOSEDAYUSEDBY = "CLOSEDAYUSEDBY";
            public const string  COMPADD1 = "COMPADD1";
            public const string  COMPADD2 = "COMPADD2";
            public const string  COMPADD3 = "COMPADD3";
            public const string  COMPADD4 = "COMPADD4";
            public const string  COMPANANO = "COMPANANO";
            public const string  COMPANYCODE = "COMPANYCODE";
            public const string  COMPANYNAME = "COMPANYNAME";
            public const string  COMPCMBINVSTYLNM = "COMPCMBINVSTYLNM";
            public const string  COMPFAX = "COMPFAX";
            public const string  COMPINVSTYLNM = "COMPINVSTYLNM";
            public const string  COMPPHONE = "COMPPHONE";
            public const string  COMPVATNO = "COMPVATNO";
            public const string  COMPWWW = "COMPWWW";
            public const string  CONTACTLOGNO = "CONTACTLOGNO";
            public const string  CSHBOOKEXPPATH = "CSHBOOKEXPPATH";
            public const string  CSHBOOKEXPPATHBAK = "CSHBOOKEXPPATHBAK";
            public const string  CSTCLARECNO = "CSTCLARECNO";
            public const string  DDINUSE = "DDINUSE";
            public const string  DDINUSEBY = "DDINUSEBY";
            public const string  DEBTOREXPPATH = "DEBTOREXPPATH";
            public const string  DEBTOREXPPATHBAK = "DEBTOREXPPATHBAK";
            public const string  DEFPAYMENTTYPE = "DEFPAYMENTTYPE";
            public const string  DELIVERYPRTNM = "DELIVERYPRTNM";
            public const string  DELIVERYWEIGHTPRTNM = "DELIVERYWEIGHTPRTNM";
            public const string  DGPEXTRACTINUSE = "DGPEXTRACTINUSE";
            public const string  DGPEXTRACTINUSEBY = "DGPEXTRACTINUSEBY";
            public const string  EANCODE = "EANCODE";
            public const string  FINCONO = "FINCONO";
            public const string  FINJOURNAL = "FINJOURNAL";
            public const string  FINOUTPUTDIR = "FINOUTPUTDIR";
            public const string  FYFBUSUNITCONO = "FYFBUSUNITCONO";
            public const string  GLDBKINUSE = "GLDBKINUSE";
            public const string  GLDBKUSEDBY = "GLDBKUSEDBY";
            public const string  IMAGEFILENAME = "IMAGEFILENAME";
            public const string  INTCOMCHGDBKINUSE = "INTCOMCHGDBKINUSE";
            public const string  INTCOMTRANINUSEBY = "INTCOMTRANINUSEBY";
            public const string  INTRASTATBRANCHID = "INTRASTATBRANCHID";
            public const string  INUSE = "INUSE";
            public const string  INVSESSIONNO = "INVSESSIONNO";
            public const string  LASTBATCHNO = "LASTBATCHNO";
            public const string  LASTCDTBATCHNO = "LASTCDTBATCHNO";
            public const string  LASTDBTBATCHNO = "LASTDBTBATCHNO";
            public const string  LASTINVBATCHNO = "LASTINVBATCHNO";
            public const string  LASTMANCDTBATCHNO = "LASTMANCDTBATCHNO";
            public const string  LASTMANINVBATCHNO = "LASTMANINVBATCHNO";
            public const string  LASTPREINVUPDATEOK = "LASTPREINVUPDATEOK";
            public const string  LMTONTRADSTCKSEL = "LMTONTRADSTCKSEL";
            public const string  LOTPROFITDISP = "LOTPROFITDISP";
            public const string  LOTPROFITMETH = "LOTPROFITMETH";
            public const string  LSTGLDBKNO = "LSTGLDBKNO";
            public const string  LSTINTCOMCHGDBKNO = "LSTINTCOMCHGDBKNO";
            public const string  LSTMKTBATCHNO = "LSTMKTBATCHNO";
            public const string  LSTPLDBKNO = "LSTPLDBKNO";
            public const string  LSTPORECOVDBKNO = "LSTPORECOVDBKNO";
            public const string  LSTPRECHGDBKNO = "LSTPRECHGDBKNO";
            public const string  LSTPREPDBKNO = "LSTPREPDBKNO";
            public const string  LSTSALAUDRECNO = "LSTSALAUDRECNO";
            public const string  LSTSLDBKNO = "LSTSLDBKNO";
            public const string  LSTTSHPRPKDBKNO = "LSTTSHPRPKDBKNO";
            public const string  LSTVATDBKNO = "LSTVATDBKNO";
            public const string  LSTWHTAXDBKNO = "LSTWHTAXDBKNO";
            public const string  LUSERCVDQTYFORACR = "LUSERCVDQTYFORACR";
            public const string  MARKETORDENTAUTOINVPRT = "MARKETORDENTAUTOINVPRT";
            public const string  MARKETORDENTCASHUPDATE = "MARKETORDENTCASHUPDATE";
            public const string  MKTSALESSETTODLV = "MKTSALESSETTODLV";
            public const string  NEXTCDTNOTENO = "NEXTCDTNOTENO";
            public const string  NEXTINVOICENO = "NEXTINVOICENO";
            public const string  NOVATFORSALOFF = "NOVATFORSALOFF";
            public const string  NXTDAILYCREDITNO = "NXTDAILYCREDITNO";
            public const string  NXTDAILYINVOICENO = "NXTDAILYINVOICENO";
            public const string  NXTQUICKINVNO = "NXTQUICKINVNO";
            public const string  NXTSERVINVNO = "NXTSERVINVNO";
            public const string  PAYMENTSETUPINUSE = "PAYMENTSETUPINUSE";
            public const string  PAYMENTSETUPINUSEBYLOGON = "PAYMENTSETUPINUSEBYLOGON";
            public const string  PAYMENTSETUPINUSEBYSESS = "PAYMENTSETUPINUSEBYSESS";
            public const string  PAYMENTSETUPINUSELOCKTIME = "PAYMENTSETUPINUSELOCKTIME";
            public const string  PICKFIFOPRTNM = "PICKFIFOPRTNM";
            public const string  PICKNONFIFOPRTNM = "PICKNONFIFOPRTNM";
            public const string  PICKPRTNM = "PICKPRTNM";
            public const string  PLDBKINUSE = "PLDBKINUSE";
            public const string  PLDBKUSEDBY = "PLDBKUSEDBY";
            public const string  PORECOVDBKINUSE = "PORECOVDBKINUSE";
            public const string  PORECOVDBKUSEDBY = "PORECOVDBKUSEDBY";
            public const string  POSTCODE = "POSTCODE";
            public const string  PRECHGDBKINUSE = "PRECHGDBKINUSE";
            public const string  PRECHGDBKUSEDBY = "PRECHGDBKUSEDBY";
            public const string  PREPDBKINUSE = "PREPDBKINUSE";
            public const string  PREPDBKUSEDBY = "PREPDBKUSEDBY";
            public const string  PURINVAUTHAPPBOX = "PURINVAUTHAPPBOX";
            public const string  SALBUSUNITRECNO = "SALBUSUNITRECNO";
            public const string  SALOFFCODE = "SALOFFCODE";
            public const string  SALOFFDDFILENO = "SALOFFDDFILENO";
            public const string  SALOFFDESC = "SALOFFDESC";
            public const string  SEPINVNO = "SEPINVNO";
            public const string  SERVINVINUSE = "SERVINVINUSE";
            public const string  SERVINVLOGONNO = "SERVINVLOGONNO";
            public const string  SERVINVSESSION = "SERVINVSESSION";
            public const string  SINGLECOMLOTS = "SINGLECOMLOTS";
            public const string  SLDBKINUSE = "SLDBKINUSE";
            public const string  SLDBKUSEDBY = "SLDBKUSEDBY";
            public const string  SMNONCASHDESK = "SMNONCASHDESK";
            public const string  STKDISS_USEEXTRACTDT = "STKDISS_USEEXTRACTDT";
            public const string  SUPCLARECNO = "SUPCLARECNO";
            public const string  SUPFOROVERSOLDSTOCK = "SUPFOROVERSOLDSTOCK";
            public const string  TAXDATEBFDLVDATE = "TAXDATEBFDLVDATE";
            public const string  TKT_ALLOWPRCCHGAFTSTKDISS = "TKT_ALLOWPRCCHGAFTSTKDISS";
            public const string  TKTBKMAXNO = "TKTBKMAXNO";
            public const string  TKTBKOFFSET = "TKTBKOFFSET";
            public const string  TKTBKSIZE = "TKTBKSIZE";
            public const string  TKTCASHACC = "TKTCASHACC";
            public const string  TKTCASHACC_COMM = "TKTCASHACC_COMM";
            public const string  TKTCASHACC_DONTHASH = "TKTCASHACC_DONTHASH";
            public const string  TKTFOCREAS_MAND = "TKTFOCREAS_MAND";
            public const string  TKTHASHTOTS_MAND = "TKTHASHTOTS_MAND";
            public const string  TKTSALEAGSTNOSTK = "TKTSALEAGSTNOSTK";
            public const string  TKTWARNOFOVERSELL = "TKTWARNOFOVERSELL";
            public const string  TSHPRPKDBKINUSE = "TSHPRPKDBKINUSE";
            public const string  TSHPRPKDBKUSEDBY = "TSHPRPKDBKUSEDBY";
            public const string  USEADDAUTH = "USEADDAUTH";
            public const string  USEDBY = "USEDBY";
            public const string  USEMANINVASMANSALENTRY = "USEMANINVASMANSALENTRY";
            public const string  USESEQINVNOS = "USESEQINVNOS";
            public const string  USETKTNUMFORSTKSWAP = "USETKTNUMFORSTKSWAP";
            public const string  VATDBKINUSE = "VATDBKINUSE";
            public const string  VATDBKUSEDBY = "VATDBKUSEDBY";
            public const string  WHTAXDBKINUSE = "WHTAXDBKINUSE";
            public const string  WHTAXDBKUSEDBY = "WHTAXDBKUSEDBY";
 // ReSharper restore InconsistentNaming
        }


    }

}
