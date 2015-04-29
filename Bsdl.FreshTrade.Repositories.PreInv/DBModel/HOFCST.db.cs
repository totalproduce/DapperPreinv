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
    /// Entity for the HOFCST table
    /// </summary>
    public partial class HOFCST : BaseDbModel<HOFCST, HOFCSTKey>
    {
#region tableDefs

       public static List<EntityPropDef> GetPropDefs() {
         var result = new List<EntityPropDef>();

//EntityPropDef(string propName, string columnName, bool isKey, bool isNullable, string refEntityName, PropertyInfo keyPropInfo,
//            int size, int? prec, int? scale)



         result.Add(new EntityPropDef(
         PropertyHelper <HOFCST>.GetProperty(x => x.Hofrecno),
         "HOFRECNO", // columnName
         true,                    //isKey
         false, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  10, // int? prec
                           0  // int? Scale
         ,
         typeof(HOFCST)
       ));

         result.Add(new EntityPropDef(
         PropertyHelper <HOFCST>.GetProperty(x => x.Currencycode),
         "CURRENCYCODE", // columnName
         true,                    //isKey
         false, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  5, // int? prec
                           0  // int? Scale
         ,
         typeof(HOFCST)
       ));

         result.Add(new EntityPropDef(
         PropertyHelper <HOFCST>.GetProperty(x => x.Saloffno),
         "SALOFFNO", // columnName
         true,                    //isKey
         false, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  5, // int? prec
                           0  // int? Scale
         ,
         typeof(HOFCST)
       ));


         result.Add(new EntityPropDef(
         PropertyHelper <HOFCST>.GetProperty(x => x.Accrecno),
         "ACCRECNO", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  10, // int? prec
                           0  // int? Scale
         ,
         typeof(HOFCST)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <HOFCST>.GetProperty(x => x.Hofinvtocstcode),
         "HOFINVTOCSTCODE", // columnName
         false,                    //isKey
         false, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  10, // int? prec
                           0  // int? Scale
         ,
         typeof(HOFCST)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <HOFCST>.GetProperty(x => x.Invsaloffno),
         "INVSALOFFNO", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  5, // int? prec
                           0  // int? Scale
         ,
         typeof(HOFCST)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <HOFCST>.GetProperty(x => x.Lstinvout),
         "LSTINVOUT", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  10, // int? prec
                           0  // int? Scale
         ,
         typeof(HOFCST)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <HOFCST>.GetProperty(x => x.Supplierref),
         "SUPPLIERREF", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         20,       // int size   
                  null, // int? prec
                   
         null // int? Scale
         ,
         typeof(HOFCST)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <HOFCST>.GetProperty(x => x.Suppref),
         "SUPPREF", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         8,       // int size   
                  null, // int? prec
                   
         null // int? Scale
         ,
         typeof(HOFCST)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <HOFCST>.GetProperty(x => x.Useuploadhof),
         "USEUPLOADHOF", // columnName
         false,                    //isKey
         false, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  1, // int? prec
                           0  // int? Scale
         ,
         typeof(HOFCST)
         ));
         return result; 
       }

#endregion     
        private int _fHofrecno;
        public int Hofrecno
        {
            get { return _fHofrecno; }
            set
            {
                var oldKey = Key;
                if (_fHofrecno != value)
                {
                    Modify();
                    _fHofrecno = value;
                    KeyChanged(oldKey);
                }
            }
        }

        private int _fCurrencycode;
        public int Currencycode
        {
            get { return _fCurrencycode; }
            set
            {
                var oldKey = Key;
                if (_fCurrencycode != value)
                {
                    Modify();
                    _fCurrencycode = value;
                    KeyChanged(oldKey);
                }
            }
        }

        private int _fSaloffno;
        public int Saloffno
        {
            get { return _fSaloffno; }
            set
            {
                var oldKey = Key;
                if (_fSaloffno != value)
                {
                    Modify();
                    _fSaloffno = value;
                    KeyChanged(oldKey);
                }
            }
        }

        private int? _fAccrecno;
        public int? Accrecno
        {
            get { return _fAccrecno; }
            set
            {
                if (_fAccrecno != value)
                {
                    Modify();
                    _fAccrecno = value;
                }
            }
        }

        private int _fHofinvtocstcode;
        public int Hofinvtocstcode
        {
            get { return _fHofinvtocstcode; }
            set
            {
                if (_fHofinvtocstcode != value)
                {
                    Modify();
                    _fHofinvtocstcode = value;
                }
            }
        }

        private int? _fInvsaloffno;
        public int? Invsaloffno
        {
            get { return _fInvsaloffno; }
            set
            {
                if (_fInvsaloffno != value)
                {
                    Modify();
                    _fInvsaloffno = value;
                }
            }
        }

        private int? _fLstinvout;
        public int? Lstinvout
        {
            get { return _fLstinvout; }
            set
            {
                if (_fLstinvout != value)
                {
                    Modify();
                    _fLstinvout = value;
                }
            }
        }

        private string _fSupplierref;
        public string Supplierref
        {
            get { return _fSupplierref; }
            set
            {
                if (_fSupplierref != value)
                {
                    Modify();
                    _fSupplierref = value;
                }
            }
        }

        private string _fSuppref;
        public string Suppref
        {
            get { return _fSuppref; }
            set
            {
                if (_fSuppref != value)
                {
                    Modify();
                    _fSuppref = value;
                }
            }
        }

        private short _fUseuploadhof;
        public short Useuploadhof
        {
            get { return _fUseuploadhof; }
            set
            {
                if (_fUseuploadhof != value)
                {
                    Modify();
                    _fUseuploadhof = value;
                }
            }
        }

        public override HOFCSTKey Key
        {
            get
            {
                return new HOFCSTKey { Hofrecno = Hofrecno, Currencycode = Currencycode, Saloffno = Saloffno };
            }
            set
            {
                if (value == null)
                    throw new ArgumentNullException("value", "Entity key can not be null.");
                Hofrecno = value.Hofrecno;
                Currencycode = value.Currencycode;
                Saloffno = value.Saloffno;
            }
        }

        public override string KeyAsString { get { return Key.AsString; } }


        public override HOFCST Clone()
        {
            var obj = new HOFCST
                {
                    Hofrecno = Hofrecno,
                    Currencycode = Currencycode,
                    Saloffno = Saloffno,
                    Accrecno = Accrecno,
                    Hofinvtocstcode = Hofinvtocstcode,
                    Invsaloffno = Invsaloffno,
                    Lstinvout = Lstinvout,
                    Supplierref = Supplierref,
                    Suppref = Suppref,
                    Useuploadhof = Useuploadhof,
                };

            return obj;
        }

        public static class FieldNames
        {
// ReSharper disable InconsistentNaming
            public const string  HOFRECNO = "HOFRECNO";
            public const string  CURRENCYCODE = "CURRENCYCODE";
            public const string  SALOFFNO = "SALOFFNO";
            public const string  ACCRECNO = "ACCRECNO";
            public const string  HOFINVTOCSTCODE = "HOFINVTOCSTCODE";
            public const string  INVSALOFFNO = "INVSALOFFNO";
            public const string  LSTINVOUT = "LSTINVOUT";
            public const string  SUPPLIERREF = "SUPPLIERREF";
            public const string  SUPPREF = "SUPPREF";
            public const string  USEUPLOADHOF = "USEUPLOADHOF";
 // ReSharper restore InconsistentNaming
        }


    }

    /// <summary>
    /// Define type of the primary key property of the HOFCST entity.
    /// </summary>
    public class HOFCSTKey : ICompositeKey
    {
        public int Hofrecno { get; set; }
        public int Currencycode { get; set; }
        public int Saloffno { get; set; }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != GetType()) return false;
            return Equals((HOFCSTKey)obj);
        }

        protected bool Equals(HOFCSTKey other)
        {
            return Hofrecno == other.Hofrecno && Currencycode == other.Currencycode && Saloffno == other.Saloffno;
        }

        public override int GetHashCode()
        {
            unchecked
            {
                int hashCode = 0;
                hashCode = (hashCode * 397) ^ (Hofrecno).GetHashCode();
                hashCode = (hashCode * 397) ^ (Currencycode).GetHashCode();
                hashCode = (hashCode * 397) ^ (Saloffno).GetHashCode();
                return hashCode;
            }
        }

        public static HOFCSTKey Parse(string key)
        {
            var parts = key.Split('|');
            return new HOFCSTKey
            {
                Hofrecno = int.Parse(parts[0]),
                Currencycode = int.Parse(parts[1]),
                Saloffno = int.Parse(parts[2]),
            };
        }

        public string AsString
        {
            get { return Hofrecno.ToString() + "|" + Currencycode.ToString() + "|" + Saloffno.ToString(); }
        }

        public override string ToString()
        {
            return AsString;
        }

    }

}
