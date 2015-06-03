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
    /// Entity for the PREINVERRORS table
    /// </summary>
    public partial class PreInvError : BaseDbModel<PreInvError, int>
    {
#region tableDefs

       public static List<EntityPropDef> GetPropDefs() {
         var result = new List<EntityPropDef>();

//EntityPropDef(string propName, string columnName, bool isKey, bool isNullable, string refEntityName, PropertyInfo keyPropInfo,
//            int size, int? prec, int? scale)



         result.Add(new EntityPropDef(
         PropertyHelper <PreInvError>.GetProperty(x => x.Errno),
         "ERRNO", // columnName
         true,                    //isKey
         false, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  5, // int? prec
                           0  // int? Scale
         ,
         typeof(PreInvError)
       ));


         result.Add(new EntityPropDef(
         PropertyHelper <PreInvError>.GetProperty(x => x.Erriscritical),
         "ERRISCRITICAL", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  1, // int? prec
                           0  // int? Scale
         ,
         typeof(PreInvError)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <PreInvError>.GetProperty(x => x.Errreason),
         "ERRREASON", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         64,       // int size   
                  null, // int? prec
                   
         null // int? Scale
         ,
         typeof(PreInvError)
         ));
         return result; 
       }

#endregion     
        private int _fErrno;
        public int Errno
        {
            get { return _fErrno; }
            set
            {
                var oldKey = Key;
                if (_fErrno != value)
                {
                    Modify();
                    _fErrno = value;
                    KeyChanged(oldKey);
                }
            }
        }

        private short? _fErriscritical;
        public short? Erriscritical
        {
            get { return _fErriscritical; }
            set
            {
                if (_fErriscritical != value)
                {
                    Modify();
                    _fErriscritical = value;
                }
            }
        }

        private string _fErrreason;
        public string Errreason
        {
            get { return _fErrreason; }
            set
            {
                if (_fErrreason != value)
                {
                    Modify();
                    _fErrreason = value;
                }
            }
        }

        public override int Key
        {
            get { return Errno; }
            set { Errno = value; }
        }

        public override string KeyAsString { get { return Key.ToString(CultureInfo.InvariantCulture); } }


        public override PreInvError Clone()
        {
            var obj = new PreInvError
                {
                    Errno = Errno,
                    Erriscritical = Erriscritical,
                    Errreason = Errreason,
                };

            return obj;
        }

        public static class FieldNames
        {
// ReSharper disable InconsistentNaming
            public const string  ERRNO = "ERRNO";
            public const string  ERRISCRITICAL = "ERRISCRITICAL";
            public const string  ERRREASON = "ERRREASON";
 // ReSharper restore InconsistentNaming
        }


    }

}
