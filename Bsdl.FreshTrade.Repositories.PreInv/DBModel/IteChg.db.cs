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
    /// Entity for the ITECHG table
    /// </summary>
    public partial class IteChg : BaseDbModel<IteChg, int>
    {
#region tableDefs

       public static List<EntityPropDef> GetPropDefs() {
         var result = new List<EntityPropDef>();

//EntityPropDef(string propName, string columnName, bool isKey, bool isNullable, string refEntityName, PropertyInfo keyPropInfo,
//            int size, int? prec, int? scale)



         result.Add(new EntityPropDef(
         PropertyHelper <IteChg>.GetProperty(x => x.Ichrecno),
         "ICHRECNO", // columnName
         true,                    //isKey
         false, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  10, // int? prec
                           0  // int? Scale
         ,
         typeof(IteChg)
       ));


         result.Add(new EntityPropDef(
         PropertyHelper <IteChg>.GetProperty(x => x.Acsale),
         "ACSALE", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  1, // int? prec
                           0  // int? Scale
         ,
         typeof(IteChg)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <IteChg>.GetProperty(x => x.Ctyno),
         "CTYNO", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  5, // int? prec
                           0  // int? Scale
         ,
         typeof(IteChg)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <IteChg>.GetProperty(x => x.Delrecno),
         "DELRECNO", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  10, // int? prec
                           0  // int? Scale
         ,
         typeof(IteChg)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <IteChg>.GetProperty(x => x.Dprrecno),
         "DPRRECNO", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  10, // int? prec
                           0  // int? Scale
         ,
         typeof(IteChg)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <IteChg>.GetProperty(x => x.Excrecno),
         "EXCRECNO", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  10, // int? prec
                           0  // int? Scale
         ,
         typeof(IteChg)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <IteChg>.GetProperty(x => x.Ichacrrecno),
         "ICHACRRECNO", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  10, // int? prec
                           0  // int? Scale
         ,
         typeof(IteChg)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <IteChg>.GetProperty(x => x.Ichappamt),
         "ICHAPPAMT", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  126, // int? prec
                   
         null // int? Scale
         ,
         typeof(IteChg)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <IteChg>.GetProperty(x => x.Ichappfac),
         "ICHAPPFAC", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  5, // int? prec
                           0  // int? Scale
         ,
         typeof(IteChg)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <IteChg>.GetProperty(x => x.Ichappmult),
         "ICHAPPMULT", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  5, // int? prec
                           0  // int? Scale
         ,
         typeof(IteChg)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <IteChg>.GetProperty(x => x.Ichauthamm),
         "ICHAUTHAMM", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  126, // int? prec
                   
         null // int? Scale
         ,
         typeof(IteChg)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <IteChg>.GetProperty(x => x.Ichchacalc),
         "ICHCHACALC", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  5, // int? prec
                           0  // int? Scale
         ,
         typeof(IteChg)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <IteChg>.GetProperty(x => x.Ichchgfor),
         "ICHCHGFOR", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  5, // int? prec
                           0  // int? Scale
         ,
         typeof(IteChg)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <IteChg>.GetProperty(x => x.Ichchngdbyuser),
         "ICHCHNGDBYUSER", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  1, // int? prec
                           0  // int? Scale
         ,
         typeof(IteChg)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <IteChg>.GetProperty(x => x.Ichcostamt),
         "ICHCOSTAMT", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  22, // int? prec
                   
         null // int? Scale
         ,
         typeof(IteChg)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <IteChg>.GetProperty(x => x.Ichdistype),
         "ICHDISTYPE", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  5, // int? prec
                           0  // int? Scale
         ,
         typeof(IteChg)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <IteChg>.GetProperty(x => x.Ichhasaccrual),
         "ICHHASACCRUAL", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  1, // int? prec
                           0  // int? Scale
         ,
         typeof(IteChg)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <IteChg>.GetProperty(x => x.Ichisanauto),
         "ICHISANAUTO", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  1, // int? prec
                           0  // int? Scale
         ,
         typeof(IteChg)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <IteChg>.GetProperty(x => x.Ichistrecno),
         "ICHISTRECNO", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  10, // int? prec
                           0  // int? Scale
         ,
         typeof(IteChg)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <IteChg>.GetProperty(x => x.Ichonpayment),
         "ICHONPAYMENT", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  1, // int? prec
                           0  // int? Scale
         ,
         typeof(IteChg)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <IteChg>.GetProperty(x => x.Ichorgappamt),
         "ICHORGAPPAMT", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  22, // int? prec
                   
         null // int? Scale
         ,
         typeof(IteChg)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <IteChg>.GetProperty(x => x.Ichpackmistrecno),
         "ICHPACKMISTRECNO", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  10, // int? prec
                           0  // int? Scale
         ,
         typeof(IteChg)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <IteChg>.GetProperty(x => x.Ichpcntorrate),
         "ICHPCNTORRATE", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  126, // int? prec
                   
         null // int? Scale
         ,
         typeof(IteChg)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <IteChg>.GetProperty(x => x.Ichrawappamt),
         "ICHRAWAPPAMT", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  126, // int? prec
                   
         null // int? Scale
         ,
         typeof(IteChg)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <IteChg>.GetProperty(x => x.Ichrawauthamm),
         "ICHRAWAUTHAMM", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  126, // int? prec
                   
         null // int? Scale
         ,
         typeof(IteChg)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <IteChg>.GetProperty(x => x.Ichrealdistype),
         "ICHREALDISTYPE", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  5, // int? prec
                           0  // int? Scale
         ,
         typeof(IteChg)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <IteChg>.GetProperty(x => x.Ichretno),
         "ICHRETNO", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  5, // int? prec
                           0  // int? Scale
         ,
         typeof(IteChg)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <IteChg>.GetProperty(x => x.Ichspeto),
         "ICHSPETO", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         1,       // int size   
                  null, // int? prec
                   
         null // int? Scale
         ,
         typeof(IteChg)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <IteChg>.GetProperty(x => x.Litrecno),
         "LITRECNO", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  10, // int? prec
                           0  // int? Scale
         ,
         typeof(IteChg)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <IteChg>.GetProperty(x => x.Pmorddetrecno),
         "PMORDDETRECNO", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  10, // int? prec
                           0  // int? Scale
         ,
         typeof(IteChg)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <IteChg>.GetProperty(x => x.Rebdislitrecno),
         "REBDISLITRECNO", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  10, // int? prec
                           0  // int? Scale
         ,
         typeof(IteChg)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <IteChg>.GetProperty(x => x.Tbcpostrecno),
         "TBCPOSTRECNO", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  10, // int? prec
                           0  // int? Scale
         ,
         typeof(IteChg)
         ));
         return result; 
       }

#endregion     
        private int _fIchrecno;
        public int Ichrecno
        {
            get { return _fIchrecno; }
            set
            {
                var oldKey = Key;
                if (_fIchrecno != value)
                {
                    Modify();
                    _fIchrecno = value;
                    KeyChanged(oldKey);
                }
            }
        }

        private short? _fAcsale;
        public short? Acsale
        {
            get { return _fAcsale; }
            set
            {
                if (_fAcsale != value)
                {
                    Modify();
                    _fAcsale = value;
                }
            }
        }

        private int? _fCtyno;
        public int? Ctyno
        {
            get { return _fCtyno; }
            set
            {
                if (_fCtyno != value)
                {
                    Modify();
                    _fCtyno = value;
                }
            }
        }

        private int? _fDelrecno;
        public int? Delrecno
        {
            get { return _fDelrecno; }
            set
            {
                if (_fDelrecno != value)
                {
                    Modify();
                    _fDelrecno = value;
                }
            }
        }

        private int? _fDprrecno;
        public int? Dprrecno
        {
            get { return _fDprrecno; }
            set
            {
                if (_fDprrecno != value)
                {
                    Modify();
                    _fDprrecno = value;
                }
            }
        }

        private int? _fExcrecno;
        public int? Excrecno
        {
            get { return _fExcrecno; }
            set
            {
                if (_fExcrecno != value)
                {
                    Modify();
                    _fExcrecno = value;
                }
            }
        }

        private int? _fIchacrrecno;
        public int? Ichacrrecno
        {
            get { return _fIchacrrecno; }
            set
            {
                if (_fIchacrrecno != value)
                {
                    Modify();
                    _fIchacrrecno = value;
                }
            }
        }

        private decimal? _fIchappamt;
        public decimal? Ichappamt
        {
            get { return _fIchappamt; }
            set
            {
                if (_fIchappamt != value)
                {
                    Modify();
                    _fIchappamt = value;
                }
            }
        }

        private int? _fIchappfac;
        public int? Ichappfac
        {
            get { return _fIchappfac; }
            set
            {
                if (_fIchappfac != value)
                {
                    Modify();
                    _fIchappfac = value;
                }
            }
        }

        private int? _fIchappmult;
        public int? Ichappmult
        {
            get { return _fIchappmult; }
            set
            {
                if (_fIchappmult != value)
                {
                    Modify();
                    _fIchappmult = value;
                }
            }
        }

        private decimal? _fIchauthamm;
        public decimal? Ichauthamm
        {
            get { return _fIchauthamm; }
            set
            {
                if (_fIchauthamm != value)
                {
                    Modify();
                    _fIchauthamm = value;
                }
            }
        }

        private int? _fIchchacalc;
        public int? Ichchacalc
        {
            get { return _fIchchacalc; }
            set
            {
                if (_fIchchacalc != value)
                {
                    Modify();
                    _fIchchacalc = value;
                }
            }
        }

        private int? _fIchchgfor;
        public int? Ichchgfor
        {
            get { return _fIchchgfor; }
            set
            {
                if (_fIchchgfor != value)
                {
                    Modify();
                    _fIchchgfor = value;
                }
            }
        }

        private short? _fIchchngdbyuser;
        public short? Ichchngdbyuser
        {
            get { return _fIchchngdbyuser; }
            set
            {
                if (_fIchchngdbyuser != value)
                {
                    Modify();
                    _fIchchngdbyuser = value;
                }
            }
        }

        private decimal? _fIchcostamt;
        public decimal? Ichcostamt
        {
            get { return _fIchcostamt; }
            set
            {
                if (_fIchcostamt != value)
                {
                    Modify();
                    _fIchcostamt = value;
                }
            }
        }

        private int? _fIchdistype;
        public int? Ichdistype
        {
            get { return _fIchdistype; }
            set
            {
                if (_fIchdistype != value)
                {
                    Modify();
                    _fIchdistype = value;
                }
            }
        }

        private short? _fIchhasaccrual;
        public short? Ichhasaccrual
        {
            get { return _fIchhasaccrual; }
            set
            {
                if (_fIchhasaccrual != value)
                {
                    Modify();
                    _fIchhasaccrual = value;
                }
            }
        }

        private short? _fIchisanauto;
        public short? Ichisanauto
        {
            get { return _fIchisanauto; }
            set
            {
                if (_fIchisanauto != value)
                {
                    Modify();
                    _fIchisanauto = value;
                }
            }
        }

        private int? _fIchistrecno;
        public int? Ichistrecno
        {
            get { return _fIchistrecno; }
            set
            {
                if (_fIchistrecno != value)
                {
                    Modify();
                    _fIchistrecno = value;
                }
            }
        }

        private short? _fIchonpayment;
        public short? Ichonpayment
        {
            get { return _fIchonpayment; }
            set
            {
                if (_fIchonpayment != value)
                {
                    Modify();
                    _fIchonpayment = value;
                }
            }
        }

        private decimal? _fIchorgappamt;
        public decimal? Ichorgappamt
        {
            get { return _fIchorgappamt; }
            set
            {
                if (_fIchorgappamt != value)
                {
                    Modify();
                    _fIchorgappamt = value;
                }
            }
        }

        private int? _fIchpackmistrecno;
        public int? Ichpackmistrecno
        {
            get { return _fIchpackmistrecno; }
            set
            {
                if (_fIchpackmistrecno != value)
                {
                    Modify();
                    _fIchpackmistrecno = value;
                }
            }
        }

        private decimal? _fIchpcntorrate;
        public decimal? Ichpcntorrate
        {
            get { return _fIchpcntorrate; }
            set
            {
                if (_fIchpcntorrate != value)
                {
                    Modify();
                    _fIchpcntorrate = value;
                }
            }
        }

        private decimal? _fIchrawappamt;
        public decimal? Ichrawappamt
        {
            get { return _fIchrawappamt; }
            set
            {
                if (_fIchrawappamt != value)
                {
                    Modify();
                    _fIchrawappamt = value;
                }
            }
        }

        private decimal? _fIchrawauthamm;
        public decimal? Ichrawauthamm
        {
            get { return _fIchrawauthamm; }
            set
            {
                if (_fIchrawauthamm != value)
                {
                    Modify();
                    _fIchrawauthamm = value;
                }
            }
        }

        private int? _fIchrealdistype;
        public int? Ichrealdistype
        {
            get { return _fIchrealdistype; }
            set
            {
                if (_fIchrealdistype != value)
                {
                    Modify();
                    _fIchrealdistype = value;
                }
            }
        }

        private int? _fIchretno;
        public int? Ichretno
        {
            get { return _fIchretno; }
            set
            {
                if (_fIchretno != value)
                {
                    Modify();
                    _fIchretno = value;
                }
            }
        }

        private string _fIchspeto;
        public string Ichspeto
        {
            get { return _fIchspeto; }
            set
            {
                if (_fIchspeto != value)
                {
                    Modify();
                    _fIchspeto = value;
                }
            }
        }

        private int? _fLitrecno;
        public int? Litrecno
        {
            get { return _fLitrecno; }
            set
            {
                if (_fLitrecno != value)
                {
                    Modify();
                    _fLitrecno = value;
                }
            }
        }

        private int? _fPmorddetrecno;
        public int? Pmorddetrecno
        {
            get { return _fPmorddetrecno; }
            set
            {
                if (_fPmorddetrecno != value)
                {
                    Modify();
                    _fPmorddetrecno = value;
                }
            }
        }

        private int? _fRebdislitrecno;
        public int? Rebdislitrecno
        {
            get { return _fRebdislitrecno; }
            set
            {
                if (_fRebdislitrecno != value)
                {
                    Modify();
                    _fRebdislitrecno = value;
                }
            }
        }

        private int? _fTbcpostrecno;
        public int? Tbcpostrecno
        {
            get { return _fTbcpostrecno; }
            set
            {
                if (_fTbcpostrecno != value)
                {
                    Modify();
                    _fTbcpostrecno = value;
                }
            }
        }

        public override int Key
        {
            get { return Ichrecno; }
            set { Ichrecno = value; }
        }

        public override string KeyAsString { get { return Key.ToString(CultureInfo.InvariantCulture); } }


        public override IteChg Clone()
        {
            var obj = new IteChg
                {
                    Ichrecno = Ichrecno,
                    Acsale = Acsale,
                    Ctyno = Ctyno,
                    Delrecno = Delrecno,
                    Dprrecno = Dprrecno,
                    Excrecno = Excrecno,
                    Ichacrrecno = Ichacrrecno,
                    Ichappamt = Ichappamt,
                    Ichappfac = Ichappfac,
                    Ichappmult = Ichappmult,
                    Ichauthamm = Ichauthamm,
                    Ichchacalc = Ichchacalc,
                    Ichchgfor = Ichchgfor,
                    Ichchngdbyuser = Ichchngdbyuser,
                    Ichcostamt = Ichcostamt,
                    Ichdistype = Ichdistype,
                    Ichhasaccrual = Ichhasaccrual,
                    Ichisanauto = Ichisanauto,
                    Ichistrecno = Ichistrecno,
                    Ichonpayment = Ichonpayment,
                    Ichorgappamt = Ichorgappamt,
                    Ichpackmistrecno = Ichpackmistrecno,
                    Ichpcntorrate = Ichpcntorrate,
                    Ichrawappamt = Ichrawappamt,
                    Ichrawauthamm = Ichrawauthamm,
                    Ichrealdistype = Ichrealdistype,
                    Ichretno = Ichretno,
                    Ichspeto = Ichspeto,
                    Litrecno = Litrecno,
                    Pmorddetrecno = Pmorddetrecno,
                    Rebdislitrecno = Rebdislitrecno,
                    Tbcpostrecno = Tbcpostrecno,
                };

            return obj;
        }

        public static class FieldNames
        {
// ReSharper disable InconsistentNaming
            public const string  ICHRECNO = "ICHRECNO";
            public const string  ACSALE = "ACSALE";
            public const string  CTYNO = "CTYNO";
            public const string  DELRECNO = "DELRECNO";
            public const string  DPRRECNO = "DPRRECNO";
            public const string  EXCRECNO = "EXCRECNO";
            public const string  ICHACRRECNO = "ICHACRRECNO";
            public const string  ICHAPPAMT = "ICHAPPAMT";
            public const string  ICHAPPFAC = "ICHAPPFAC";
            public const string  ICHAPPMULT = "ICHAPPMULT";
            public const string  ICHAUTHAMM = "ICHAUTHAMM";
            public const string  ICHCHACALC = "ICHCHACALC";
            public const string  ICHCHGFOR = "ICHCHGFOR";
            public const string  ICHCHNGDBYUSER = "ICHCHNGDBYUSER";
            public const string  ICHCOSTAMT = "ICHCOSTAMT";
            public const string  ICHDISTYPE = "ICHDISTYPE";
            public const string  ICHHASACCRUAL = "ICHHASACCRUAL";
            public const string  ICHISANAUTO = "ICHISANAUTO";
            public const string  ICHISTRECNO = "ICHISTRECNO";
            public const string  ICHONPAYMENT = "ICHONPAYMENT";
            public const string  ICHORGAPPAMT = "ICHORGAPPAMT";
            public const string  ICHPACKMISTRECNO = "ICHPACKMISTRECNO";
            public const string  ICHPCNTORRATE = "ICHPCNTORRATE";
            public const string  ICHRAWAPPAMT = "ICHRAWAPPAMT";
            public const string  ICHRAWAUTHAMM = "ICHRAWAUTHAMM";
            public const string  ICHREALDISTYPE = "ICHREALDISTYPE";
            public const string  ICHRETNO = "ICHRETNO";
            public const string  ICHSPETO = "ICHSPETO";
            public const string  LITRECNO = "LITRECNO";
            public const string  PMORDDETRECNO = "PMORDDETRECNO";
            public const string  REBDISLITRECNO = "REBDISLITRECNO";
            public const string  TBCPOSTRECNO = "TBCPOSTRECNO";
 // ReSharper restore InconsistentNaming
        }


    }

}
