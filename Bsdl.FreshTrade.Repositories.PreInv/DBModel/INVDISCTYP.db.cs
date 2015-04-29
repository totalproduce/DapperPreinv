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
    /// Entity for the PREINVTEMP_INVDISCTYP table
    /// </summary>
    public partial class INVDISCTYP : BaseDbModel<INVDISCTYP, string>
    {
#region tableDefs

       public static List<EntityPropDef> GetPropDefs() {
         var result = new List<EntityPropDef>();

//EntityPropDef(string propName, string columnName, bool isKey, bool isNullable, string refEntityName, PropertyInfo keyPropInfo,
//            int size, int? prec, int? scale)




         result.Add(new EntityPropDef(
         PropertyHelper <INVDISCTYP>.GetProperty(x => x.Discbaseamt),
         "DISCBASEAMT", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  126, // int? prec
                   
         null // int? Scale
         ,
         typeof(INVDISCTYP)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <INVDISCTYP>.GetProperty(x => x.Discdetrstr),
         "DISCDETRSTR", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         30,       // int size   
                  null, // int? prec
                   
         null // int? Scale
         ,
         typeof(INVDISCTYP)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <INVDISCTYP>.GetProperty(x => x.Disceuroamt),
         "DISCEUROAMT", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  126, // int? prec
                   
         null // int? Scale
         ,
         typeof(INVDISCTYP)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <INVDISCTYP>.GetProperty(x => x.Discglrecno),
         "DISCGLRECNO", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  10, // int? prec
                           0  // int? Scale
         ,
         typeof(INVDISCTYP)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <INVDISCTYP>.GetProperty(x => x.Discloclamt),
         "DISCLOCLAMT", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  126, // int? prec
                   
         null // int? Scale
         ,
         typeof(INVDISCTYP)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <INVDISCTYP>.GetProperty(x => x.Discrate),
         "DISCRATE", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  126, // int? prec
                   
         null // int? Scale
         ,
         typeof(INVDISCTYP)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <INVDISCTYP>.GetProperty(x => x.Discseqno),
         "DISCSEQNO", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  10, // int? prec
                           0  // int? Scale
         ,
         typeof(INVDISCTYP)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <INVDISCTYP>.GetProperty(x => x.Disctyp),
         "DISCTYP", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  10, // int? prec
                           0  // int? Scale
         ,
         typeof(INVDISCTYP)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <INVDISCTYP>.GetProperty(x => x.Dlvinvoiceno),
         "DLVINVOICENO", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         20,       // int size   
                  null, // int? prec
                   
         null // int? Scale
         ,
         typeof(INVDISCTYP)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <INVDISCTYP>.GetProperty(x => x.Extractsessionid),
         "EXTRACTSESSIONID", // columnName
         false,                    //isKey
         false, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  10, // int? prec
                           0  // int? Scale
         ,
         typeof(INVDISCTYP)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <INVDISCTYP>.GetProperty(x => x.Ichrecno),
         "ICHRECNO", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  10, // int? prec
                           0  // int? Scale
         ,
         typeof(INVDISCTYP)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <INVDISCTYP>.GetProperty(x => x.Recno),
         "RECNO", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  10, // int? prec
                           0  // int? Scale
         ,
         typeof(INVDISCTYP)
         ));
         return result; 
       }

#endregion     
        private decimal? _fDiscbaseamt;
        public decimal? Discbaseamt
        {
            get { return _fDiscbaseamt; }
            set
            {
                if (_fDiscbaseamt != value)
                {
                    Modify();
                    _fDiscbaseamt = value;
                }
            }
        }

        private string _fDiscdetrstr;
        public string Discdetrstr
        {
            get { return _fDiscdetrstr; }
            set
            {
                if (_fDiscdetrstr != value)
                {
                    Modify();
                    _fDiscdetrstr = value;
                }
            }
        }

        private decimal? _fDisceuroamt;
        public decimal? Disceuroamt
        {
            get { return _fDisceuroamt; }
            set
            {
                if (_fDisceuroamt != value)
                {
                    Modify();
                    _fDisceuroamt = value;
                }
            }
        }

        private int? _fDiscglrecno;
        public int? Discglrecno
        {
            get { return _fDiscglrecno; }
            set
            {
                if (_fDiscglrecno != value)
                {
                    Modify();
                    _fDiscglrecno = value;
                }
            }
        }

        private decimal? _fDiscloclamt;
        public decimal? Discloclamt
        {
            get { return _fDiscloclamt; }
            set
            {
                if (_fDiscloclamt != value)
                {
                    Modify();
                    _fDiscloclamt = value;
                }
            }
        }

        private decimal? _fDiscrate;
        public decimal? Discrate
        {
            get { return _fDiscrate; }
            set
            {
                if (_fDiscrate != value)
                {
                    Modify();
                    _fDiscrate = value;
                }
            }
        }

        private int? _fDiscseqno;
        public int? Discseqno
        {
            get { return _fDiscseqno; }
            set
            {
                if (_fDiscseqno != value)
                {
                    Modify();
                    _fDiscseqno = value;
                }
            }
        }

        private int? _fDisctyp;
        public int? Disctyp
        {
            get { return _fDisctyp; }
            set
            {
                if (_fDisctyp != value)
                {
                    Modify();
                    _fDisctyp = value;
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

        private int? _fIchrecno;
        public int? Ichrecno
        {
            get { return _fIchrecno; }
            set
            {
                if (_fIchrecno != value)
                {
                    Modify();
                    _fIchrecno = value;
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


        public override INVDISCTYP Clone()
        {
            var obj = new INVDISCTYP
                {
                    Discbaseamt = Discbaseamt,
                    Discdetrstr = Discdetrstr,
                    Disceuroamt = Disceuroamt,
                    Discglrecno = Discglrecno,
                    Discloclamt = Discloclamt,
                    Discrate = Discrate,
                    Discseqno = Discseqno,
                    Disctyp = Disctyp,
                    Dlvinvoiceno = Dlvinvoiceno,
                    Extractsessionid = Extractsessionid,
                    Ichrecno = Ichrecno,
                    Recno = Recno,
                };

            return obj;
        }

        public static class FieldNames
        {
// ReSharper disable InconsistentNaming
            public const string  DISCBASEAMT = "DISCBASEAMT";
            public const string  DISCDETRSTR = "DISCDETRSTR";
            public const string  DISCEUROAMT = "DISCEUROAMT";
            public const string  DISCGLRECNO = "DISCGLRECNO";
            public const string  DISCLOCLAMT = "DISCLOCLAMT";
            public const string  DISCRATE = "DISCRATE";
            public const string  DISCSEQNO = "DISCSEQNO";
            public const string  DISCTYP = "DISCTYP";
            public const string  DLVINVOICENO = "DLVINVOICENO";
            public const string  EXTRACTSESSIONID = "EXTRACTSESSIONID";
            public const string  ICHRECNO = "ICHRECNO";
            public const string  RECNO = "RECNO";
 // ReSharper restore InconsistentNaming
        }


    }

}
