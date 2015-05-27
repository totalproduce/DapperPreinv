// <summary>
// This file is generated automatically. Any changes will be lost.
// </summary>

using System;
using System.Collections.Generic;
using System.Globalization;
using Bsdl.FreshTrade.Repositories.Basic.DBModel;
using Bsdl.FreshTrade.Repositories.Basic.Persistance;

namespace Bsdl.FreshTrade.Repositories.Account.DBModel
{
    /// <summary>
    /// Entity for the CSTANGRP table
    /// </summary>
    public partial class CustomerGroup : BaseDbModel<CustomerGroup, int>
    {
#region tableDefs

       public static List<EntityPropDef> GetPropDefs() {
         var result = new List<EntityPropDef>();

//EntityPropDef(string propName, string columnName, bool isKey, bool isNullable, string refEntityName, PropertyInfo keyPropInfo,
//            int size, int? prec, int? scale)



         result.Add(new EntityPropDef(
         PropertyHelper <CustomerGroup>.GetProperty(x => x.Csgrecno),
         "CSGRECNO", // columnName
         true,                    //isKey
         false, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  5, // int? prec
                           0  // int? Scale
         ,
         typeof(CustomerGroup)
       ));


         result.Add(new EntityPropDef(
         PropertyHelper <CustomerGroup>.GetProperty(x => x.Csgcontainergroup),
         "CSGCONTAINERGROUP", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  1, // int? prec
                           0  // int? Scale
         ,
         typeof(CustomerGroup)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <CustomerGroup>.GetProperty(x => x.Csgdesc),
         "CSGDESC", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         30,       // int size   
                  null, // int? prec
                   
         null // int? Scale
         ,
         typeof(CustomerGroup)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <CustomerGroup>.GetProperty(x => x.Csgnoofcst),
         "CSGNOOFCST", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  10, // int? prec
                           0  // int? Scale
         ,
         typeof(CustomerGroup)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <CustomerGroup>.GetProperty(x => x.Csgtype),
         "CSGTYPE", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  5, // int? prec
                           0  // int? Scale
         ,
         typeof(CustomerGroup)
         ));
         return result; 
       }

#endregion     
        private int _fCsgrecno;
        public int Csgrecno
        {
            get { return _fCsgrecno; }
            set
            {
                var oldKey = Key;
                if (_fCsgrecno != value)
                {
                    Modify();
                    _fCsgrecno = value;
                    KeyChanged(oldKey);
                }
            }
        }

        private short? _fCsgcontainergroup;
        public short? Csgcontainergroup
        {
            get { return _fCsgcontainergroup; }
            set
            {
                if (_fCsgcontainergroup != value)
                {
                    Modify();
                    _fCsgcontainergroup = value;
                }
            }
        }

        private string _fCsgdesc;
        public string Csgdesc
        {
            get { return _fCsgdesc; }
            set
            {
                if (_fCsgdesc != value)
                {
                    Modify();
                    _fCsgdesc = value;
                }
            }
        }

        private int? _fCsgnoofcst;
        public int? Csgnoofcst
        {
            get { return _fCsgnoofcst; }
            set
            {
                if (_fCsgnoofcst != value)
                {
                    Modify();
                    _fCsgnoofcst = value;
                }
            }
        }

        private int? _fCsgtype;
        public int? Csgtype
        {
            get { return _fCsgtype; }
            set
            {
                if (_fCsgtype != value)
                {
                    Modify();
                    _fCsgtype = value;
                }
            }
        }

        public override int Key
        {
            get { return Csgrecno; }
            set { Csgrecno = value; }
        }

        public override string KeyAsString { get { return Key.ToString(CultureInfo.InvariantCulture); } }


        public override CustomerGroup Clone()
        {
            var obj = new CustomerGroup
                {
                    Csgrecno = Csgrecno,
                    Csgcontainergroup = Csgcontainergroup,
                    Csgdesc = Csgdesc,
                    Csgnoofcst = Csgnoofcst,
                    Csgtype = Csgtype,
                };

            return obj;
        }

        public static class FieldNames
        {
// ReSharper disable InconsistentNaming
            public const string  CSGRECNO = "CSGRECNO";
            public const string  CSGCONTAINERGROUP = "CSGCONTAINERGROUP";
            public const string  CSGDESC = "CSGDESC";
            public const string  CSGNOOFCST = "CSGNOOFCST";
            public const string  CSGTYPE = "CSGTYPE";
 // ReSharper restore InconsistentNaming
        }


    }

}
