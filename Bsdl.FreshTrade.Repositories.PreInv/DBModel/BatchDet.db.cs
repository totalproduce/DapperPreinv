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
    /// Entity for the BATCHDET table
    /// </summary>
    public partial class BatchDet : BaseDbModel<BatchDet, int>
    {
#region tableDefs

       public static List<EntityPropDef> GetPropDefs() {
         var result = new List<EntityPropDef>();

//EntityPropDef(string propName, string columnName, bool isKey, bool isNullable, string refEntityName, PropertyInfo keyPropInfo,
//            int size, int? prec, int? scale)



         result.Add(new EntityPropDef(
         PropertyHelper <BatchDet>.GetProperty(x => x.Bdtrecno),
         "BDTRECNO", // columnName
         true,                    //isKey
         false, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  10, // int? prec
                           0  // int? Scale
         ,
         typeof(BatchDet)
       ));


         result.Add(new EntityPropDef(
         PropertyHelper <BatchDet>.GetProperty(x => x.Bdtbatrecno),
         "BDTBATRECNO", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  10, // int? prec
                           0  // int? Scale
         ,
         typeof(BatchDet)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <BatchDet>.GetProperty(x => x.Bdtcurtotal),
         "BDTCURTOTAL", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         20,       // int size   
                  null, // int? prec
                   
         null // int? Scale
         ,
         typeof(BatchDet)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <BatchDet>.GetProperty(x => x.Bdtedifile),
         "BDTEDIFILE", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         12,       // int size   
                  null, // int? prec
                   
         null // int? Scale
         ,
         typeof(BatchDet)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <BatchDet>.GetProperty(x => x.Bdtinvrecno),
         "BDTINVRECNO", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  10, // int? prec
                           0  // int? Scale
         ,
         typeof(BatchDet)
         ));
         return result; 
       }

#endregion     
        private int _fBdtrecno;
        public int Bdtrecno
        {
            get { return _fBdtrecno; }
            set
            {
                var oldKey = Key;
                if (_fBdtrecno != value)
                {
                    Modify();
                    _fBdtrecno = value;
                    KeyChanged(oldKey);
                }
            }
        }

        private int? _fBdtbatrecno;
        public int? Bdtbatrecno
        {
            get { return _fBdtbatrecno; }
            set
            {
                if (_fBdtbatrecno != value)
                {
                    Modify();
                    _fBdtbatrecno = value;
                }
            }
        }

        private string _fBdtcurtotal;
        public string Bdtcurtotal
        {
            get { return _fBdtcurtotal; }
            set
            {
                if (_fBdtcurtotal != value)
                {
                    Modify();
                    _fBdtcurtotal = value;
                }
            }
        }

        private string _fBdtedifile;
        public string Bdtedifile
        {
            get { return _fBdtedifile; }
            set
            {
                if (_fBdtedifile != value)
                {
                    Modify();
                    _fBdtedifile = value;
                }
            }
        }

        private int? _fBdtinvrecno;
        public int? Bdtinvrecno
        {
            get { return _fBdtinvrecno; }
            set
            {
                if (_fBdtinvrecno != value)
                {
                    Modify();
                    _fBdtinvrecno = value;
                }
            }
        }

        public override int Key
        {
            get { return Bdtrecno; }
            set { Bdtrecno = value; }
        }

        public override string KeyAsString { get { return Key.ToString(CultureInfo.InvariantCulture); } }


        public override BatchDet Clone()
        {
            var obj = new BatchDet
                {
                    Bdtrecno = Bdtrecno,
                    Bdtbatrecno = Bdtbatrecno,
                    Bdtcurtotal = Bdtcurtotal,
                    Bdtedifile = Bdtedifile,
                    Bdtinvrecno = Bdtinvrecno,
                };

            return obj;
        }

        public static class FieldNames
        {
// ReSharper disable InconsistentNaming
            public const string  BDTRECNO = "BDTRECNO";
            public const string  BDTBATRECNO = "BDTBATRECNO";
            public const string  BDTCURTOTAL = "BDTCURTOTAL";
            public const string  BDTEDIFILE = "BDTEDIFILE";
            public const string  BDTINVRECNO = "BDTINVRECNO";
 // ReSharper restore InconsistentNaming
        }


    }

}
