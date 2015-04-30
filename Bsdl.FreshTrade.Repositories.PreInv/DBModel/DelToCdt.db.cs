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
    /// Entity for the DELTOCDT table
    /// </summary>
    public partial class DelToCdt : BaseDbModel<DelToCdt, int>
    {
#region tableDefs

       public static List<EntityPropDef> GetPropDefs() {
         var result = new List<EntityPropDef>();

//EntityPropDef(string propName, string columnName, bool isKey, bool isNullable, string refEntityName, PropertyInfo keyPropInfo,
//            int size, int? prec, int? scale)



         result.Add(new EntityPropDef(
         PropertyHelper <DelToCdt>.GetProperty(x => x.Cdtdprrecno),
         "CDTDPRRECNO", // columnName
         true,                    //isKey
         false, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  10, // int? prec
                           0  // int? Scale
         ,
         typeof(DelToCdt)
       ));


         result.Add(new EntityPropDef(
         PropertyHelper <DelToCdt>.GetProperty(x => x.Orgdprrecno),
         "ORGDPRRECNO", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  10, // int? prec
                           0  // int? Scale
         ,
         typeof(DelToCdt)
         ));
         return result; 
       }

#endregion     
        private int _fCdtdprrecno;
        public int Cdtdprrecno
        {
            get { return _fCdtdprrecno; }
            set
            {
                var oldKey = Key;
                if (_fCdtdprrecno != value)
                {
                    Modify();
                    _fCdtdprrecno = value;
                    KeyChanged(oldKey);
                }
            }
        }

        private int? _fOrgdprrecno;
        public int? Orgdprrecno
        {
            get { return _fOrgdprrecno; }
            set
            {
                if (_fOrgdprrecno != value)
                {
                    Modify();
                    _fOrgdprrecno = value;
                }
            }
        }

        public override int Key
        {
            get { return Cdtdprrecno; }
            set { Cdtdprrecno = value; }
        }

        public override string KeyAsString { get { return Key.ToString(CultureInfo.InvariantCulture); } }


        public override DelToCdt Clone()
        {
            var obj = new DelToCdt
                {
                    Cdtdprrecno = Cdtdprrecno,
                    Orgdprrecno = Orgdprrecno,
                };

            return obj;
        }

        public static class FieldNames
        {
// ReSharper disable InconsistentNaming
            public const string  CDTDPRRECNO = "CDTDPRRECNO";
            public const string  ORGDPRRECNO = "ORGDPRRECNO";
 // ReSharper restore InconsistentNaming
        }


    }

}
