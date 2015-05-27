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
    /// Entity for the DISRATES table
    /// </summary>
    public partial class DisRates : BaseDbModel<DisRates, DisRatesKey>
    {
#region tableDefs

       public static List<EntityPropDef> GetPropDefs() {
         var result = new List<EntityPropDef>();

//EntityPropDef(string propName, string columnName, bool isKey, bool isNullable, string refEntityName, PropertyInfo keyPropInfo,
//            int size, int? prec, int? scale)



         result.Add(new EntityPropDef(
         PropertyHelper <DisRates>.GetProperty(x => x.Drarecno),
         "DRARECNO", // columnName
         true,                    //isKey
         false, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  10, // int? prec
                           0  // int? Scale
         ,
         typeof(DisRates)
       ));

         result.Add(new EntityPropDef(
         PropertyHelper <DisRates>.GetProperty(x => x.Thisseqno),
         "THISSEQNO", // columnName
         true,                    //isKey
         false, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  5, // int? prec
                           0  // int? Scale
         ,
         typeof(DisRates)
       ));


         result.Add(new EntityPropDef(
         PropertyHelper <DisRates>.GetProperty(x => x.Discinclduty),
         "DISCINCLDUTY", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  1, // int? prec
                           0  // int? Scale
         ,
         typeof(DisRates)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <DisRates>.GetProperty(x => x.Disglrecno),
         "DISGLRECNO", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  10, // int? prec
                           0  // int? Scale
         ,
         typeof(DisRates)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <DisRates>.GetProperty(x => x.Thisdedstr),
         "THISDEDSTR", // columnName
         false,                    //isKey
         false, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         30,       // int size   
                  null, // int? prec
                   
         null // int? Scale
         ,
         typeof(DisRates)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <DisRates>.GetProperty(x => x.Thison),
         "THISON", // columnName
         false,                    //isKey
         false, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  5, // int? prec
                           0  // int? Scale
         ,
         typeof(DisRates)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <DisRates>.GetProperty(x => x.Thispercrate),
         "THISPERCRATE", // columnName
         false,                    //isKey
         false, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  126, // int? prec
                   
         null // int? Scale
         ,
         typeof(DisRates)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <DisRates>.GetProperty(x => x.Thisrate),
         "THISRATE", // columnName
         false,                    //isKey
         false, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  126, // int? prec
                   
         null // int? Scale
         ,
         typeof(DisRates)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <DisRates>.GetProperty(x => x.Thisstndunitrate),
         "THISSTNDUNITRATE", // columnName
         false,                    //isKey
         false, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  22, // int? prec
                   
         null // int? Scale
         ,
         typeof(DisRates)
         ));
         return result; 
       }

#endregion     
        private int _fDrarecno;
        public int Drarecno
        {
            get { return _fDrarecno; }
            set
            {
                var oldKey = Key;
                if (_fDrarecno != value)
                {
                    Modify();
                    _fDrarecno = value;
                    KeyChanged(oldKey);
                }
            }
        }

        private int _fThisseqno;
        public int Thisseqno
        {
            get { return _fThisseqno; }
            set
            {
                var oldKey = Key;
                if (_fThisseqno != value)
                {
                    Modify();
                    _fThisseqno = value;
                    KeyChanged(oldKey);
                }
            }
        }

        private short? _fDiscinclduty;
        public short? Discinclduty
        {
            get { return _fDiscinclduty; }
            set
            {
                if (_fDiscinclduty != value)
                {
                    Modify();
                    _fDiscinclduty = value;
                }
            }
        }

        private int? _fDisglrecno;
        public int? Disglrecno
        {
            get { return _fDisglrecno; }
            set
            {
                if (_fDisglrecno != value)
                {
                    Modify();
                    _fDisglrecno = value;
                }
            }
        }

        private string _fThisdedstr;
        public string Thisdedstr
        {
            get { return _fThisdedstr; }
            set
            {
                if (_fThisdedstr != value)
                {
                    Modify();
                    _fThisdedstr = value;
                }
            }
        }

        private int _fThison;
        public int Thison
        {
            get { return _fThison; }
            set
            {
                if (_fThison != value)
                {
                    Modify();
                    _fThison = value;
                }
            }
        }

        private decimal _fThispercrate;
        public decimal Thispercrate
        {
            get { return _fThispercrate; }
            set
            {
                if (_fThispercrate != value)
                {
                    Modify();
                    _fThispercrate = value;
                }
            }
        }

        private decimal _fThisrate;
        public decimal Thisrate
        {
            get { return _fThisrate; }
            set
            {
                if (_fThisrate != value)
                {
                    Modify();
                    _fThisrate = value;
                }
            }
        }

        private decimal _fThisstndunitrate;
        public decimal Thisstndunitrate
        {
            get { return _fThisstndunitrate; }
            set
            {
                if (_fThisstndunitrate != value)
                {
                    Modify();
                    _fThisstndunitrate = value;
                }
            }
        }

        public override DisRatesKey Key
        {
            get
            {
                return new DisRatesKey { Drarecno = Drarecno, Thisseqno = Thisseqno };
            }
            set
            {
                if (value == null)
                    throw new ArgumentNullException("value", "Entity key can not be null.");
                Drarecno = value.Drarecno;
                Thisseqno = value.Thisseqno;
            }
        }

        public override string KeyAsString { get { return Key.AsString; } }


        public override DisRates Clone()
        {
            var obj = new DisRates
                {
                    Drarecno = Drarecno,
                    Thisseqno = Thisseqno,
                    Discinclduty = Discinclduty,
                    Disglrecno = Disglrecno,
                    Thisdedstr = Thisdedstr,
                    Thison = Thison,
                    Thispercrate = Thispercrate,
                    Thisrate = Thisrate,
                    Thisstndunitrate = Thisstndunitrate,
                };

            return obj;
        }

        public static class FieldNames
        {
// ReSharper disable InconsistentNaming
            public const string  DRARECNO = "DRARECNO";
            public const string  THISSEQNO = "THISSEQNO";
            public const string  DISCINCLDUTY = "DISCINCLDUTY";
            public const string  DISGLRECNO = "DISGLRECNO";
            public const string  THISDEDSTR = "THISDEDSTR";
            public const string  THISON = "THISON";
            public const string  THISPERCRATE = "THISPERCRATE";
            public const string  THISRATE = "THISRATE";
            public const string  THISSTNDUNITRATE = "THISSTNDUNITRATE";
 // ReSharper restore InconsistentNaming
        }


    }

    /// <summary>
    /// Define type of the primary key property of the DISRATES entity.
    /// </summary>
    public class DisRatesKey : ICompositeKey
    {
        public int Drarecno { get; set; }
        public int Thisseqno { get; set; }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != GetType()) return false;
            return Equals((DisRatesKey)obj);
        }

        protected bool Equals(DisRatesKey other)
        {
            return Drarecno == other.Drarecno && Thisseqno == other.Thisseqno;
        }

        public override int GetHashCode()
        {
            unchecked
            {
                int hashCode = 0;
                hashCode = (hashCode * 397) ^ (Drarecno).GetHashCode();
                hashCode = (hashCode * 397) ^ (Thisseqno).GetHashCode();
                return hashCode;
            }
        }

        public static DisRatesKey Parse(string key)
        {
            var parts = key.Split('|');
            return new DisRatesKey
            {
                Drarecno = int.Parse(parts[0]),
                Thisseqno = int.Parse(parts[1]),
            };
        }

        public string AsString
        {
            get { return Drarecno.ToString() + "|" + Thisseqno.ToString(); }
        }

        public override string ToString()
        {
            return AsString;
        }

    }

}
