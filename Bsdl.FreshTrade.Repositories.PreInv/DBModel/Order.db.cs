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
    /// Entity for the ORDERS table
    /// </summary>
    public partial class Order : BaseDbModel<Order, int>
    {
#region tableDefs

       public static List<EntityPropDef> GetPropDefs() {
         var result = new List<EntityPropDef>();

//EntityPropDef(string propName, string columnName, bool isKey, bool isNullable, string refEntityName, PropertyInfo keyPropInfo,
//            int size, int? prec, int? scale)



         result.Add(new EntityPropDef(
         PropertyHelper <Order>.GetProperty(x => x.Ordrecno),
         "ORDRECNO", // columnName
         true,                    //isKey
         false, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  10, // int? prec
                           0  // int? Scale
         ,
         typeof(Order)
       ));


         result.Add(new EntityPropDef(
         PropertyHelper <Order>.GetProperty(x => x.Actcstcode),
         "ACTCSTCODE", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  10, // int? prec
                           0  // int? Scale
         ,
         typeof(Order)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <Order>.GetProperty(x => x.Ediuplrecno),
         "EDIUPLRECNO", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  10, // int? prec
                           0  // int? Scale
         ,
         typeof(Order)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <Order>.GetProperty(x => x.Isediord),
         "ISEDIORD", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  1, // int? prec
                           0  // int? Scale
         ,
         typeof(Order)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <Order>.GetProperty(x => x.Istradesale),
         "ISTRADESALE", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  1, // int? prec
                           0  // int? Scale
         ,
         typeof(Order)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <Order>.GetProperty(x => x.Ordaccname),
         "ORDACCNAME", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         40,       // int size   
                  null, // int? prec
                   
         null // int? Scale
         ,
         typeof(Order)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <Order>.GetProperty(x => x.Ordclaacccode),
         "ORDCLAACCCODE", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         8,       // int size   
                  null, // int? prec
                   
         null // int? Scale
         ,
         typeof(Order)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <Order>.GetProperty(x => x.Ordcstcode),
         "ORDCSTCODE", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  10, // int? prec
                           0  // int? Scale
         ,
         typeof(Order)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <Order>.GetProperty(x => x.Ordcustordno),
         "ORDCUSTORDNO", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         25,       // int size   
                  null, // int? prec
                   
         null // int? Scale
         ,
         typeof(Order)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <Order>.GetProperty(x => x.Orddate),
         "ORDDATE", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  null, // int? prec
                   
         null // int? Scale
         ,
         typeof(Order)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <Order>.GetProperty(x => x.Ordreqdeldate),
         "ORDREQDELDATE", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  null, // int? prec
                   
         null // int? Scale
         ,
         typeof(Order)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <Order>.GetProperty(x => x.Ordsaltyp),
         "ORDSALTYP", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         1,       // int size   
                  null, // int? prec
                   
         null // int? Scale
         ,
         typeof(Order)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <Order>.GetProperty(x => x.Ordsmnno),
         "ORDSMNNO", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  5, // int? prec
                           0  // int? Scale
         ,
         typeof(Order)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <Order>.GetProperty(x => x.Productionorder),
         "PRODUCTIONORDER", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  1, // int? prec
                           0  // int? Scale
         ,
         typeof(Order)
         ));
         return result; 
       }

#endregion     
        private int _fOrdrecno;
        public int Ordrecno
        {
            get { return _fOrdrecno; }
            set
            {
                var oldKey = Key;
                if (_fOrdrecno != value)
                {
                    Modify();
                    _fOrdrecno = value;
                    KeyChanged(oldKey);
                }
            }
        }

        private int? _fActcstcode;
        public int? Actcstcode
        {
            get { return _fActcstcode; }
            set
            {
                if (_fActcstcode != value)
                {
                    Modify();
                    _fActcstcode = value;
                }
            }
        }

        private int? _fEdiuplrecno;
        public int? Ediuplrecno
        {
            get { return _fEdiuplrecno; }
            set
            {
                if (_fEdiuplrecno != value)
                {
                    Modify();
                    _fEdiuplrecno = value;
                }
            }
        }

        private short? _fIsediord;
        public short? Isediord
        {
            get { return _fIsediord; }
            set
            {
                if (_fIsediord != value)
                {
                    Modify();
                    _fIsediord = value;
                }
            }
        }

        private short? _fIstradesale;
        public short? Istradesale
        {
            get { return _fIstradesale; }
            set
            {
                if (_fIstradesale != value)
                {
                    Modify();
                    _fIstradesale = value;
                }
            }
        }

        private string _fOrdaccname;
        public string Ordaccname
        {
            get { return _fOrdaccname; }
            set
            {
                if (_fOrdaccname != value)
                {
                    Modify();
                    _fOrdaccname = value;
                }
            }
        }

        private string _fOrdclaacccode;
        public string Ordclaacccode
        {
            get { return _fOrdclaacccode; }
            set
            {
                if (_fOrdclaacccode != value)
                {
                    Modify();
                    _fOrdclaacccode = value;
                }
            }
        }

        private int? _fOrdcstcode;
        public int? Ordcstcode
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

        private DateTime? _fOrdreqdeldate;
        public DateTime? Ordreqdeldate
        {
            get { return _fOrdreqdeldate; }
            set
            {
                if (_fOrdreqdeldate != value)
                {
                    Modify();
                    _fOrdreqdeldate = value;
                }
            }
        }

        private string _fOrdsaltyp;
        public string Ordsaltyp
        {
            get { return _fOrdsaltyp; }
            set
            {
                if (_fOrdsaltyp != value)
                {
                    Modify();
                    _fOrdsaltyp = value;
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

        private short? _fProductionorder;
        public short? Productionorder
        {
            get { return _fProductionorder; }
            set
            {
                if (_fProductionorder != value)
                {
                    Modify();
                    _fProductionorder = value;
                }
            }
        }

        public override int Key
        {
            get { return Ordrecno; }
            set { Ordrecno = value; }
        }

        public override string KeyAsString { get { return Key.ToString(CultureInfo.InvariantCulture); } }


        public override Order Clone()
        {
            var obj = new Order
                {
                    Ordrecno = Ordrecno,
                    Actcstcode = Actcstcode,
                    Ediuplrecno = Ediuplrecno,
                    Isediord = Isediord,
                    Istradesale = Istradesale,
                    Ordaccname = Ordaccname,
                    Ordclaacccode = Ordclaacccode,
                    Ordcstcode = Ordcstcode,
                    Ordcustordno = Ordcustordno,
                    Orddate = Orddate,
                    Ordreqdeldate = Ordreqdeldate,
                    Ordsaltyp = Ordsaltyp,
                    Ordsmnno = Ordsmnno,
                    Productionorder = Productionorder,
                };

            return obj;
        }

        public static class FieldNames
        {
// ReSharper disable InconsistentNaming
            public const string  ORDRECNO = "ORDRECNO";
            public const string  ACTCSTCODE = "ACTCSTCODE";
            public const string  EDIUPLRECNO = "EDIUPLRECNO";
            public const string  ISEDIORD = "ISEDIORD";
            public const string  ISTRADESALE = "ISTRADESALE";
            public const string  ORDACCNAME = "ORDACCNAME";
            public const string  ORDCLAACCCODE = "ORDCLAACCCODE";
            public const string  ORDCSTCODE = "ORDCSTCODE";
            public const string  ORDCUSTORDNO = "ORDCUSTORDNO";
            public const string  ORDDATE = "ORDDATE";
            public const string  ORDREQDELDATE = "ORDREQDELDATE";
            public const string  ORDSALTYP = "ORDSALTYP";
            public const string  ORDSMNNO = "ORDSMNNO";
            public const string  PRODUCTIONORDER = "PRODUCTIONORDER";
 // ReSharper restore InconsistentNaming
        }


    }

}
