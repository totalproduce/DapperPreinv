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
    /// Table to group credit / debit note DELPRICEs into group for transaction generation
    /// </summary>
    public partial class DelPriceCreditRef : BaseDbModel<DelPriceCreditRef, int>
    {
#region tableDefs

       public static List<EntityPropDef> GetPropDefs() {
         var result = new List<EntityPropDef>();

//EntityPropDef(string propName, string columnName, bool isKey, bool isNullable, string refEntityName, PropertyInfo keyPropInfo,
//            int size, int? prec, int? scale)



         result.Add(new EntityPropDef(
         PropertyHelper <DelPriceCreditRef>.GetProperty(x => x.Dprcdtrefno),
         "DPRCDTREFNO", // columnName
         true,                    //isKey
         false, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  10, // int? prec
                           0  // int? Scale
         ,
         typeof(DelPriceCreditRef)
       ));


         result.Add(new EntityPropDef(
         PropertyHelper <DelPriceCreditRef>.GetProperty(x => x.Creditref),
         "CREDITREF", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         20,       // int size   
                  null, // int? prec
                   
         null // int? Scale
         ,
         typeof(DelPriceCreditRef)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <DelPriceCreditRef>.GetProperty(x => x.Dlvordno),
         "DLVORDNO", // columnName
         false,                    //isKey
         false, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  10, // int? prec
                           0  // int? Scale
         ,
         typeof(DelPriceCreditRef)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <DelPriceCreditRef>.GetProperty(x => x.Invstatus),
         "INVSTATUS", // columnName
         false,                    //isKey
         false, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  5, // int? prec
                           0  // int? Scale
         ,
         typeof(DelPriceCreditRef)
         ));
         return result; 
       }

#endregion     
        private int _fDprcdtrefno;
        /// <summary>
        /// Primary Key
        /// </summary>
        public int Dprcdtrefno
        {
            get { return _fDprcdtrefno; }
            set
            {
                var oldKey = Key;
                if (_fDprcdtrefno != value)
                {
                    Modify();
                    _fDprcdtrefno = value;
                    KeyChanged(oldKey);
                }
            }
        }

        private string _fCreditref;
        /// <summary>
        /// Reference for this group of credit / debit lines
        /// </summary>
        public string Creditref
        {
            get { return _fCreditref; }
            set
            {
                if (_fCreditref != value)
                {
                    Modify();
                    _fCreditref = value;
                }
            }
        }

        private int _fDlvordno;
        /// <summary>
        /// Foreign Key - DELHED.DLVORDNO
        /// </summary>
        public int Dlvordno
        {
            get { return _fDlvordno; }
            set
            {
                if (_fDlvordno != value)
                {
                    Modify();
                    _fDlvordno = value;
                }
            }
        }

        private int _fInvstatus;
        /// <summary>
        /// Status indicator. 1 = open, 10 = invoiced
        /// </summary>
        public int Invstatus
        {
            get { return _fInvstatus; }
            set
            {
                if (_fInvstatus != value)
                {
                    Modify();
                    _fInvstatus = value;
                }
            }
        }

        public override int Key
        {
            get { return Dprcdtrefno; }
            set { Dprcdtrefno = value; }
        }

        public override string KeyAsString { get { return Key.ToString(CultureInfo.InvariantCulture); } }


        public override DelPriceCreditRef Clone()
        {
            var obj = new DelPriceCreditRef
                {
                    Dprcdtrefno = Dprcdtrefno,
                    Creditref = Creditref,
                    Dlvordno = Dlvordno,
                    Invstatus = Invstatus,
                };

            return obj;
        }

        public static class FieldNames
        {
// ReSharper disable InconsistentNaming
            public const string  DPRCDTREFNO = "DPRCDTREFNO";
            public const string  CREDITREF = "CREDITREF";
            public const string  DLVORDNO = "DLVORDNO";
            public const string  INVSTATUS = "INVSTATUS";
 // ReSharper restore InconsistentNaming
        }


    }

}
