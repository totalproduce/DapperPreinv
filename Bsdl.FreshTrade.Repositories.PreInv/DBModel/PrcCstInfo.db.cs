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
    /// Entity for the PRCCSTINFO table
    /// </summary>
    public partial class PrcCstInfo : BaseDbModel<PrcCstInfo, int>
    {
#region tableDefs

       public static List<EntityPropDef> GetPropDefs() {
         var result = new List<EntityPropDef>();

//EntityPropDef(string propName, string columnName, bool isKey, bool isNullable, string refEntityName, PropertyInfo keyPropInfo,
//            int size, int? prec, int? scale)



         result.Add(new EntityPropDef(
         PropertyHelper <PrcCstInfo>.GetProperty(x => x.Ppccltrecno),
         "PPCCLTRECNO", // columnName
         true,                    //isKey
         false, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  10, // int? prec
                           0  // int? Scale
         ,
         typeof(PrcCstInfo)
       ));


         result.Add(new EntityPropDef(
         PropertyHelper <PrcCstInfo>.GetProperty(x => x.Ppcclass),
         "PPCCLASS", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         10,       // int size   
                  null, // int? prec
                   
         null // int? Scale
         ,
         typeof(PrcCstInfo)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <PrcCstInfo>.GetProperty(x => x.Ppcclientprdno),
         "PPCCLIENTPRDNO", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         16,       // int size   
                  null, // int? prec
                   
         null // int? Scale
         ,
         typeof(PrcCstInfo)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <PrcCstInfo>.GetProperty(x => x.Ppcconsumerunit),
         "PPCCONSUMERUNIT", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  10, // int? prec
                           0  // int? Scale
         ,
         typeof(PrcCstInfo)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <PrcCstInfo>.GetProperty(x => x.Ppcgrpno),
         "PPCGRPNO", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  5, // int? prec
                           0  // int? Scale
         ,
         typeof(PrcCstInfo)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <PrcCstInfo>.GetProperty(x => x.Ppcorigin),
         "PPCORIGIN", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         20,       // int size   
                  null, // int? prec
                   
         null // int? Scale
         ,
         typeof(PrcCstInfo)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <PrcCstInfo>.GetProperty(x => x.Ppcprdctnplus),
         "PPCPRDCTNPLUS", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  5, // int? prec
                           0  // int? Scale
         ,
         typeof(PrcCstInfo)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <PrcCstInfo>.GetProperty(x => x.Ppcprdctnplus2),
         "PPCPRDCTNPLUS2", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  5, // int? prec
                           0  // int? Scale
         ,
         typeof(PrcCstInfo)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <PrcCstInfo>.GetProperty(x => x.Ppcprddesc),
         "PPCPRDDESC", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         50,       // int size   
                  null, // int? prec
                   
         null // int? Scale
         ,
         typeof(PrcCstInfo)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <PrcCstInfo>.GetProperty(x => x.Ppcsize),
         "PPCSIZE", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         10,       // int size   
                  null, // int? prec
                   
         null // int? Scale
         ,
         typeof(PrcCstInfo)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <PrcCstInfo>.GetProperty(x => x.Ppcsku),
         "PPCSKU", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         14,       // int size   
                  null, // int? prec
                   
         null // int? Scale
         ,
         typeof(PrcCstInfo)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <PrcCstInfo>.GetProperty(x => x.Ppctargetwgt),
         "PPCTARGETWGT", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         10,       // int size   
                  null, // int? prec
                   
         null // int? Scale
         ,
         typeof(PrcCstInfo)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <PrcCstInfo>.GetProperty(x => x.Ppctradedunit),
         "PPCTRADEDUNIT", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         14,       // int size   
                  null, // int? prec
                   
         null // int? Scale
         ,
         typeof(PrcCstInfo)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <PrcCstInfo>.GetProperty(x => x.Ppcunitcount),
         "PPCUNITCOUNT", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  5, // int? prec
                           0  // int? Scale
         ,
         typeof(PrcCstInfo)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <PrcCstInfo>.GetProperty(x => x.Ppcwgtdeclaredbox),
         "PPCWGTDECLAREDBOX", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         10,       // int size   
                  null, // int? prec
                   
         null // int? Scale
         ,
         typeof(PrcCstInfo)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <PrcCstInfo>.GetProperty(x => x.Ppcwgtdeclaredpack),
         "PPCWGTDECLAREDPACK", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         10,       // int size   
                  null, // int? prec
                   
         null // int? Scale
         ,
         typeof(PrcCstInfo)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <PrcCstInfo>.GetProperty(x => x.Productedicode),
         "PRODUCTEDICODE", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         6,       // int size   
                  null, // int? prec
                   
         null // int? Scale
         ,
         typeof(PrcCstInfo)
         ));
         return result; 
       }

#endregion     
        private int _fPpccltrecno;
        public int Ppccltrecno
        {
            get { return _fPpccltrecno; }
            set
            {
                var oldKey = Key;
                if (_fPpccltrecno != value)
                {
                    Modify();
                    _fPpccltrecno = value;
                    KeyChanged(oldKey);
                }
            }
        }

        private string _fPpcclass;
        public string Ppcclass
        {
            get { return _fPpcclass; }
            set
            {
                if (_fPpcclass != value)
                {
                    Modify();
                    _fPpcclass = value;
                }
            }
        }

        private string _fPpcclientprdno;
        public string Ppcclientprdno
        {
            get { return _fPpcclientprdno; }
            set
            {
                if (_fPpcclientprdno != value)
                {
                    Modify();
                    _fPpcclientprdno = value;
                }
            }
        }

        private int? _fPpcconsumerunit;
        public int? Ppcconsumerunit
        {
            get { return _fPpcconsumerunit; }
            set
            {
                if (_fPpcconsumerunit != value)
                {
                    Modify();
                    _fPpcconsumerunit = value;
                }
            }
        }

        private int? _fPpcgrpno;
        public int? Ppcgrpno
        {
            get { return _fPpcgrpno; }
            set
            {
                if (_fPpcgrpno != value)
                {
                    Modify();
                    _fPpcgrpno = value;
                }
            }
        }

        private string _fPpcorigin;
        public string Ppcorigin
        {
            get { return _fPpcorigin; }
            set
            {
                if (_fPpcorigin != value)
                {
                    Modify();
                    _fPpcorigin = value;
                }
            }
        }

        private int? _fPpcprdctnplus;
        public int? Ppcprdctnplus
        {
            get { return _fPpcprdctnplus; }
            set
            {
                if (_fPpcprdctnplus != value)
                {
                    Modify();
                    _fPpcprdctnplus = value;
                }
            }
        }

        private int? _fPpcprdctnplus2;
        public int? Ppcprdctnplus2
        {
            get { return _fPpcprdctnplus2; }
            set
            {
                if (_fPpcprdctnplus2 != value)
                {
                    Modify();
                    _fPpcprdctnplus2 = value;
                }
            }
        }

        private string _fPpcprddesc;
        public string Ppcprddesc
        {
            get { return _fPpcprddesc; }
            set
            {
                if (_fPpcprddesc != value)
                {
                    Modify();
                    _fPpcprddesc = value;
                }
            }
        }

        private string _fPpcsize;
        public string Ppcsize
        {
            get { return _fPpcsize; }
            set
            {
                if (_fPpcsize != value)
                {
                    Modify();
                    _fPpcsize = value;
                }
            }
        }

        private string _fPpcsku;
        public string Ppcsku
        {
            get { return _fPpcsku; }
            set
            {
                if (_fPpcsku != value)
                {
                    Modify();
                    _fPpcsku = value;
                }
            }
        }

        private string _fPpctargetwgt;
        public string Ppctargetwgt
        {
            get { return _fPpctargetwgt; }
            set
            {
                if (_fPpctargetwgt != value)
                {
                    Modify();
                    _fPpctargetwgt = value;
                }
            }
        }

        private string _fPpctradedunit;
        public string Ppctradedunit
        {
            get { return _fPpctradedunit; }
            set
            {
                if (_fPpctradedunit != value)
                {
                    Modify();
                    _fPpctradedunit = value;
                }
            }
        }

        private int? _fPpcunitcount;
        public int? Ppcunitcount
        {
            get { return _fPpcunitcount; }
            set
            {
                if (_fPpcunitcount != value)
                {
                    Modify();
                    _fPpcunitcount = value;
                }
            }
        }

        private string _fPpcwgtdeclaredbox;
        public string Ppcwgtdeclaredbox
        {
            get { return _fPpcwgtdeclaredbox; }
            set
            {
                if (_fPpcwgtdeclaredbox != value)
                {
                    Modify();
                    _fPpcwgtdeclaredbox = value;
                }
            }
        }

        private string _fPpcwgtdeclaredpack;
        public string Ppcwgtdeclaredpack
        {
            get { return _fPpcwgtdeclaredpack; }
            set
            {
                if (_fPpcwgtdeclaredpack != value)
                {
                    Modify();
                    _fPpcwgtdeclaredpack = value;
                }
            }
        }

        private string _fProductedicode;
        public string Productedicode
        {
            get { return _fProductedicode; }
            set
            {
                if (_fProductedicode != value)
                {
                    Modify();
                    _fProductedicode = value;
                }
            }
        }

        public override int Key
        {
            get { return Ppccltrecno; }
            set { Ppccltrecno = value; }
        }

        public override string KeyAsString { get { return Key.ToString(CultureInfo.InvariantCulture); } }


        public override PrcCstInfo Clone()
        {
            var obj = new PrcCstInfo
                {
                    Ppccltrecno = Ppccltrecno,
                    Ppcclass = Ppcclass,
                    Ppcclientprdno = Ppcclientprdno,
                    Ppcconsumerunit = Ppcconsumerunit,
                    Ppcgrpno = Ppcgrpno,
                    Ppcorigin = Ppcorigin,
                    Ppcprdctnplus = Ppcprdctnplus,
                    Ppcprdctnplus2 = Ppcprdctnplus2,
                    Ppcprddesc = Ppcprddesc,
                    Ppcsize = Ppcsize,
                    Ppcsku = Ppcsku,
                    Ppctargetwgt = Ppctargetwgt,
                    Ppctradedunit = Ppctradedunit,
                    Ppcunitcount = Ppcunitcount,
                    Ppcwgtdeclaredbox = Ppcwgtdeclaredbox,
                    Ppcwgtdeclaredpack = Ppcwgtdeclaredpack,
                    Productedicode = Productedicode,
                };

            return obj;
        }

        public static class FieldNames
        {
// ReSharper disable InconsistentNaming
            public const string  PPCCLTRECNO = "PPCCLTRECNO";
            public const string  PPCCLASS = "PPCCLASS";
            public const string  PPCCLIENTPRDNO = "PPCCLIENTPRDNO";
            public const string  PPCCONSUMERUNIT = "PPCCONSUMERUNIT";
            public const string  PPCGRPNO = "PPCGRPNO";
            public const string  PPCORIGIN = "PPCORIGIN";
            public const string  PPCPRDCTNPLUS = "PPCPRDCTNPLUS";
            public const string  PPCPRDCTNPLUS2 = "PPCPRDCTNPLUS2";
            public const string  PPCPRDDESC = "PPCPRDDESC";
            public const string  PPCSIZE = "PPCSIZE";
            public const string  PPCSKU = "PPCSKU";
            public const string  PPCTARGETWGT = "PPCTARGETWGT";
            public const string  PPCTRADEDUNIT = "PPCTRADEDUNIT";
            public const string  PPCUNITCOUNT = "PPCUNITCOUNT";
            public const string  PPCWGTDECLAREDBOX = "PPCWGTDECLAREDBOX";
            public const string  PPCWGTDECLAREDPACK = "PPCWGTDECLAREDPACK";
            public const string  PRODUCTEDICODE = "PRODUCTEDICODE";
 // ReSharper restore InconsistentNaming
        }


    }

}
