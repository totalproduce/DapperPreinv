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
    /// Entity for the AUDITRECORD table
    /// </summary>
    public partial class AuditRecord : BaseDbModel<AuditRecord, int>
    {
#region tableDefs

       public static List<EntityPropDef> GetPropDefs() {
         var result = new List<EntityPropDef>();

//EntityPropDef(string propName, string columnName, bool isKey, bool isNullable, string refEntityName, PropertyInfo keyPropInfo,
//            int size, int? prec, int? scale)



         result.Add(new EntityPropDef(
         PropertyHelper <AuditRecord>.GetProperty(x => x.Auditrecordno),
         "AUDITRECORDNO", // columnName
         true,                    //isKey
         false, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  10, // int? prec
                           0  // int? Scale
         ,
         typeof(AuditRecord)
       ));


         result.Add(new EntityPropDef(
         PropertyHelper <AuditRecord>.GetProperty(x => x.Auditactionno),
         "AUDITACTIONNO", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  5, // int? prec
                           0  // int? Scale
         ,
         typeof(AuditRecord)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <AuditRecord>.GetProperty(x => x.Auditchangedfrom),
         "AUDITCHANGEDFROM", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         50,       // int size   
                  null, // int? prec
                   
         null // int? Scale
         ,
         typeof(AuditRecord)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <AuditRecord>.GetProperty(x => x.Auditchangedto),
         "AUDITCHANGEDTO", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         50,       // int size   
                  null, // int? prec
                   
         null // int? Scale
         ,
         typeof(AuditRecord)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <AuditRecord>.GetProperty(x => x.Auditdate),
         "AUDITDATE", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  null, // int? prec
                   
         null // int? Scale
         ,
         typeof(AuditRecord)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <AuditRecord>.GetProperty(x => x.Auditdoneby),
         "AUDITDONEBY", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  5, // int? prec
                           0  // int? Scale
         ,
         typeof(AuditRecord)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <AuditRecord>.GetProperty(x => x.Auditformname),
         "AUDITFORMNAME", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         20,       // int size   
                  null, // int? prec
                   
         null // int? Scale
         ,
         typeof(AuditRecord)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <AuditRecord>.GetProperty(x => x.Auditformno),
         "AUDITFORMNO", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  10, // int? prec
                           0  // int? Scale
         ,
         typeof(AuditRecord)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <AuditRecord>.GetProperty(x => x.Auditlinkrecno1),
         "AUDITLINKRECNO1", // columnName
         false,                    //isKey
         false, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  10, // int? prec
                           0  // int? Scale
         ,
         typeof(AuditRecord)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <AuditRecord>.GetProperty(x => x.Auditlinkrecno2),
         "AUDITLINKRECNO2", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  10, // int? prec
                           0  // int? Scale
         ,
         typeof(AuditRecord)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <AuditRecord>.GetProperty(x => x.Auditlinkrecno3),
         "AUDITLINKRECNO3", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  10, // int? prec
                           0  // int? Scale
         ,
         typeof(AuditRecord)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <AuditRecord>.GetProperty(x => x.Auditrdtuser),
         "AUDITRDTUSER", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         20,       // int size   
                  null, // int? prec
                   
         null // int? Scale
         ,
         typeof(AuditRecord)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <AuditRecord>.GetProperty(x => x.Audittypeno),
         "AUDITTYPENO", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  5, // int? prec
                           0  // int? Scale
         ,
         typeof(AuditRecord)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <AuditRecord>.GetProperty(x => x.Lherecno),
         "LHERECNO", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  10, // int? prec
                           0  // int? Scale
         ,
         typeof(AuditRecord)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <AuditRecord>.GetProperty(x => x.Lititeno),
         "LITITENO", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  10, // int? prec
                           0  // int? Scale
         ,
         typeof(AuditRecord)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <AuditRecord>.GetProperty(x => x.Porno),
         "PORNO", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  10, // int? prec
                           0  // int? Scale
         ,
         typeof(AuditRecord)
         ));
         return result; 
       }

#endregion     
        private int _fAuditrecordno;
        public int Auditrecordno
        {
            get { return _fAuditrecordno; }
            set
            {
                var oldKey = Key;
                if (_fAuditrecordno != value)
                {
                    Modify();
                    _fAuditrecordno = value;
                    KeyChanged(oldKey);
                }
            }
        }

        private int? _fAuditactionno;
        public int? Auditactionno
        {
            get { return _fAuditactionno; }
            set
            {
                if (_fAuditactionno != value)
                {
                    Modify();
                    _fAuditactionno = value;
                }
            }
        }

        private string _fAuditchangedfrom;
        public string Auditchangedfrom
        {
            get { return _fAuditchangedfrom; }
            set
            {
                if (_fAuditchangedfrom != value)
                {
                    Modify();
                    _fAuditchangedfrom = value;
                }
            }
        }

        private string _fAuditchangedto;
        public string Auditchangedto
        {
            get { return _fAuditchangedto; }
            set
            {
                if (_fAuditchangedto != value)
                {
                    Modify();
                    _fAuditchangedto = value;
                }
            }
        }

        private DateTime? _fAuditdate;
        public DateTime? Auditdate
        {
            get { return _fAuditdate; }
            set
            {
                if (_fAuditdate != value)
                {
                    Modify();
                    _fAuditdate = value;
                }
            }
        }

        private int? _fAuditdoneby;
        public int? Auditdoneby
        {
            get { return _fAuditdoneby; }
            set
            {
                if (_fAuditdoneby != value)
                {
                    Modify();
                    _fAuditdoneby = value;
                }
            }
        }

        private string _fAuditformname;
        public string Auditformname
        {
            get { return _fAuditformname; }
            set
            {
                if (_fAuditformname != value)
                {
                    Modify();
                    _fAuditformname = value;
                }
            }
        }

        private int? _fAuditformno;
        public int? Auditformno
        {
            get { return _fAuditformno; }
            set
            {
                if (_fAuditformno != value)
                {
                    Modify();
                    _fAuditformno = value;
                }
            }
        }

        private int _fAuditlinkrecno1;
        public int Auditlinkrecno1
        {
            get { return _fAuditlinkrecno1; }
            set
            {
                if (_fAuditlinkrecno1 != value)
                {
                    Modify();
                    _fAuditlinkrecno1 = value;
                }
            }
        }

        private int? _fAuditlinkrecno2;
        public int? Auditlinkrecno2
        {
            get { return _fAuditlinkrecno2; }
            set
            {
                if (_fAuditlinkrecno2 != value)
                {
                    Modify();
                    _fAuditlinkrecno2 = value;
                }
            }
        }

        private int? _fAuditlinkrecno3;
        public int? Auditlinkrecno3
        {
            get { return _fAuditlinkrecno3; }
            set
            {
                if (_fAuditlinkrecno3 != value)
                {
                    Modify();
                    _fAuditlinkrecno3 = value;
                }
            }
        }

        private string _fAuditrdtuser;
        public string Auditrdtuser
        {
            get { return _fAuditrdtuser; }
            set
            {
                if (_fAuditrdtuser != value)
                {
                    Modify();
                    _fAuditrdtuser = value;
                }
            }
        }

        private int? _fAudittypeno;
        public int? Audittypeno
        {
            get { return _fAudittypeno; }
            set
            {
                if (_fAudittypeno != value)
                {
                    Modify();
                    _fAudittypeno = value;
                }
            }
        }

        private int? _fLherecno;
        public int? Lherecno
        {
            get { return _fLherecno; }
            set
            {
                if (_fLherecno != value)
                {
                    Modify();
                    _fLherecno = value;
                }
            }
        }

        private int? _fLititeno;
        public int? Lititeno
        {
            get { return _fLititeno; }
            set
            {
                if (_fLititeno != value)
                {
                    Modify();
                    _fLititeno = value;
                }
            }
        }

        private int? _fPorno;
        public int? Porno
        {
            get { return _fPorno; }
            set
            {
                if (_fPorno != value)
                {
                    Modify();
                    _fPorno = value;
                }
            }
        }

        public override int Key
        {
            get { return Auditrecordno; }
            set { Auditrecordno = value; }
        }

        public override string KeyAsString { get { return Key.ToString(CultureInfo.InvariantCulture); } }


        public override AuditRecord Clone()
        {
            var obj = new AuditRecord
                {
                    Auditrecordno = Auditrecordno,
                    Auditactionno = Auditactionno,
                    Auditchangedfrom = Auditchangedfrom,
                    Auditchangedto = Auditchangedto,
                    Auditdate = Auditdate,
                    Auditdoneby = Auditdoneby,
                    Auditformname = Auditformname,
                    Auditformno = Auditformno,
                    Auditlinkrecno1 = Auditlinkrecno1,
                    Auditlinkrecno2 = Auditlinkrecno2,
                    Auditlinkrecno3 = Auditlinkrecno3,
                    Auditrdtuser = Auditrdtuser,
                    Audittypeno = Audittypeno,
                    Lherecno = Lherecno,
                    Lititeno = Lititeno,
                    Porno = Porno,
                };

            return obj;
        }

        public static class FieldNames
        {
// ReSharper disable InconsistentNaming
            public const string  AUDITRECORDNO = "AUDITRECORDNO";
            public const string  AUDITACTIONNO = "AUDITACTIONNO";
            public const string  AUDITCHANGEDFROM = "AUDITCHANGEDFROM";
            public const string  AUDITCHANGEDTO = "AUDITCHANGEDTO";
            public const string  AUDITDATE = "AUDITDATE";
            public const string  AUDITDONEBY = "AUDITDONEBY";
            public const string  AUDITFORMNAME = "AUDITFORMNAME";
            public const string  AUDITFORMNO = "AUDITFORMNO";
            public const string  AUDITLINKRECNO1 = "AUDITLINKRECNO1";
            public const string  AUDITLINKRECNO2 = "AUDITLINKRECNO2";
            public const string  AUDITLINKRECNO3 = "AUDITLINKRECNO3";
            public const string  AUDITRDTUSER = "AUDITRDTUSER";
            public const string  AUDITTYPENO = "AUDITTYPENO";
            public const string  LHERECNO = "LHERECNO";
            public const string  LITITENO = "LITITENO";
            public const string  PORNO = "PORNO";
 // ReSharper restore InconsistentNaming
        }


    }

}
