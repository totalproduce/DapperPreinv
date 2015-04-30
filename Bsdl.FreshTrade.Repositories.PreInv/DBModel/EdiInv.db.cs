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
    /// Entity for the EDIINV table
    /// </summary>
    public partial class EdiInv : BaseDbModel<EdiInv, EdiInvKey>
    {
#region tableDefs

       public static List<EntityPropDef> GetPropDefs() {
         var result = new List<EntityPropDef>();

//EntityPropDef(string propName, string columnName, bool isKey, bool isNullable, string refEntityName, PropertyInfo keyPropInfo,
//            int size, int? prec, int? scale)



         result.Add(new EntityPropDef(
         PropertyHelper <EdiInv>.GetProperty(x => x.Coglbno),
         "COGLBNO", // columnName
         true,                    //isKey
         false, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  5, // int? prec
                           0  // int? Scale
         ,
         typeof(EdiInv)
       ));

         result.Add(new EntityPropDef(
         PropertyHelper <EdiInv>.GetProperty(x => x.Hofcstcode),
         "HOFCSTCODE", // columnName
         true,                    //isKey
         false, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         8,       // int size   
           
         null, // int? prec
                    
         null // int? Scale
         ,
         typeof(EdiInv)
       ));

         result.Add(new EntityPropDef(
         PropertyHelper <EdiInv>.GetProperty(x => x.Hofclarecno),
         "HOFCLARECNO", // columnName
         true,                    //isKey
         false, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  10, // int? prec
                           0  // int? Scale
         ,
         typeof(EdiInv)
       ));

         result.Add(new EntityPropDef(
         PropertyHelper <EdiInv>.GetProperty(x => x.Invoiceno),
         "INVOICENO", // columnName
         true,                    //isKey
         false, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         12,       // int size   
           
         null, // int? prec
                    
         null // int? Scale
         ,
         typeof(EdiInv)
       ));

         result.Add(new EntityPropDef(
         PropertyHelper <EdiInv>.GetProperty(x => x.Dlvordno),
         "DLVORDNO", // columnName
         true,                    //isKey
         false, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  10, // int? prec
                           0  // int? Scale
         ,
         typeof(EdiInv)
       ));


         result.Add(new EntityPropDef(
         PropertyHelper <EdiInv>.GetProperty(x => x.Atrrecno),
         "ATRRECNO", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  10, // int? prec
                           0  // int? Scale
         ,
         typeof(EdiInv)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <EdiInv>.GetProperty(x => x.Clarecno),
         "CLARECNO", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  10, // int? prec
                           0  // int? Scale
         ,
         typeof(EdiInv)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <EdiInv>.GetProperty(x => x.Cleared),
         "CLEARED", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  5, // int? prec
                           0  // int? Scale
         ,
         typeof(EdiInv)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <EdiInv>.GetProperty(x => x.Dlvdeldate),
         "DLVDELDATE", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  null, // int? prec
                   
         null // int? Scale
         ,
         typeof(EdiInv)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <EdiInv>.GetProperty(x => x.Dlvpodno),
         "DLVPODNO", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         15,       // int size   
                  null, // int? prec
                   
         null // int? Scale
         ,
         typeof(EdiInv)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <EdiInv>.GetProperty(x => x.Dlvshpdate),
         "DLVSHPDATE", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  null, // int? prec
                   
         null // int? Scale
         ,
         typeof(EdiInv)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <EdiInv>.GetProperty(x => x.Ediinvrecno),
         "EDIINVRECNO", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  10, // int? prec
                           0  // int? Scale
         ,
         typeof(EdiInv)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <EdiInv>.GetProperty(x => x.Filetype),
         "FILETYPE", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         16,       // int size   
                  null, // int? prec
                   
         null // int? Scale
         ,
         typeof(EdiInv)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <EdiInv>.GetProperty(x => x.Ftdlvordno),
         "FTDLVORDNO", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  10, // int? prec
                           0  // int? Scale
         ,
         typeof(EdiInv)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <EdiInv>.GetProperty(x => x.Invamt),
         "INVAMT", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  126, // int? prec
                   
         null // int? Scale
         ,
         typeof(EdiInv)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <EdiInv>.GetProperty(x => x.Invdate),
         "INVDATE", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  null, // int? prec
                   
         null // int? Scale
         ,
         typeof(EdiInv)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <EdiInv>.GetProperty(x => x.Invvatamt),
         "INVVATAMT", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  126, // int? prec
                   
         null // int? Scale
         ,
         typeof(EdiInv)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <EdiInv>.GetProperty(x => x.Ordcstcode),
         "ORDCSTCODE", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         8,       // int size   
                  null, // int? prec
                   
         null // int? Scale
         ,
         typeof(EdiInv)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <EdiInv>.GetProperty(x => x.Orddate),
         "ORDDATE", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  null, // int? prec
                   
         null // int? Scale
         ,
         typeof(EdiInv)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <EdiInv>.GetProperty(x => x.Ordno),
         "ORDNO", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         12,       // int size   
                  null, // int? prec
                   
         null // int? Scale
         ,
         typeof(EdiInv)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <EdiInv>.GetProperty(x => x.Ordref),
         "ORDREF", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         15,       // int size   
                  null, // int? prec
                   
         null // int? Scale
         ,
         typeof(EdiInv)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <EdiInv>.GetProperty(x => x.Porrecno),
         "PORRECNO", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  10, // int? prec
                           0  // int? Scale
         ,
         typeof(EdiInv)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <EdiInv>.GetProperty(x => x.Saloffno),
         "SALOFFNO", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  5, // int? prec
                           0  // int? Scale
         ,
         typeof(EdiInv)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <EdiInv>.GetProperty(x => x.Supplieracccode),
         "SUPPLIERACCCODE", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         8,       // int size   
                  null, // int? prec
                   
         null // int? Scale
         ,
         typeof(EdiInv)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <EdiInv>.GetProperty(x => x.Supplierclarecno),
         "SUPPLIERCLARECNO", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  10, // int? prec
                           0  // int? Scale
         ,
         typeof(EdiInv)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <EdiInv>.GetProperty(x => x.Uplrecnoin),
         "UPLRECNOIN", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  10, // int? prec
                           0  // int? Scale
         ,
         typeof(EdiInv)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <EdiInv>.GetProperty(x => x.Uplrecnoout),
         "UPLRECNOOUT", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  10, // int? prec
                           0  // int? Scale
         ,
         typeof(EdiInv)
         ));
         return result; 
       }

#endregion     
        private int _fCoglbno;
        public int Coglbno
        {
            get { return _fCoglbno; }
            set
            {
                var oldKey = Key;
                if (_fCoglbno != value)
                {
                    Modify();
                    _fCoglbno = value;
                    KeyChanged(oldKey);
                }
            }
        }

        private string _fHofcstcode;
        public string Hofcstcode
        {
            get { return _fHofcstcode; }
            set
            {
                var oldKey = Key;
                if (_fHofcstcode != value)
                {
                    Modify();
                    _fHofcstcode = value;
                    KeyChanged(oldKey);
                }
            }
        }

        private int _fHofclarecno;
        public int Hofclarecno
        {
            get { return _fHofclarecno; }
            set
            {
                var oldKey = Key;
                if (_fHofclarecno != value)
                {
                    Modify();
                    _fHofclarecno = value;
                    KeyChanged(oldKey);
                }
            }
        }

        private string _fInvoiceno;
        public string Invoiceno
        {
            get { return _fInvoiceno; }
            set
            {
                var oldKey = Key;
                if (_fInvoiceno != value)
                {
                    Modify();
                    _fInvoiceno = value;
                    KeyChanged(oldKey);
                }
            }
        }

        private int _fDlvordno;
        public int Dlvordno
        {
            get { return _fDlvordno; }
            set
            {
                var oldKey = Key;
                if (_fDlvordno != value)
                {
                    Modify();
                    _fDlvordno = value;
                    KeyChanged(oldKey);
                }
            }
        }

        private int? _fAtrrecno;
        public int? Atrrecno
        {
            get { return _fAtrrecno; }
            set
            {
                if (_fAtrrecno != value)
                {
                    Modify();
                    _fAtrrecno = value;
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

        private int? _fCleared;
        public int? Cleared
        {
            get { return _fCleared; }
            set
            {
                if (_fCleared != value)
                {
                    Modify();
                    _fCleared = value;
                }
            }
        }

        private DateTime? _fDlvdeldate;
        public DateTime? Dlvdeldate
        {
            get { return _fDlvdeldate; }
            set
            {
                if (_fDlvdeldate != value)
                {
                    Modify();
                    _fDlvdeldate = value;
                }
            }
        }

        private string _fDlvpodno;
        public string Dlvpodno
        {
            get { return _fDlvpodno; }
            set
            {
                if (_fDlvpodno != value)
                {
                    Modify();
                    _fDlvpodno = value;
                }
            }
        }

        private DateTime? _fDlvshpdate;
        public DateTime? Dlvshpdate
        {
            get { return _fDlvshpdate; }
            set
            {
                if (_fDlvshpdate != value)
                {
                    Modify();
                    _fDlvshpdate = value;
                }
            }
        }

        private int? _fEdiinvrecno;
        public int? Ediinvrecno
        {
            get { return _fEdiinvrecno; }
            set
            {
                if (_fEdiinvrecno != value)
                {
                    Modify();
                    _fEdiinvrecno = value;
                }
            }
        }

        private string _fFiletype;
        public string Filetype
        {
            get { return _fFiletype; }
            set
            {
                if (_fFiletype != value)
                {
                    Modify();
                    _fFiletype = value;
                }
            }
        }

        private int? _fFtdlvordno;
        public int? Ftdlvordno
        {
            get { return _fFtdlvordno; }
            set
            {
                if (_fFtdlvordno != value)
                {
                    Modify();
                    _fFtdlvordno = value;
                }
            }
        }

        private decimal? _fInvamt;
        public decimal? Invamt
        {
            get { return _fInvamt; }
            set
            {
                if (_fInvamt != value)
                {
                    Modify();
                    _fInvamt = value;
                }
            }
        }

        private DateTime? _fInvdate;
        public DateTime? Invdate
        {
            get { return _fInvdate; }
            set
            {
                if (_fInvdate != value)
                {
                    Modify();
                    _fInvdate = value;
                }
            }
        }

        private decimal? _fInvvatamt;
        public decimal? Invvatamt
        {
            get { return _fInvvatamt; }
            set
            {
                if (_fInvvatamt != value)
                {
                    Modify();
                    _fInvvatamt = value;
                }
            }
        }

        private string _fOrdcstcode;
        public string Ordcstcode
        {
            get { return _fOrdcstcode; }
            set
            {
                if (_fOrdcstcode != value)
                {
                    Modify();
                    _fOrdcstcode = value;
                }
            }
        }

        private DateTime? _fOrddate;
        public DateTime? Orddate
        {
            get { return _fOrddate; }
            set
            {
                if (_fOrddate != value)
                {
                    Modify();
                    _fOrddate = value;
                }
            }
        }

        private string _fOrdno;
        public string Ordno
        {
            get { return _fOrdno; }
            set
            {
                if (_fOrdno != value)
                {
                    Modify();
                    _fOrdno = value;
                }
            }
        }

        private string _fOrdref;
        public string Ordref
        {
            get { return _fOrdref; }
            set
            {
                if (_fOrdref != value)
                {
                    Modify();
                    _fOrdref = value;
                }
            }
        }

        private int? _fPorrecno;
        public int? Porrecno
        {
            get { return _fPorrecno; }
            set
            {
                if (_fPorrecno != value)
                {
                    Modify();
                    _fPorrecno = value;
                }
            }
        }

        private int? _fSaloffno;
        public int? Saloffno
        {
            get { return _fSaloffno; }
            set
            {
                if (_fSaloffno != value)
                {
                    Modify();
                    _fSaloffno = value;
                }
            }
        }

        private string _fSupplieracccode;
        public string Supplieracccode
        {
            get { return _fSupplieracccode; }
            set
            {
                if (_fSupplieracccode != value)
                {
                    Modify();
                    _fSupplieracccode = value;
                }
            }
        }

        private int? _fSupplierclarecno;
        public int? Supplierclarecno
        {
            get { return _fSupplierclarecno; }
            set
            {
                if (_fSupplierclarecno != value)
                {
                    Modify();
                    _fSupplierclarecno = value;
                }
            }
        }

        private int? _fUplrecnoin;
        public int? Uplrecnoin
        {
            get { return _fUplrecnoin; }
            set
            {
                if (_fUplrecnoin != value)
                {
                    Modify();
                    _fUplrecnoin = value;
                }
            }
        }

        private int? _fUplrecnoout;
        public int? Uplrecnoout
        {
            get { return _fUplrecnoout; }
            set
            {
                if (_fUplrecnoout != value)
                {
                    Modify();
                    _fUplrecnoout = value;
                }
            }
        }

        public override EdiInvKey Key
        {
            get
            {
                return new EdiInvKey { Coglbno = Coglbno, Hofcstcode = Hofcstcode, Hofclarecno = Hofclarecno, Invoiceno = Invoiceno, Dlvordno = Dlvordno };
            }
            set
            {
                if (value == null)
                    throw new ArgumentNullException("value", "Entity key can not be null.");
                Coglbno = value.Coglbno;
                Hofcstcode = value.Hofcstcode;
                Hofclarecno = value.Hofclarecno;
                Invoiceno = value.Invoiceno;
                Dlvordno = value.Dlvordno;
            }
        }

        public override string KeyAsString { get { return Key.AsString; } }


        public override EdiInv Clone()
        {
            var obj = new EdiInv
                {
                    Coglbno = Coglbno,
                    Hofcstcode = Hofcstcode,
                    Hofclarecno = Hofclarecno,
                    Invoiceno = Invoiceno,
                    Dlvordno = Dlvordno,
                    Atrrecno = Atrrecno,
                    Clarecno = Clarecno,
                    Cleared = Cleared,
                    Dlvdeldate = Dlvdeldate,
                    Dlvpodno = Dlvpodno,
                    Dlvshpdate = Dlvshpdate,
                    Ediinvrecno = Ediinvrecno,
                    Filetype = Filetype,
                    Ftdlvordno = Ftdlvordno,
                    Invamt = Invamt,
                    Invdate = Invdate,
                    Invvatamt = Invvatamt,
                    Ordcstcode = Ordcstcode,
                    Orddate = Orddate,
                    Ordno = Ordno,
                    Ordref = Ordref,
                    Porrecno = Porrecno,
                    Saloffno = Saloffno,
                    Supplieracccode = Supplieracccode,
                    Supplierclarecno = Supplierclarecno,
                    Uplrecnoin = Uplrecnoin,
                    Uplrecnoout = Uplrecnoout,
                };

            return obj;
        }

        public static class FieldNames
        {
// ReSharper disable InconsistentNaming
            public const string  COGLBNO = "COGLBNO";
            public const string  HOFCSTCODE = "HOFCSTCODE";
            public const string  HOFCLARECNO = "HOFCLARECNO";
            public const string  INVOICENO = "INVOICENO";
            public const string  DLVORDNO = "DLVORDNO";
            public const string  ATRRECNO = "ATRRECNO";
            public const string  CLARECNO = "CLARECNO";
            public const string  CLEARED = "CLEARED";
            public const string  DLVDELDATE = "DLVDELDATE";
            public const string  DLVPODNO = "DLVPODNO";
            public const string  DLVSHPDATE = "DLVSHPDATE";
            public const string  EDIINVRECNO = "EDIINVRECNO";
            public const string  FILETYPE = "FILETYPE";
            public const string  FTDLVORDNO = "FTDLVORDNO";
            public const string  INVAMT = "INVAMT";
            public const string  INVDATE = "INVDATE";
            public const string  INVVATAMT = "INVVATAMT";
            public const string  ORDCSTCODE = "ORDCSTCODE";
            public const string  ORDDATE = "ORDDATE";
            public const string  ORDNO = "ORDNO";
            public const string  ORDREF = "ORDREF";
            public const string  PORRECNO = "PORRECNO";
            public const string  SALOFFNO = "SALOFFNO";
            public const string  SUPPLIERACCCODE = "SUPPLIERACCCODE";
            public const string  SUPPLIERCLARECNO = "SUPPLIERCLARECNO";
            public const string  UPLRECNOIN = "UPLRECNOIN";
            public const string  UPLRECNOOUT = "UPLRECNOOUT";
 // ReSharper restore InconsistentNaming
        }


    }

    /// <summary>
    /// Define type of the primary key property of the EDIINV entity.
    /// </summary>
    public class EdiInvKey : ICompositeKey
    {
        public int Coglbno { get; set; }
        public string Hofcstcode { get; set; }
        public int Hofclarecno { get; set; }
        public string Invoiceno { get; set; }
        public int Dlvordno { get; set; }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != GetType()) return false;
            return Equals((EdiInvKey)obj);
        }

        protected bool Equals(EdiInvKey other)
        {
            return Coglbno == other.Coglbno && Hofcstcode == other.Hofcstcode && Hofclarecno == other.Hofclarecno && Invoiceno == other.Invoiceno && Dlvordno == other.Dlvordno;
        }

        public override int GetHashCode()
        {
            unchecked
            {
                int hashCode = 0;
                hashCode = (hashCode * 397) ^ (Coglbno).GetHashCode();
                hashCode = (hashCode * 397) ^ (Hofcstcode ?? "").GetHashCode();
                hashCode = (hashCode * 397) ^ (Hofclarecno).GetHashCode();
                hashCode = (hashCode * 397) ^ (Invoiceno ?? "").GetHashCode();
                hashCode = (hashCode * 397) ^ (Dlvordno).GetHashCode();
                return hashCode;
            }
        }

        public static EdiInvKey Parse(string key)
        {
            var parts = key.Split('|');
            return new EdiInvKey
            {
                Coglbno = int.Parse(parts[0]),
                Hofcstcode = parts[1],
                Hofclarecno = int.Parse(parts[2]),
                Invoiceno = parts[3],
                Dlvordno = int.Parse(parts[4]),
            };
        }

        public string AsString
        {
            get { return Coglbno.ToString() + "|" + Hofcstcode.ToString() + "|" + Hofclarecno.ToString() + "|" + Invoiceno.ToString() + "|" + Dlvordno.ToString(); }
        }

        public override string ToString()
        {
            return AsString;
        }

    }

}
