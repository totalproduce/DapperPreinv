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
    /// Entity for the ACCALLVAL table
    /// </summary>
    public partial class AccAllVal : BaseDbModel<AccAllVal, int>
    {
#region tableDefs

       public static List<EntityPropDef> GetPropDefs() {
         var result = new List<EntityPropDef>();

//EntityPropDef(string propName, string columnName, bool isKey, bool isNullable, string refEntityName, PropertyInfo keyPropInfo,
//            int size, int? prec, int? scale)



         result.Add(new EntityPropDef(
         PropertyHelper <AccAllVal>.GetProperty(x => x.Aavrecno),
         "AAVRECNO", // columnName
         true,                    //isKey
         false, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  10, // int? prec
                           0  // int? Scale
         ,
         typeof(AccAllVal)
       ));


         result.Add(new EntityPropDef(
         PropertyHelper <AccAllVal>.GetProperty(x => x.Aavamount),
         "AAVAMOUNT", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  126, // int? prec
                   
         null // int? Scale
         ,
         typeof(AccAllVal)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <AccAllVal>.GetProperty(x => x.Aavbaseamount),
         "AAVBASEAMOUNT", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  126, // int? prec
                   
         null // int? Scale
         ,
         typeof(AccAllVal)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <AccAllVal>.GetProperty(x => x.Aavcurrecno),
         "AAVCURRECNO", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  5, // int? prec
                           0  // int? Scale
         ,
         typeof(AccAllVal)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <AccAllVal>.GetProperty(x => x.Aaveuroamount),
         "AAVEUROAMOUNT", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  126, // int? prec
                   
         null // int? Scale
         ,
         typeof(AccAllVal)
         ));
         return result; 
       }

#endregion     
        private int _fAavrecno;
        public int Aavrecno
        {
            get { return _fAavrecno; }
            set
            {
                var oldKey = Key;
                if (_fAavrecno != value)
                {
                    Modify();
                    _fAavrecno = value;
                    KeyChanged(oldKey);
                }
            }
        }

        private decimal? _fAavamount;
        public decimal? Aavamount
        {
            get { return _fAavamount; }
            set
            {
                if (_fAavamount != value)
                {
                    Modify();
                    _fAavamount = value;
                }
            }
        }

        private decimal? _fAavbaseamount;
        public decimal? Aavbaseamount
        {
            get { return _fAavbaseamount; }
            set
            {
                if (_fAavbaseamount != value)
                {
                    Modify();
                    _fAavbaseamount = value;
                }
            }
        }

        private int? _fAavcurrecno;
        public int? Aavcurrecno
        {
            get { return _fAavcurrecno; }
            set
            {
                if (_fAavcurrecno != value)
                {
                    Modify();
                    _fAavcurrecno = value;
                }
            }
        }

        private decimal? _fAaveuroamount;
        public decimal? Aaveuroamount
        {
            get { return _fAaveuroamount; }
            set
            {
                if (_fAaveuroamount != value)
                {
                    Modify();
                    _fAaveuroamount = value;
                }
            }
        }

        public override int Key
        {
            get { return Aavrecno; }
            set { Aavrecno = value; }
        }

        public override string KeyAsString { get { return Key.ToString(CultureInfo.InvariantCulture); } }


        public override AccAllVal Clone()
        {
            var obj = new AccAllVal
                {
                    Aavrecno = Aavrecno,
                    Aavamount = Aavamount,
                    Aavbaseamount = Aavbaseamount,
                    Aavcurrecno = Aavcurrecno,
                    Aaveuroamount = Aaveuroamount,
                };

            return obj;
        }

        public static class FieldNames
        {
// ReSharper disable InconsistentNaming
            public const string  AAVRECNO = "AAVRECNO";
            public const string  AAVAMOUNT = "AAVAMOUNT";
            public const string  AAVBASEAMOUNT = "AAVBASEAMOUNT";
            public const string  AAVCURRECNO = "AAVCURRECNO";
            public const string  AAVEUROAMOUNT = "AAVEUROAMOUNT";
 // ReSharper restore InconsistentNaming
        }


    }

}
