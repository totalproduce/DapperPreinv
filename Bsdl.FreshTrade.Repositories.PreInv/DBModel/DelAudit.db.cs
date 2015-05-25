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
    /// Entity for the DELAUDIT table
    /// </summary>
    public partial class DelAudit : BaseDbModel<DelAudit, int>
    {
#region tableDefs

       public static List<EntityPropDef> GetPropDefs() {
         var result = new List<EntityPropDef>();

//EntityPropDef(string propName, string columnName, bool isKey, bool isNullable, string refEntityName, PropertyInfo keyPropInfo,
//            int size, int? prec, int? scale)



         result.Add(new EntityPropDef(
         PropertyHelper <DelAudit>.GetProperty(x => x.Delaudrecno),
         "DELAUDRECNO", // columnName
         true,                    //isKey
         false, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  10, // int? prec
                           0  // int? Scale
         ,
         typeof(DelAudit)
       ));


         result.Add(new EntityPropDef(
         PropertyHelper <DelAudit>.GetProperty(x => x.Delauddate),
         "DELAUDDATE", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  null, // int? prec
                   
         null // int? Scale
         ,
         typeof(DelAudit)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <DelAudit>.GetProperty(x => x.Delauddelrecno),
         "DELAUDDELRECNO", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  10, // int? prec
                           0  // int? Scale
         ,
         typeof(DelAudit)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <DelAudit>.GetProperty(x => x.Delaudfrom),
         "DELAUDFROM", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         16,       // int size   
                  null, // int? prec
                   
         null // int? Scale
         ,
         typeof(DelAudit)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <DelAudit>.GetProperty(x => x.Delaudgrpno),
         "DELAUDGRPNO", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  10, // int? prec
                           0  // int? Scale
         ,
         typeof(DelAudit)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <DelAudit>.GetProperty(x => x.Delaudtime),
         "DELAUDTIME", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         11,       // int size   
                  null, // int? prec
                   
         null // int? Scale
         ,
         typeof(DelAudit)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <DelAudit>.GetProperty(x => x.Delaudto),
         "DELAUDTO", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         16,       // int size   
                  null, // int? prec
                   
         null // int? Scale
         ,
         typeof(DelAudit)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <DelAudit>.GetProperty(x => x.Delaudtyp),
         "DELAUDTYP", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  5, // int? prec
                           0  // int? Scale
         ,
         typeof(DelAudit)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <DelAudit>.GetProperty(x => x.Dprrecno),
         "DPRRECNO", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  10, // int? prec
                           0  // int? Scale
         ,
         typeof(DelAudit)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <DelAudit>.GetProperty(x => x.Dprtoaction),
         "DPRTOACTION", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  5, // int? prec
                           0  // int? Scale
         ,
         typeof(DelAudit)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <DelAudit>.GetProperty(x => x.Formname),
         "FORMNAME", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         20,       // int size   
                  null, // int? prec
                   
         null // int? Scale
         ,
         typeof(DelAudit)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <DelAudit>.GetProperty(x => x.Formno),
         "FORMNO", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  5, // int? prec
                           0  // int? Scale
         ,
         typeof(DelAudit)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <DelAudit>.GetProperty(x => x.Logonno),
         "LOGONNO", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  5, // int? prec
                           0  // int? Scale
         ,
         typeof(DelAudit)
         ));
         return result; 
       }

#endregion     
        private int _fDelaudrecno;
        public int Delaudrecno
        {
            get { return _fDelaudrecno; }
            set
            {
                var oldKey = Key;
                if (_fDelaudrecno != value)
                {
                    Modify();
                    _fDelaudrecno = value;
                    KeyChanged(oldKey);
                }
            }
        }

        private DateTime? _fDelauddate;
        public DateTime? Delauddate
        {
            get { return _fDelauddate; }
            set
            {
                if (_fDelauddate != value)
                {
                    Modify();
                    _fDelauddate = value;
                }
            }
        }

        private int? _fDelauddelrecno;
        public int? Delauddelrecno
        {
            get { return _fDelauddelrecno; }
            set
            {
                if (_fDelauddelrecno != value)
                {
                    Modify();
                    _fDelauddelrecno = value;
                }
            }
        }

        private string _fDelaudfrom;
        public string Delaudfrom
        {
            get { return _fDelaudfrom; }
            set
            {
                if (_fDelaudfrom != value)
                {
                    Modify();
                    _fDelaudfrom = value;
                }
            }
        }

        private int? _fDelaudgrpno;
        public int? Delaudgrpno
        {
            get { return _fDelaudgrpno; }
            set
            {
                if (_fDelaudgrpno != value)
                {
                    Modify();
                    _fDelaudgrpno = value;
                }
            }
        }

        private string _fDelaudtime;
        public string Delaudtime
        {
            get { return _fDelaudtime; }
            set
            {
                if (_fDelaudtime != value)
                {
                    Modify();
                    _fDelaudtime = value;
                }
            }
        }

        private string _fDelaudto;
        public string Delaudto
        {
            get { return _fDelaudto; }
            set
            {
                if (_fDelaudto != value)
                {
                    Modify();
                    _fDelaudto = value;
                }
            }
        }

        private int? _fDelaudtyp;
        public int? Delaudtyp
        {
            get { return _fDelaudtyp; }
            set
            {
                if (_fDelaudtyp != value)
                {
                    Modify();
                    _fDelaudtyp = value;
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

        private int? _fDprtoaction;
        public int? Dprtoaction
        {
            get { return _fDprtoaction; }
            set
            {
                if (_fDprtoaction != value)
                {
                    Modify();
                    _fDprtoaction = value;
                }
            }
        }

        private string _fFormname;
        /// <summary>
        /// This field can be used to indicate the actual form that called a library. This way one can determine the user process that triggered the audit, regardless of what library the code resides in. NOTE: the formname will not match the formnumber (DelAudit.formno);  The formno is the actual writer of the audit and will always be populated, the formname is the form that called the library - this will be blank by default;  the developer must pass this information through; [Pass an audit type of -99;  the data is the Alpha formname]
        /// </summary>
        public string Formname
        {
            get { return _fFormname; }
            set
            {
                if (_fFormname != value)
                {
                    Modify();
                    _fFormname = value;
                }
            }
        }

        private int? _fFormno;
        public int? Formno
        {
            get { return _fFormno; }
            set
            {
                if (_fFormno != value)
                {
                    Modify();
                    _fFormno = value;
                }
            }
        }

        private int? _fLogonno;
        public int? Logonno
        {
            get { return _fLogonno; }
            set
            {
                if (_fLogonno != value)
                {
                    Modify();
                    _fLogonno = value;
                }
            }
        }

        public override int Key
        {
            get { return Delaudrecno; }
            set { Delaudrecno = value; }
        }

        public override string KeyAsString { get { return Key.ToString(CultureInfo.InvariantCulture); } }


        public override DelAudit Clone()
        {
            var obj = new DelAudit
                {
                    Delaudrecno = Delaudrecno,
                    Delauddate = Delauddate,
                    Delauddelrecno = Delauddelrecno,
                    Delaudfrom = Delaudfrom,
                    Delaudgrpno = Delaudgrpno,
                    Delaudtime = Delaudtime,
                    Delaudto = Delaudto,
                    Delaudtyp = Delaudtyp,
                    Dprrecno = Dprrecno,
                    Dprtoaction = Dprtoaction,
                    Formname = Formname,
                    Formno = Formno,
                    Logonno = Logonno,
                };

            return obj;
        }

        public static class FieldNames
        {
// ReSharper disable InconsistentNaming
            public const string  DELAUDRECNO = "DELAUDRECNO";
            public const string  DELAUDDATE = "DELAUDDATE";
            public const string  DELAUDDELRECNO = "DELAUDDELRECNO";
            public const string  DELAUDFROM = "DELAUDFROM";
            public const string  DELAUDGRPNO = "DELAUDGRPNO";
            public const string  DELAUDTIME = "DELAUDTIME";
            public const string  DELAUDTO = "DELAUDTO";
            public const string  DELAUDTYP = "DELAUDTYP";
            public const string  DPRRECNO = "DPRRECNO";
            public const string  DPRTOACTION = "DPRTOACTION";
            public const string  FORMNAME = "FORMNAME";
            public const string  FORMNO = "FORMNO";
            public const string  LOGONNO = "LOGONNO";
 // ReSharper restore InconsistentNaming
        }


    }

}
