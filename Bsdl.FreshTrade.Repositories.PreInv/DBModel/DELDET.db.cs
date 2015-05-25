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
    /// Entity for the DELDET table
    /// </summary>
    public partial class DELDET : BaseDbModel<DELDET, int>
    {
#region tableDefs

       public static List<EntityPropDef> GetPropDefs() {
         var result = new List<EntityPropDef>();

//EntityPropDef(string propName, string columnName, bool isKey, bool isNullable, string refEntityName, PropertyInfo keyPropInfo,
//            int size, int? prec, int? scale)



         result.Add(new EntityPropDef(
         PropertyHelper <DELDET>.GetProperty(x => x.Delrecno),
         "DELRECNO", // columnName
         true,                    //isKey
         false, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  10, // int? prec
                           0  // int? Scale
         ,
         typeof(DELDET)
       ));


         result.Add(new EntityPropDef(
         PropertyHelper <DELDET>.GetProperty(x => x.Delcltprdno),
         "DELCLTPRDNO", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         16,       // int size   
                  null, // int? prec
                   
         null // int? Scale
         ,
         typeof(DELDET)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <DELDET>.GetProperty(x => x.Delcomno),
         "DELCOMNO", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  10, // int? prec
                           0  // int? Scale
         ,
         typeof(DELDET)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <DELDET>.GetProperty(x => x.Deldlvordno),
         "DELDLVORDNO", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  10, // int? prec
                           0  // int? Scale
         ,
         typeof(DELDET)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <DELDET>.GetProperty(x => x.Delnettweight),
         "DELNETTWEIGHT", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  126, // int? prec
                   
         null // int? Scale
         ,
         typeof(DELDET)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <DELDET>.GetProperty(x => x.Delprcbywgt),
         "DELPRCBYWGT", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  1, // int? prec
                           0  // int? Scale
         ,
         typeof(DELDET)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <DELDET>.GetProperty(x => x.Delprcprdno),
         "DELPRCPRDNO", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  10, // int? prec
                           0  // int? Scale
         ,
         typeof(DELDET)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <DELDET>.GetProperty(x => x.Delpriceper),
         "DELPRICEPER", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  5, // int? prec
                           0  // int? Scale
         ,
         typeof(DELDET)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <DELDET>.GetProperty(x => x.Delqty),
         "DELQTY", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  10, // int? prec
                           0  // int? Scale
         ,
         typeof(DELDET)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <DELDET>.GetProperty(x => x.Delqtyper),
         "DELQTYPER", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  5, // int? prec
                           0  // int? Scale
         ,
         typeof(DELDET)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <DELDET>.GetProperty(x => x.Delsmnno),
         "DELSMNNO", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  5, // int? prec
                           0  // int? Scale
         ,
         typeof(DELDET)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <DELDET>.GetProperty(x => x.Delstatus),
         "DELSTATUS", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         3,       // int size   
                  null, // int? prec
                   
         null // int? Scale
         ,
         typeof(DELDET)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <DELDET>.GetProperty(x => x.Delstkstatus),
         "DELSTKSTATUS", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  5, // int? prec
                           0  // int? Scale
         ,
         typeof(DELDET)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <DELDET>.GetProperty(x => x.Delsupclarecno),
         "DELSUPCLARECNO", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  10, // int? prec
                           0  // int? Scale
         ,
         typeof(DELDET)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <DELDET>.GetProperty(x => x.Deltareweight),
         "DELTAREWEIGHT", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  126, // int? prec
                   
         null // int? Scale
         ,
         typeof(DELDET)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <DELDET>.GetProperty(x => x.Delupdpikqty),
         "DELUPDPIKQTY", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  10, // int? prec
                           0  // int? Scale
         ,
         typeof(DELDET)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <DELDET>.GetProperty(x => x.Delweight),
         "DELWEIGHT", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  126, // int? prec
                   
         null // int? Scale
         ,
         typeof(DELDET)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <DELDET>.GetProperty(x => x.Detsyscalcpals),
         "DETSYSCALCPALS", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  126, // int? prec
                   
         null // int? Scale
         ,
         typeof(DELDET)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <DELDET>.GetProperty(x => x.Dlvprtstat),
         "DLVPRTSTAT", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  5, // int? prec
                           0  // int? Scale
         ,
         typeof(DELDET)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <DELDET>.GetProperty(x => x.Edilineno),
         "EDILINENO", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  10, // int? prec
                           0  // int? Scale
         ,
         typeof(DELDET)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <DELDET>.GetProperty(x => x.Ppccltrecno),
         "PPCCLTRECNO", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  10, // int? prec
                           0  // int? Scale
         ,
         typeof(DELDET)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <DELDET>.GetProperty(x => x.Prllineno),
         "PRLLINENO", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  10, // int? prec
                           0  // int? Scale
         ,
         typeof(DELDET)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <DELDET>.GetProperty(x => x.Prllinno),
         "PRLLINNO", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  10, // int? prec
                           0  // int? Scale
         ,
         typeof(DELDET)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <DELDET>.GetProperty(x => x.Profileheadrecno),
         "PROFILEHEADRECNO", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  10, // int? prec
                           0  // int? Scale
         ,
         typeof(DELDET)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <DELDET>.GetProperty(x => x.Prtstat),
         "PRTSTAT", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  5, // int? prec
                           0  // int? Scale
         ,
         typeof(DELDET)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <DELDET>.GetProperty(x => x.Qtyper),
         "QTYPER", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  5, // int? prec
                           0  // int? Scale
         ,
         typeof(DELDET)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <DELDET>.GetProperty(x => x.Rndapportpals),
         "RNDAPPORTPALS", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  126, // int? prec
                   
         null // int? Scale
         ,
         typeof(DELDET)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <DELDET>.GetProperty(x => x.Userdetinppals),
         "USERDETINPPALS", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  126, // int? prec
                   
         null // int? Scale
         ,
         typeof(DELDET)
         ));
         return result; 
       }

#endregion     
        private int _fDelrecno;
        public int Delrecno
        {
            get { return _fDelrecno; }
            set
            {
                var oldKey = Key;
                if (_fDelrecno != value)
                {
                    Modify();
                    _fDelrecno = value;
                    KeyChanged(oldKey);
                }
            }
        }

        private string _fDelcltprdno;
        public string Delcltprdno
        {
            get { return _fDelcltprdno; }
            set
            {
                if (_fDelcltprdno != value)
                {
                    Modify();
                    _fDelcltprdno = value;
                }
            }
        }

        private int? _fDelcomno;
        public int? Delcomno
        {
            get { return _fDelcomno; }
            set
            {
                if (_fDelcomno != value)
                {
                    Modify();
                    _fDelcomno = value;
                }
            }
        }

        private int? _fDeldlvordno;
        public int? Deldlvordno
        {
            get { return _fDeldlvordno; }
            set
            {
                if (_fDeldlvordno != value)
                {
                    Modify();
                    _fDeldlvordno = value;
                }
            }
        }

        private decimal? _fDelnettweight;
        public decimal? Delnettweight
        {
            get { return _fDelnettweight; }
            set
            {
                if (_fDelnettweight != value)
                {
                    Modify();
                    _fDelnettweight = value;
                }
            }
        }

        private short? _fDelprcbywgt;
        public short? Delprcbywgt
        {
            get { return _fDelprcbywgt; }
            set
            {
                if (_fDelprcbywgt != value)
                {
                    Modify();
                    _fDelprcbywgt = value;
                }
            }
        }

        private int? _fDelprcprdno;
        public int? Delprcprdno
        {
            get { return _fDelprcprdno; }
            set
            {
                if (_fDelprcprdno != value)
                {
                    Modify();
                    _fDelprcprdno = value;
                }
            }
        }

        private int? _fDelpriceper;
        public int? Delpriceper
        {
            get { return _fDelpriceper; }
            set
            {
                if (_fDelpriceper != value)
                {
                    Modify();
                    _fDelpriceper = value;
                }
            }
        }

        private int? _fDelqty;
        public int? Delqty
        {
            get { return _fDelqty; }
            set
            {
                if (_fDelqty != value)
                {
                    Modify();
                    _fDelqty = value;
                }
            }
        }

        private int? _fDelqtyper;
        public int? Delqtyper
        {
            get { return _fDelqtyper; }
            set
            {
                if (_fDelqtyper != value)
                {
                    Modify();
                    _fDelqtyper = value;
                }
            }
        }

        private int? _fDelsmnno;
        public int? Delsmnno
        {
            get { return _fDelsmnno; }
            set
            {
                if (_fDelsmnno != value)
                {
                    Modify();
                    _fDelsmnno = value;
                }
            }
        }

        private string _fDelstatus;
        public string Delstatus
        {
            get { return _fDelstatus; }
            set
            {
                if (_fDelstatus != value)
                {
                    Modify();
                    _fDelstatus = value;
                }
            }
        }

        private int? _fDelstkstatus;
        public int? Delstkstatus
        {
            get { return _fDelstkstatus; }
            set
            {
                if (_fDelstkstatus != value)
                {
                    Modify();
                    _fDelstkstatus = value;
                }
            }
        }

        private int? _fDelsupclarecno;
        public int? Delsupclarecno
        {
            get { return _fDelsupclarecno; }
            set
            {
                if (_fDelsupclarecno != value)
                {
                    Modify();
                    _fDelsupclarecno = value;
                }
            }
        }

        private decimal? _fDeltareweight;
        public decimal? Deltareweight
        {
            get { return _fDeltareweight; }
            set
            {
                if (_fDeltareweight != value)
                {
                    Modify();
                    _fDeltareweight = value;
                }
            }
        }

        private int? _fDelupdpikqty;
        public int? Delupdpikqty
        {
            get { return _fDelupdpikqty; }
            set
            {
                if (_fDelupdpikqty != value)
                {
                    Modify();
                    _fDelupdpikqty = value;
                }
            }
        }

        private decimal? _fDelweight;
        public decimal? Delweight
        {
            get { return _fDelweight; }
            set
            {
                if (_fDelweight != value)
                {
                    Modify();
                    _fDelweight = value;
                }
            }
        }

        private decimal? _fDetsyscalcpals;
        public decimal? Detsyscalcpals
        {
            get { return _fDetsyscalcpals; }
            set
            {
                if (_fDetsyscalcpals != value)
                {
                    Modify();
                    _fDetsyscalcpals = value;
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

        private int? _fEdilineno;
        public int? Edilineno
        {
            get { return _fEdilineno; }
            set
            {
                if (_fEdilineno != value)
                {
                    Modify();
                    _fEdilineno = value;
                }
            }
        }

        private int? _fPpccltrecno;
        /// <summary>
        /// LINK TO THE PRCCSTINFO TABLE TO GIVE THE CLIENT PRODUCT DETAILS
        /// </summary>
        public int? Ppccltrecno
        {
            get { return _fPpccltrecno; }
            set
            {
                if (_fPpccltrecno != value)
                {
                    Modify();
                    _fPpccltrecno = value;
                }
            }
        }

        private int? _fPrllineno;
        /// <summary>
        /// LINK TO THE PRCNEWLIST TABLE TO GIVE THE PRICE LIST RECORD
        /// </summary>
        public int? Prllineno
        {
            get { return _fPrllineno; }
            set
            {
                if (_fPrllineno != value)
                {
                    Modify();
                    _fPrllineno = value;
                }
            }
        }

        private int? _fPrllinno;
        public int? Prllinno
        {
            get { return _fPrllinno; }
            set
            {
                if (_fPrllinno != value)
                {
                    Modify();
                    _fPrllinno = value;
                }
            }
        }

        private int? _fProfileheadrecno;
        /// <summary>
        /// LINK TO THE PRICELISTPROFILEHEAD TABLE TO GIVE THE PROFILE PRICE
        /// </summary>
        public int? Profileheadrecno
        {
            get { return _fProfileheadrecno; }
            set
            {
                if (_fProfileheadrecno != value)
                {
                    Modify();
                    _fProfileheadrecno = value;
                }
            }
        }

        private int? _fPrtstat;
        public int? Prtstat
        {
            get { return _fPrtstat; }
            set
            {
                if (_fPrtstat != value)
                {
                    Modify();
                    _fPrtstat = value;
                }
            }
        }

        private int? _fQtyper;
        public int? Qtyper
        {
            get { return _fQtyper; }
            set
            {
                if (_fQtyper != value)
                {
                    Modify();
                    _fQtyper = value;
                }
            }
        }

        private decimal? _fRndapportpals;
        public decimal? Rndapportpals
        {
            get { return _fRndapportpals; }
            set
            {
                if (_fRndapportpals != value)
                {
                    Modify();
                    _fRndapportpals = value;
                }
            }
        }

        private decimal? _fUserdetinppals;
        public decimal? Userdetinppals
        {
            get { return _fUserdetinppals; }
            set
            {
                if (_fUserdetinppals != value)
                {
                    Modify();
                    _fUserdetinppals = value;
                }
            }
        }

        public override int Key
        {
            get { return Delrecno; }
            set { Delrecno = value; }
        }

        public override string KeyAsString { get { return Key.ToString(CultureInfo.InvariantCulture); } }


        public override DELDET Clone()
        {
            var obj = new DELDET
                {
                    Delrecno = Delrecno,
                    Delcltprdno = Delcltprdno,
                    Delcomno = Delcomno,
                    Deldlvordno = Deldlvordno,
                    Delnettweight = Delnettweight,
                    Delprcbywgt = Delprcbywgt,
                    Delprcprdno = Delprcprdno,
                    Delpriceper = Delpriceper,
                    Delqty = Delqty,
                    Delqtyper = Delqtyper,
                    Delsmnno = Delsmnno,
                    Delstatus = Delstatus,
                    Delstkstatus = Delstkstatus,
                    Delsupclarecno = Delsupclarecno,
                    Deltareweight = Deltareweight,
                    Delupdpikqty = Delupdpikqty,
                    Delweight = Delweight,
                    Detsyscalcpals = Detsyscalcpals,
                    Dlvprtstat = Dlvprtstat,
                    Edilineno = Edilineno,
                    Ppccltrecno = Ppccltrecno,
                    Prllineno = Prllineno,
                    Prllinno = Prllinno,
                    Profileheadrecno = Profileheadrecno,
                    Prtstat = Prtstat,
                    Qtyper = Qtyper,
                    Rndapportpals = Rndapportpals,
                    Userdetinppals = Userdetinppals,
                };

            return obj;
        }

        public static class FieldNames
        {
// ReSharper disable InconsistentNaming
            public const string  DELRECNO = "DELRECNO";
            public const string  DELCLTPRDNO = "DELCLTPRDNO";
            public const string  DELCOMNO = "DELCOMNO";
            public const string  DELDLVORDNO = "DELDLVORDNO";
            public const string  DELNETTWEIGHT = "DELNETTWEIGHT";
            public const string  DELPRCBYWGT = "DELPRCBYWGT";
            public const string  DELPRCPRDNO = "DELPRCPRDNO";
            public const string  DELPRICEPER = "DELPRICEPER";
            public const string  DELQTY = "DELQTY";
            public const string  DELQTYPER = "DELQTYPER";
            public const string  DELSMNNO = "DELSMNNO";
            public const string  DELSTATUS = "DELSTATUS";
            public const string  DELSTKSTATUS = "DELSTKSTATUS";
            public const string  DELSUPCLARECNO = "DELSUPCLARECNO";
            public const string  DELTAREWEIGHT = "DELTAREWEIGHT";
            public const string  DELUPDPIKQTY = "DELUPDPIKQTY";
            public const string  DELWEIGHT = "DELWEIGHT";
            public const string  DETSYSCALCPALS = "DETSYSCALCPALS";
            public const string  DLVPRTSTAT = "DLVPRTSTAT";
            public const string  EDILINENO = "EDILINENO";
            public const string  PPCCLTRECNO = "PPCCLTRECNO";
            public const string  PRLLINENO = "PRLLINENO";
            public const string  PRLLINNO = "PRLLINNO";
            public const string  PROFILEHEADRECNO = "PROFILEHEADRECNO";
            public const string  PRTSTAT = "PRTSTAT";
            public const string  QTYPER = "QTYPER";
            public const string  RNDAPPORTPALS = "RNDAPPORTPALS";
            public const string  USERDETINPPALS = "USERDETINPPALS";
 // ReSharper restore InconsistentNaming
        }


    }

}
