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
    /// Entity for the STOCLOC table
    /// </summary>
    public partial class StocLoc : BaseDbModel<StocLoc, int>
    {
#region tableDefs

       public static List<EntityPropDef> GetPropDefs() {
         var result = new List<EntityPropDef>();

//EntityPropDef(string propName, string columnName, bool isKey, bool isNullable, string refEntityName, PropertyInfo keyPropInfo,
//            int size, int? prec, int? scale)



         result.Add(new EntityPropDef(
         PropertyHelper <StocLoc>.GetProperty(x => x.Stcrecno),
         "STCRECNO", // columnName
         true,                    //isKey
         false, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  5, // int? prec
                           0  // int? Scale
         ,
         typeof(StocLoc)
       ));


         result.Add(new EntityPropDef(
         PropertyHelper <StocLoc>.GetProperty(x => x.Aliasfrom),
         "ALIASFROM", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         10,       // int size   
                  null, // int? prec
                   
         null // int? Scale
         ,
         typeof(StocLoc)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <StocLoc>.GetProperty(x => x.Aliasto),
         "ALIASTO", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         10,       // int size   
                  null, // int? prec
                   
         null // int? Scale
         ,
         typeof(StocLoc)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <StocLoc>.GetProperty(x => x.Allocareaexpected),
         "ALLOCAREAEXPECTED", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  1, // int? prec
                           0  // int? Scale
         ,
         typeof(StocLoc)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <StocLoc>.GetProperty(x => x.Alloclitidtrnshipno),
         "ALLOCLITIDTRNSHIPNO", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  1, // int? prec
                           0  // int? Scale
         ,
         typeof(StocLoc)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <StocLoc>.GetProperty(x => x.Allowautorcvinpoentry),
         "ALLOWAUTORCVINPOENTRY", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  1, // int? prec
                           0  // int? Scale
         ,
         typeof(StocLoc)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <StocLoc>.GetProperty(x => x.Allowfifointshiprcv),
         "ALLOWFIFOINTSHIPRCV", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  1, // int? prec
                           0  // int? Scale
         ,
         typeof(StocLoc)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <StocLoc>.GetProperty(x => x.Autoallocpick),
         "AUTOALLOCPICK", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  1, // int? prec
                           0  // int? Scale
         ,
         typeof(StocLoc)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <StocLoc>.GetProperty(x => x.Autodespatchinordprgdet),
         "AUTODESPATCHINORDPRGDET", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  1, // int? prec
                           0  // int? Scale
         ,
         typeof(StocLoc)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <StocLoc>.GetProperty(x => x.AutofifoalloconAnc),
         "AUTOFIFOALLOCON_ANC", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  1, // int? prec
                           0  // int? Scale
         ,
         typeof(StocLoc)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <StocLoc>.GetProperty(x => x.Autoonerouteperdlv),
         "AUTOONEROUTEPERDLV", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  1, // int? prec
                           0  // int? Scale
         ,
         typeof(StocLoc)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <StocLoc>.GetProperty(x => x.Autopackmeth),
         "AUTOPACKMETH", // columnName
         false,                    //isKey
         false, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  1, // int? prec
                           0  // int? Scale
         ,
         typeof(StocLoc)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <StocLoc>.GetProperty(x => x.Autorcvfifopals),
         "AUTORCVFIFOPALS", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  1, // int? prec
                           0  // int? Scale
         ,
         typeof(StocLoc)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <StocLoc>.GetProperty(x => x.Autorcvonepoperday),
         "AUTORCVONEPOPERDAY", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  1, // int? prec
                           0  // int? Scale
         ,
         typeof(StocLoc)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <StocLoc>.GetProperty(x => x.Autorcvtrans),
         "AUTORCVTRANS", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  1, // int? prec
                           0  // int? Scale
         ,
         typeof(StocLoc)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <StocLoc>.GetProperty(x => x.Canrepack),
         "CANREPACK", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  1, // int? prec
                           0  // int? Scale
         ,
         typeof(StocLoc)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <StocLoc>.GetProperty(x => x.Capecode),
         "CAPECODE", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         8,       // int size   
                  null, // int? prec
                   
         null // int? Scale
         ,
         typeof(StocLoc)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <StocLoc>.GetProperty(x => x.Capespan),
         "CAPESPAN", // columnName
         false,                    //isKey
         false, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  1, // int? prec
                           0  // int? Scale
         ,
         typeof(StocLoc)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <StocLoc>.GetProperty(x => x.Chepcode),
         "CHEPCODE", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         10,       // int size   
                  null, // int? prec
                   
         null // int? Scale
         ,
         typeof(StocLoc)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <StocLoc>.GetProperty(x => x.Communicate),
         "COMMUNICATE", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  1, // int? prec
                           0  // int? Scale
         ,
         typeof(StocLoc)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <StocLoc>.GetProperty(x => x.Confirmtranshipments),
         "CONFIRMTRANSHIPMENTS", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  1, // int? prec
                           0  // int? Scale
         ,
         typeof(StocLoc)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <StocLoc>.GetProperty(x => x.Confsaleout),
         "CONFSALEOUT", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  1, // int? prec
                           0  // int? Scale
         ,
         typeof(StocLoc)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <StocLoc>.GetProperty(x => x.Consolidatepick),
         "CONSOLIDATEPICK", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  1, // int? prec
                           0  // int? Scale
         ,
         typeof(StocLoc)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <StocLoc>.GetProperty(x => x.Defloadbayrecno),
         "DEFLOADBAYRECNO", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  10, // int? prec
                           0  // int? Scale
         ,
         typeof(StocLoc)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <StocLoc>.GetProperty(x => x.Defprepackareain),
         "DEFPREPACKAREAIN", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  10, // int? prec
                           0  // int? Scale
         ,
         typeof(StocLoc)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <StocLoc>.GetProperty(x => x.Defprepackareaout),
         "DEFPREPACKAREAOUT", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  10, // int? prec
                           0  // int? Scale
         ,
         typeof(StocLoc)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <StocLoc>.GetProperty(x => x.Defsmnno),
         "DEFSMNNO", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  5, // int? prec
                           0  // int? Scale
         ,
         typeof(StocLoc)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <StocLoc>.GetProperty(x => x.Deftranbayrecno),
         "DEFTRANBAYRECNO", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  10, // int? prec
                           0  // int? Scale
         ,
         typeof(StocLoc)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <StocLoc>.GetProperty(x => x.Delnoterpt),
         "DELNOTERPT", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         8,       // int size   
                  null, // int? prec
                   
         null // int? Scale
         ,
         typeof(StocLoc)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <StocLoc>.GetProperty(x => x.Delprinter),
         "DELPRINTER", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         6,       // int size   
                  null, // int? prec
                   
         null // int? Scale
         ,
         typeof(StocLoc)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <StocLoc>.GetProperty(x => x.Discardallocmsgondlvprt),
         "DISCARDALLOCMSGONDLVPRT", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  1, // int? prec
                           0  // int? Scale
         ,
         typeof(StocLoc)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <StocLoc>.GetProperty(x => x.Dlvnoteshowsancilandpallet),
         "DLVNOTESHOWSANCILANDPALLET", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  1, // int? prec
                           0  // int? Scale
         ,
         typeof(StocLoc)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <StocLoc>.GetProperty(x => x.Entaveqcwgt4tship),
         "ENTAVEQCWGT4TSHIP", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  1, // int? prec
                           0  // int? Scale
         ,
         typeof(StocLoc)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <StocLoc>.GetProperty(x => x.FifoDespOpt),
         "FIFO_DESP_OPT", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  5, // int? prec
                           0  // int? Scale
         ,
         typeof(StocLoc)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <StocLoc>.GetProperty(x => x.FifoDespOrder),
         "FIFO_DESP_ORDER", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  1, // int? prec
                           0  // int? Scale
         ,
         typeof(StocLoc)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <StocLoc>.GetProperty(x => x.Homesaloffno),
         "HOMESALOFFNO", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  5, // int? prec
                           0  // int? Scale
         ,
         typeof(StocLoc)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <StocLoc>.GetProperty(x => x.Homestcloc),
         "HOMESTCLOC", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  5, // int? prec
                           0  // int? Scale
         ,
         typeof(StocLoc)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <StocLoc>.GetProperty(x => x.Ifcocode),
         "IFCOCODE", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         13,       // int size   
                  null, // int? prec
                   
         null // int? Scale
         ,
         typeof(StocLoc)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <StocLoc>.GetProperty(x => x.Incountry),
         "INCOUNTRY", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  5, // int? prec
                           0  // int? Scale
         ,
         typeof(StocLoc)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <StocLoc>.GetProperty(x => x.Intransitbayrecno),
         "INTRANSITBAYRECNO", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  10, // int? prec
                           0  // int? Scale
         ,
         typeof(StocLoc)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <StocLoc>.GetProperty(x => x.Iscommssite),
         "ISCOMMSSITE", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  1, // int? prec
                           0  // int? Scale
         ,
         typeof(StocLoc)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <StocLoc>.GetProperty(x => x.Isdirstcloc),
         "ISDIRSTCLOC", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  5, // int? prec
                           0  // int? Scale
         ,
         typeof(StocLoc)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <StocLoc>.GetProperty(x => x.Isgrowerdirect),
         "ISGROWERDIRECT", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  1, // int? prec
                           0  // int? Scale
         ,
         typeof(StocLoc)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <StocLoc>.GetProperty(x => x.Isnonpallet),
         "ISNONPALLET", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  1, // int? prec
                           0  // int? Scale
         ,
         typeof(StocLoc)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <StocLoc>.GetProperty(x => x.Istradesaleslocation),
         "ISTRADESALESLOCATION", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  1, // int? prec
                           0  // int? Scale
         ,
         typeof(StocLoc)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <StocLoc>.GetProperty(x => x.Lissplitpick),
         "LISSPLITPICK", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  1, // int? prec
                           0  // int? Scale
         ,
         typeof(StocLoc)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <StocLoc>.GetProperty(x => x.Locarea),
         "LOCAREA", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         10,       // int size   
                  null, // int? prec
                   
         null // int? Scale
         ,
         typeof(StocLoc)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <StocLoc>.GetProperty(x => x.Lstdaldelrecno),
         "LSTDALDELRECNO", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  10, // int? prec
                           0  // int? Scale
         ,
         typeof(StocLoc)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <StocLoc>.GetProperty(x => x.Lstpalaudrecno),
         "LSTPALAUDRECNO", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  10, // int? prec
                           0  // int? Scale
         ,
         typeof(StocLoc)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <StocLoc>.GetProperty(x => x.Maxsmvtime),
         "MAXSMVTIME", // columnName
         false,                    //isKey
         false, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  5, // int? prec
                           0  // int? Scale
         ,
         typeof(StocLoc)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <StocLoc>.GetProperty(x => x.Modemno),
         "MODEMNO", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         12,       // int size   
                  null, // int? prec
                   
         null // int? Scale
         ,
         typeof(StocLoc)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <StocLoc>.GetProperty(x => x.Nopopallab),
         "NOPOPALLAB", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  5, // int? prec
                           0  // int? Scale
         ,
         typeof(StocLoc)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <StocLoc>.GetProperty(x => x.Nowopallab),
         "NOWOPALLAB", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  5, // int? prec
                           0  // int? Scale
         ,
         typeof(StocLoc)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <StocLoc>.GetProperty(x => x.Onepalperlotinlotpoent),
         "ONEPALPERLOTINLOTPOENT", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  1, // int? prec
                           0  // int? Scale
         ,
         typeof(StocLoc)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <StocLoc>.GetProperty(x => x.Onepoperdeldet),
         "ONEPOPERDELDET", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  1, // int? prec
                           0  // int? Scale
         ,
         typeof(StocLoc)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <StocLoc>.GetProperty(x => x.Palcust),
         "PALCUST", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  1, // int? prec
                           0  // int? Scale
         ,
         typeof(StocLoc)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <StocLoc>.GetProperty(x => x.Palletondel),
         "PALLETONDEL", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  1, // int? prec
                           0  // int? Scale
         ,
         typeof(StocLoc)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <StocLoc>.GetProperty(x => x.Palletonpick),
         "PALLETONPICK", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  1, // int? prec
                           0  // int? Scale
         ,
         typeof(StocLoc)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <StocLoc>.GetProperty(x => x.Palwiz),
         "PALWIZ", // columnName
         false,                    //isKey
         false, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  1, // int? prec
                           0  // int? Scale
         ,
         typeof(StocLoc)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <StocLoc>.GetProperty(x => x.Picklistrpt),
         "PICKLISTRPT", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         8,       // int size   
                  null, // int? prec
                   
         null // int? Scale
         ,
         typeof(StocLoc)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <StocLoc>.GetProperty(x => x.Pickprinter),
         "PICKPRINTER", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         6,       // int size   
                  null, // int? prec
                   
         null // int? Scale
         ,
         typeof(StocLoc)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <StocLoc>.GetProperty(x => x.Pp2ndclassoutarea),
         "PP2NDCLASSOUTAREA", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  10, // int? prec
                           0  // int? Scale
         ,
         typeof(StocLoc)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <StocLoc>.GetProperty(x => x.Pp2ndclassoutloc),
         "PP2NDCLASSOUTLOC", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  5, // int? prec
                           0  // int? Scale
         ,
         typeof(StocLoc)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <StocLoc>.GetProperty(x => x.Ppfirstclassoutloc),
         "PPFIRSTCLASSOUTLOC", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  5, // int? prec
                           0  // int? Scale
         ,
         typeof(StocLoc)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <StocLoc>.GetProperty(x => x.Prdelnote),
         "PRDELNOTE", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         1,       // int size   
                  null, // int? prec
                   
         null // int? Scale
         ,
         typeof(StocLoc)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <StocLoc>.GetProperty(x => x.Prpicklst),
         "PRPICKLST", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         1,       // int size   
                  null, // int? prec
                   
         null // int? Scale
         ,
         typeof(StocLoc)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <StocLoc>.GetProperty(x => x.Restrictpalstostocloc),
         "RESTRICTPALSTOSTOCLOC", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  1, // int? prec
                           0  // int? Scale
         ,
         typeof(StocLoc)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <StocLoc>.GetProperty(x => x.Stclocdesc),
         "STCLOCDESC", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         20,       // int size   
                  null, // int? prec
                   
         null // int? Scale
         ,
         typeof(StocLoc)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <StocLoc>.GetProperty(x => x.Stclocfifo),
         "STCLOCFIFO", // columnName
         false,                    //isKey
         false, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  1, // int? prec
                           0  // int? Scale
         ,
         typeof(StocLoc)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <StocLoc>.GetProperty(x => x.Stoclocananumber),
         "STOCLOCANANUMBER", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         13,       // int size   
                  null, // int? prec
                   
         null // int? Scale
         ,
         typeof(StocLoc)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <StocLoc>.GetProperty(x => x.Suppressoverallocmsg),
         "SUPPRESSOVERALLOCMSG", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  1, // int? prec
                           0  // int? Scale
         ,
         typeof(StocLoc)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <StocLoc>.GetProperty(x => x.Transhipbayrecno),
         "TRANSHIPBAYRECNO", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  10, // int? prec
                           0  // int? Scale
         ,
         typeof(StocLoc)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <StocLoc>.GetProperty(x => x.TshipSplitatnew),
         "TSHIP_SPLITATNEW", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  1, // int? prec
                           0  // int? Scale
         ,
         typeof(StocLoc)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <StocLoc>.GetProperty(x => x.Usealternateproddescs),
         "USEALTERNATEPRODDESCS", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  1, // int? prec
                           0  // int? Scale
         ,
         typeof(StocLoc)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <StocLoc>.GetProperty(x => x.Weighallkgpicks),
         "WEIGHALLKGPICKS", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  1, // int? prec
                           0  // int? Scale
         ,
         typeof(StocLoc)
         ));
         return result; 
       }

#endregion     
        private int _fStcrecno;
        public int Stcrecno
        {
            get { return _fStcrecno; }
            set
            {
                var oldKey = Key;
                if (_fStcrecno != value)
                {
                    Modify();
                    _fStcrecno = value;
                    KeyChanged(oldKey);
                }
            }
        }

        private string _fAliasfrom;
        public string Aliasfrom
        {
            get { return _fAliasfrom; }
            set
            {
                if (_fAliasfrom != value)
                {
                    Modify();
                    _fAliasfrom = value;
                }
            }
        }

        private string _fAliasto;
        public string Aliasto
        {
            get { return _fAliasto; }
            set
            {
                if (_fAliasto != value)
                {
                    Modify();
                    _fAliasto = value;
                }
            }
        }

        private short? _fAllocareaexpected;
        public short? Allocareaexpected
        {
            get { return _fAllocareaexpected; }
            set
            {
                if (_fAllocareaexpected != value)
                {
                    Modify();
                    _fAllocareaexpected = value;
                }
            }
        }

        private short? _fAlloclitidtrnshipno;
        public short? Alloclitidtrnshipno
        {
            get { return _fAlloclitidtrnshipno; }
            set
            {
                if (_fAlloclitidtrnshipno != value)
                {
                    Modify();
                    _fAlloclitidtrnshipno = value;
                }
            }
        }

        private short? _fAllowautorcvinpoentry;
        /// <summary>
        /// Will allow the site to recieve automatically in Purchase Order Entry
        /// </summary>
        public short? Allowautorcvinpoentry
        {
            get { return _fAllowautorcvinpoentry; }
            set
            {
                if (_fAllowautorcvinpoentry != value)
                {
                    Modify();
                    _fAllowautorcvinpoentry = value;
                }
            }
        }

        private short? _fAllowfifointshiprcv;
        public short? Allowfifointshiprcv
        {
            get { return _fAllowfifointshiprcv; }
            set
            {
                if (_fAllowfifointshiprcv != value)
                {
                    Modify();
                    _fAllowfifointshiprcv = value;
                }
            }
        }

        private short? _fAutoallocpick;
        public short? Autoallocpick
        {
            get { return _fAutoallocpick; }
            set
            {
                if (_fAutoallocpick != value)
                {
                    Modify();
                    _fAutoallocpick = value;
                }
            }
        }

        private short? _fAutodespatchinordprgdet;
        /// <summary>
        /// Will allow sales to automatically be status DPT in ORDENTFORPRGDET
        /// </summary>
        public short? Autodespatchinordprgdet
        {
            get { return _fAutodespatchinordprgdet; }
            set
            {
                if (_fAutodespatchinordprgdet != value)
                {
                    Modify();
                    _fAutodespatchinordprgdet = value;
                }
            }
        }

        private short? _fAutofifoalloconAnc;
        /// <summary>
        /// Ancillaries will be auto-allocated to Stock
        /// </summary>
        public short? AutofifoalloconAnc
        {
            get { return _fAutofifoalloconAnc; }
            set
            {
                if (_fAutofifoalloconAnc != value)
                {
                    Modify();
                    _fAutofifoalloconAnc = value;
                }
            }
        }

        private short? _fAutoonerouteperdlv;
        public short? Autoonerouteperdlv
        {
            get { return _fAutoonerouteperdlv; }
            set
            {
                if (_fAutoonerouteperdlv != value)
                {
                    Modify();
                    _fAutoonerouteperdlv = value;
                }
            }
        }

        private short _fAutopackmeth;
        public short Autopackmeth
        {
            get { return _fAutopackmeth; }
            set
            {
                if (_fAutopackmeth != value)
                {
                    Modify();
                    _fAutopackmeth = value;
                }
            }
        }

        private short? _fAutorcvfifopals;
        public short? Autorcvfifopals
        {
            get { return _fAutorcvfifopals; }
            set
            {
                if (_fAutorcvfifopals != value)
                {
                    Modify();
                    _fAutorcvfifopals = value;
                }
            }
        }

        private short? _fAutorcvonepoperday;
        public short? Autorcvonepoperday
        {
            get { return _fAutorcvonepoperday; }
            set
            {
                if (_fAutorcvonepoperday != value)
                {
                    Modify();
                    _fAutorcvonepoperday = value;
                }
            }
        }

        private short? _fAutorcvtrans;
        public short? Autorcvtrans
        {
            get { return _fAutorcvtrans; }
            set
            {
                if (_fAutorcvtrans != value)
                {
                    Modify();
                    _fAutorcvtrans = value;
                }
            }
        }

        private short? _fCanrepack;
        public short? Canrepack
        {
            get { return _fCanrepack; }
            set
            {
                if (_fCanrepack != value)
                {
                    Modify();
                    _fCanrepack = value;
                }
            }
        }

        private string _fCapecode;
        public string Capecode
        {
            get { return _fCapecode; }
            set
            {
                if (_fCapecode != value)
                {
                    Modify();
                    _fCapecode = value;
                }
            }
        }

        private short _fCapespan;
        public short Capespan
        {
            get { return _fCapespan; }
            set
            {
                if (_fCapespan != value)
                {
                    Modify();
                    _fCapespan = value;
                }
            }
        }

        private string _fChepcode;
        public string Chepcode
        {
            get { return _fChepcode; }
            set
            {
                if (_fChepcode != value)
                {
                    Modify();
                    _fChepcode = value;
                }
            }
        }

        private short? _fCommunicate;
        public short? Communicate
        {
            get { return _fCommunicate; }
            set
            {
                if (_fCommunicate != value)
                {
                    Modify();
                    _fCommunicate = value;
                }
            }
        }

        private short? _fConfirmtranshipments;
        public short? Confirmtranshipments
        {
            get { return _fConfirmtranshipments; }
            set
            {
                if (_fConfirmtranshipments != value)
                {
                    Modify();
                    _fConfirmtranshipments = value;
                }
            }
        }

        private short? _fConfsaleout;
        public short? Confsaleout
        {
            get { return _fConfsaleout; }
            set
            {
                if (_fConfsaleout != value)
                {
                    Modify();
                    _fConfsaleout = value;
                }
            }
        }

        private short? _fConsolidatepick;
        public short? Consolidatepick
        {
            get { return _fConsolidatepick; }
            set
            {
                if (_fConsolidatepick != value)
                {
                    Modify();
                    _fConsolidatepick = value;
                }
            }
        }

        private int? _fDefloadbayrecno;
        public int? Defloadbayrecno
        {
            get { return _fDefloadbayrecno; }
            set
            {
                if (_fDefloadbayrecno != value)
                {
                    Modify();
                    _fDefloadbayrecno = value;
                }
            }
        }

        private int? _fDefprepackareain;
        public int? Defprepackareain
        {
            get { return _fDefprepackareain; }
            set
            {
                if (_fDefprepackareain != value)
                {
                    Modify();
                    _fDefprepackareain = value;
                }
            }
        }

        private int? _fDefprepackareaout;
        public int? Defprepackareaout
        {
            get { return _fDefprepackareaout; }
            set
            {
                if (_fDefprepackareaout != value)
                {
                    Modify();
                    _fDefprepackareaout = value;
                }
            }
        }

        private int? _fDefsmnno;
        public int? Defsmnno
        {
            get { return _fDefsmnno; }
            set
            {
                if (_fDefsmnno != value)
                {
                    Modify();
                    _fDefsmnno = value;
                }
            }
        }

        private int? _fDeftranbayrecno;
        public int? Deftranbayrecno
        {
            get { return _fDeftranbayrecno; }
            set
            {
                if (_fDeftranbayrecno != value)
                {
                    Modify();
                    _fDeftranbayrecno = value;
                }
            }
        }

        private string _fDelnoterpt;
        public string Delnoterpt
        {
            get { return _fDelnoterpt; }
            set
            {
                if (_fDelnoterpt != value)
                {
                    Modify();
                    _fDelnoterpt = value;
                }
            }
        }

        private string _fDelprinter;
        public string Delprinter
        {
            get { return _fDelprinter; }
            set
            {
                if (_fDelprinter != value)
                {
                    Modify();
                    _fDelprinter = value;
                }
            }
        }

        private short? _fDiscardallocmsgondlvprt;
        public short? Discardallocmsgondlvprt
        {
            get { return _fDiscardallocmsgondlvprt; }
            set
            {
                if (_fDiscardallocmsgondlvprt != value)
                {
                    Modify();
                    _fDiscardallocmsgondlvprt = value;
                }
            }
        }

        private short? _fDlvnoteshowsancilandpallet;
        public short? Dlvnoteshowsancilandpallet
        {
            get { return _fDlvnoteshowsancilandpallet; }
            set
            {
                if (_fDlvnoteshowsancilandpallet != value)
                {
                    Modify();
                    _fDlvnoteshowsancilandpallet = value;
                }
            }
        }

        private short? _fEntaveqcwgt4tship;
        public short? Entaveqcwgt4tship
        {
            get { return _fEntaveqcwgt4tship; }
            set
            {
                if (_fEntaveqcwgt4tship != value)
                {
                    Modify();
                    _fEntaveqcwgt4tship = value;
                }
            }
        }

        private int? _fFifoDespOpt;
        /// <summary>
        /// DELLIST FIFO ORDER - LINKED TO LOOKUPS
        /// </summary>
        public int? FifoDespOpt
        {
            get { return _fFifoDespOpt; }
            set
            {
                if (_fFifoDespOpt != value)
                {
                    Modify();
                    _fFifoDespOpt = value;
                }
            }
        }

        private short? _fFifoDespOrder;
        /// <summary>
        /// ORDER FOR FIFO_DESP_OPT - 1 = ASCENDING 2 = DESCENDING
        /// </summary>
        public short? FifoDespOrder
        {
            get { return _fFifoDespOrder; }
            set
            {
                if (_fFifoDespOrder != value)
                {
                    Modify();
                    _fFifoDespOrder = value;
                }
            }
        }

        private int? _fHomesaloffno;
        public int? Homesaloffno
        {
            get { return _fHomesaloffno; }
            set
            {
                if (_fHomesaloffno != value)
                {
                    Modify();
                    _fHomesaloffno = value;
                }
            }
        }

        private int? _fHomestcloc;
        public int? Homestcloc
        {
            get { return _fHomestcloc; }
            set
            {
                if (_fHomestcloc != value)
                {
                    Modify();
                    _fHomestcloc = value;
                }
            }
        }

        private string _fIfcocode;
        public string Ifcocode
        {
            get { return _fIfcocode; }
            set
            {
                if (_fIfcocode != value)
                {
                    Modify();
                    _fIfcocode = value;
                }
            }
        }

        private int? _fIncountry;
        public int? Incountry
        {
            get { return _fIncountry; }
            set
            {
                if (_fIncountry != value)
                {
                    Modify();
                    _fIncountry = value;
                }
            }
        }

        private int? _fIntransitbayrecno;
        public int? Intransitbayrecno
        {
            get { return _fIntransitbayrecno; }
            set
            {
                if (_fIntransitbayrecno != value)
                {
                    Modify();
                    _fIntransitbayrecno = value;
                }
            }
        }

        private short? _fIscommssite;
        public short? Iscommssite
        {
            get { return _fIscommssite; }
            set
            {
                if (_fIscommssite != value)
                {
                    Modify();
                    _fIscommssite = value;
                }
            }
        }

        private int? _fIsdirstcloc;
        public int? Isdirstcloc
        {
            get { return _fIsdirstcloc; }
            set
            {
                if (_fIsdirstcloc != value)
                {
                    Modify();
                    _fIsdirstcloc = value;
                }
            }
        }

        private short? _fIsgrowerdirect;
        public short? Isgrowerdirect
        {
            get { return _fIsgrowerdirect; }
            set
            {
                if (_fIsgrowerdirect != value)
                {
                    Modify();
                    _fIsgrowerdirect = value;
                }
            }
        }

        private short? _fIsnonpallet;
        public short? Isnonpallet
        {
            get { return _fIsnonpallet; }
            set
            {
                if (_fIsnonpallet != value)
                {
                    Modify();
                    _fIsnonpallet = value;
                }
            }
        }

        private short? _fIstradesaleslocation;
        public short? Istradesaleslocation
        {
            get { return _fIstradesaleslocation; }
            set
            {
                if (_fIstradesaleslocation != value)
                {
                    Modify();
                    _fIstradesaleslocation = value;
                }
            }
        }

        private short? _fLissplitpick;
        public short? Lissplitpick
        {
            get { return _fLissplitpick; }
            set
            {
                if (_fLissplitpick != value)
                {
                    Modify();
                    _fLissplitpick = value;
                }
            }
        }

        private string _fLocarea;
        public string Locarea
        {
            get { return _fLocarea; }
            set
            {
                if (_fLocarea != value)
                {
                    Modify();
                    _fLocarea = value;
                }
            }
        }

        private int? _fLstdaldelrecno;
        public int? Lstdaldelrecno
        {
            get { return _fLstdaldelrecno; }
            set
            {
                if (_fLstdaldelrecno != value)
                {
                    Modify();
                    _fLstdaldelrecno = value;
                }
            }
        }

        private int? _fLstpalaudrecno;
        public int? Lstpalaudrecno
        {
            get { return _fLstpalaudrecno; }
            set
            {
                if (_fLstpalaudrecno != value)
                {
                    Modify();
                    _fLstpalaudrecno = value;
                }
            }
        }

        private int _fMaxsmvtime;
        public int Maxsmvtime
        {
            get { return _fMaxsmvtime; }
            set
            {
                if (_fMaxsmvtime != value)
                {
                    Modify();
                    _fMaxsmvtime = value;
                }
            }
        }

        private string _fModemno;
        public string Modemno
        {
            get { return _fModemno; }
            set
            {
                if (_fModemno != value)
                {
                    Modify();
                    _fModemno = value;
                }
            }
        }

        private int? _fNopopallab;
        /// <summary>
        /// Number of PO Labels to print
        /// </summary>
        public int? Nopopallab
        {
            get { return _fNopopallab; }
            set
            {
                if (_fNopopallab != value)
                {
                    Modify();
                    _fNopopallab = value;
                }
            }
        }

        private int? _fNowopallab;
        /// <summary>
        /// Number of WO Labels to print
        /// </summary>
        public int? Nowopallab
        {
            get { return _fNowopallab; }
            set
            {
                if (_fNowopallab != value)
                {
                    Modify();
                    _fNowopallab = value;
                }
            }
        }

        private short? _fOnepalperlotinlotpoent;
        public short? Onepalperlotinlotpoent
        {
            get { return _fOnepalperlotinlotpoent; }
            set
            {
                if (_fOnepalperlotinlotpoent != value)
                {
                    Modify();
                    _fOnepalperlotinlotpoent = value;
                }
            }
        }

        private short? _fOnepoperdeldet;
        public short? Onepoperdeldet
        {
            get { return _fOnepoperdeldet; }
            set
            {
                if (_fOnepoperdeldet != value)
                {
                    Modify();
                    _fOnepoperdeldet = value;
                }
            }
        }

        private short? _fPalcust;
        public short? Palcust
        {
            get { return _fPalcust; }
            set
            {
                if (_fPalcust != value)
                {
                    Modify();
                    _fPalcust = value;
                }
            }
        }

        private short? _fPalletondel;
        public short? Palletondel
        {
            get { return _fPalletondel; }
            set
            {
                if (_fPalletondel != value)
                {
                    Modify();
                    _fPalletondel = value;
                }
            }
        }

        private short? _fPalletonpick;
        public short? Palletonpick
        {
            get { return _fPalletonpick; }
            set
            {
                if (_fPalletonpick != value)
                {
                    Modify();
                    _fPalletonpick = value;
                }
            }
        }

        private short _fPalwiz;
        public short Palwiz
        {
            get { return _fPalwiz; }
            set
            {
                if (_fPalwiz != value)
                {
                    Modify();
                    _fPalwiz = value;
                }
            }
        }

        private string _fPicklistrpt;
        public string Picklistrpt
        {
            get { return _fPicklistrpt; }
            set
            {
                if (_fPicklistrpt != value)
                {
                    Modify();
                    _fPicklistrpt = value;
                }
            }
        }

        private string _fPickprinter;
        public string Pickprinter
        {
            get { return _fPickprinter; }
            set
            {
                if (_fPickprinter != value)
                {
                    Modify();
                    _fPickprinter = value;
                }
            }
        }

        private int? _fPp2ndclassoutarea;
        public int? Pp2ndclassoutarea
        {
            get { return _fPp2ndclassoutarea; }
            set
            {
                if (_fPp2ndclassoutarea != value)
                {
                    Modify();
                    _fPp2ndclassoutarea = value;
                }
            }
        }

        private int? _fPp2ndclassoutloc;
        public int? Pp2ndclassoutloc
        {
            get { return _fPp2ndclassoutloc; }
            set
            {
                if (_fPp2ndclassoutloc != value)
                {
                    Modify();
                    _fPp2ndclassoutloc = value;
                }
            }
        }

        private int? _fPpfirstclassoutloc;
        public int? Ppfirstclassoutloc
        {
            get { return _fPpfirstclassoutloc; }
            set
            {
                if (_fPpfirstclassoutloc != value)
                {
                    Modify();
                    _fPpfirstclassoutloc = value;
                }
            }
        }

        private string _fPrdelnote;
        public string Prdelnote
        {
            get { return _fPrdelnote; }
            set
            {
                if (_fPrdelnote != value)
                {
                    Modify();
                    _fPrdelnote = value;
                }
            }
        }

        private string _fPrpicklst;
        public string Prpicklst
        {
            get { return _fPrpicklst; }
            set
            {
                if (_fPrpicklst != value)
                {
                    Modify();
                    _fPrpicklst = value;
                }
            }
        }

        private short? _fRestrictpalstostocloc;
        public short? Restrictpalstostocloc
        {
            get { return _fRestrictpalstostocloc; }
            set
            {
                if (_fRestrictpalstostocloc != value)
                {
                    Modify();
                    _fRestrictpalstostocloc = value;
                }
            }
        }

        private string _fStclocdesc;
        public string Stclocdesc
        {
            get { return _fStclocdesc; }
            set
            {
                if (_fStclocdesc != value)
                {
                    Modify();
                    _fStclocdesc = value;
                }
            }
        }

        private short _fStclocfifo;
        public short Stclocfifo
        {
            get { return _fStclocfifo; }
            set
            {
                if (_fStclocfifo != value)
                {
                    Modify();
                    _fStclocfifo = value;
                }
            }
        }

        private string _fStoclocananumber;
        public string Stoclocananumber
        {
            get { return _fStoclocananumber; }
            set
            {
                if (_fStoclocananumber != value)
                {
                    Modify();
                    _fStoclocananumber = value;
                }
            }
        }

        private short? _fSuppressoverallocmsg;
        public short? Suppressoverallocmsg
        {
            get { return _fSuppressoverallocmsg; }
            set
            {
                if (_fSuppressoverallocmsg != value)
                {
                    Modify();
                    _fSuppressoverallocmsg = value;
                }
            }
        }

        private int? _fTranshipbayrecno;
        public int? Transhipbayrecno
        {
            get { return _fTranshipbayrecno; }
            set
            {
                if (_fTranshipbayrecno != value)
                {
                    Modify();
                    _fTranshipbayrecno = value;
                }
            }
        }

        private short? _fTshipSplitatnew;
        public short? TshipSplitatnew
        {
            get { return _fTshipSplitatnew; }
            set
            {
                if (_fTshipSplitatnew != value)
                {
                    Modify();
                    _fTshipSplitatnew = value;
                }
            }
        }

        private short? _fUsealternateproddescs;
        public short? Usealternateproddescs
        {
            get { return _fUsealternateproddescs; }
            set
            {
                if (_fUsealternateproddescs != value)
                {
                    Modify();
                    _fUsealternateproddescs = value;
                }
            }
        }

        private short? _fWeighallkgpicks;
        public short? Weighallkgpicks
        {
            get { return _fWeighallkgpicks; }
            set
            {
                if (_fWeighallkgpicks != value)
                {
                    Modify();
                    _fWeighallkgpicks = value;
                }
            }
        }

        public override int Key
        {
            get { return Stcrecno; }
            set { Stcrecno = value; }
        }

        public override string KeyAsString { get { return Key.ToString(CultureInfo.InvariantCulture); } }


        public override StocLoc Clone()
        {
            var obj = new StocLoc
                {
                    Stcrecno = Stcrecno,
                    Aliasfrom = Aliasfrom,
                    Aliasto = Aliasto,
                    Allocareaexpected = Allocareaexpected,
                    Alloclitidtrnshipno = Alloclitidtrnshipno,
                    Allowautorcvinpoentry = Allowautorcvinpoentry,
                    Allowfifointshiprcv = Allowfifointshiprcv,
                    Autoallocpick = Autoallocpick,
                    Autodespatchinordprgdet = Autodespatchinordprgdet,
                    AutofifoalloconAnc = AutofifoalloconAnc,
                    Autoonerouteperdlv = Autoonerouteperdlv,
                    Autopackmeth = Autopackmeth,
                    Autorcvfifopals = Autorcvfifopals,
                    Autorcvonepoperday = Autorcvonepoperday,
                    Autorcvtrans = Autorcvtrans,
                    Canrepack = Canrepack,
                    Capecode = Capecode,
                    Capespan = Capespan,
                    Chepcode = Chepcode,
                    Communicate = Communicate,
                    Confirmtranshipments = Confirmtranshipments,
                    Confsaleout = Confsaleout,
                    Consolidatepick = Consolidatepick,
                    Defloadbayrecno = Defloadbayrecno,
                    Defprepackareain = Defprepackareain,
                    Defprepackareaout = Defprepackareaout,
                    Defsmnno = Defsmnno,
                    Deftranbayrecno = Deftranbayrecno,
                    Delnoterpt = Delnoterpt,
                    Delprinter = Delprinter,
                    Discardallocmsgondlvprt = Discardallocmsgondlvprt,
                    Dlvnoteshowsancilandpallet = Dlvnoteshowsancilandpallet,
                    Entaveqcwgt4tship = Entaveqcwgt4tship,
                    FifoDespOpt = FifoDespOpt,
                    FifoDespOrder = FifoDespOrder,
                    Homesaloffno = Homesaloffno,
                    Homestcloc = Homestcloc,
                    Ifcocode = Ifcocode,
                    Incountry = Incountry,
                    Intransitbayrecno = Intransitbayrecno,
                    Iscommssite = Iscommssite,
                    Isdirstcloc = Isdirstcloc,
                    Isgrowerdirect = Isgrowerdirect,
                    Isnonpallet = Isnonpallet,
                    Istradesaleslocation = Istradesaleslocation,
                    Lissplitpick = Lissplitpick,
                    Locarea = Locarea,
                    Lstdaldelrecno = Lstdaldelrecno,
                    Lstpalaudrecno = Lstpalaudrecno,
                    Maxsmvtime = Maxsmvtime,
                    Modemno = Modemno,
                    Nopopallab = Nopopallab,
                    Nowopallab = Nowopallab,
                    Onepalperlotinlotpoent = Onepalperlotinlotpoent,
                    Onepoperdeldet = Onepoperdeldet,
                    Palcust = Palcust,
                    Palletondel = Palletondel,
                    Palletonpick = Palletonpick,
                    Palwiz = Palwiz,
                    Picklistrpt = Picklistrpt,
                    Pickprinter = Pickprinter,
                    Pp2ndclassoutarea = Pp2ndclassoutarea,
                    Pp2ndclassoutloc = Pp2ndclassoutloc,
                    Ppfirstclassoutloc = Ppfirstclassoutloc,
                    Prdelnote = Prdelnote,
                    Prpicklst = Prpicklst,
                    Restrictpalstostocloc = Restrictpalstostocloc,
                    Stclocdesc = Stclocdesc,
                    Stclocfifo = Stclocfifo,
                    Stoclocananumber = Stoclocananumber,
                    Suppressoverallocmsg = Suppressoverallocmsg,
                    Transhipbayrecno = Transhipbayrecno,
                    TshipSplitatnew = TshipSplitatnew,
                    Usealternateproddescs = Usealternateproddescs,
                    Weighallkgpicks = Weighallkgpicks,
                };

            return obj;
        }

        public static class FieldNames
        {
// ReSharper disable InconsistentNaming
            public const string  STCRECNO = "STCRECNO";
            public const string  ALIASFROM = "ALIASFROM";
            public const string  ALIASTO = "ALIASTO";
            public const string  ALLOCAREAEXPECTED = "ALLOCAREAEXPECTED";
            public const string  ALLOCLITIDTRNSHIPNO = "ALLOCLITIDTRNSHIPNO";
            public const string  ALLOWAUTORCVINPOENTRY = "ALLOWAUTORCVINPOENTRY";
            public const string  ALLOWFIFOINTSHIPRCV = "ALLOWFIFOINTSHIPRCV";
            public const string  AUTOALLOCPICK = "AUTOALLOCPICK";
            public const string  AUTODESPATCHINORDPRGDET = "AUTODESPATCHINORDPRGDET";
            public const string  AUTOFIFOALLOCON_ANC = "AUTOFIFOALLOCON_ANC";
            public const string  AUTOONEROUTEPERDLV = "AUTOONEROUTEPERDLV";
            public const string  AUTOPACKMETH = "AUTOPACKMETH";
            public const string  AUTORCVFIFOPALS = "AUTORCVFIFOPALS";
            public const string  AUTORCVONEPOPERDAY = "AUTORCVONEPOPERDAY";
            public const string  AUTORCVTRANS = "AUTORCVTRANS";
            public const string  CANREPACK = "CANREPACK";
            public const string  CAPECODE = "CAPECODE";
            public const string  CAPESPAN = "CAPESPAN";
            public const string  CHEPCODE = "CHEPCODE";
            public const string  COMMUNICATE = "COMMUNICATE";
            public const string  CONFIRMTRANSHIPMENTS = "CONFIRMTRANSHIPMENTS";
            public const string  CONFSALEOUT = "CONFSALEOUT";
            public const string  CONSOLIDATEPICK = "CONSOLIDATEPICK";
            public const string  DEFLOADBAYRECNO = "DEFLOADBAYRECNO";
            public const string  DEFPREPACKAREAIN = "DEFPREPACKAREAIN";
            public const string  DEFPREPACKAREAOUT = "DEFPREPACKAREAOUT";
            public const string  DEFSMNNO = "DEFSMNNO";
            public const string  DEFTRANBAYRECNO = "DEFTRANBAYRECNO";
            public const string  DELNOTERPT = "DELNOTERPT";
            public const string  DELPRINTER = "DELPRINTER";
            public const string  DISCARDALLOCMSGONDLVPRT = "DISCARDALLOCMSGONDLVPRT";
            public const string  DLVNOTESHOWSANCILANDPALLET = "DLVNOTESHOWSANCILANDPALLET";
            public const string  ENTAVEQCWGT4TSHIP = "ENTAVEQCWGT4TSHIP";
            public const string  FIFO_DESP_OPT = "FIFO_DESP_OPT";
            public const string  FIFO_DESP_ORDER = "FIFO_DESP_ORDER";
            public const string  HOMESALOFFNO = "HOMESALOFFNO";
            public const string  HOMESTCLOC = "HOMESTCLOC";
            public const string  IFCOCODE = "IFCOCODE";
            public const string  INCOUNTRY = "INCOUNTRY";
            public const string  INTRANSITBAYRECNO = "INTRANSITBAYRECNO";
            public const string  ISCOMMSSITE = "ISCOMMSSITE";
            public const string  ISDIRSTCLOC = "ISDIRSTCLOC";
            public const string  ISGROWERDIRECT = "ISGROWERDIRECT";
            public const string  ISNONPALLET = "ISNONPALLET";
            public const string  ISTRADESALESLOCATION = "ISTRADESALESLOCATION";
            public const string  LISSPLITPICK = "LISSPLITPICK";
            public const string  LOCAREA = "LOCAREA";
            public const string  LSTDALDELRECNO = "LSTDALDELRECNO";
            public const string  LSTPALAUDRECNO = "LSTPALAUDRECNO";
            public const string  MAXSMVTIME = "MAXSMVTIME";
            public const string  MODEMNO = "MODEMNO";
            public const string  NOPOPALLAB = "NOPOPALLAB";
            public const string  NOWOPALLAB = "NOWOPALLAB";
            public const string  ONEPALPERLOTINLOTPOENT = "ONEPALPERLOTINLOTPOENT";
            public const string  ONEPOPERDELDET = "ONEPOPERDELDET";
            public const string  PALCUST = "PALCUST";
            public const string  PALLETONDEL = "PALLETONDEL";
            public const string  PALLETONPICK = "PALLETONPICK";
            public const string  PALWIZ = "PALWIZ";
            public const string  PICKLISTRPT = "PICKLISTRPT";
            public const string  PICKPRINTER = "PICKPRINTER";
            public const string  PP2NDCLASSOUTAREA = "PP2NDCLASSOUTAREA";
            public const string  PP2NDCLASSOUTLOC = "PP2NDCLASSOUTLOC";
            public const string  PPFIRSTCLASSOUTLOC = "PPFIRSTCLASSOUTLOC";
            public const string  PRDELNOTE = "PRDELNOTE";
            public const string  PRPICKLST = "PRPICKLST";
            public const string  RESTRICTPALSTOSTOCLOC = "RESTRICTPALSTOSTOCLOC";
            public const string  STCLOCDESC = "STCLOCDESC";
            public const string  STCLOCFIFO = "STCLOCFIFO";
            public const string  STOCLOCANANUMBER = "STOCLOCANANUMBER";
            public const string  SUPPRESSOVERALLOCMSG = "SUPPRESSOVERALLOCMSG";
            public const string  TRANSHIPBAYRECNO = "TRANSHIPBAYRECNO";
            public const string  TSHIP_SPLITATNEW = "TSHIP_SPLITATNEW";
            public const string  USEALTERNATEPRODDESCS = "USEALTERNATEPRODDESCS";
            public const string  WEIGHALLKGPICKS = "WEIGHALLKGPICKS";
 // ReSharper restore InconsistentNaming
        }


    }

}
