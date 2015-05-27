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
    /// Entity for the CDTNONREL table
    /// </summary>
    public partial class CreditNoteToDelivery : BaseDbModel<CreditNoteToDelivery, CreditNoteToDeliveryKey>
    {
#region tableDefs

       public static List<EntityPropDef> GetPropDefs() {
         var result = new List<EntityPropDef>();

//EntityPropDef(string propName, string columnName, bool isKey, bool isNullable, string refEntityName, PropertyInfo keyPropInfo,
//            int size, int? prec, int? scale)



         result.Add(new EntityPropDef(
         PropertyHelper <CreditNoteToDelivery>.GetProperty(x => x.Dprrecno),
         "DPRRECNO", // columnName
         true,                    //isKey
         false, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  10, // int? prec
                           0  // int? Scale
         ,
         typeof(CreditNoteToDelivery)
       ));

         result.Add(new EntityPropDef(
         PropertyHelper <CreditNoteToDelivery>.GetProperty(x => x.Pallocrecno),
         "PALLOCRECNO", // columnName
         true,                    //isKey
         false, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  10, // int? prec
                           0  // int? Scale
         ,
         typeof(CreditNoteToDelivery)
       ));


         result.Add(new EntityPropDef(
         PropertyHelper <CreditNoteToDelivery>.GetProperty(x => x.Dlvordno),
         "DLVORDNO", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  10, // int? prec
                           0  // int? Scale
         ,
         typeof(CreditNoteToDelivery)
         ));
         return result; 
       }

#endregion     
        private int _fDprrecno;
        public int Dprrecno
        {
            get { return _fDprrecno; }
            set
            {
                var oldKey = Key;
                if (_fDprrecno != value)
                {
                    Modify();
                    _fDprrecno = value;
                    KeyChanged(oldKey);
                }
            }
        }

        private int _fPallocrecno;
        public int Pallocrecno
        {
            get { return _fPallocrecno; }
            set
            {
                var oldKey = Key;
                if (_fPallocrecno != value)
                {
                    Modify();
                    _fPallocrecno = value;
                    KeyChanged(oldKey);
                }
            }
        }

        private int? _fDlvordno;
        public int? Dlvordno
        {
            get { return _fDlvordno; }
            set
            {
                if (_fDlvordno != value)
                {
                    Modify();
                    _fDlvordno = value;
                }
            }
        }

        public override CreditNoteToDeliveryKey Key
        {
            get
            {
                return new CreditNoteToDeliveryKey { Dprrecno = Dprrecno, Pallocrecno = Pallocrecno };
            }
            set
            {
                if (value == null)
                    throw new ArgumentNullException("value", "Entity key can not be null.");
                Dprrecno = value.Dprrecno;
                Pallocrecno = value.Pallocrecno;
            }
        }

        public override string KeyAsString { get { return Key.AsString; } }


        public override CreditNoteToDelivery Clone()
        {
            var obj = new CreditNoteToDelivery
                {
                    Dprrecno = Dprrecno,
                    Pallocrecno = Pallocrecno,
                    Dlvordno = Dlvordno,
                };

            return obj;
        }

        public static class FieldNames
        {
// ReSharper disable InconsistentNaming
            public const string  DPRRECNO = "DPRRECNO";
            public const string  PALLOCRECNO = "PALLOCRECNO";
            public const string  DLVORDNO = "DLVORDNO";
 // ReSharper restore InconsistentNaming
        }


    }

    /// <summary>
    /// Define type of the primary key property of the CDTNONREL entity.
    /// </summary>
    public class CreditNoteToDeliveryKey : ICompositeKey
    {
        public int Dprrecno { get; set; }
        public int Pallocrecno { get; set; }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != GetType()) return false;
            return Equals((CreditNoteToDeliveryKey)obj);
        }

        protected bool Equals(CreditNoteToDeliveryKey other)
        {
            return Dprrecno == other.Dprrecno && Pallocrecno == other.Pallocrecno;
        }

        public override int GetHashCode()
        {
            unchecked
            {
                int hashCode = 0;
                hashCode = (hashCode * 397) ^ (Dprrecno).GetHashCode();
                hashCode = (hashCode * 397) ^ (Pallocrecno).GetHashCode();
                return hashCode;
            }
        }

        public static CreditNoteToDeliveryKey Parse(string key)
        {
            var parts = key.Split('|');
            return new CreditNoteToDeliveryKey
            {
                Dprrecno = int.Parse(parts[0]),
                Pallocrecno = int.Parse(parts[1]),
            };
        }

        public string AsString
        {
            get { return Dprrecno.ToString() + "|" + Pallocrecno.ToString(); }
        }

        public override string ToString()
        {
            return AsString;
        }

    }

}
