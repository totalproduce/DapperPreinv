




// <summary>
// This file is generated automatically. Any changes will be lost.
// </summary>

using System;
using System.Collections.Generic;
using System.Globalization;
using Bsdl.FreshTrade.Repositories.Basic.DBModel;
using Bsdl.FreshTrade.Repositories.Basic.Persistance;

namespace Bsdl.FreshTrade.Repositories.Basic.DBModel
{
    /// <summary>
    /// Entity for the WIZSYSPREF table
    /// </summary>
    public partial class WizSysPref : BaseDbModel<WizSysPref, int>
    {
#region tableDefs

       public static List<EntityPropDef> GetPropDefs() {
         var result = new List<EntityPropDef>();

//EntityPropDef(string propName, string columnName, bool isKey, bool isNullable, string refEntityName, PropertyInfo keyPropInfo,
//            int size, int? prec, int? scale)



         result.Add(new EntityPropDef(
         PropertyHelper <WizSysPref>.GetProperty(x => x.Sysprefid),
         "SYSPREFID", // columnName
         true,                    //isKey
         false, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  5, // int? prec
                           0  // int? Scale
         ,
         typeof(WizSysPref)
       ));


         result.Add(new EntityPropDef(
         PropertyHelper <WizSysPref>.GetProperty(x => x.Syslookupbyfld1),
         "SYSLOOKUPBYFLD1", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         30,       // int size   
                  null, // int? prec
                   
         null // int? Scale
         ,
         typeof(WizSysPref)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <WizSysPref>.GetProperty(x => x.Syslookupbyfld2),
         "SYSLOOKUPBYFLD2", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         30,       // int size   
                  null, // int? prec
                   
         null // int? Scale
         ,
         typeof(WizSysPref)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <WizSysPref>.GetProperty(x => x.Syslookupbyval1),
         "SYSLOOKUPBYVAL1", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         30,       // int size   
                  null, // int? prec
                   
         null // int? Scale
         ,
         typeof(WizSysPref)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <WizSysPref>.GetProperty(x => x.Syslookupbyval2),
         "SYSLOOKUPBYVAL2", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         30,       // int size   
                  null, // int? prec
                   
         null // int? Scale
         ,
         typeof(WizSysPref)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <WizSysPref>.GetProperty(x => x.Syslookupdesc),
         "SYSLOOKUPDESC", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         30,       // int size   
                  null, // int? prec
                   
         null // int? Scale
         ,
         typeof(WizSysPref)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <WizSysPref>.GetProperty(x => x.Syslookuptable),
         "SYSLOOKUPTABLE", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         30,       // int size   
                  null, // int? prec
                   
         null // int? Scale
         ,
         typeof(WizSysPref)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <WizSysPref>.GetProperty(x => x.Syslookupvalue),
         "SYSLOOKUPVALUE", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         30,       // int size   
                  null, // int? prec
                   
         null // int? Scale
         ,
         typeof(WizSysPref)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <WizSysPref>.GetProperty(x => x.Sysprefdefault),
         "SYSPREFDEFAULT", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         30,       // int size   
                  null, // int? prec
                   
         null // int? Scale
         ,
         typeof(WizSysPref)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <WizSysPref>.GetProperty(x => x.Sysprefdescription),
         "SYSPREFDESCRIPTION", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         175,       // int size   
                  null, // int? prec
                   
         null // int? Scale
         ,
         typeof(WizSysPref)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <WizSysPref>.GetProperty(x => x.Sysprefdetail),
         "SYSPREFDETAIL", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         75,       // int size   
                  null, // int? prec
                   
         null // int? Scale
         ,
         typeof(WizSysPref)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <WizSysPref>.GetProperty(x => x.Sysprefheader),
         "SYSPREFHEADER", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         75,       // int size   
                  null, // int? prec
                   
         null // int? Scale
         ,
         typeof(WizSysPref)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <WizSysPref>.GetProperty(x => x.Sysprefmax),
         "SYSPREFMAX", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  10, // int? prec
                           0  // int? Scale
         ,
         typeof(WizSysPref)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <WizSysPref>.GetProperty(x => x.Sysprefmin),
         "SYSPREFMIN", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  10, // int? prec
                           0  // int? Scale
         ,
         typeof(WizSysPref)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <WizSysPref>.GetProperty(x => x.Sysprefname),
         "SYSPREFNAME", // columnName
         false,                    //isKey
         false, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         30,       // int size   
                  null, // int? prec
                   
         null // int? Scale
         ,
         typeof(WizSysPref)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <WizSysPref>.GetProperty(x => x.Sysprefsubdetail),
         "SYSPREFSUBDETAIL", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         75,       // int size   
                  null, // int? prec
                   
         null // int? Scale
         ,
         typeof(WizSysPref)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <WizSysPref>.GetProperty(x => x.Syspreftype),
         "SYSPREFTYPE", // columnName
         false,                    //isKey
         false, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         1,       // int size   
                  null, // int? prec
                   
         null // int? Scale
         ,
         typeof(WizSysPref)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <WizSysPref>.GetProperty(x => x.Sysprefvalue),
         "SYSPREFVALUE", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         30,       // int size   
                  null, // int? prec
                   
         null // int? Scale
         ,
         typeof(WizSysPref)
         ));
         return result; 
       }

#endregion     
        private int _fSysprefid;
        public int Sysprefid
        {
            get { return _fSysprefid; }
            set
            {
                var oldKey = Key;
                if (_fSysprefid != value)
                {
                    Modify();
                    _fSysprefid = value;
                    KeyChanged(oldKey);
                }
            }
        }

        private string _fSyslookupbyfld1;
        public string Syslookupbyfld1
        {
            get { return _fSyslookupbyfld1; }
            set
            {
                if (_fSyslookupbyfld1 != value)
                {
                    Modify();
                    _fSyslookupbyfld1 = value;
                }
            }
        }

        private string _fSyslookupbyfld2;
        public string Syslookupbyfld2
        {
            get { return _fSyslookupbyfld2; }
            set
            {
                if (_fSyslookupbyfld2 != value)
                {
                    Modify();
                    _fSyslookupbyfld2 = value;
                }
            }
        }

        private string _fSyslookupbyval1;
        public string Syslookupbyval1
        {
            get { return _fSyslookupbyval1; }
            set
            {
                if (_fSyslookupbyval1 != value)
                {
                    Modify();
                    _fSyslookupbyval1 = value;
                }
            }
        }

        private string _fSyslookupbyval2;
        public string Syslookupbyval2
        {
            get { return _fSyslookupbyval2; }
            set
            {
                if (_fSyslookupbyval2 != value)
                {
                    Modify();
                    _fSyslookupbyval2 = value;
                }
            }
        }

        private string _fSyslookupdesc;
        public string Syslookupdesc
        {
            get { return _fSyslookupdesc; }
            set
            {
                if (_fSyslookupdesc != value)
                {
                    Modify();
                    _fSyslookupdesc = value;
                }
            }
        }

        private string _fSyslookuptable;
        public string Syslookuptable
        {
            get { return _fSyslookuptable; }
            set
            {
                if (_fSyslookuptable != value)
                {
                    Modify();
                    _fSyslookuptable = value;
                }
            }
        }

        private string _fSyslookupvalue;
        public string Syslookupvalue
        {
            get { return _fSyslookupvalue; }
            set
            {
                if (_fSyslookupvalue != value)
                {
                    Modify();
                    _fSyslookupvalue = value;
                }
            }
        }

        private string _fSysprefdefault;
        public string Sysprefdefault
        {
            get { return _fSysprefdefault; }
            set
            {
                if (_fSysprefdefault != value)
                {
                    Modify();
                    _fSysprefdefault = value;
                }
            }
        }

        private string _fSysprefdescription;
        public string Sysprefdescription
        {
            get { return _fSysprefdescription; }
            set
            {
                if (_fSysprefdescription != value)
                {
                    Modify();
                    _fSysprefdescription = value;
                }
            }
        }

        private string _fSysprefdetail;
        public string Sysprefdetail
        {
            get { return _fSysprefdetail; }
            set
            {
                if (_fSysprefdetail != value)
                {
                    Modify();
                    _fSysprefdetail = value;
                }
            }
        }

        private string _fSysprefheader;
        public string Sysprefheader
        {
            get { return _fSysprefheader; }
            set
            {
                if (_fSysprefheader != value)
                {
                    Modify();
                    _fSysprefheader = value;
                }
            }
        }

        private int? _fSysprefmax;
        public int? Sysprefmax
        {
            get { return _fSysprefmax; }
            set
            {
                if (_fSysprefmax != value)
                {
                    Modify();
                    _fSysprefmax = value;
                }
            }
        }

        private int? _fSysprefmin;
        public int? Sysprefmin
        {
            get { return _fSysprefmin; }
            set
            {
                if (_fSysprefmin != value)
                {
                    Modify();
                    _fSysprefmin = value;
                }
            }
        }

        private string _fSysprefname;
        public string Sysprefname
        {
            get { return _fSysprefname; }
            set
            {
                if (_fSysprefname != value)
                {
                    Modify();
                    _fSysprefname = value;
                }
            }
        }

        private string _fSysprefsubdetail;
        public string Sysprefsubdetail
        {
            get { return _fSysprefsubdetail; }
            set
            {
                if (_fSysprefsubdetail != value)
                {
                    Modify();
                    _fSysprefsubdetail = value;
                }
            }
        }

        private string _fSyspreftype;
        public string Syspreftype
        {
            get { return _fSyspreftype; }
            set
            {
                if (_fSyspreftype != value)
                {
                    Modify();
                    _fSyspreftype = value;
                }
            }
        }

        private string _fSysprefvalue;
        public string Sysprefvalue
        {
            get { return _fSysprefvalue; }
            set
            {
                if (_fSysprefvalue != value)
                {
                    Modify();
                    _fSysprefvalue = value;
                }
            }
        }

        public override int Key
        {
            get { return Sysprefid; }
            set { Sysprefid = value; }
        }

        public override string KeyAsString { get { return Key.ToString(CultureInfo.InvariantCulture); } }


        public override WizSysPref Clone()
        {
            var obj = new WizSysPref
                {
                    Sysprefid = Sysprefid,
                    Syslookupbyfld1 = Syslookupbyfld1,
                    Syslookupbyfld2 = Syslookupbyfld2,
                    Syslookupbyval1 = Syslookupbyval1,
                    Syslookupbyval2 = Syslookupbyval2,
                    Syslookupdesc = Syslookupdesc,
                    Syslookuptable = Syslookuptable,
                    Syslookupvalue = Syslookupvalue,
                    Sysprefdefault = Sysprefdefault,
                    Sysprefdescription = Sysprefdescription,
                    Sysprefdetail = Sysprefdetail,
                    Sysprefheader = Sysprefheader,
                    Sysprefmax = Sysprefmax,
                    Sysprefmin = Sysprefmin,
                    Sysprefname = Sysprefname,
                    Sysprefsubdetail = Sysprefsubdetail,
                    Syspreftype = Syspreftype,
                    Sysprefvalue = Sysprefvalue,
                };

            return obj;
        }

        public static class FieldNames
        {
// ReSharper disable InconsistentNaming
            public const string  SYSPREFID = "SYSPREFID";
            public const string  SYSLOOKUPBYFLD1 = "SYSLOOKUPBYFLD1";
            public const string  SYSLOOKUPBYFLD2 = "SYSLOOKUPBYFLD2";
            public const string  SYSLOOKUPBYVAL1 = "SYSLOOKUPBYVAL1";
            public const string  SYSLOOKUPBYVAL2 = "SYSLOOKUPBYVAL2";
            public const string  SYSLOOKUPDESC = "SYSLOOKUPDESC";
            public const string  SYSLOOKUPTABLE = "SYSLOOKUPTABLE";
            public const string  SYSLOOKUPVALUE = "SYSLOOKUPVALUE";
            public const string  SYSPREFDEFAULT = "SYSPREFDEFAULT";
            public const string  SYSPREFDESCRIPTION = "SYSPREFDESCRIPTION";
            public const string  SYSPREFDETAIL = "SYSPREFDETAIL";
            public const string  SYSPREFHEADER = "SYSPREFHEADER";
            public const string  SYSPREFMAX = "SYSPREFMAX";
            public const string  SYSPREFMIN = "SYSPREFMIN";
            public const string  SYSPREFNAME = "SYSPREFNAME";
            public const string  SYSPREFSUBDETAIL = "SYSPREFSUBDETAIL";
            public const string  SYSPREFTYPE = "SYSPREFTYPE";
            public const string  SYSPREFVALUE = "SYSPREFVALUE";
 // ReSharper restore InconsistentNaming
        }


    }

}
