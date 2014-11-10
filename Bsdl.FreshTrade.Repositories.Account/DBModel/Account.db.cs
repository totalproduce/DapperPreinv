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
    /// Entity for the ACCOUNTS table
    /// </summary>
    public partial class Account : BaseDbModel<Account, string>
    {
#region tableDefs

       public static List<EntityPropDef> GetPropDefs() {
         var result = new List<EntityPropDef>();

//EntityPropDef(string propName, string columnName, bool isKey, bool isNullable, string refEntityName, PropertyInfo keyPropInfo,
//            int size, int? prec, int? scale)



         result.Add(new EntityPropDef(
         PropertyHelper <Account>.GetProperty(x => x.Acccode),
         "ACCCODE", // columnName
         true,                    //isKey
         false, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         8,       // int size   
           
         null, // int? prec
                    
         null // int? Scale
         ,
         typeof(Account)
       ));


         result.Add(new EntityPropDef(
         PropertyHelper <Account>.GetProperty(x => x.Acc1099type),
         "ACC1099TYPE", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  5, // int? prec
                           0  // int? Scale
         ,
         typeof(Account)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <Account>.GetProperty(x => x.Accactive),
         "ACCACTIVE", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  5, // int? prec
                           0  // int? Scale
         ,
         typeof(Account)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <Account>.GetProperty(x => x.Accaddress1),
         "ACCADDRESS1", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         35,       // int size   
                  null, // int? prec
                   
         null // int? Scale
         ,
         typeof(Account)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <Account>.GetProperty(x => x.Accaddress2),
         "ACCADDRESS2", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         35,       // int size   
                  null, // int? prec
                   
         null // int? Scale
         ,
         typeof(Account)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <Account>.GetProperty(x => x.Accaddress3),
         "ACCADDRESS3", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         35,       // int size   
                  null, // int? prec
                   
         null // int? Scale
         ,
         typeof(Account)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <Account>.GetProperty(x => x.Accaddress4),
         "ACCADDRESS4", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         35,       // int size   
                  null, // int? prec
                   
         null // int? Scale
         ,
         typeof(Account)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <Account>.GetProperty(x => x.Accallpartprcinv),
         "ACCALLPARTPRCINV", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  5, // int? prec
                           0  // int? Scale
         ,
         typeof(Account)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <Account>.GetProperty(x => x.Accananumber),
         "ACCANANUMBER", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         13,       // int size   
                  null, // int? prec
                   
         null // int? Scale
         ,
         typeof(Account)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <Account>.GetProperty(x => x.Accanctypondispatch),
         "ACCANCTYPONDISPATCH", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  10, // int? prec
                           0  // int? Scale
         ,
         typeof(Account)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <Account>.GetProperty(x => x.Accanusefastmoving),
         "ACCANUSEFASTMOVING", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  5, // int? prec
                           0  // int? Scale
         ,
         typeof(Account)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <Account>.GetProperty(x => x.Accapdefcomm),
         "ACCAPDEFCOMM", // columnName
         false,                    //isKey
         false, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  126, // int? prec
                   
         null // int? Scale
         ,
         typeof(Account)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <Account>.GetProperty(x => x.Accapdefhand),
         "ACCAPDEFHAND", // columnName
         false,                    //isKey
         false, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  126, // int? prec
                   
         null // int? Scale
         ,
         typeof(Account)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <Account>.GetProperty(x => x.Accappayfrom),
         "ACCAPPAYFROM", // columnName
         false,                    //isKey
         false, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  5, // int? prec
                           0  // int? Scale
         ,
         typeof(Account)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <Account>.GetProperty(x => x.Accapply2vatspurch),
         "ACCAPPLY2VATSPURCH", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  1, // int? prec
                           0  // int? Scale
         ,
         typeof(Account)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <Account>.GetProperty(x => x.Accapply2vatssales),
         "ACCAPPLY2VATSSALES", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  1, // int? prec
                           0  // int? Scale
         ,
         typeof(Account)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <Account>.GetProperty(x => x.Accapplycompvatpurch),
         "ACCAPPLYCOMPVATPURCH", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  1, // int? prec
                           0  // int? Scale
         ,
         typeof(Account)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <Account>.GetProperty(x => x.Accapplycompvatsale),
         "ACCAPPLYCOMPVATSALE", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  1, // int? prec
                           0  // int? Scale
         ,
         typeof(Account)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <Account>.GetProperty(x => x.Accapplywithholdtax),
         "ACCAPPLYWITHHOLDTAX", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  1, // int? prec
                           0  // int? Scale
         ,
         typeof(Account)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <Account>.GetProperty(x => x.Accarautoalloccdts),
         "ACCARAUTOALLOCCDTS", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  5, // int? prec
                           0  // int? Scale
         ,
         typeof(Account)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <Account>.GetProperty(x => x.Accarcreditlimit),
         "ACCARCREDITLIMIT", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  126, // int? prec
                   
         null // int? Scale
         ,
         typeof(Account)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <Account>.GetProperty(x => x.Accarcreditterms),
         "ACCARCREDITTERMS", // columnName
         false,                    //isKey
         false, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  5, // int? prec
                           0  // int? Scale
         ,
         typeof(Account)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <Account>.GetProperty(x => x.Accarinvoiceperiod),
         "ACCARINVOICEPERIOD", // columnName
         false,                    //isKey
         false, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  5, // int? prec
                           0  // int? Scale
         ,
         typeof(Account)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <Account>.GetProperty(x => x.Accarinvoicetype),
         "ACCARINVOICETYPE", // columnName
         false,                    //isKey
         false, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  5, // int? prec
                           0  // int? Scale
         ,
         typeof(Account)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <Account>.GetProperty(x => x.Accarpodreq),
         "ACCARPODREQ", // columnName
         false,                    //isKey
         false, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  5, // int? prec
                           0  // int? Scale
         ,
         typeof(Account)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <Account>.GetProperty(x => x.Accarstmntperiod),
         "ACCARSTMNTPERIOD", // columnName
         false,                    //isKey
         false, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  5, // int? prec
                           0  // int? Scale
         ,
         typeof(Account)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <Account>.GetProperty(x => x.Acccapeallupl),
         "ACCCAPEALLUPL", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  1, // int? prec
                           0  // int? Scale
         ,
         typeof(Account)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <Account>.GetProperty(x => x.Accchepcode),
         "ACCCHEPCODE", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         13,       // int size   
                  null, // int? prec
                   
         null // int? Scale
         ,
         typeof(Account)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <Account>.GetProperty(x => x.Acccomprecno),
         "ACCCOMPRECNO", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  5, // int? prec
                           0  // int? Scale
         ,
         typeof(Account)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <Account>.GetProperty(x => x.Accconfpalsondispatch),
         "ACCCONFPALSONDISPATCH", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  1, // int? prec
                           0  // int? Scale
         ,
         typeof(Account)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <Account>.GetProperty(x => x.Acccountryno),
         "ACCCOUNTRYNO", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  5, // int? prec
                           0  // int? Scale
         ,
         typeof(Account)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <Account>.GetProperty(x => x.Acccustordcheck),
         "ACCCUSTORDCHECK", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  5, // int? prec
                           0  // int? Scale
         ,
         typeof(Account)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <Account>.GetProperty(x => x.Acccustordreq),
         "ACCCUSTORDREQ", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  5, // int? prec
                           0  // int? Scale
         ,
         typeof(Account)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <Account>.GetProperty(x => x.Acccustrefno),
         "ACCCUSTREFNO", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         12,       // int size   
                  null, // int? prec
                   
         null // int? Scale
         ,
         typeof(Account)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <Account>.GetProperty(x => x.Accdefsaloffno),
         "ACCDEFSALOFFNO", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  5, // int? prec
                           0  // int? Scale
         ,
         typeof(Account)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <Account>.GetProperty(x => x.Accdelivarea),
         "ACCDELIVAREA", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         10,       // int size   
                  null, // int? prec
                   
         null // int? Scale
         ,
         typeof(Account)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <Account>.GetProperty(x => x.Accdelivdefstcloc),
         "ACCDELIVDEFSTCLOC", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  5, // int? prec
                           0  // int? Scale
         ,
         typeof(Account)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <Account>.GetProperty(x => x.Accdelivnotestyle),
         "ACCDELIVNOTESTYLE", // columnName
         false,                    //isKey
         false, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  5, // int? prec
                           0  // int? Scale
         ,
         typeof(Account)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <Account>.GetProperty(x => x.Accdelivtownrecno),
         "ACCDELIVTOWNRECNO", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  10, // int? prec
                           0  // int? Scale
         ,
         typeof(Account)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <Account>.GetProperty(x => x.Accdetsonrem),
         "ACCDETSONREM", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  5, // int? prec
                           0  // int? Scale
         ,
         typeof(Account)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <Account>.GetProperty(x => x.Accedidepotno),
         "ACCEDIDEPOTNO", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         5,       // int size   
                  null, // int? prec
                   
         null // int? Scale
         ,
         typeof(Account)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <Account>.GetProperty(x => x.Accextcrdlim),
         "ACCEXTCRDLIM", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  126, // int? prec
                   
         null // int? Scale
         ,
         typeof(Account)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <Account>.GetProperty(x => x.Accextdate),
         "ACCEXTDATE", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  null, // int? prec
                   
         null // int? Scale
         ,
         typeof(Account)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <Account>.GetProperty(x => x.Accexterntranship),
         "ACCEXTERNTRANSHIP", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  1, // int? prec
                           0  // int? Scale
         ,
         typeof(Account)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <Account>.GetProperty(x => x.Accfaxno),
         "ACCFAXNO", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         20,       // int size   
                  null, // int? prec
                   
         null // int? Scale
         ,
         typeof(Account)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <Account>.GetProperty(x => x.Accglanl),
         "ACCGLANL", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  5, // int? prec
                           0  // int? Scale
         ,
         typeof(Account)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <Account>.GetProperty(x => x.Acchaulierananumber),
         "ACCHAULIERANANUMBER", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         13,       // int size   
                  null, // int? prec
                   
         null // int? Scale
         ,
         typeof(Account)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <Account>.GetProperty(x => x.Acchofrecno),
         "ACCHOFRECNO", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  10, // int? prec
                           0  // int? Scale
         ,
         typeof(Account)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <Account>.GetProperty(x => x.Accifcocode),
         "ACCIFCOCODE", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         13,       // int size   
                  null, // int? prec
                   
         null // int? Scale
         ,
         typeof(Account)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <Account>.GetProperty(x => x.Accincrabofil),
         "ACCINCRABOFIL", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  1, // int? prec
                           0  // int? Scale
         ,
         typeof(Account)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <Account>.GetProperty(x => x.Accinvoiceananumber),
         "ACCINVOICEANANUMBER", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         13,       // int size   
                  null, // int? prec
                   
         null // int? Scale
         ,
         typeof(Account)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <Account>.GetProperty(x => x.Accinvondesp),
         "ACCINVONDESP", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  1, // int? prec
                           0  // int? Scale
         ,
         typeof(Account)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <Account>.GetProperty(x => x.Accisbondedstore),
         "ACCISBONDEDSTORE", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  1, // int? prec
                           0  // int? Scale
         ,
         typeof(Account)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <Account>.GetProperty(x => x.Accisdeffot),
         "ACCISDEFFOT", // columnName
         false,                    //isKey
         false, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  5, // int? prec
                           0  // int? Scale
         ,
         typeof(Account)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <Account>.GetProperty(x => x.Acclanguage),
         "ACCLANGUAGE", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  5, // int? prec
                           0  // int? Scale
         ,
         typeof(Account)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <Account>.GetProperty(x => x.Accname),
         "ACCNAME", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         40,       // int size   
                  null, // int? prec
                   
         null // int? Scale
         ,
         typeof(Account)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <Account>.GetProperty(x => x.Accpalwizsite),
         "ACCPALWIZSITE", // columnName
         false,                    //isKey
         false, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  1, // int? prec
                           0  // int? Scale
         ,
         typeof(Account)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <Account>.GetProperty(x => x.Accpalwizstcloc),
         "ACCPALWIZSTCLOC", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  5, // int? prec
                           0  // int? Scale
         ,
         typeof(Account)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <Account>.GetProperty(x => x.Accpaydays),
         "ACCPAYDAYS", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  5, // int? prec
                           0  // int? Scale
         ,
         typeof(Account)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <Account>.GetProperty(x => x.Accpostcode),
         "ACCPOSTCODE", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         9,       // int size   
                  null, // int? prec
                   
         null // int? Scale
         ,
         typeof(Account)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <Account>.GetProperty(x => x.Accpredlvedireqd),
         "ACCPREDLVEDIREQD", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  1, // int? prec
                           0  // int? Scale
         ,
         typeof(Account)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <Account>.GetProperty(x => x.Accrecno),
         "ACCRECNO", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  10, // int? prec
                           0  // int? Scale
         ,
         typeof(Account)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <Account>.GetProperty(x => x.Accsplitinvoice),
         "ACCSPLITINVOICE", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  5, // int? prec
                           0  // int? Scale
         ,
         typeof(Account)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <Account>.GetProperty(x => x.Accssccpalnoreqd),
         "ACCSSCCPALNOREQD", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  1, // int? prec
                           0  // int? Scale
         ,
         typeof(Account)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <Account>.GetProperty(x => x.Accsuphofrecno),
         "ACCSUPHOFRECNO", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  10, // int? prec
                           0  // int? Scale
         ,
         typeof(Account)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <Account>.GetProperty(x => x.Acctelno),
         "ACCTELNO", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         20,       // int size   
                  null, // int? prec
                   
         null // int? Scale
         ,
         typeof(Account)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <Account>.GetProperty(x => x.Accunlimcrdlim),
         "ACCUNLIMCRDLIM", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  1, // int? prec
                           0  // int? Scale
         ,
         typeof(Account)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <Account>.GetProperty(x => x.Accuploadhofrecno),
         "ACCUPLOADHOFRECNO", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  10, // int? prec
                           0  // int? Scale
         ,
         typeof(Account)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <Account>.GetProperty(x => x.Accvatno),
         "ACCVATNO", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         15,       // int size   
                  null, // int? prec
                   
         null // int? Scale
         ,
         typeof(Account)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <Account>.GetProperty(x => x.Acsaleisinv),
         "ACSALEISINV", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  1, // int? prec
                           0  // int? Scale
         ,
         typeof(Account)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <Account>.GetProperty(x => x.Arvalue),
         "ARVALUE", // columnName
         false,                    //isKey
         false, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  126, // int? prec
                   
         null // int? Scale
         ,
         typeof(Account)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <Account>.GetProperty(x => x.Bankguaranteeamount),
         "BANKGUARANTEEAMOUNT", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  126, // int? prec
                   
         null // int? Scale
         ,
         typeof(Account)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <Account>.GetProperty(x => x.Cashcustomer),
         "CASHCUSTOMER", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  1, // int? prec
                           0  // int? Scale
         ,
         typeof(Account)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <Account>.GetProperty(x => x.Clearingagent),
         "CLEARINGAGENT", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         8,       // int size   
                  null, // int? prec
                   
         null // int? Scale
         ,
         typeof(Account)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <Account>.GetProperty(x => x.Creditinsuranceamount),
         "CREDITINSURANCEAMOUNT", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  126, // int? prec
                   
         null // int? Scale
         ,
         typeof(Account)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <Account>.GetProperty(x => x.Credittermtype),
         "CREDITTERMTYPE", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  5, // int? prec
                           0  // int? Scale
         ,
         typeof(Account)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <Account>.GetProperty(x => x.Cstaheno),
         "CSTAHENO", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  10, // int? prec
                           0  // int? Scale
         ,
         typeof(Account)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <Account>.GetProperty(x => x.Cstrebateno),
         "CSTREBATENO", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  5, // int? prec
                           0  // int? Scale
         ,
         typeof(Account)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <Account>.GetProperty(x => x.Cstvattype),
         "CSTVATTYPE", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  5, // int? prec
                           0  // int? Scale
         ,
         typeof(Account)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <Account>.GetProperty(x => x.Customsupid),
         "CUSTOMSUPID", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         20,       // int size   
                  null, // int? prec
                   
         null // int? Scale
         ,
         typeof(Account)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <Account>.GetProperty(x => x.Ddenabled),
         "DDENABLED", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  1, // int? prec
                           0  // int? Scale
         ,
         typeof(Account)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <Account>.GetProperty(x => x.Defaccrwgttyp),
         "DEFACCRWGTTYP", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  5, // int? prec
                           0  // int? Scale
         ,
         typeof(Account)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <Account>.GetProperty(x => x.Defdltrecno),
         "DEFDLTRECNO", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  5, // int? prec
                           0  // int? Scale
         ,
         typeof(Account)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <Account>.GetProperty(x => x.Defdlvtime),
         "DEFDLVTIME", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         5,       // int size   
                  null, // int? prec
                   
         null // int? Scale
         ,
         typeof(Account)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <Account>.GetProperty(x => x.Delivcity),
         "DELIVCITY", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         30,       // int size   
                  null, // int? prec
                   
         null // int? Scale
         ,
         typeof(Account)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <Account>.GetProperty(x => x.Deliveryiln),
         "DELIVERYILN", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         13,       // int size   
                  null, // int? prec
                   
         null // int? Scale
         ,
         typeof(Account)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <Account>.GetProperty(x => x.Delivname1),
         "DELIVNAME1", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         30,       // int size   
                  null, // int? prec
                   
         null // int? Scale
         ,
         typeof(Account)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <Account>.GetProperty(x => x.Delivname2),
         "DELIVNAME2", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         30,       // int size   
                  null, // int? prec
                   
         null // int? Scale
         ,
         typeof(Account)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <Account>.GetProperty(x => x.Delivpostcode),
         "DELIVPOSTCODE", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         15,       // int size   
                  null, // int? prec
                   
         null // int? Scale
         ,
         typeof(Account)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <Account>.GetProperty(x => x.Delivstreet),
         "DELIVSTREET", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         30,       // int size   
                  null, // int? prec
                   
         null // int? Scale
         ,
         typeof(Account)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <Account>.GetProperty(x => x.Dlvnoteshowsancilsummary),
         "DLVNOTESHOWSANCILSUMMARY", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  1, // int? prec
                           0  // int? Scale
         ,
         typeof(Account)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <Account>.GetProperty(x => x.Dlvnoteshowspalletsummary),
         "DLVNOTESHOWSPALLETSUMMARY", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  1, // int? prec
                           0  // int? Scale
         ,
         typeof(Account)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <Account>.GetProperty(x => x.Dutyinclsales),
         "DUTYINCLSALES", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  1, // int? prec
                           0  // int? Scale
         ,
         typeof(Account)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <Account>.GetProperty(x => x.Edifacilityno),
         "EDIFACILITYNO", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         3,       // int size   
                  null, // int? prec
                   
         null // int? Scale
         ,
         typeof(Account)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <Account>.GetProperty(x => x.Ediwarehouseno),
         "EDIWAREHOUSENO", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         3,       // int size   
                  null, // int? prec
                   
         null // int? Scale
         ,
         typeof(Account)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <Account>.GetProperty(x => x.Grossornett),
         "GROSSORNETT", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  5, // int? prec
                           0  // int? Scale
         ,
         typeof(Account)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <Account>.GetProperty(x => x.IlnNumber),
         "ILN_NUMBER", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         13,       // int size   
                  null, // int? prec
                   
         null // int? Scale
         ,
         typeof(Account)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <Account>.GetProperty(x => x.Imparval),
         "IMPARVAL", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  126, // int? prec
                   
         null // int? Scale
         ,
         typeof(Account)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <Account>.GetProperty(x => x.Incindiscscheme),
         "INCINDISCSCHEME", // columnName
         false,                    //isKey
         false, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  1, // int? prec
                           0  // int? Scale
         ,
         typeof(Account)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <Account>.GetProperty(x => x.Incinpricelist),
         "INCINPRICELIST", // columnName
         false,                    //isKey
         false, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  1, // int? prec
                           0  // int? Scale
         ,
         typeof(Account)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <Account>.GetProperty(x => x.Interdeptcust),
         "INTERDEPTCUST", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  1, // int? prec
                           0  // int? Scale
         ,
         typeof(Account)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <Account>.GetProperty(x => x.Mandpricemeth),
         "MANDPRICEMETH", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  1, // int? prec
                           0  // int? Scale
         ,
         typeof(Account)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <Account>.GetProperty(x => x.Mergecustordrecs),
         "MERGECUSTORDRECS", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  1, // int? prec
                           0  // int? Scale
         ,
         typeof(Account)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <Account>.GetProperty(x => x.Multidlvdateononerte),
         "MULTIDLVDATEONONERTE", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  1, // int? prec
                           0  // int? Scale
         ,
         typeof(Account)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <Account>.GetProperty(x => x.Numofinvoicecopies),
         "NUMOFINVOICECOPIES", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  5, // int? prec
                           0  // int? Scale
         ,
         typeof(Account)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <Account>.GetProperty(x => x.Paymentagentclarecno),
         "PAYMENTAGENTCLARECNO", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  10, // int? prec
                           0  // int? Scale
         ,
         typeof(Account)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <Account>.GetProperty(x => x.Postcode2),
         "POSTCODE2", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         5,       // int size   
                  null, // int? prec
                   
         null // int? Scale
         ,
         typeof(Account)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <Account>.GetProperty(x => x.Priceddlvvalue),
         "PRICEDDLVVALUE", // columnName
         false,                    //isKey
         false, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  126, // int? prec
                   
         null // int? Scale
         ,
         typeof(Account)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <Account>.GetProperty(x => x.Purchinvvatrecno),
         "PURCHINVVATRECNO", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  5, // int? prec
                           0  // int? Scale
         ,
         typeof(Account)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <Account>.GetProperty(x => x.Quickcustentry),
         "QUICKCUSTENTRY", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  5, // int? prec
                           0  // int? Scale
         ,
         typeof(Account)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <Account>.GetProperty(x => x.Requireshippingnotification),
         "REQUIRESHIPPINGNOTIFICATION", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  1, // int? prec
                           0  // int? Scale
         ,
         typeof(Account)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <Account>.GetProperty(x => x.Rtemandhaul),
         "RTEMANDHAUL", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  1, // int? prec
                           0  // int? Scale
         ,
         typeof(Account)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <Account>.GetProperty(x => x.Salesscrmainoffcust),
         "SALESSCRMAINOFFCUST", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  10, // int? prec
                           0  // int? Scale
         ,
         typeof(Account)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <Account>.GetProperty(x => x.Scatcode),
         "SCATCODE", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         10,       // int size   
                  null, // int? prec
                   
         null // int? Scale
         ,
         typeof(Account)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <Account>.GetProperty(x => x.Scatlength),
         "SCATLENGTH", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  5, // int? prec
                           0  // int? Scale
         ,
         typeof(Account)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <Account>.GetProperty(x => x.Scatseqendno),
         "SCATSEQENDNO", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  10, // int? prec
                           0  // int? Scale
         ,
         typeof(Account)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <Account>.GetProperty(x => x.Scatseqstartno),
         "SCATSEQSTARTNO", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  10, // int? prec
                           0  // int? Scale
         ,
         typeof(Account)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <Account>.GetProperty(x => x.Setdlvdateasinvdate),
         "SETDLVDATEASINVDATE", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  1, // int? prec
                           0  // int? Scale
         ,
         typeof(Account)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <Account>.GetProperty(x => x.Ssccfordlv),
         "SSCCFORDLV", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  1, // int? prec
                           0  // int? Scale
         ,
         typeof(Account)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <Account>.GetProperty(x => x.Starecno),
         "STARECNO", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  5, // int? prec
                           0  // int? Scale
         ,
         typeof(Account)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <Account>.GetProperty(x => x.Supclaimscust),
         "SUPCLAIMSCUST", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  1, // int? prec
                           0  // int? Scale
         ,
         typeof(Account)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <Account>.GetProperty(x => x.Suphasdefexpprice),
         "SUPHASDEFEXPPRICE", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  5, // int? prec
                           0  // int? Scale
         ,
         typeof(Account)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <Account>.GetProperty(x => x.ThirdpartyAllowprices),
         "THIRDPARTY_ALLOWPRICES", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  1, // int? prec
                           0  // int? Scale
         ,
         typeof(Account)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <Account>.GetProperty(x => x.Thirdpartyonly),
         "THIRDPARTYONLY", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  1, // int? prec
                           0  // int? Scale
         ,
         typeof(Account)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <Account>.GetProperty(x => x.Trancoldstoreno),
         "TRANCOLDSTORENO", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         20,       // int size   
                  null, // int? prec
                   
         null // int? Scale
         ,
         typeof(Account)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <Account>.GetProperty(x => x.Unpriceddlvvalue),
         "UNPRICEDDLVVALUE", // columnName
         false,                    //isKey
         false, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  126, // int? prec
                   
         null // int? Scale
         ,
         typeof(Account)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <Account>.GetProperty(x => x.Using1099),
         "USING1099", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  1, // int? prec
                           0  // int? Scale
         ,
         typeof(Account)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <Account>.GetProperty(x => x.Wtaxincvat),
         "WTAXINCVAT", // columnName
         false,                    //isKey
         false, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  1, // int? prec
                           0  // int? Scale
         ,
         typeof(Account)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <Account>.GetProperty(x => x.Zaplcdtrans),
         "ZAPLCDTRANS", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  1, // int? prec
                           0  // int? Scale
         ,
         typeof(Account)
         ));
         return result; 
       }

#endregion     
        private string _fAcccode;
        public string Acccode
        {
            get { return _fAcccode; }
            set
            {
                var oldKey = Key;
                if (_fAcccode != value)
                {
                    Modify();
                    _fAcccode = value;
                    KeyChanged(oldKey);
                }
            }
        }

        private int? _fAcc1099type;
        public int? Acc1099type
        {
            get { return _fAcc1099type; }
            set
            {
                if (_fAcc1099type != value)
                {
                    Modify();
                    _fAcc1099type = value;
                }
            }
        }

        private int? _fAccactive;
        public int? Accactive
        {
            get { return _fAccactive; }
            set
            {
                if (_fAccactive != value)
                {
                    Modify();
                    _fAccactive = value;
                }
            }
        }

        private string _fAccaddress1;
        public string Accaddress1
        {
            get { return _fAccaddress1; }
            set
            {
                if (_fAccaddress1 != value)
                {
                    Modify();
                    _fAccaddress1 = value;
                }
            }
        }

        private string _fAccaddress2;
        public string Accaddress2
        {
            get { return _fAccaddress2; }
            set
            {
                if (_fAccaddress2 != value)
                {
                    Modify();
                    _fAccaddress2 = value;
                }
            }
        }

        private string _fAccaddress3;
        public string Accaddress3
        {
            get { return _fAccaddress3; }
            set
            {
                if (_fAccaddress3 != value)
                {
                    Modify();
                    _fAccaddress3 = value;
                }
            }
        }

        private string _fAccaddress4;
        public string Accaddress4
        {
            get { return _fAccaddress4; }
            set
            {
                if (_fAccaddress4 != value)
                {
                    Modify();
                    _fAccaddress4 = value;
                }
            }
        }

        private int? _fAccallpartprcinv;
        public int? Accallpartprcinv
        {
            get { return _fAccallpartprcinv; }
            set
            {
                if (_fAccallpartprcinv != value)
                {
                    Modify();
                    _fAccallpartprcinv = value;
                }
            }
        }

        private string _fAccananumber;
        public string Accananumber
        {
            get { return _fAccananumber; }
            set
            {
                if (_fAccananumber != value)
                {
                    Modify();
                    _fAccananumber = value;
                }
            }
        }

        private int? _fAccanctypondispatch;
        /// <summary>
        /// Ancillary Product on Dispatch
        /// </summary>
        public int? Accanctypondispatch
        {
            get { return _fAccanctypondispatch; }
            set
            {
                if (_fAccanctypondispatch != value)
                {
                    Modify();
                    _fAccanctypondispatch = value;
                }
            }
        }

        private int? _fAccanusefastmoving;
        public int? Accanusefastmoving
        {
            get { return _fAccanusefastmoving; }
            set
            {
                if (_fAccanusefastmoving != value)
                {
                    Modify();
                    _fAccanusefastmoving = value;
                }
            }
        }

        private decimal _fAccapdefcomm;
        public decimal Accapdefcomm
        {
            get { return _fAccapdefcomm; }
            set
            {
                if (_fAccapdefcomm != value)
                {
                    Modify();
                    _fAccapdefcomm = value;
                }
            }
        }

        private decimal _fAccapdefhand;
        public decimal Accapdefhand
        {
            get { return _fAccapdefhand; }
            set
            {
                if (_fAccapdefhand != value)
                {
                    Modify();
                    _fAccapdefhand = value;
                }
            }
        }

        private int _fAccappayfrom;
        public int Accappayfrom
        {
            get { return _fAccappayfrom; }
            set
            {
                if (_fAccappayfrom != value)
                {
                    Modify();
                    _fAccappayfrom = value;
                }
            }
        }

        private short? _fAccapply2vatspurch;
        public short? Accapply2vatspurch
        {
            get { return _fAccapply2vatspurch; }
            set
            {
                if (_fAccapply2vatspurch != value)
                {
                    Modify();
                    _fAccapply2vatspurch = value;
                }
            }
        }

        private short? _fAccapply2vatssales;
        public short? Accapply2vatssales
        {
            get { return _fAccapply2vatssales; }
            set
            {
                if (_fAccapply2vatssales != value)
                {
                    Modify();
                    _fAccapply2vatssales = value;
                }
            }
        }

        private short? _fAccapplycompvatpurch;
        public short? Accapplycompvatpurch
        {
            get { return _fAccapplycompvatpurch; }
            set
            {
                if (_fAccapplycompvatpurch != value)
                {
                    Modify();
                    _fAccapplycompvatpurch = value;
                }
            }
        }

        private short? _fAccapplycompvatsale;
        public short? Accapplycompvatsale
        {
            get { return _fAccapplycompvatsale; }
            set
            {
                if (_fAccapplycompvatsale != value)
                {
                    Modify();
                    _fAccapplycompvatsale = value;
                }
            }
        }

        private short? _fAccapplywithholdtax;
        public short? Accapplywithholdtax
        {
            get { return _fAccapplywithholdtax; }
            set
            {
                if (_fAccapplywithholdtax != value)
                {
                    Modify();
                    _fAccapplywithholdtax = value;
                }
            }
        }

        private int? _fAccarautoalloccdts;
        public int? Accarautoalloccdts
        {
            get { return _fAccarautoalloccdts; }
            set
            {
                if (_fAccarautoalloccdts != value)
                {
                    Modify();
                    _fAccarautoalloccdts = value;
                }
            }
        }

        private decimal? _fAccarcreditlimit;
        public decimal? Accarcreditlimit
        {
            get { return _fAccarcreditlimit; }
            set
            {
                if (_fAccarcreditlimit != value)
                {
                    Modify();
                    _fAccarcreditlimit = value;
                }
            }
        }

        private int _fAccarcreditterms;
        public int Accarcreditterms
        {
            get { return _fAccarcreditterms; }
            set
            {
                if (_fAccarcreditterms != value)
                {
                    Modify();
                    _fAccarcreditterms = value;
                }
            }
        }

        private int _fAccarinvoiceperiod;
        public int Accarinvoiceperiod
        {
            get { return _fAccarinvoiceperiod; }
            set
            {
                if (_fAccarinvoiceperiod != value)
                {
                    Modify();
                    _fAccarinvoiceperiod = value;
                }
            }
        }

        private int _fAccarinvoicetype;
        public int Accarinvoicetype
        {
            get { return _fAccarinvoicetype; }
            set
            {
                if (_fAccarinvoicetype != value)
                {
                    Modify();
                    _fAccarinvoicetype = value;
                }
            }
        }

        private int _fAccarpodreq;
        public int Accarpodreq
        {
            get { return _fAccarpodreq; }
            set
            {
                if (_fAccarpodreq != value)
                {
                    Modify();
                    _fAccarpodreq = value;
                }
            }
        }

        private int _fAccarstmntperiod;
        public int Accarstmntperiod
        {
            get { return _fAccarstmntperiod; }
            set
            {
                if (_fAccarstmntperiod != value)
                {
                    Modify();
                    _fAccarstmntperiod = value;
                }
            }
        }

        private short? _fAcccapeallupl;
        public short? Acccapeallupl
        {
            get { return _fAcccapeallupl; }
            set
            {
                if (_fAcccapeallupl != value)
                {
                    Modify();
                    _fAcccapeallupl = value;
                }
            }
        }

        private string _fAccchepcode;
        public string Accchepcode
        {
            get { return _fAccchepcode; }
            set
            {
                if (_fAccchepcode != value)
                {
                    Modify();
                    _fAccchepcode = value;
                }
            }
        }

        private int? _fAcccomprecno;
        public int? Acccomprecno
        {
            get { return _fAcccomprecno; }
            set
            {
                if (_fAcccomprecno != value)
                {
                    Modify();
                    _fAcccomprecno = value;
                }
            }
        }

        private short? _fAccconfpalsondispatch;
        /// <summary>
        /// Must Confirm Pallets at Point of Dispatch
        /// </summary>
        public short? Accconfpalsondispatch
        {
            get { return _fAccconfpalsondispatch; }
            set
            {
                if (_fAccconfpalsondispatch != value)
                {
                    Modify();
                    _fAccconfpalsondispatch = value;
                }
            }
        }

        private int? _fAcccountryno;
        public int? Acccountryno
        {
            get { return _fAcccountryno; }
            set
            {
                if (_fAcccountryno != value)
                {
                    Modify();
                    _fAcccountryno = value;
                }
            }
        }

        private int? _fAcccustordcheck;
        public int? Acccustordcheck
        {
            get { return _fAcccustordcheck; }
            set
            {
                if (_fAcccustordcheck != value)
                {
                    Modify();
                    _fAcccustordcheck = value;
                }
            }
        }

        private int? _fAcccustordreq;
        public int? Acccustordreq
        {
            get { return _fAcccustordreq; }
            set
            {
                if (_fAcccustordreq != value)
                {
                    Modify();
                    _fAcccustordreq = value;
                }
            }
        }

        private string _fAcccustrefno;
        public string Acccustrefno
        {
            get { return _fAcccustrefno; }
            set
            {
                if (_fAcccustrefno != value)
                {
                    Modify();
                    _fAcccustrefno = value;
                }
            }
        }

        private int? _fAccdefsaloffno;
        public int? Accdefsaloffno
        {
            get { return _fAccdefsaloffno; }
            set
            {
                if (_fAccdefsaloffno != value)
                {
                    Modify();
                    _fAccdefsaloffno = value;
                }
            }
        }

        private string _fAccdelivarea;
        public string Accdelivarea
        {
            get { return _fAccdelivarea; }
            set
            {
                if (_fAccdelivarea != value)
                {
                    Modify();
                    _fAccdelivarea = value;
                }
            }
        }

        private int? _fAccdelivdefstcloc;
        public int? Accdelivdefstcloc
        {
            get { return _fAccdelivdefstcloc; }
            set
            {
                if (_fAccdelivdefstcloc != value)
                {
                    Modify();
                    _fAccdelivdefstcloc = value;
                }
            }
        }

        private int _fAccdelivnotestyle;
        public int Accdelivnotestyle
        {
            get { return _fAccdelivnotestyle; }
            set
            {
                if (_fAccdelivnotestyle != value)
                {
                    Modify();
                    _fAccdelivnotestyle = value;
                }
            }
        }

        private int? _fAccdelivtownrecno;
        public int? Accdelivtownrecno
        {
            get { return _fAccdelivtownrecno; }
            set
            {
                if (_fAccdelivtownrecno != value)
                {
                    Modify();
                    _fAccdelivtownrecno = value;
                }
            }
        }

        private int? _fAccdetsonrem;
        public int? Accdetsonrem
        {
            get { return _fAccdetsonrem; }
            set
            {
                if (_fAccdetsonrem != value)
                {
                    Modify();
                    _fAccdetsonrem = value;
                }
            }
        }

        private string _fAccedidepotno;
        public string Accedidepotno
        {
            get { return _fAccedidepotno; }
            set
            {
                if (_fAccedidepotno != value)
                {
                    Modify();
                    _fAccedidepotno = value;
                }
            }
        }

        private decimal? _fAccextcrdlim;
        public decimal? Accextcrdlim
        {
            get { return _fAccextcrdlim; }
            set
            {
                if (_fAccextcrdlim != value)
                {
                    Modify();
                    _fAccextcrdlim = value;
                }
            }
        }

        private DateTime? _fAccextdate;
        public DateTime? Accextdate
        {
            get { return _fAccextdate; }
            set
            {
                if (_fAccextdate != value)
                {
                    Modify();
                    _fAccextdate = value;
                }
            }
        }

        private short? _fAccexterntranship;
        public short? Accexterntranship
        {
            get { return _fAccexterntranship; }
            set
            {
                if (_fAccexterntranship != value)
                {
                    Modify();
                    _fAccexterntranship = value;
                }
            }
        }

        private string _fAccfaxno;
        public string Accfaxno
        {
            get { return _fAccfaxno; }
            set
            {
                if (_fAccfaxno != value)
                {
                    Modify();
                    _fAccfaxno = value;
                }
            }
        }

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

        private string _fAcchaulierananumber;
        public string Acchaulierananumber
        {
            get { return _fAcchaulierananumber; }
            set
            {
                if (_fAcchaulierananumber != value)
                {
                    Modify();
                    _fAcchaulierananumber = value;
                }
            }
        }

        private int? _fAcchofrecno;
        public int? Acchofrecno
        {
            get { return _fAcchofrecno; }
            set
            {
                if (_fAcchofrecno != value)
                {
                    Modify();
                    _fAcchofrecno = value;
                }
            }
        }

        private string _fAccifcocode;
        public string Accifcocode
        {
            get { return _fAccifcocode; }
            set
            {
                if (_fAccifcocode != value)
                {
                    Modify();
                    _fAccifcocode = value;
                }
            }
        }

        private short? _fAccincrabofil;
        public short? Accincrabofil
        {
            get { return _fAccincrabofil; }
            set
            {
                if (_fAccincrabofil != value)
                {
                    Modify();
                    _fAccincrabofil = value;
                }
            }
        }

        private string _fAccinvoiceananumber;
        public string Accinvoiceananumber
        {
            get { return _fAccinvoiceananumber; }
            set
            {
                if (_fAccinvoiceananumber != value)
                {
                    Modify();
                    _fAccinvoiceananumber = value;
                }
            }
        }

        private short? _fAccinvondesp;
        public short? Accinvondesp
        {
            get { return _fAccinvondesp; }
            set
            {
                if (_fAccinvondesp != value)
                {
                    Modify();
                    _fAccinvondesp = value;
                }
            }
        }

        private short? _fAccisbondedstore;
        public short? Accisbondedstore
        {
            get { return _fAccisbondedstore; }
            set
            {
                if (_fAccisbondedstore != value)
                {
                    Modify();
                    _fAccisbondedstore = value;
                }
            }
        }

        private int _fAccisdeffot;
        public int Accisdeffot
        {
            get { return _fAccisdeffot; }
            set
            {
                if (_fAccisdeffot != value)
                {
                    Modify();
                    _fAccisdeffot = value;
                }
            }
        }

        private int? _fAcclanguage;
        public int? Acclanguage
        {
            get { return _fAcclanguage; }
            set
            {
                if (_fAcclanguage != value)
                {
                    Modify();
                    _fAcclanguage = value;
                }
            }
        }

        private string _fAccname;
        public string Accname
        {
            get { return _fAccname; }
            set
            {
                if (_fAccname != value)
                {
                    Modify();
                    _fAccname = value;
                }
            }
        }

        private short _fAccpalwizsite;
        public short Accpalwizsite
        {
            get { return _fAccpalwizsite; }
            set
            {
                if (_fAccpalwizsite != value)
                {
                    Modify();
                    _fAccpalwizsite = value;
                }
            }
        }

        private int? _fAccpalwizstcloc;
        public int? Accpalwizstcloc
        {
            get { return _fAccpalwizstcloc; }
            set
            {
                if (_fAccpalwizstcloc != value)
                {
                    Modify();
                    _fAccpalwizstcloc = value;
                }
            }
        }

        private int? _fAccpaydays;
        public int? Accpaydays
        {
            get { return _fAccpaydays; }
            set
            {
                if (_fAccpaydays != value)
                {
                    Modify();
                    _fAccpaydays = value;
                }
            }
        }

        private string _fAccpostcode;
        public string Accpostcode
        {
            get { return _fAccpostcode; }
            set
            {
                if (_fAccpostcode != value)
                {
                    Modify();
                    _fAccpostcode = value;
                }
            }
        }

        private short? _fAccpredlvedireqd;
        public short? Accpredlvedireqd
        {
            get { return _fAccpredlvedireqd; }
            set
            {
                if (_fAccpredlvedireqd != value)
                {
                    Modify();
                    _fAccpredlvedireqd = value;
                }
            }
        }

        private int? _fAccrecno;
        public int? Accrecno
        {
            get { return _fAccrecno; }
            set
            {
                if (_fAccrecno != value)
                {
                    Modify();
                    _fAccrecno = value;
                }
            }
        }

        private int? _fAccsplitinvoice;
        public int? Accsplitinvoice
        {
            get { return _fAccsplitinvoice; }
            set
            {
                if (_fAccsplitinvoice != value)
                {
                    Modify();
                    _fAccsplitinvoice = value;
                }
            }
        }

        private short? _fAccssccpalnoreqd;
        public short? Accssccpalnoreqd
        {
            get { return _fAccssccpalnoreqd; }
            set
            {
                if (_fAccssccpalnoreqd != value)
                {
                    Modify();
                    _fAccssccpalnoreqd = value;
                }
            }
        }

        private int? _fAccsuphofrecno;
        public int? Accsuphofrecno
        {
            get { return _fAccsuphofrecno; }
            set
            {
                if (_fAccsuphofrecno != value)
                {
                    Modify();
                    _fAccsuphofrecno = value;
                }
            }
        }

        private string _fAcctelno;
        public string Acctelno
        {
            get { return _fAcctelno; }
            set
            {
                if (_fAcctelno != value)
                {
                    Modify();
                    _fAcctelno = value;
                }
            }
        }

        private short? _fAccunlimcrdlim;
        public short? Accunlimcrdlim
        {
            get { return _fAccunlimcrdlim; }
            set
            {
                if (_fAccunlimcrdlim != value)
                {
                    Modify();
                    _fAccunlimcrdlim = value;
                }
            }
        }

        private int? _fAccuploadhofrecno;
        public int? Accuploadhofrecno
        {
            get { return _fAccuploadhofrecno; }
            set
            {
                if (_fAccuploadhofrecno != value)
                {
                    Modify();
                    _fAccuploadhofrecno = value;
                }
            }
        }

        private string _fAccvatno;
        public string Accvatno
        {
            get { return _fAccvatno; }
            set
            {
                if (_fAccvatno != value)
                {
                    Modify();
                    _fAccvatno = value;
                }
            }
        }

        private short? _fAcsaleisinv;
        public short? Acsaleisinv
        {
            get { return _fAcsaleisinv; }
            set
            {
                if (_fAcsaleisinv != value)
                {
                    Modify();
                    _fAcsaleisinv = value;
                }
            }
        }

        private decimal _fArvalue;
        public decimal Arvalue
        {
            get { return _fArvalue; }
            set
            {
                if (_fArvalue != value)
                {
                    Modify();
                    _fArvalue = value;
                }
            }
        }

        private decimal? _fBankguaranteeamount;
        public decimal? Bankguaranteeamount
        {
            get { return _fBankguaranteeamount; }
            set
            {
                if (_fBankguaranteeamount != value)
                {
                    Modify();
                    _fBankguaranteeamount = value;
                }
            }
        }

        private short? _fCashcustomer;
        public short? Cashcustomer
        {
            get { return _fCashcustomer; }
            set
            {
                if (_fCashcustomer != value)
                {
                    Modify();
                    _fCashcustomer = value;
                }
            }
        }

        private string _fClearingagent;
        public string Clearingagent
        {
            get { return _fClearingagent; }
            set
            {
                if (_fClearingagent != value)
                {
                    Modify();
                    _fClearingagent = value;
                }
            }
        }

        private decimal? _fCreditinsuranceamount;
        public decimal? Creditinsuranceamount
        {
            get { return _fCreditinsuranceamount; }
            set
            {
                if (_fCreditinsuranceamount != value)
                {
                    Modify();
                    _fCreditinsuranceamount = value;
                }
            }
        }

        private int? _fCredittermtype;
        public int? Credittermtype
        {
            get { return _fCredittermtype; }
            set
            {
                if (_fCredittermtype != value)
                {
                    Modify();
                    _fCredittermtype = value;
                }
            }
        }

        private int? _fCstaheno;
        public int? Cstaheno
        {
            get { return _fCstaheno; }
            set
            {
                if (_fCstaheno != value)
                {
                    Modify();
                    _fCstaheno = value;
                }
            }
        }

        private int? _fCstrebateno;
        public int? Cstrebateno
        {
            get { return _fCstrebateno; }
            set
            {
                if (_fCstrebateno != value)
                {
                    Modify();
                    _fCstrebateno = value;
                }
            }
        }

        private int? _fCstvattype;
        public int? Cstvattype
        {
            get { return _fCstvattype; }
            set
            {
                if (_fCstvattype != value)
                {
                    Modify();
                    _fCstvattype = value;
                }
            }
        }

        private string _fCustomsupid;
        public string Customsupid
        {
            get { return _fCustomsupid; }
            set
            {
                if (_fCustomsupid != value)
                {
                    Modify();
                    _fCustomsupid = value;
                }
            }
        }

        private short? _fDdenabled;
        public short? Ddenabled
        {
            get { return _fDdenabled; }
            set
            {
                if (_fDdenabled != value)
                {
                    Modify();
                    _fDdenabled = value;
                }
            }
        }

        private int? _fDefaccrwgttyp;
        public int? Defaccrwgttyp
        {
            get { return _fDefaccrwgttyp; }
            set
            {
                if (_fDefaccrwgttyp != value)
                {
                    Modify();
                    _fDefaccrwgttyp = value;
                }
            }
        }

        private int? _fDefdltrecno;
        public int? Defdltrecno
        {
            get { return _fDefdltrecno; }
            set
            {
                if (_fDefdltrecno != value)
                {
                    Modify();
                    _fDefdltrecno = value;
                }
            }
        }

        private string _fDefdlvtime;
        public string Defdlvtime
        {
            get { return _fDefdlvtime; }
            set
            {
                if (_fDefdlvtime != value)
                {
                    Modify();
                    _fDefdlvtime = value;
                }
            }
        }

        private string _fDelivcity;
        public string Delivcity
        {
            get { return _fDelivcity; }
            set
            {
                if (_fDelivcity != value)
                {
                    Modify();
                    _fDelivcity = value;
                }
            }
        }

        private string _fDeliveryiln;
        public string Deliveryiln
        {
            get { return _fDeliveryiln; }
            set
            {
                if (_fDeliveryiln != value)
                {
                    Modify();
                    _fDeliveryiln = value;
                }
            }
        }

        private string _fDelivname1;
        public string Delivname1
        {
            get { return _fDelivname1; }
            set
            {
                if (_fDelivname1 != value)
                {
                    Modify();
                    _fDelivname1 = value;
                }
            }
        }

        private string _fDelivname2;
        public string Delivname2
        {
            get { return _fDelivname2; }
            set
            {
                if (_fDelivname2 != value)
                {
                    Modify();
                    _fDelivname2 = value;
                }
            }
        }

        private string _fDelivpostcode;
        public string Delivpostcode
        {
            get { return _fDelivpostcode; }
            set
            {
                if (_fDelivpostcode != value)
                {
                    Modify();
                    _fDelivpostcode = value;
                }
            }
        }

        private string _fDelivstreet;
        public string Delivstreet
        {
            get { return _fDelivstreet; }
            set
            {
                if (_fDelivstreet != value)
                {
                    Modify();
                    _fDelivstreet = value;
                }
            }
        }

        private short? _fDlvnoteshowsancilsummary;
        public short? Dlvnoteshowsancilsummary
        {
            get { return _fDlvnoteshowsancilsummary; }
            set
            {
                if (_fDlvnoteshowsancilsummary != value)
                {
                    Modify();
                    _fDlvnoteshowsancilsummary = value;
                }
            }
        }

        private short? _fDlvnoteshowspalletsummary;
        public short? Dlvnoteshowspalletsummary
        {
            get { return _fDlvnoteshowspalletsummary; }
            set
            {
                if (_fDlvnoteshowspalletsummary != value)
                {
                    Modify();
                    _fDlvnoteshowspalletsummary = value;
                }
            }
        }

        private short? _fDutyinclsales;
        public short? Dutyinclsales
        {
            get { return _fDutyinclsales; }
            set
            {
                if (_fDutyinclsales != value)
                {
                    Modify();
                    _fDutyinclsales = value;
                }
            }
        }

        private string _fEdifacilityno;
        public string Edifacilityno
        {
            get { return _fEdifacilityno; }
            set
            {
                if (_fEdifacilityno != value)
                {
                    Modify();
                    _fEdifacilityno = value;
                }
            }
        }

        private string _fEdiwarehouseno;
        public string Ediwarehouseno
        {
            get { return _fEdiwarehouseno; }
            set
            {
                if (_fEdiwarehouseno != value)
                {
                    Modify();
                    _fEdiwarehouseno = value;
                }
            }
        }

        private int? _fGrossornett;
        public int? Grossornett
        {
            get { return _fGrossornett; }
            set
            {
                if (_fGrossornett != value)
                {
                    Modify();
                    _fGrossornett = value;
                }
            }
        }

        private string _fIlnNumber;
        public string IlnNumber
        {
            get { return _fIlnNumber; }
            set
            {
                if (_fIlnNumber != value)
                {
                    Modify();
                    _fIlnNumber = value;
                }
            }
        }

        private decimal? _fImparval;
        public decimal? Imparval
        {
            get { return _fImparval; }
            set
            {
                if (_fImparval != value)
                {
                    Modify();
                    _fImparval = value;
                }
            }
        }

        private short _fIncindiscscheme;
        public short Incindiscscheme
        {
            get { return _fIncindiscscheme; }
            set
            {
                if (_fIncindiscscheme != value)
                {
                    Modify();
                    _fIncindiscscheme = value;
                }
            }
        }

        private short _fIncinpricelist;
        public short Incinpricelist
        {
            get { return _fIncinpricelist; }
            set
            {
                if (_fIncinpricelist != value)
                {
                    Modify();
                    _fIncinpricelist = value;
                }
            }
        }

        private short? _fInterdeptcust;
        /// <summary>
        /// Is this ACCOUNT an Interdepartment Sale? - 1 = Yes
        /// </summary>
        public short? Interdeptcust
        {
            get { return _fInterdeptcust; }
            set
            {
                if (_fInterdeptcust != value)
                {
                    Modify();
                    _fInterdeptcust = value;
                }
            }
        }

        private short? _fMandpricemeth;
        public short? Mandpricemeth
        {
            get { return _fMandpricemeth; }
            set
            {
                if (_fMandpricemeth != value)
                {
                    Modify();
                    _fMandpricemeth = value;
                }
            }
        }

        private short? _fMergecustordrecs;
        public short? Mergecustordrecs
        {
            get { return _fMergecustordrecs; }
            set
            {
                if (_fMergecustordrecs != value)
                {
                    Modify();
                    _fMergecustordrecs = value;
                }
            }
        }

        private short? _fMultidlvdateononerte;
        public short? Multidlvdateononerte
        {
            get { return _fMultidlvdateononerte; }
            set
            {
                if (_fMultidlvdateononerte != value)
                {
                    Modify();
                    _fMultidlvdateononerte = value;
                }
            }
        }

        private int? _fNumofinvoicecopies;
        public int? Numofinvoicecopies
        {
            get { return _fNumofinvoicecopies; }
            set
            {
                if (_fNumofinvoicecopies != value)
                {
                    Modify();
                    _fNumofinvoicecopies = value;
                }
            }
        }

        private int? _fPaymentagentclarecno;
        public int? Paymentagentclarecno
        {
            get { return _fPaymentagentclarecno; }
            set
            {
                if (_fPaymentagentclarecno != value)
                {
                    Modify();
                    _fPaymentagentclarecno = value;
                }
            }
        }

        private string _fPostcode2;
        public string Postcode2
        {
            get { return _fPostcode2; }
            set
            {
                if (_fPostcode2 != value)
                {
                    Modify();
                    _fPostcode2 = value;
                }
            }
        }

        private decimal _fPriceddlvvalue;
        public decimal Priceddlvvalue
        {
            get { return _fPriceddlvvalue; }
            set
            {
                if (_fPriceddlvvalue != value)
                {
                    Modify();
                    _fPriceddlvvalue = value;
                }
            }
        }

        private int? _fPurchinvvatrecno;
        public int? Purchinvvatrecno
        {
            get { return _fPurchinvvatrecno; }
            set
            {
                if (_fPurchinvvatrecno != value)
                {
                    Modify();
                    _fPurchinvvatrecno = value;
                }
            }
        }

        private int? _fQuickcustentry;
        public int? Quickcustentry
        {
            get { return _fQuickcustentry; }
            set
            {
                if (_fQuickcustentry != value)
                {
                    Modify();
                    _fQuickcustentry = value;
                }
            }
        }

        private short? _fRequireshippingnotification;
        public short? Requireshippingnotification
        {
            get { return _fRequireshippingnotification; }
            set
            {
                if (_fRequireshippingnotification != value)
                {
                    Modify();
                    _fRequireshippingnotification = value;
                }
            }
        }

        private short? _fRtemandhaul;
        public short? Rtemandhaul
        {
            get { return _fRtemandhaul; }
            set
            {
                if (_fRtemandhaul != value)
                {
                    Modify();
                    _fRtemandhaul = value;
                }
            }
        }

        private int? _fSalesscrmainoffcust;
        public int? Salesscrmainoffcust
        {
            get { return _fSalesscrmainoffcust; }
            set
            {
                if (_fSalesscrmainoffcust != value)
                {
                    Modify();
                    _fSalesscrmainoffcust = value;
                }
            }
        }

        private string _fScatcode;
        public string Scatcode
        {
            get { return _fScatcode; }
            set
            {
                if (_fScatcode != value)
                {
                    Modify();
                    _fScatcode = value;
                }
            }
        }

        private int? _fScatlength;
        public int? Scatlength
        {
            get { return _fScatlength; }
            set
            {
                if (_fScatlength != value)
                {
                    Modify();
                    _fScatlength = value;
                }
            }
        }

        private int? _fScatseqendno;
        public int? Scatseqendno
        {
            get { return _fScatseqendno; }
            set
            {
                if (_fScatseqendno != value)
                {
                    Modify();
                    _fScatseqendno = value;
                }
            }
        }

        private int? _fScatseqstartno;
        public int? Scatseqstartno
        {
            get { return _fScatseqstartno; }
            set
            {
                if (_fScatseqstartno != value)
                {
                    Modify();
                    _fScatseqstartno = value;
                }
            }
        }

        private short? _fSetdlvdateasinvdate;
        public short? Setdlvdateasinvdate
        {
            get { return _fSetdlvdateasinvdate; }
            set
            {
                if (_fSetdlvdateasinvdate != value)
                {
                    Modify();
                    _fSetdlvdateasinvdate = value;
                }
            }
        }

        private short? _fSsccfordlv;
        public short? Ssccfordlv
        {
            get { return _fSsccfordlv; }
            set
            {
                if (_fSsccfordlv != value)
                {
                    Modify();
                    _fSsccfordlv = value;
                }
            }
        }

        private int? _fStarecno;
        public int? Starecno
        {
            get { return _fStarecno; }
            set
            {
                if (_fStarecno != value)
                {
                    Modify();
                    _fStarecno = value;
                }
            }
        }

        private short? _fSupclaimscust;
        public short? Supclaimscust
        {
            get { return _fSupclaimscust; }
            set
            {
                if (_fSupclaimscust != value)
                {
                    Modify();
                    _fSupclaimscust = value;
                }
            }
        }

        private int? _fSuphasdefexpprice;
        public int? Suphasdefexpprice
        {
            get { return _fSuphasdefexpprice; }
            set
            {
                if (_fSuphasdefexpprice != value)
                {
                    Modify();
                    _fSuphasdefexpprice = value;
                }
            }
        }

        private short? _fThirdpartyAllowprices;
        public short? ThirdpartyAllowprices
        {
            get { return _fThirdpartyAllowprices; }
            set
            {
                if (_fThirdpartyAllowprices != value)
                {
                    Modify();
                    _fThirdpartyAllowprices = value;
                }
            }
        }

        private short? _fThirdpartyonly;
        public short? Thirdpartyonly
        {
            get { return _fThirdpartyonly; }
            set
            {
                if (_fThirdpartyonly != value)
                {
                    Modify();
                    _fThirdpartyonly = value;
                }
            }
        }

        private string _fTrancoldstoreno;
        public string Trancoldstoreno
        {
            get { return _fTrancoldstoreno; }
            set
            {
                if (_fTrancoldstoreno != value)
                {
                    Modify();
                    _fTrancoldstoreno = value;
                }
            }
        }

        private decimal _fUnpriceddlvvalue;
        public decimal Unpriceddlvvalue
        {
            get { return _fUnpriceddlvvalue; }
            set
            {
                if (_fUnpriceddlvvalue != value)
                {
                    Modify();
                    _fUnpriceddlvvalue = value;
                }
            }
        }

        private short? _fUsing1099;
        public short? Using1099
        {
            get { return _fUsing1099; }
            set
            {
                if (_fUsing1099 != value)
                {
                    Modify();
                    _fUsing1099 = value;
                }
            }
        }

        private short _fWtaxincvat;
        public short Wtaxincvat
        {
            get { return _fWtaxincvat; }
            set
            {
                if (_fWtaxincvat != value)
                {
                    Modify();
                    _fWtaxincvat = value;
                }
            }
        }

        private short? _fZaplcdtrans;
        public short? Zaplcdtrans
        {
            get { return _fZaplcdtrans; }
            set
            {
                if (_fZaplcdtrans != value)
                {
                    Modify();
                    _fZaplcdtrans = value;
                }
            }
        }

        public override string Key
        {
            get { return Acccode; }
            set { Acccode = value; }
        }

        public override string KeyAsString { get { return Key; } }


        public override Account Clone()
        {
            var obj = new Account
                {
                    Acccode = Acccode,
                    Acc1099type = Acc1099type,
                    Accactive = Accactive,
                    Accaddress1 = Accaddress1,
                    Accaddress2 = Accaddress2,
                    Accaddress3 = Accaddress3,
                    Accaddress4 = Accaddress4,
                    Accallpartprcinv = Accallpartprcinv,
                    Accananumber = Accananumber,
                    Accanctypondispatch = Accanctypondispatch,
                    Accanusefastmoving = Accanusefastmoving,
                    Accapdefcomm = Accapdefcomm,
                    Accapdefhand = Accapdefhand,
                    Accappayfrom = Accappayfrom,
                    Accapply2vatspurch = Accapply2vatspurch,
                    Accapply2vatssales = Accapply2vatssales,
                    Accapplycompvatpurch = Accapplycompvatpurch,
                    Accapplycompvatsale = Accapplycompvatsale,
                    Accapplywithholdtax = Accapplywithholdtax,
                    Accarautoalloccdts = Accarautoalloccdts,
                    Accarcreditlimit = Accarcreditlimit,
                    Accarcreditterms = Accarcreditterms,
                    Accarinvoiceperiod = Accarinvoiceperiod,
                    Accarinvoicetype = Accarinvoicetype,
                    Accarpodreq = Accarpodreq,
                    Accarstmntperiod = Accarstmntperiod,
                    Acccapeallupl = Acccapeallupl,
                    Accchepcode = Accchepcode,
                    Acccomprecno = Acccomprecno,
                    Accconfpalsondispatch = Accconfpalsondispatch,
                    Acccountryno = Acccountryno,
                    Acccustordcheck = Acccustordcheck,
                    Acccustordreq = Acccustordreq,
                    Acccustrefno = Acccustrefno,
                    Accdefsaloffno = Accdefsaloffno,
                    Accdelivarea = Accdelivarea,
                    Accdelivdefstcloc = Accdelivdefstcloc,
                    Accdelivnotestyle = Accdelivnotestyle,
                    Accdelivtownrecno = Accdelivtownrecno,
                    Accdetsonrem = Accdetsonrem,
                    Accedidepotno = Accedidepotno,
                    Accextcrdlim = Accextcrdlim,
                    Accextdate = Accextdate,
                    Accexterntranship = Accexterntranship,
                    Accfaxno = Accfaxno,
                    Accglanl = Accglanl,
                    Acchaulierananumber = Acchaulierananumber,
                    Acchofrecno = Acchofrecno,
                    Accifcocode = Accifcocode,
                    Accincrabofil = Accincrabofil,
                    Accinvoiceananumber = Accinvoiceananumber,
                    Accinvondesp = Accinvondesp,
                    Accisbondedstore = Accisbondedstore,
                    Accisdeffot = Accisdeffot,
                    Acclanguage = Acclanguage,
                    Accname = Accname,
                    Accpalwizsite = Accpalwizsite,
                    Accpalwizstcloc = Accpalwizstcloc,
                    Accpaydays = Accpaydays,
                    Accpostcode = Accpostcode,
                    Accpredlvedireqd = Accpredlvedireqd,
                    Accrecno = Accrecno,
                    Accsplitinvoice = Accsplitinvoice,
                    Accssccpalnoreqd = Accssccpalnoreqd,
                    Accsuphofrecno = Accsuphofrecno,
                    Acctelno = Acctelno,
                    Accunlimcrdlim = Accunlimcrdlim,
                    Accuploadhofrecno = Accuploadhofrecno,
                    Accvatno = Accvatno,
                    Acsaleisinv = Acsaleisinv,
                    Arvalue = Arvalue,
                    Bankguaranteeamount = Bankguaranteeamount,
                    Cashcustomer = Cashcustomer,
                    Clearingagent = Clearingagent,
                    Creditinsuranceamount = Creditinsuranceamount,
                    Credittermtype = Credittermtype,
                    Cstaheno = Cstaheno,
                    Cstrebateno = Cstrebateno,
                    Cstvattype = Cstvattype,
                    Customsupid = Customsupid,
                    Ddenabled = Ddenabled,
                    Defaccrwgttyp = Defaccrwgttyp,
                    Defdltrecno = Defdltrecno,
                    Defdlvtime = Defdlvtime,
                    Delivcity = Delivcity,
                    Deliveryiln = Deliveryiln,
                    Delivname1 = Delivname1,
                    Delivname2 = Delivname2,
                    Delivpostcode = Delivpostcode,
                    Delivstreet = Delivstreet,
                    Dlvnoteshowsancilsummary = Dlvnoteshowsancilsummary,
                    Dlvnoteshowspalletsummary = Dlvnoteshowspalletsummary,
                    Dutyinclsales = Dutyinclsales,
                    Edifacilityno = Edifacilityno,
                    Ediwarehouseno = Ediwarehouseno,
                    Grossornett = Grossornett,
                    IlnNumber = IlnNumber,
                    Imparval = Imparval,
                    Incindiscscheme = Incindiscscheme,
                    Incinpricelist = Incinpricelist,
                    Interdeptcust = Interdeptcust,
                    Mandpricemeth = Mandpricemeth,
                    Mergecustordrecs = Mergecustordrecs,
                    Multidlvdateononerte = Multidlvdateononerte,
                    Numofinvoicecopies = Numofinvoicecopies,
                    Paymentagentclarecno = Paymentagentclarecno,
                    Postcode2 = Postcode2,
                    Priceddlvvalue = Priceddlvvalue,
                    Purchinvvatrecno = Purchinvvatrecno,
                    Quickcustentry = Quickcustentry,
                    Requireshippingnotification = Requireshippingnotification,
                    Rtemandhaul = Rtemandhaul,
                    Salesscrmainoffcust = Salesscrmainoffcust,
                    Scatcode = Scatcode,
                    Scatlength = Scatlength,
                    Scatseqendno = Scatseqendno,
                    Scatseqstartno = Scatseqstartno,
                    Setdlvdateasinvdate = Setdlvdateasinvdate,
                    Ssccfordlv = Ssccfordlv,
                    Starecno = Starecno,
                    Supclaimscust = Supclaimscust,
                    Suphasdefexpprice = Suphasdefexpprice,
                    ThirdpartyAllowprices = ThirdpartyAllowprices,
                    Thirdpartyonly = Thirdpartyonly,
                    Trancoldstoreno = Trancoldstoreno,
                    Unpriceddlvvalue = Unpriceddlvvalue,
                    Using1099 = Using1099,
                    Wtaxincvat = Wtaxincvat,
                    Zaplcdtrans = Zaplcdtrans,
                };

            return obj;
        }

        public static class FieldNames
        {
// ReSharper disable InconsistentNaming
            public const string  ACCCODE = "ACCCODE";
            public const string  ACC1099TYPE = "ACC1099TYPE";
            public const string  ACCACTIVE = "ACCACTIVE";
            public const string  ACCADDRESS1 = "ACCADDRESS1";
            public const string  ACCADDRESS2 = "ACCADDRESS2";
            public const string  ACCADDRESS3 = "ACCADDRESS3";
            public const string  ACCADDRESS4 = "ACCADDRESS4";
            public const string  ACCALLPARTPRCINV = "ACCALLPARTPRCINV";
            public const string  ACCANANUMBER = "ACCANANUMBER";
            public const string  ACCANCTYPONDISPATCH = "ACCANCTYPONDISPATCH";
            public const string  ACCANUSEFASTMOVING = "ACCANUSEFASTMOVING";
            public const string  ACCAPDEFCOMM = "ACCAPDEFCOMM";
            public const string  ACCAPDEFHAND = "ACCAPDEFHAND";
            public const string  ACCAPPAYFROM = "ACCAPPAYFROM";
            public const string  ACCAPPLY2VATSPURCH = "ACCAPPLY2VATSPURCH";
            public const string  ACCAPPLY2VATSSALES = "ACCAPPLY2VATSSALES";
            public const string  ACCAPPLYCOMPVATPURCH = "ACCAPPLYCOMPVATPURCH";
            public const string  ACCAPPLYCOMPVATSALE = "ACCAPPLYCOMPVATSALE";
            public const string  ACCAPPLYWITHHOLDTAX = "ACCAPPLYWITHHOLDTAX";
            public const string  ACCARAUTOALLOCCDTS = "ACCARAUTOALLOCCDTS";
            public const string  ACCARCREDITLIMIT = "ACCARCREDITLIMIT";
            public const string  ACCARCREDITTERMS = "ACCARCREDITTERMS";
            public const string  ACCARINVOICEPERIOD = "ACCARINVOICEPERIOD";
            public const string  ACCARINVOICETYPE = "ACCARINVOICETYPE";
            public const string  ACCARPODREQ = "ACCARPODREQ";
            public const string  ACCARSTMNTPERIOD = "ACCARSTMNTPERIOD";
            public const string  ACCCAPEALLUPL = "ACCCAPEALLUPL";
            public const string  ACCCHEPCODE = "ACCCHEPCODE";
            public const string  ACCCOMPRECNO = "ACCCOMPRECNO";
            public const string  ACCCONFPALSONDISPATCH = "ACCCONFPALSONDISPATCH";
            public const string  ACCCOUNTRYNO = "ACCCOUNTRYNO";
            public const string  ACCCUSTORDCHECK = "ACCCUSTORDCHECK";
            public const string  ACCCUSTORDREQ = "ACCCUSTORDREQ";
            public const string  ACCCUSTREFNO = "ACCCUSTREFNO";
            public const string  ACCDEFSALOFFNO = "ACCDEFSALOFFNO";
            public const string  ACCDELIVAREA = "ACCDELIVAREA";
            public const string  ACCDELIVDEFSTCLOC = "ACCDELIVDEFSTCLOC";
            public const string  ACCDELIVNOTESTYLE = "ACCDELIVNOTESTYLE";
            public const string  ACCDELIVTOWNRECNO = "ACCDELIVTOWNRECNO";
            public const string  ACCDETSONREM = "ACCDETSONREM";
            public const string  ACCEDIDEPOTNO = "ACCEDIDEPOTNO";
            public const string  ACCEXTCRDLIM = "ACCEXTCRDLIM";
            public const string  ACCEXTDATE = "ACCEXTDATE";
            public const string  ACCEXTERNTRANSHIP = "ACCEXTERNTRANSHIP";
            public const string  ACCFAXNO = "ACCFAXNO";
            public const string  ACCGLANL = "ACCGLANL";
            public const string  ACCHAULIERANANUMBER = "ACCHAULIERANANUMBER";
            public const string  ACCHOFRECNO = "ACCHOFRECNO";
            public const string  ACCIFCOCODE = "ACCIFCOCODE";
            public const string  ACCINCRABOFIL = "ACCINCRABOFIL";
            public const string  ACCINVOICEANANUMBER = "ACCINVOICEANANUMBER";
            public const string  ACCINVONDESP = "ACCINVONDESP";
            public const string  ACCISBONDEDSTORE = "ACCISBONDEDSTORE";
            public const string  ACCISDEFFOT = "ACCISDEFFOT";
            public const string  ACCLANGUAGE = "ACCLANGUAGE";
            public const string  ACCNAME = "ACCNAME";
            public const string  ACCPALWIZSITE = "ACCPALWIZSITE";
            public const string  ACCPALWIZSTCLOC = "ACCPALWIZSTCLOC";
            public const string  ACCPAYDAYS = "ACCPAYDAYS";
            public const string  ACCPOSTCODE = "ACCPOSTCODE";
            public const string  ACCPREDLVEDIREQD = "ACCPREDLVEDIREQD";
            public const string  ACCRECNO = "ACCRECNO";
            public const string  ACCSPLITINVOICE = "ACCSPLITINVOICE";
            public const string  ACCSSCCPALNOREQD = "ACCSSCCPALNOREQD";
            public const string  ACCSUPHOFRECNO = "ACCSUPHOFRECNO";
            public const string  ACCTELNO = "ACCTELNO";
            public const string  ACCUNLIMCRDLIM = "ACCUNLIMCRDLIM";
            public const string  ACCUPLOADHOFRECNO = "ACCUPLOADHOFRECNO";
            public const string  ACCVATNO = "ACCVATNO";
            public const string  ACSALEISINV = "ACSALEISINV";
            public const string  ARVALUE = "ARVALUE";
            public const string  BANKGUARANTEEAMOUNT = "BANKGUARANTEEAMOUNT";
            public const string  CASHCUSTOMER = "CASHCUSTOMER";
            public const string  CLEARINGAGENT = "CLEARINGAGENT";
            public const string  CREDITINSURANCEAMOUNT = "CREDITINSURANCEAMOUNT";
            public const string  CREDITTERMTYPE = "CREDITTERMTYPE";
            public const string  CSTAHENO = "CSTAHENO";
            public const string  CSTREBATENO = "CSTREBATENO";
            public const string  CSTVATTYPE = "CSTVATTYPE";
            public const string  CUSTOMSUPID = "CUSTOMSUPID";
            public const string  DDENABLED = "DDENABLED";
            public const string  DEFACCRWGTTYP = "DEFACCRWGTTYP";
            public const string  DEFDLTRECNO = "DEFDLTRECNO";
            public const string  DEFDLVTIME = "DEFDLVTIME";
            public const string  DELIVCITY = "DELIVCITY";
            public const string  DELIVERYILN = "DELIVERYILN";
            public const string  DELIVNAME1 = "DELIVNAME1";
            public const string  DELIVNAME2 = "DELIVNAME2";
            public const string  DELIVPOSTCODE = "DELIVPOSTCODE";
            public const string  DELIVSTREET = "DELIVSTREET";
            public const string  DLVNOTESHOWSANCILSUMMARY = "DLVNOTESHOWSANCILSUMMARY";
            public const string  DLVNOTESHOWSPALLETSUMMARY = "DLVNOTESHOWSPALLETSUMMARY";
            public const string  DUTYINCLSALES = "DUTYINCLSALES";
            public const string  EDIFACILITYNO = "EDIFACILITYNO";
            public const string  EDIWAREHOUSENO = "EDIWAREHOUSENO";
            public const string  GROSSORNETT = "GROSSORNETT";
            public const string  ILN_NUMBER = "ILN_NUMBER";
            public const string  IMPARVAL = "IMPARVAL";
            public const string  INCINDISCSCHEME = "INCINDISCSCHEME";
            public const string  INCINPRICELIST = "INCINPRICELIST";
            public const string  INTERDEPTCUST = "INTERDEPTCUST";
            public const string  MANDPRICEMETH = "MANDPRICEMETH";
            public const string  MERGECUSTORDRECS = "MERGECUSTORDRECS";
            public const string  MULTIDLVDATEONONERTE = "MULTIDLVDATEONONERTE";
            public const string  NUMOFINVOICECOPIES = "NUMOFINVOICECOPIES";
            public const string  PAYMENTAGENTCLARECNO = "PAYMENTAGENTCLARECNO";
            public const string  POSTCODE2 = "POSTCODE2";
            public const string  PRICEDDLVVALUE = "PRICEDDLVVALUE";
            public const string  PURCHINVVATRECNO = "PURCHINVVATRECNO";
            public const string  QUICKCUSTENTRY = "QUICKCUSTENTRY";
            public const string  REQUIRESHIPPINGNOTIFICATION = "REQUIRESHIPPINGNOTIFICATION";
            public const string  RTEMANDHAUL = "RTEMANDHAUL";
            public const string  SALESSCRMAINOFFCUST = "SALESSCRMAINOFFCUST";
            public const string  SCATCODE = "SCATCODE";
            public const string  SCATLENGTH = "SCATLENGTH";
            public const string  SCATSEQENDNO = "SCATSEQENDNO";
            public const string  SCATSEQSTARTNO = "SCATSEQSTARTNO";
            public const string  SETDLVDATEASINVDATE = "SETDLVDATEASINVDATE";
            public const string  SSCCFORDLV = "SSCCFORDLV";
            public const string  STARECNO = "STARECNO";
            public const string  SUPCLAIMSCUST = "SUPCLAIMSCUST";
            public const string  SUPHASDEFEXPPRICE = "SUPHASDEFEXPPRICE";
            public const string  THIRDPARTY_ALLOWPRICES = "THIRDPARTY_ALLOWPRICES";
            public const string  THIRDPARTYONLY = "THIRDPARTYONLY";
            public const string  TRANCOLDSTORENO = "TRANCOLDSTORENO";
            public const string  UNPRICEDDLVVALUE = "UNPRICEDDLVVALUE";
            public const string  USING1099 = "USING1099";
            public const string  WTAXINCVAT = "WTAXINCVAT";
            public const string  ZAPLCDTRANS = "ZAPLCDTRANS";
 // ReSharper restore InconsistentNaming
        }


    }

}
