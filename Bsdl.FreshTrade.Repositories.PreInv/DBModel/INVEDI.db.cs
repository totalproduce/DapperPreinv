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
    /// Entity for the PREINVTEMP_INVEDI table
    /// </summary>
    public partial class INVEDI : BaseDbModel<INVEDI, string>
    {
#region tableDefs

       public static List<EntityPropDef> GetPropDefs() {
         var result = new List<EntityPropDef>();

//EntityPropDef(string propName, string columnName, bool isKey, bool isNullable, string refEntityName, PropertyInfo keyPropInfo,
//            int size, int? prec, int? scale)




         result.Add(new EntityPropDef(
         PropertyHelper <INVEDI>.GetProperty(x => x.Companyname),
         "COMPANYNAME", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         40,       // int size   
                  null, // int? prec
                   
         null // int? Scale
         ,
         typeof(INVEDI)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <INVEDI>.GetProperty(x => x.Edifile),
         "EDIFILE", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         12,       // int size   
                  null, // int? prec
                   
         null // int? Scale
         ,
         typeof(INVEDI)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <INVEDI>.GetProperty(x => x.Ehheadid),
         "EHHEADID", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  10, // int? prec
                           0  // int? Scale
         ,
         typeof(INVEDI)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <INVEDI>.GetProperty(x => x.Extractsessionid),
         "EXTRACTSESSIONID", // columnName
         false,                    //isKey
         false, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  10, // int? prec
                           0  // int? Scale
         ,
         typeof(INVEDI)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <INVEDI>.GetProperty(x => x.Fileno),
         "FILENO", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  10, // int? prec
                           0  // int? Scale
         ,
         typeof(INVEDI)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <INVEDI>.GetProperty(x => x.Hofclarecno),
         "HOFCLARECNO", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  10, // int? prec
                           0  // int? Scale
         ,
         typeof(INVEDI)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <INVEDI>.GetProperty(x => x.Hofcstcode),
         "HOFCSTCODE", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         8,       // int size   
                  null, // int? prec
                   
         null // int? Scale
         ,
         typeof(INVEDI)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <INVEDI>.GetProperty(x => x.Hofcstname),
         "HOFCSTNAME", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         40,       // int size   
                  null, // int? prec
                   
         null // int? Scale
         ,
         typeof(INVEDI)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <INVEDI>.GetProperty(x => x.Newfile),
         "NEWFILE", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  1, // int? prec
                           0  // int? Scale
         ,
         typeof(INVEDI)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <INVEDI>.GetProperty(x => x.Newtransref),
         "NEWTRANSREF", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  1, // int? prec
                           0  // int? Scale
         ,
         typeof(INVEDI)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <INVEDI>.GetProperty(x => x.Prcglbrecno),
         "PRCGLBRECNO", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  10, // int? prec
                           0  // int? Scale
         ,
         typeof(INVEDI)
         ));
         return result; 
       }

#endregion     
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

        private string _fEdifile;
        public string Edifile
        {
            get { return _fEdifile; }
            set
            {
                if (_fEdifile != value)
                {
                    Modify();
                    _fEdifile = value;
                }
            }
        }

        private int? _fEhheadid;
        public int? Ehheadid
        {
            get { return _fEhheadid; }
            set
            {
                if (_fEhheadid != value)
                {
                    Modify();
                    _fEhheadid = value;
                }
            }
        }

        private int _fExtractsessionid;
        public int Extractsessionid
        {
            get { return _fExtractsessionid; }
            set
            {
                if (_fExtractsessionid != value)
                {
                    Modify();
                    _fExtractsessionid = value;
                }
            }
        }

        private int? _fFileno;
        public int? Fileno
        {
            get { return _fFileno; }
            set
            {
                if (_fFileno != value)
                {
                    Modify();
                    _fFileno = value;
                }
            }
        }

        private int? _fHofclarecno;
        public int? Hofclarecno
        {
            get { return _fHofclarecno; }
            set
            {
                if (_fHofclarecno != value)
                {
                    Modify();
                    _fHofclarecno = value;
                }
            }
        }

        private string _fHofcstcode;
        public string Hofcstcode
        {
            get { return _fHofcstcode; }
            set
            {
                if (_fHofcstcode != value)
                {
                    Modify();
                    _fHofcstcode = value;
                }
            }
        }

        private string _fHofcstname;
        public string Hofcstname
        {
            get { return _fHofcstname; }
            set
            {
                if (_fHofcstname != value)
                {
                    Modify();
                    _fHofcstname = value;
                }
            }
        }

        private short? _fNewfile;
        public short? Newfile
        {
            get { return _fNewfile; }
            set
            {
                if (_fNewfile != value)
                {
                    Modify();
                    _fNewfile = value;
                }
            }
        }

        private short? _fNewtransref;
        public short? Newtransref
        {
            get { return _fNewtransref; }
            set
            {
                if (_fNewtransref != value)
                {
                    Modify();
                    _fNewtransref = value;
                }
            }
        }

        private int? _fPrcglbrecno;
        public int? Prcglbrecno
        {
            get { return _fPrcglbrecno; }
            set
            {
                if (_fPrcglbrecno != value)
                {
                    Modify();
                    _fPrcglbrecno = value;
                }
            }
        }


        public override INVEDI Clone()
        {
            var obj = new INVEDI
                {
                    Companyname = Companyname,
                    Edifile = Edifile,
                    Ehheadid = Ehheadid,
                    Extractsessionid = Extractsessionid,
                    Fileno = Fileno,
                    Hofclarecno = Hofclarecno,
                    Hofcstcode = Hofcstcode,
                    Hofcstname = Hofcstname,
                    Newfile = Newfile,
                    Newtransref = Newtransref,
                    Prcglbrecno = Prcglbrecno,
                };

            return obj;
        }

        public static class FieldNames
        {
// ReSharper disable InconsistentNaming
            public const string  COMPANYNAME = "COMPANYNAME";
            public const string  EDIFILE = "EDIFILE";
            public const string  EHHEADID = "EHHEADID";
            public const string  EXTRACTSESSIONID = "EXTRACTSESSIONID";
            public const string  FILENO = "FILENO";
            public const string  HOFCLARECNO = "HOFCLARECNO";
            public const string  HOFCSTCODE = "HOFCSTCODE";
            public const string  HOFCSTNAME = "HOFCSTNAME";
            public const string  NEWFILE = "NEWFILE";
            public const string  NEWTRANSREF = "NEWTRANSREF";
            public const string  PRCGLBRECNO = "PRCGLBRECNO";
 // ReSharper restore InconsistentNaming
        }


    }

}
