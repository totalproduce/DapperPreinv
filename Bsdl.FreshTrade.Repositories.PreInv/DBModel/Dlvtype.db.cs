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
    /// Entity for the DLVTYPE table
    /// </summary>
    public partial class Dlvtype : BaseDbModel<Dlvtype, int>
    {
#region tableDefs

       public static List<EntityPropDef> GetPropDefs() {
         var result = new List<EntityPropDef>();

//EntityPropDef(string propName, string columnName, bool isKey, bool isNullable, string refEntityName, PropertyInfo keyPropInfo,
//            int size, int? prec, int? scale)



         result.Add(new EntityPropDef(
         PropertyHelper <Dlvtype>.GetProperty(x => x.Dltrecno),
         "DLTRECNO", // columnName
         true,                    //isKey
         false, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  5, // int? prec
                           0  // int? Scale
         ,
         typeof(Dlvtype)
       ));


         result.Add(new EntityPropDef(
         PropertyHelper <Dlvtype>.GetProperty(x => x.Capepricemethod),
         "CAPEPRICEMETHOD", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         1,       // int size   
                  null, // int? prec
                   
         null // int? Scale
         ,
         typeof(Dlvtype)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <Dlvtype>.GetProperty(x => x.Deliverycondition),
         "DELIVERYCONDITION", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         5,       // int size   
                  null, // int? prec
                   
         null // int? Scale
         ,
         typeof(Dlvtype)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <Dlvtype>.GetProperty(x => x.Deliveryconditiondesc),
         "DELIVERYCONDITIONDESC", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         30,       // int size   
                  null, // int? prec
                   
         null // int? Scale
         ,
         typeof(Dlvtype)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <Dlvtype>.GetProperty(x => x.Dutycharged),
         "DUTYCHARGED", // columnName
         false,                    //isKey
         false, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  1, // int? prec
                           0  // int? Scale
         ,
         typeof(Dlvtype)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <Dlvtype>.GetProperty(x => x.Goodsonconsignment),
         "GOODSONCONSIGNMENT", // columnName
         false,                    //isKey
         false, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  1, // int? prec
                           0  // int? Scale
         ,
         typeof(Dlvtype)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <Dlvtype>.GetProperty(x => x.Owncollection),
         "OWNCOLLECTION", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  5, // int? prec
                           0  // int? Scale
         ,
         typeof(Dlvtype)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <Dlvtype>.GetProperty(x => x.Showinwholesale),
         "SHOWINWHOLESALE", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  1, // int? prec
                           0  // int? Scale
         ,
         typeof(Dlvtype)
         ));
         return result; 
       }

#endregion     
        private int _fDltrecno;
        public int Dltrecno
        {
            get { return _fDltrecno; }
            set
            {
                var oldKey = Key;
                if (_fDltrecno != value)
                {
                    Modify();
                    _fDltrecno = value;
                    KeyChanged(oldKey);
                }
            }
        }

        private string _fCapepricemethod;
        public string Capepricemethod
        {
            get { return _fCapepricemethod; }
            set
            {
                if (_fCapepricemethod != value)
                {
                    Modify();
                    _fCapepricemethod = value;
                }
            }
        }

        private string _fDeliverycondition;
        public string Deliverycondition
        {
            get { return _fDeliverycondition; }
            set
            {
                if (_fDeliverycondition != value)
                {
                    Modify();
                    _fDeliverycondition = value;
                }
            }
        }

        private string _fDeliveryconditiondesc;
        public string Deliveryconditiondesc
        {
            get { return _fDeliveryconditiondesc; }
            set
            {
                if (_fDeliveryconditiondesc != value)
                {
                    Modify();
                    _fDeliveryconditiondesc = value;
                }
            }
        }

        private short _fDutycharged;
        public short Dutycharged
        {
            get { return _fDutycharged; }
            set
            {
                if (_fDutycharged != value)
                {
                    Modify();
                    _fDutycharged = value;
                }
            }
        }

        private short _fGoodsonconsignment;
        public short Goodsonconsignment
        {
            get { return _fGoodsonconsignment; }
            set
            {
                if (_fGoodsonconsignment != value)
                {
                    Modify();
                    _fGoodsonconsignment = value;
                }
            }
        }

        private int? _fOwncollection;
        public int? Owncollection
        {
            get { return _fOwncollection; }
            set
            {
                if (_fOwncollection != value)
                {
                    Modify();
                    _fOwncollection = value;
                }
            }
        }

        private short? _fShowinwholesale;
        public short? Showinwholesale
        {
            get { return _fShowinwholesale; }
            set
            {
                if (_fShowinwholesale != value)
                {
                    Modify();
                    _fShowinwholesale = value;
                }
            }
        }

        public override int Key
        {
            get { return Dltrecno; }
            set { Dltrecno = value; }
        }

        public override string KeyAsString { get { return Key.ToString(CultureInfo.InvariantCulture); } }


        public override Dlvtype Clone()
        {
            var obj = new Dlvtype
                {
                    Dltrecno = Dltrecno,
                    Capepricemethod = Capepricemethod,
                    Deliverycondition = Deliverycondition,
                    Deliveryconditiondesc = Deliveryconditiondesc,
                    Dutycharged = Dutycharged,
                    Goodsonconsignment = Goodsonconsignment,
                    Owncollection = Owncollection,
                    Showinwholesale = Showinwholesale,
                };

            return obj;
        }

        public static class FieldNames
        {
// ReSharper disable InconsistentNaming
            public const string  DLTRECNO = "DLTRECNO";
            public const string  CAPEPRICEMETHOD = "CAPEPRICEMETHOD";
            public const string  DELIVERYCONDITION = "DELIVERYCONDITION";
            public const string  DELIVERYCONDITIONDESC = "DELIVERYCONDITIONDESC";
            public const string  DUTYCHARGED = "DUTYCHARGED";
            public const string  GOODSONCONSIGNMENT = "GOODSONCONSIGNMENT";
            public const string  OWNCOLLECTION = "OWNCOLLECTION";
            public const string  SHOWINWHOLESALE = "SHOWINWHOLESALE";
 // ReSharper restore InconsistentNaming
        }


    }

}
