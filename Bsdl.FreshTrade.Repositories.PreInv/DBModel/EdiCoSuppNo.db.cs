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
    /// Entity for the COSUPPNO table
    /// </summary>
    public partial class EdiCoSuppNo : BaseDbModel<EdiCoSuppNo, EdiCoSuppNoKey>
    {
#region tableDefs

       public static List<EntityPropDef> GetPropDefs() {
         var result = new List<EntityPropDef>();

//EntityPropDef(string propName, string columnName, bool isKey, bool isNullable, string refEntityName, PropertyInfo keyPropInfo,
//            int size, int? prec, int? scale)



         result.Add(new EntityPropDef(
         PropertyHelper <EdiCoSuppNo>.GetProperty(x => x.Hocode),
         "HOCODE", // columnName
         true,                    //isKey
         false, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  10, // int? prec
                           0  // int? Scale
         ,
         typeof(EdiCoSuppNo)
       ));

         result.Add(new EntityPropDef(
         PropertyHelper <EdiCoSuppNo>.GetProperty(x => x.Coglbno),
         "COGLBNO", // columnName
         true,                    //isKey
         false, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  5, // int? prec
                           0  // int? Scale
         ,
         typeof(EdiCoSuppNo)
       ));


         result.Add(new EntityPropDef(
         PropertyHelper <EdiCoSuppNo>.GetProperty(x => x.Allowasngeneratepallets),
         "ALLOWASNGENERATEPALLETS", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  1, // int? prec
                           0  // int? Scale
         ,
         typeof(EdiCoSuppNo)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <EdiCoSuppNo>.GetProperty(x => x.Allownewordersameday),
         "ALLOWNEWORDERSAMEDAY", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  1, // int? prec
                           0  // int? Scale
         ,
         typeof(EdiCoSuppNo)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <EdiCoSuppNo>.GetProperty(x => x.AnsiApplicationreceiverscode),
         "ANSI_APPLICATIONRECEIVERSCODE", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         15,       // int size   
                  null, // int? prec
                   
         null // int? Scale
         ,
         typeof(EdiCoSuppNo)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <EdiCoSuppNo>.GetProperty(x => x.AnsiElementsepchar),
         "ANSI_ELEMENTSEPCHAR", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         1,       // int size   
                  null, // int? prec
                   
         null // int? Scale
         ,
         typeof(EdiCoSuppNo)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <EdiCoSuppNo>.GetProperty(x => x.AnsiFieldsepchar),
         "ANSI_FIELDSEPCHAR", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         1,       // int size   
                  null, // int? prec
                   
         null // int? Scale
         ,
         typeof(EdiCoSuppNo)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <EdiCoSuppNo>.GetProperty(x => x.AnsiInterchngcontrolno),
         "ANSI_INTERCHNGCONTROLNO", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  10, // int? prec
                           0  // int? Scale
         ,
         typeof(EdiCoSuppNo)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <EdiCoSuppNo>.GetProperty(x => x.AnsiInterchngreceiverid),
         "ANSI_INTERCHNGRECEIVERID", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         15,       // int size   
                  null, // int? prec
                   
         null // int? Scale
         ,
         typeof(EdiCoSuppNo)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <EdiCoSuppNo>.GetProperty(x => x.AnsiInterchngreceiverqual),
         "ANSI_INTERCHNGRECEIVERQUAL", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         2,       // int size   
                  null, // int? prec
                   
         null // int? Scale
         ,
         typeof(EdiCoSuppNo)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <EdiCoSuppNo>.GetProperty(x => x.AnsiInterchngsenderid),
         "ANSI_INTERCHNGSENDERID", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         15,       // int size   
                  null, // int? prec
                   
         null // int? Scale
         ,
         typeof(EdiCoSuppNo)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <EdiCoSuppNo>.GetProperty(x => x.AnsiInterchngsenderqual),
         "ANSI_INTERCHNGSENDERQUAL", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         2,       // int size   
                  null, // int? prec
                   
         null // int? Scale
         ,
         typeof(EdiCoSuppNo)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <EdiCoSuppNo>.GetProperty(x => x.AnsiProductqualifier),
         "ANSI_PRODUCTQUALIFIER", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         2,       // int size   
                  null, // int? prec
                   
         null // int? Scale
         ,
         typeof(EdiCoSuppNo)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <EdiCoSuppNo>.GetProperty(x => x.AnsiRefid),
         "ANSI_REFID", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         10,       // int size   
                  null, // int? prec
                   
         null // int? Scale
         ,
         typeof(EdiCoSuppNo)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <EdiCoSuppNo>.GetProperty(x => x.AnsiRefidcode),
         "ANSI_REFIDCODE", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         3,       // int size   
                  null, // int? prec
                   
         null // int? Scale
         ,
         typeof(EdiCoSuppNo)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <EdiCoSuppNo>.GetProperty(x => x.AnsiRepsepchar),
         "ANSI_REPSEPCHAR", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         1,       // int size   
                  null, // int? prec
                   
         null // int? Scale
         ,
         typeof(EdiCoSuppNo)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <EdiCoSuppNo>.GetProperty(x => x.AnsiReqacknowledgement),
         "ANSI_REQACKNOWLEDGEMENT", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  1, // int? prec
                           0  // int? Scale
         ,
         typeof(EdiCoSuppNo)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <EdiCoSuppNo>.GetProperty(x => x.AnsiTestorproduction),
         "ANSI_TESTORPRODUCTION", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         1,       // int size   
                  null, // int? prec
                   
         null // int? Scale
         ,
         typeof(EdiCoSuppNo)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <EdiCoSuppNo>.GetProperty(x => x.AnsiTransactionsetcontrolno),
         "ANSI_TRANSACTIONSETCONTROLNO", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  10, // int? prec
                           0  // int? Scale
         ,
         typeof(EdiCoSuppNo)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <EdiCoSuppNo>.GetProperty(x => x.Asnincludeweight),
         "ASNINCLUDEWEIGHT", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  1, // int? prec
                           0  // int? Scale
         ,
         typeof(EdiCoSuppNo)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <EdiCoSuppNo>.GetProperty(x => x.Asnoneproductperpallet),
         "ASNONEPRODUCTPERPALLET", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  1, // int? prec
                           0  // int? Scale
         ,
         typeof(EdiCoSuppNo)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <EdiCoSuppNo>.GetProperty(x => x.Asnunbana),
         "ASNUNBANA", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         13,       // int size   
                  null, // int? prec
                   
         null // int? Scale
         ,
         typeof(EdiCoSuppNo)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <EdiCoSuppNo>.GetProperty(x => x.Blankildisspaces),
         "BLANKILDISSPACES", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  1, // int? prec
                           0  // int? Scale
         ,
         typeof(EdiCoSuppNo)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <EdiCoSuppNo>.GetProperty(x => x.Blanktransportid),
         "BLANKTRANSPORTID", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  1, // int? prec
                           0  // int? Scale
         ,
         typeof(EdiCoSuppNo)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <EdiCoSuppNo>.GetProperty(x => x.Caselabelprtnm),
         "CASELABELPRTNM", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         20,       // int size   
                  null, // int? prec
                   
         null // int? Scale
         ,
         typeof(EdiCoSuppNo)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <EdiCoSuppNo>.GetProperty(x => x.Caselabelprtor),
         "CASELABELPRTOR", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         1,       // int size   
                  null, // int? prec
                   
         null // int? Scale
         ,
         typeof(EdiCoSuppNo)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <EdiCoSuppNo>.GetProperty(x => x.Combinedeliveries),
         "COMBINEDELIVERIES", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  1, // int? prec
                           0  // int? Scale
         ,
         typeof(EdiCoSuppNo)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <EdiCoSuppNo>.GetProperty(x => x.Crossdockupload),
         "CROSSDOCKUPLOAD", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  1, // int? prec
                           0  // int? Scale
         ,
         typeof(EdiCoSuppNo)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <EdiCoSuppNo>.GetProperty(x => x.Discountcondition),
         "DISCOUNTCONDITION", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         100,       // int size   
                  null, // int? prec
                   
         null // int? Scale
         ,
         typeof(EdiCoSuppNo)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <EdiCoSuppNo>.GetProperty(x => x.Duplicateorders),
         "DUPLICATEORDERS", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         12,       // int size   
                  null, // int? prec
                   
         null // int? Scale
         ,
         typeof(EdiCoSuppNo)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <EdiCoSuppNo>.GetProperty(x => x.Edidbtcdtfileext),
         "EDIDBTCDTFILEEXT", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         3,       // int size   
                  null, // int? prec
                   
         null // int? Scale
         ,
         typeof(EdiCoSuppNo)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <EdiCoSuppNo>.GetProperty(x => x.Edidbtcdtfileprefix),
         "EDIDBTCDTFILEPREFIX", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         2,       // int size   
                  null, // int? prec
                   
         null // int? Scale
         ,
         typeof(EdiCoSuppNo)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <EdiCoSuppNo>.GetProperty(x => x.Edidbtcdtformatrecno),
         "EDIDBTCDTFORMATRECNO", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  10, // int? prec
                           0  // int? Scale
         ,
         typeof(EdiCoSuppNo)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <EdiCoSuppNo>.GetProperty(x => x.Edidbtcdttrnformat),
         "EDIDBTCDTTRNFORMAT", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         12,       // int size   
                  null, // int? prec
                   
         null // int? Scale
         ,
         typeof(EdiCoSuppNo)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <EdiCoSuppNo>.GetProperty(x => x.Edidbtscdts),
         "EDIDBTSCDTS", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         12,       // int size   
                  null, // int? prec
                   
         null // int? Scale
         ,
         typeof(EdiCoSuppNo)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <EdiCoSuppNo>.GetProperty(x => x.Edidelnotefileext),
         "EDIDELNOTEFILEEXT", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         3,       // int size   
                  null, // int? prec
                   
         null // int? Scale
         ,
         typeof(EdiCoSuppNo)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <EdiCoSuppNo>.GetProperty(x => x.Edidelnotefileprefix),
         "EDIDELNOTEFILEPREFIX", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         2,       // int size   
                  null, // int? prec
                   
         null // int? Scale
         ,
         typeof(EdiCoSuppNo)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <EdiCoSuppNo>.GetProperty(x => x.Edidelnoteformatrecno),
         "EDIDELNOTEFORMATRECNO", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  10, // int? prec
                           0  // int? Scale
         ,
         typeof(EdiCoSuppNo)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <EdiCoSuppNo>.GetProperty(x => x.Edidelnotes),
         "EDIDELNOTES", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         12,       // int size   
                  null, // int? prec
                   
         null // int? Scale
         ,
         typeof(EdiCoSuppNo)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <EdiCoSuppNo>.GetProperty(x => x.Edidelnotetrnformat),
         "EDIDELNOTETRNFORMAT", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         12,       // int size   
                  null, // int? prec
                   
         null // int? Scale
         ,
         typeof(EdiCoSuppNo)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <EdiCoSuppNo>.GetProperty(x => x.Ediinvoicefileext),
         "EDIINVOICEFILEEXT", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         3,       // int size   
                  null, // int? prec
                   
         null // int? Scale
         ,
         typeof(EdiCoSuppNo)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <EdiCoSuppNo>.GetProperty(x => x.Ediinvoicefileprefix),
         "EDIINVOICEFILEPREFIX", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         2,       // int size   
                  null, // int? prec
                   
         null // int? Scale
         ,
         typeof(EdiCoSuppNo)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <EdiCoSuppNo>.GetProperty(x => x.Ediinvoiceformatrecno),
         "EDIINVOICEFORMATRECNO", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  10, // int? prec
                           0  // int? Scale
         ,
         typeof(EdiCoSuppNo)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <EdiCoSuppNo>.GetProperty(x => x.Ediinvoicerouting),
         "EDIINVOICEROUTING", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         100,       // int size   
                  null, // int? prec
                   
         null // int? Scale
         ,
         typeof(EdiCoSuppNo)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <EdiCoSuppNo>.GetProperty(x => x.Ediinvoices),
         "EDIINVOICES", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         12,       // int size   
                  null, // int? prec
                   
         null // int? Scale
         ,
         typeof(EdiCoSuppNo)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <EdiCoSuppNo>.GetProperty(x => x.Ediinvoicetrnformat),
         "EDIINVOICETRNFORMAT", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         12,       // int size   
                  null, // int? prec
                   
         null // int? Scale
         ,
         typeof(EdiCoSuppNo)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <EdiCoSuppNo>.GetProperty(x => x.Ediorderfileext),
         "EDIORDERFILEEXT", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         3,       // int size   
                  null, // int? prec
                   
         null // int? Scale
         ,
         typeof(EdiCoSuppNo)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <EdiCoSuppNo>.GetProperty(x => x.Ediorderfileprefix),
         "EDIORDERFILEPREFIX", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         2,       // int size   
                  null, // int? prec
                   
         null // int? Scale
         ,
         typeof(EdiCoSuppNo)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <EdiCoSuppNo>.GetProperty(x => x.Ediorderformatrecno),
         "EDIORDERFORMATRECNO", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  10, // int? prec
                           0  // int? Scale
         ,
         typeof(EdiCoSuppNo)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <EdiCoSuppNo>.GetProperty(x => x.Ediorders),
         "EDIORDERS", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         12,       // int size   
                  null, // int? prec
                   
         null // int? Scale
         ,
         typeof(EdiCoSuppNo)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <EdiCoSuppNo>.GetProperty(x => x.Ediordertrnformat),
         "EDIORDERTRNFORMAT", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         12,       // int size   
                  null, // int? prec
                   
         null // int? Scale
         ,
         typeof(EdiCoSuppNo)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <EdiCoSuppNo>.GetProperty(x => x.Ediprgorderfileext),
         "EDIPRGORDERFILEEXT", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         3,       // int size   
                  null, // int? prec
                   
         null // int? Scale
         ,
         typeof(EdiCoSuppNo)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <EdiCoSuppNo>.GetProperty(x => x.Ediprgorderfileprefix),
         "EDIPRGORDERFILEPREFIX", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         2,       // int size   
                  null, // int? prec
                   
         null // int? Scale
         ,
         typeof(EdiCoSuppNo)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <EdiCoSuppNo>.GetProperty(x => x.Ediprgorderformatrecno),
         "EDIPRGORDERFORMATRECNO", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  10, // int? prec
                           0  // int? Scale
         ,
         typeof(EdiCoSuppNo)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <EdiCoSuppNo>.GetProperty(x => x.Ediprgorders),
         "EDIPRGORDERS", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         12,       // int size   
                  null, // int? prec
                   
         null // int? Scale
         ,
         typeof(EdiCoSuppNo)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <EdiCoSuppNo>.GetProperty(x => x.Ediprgordertrnformat),
         "EDIPRGORDERTRNFORMAT", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         12,       // int size   
                  null, // int? prec
                   
         null // int? Scale
         ,
         typeof(EdiCoSuppNo)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <EdiCoSuppNo>.GetProperty(x => x.Edipricelistfileext),
         "EDIPRICELISTFILEEXT", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         3,       // int size   
                  null, // int? prec
                   
         null // int? Scale
         ,
         typeof(EdiCoSuppNo)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <EdiCoSuppNo>.GetProperty(x => x.Edipricelistfileprefix),
         "EDIPRICELISTFILEPREFIX", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         2,       // int size   
                  null, // int? prec
                   
         null // int? Scale
         ,
         typeof(EdiCoSuppNo)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <EdiCoSuppNo>.GetProperty(x => x.Edipricelistformatrecno),
         "EDIPRICELISTFORMATRECNO", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  10, // int? prec
                           0  // int? Scale
         ,
         typeof(EdiCoSuppNo)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <EdiCoSuppNo>.GetProperty(x => x.Edipricelists),
         "EDIPRICELISTS", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         12,       // int size   
                  null, // int? prec
                   
         null // int? Scale
         ,
         typeof(EdiCoSuppNo)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <EdiCoSuppNo>.GetProperty(x => x.Edipricelistsout),
         "EDIPRICELISTSOUT", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         12,       // int size   
                  null, // int? prec
                   
         null // int? Scale
         ,
         typeof(EdiCoSuppNo)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <EdiCoSuppNo>.GetProperty(x => x.Edipricelisttrnformat),
         "EDIPRICELISTTRNFORMAT", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         12,       // int size   
                  null, // int? prec
                   
         null // int? Scale
         ,
         typeof(EdiCoSuppNo)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <EdiCoSuppNo>.GetProperty(x => x.Ediremitfileext),
         "EDIREMITFILEEXT", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         3,       // int size   
                  null, // int? prec
                   
         null // int? Scale
         ,
         typeof(EdiCoSuppNo)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <EdiCoSuppNo>.GetProperty(x => x.Ediremitfileprefix),
         "EDIREMITFILEPREFIX", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         3,       // int size   
                  null, // int? prec
                   
         null // int? Scale
         ,
         typeof(EdiCoSuppNo)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <EdiCoSuppNo>.GetProperty(x => x.Ediremittances),
         "EDIREMITTANCES", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         3,       // int size   
                  null, // int? prec
                   
         null // int? Scale
         ,
         typeof(EdiCoSuppNo)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <EdiCoSuppNo>.GetProperty(x => x.Ediremittrnformat),
         "EDIREMITTRNFORMAT", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         12,       // int size   
                  null, // int? prec
                   
         null // int? Scale
         ,
         typeof(EdiCoSuppNo)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <EdiCoSuppNo>.GetProperty(x => x.Ediremittrnformatrecno),
         "EDIREMITTRNFORMATRECNO", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  10, // int? prec
                           0  // int? Scale
         ,
         typeof(EdiCoSuppNo)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <EdiCoSuppNo>.GetProperty(x => x.Ediremoveleadzero),
         "EDIREMOVELEADZERO", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  1, // int? prec
                           0  // int? Scale
         ,
         typeof(EdiCoSuppNo)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <EdiCoSuppNo>.GetProperty(x => x.Edishipdesc),
         "EDISHIPDESC", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         12,       // int size   
                  null, // int? prec
                   
         null // int? Scale
         ,
         typeof(EdiCoSuppNo)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <EdiCoSuppNo>.GetProperty(x => x.Edishipext),
         "EDISHIPEXT", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         3,       // int size   
                  null, // int? prec
                   
         null // int? Scale
         ,
         typeof(EdiCoSuppNo)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <EdiCoSuppNo>.GetProperty(x => x.Edishipnxtno),
         "EDISHIPNXTNO", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  10, // int? prec
                           0  // int? Scale
         ,
         typeof(EdiCoSuppNo)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <EdiCoSuppNo>.GetProperty(x => x.Edishipprefix),
         "EDISHIPPREFIX", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         3,       // int size   
                  null, // int? prec
                   
         null // int? Scale
         ,
         typeof(EdiCoSuppNo)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <EdiCoSuppNo>.GetProperty(x => x.Edishiprecno),
         "EDISHIPRECNO", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  10, // int? prec
                           0  // int? Scale
         ,
         typeof(EdiCoSuppNo)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <EdiCoSuppNo>.GetProperty(x => x.Ediuseshipping),
         "EDIUSESHIPPING", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  1, // int? prec
                           0  // int? Scale
         ,
         typeof(EdiCoSuppNo)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <EdiCoSuppNo>.GetProperty(x => x.Exclinvprefix),
         "EXCLINVPREFIX", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  1, // int? prec
                           0  // int? Scale
         ,
         typeof(EdiCoSuppNo)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <EdiCoSuppNo>.GetProperty(x => x.Excludezerogoods),
         "EXCLUDEZEROGOODS", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  1, // int? prec
                           0  // int? Scale
         ,
         typeof(EdiCoSuppNo)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <EdiCoSuppNo>.GetProperty(x => x.Freewayrealeanpos),
         "FREEWAYREALEANPOS", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  5, // int? prec
                           0  // int? Scale
         ,
         typeof(EdiCoSuppNo)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <EdiCoSuppNo>.GetProperty(x => x.Lineterminator),
         "LINETERMINATOR", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         2,       // int size   
                  null, // int? prec
                   
         null // int? Scale
         ,
         typeof(EdiCoSuppNo)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <EdiCoSuppNo>.GetProperty(x => x.Lstcdtout),
         "LSTCDTOUT", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  5, // int? prec
                           0  // int? Scale
         ,
         typeof(EdiCoSuppNo)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <EdiCoSuppNo>.GetProperty(x => x.Lstdelnoteout),
         "LSTDELNOTEOUT", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  5, // int? prec
                           0  // int? Scale
         ,
         typeof(EdiCoSuppNo)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <EdiCoSuppNo>.GetProperty(x => x.Lstinvout),
         "LSTINVOUT", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  10, // int? prec
                           0  // int? Scale
         ,
         typeof(EdiCoSuppNo)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <EdiCoSuppNo>.GetProperty(x => x.Lstordersout),
         "LSTORDERSOUT", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  5, // int? prec
                           0  // int? Scale
         ,
         typeof(EdiCoSuppNo)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <EdiCoSuppNo>.GetProperty(x => x.Lstpricelistout),
         "LSTPRICELISTOUT", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  5, // int? prec
                           0  // int? Scale
         ,
         typeof(EdiCoSuppNo)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <EdiCoSuppNo>.GetProperty(x => x.Newadditions),
         "NEWADDITIONS", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         12,       // int size   
                  null, // int? prec
                   
         null // int? Scale
         ,
         typeof(EdiCoSuppNo)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <EdiCoSuppNo>.GetProperty(x => x.Nxtpredlvtransid),
         "NXTPREDLVTRANSID", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  10, // int? prec
                           0  // int? Scale
         ,
         typeof(EdiCoSuppNo)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <EdiCoSuppNo>.GetProperty(x => x.Orderbydlvdate),
         "ORDERBYDLVDATE", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  1, // int? prec
                           0  // int? Scale
         ,
         typeof(EdiCoSuppNo)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <EdiCoSuppNo>.GetProperty(x => x.Ordernolength),
         "ORDERNOLENGTH", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  5, // int? prec
                           0  // int? Scale
         ,
         typeof(EdiCoSuppNo)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <EdiCoSuppNo>.GetProperty(x => x.Ordernostartposition),
         "ORDERNOSTARTPOSITION", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  5, // int? prec
                           0  // int? Scale
         ,
         typeof(EdiCoSuppNo)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <EdiCoSuppNo>.GetProperty(x => x.Palletlabelprtnm),
         "PALLETLABELPRTNM", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         20,       // int size   
                  null, // int? prec
                   
         null // int? Scale
         ,
         typeof(EdiCoSuppNo)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <EdiCoSuppNo>.GetProperty(x => x.Palletlabelprtor),
         "PALLETLABELPRTOR", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         1,       // int size   
                  null, // int? prec
                   
         null // int? Scale
         ,
         typeof(EdiCoSuppNo)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <EdiCoSuppNo>.GetProperty(x => x.Paymentmethod),
         "PAYMENTMETHOD", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         5,       // int size   
                  null, // int? prec
                   
         null // int? Scale
         ,
         typeof(EdiCoSuppNo)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <EdiCoSuppNo>.GetProperty(x => x.Penaltycondition),
         "PENALTYCONDITION", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         100,       // int size   
                  null, // int? prec
                   
         null // int? Scale
         ,
         typeof(EdiCoSuppNo)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <EdiCoSuppNo>.GetProperty(x => x.Qtychangelog),
         "QTYCHANGELOG", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         12,       // int size   
                  null, // int? prec
                   
         null // int? Scale
         ,
         typeof(EdiCoSuppNo)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <EdiCoSuppNo>.GetProperty(x => x.Qtychanges),
         "QTYCHANGES", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         12,       // int size   
                  null, // int? prec
                   
         null // int? Scale
         ,
         typeof(EdiCoSuppNo)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <EdiCoSuppNo>.GetProperty(x => x.Retrieveby),
         "RETRIEVEBY", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  5, // int? prec
                           0  // int? Scale
         ,
         typeof(EdiCoSuppNo)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <EdiCoSuppNo>.GetProperty(x => x.Retrievehocode),
         "RETRIEVEHOCODE", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  10, // int? prec
                           0  // int? Scale
         ,
         typeof(EdiCoSuppNo)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <EdiCoSuppNo>.GetProperty(x => x.Showtransportid),
         "SHOWTRANSPORTID", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  1, // int? prec
                           0  // int? Scale
         ,
         typeof(EdiCoSuppNo)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <EdiCoSuppNo>.GetProperty(x => x.Supaccno),
         "SUPACCNO", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         13,       // int size   
                  null, // int? prec
                   
         null // int? Scale
         ,
         typeof(EdiCoSuppNo)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <EdiCoSuppNo>.GetProperty(x => x.Supplierrefinorderno),
         "SUPPLIERREFINORDERNO", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  1, // int? prec
                           0  // int? Scale
         ,
         typeof(EdiCoSuppNo)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <EdiCoSuppNo>.GetProperty(x => x.Suppref),
         "SUPPREF", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         8,       // int size   
                  null, // int? prec
                   
         null // int? Scale
         ,
         typeof(EdiCoSuppNo)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <EdiCoSuppNo>.GetProperty(x => x.Tradacomidentity),
         "TRADACOMIDENTITY", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         20,       // int size   
                  null, // int? prec
                   
         null // int? Scale
         ,
         typeof(EdiCoSuppNo)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <EdiCoSuppNo>.GetProperty(x => x.Uploadmissingproducts),
         "UPLOADMISSINGPRODUCTS", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  1, // int? prec
                           0  // int? Scale
         ,
         typeof(EdiCoSuppNo)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <EdiCoSuppNo>.GetProperty(x => x.Usedepotnoasfileext),
         "USEDEPOTNOASFILEEXT", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  1, // int? prec
                           0  // int? Scale
         ,
         typeof(EdiCoSuppNo)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <EdiCoSuppNo>.GetProperty(x => x.Useearlydlvdate),
         "USEEARLYDLVDATE", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  1, // int? prec
                           0  // int? Scale
         ,
         typeof(EdiCoSuppNo)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <EdiCoSuppNo>.GetProperty(x => x.Usetradedunitinild),
         "USETRADEDUNITINILD", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  1, // int? prec
                           0  // int? Scale
         ,
         typeof(EdiCoSuppNo)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <EdiCoSuppNo>.GetProperty(x => x.Vatnbrinfreeway),
         "VATNBRINFREEWAY", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  1, // int? prec
                           0  // int? Scale
         ,
         typeof(EdiCoSuppNo)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <EdiCoSuppNo>.GetProperty(x => x.Writeweeklyorders),
         "WRITEWEEKLYORDERS", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  1, // int? prec
                           0  // int? Scale
         ,
         typeof(EdiCoSuppNo)
         ));
         return result; 
       }

#endregion     
        private int _fHocode;
        public int Hocode
        {
            get { return _fHocode; }
            set
            {
                var oldKey = Key;
                if (_fHocode != value)
                {
                    Modify();
                    _fHocode = value;
                    KeyChanged(oldKey);
                }
            }
        }

        private int _fCoglbno;
        public int Coglbno
        {
            get { return _fCoglbno; }
            set
            {
                var oldKey = Key;
                if (_fCoglbno != value)
                {
                    Modify();
                    _fCoglbno = value;
                    KeyChanged(oldKey);
                }
            }
        }

        private short? _fAllowasngeneratepallets;
        public short? Allowasngeneratepallets
        {
            get { return _fAllowasngeneratepallets; }
            set
            {
                if (_fAllowasngeneratepallets != value)
                {
                    Modify();
                    _fAllowasngeneratepallets = value;
                }
            }
        }

        private short? _fAllownewordersameday;
        public short? Allownewordersameday
        {
            get { return _fAllownewordersameday; }
            set
            {
                if (_fAllownewordersameday != value)
                {
                    Modify();
                    _fAllownewordersameday = value;
                }
            }
        }

        private string _fAnsiApplicationreceiverscode;
        public string AnsiApplicationreceiverscode
        {
            get { return _fAnsiApplicationreceiverscode; }
            set
            {
                if (_fAnsiApplicationreceiverscode != value)
                {
                    Modify();
                    _fAnsiApplicationreceiverscode = value;
                }
            }
        }

        private string _fAnsiElementsepchar;
        public string AnsiElementsepchar
        {
            get { return _fAnsiElementsepchar; }
            set
            {
                if (_fAnsiElementsepchar != value)
                {
                    Modify();
                    _fAnsiElementsepchar = value;
                }
            }
        }

        private string _fAnsiFieldsepchar;
        public string AnsiFieldsepchar
        {
            get { return _fAnsiFieldsepchar; }
            set
            {
                if (_fAnsiFieldsepchar != value)
                {
                    Modify();
                    _fAnsiFieldsepchar = value;
                }
            }
        }

        private int? _fAnsiInterchngcontrolno;
        public int? AnsiInterchngcontrolno
        {
            get { return _fAnsiInterchngcontrolno; }
            set
            {
                if (_fAnsiInterchngcontrolno != value)
                {
                    Modify();
                    _fAnsiInterchngcontrolno = value;
                }
            }
        }

        private string _fAnsiInterchngreceiverid;
        public string AnsiInterchngreceiverid
        {
            get { return _fAnsiInterchngreceiverid; }
            set
            {
                if (_fAnsiInterchngreceiverid != value)
                {
                    Modify();
                    _fAnsiInterchngreceiverid = value;
                }
            }
        }

        private string _fAnsiInterchngreceiverqual;
        public string AnsiInterchngreceiverqual
        {
            get { return _fAnsiInterchngreceiverqual; }
            set
            {
                if (_fAnsiInterchngreceiverqual != value)
                {
                    Modify();
                    _fAnsiInterchngreceiverqual = value;
                }
            }
        }

        private string _fAnsiInterchngsenderid;
        public string AnsiInterchngsenderid
        {
            get { return _fAnsiInterchngsenderid; }
            set
            {
                if (_fAnsiInterchngsenderid != value)
                {
                    Modify();
                    _fAnsiInterchngsenderid = value;
                }
            }
        }

        private string _fAnsiInterchngsenderqual;
        public string AnsiInterchngsenderqual
        {
            get { return _fAnsiInterchngsenderqual; }
            set
            {
                if (_fAnsiInterchngsenderqual != value)
                {
                    Modify();
                    _fAnsiInterchngsenderqual = value;
                }
            }
        }

        private string _fAnsiProductqualifier;
        public string AnsiProductqualifier
        {
            get { return _fAnsiProductqualifier; }
            set
            {
                if (_fAnsiProductqualifier != value)
                {
                    Modify();
                    _fAnsiProductqualifier = value;
                }
            }
        }

        private string _fAnsiRefid;
        public string AnsiRefid
        {
            get { return _fAnsiRefid; }
            set
            {
                if (_fAnsiRefid != value)
                {
                    Modify();
                    _fAnsiRefid = value;
                }
            }
        }

        private string _fAnsiRefidcode;
        public string AnsiRefidcode
        {
            get { return _fAnsiRefidcode; }
            set
            {
                if (_fAnsiRefidcode != value)
                {
                    Modify();
                    _fAnsiRefidcode = value;
                }
            }
        }

        private string _fAnsiRepsepchar;
        public string AnsiRepsepchar
        {
            get { return _fAnsiRepsepchar; }
            set
            {
                if (_fAnsiRepsepchar != value)
                {
                    Modify();
                    _fAnsiRepsepchar = value;
                }
            }
        }

        private short? _fAnsiReqacknowledgement;
        public short? AnsiReqacknowledgement
        {
            get { return _fAnsiReqacknowledgement; }
            set
            {
                if (_fAnsiReqacknowledgement != value)
                {
                    Modify();
                    _fAnsiReqacknowledgement = value;
                }
            }
        }

        private string _fAnsiTestorproduction;
        public string AnsiTestorproduction
        {
            get { return _fAnsiTestorproduction; }
            set
            {
                if (_fAnsiTestorproduction != value)
                {
                    Modify();
                    _fAnsiTestorproduction = value;
                }
            }
        }

        private int? _fAnsiTransactionsetcontrolno;
        public int? AnsiTransactionsetcontrolno
        {
            get { return _fAnsiTransactionsetcontrolno; }
            set
            {
                if (_fAnsiTransactionsetcontrolno != value)
                {
                    Modify();
                    _fAnsiTransactionsetcontrolno = value;
                }
            }
        }

        private short? _fAsnincludeweight;
        public short? Asnincludeweight
        {
            get { return _fAsnincludeweight; }
            set
            {
                if (_fAsnincludeweight != value)
                {
                    Modify();
                    _fAsnincludeweight = value;
                }
            }
        }

        private short? _fAsnoneproductperpallet;
        public short? Asnoneproductperpallet
        {
            get { return _fAsnoneproductperpallet; }
            set
            {
                if (_fAsnoneproductperpallet != value)
                {
                    Modify();
                    _fAsnoneproductperpallet = value;
                }
            }
        }

        private string _fAsnunbana;
        public string Asnunbana
        {
            get { return _fAsnunbana; }
            set
            {
                if (_fAsnunbana != value)
                {
                    Modify();
                    _fAsnunbana = value;
                }
            }
        }

        private short? _fBlankildisspaces;
        public short? Blankildisspaces
        {
            get { return _fBlankildisspaces; }
            set
            {
                if (_fBlankildisspaces != value)
                {
                    Modify();
                    _fBlankildisspaces = value;
                }
            }
        }

        private short? _fBlanktransportid;
        public short? Blanktransportid
        {
            get { return _fBlanktransportid; }
            set
            {
                if (_fBlanktransportid != value)
                {
                    Modify();
                    _fBlanktransportid = value;
                }
            }
        }

        private string _fCaselabelprtnm;
        public string Caselabelprtnm
        {
            get { return _fCaselabelprtnm; }
            set
            {
                if (_fCaselabelprtnm != value)
                {
                    Modify();
                    _fCaselabelprtnm = value;
                }
            }
        }

        private string _fCaselabelprtor;
        public string Caselabelprtor
        {
            get { return _fCaselabelprtor; }
            set
            {
                if (_fCaselabelprtor != value)
                {
                    Modify();
                    _fCaselabelprtor = value;
                }
            }
        }

        private short? _fCombinedeliveries;
        public short? Combinedeliveries
        {
            get { return _fCombinedeliveries; }
            set
            {
                if (_fCombinedeliveries != value)
                {
                    Modify();
                    _fCombinedeliveries = value;
                }
            }
        }

        private short? _fCrossdockupload;
        public short? Crossdockupload
        {
            get { return _fCrossdockupload; }
            set
            {
                if (_fCrossdockupload != value)
                {
                    Modify();
                    _fCrossdockupload = value;
                }
            }
        }

        private string _fDiscountcondition;
        public string Discountcondition
        {
            get { return _fDiscountcondition; }
            set
            {
                if (_fDiscountcondition != value)
                {
                    Modify();
                    _fDiscountcondition = value;
                }
            }
        }

        private string _fDuplicateorders;
        public string Duplicateorders
        {
            get { return _fDuplicateorders; }
            set
            {
                if (_fDuplicateorders != value)
                {
                    Modify();
                    _fDuplicateorders = value;
                }
            }
        }

        private string _fEdidbtcdtfileext;
        public string Edidbtcdtfileext
        {
            get { return _fEdidbtcdtfileext; }
            set
            {
                if (_fEdidbtcdtfileext != value)
                {
                    Modify();
                    _fEdidbtcdtfileext = value;
                }
            }
        }

        private string _fEdidbtcdtfileprefix;
        public string Edidbtcdtfileprefix
        {
            get { return _fEdidbtcdtfileprefix; }
            set
            {
                if (_fEdidbtcdtfileprefix != value)
                {
                    Modify();
                    _fEdidbtcdtfileprefix = value;
                }
            }
        }

        private int? _fEdidbtcdtformatrecno;
        public int? Edidbtcdtformatrecno
        {
            get { return _fEdidbtcdtformatrecno; }
            set
            {
                if (_fEdidbtcdtformatrecno != value)
                {
                    Modify();
                    _fEdidbtcdtformatrecno = value;
                }
            }
        }

        private string _fEdidbtcdttrnformat;
        public string Edidbtcdttrnformat
        {
            get { return _fEdidbtcdttrnformat; }
            set
            {
                if (_fEdidbtcdttrnformat != value)
                {
                    Modify();
                    _fEdidbtcdttrnformat = value;
                }
            }
        }

        private string _fEdidbtscdts;
        public string Edidbtscdts
        {
            get { return _fEdidbtscdts; }
            set
            {
                if (_fEdidbtscdts != value)
                {
                    Modify();
                    _fEdidbtscdts = value;
                }
            }
        }

        private string _fEdidelnotefileext;
        public string Edidelnotefileext
        {
            get { return _fEdidelnotefileext; }
            set
            {
                if (_fEdidelnotefileext != value)
                {
                    Modify();
                    _fEdidelnotefileext = value;
                }
            }
        }

        private string _fEdidelnotefileprefix;
        public string Edidelnotefileprefix
        {
            get { return _fEdidelnotefileprefix; }
            set
            {
                if (_fEdidelnotefileprefix != value)
                {
                    Modify();
                    _fEdidelnotefileprefix = value;
                }
            }
        }

        private int? _fEdidelnoteformatrecno;
        public int? Edidelnoteformatrecno
        {
            get { return _fEdidelnoteformatrecno; }
            set
            {
                if (_fEdidelnoteformatrecno != value)
                {
                    Modify();
                    _fEdidelnoteformatrecno = value;
                }
            }
        }

        private string _fEdidelnotes;
        public string Edidelnotes
        {
            get { return _fEdidelnotes; }
            set
            {
                if (_fEdidelnotes != value)
                {
                    Modify();
                    _fEdidelnotes = value;
                }
            }
        }

        private string _fEdidelnotetrnformat;
        public string Edidelnotetrnformat
        {
            get { return _fEdidelnotetrnformat; }
            set
            {
                if (_fEdidelnotetrnformat != value)
                {
                    Modify();
                    _fEdidelnotetrnformat = value;
                }
            }
        }

        private string _fEdiinvoicefileext;
        public string Ediinvoicefileext
        {
            get { return _fEdiinvoicefileext; }
            set
            {
                if (_fEdiinvoicefileext != value)
                {
                    Modify();
                    _fEdiinvoicefileext = value;
                }
            }
        }

        private string _fEdiinvoicefileprefix;
        public string Ediinvoicefileprefix
        {
            get { return _fEdiinvoicefileprefix; }
            set
            {
                if (_fEdiinvoicefileprefix != value)
                {
                    Modify();
                    _fEdiinvoicefileprefix = value;
                }
            }
        }

        private int? _fEdiinvoiceformatrecno;
        public int? Ediinvoiceformatrecno
        {
            get { return _fEdiinvoiceformatrecno; }
            set
            {
                if (_fEdiinvoiceformatrecno != value)
                {
                    Modify();
                    _fEdiinvoiceformatrecno = value;
                }
            }
        }

        private string _fEdiinvoicerouting;
        public string Ediinvoicerouting
        {
            get { return _fEdiinvoicerouting; }
            set
            {
                if (_fEdiinvoicerouting != value)
                {
                    Modify();
                    _fEdiinvoicerouting = value;
                }
            }
        }

        private string _fEdiinvoices;
        public string Ediinvoices
        {
            get { return _fEdiinvoices; }
            set
            {
                if (_fEdiinvoices != value)
                {
                    Modify();
                    _fEdiinvoices = value;
                }
            }
        }

        private string _fEdiinvoicetrnformat;
        public string Ediinvoicetrnformat
        {
            get { return _fEdiinvoicetrnformat; }
            set
            {
                if (_fEdiinvoicetrnformat != value)
                {
                    Modify();
                    _fEdiinvoicetrnformat = value;
                }
            }
        }

        private string _fEdiorderfileext;
        public string Ediorderfileext
        {
            get { return _fEdiorderfileext; }
            set
            {
                if (_fEdiorderfileext != value)
                {
                    Modify();
                    _fEdiorderfileext = value;
                }
            }
        }

        private string _fEdiorderfileprefix;
        public string Ediorderfileprefix
        {
            get { return _fEdiorderfileprefix; }
            set
            {
                if (_fEdiorderfileprefix != value)
                {
                    Modify();
                    _fEdiorderfileprefix = value;
                }
            }
        }

        private int? _fEdiorderformatrecno;
        public int? Ediorderformatrecno
        {
            get { return _fEdiorderformatrecno; }
            set
            {
                if (_fEdiorderformatrecno != value)
                {
                    Modify();
                    _fEdiorderformatrecno = value;
                }
            }
        }

        private string _fEdiorders;
        public string Ediorders
        {
            get { return _fEdiorders; }
            set
            {
                if (_fEdiorders != value)
                {
                    Modify();
                    _fEdiorders = value;
                }
            }
        }

        private string _fEdiordertrnformat;
        public string Ediordertrnformat
        {
            get { return _fEdiordertrnformat; }
            set
            {
                if (_fEdiordertrnformat != value)
                {
                    Modify();
                    _fEdiordertrnformat = value;
                }
            }
        }

        private string _fEdiprgorderfileext;
        public string Ediprgorderfileext
        {
            get { return _fEdiprgorderfileext; }
            set
            {
                if (_fEdiprgorderfileext != value)
                {
                    Modify();
                    _fEdiprgorderfileext = value;
                }
            }
        }

        private string _fEdiprgorderfileprefix;
        public string Ediprgorderfileprefix
        {
            get { return _fEdiprgorderfileprefix; }
            set
            {
                if (_fEdiprgorderfileprefix != value)
                {
                    Modify();
                    _fEdiprgorderfileprefix = value;
                }
            }
        }

        private int? _fEdiprgorderformatrecno;
        public int? Ediprgorderformatrecno
        {
            get { return _fEdiprgorderformatrecno; }
            set
            {
                if (_fEdiprgorderformatrecno != value)
                {
                    Modify();
                    _fEdiprgorderformatrecno = value;
                }
            }
        }

        private string _fEdiprgorders;
        public string Ediprgorders
        {
            get { return _fEdiprgorders; }
            set
            {
                if (_fEdiprgorders != value)
                {
                    Modify();
                    _fEdiprgorders = value;
                }
            }
        }

        private string _fEdiprgordertrnformat;
        public string Ediprgordertrnformat
        {
            get { return _fEdiprgordertrnformat; }
            set
            {
                if (_fEdiprgordertrnformat != value)
                {
                    Modify();
                    _fEdiprgordertrnformat = value;
                }
            }
        }

        private string _fEdipricelistfileext;
        public string Edipricelistfileext
        {
            get { return _fEdipricelistfileext; }
            set
            {
                if (_fEdipricelistfileext != value)
                {
                    Modify();
                    _fEdipricelistfileext = value;
                }
            }
        }

        private string _fEdipricelistfileprefix;
        public string Edipricelistfileprefix
        {
            get { return _fEdipricelistfileprefix; }
            set
            {
                if (_fEdipricelistfileprefix != value)
                {
                    Modify();
                    _fEdipricelistfileprefix = value;
                }
            }
        }

        private int? _fEdipricelistformatrecno;
        public int? Edipricelistformatrecno
        {
            get { return _fEdipricelistformatrecno; }
            set
            {
                if (_fEdipricelistformatrecno != value)
                {
                    Modify();
                    _fEdipricelistformatrecno = value;
                }
            }
        }

        private string _fEdipricelists;
        public string Edipricelists
        {
            get { return _fEdipricelists; }
            set
            {
                if (_fEdipricelists != value)
                {
                    Modify();
                    _fEdipricelists = value;
                }
            }
        }

        private string _fEdipricelistsout;
        public string Edipricelistsout
        {
            get { return _fEdipricelistsout; }
            set
            {
                if (_fEdipricelistsout != value)
                {
                    Modify();
                    _fEdipricelistsout = value;
                }
            }
        }

        private string _fEdipricelisttrnformat;
        public string Edipricelisttrnformat
        {
            get { return _fEdipricelisttrnformat; }
            set
            {
                if (_fEdipricelisttrnformat != value)
                {
                    Modify();
                    _fEdipricelisttrnformat = value;
                }
            }
        }

        private string _fEdiremitfileext;
        public string Ediremitfileext
        {
            get { return _fEdiremitfileext; }
            set
            {
                if (_fEdiremitfileext != value)
                {
                    Modify();
                    _fEdiremitfileext = value;
                }
            }
        }

        private string _fEdiremitfileprefix;
        public string Ediremitfileprefix
        {
            get { return _fEdiremitfileprefix; }
            set
            {
                if (_fEdiremitfileprefix != value)
                {
                    Modify();
                    _fEdiremitfileprefix = value;
                }
            }
        }

        private string _fEdiremittances;
        public string Ediremittances
        {
            get { return _fEdiremittances; }
            set
            {
                if (_fEdiremittances != value)
                {
                    Modify();
                    _fEdiremittances = value;
                }
            }
        }

        private string _fEdiremittrnformat;
        public string Ediremittrnformat
        {
            get { return _fEdiremittrnformat; }
            set
            {
                if (_fEdiremittrnformat != value)
                {
                    Modify();
                    _fEdiremittrnformat = value;
                }
            }
        }

        private int? _fEdiremittrnformatrecno;
        public int? Ediremittrnformatrecno
        {
            get { return _fEdiremittrnformatrecno; }
            set
            {
                if (_fEdiremittrnformatrecno != value)
                {
                    Modify();
                    _fEdiremittrnformatrecno = value;
                }
            }
        }

        private short? _fEdiremoveleadzero;
        public short? Ediremoveleadzero
        {
            get { return _fEdiremoveleadzero; }
            set
            {
                if (_fEdiremoveleadzero != value)
                {
                    Modify();
                    _fEdiremoveleadzero = value;
                }
            }
        }

        private string _fEdishipdesc;
        public string Edishipdesc
        {
            get { return _fEdishipdesc; }
            set
            {
                if (_fEdishipdesc != value)
                {
                    Modify();
                    _fEdishipdesc = value;
                }
            }
        }

        private string _fEdishipext;
        public string Edishipext
        {
            get { return _fEdishipext; }
            set
            {
                if (_fEdishipext != value)
                {
                    Modify();
                    _fEdishipext = value;
                }
            }
        }

        private int? _fEdishipnxtno;
        public int? Edishipnxtno
        {
            get { return _fEdishipnxtno; }
            set
            {
                if (_fEdishipnxtno != value)
                {
                    Modify();
                    _fEdishipnxtno = value;
                }
            }
        }

        private string _fEdishipprefix;
        public string Edishipprefix
        {
            get { return _fEdishipprefix; }
            set
            {
                if (_fEdishipprefix != value)
                {
                    Modify();
                    _fEdishipprefix = value;
                }
            }
        }

        private int? _fEdishiprecno;
        public int? Edishiprecno
        {
            get { return _fEdishiprecno; }
            set
            {
                if (_fEdishiprecno != value)
                {
                    Modify();
                    _fEdishiprecno = value;
                }
            }
        }

        private short? _fEdiuseshipping;
        public short? Ediuseshipping
        {
            get { return _fEdiuseshipping; }
            set
            {
                if (_fEdiuseshipping != value)
                {
                    Modify();
                    _fEdiuseshipping = value;
                }
            }
        }

        private short? _fExclinvprefix;
        public short? Exclinvprefix
        {
            get { return _fExclinvprefix; }
            set
            {
                if (_fExclinvprefix != value)
                {
                    Modify();
                    _fExclinvprefix = value;
                }
            }
        }

        private short? _fExcludezerogoods;
        public short? Excludezerogoods
        {
            get { return _fExcludezerogoods; }
            set
            {
                if (_fExcludezerogoods != value)
                {
                    Modify();
                    _fExcludezerogoods = value;
                }
            }
        }

        private int? _fFreewayrealeanpos;
        public int? Freewayrealeanpos
        {
            get { return _fFreewayrealeanpos; }
            set
            {
                if (_fFreewayrealeanpos != value)
                {
                    Modify();
                    _fFreewayrealeanpos = value;
                }
            }
        }

        private string _fLineterminator;
        public string Lineterminator
        {
            get { return _fLineterminator; }
            set
            {
                if (_fLineterminator != value)
                {
                    Modify();
                    _fLineterminator = value;
                }
            }
        }

        private int? _fLstcdtout;
        public int? Lstcdtout
        {
            get { return _fLstcdtout; }
            set
            {
                if (_fLstcdtout != value)
                {
                    Modify();
                    _fLstcdtout = value;
                }
            }
        }

        private int? _fLstdelnoteout;
        public int? Lstdelnoteout
        {
            get { return _fLstdelnoteout; }
            set
            {
                if (_fLstdelnoteout != value)
                {
                    Modify();
                    _fLstdelnoteout = value;
                }
            }
        }

        private int? _fLstinvout;
        public int? Lstinvout
        {
            get { return _fLstinvout; }
            set
            {
                if (_fLstinvout != value)
                {
                    Modify();
                    _fLstinvout = value;
                }
            }
        }

        private int? _fLstordersout;
        public int? Lstordersout
        {
            get { return _fLstordersout; }
            set
            {
                if (_fLstordersout != value)
                {
                    Modify();
                    _fLstordersout = value;
                }
            }
        }

        private int? _fLstpricelistout;
        public int? Lstpricelistout
        {
            get { return _fLstpricelistout; }
            set
            {
                if (_fLstpricelistout != value)
                {
                    Modify();
                    _fLstpricelistout = value;
                }
            }
        }

        private string _fNewadditions;
        public string Newadditions
        {
            get { return _fNewadditions; }
            set
            {
                if (_fNewadditions != value)
                {
                    Modify();
                    _fNewadditions = value;
                }
            }
        }

        private int? _fNxtpredlvtransid;
        public int? Nxtpredlvtransid
        {
            get { return _fNxtpredlvtransid; }
            set
            {
                if (_fNxtpredlvtransid != value)
                {
                    Modify();
                    _fNxtpredlvtransid = value;
                }
            }
        }

        private short? _fOrderbydlvdate;
        public short? Orderbydlvdate
        {
            get { return _fOrderbydlvdate; }
            set
            {
                if (_fOrderbydlvdate != value)
                {
                    Modify();
                    _fOrderbydlvdate = value;
                }
            }
        }

        private int? _fOrdernolength;
        public int? Ordernolength
        {
            get { return _fOrdernolength; }
            set
            {
                if (_fOrdernolength != value)
                {
                    Modify();
                    _fOrdernolength = value;
                }
            }
        }

        private int? _fOrdernostartposition;
        public int? Ordernostartposition
        {
            get { return _fOrdernostartposition; }
            set
            {
                if (_fOrdernostartposition != value)
                {
                    Modify();
                    _fOrdernostartposition = value;
                }
            }
        }

        private string _fPalletlabelprtnm;
        public string Palletlabelprtnm
        {
            get { return _fPalletlabelprtnm; }
            set
            {
                if (_fPalletlabelprtnm != value)
                {
                    Modify();
                    _fPalletlabelprtnm = value;
                }
            }
        }

        private string _fPalletlabelprtor;
        public string Palletlabelprtor
        {
            get { return _fPalletlabelprtor; }
            set
            {
                if (_fPalletlabelprtor != value)
                {
                    Modify();
                    _fPalletlabelprtor = value;
                }
            }
        }

        private string _fPaymentmethod;
        public string Paymentmethod
        {
            get { return _fPaymentmethod; }
            set
            {
                if (_fPaymentmethod != value)
                {
                    Modify();
                    _fPaymentmethod = value;
                }
            }
        }

        private string _fPenaltycondition;
        public string Penaltycondition
        {
            get { return _fPenaltycondition; }
            set
            {
                if (_fPenaltycondition != value)
                {
                    Modify();
                    _fPenaltycondition = value;
                }
            }
        }

        private string _fQtychangelog;
        public string Qtychangelog
        {
            get { return _fQtychangelog; }
            set
            {
                if (_fQtychangelog != value)
                {
                    Modify();
                    _fQtychangelog = value;
                }
            }
        }

        private string _fQtychanges;
        public string Qtychanges
        {
            get { return _fQtychanges; }
            set
            {
                if (_fQtychanges != value)
                {
                    Modify();
                    _fQtychanges = value;
                }
            }
        }

        private int? _fRetrieveby;
        public int? Retrieveby
        {
            get { return _fRetrieveby; }
            set
            {
                if (_fRetrieveby != value)
                {
                    Modify();
                    _fRetrieveby = value;
                }
            }
        }

        private int? _fRetrievehocode;
        public int? Retrievehocode
        {
            get { return _fRetrievehocode; }
            set
            {
                if (_fRetrievehocode != value)
                {
                    Modify();
                    _fRetrievehocode = value;
                }
            }
        }

        private short? _fShowtransportid;
        public short? Showtransportid
        {
            get { return _fShowtransportid; }
            set
            {
                if (_fShowtransportid != value)
                {
                    Modify();
                    _fShowtransportid = value;
                }
            }
        }

        private string _fSupaccno;
        public string Supaccno
        {
            get { return _fSupaccno; }
            set
            {
                if (_fSupaccno != value)
                {
                    Modify();
                    _fSupaccno = value;
                }
            }
        }

        private short? _fSupplierrefinorderno;
        public short? Supplierrefinorderno
        {
            get { return _fSupplierrefinorderno; }
            set
            {
                if (_fSupplierrefinorderno != value)
                {
                    Modify();
                    _fSupplierrefinorderno = value;
                }
            }
        }

        private string _fSuppref;
        public string Suppref
        {
            get { return _fSuppref; }
            set
            {
                if (_fSuppref != value)
                {
                    Modify();
                    _fSuppref = value;
                }
            }
        }

        private string _fTradacomidentity;
        public string Tradacomidentity
        {
            get { return _fTradacomidentity; }
            set
            {
                if (_fTradacomidentity != value)
                {
                    Modify();
                    _fTradacomidentity = value;
                }
            }
        }

        private short? _fUploadmissingproducts;
        public short? Uploadmissingproducts
        {
            get { return _fUploadmissingproducts; }
            set
            {
                if (_fUploadmissingproducts != value)
                {
                    Modify();
                    _fUploadmissingproducts = value;
                }
            }
        }

        private short? _fUsedepotnoasfileext;
        public short? Usedepotnoasfileext
        {
            get { return _fUsedepotnoasfileext; }
            set
            {
                if (_fUsedepotnoasfileext != value)
                {
                    Modify();
                    _fUsedepotnoasfileext = value;
                }
            }
        }

        private short? _fUseearlydlvdate;
        public short? Useearlydlvdate
        {
            get { return _fUseearlydlvdate; }
            set
            {
                if (_fUseearlydlvdate != value)
                {
                    Modify();
                    _fUseearlydlvdate = value;
                }
            }
        }

        private short? _fUsetradedunitinild;
        public short? Usetradedunitinild
        {
            get { return _fUsetradedunitinild; }
            set
            {
                if (_fUsetradedunitinild != value)
                {
                    Modify();
                    _fUsetradedunitinild = value;
                }
            }
        }

        private short? _fVatnbrinfreeway;
        public short? Vatnbrinfreeway
        {
            get { return _fVatnbrinfreeway; }
            set
            {
                if (_fVatnbrinfreeway != value)
                {
                    Modify();
                    _fVatnbrinfreeway = value;
                }
            }
        }

        private short? _fWriteweeklyorders;
        public short? Writeweeklyorders
        {
            get { return _fWriteweeklyorders; }
            set
            {
                if (_fWriteweeklyorders != value)
                {
                    Modify();
                    _fWriteweeklyorders = value;
                }
            }
        }

        public override EdiCoSuppNoKey Key
        {
            get
            {
                return new EdiCoSuppNoKey { Hocode = Hocode, Coglbno = Coglbno };
            }
            set
            {
                if (value == null)
                    throw new ArgumentNullException("value", "Entity key can not be null.");
                Hocode = value.Hocode;
                Coglbno = value.Coglbno;
            }
        }

        public override string KeyAsString { get { return Key.AsString; } }


        public override EdiCoSuppNo Clone()
        {
            var obj = new EdiCoSuppNo
                {
                    Hocode = Hocode,
                    Coglbno = Coglbno,
                    Allowasngeneratepallets = Allowasngeneratepallets,
                    Allownewordersameday = Allownewordersameday,
                    AnsiApplicationreceiverscode = AnsiApplicationreceiverscode,
                    AnsiElementsepchar = AnsiElementsepchar,
                    AnsiFieldsepchar = AnsiFieldsepchar,
                    AnsiInterchngcontrolno = AnsiInterchngcontrolno,
                    AnsiInterchngreceiverid = AnsiInterchngreceiverid,
                    AnsiInterchngreceiverqual = AnsiInterchngreceiverqual,
                    AnsiInterchngsenderid = AnsiInterchngsenderid,
                    AnsiInterchngsenderqual = AnsiInterchngsenderqual,
                    AnsiProductqualifier = AnsiProductqualifier,
                    AnsiRefid = AnsiRefid,
                    AnsiRefidcode = AnsiRefidcode,
                    AnsiRepsepchar = AnsiRepsepchar,
                    AnsiReqacknowledgement = AnsiReqacknowledgement,
                    AnsiTestorproduction = AnsiTestorproduction,
                    AnsiTransactionsetcontrolno = AnsiTransactionsetcontrolno,
                    Asnincludeweight = Asnincludeweight,
                    Asnoneproductperpallet = Asnoneproductperpallet,
                    Asnunbana = Asnunbana,
                    Blankildisspaces = Blankildisspaces,
                    Blanktransportid = Blanktransportid,
                    Caselabelprtnm = Caselabelprtnm,
                    Caselabelprtor = Caselabelprtor,
                    Combinedeliveries = Combinedeliveries,
                    Crossdockupload = Crossdockupload,
                    Discountcondition = Discountcondition,
                    Duplicateorders = Duplicateorders,
                    Edidbtcdtfileext = Edidbtcdtfileext,
                    Edidbtcdtfileprefix = Edidbtcdtfileprefix,
                    Edidbtcdtformatrecno = Edidbtcdtformatrecno,
                    Edidbtcdttrnformat = Edidbtcdttrnformat,
                    Edidbtscdts = Edidbtscdts,
                    Edidelnotefileext = Edidelnotefileext,
                    Edidelnotefileprefix = Edidelnotefileprefix,
                    Edidelnoteformatrecno = Edidelnoteformatrecno,
                    Edidelnotes = Edidelnotes,
                    Edidelnotetrnformat = Edidelnotetrnformat,
                    Ediinvoicefileext = Ediinvoicefileext,
                    Ediinvoicefileprefix = Ediinvoicefileprefix,
                    Ediinvoiceformatrecno = Ediinvoiceformatrecno,
                    Ediinvoicerouting = Ediinvoicerouting,
                    Ediinvoices = Ediinvoices,
                    Ediinvoicetrnformat = Ediinvoicetrnformat,
                    Ediorderfileext = Ediorderfileext,
                    Ediorderfileprefix = Ediorderfileprefix,
                    Ediorderformatrecno = Ediorderformatrecno,
                    Ediorders = Ediorders,
                    Ediordertrnformat = Ediordertrnformat,
                    Ediprgorderfileext = Ediprgorderfileext,
                    Ediprgorderfileprefix = Ediprgorderfileprefix,
                    Ediprgorderformatrecno = Ediprgorderformatrecno,
                    Ediprgorders = Ediprgorders,
                    Ediprgordertrnformat = Ediprgordertrnformat,
                    Edipricelistfileext = Edipricelistfileext,
                    Edipricelistfileprefix = Edipricelistfileprefix,
                    Edipricelistformatrecno = Edipricelistformatrecno,
                    Edipricelists = Edipricelists,
                    Edipricelistsout = Edipricelistsout,
                    Edipricelisttrnformat = Edipricelisttrnformat,
                    Ediremitfileext = Ediremitfileext,
                    Ediremitfileprefix = Ediremitfileprefix,
                    Ediremittances = Ediremittances,
                    Ediremittrnformat = Ediremittrnformat,
                    Ediremittrnformatrecno = Ediremittrnformatrecno,
                    Ediremoveleadzero = Ediremoveleadzero,
                    Edishipdesc = Edishipdesc,
                    Edishipext = Edishipext,
                    Edishipnxtno = Edishipnxtno,
                    Edishipprefix = Edishipprefix,
                    Edishiprecno = Edishiprecno,
                    Ediuseshipping = Ediuseshipping,
                    Exclinvprefix = Exclinvprefix,
                    Excludezerogoods = Excludezerogoods,
                    Freewayrealeanpos = Freewayrealeanpos,
                    Lineterminator = Lineterminator,
                    Lstcdtout = Lstcdtout,
                    Lstdelnoteout = Lstdelnoteout,
                    Lstinvout = Lstinvout,
                    Lstordersout = Lstordersout,
                    Lstpricelistout = Lstpricelistout,
                    Newadditions = Newadditions,
                    Nxtpredlvtransid = Nxtpredlvtransid,
                    Orderbydlvdate = Orderbydlvdate,
                    Ordernolength = Ordernolength,
                    Ordernostartposition = Ordernostartposition,
                    Palletlabelprtnm = Palletlabelprtnm,
                    Palletlabelprtor = Palletlabelprtor,
                    Paymentmethod = Paymentmethod,
                    Penaltycondition = Penaltycondition,
                    Qtychangelog = Qtychangelog,
                    Qtychanges = Qtychanges,
                    Retrieveby = Retrieveby,
                    Retrievehocode = Retrievehocode,
                    Showtransportid = Showtransportid,
                    Supaccno = Supaccno,
                    Supplierrefinorderno = Supplierrefinorderno,
                    Suppref = Suppref,
                    Tradacomidentity = Tradacomidentity,
                    Uploadmissingproducts = Uploadmissingproducts,
                    Usedepotnoasfileext = Usedepotnoasfileext,
                    Useearlydlvdate = Useearlydlvdate,
                    Usetradedunitinild = Usetradedunitinild,
                    Vatnbrinfreeway = Vatnbrinfreeway,
                    Writeweeklyorders = Writeweeklyorders,
                };

            return obj;
        }

        public static class FieldNames
        {
// ReSharper disable InconsistentNaming
            public const string  HOCODE = "HOCODE";
            public const string  COGLBNO = "COGLBNO";
            public const string  ALLOWASNGENERATEPALLETS = "ALLOWASNGENERATEPALLETS";
            public const string  ALLOWNEWORDERSAMEDAY = "ALLOWNEWORDERSAMEDAY";
            public const string  ANSI_APPLICATIONRECEIVERSCODE = "ANSI_APPLICATIONRECEIVERSCODE";
            public const string  ANSI_ELEMENTSEPCHAR = "ANSI_ELEMENTSEPCHAR";
            public const string  ANSI_FIELDSEPCHAR = "ANSI_FIELDSEPCHAR";
            public const string  ANSI_INTERCHNGCONTROLNO = "ANSI_INTERCHNGCONTROLNO";
            public const string  ANSI_INTERCHNGRECEIVERID = "ANSI_INTERCHNGRECEIVERID";
            public const string  ANSI_INTERCHNGRECEIVERQUAL = "ANSI_INTERCHNGRECEIVERQUAL";
            public const string  ANSI_INTERCHNGSENDERID = "ANSI_INTERCHNGSENDERID";
            public const string  ANSI_INTERCHNGSENDERQUAL = "ANSI_INTERCHNGSENDERQUAL";
            public const string  ANSI_PRODUCTQUALIFIER = "ANSI_PRODUCTQUALIFIER";
            public const string  ANSI_REFID = "ANSI_REFID";
            public const string  ANSI_REFIDCODE = "ANSI_REFIDCODE";
            public const string  ANSI_REPSEPCHAR = "ANSI_REPSEPCHAR";
            public const string  ANSI_REQACKNOWLEDGEMENT = "ANSI_REQACKNOWLEDGEMENT";
            public const string  ANSI_TESTORPRODUCTION = "ANSI_TESTORPRODUCTION";
            public const string  ANSI_TRANSACTIONSETCONTROLNO = "ANSI_TRANSACTIONSETCONTROLNO";
            public const string  ASNINCLUDEWEIGHT = "ASNINCLUDEWEIGHT";
            public const string  ASNONEPRODUCTPERPALLET = "ASNONEPRODUCTPERPALLET";
            public const string  ASNUNBANA = "ASNUNBANA";
            public const string  BLANKILDISSPACES = "BLANKILDISSPACES";
            public const string  BLANKTRANSPORTID = "BLANKTRANSPORTID";
            public const string  CASELABELPRTNM = "CASELABELPRTNM";
            public const string  CASELABELPRTOR = "CASELABELPRTOR";
            public const string  COMBINEDELIVERIES = "COMBINEDELIVERIES";
            public const string  CROSSDOCKUPLOAD = "CROSSDOCKUPLOAD";
            public const string  DISCOUNTCONDITION = "DISCOUNTCONDITION";
            public const string  DUPLICATEORDERS = "DUPLICATEORDERS";
            public const string  EDIDBTCDTFILEEXT = "EDIDBTCDTFILEEXT";
            public const string  EDIDBTCDTFILEPREFIX = "EDIDBTCDTFILEPREFIX";
            public const string  EDIDBTCDTFORMATRECNO = "EDIDBTCDTFORMATRECNO";
            public const string  EDIDBTCDTTRNFORMAT = "EDIDBTCDTTRNFORMAT";
            public const string  EDIDBTSCDTS = "EDIDBTSCDTS";
            public const string  EDIDELNOTEFILEEXT = "EDIDELNOTEFILEEXT";
            public const string  EDIDELNOTEFILEPREFIX = "EDIDELNOTEFILEPREFIX";
            public const string  EDIDELNOTEFORMATRECNO = "EDIDELNOTEFORMATRECNO";
            public const string  EDIDELNOTES = "EDIDELNOTES";
            public const string  EDIDELNOTETRNFORMAT = "EDIDELNOTETRNFORMAT";
            public const string  EDIINVOICEFILEEXT = "EDIINVOICEFILEEXT";
            public const string  EDIINVOICEFILEPREFIX = "EDIINVOICEFILEPREFIX";
            public const string  EDIINVOICEFORMATRECNO = "EDIINVOICEFORMATRECNO";
            public const string  EDIINVOICEROUTING = "EDIINVOICEROUTING";
            public const string  EDIINVOICES = "EDIINVOICES";
            public const string  EDIINVOICETRNFORMAT = "EDIINVOICETRNFORMAT";
            public const string  EDIORDERFILEEXT = "EDIORDERFILEEXT";
            public const string  EDIORDERFILEPREFIX = "EDIORDERFILEPREFIX";
            public const string  EDIORDERFORMATRECNO = "EDIORDERFORMATRECNO";
            public const string  EDIORDERS = "EDIORDERS";
            public const string  EDIORDERTRNFORMAT = "EDIORDERTRNFORMAT";
            public const string  EDIPRGORDERFILEEXT = "EDIPRGORDERFILEEXT";
            public const string  EDIPRGORDERFILEPREFIX = "EDIPRGORDERFILEPREFIX";
            public const string  EDIPRGORDERFORMATRECNO = "EDIPRGORDERFORMATRECNO";
            public const string  EDIPRGORDERS = "EDIPRGORDERS";
            public const string  EDIPRGORDERTRNFORMAT = "EDIPRGORDERTRNFORMAT";
            public const string  EDIPRICELISTFILEEXT = "EDIPRICELISTFILEEXT";
            public const string  EDIPRICELISTFILEPREFIX = "EDIPRICELISTFILEPREFIX";
            public const string  EDIPRICELISTFORMATRECNO = "EDIPRICELISTFORMATRECNO";
            public const string  EDIPRICELISTS = "EDIPRICELISTS";
            public const string  EDIPRICELISTSOUT = "EDIPRICELISTSOUT";
            public const string  EDIPRICELISTTRNFORMAT = "EDIPRICELISTTRNFORMAT";
            public const string  EDIREMITFILEEXT = "EDIREMITFILEEXT";
            public const string  EDIREMITFILEPREFIX = "EDIREMITFILEPREFIX";
            public const string  EDIREMITTANCES = "EDIREMITTANCES";
            public const string  EDIREMITTRNFORMAT = "EDIREMITTRNFORMAT";
            public const string  EDIREMITTRNFORMATRECNO = "EDIREMITTRNFORMATRECNO";
            public const string  EDIREMOVELEADZERO = "EDIREMOVELEADZERO";
            public const string  EDISHIPDESC = "EDISHIPDESC";
            public const string  EDISHIPEXT = "EDISHIPEXT";
            public const string  EDISHIPNXTNO = "EDISHIPNXTNO";
            public const string  EDISHIPPREFIX = "EDISHIPPREFIX";
            public const string  EDISHIPRECNO = "EDISHIPRECNO";
            public const string  EDIUSESHIPPING = "EDIUSESHIPPING";
            public const string  EXCLINVPREFIX = "EXCLINVPREFIX";
            public const string  EXCLUDEZEROGOODS = "EXCLUDEZEROGOODS";
            public const string  FREEWAYREALEANPOS = "FREEWAYREALEANPOS";
            public const string  LINETERMINATOR = "LINETERMINATOR";
            public const string  LSTCDTOUT = "LSTCDTOUT";
            public const string  LSTDELNOTEOUT = "LSTDELNOTEOUT";
            public const string  LSTINVOUT = "LSTINVOUT";
            public const string  LSTORDERSOUT = "LSTORDERSOUT";
            public const string  LSTPRICELISTOUT = "LSTPRICELISTOUT";
            public const string  NEWADDITIONS = "NEWADDITIONS";
            public const string  NXTPREDLVTRANSID = "NXTPREDLVTRANSID";
            public const string  ORDERBYDLVDATE = "ORDERBYDLVDATE";
            public const string  ORDERNOLENGTH = "ORDERNOLENGTH";
            public const string  ORDERNOSTARTPOSITION = "ORDERNOSTARTPOSITION";
            public const string  PALLETLABELPRTNM = "PALLETLABELPRTNM";
            public const string  PALLETLABELPRTOR = "PALLETLABELPRTOR";
            public const string  PAYMENTMETHOD = "PAYMENTMETHOD";
            public const string  PENALTYCONDITION = "PENALTYCONDITION";
            public const string  QTYCHANGELOG = "QTYCHANGELOG";
            public const string  QTYCHANGES = "QTYCHANGES";
            public const string  RETRIEVEBY = "RETRIEVEBY";
            public const string  RETRIEVEHOCODE = "RETRIEVEHOCODE";
            public const string  SHOWTRANSPORTID = "SHOWTRANSPORTID";
            public const string  SUPACCNO = "SUPACCNO";
            public const string  SUPPLIERREFINORDERNO = "SUPPLIERREFINORDERNO";
            public const string  SUPPREF = "SUPPREF";
            public const string  TRADACOMIDENTITY = "TRADACOMIDENTITY";
            public const string  UPLOADMISSINGPRODUCTS = "UPLOADMISSINGPRODUCTS";
            public const string  USEDEPOTNOASFILEEXT = "USEDEPOTNOASFILEEXT";
            public const string  USEEARLYDLVDATE = "USEEARLYDLVDATE";
            public const string  USETRADEDUNITINILD = "USETRADEDUNITINILD";
            public const string  VATNBRINFREEWAY = "VATNBRINFREEWAY";
            public const string  WRITEWEEKLYORDERS = "WRITEWEEKLYORDERS";
 // ReSharper restore InconsistentNaming
        }


    }

    /// <summary>
    /// Define type of the primary key property of the COSUPPNO entity.
    /// </summary>
    public class EdiCoSuppNoKey : ICompositeKey
    {
        public int Hocode { get; set; }
        public int Coglbno { get; set; }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != GetType()) return false;
            return Equals((EdiCoSuppNoKey)obj);
        }

        protected bool Equals(EdiCoSuppNoKey other)
        {
            return Hocode == other.Hocode && Coglbno == other.Coglbno;
        }

        public override int GetHashCode()
        {
            unchecked
            {
                int hashCode = 0;
                hashCode = (hashCode * 397) ^ (Hocode).GetHashCode();
                hashCode = (hashCode * 397) ^ (Coglbno).GetHashCode();
                return hashCode;
            }
        }

        public static EdiCoSuppNoKey Parse(string key)
        {
            var parts = key.Split('|');
            return new EdiCoSuppNoKey
            {
                Hocode = int.Parse(parts[0]),
                Coglbno = int.Parse(parts[1]),
            };
        }

        public string AsString
        {
            get { return Hocode.ToString() + "|" + Coglbno.ToString(); }
        }

        public override string ToString()
        {
            return AsString;
        }

    }

}
