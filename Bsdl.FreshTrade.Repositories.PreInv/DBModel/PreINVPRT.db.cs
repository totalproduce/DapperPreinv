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
    /// Entity for the PREINVTEMP_PREINVPRT table
    /// </summary>
    public partial class PreINVPRT : BaseDbModel<PreINVPRT, string>
    {
#region tableDefs

       public static List<EntityPropDef> GetPropDefs() {
         var result = new List<EntityPropDef>();

//EntityPropDef(string propName, string columnName, bool isKey, bool isNullable, string refEntityName, PropertyInfo keyPropInfo,
//            int size, int? prec, int? scale)




         result.Add(new EntityPropDef(
         PropertyHelper <PreINVPRT>.GetProperty(x => x.Cancelleddlv),
         "CANCELLEDDLV", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  10, // int? prec
                           0  // int? Scale
         ,
         typeof(PreINVPRT)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <PreINVPRT>.GetProperty(x => x.Curdesc),
         "CURDESC", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         30,       // int size   
                  null, // int? prec
                   
         null // int? Scale
         ,
         typeof(PreINVPRT)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <PreINVPRT>.GetProperty(x => x.Delclarecno),
         "DELCLARECNO", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  10, // int? prec
                           0  // int? Scale
         ,
         typeof(PreINVPRT)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <PreINVPRT>.GetProperty(x => x.Dltrecno),
         "DLTRECNO", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  10, // int? prec
                           0  // int? Scale
         ,
         typeof(PreINVPRT)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <PreINVPRT>.GetProperty(x => x.Dlvdeldate),
         "DLVDELDATE", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  null, // int? prec
                   
         null // int? Scale
         ,
         typeof(PreINVPRT)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <PreINVPRT>.GetProperty(x => x.Dlvinvoiceno),
         "DLVINVOICENO", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         20,       // int size   
                  null, // int? prec
                   
         null // int? Scale
         ,
         typeof(PreINVPRT)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <PreINVPRT>.GetProperty(x => x.Dlvordno),
         "DLVORDNO", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  10, // int? prec
                           0  // int? Scale
         ,
         typeof(PreINVPRT)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <PreINVPRT>.GetProperty(x => x.Dlvpodno),
         "DLVPODNO", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         15,       // int size   
                  null, // int? prec
                   
         null // int? Scale
         ,
         typeof(PreINVPRT)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <PreINVPRT>.GetProperty(x => x.Dlvprghedno),
         "DLVPRGHEDNO", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  10, // int? prec
                           0  // int? Scale
         ,
         typeof(PreINVPRT)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <PreINVPRT>.GetProperty(x => x.Dlvsaloffno),
         "DLVSALOFFNO", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  10, // int? prec
                           0  // int? Scale
         ,
         typeof(PreINVPRT)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <PreINVPRT>.GetProperty(x => x.Dlvshpdate),
         "DLVSHPDATE", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  null, // int? prec
                   
         null // int? Scale
         ,
         typeof(PreINVPRT)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <PreINVPRT>.GetProperty(x => x.Extractsessionid),
         "EXTRACTSESSIONID", // columnName
         false,                    //isKey
         false, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  10, // int? prec
                           0  // int? Scale
         ,
         typeof(PreINVPRT)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <PreINVPRT>.GetProperty(x => x.Hofclarecno),
         "HOFCLARECNO", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  10, // int? prec
                           0  // int? Scale
         ,
         typeof(PreINVPRT)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <PreINVPRT>.GetProperty(x => x.Hofcstcode),
         "HOFCSTCODE", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         8,       // int size   
                  null, // int? prec
                   
         null // int? Scale
         ,
         typeof(PreINVPRT)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <PreINVPRT>.GetProperty(x => x.Invdate),
         "INVDATE", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  null, // int? prec
                   
         null // int? Scale
         ,
         typeof(PreINVPRT)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <PreINVPRT>.GetProperty(x => x.Invoicetype),
         "INVOICETYPE", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  10, // int? prec
                           0  // int? Scale
         ,
         typeof(PreINVPRT)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <PreINVPRT>.GetProperty(x => x.Isediprg),
         "ISEDIPRG", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  1, // int? prec
                           0  // int? Scale
         ,
         typeof(PreINVPRT)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <PreINVPRT>.GetProperty(x => x.Ordcstcode),
         "ORDCSTCODE", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         8,       // int size   
                  null, // int? prec
                   
         null // int? Scale
         ,
         typeof(PreINVPRT)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <PreINVPRT>.GetProperty(x => x.Ordcustordno),
         "ORDCUSTORDNO", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         25,       // int size   
                  null, // int? prec
                   
         null // int? Scale
         ,
         typeof(PreINVPRT)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <PreINVPRT>.GetProperty(x => x.Orddate),
         "ORDDATE", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  null, // int? prec
                   
         null // int? Scale
         ,
         typeof(PreINVPRT)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <PreINVPRT>.GetProperty(x => x.Ordrecno),
         "ORDRECNO", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  10, // int? prec
                           0  // int? Scale
         ,
         typeof(PreINVPRT)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <PreINVPRT>.GetProperty(x => x.Ordsmnno),
         "ORDSMNNO", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  10, // int? prec
                           0  // int? Scale
         ,
         typeof(PreINVPRT)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <PreINVPRT>.GetProperty(x => x.Prcglbrecno),
         "PRCGLBRECNO", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  10, // int? prec
                           0  // int? Scale
         ,
         typeof(PreINVPRT)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <PreINVPRT>.GetProperty(x => x.Recno),
         "RECNO", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  10, // int? prec
                           0  // int? Scale
         ,
         typeof(PreINVPRT)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <PreINVPRT>.GetProperty(x => x.Saloffdesc),
         "SALOFFDESC", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         23,       // int size   
                  null, // int? prec
                   
         null // int? Scale
         ,
         typeof(PreINVPRT)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <PreINVPRT>.GetProperty(x => x.Sort1),
         "SORT1", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         30,       // int size   
                  null, // int? prec
                   
         null // int? Scale
         ,
         typeof(PreINVPRT)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <PreINVPRT>.GetProperty(x => x.Sort2),
         "SORT2", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         30,       // int size   
                  null, // int? prec
                   
         null // int? Scale
         ,
         typeof(PreINVPRT)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <PreINVPRT>.GetProperty(x => x.Vatable),
         "VATABLE", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         1,       // int size   
                  null, // int? prec
                   
         null // int? Scale
         ,
         typeof(PreINVPRT)
         ));
         return result; 
       }

#endregion     
        private int? _fCancelleddlv;
        public int? Cancelleddlv
        {
            get { return _fCancelleddlv; }
            set
            {
                if (_fCancelleddlv != value)
                {
                    Modify();
                    _fCancelleddlv = value;
                }
            }
        }

        private string _fCurdesc;
        public string Curdesc
        {
            get { return _fCurdesc; }
            set
            {
                if (_fCurdesc != value)
                {
                    Modify();
                    _fCurdesc = value;
                }
            }
        }

        private int? _fDelclarecno;
        public int? Delclarecno
        {
            get { return _fDelclarecno; }
            set
            {
                if (_fDelclarecno != value)
                {
                    Modify();
                    _fDelclarecno = value;
                }
            }
        }

        private int? _fDltrecno;
        public int? Dltrecno
        {
            get { return _fDltrecno; }
            set
            {
                if (_fDltrecno != value)
                {
                    Modify();
                    _fDltrecno = value;
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

        private string _fDlvinvoiceno;
        public string Dlvinvoiceno
        {
            get { return _fDlvinvoiceno; }
            set
            {
                if (_fDlvinvoiceno != value)
                {
                    Modify();
                    _fDlvinvoiceno = value;
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

        private int? _fDlvprghedno;
        public int? Dlvprghedno
        {
            get { return _fDlvprghedno; }
            set
            {
                if (_fDlvprghedno != value)
                {
                    Modify();
                    _fDlvprghedno = value;
                }
            }
        }

        private int? _fDlvsaloffno;
        public int? Dlvsaloffno
        {
            get { return _fDlvsaloffno; }
            set
            {
                if (_fDlvsaloffno != value)
                {
                    Modify();
                    _fDlvsaloffno = value;
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

        private int _fExtractsessionid;
        public int Extractsessionid
        {
            get { return _fExtractsessionid; }
            set
            {
                if (_fExtractsessionid != value)
                {
                    Modify();
                    _fExtractsessionid = value;
                }
            }
        }

        private int? _fHofclarecno;
        public int? Hofclarecno
        {
            get { return _fHofclarecno; }
            set
            {
                if (_fHofclarecno != value)
                {
                    Modify();
                    _fHofclarecno = value;
                }
            }
        }

        private string _fHofcstcode;
        public string Hofcstcode
        {
            get { return _fHofcstcode; }
            set
            {
                if (_fHofcstcode != value)
                {
                    Modify();
                    _fHofcstcode = value;
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

        private int? _fInvoicetype;
        public int? Invoicetype
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

        private short? _fIsediprg;
        public short? Isediprg
        {
            get { return _fIsediprg; }
            set
            {
                if (_fIsediprg != value)
                {
                    Modify();
                    _fIsediprg = value;
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

        private string _fOrdcustordno;
        public string Ordcustordno
        {
            get { return _fOrdcustordno; }
            set
            {
                if (_fOrdcustordno != value)
                {
                    Modify();
                    _fOrdcustordno = value;
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

        private int? _fOrdrecno;
        public int? Ordrecno
        {
            get { return _fOrdrecno; }
            set
            {
                if (_fOrdrecno != value)
                {
                    Modify();
                    _fOrdrecno = value;
                }
            }
        }

        private int? _fOrdsmnno;
        public int? Ordsmnno
        {
            get { return _fOrdsmnno; }
            set
            {
                if (_fOrdsmnno != value)
                {
                    Modify();
                    _fOrdsmnno = value;
                }
            }
        }

        private int? _fPrcglbrecno;
        public int? Prcglbrecno
        {
            get { return _fPrcglbrecno; }
            set
            {
                if (_fPrcglbrecno != value)
                {
                    Modify();
                    _fPrcglbrecno = value;
                }
            }
        }

        private int? _fRecno;
        public int? Recno
        {
            get { return _fRecno; }
            set
            {
                if (_fRecno != value)
                {
                    Modify();
                    _fRecno = value;
                }
            }
        }

        private string _fSaloffdesc;
        public string Saloffdesc
        {
            get { return _fSaloffdesc; }
            set
            {
                if (_fSaloffdesc != value)
                {
                    Modify();
                    _fSaloffdesc = value;
                }
            }
        }

        private string _fSort1;
        public string Sort1
        {
            get { return _fSort1; }
            set
            {
                if (_fSort1 != value)
                {
                    Modify();
                    _fSort1 = value;
                }
            }
        }

        private string _fSort2;
        public string Sort2
        {
            get { return _fSort2; }
            set
            {
                if (_fSort2 != value)
                {
                    Modify();
                    _fSort2 = value;
                }
            }
        }

        private string _fVatable;
        public string Vatable
        {
            get { return _fVatable; }
            set
            {
                if (_fVatable != value)
                {
                    Modify();
                    _fVatable = value;
                }
            }
        }


        public override PreINVPRT Clone()
        {
            var obj = new PreINVPRT
                {
                    Cancelleddlv = Cancelleddlv,
                    Curdesc = Curdesc,
                    Delclarecno = Delclarecno,
                    Dltrecno = Dltrecno,
                    Dlvdeldate = Dlvdeldate,
                    Dlvinvoiceno = Dlvinvoiceno,
                    Dlvordno = Dlvordno,
                    Dlvpodno = Dlvpodno,
                    Dlvprghedno = Dlvprghedno,
                    Dlvsaloffno = Dlvsaloffno,
                    Dlvshpdate = Dlvshpdate,
                    Extractsessionid = Extractsessionid,
                    Hofclarecno = Hofclarecno,
                    Hofcstcode = Hofcstcode,
                    Invdate = Invdate,
                    Invoicetype = Invoicetype,
                    Isediprg = Isediprg,
                    Ordcstcode = Ordcstcode,
                    Ordcustordno = Ordcustordno,
                    Orddate = Orddate,
                    Ordrecno = Ordrecno,
                    Ordsmnno = Ordsmnno,
                    Prcglbrecno = Prcglbrecno,
                    Recno = Recno,
                    Saloffdesc = Saloffdesc,
                    Sort1 = Sort1,
                    Sort2 = Sort2,
                    Vatable = Vatable,
                };

            return obj;
        }

        public static class FieldNames
        {
// ReSharper disable InconsistentNaming
            public const string  CANCELLEDDLV = "CANCELLEDDLV";
            public const string  CURDESC = "CURDESC";
            public const string  DELCLARECNO = "DELCLARECNO";
            public const string  DLTRECNO = "DLTRECNO";
            public const string  DLVDELDATE = "DLVDELDATE";
            public const string  DLVINVOICENO = "DLVINVOICENO";
            public const string  DLVORDNO = "DLVORDNO";
            public const string  DLVPODNO = "DLVPODNO";
            public const string  DLVPRGHEDNO = "DLVPRGHEDNO";
            public const string  DLVSALOFFNO = "DLVSALOFFNO";
            public const string  DLVSHPDATE = "DLVSHPDATE";
            public const string  EXTRACTSESSIONID = "EXTRACTSESSIONID";
            public const string  HOFCLARECNO = "HOFCLARECNO";
            public const string  HOFCSTCODE = "HOFCSTCODE";
            public const string  INVDATE = "INVDATE";
            public const string  INVOICETYPE = "INVOICETYPE";
            public const string  ISEDIPRG = "ISEDIPRG";
            public const string  ORDCSTCODE = "ORDCSTCODE";
            public const string  ORDCUSTORDNO = "ORDCUSTORDNO";
            public const string  ORDDATE = "ORDDATE";
            public const string  ORDRECNO = "ORDRECNO";
            public const string  ORDSMNNO = "ORDSMNNO";
            public const string  PRCGLBRECNO = "PRCGLBRECNO";
            public const string  RECNO = "RECNO";
            public const string  SALOFFDESC = "SALOFFDESC";
            public const string  SORT1 = "SORT1";
            public const string  SORT2 = "SORT2";
            public const string  VATABLE = "VATABLE";
 // ReSharper restore InconsistentNaming
        }


    }

}
