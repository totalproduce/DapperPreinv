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
    /// Entity for the CSTANREC table
    /// </summary>
    public partial class CstAnRec : BaseDbModel<CstAnRec, CstAnRecKey>
    {
#region tableDefs

       public static List<EntityPropDef> GetPropDefs() {
         var result = new List<EntityPropDef>();

//EntityPropDef(string propName, string columnName, bool isKey, bool isNullable, string refEntityName, PropertyInfo keyPropInfo,
//            int size, int? prec, int? scale)



         result.Add(new EntityPropDef(
         PropertyHelper <CstAnRec>.GetProperty(x => x.Csdcsgrecno),
         "CSDCSGRECNO", // columnName
         true,                    //isKey
         false, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  5, // int? prec
                           0  // int? Scale
         ,
         typeof(CstAnRec)
       ));

         result.Add(new EntityPropDef(
         PropertyHelper <CstAnRec>.GetProperty(x => x.Csdcstcode),
         "CSDCSTCODE", // columnName
         true,                    //isKey
         false, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  10, // int? prec
                           0  // int? Scale
         ,
         typeof(CstAnRec)
       ));

         result.Add(new EntityPropDef(
         PropertyHelper <CstAnRec>.GetProperty(x => x.Csdcsarecno),
         "CSDCSARECNO", // columnName
         true,                    //isKey
         false, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  5, // int? prec
                           0  // int? Scale
         ,
         typeof(CstAnRec)
       ));

         return result; 
       }

#endregion     
        private int _fCsdcsgrecno;
        public int Csdcsgrecno
        {
            get { return _fCsdcsgrecno; }
            set
            {
                var oldKey = Key;
                if (_fCsdcsgrecno != value)
                {
                    Modify();
                    _fCsdcsgrecno = value;
                    KeyChanged(oldKey);
                }
            }
        }

        private int _fCsdcstcode;
        public int Csdcstcode
        {
            get { return _fCsdcstcode; }
            set
            {
                var oldKey = Key;
                if (_fCsdcstcode != value)
                {
                    Modify();
                    _fCsdcstcode = value;
                    KeyChanged(oldKey);
                }
            }
        }

        private int _fCsdcsarecno;
        public int Csdcsarecno
        {
            get { return _fCsdcsarecno; }
            set
            {
                var oldKey = Key;
                if (_fCsdcsarecno != value)
                {
                    Modify();
                    _fCsdcsarecno = value;
                    KeyChanged(oldKey);
                }
            }
        }

        public override CstAnRecKey Key
        {
            get
            {
                return new CstAnRecKey { Csdcsgrecno = Csdcsgrecno, Csdcstcode = Csdcstcode, Csdcsarecno = Csdcsarecno };
            }
            set
            {
                if (value == null)
                    throw new ArgumentNullException("value", "Entity key can not be null.");
                Csdcsgrecno = value.Csdcsgrecno;
                Csdcstcode = value.Csdcstcode;
                Csdcsarecno = value.Csdcsarecno;
            }
        }

        public override string KeyAsString { get { return Key.AsString; } }


        public override CstAnRec Clone()
        {
            var obj = new CstAnRec
                {
                    Csdcsgrecno = Csdcsgrecno,
                    Csdcstcode = Csdcstcode,
                    Csdcsarecno = Csdcsarecno,
                };

            return obj;
        }

        public static class FieldNames
        {
// ReSharper disable InconsistentNaming
            public const string  CSDCSGRECNO = "CSDCSGRECNO";
            public const string  CSDCSTCODE = "CSDCSTCODE";
            public const string  CSDCSARECNO = "CSDCSARECNO";
 // ReSharper restore InconsistentNaming
        }


    }

    /// <summary>
    /// Define type of the primary key property of the CSTANREC entity.
    /// </summary>
    public class CstAnRecKey : ICompositeKey
    {
        public int Csdcsgrecno { get; set; }
        public int Csdcstcode { get; set; }
        public int Csdcsarecno { get; set; }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != GetType()) return false;
            return Equals((CstAnRecKey)obj);
        }

        protected bool Equals(CstAnRecKey other)
        {
            return Csdcsgrecno == other.Csdcsgrecno && Csdcstcode == other.Csdcstcode && Csdcsarecno == other.Csdcsarecno;
        }

        public override int GetHashCode()
        {
            unchecked
            {
                int hashCode = 0;
                hashCode = (hashCode * 397) ^ (Csdcsgrecno).GetHashCode();
                hashCode = (hashCode * 397) ^ (Csdcstcode).GetHashCode();
                hashCode = (hashCode * 397) ^ (Csdcsarecno).GetHashCode();
                return hashCode;
            }
        }

        public static CstAnRecKey Parse(string key)
        {
            var parts = key.Split('|');
            return new CstAnRecKey
            {
                Csdcsgrecno = int.Parse(parts[0]),
                Csdcstcode = int.Parse(parts[1]),
                Csdcsarecno = int.Parse(parts[2]),
            };
        }

        public string AsString
        {
            get { return Csdcsgrecno.ToString() + "|" + Csdcstcode.ToString() + "|" + Csdcsarecno.ToString(); }
        }

        public override string ToString()
        {
            return AsString;
        }

    }

}
