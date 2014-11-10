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
    /// Entity for the ACCRECHG table
    /// </summary>
    public partial class AccReChg : BaseDbModel<AccReChg, int>
    {
#region tableDefs

       public static List<EntityPropDef> GetPropDefs() {
         var result = new List<EntityPropDef>();

//EntityPropDef(string propName, string columnName, bool isKey, bool isNullable, string refEntityName, PropertyInfo keyPropInfo,
//            int size, int? prec, int? scale)



         result.Add(new EntityPropDef(
         PropertyHelper <AccReChg>.GetProperty(x => x.Rechgrecno),
         "RECHGRECNO", // columnName
         true,                    //isKey
         false, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  10, // int? prec
                           0  // int? Scale
         ,
         typeof(AccReChg)
       ));


         result.Add(new EntityPropDef(
         PropertyHelper <AccReChg>.GetProperty(x => x.Batrecno),
         "BATRECNO", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  10, // int? prec
                           0  // int? Scale
         ,
         typeof(AccReChg)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <AccReChg>.GetProperty(x => x.Fromsaloffno),
         "FROMSALOFFNO", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  5, // int? prec
                           0  // int? Scale
         ,
         typeof(AccReChg)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <AccReChg>.GetProperty(x => x.Origatrrecno),
         "ORIGATRRECNO", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  10, // int? prec
                           0  // int? Scale
         ,
         typeof(AccReChg)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <AccReChg>.GetProperty(x => x.Repackatrrecno),
         "REPACKATRRECNO", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  10, // int? prec
                           0  // int? Scale
         ,
         typeof(AccReChg)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <AccReChg>.GetProperty(x => x.Tosaloffno),
         "TOSALOFFNO", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  5, // int? prec
                           0  // int? Scale
         ,
         typeof(AccReChg)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <AccReChg>.GetProperty(x => x.Trnshpatrrecno),
         "TRNSHPATRRECNO", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  10, // int? prec
                           0  // int? Scale
         ,
         typeof(AccReChg)
         ));
         return result; 
       }

#endregion     
        private int _fRechgrecno;
        public int Rechgrecno
        {
            get { return _fRechgrecno; }
            set
            {
                var oldKey = Key;
                if (_fRechgrecno != value)
                {
                    Modify();
                    _fRechgrecno = value;
                    KeyChanged(oldKey);
                }
            }
        }

        private int? _fBatrecno;
        public int? Batrecno
        {
            get { return _fBatrecno; }
            set
            {
                if (_fBatrecno != value)
                {
                    Modify();
                    _fBatrecno = value;
                }
            }
        }

        private int? _fFromsaloffno;
        public int? Fromsaloffno
        {
            get { return _fFromsaloffno; }
            set
            {
                if (_fFromsaloffno != value)
                {
                    Modify();
                    _fFromsaloffno = value;
                }
            }
        }

        private int? _fOrigatrrecno;
        public int? Origatrrecno
        {
            get { return _fOrigatrrecno; }
            set
            {
                if (_fOrigatrrecno != value)
                {
                    Modify();
                    _fOrigatrrecno = value;
                }
            }
        }

        private int? _fRepackatrrecno;
        public int? Repackatrrecno
        {
            get { return _fRepackatrrecno; }
            set
            {
                if (_fRepackatrrecno != value)
                {
                    Modify();
                    _fRepackatrrecno = value;
                }
            }
        }

        private int? _fTosaloffno;
        public int? Tosaloffno
        {
            get { return _fTosaloffno; }
            set
            {
                if (_fTosaloffno != value)
                {
                    Modify();
                    _fTosaloffno = value;
                }
            }
        }

        private int? _fTrnshpatrrecno;
        public int? Trnshpatrrecno
        {
            get { return _fTrnshpatrrecno; }
            set
            {
                if (_fTrnshpatrrecno != value)
                {
                    Modify();
                    _fTrnshpatrrecno = value;
                }
            }
        }

        public override int Key
        {
            get { return Rechgrecno; }
            set { Rechgrecno = value; }
        }

        public override string KeyAsString { get { return Key.ToString(CultureInfo.InvariantCulture); } }


        public override AccReChg Clone()
        {
            var obj = new AccReChg
                {
                    Rechgrecno = Rechgrecno,
                    Batrecno = Batrecno,
                    Fromsaloffno = Fromsaloffno,
                    Origatrrecno = Origatrrecno,
                    Repackatrrecno = Repackatrrecno,
                    Tosaloffno = Tosaloffno,
                    Trnshpatrrecno = Trnshpatrrecno,
                };

            return obj;
        }

        public static class FieldNames
        {
// ReSharper disable InconsistentNaming
            public const string  RECHGRECNO = "RECHGRECNO";
            public const string  BATRECNO = "BATRECNO";
            public const string  FROMSALOFFNO = "FROMSALOFFNO";
            public const string  ORIGATRRECNO = "ORIGATRRECNO";
            public const string  REPACKATRRECNO = "REPACKATRRECNO";
            public const string  TOSALOFFNO = "TOSALOFFNO";
            public const string  TRNSHPATRRECNO = "TRNSHPATRRECNO";
 // ReSharper restore InconsistentNaming
        }


    }

}
