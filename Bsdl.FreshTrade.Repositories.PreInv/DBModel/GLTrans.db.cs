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
    /// Entity for the GLTRANS table
    /// </summary>
    public partial class GLTrans : BaseDbModel<GLTrans, int>
    {
#region tableDefs

       public static List<EntityPropDef> GetPropDefs() {
         var result = new List<EntityPropDef>();

//EntityPropDef(string propName, string columnName, bool isKey, bool isNullable, string refEntityName, PropertyInfo keyPropInfo,
//            int size, int? prec, int? scale)



         result.Add(new EntityPropDef(
         PropertyHelper <GLTrans>.GetProperty(x => x.Gltrecno),
         "GLTRECNO", // columnName
         true,                    //isKey
         false, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  10, // int? prec
                           0  // int? Scale
         ,
         typeof(GLTrans)
       ));


         result.Add(new EntityPropDef(
         PropertyHelper <GLTrans>.GetProperty(x => x.Glextractbatchid),
         "GLEXTRACTBATCHID", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  10, // int? prec
                           0  // int? Scale
         ,
         typeof(GLTrans)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <GLTrans>.GetProperty(x => x.Gltcat),
         "GLTCAT", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         1,       // int size   
                  null, // int? prec
                   
         null // int? Scale
         ,
         typeof(GLTrans)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <GLTrans>.GetProperty(x => x.Gltcomno),
         "GLTCOMNO", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  10, // int? prec
                           0  // int? Scale
         ,
         typeof(GLTrans)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <GLTrans>.GetProperty(x => x.Gltcramount),
         "GLTCRAMOUNT", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  126, // int? prec
                   
         null // int? Scale
         ,
         typeof(GLTrans)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <GLTrans>.GetProperty(x => x.Gltdbamount),
         "GLTDBAMOUNT", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  126, // int? prec
                   
         null // int? Scale
         ,
         typeof(GLTrans)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <GLTrans>.GetProperty(x => x.Gltdbno),
         "GLTDBNO", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  10, // int? prec
                           0  // int? Scale
         ,
         typeof(GLTrans)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <GLTrans>.GetProperty(x => x.Gltdbtyp),
         "GLTDBTYP", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  5, // int? prec
                           0  // int? Scale
         ,
         typeof(GLTrans)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <GLTrans>.GetProperty(x => x.Gltganrecno),
         "GLTGANRECNO", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  10, // int? prec
                           0  // int? Scale
         ,
         typeof(GLTrans)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <GLTrans>.GetProperty(x => x.Gltorgdbno),
         "GLTORGDBNO", // columnName
         false,                    //isKey
         false, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  10, // int? prec
                           0  // int? Scale
         ,
         typeof(GLTrans)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <GLTrans>.GetProperty(x => x.Gltperno),
         "GLTPERNO", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  5, // int? prec
                           0  // int? Scale
         ,
         typeof(GLTrans)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <GLTrans>.GetProperty(x => x.Gltsaloffno),
         "GLTSALOFFNO", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  5, // int? prec
                           0  // int? Scale
         ,
         typeof(GLTrans)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <GLTrans>.GetProperty(x => x.Gltyrno),
         "GLTYRNO", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  5, // int? prec
                           0  // int? Scale
         ,
         typeof(GLTrans)
         ));
         return result; 
       }

#endregion     
        private int _fGltrecno;
        public int Gltrecno
        {
            get { return _fGltrecno; }
            set
            {
                var oldKey = Key;
                if (_fGltrecno != value)
                {
                    Modify();
                    _fGltrecno = value;
                    KeyChanged(oldKey);
                }
            }
        }

        private int? _fGlextractbatchid;
        public int? Glextractbatchid
        {
            get { return _fGlextractbatchid; }
            set
            {
                if (_fGlextractbatchid != value)
                {
                    Modify();
                    _fGlextractbatchid = value;
                }
            }
        }

        private string _fGltcat;
        public string Gltcat
        {
            get { return _fGltcat; }
            set
            {
                if (_fGltcat != value)
                {
                    Modify();
                    _fGltcat = value;
                }
            }
        }

        private int? _fGltcomno;
        public int? Gltcomno
        {
            get { return _fGltcomno; }
            set
            {
                if (_fGltcomno != value)
                {
                    Modify();
                    _fGltcomno = value;
                }
            }
        }

        private decimal? _fGltcramount;
        public decimal? Gltcramount
        {
            get { return _fGltcramount; }
            set
            {
                if (_fGltcramount != value)
                {
                    Modify();
                    _fGltcramount = value;
                }
            }
        }

        private decimal? _fGltdbamount;
        public decimal? Gltdbamount
        {
            get { return _fGltdbamount; }
            set
            {
                if (_fGltdbamount != value)
                {
                    Modify();
                    _fGltdbamount = value;
                }
            }
        }

        private int? _fGltdbno;
        public int? Gltdbno
        {
            get { return _fGltdbno; }
            set
            {
                if (_fGltdbno != value)
                {
                    Modify();
                    _fGltdbno = value;
                }
            }
        }

        private int? _fGltdbtyp;
        public int? Gltdbtyp
        {
            get { return _fGltdbtyp; }
            set
            {
                if (_fGltdbtyp != value)
                {
                    Modify();
                    _fGltdbtyp = value;
                }
            }
        }

        private int? _fGltganrecno;
        public int? Gltganrecno
        {
            get { return _fGltganrecno; }
            set
            {
                if (_fGltganrecno != value)
                {
                    Modify();
                    _fGltganrecno = value;
                }
            }
        }

        private int _fGltorgdbno;
        public int Gltorgdbno
        {
            get { return _fGltorgdbno; }
            set
            {
                if (_fGltorgdbno != value)
                {
                    Modify();
                    _fGltorgdbno = value;
                }
            }
        }

        private int? _fGltperno;
        public int? Gltperno
        {
            get { return _fGltperno; }
            set
            {
                if (_fGltperno != value)
                {
                    Modify();
                    _fGltperno = value;
                }
            }
        }

        private int? _fGltsaloffno;
        public int? Gltsaloffno
        {
            get { return _fGltsaloffno; }
            set
            {
                if (_fGltsaloffno != value)
                {
                    Modify();
                    _fGltsaloffno = value;
                }
            }
        }

        private int? _fGltyrno;
        public int? Gltyrno
        {
            get { return _fGltyrno; }
            set
            {
                if (_fGltyrno != value)
                {
                    Modify();
                    _fGltyrno = value;
                }
            }
        }

        public override int Key
        {
            get { return Gltrecno; }
            set { Gltrecno = value; }
        }

        public override string KeyAsString { get { return Key.ToString(CultureInfo.InvariantCulture); } }


        public override GLTrans Clone()
        {
            var obj = new GLTrans
                {
                    Gltrecno = Gltrecno,
                    Glextractbatchid = Glextractbatchid,
                    Gltcat = Gltcat,
                    Gltcomno = Gltcomno,
                    Gltcramount = Gltcramount,
                    Gltdbamount = Gltdbamount,
                    Gltdbno = Gltdbno,
                    Gltdbtyp = Gltdbtyp,
                    Gltganrecno = Gltganrecno,
                    Gltorgdbno = Gltorgdbno,
                    Gltperno = Gltperno,
                    Gltsaloffno = Gltsaloffno,
                    Gltyrno = Gltyrno,
                };

            return obj;
        }

        public static class FieldNames
        {
// ReSharper disable InconsistentNaming
            public const string  GLTRECNO = "GLTRECNO";
            public const string  GLEXTRACTBATCHID = "GLEXTRACTBATCHID";
            public const string  GLTCAT = "GLTCAT";
            public const string  GLTCOMNO = "GLTCOMNO";
            public const string  GLTCRAMOUNT = "GLTCRAMOUNT";
            public const string  GLTDBAMOUNT = "GLTDBAMOUNT";
            public const string  GLTDBNO = "GLTDBNO";
            public const string  GLTDBTYP = "GLTDBTYP";
            public const string  GLTGANRECNO = "GLTGANRECNO";
            public const string  GLTORGDBNO = "GLTORGDBNO";
            public const string  GLTPERNO = "GLTPERNO";
            public const string  GLTSALOFFNO = "GLTSALOFFNO";
            public const string  GLTYRNO = "GLTYRNO";
 // ReSharper restore InconsistentNaming
        }


    }

}
