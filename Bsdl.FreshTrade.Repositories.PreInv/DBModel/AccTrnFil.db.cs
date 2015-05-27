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
    /// Entity for the ACCTRNFIL table
    /// </summary>
    public partial class AccTrnFil : BaseDbModel<AccTrnFil, int>
    {
#region tableDefs

       public static List<EntityPropDef> GetPropDefs() {
         var result = new List<EntityPropDef>();

//EntityPropDef(string propName, string columnName, bool isKey, bool isNullable, string refEntityName, PropertyInfo keyPropInfo,
//            int size, int? prec, int? scale)



         result.Add(new EntityPropDef(
         PropertyHelper <AccTrnFil>.GetProperty(x => x.Atrrecno),
         "ATRRECNO", // columnName
         true,                    //isKey
         false, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  10, // int? prec
                           0  // int? Scale
         ,
         typeof(AccTrnFil)
       ));


         result.Add(new EntityPropDef(
         PropertyHelper <AccTrnFil>.GetProperty(x => x.Atr1099type),
         "ATR1099TYPE", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  5, // int? prec
                           0  // int? Scale
         ,
         typeof(AccTrnFil)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <AccTrnFil>.GetProperty(x => x.Atractpstdate),
         "ATRACTPSTDATE", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  null, // int? prec
                   
         null // int? Scale
         ,
         typeof(AccTrnFil)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <AccTrnFil>.GetProperty(x => x.Atractpstlogon),
         "ATRACTPSTLOGON", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  5, // int? prec
                           0  // int? Scale
         ,
         typeof(AccTrnFil)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <AccTrnFil>.GetProperty(x => x.Atramount),
         "ATRAMOUNT", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  126, // int? prec
                   
         null // int? Scale
         ,
         typeof(AccTrnFil)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <AccTrnFil>.GetProperty(x => x.Atramountwhval),
         "ATRAMOUNTWHVAL", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  126, // int? prec
                   
         null // int? Scale
         ,
         typeof(AccTrnFil)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <AccTrnFil>.GetProperty(x => x.Atrauthbyno),
         "ATRAUTHBYNO", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  5, // int? prec
                           0  // int? Scale
         ,
         typeof(AccTrnFil)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <AccTrnFil>.GetProperty(x => x.Atrbalance),
         "ATRBALANCE", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  126, // int? prec
                   
         null // int? Scale
         ,
         typeof(AccTrnFil)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <AccTrnFil>.GetProperty(x => x.Atrbalatlststmt),
         "ATRBALATLSTSTMT", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  126, // int? prec
                   
         null // int? Scale
         ,
         typeof(AccTrnFil)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <AccTrnFil>.GetProperty(x => x.Atrbaseamount),
         "ATRBASEAMOUNT", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  126, // int? prec
                   
         null // int? Scale
         ,
         typeof(AccTrnFil)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <AccTrnFil>.GetProperty(x => x.Atrbaserate),
         "ATRBASERATE", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  126, // int? prec
                   
         null // int? Scale
         ,
         typeof(AccTrnFil)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <AccTrnFil>.GetProperty(x => x.Atrclarecno),
         "ATRCLARECNO", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  10, // int? prec
                           0  // int? Scale
         ,
         typeof(AccTrnFil)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <AccTrnFil>.GetProperty(x => x.Atrclass),
         "ATRCLASS", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  5, // int? prec
                           0  // int? Scale
         ,
         typeof(AccTrnFil)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <AccTrnFil>.GetProperty(x => x.Atrcoglbrecno),
         "ATRCOGLBRECNO", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  5, // int? prec
                           0  // int? Scale
         ,
         typeof(AccTrnFil)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <AccTrnFil>.GetProperty(x => x.Atrcurrecno),
         "ATRCURRECNO", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  5, // int? prec
                           0  // int? Scale
         ,
         typeof(AccTrnFil)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <AccTrnFil>.GetProperty(x => x.Atrdbno),
         "ATRDBNO", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  10, // int? prec
                           0  // int? Scale
         ,
         typeof(AccTrnFil)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <AccTrnFil>.GetProperty(x => x.Atrdbtype),
         "ATRDBTYPE", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  5, // int? prec
                           0  // int? Scale
         ,
         typeof(AccTrnFil)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <AccTrnFil>.GetProperty(x => x.Atrdelclarecno),
         "ATRDELCLARECNO", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  10, // int? prec
                           0  // int? Scale
         ,
         typeof(AccTrnFil)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <AccTrnFil>.GetProperty(x => x.Atrdispute),
         "ATRDISPUTE", // columnName
         false,                    //isKey
         false, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  5, // int? prec
                           0  // int? Scale
         ,
         typeof(AccTrnFil)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <AccTrnFil>.GetProperty(x => x.Atreuroamount),
         "ATREUROAMOUNT", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  126, // int? prec
                   
         null // int? Scale
         ,
         typeof(AccTrnFil)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <AccTrnFil>.GetProperty(x => x.Atreurorate),
         "ATREURORATE", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  126, // int? prec
                   
         null // int? Scale
         ,
         typeof(AccTrnFil)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <AccTrnFil>.GetProperty(x => x.Atrexclfromexport),
         "ATREXCLFROMEXPORT", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  5, // int? prec
                           0  // int? Scale
         ,
         typeof(AccTrnFil)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <AccTrnFil>.GetProperty(x => x.Atrfactorclarec),
         "ATRFACTORCLAREC", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  10, // int? prec
                           0  // int? Scale
         ,
         typeof(AccTrnFil)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <AccTrnFil>.GetProperty(x => x.Atronpayplan),
         "ATRONPAYPLAN", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  1, // int? prec
                           0  // int? Scale
         ,
         typeof(AccTrnFil)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <AccTrnFil>.GetProperty(x => x.Atrourrefno),
         "ATROURREFNO", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  10, // int? prec
                           0  // int? Scale
         ,
         typeof(AccTrnFil)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <AccTrnFil>.GetProperty(x => x.Atrperiodno),
         "ATRPERIODNO", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  5, // int? prec
                           0  // int? Scale
         ,
         typeof(AccTrnFil)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <AccTrnFil>.GetProperty(x => x.Atrprdorpan),
         "ATRPRDORPAN", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  5, // int? prec
                           0  // int? Scale
         ,
         typeof(AccTrnFil)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <AccTrnFil>.GetProperty(x => x.Atrpstdate),
         "ATRPSTDATE", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  null, // int? prec
                   
         null // int? Scale
         ,
         typeof(AccTrnFil)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <AccTrnFil>.GetProperty(x => x.Atrpstdatedchq),
         "ATRPSTDATEDCHQ", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  1, // int? prec
                           0  // int? Scale
         ,
         typeof(AccTrnFil)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <AccTrnFil>.GetProperty(x => x.Atrpstdchqentdate),
         "ATRPSTDCHQENTDATE", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  null, // int? prec
                   
         null // int? Scale
         ,
         typeof(AccTrnFil)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <AccTrnFil>.GetProperty(x => x.Atrpsttyp),
         "ATRPSTTYP", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  5, // int? prec
                           0  // int? Scale
         ,
         typeof(AccTrnFil)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <AccTrnFil>.GetProperty(x => x.Atrpurauthbatrec),
         "ATRPURAUTHBATREC", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  10, // int? prec
                           0  // int? Scale
         ,
         typeof(AccTrnFil)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <AccTrnFil>.GetProperty(x => x.Atrref),
         "ATRREF", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         20,       // int size   
                  null, // int? prec
                   
         null // int? Scale
         ,
         typeof(AccTrnFil)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <AccTrnFil>.GetProperty(x => x.Atrref2),
         "ATRREF2", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         20,       // int size   
                  null, // int? prec
                   
         null // int? Scale
         ,
         typeof(AccTrnFil)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <AccTrnFil>.GetProperty(x => x.Atrsaloffno),
         "ATRSALOFFNO", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  5, // int? prec
                           0  // int? Scale
         ,
         typeof(AccTrnFil)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <AccTrnFil>.GetProperty(x => x.Atrstatind),
         "ATRSTATIND", // columnName
         false,                    //isKey
         false, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  5, // int? prec
                           0  // int? Scale
         ,
         typeof(AccTrnFil)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <AccTrnFil>.GetProperty(x => x.Atrtoauthno),
         "ATRTOAUTHNO", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  5, // int? prec
                           0  // int? Scale
         ,
         typeof(AccTrnFil)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <AccTrnFil>.GetProperty(x => x.Atrtopayamt),
         "ATRTOPAYAMT", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  126, // int? prec
                   
         null // int? Scale
         ,
         typeof(AccTrnFil)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <AccTrnFil>.GetProperty(x => x.Atrtopaydate),
         "ATRTOPAYDATE", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  null, // int? prec
                   
         null // int? Scale
         ,
         typeof(AccTrnFil)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <AccTrnFil>.GetProperty(x => x.Atrtriangulate),
         "ATRTRIANGULATE", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  1, // int? prec
                           0  // int? Scale
         ,
         typeof(AccTrnFil)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <AccTrnFil>.GetProperty(x => x.Atrwhtaxamount),
         "ATRWHTAXAMOUNT", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  126, // int? prec
                   
         null // int? Scale
         ,
         typeof(AccTrnFil)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <AccTrnFil>.GetProperty(x => x.Atrwithholdtax),
         "ATRWITHHOLDTAX", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  1, // int? prec
                           0  // int? Scale
         ,
         typeof(AccTrnFil)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <AccTrnFil>.GetProperty(x => x.Atrwithholdtaxrate),
         "ATRWITHHOLDTAXRATE", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  126, // int? prec
                   
         null // int? Scale
         ,
         typeof(AccTrnFil)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <AccTrnFil>.GetProperty(x => x.Atryearno),
         "ATRYEARNO", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  5, // int? prec
                           0  // int? Scale
         ,
         typeof(AccTrnFil)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <AccTrnFil>.GetProperty(x => x.Clrddate),
         "CLRDDATE", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         10,       // int size   
                  null, // int? prec
                   
         null // int? Scale
         ,
         typeof(AccTrnFil)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <AccTrnFil>.GetProperty(x => x.Intcomptrn),
         "INTCOMPTRN", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  5, // int? prec
                           0  // int? Scale
         ,
         typeof(AccTrnFil)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <AccTrnFil>.GetProperty(x => x.Invexchrate),
         "INVEXCHRATE", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  126, // int? prec
                   
         null // int? Scale
         ,
         typeof(AccTrnFil)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <AccTrnFil>.GetProperty(x => x.Onholdby),
         "ONHOLDBY", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  5, // int? prec
                           0  // int? Scale
         ,
         typeof(AccTrnFil)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <AccTrnFil>.GetProperty(x => x.Onholddate),
         "ONHOLDDATE", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  null, // int? prec
                   
         null // int? Scale
         ,
         typeof(AccTrnFil)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <AccTrnFil>.GetProperty(x => x.Paymentagentprinted),
         "PAYMENTAGENTPRINTED", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  1, // int? prec
                           0  // int? Scale
         ,
         typeof(AccTrnFil)
         ));
         return result; 
       }

#endregion     
        private int _fAtrrecno;
        public int Atrrecno
        {
            get { return _fAtrrecno; }
            set
            {
                var oldKey = Key;
                if (_fAtrrecno != value)
                {
                    Modify();
                    _fAtrrecno = value;
                    KeyChanged(oldKey);
                }
            }
        }

        private int? _fAtr1099type;
        public int? Atr1099type
        {
            get { return _fAtr1099type; }
            set
            {
                if (_fAtr1099type != value)
                {
                    Modify();
                    _fAtr1099type = value;
                }
            }
        }

        private DateTime? _fAtractpstdate;
        public DateTime? Atractpstdate
        {
            get { return _fAtractpstdate; }
            set
            {
                if (_fAtractpstdate != value)
                {
                    Modify();
                    _fAtractpstdate = value;
                }
            }
        }

        private int? _fAtractpstlogon;
        public int? Atractpstlogon
        {
            get { return _fAtractpstlogon; }
            set
            {
                if (_fAtractpstlogon != value)
                {
                    Modify();
                    _fAtractpstlogon = value;
                }
            }
        }

        private decimal? _fAtramount;
        public decimal? Atramount
        {
            get { return _fAtramount; }
            set
            {
                if (_fAtramount != value)
                {
                    Modify();
                    _fAtramount = value;
                }
            }
        }

        private decimal? _fAtramountwhval;
        public decimal? Atramountwhval
        {
            get { return _fAtramountwhval; }
            set
            {
                if (_fAtramountwhval != value)
                {
                    Modify();
                    _fAtramountwhval = value;
                }
            }
        }

        private int? _fAtrauthbyno;
        public int? Atrauthbyno
        {
            get { return _fAtrauthbyno; }
            set
            {
                if (_fAtrauthbyno != value)
                {
                    Modify();
                    _fAtrauthbyno = value;
                }
            }
        }

        private decimal? _fAtrbalance;
        public decimal? Atrbalance
        {
            get { return _fAtrbalance; }
            set
            {
                if (_fAtrbalance != value)
                {
                    Modify();
                    _fAtrbalance = value;
                }
            }
        }

        private decimal? _fAtrbalatlststmt;
        public decimal? Atrbalatlststmt
        {
            get { return _fAtrbalatlststmt; }
            set
            {
                if (_fAtrbalatlststmt != value)
                {
                    Modify();
                    _fAtrbalatlststmt = value;
                }
            }
        }

        private decimal? _fAtrbaseamount;
        public decimal? Atrbaseamount
        {
            get { return _fAtrbaseamount; }
            set
            {
                if (_fAtrbaseamount != value)
                {
                    Modify();
                    _fAtrbaseamount = value;
                }
            }
        }

        private decimal? _fAtrbaserate;
        public decimal? Atrbaserate
        {
            get { return _fAtrbaserate; }
            set
            {
                if (_fAtrbaserate != value)
                {
                    Modify();
                    _fAtrbaserate = value;
                }
            }
        }

        private int? _fAtrclarecno;
        public int? Atrclarecno
        {
            get { return _fAtrclarecno; }
            set
            {
                if (_fAtrclarecno != value)
                {
                    Modify();
                    _fAtrclarecno = value;
                }
            }
        }

        private int? _fAtrclass;
        public int? Atrclass
        {
            get { return _fAtrclass; }
            set
            {
                if (_fAtrclass != value)
                {
                    Modify();
                    _fAtrclass = value;
                }
            }
        }

        private int? _fAtrcoglbrecno;
        public int? Atrcoglbrecno
        {
            get { return _fAtrcoglbrecno; }
            set
            {
                if (_fAtrcoglbrecno != value)
                {
                    Modify();
                    _fAtrcoglbrecno = value;
                }
            }
        }

        private int? _fAtrcurrecno;
        public int? Atrcurrecno
        {
            get { return _fAtrcurrecno; }
            set
            {
                if (_fAtrcurrecno != value)
                {
                    Modify();
                    _fAtrcurrecno = value;
                }
            }
        }

        private int? _fAtrdbno;
        public int? Atrdbno
        {
            get { return _fAtrdbno; }
            set
            {
                if (_fAtrdbno != value)
                {
                    Modify();
                    _fAtrdbno = value;
                }
            }
        }

        private int? _fAtrdbtype;
        public int? Atrdbtype
        {
            get { return _fAtrdbtype; }
            set
            {
                if (_fAtrdbtype != value)
                {
                    Modify();
                    _fAtrdbtype = value;
                }
            }
        }

        private int? _fAtrdelclarecno;
        public int? Atrdelclarecno
        {
            get { return _fAtrdelclarecno; }
            set
            {
                if (_fAtrdelclarecno != value)
                {
                    Modify();
                    _fAtrdelclarecno = value;
                }
            }
        }

        private int _fAtrdispute;
        public int Atrdispute
        {
            get { return _fAtrdispute; }
            set
            {
                if (_fAtrdispute != value)
                {
                    Modify();
                    _fAtrdispute = value;
                }
            }
        }

        private decimal? _fAtreuroamount;
        public decimal? Atreuroamount
        {
            get { return _fAtreuroamount; }
            set
            {
                if (_fAtreuroamount != value)
                {
                    Modify();
                    _fAtreuroamount = value;
                }
            }
        }

        private decimal? _fAtreurorate;
        public decimal? Atreurorate
        {
            get { return _fAtreurorate; }
            set
            {
                if (_fAtreurorate != value)
                {
                    Modify();
                    _fAtreurorate = value;
                }
            }
        }

        private int? _fAtrexclfromexport;
        public int? Atrexclfromexport
        {
            get { return _fAtrexclfromexport; }
            set
            {
                if (_fAtrexclfromexport != value)
                {
                    Modify();
                    _fAtrexclfromexport = value;
                }
            }
        }

        private int? _fAtrfactorclarec;
        public int? Atrfactorclarec
        {
            get { return _fAtrfactorclarec; }
            set
            {
                if (_fAtrfactorclarec != value)
                {
                    Modify();
                    _fAtrfactorclarec = value;
                }
            }
        }

        private short? _fAtronpayplan;
        public short? Atronpayplan
        {
            get { return _fAtronpayplan; }
            set
            {
                if (_fAtronpayplan != value)
                {
                    Modify();
                    _fAtronpayplan = value;
                }
            }
        }

        private int? _fAtrourrefno;
        public int? Atrourrefno
        {
            get { return _fAtrourrefno; }
            set
            {
                if (_fAtrourrefno != value)
                {
                    Modify();
                    _fAtrourrefno = value;
                }
            }
        }

        private int? _fAtrperiodno;
        public int? Atrperiodno
        {
            get { return _fAtrperiodno; }
            set
            {
                if (_fAtrperiodno != value)
                {
                    Modify();
                    _fAtrperiodno = value;
                }
            }
        }

        private int? _fAtrprdorpan;
        public int? Atrprdorpan
        {
            get { return _fAtrprdorpan; }
            set
            {
                if (_fAtrprdorpan != value)
                {
                    Modify();
                    _fAtrprdorpan = value;
                }
            }
        }

        private DateTime? _fAtrpstdate;
        public DateTime? Atrpstdate
        {
            get { return _fAtrpstdate; }
            set
            {
                if (_fAtrpstdate != value)
                {
                    Modify();
                    _fAtrpstdate = value;
                }
            }
        }

        private short? _fAtrpstdatedchq;
        public short? Atrpstdatedchq
        {
            get { return _fAtrpstdatedchq; }
            set
            {
                if (_fAtrpstdatedchq != value)
                {
                    Modify();
                    _fAtrpstdatedchq = value;
                }
            }
        }

        private DateTime? _fAtrpstdchqentdate;
        public DateTime? Atrpstdchqentdate
        {
            get { return _fAtrpstdchqentdate; }
            set
            {
                if (_fAtrpstdchqentdate != value)
                {
                    Modify();
                    _fAtrpstdchqentdate = value;
                }
            }
        }

        private int? _fAtrpsttyp;
        public int? Atrpsttyp
        {
            get { return _fAtrpsttyp; }
            set
            {
                if (_fAtrpsttyp != value)
                {
                    Modify();
                    _fAtrpsttyp = value;
                }
            }
        }

        private int? _fAtrpurauthbatrec;
        public int? Atrpurauthbatrec
        {
            get { return _fAtrpurauthbatrec; }
            set
            {
                if (_fAtrpurauthbatrec != value)
                {
                    Modify();
                    _fAtrpurauthbatrec = value;
                }
            }
        }

        private string _fAtrref;
        public string Atrref
        {
            get { return _fAtrref; }
            set
            {
                if (_fAtrref != value)
                {
                    Modify();
                    _fAtrref = value;
                }
            }
        }

        private string _fAtrref2;
        public string Atrref2
        {
            get { return _fAtrref2; }
            set
            {
                if (_fAtrref2 != value)
                {
                    Modify();
                    _fAtrref2 = value;
                }
            }
        }

        private int? _fAtrsaloffno;
        public int? Atrsaloffno
        {
            get { return _fAtrsaloffno; }
            set
            {
                if (_fAtrsaloffno != value)
                {
                    Modify();
                    _fAtrsaloffno = value;
                }
            }
        }

        private int _fAtrstatind;
        public int Atrstatind
        {
            get { return _fAtrstatind; }
            set
            {
                if (_fAtrstatind != value)
                {
                    Modify();
                    _fAtrstatind = value;
                }
            }
        }

        private int? _fAtrtoauthno;
        public int? Atrtoauthno
        {
            get { return _fAtrtoauthno; }
            set
            {
                if (_fAtrtoauthno != value)
                {
                    Modify();
                    _fAtrtoauthno = value;
                }
            }
        }

        private decimal? _fAtrtopayamt;
        public decimal? Atrtopayamt
        {
            get { return _fAtrtopayamt; }
            set
            {
                if (_fAtrtopayamt != value)
                {
                    Modify();
                    _fAtrtopayamt = value;
                }
            }
        }

        private DateTime? _fAtrtopaydate;
        public DateTime? Atrtopaydate
        {
            get { return _fAtrtopaydate; }
            set
            {
                if (_fAtrtopaydate != value)
                {
                    Modify();
                    _fAtrtopaydate = value;
                }
            }
        }

        private short? _fAtrtriangulate;
        public short? Atrtriangulate
        {
            get { return _fAtrtriangulate; }
            set
            {
                if (_fAtrtriangulate != value)
                {
                    Modify();
                    _fAtrtriangulate = value;
                }
            }
        }

        private decimal? _fAtrwhtaxamount;
        public decimal? Atrwhtaxamount
        {
            get { return _fAtrwhtaxamount; }
            set
            {
                if (_fAtrwhtaxamount != value)
                {
                    Modify();
                    _fAtrwhtaxamount = value;
                }
            }
        }

        private short? _fAtrwithholdtax;
        public short? Atrwithholdtax
        {
            get { return _fAtrwithholdtax; }
            set
            {
                if (_fAtrwithholdtax != value)
                {
                    Modify();
                    _fAtrwithholdtax = value;
                }
            }
        }

        private decimal? _fAtrwithholdtaxrate;
        public decimal? Atrwithholdtaxrate
        {
            get { return _fAtrwithholdtaxrate; }
            set
            {
                if (_fAtrwithholdtaxrate != value)
                {
                    Modify();
                    _fAtrwithholdtaxrate = value;
                }
            }
        }

        private int? _fAtryearno;
        public int? Atryearno
        {
            get { return _fAtryearno; }
            set
            {
                if (_fAtryearno != value)
                {
                    Modify();
                    _fAtryearno = value;
                }
            }
        }

        private string _fClrddate;
        public string Clrddate
        {
            get { return _fClrddate; }
            set
            {
                if (_fClrddate != value)
                {
                    Modify();
                    _fClrddate = value;
                }
            }
        }

        private int? _fIntcomptrn;
        public int? Intcomptrn
        {
            get { return _fIntcomptrn; }
            set
            {
                if (_fIntcomptrn != value)
                {
                    Modify();
                    _fIntcomptrn = value;
                }
            }
        }

        private decimal? _fInvexchrate;
        public decimal? Invexchrate
        {
            get { return _fInvexchrate; }
            set
            {
                if (_fInvexchrate != value)
                {
                    Modify();
                    _fInvexchrate = value;
                }
            }
        }

        private int? _fOnholdby;
        public int? Onholdby
        {
            get { return _fOnholdby; }
            set
            {
                if (_fOnholdby != value)
                {
                    Modify();
                    _fOnholdby = value;
                }
            }
        }

        private DateTime? _fOnholddate;
        public DateTime? Onholddate
        {
            get { return _fOnholddate; }
            set
            {
                if (_fOnholddate != value)
                {
                    Modify();
                    _fOnholddate = value;
                }
            }
        }

        private short? _fPaymentagentprinted;
        public short? Paymentagentprinted
        {
            get { return _fPaymentagentprinted; }
            set
            {
                if (_fPaymentagentprinted != value)
                {
                    Modify();
                    _fPaymentagentprinted = value;
                }
            }
        }

        public override int Key
        {
            get { return Atrrecno; }
            set { Atrrecno = value; }
        }

        public override string KeyAsString { get { return Key.ToString(CultureInfo.InvariantCulture); } }


        public override AccTrnFil Clone()
        {
            var obj = new AccTrnFil
                {
                    Atrrecno = Atrrecno,
                    Atr1099type = Atr1099type,
                    Atractpstdate = Atractpstdate,
                    Atractpstlogon = Atractpstlogon,
                    Atramount = Atramount,
                    Atramountwhval = Atramountwhval,
                    Atrauthbyno = Atrauthbyno,
                    Atrbalance = Atrbalance,
                    Atrbalatlststmt = Atrbalatlststmt,
                    Atrbaseamount = Atrbaseamount,
                    Atrbaserate = Atrbaserate,
                    Atrclarecno = Atrclarecno,
                    Atrclass = Atrclass,
                    Atrcoglbrecno = Atrcoglbrecno,
                    Atrcurrecno = Atrcurrecno,
                    Atrdbno = Atrdbno,
                    Atrdbtype = Atrdbtype,
                    Atrdelclarecno = Atrdelclarecno,
                    Atrdispute = Atrdispute,
                    Atreuroamount = Atreuroamount,
                    Atreurorate = Atreurorate,
                    Atrexclfromexport = Atrexclfromexport,
                    Atrfactorclarec = Atrfactorclarec,
                    Atronpayplan = Atronpayplan,
                    Atrourrefno = Atrourrefno,
                    Atrperiodno = Atrperiodno,
                    Atrprdorpan = Atrprdorpan,
                    Atrpstdate = Atrpstdate,
                    Atrpstdatedchq = Atrpstdatedchq,
                    Atrpstdchqentdate = Atrpstdchqentdate,
                    Atrpsttyp = Atrpsttyp,
                    Atrpurauthbatrec = Atrpurauthbatrec,
                    Atrref = Atrref,
                    Atrref2 = Atrref2,
                    Atrsaloffno = Atrsaloffno,
                    Atrstatind = Atrstatind,
                    Atrtoauthno = Atrtoauthno,
                    Atrtopayamt = Atrtopayamt,
                    Atrtopaydate = Atrtopaydate,
                    Atrtriangulate = Atrtriangulate,
                    Atrwhtaxamount = Atrwhtaxamount,
                    Atrwithholdtax = Atrwithholdtax,
                    Atrwithholdtaxrate = Atrwithholdtaxrate,
                    Atryearno = Atryearno,
                    Clrddate = Clrddate,
                    Intcomptrn = Intcomptrn,
                    Invexchrate = Invexchrate,
                    Onholdby = Onholdby,
                    Onholddate = Onholddate,
                    Paymentagentprinted = Paymentagentprinted,
                };

            return obj;
        }

        public static class FieldNames
        {
// ReSharper disable InconsistentNaming
            public const string  ATRRECNO = "ATRRECNO";
            public const string  ATR1099TYPE = "ATR1099TYPE";
            public const string  ATRACTPSTDATE = "ATRACTPSTDATE";
            public const string  ATRACTPSTLOGON = "ATRACTPSTLOGON";
            public const string  ATRAMOUNT = "ATRAMOUNT";
            public const string  ATRAMOUNTWHVAL = "ATRAMOUNTWHVAL";
            public const string  ATRAUTHBYNO = "ATRAUTHBYNO";
            public const string  ATRBALANCE = "ATRBALANCE";
            public const string  ATRBALATLSTSTMT = "ATRBALATLSTSTMT";
            public const string  ATRBASEAMOUNT = "ATRBASEAMOUNT";
            public const string  ATRBASERATE = "ATRBASERATE";
            public const string  ATRCLARECNO = "ATRCLARECNO";
            public const string  ATRCLASS = "ATRCLASS";
            public const string  ATRCOGLBRECNO = "ATRCOGLBRECNO";
            public const string  ATRCURRECNO = "ATRCURRECNO";
            public const string  ATRDBNO = "ATRDBNO";
            public const string  ATRDBTYPE = "ATRDBTYPE";
            public const string  ATRDELCLARECNO = "ATRDELCLARECNO";
            public const string  ATRDISPUTE = "ATRDISPUTE";
            public const string  ATREUROAMOUNT = "ATREUROAMOUNT";
            public const string  ATREURORATE = "ATREURORATE";
            public const string  ATREXCLFROMEXPORT = "ATREXCLFROMEXPORT";
            public const string  ATRFACTORCLAREC = "ATRFACTORCLAREC";
            public const string  ATRONPAYPLAN = "ATRONPAYPLAN";
            public const string  ATROURREFNO = "ATROURREFNO";
            public const string  ATRPERIODNO = "ATRPERIODNO";
            public const string  ATRPRDORPAN = "ATRPRDORPAN";
            public const string  ATRPSTDATE = "ATRPSTDATE";
            public const string  ATRPSTDATEDCHQ = "ATRPSTDATEDCHQ";
            public const string  ATRPSTDCHQENTDATE = "ATRPSTDCHQENTDATE";
            public const string  ATRPSTTYP = "ATRPSTTYP";
            public const string  ATRPURAUTHBATREC = "ATRPURAUTHBATREC";
            public const string  ATRREF = "ATRREF";
            public const string  ATRREF2 = "ATRREF2";
            public const string  ATRSALOFFNO = "ATRSALOFFNO";
            public const string  ATRSTATIND = "ATRSTATIND";
            public const string  ATRTOAUTHNO = "ATRTOAUTHNO";
            public const string  ATRTOPAYAMT = "ATRTOPAYAMT";
            public const string  ATRTOPAYDATE = "ATRTOPAYDATE";
            public const string  ATRTRIANGULATE = "ATRTRIANGULATE";
            public const string  ATRWHTAXAMOUNT = "ATRWHTAXAMOUNT";
            public const string  ATRWITHHOLDTAX = "ATRWITHHOLDTAX";
            public const string  ATRWITHHOLDTAXRATE = "ATRWITHHOLDTAXRATE";
            public const string  ATRYEARNO = "ATRYEARNO";
            public const string  CLRDDATE = "CLRDDATE";
            public const string  INTCOMPTRN = "INTCOMPTRN";
            public const string  INVEXCHRATE = "INVEXCHRATE";
            public const string  ONHOLDBY = "ONHOLDBY";
            public const string  ONHOLDDATE = "ONHOLDDATE";
            public const string  PAYMENTAGENTPRINTED = "PAYMENTAGENTPRINTED";
 // ReSharper restore InconsistentNaming
        }


    }

}
