// <summary>
// This file is generated automatically. Any changes will be lost.
// </summary>

using System;
using System.Collections.Generic;
using System.Globalization;
using Bsdl.FreshTrade.Repositories.Basic.DBModel;
using Bsdl.FreshTrade.Repositories.Basic.Persistance;

namespace Bsdl.FreshTrade.Repositories.Basic.DBModel
{
    /// <summary>
    /// Entity for the ACCCURRRATE table
    /// </summary>
    public partial class CurrencyRate : BaseDbModel<CurrencyRate, CurrencyRateKey>
    {
#region tableDefs

       public static List<EntityPropDef> GetPropDefs() {
         var result = new List<EntityPropDef>();

//EntityPropDef(string propName, string columnName, bool isKey, bool isNullable, string refEntityName, PropertyInfo keyPropInfo,
//            int size, int? prec, int? scale)



         result.Add(new EntityPropDef(
         PropertyHelper <CurrencyRate>.GetProperty(x => x.Ratcurno),
         "RATCURNO", // columnName
         true,                    //isKey
         false, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  5, // int? prec
                           0  // int? Scale
         ,
         typeof(CurrencyRate)
       ));

         result.Add(new EntityPropDef(
         PropertyHelper <CurrencyRate>.GetProperty(x => x.Ratusefor),
         "RATUSEFOR", // columnName
         true,                    //isKey
         false, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  5, // int? prec
                           0  // int? Scale
         ,
         typeof(CurrencyRate)
       ));


         result.Add(new EntityPropDef(
         PropertyHelper <CurrencyRate>.GetProperty(x => x.Ratratefrombase),
         "RATRATEFROMBASE", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  126, // int? prec
                   
         null // int? Scale
         ,
         typeof(CurrencyRate)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <CurrencyRate>.GetProperty(x => x.Ratratefromeuro),
         "RATRATEFROMEURO", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  126, // int? prec
                   
         null // int? Scale
         ,
         typeof(CurrencyRate)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <CurrencyRate>.GetProperty(x => x.Ratratetobase),
         "RATRATETOBASE", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  126, // int? prec
                   
         null // int? Scale
         ,
         typeof(CurrencyRate)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <CurrencyRate>.GetProperty(x => x.Ratratetoeuro),
         "RATRATETOEURO", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  126, // int? prec
                   
         null // int? Scale
         ,
         typeof(CurrencyRate)
         ));
         return result; 
       }

#endregion     
        private int _fRatcurno;
        public int Ratcurno
        {
            get { return _fRatcurno; }
            set
            {
                var oldKey = Key;
                if (_fRatcurno != value)
                {
                    Modify();
                    _fRatcurno = value;
                    KeyChanged(oldKey);
                }
            }
        }

        private int _fRatusefor;
        public int Ratusefor
        {
            get { return _fRatusefor; }
            set
            {
                var oldKey = Key;
                if (_fRatusefor != value)
                {
                    Modify();
                    _fRatusefor = value;
                    KeyChanged(oldKey);
                }
            }
        }

        private decimal? _fRatratefrombase;
        public decimal? Ratratefrombase
        {
            get { return _fRatratefrombase; }
            set
            {
                if (_fRatratefrombase != value)
                {
                    Modify();
                    _fRatratefrombase = value;
                }
            }
        }

        private decimal? _fRatratefromeuro;
        public decimal? Ratratefromeuro
        {
            get { return _fRatratefromeuro; }
            set
            {
                if (_fRatratefromeuro != value)
                {
                    Modify();
                    _fRatratefromeuro = value;
                }
            }
        }

        private decimal? _fRatratetobase;
        public decimal? Ratratetobase
        {
            get { return _fRatratetobase; }
            set
            {
                if (_fRatratetobase != value)
                {
                    Modify();
                    _fRatratetobase = value;
                }
            }
        }

        private decimal? _fRatratetoeuro;
        public decimal? Ratratetoeuro
        {
            get { return _fRatratetoeuro; }
            set
            {
                if (_fRatratetoeuro != value)
                {
                    Modify();
                    _fRatratetoeuro = value;
                }
            }
        }

        public override CurrencyRateKey Key
        {
            get
            {
                return new CurrencyRateKey { Ratcurno = Ratcurno, Ratusefor = Ratusefor };
            }
            set
            {
                if (value == null)
                    throw new ArgumentNullException("value", "Entity key can not be null.");
                Ratcurno = value.Ratcurno;
                Ratusefor = value.Ratusefor;
            }
        }

        public override string KeyAsString { get { return Key.AsString; } }


        public override CurrencyRate Clone()
        {
            var obj = new CurrencyRate
                {
                    Ratcurno = Ratcurno,
                    Ratusefor = Ratusefor,
                    Ratratefrombase = Ratratefrombase,
                    Ratratefromeuro = Ratratefromeuro,
                    Ratratetobase = Ratratetobase,
                    Ratratetoeuro = Ratratetoeuro,
                };

            return obj;
        }

        public static class FieldNames
        {
// ReSharper disable InconsistentNaming
            public const string  RATCURNO = "RATCURNO";
            public const string  RATUSEFOR = "RATUSEFOR";
            public const string  RATRATEFROMBASE = "RATRATEFROMBASE";
            public const string  RATRATEFROMEURO = "RATRATEFROMEURO";
            public const string  RATRATETOBASE = "RATRATETOBASE";
            public const string  RATRATETOEURO = "RATRATETOEURO";
 // ReSharper restore InconsistentNaming
        }


    }

    /// <summary>
    /// Define type of the primary key property of the ACCCURRRATE entity.
    /// </summary>
    public class CurrencyRateKey : ICompositeKey
    {
        public int Ratcurno { get; set; }
        public int Ratusefor { get; set; }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != GetType()) return false;
            return Equals((CurrencyRateKey)obj);
        }

        protected bool Equals(CurrencyRateKey other)
        {
            return Ratcurno == other.Ratcurno && Ratusefor == other.Ratusefor;
        }

        public override int GetHashCode()
        {
            unchecked
            {
                int hashCode = 0;
                hashCode = (hashCode * 397) ^ (Ratcurno).GetHashCode();
                hashCode = (hashCode * 397) ^ (Ratusefor).GetHashCode();
                return hashCode;
            }
        }

        public static CurrencyRateKey Parse(string key)
        {
            var parts = key.Split('|');
            return new CurrencyRateKey
            {
                Ratcurno = int.Parse(parts[0]),
                Ratusefor = int.Parse(parts[1]),
            };
        }

        public string AsString
        {
            get { return Ratcurno.ToString() + "|" + Ratusefor.ToString(); }
        }

        public override string ToString()
        {
            return AsString;
        }

    }

}
