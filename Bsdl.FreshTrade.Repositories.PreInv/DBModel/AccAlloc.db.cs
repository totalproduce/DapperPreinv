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
    /// Entity for the ACCALLOC table
    /// </summary>
    public partial class AccAlloc : BaseDbModel<AccAlloc, AccAllocKey>
    {
#region tableDefs

       public static List<EntityPropDef> GetPropDefs() {
         var result = new List<EntityPropDef>();

//EntityPropDef(string propName, string columnName, bool isKey, bool isNullable, string refEntityName, PropertyInfo keyPropInfo,
//            int size, int? prec, int? scale)



         result.Add(new EntityPropDef(
         PropertyHelper <AccAlloc>.GetProperty(x => x.Acaatrrecnofrom),
         "ACAATRRECNOFROM", // columnName
         true,                    //isKey
         false, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  10, // int? prec
                           0  // int? Scale
         ,
         typeof(AccAlloc)
       ));

         result.Add(new EntityPropDef(
         PropertyHelper <AccAlloc>.GetProperty(x => x.Acaatrrecnoto),
         "ACAATRRECNOTO", // columnName
         true,                    //isKey
         false, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  10, // int? prec
                           0  // int? Scale
         ,
         typeof(AccAlloc)
       ));

         result.Add(new EntityPropDef(
         PropertyHelper <AccAlloc>.GetProperty(x => x.Acaaavrecno),
         "ACAAAVRECNO", // columnName
         true,                    //isKey
         false, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  10, // int? prec
                           0  // int? Scale
         ,
         typeof(AccAlloc)
       ));


         result.Add(new EntityPropDef(
         PropertyHelper <AccAlloc>.GetProperty(x => x.Acadrcr),
         "ACADRCR", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  5, // int? prec
                           0  // int? Scale
         ,
         typeof(AccAlloc)
         ));
         return result; 
       }

#endregion     
        private int _fAcaatrrecnofrom;
        public int Acaatrrecnofrom
        {
            get { return _fAcaatrrecnofrom; }
            set
            {
                var oldKey = Key;
                if (_fAcaatrrecnofrom != value)
                {
                    Modify();
                    _fAcaatrrecnofrom = value;
                    KeyChanged(oldKey);
                }
            }
        }

        private int _fAcaatrrecnoto;
        public int Acaatrrecnoto
        {
            get { return _fAcaatrrecnoto; }
            set
            {
                var oldKey = Key;
                if (_fAcaatrrecnoto != value)
                {
                    Modify();
                    _fAcaatrrecnoto = value;
                    KeyChanged(oldKey);
                }
            }
        }

        private int _fAcaaavrecno;
        public int Acaaavrecno
        {
            get { return _fAcaaavrecno; }
            set
            {
                var oldKey = Key;
                if (_fAcaaavrecno != value)
                {
                    Modify();
                    _fAcaaavrecno = value;
                    KeyChanged(oldKey);
                }
            }
        }

        private int? _fAcadrcr;
        public int? Acadrcr
        {
            get { return _fAcadrcr; }
            set
            {
                if (_fAcadrcr != value)
                {
                    Modify();
                    _fAcadrcr = value;
                }
            }
        }

        public override AccAllocKey Key
        {
            get
            {
                return new AccAllocKey { Acaatrrecnofrom = Acaatrrecnofrom, Acaatrrecnoto = Acaatrrecnoto, Acaaavrecno = Acaaavrecno };
            }
            set
            {
                if (value == null)
                    throw new ArgumentNullException("value", "Entity key can not be null.");
                Acaatrrecnofrom = value.Acaatrrecnofrom;
                Acaatrrecnoto = value.Acaatrrecnoto;
                Acaaavrecno = value.Acaaavrecno;
            }
        }

        public override string KeyAsString { get { return Key.AsString; } }


        public override AccAlloc Clone()
        {
            var obj = new AccAlloc
                {
                    Acaatrrecnofrom = Acaatrrecnofrom,
                    Acaatrrecnoto = Acaatrrecnoto,
                    Acaaavrecno = Acaaavrecno,
                    Acadrcr = Acadrcr,
                };

            return obj;
        }

        public static class FieldNames
        {
// ReSharper disable InconsistentNaming
            public const string  ACAATRRECNOFROM = "ACAATRRECNOFROM";
            public const string  ACAATRRECNOTO = "ACAATRRECNOTO";
            public const string  ACAAAVRECNO = "ACAAAVRECNO";
            public const string  ACADRCR = "ACADRCR";
 // ReSharper restore InconsistentNaming
        }


    }

    /// <summary>
    /// Define type of the primary key property of the ACCALLOC entity.
    /// </summary>
    public class AccAllocKey : ICompositeKey
    {
        public int Acaatrrecnofrom { get; set; }
        public int Acaatrrecnoto { get; set; }
        public int Acaaavrecno { get; set; }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != GetType()) return false;
            return Equals((AccAllocKey)obj);
        }

        protected bool Equals(AccAllocKey other)
        {
            return Acaatrrecnofrom == other.Acaatrrecnofrom && Acaatrrecnoto == other.Acaatrrecnoto && Acaaavrecno == other.Acaaavrecno;
        }

        public override int GetHashCode()
        {
            unchecked
            {
                int hashCode = 0;
                hashCode = (hashCode * 397) ^ (Acaatrrecnofrom).GetHashCode();
                hashCode = (hashCode * 397) ^ (Acaatrrecnoto).GetHashCode();
                hashCode = (hashCode * 397) ^ (Acaaavrecno).GetHashCode();
                return hashCode;
            }
        }

        public static AccAllocKey Parse(string key)
        {
            var parts = key.Split('|');
            return new AccAllocKey
            {
                Acaatrrecnofrom = int.Parse(parts[0]),
                Acaatrrecnoto = int.Parse(parts[1]),
                Acaaavrecno = int.Parse(parts[2]),
            };
        }

        public string AsString
        {
            get { return Acaatrrecnofrom.ToString() + "|" + Acaatrrecnoto.ToString() + "|" + Acaaavrecno.ToString(); }
        }

        public override string ToString()
        {
            return AsString;
        }

    }

}
