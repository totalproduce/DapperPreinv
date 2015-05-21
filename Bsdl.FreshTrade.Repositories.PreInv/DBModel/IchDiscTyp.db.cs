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
    /// Entity for the ICHDISCTYP table
    /// </summary>
    public partial class IchDiscTyp : BaseDbModel<IchDiscTyp, int>
    {
#region tableDefs

       public static List<EntityPropDef> GetPropDefs() {
         var result = new List<EntityPropDef>();

//EntityPropDef(string propName, string columnName, bool isKey, bool isNullable, string refEntityName, PropertyInfo keyPropInfo,
//            int size, int? prec, int? scale)



         result.Add(new EntityPropDef(
         PropertyHelper <IchDiscTyp>.GetProperty(x => x.Ichrecno),
         "ICHRECNO", // columnName
         true,                    //isKey
         false, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  10, // int? prec
                           0  // int? Scale
         ,
         typeof(IchDiscTyp)
       ));


         result.Add(new EntityPropDef(
         PropertyHelper <IchDiscTyp>.GetProperty(x => x.Discdedstr),
         "DISCDEDSTR", // columnName
         false,                    //isKey
         false, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         30,       // int size   
                  null, // int? prec
                   
         null // int? Scale
         ,
         typeof(IchDiscTyp)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <IchDiscTyp>.GetProperty(x => x.Discgrpglrecno),
         "DISCGRPGLRECNO", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  10, // int? prec
                           0  // int? Scale
         ,
         typeof(IchDiscTyp)
         ));
         return result; 
       }

#endregion     
        private int _fIchrecno;
        public int Ichrecno
        {
            get { return _fIchrecno; }
            set
            {
                var oldKey = Key;
                if (_fIchrecno != value)
                {
                    Modify();
                    _fIchrecno = value;
                    KeyChanged(oldKey);
                }
            }
        }

        private string _fDiscdedstr;
        public string Discdedstr
        {
            get { return _fDiscdedstr; }
            set
            {
                if (_fDiscdedstr != value)
                {
                    Modify();
                    _fDiscdedstr = value;
                }
            }
        }

        private int? _fDiscgrpglrecno;
        public int? Discgrpglrecno
        {
            get { return _fDiscgrpglrecno; }
            set
            {
                if (_fDiscgrpglrecno != value)
                {
                    Modify();
                    _fDiscgrpglrecno = value;
                }
            }
        }

        public override int Key
        {
            get { return Ichrecno; }
            set { Ichrecno = value; }
        }

        public override string KeyAsString { get { return Key.ToString(CultureInfo.InvariantCulture); } }


        public override IchDiscTyp Clone()
        {
            var obj = new IchDiscTyp
                {
                    Ichrecno = Ichrecno,
                    Discdedstr = Discdedstr,
                    Discgrpglrecno = Discgrpglrecno,
                };

            return obj;
        }

        public static class FieldNames
        {
// ReSharper disable InconsistentNaming
            public const string  ICHRECNO = "ICHRECNO";
            public const string  DISCDEDSTR = "DISCDEDSTR";
            public const string  DISCGRPGLRECNO = "DISCGRPGLRECNO";
 // ReSharper restore InconsistentNaming
        }


    }

}
