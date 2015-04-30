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
    /// Entity for the DELTOIST table
    /// </summary>
    public partial class DELTOIST : BaseDbModel<DELTOIST, DELTOISTKey>
    {
#region tableDefs

       public static List<EntityPropDef> GetPropDefs() {
         var result = new List<EntityPropDef>();

//EntityPropDef(string propName, string columnName, bool isKey, bool isNullable, string refEntityName, PropertyInfo keyPropInfo,
//            int size, int? prec, int? scale)



         result.Add(new EntityPropDef(
         PropertyHelper <DELTOIST>.GetProperty(x => x.Disdprrecno),
         "DISDPRRECNO", // columnName
         true,                    //isKey
         false, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  10, // int? prec
                           0  // int? Scale
         ,
         typeof(DELTOIST)
       ));

         result.Add(new EntityPropDef(
         PropertyHelper <DELTOIST>.GetProperty(x => x.Disistrecno),
         "DISISTRECNO", // columnName
         true,                    //isKey
         false, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  10, // int? prec
                           0  // int? Scale
         ,
         typeof(DELTOIST)
       ));


         result.Add(new EntityPropDef(
         PropertyHelper <DELTOIST>.GetProperty(x => x.Discdsrefno),
         "DISCDSREFNO", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  5, // int? prec
                           0  // int? Scale
         ,
         typeof(DELTOIST)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <DELTOIST>.GetProperty(x => x.Disnettvalue),
         "DISNETTVALUE", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  126, // int? prec
                   
         null // int? Scale
         ,
         typeof(DELTOIST)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <DELTOIST>.GetProperty(x => x.Disqty),
         "DISQTY", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  10, // int? prec
                           0  // int? Scale
         ,
         typeof(DELTOIST)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <DELTOIST>.GetProperty(x => x.Disstkqty),
         "DISSTKQTY", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  10, // int? prec
                           0  // int? Scale
         ,
         typeof(DELTOIST)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <DELTOIST>.GetProperty(x => x.Disstkweight),
         "DISSTKWEIGHT", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  126, // int? prec
                   
         null // int? Scale
         ,
         typeof(DELTOIST)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <DELTOIST>.GetProperty(x => x.Disvalue),
         "DISVALUE", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  126, // int? prec
                   
         null // int? Scale
         ,
         typeof(DELTOIST)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <DELTOIST>.GetProperty(x => x.Disweight),
         "DISWEIGHT", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  126, // int? prec
                   
         null // int? Scale
         ,
         typeof(DELTOIST)
         ));
         return result; 
       }

#endregion     
        private int _fDisdprrecno;
        public int Disdprrecno
        {
            get { return _fDisdprrecno; }
            set
            {
                var oldKey = Key;
                if (_fDisdprrecno != value)
                {
                    Modify();
                    _fDisdprrecno = value;
                    KeyChanged(oldKey);
                }
            }
        }

        private int _fDisistrecno;
        public int Disistrecno
        {
            get { return _fDisistrecno; }
            set
            {
                var oldKey = Key;
                if (_fDisistrecno != value)
                {
                    Modify();
                    _fDisistrecno = value;
                    KeyChanged(oldKey);
                }
            }
        }

        private int? _fDiscdsrefno;
        public int? Discdsrefno
        {
            get { return _fDiscdsrefno; }
            set
            {
                if (_fDiscdsrefno != value)
                {
                    Modify();
                    _fDiscdsrefno = value;
                }
            }
        }

        private decimal? _fDisnettvalue;
        public decimal? Disnettvalue
        {
            get { return _fDisnettvalue; }
            set
            {
                if (_fDisnettvalue != value)
                {
                    Modify();
                    _fDisnettvalue = value;
                }
            }
        }

        private int? _fDisqty;
        public int? Disqty
        {
            get { return _fDisqty; }
            set
            {
                if (_fDisqty != value)
                {
                    Modify();
                    _fDisqty = value;
                }
            }
        }

        private int? _fDisstkqty;
        public int? Disstkqty
        {
            get { return _fDisstkqty; }
            set
            {
                if (_fDisstkqty != value)
                {
                    Modify();
                    _fDisstkqty = value;
                }
            }
        }

        private decimal? _fDisstkweight;
        public decimal? Disstkweight
        {
            get { return _fDisstkweight; }
            set
            {
                if (_fDisstkweight != value)
                {
                    Modify();
                    _fDisstkweight = value;
                }
            }
        }

        private decimal? _fDisvalue;
        public decimal? Disvalue
        {
            get { return _fDisvalue; }
            set
            {
                if (_fDisvalue != value)
                {
                    Modify();
                    _fDisvalue = value;
                }
            }
        }

        private decimal? _fDisweight;
        public decimal? Disweight
        {
            get { return _fDisweight; }
            set
            {
                if (_fDisweight != value)
                {
                    Modify();
                    _fDisweight = value;
                }
            }
        }

        public override DELTOISTKey Key
        {
            get
            {
                return new DELTOISTKey { Disdprrecno = Disdprrecno, Disistrecno = Disistrecno };
            }
            set
            {
                if (value == null)
                    throw new ArgumentNullException("value", "Entity key can not be null.");
                Disdprrecno = value.Disdprrecno;
                Disistrecno = value.Disistrecno;
            }
        }

        public override string KeyAsString { get { return Key.AsString; } }


        public override DELTOIST Clone()
        {
            var obj = new DELTOIST
                {
                    Disdprrecno = Disdprrecno,
                    Disistrecno = Disistrecno,
                    Discdsrefno = Discdsrefno,
                    Disnettvalue = Disnettvalue,
                    Disqty = Disqty,
                    Disstkqty = Disstkqty,
                    Disstkweight = Disstkweight,
                    Disvalue = Disvalue,
                    Disweight = Disweight,
                };

            return obj;
        }

        public static class FieldNames
        {
// ReSharper disable InconsistentNaming
            public const string  DISDPRRECNO = "DISDPRRECNO";
            public const string  DISISTRECNO = "DISISTRECNO";
            public const string  DISCDSREFNO = "DISCDSREFNO";
            public const string  DISNETTVALUE = "DISNETTVALUE";
            public const string  DISQTY = "DISQTY";
            public const string  DISSTKQTY = "DISSTKQTY";
            public const string  DISSTKWEIGHT = "DISSTKWEIGHT";
            public const string  DISVALUE = "DISVALUE";
            public const string  DISWEIGHT = "DISWEIGHT";
 // ReSharper restore InconsistentNaming
        }


    }

    /// <summary>
    /// Define type of the primary key property of the DELTOIST entity.
    /// </summary>
    public class DELTOISTKey : ICompositeKey
    {
        public int Disdprrecno { get; set; }
        public int Disistrecno { get; set; }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != GetType()) return false;
            return Equals((DELTOISTKey)obj);
        }

        protected bool Equals(DELTOISTKey other)
        {
            return Disdprrecno == other.Disdprrecno && Disistrecno == other.Disistrecno;
        }

        public override int GetHashCode()
        {
            unchecked
            {
                int hashCode = 0;
                hashCode = (hashCode * 397) ^ (Disdprrecno).GetHashCode();
                hashCode = (hashCode * 397) ^ (Disistrecno).GetHashCode();
                return hashCode;
            }
        }

        public static DELTOISTKey Parse(string key)
        {
            var parts = key.Split('|');
            return new DELTOISTKey
            {
                Disdprrecno = int.Parse(parts[0]),
                Disistrecno = int.Parse(parts[1]),
            };
        }

        public string AsString
        {
            get { return Disdprrecno.ToString() + "|" + Disistrecno.ToString(); }
        }

        public override string ToString()
        {
            return AsString;
        }

    }

}
