




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
    /// Entity for the VATRATES table
    /// </summary>
    public partial class VatRates : BaseDbModel<VatRates, int>
    {
#region tableDefs

       public static List<EntityPropDef> GetPropDefs() {
         var result = new List<EntityPropDef>();

//EntityPropDef(string propName, string columnName, bool isKey, bool isNullable, string refEntityName, PropertyInfo keyPropInfo,
//            int size, int? prec, int? scale)



         result.Add(new EntityPropDef(
         PropertyHelper <VatRates>.GetProperty(x => x.Vatrecno),
         "VATRECNO", // columnName
         true,                    //isKey
         false, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  5, // int? prec
                           0  // int? Scale
         ,
         typeof(VatRates)
       ));


         result.Add(new EntityPropDef(
         PropertyHelper <VatRates>.GetProperty(x => x.Exclfromvatextract),
         "EXCLFROMVATEXTRACT", // columnName
         false,                    //isKey
         false, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  1, // int? prec
                           0  // int? Scale
         ,
         typeof(VatRates)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <VatRates>.GetProperty(x => x.Formno),
         "FORMNO", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  10, // int? prec
                           0  // int? Scale
         ,
         typeof(VatRates)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <VatRates>.GetProperty(x => x.Intercee),
         "INTERCEE", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  1, // int? prec
                           0  // int? Scale
         ,
         typeof(VatRates)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <VatRates>.GetProperty(x => x.Lstlogonno),
         "LSTLOGONNO", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  5, // int? prec
                           0  // int? Scale
         ,
         typeof(VatRates)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <VatRates>.GetProperty(x => x.Slpltype),
         "SLPLTYPE", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  5, // int? prec
                           0  // int? Scale
         ,
         typeof(VatRates)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <VatRates>.GetProperty(x => x.Vatdesc),
         "VATDESC", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         20,       // int size   
                  null, // int? prec
                   
         null // int? Scale
         ,
         typeof(VatRates)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <VatRates>.GetProperty(x => x.Vatganrecno),
         "VATGANRECNO", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  10, // int? prec
                           0  // int? Scale
         ,
         typeof(VatRates)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <VatRates>.GetProperty(x => x.Vatrate),
         "VATRATE", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  126, // int? prec
                   
         null // int? Scale
         ,
         typeof(VatRates)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <VatRates>.GetProperty(x => x.Vatrate2),
         "VATRATE2", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  126, // int? prec
                   
         null // int? Scale
         ,
         typeof(VatRates)
         ));
         return result; 
       }

#endregion     
        private int _fVatrecno;
        public int Vatrecno
        {
            get { return _fVatrecno; }
            set
            {
                var oldKey = Key;
                if (_fVatrecno != value)
                {
                    Modify();
                    _fVatrecno = value;
                    KeyChanged(oldKey);
                }
            }
        }

        private short _fExclfromvatextract;
        public short Exclfromvatextract
        {
            get { return _fExclfromvatextract; }
            set
            {
                if (_fExclfromvatextract != value)
                {
                    Modify();
                    _fExclfromvatextract = value;
                }
            }
        }

        private int? _fFormno;
        public int? Formno
        {
            get { return _fFormno; }
            set
            {
                if (_fFormno != value)
                {
                    Modify();
                    _fFormno = value;
                }
            }
        }

        private short? _fIntercee;
        public short? Intercee
        {
            get { return _fIntercee; }
            set
            {
                if (_fIntercee != value)
                {
                    Modify();
                    _fIntercee = value;
                }
            }
        }

        private int? _fLstlogonno;
        public int? Lstlogonno
        {
            get { return _fLstlogonno; }
            set
            {
                if (_fLstlogonno != value)
                {
                    Modify();
                    _fLstlogonno = value;
                }
            }
        }

        private int? _fSlpltype;
        public int? Slpltype
        {
            get { return _fSlpltype; }
            set
            {
                if (_fSlpltype != value)
                {
                    Modify();
                    _fSlpltype = value;
                }
            }
        }

        private string _fVatdesc;
        public string Vatdesc
        {
            get { return _fVatdesc; }
            set
            {
                if (_fVatdesc != value)
                {
                    Modify();
                    _fVatdesc = value;
                }
            }
        }

        private int? _fVatganrecno;
        public int? Vatganrecno
        {
            get { return _fVatganrecno; }
            set
            {
                if (_fVatganrecno != value)
                {
                    Modify();
                    _fVatganrecno = value;
                }
            }
        }

        private decimal? _fVatrate;
        public decimal? Vatrate
        {
            get { return _fVatrate; }
            set
            {
                if (_fVatrate != value)
                {
                    Modify();
                    _fVatrate = value;
                }
            }
        }

        private decimal? _fVatrate2;
        public decimal? Vatrate2
        {
            get { return _fVatrate2; }
            set
            {
                if (_fVatrate2 != value)
                {
                    Modify();
                    _fVatrate2 = value;
                }
            }
        }

        public override int Key
        {
            get { return Vatrecno; }
            set { Vatrecno = value; }
        }

        public override string KeyAsString { get { return Key.ToString(CultureInfo.InvariantCulture); } }


        public override VatRates Clone()
        {
            var obj = new VatRates
                {
                    Vatrecno = Vatrecno,
                    Exclfromvatextract = Exclfromvatextract,
                    Formno = Formno,
                    Intercee = Intercee,
                    Lstlogonno = Lstlogonno,
                    Slpltype = Slpltype,
                    Vatdesc = Vatdesc,
                    Vatganrecno = Vatganrecno,
                    Vatrate = Vatrate,
                    Vatrate2 = Vatrate2,
                };

            return obj;
        }

        public static class FieldNames
        {
// ReSharper disable InconsistentNaming
            public const string  VATRECNO = "VATRECNO";
            public const string  EXCLFROMVATEXTRACT = "EXCLFROMVATEXTRACT";
            public const string  FORMNO = "FORMNO";
            public const string  INTERCEE = "INTERCEE";
            public const string  LSTLOGONNO = "LSTLOGONNO";
            public const string  SLPLTYPE = "SLPLTYPE";
            public const string  VATDESC = "VATDESC";
            public const string  VATGANRECNO = "VATGANRECNO";
            public const string  VATRATE = "VATRATE";
            public const string  VATRATE2 = "VATRATE2";
 // ReSharper restore InconsistentNaming
        }


    }

}
