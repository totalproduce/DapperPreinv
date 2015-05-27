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
    /// Entity for the ACCVAT table
    /// </summary>
    public partial class AccVAT : BaseDbModel<AccVAT, AccVATKey>
    {
#region tableDefs

       public static List<EntityPropDef> GetPropDefs() {
         var result = new List<EntityPropDef>();

//EntityPropDef(string propName, string columnName, bool isKey, bool isNullable, string refEntityName, PropertyInfo keyPropInfo,
//            int size, int? prec, int? scale)



         result.Add(new EntityPropDef(
         PropertyHelper <AccVAT>.GetProperty(x => x.Avaatrrecno),
         "AVAATRRECNO", // columnName
         true,                    //isKey
         false, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  10, // int? prec
                           0  // int? Scale
         ,
         typeof(AccVAT)
       ));

         result.Add(new EntityPropDef(
         PropertyHelper <AccVAT>.GetProperty(x => x.Avavatcde),
         "AVAVATCDE", // columnName
         true,                    //isKey
         false, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  5, // int? prec
                           0  // int? Scale
         ,
         typeof(AccVAT)
       ));

         result.Add(new EntityPropDef(
         PropertyHelper <AccVAT>.GetProperty(x => x.Avaaddkey),
         "AVAADDKEY", // columnName
         true,                    //isKey
         false, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  5, // int? prec
                           0  // int? Scale
         ,
         typeof(AccVAT)
       ));

         result.Add(new EntityPropDef(
         PropertyHelper <AccVAT>.GetProperty(x => x.Avavattypno),
         "AVAVATTYPNO", // columnName
         true,                    //isKey
         false, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  5, // int? prec
                           0  // int? Scale
         ,
         typeof(AccVAT)
       ));


         result.Add(new EntityPropDef(
         PropertyHelper <AccVAT>.GetProperty(x => x.Avabasegoods),
         "AVABASEGOODS", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  126, // int? prec
                   
         null // int? Scale
         ,
         typeof(AccVAT)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <AccVAT>.GetProperty(x => x.Avabasevat),
         "AVABASEVAT", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  126, // int? prec
                   
         null // int? Scale
         ,
         typeof(AccVAT)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <AccVAT>.GetProperty(x => x.Avaeurogoods),
         "AVAEUROGOODS", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  126, // int? prec
                   
         null // int? Scale
         ,
         typeof(AccVAT)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <AccVAT>.GetProperty(x => x.Avaeurovat),
         "AVAEUROVAT", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  126, // int? prec
                   
         null // int? Scale
         ,
         typeof(AccVAT)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <AccVAT>.GetProperty(x => x.Avagoods),
         "AVAGOODS", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  126, // int? prec
                   
         null // int? Scale
         ,
         typeof(AccVAT)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <AccVAT>.GetProperty(x => x.Avaisrevcrdr),
         "AVAISREVCRDR", // columnName
         false,                    //isKey
         false, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  1, // int? prec
                           0  // int? Scale
         ,
         typeof(AccVAT)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <AccVAT>.GetProperty(x => x.Avarptdate),
         "AVARPTDATE", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  null, // int? prec
                   
         null // int? Scale
         ,
         typeof(AccVAT)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <AccVAT>.GetProperty(x => x.Avarptno),
         "AVARPTNO", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  10, // int? prec
                           0  // int? Scale
         ,
         typeof(AccVAT)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <AccVAT>.GetProperty(x => x.Avavat),
         "AVAVAT", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  126, // int? prec
                   
         null // int? Scale
         ,
         typeof(AccVAT)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <AccVAT>.GetProperty(x => x.Avavatrate),
         "AVAVATRATE", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  126, // int? prec
                   
         null // int? Scale
         ,
         typeof(AccVAT)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <AccVAT>.GetProperty(x => x.Avaveano),
         "AVAVEANO", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  5, // int? prec
                           0  // int? Scale
         ,
         typeof(AccVAT)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <AccVAT>.GetProperty(x => x.Exclgoods),
         "EXCLGOODS", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  1, // int? prec
                           0  // int? Scale
         ,
         typeof(AccVAT)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <AccVAT>.GetProperty(x => x.Vatlnkrecno),
         "VATLNKRECNO", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  10, // int? prec
                           0  // int? Scale
         ,
         typeof(AccVAT)
         ));
         return result; 
       }

#endregion     
        private int _fAvaatrrecno;
        public int Avaatrrecno
        {
            get { return _fAvaatrrecno; }
            set
            {
                var oldKey = Key;
                if (_fAvaatrrecno != value)
                {
                    Modify();
                    _fAvaatrrecno = value;
                    KeyChanged(oldKey);
                }
            }
        }

        private int _fAvavatcde;
        public int Avavatcde
        {
            get { return _fAvavatcde; }
            set
            {
                var oldKey = Key;
                if (_fAvavatcde != value)
                {
                    Modify();
                    _fAvavatcde = value;
                    KeyChanged(oldKey);
                }
            }
        }

        private int _fAvaaddkey;
        public int Avaaddkey
        {
            get { return _fAvaaddkey; }
            set
            {
                var oldKey = Key;
                if (_fAvaaddkey != value)
                {
                    Modify();
                    _fAvaaddkey = value;
                    KeyChanged(oldKey);
                }
            }
        }

        private int _fAvavattypno;
        public int Avavattypno
        {
            get { return _fAvavattypno; }
            set
            {
                var oldKey = Key;
                if (_fAvavattypno != value)
                {
                    Modify();
                    _fAvavattypno = value;
                    KeyChanged(oldKey);
                }
            }
        }

        private decimal? _fAvabasegoods;
        public decimal? Avabasegoods
        {
            get { return _fAvabasegoods; }
            set
            {
                if (_fAvabasegoods != value)
                {
                    Modify();
                    _fAvabasegoods = value;
                }
            }
        }

        private decimal? _fAvabasevat;
        public decimal? Avabasevat
        {
            get { return _fAvabasevat; }
            set
            {
                if (_fAvabasevat != value)
                {
                    Modify();
                    _fAvabasevat = value;
                }
            }
        }

        private decimal? _fAvaeurogoods;
        public decimal? Avaeurogoods
        {
            get { return _fAvaeurogoods; }
            set
            {
                if (_fAvaeurogoods != value)
                {
                    Modify();
                    _fAvaeurogoods = value;
                }
            }
        }

        private decimal? _fAvaeurovat;
        public decimal? Avaeurovat
        {
            get { return _fAvaeurovat; }
            set
            {
                if (_fAvaeurovat != value)
                {
                    Modify();
                    _fAvaeurovat = value;
                }
            }
        }

        private decimal? _fAvagoods;
        public decimal? Avagoods
        {
            get { return _fAvagoods; }
            set
            {
                if (_fAvagoods != value)
                {
                    Modify();
                    _fAvagoods = value;
                }
            }
        }

        private short _fAvaisrevcrdr;
        public short Avaisrevcrdr
        {
            get { return _fAvaisrevcrdr; }
            set
            {
                if (_fAvaisrevcrdr != value)
                {
                    Modify();
                    _fAvaisrevcrdr = value;
                }
            }
        }

        private DateTime? _fAvarptdate;
        public DateTime? Avarptdate
        {
            get { return _fAvarptdate; }
            set
            {
                if (_fAvarptdate != value)
                {
                    Modify();
                    _fAvarptdate = value;
                }
            }
        }

        private int? _fAvarptno;
        public int? Avarptno
        {
            get { return _fAvarptno; }
            set
            {
                if (_fAvarptno != value)
                {
                    Modify();
                    _fAvarptno = value;
                }
            }
        }

        private decimal? _fAvavat;
        public decimal? Avavat
        {
            get { return _fAvavat; }
            set
            {
                if (_fAvavat != value)
                {
                    Modify();
                    _fAvavat = value;
                }
            }
        }

        private decimal? _fAvavatrate;
        public decimal? Avavatrate
        {
            get { return _fAvavatrate; }
            set
            {
                if (_fAvavatrate != value)
                {
                    Modify();
                    _fAvavatrate = value;
                }
            }
        }

        private int? _fAvaveano;
        public int? Avaveano
        {
            get { return _fAvaveano; }
            set
            {
                if (_fAvaveano != value)
                {
                    Modify();
                    _fAvaveano = value;
                }
            }
        }

        private short? _fExclgoods;
        public short? Exclgoods
        {
            get { return _fExclgoods; }
            set
            {
                if (_fExclgoods != value)
                {
                    Modify();
                    _fExclgoods = value;
                }
            }
        }

        private int? _fVatlnkrecno;
        public int? Vatlnkrecno
        {
            get { return _fVatlnkrecno; }
            set
            {
                if (_fVatlnkrecno != value)
                {
                    Modify();
                    _fVatlnkrecno = value;
                }
            }
        }

        public override AccVATKey Key
        {
            get
            {
                return new AccVATKey { Avaatrrecno = Avaatrrecno, Avavatcde = Avavatcde, Avaaddkey = Avaaddkey, Avavattypno = Avavattypno };
            }
            set
            {
                if (value == null)
                    throw new ArgumentNullException("value", "Entity key can not be null.");
                Avaatrrecno = value.Avaatrrecno;
                Avavatcde = value.Avavatcde;
                Avaaddkey = value.Avaaddkey;
                Avavattypno = value.Avavattypno;
            }
        }

        public override string KeyAsString { get { return Key.AsString; } }


        public override AccVAT Clone()
        {
            var obj = new AccVAT
                {
                    Avaatrrecno = Avaatrrecno,
                    Avavatcde = Avavatcde,
                    Avaaddkey = Avaaddkey,
                    Avavattypno = Avavattypno,
                    Avabasegoods = Avabasegoods,
                    Avabasevat = Avabasevat,
                    Avaeurogoods = Avaeurogoods,
                    Avaeurovat = Avaeurovat,
                    Avagoods = Avagoods,
                    Avaisrevcrdr = Avaisrevcrdr,
                    Avarptdate = Avarptdate,
                    Avarptno = Avarptno,
                    Avavat = Avavat,
                    Avavatrate = Avavatrate,
                    Avaveano = Avaveano,
                    Exclgoods = Exclgoods,
                    Vatlnkrecno = Vatlnkrecno,
                };

            return obj;
        }

        public static class FieldNames
        {
// ReSharper disable InconsistentNaming
            public const string  AVAATRRECNO = "AVAATRRECNO";
            public const string  AVAVATCDE = "AVAVATCDE";
            public const string  AVAADDKEY = "AVAADDKEY";
            public const string  AVAVATTYPNO = "AVAVATTYPNO";
            public const string  AVABASEGOODS = "AVABASEGOODS";
            public const string  AVABASEVAT = "AVABASEVAT";
            public const string  AVAEUROGOODS = "AVAEUROGOODS";
            public const string  AVAEUROVAT = "AVAEUROVAT";
            public const string  AVAGOODS = "AVAGOODS";
            public const string  AVAISREVCRDR = "AVAISREVCRDR";
            public const string  AVARPTDATE = "AVARPTDATE";
            public const string  AVARPTNO = "AVARPTNO";
            public const string  AVAVAT = "AVAVAT";
            public const string  AVAVATRATE = "AVAVATRATE";
            public const string  AVAVEANO = "AVAVEANO";
            public const string  EXCLGOODS = "EXCLGOODS";
            public const string  VATLNKRECNO = "VATLNKRECNO";
 // ReSharper restore InconsistentNaming
        }


    }

    /// <summary>
    /// Define type of the primary key property of the ACCVAT entity.
    /// </summary>
    public class AccVATKey : ICompositeKey
    {
        public int Avaatrrecno { get; set; }
        public int Avavatcde { get; set; }
        public int Avaaddkey { get; set; }
        public int Avavattypno { get; set; }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != GetType()) return false;
            return Equals((AccVATKey)obj);
        }

        protected bool Equals(AccVATKey other)
        {
            return Avaatrrecno == other.Avaatrrecno && Avavatcde == other.Avavatcde && Avaaddkey == other.Avaaddkey && Avavattypno == other.Avavattypno;
        }

        public override int GetHashCode()
        {
            unchecked
            {
                int hashCode = 0;
                hashCode = (hashCode * 397) ^ (Avaatrrecno).GetHashCode();
                hashCode = (hashCode * 397) ^ (Avavatcde).GetHashCode();
                hashCode = (hashCode * 397) ^ (Avaaddkey).GetHashCode();
                hashCode = (hashCode * 397) ^ (Avavattypno).GetHashCode();
                return hashCode;
            }
        }

        public static AccVATKey Parse(string key)
        {
            var parts = key.Split('|');
            return new AccVATKey
            {
                Avaatrrecno = int.Parse(parts[0]),
                Avavatcde = int.Parse(parts[1]),
                Avaaddkey = int.Parse(parts[2]),
                Avavattypno = int.Parse(parts[3]),
            };
        }

        public string AsString
        {
            get { return Avaatrrecno.ToString() + "|" + Avavatcde.ToString() + "|" + Avaaddkey.ToString() + "|" + Avavattypno.ToString(); }
        }

        public override string ToString()
        {
            return AsString;
        }

    }

}
