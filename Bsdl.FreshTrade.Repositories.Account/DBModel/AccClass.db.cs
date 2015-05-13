




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
    /// Entity for the ACCCLASS table
    /// </summary>
    public partial class AccClass : BaseDbModel<AccClass, AccClassKey>
    {
#region tableDefs

       public static List<EntityPropDef> GetPropDefs() {
         var result = new List<EntityPropDef>();

//EntityPropDef(string propName, string columnName, bool isKey, bool isNullable, string refEntityName, PropertyInfo keyPropInfo,
//            int size, int? prec, int? scale)



         result.Add(new EntityPropDef(
         PropertyHelper <AccClass>.GetProperty(x => x.Claacccode),
         "CLAACCCODE", // columnName
         true,                    //isKey
         false, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         8,       // int size   
           
         null, // int? prec
                    
         null // int? Scale
         ,
         typeof(AccClass)
       ));

         result.Add(new EntityPropDef(
         PropertyHelper <AccClass>.GetProperty(x => x.Claacccstsup),
         "CLAACCCSTSUP", // columnName
         true,                    //isKey
         false, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  5, // int? prec
                           0  // int? Scale
         ,
         typeof(AccClass)
       ));

         result.Add(new EntityPropDef(
         PropertyHelper <AccClass>.GetProperty(x => x.Clacurrno),
         "CLACURRNO", // columnName
         true,                    //isKey
         false, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  5, // int? prec
                           0  // int? Scale
         ,
         typeof(AccClass)
       ));


         result.Add(new EntityPropDef(
         PropertyHelper <AccClass>.GetProperty(x => x.Accglexprecno),
         "ACCGLEXPRECNO", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  10, // int? prec
                           0  // int? Scale
         ,
         typeof(AccClass)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <AccClass>.GetProperty(x => x.Aponhold),
         "APONHOLD", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  1, // int? prec
                           0  // int? Scale
         ,
         typeof(AccClass)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <AccClass>.GetProperty(x => x.Claaccno),
         "CLAACCNO", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  10, // int? prec
                           0  // int? Scale
         ,
         typeof(AccClass)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <AccClass>.GetProperty(x => x.Claactive),
         "CLAACTIVE", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  5, // int? prec
                           0  // int? Scale
         ,
         typeof(AccClass)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <AccClass>.GetProperty(x => x.Claaltprintcur),
         "CLAALTPRINTCUR", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  5, // int? prec
                           0  // int? Scale
         ,
         typeof(AccClass)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <AccClass>.GetProperty(x => x.Clachqtoclarecno),
         "CLACHQTOCLARECNO", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  10, // int? prec
                           0  // int? Scale
         ,
         typeof(AccClass)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <AccClass>.GetProperty(x => x.Clacontactname),
         "CLACONTACTNAME", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         40,       // int size   
                  null, // int? prec
                   
         null // int? Scale
         ,
         typeof(AccClass)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <AccClass>.GetProperty(x => x.Clafaxno),
         "CLAFAXNO", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         20,       // int size   
                  null, // int? prec
                   
         null // int? Scale
         ,
         typeof(AccClass)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <AccClass>.GetProperty(x => x.Clahasbeenused),
         "CLAHASBEENUSED", // columnName
         false,                    //isKey
         false, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  1, // int? prec
                           0  // int? Scale
         ,
         typeof(AccClass)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <AccClass>.GetProperty(x => x.Clarecno),
         "CLARECNO", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  10, // int? prec
                           0  // int? Scale
         ,
         typeof(AccClass)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <AccClass>.GetProperty(x => x.Clateleno),
         "CLATELENO", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         20,       // int size   
                  null, // int? prec
                   
         null // int? Scale
         ,
         typeof(AccClass)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <AccClass>.GetProperty(x => x.Defaultpotype),
         "DEFAULTPOTYPE", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  5, // int? prec
                           0  // int? Scale
         ,
         typeof(AccClass)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <AccClass>.GetProperty(x => x.Lusegreendot),
         "LUSEGREENDOT", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  1, // int? prec
                           0  // int? Scale
         ,
         typeof(AccClass)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <AccClass>.GetProperty(x => x.Onholdreasoncodeno),
         "ONHOLDREASONCODENO", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  10, // int? prec
                           0  // int? Scale
         ,
         typeof(AccClass)
         ));
         return result; 
       }

#endregion     
        private string _fClaacccode;
        public string Claacccode
        {
            get { return _fClaacccode; }
            set
            {
                var oldKey = Key;
                if (_fClaacccode != value)
                {
                    Modify();
                    _fClaacccode = value;
                    KeyChanged(oldKey);
                }
            }
        }

        private int _fClaacccstsup;
        public int Claacccstsup
        {
            get { return _fClaacccstsup; }
            set
            {
                var oldKey = Key;
                if (_fClaacccstsup != value)
                {
                    Modify();
                    _fClaacccstsup = value;
                    KeyChanged(oldKey);
                }
            }
        }

        private int _fClacurrno;
        public int Clacurrno
        {
            get { return _fClacurrno; }
            set
            {
                var oldKey = Key;
                if (_fClacurrno != value)
                {
                    Modify();
                    _fClacurrno = value;
                    KeyChanged(oldKey);
                }
            }
        }

        private int? _fAccglexprecno;
        public int? Accglexprecno
        {
            get { return _fAccglexprecno; }
            set
            {
                if (_fAccglexprecno != value)
                {
                    Modify();
                    _fAccglexprecno = value;
                }
            }
        }

        private short? _fAponhold;
        public short? Aponhold
        {
            get { return _fAponhold; }
            set
            {
                if (_fAponhold != value)
                {
                    Modify();
                    _fAponhold = value;
                }
            }
        }

        private int? _fClaaccno;
        public int? Claaccno
        {
            get { return _fClaaccno; }
            set
            {
                if (_fClaaccno != value)
                {
                    Modify();
                    _fClaaccno = value;
                }
            }
        }

        private int? _fClaactive;
        public int? Claactive
        {
            get { return _fClaactive; }
            set
            {
                if (_fClaactive != value)
                {
                    Modify();
                    _fClaactive = value;
                }
            }
        }

        private int? _fClaaltprintcur;
        public int? Claaltprintcur
        {
            get { return _fClaaltprintcur; }
            set
            {
                if (_fClaaltprintcur != value)
                {
                    Modify();
                    _fClaaltprintcur = value;
                }
            }
        }

        private int? _fClachqtoclarecno;
        public int? Clachqtoclarecno
        {
            get { return _fClachqtoclarecno; }
            set
            {
                if (_fClachqtoclarecno != value)
                {
                    Modify();
                    _fClachqtoclarecno = value;
                }
            }
        }

        private string _fClacontactname;
        public string Clacontactname
        {
            get { return _fClacontactname; }
            set
            {
                if (_fClacontactname != value)
                {
                    Modify();
                    _fClacontactname = value;
                }
            }
        }

        private string _fClafaxno;
        public string Clafaxno
        {
            get { return _fClafaxno; }
            set
            {
                if (_fClafaxno != value)
                {
                    Modify();
                    _fClafaxno = value;
                }
            }
        }

        private short _fClahasbeenused;
        public short Clahasbeenused
        {
            get { return _fClahasbeenused; }
            set
            {
                if (_fClahasbeenused != value)
                {
                    Modify();
                    _fClahasbeenused = value;
                }
            }
        }

        private int? _fClarecno;
        public int? Clarecno
        {
            get { return _fClarecno; }
            set
            {
                if (_fClarecno != value)
                {
                    Modify();
                    _fClarecno = value;
                }
            }
        }

        private string _fClateleno;
        public string Clateleno
        {
            get { return _fClateleno; }
            set
            {
                if (_fClateleno != value)
                {
                    Modify();
                    _fClateleno = value;
                }
            }
        }

        private int? _fDefaultpotype;
        public int? Defaultpotype
        {
            get { return _fDefaultpotype; }
            set
            {
                if (_fDefaultpotype != value)
                {
                    Modify();
                    _fDefaultpotype = value;
                }
            }
        }

        private short? _fLusegreendot;
        public short? Lusegreendot
        {
            get { return _fLusegreendot; }
            set
            {
                if (_fLusegreendot != value)
                {
                    Modify();
                    _fLusegreendot = value;
                }
            }
        }

        private int? _fOnholdreasoncodeno;
        public int? Onholdreasoncodeno
        {
            get { return _fOnholdreasoncodeno; }
            set
            {
                if (_fOnholdreasoncodeno != value)
                {
                    Modify();
                    _fOnholdreasoncodeno = value;
                }
            }
        }

        public override AccClassKey Key
        {
            get
            {
                return new AccClassKey { Claacccode = Claacccode, Claacccstsup = Claacccstsup, Clacurrno = Clacurrno };
            }
            set
            {
                if (value == null)
                    throw new ArgumentNullException("value", "Entity key can not be null.");
                Claacccode = value.Claacccode;
                Claacccstsup = value.Claacccstsup;
                Clacurrno = value.Clacurrno;
            }
        }

        public override string KeyAsString { get { return Key.AsString; } }


        public override AccClass Clone()
        {
            var obj = new AccClass
                {
                    Claacccode = Claacccode,
                    Claacccstsup = Claacccstsup,
                    Clacurrno = Clacurrno,
                    Accglexprecno = Accglexprecno,
                    Aponhold = Aponhold,
                    Claaccno = Claaccno,
                    Claactive = Claactive,
                    Claaltprintcur = Claaltprintcur,
                    Clachqtoclarecno = Clachqtoclarecno,
                    Clacontactname = Clacontactname,
                    Clafaxno = Clafaxno,
                    Clahasbeenused = Clahasbeenused,
                    Clarecno = Clarecno,
                    Clateleno = Clateleno,
                    Defaultpotype = Defaultpotype,
                    Lusegreendot = Lusegreendot,
                    Onholdreasoncodeno = Onholdreasoncodeno,
                };

            return obj;
        }

        public static class FieldNames
        {
// ReSharper disable InconsistentNaming
            public const string  CLAACCCODE = "CLAACCCODE";
            public const string  CLAACCCSTSUP = "CLAACCCSTSUP";
            public const string  CLACURRNO = "CLACURRNO";
            public const string  ACCGLEXPRECNO = "ACCGLEXPRECNO";
            public const string  APONHOLD = "APONHOLD";
            public const string  CLAACCNO = "CLAACCNO";
            public const string  CLAACTIVE = "CLAACTIVE";
            public const string  CLAALTPRINTCUR = "CLAALTPRINTCUR";
            public const string  CLACHQTOCLARECNO = "CLACHQTOCLARECNO";
            public const string  CLACONTACTNAME = "CLACONTACTNAME";
            public const string  CLAFAXNO = "CLAFAXNO";
            public const string  CLAHASBEENUSED = "CLAHASBEENUSED";
            public const string  CLARECNO = "CLARECNO";
            public const string  CLATELENO = "CLATELENO";
            public const string  DEFAULTPOTYPE = "DEFAULTPOTYPE";
            public const string  LUSEGREENDOT = "LUSEGREENDOT";
            public const string  ONHOLDREASONCODENO = "ONHOLDREASONCODENO";
 // ReSharper restore InconsistentNaming
        }


    }

    /// <summary>
    /// Define type of the primary key property of the ACCCLASS entity.
    /// </summary>
    public class AccClassKey : ICompositeKey
    {
        public string Claacccode { get; set; }
        public int Claacccstsup { get; set; }
        public int Clacurrno { get; set; }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != GetType()) return false;
            return Equals((AccClassKey)obj);
        }

        protected bool Equals(AccClassKey other)
        {
            return Claacccode == other.Claacccode && Claacccstsup == other.Claacccstsup && Clacurrno == other.Clacurrno;
        }

        public override int GetHashCode()
        {
            unchecked
            {
                int hashCode = 0;
                hashCode = (hashCode * 397) ^ (Claacccode ?? "").GetHashCode();
                hashCode = (hashCode * 397) ^ (Claacccstsup).GetHashCode();
                hashCode = (hashCode * 397) ^ (Clacurrno).GetHashCode();
                return hashCode;
            }
        }

        public static AccClassKey Parse(string key)
        {
            var parts = key.Split('|');
            return new AccClassKey
            {
                Claacccode = parts[0],
                Claacccstsup = int.Parse(parts[1]),
                Clacurrno = int.Parse(parts[2]),
            };
        }

        public string AsString
        {
            get { return Claacccode.ToString() + "|" + Claacccstsup.ToString() + "|" + Clacurrno.ToString(); }
        }

        public override string ToString()
        {
            return AsString;
        }

    }

}
