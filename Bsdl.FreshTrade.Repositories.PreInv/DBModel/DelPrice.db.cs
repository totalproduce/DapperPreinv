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
    /// Entity for the DELPRICE table
    /// </summary>
    public partial class DelPrice : BaseDbModel<DelPrice, int>
    {
#region tableDefs

       public static List<EntityPropDef> GetPropDefs() {
         var result = new List<EntityPropDef>();

//EntityPropDef(string propName, string columnName, bool isKey, bool isNullable, string refEntityName, PropertyInfo keyPropInfo,
//            int size, int? prec, int? scale)



         result.Add(new EntityPropDef(
         PropertyHelper <DelPrice>.GetProperty(x => x.Dprrecno),
         "DPRRECNO", // columnName
         true,                    //isKey
         false, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  10, // int? prec
                           0  // int? Scale
         ,
         typeof(DelPrice)
       ));


         result.Add(new EntityPropDef(
         PropertyHelper <DelPrice>.GetProperty(x => x.Adjby),
         "ADJBY", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  5, // int? prec
                           0  // int? Scale
         ,
         typeof(DelPrice)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <DelPrice>.GetProperty(x => x.Delallwkrecno),
         "DELALLWKRECNO", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  10, // int? prec
                           0  // int? Scale
         ,
         typeof(DelPrice)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <DelPrice>.GetProperty(x => x.Delbasenettval),
         "DELBASENETTVAL", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  126, // int? prec
                   
         null // int? Scale
         ,
         typeof(DelPrice)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <DelPrice>.GetProperty(x => x.Delbasevatvalue),
         "DELBASEVATVALUE", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  126, // int? prec
                   
         null // int? Scale
         ,
         typeof(DelPrice)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <DelPrice>.GetProperty(x => x.Deleuronettval),
         "DELEURONETTVAL", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  126, // int? prec
                   
         null // int? Scale
         ,
         typeof(DelPrice)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <DelPrice>.GetProperty(x => x.Deleurovatvalue),
         "DELEUROVATVALUE", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  126, // int? prec
                   
         null // int? Scale
         ,
         typeof(DelPrice)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <DelPrice>.GetProperty(x => x.Delfreeofchg),
         "DELFREEOFCHG", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  1, // int? prec
                           0  // int? Scale
         ,
         typeof(DelPrice)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <DelPrice>.GetProperty(x => x.Delinvrecno),
         "DELINVRECNO", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  10, // int? prec
                           0  // int? Scale
         ,
         typeof(DelPrice)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <DelPrice>.GetProperty(x => x.Delinvstatus),
         "DELINVSTATUS", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  5, // int? prec
                           0  // int? Scale
         ,
         typeof(DelPrice)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <DelPrice>.GetProperty(x => x.Delisguideprice),
         "DELISGUIDEPRICE", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  1, // int? prec
                           0  // int? Scale
         ,
         typeof(DelPrice)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <DelPrice>.GetProperty(x => x.Delnettvalue),
         "DELNETTVALUE", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  126, // int? prec
                   
         null // int? Scale
         ,
         typeof(DelPrice)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <DelPrice>.GetProperty(x => x.Delprccomno),
         "DELPRCCOMNO", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  10, // int? prec
                           0  // int? Scale
         ,
         typeof(DelPrice)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <DelPrice>.GetProperty(x => x.Delprcqty),
         "DELPRCQTY", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  10, // int? prec
                           0  // int? Scale
         ,
         typeof(DelPrice)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <DelPrice>.GetProperty(x => x.Delprcweight),
         "DELPRCWEIGHT", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  126, // int? prec
                   
         null // int? Scale
         ,
         typeof(DelPrice)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <DelPrice>.GetProperty(x => x.Delprice),
         "DELPRICE", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  126, // int? prec
                   
         null // int? Scale
         ,
         typeof(DelPrice)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <DelPrice>.GetProperty(x => x.Delretailprice),
         "DELRETAILPRICE", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  126, // int? prec
                   
         null // int? Scale
         ,
         typeof(DelPrice)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <DelPrice>.GetProperty(x => x.Deltobaserate),
         "DELTOBASERATE", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  126, // int? prec
                   
         null // int? Scale
         ,
         typeof(DelPrice)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <DelPrice>.GetProperty(x => x.Deltoeurorate),
         "DELTOEURORATE", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  126, // int? prec
                   
         null // int? Scale
         ,
         typeof(DelPrice)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <DelPrice>.GetProperty(x => x.Deltriangulate),
         "DELTRIANGULATE", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  1, // int? prec
                           0  // int? Scale
         ,
         typeof(DelPrice)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <DelPrice>.GetProperty(x => x.Delvatrate),
         "DELVATRATE", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  126, // int? prec
                   
         null // int? Scale
         ,
         typeof(DelPrice)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <DelPrice>.GetProperty(x => x.Delvatrate2),
         "DELVATRATE2", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  126, // int? prec
                   
         null // int? Scale
         ,
         typeof(DelPrice)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <DelPrice>.GetProperty(x => x.Delvatrecno),
         "DELVATRECNO", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  5, // int? prec
                           0  // int? Scale
         ,
         typeof(DelPrice)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <DelPrice>.GetProperty(x => x.Delvatvalue),
         "DELVATVALUE", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  126, // int? prec
                   
         null // int? Scale
         ,
         typeof(DelPrice)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <DelPrice>.GetProperty(x => x.Dprcdtrefno),
         "DPRCDTREFNO", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  10, // int? prec
                           0  // int? Scale
         ,
         typeof(DelPrice)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <DelPrice>.GetProperty(x => x.Dprcreationdate),
         "DPRCREATIONDATE", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  null, // int? prec
                   
         null // int? Scale
         ,
         typeof(DelPrice)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <DelPrice>.GetProperty(x => x.Dprdelrecno),
         "DPRDELRECNO", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  10, // int? prec
                           0  // int? Scale
         ,
         typeof(DelPrice)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <DelPrice>.GetProperty(x => x.Dprisprcccdtdbt),
         "DPRISPRCCCDTDBT", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  1, // int? prec
                           0  // int? Scale
         ,
         typeof(DelPrice)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <DelPrice>.GetProperty(x => x.Dprispriceadjonly),
         "DPRISPRICEADJONLY", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  1, // int? prec
                           0  // int? Scale
         ,
         typeof(DelPrice)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <DelPrice>.GetProperty(x => x.Dprmanwgtchg),
         "DPRMANWGTCHG", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  1, // int? prec
                           0  // int? Scale
         ,
         typeof(DelPrice)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <DelPrice>.GetProperty(x => x.Dprnominalprice),
         "DPRNOMINALPRICE", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  126, // int? prec
                   
         null // int? Scale
         ,
         typeof(DelPrice)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <DelPrice>.GetProperty(x => x.Dprpreas),
         "DPRPREAS", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         2,       // int size   
                  null, // int? prec
                   
         null // int? Scale
         ,
         typeof(DelPrice)
         ));
         return result; 
       }

#endregion     
        private int _fDprrecno;
        public int Dprrecno
        {
            get { return _fDprrecno; }
            set
            {
                var oldKey = Key;
                if (_fDprrecno != value)
                {
                    Modify();
                    _fDprrecno = value;
                    KeyChanged(oldKey);
                }
            }
        }

        private int? _fAdjby;
        public int? Adjby
        {
            get { return _fAdjby; }
            set
            {
                if (_fAdjby != value)
                {
                    Modify();
                    _fAdjby = value;
                }
            }
        }

        private int? _fDelallwkrecno;
        public int? Delallwkrecno
        {
            get { return _fDelallwkrecno; }
            set
            {
                if (_fDelallwkrecno != value)
                {
                    Modify();
                    _fDelallwkrecno = value;
                }
            }
        }

        private decimal? _fDelbasenettval;
        public decimal? Delbasenettval
        {
            get { return _fDelbasenettval; }
            set
            {
                if (_fDelbasenettval != value)
                {
                    Modify();
                    _fDelbasenettval = value;
                }
            }
        }

        private decimal? _fDelbasevatvalue;
        public decimal? Delbasevatvalue
        {
            get { return _fDelbasevatvalue; }
            set
            {
                if (_fDelbasevatvalue != value)
                {
                    Modify();
                    _fDelbasevatvalue = value;
                }
            }
        }

        private decimal? _fDeleuronettval;
        public decimal? Deleuronettval
        {
            get { return _fDeleuronettval; }
            set
            {
                if (_fDeleuronettval != value)
                {
                    Modify();
                    _fDeleuronettval = value;
                }
            }
        }

        private decimal? _fDeleurovatvalue;
        public decimal? Deleurovatvalue
        {
            get { return _fDeleurovatvalue; }
            set
            {
                if (_fDeleurovatvalue != value)
                {
                    Modify();
                    _fDeleurovatvalue = value;
                }
            }
        }

        private short? _fDelfreeofchg;
        public short? Delfreeofchg
        {
            get { return _fDelfreeofchg; }
            set
            {
                if (_fDelfreeofchg != value)
                {
                    Modify();
                    _fDelfreeofchg = value;
                }
            }
        }

        private int? _fDelinvrecno;
        public int? Delinvrecno
        {
            get { return _fDelinvrecno; }
            set
            {
                if (_fDelinvrecno != value)
                {
                    Modify();
                    _fDelinvrecno = value;
                }
            }
        }

        private int? _fDelinvstatus;
        public int? Delinvstatus
        {
            get { return _fDelinvstatus; }
            set
            {
                if (_fDelinvstatus != value)
                {
                    Modify();
                    _fDelinvstatus = value;
                }
            }
        }

        private short? _fDelisguideprice;
        public short? Delisguideprice
        {
            get { return _fDelisguideprice; }
            set
            {
                if (_fDelisguideprice != value)
                {
                    Modify();
                    _fDelisguideprice = value;
                }
            }
        }

        private decimal? _fDelnettvalue;
        public decimal? Delnettvalue
        {
            get { return _fDelnettvalue; }
            set
            {
                if (_fDelnettvalue != value)
                {
                    Modify();
                    _fDelnettvalue = value;
                }
            }
        }

        private int? _fDelprccomno;
        public int? Delprccomno
        {
            get { return _fDelprccomno; }
            set
            {
                if (_fDelprccomno != value)
                {
                    Modify();
                    _fDelprccomno = value;
                }
            }
        }

        private int? _fDelprcqty;
        public int? Delprcqty
        {
            get { return _fDelprcqty; }
            set
            {
                if (_fDelprcqty != value)
                {
                    Modify();
                    _fDelprcqty = value;
                }
            }
        }

        private decimal? _fDelprcweight;
        public decimal? Delprcweight
        {
            get { return _fDelprcweight; }
            set
            {
                if (_fDelprcweight != value)
                {
                    Modify();
                    _fDelprcweight = value;
                }
            }
        }

        private decimal? _fDelprice;
        public decimal? Delprice
        {
            get { return _fDelprice; }
            set
            {
                if (_fDelprice != value)
                {
                    Modify();
                    _fDelprice = value;
                }
            }
        }

        private decimal? _fDelretailprice;
        public decimal? Delretailprice
        {
            get { return _fDelretailprice; }
            set
            {
                if (_fDelretailprice != value)
                {
                    Modify();
                    _fDelretailprice = value;
                }
            }
        }

        private decimal? _fDeltobaserate;
        public decimal? Deltobaserate
        {
            get { return _fDeltobaserate; }
            set
            {
                if (_fDeltobaserate != value)
                {
                    Modify();
                    _fDeltobaserate = value;
                }
            }
        }

        private decimal? _fDeltoeurorate;
        public decimal? Deltoeurorate
        {
            get { return _fDeltoeurorate; }
            set
            {
                if (_fDeltoeurorate != value)
                {
                    Modify();
                    _fDeltoeurorate = value;
                }
            }
        }

        private short? _fDeltriangulate;
        public short? Deltriangulate
        {
            get { return _fDeltriangulate; }
            set
            {
                if (_fDeltriangulate != value)
                {
                    Modify();
                    _fDeltriangulate = value;
                }
            }
        }

        private decimal? _fDelvatrate;
        public decimal? Delvatrate
        {
            get { return _fDelvatrate; }
            set
            {
                if (_fDelvatrate != value)
                {
                    Modify();
                    _fDelvatrate = value;
                }
            }
        }

        private decimal? _fDelvatrate2;
        public decimal? Delvatrate2
        {
            get { return _fDelvatrate2; }
            set
            {
                if (_fDelvatrate2 != value)
                {
                    Modify();
                    _fDelvatrate2 = value;
                }
            }
        }

        private int? _fDelvatrecno;
        public int? Delvatrecno
        {
            get { return _fDelvatrecno; }
            set
            {
                if (_fDelvatrecno != value)
                {
                    Modify();
                    _fDelvatrecno = value;
                }
            }
        }

        private decimal? _fDelvatvalue;
        public decimal? Delvatvalue
        {
            get { return _fDelvatvalue; }
            set
            {
                if (_fDelvatvalue != value)
                {
                    Modify();
                    _fDelvatvalue = value;
                }
            }
        }

        private int? _fDprcdtrefno;
        /// <summary>
        /// The credit reference. Foreign Key - DELPRICE_CREDITREF
        /// </summary>
        public int? Dprcdtrefno
        {
            get { return _fDprcdtrefno; }
            set
            {
                if (_fDprcdtrefno != value)
                {
                    Modify();
                    _fDprcdtrefno = value;
                }
            }
        }

        private DateTime? _fDprcreationdate;
        public DateTime? Dprcreationdate
        {
            get { return _fDprcreationdate; }
            set
            {
                if (_fDprcreationdate != value)
                {
                    Modify();
                    _fDprcreationdate = value;
                }
            }
        }

        private int? _fDprdelrecno;
        public int? Dprdelrecno
        {
            get { return _fDprdelrecno; }
            set
            {
                if (_fDprdelrecno != value)
                {
                    Modify();
                    _fDprdelrecno = value;
                }
            }
        }

        private short? _fDprisprcccdtdbt;
        public short? Dprisprcccdtdbt
        {
            get { return _fDprisprcccdtdbt; }
            set
            {
                if (_fDprisprcccdtdbt != value)
                {
                    Modify();
                    _fDprisprcccdtdbt = value;
                }
            }
        }

        private short? _fDprispriceadjonly;
        public short? Dprispriceadjonly
        {
            get { return _fDprispriceadjonly; }
            set
            {
                if (_fDprispriceadjonly != value)
                {
                    Modify();
                    _fDprispriceadjonly = value;
                }
            }
        }

        private short? _fDprmanwgtchg;
        public short? Dprmanwgtchg
        {
            get { return _fDprmanwgtchg; }
            set
            {
                if (_fDprmanwgtchg != value)
                {
                    Modify();
                    _fDprmanwgtchg = value;
                }
            }
        }

        private decimal? _fDprnominalprice;
        public decimal? Dprnominalprice
        {
            get { return _fDprnominalprice; }
            set
            {
                if (_fDprnominalprice != value)
                {
                    Modify();
                    _fDprnominalprice = value;
                }
            }
        }

        private string _fDprpreas;
        public string Dprpreas
        {
            get { return _fDprpreas; }
            set
            {
                if (_fDprpreas != value)
                {
                    Modify();
                    _fDprpreas = value;
                }
            }
        }

        public override int Key
        {
            get { return Dprrecno; }
            set { Dprrecno = value; }
        }

        public override string KeyAsString { get { return Key.ToString(CultureInfo.InvariantCulture); } }


        public override DelPrice Clone()
        {
            var obj = new DelPrice
                {
                    Dprrecno = Dprrecno,
                    Adjby = Adjby,
                    Delallwkrecno = Delallwkrecno,
                    Delbasenettval = Delbasenettval,
                    Delbasevatvalue = Delbasevatvalue,
                    Deleuronettval = Deleuronettval,
                    Deleurovatvalue = Deleurovatvalue,
                    Delfreeofchg = Delfreeofchg,
                    Delinvrecno = Delinvrecno,
                    Delinvstatus = Delinvstatus,
                    Delisguideprice = Delisguideprice,
                    Delnettvalue = Delnettvalue,
                    Delprccomno = Delprccomno,
                    Delprcqty = Delprcqty,
                    Delprcweight = Delprcweight,
                    Delprice = Delprice,
                    Delretailprice = Delretailprice,
                    Deltobaserate = Deltobaserate,
                    Deltoeurorate = Deltoeurorate,
                    Deltriangulate = Deltriangulate,
                    Delvatrate = Delvatrate,
                    Delvatrate2 = Delvatrate2,
                    Delvatrecno = Delvatrecno,
                    Delvatvalue = Delvatvalue,
                    Dprcdtrefno = Dprcdtrefno,
                    Dprcreationdate = Dprcreationdate,
                    Dprdelrecno = Dprdelrecno,
                    Dprisprcccdtdbt = Dprisprcccdtdbt,
                    Dprispriceadjonly = Dprispriceadjonly,
                    Dprmanwgtchg = Dprmanwgtchg,
                    Dprnominalprice = Dprnominalprice,
                    Dprpreas = Dprpreas,
                };

            return obj;
        }

        public static class FieldNames
        {
// ReSharper disable InconsistentNaming
            public const string  DPRRECNO = "DPRRECNO";
            public const string  ADJBY = "ADJBY";
            public const string  DELALLWKRECNO = "DELALLWKRECNO";
            public const string  DELBASENETTVAL = "DELBASENETTVAL";
            public const string  DELBASEVATVALUE = "DELBASEVATVALUE";
            public const string  DELEURONETTVAL = "DELEURONETTVAL";
            public const string  DELEUROVATVALUE = "DELEUROVATVALUE";
            public const string  DELFREEOFCHG = "DELFREEOFCHG";
            public const string  DELINVRECNO = "DELINVRECNO";
            public const string  DELINVSTATUS = "DELINVSTATUS";
            public const string  DELISGUIDEPRICE = "DELISGUIDEPRICE";
            public const string  DELNETTVALUE = "DELNETTVALUE";
            public const string  DELPRCCOMNO = "DELPRCCOMNO";
            public const string  DELPRCQTY = "DELPRCQTY";
            public const string  DELPRCWEIGHT = "DELPRCWEIGHT";
            public const string  DELPRICE = "DELPRICE";
            public const string  DELRETAILPRICE = "DELRETAILPRICE";
            public const string  DELTOBASERATE = "DELTOBASERATE";
            public const string  DELTOEURORATE = "DELTOEURORATE";
            public const string  DELTRIANGULATE = "DELTRIANGULATE";
            public const string  DELVATRATE = "DELVATRATE";
            public const string  DELVATRATE2 = "DELVATRATE2";
            public const string  DELVATRECNO = "DELVATRECNO";
            public const string  DELVATVALUE = "DELVATVALUE";
            public const string  DPRCDTREFNO = "DPRCDTREFNO";
            public const string  DPRCREATIONDATE = "DPRCREATIONDATE";
            public const string  DPRDELRECNO = "DPRDELRECNO";
            public const string  DPRISPRCCCDTDBT = "DPRISPRCCCDTDBT";
            public const string  DPRISPRICEADJONLY = "DPRISPRICEADJONLY";
            public const string  DPRMANWGTCHG = "DPRMANWGTCHG";
            public const string  DPRNOMINALPRICE = "DPRNOMINALPRICE";
            public const string  DPRPREAS = "DPRPREAS";
 // ReSharper restore InconsistentNaming
        }


    }

}
