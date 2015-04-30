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
    /// Entity for the PRCNEWCSTS table
    /// </summary>
    public partial class PRCNEWCSTS : BaseDbModel<PRCNEWCSTS, PRCNEWCSTSKey>
    {
#region tableDefs

       public static List<EntityPropDef> GetPropDefs() {
         var result = new List<EntityPropDef>();

//EntityPropDef(string propName, string columnName, bool isKey, bool isNullable, string refEntityName, PropertyInfo keyPropInfo,
//            int size, int? prec, int? scale)



         result.Add(new EntityPropDef(
         PropertyHelper <PRCNEWCSTS>.GetProperty(x => x.Prcclarecno),
         "PRCCLARECNO", // columnName
         true,                    //isKey
         false, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  10, // int? prec
                           0  // int? Scale
         ,
         typeof(PRCNEWCSTS)
       ));

         result.Add(new EntityPropDef(
         PropertyHelper <PRCNEWCSTS>.GetProperty(x => x.Cstprcgrprecno),
         "CSTPRCGRPRECNO", // columnName
         true,                    //isKey
         false, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  5, // int? prec
                           0  // int? Scale
         ,
         typeof(PRCNEWCSTS)
       ));

         return result; 
       }

#endregion     
        private int _fPrcclarecno;
        public int Prcclarecno
        {
            get { return _fPrcclarecno; }
            set
            {
                var oldKey = Key;
                if (_fPrcclarecno != value)
                {
                    Modify();
                    _fPrcclarecno = value;
                    KeyChanged(oldKey);
                }
            }
        }

        private int _fCstprcgrprecno;
        public int Cstprcgrprecno
        {
            get { return _fCstprcgrprecno; }
            set
            {
                var oldKey = Key;
                if (_fCstprcgrprecno != value)
                {
                    Modify();
                    _fCstprcgrprecno = value;
                    KeyChanged(oldKey);
                }
            }
        }

        public override PRCNEWCSTSKey Key
        {
            get
            {
                return new PRCNEWCSTSKey { Prcclarecno = Prcclarecno, Cstprcgrprecno = Cstprcgrprecno };
            }
            set
            {
                if (value == null)
                    throw new ArgumentNullException("value", "Entity key can not be null.");
                Prcclarecno = value.Prcclarecno;
                Cstprcgrprecno = value.Cstprcgrprecno;
            }
        }

        public override string KeyAsString { get { return Key.AsString; } }


        public override PRCNEWCSTS Clone()
        {
            var obj = new PRCNEWCSTS
                {
                    Prcclarecno = Prcclarecno,
                    Cstprcgrprecno = Cstprcgrprecno,
                };

            return obj;
        }

        public static class FieldNames
        {
// ReSharper disable InconsistentNaming
            public const string  PRCCLARECNO = "PRCCLARECNO";
            public const string  CSTPRCGRPRECNO = "CSTPRCGRPRECNO";
 // ReSharper restore InconsistentNaming
        }


    }

    /// <summary>
    /// Define type of the primary key property of the PRCNEWCSTS entity.
    /// </summary>
    public class PRCNEWCSTSKey : ICompositeKey
    {
        public int Prcclarecno { get; set; }
        public int Cstprcgrprecno { get; set; }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != GetType()) return false;
            return Equals((PRCNEWCSTSKey)obj);
        }

        protected bool Equals(PRCNEWCSTSKey other)
        {
            return Prcclarecno == other.Prcclarecno && Cstprcgrprecno == other.Cstprcgrprecno;
        }

        public override int GetHashCode()
        {
            unchecked
            {
                int hashCode = 0;
                hashCode = (hashCode * 397) ^ (Prcclarecno).GetHashCode();
                hashCode = (hashCode * 397) ^ (Cstprcgrprecno).GetHashCode();
                return hashCode;
            }
        }

        public static PRCNEWCSTSKey Parse(string key)
        {
            var parts = key.Split('|');
            return new PRCNEWCSTSKey
            {
                Prcclarecno = int.Parse(parts[0]),
                Cstprcgrprecno = int.Parse(parts[1]),
            };
        }

        public string AsString
        {
            get { return Prcclarecno.ToString() + "|" + Cstprcgrprecno.ToString(); }
        }

        public override string ToString()
        {
            return AsString;
        }

    }

}
