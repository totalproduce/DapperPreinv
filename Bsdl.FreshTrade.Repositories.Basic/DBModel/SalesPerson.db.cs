// <summary>
// This file is generated automatically. Any changes will be lost.
// </summary>

using System;
using System.Collections.Generic;
using System.Globalization;
using Bsdl.FreshTrade.Repositories.Basic.DBModel;
using Bsdl.FreshTrade.Repositories.Basic.Persistance;

namespace Bsdl.FreshTrade.Repositories.Basic.DBModel
{
    /// <summary>
    /// Entity for the SMN table
    /// </summary>
    public partial class SalesPerson : BaseDbModel<SalesPerson, int>
    {
#region tableDefs

       public static List<EntityPropDef> GetPropDefs() {
         var result = new List<EntityPropDef>();

//EntityPropDef(string propName, string columnName, bool isKey, bool isNullable, string refEntityName, PropertyInfo keyPropInfo,
//            int size, int? prec, int? scale)



         result.Add(new EntityPropDef(
         PropertyHelper <SalesPerson>.GetProperty(x => x.Smnno),
         "SMNNO", // columnName
         true,                    //isKey
         false, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  5, // int? prec
                           0  // int? Scale
         ,
         typeof(SalesPerson)
       ));


         result.Add(new EntityPropDef(
         PropertyHelper <SalesPerson>.GetProperty(x => x.Enttype1),
         "ENTTYPE1", // columnName
         false,                    //isKey
         false, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  1, // int? prec
                           0  // int? Scale
         ,
         typeof(SalesPerson)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <SalesPerson>.GetProperty(x => x.Enttype2),
         "ENTTYPE2", // columnName
         false,                    //isKey
         false, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  1, // int? prec
                           0  // int? Scale
         ,
         typeof(SalesPerson)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <SalesPerson>.GetProperty(x => x.Enttype3),
         "ENTTYPE3", // columnName
         false,                    //isKey
         false, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  1, // int? prec
                           0  // int? Scale
         ,
         typeof(SalesPerson)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <SalesPerson>.GetProperty(x => x.Smnactive),
         "SMNACTIVE", // columnName
         false,                    //isKey
         false, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  1, // int? prec
                           0  // int? Scale
         ,
         typeof(SalesPerson)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <SalesPerson>.GetProperty(x => x.Smnextno),
         "SMNEXTNO", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  5, // int? prec
                           0  // int? Scale
         ,
         typeof(SalesPerson)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <SalesPerson>.GetProperty(x => x.Smngrpname),
         "SMNGRPNAME", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         15,       // int size   
                  null, // int? prec
                   
         null // int? Scale
         ,
         typeof(SalesPerson)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <SalesPerson>.GetProperty(x => x.Smnid),
         "SMNID", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  5, // int? prec
                           0  // int? Scale
         ,
         typeof(SalesPerson)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <SalesPerson>.GetProperty(x => x.Smnname),
         "SMNNAME", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         30,       // int size   
                  null, // int? prec
                   
         null // int? Scale
         ,
         typeof(SalesPerson)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <SalesPerson>.GetProperty(x => x.Smntouched),
         "SMNTOUCHED", // columnName
         false,                    //isKey
         false, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  1, // int? prec
                           0  // int? Scale
         ,
         typeof(SalesPerson)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <SalesPerson>.GetProperty(x => x.Smntype),
         "SMNTYPE", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         4,       // int size   
                  null, // int? prec
                   
         null // int? Scale
         ,
         typeof(SalesPerson)
         ));
         return result; 
       }

#endregion     
        private int _fSmnno;
        public int Smnno
        {
            get { return _fSmnno; }
            set
            {
                var oldKey = Key;
                if (_fSmnno != value)
                {
                    Modify();
                    _fSmnno = value;
                    KeyChanged(oldKey);
                }
            }
        }

        private short _fEnttype1;
        public short Enttype1
        {
            get { return _fEnttype1; }
            set
            {
                if (_fEnttype1 != value)
                {
                    Modify();
                    _fEnttype1 = value;
                }
            }
        }

        private short _fEnttype2;
        public short Enttype2
        {
            get { return _fEnttype2; }
            set
            {
                if (_fEnttype2 != value)
                {
                    Modify();
                    _fEnttype2 = value;
                }
            }
        }

        private short _fEnttype3;
        public short Enttype3
        {
            get { return _fEnttype3; }
            set
            {
                if (_fEnttype3 != value)
                {
                    Modify();
                    _fEnttype3 = value;
                }
            }
        }

        private short _fSmnactive;
        public short Smnactive
        {
            get { return _fSmnactive; }
            set
            {
                if (_fSmnactive != value)
                {
                    Modify();
                    _fSmnactive = value;
                }
            }
        }

        private int? _fSmnextno;
        public int? Smnextno
        {
            get { return _fSmnextno; }
            set
            {
                if (_fSmnextno != value)
                {
                    Modify();
                    _fSmnextno = value;
                }
            }
        }

        private string _fSmngrpname;
        public string Smngrpname
        {
            get { return _fSmngrpname; }
            set
            {
                if (_fSmngrpname != value)
                {
                    Modify();
                    _fSmngrpname = value;
                }
            }
        }

        private int? _fSmnid;
        public int? Smnid
        {
            get { return _fSmnid; }
            set
            {
                if (_fSmnid != value)
                {
                    Modify();
                    _fSmnid = value;
                }
            }
        }

        private string _fSmnname;
        public string Smnname
        {
            get { return _fSmnname; }
            set
            {
                if (_fSmnname != value)
                {
                    Modify();
                    _fSmnname = value;
                }
            }
        }

        private short _fSmntouched;
        public short Smntouched
        {
            get { return _fSmntouched; }
            set
            {
                if (_fSmntouched != value)
                {
                    Modify();
                    _fSmntouched = value;
                }
            }
        }

        private string _fSmntype;
        public string Smntype
        {
            get { return _fSmntype; }
            set
            {
                if (_fSmntype != value)
                {
                    Modify();
                    _fSmntype = value;
                }
            }
        }

        public override int Key
        {
            get { return Smnno; }
            set { Smnno = value; }
        }

        public override string KeyAsString { get { return Key.ToString(CultureInfo.InvariantCulture); } }


        public override SalesPerson Clone()
        {
            var obj = new SalesPerson
                {
                    Smnno = Smnno,
                    Enttype1 = Enttype1,
                    Enttype2 = Enttype2,
                    Enttype3 = Enttype3,
                    Smnactive = Smnactive,
                    Smnextno = Smnextno,
                    Smngrpname = Smngrpname,
                    Smnid = Smnid,
                    Smnname = Smnname,
                    Smntouched = Smntouched,
                    Smntype = Smntype,
                };

            return obj;
        }

        public static class FieldNames
        {
// ReSharper disable InconsistentNaming
            public const string  SMNNO = "SMNNO";
            public const string  ENTTYPE1 = "ENTTYPE1";
            public const string  ENTTYPE2 = "ENTTYPE2";
            public const string  ENTTYPE3 = "ENTTYPE3";
            public const string  SMNACTIVE = "SMNACTIVE";
            public const string  SMNEXTNO = "SMNEXTNO";
            public const string  SMNGRPNAME = "SMNGRPNAME";
            public const string  SMNID = "SMNID";
            public const string  SMNNAME = "SMNNAME";
            public const string  SMNTOUCHED = "SMNTOUCHED";
            public const string  SMNTYPE = "SMNTYPE";
 // ReSharper restore InconsistentNaming
        }


    }

}
