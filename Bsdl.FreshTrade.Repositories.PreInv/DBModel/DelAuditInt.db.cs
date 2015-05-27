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
    /// Entity for the DELAUDIT_INT table
    /// </summary>
    public partial class DelAuditInt : BaseDbModel<DelAuditInt, int>
    {
#region tableDefs

       public static List<EntityPropDef> GetPropDefs() {
         var result = new List<EntityPropDef>();

//EntityPropDef(string propName, string columnName, bool isKey, bool isNullable, string refEntityName, PropertyInfo keyPropInfo,
//            int size, int? prec, int? scale)



         result.Add(new EntityPropDef(
         PropertyHelper <DelAuditInt>.GetProperty(x => x.Delaudintrecno),
         "DELAUDINTRECNO", // columnName
         true,                    //isKey
         false, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  10, // int? prec
                           0  // int? Scale
         ,
         typeof(DelAuditInt)
       ));


         result.Add(new EntityPropDef(
         PropertyHelper <DelAuditInt>.GetProperty(x => x.Delaudintdate),
         "DELAUDINTDATE", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  null, // int? prec
                   
         null // int? Scale
         ,
         typeof(DelAuditInt)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <DelAuditInt>.GetProperty(x => x.Delaudintdelrecno),
         "DELAUDINTDELRECNO", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  10, // int? prec
                           0  // int? Scale
         ,
         typeof(DelAuditInt)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <DelAuditInt>.GetProperty(x => x.Delaudintfrom),
         "DELAUDINTFROM", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         255,       // int size   
                  null, // int? prec
                   
         null // int? Scale
         ,
         typeof(DelAuditInt)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <DelAuditInt>.GetProperty(x => x.Delaudintgrpno),
         "DELAUDINTGRPNO", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  10, // int? prec
                           0  // int? Scale
         ,
         typeof(DelAuditInt)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <DelAuditInt>.GetProperty(x => x.Delaudintto),
         "DELAUDINTTO", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         255,       // int size   
                  null, // int? prec
                   
         null // int? Scale
         ,
         typeof(DelAuditInt)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <DelAuditInt>.GetProperty(x => x.Delaudinttyp),
         "DELAUDINTTYP", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  5, // int? prec
                           0  // int? Scale
         ,
         typeof(DelAuditInt)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <DelAuditInt>.GetProperty(x => x.Dprrecnoint),
         "DPRRECNOINT", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  10, // int? prec
                           0  // int? Scale
         ,
         typeof(DelAuditInt)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <DelAuditInt>.GetProperty(x => x.Formintno),
         "FORMINTNO", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  5, // int? prec
                           0  // int? Scale
         ,
         typeof(DelAuditInt)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <DelAuditInt>.GetProperty(x => x.Logonintno),
         "LOGONINTNO", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  5, // int? prec
                           0  // int? Scale
         ,
         typeof(DelAuditInt)
         ));
         return result; 
       }

#endregion     
        private int _fDelaudintrecno;
        public int Delaudintrecno
        {
            get { return _fDelaudintrecno; }
            set
            {
                var oldKey = Key;
                if (_fDelaudintrecno != value)
                {
                    Modify();
                    _fDelaudintrecno = value;
                    KeyChanged(oldKey);
                }
            }
        }

        private DateTime? _fDelaudintdate;
        public DateTime? Delaudintdate
        {
            get { return _fDelaudintdate; }
            set
            {
                if (_fDelaudintdate != value)
                {
                    Modify();
                    _fDelaudintdate = value;
                }
            }
        }

        private int? _fDelaudintdelrecno;
        public int? Delaudintdelrecno
        {
            get { return _fDelaudintdelrecno; }
            set
            {
                if (_fDelaudintdelrecno != value)
                {
                    Modify();
                    _fDelaudintdelrecno = value;
                }
            }
        }

        private string _fDelaudintfrom;
        public string Delaudintfrom
        {
            get { return _fDelaudintfrom; }
            set
            {
                if (_fDelaudintfrom != value)
                {
                    Modify();
                    _fDelaudintfrom = value;
                }
            }
        }

        private int? _fDelaudintgrpno;
        public int? Delaudintgrpno
        {
            get { return _fDelaudintgrpno; }
            set
            {
                if (_fDelaudintgrpno != value)
                {
                    Modify();
                    _fDelaudintgrpno = value;
                }
            }
        }

        private string _fDelaudintto;
        public string Delaudintto
        {
            get { return _fDelaudintto; }
            set
            {
                if (_fDelaudintto != value)
                {
                    Modify();
                    _fDelaudintto = value;
                }
            }
        }

        private int? _fDelaudinttyp;
        public int? Delaudinttyp
        {
            get { return _fDelaudinttyp; }
            set
            {
                if (_fDelaudinttyp != value)
                {
                    Modify();
                    _fDelaudinttyp = value;
                }
            }
        }

        private int? _fDprrecnoint;
        public int? Dprrecnoint
        {
            get { return _fDprrecnoint; }
            set
            {
                if (_fDprrecnoint != value)
                {
                    Modify();
                    _fDprrecnoint = value;
                }
            }
        }

        private int? _fFormintno;
        public int? Formintno
        {
            get { return _fFormintno; }
            set
            {
                if (_fFormintno != value)
                {
                    Modify();
                    _fFormintno = value;
                }
            }
        }

        private int? _fLogonintno;
        public int? Logonintno
        {
            get { return _fLogonintno; }
            set
            {
                if (_fLogonintno != value)
                {
                    Modify();
                    _fLogonintno = value;
                }
            }
        }

        public override int Key
        {
            get { return Delaudintrecno; }
            set { Delaudintrecno = value; }
        }

        public override string KeyAsString { get { return Key.ToString(CultureInfo.InvariantCulture); } }


        public override DelAuditInt Clone()
        {
            var obj = new DelAuditInt
                {
                    Delaudintrecno = Delaudintrecno,
                    Delaudintdate = Delaudintdate,
                    Delaudintdelrecno = Delaudintdelrecno,
                    Delaudintfrom = Delaudintfrom,
                    Delaudintgrpno = Delaudintgrpno,
                    Delaudintto = Delaudintto,
                    Delaudinttyp = Delaudinttyp,
                    Dprrecnoint = Dprrecnoint,
                    Formintno = Formintno,
                    Logonintno = Logonintno,
                };

            return obj;
        }

        public static class FieldNames
        {
// ReSharper disable InconsistentNaming
            public const string  DELAUDINTRECNO = "DELAUDINTRECNO";
            public const string  DELAUDINTDATE = "DELAUDINTDATE";
            public const string  DELAUDINTDELRECNO = "DELAUDINTDELRECNO";
            public const string  DELAUDINTFROM = "DELAUDINTFROM";
            public const string  DELAUDINTGRPNO = "DELAUDINTGRPNO";
            public const string  DELAUDINTTO = "DELAUDINTTO";
            public const string  DELAUDINTTYP = "DELAUDINTTYP";
            public const string  DPRRECNOINT = "DPRRECNOINT";
            public const string  FORMINTNO = "FORMINTNO";
            public const string  LOGONINTNO = "LOGONINTNO";
 // ReSharper restore InconsistentNaming
        }


    }

}
