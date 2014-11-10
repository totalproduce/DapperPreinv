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
    /// Entity for the DELHED table
    /// </summary>
    public partial class DELHED : BaseDbModel<DELHED, int>
    {
#region tableDefs

       public static List<EntityPropDef> GetPropDefs() {
         var result = new List<EntityPropDef>();

//EntityPropDef(string propName, string columnName, bool isKey, bool isNullable, string refEntityName, PropertyInfo keyPropInfo,
//            int size, int? prec, int? scale)



         result.Add(new EntityPropDef(
         PropertyHelper <DELHED>.GetProperty(x => x.Dlvordno),
         "DLVORDNO", // columnName
         true,                    //isKey
         false, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  10, // int? prec
                           0  // int? Scale
         ,
         typeof(DELHED)
       ));


         result.Add(new EntityPropDef(
         PropertyHelper <DELHED>.GetProperty(x => x.Creditcontrolhold),
         "CREDITCONTROLHOLD", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  1, // int? prec
                           0  // int? Scale
         ,
         typeof(DELHED)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <DELHED>.GetProperty(x => x.Delcredonholdval),
         "DELCREDONHOLDVAL", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  126, // int? prec
                   
         null // int? Scale
         ,
         typeof(DELHED)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <DELHED>.GetProperty(x => x.Deltransprcmeth),
         "DELTRANSPRCMETH", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  5, // int? prec
                           0  // int? Scale
         ,
         typeof(DELHED)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <DELHED>.GetProperty(x => x.Dlvcomno),
         "DLVCOMNO", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  10, // int? prec
                           0  // int? Scale
         ,
         typeof(DELHED)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <DELHED>.GetProperty(x => x.Dlvcstsupno),
         "DLVCSTSUPNO", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  5, // int? prec
                           0  // int? Scale
         ,
         typeof(DELHED)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <DELHED>.GetProperty(x => x.Dlvcurrecno),
         "DLVCURRECNO", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  5, // int? prec
                           0  // int? Scale
         ,
         typeof(DELHED)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <DELHED>.GetProperty(x => x.Dlvdeldate),
         "DLVDELDATE", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  null, // int? prec
                   
         null // int? Scale
         ,
         typeof(DELHED)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <DELHED>.GetProperty(x => x.Dlvdltrecno),
         "DLVDLTRECNO", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  5, // int? prec
                           0  // int? Scale
         ,
         typeof(DELHED)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <DELHED>.GetProperty(x => x.Dlvediref),
         "DLVEDIREF", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         15,       // int size   
                  null, // int? prec
                   
         null // int? Scale
         ,
         typeof(DELHED)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <DELHED>.GetProperty(x => x.Dlvfaxsent),
         "DLVFAXSENT", // columnName
         false,                    //isKey
         false, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  5, // int? prec
                           0  // int? Scale
         ,
         typeof(DELHED)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <DELHED>.GetProperty(x => x.Dlvhasopenprc),
         "DLVHASOPENPRC", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  1, // int? prec
                           0  // int? Scale
         ,
         typeof(DELHED)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <DELHED>.GetProperty(x => x.Dlvisdirect),
         "DLVISDIRECT", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  5, // int? prec
                           0  // int? Scale
         ,
         typeof(DELHED)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <DELHED>.GetProperty(x => x.Dlvismktsale),
         "DLVISMKTSALE", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  1, // int? prec
                           0  // int? Scale
         ,
         typeof(DELHED)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <DELHED>.GetProperty(x => x.Dlvnotclosed),
         "DLVNOTCLOSED", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  5, // int? prec
                           0  // int? Scale
         ,
         typeof(DELHED)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <DELHED>.GetProperty(x => x.Dlvordrecno),
         "DLVORDRECNO", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  10, // int? prec
                           0  // int? Scale
         ,
         typeof(DELHED)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <DELHED>.GetProperty(x => x.Dlvowncollection),
         "DLVOWNCOLLECTION", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  1, // int? prec
                           0  // int? Scale
         ,
         typeof(DELHED)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <DELHED>.GetProperty(x => x.Dlvpassed),
         "DLVPASSED", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  1, // int? prec
                           0  // int? Scale
         ,
         typeof(DELHED)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <DELHED>.GetProperty(x => x.Dlvpodno),
         "DLVPODNO", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         15,       // int size   
                  null, // int? prec
                   
         null // int? Scale
         ,
         typeof(DELHED)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <DELHED>.GetProperty(x => x.Dlvprghedno),
         "DLVPRGHEDNO", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  10, // int? prec
                           0  // int? Scale
         ,
         typeof(DELHED)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <DELHED>.GetProperty(x => x.Dlvpriority),
         "DLVPRIORITY", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  5, // int? prec
                           0  // int? Scale
         ,
         typeof(DELHED)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <DELHED>.GetProperty(x => x.Dlvprtstat),
         "DLVPRTSTAT", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  5, // int? prec
                           0  // int? Scale
         ,
         typeof(DELHED)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <DELHED>.GetProperty(x => x.Dlvrelconfm),
         "DLVRELCONFM", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  1, // int? prec
                           0  // int? Scale
         ,
         typeof(DELHED)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <DELHED>.GetProperty(x => x.Dlvrelinv),
         "DLVRELINV", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         3,       // int size   
                  null, // int? prec
                   
         null // int? Scale
         ,
         typeof(DELHED)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <DELHED>.GetProperty(x => x.Dlvrthno),
         "DLVRTHNO", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  10, // int? prec
                           0  // int? Scale
         ,
         typeof(DELHED)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <DELHED>.GetProperty(x => x.Dlvsaloffno),
         "DLVSALOFFNO", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  5, // int? prec
                           0  // int? Scale
         ,
         typeof(DELHED)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <DELHED>.GetProperty(x => x.Dlvsaltyp),
         "DLVSALTYP", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         1,       // int size   
                  null, // int? prec
                   
         null // int? Scale
         ,
         typeof(DELHED)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <DELHED>.GetProperty(x => x.Dlvshpdate),
         "DLVSHPDATE", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  null, // int? prec
                   
         null // int? Scale
         ,
         typeof(DELHED)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <DELHED>.GetProperty(x => x.Dlvstkloc),
         "DLVSTKLOC", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  5, // int? prec
                           0  // int? Scale
         ,
         typeof(DELHED)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <DELHED>.GetProperty(x => x.Dlvtime),
         "DLVTIME", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         5,       // int size   
                  null, // int? prec
                   
         null // int? Scale
         ,
         typeof(DELHED)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <DELHED>.GetProperty(x => x.Dlvtranind),
         "DLVTRANIND", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  5, // int? prec
                           0  // int? Scale
         ,
         typeof(DELHED)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <DELHED>.GetProperty(x => x.Dlvtransconfdate),
         "DLVTRANSCONFDATE", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  null, // int? prec
                   
         null // int? Scale
         ,
         typeof(DELHED)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <DELHED>.GetProperty(x => x.Dlvtransship),
         "DLVTRANSSHIP", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  5, // int? prec
                           0  // int? Scale
         ,
         typeof(DELHED)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <DELHED>.GetProperty(x => x.Dlvtransshiptoloc),
         "DLVTRANSSHIPTOLOC", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  5, // int? prec
                           0  // int? Scale
         ,
         typeof(DELHED)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <DELHED>.GetProperty(x => x.Dlvupddate),
         "DLVUPDDATE", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  null, // int? prec
                   
         null // int? Scale
         ,
         typeof(DELHED)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <DELHED>.GetProperty(x => x.Dlvupdtime),
         "DLVUPDTIME", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         11,       // int size   
                  null, // int? prec
                   
         null // int? Scale
         ,
         typeof(DELHED)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <DELHED>.GetProperty(x => x.Hedsyscalcpals),
         "HEDSYSCALCPALS", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  126, // int? prec
                   
         null // int? Scale
         ,
         typeof(DELHED)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <DELHED>.GetProperty(x => x.Interdeptflag),
         "INTERDEPTFLAG", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  5, // int? prec
                           0  // int? Scale
         ,
         typeof(DELHED)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <DELHED>.GetProperty(x => x.Invoiceref),
         "INVOICEREF", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         20,       // int size   
                  null, // int? prec
                   
         null // int? Scale
         ,
         typeof(DELHED)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <DELHED>.GetProperty(x => x.Invsaloffno),
         "INVSALOFFNO", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  5, // int? prec
                           0  // int? Scale
         ,
         typeof(DELHED)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <DELHED>.GetProperty(x => x.Isopenformore),
         "ISOPENFORMORE", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  5, // int? prec
                           0  // int? Scale
         ,
         typeof(DELHED)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <DELHED>.GetProperty(x => x.Logonno),
         "LOGONNO", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  5, // int? prec
                           0  // int? Scale
         ,
         typeof(DELHED)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <DELHED>.GetProperty(x => x.Ordertype),
         "ORDERTYPE", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  5, // int? prec
                           0  // int? Scale
         ,
         typeof(DELHED)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <DELHED>.GetProperty(x => x.Qcchecked),
         "QCCHECKED", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  1, // int? prec
                           0  // int? Scale
         ,
         typeof(DELHED)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <DELHED>.GetProperty(x => x.Qcnarrecno),
         "QCNARRECNO", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  5, // int? prec
                           0  // int? Scale
         ,
         typeof(DELHED)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <DELHED>.GetProperty(x => x.Supclarecno),
         "SUPCLARECNO", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  10, // int? prec
                           0  // int? Scale
         ,
         typeof(DELHED)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <DELHED>.GetProperty(x => x.Transferflg),
         "TRANSFERFLG", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  10, // int? prec
                           0  // int? Scale
         ,
         typeof(DELHED)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <DELHED>.GetProperty(x => x.Trnsaloffno),
         "TRNSALOFFNO", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  5, // int? prec
                           0  // int? Scale
         ,
         typeof(DELHED)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <DELHED>.GetProperty(x => x.Userinppals),
         "USERINPPALS", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  126, // int? prec
                   
         null // int? Scale
         ,
         typeof(DELHED)
         ));
         return result; 
       }

#endregion     
        private int _fDlvordno;
        public int Dlvordno
        {
            get { return _fDlvordno; }
            set
            {
                var oldKey = Key;
                if (_fDlvordno != value)
                {
                    Modify();
                    _fDlvordno = value;
                    KeyChanged(oldKey);
                }
            }
        }

        private short? _fCreditcontrolhold;
        public short? Creditcontrolhold
        {
            get { return _fCreditcontrolhold; }
            set
            {
                if (_fCreditcontrolhold != value)
                {
                    Modify();
                    _fCreditcontrolhold = value;
                }
            }
        }

        private decimal? _fDelcredonholdval;
        public decimal? Delcredonholdval
        {
            get { return _fDelcredonholdval; }
            set
            {
                if (_fDelcredonholdval != value)
                {
                    Modify();
                    _fDelcredonholdval = value;
                }
            }
        }

        private int? _fDeltransprcmeth;
        public int? Deltransprcmeth
        {
            get { return _fDeltransprcmeth; }
            set
            {
                if (_fDeltransprcmeth != value)
                {
                    Modify();
                    _fDeltransprcmeth = value;
                }
            }
        }

        private int? _fDlvcomno;
        public int? Dlvcomno
        {
            get { return _fDlvcomno; }
            set
            {
                if (_fDlvcomno != value)
                {
                    Modify();
                    _fDlvcomno = value;
                }
            }
        }

        private int? _fDlvcstsupno;
        public int? Dlvcstsupno
        {
            get { return _fDlvcstsupno; }
            set
            {
                if (_fDlvcstsupno != value)
                {
                    Modify();
                    _fDlvcstsupno = value;
                }
            }
        }

        private int? _fDlvcurrecno;
        public int? Dlvcurrecno
        {
            get { return _fDlvcurrecno; }
            set
            {
                if (_fDlvcurrecno != value)
                {
                    Modify();
                    _fDlvcurrecno = value;
                }
            }
        }

        private DateTime? _fDlvdeldate;
        public DateTime? Dlvdeldate
        {
            get { return _fDlvdeldate; }
            set
            {
                if (_fDlvdeldate != value)
                {
                    Modify();
                    _fDlvdeldate = value;
                }
            }
        }

        private int? _fDlvdltrecno;
        public int? Dlvdltrecno
        {
            get { return _fDlvdltrecno; }
            set
            {
                if (_fDlvdltrecno != value)
                {
                    Modify();
                    _fDlvdltrecno = value;
                }
            }
        }

        private string _fDlvediref;
        public string Dlvediref
        {
            get { return _fDlvediref; }
            set
            {
                if (_fDlvediref != value)
                {
                    Modify();
                    _fDlvediref = value;
                }
            }
        }

        private int _fDlvfaxsent;
        public int Dlvfaxsent
        {
            get { return _fDlvfaxsent; }
            set
            {
                if (_fDlvfaxsent != value)
                {
                    Modify();
                    _fDlvfaxsent = value;
                }
            }
        }

        private short? _fDlvhasopenprc;
        public short? Dlvhasopenprc
        {
            get { return _fDlvhasopenprc; }
            set
            {
                if (_fDlvhasopenprc != value)
                {
                    Modify();
                    _fDlvhasopenprc = value;
                }
            }
        }

        private int? _fDlvisdirect;
        public int? Dlvisdirect
        {
            get { return _fDlvisdirect; }
            set
            {
                if (_fDlvisdirect != value)
                {
                    Modify();
                    _fDlvisdirect = value;
                }
            }
        }

        private short? _fDlvismktsale;
        public short? Dlvismktsale
        {
            get { return _fDlvismktsale; }
            set
            {
                if (_fDlvismktsale != value)
                {
                    Modify();
                    _fDlvismktsale = value;
                }
            }
        }

        private int? _fDlvnotclosed;
        public int? Dlvnotclosed
        {
            get { return _fDlvnotclosed; }
            set
            {
                if (_fDlvnotclosed != value)
                {
                    Modify();
                    _fDlvnotclosed = value;
                }
            }
        }

        private int? _fDlvordrecno;
        public int? Dlvordrecno
        {
            get { return _fDlvordrecno; }
            set
            {
                if (_fDlvordrecno != value)
                {
                    Modify();
                    _fDlvordrecno = value;
                }
            }
        }

        private short? _fDlvowncollection;
        public short? Dlvowncollection
        {
            get { return _fDlvowncollection; }
            set
            {
                if (_fDlvowncollection != value)
                {
                    Modify();
                    _fDlvowncollection = value;
                }
            }
        }

        private short? _fDlvpassed;
        public short? Dlvpassed
        {
            get { return _fDlvpassed; }
            set
            {
                if (_fDlvpassed != value)
                {
                    Modify();
                    _fDlvpassed = value;
                }
            }
        }

        private string _fDlvpodno;
        public string Dlvpodno
        {
            get { return _fDlvpodno; }
            set
            {
                if (_fDlvpodno != value)
                {
                    Modify();
                    _fDlvpodno = value;
                }
            }
        }

        private int? _fDlvprghedno;
        public int? Dlvprghedno
        {
            get { return _fDlvprghedno; }
            set
            {
                if (_fDlvprghedno != value)
                {
                    Modify();
                    _fDlvprghedno = value;
                }
            }
        }

        private int? _fDlvpriority;
        public int? Dlvpriority
        {
            get { return _fDlvpriority; }
            set
            {
                if (_fDlvpriority != value)
                {
                    Modify();
                    _fDlvpriority = value;
                }
            }
        }

        private int? _fDlvprtstat;
        public int? Dlvprtstat
        {
            get { return _fDlvprtstat; }
            set
            {
                if (_fDlvprtstat != value)
                {
                    Modify();
                    _fDlvprtstat = value;
                }
            }
        }

        private short? _fDlvrelconfm;
        public short? Dlvrelconfm
        {
            get { return _fDlvrelconfm; }
            set
            {
                if (_fDlvrelconfm != value)
                {
                    Modify();
                    _fDlvrelconfm = value;
                }
            }
        }

        private string _fDlvrelinv;
        public string Dlvrelinv
        {
            get { return _fDlvrelinv; }
            set
            {
                if (_fDlvrelinv != value)
                {
                    Modify();
                    _fDlvrelinv = value;
                }
            }
        }

        private int? _fDlvrthno;
        public int? Dlvrthno
        {
            get { return _fDlvrthno; }
            set
            {
                if (_fDlvrthno != value)
                {
                    Modify();
                    _fDlvrthno = value;
                }
            }
        }

        private int? _fDlvsaloffno;
        public int? Dlvsaloffno
        {
            get { return _fDlvsaloffno; }
            set
            {
                if (_fDlvsaloffno != value)
                {
                    Modify();
                    _fDlvsaloffno = value;
                }
            }
        }

        private string _fDlvsaltyp;
        public string Dlvsaltyp
        {
            get { return _fDlvsaltyp; }
            set
            {
                if (_fDlvsaltyp != value)
                {
                    Modify();
                    _fDlvsaltyp = value;
                }
            }
        }

        private DateTime? _fDlvshpdate;
        public DateTime? Dlvshpdate
        {
            get { return _fDlvshpdate; }
            set
            {
                if (_fDlvshpdate != value)
                {
                    Modify();
                    _fDlvshpdate = value;
                }
            }
        }

        private int? _fDlvstkloc;
        public int? Dlvstkloc
        {
            get { return _fDlvstkloc; }
            set
            {
                if (_fDlvstkloc != value)
                {
                    Modify();
                    _fDlvstkloc = value;
                }
            }
        }

        private string _fDlvtime;
        public string Dlvtime
        {
            get { return _fDlvtime; }
            set
            {
                if (_fDlvtime != value)
                {
                    Modify();
                    _fDlvtime = value;
                }
            }
        }

        private int? _fDlvtranind;
        public int? Dlvtranind
        {
            get { return _fDlvtranind; }
            set
            {
                if (_fDlvtranind != value)
                {
                    Modify();
                    _fDlvtranind = value;
                }
            }
        }

        private DateTime? _fDlvtransconfdate;
        public DateTime? Dlvtransconfdate
        {
            get { return _fDlvtransconfdate; }
            set
            {
                if (_fDlvtransconfdate != value)
                {
                    Modify();
                    _fDlvtransconfdate = value;
                }
            }
        }

        private int? _fDlvtransship;
        public int? Dlvtransship
        {
            get { return _fDlvtransship; }
            set
            {
                if (_fDlvtransship != value)
                {
                    Modify();
                    _fDlvtransship = value;
                }
            }
        }

        private int? _fDlvtransshiptoloc;
        public int? Dlvtransshiptoloc
        {
            get { return _fDlvtransshiptoloc; }
            set
            {
                if (_fDlvtransshiptoloc != value)
                {
                    Modify();
                    _fDlvtransshiptoloc = value;
                }
            }
        }

        private DateTime? _fDlvupddate;
        public DateTime? Dlvupddate
        {
            get { return _fDlvupddate; }
            set
            {
                if (_fDlvupddate != value)
                {
                    Modify();
                    _fDlvupddate = value;
                }
            }
        }

        private string _fDlvupdtime;
        public string Dlvupdtime
        {
            get { return _fDlvupdtime; }
            set
            {
                if (_fDlvupdtime != value)
                {
                    Modify();
                    _fDlvupdtime = value;
                }
            }
        }

        private decimal? _fHedsyscalcpals;
        public decimal? Hedsyscalcpals
        {
            get { return _fHedsyscalcpals; }
            set
            {
                if (_fHedsyscalcpals != value)
                {
                    Modify();
                    _fHedsyscalcpals = value;
                }
            }
        }

        private int? _fInterdeptflag;
        /// <summary>
        /// If this sale is a interdepartment sale then this will be the Department Number (DEPARTMENTS.DPTRECNO)
        /// </summary>
        public int? Interdeptflag
        {
            get { return _fInterdeptflag; }
            set
            {
                if (_fInterdeptflag != value)
                {
                    Modify();
                    _fInterdeptflag = value;
                }
            }
        }

        private string _fInvoiceref;
        public string Invoiceref
        {
            get { return _fInvoiceref; }
            set
            {
                if (_fInvoiceref != value)
                {
                    Modify();
                    _fInvoiceref = value;
                }
            }
        }

        private int? _fInvsaloffno;
        public int? Invsaloffno
        {
            get { return _fInvsaloffno; }
            set
            {
                if (_fInvsaloffno != value)
                {
                    Modify();
                    _fInvsaloffno = value;
                }
            }
        }

        private int? _fIsopenformore;
        public int? Isopenformore
        {
            get { return _fIsopenformore; }
            set
            {
                if (_fIsopenformore != value)
                {
                    Modify();
                    _fIsopenformore = value;
                }
            }
        }

        private int? _fLogonno;
        public int? Logonno
        {
            get { return _fLogonno; }
            set
            {
                if (_fLogonno != value)
                {
                    Modify();
                    _fLogonno = value;
                }
            }
        }

        private int? _fOrdertype;
        public int? Ordertype
        {
            get { return _fOrdertype; }
            set
            {
                if (_fOrdertype != value)
                {
                    Modify();
                    _fOrdertype = value;
                }
            }
        }

        private short? _fQcchecked;
        public short? Qcchecked
        {
            get { return _fQcchecked; }
            set
            {
                if (_fQcchecked != value)
                {
                    Modify();
                    _fQcchecked = value;
                }
            }
        }

        private int? _fQcnarrecno;
        public int? Qcnarrecno
        {
            get { return _fQcnarrecno; }
            set
            {
                if (_fQcnarrecno != value)
                {
                    Modify();
                    _fQcnarrecno = value;
                }
            }
        }

        private int? _fSupclarecno;
        public int? Supclarecno
        {
            get { return _fSupclarecno; }
            set
            {
                if (_fSupclarecno != value)
                {
                    Modify();
                    _fSupclarecno = value;
                }
            }
        }

        private int? _fTransferflg;
        public int? Transferflg
        {
            get { return _fTransferflg; }
            set
            {
                if (_fTransferflg != value)
                {
                    Modify();
                    _fTransferflg = value;
                }
            }
        }

        private int? _fTrnsaloffno;
        public int? Trnsaloffno
        {
            get { return _fTrnsaloffno; }
            set
            {
                if (_fTrnsaloffno != value)
                {
                    Modify();
                    _fTrnsaloffno = value;
                }
            }
        }

        private decimal? _fUserinppals;
        public decimal? Userinppals
        {
            get { return _fUserinppals; }
            set
            {
                if (_fUserinppals != value)
                {
                    Modify();
                    _fUserinppals = value;
                }
            }
        }

        public override int Key
        {
            get { return Dlvordno; }
            set { Dlvordno = value; }
        }

        public override string KeyAsString { get { return Key.ToString(CultureInfo.InvariantCulture); } }


        public override DELHED Clone()
        {
            var obj = new DELHED
                {
                    Dlvordno = Dlvordno,
                    Creditcontrolhold = Creditcontrolhold,
                    Delcredonholdval = Delcredonholdval,
                    Deltransprcmeth = Deltransprcmeth,
                    Dlvcomno = Dlvcomno,
                    Dlvcstsupno = Dlvcstsupno,
                    Dlvcurrecno = Dlvcurrecno,
                    Dlvdeldate = Dlvdeldate,
                    Dlvdltrecno = Dlvdltrecno,
                    Dlvediref = Dlvediref,
                    Dlvfaxsent = Dlvfaxsent,
                    Dlvhasopenprc = Dlvhasopenprc,
                    Dlvisdirect = Dlvisdirect,
                    Dlvismktsale = Dlvismktsale,
                    Dlvnotclosed = Dlvnotclosed,
                    Dlvordrecno = Dlvordrecno,
                    Dlvowncollection = Dlvowncollection,
                    Dlvpassed = Dlvpassed,
                    Dlvpodno = Dlvpodno,
                    Dlvprghedno = Dlvprghedno,
                    Dlvpriority = Dlvpriority,
                    Dlvprtstat = Dlvprtstat,
                    Dlvrelconfm = Dlvrelconfm,
                    Dlvrelinv = Dlvrelinv,
                    Dlvrthno = Dlvrthno,
                    Dlvsaloffno = Dlvsaloffno,
                    Dlvsaltyp = Dlvsaltyp,
                    Dlvshpdate = Dlvshpdate,
                    Dlvstkloc = Dlvstkloc,
                    Dlvtime = Dlvtime,
                    Dlvtranind = Dlvtranind,
                    Dlvtransconfdate = Dlvtransconfdate,
                    Dlvtransship = Dlvtransship,
                    Dlvtransshiptoloc = Dlvtransshiptoloc,
                    Dlvupddate = Dlvupddate,
                    Dlvupdtime = Dlvupdtime,
                    Hedsyscalcpals = Hedsyscalcpals,
                    Interdeptflag = Interdeptflag,
                    Invoiceref = Invoiceref,
                    Invsaloffno = Invsaloffno,
                    Isopenformore = Isopenformore,
                    Logonno = Logonno,
                    Ordertype = Ordertype,
                    Qcchecked = Qcchecked,
                    Qcnarrecno = Qcnarrecno,
                    Supclarecno = Supclarecno,
                    Transferflg = Transferflg,
                    Trnsaloffno = Trnsaloffno,
                    Userinppals = Userinppals,
                };

            return obj;
        }

        public static class FieldNames
        {
// ReSharper disable InconsistentNaming
            public const string  DLVORDNO = "DLVORDNO";
            public const string  CREDITCONTROLHOLD = "CREDITCONTROLHOLD";
            public const string  DELCREDONHOLDVAL = "DELCREDONHOLDVAL";
            public const string  DELTRANSPRCMETH = "DELTRANSPRCMETH";
            public const string  DLVCOMNO = "DLVCOMNO";
            public const string  DLVCSTSUPNO = "DLVCSTSUPNO";
            public const string  DLVCURRECNO = "DLVCURRECNO";
            public const string  DLVDELDATE = "DLVDELDATE";
            public const string  DLVDLTRECNO = "DLVDLTRECNO";
            public const string  DLVEDIREF = "DLVEDIREF";
            public const string  DLVFAXSENT = "DLVFAXSENT";
            public const string  DLVHASOPENPRC = "DLVHASOPENPRC";
            public const string  DLVISDIRECT = "DLVISDIRECT";
            public const string  DLVISMKTSALE = "DLVISMKTSALE";
            public const string  DLVNOTCLOSED = "DLVNOTCLOSED";
            public const string  DLVORDRECNO = "DLVORDRECNO";
            public const string  DLVOWNCOLLECTION = "DLVOWNCOLLECTION";
            public const string  DLVPASSED = "DLVPASSED";
            public const string  DLVPODNO = "DLVPODNO";
            public const string  DLVPRGHEDNO = "DLVPRGHEDNO";
            public const string  DLVPRIORITY = "DLVPRIORITY";
            public const string  DLVPRTSTAT = "DLVPRTSTAT";
            public const string  DLVRELCONFM = "DLVRELCONFM";
            public const string  DLVRELINV = "DLVRELINV";
            public const string  DLVRTHNO = "DLVRTHNO";
            public const string  DLVSALOFFNO = "DLVSALOFFNO";
            public const string  DLVSALTYP = "DLVSALTYP";
            public const string  DLVSHPDATE = "DLVSHPDATE";
            public const string  DLVSTKLOC = "DLVSTKLOC";
            public const string  DLVTIME = "DLVTIME";
            public const string  DLVTRANIND = "DLVTRANIND";
            public const string  DLVTRANSCONFDATE = "DLVTRANSCONFDATE";
            public const string  DLVTRANSSHIP = "DLVTRANSSHIP";
            public const string  DLVTRANSSHIPTOLOC = "DLVTRANSSHIPTOLOC";
            public const string  DLVUPDDATE = "DLVUPDDATE";
            public const string  DLVUPDTIME = "DLVUPDTIME";
            public const string  HEDSYSCALCPALS = "HEDSYSCALCPALS";
            public const string  INTERDEPTFLAG = "INTERDEPTFLAG";
            public const string  INVOICEREF = "INVOICEREF";
            public const string  INVSALOFFNO = "INVSALOFFNO";
            public const string  ISOPENFORMORE = "ISOPENFORMORE";
            public const string  LOGONNO = "LOGONNO";
            public const string  ORDERTYPE = "ORDERTYPE";
            public const string  QCCHECKED = "QCCHECKED";
            public const string  QCNARRECNO = "QCNARRECNO";
            public const string  SUPCLARECNO = "SUPCLARECNO";
            public const string  TRANSFERFLG = "TRANSFERFLG";
            public const string  TRNSALOFFNO = "TRNSALOFFNO";
            public const string  USERINPPALS = "USERINPPALS";
 // ReSharper restore InconsistentNaming
        }


    }

}
