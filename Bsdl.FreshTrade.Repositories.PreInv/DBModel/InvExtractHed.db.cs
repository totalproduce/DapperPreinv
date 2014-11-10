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
    /// Entity for the PREINVTEMP_INVEXTRACTHED table
    /// </summary>
    public partial class InvExtractHed : BaseDbModel<InvExtractHed, int>
    {
#region tableDefs

       public static List<EntityPropDef> GetPropDefs() {
         var result = new List<EntityPropDef>();

//EntityPropDef(string propName, string columnName, bool isKey, bool isNullable, string refEntityName, PropertyInfo keyPropInfo,
//            int size, int? prec, int? scale)



         result.Add(new EntityPropDef(
         PropertyHelper <InvExtractHed>.GetProperty(x => x.Extractsessionid),
         "EXTRACTSESSIONID", // columnName
         true,                    //isKey
         false, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  10, // int? prec
                           0  // int? Scale
         ,
         typeof(InvExtractHed)
       ));


         result.Add(new EntityPropDef(
         PropertyHelper <InvExtractHed>.GetProperty(x => x.Companyno),
         "COMPANYNO", // columnName
         false,                    //isKey
         false, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  10, // int? prec
                           0  // int? Scale
         ,
         typeof(InvExtractHed)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <InvExtractHed>.GetProperty(x => x.Createddate),
         "CREATEDDATE", // columnName
         false,                    //isKey
         false, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  null, // int? prec
                   
         null // int? Scale
         ,
         typeof(InvExtractHed)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <InvExtractHed>.GetProperty(x => x.Invoiceordertype),
         "INVOICEORDERTYPE", // columnName
         false,                    //isKey
         false, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         50,       // int size   
                  null, // int? prec
                   
         null // int? Scale
         ,
         typeof(InvExtractHed)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <InvExtractHed>.GetProperty(x => x.Invoiceperiod),
         "INVOICEPERIOD", // columnName
         false,                    //isKey
         false, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  5, // int? prec
                           0  // int? Scale
         ,
         typeof(InvExtractHed)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <InvExtractHed>.GetProperty(x => x.Invoiceperiodasstr),
         "INVOICEPERIODASSTR", // columnName
         false,                    //isKey
         false, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         50,       // int size   
                  null, // int? prec
                   
         null // int? Scale
         ,
         typeof(InvExtractHed)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <InvExtractHed>.GetProperty(x => x.Invoicetype),
         "INVOICETYPE", // columnName
         false,                    //isKey
         false, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  5, // int? prec
                           0  // int? Scale
         ,
         typeof(InvExtractHed)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <InvExtractHed>.GetProperty(x => x.Invoicetypename),
         "INVOICETYPENAME", // columnName
         false,                    //isKey
         false, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         50,       // int size   
                  null, // int? prec
                   
         null // int? Scale
         ,
         typeof(InvExtractHed)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <InvExtractHed>.GetProperty(x => x.Isintercompanytransfer),
         "ISINTERCOMPANYTRANSFER", // columnName
         false,                    //isKey
         false, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  1, // int? prec
                           0  // int? Scale
         ,
         typeof(InvExtractHed)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <InvExtractHed>.GetProperty(x => x.Lastinvoiceno),
         "LASTINVOICENO", // columnName
         false,                    //isKey
         false, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  10, // int? prec
                           0  // int? Scale
         ,
         typeof(InvExtractHed)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <InvExtractHed>.GetProperty(x => x.Logonno),
         "LOGONNO", // columnName
         false,                    //isKey
         false, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  5, // int? prec
                           0  // int? Scale
         ,
         typeof(InvExtractHed)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <InvExtractHed>.GetProperty(x => x.Reqdate),
         "REQDATE", // columnName
         false,                    //isKey
         false, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  null, // int? prec
                   
         null // int? Scale
         ,
         typeof(InvExtractHed)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <InvExtractHed>.GetProperty(x => x.Salesofficename),
         "SALESOFFICENAME", // columnName
         false,                    //isKey
         false, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         50,       // int size   
                  null, // int? prec
                   
         null // int? Scale
         ,
         typeof(InvExtractHed)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <InvExtractHed>.GetProperty(x => x.Salesofficeno),
         "SALESOFFICENO", // columnName
         false,                    //isKey
         false, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  5, // int? prec
                           0  // int? Scale
         ,
         typeof(InvExtractHed)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <InvExtractHed>.GetProperty(x => x.Taxdate),
         "TAXDATE", // columnName
         false,                    //isKey
         false, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  null, // int? prec
                   
         null // int? Scale
         ,
         typeof(InvExtractHed)
         ));
         return result; 
       }

#endregion     
        private int _fExtractsessionid;
        public int Extractsessionid
        {
            get { return _fExtractsessionid; }
            set
            {
                var oldKey = Key;
                if (_fExtractsessionid != value)
                {
                    Modify();
                    _fExtractsessionid = value;
                    KeyChanged(oldKey);
                }
            }
        }

        private int _fCompanyno;
        public int Companyno
        {
            get { return _fCompanyno; }
            set
            {
                if (_fCompanyno != value)
                {
                    Modify();
                    _fCompanyno = value;
                }
            }
        }

        private DateTime _fCreateddate;
        public DateTime Createddate
        {
            get { return _fCreateddate; }
            set
            {
                if (_fCreateddate != value)
                {
                    Modify();
                    _fCreateddate = value;
                }
            }
        }

        private string _fInvoiceordertype;
        public string Invoiceordertype
        {
            get { return _fInvoiceordertype; }
            set
            {
                if (_fInvoiceordertype != value)
                {
                    Modify();
                    _fInvoiceordertype = value;
                }
            }
        }

        private int _fInvoiceperiod;
        public int Invoiceperiod
        {
            get { return _fInvoiceperiod; }
            set
            {
                if (_fInvoiceperiod != value)
                {
                    Modify();
                    _fInvoiceperiod = value;
                }
            }
        }

        private string _fInvoiceperiodasstr;
        public string Invoiceperiodasstr
        {
            get { return _fInvoiceperiodasstr; }
            set
            {
                if (_fInvoiceperiodasstr != value)
                {
                    Modify();
                    _fInvoiceperiodasstr = value;
                }
            }
        }

        private int _fInvoicetype;
        public int Invoicetype
        {
            get { return _fInvoicetype; }
            set
            {
                if (_fInvoicetype != value)
                {
                    Modify();
                    _fInvoicetype = value;
                }
            }
        }

        private string _fInvoicetypename;
        public string Invoicetypename
        {
            get { return _fInvoicetypename; }
            set
            {
                if (_fInvoicetypename != value)
                {
                    Modify();
                    _fInvoicetypename = value;
                }
            }
        }

        private short _fIsintercompanytransfer;
        public short Isintercompanytransfer
        {
            get { return _fIsintercompanytransfer; }
            set
            {
                if (_fIsintercompanytransfer != value)
                {
                    Modify();
                    _fIsintercompanytransfer = value;
                }
            }
        }

        private int _fLastinvoiceno;
        public int Lastinvoiceno
        {
            get { return _fLastinvoiceno; }
            set
            {
                if (_fLastinvoiceno != value)
                {
                    Modify();
                    _fLastinvoiceno = value;
                }
            }
        }

        private int _fLogonno;
        public int Logonno
        {
            get { return _fLogonno; }
            set
            {
                if (_fLogonno != value)
                {
                    Modify();
                    _fLogonno = value;
                }
            }
        }

        private DateTime _fReqdate;
        public DateTime Reqdate
        {
            get { return _fReqdate; }
            set
            {
                if (_fReqdate != value)
                {
                    Modify();
                    _fReqdate = value;
                }
            }
        }

        private string _fSalesofficename;
        public string Salesofficename
        {
            get { return _fSalesofficename; }
            set
            {
                if (_fSalesofficename != value)
                {
                    Modify();
                    _fSalesofficename = value;
                }
            }
        }

        private int _fSalesofficeno;
        public int Salesofficeno
        {
            get { return _fSalesofficeno; }
            set
            {
                if (_fSalesofficeno != value)
                {
                    Modify();
                    _fSalesofficeno = value;
                }
            }
        }

        private DateTime _fTaxdate;
        public DateTime Taxdate
        {
            get { return _fTaxdate; }
            set
            {
                if (_fTaxdate != value)
                {
                    Modify();
                    _fTaxdate = value;
                }
            }
        }

        public override int Key
        {
            get { return Extractsessionid; }
            set { Extractsessionid = value; }
        }

        public override string KeyAsString { get { return Key.ToString(CultureInfo.InvariantCulture); } }


        public override InvExtractHed Clone()
        {
            var obj = new InvExtractHed
                {
                    Extractsessionid = Extractsessionid,
                    Companyno = Companyno,
                    Createddate = Createddate,
                    Invoiceordertype = Invoiceordertype,
                    Invoiceperiod = Invoiceperiod,
                    Invoiceperiodasstr = Invoiceperiodasstr,
                    Invoicetype = Invoicetype,
                    Invoicetypename = Invoicetypename,
                    Isintercompanytransfer = Isintercompanytransfer,
                    Lastinvoiceno = Lastinvoiceno,
                    Logonno = Logonno,
                    Reqdate = Reqdate,
                    Salesofficename = Salesofficename,
                    Salesofficeno = Salesofficeno,
                    Taxdate = Taxdate,
                };

            return obj;
        }

        public static class FieldNames
        {
// ReSharper disable InconsistentNaming
            public const string  EXTRACTSESSIONID = "EXTRACTSESSIONID";
            public const string  COMPANYNO = "COMPANYNO";
            public const string  CREATEDDATE = "CREATEDDATE";
            public const string  INVOICEORDERTYPE = "INVOICEORDERTYPE";
            public const string  INVOICEPERIOD = "INVOICEPERIOD";
            public const string  INVOICEPERIODASSTR = "INVOICEPERIODASSTR";
            public const string  INVOICETYPE = "INVOICETYPE";
            public const string  INVOICETYPENAME = "INVOICETYPENAME";
            public const string  ISINTERCOMPANYTRANSFER = "ISINTERCOMPANYTRANSFER";
            public const string  LASTINVOICENO = "LASTINVOICENO";
            public const string  LOGONNO = "LOGONNO";
            public const string  REQDATE = "REQDATE";
            public const string  SALESOFFICENAME = "SALESOFFICENAME";
            public const string  SALESOFFICENO = "SALESOFFICENO";
            public const string  TAXDATE = "TAXDATE";
 // ReSharper restore InconsistentNaming
        }


    }

}
