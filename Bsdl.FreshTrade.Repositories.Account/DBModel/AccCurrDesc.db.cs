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
    /// Entity for the ACCCURRDESC table
    /// </summary>
    public partial class AccCurrDesc : BaseDbModel<AccCurrDesc, int>
    {
#region tableDefs

       public static List<EntityPropDef> GetPropDefs() {
         var result = new List<EntityPropDef>();

//EntityPropDef(string propName, string columnName, bool isKey, bool isNullable, string refEntityName, PropertyInfo keyPropInfo,
//            int size, int? prec, int? scale)



         result.Add(new EntityPropDef(
         PropertyHelper <AccCurrDesc>.GetProperty(x => x.Curno),
         "CURNO", // columnName
         true,                    //isKey
         false, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  5, // int? prec
                           0  // int? Scale
         ,
         typeof(AccCurrDesc)
       ));


         result.Add(new EntityPropDef(
         PropertyHelper <AccCurrDesc>.GetProperty(x => x.Curcode),
         "CURCODE", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         3,       // int size   
                  null, // int? prec
                   
         null // int? Scale
         ,
         typeof(AccCurrDesc)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <AccCurrDesc>.GetProperty(x => x.Curdecimalplaces),
         "CURDECIMALPLACES", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  5, // int? prec
                           0  // int? Scale
         ,
         typeof(AccCurrDesc)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <AccCurrDesc>.GetProperty(x => x.Curdecimalpoint),
         "CURDECIMALPOINT", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         1,       // int size   
                  null, // int? prec
                   
         null // int? Scale
         ,
         typeof(AccCurrDesc)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <AccCurrDesc>.GetProperty(x => x.Curdefbanrecno),
         "CURDEFBANRECNO", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  5, // int? prec
                           0  // int? Scale
         ,
         typeof(AccCurrDesc)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <AccCurrDesc>.GetProperty(x => x.Curdesc),
         "CURDESC", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         30,       // int size   
                  null, // int? prec
                   
         null // int? Scale
         ,
         typeof(AccCurrDesc)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <AccCurrDesc>.GetProperty(x => x.Curextnnumpicture),
         "CUREXTNNUMPICTURE", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         30,       // int size   
                  null, // int? prec
                   
         null // int? Scale
         ,
         typeof(AccCurrDesc)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <AccCurrDesc>.GetProperty(x => x.Cursymbol),
         "CURSYMBOL", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         4,       // int size   
                  null, // int? prec
                   
         null // int? Scale
         ,
         typeof(AccCurrDesc)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <AccCurrDesc>.GetProperty(x => x.Cursymbolatfront),
         "CURSYMBOLATFRONT", // columnName
         false,                    //isKey
         false, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  1, // int? prec
                           0  // int? Scale
         ,
         typeof(AccCurrDesc)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <AccCurrDesc>.GetProperty(x => x.Curthousandseparator),
         "CURTHOUSANDSEPARATOR", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         1,       // int size   
                  null, // int? prec
                   
         null // int? Scale
         ,
         typeof(AccCurrDesc)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <AccCurrDesc>.GetProperty(x => x.Curtriangreq),
         "CURTRIANGREQ", // columnName
         false,                    //isKey
         false, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  1, // int? prec
                           0  // int? Scale
         ,
         typeof(AccCurrDesc)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <AccCurrDesc>.GetProperty(x => x.Curunitnumpicture),
         "CURUNITNUMPICTURE", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         30,       // int size   
                  null, // int? prec
                   
         null // int? Scale
         ,
         typeof(AccCurrDesc)
         ));
         return result; 
       }

#endregion     
        private int _fCurno;
        public int Curno
        {
            get { return _fCurno; }
            set
            {
                var oldKey = Key;
                if (_fCurno != value)
                {
                    Modify();
                    _fCurno = value;
                    KeyChanged(oldKey);
                }
            }
        }

        private string _fCurcode;
        public string Curcode
        {
            get { return _fCurcode; }
            set
            {
                if (_fCurcode != value)
                {
                    Modify();
                    _fCurcode = value;
                }
            }
        }

        private int? _fCurdecimalplaces;
        public int? Curdecimalplaces
        {
            get { return _fCurdecimalplaces; }
            set
            {
                if (_fCurdecimalplaces != value)
                {
                    Modify();
                    _fCurdecimalplaces = value;
                }
            }
        }

        private string _fCurdecimalpoint;
        public string Curdecimalpoint
        {
            get { return _fCurdecimalpoint; }
            set
            {
                if (_fCurdecimalpoint != value)
                {
                    Modify();
                    _fCurdecimalpoint = value;
                }
            }
        }

        private int? _fCurdefbanrecno;
        public int? Curdefbanrecno
        {
            get { return _fCurdefbanrecno; }
            set
            {
                if (_fCurdefbanrecno != value)
                {
                    Modify();
                    _fCurdefbanrecno = value;
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

        private string _fCurextnnumpicture;
        public string Curextnnumpicture
        {
            get { return _fCurextnnumpicture; }
            set
            {
                if (_fCurextnnumpicture != value)
                {
                    Modify();
                    _fCurextnnumpicture = value;
                }
            }
        }

        private string _fCursymbol;
        public string Cursymbol
        {
            get { return _fCursymbol; }
            set
            {
                if (_fCursymbol != value)
                {
                    Modify();
                    _fCursymbol = value;
                }
            }
        }

        private short _fCursymbolatfront;
        public short Cursymbolatfront
        {
            get { return _fCursymbolatfront; }
            set
            {
                if (_fCursymbolatfront != value)
                {
                    Modify();
                    _fCursymbolatfront = value;
                }
            }
        }

        private string _fCurthousandseparator;
        public string Curthousandseparator
        {
            get { return _fCurthousandseparator; }
            set
            {
                if (_fCurthousandseparator != value)
                {
                    Modify();
                    _fCurthousandseparator = value;
                }
            }
        }

        private short _fCurtriangreq;
        public short Curtriangreq
        {
            get { return _fCurtriangreq; }
            set
            {
                if (_fCurtriangreq != value)
                {
                    Modify();
                    _fCurtriangreq = value;
                }
            }
        }

        private string _fCurunitnumpicture;
        public string Curunitnumpicture
        {
            get { return _fCurunitnumpicture; }
            set
            {
                if (_fCurunitnumpicture != value)
                {
                    Modify();
                    _fCurunitnumpicture = value;
                }
            }
        }

        public override int Key
        {
            get { return Curno; }
            set { Curno = value; }
        }

        public override string KeyAsString { get { return Key.ToString(CultureInfo.InvariantCulture); } }


        public override AccCurrDesc Clone()
        {
            var obj = new AccCurrDesc
                {
                    Curno = Curno,
                    Curcode = Curcode,
                    Curdecimalplaces = Curdecimalplaces,
                    Curdecimalpoint = Curdecimalpoint,
                    Curdefbanrecno = Curdefbanrecno,
                    Curdesc = Curdesc,
                    Curextnnumpicture = Curextnnumpicture,
                    Cursymbol = Cursymbol,
                    Cursymbolatfront = Cursymbolatfront,
                    Curthousandseparator = Curthousandseparator,
                    Curtriangreq = Curtriangreq,
                    Curunitnumpicture = Curunitnumpicture,
                };

            return obj;
        }

        public static class FieldNames
        {
// ReSharper disable InconsistentNaming
            public const string  CURNO = "CURNO";
            public const string  CURCODE = "CURCODE";
            public const string  CURDECIMALPLACES = "CURDECIMALPLACES";
            public const string  CURDECIMALPOINT = "CURDECIMALPOINT";
            public const string  CURDEFBANRECNO = "CURDEFBANRECNO";
            public const string  CURDESC = "CURDESC";
            public const string  CUREXTNNUMPICTURE = "CUREXTNNUMPICTURE";
            public const string  CURSYMBOL = "CURSYMBOL";
            public const string  CURSYMBOLATFRONT = "CURSYMBOLATFRONT";
            public const string  CURTHOUSANDSEPARATOR = "CURTHOUSANDSEPARATOR";
            public const string  CURTRIANGREQ = "CURTRIANGREQ";
            public const string  CURUNITNUMPICTURE = "CURUNITNUMPICTURE";
 // ReSharper restore InconsistentNaming
        }


    }

}
