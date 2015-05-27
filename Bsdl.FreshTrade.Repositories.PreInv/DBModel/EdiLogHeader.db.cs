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
    /// Entity for the EDILOGHEADER table
    /// </summary>
    public partial class EdiLogHeader : BaseDbModel<EdiLogHeader, int>
    {
#region tableDefs

       public static List<EntityPropDef> GetPropDefs() {
         var result = new List<EntityPropDef>();

//EntityPropDef(string propName, string columnName, bool isKey, bool isNullable, string refEntityName, PropertyInfo keyPropInfo,
//            int size, int? prec, int? scale)



         result.Add(new EntityPropDef(
         PropertyHelper <EdiLogHeader>.GetProperty(x => x.Ehheadid),
         "EHHEADID", // columnName
         true,                    //isKey
         false, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  10, // int? prec
                           0  // int? Scale
         ,
         typeof(EdiLogHeader)
       ));


         result.Add(new EntityPropDef(
         PropertyHelper <EdiLogHeader>.GetProperty(x => x.Ehbaserate),
         "EHBASERATE", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  126, // int? prec
                   
         null // int? Scale
         ,
         typeof(EdiLogHeader)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <EdiLogHeader>.GetProperty(x => x.Ehbatchprintno),
         "EHBATCHPRINTNO", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  5, // int? prec
                           0  // int? Scale
         ,
         typeof(EdiLogHeader)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <EdiLogHeader>.GetProperty(x => x.Ehbatrecno),
         "EHBATRECNO", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  10, // int? prec
                           0  // int? Scale
         ,
         typeof(EdiLogHeader)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <EdiLogHeader>.GetProperty(x => x.Ehcompanyno),
         "EHCOMPANYNO", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  5, // int? prec
                           0  // int? Scale
         ,
         typeof(EdiLogHeader)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <EdiLogHeader>.GetProperty(x => x.Ehcurno),
         "EHCURNO", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  5, // int? prec
                           0  // int? Scale
         ,
         typeof(EdiLogHeader)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <EdiLogHeader>.GetProperty(x => x.Eheurorate),
         "EHEURORATE", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  126, // int? prec
                   
         null // int? Scale
         ,
         typeof(EdiLogHeader)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <EdiLogHeader>.GetProperty(x => x.Ehhocode),
         "EHHOCODE", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  5, // int? prec
                           0  // int? Scale
         ,
         typeof(EdiLogHeader)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <EdiLogHeader>.GetProperty(x => x.Ehsalesoffice),
         "EHSALESOFFICE", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  5, // int? prec
                           0  // int? Scale
         ,
         typeof(EdiLogHeader)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <EdiLogHeader>.GetProperty(x => x.Ehtransdate),
         "EHTRANSDATE", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  null, // int? prec
                   
         null // int? Scale
         ,
         typeof(EdiLogHeader)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <EdiLogHeader>.GetProperty(x => x.Ehtransfilename),
         "EHTRANSFILENAME", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         25,       // int size   
                  null, // int? prec
                   
         null // int? Scale
         ,
         typeof(EdiLogHeader)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <EdiLogHeader>.GetProperty(x => x.Ehtransformat),
         "EHTRANSFORMAT", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         10,       // int size   
                  null, // int? prec
                   
         null // int? Scale
         ,
         typeof(EdiLogHeader)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <EdiLogHeader>.GetProperty(x => x.Ehtransrecno),
         "EHTRANSRECNO", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  10, // int? prec
                           0  // int? Scale
         ,
         typeof(EdiLogHeader)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <EdiLogHeader>.GetProperty(x => x.Ehtransref),
         "EHTRANSREF", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  5, // int? prec
                           0  // int? Scale
         ,
         typeof(EdiLogHeader)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <EdiLogHeader>.GetProperty(x => x.Ehtranstype),
         "EHTRANSTYPE", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         3,       // int size   
                  null, // int? prec
                   
         null // int? Scale
         ,
         typeof(EdiLogHeader)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <EdiLogHeader>.GetProperty(x => x.Ehtriangulate),
         "EHTRIANGULATE", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  1, // int? prec
                           0  // int? Scale
         ,
         typeof(EdiLogHeader)
         ));
         return result; 
       }

#endregion     
        private int _fEhheadid;
        public int Ehheadid
        {
            get { return _fEhheadid; }
            set
            {
                var oldKey = Key;
                if (_fEhheadid != value)
                {
                    Modify();
                    _fEhheadid = value;
                    KeyChanged(oldKey);
                }
            }
        }

        private decimal? _fEhbaserate;
        public decimal? Ehbaserate
        {
            get { return _fEhbaserate; }
            set
            {
                if (_fEhbaserate != value)
                {
                    Modify();
                    _fEhbaserate = value;
                }
            }
        }

        private int? _fEhbatchprintno;
        public int? Ehbatchprintno
        {
            get { return _fEhbatchprintno; }
            set
            {
                if (_fEhbatchprintno != value)
                {
                    Modify();
                    _fEhbatchprintno = value;
                }
            }
        }

        private int? _fEhbatrecno;
        public int? Ehbatrecno
        {
            get { return _fEhbatrecno; }
            set
            {
                if (_fEhbatrecno != value)
                {
                    Modify();
                    _fEhbatrecno = value;
                }
            }
        }

        private int? _fEhcompanyno;
        public int? Ehcompanyno
        {
            get { return _fEhcompanyno; }
            set
            {
                if (_fEhcompanyno != value)
                {
                    Modify();
                    _fEhcompanyno = value;
                }
            }
        }

        private int? _fEhcurno;
        public int? Ehcurno
        {
            get { return _fEhcurno; }
            set
            {
                if (_fEhcurno != value)
                {
                    Modify();
                    _fEhcurno = value;
                }
            }
        }

        private decimal? _fEheurorate;
        public decimal? Eheurorate
        {
            get { return _fEheurorate; }
            set
            {
                if (_fEheurorate != value)
                {
                    Modify();
                    _fEheurorate = value;
                }
            }
        }

        private int? _fEhhocode;
        public int? Ehhocode
        {
            get { return _fEhhocode; }
            set
            {
                if (_fEhhocode != value)
                {
                    Modify();
                    _fEhhocode = value;
                }
            }
        }

        private int? _fEhsalesoffice;
        public int? Ehsalesoffice
        {
            get { return _fEhsalesoffice; }
            set
            {
                if (_fEhsalesoffice != value)
                {
                    Modify();
                    _fEhsalesoffice = value;
                }
            }
        }

        private DateTime? _fEhtransdate;
        public DateTime? Ehtransdate
        {
            get { return _fEhtransdate; }
            set
            {
                if (_fEhtransdate != value)
                {
                    Modify();
                    _fEhtransdate = value;
                }
            }
        }

        private string _fEhtransfilename;
        public string Ehtransfilename
        {
            get { return _fEhtransfilename; }
            set
            {
                if (_fEhtransfilename != value)
                {
                    Modify();
                    _fEhtransfilename = value;
                }
            }
        }

        private string _fEhtransformat;
        public string Ehtransformat
        {
            get { return _fEhtransformat; }
            set
            {
                if (_fEhtransformat != value)
                {
                    Modify();
                    _fEhtransformat = value;
                }
            }
        }

        private int? _fEhtransrecno;
        public int? Ehtransrecno
        {
            get { return _fEhtransrecno; }
            set
            {
                if (_fEhtransrecno != value)
                {
                    Modify();
                    _fEhtransrecno = value;
                }
            }
        }

        private int? _fEhtransref;
        public int? Ehtransref
        {
            get { return _fEhtransref; }
            set
            {
                if (_fEhtransref != value)
                {
                    Modify();
                    _fEhtransref = value;
                }
            }
        }

        private string _fEhtranstype;
        public string Ehtranstype
        {
            get { return _fEhtranstype; }
            set
            {
                if (_fEhtranstype != value)
                {
                    Modify();
                    _fEhtranstype = value;
                }
            }
        }

        private short? _fEhtriangulate;
        public short? Ehtriangulate
        {
            get { return _fEhtriangulate; }
            set
            {
                if (_fEhtriangulate != value)
                {
                    Modify();
                    _fEhtriangulate = value;
                }
            }
        }

        public override int Key
        {
            get { return Ehheadid; }
            set { Ehheadid = value; }
        }

        public override string KeyAsString { get { return Key.ToString(CultureInfo.InvariantCulture); } }


        public override EdiLogHeader Clone()
        {
            var obj = new EdiLogHeader
                {
                    Ehheadid = Ehheadid,
                    Ehbaserate = Ehbaserate,
                    Ehbatchprintno = Ehbatchprintno,
                    Ehbatrecno = Ehbatrecno,
                    Ehcompanyno = Ehcompanyno,
                    Ehcurno = Ehcurno,
                    Eheurorate = Eheurorate,
                    Ehhocode = Ehhocode,
                    Ehsalesoffice = Ehsalesoffice,
                    Ehtransdate = Ehtransdate,
                    Ehtransfilename = Ehtransfilename,
                    Ehtransformat = Ehtransformat,
                    Ehtransrecno = Ehtransrecno,
                    Ehtransref = Ehtransref,
                    Ehtranstype = Ehtranstype,
                    Ehtriangulate = Ehtriangulate,
                };

            return obj;
        }

        public static class FieldNames
        {
// ReSharper disable InconsistentNaming
            public const string  EHHEADID = "EHHEADID";
            public const string  EHBASERATE = "EHBASERATE";
            public const string  EHBATCHPRINTNO = "EHBATCHPRINTNO";
            public const string  EHBATRECNO = "EHBATRECNO";
            public const string  EHCOMPANYNO = "EHCOMPANYNO";
            public const string  EHCURNO = "EHCURNO";
            public const string  EHEURORATE = "EHEURORATE";
            public const string  EHHOCODE = "EHHOCODE";
            public const string  EHSALESOFFICE = "EHSALESOFFICE";
            public const string  EHTRANSDATE = "EHTRANSDATE";
            public const string  EHTRANSFILENAME = "EHTRANSFILENAME";
            public const string  EHTRANSFORMAT = "EHTRANSFORMAT";
            public const string  EHTRANSRECNO = "EHTRANSRECNO";
            public const string  EHTRANSREF = "EHTRANSREF";
            public const string  EHTRANSTYPE = "EHTRANSTYPE";
            public const string  EHTRIANGULATE = "EHTRIANGULATE";
 // ReSharper restore InconsistentNaming
        }


    }

}
