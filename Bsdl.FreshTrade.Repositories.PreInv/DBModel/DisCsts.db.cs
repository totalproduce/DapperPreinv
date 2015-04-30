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
    /// Entity for the DISCSTS table
    /// </summary>
    public partial class DisCsts : BaseDbModel<DisCsts, DisCstsKey>
    {
#region tableDefs

       public static List<EntityPropDef> GetPropDefs() {
         var result = new List<EntityPropDef>();

//EntityPropDef(string propName, string columnName, bool isKey, bool isNullable, string refEntityName, PropertyInfo keyPropInfo,
//            int size, int? prec, int? scale)



         result.Add(new EntityPropDef(
         PropertyHelper <DisCsts>.GetProperty(x => x.Cstdisgrprecno),
         "CSTDISGRPRECNO", // columnName
         true,                    //isKey
         false, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  5, // int? prec
                           0  // int? Scale
         ,
         typeof(DisCsts)
       ));

         result.Add(new EntityPropDef(
         PropertyHelper <DisCsts>.GetProperty(x => x.Discstcode),
         "DISCSTCODE", // columnName
         true,                    //isKey
         false, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  10, // int? prec
                           0  // int? Scale
         ,
         typeof(DisCsts)
       ));

         return result; 
       }

#endregion     
        private int _fCstdisgrprecno;
        public int Cstdisgrprecno
        {
            get { return _fCstdisgrprecno; }
            set
            {
                var oldKey = Key;
                if (_fCstdisgrprecno != value)
                {
                    Modify();
                    _fCstdisgrprecno = value;
                    KeyChanged(oldKey);
                }
            }
        }

        private int _fDiscstcode;
        public int Discstcode
        {
            get { return _fDiscstcode; }
            set
            {
                var oldKey = Key;
                if (_fDiscstcode != value)
                {
                    Modify();
                    _fDiscstcode = value;
                    KeyChanged(oldKey);
                }
            }
        }

        public override DisCstsKey Key
        {
            get
            {
                return new DisCstsKey { Cstdisgrprecno = Cstdisgrprecno, Discstcode = Discstcode };
            }
            set
            {
                if (value == null)
                    throw new ArgumentNullException("value", "Entity key can not be null.");
                Cstdisgrprecno = value.Cstdisgrprecno;
                Discstcode = value.Discstcode;
            }
        }

        public override string KeyAsString { get { return Key.AsString; } }


        public override DisCsts Clone()
        {
            var obj = new DisCsts
                {
                    Cstdisgrprecno = Cstdisgrprecno,
                    Discstcode = Discstcode,
                };

            return obj;
        }

        public static class FieldNames
        {
// ReSharper disable InconsistentNaming
            public const string  CSTDISGRPRECNO = "CSTDISGRPRECNO";
            public const string  DISCSTCODE = "DISCSTCODE";
 // ReSharper restore InconsistentNaming
        }


    }

    /// <summary>
    /// Define type of the primary key property of the DISCSTS entity.
    /// </summary>
    public class DisCstsKey : ICompositeKey
    {
        public int Cstdisgrprecno { get; set; }
        public int Discstcode { get; set; }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != GetType()) return false;
            return Equals((DisCstsKey)obj);
        }

        protected bool Equals(DisCstsKey other)
        {
            return Cstdisgrprecno == other.Cstdisgrprecno && Discstcode == other.Discstcode;
        }

        public override int GetHashCode()
        {
            unchecked
            {
                int hashCode = 0;
                hashCode = (hashCode * 397) ^ (Cstdisgrprecno).GetHashCode();
                hashCode = (hashCode * 397) ^ (Discstcode).GetHashCode();
                return hashCode;
            }
        }

        public static DisCstsKey Parse(string key)
        {
            var parts = key.Split('|');
            return new DisCstsKey
            {
                Cstdisgrprecno = int.Parse(parts[0]),
                Discstcode = int.Parse(parts[1]),
            };
        }

        public string AsString
        {
            get { return Cstdisgrprecno.ToString() + "|" + Discstcode.ToString(); }
        }

        public override string ToString()
        {
            return AsString;
        }

    }

}
