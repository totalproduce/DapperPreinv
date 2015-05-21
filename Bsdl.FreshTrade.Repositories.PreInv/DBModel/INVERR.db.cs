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
    /// Entity for the PREINVTEMP_INVERR table
    /// </summary>
    public partial class INVERR : BaseDbModel<INVERR, string>
    {
#region tableDefs

       public static List<EntityPropDef> GetPropDefs() {
         var result = new List<EntityPropDef>();

//EntityPropDef(string propName, string columnName, bool isKey, bool isNullable, string refEntityName, PropertyInfo keyPropInfo,
//            int size, int? prec, int? scale)




         result.Add(new EntityPropDef(
         PropertyHelper <INVERR>.GetProperty(x => x.Dlvordno),
         "DLVORDNO", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  10, // int? prec
                           0  // int? Scale
         ,
         typeof(INVERR)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <INVERR>.GetProperty(x => x.Errno),
         "ERRNO", // columnName
         false,                    //isKey
         false, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  10, // int? prec
                           0  // int? Scale
         ,
         typeof(INVERR)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <INVERR>.GetProperty(x => x.Extractsessionid),
         "EXTRACTSESSIONID", // columnName
         false,                    //isKey
         false, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  10, // int? prec
                           0  // int? Scale
         ,
         typeof(INVERR)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <INVERR>.GetProperty(x => x.Logrecno),
         "LOGRECNO", // columnName
         false,                    //isKey
         false, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  10, // int? prec
                           0  // int? Scale
         ,
         typeof(INVERR)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <INVERR>.GetProperty(x => x.Ordcstcode),
         "ORDCSTCODE", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         8,       // int size   
                  null, // int? prec
                   
         null // int? Scale
         ,
         typeof(INVERR)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <INVERR>.GetProperty(x => x.Ordcustordno),
         "ORDCUSTORDNO", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         25,       // int size   
                  null, // int? prec
                   
         null // int? Scale
         ,
         typeof(INVERR)
         ));
         return result; 
       }

#endregion     
        private int? _fDlvordno;
        public int? Dlvordno
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

        private int _fErrno;
        public int Errno
        {
            get { return _fErrno; }
            set
            {
                if (_fErrno != value)
                {
                    Modify();
                    _fErrno = value;
                }
            }
        }

        private int _fExtractsessionid;
        public int Extractsessionid
        {
            get { return _fExtractsessionid; }
            set
            {
                if (_fExtractsessionid != value)
                {
                    Modify();
                    _fExtractsessionid = value;
                }
            }
        }

        private int _fLogrecno;
        public int Logrecno
        {
            get { return _fLogrecno; }
            set
            {
                if (_fLogrecno != value)
                {
                    Modify();
                    _fLogrecno = value;
                }
            }
        }

        private string _fOrdcstcode;
        public string Ordcstcode
        {
            get { return _fOrdcstcode; }
            set
            {
                if (_fOrdcstcode != value)
                {
                    Modify();
                    _fOrdcstcode = value;
                }
            }
        }

        private string _fOrdcustordno;
        public string Ordcustordno
        {
            get { return _fOrdcustordno; }
            set
            {
                if (_fOrdcustordno != value)
                {
                    Modify();
                    _fOrdcustordno = value;
                }
            }
        }


        public override INVERR Clone()
        {
            var obj = new INVERR
                {
                    Dlvordno = Dlvordno,
                    Errno = Errno,
                    Extractsessionid = Extractsessionid,
                    Logrecno = Logrecno,
                    Ordcstcode = Ordcstcode,
                    Ordcustordno = Ordcustordno,
                };

            return obj;
        }

        public static class FieldNames
        {
// ReSharper disable InconsistentNaming
            public const string  DLVORDNO = "DLVORDNO";
            public const string  ERRNO = "ERRNO";
            public const string  EXTRACTSESSIONID = "EXTRACTSESSIONID";
            public const string  LOGRECNO = "LOGRECNO";
            public const string  ORDCSTCODE = "ORDCSTCODE";
            public const string  ORDCUSTORDNO = "ORDCUSTORDNO";
 // ReSharper restore InconsistentNaming
        }


    }

}
