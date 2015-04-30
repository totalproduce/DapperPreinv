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
    /// Entity for the BATCH table
    /// </summary>
    public partial class Batch : BaseDbModel<Batch, int>
    {
#region tableDefs

       public static List<EntityPropDef> GetPropDefs() {
         var result = new List<EntityPropDef>();

//EntityPropDef(string propName, string columnName, bool isKey, bool isNullable, string refEntityName, PropertyInfo keyPropInfo,
//            int size, int? prec, int? scale)



         result.Add(new EntityPropDef(
         PropertyHelper <Batch>.GetProperty(x => x.Batrecno),
         "BATRECNO", // columnName
         true,                    //isKey
         false, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  10, // int? prec
                           0  // int? Scale
         ,
         typeof(Batch)
       ));


         result.Add(new EntityPropDef(
         PropertyHelper <Batch>.GetProperty(x => x.Batchallocflg),
         "BATCHALLOCFLG", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  1, // int? prec
                           0  // int? Scale
         ,
         typeof(Batch)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <Batch>.GetProperty(x => x.Batchcutoffdate),
         "BATCHCUTOFFDATE", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  null, // int? prec
                   
         null // int? Scale
         ,
         typeof(Batch)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <Batch>.GetProperty(x => x.Batchinvperiod),
         "BATCHINVPERIOD", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         10,       // int size   
                  null, // int? prec
                   
         null // int? Scale
         ,
         typeof(Batch)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <Batch>.GetProperty(x => x.Batchinvtype),
         "BATCHINVTYPE", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         12,       // int size   
                  null, // int? prec
                   
         null // int? Scale
         ,
         typeof(Batch)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <Batch>.GetProperty(x => x.Batchmarketind),
         "BATCHMARKETIND", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  1, // int? prec
                           0  // int? Scale
         ,
         typeof(Batch)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <Batch>.GetProperty(x => x.Batchmergetrans),
         "BATCHMERGETRANS", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  1, // int? prec
                           0  // int? Scale
         ,
         typeof(Batch)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <Batch>.GetProperty(x => x.Batchnetusername),
         "BATCHNETUSERNAME", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         28,       // int size   
                  null, // int? prec
                   
         null // int? Scale
         ,
         typeof(Batch)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <Batch>.GetProperty(x => x.Batchno),
         "BATCHNO", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  10, // int? prec
                           0  // int? Scale
         ,
         typeof(Batch)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <Batch>.GetProperty(x => x.Batchprintno),
         "BATCHPRINTNO", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  5, // int? prec
                           0  // int? Scale
         ,
         typeof(Batch)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <Batch>.GetProperty(x => x.Batchpstrecno),
         "BATCHPSTRECNO", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  5, // int? prec
                           0  // int? Scale
         ,
         typeof(Batch)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <Batch>.GetProperty(x => x.Batchsaloffno),
         "BATCHSALOFFNO", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  5, // int? prec
                           0  // int? Scale
         ,
         typeof(Batch)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <Batch>.GetProperty(x => x.Batchtaxdate),
         "BATCHTAXDATE", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  null, // int? prec
                   
         null // int? Scale
         ,
         typeof(Batch)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <Batch>.GetProperty(x => x.Batchtimestamp),
         "BATCHTIMESTAMP", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  null, // int? prec
                   
         null // int? Scale
         ,
         typeof(Batch)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <Batch>.GetProperty(x => x.Batchtypeno),
         "BATCHTYPENO", // columnName
         false,                    //isKey
         false, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  5, // int? prec
                           0  // int? Scale
         ,
         typeof(Batch)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <Batch>.GetProperty(x => x.Interdeptprocessed),
         "INTERDEPTPROCESSED", // columnName
         false,                    //isKey
         false, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  1, // int? prec
                           0  // int? Scale
         ,
         typeof(Batch)
         ));
         return result; 
       }

#endregion     
        private int _fBatrecno;
        public int Batrecno
        {
            get { return _fBatrecno; }
            set
            {
                var oldKey = Key;
                if (_fBatrecno != value)
                {
                    Modify();
                    _fBatrecno = value;
                    KeyChanged(oldKey);
                }
            }
        }

        private short? _fBatchallocflg;
        public short? Batchallocflg
        {
            get { return _fBatchallocflg; }
            set
            {
                if (_fBatchallocflg != value)
                {
                    Modify();
                    _fBatchallocflg = value;
                }
            }
        }

        private DateTime? _fBatchcutoffdate;
        public DateTime? Batchcutoffdate
        {
            get { return _fBatchcutoffdate; }
            set
            {
                if (_fBatchcutoffdate != value)
                {
                    Modify();
                    _fBatchcutoffdate = value;
                }
            }
        }

        private string _fBatchinvperiod;
        public string Batchinvperiod
        {
            get { return _fBatchinvperiod; }
            set
            {
                if (_fBatchinvperiod != value)
                {
                    Modify();
                    _fBatchinvperiod = value;
                }
            }
        }

        private string _fBatchinvtype;
        public string Batchinvtype
        {
            get { return _fBatchinvtype; }
            set
            {
                if (_fBatchinvtype != value)
                {
                    Modify();
                    _fBatchinvtype = value;
                }
            }
        }

        private short? _fBatchmarketind;
        public short? Batchmarketind
        {
            get { return _fBatchmarketind; }
            set
            {
                if (_fBatchmarketind != value)
                {
                    Modify();
                    _fBatchmarketind = value;
                }
            }
        }

        private short? _fBatchmergetrans;
        public short? Batchmergetrans
        {
            get { return _fBatchmergetrans; }
            set
            {
                if (_fBatchmergetrans != value)
                {
                    Modify();
                    _fBatchmergetrans = value;
                }
            }
        }

        private string _fBatchnetusername;
        public string Batchnetusername
        {
            get { return _fBatchnetusername; }
            set
            {
                if (_fBatchnetusername != value)
                {
                    Modify();
                    _fBatchnetusername = value;
                }
            }
        }

        private int? _fBatchno;
        public int? Batchno
        {
            get { return _fBatchno; }
            set
            {
                if (_fBatchno != value)
                {
                    Modify();
                    _fBatchno = value;
                }
            }
        }

        private int? _fBatchprintno;
        public int? Batchprintno
        {
            get { return _fBatchprintno; }
            set
            {
                if (_fBatchprintno != value)
                {
                    Modify();
                    _fBatchprintno = value;
                }
            }
        }

        private int? _fBatchpstrecno;
        public int? Batchpstrecno
        {
            get { return _fBatchpstrecno; }
            set
            {
                if (_fBatchpstrecno != value)
                {
                    Modify();
                    _fBatchpstrecno = value;
                }
            }
        }

        private int? _fBatchsaloffno;
        public int? Batchsaloffno
        {
            get { return _fBatchsaloffno; }
            set
            {
                if (_fBatchsaloffno != value)
                {
                    Modify();
                    _fBatchsaloffno = value;
                }
            }
        }

        private DateTime? _fBatchtaxdate;
        public DateTime? Batchtaxdate
        {
            get { return _fBatchtaxdate; }
            set
            {
                if (_fBatchtaxdate != value)
                {
                    Modify();
                    _fBatchtaxdate = value;
                }
            }
        }

        private DateTime? _fBatchtimestamp;
        public DateTime? Batchtimestamp
        {
            get { return _fBatchtimestamp; }
            set
            {
                if (_fBatchtimestamp != value)
                {
                    Modify();
                    _fBatchtimestamp = value;
                }
            }
        }

        private int _fBatchtypeno;
        public int Batchtypeno
        {
            get { return _fBatchtypeno; }
            set
            {
                if (_fBatchtypeno != value)
                {
                    Modify();
                    _fBatchtypeno = value;
                }
            }
        }

        private short _fInterdeptprocessed;
        public short Interdeptprocessed
        {
            get { return _fInterdeptprocessed; }
            set
            {
                if (_fInterdeptprocessed != value)
                {
                    Modify();
                    _fInterdeptprocessed = value;
                }
            }
        }

        public override int Key
        {
            get { return Batrecno; }
            set { Batrecno = value; }
        }

        public override string KeyAsString { get { return Key.ToString(CultureInfo.InvariantCulture); } }


        public override Batch Clone()
        {
            var obj = new Batch
                {
                    Batrecno = Batrecno,
                    Batchallocflg = Batchallocflg,
                    Batchcutoffdate = Batchcutoffdate,
                    Batchinvperiod = Batchinvperiod,
                    Batchinvtype = Batchinvtype,
                    Batchmarketind = Batchmarketind,
                    Batchmergetrans = Batchmergetrans,
                    Batchnetusername = Batchnetusername,
                    Batchno = Batchno,
                    Batchprintno = Batchprintno,
                    Batchpstrecno = Batchpstrecno,
                    Batchsaloffno = Batchsaloffno,
                    Batchtaxdate = Batchtaxdate,
                    Batchtimestamp = Batchtimestamp,
                    Batchtypeno = Batchtypeno,
                    Interdeptprocessed = Interdeptprocessed,
                };

            return obj;
        }

        public static class FieldNames
        {
// ReSharper disable InconsistentNaming
            public const string  BATRECNO = "BATRECNO";
            public const string  BATCHALLOCFLG = "BATCHALLOCFLG";
            public const string  BATCHCUTOFFDATE = "BATCHCUTOFFDATE";
            public const string  BATCHINVPERIOD = "BATCHINVPERIOD";
            public const string  BATCHINVTYPE = "BATCHINVTYPE";
            public const string  BATCHMARKETIND = "BATCHMARKETIND";
            public const string  BATCHMERGETRANS = "BATCHMERGETRANS";
            public const string  BATCHNETUSERNAME = "BATCHNETUSERNAME";
            public const string  BATCHNO = "BATCHNO";
            public const string  BATCHPRINTNO = "BATCHPRINTNO";
            public const string  BATCHPSTRECNO = "BATCHPSTRECNO";
            public const string  BATCHSALOFFNO = "BATCHSALOFFNO";
            public const string  BATCHTAXDATE = "BATCHTAXDATE";
            public const string  BATCHTIMESTAMP = "BATCHTIMESTAMP";
            public const string  BATCHTYPENO = "BATCHTYPENO";
            public const string  INTERDEPTPROCESSED = "INTERDEPTPROCESSED";
 // ReSharper restore InconsistentNaming
        }


    }

}
