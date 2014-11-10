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
    /// Entity for the DISGRPS table
    /// </summary>
    public partial class DisGrps : BaseDbModel<DisGrps, int>
    {
#region tableDefs

       public static List<EntityPropDef> GetPropDefs() {
         var result = new List<EntityPropDef>();

//EntityPropDef(string propName, string columnName, bool isKey, bool isNullable, string refEntityName, PropertyInfo keyPropInfo,
//            int size, int? prec, int? scale)



         result.Add(new EntityPropDef(
         PropertyHelper <DisGrps>.GetProperty(x => x.Disgrprecno),
         "DISGRPRECNO", // columnName
         true,                    //isKey
         false, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  5, // int? prec
                           0  // int? Scale
         ,
         typeof(DisGrps)
       ));


         result.Add(new EntityPropDef(
         PropertyHelper <DisGrps>.GetProperty(x => x.Applyrebstofoc),
         "APPLYREBSTOFOC", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  1, // int? prec
                           0  // int? Scale
         ,
         typeof(DisGrps)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <DisGrps>.GetProperty(x => x.Discommdesc),
         "DISCOMMDESC", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         30,       // int size   
                  null, // int? prec
                   
         null // int? Scale
         ,
         typeof(DisGrps)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <DisGrps>.GetProperty(x => x.Discstsup),
         "DISCSTSUP", // columnName
         false,                    //isKey
         false, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  5, // int? prec
                           0  // int? Scale
         ,
         typeof(DisGrps)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <DisGrps>.GetProperty(x => x.Disdesc),
         "DISDESC", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         30,       // int size   
                  null, // int? prec
                   
         null // int? Scale
         ,
         typeof(DisGrps)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <DisGrps>.GetProperty(x => x.Dishancommvatcode),
         "DISHANCOMMVATCODE", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  5, // int? prec
                           0  // int? Scale
         ,
         typeof(DisGrps)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <DisGrps>.GetProperty(x => x.Dishanddesc),
         "DISHANDDESC", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         30,       // int size   
                  null, // int? prec
                   
         null // int? Scale
         ,
         typeof(DisGrps)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <DisGrps>.GetProperty(x => x.Isactive),
         "ISACTIVE", // columnName
         false,                    //isKey
         false, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  1, // int? prec
                           0  // int? Scale
         ,
         typeof(DisGrps)
         ));
         return result; 
       }

#endregion     
        private int _fDisgrprecno;
        public int Disgrprecno
        {
            get { return _fDisgrprecno; }
            set
            {
                var oldKey = Key;
                if (_fDisgrprecno != value)
                {
                    Modify();
                    _fDisgrprecno = value;
                    KeyChanged(oldKey);
                }
            }
        }

        private short? _fApplyrebstofoc;
        public short? Applyrebstofoc
        {
            get { return _fApplyrebstofoc; }
            set
            {
                if (_fApplyrebstofoc != value)
                {
                    Modify();
                    _fApplyrebstofoc = value;
                }
            }
        }

        private string _fDiscommdesc;
        public string Discommdesc
        {
            get { return _fDiscommdesc; }
            set
            {
                if (_fDiscommdesc != value)
                {
                    Modify();
                    _fDiscommdesc = value;
                }
            }
        }

        private int _fDiscstsup;
        public int Discstsup
        {
            get { return _fDiscstsup; }
            set
            {
                if (_fDiscstsup != value)
                {
                    Modify();
                    _fDiscstsup = value;
                }
            }
        }

        private string _fDisdesc;
        public string Disdesc
        {
            get { return _fDisdesc; }
            set
            {
                if (_fDisdesc != value)
                {
                    Modify();
                    _fDisdesc = value;
                }
            }
        }

        private int? _fDishancommvatcode;
        public int? Dishancommvatcode
        {
            get { return _fDishancommvatcode; }
            set
            {
                if (_fDishancommvatcode != value)
                {
                    Modify();
                    _fDishancommvatcode = value;
                }
            }
        }

        private string _fDishanddesc;
        public string Dishanddesc
        {
            get { return _fDishanddesc; }
            set
            {
                if (_fDishanddesc != value)
                {
                    Modify();
                    _fDishanddesc = value;
                }
            }
        }

        private short _fIsactive;
        public short Isactive
        {
            get { return _fIsactive; }
            set
            {
                if (_fIsactive != value)
                {
                    Modify();
                    _fIsactive = value;
                }
            }
        }

        public override int Key
        {
            get { return Disgrprecno; }
            set { Disgrprecno = value; }
        }

        public override string KeyAsString { get { return Key.ToString(CultureInfo.InvariantCulture); } }


        public override DisGrps Clone()
        {
            var obj = new DisGrps
                {
                    Disgrprecno = Disgrprecno,
                    Applyrebstofoc = Applyrebstofoc,
                    Discommdesc = Discommdesc,
                    Discstsup = Discstsup,
                    Disdesc = Disdesc,
                    Dishancommvatcode = Dishancommvatcode,
                    Dishanddesc = Dishanddesc,
                    Isactive = Isactive,
                };

            return obj;
        }

        public static class FieldNames
        {
// ReSharper disable InconsistentNaming
            public const string  DISGRPRECNO = "DISGRPRECNO";
            public const string  APPLYREBSTOFOC = "APPLYREBSTOFOC";
            public const string  DISCOMMDESC = "DISCOMMDESC";
            public const string  DISCSTSUP = "DISCSTSUP";
            public const string  DISDESC = "DISDESC";
            public const string  DISHANCOMMVATCODE = "DISHANCOMMVATCODE";
            public const string  DISHANDDESC = "DISHANDDESC";
            public const string  ISACTIVE = "ISACTIVE";
 // ReSharper restore InconsistentNaming
        }


    }

}
