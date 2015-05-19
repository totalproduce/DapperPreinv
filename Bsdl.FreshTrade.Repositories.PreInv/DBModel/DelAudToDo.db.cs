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
    /// Entity for the DELAUDTODO table
    /// </summary>
    public partial class DelAudToDo : BaseDbModel<DelAudToDo, int>
    {
#region tableDefs

       public static List<EntityPropDef> GetPropDefs() {
         var result = new List<EntityPropDef>();

//EntityPropDef(string propName, string columnName, bool isKey, bool isNullable, string refEntityName, PropertyInfo keyPropInfo,
//            int size, int? prec, int? scale)



         result.Add(new EntityPropDef(
         PropertyHelper <DelAudToDo>.GetProperty(x => x.Dalrecno),
         "DALRECNO", // columnName
         true,                    //isKey
         false, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  10, // int? prec
                           0  // int? Scale
         ,
         typeof(DelAudToDo)
       ));


         result.Add(new EntityPropDef(
         PropertyHelper <DelAudToDo>.GetProperty(x => x.Dalupdind),
         "DALUPDIND", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  5, // int? prec
                           0  // int? Scale
         ,
         typeof(DelAudToDo)
         ));
         return result; 
       }

#endregion     
        private int _fDalrecno;
        public int Dalrecno
        {
            get { return _fDalrecno; }
            set
            {
                var oldKey = Key;
                if (_fDalrecno != value)
                {
                    Modify();
                    _fDalrecno = value;
                    KeyChanged(oldKey);
                }
            }
        }

        private int? _fDalupdind;
        public int? Dalupdind
        {
            get { return _fDalupdind; }
            set
            {
                if (_fDalupdind != value)
                {
                    Modify();
                    _fDalupdind = value;
                }
            }
        }

        public override int Key
        {
            get { return Dalrecno; }
            set { Dalrecno = value; }
        }

        public override string KeyAsString { get { return Key.ToString(CultureInfo.InvariantCulture); } }


        public override DelAudToDo Clone()
        {
            var obj = new DelAudToDo
                {
                    Dalrecno = Dalrecno,
                    Dalupdind = Dalupdind,
                };

            return obj;
        }

        public static class FieldNames
        {
// ReSharper disable InconsistentNaming
            public const string  DALRECNO = "DALRECNO";
            public const string  DALUPDIND = "DALUPDIND";
 // ReSharper restore InconsistentNaming
        }


    }

}
