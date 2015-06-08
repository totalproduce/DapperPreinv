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
    /// Entity for the CSTANDES table
    /// </summary>
    public partial class CustomerCategory : BaseDbModel<CustomerCategory, int>
    {
#region tableDefs

       public static List<EntityPropDef> GetPropDefs() {
         var result = new List<EntityPropDef>();

//EntityPropDef(string propName, string columnName, bool isKey, bool isNullable, string refEntityName, PropertyInfo keyPropInfo,
//            int size, int? prec, int? scale)



         result.Add(new EntityPropDef(
         PropertyHelper <CustomerCategory>.GetProperty(x => x.Csarecno),
         "CSARECNO", // columnName
         true,                    //isKey
         false, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  5, // int? prec
                           0  // int? Scale
         ,
         typeof(CustomerCategory)
       ));


         result.Add(new EntityPropDef(
         PropertyHelper <CustomerCategory>.GetProperty(x => x.Csacsgrecno),
         "CSACSGRECNO", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  5, // int? prec
                           0  // int? Scale
         ,
         typeof(CustomerCategory)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <CustomerCategory>.GetProperty(x => x.Csadesc),
         "CSADESC", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         30,       // int size   
                  null, // int? prec
                   
         null // int? Scale
         ,
         typeof(CustomerCategory)
         ));
         return result; 
       }

#endregion     
        private int _fCsarecno;
        public int Csarecno
        {
            get { return _fCsarecno; }
            set
            {
                var oldKey = Key;
                if (_fCsarecno != value)
                {
                    Modify();
                    _fCsarecno = value;
                    KeyChanged(oldKey);
                }
            }
        }

        private int? _fCsacsgrecno;
        public int? Csacsgrecno
        {
            get { return _fCsacsgrecno; }
            set
            {
                if (_fCsacsgrecno != value)
                {
                    Modify();
                    _fCsacsgrecno = value;
                }
            }
        }

        private string _fCsadesc;
        public string Csadesc
        {
            get { return _fCsadesc; }
            set
            {
                if (_fCsadesc != value)
                {
                    Modify();
                    _fCsadesc = value;
                }
            }
        }

        public override int Key
        {
            get { return Csarecno; }
            set { Csarecno = value; }
        }

        public override string KeyAsString { get { return Key.ToString(CultureInfo.InvariantCulture); } }


        public override CustomerCategory Clone()
        {
            var obj = new CustomerCategory
                {
                    Csarecno = Csarecno,
                    Csacsgrecno = Csacsgrecno,
                    Csadesc = Csadesc,
                };

            return obj;
        }

        public static class FieldNames
        {
// ReSharper disable InconsistentNaming
            public const string  CSARECNO = "CSARECNO";
            public const string  CSACSGRECNO = "CSACSGRECNO";
            public const string  CSADESC = "CSADESC";
 // ReSharper restore InconsistentNaming
        }


    }

}
