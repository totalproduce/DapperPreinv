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
    /// Entity for the LOGONS table
    /// </summary>
    public partial class Logons : BaseDbModel<Logons, string>
    {
#region tableDefs

       public static List<EntityPropDef> GetPropDefs() {
         var result = new List<EntityPropDef>();

//EntityPropDef(string propName, string columnName, bool isKey, bool isNullable, string refEntityName, PropertyInfo keyPropInfo,
//            int size, int? prec, int? scale)



         result.Add(new EntityPropDef(
         PropertyHelper <Logons>.GetProperty(x => x.Logonname),
         "LOGONNAME", // columnName
         true,                    //isKey
         false, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         40,       // int size   
           
         null, // int? prec
                    
         null // int? Scale
         ,
         typeof(Logons)
       ));


         result.Add(new EntityPropDef(
         PropertyHelper <Logons>.GetProperty(x => x.Active),
         "ACTIVE", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  1, // int? prec
                           0  // int? Scale
         ,
         typeof(Logons)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <Logons>.GetProperty(x => x.Authno),
         "AUTHNO", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  5, // int? prec
                           0  // int? Scale
         ,
         typeof(Logons)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <Logons>.GetProperty(x => x.Availtomkthandheld),
         "AVAILTOMKTHANDHELD", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  1, // int? prec
                           0  // int? Scale
         ,
         typeof(Logons)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <Logons>.GetProperty(x => x.Canseeallsups),
         "CANSEEALLSUPS", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  1, // int? prec
                           0  // int? Scale
         ,
         typeof(Logons)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <Logons>.GetProperty(x => x.Companyno),
         "COMPANYNO", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  5, // int? prec
                           0  // int? Scale
         ,
         typeof(Logons)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <Logons>.GetProperty(x => x.Dept),
         "DEPT", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         30,       // int size   
                  null, // int? prec
                   
         null // int? Scale
         ,
         typeof(Logons)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <Logons>.GetProperty(x => x.Emailaddress),
         "EMAILADDRESS", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         40,       // int size   
                  null, // int? prec
                   
         null // int? Scale
         ,
         typeof(Logons)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <Logons>.GetProperty(x => x.Fax),
         "FAX", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         30,       // int size   
                  null, // int? prec
                   
         null // int? Scale
         ,
         typeof(Logons)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <Logons>.GetProperty(x => x.HandheldmenusMenuid),
         "HANDHELDMENUS_MENUID", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  5, // int? prec
                           0  // int? Scale
         ,
         typeof(Logons)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <Logons>.GetProperty(x => x.Handheldpassword),
         "HANDHELDPASSWORD", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         35,       // int size   
                  null, // int? prec
                   
         null // int? Scale
         ,
         typeof(Logons)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <Logons>.GetProperty(x => x.Langno),
         "LANGNO", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  5, // int? prec
                           0  // int? Scale
         ,
         typeof(Logons)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <Logons>.GetProperty(x => x.Loggrpno),
         "LOGGRPNO", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  5, // int? prec
                           0  // int? Scale
         ,
         typeof(Logons)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <Logons>.GetProperty(x => x.Logonno),
         "LOGONNO", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  5, // int? prec
                           0  // int? Scale
         ,
         typeof(Logons)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <Logons>.GetProperty(x => x.Phone),
         "PHONE", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         30,       // int size   
                  null, // int? prec
                   
         null // int? Scale
         ,
         typeof(Logons)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <Logons>.GetProperty(x => x.Usergroupno),
         "USERGROUPNO", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  5, // int? prec
                           0  // int? Scale
         ,
         typeof(Logons)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <Logons>.GetProperty(x => x.Username),
         "USERNAME", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         50,       // int size   
                  null, // int? prec
                   
         null // int? Scale
         ,
         typeof(Logons)
         ));
         return result; 
       }

#endregion     
        private string _fLogonname;
        public string Logonname
        {
            get { return _fLogonname; }
            set
            {
                var oldKey = Key;
                if (_fLogonname != value)
                {
                    Modify();
                    _fLogonname = value;
                    KeyChanged(oldKey);
                }
            }
        }

        private short? _fActive;
        public short? Active
        {
            get { return _fActive; }
            set
            {
                if (_fActive != value)
                {
                    Modify();
                    _fActive = value;
                }
            }
        }

        private int? _fAuthno;
        public int? Authno
        {
            get { return _fAuthno; }
            set
            {
                if (_fAuthno != value)
                {
                    Modify();
                    _fAuthno = value;
                }
            }
        }

        private short? _fAvailtomkthandheld;
        /// <summary>
        /// Can log onto Handheld
        /// </summary>
        public short? Availtomkthandheld
        {
            get { return _fAvailtomkthandheld; }
            set
            {
                if (_fAvailtomkthandheld != value)
                {
                    Modify();
                    _fAvailtomkthandheld = value;
                }
            }
        }

        private short? _fCanseeallsups;
        public short? Canseeallsups
        {
            get { return _fCanseeallsups; }
            set
            {
                if (_fCanseeallsups != value)
                {
                    Modify();
                    _fCanseeallsups = value;
                }
            }
        }

        private int? _fCompanyno;
        public int? Companyno
        {
            get { return _fCompanyno; }
            set
            {
                if (_fCompanyno != value)
                {
                    Modify();
                    _fCompanyno = value;
                }
            }
        }

        private string _fDept;
        public string Dept
        {
            get { return _fDept; }
            set
            {
                if (_fDept != value)
                {
                    Modify();
                    _fDept = value;
                }
            }
        }

        private string _fEmailaddress;
        public string Emailaddress
        {
            get { return _fEmailaddress; }
            set
            {
                if (_fEmailaddress != value)
                {
                    Modify();
                    _fEmailaddress = value;
                }
            }
        }

        private string _fFax;
        public string Fax
        {
            get { return _fFax; }
            set
            {
                if (_fFax != value)
                {
                    Modify();
                    _fFax = value;
                }
            }
        }

        private int? _fHandheldmenusMenuid;
        public int? HandheldmenusMenuid
        {
            get { return _fHandheldmenusMenuid; }
            set
            {
                if (_fHandheldmenusMenuid != value)
                {
                    Modify();
                    _fHandheldmenusMenuid = value;
                }
            }
        }

        private string _fHandheldpassword;
        /// <summary>
        /// MD5 Encrypted password for handheld
        /// </summary>
        public string Handheldpassword
        {
            get { return _fHandheldpassword; }
            set
            {
                if (_fHandheldpassword != value)
                {
                    Modify();
                    _fHandheldpassword = value;
                }
            }
        }

        private int? _fLangno;
        public int? Langno
        {
            get { return _fLangno; }
            set
            {
                if (_fLangno != value)
                {
                    Modify();
                    _fLangno = value;
                }
            }
        }

        private int? _fLoggrpno;
        public int? Loggrpno
        {
            get { return _fLoggrpno; }
            set
            {
                if (_fLoggrpno != value)
                {
                    Modify();
                    _fLoggrpno = value;
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

        private string _fPhone;
        public string Phone
        {
            get { return _fPhone; }
            set
            {
                if (_fPhone != value)
                {
                    Modify();
                    _fPhone = value;
                }
            }
        }

        private int? _fUsergroupno;
        public int? Usergroupno
        {
            get { return _fUsergroupno; }
            set
            {
                if (_fUsergroupno != value)
                {
                    Modify();
                    _fUsergroupno = value;
                }
            }
        }

        private string _fUsername;
        public string Username
        {
            get { return _fUsername; }
            set
            {
                if (_fUsername != value)
                {
                    Modify();
                    _fUsername = value;
                }
            }
        }

        public override string Key
        {
            get { return Logonname; }
            set { Logonname = value; }
        }

        public override string KeyAsString { get { return Key; } }


        public override Logons Clone()
        {
            var obj = new Logons
                {
                    Logonname = Logonname,
                    Active = Active,
                    Authno = Authno,
                    Availtomkthandheld = Availtomkthandheld,
                    Canseeallsups = Canseeallsups,
                    Companyno = Companyno,
                    Dept = Dept,
                    Emailaddress = Emailaddress,
                    Fax = Fax,
                    HandheldmenusMenuid = HandheldmenusMenuid,
                    Handheldpassword = Handheldpassword,
                    Langno = Langno,
                    Loggrpno = Loggrpno,
                    Logonno = Logonno,
                    Phone = Phone,
                    Usergroupno = Usergroupno,
                    Username = Username,
                };

            return obj;
        }

        public static class FieldNames
        {
// ReSharper disable InconsistentNaming
            public const string  LOGONNAME = "LOGONNAME";
            public const string  ACTIVE = "ACTIVE";
            public const string  AUTHNO = "AUTHNO";
            public const string  AVAILTOMKTHANDHELD = "AVAILTOMKTHANDHELD";
            public const string  CANSEEALLSUPS = "CANSEEALLSUPS";
            public const string  COMPANYNO = "COMPANYNO";
            public const string  DEPT = "DEPT";
            public const string  EMAILADDRESS = "EMAILADDRESS";
            public const string  FAX = "FAX";
            public const string  HANDHELDMENUS_MENUID = "HANDHELDMENUS_MENUID";
            public const string  HANDHELDPASSWORD = "HANDHELDPASSWORD";
            public const string  LANGNO = "LANGNO";
            public const string  LOGGRPNO = "LOGGRPNO";
            public const string  LOGONNO = "LOGONNO";
            public const string  PHONE = "PHONE";
            public const string  USERGROUPNO = "USERGROUPNO";
            public const string  USERNAME = "USERNAME";
 // ReSharper restore InconsistentNaming
        }


    }

}
