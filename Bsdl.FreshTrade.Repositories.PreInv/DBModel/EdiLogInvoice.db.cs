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
    /// Entity for the EDILOGINVOICE table
    /// </summary>
    public partial class EdiLogInvoice : BaseDbModel<EdiLogInvoice, int>
    {
#region tableDefs

       public static List<EntityPropDef> GetPropDefs() {
         var result = new List<EntityPropDef>();

//EntityPropDef(string propName, string columnName, bool isKey, bool isNullable, string refEntityName, PropertyInfo keyPropInfo,
//            int size, int? prec, int? scale)



         result.Add(new EntityPropDef(
         PropertyHelper <EdiLogInvoice>.GetProperty(x => x.Eiinvoiceid),
         "EIINVOICEID", // columnName
         true,                    //isKey
         false, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  10, // int? prec
                           0  // int? Scale
         ,
         typeof(EdiLogInvoice)
       ));


         result.Add(new EntityPropDef(
         PropertyHelper <EdiLogInvoice>.GetProperty(x => x.Eiatrrecno),
         "EIATRRECNO", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  10, // int? prec
                           0  // int? Scale
         ,
         typeof(EdiLogInvoice)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <EdiLogInvoice>.GetProperty(x => x.Eiheadid),
         "EIHEADID", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  10, // int? prec
                           0  // int? Scale
         ,
         typeof(EdiLogInvoice)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <EdiLogInvoice>.GetProperty(x => x.Eitotaldiscount),
         "EITOTALDISCOUNT", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  126, // int? prec
                   
         null // int? Scale
         ,
         typeof(EdiLogInvoice)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <EdiLogInvoice>.GetProperty(x => x.Eitotalgoods),
         "EITOTALGOODS", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  126, // int? prec
                   
         null // int? Scale
         ,
         typeof(EdiLogInvoice)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <EdiLogInvoice>.GetProperty(x => x.Eitotalinvoiced),
         "EITOTALINVOICED", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  126, // int? prec
                   
         null // int? Scale
         ,
         typeof(EdiLogInvoice)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <EdiLogInvoice>.GetProperty(x => x.Eitotalvat),
         "EITOTALVAT", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  126, // int? prec
                   
         null // int? Scale
         ,
         typeof(EdiLogInvoice)
         ));
         return result; 
       }

#endregion     
        private int _fEiinvoiceid;
        public int Eiinvoiceid
        {
            get { return _fEiinvoiceid; }
            set
            {
                var oldKey = Key;
                if (_fEiinvoiceid != value)
                {
                    Modify();
                    _fEiinvoiceid = value;
                    KeyChanged(oldKey);
                }
            }
        }

        private int? _fEiatrrecno;
        public int? Eiatrrecno
        {
            get { return _fEiatrrecno; }
            set
            {
                if (_fEiatrrecno != value)
                {
                    Modify();
                    _fEiatrrecno = value;
                }
            }
        }

        private int? _fEiheadid;
        public int? Eiheadid
        {
            get { return _fEiheadid; }
            set
            {
                if (_fEiheadid != value)
                {
                    Modify();
                    _fEiheadid = value;
                }
            }
        }

        private decimal? _fEitotaldiscount;
        public decimal? Eitotaldiscount
        {
            get { return _fEitotaldiscount; }
            set
            {
                if (_fEitotaldiscount != value)
                {
                    Modify();
                    _fEitotaldiscount = value;
                }
            }
        }

        private decimal? _fEitotalgoods;
        public decimal? Eitotalgoods
        {
            get { return _fEitotalgoods; }
            set
            {
                if (_fEitotalgoods != value)
                {
                    Modify();
                    _fEitotalgoods = value;
                }
            }
        }

        private decimal? _fEitotalinvoiced;
        public decimal? Eitotalinvoiced
        {
            get { return _fEitotalinvoiced; }
            set
            {
                if (_fEitotalinvoiced != value)
                {
                    Modify();
                    _fEitotalinvoiced = value;
                }
            }
        }

        private decimal? _fEitotalvat;
        public decimal? Eitotalvat
        {
            get { return _fEitotalvat; }
            set
            {
                if (_fEitotalvat != value)
                {
                    Modify();
                    _fEitotalvat = value;
                }
            }
        }

        public override int Key
        {
            get { return Eiinvoiceid; }
            set { Eiinvoiceid = value; }
        }

        public override string KeyAsString { get { return Key.ToString(CultureInfo.InvariantCulture); } }


        public override EdiLogInvoice Clone()
        {
            var obj = new EdiLogInvoice
                {
                    Eiinvoiceid = Eiinvoiceid,
                    Eiatrrecno = Eiatrrecno,
                    Eiheadid = Eiheadid,
                    Eitotaldiscount = Eitotaldiscount,
                    Eitotalgoods = Eitotalgoods,
                    Eitotalinvoiced = Eitotalinvoiced,
                    Eitotalvat = Eitotalvat,
                };

            return obj;
        }

        public static class FieldNames
        {
// ReSharper disable InconsistentNaming
            public const string  EIINVOICEID = "EIINVOICEID";
            public const string  EIATRRECNO = "EIATRRECNO";
            public const string  EIHEADID = "EIHEADID";
            public const string  EITOTALDISCOUNT = "EITOTALDISCOUNT";
            public const string  EITOTALGOODS = "EITOTALGOODS";
            public const string  EITOTALINVOICED = "EITOTALINVOICED";
            public const string  EITOTALVAT = "EITOTALVAT";
 // ReSharper restore InconsistentNaming
        }


    }

}
