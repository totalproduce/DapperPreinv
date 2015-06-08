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
    /// Entity for the VATLINKS table
    /// </summary>
    public partial class VatLinks : BaseDbModel<VatLinks, int>
    {
#region tableDefs

       public static List<EntityPropDef> GetPropDefs() {
         var result = new List<EntityPropDef>();

//EntityPropDef(string propName, string columnName, bool isKey, bool isNullable, string refEntityName, PropertyInfo keyPropInfo,
//            int size, int? prec, int? scale)



         result.Add(new EntityPropDef(
         PropertyHelper <VatLinks>.GetProperty(x => x.Vatlnkrecno),
         "VATLNKRECNO", // columnName
         true,                    //isKey
         false, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  5, // int? prec
                           0  // int? Scale
         ,
         typeof(VatLinks)
       ));


         result.Add(new EntityPropDef(
         PropertyHelper <VatLinks>.GetProperty(x => x.Chgvatgrpno),
         "CHGVATGRPNO", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  5, // int? prec
                           0  // int? Scale
         ,
         typeof(VatLinks)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <VatLinks>.GetProperty(x => x.Cstvattype),
         "CSTVATTYPE", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  5, // int? prec
                           0  // int? Scale
         ,
         typeof(VatLinks)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <VatLinks>.GetProperty(x => x.Finfiscrep),
         "FINFISCREP", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         2,       // int size   
                  null, // int? prec
                   
         null // int? Scale
         ,
         typeof(VatLinks)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <VatLinks>.GetProperty(x => x.Fingroup),
         "FINGROUP", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  5, // int? prec
                           0  // int? Scale
         ,
         typeof(VatLinks)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <VatLinks>.GetProperty(x => x.Finvatcode),
         "FINVATCODE", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         2,       // int size   
                  null, // int? prec
                   
         null // int? Scale
         ,
         typeof(VatLinks)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <VatLinks>.GetProperty(x => x.Formno),
         "FORMNO", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  10, // int? prec
                           0  // int? Scale
         ,
         typeof(VatLinks)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <VatLinks>.GetProperty(x => x.Lstlogonno),
         "LSTLOGONNO", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  5, // int? prec
                           0  // int? Scale
         ,
         typeof(VatLinks)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <VatLinks>.GetProperty(x => x.Panitref1),
         "PANITREF1", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  5, // int? prec
                           0  // int? Scale
         ,
         typeof(VatLinks)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <VatLinks>.GetProperty(x => x.Panitref2),
         "PANITREF2", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  5, // int? prec
                           0  // int? Scale
         ,
         typeof(VatLinks)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <VatLinks>.GetProperty(x => x.Panitref3),
         "PANITREF3", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  5, // int? prec
                           0  // int? Scale
         ,
         typeof(VatLinks)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <VatLinks>.GetProperty(x => x.Panitref4),
         "PANITREF4", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  5, // int? prec
                           0  // int? Scale
         ,
         typeof(VatLinks)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <VatLinks>.GetProperty(x => x.Panitref5),
         "PANITREF5", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  5, // int? prec
                           0  // int? Scale
         ,
         typeof(VatLinks)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <VatLinks>.GetProperty(x => x.Panitref6),
         "PANITREF6", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  5, // int? prec
                           0  // int? Scale
         ,
         typeof(VatLinks)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <VatLinks>.GetProperty(x => x.Vatacccstsup),
         "VATACCCSTSUP", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  5, // int? prec
                           0  // int? Scale
         ,
         typeof(VatLinks)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <VatLinks>.GetProperty(x => x.Vatctyno),
         "VATCTYNO", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  5, // int? prec
                           0  // int? Scale
         ,
         typeof(VatLinks)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <VatLinks>.GetProperty(x => x.Vatdlvcountryno),
         "VATDLVCOUNTRYNO", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  5, // int? prec
                           0  // int? Scale
         ,
         typeof(VatLinks)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <VatLinks>.GetProperty(x => x.Vatdlvtype),
         "VATDLVTYPE", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  5, // int? prec
                           0  // int? Scale
         ,
         typeof(VatLinks)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <VatLinks>.GetProperty(x => x.Vatfromcountryno),
         "VATFROMCOUNTRYNO", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  5, // int? prec
                           0  // int? Scale
         ,
         typeof(VatLinks)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <VatLinks>.GetProperty(x => x.Vatprcref1),
         "VATPRCREF1", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  5, // int? prec
                           0  // int? Scale
         ,
         typeof(VatLinks)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <VatLinks>.GetProperty(x => x.Vatprcref2),
         "VATPRCREF2", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  5, // int? prec
                           0  // int? Scale
         ,
         typeof(VatLinks)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <VatLinks>.GetProperty(x => x.Vatprcref3),
         "VATPRCREF3", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  5, // int? prec
                           0  // int? Scale
         ,
         typeof(VatLinks)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <VatLinks>.GetProperty(x => x.Vatprcref4),
         "VATPRCREF4", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  5, // int? prec
                           0  // int? Scale
         ,
         typeof(VatLinks)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <VatLinks>.GetProperty(x => x.Vatprcref5),
         "VATPRCREF5", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  5, // int? prec
                           0  // int? Scale
         ,
         typeof(VatLinks)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <VatLinks>.GetProperty(x => x.Vatprcref6),
         "VATPRCREF6", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  5, // int? prec
                           0  // int? Scale
         ,
         typeof(VatLinks)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <VatLinks>.GetProperty(x => x.Vatrecno),
         "VATRECNO", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  5, // int? prec
                           0  // int? Scale
         ,
         typeof(VatLinks)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <VatLinks>.GetProperty(x => x.Vatsalesoffice),
         "VATSALESOFFICE", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  5, // int? prec
                           0  // int? Scale
         ,
         typeof(VatLinks)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <VatLinks>.GetProperty(x => x.Vatvearecno),
         "VATVEARECNO", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  5, // int? prec
                           0  // int? Scale
         ,
         typeof(VatLinks)
         ));
         return result; 
       }

#endregion     
        private int _fVatlnkrecno;
        public int Vatlnkrecno
        {
            get { return _fVatlnkrecno; }
            set
            {
                var oldKey = Key;
                if (_fVatlnkrecno != value)
                {
                    Modify();
                    _fVatlnkrecno = value;
                    KeyChanged(oldKey);
                }
            }
        }

        private int? _fChgvatgrpno;
        public int? Chgvatgrpno
        {
            get { return _fChgvatgrpno; }
            set
            {
                if (_fChgvatgrpno != value)
                {
                    Modify();
                    _fChgvatgrpno = value;
                }
            }
        }

        private int? _fCstvattype;
        public int? Cstvattype
        {
            get { return _fCstvattype; }
            set
            {
                if (_fCstvattype != value)
                {
                    Modify();
                    _fCstvattype = value;
                }
            }
        }

        private string _fFinfiscrep;
        public string Finfiscrep
        {
            get { return _fFinfiscrep; }
            set
            {
                if (_fFinfiscrep != value)
                {
                    Modify();
                    _fFinfiscrep = value;
                }
            }
        }

        private int? _fFingroup;
        public int? Fingroup
        {
            get { return _fFingroup; }
            set
            {
                if (_fFingroup != value)
                {
                    Modify();
                    _fFingroup = value;
                }
            }
        }

        private string _fFinvatcode;
        public string Finvatcode
        {
            get { return _fFinvatcode; }
            set
            {
                if (_fFinvatcode != value)
                {
                    Modify();
                    _fFinvatcode = value;
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

        private int? _fPanitref1;
        public int? Panitref1
        {
            get { return _fPanitref1; }
            set
            {
                if (_fPanitref1 != value)
                {
                    Modify();
                    _fPanitref1 = value;
                }
            }
        }

        private int? _fPanitref2;
        public int? Panitref2
        {
            get { return _fPanitref2; }
            set
            {
                if (_fPanitref2 != value)
                {
                    Modify();
                    _fPanitref2 = value;
                }
            }
        }

        private int? _fPanitref3;
        public int? Panitref3
        {
            get { return _fPanitref3; }
            set
            {
                if (_fPanitref3 != value)
                {
                    Modify();
                    _fPanitref3 = value;
                }
            }
        }

        private int? _fPanitref4;
        public int? Panitref4
        {
            get { return _fPanitref4; }
            set
            {
                if (_fPanitref4 != value)
                {
                    Modify();
                    _fPanitref4 = value;
                }
            }
        }

        private int? _fPanitref5;
        public int? Panitref5
        {
            get { return _fPanitref5; }
            set
            {
                if (_fPanitref5 != value)
                {
                    Modify();
                    _fPanitref5 = value;
                }
            }
        }

        private int? _fPanitref6;
        public int? Panitref6
        {
            get { return _fPanitref6; }
            set
            {
                if (_fPanitref6 != value)
                {
                    Modify();
                    _fPanitref6 = value;
                }
            }
        }

        private int? _fVatacccstsup;
        public int? Vatacccstsup
        {
            get { return _fVatacccstsup; }
            set
            {
                if (_fVatacccstsup != value)
                {
                    Modify();
                    _fVatacccstsup = value;
                }
            }
        }

        private int? _fVatctyno;
        public int? Vatctyno
        {
            get { return _fVatctyno; }
            set
            {
                if (_fVatctyno != value)
                {
                    Modify();
                    _fVatctyno = value;
                }
            }
        }

        private int? _fVatdlvcountryno;
        public int? Vatdlvcountryno
        {
            get { return _fVatdlvcountryno; }
            set
            {
                if (_fVatdlvcountryno != value)
                {
                    Modify();
                    _fVatdlvcountryno = value;
                }
            }
        }

        private int? _fVatdlvtype;
        public int? Vatdlvtype
        {
            get { return _fVatdlvtype; }
            set
            {
                if (_fVatdlvtype != value)
                {
                    Modify();
                    _fVatdlvtype = value;
                }
            }
        }

        private int? _fVatfromcountryno;
        public int? Vatfromcountryno
        {
            get { return _fVatfromcountryno; }
            set
            {
                if (_fVatfromcountryno != value)
                {
                    Modify();
                    _fVatfromcountryno = value;
                }
            }
        }

        private int? _fVatprcref1;
        public int? Vatprcref1
        {
            get { return _fVatprcref1; }
            set
            {
                if (_fVatprcref1 != value)
                {
                    Modify();
                    _fVatprcref1 = value;
                }
            }
        }

        private int? _fVatprcref2;
        public int? Vatprcref2
        {
            get { return _fVatprcref2; }
            set
            {
                if (_fVatprcref2 != value)
                {
                    Modify();
                    _fVatprcref2 = value;
                }
            }
        }

        private int? _fVatprcref3;
        public int? Vatprcref3
        {
            get { return _fVatprcref3; }
            set
            {
                if (_fVatprcref3 != value)
                {
                    Modify();
                    _fVatprcref3 = value;
                }
            }
        }

        private int? _fVatprcref4;
        public int? Vatprcref4
        {
            get { return _fVatprcref4; }
            set
            {
                if (_fVatprcref4 != value)
                {
                    Modify();
                    _fVatprcref4 = value;
                }
            }
        }

        private int? _fVatprcref5;
        public int? Vatprcref5
        {
            get { return _fVatprcref5; }
            set
            {
                if (_fVatprcref5 != value)
                {
                    Modify();
                    _fVatprcref5 = value;
                }
            }
        }

        private int? _fVatprcref6;
        public int? Vatprcref6
        {
            get { return _fVatprcref6; }
            set
            {
                if (_fVatprcref6 != value)
                {
                    Modify();
                    _fVatprcref6 = value;
                }
            }
        }

        private int? _fVatrecno;
        public int? Vatrecno
        {
            get { return _fVatrecno; }
            set
            {
                if (_fVatrecno != value)
                {
                    Modify();
                    _fVatrecno = value;
                }
            }
        }

        private int? _fVatsalesoffice;
        public int? Vatsalesoffice
        {
            get { return _fVatsalesoffice; }
            set
            {
                if (_fVatsalesoffice != value)
                {
                    Modify();
                    _fVatsalesoffice = value;
                }
            }
        }

        private int? _fVatvearecno;
        public int? Vatvearecno
        {
            get { return _fVatvearecno; }
            set
            {
                if (_fVatvearecno != value)
                {
                    Modify();
                    _fVatvearecno = value;
                }
            }
        }

        public override int Key
        {
            get { return Vatlnkrecno; }
            set { Vatlnkrecno = value; }
        }

        public override string KeyAsString { get { return Key.ToString(CultureInfo.InvariantCulture); } }


        public override VatLinks Clone()
        {
            var obj = new VatLinks
                {
                    Vatlnkrecno = Vatlnkrecno,
                    Chgvatgrpno = Chgvatgrpno,
                    Cstvattype = Cstvattype,
                    Finfiscrep = Finfiscrep,
                    Fingroup = Fingroup,
                    Finvatcode = Finvatcode,
                    Formno = Formno,
                    Lstlogonno = Lstlogonno,
                    Panitref1 = Panitref1,
                    Panitref2 = Panitref2,
                    Panitref3 = Panitref3,
                    Panitref4 = Panitref4,
                    Panitref5 = Panitref5,
                    Panitref6 = Panitref6,
                    Vatacccstsup = Vatacccstsup,
                    Vatctyno = Vatctyno,
                    Vatdlvcountryno = Vatdlvcountryno,
                    Vatdlvtype = Vatdlvtype,
                    Vatfromcountryno = Vatfromcountryno,
                    Vatprcref1 = Vatprcref1,
                    Vatprcref2 = Vatprcref2,
                    Vatprcref3 = Vatprcref3,
                    Vatprcref4 = Vatprcref4,
                    Vatprcref5 = Vatprcref5,
                    Vatprcref6 = Vatprcref6,
                    Vatrecno = Vatrecno,
                    Vatsalesoffice = Vatsalesoffice,
                    Vatvearecno = Vatvearecno,
                };

            return obj;
        }

        public static class FieldNames
        {
// ReSharper disable InconsistentNaming
            public const string  VATLNKRECNO = "VATLNKRECNO";
            public const string  CHGVATGRPNO = "CHGVATGRPNO";
            public const string  CSTVATTYPE = "CSTVATTYPE";
            public const string  FINFISCREP = "FINFISCREP";
            public const string  FINGROUP = "FINGROUP";
            public const string  FINVATCODE = "FINVATCODE";
            public const string  FORMNO = "FORMNO";
            public const string  LSTLOGONNO = "LSTLOGONNO";
            public const string  PANITREF1 = "PANITREF1";
            public const string  PANITREF2 = "PANITREF2";
            public const string  PANITREF3 = "PANITREF3";
            public const string  PANITREF4 = "PANITREF4";
            public const string  PANITREF5 = "PANITREF5";
            public const string  PANITREF6 = "PANITREF6";
            public const string  VATACCCSTSUP = "VATACCCSTSUP";
            public const string  VATCTYNO = "VATCTYNO";
            public const string  VATDLVCOUNTRYNO = "VATDLVCOUNTRYNO";
            public const string  VATDLVTYPE = "VATDLVTYPE";
            public const string  VATFROMCOUNTRYNO = "VATFROMCOUNTRYNO";
            public const string  VATPRCREF1 = "VATPRCREF1";
            public const string  VATPRCREF2 = "VATPRCREF2";
            public const string  VATPRCREF3 = "VATPRCREF3";
            public const string  VATPRCREF4 = "VATPRCREF4";
            public const string  VATPRCREF5 = "VATPRCREF5";
            public const string  VATPRCREF6 = "VATPRCREF6";
            public const string  VATRECNO = "VATRECNO";
            public const string  VATSALESOFFICE = "VATSALESOFFICE";
            public const string  VATVEARECNO = "VATVEARECNO";
 // ReSharper restore InconsistentNaming
        }


    }

}
