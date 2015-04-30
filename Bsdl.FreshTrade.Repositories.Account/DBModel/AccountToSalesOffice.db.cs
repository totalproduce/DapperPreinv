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
    /// Entity for the ACCTOSALOFF table
    /// </summary>
    public partial class AccountToSalesOffice : BaseDbModel<AccountToSalesOffice, AccountToSalesOfficeKey>
    {
#region tableDefs

       public static List<EntityPropDef> GetPropDefs() {
         var result = new List<EntityPropDef>();

//EntityPropDef(string propName, string columnName, bool isKey, bool isNullable, string refEntityName, PropertyInfo keyPropInfo,
//            int size, int? prec, int? scale)



         result.Add(new EntityPropDef(
         PropertyHelper <AccountToSalesOffice>.GetProperty(x => x.Acsclarecno),
         "ACSCLARECNO", // columnName
         true,                    //isKey
         false, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  10, // int? prec
                           0  // int? Scale
         ,
         typeof(AccountToSalesOffice)
       ));

         result.Add(new EntityPropDef(
         PropertyHelper <AccountToSalesOffice>.GetProperty(x => x.Acssaloffno),
         "ACSSALOFFNO", // columnName
         true,                    //isKey
         false, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  5, // int? prec
                           0  // int? Scale
         ,
         typeof(AccountToSalesOffice)
       ));


         result.Add(new EntityPropDef(
         PropertyHelper <AccountToSalesOffice>.GetProperty(x => x.Acctosalbacsreq),
         "ACCTOSALBACSREQ", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  1, // int? prec
                           0  // int? Scale
         ,
         typeof(AccountToSalesOffice)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <AccountToSalesOffice>.GetProperty(x => x.Acsacccode),
         "ACSACCCODE", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         8,       // int size   
                  null, // int? prec
                   
         null // int? Scale
         ,
         typeof(AccountToSalesOffice)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <AccountToSalesOffice>.GetProperty(x => x.Acsarcreditlimit),
         "ACSARCREDITLIMIT", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  126, // int? prec
                   
         null // int? Scale
         ,
         typeof(AccountToSalesOffice)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <AccountToSalesOffice>.GetProperty(x => x.Acscannotview),
         "ACSCANNOTVIEW", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  1, // int? prec
                           0  // int? Scale
         ,
         typeof(AccountToSalesOffice)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <AccountToSalesOffice>.GetProperty(x => x.Acsismaincst),
         "ACSISMAINCST", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  1, // int? prec
                           0  // int? Scale
         ,
         typeof(AccountToSalesOffice)
         ));
         return result; 
       }

#endregion     
        private int _fAcsclarecno;
        public int Acsclarecno
        {
            get { return _fAcsclarecno; }
            set
            {
                var oldKey = Key;
                if (_fAcsclarecno != value)
                {
                    Modify();
                    _fAcsclarecno = value;
                    KeyChanged(oldKey);
                }
            }
        }

        private int _fAcssaloffno;
        public int Acssaloffno
        {
            get { return _fAcssaloffno; }
            set
            {
                var oldKey = Key;
                if (_fAcssaloffno != value)
                {
                    Modify();
                    _fAcssaloffno = value;
                    KeyChanged(oldKey);
                }
            }
        }

        private short? _fAcctosalbacsreq;
        public short? Acctosalbacsreq
        {
            get { return _fAcctosalbacsreq; }
            set
            {
                if (_fAcctosalbacsreq != value)
                {
                    Modify();
                    _fAcctosalbacsreq = value;
                }
            }
        }

        private string _fAcsacccode;
        public string Acsacccode
        {
            get { return _fAcsacccode; }
            set
            {
                if (_fAcsacccode != value)
                {
                    Modify();
                    _fAcsacccode = value;
                }
            }
        }

        private decimal? _fAcsarcreditlimit;
        public decimal? Acsarcreditlimit
        {
            get { return _fAcsarcreditlimit; }
            set
            {
                if (_fAcsarcreditlimit != value)
                {
                    Modify();
                    _fAcsarcreditlimit = value;
                }
            }
        }

        private short? _fAcscannotview;
        public short? Acscannotview
        {
            get { return _fAcscannotview; }
            set
            {
                if (_fAcscannotview != value)
                {
                    Modify();
                    _fAcscannotview = value;
                }
            }
        }

        private short? _fAcsismaincst;
        public short? Acsismaincst
        {
            get { return _fAcsismaincst; }
            set
            {
                if (_fAcsismaincst != value)
                {
                    Modify();
                    _fAcsismaincst = value;
                }
            }
        }

        public override AccountToSalesOfficeKey Key
        {
            get
            {
                return new AccountToSalesOfficeKey { Acsclarecno = Acsclarecno, Acssaloffno = Acssaloffno };
            }
            set
            {
                if (value == null)
                    throw new ArgumentNullException("value", "Entity key can not be null.");
                Acsclarecno = value.Acsclarecno;
                Acssaloffno = value.Acssaloffno;
            }
        }

        public override string KeyAsString { get { return Key.AsString; } }


        public override AccountToSalesOffice Clone()
        {
            var obj = new AccountToSalesOffice
                {
                    Acsclarecno = Acsclarecno,
                    Acssaloffno = Acssaloffno,
                    Acctosalbacsreq = Acctosalbacsreq,
                    Acsacccode = Acsacccode,
                    Acsarcreditlimit = Acsarcreditlimit,
                    Acscannotview = Acscannotview,
                    Acsismaincst = Acsismaincst,
                };

            return obj;
        }

        public static class FieldNames
        {
// ReSharper disable InconsistentNaming
            public const string  ACSCLARECNO = "ACSCLARECNO";
            public const string  ACSSALOFFNO = "ACSSALOFFNO";
            public const string  ACCTOSALBACSREQ = "ACCTOSALBACSREQ";
            public const string  ACSACCCODE = "ACSACCCODE";
            public const string  ACSARCREDITLIMIT = "ACSARCREDITLIMIT";
            public const string  ACSCANNOTVIEW = "ACSCANNOTVIEW";
            public const string  ACSISMAINCST = "ACSISMAINCST";
 // ReSharper restore InconsistentNaming
        }


    }

    /// <summary>
    /// Define type of the primary key property of the ACCTOSALOFF entity.
    /// </summary>
    public class AccountToSalesOfficeKey : ICompositeKey
    {
        public int Acsclarecno { get; set; }
        public int Acssaloffno { get; set; }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != GetType()) return false;
            return Equals((AccountToSalesOfficeKey)obj);
        }

        protected bool Equals(AccountToSalesOfficeKey other)
        {
            return Acsclarecno == other.Acsclarecno && Acssaloffno == other.Acssaloffno;
        }

        public override int GetHashCode()
        {
            unchecked
            {
                int hashCode = 0;
                hashCode = (hashCode * 397) ^ (Acsclarecno).GetHashCode();
                hashCode = (hashCode * 397) ^ (Acssaloffno).GetHashCode();
                return hashCode;
            }
        }

        public static AccountToSalesOfficeKey Parse(string key)
        {
            var parts = key.Split('|');
            return new AccountToSalesOfficeKey
            {
                Acsclarecno = int.Parse(parts[0]),
                Acssaloffno = int.Parse(parts[1]),
            };
        }

        public string AsString
        {
            get { return Acsclarecno.ToString() + "|" + Acssaloffno.ToString(); }
        }

        public override string ToString()
        {
            return AsString;
        }

    }

}
