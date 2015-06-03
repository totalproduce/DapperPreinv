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
    /// Entity for the DISCPRDS table
    /// </summary>
    public partial class DiscPrds : BaseDbModel<DiscPrds, int>
    {
#region tableDefs

       public static List<EntityPropDef> GetPropDefs() {
         var result = new List<EntityPropDef>();

//EntityPropDef(string propName, string columnName, bool isKey, bool isNullable, string refEntityName, PropertyInfo keyPropInfo,
//            int size, int? prec, int? scale)



         result.Add(new EntityPropDef(
         PropertyHelper <DiscPrds>.GetProperty(x => x.Drarecno),
         "DRARECNO", // columnName
         true,                    //isKey
         false, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  10, // int? prec
                           0  // int? Scale
         ,
         typeof(DiscPrds)
       ));


         result.Add(new EntityPropDef(
         PropertyHelper <DiscPrds>.GetProperty(x => x.Draancno),
         "DRAANCNO", // columnName
         false,                    //isKey
         false, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  5, // int? prec
                           0  // int? Scale
         ,
         typeof(DiscPrds)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <DiscPrds>.GetProperty(x => x.Drachgno),
         "DRACHGNO", // columnName
         false,                    //isKey
         false, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  5, // int? prec
                           0  // int? Scale
         ,
         typeof(DiscPrds)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <DiscPrds>.GetProperty(x => x.Dradisgrprecno),
         "DRADISGRPRECNO", // columnName
         false,                    //isKey
         false, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  5, // int? prec
                           0  // int? Scale
         ,
         typeof(DiscPrds)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <DiscPrds>.GetProperty(x => x.Draexpno),
         "DRAEXPNO", // columnName
         false,                    //isKey
         false, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  10, // int? prec
                           0  // int? Scale
         ,
         typeof(DiscPrds)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <DiscPrds>.GetProperty(x => x.Draprcref1),
         "DRAPRCREF1", // columnName
         false,                    //isKey
         false, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  5, // int? prec
                           0  // int? Scale
         ,
         typeof(DiscPrds)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <DiscPrds>.GetProperty(x => x.Draprcref2),
         "DRAPRCREF2", // columnName
         false,                    //isKey
         false, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  5, // int? prec
                           0  // int? Scale
         ,
         typeof(DiscPrds)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <DiscPrds>.GetProperty(x => x.Draprcref3),
         "DRAPRCREF3", // columnName
         false,                    //isKey
         false, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  5, // int? prec
                           0  // int? Scale
         ,
         typeof(DiscPrds)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <DiscPrds>.GetProperty(x => x.Draprcref4),
         "DRAPRCREF4", // columnName
         false,                    //isKey
         false, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  5, // int? prec
                           0  // int? Scale
         ,
         typeof(DiscPrds)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <DiscPrds>.GetProperty(x => x.Draprcref5),
         "DRAPRCREF5", // columnName
         false,                    //isKey
         false, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  5, // int? prec
                           0  // int? Scale
         ,
         typeof(DiscPrds)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <DiscPrds>.GetProperty(x => x.Draprcref6),
         "DRAPRCREF6", // columnName
         false,                    //isKey
         false, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  5, // int? prec
                           0  // int? Scale
         ,
         typeof(DiscPrds)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <DiscPrds>.GetProperty(x => x.Drasaloffno),
         "DRASALOFFNO", // columnName
         false,                    //isKey
         false, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  5, // int? prec
                           0  // int? Scale
         ,
         typeof(DiscPrds)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <DiscPrds>.GetProperty(x => x.Drastcloc),
         "DRASTCLOC", // columnName
         false,                    //isKey
         false, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  5, // int? prec
                           0  // int? Scale
         ,
         typeof(DiscPrds)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <DiscPrds>.GetProperty(x => x.Dratypof),
         "DRATYPOF", // columnName
         false,                    //isKey
         false, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  5, // int? prec
                           0  // int? Scale
         ,
         typeof(DiscPrds)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <DiscPrds>.GetProperty(x => x.Finishdate),
         "FINISHDATE", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  null, // int? prec
                   
         null // int? Scale
         ,
         typeof(DiscPrds)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <DiscPrds>.GetProperty(x => x.Schemecanc),
         "SCHEMECANC", // columnName
         false,                    //isKey
         false, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  1, // int? prec
                           0  // int? Scale
         ,
         typeof(DiscPrds)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <DiscPrds>.GetProperty(x => x.Startdate),
         "STARTDATE", // columnName
         false,                    //isKey
         false, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  null, // int? prec
                   
         null // int? Scale
         ,
         typeof(DiscPrds)
         ));
         return result; 
       }

#endregion     
        private int _fDrarecno;
        public int Drarecno
        {
            get { return _fDrarecno; }
            set
            {
                var oldKey = Key;
                if (_fDrarecno != value)
                {
                    Modify();
                    _fDrarecno = value;
                    KeyChanged(oldKey);
                }
            }
        }

        private int _fDraancno;
        public int Draancno
        {
            get { return _fDraancno; }
            set
            {
                if (_fDraancno != value)
                {
                    Modify();
                    _fDraancno = value;
                }
            }
        }

        private int _fDrachgno;
        public int Drachgno
        {
            get { return _fDrachgno; }
            set
            {
                if (_fDrachgno != value)
                {
                    Modify();
                    _fDrachgno = value;
                }
            }
        }

        private int _fDradisgrprecno;
        public int Dradisgrprecno
        {
            get { return _fDradisgrprecno; }
            set
            {
                if (_fDradisgrprecno != value)
                {
                    Modify();
                    _fDradisgrprecno = value;
                }
            }
        }

        private int _fDraexpno;
        public int Draexpno
        {
            get { return _fDraexpno; }
            set
            {
                if (_fDraexpno != value)
                {
                    Modify();
                    _fDraexpno = value;
                }
            }
        }

        private int _fDraprcref1;
        public int Draprcref1
        {
            get { return _fDraprcref1; }
            set
            {
                if (_fDraprcref1 != value)
                {
                    Modify();
                    _fDraprcref1 = value;
                }
            }
        }

        private int _fDraprcref2;
        public int Draprcref2
        {
            get { return _fDraprcref2; }
            set
            {
                if (_fDraprcref2 != value)
                {
                    Modify();
                    _fDraprcref2 = value;
                }
            }
        }

        private int _fDraprcref3;
        public int Draprcref3
        {
            get { return _fDraprcref3; }
            set
            {
                if (_fDraprcref3 != value)
                {
                    Modify();
                    _fDraprcref3 = value;
                }
            }
        }

        private int _fDraprcref4;
        public int Draprcref4
        {
            get { return _fDraprcref4; }
            set
            {
                if (_fDraprcref4 != value)
                {
                    Modify();
                    _fDraprcref4 = value;
                }
            }
        }

        private int _fDraprcref5;
        public int Draprcref5
        {
            get { return _fDraprcref5; }
            set
            {
                if (_fDraprcref5 != value)
                {
                    Modify();
                    _fDraprcref5 = value;
                }
            }
        }

        private int _fDraprcref6;
        public int Draprcref6
        {
            get { return _fDraprcref6; }
            set
            {
                if (_fDraprcref6 != value)
                {
                    Modify();
                    _fDraprcref6 = value;
                }
            }
        }

        private int _fDrasaloffno;
        public int Drasaloffno
        {
            get { return _fDrasaloffno; }
            set
            {
                if (_fDrasaloffno != value)
                {
                    Modify();
                    _fDrasaloffno = value;
                }
            }
        }

        private int _fDrastcloc;
        public int Drastcloc
        {
            get { return _fDrastcloc; }
            set
            {
                if (_fDrastcloc != value)
                {
                    Modify();
                    _fDrastcloc = value;
                }
            }
        }

        private int _fDratypof;
        public int Dratypof
        {
            get { return _fDratypof; }
            set
            {
                if (_fDratypof != value)
                {
                    Modify();
                    _fDratypof = value;
                }
            }
        }

        private DateTime? _fFinishdate;
        public DateTime? Finishdate
        {
            get { return _fFinishdate; }
            set
            {
                if (_fFinishdate != value)
                {
                    Modify();
                    _fFinishdate = value;
                }
            }
        }

        private short _fSchemecanc;
        public short Schemecanc
        {
            get { return _fSchemecanc; }
            set
            {
                if (_fSchemecanc != value)
                {
                    Modify();
                    _fSchemecanc = value;
                }
            }
        }

        private DateTime _fStartdate;
        public DateTime Startdate
        {
            get { return _fStartdate; }
            set
            {
                if (_fStartdate != value)
                {
                    Modify();
                    _fStartdate = value;
                }
            }
        }

        public override int Key
        {
            get { return Drarecno; }
            set { Drarecno = value; }
        }

        public override string KeyAsString { get { return Key.ToString(CultureInfo.InvariantCulture); } }


        public override DiscPrds Clone()
        {
            var obj = new DiscPrds
                {
                    Drarecno = Drarecno,
                    Draancno = Draancno,
                    Drachgno = Drachgno,
                    Dradisgrprecno = Dradisgrprecno,
                    Draexpno = Draexpno,
                    Draprcref1 = Draprcref1,
                    Draprcref2 = Draprcref2,
                    Draprcref3 = Draprcref3,
                    Draprcref4 = Draprcref4,
                    Draprcref5 = Draprcref5,
                    Draprcref6 = Draprcref6,
                    Drasaloffno = Drasaloffno,
                    Drastcloc = Drastcloc,
                    Dratypof = Dratypof,
                    Finishdate = Finishdate,
                    Schemecanc = Schemecanc,
                    Startdate = Startdate,
                };

            return obj;
        }

        public static class FieldNames
        {
// ReSharper disable InconsistentNaming
            public const string  DRARECNO = "DRARECNO";
            public const string  DRAANCNO = "DRAANCNO";
            public const string  DRACHGNO = "DRACHGNO";
            public const string  DRADISGRPRECNO = "DRADISGRPRECNO";
            public const string  DRAEXPNO = "DRAEXPNO";
            public const string  DRAPRCREF1 = "DRAPRCREF1";
            public const string  DRAPRCREF2 = "DRAPRCREF2";
            public const string  DRAPRCREF3 = "DRAPRCREF3";
            public const string  DRAPRCREF4 = "DRAPRCREF4";
            public const string  DRAPRCREF5 = "DRAPRCREF5";
            public const string  DRAPRCREF6 = "DRAPRCREF6";
            public const string  DRASALOFFNO = "DRASALOFFNO";
            public const string  DRASTCLOC = "DRASTCLOC";
            public const string  DRATYPOF = "DRATYPOF";
            public const string  FINISHDATE = "FINISHDATE";
            public const string  SCHEMECANC = "SCHEMECANC";
            public const string  STARTDATE = "STARTDATE";
 // ReSharper restore InconsistentNaming
        }


    }

}
