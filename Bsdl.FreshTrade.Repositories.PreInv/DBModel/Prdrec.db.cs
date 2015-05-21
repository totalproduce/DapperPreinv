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
    /// Entity for the PRDREC table
    /// </summary>
    public partial class Prdrec : BaseDbModel<Prdrec, int>
    {
#region tableDefs

       public static List<EntityPropDef> GetPropDefs() {
         var result = new List<EntityPropDef>();

//EntityPropDef(string propName, string columnName, bool isKey, bool isNullable, string refEntityName, PropertyInfo keyPropInfo,
//            int size, int? prec, int? scale)



         result.Add(new EntityPropDef(
         PropertyHelper <Prdrec>.GetProperty(x => x.Prcprdno),
         "PRCPRDNO", // columnName
         true,                    //isKey
         false, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  10, // int? prec
                           0  // int? Scale
         ,
         typeof(Prdrec)
       ));


         result.Add(new EntityPropDef(
         PropertyHelper <Prdrec>.GetProperty(x => x.Active),
         "ACTIVE", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  1, // int? prec
                           0  // int? Scale
         ,
         typeof(Prdrec)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <Prdrec>.GetProperty(x => x.Defaultprd),
         "DEFAULTPRD", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  1, // int? prec
                           0  // int? Scale
         ,
         typeof(Prdrec)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <Prdrec>.GetProperty(x => x.Gtin),
         "GTIN", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         13,       // int size   
                  null, // int? prec
                   
         null // int? Scale
         ,
         typeof(Prdrec)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <Prdrec>.GetProperty(x => x.Gtinchecksum),
         "GTINCHECKSUM", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         1,       // int size   
                  null, // int? prec
                   
         null // int? Scale
         ,
         typeof(Prdrec)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <Prdrec>.GetProperty(x => x.Innerqty),
         "INNERQTY", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  10, // int? prec
                           0  // int? Scale
         ,
         typeof(Prdrec)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <Prdrec>.GetProperty(x => x.Innertype),
         "INNERTYPE", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         10,       // int size   
                  null, // int? prec
                   
         null // int? Scale
         ,
         typeof(Prdrec)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <Prdrec>.GetProperty(x => x.Ismiscprod),
         "ISMISCPROD", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  1, // int? prec
                           0  // int? Scale
         ,
         typeof(Prdrec)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <Prdrec>.GetProperty(x => x.Istradesalesprd),
         "ISTRADESALESPRD", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  1, // int? prec
                           0  // int? Scale
         ,
         typeof(Prdrec)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <Prdrec>.GetProperty(x => x.Maxprcpacpal),
         "MAXPRCPACPAL", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  5, // int? prec
                           0  // int? Scale
         ,
         typeof(Prdrec)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <Prdrec>.GetProperty(x => x.Maxprcweight),
         "MAXPRCWEIGHT", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  126, // int? prec
                   
         null // int? Scale
         ,
         typeof(Prdrec)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <Prdrec>.GetProperty(x => x.Orderupliftperc),
         "ORDERUPLIFTPERC", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  5, // int? prec
                           0  // int? Scale
         ,
         typeof(Prdrec)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <Prdrec>.GetProperty(x => x.Packitemno),
         "PACKITEMNO", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  10, // int? prec
                           0  // int? Scale
         ,
         typeof(Prdrec)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <Prdrec>.GetProperty(x => x.Palpanrecno),
         "PALPANRECNO", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  10, // int? prec
                           0  // int? Scale
         ,
         typeof(Prdrec)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <Prdrec>.GetProperty(x => x.Panrecnoinnertype),
         "PANRECNOINNERTYPE", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  10, // int? prec
                           0  // int? Scale
         ,
         typeof(Prdrec)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <Prdrec>.GetProperty(x => x.Prcbaseprice),
         "PRCBASEPRICE", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         1,       // int size   
                  null, // int? prec
                   
         null // int? Scale
         ,
         typeof(Prdrec)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <Prdrec>.GetProperty(x => x.Prcboxqty),
         "PRCBOXQTY", // columnName
         false,                    //isKey
         false, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  5, // int? prec
                           0  // int? Scale
         ,
         typeof(Prdrec)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <Prdrec>.GetProperty(x => x.Prcchgmult),
         "PRCCHGMULT", // columnName
         false,                    //isKey
         false, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  126, // int? prec
                   
         null // int? Scale
         ,
         typeof(Prdrec)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <Prdrec>.GetProperty(x => x.Prcdescchg),
         "PRCDESCCHG", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  1, // int? prec
                           0  // int? Scale
         ,
         typeof(Prdrec)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <Prdrec>.GetProperty(x => x.Prcdescription),
         "PRCDESCRIPTION", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         50,       // int size   
                  null, // int? prec
                   
         null // int? Scale
         ,
         typeof(Prdrec)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <Prdrec>.GetProperty(x => x.Prcglbrecno),
         "PRCGLBRECNO", // columnName
         false,                    //isKey
         false, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  5, // int? prec
                           0  // int? Scale
         ,
         typeof(Prdrec)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <Prdrec>.GetProperty(x => x.Prcgrsweight),
         "PRCGRSWEIGHT", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  126, // int? prec
                   
         null // int? Scale
         ,
         typeof(Prdrec)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <Prdrec>.GetProperty(x => x.Prcintracode),
         "PRCINTRACODE", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         8,       // int size   
                  null, // int? prec
                   
         null // int? Scale
         ,
         typeof(Prdrec)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <Prdrec>.GetProperty(x => x.Prcmaxprofit),
         "PRCMAXPROFIT", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         1,       // int size   
                  null, // int? prec
                   
         null // int? Scale
         ,
         typeof(Prdrec)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <Prdrec>.GetProperty(x => x.Prcminprofit),
         "PRCMINPROFIT", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         1,       // int size   
                  null, // int? prec
                   
         null // int? Scale
         ,
         typeof(Prdrec)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <Prdrec>.GetProperty(x => x.Prcnominalvalue),
         "PRCNOMINALVALUE", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  126, // int? prec
                   
         null // int? Scale
         ,
         typeof(Prdrec)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <Prdrec>.GetProperty(x => x.Prcpacpal),
         "PRCPACPAL", // columnName
         false,                    //isKey
         false, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  5, // int? prec
                           0  // int? Scale
         ,
         typeof(Prdrec)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <Prdrec>.GetProperty(x => x.Prcprdref),
         "PRCPRDREF", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         12,       // int size   
                  null, // int? prec
                   
         null // int? Scale
         ,
         typeof(Prdrec)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <Prdrec>.GetProperty(x => x.Prcpurbywgt),
         "PRCPURBYWGT", // columnName
         false,                    //isKey
         false, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  1, // int? prec
                           0  // int? Scale
         ,
         typeof(Prdrec)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <Prdrec>.GetProperty(x => x.Prcref1),
         "PRCREF1", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  5, // int? prec
                           0  // int? Scale
         ,
         typeof(Prdrec)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <Prdrec>.GetProperty(x => x.Prcref2),
         "PRCREF2", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  5, // int? prec
                           0  // int? Scale
         ,
         typeof(Prdrec)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <Prdrec>.GetProperty(x => x.Prcref3),
         "PRCREF3", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  5, // int? prec
                           0  // int? Scale
         ,
         typeof(Prdrec)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <Prdrec>.GetProperty(x => x.Prcref4),
         "PRCREF4", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  5, // int? prec
                           0  // int? Scale
         ,
         typeof(Prdrec)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <Prdrec>.GetProperty(x => x.Prcref5),
         "PRCREF5", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  5, // int? prec
                           0  // int? Scale
         ,
         typeof(Prdrec)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <Prdrec>.GetProperty(x => x.Prcref6),
         "PRCREF6", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  5, // int? prec
                           0  // int? Scale
         ,
         typeof(Prdrec)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <Prdrec>.GetProperty(x => x.Prcsalbybox),
         "PRCSALBYBOX", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  1, // int? prec
                           0  // int? Scale
         ,
         typeof(Prdrec)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <Prdrec>.GetProperty(x => x.Prcsalbyeach),
         "PRCSALBYEACH", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  1, // int? prec
                           0  // int? Scale
         ,
         typeof(Prdrec)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <Prdrec>.GetProperty(x => x.Prcsalbyinner),
         "PRCSALBYINNER", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  1, // int? prec
                           0  // int? Scale
         ,
         typeof(Prdrec)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <Prdrec>.GetProperty(x => x.Prcsalbywgt),
         "PRCSALBYWGT", // columnName
         false,                    //isKey
         false, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  1, // int? prec
                           0  // int? Scale
         ,
         typeof(Prdrec)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <Prdrec>.GetProperty(x => x.Prcsampqty),
         "PRCSAMPQTY", // columnName
         false,                    //isKey
         false, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  5, // int? prec
                           0  // int? Scale
         ,
         typeof(Prdrec)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <Prdrec>.GetProperty(x => x.Prcshortdesc),
         "PRCSHORTDESC", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         10,       // int size   
                  null, // int? prec
                   
         null // int? Scale
         ,
         typeof(Prdrec)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <Prdrec>.GetProperty(x => x.Prcstkbywgt),
         "PRCSTKBYWGT", // columnName
         false,                    //isKey
         false, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  1, // int? prec
                           0  // int? Scale
         ,
         typeof(Prdrec)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <Prdrec>.GetProperty(x => x.Prcstreetprice),
         "PRCSTREETPRICE", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         1,       // int size   
                  null, // int? prec
                   
         null // int? Scale
         ,
         typeof(Prdrec)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <Prdrec>.GetProperty(x => x.Prctemperature),
         "PRCTEMPERATURE", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  5, // int? prec
                           0  // int? Scale
         ,
         typeof(Prdrec)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <Prdrec>.GetProperty(x => x.Prcvatcode),
         "PRCVATCODE", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  5, // int? prec
                           0  // int? Scale
         ,
         typeof(Prdrec)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <Prdrec>.GetProperty(x => x.Prcweight),
         "PRCWEIGHT", // columnName
         false,                    //isKey
         false, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  126, // int? prec
                   
         null // int? Scale
         ,
         typeof(Prdrec)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <Prdrec>.GetProperty(x => x.Prdtype),
         "PRDTYPE", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  1, // int? prec
                           0  // int? Scale
         ,
         typeof(Prdrec)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <Prdrec>.GetProperty(x => x.Preusagebydecimal),
         "PREUSAGEBYDECIMAL", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  10, // int? prec
                           0  // int? Scale
         ,
         typeof(Prdrec)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <Prdrec>.GetProperty(x => x.Prodtype),
         "PRODTYPE", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  10, // int? prec
                           0  // int? Scale
         ,
         typeof(Prdrec)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <Prdrec>.GetProperty(x => x.Retailunit),
         "RETAILUNIT", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  126, // int? prec
                   
         null // int? Scale
         ,
         typeof(Prdrec)
         ));
         return result; 
       }

#endregion     
        private int _fPrcprdno;
        public int Prcprdno
        {
            get { return _fPrcprdno; }
            set
            {
                var oldKey = Key;
                if (_fPrcprdno != value)
                {
                    Modify();
                    _fPrcprdno = value;
                    KeyChanged(oldKey);
                }
            }
        }

        private short? _fActive;
        public short? Active
        {
            get { return _fActive; }
            set
            {
                if (_fActive != value)
                {
                    Modify();
                    _fActive = value;
                }
            }
        }

        private short? _fDefaultprd;
        public short? Defaultprd
        {
            get { return _fDefaultprd; }
            set
            {
                if (_fDefaultprd != value)
                {
                    Modify();
                    _fDefaultprd = value;
                }
            }
        }

        private string _fGtin;
        public string Gtin
        {
            get { return _fGtin; }
            set
            {
                if (_fGtin != value)
                {
                    Modify();
                    _fGtin = value;
                }
            }
        }

        private string _fGtinchecksum;
        public string Gtinchecksum
        {
            get { return _fGtinchecksum; }
            set
            {
                if (_fGtinchecksum != value)
                {
                    Modify();
                    _fGtinchecksum = value;
                }
            }
        }

        private int? _fInnerqty;
        public int? Innerqty
        {
            get { return _fInnerqty; }
            set
            {
                if (_fInnerqty != value)
                {
                    Modify();
                    _fInnerqty = value;
                }
            }
        }

        private string _fInnertype;
        public string Innertype
        {
            get { return _fInnertype; }
            set
            {
                if (_fInnertype != value)
                {
                    Modify();
                    _fInnertype = value;
                }
            }
        }

        private short? _fIsmiscprod;
        public short? Ismiscprod
        {
            get { return _fIsmiscprod; }
            set
            {
                if (_fIsmiscprod != value)
                {
                    Modify();
                    _fIsmiscprod = value;
                }
            }
        }

        private short? _fIstradesalesprd;
        public short? Istradesalesprd
        {
            get { return _fIstradesalesprd; }
            set
            {
                if (_fIstradesalesprd != value)
                {
                    Modify();
                    _fIstradesalesprd = value;
                }
            }
        }

        private int? _fMaxprcpacpal;
        public int? Maxprcpacpal
        {
            get { return _fMaxprcpacpal; }
            set
            {
                if (_fMaxprcpacpal != value)
                {
                    Modify();
                    _fMaxprcpacpal = value;
                }
            }
        }

        private decimal? _fMaxprcweight;
        public decimal? Maxprcweight
        {
            get { return _fMaxprcweight; }
            set
            {
                if (_fMaxprcweight != value)
                {
                    Modify();
                    _fMaxprcweight = value;
                }
            }
        }

        private int? _fOrderupliftperc;
        public int? Orderupliftperc
        {
            get { return _fOrderupliftperc; }
            set
            {
                if (_fOrderupliftperc != value)
                {
                    Modify();
                    _fOrderupliftperc = value;
                }
            }
        }

        private int? _fPackitemno;
        public int? Packitemno
        {
            get { return _fPackitemno; }
            set
            {
                if (_fPackitemno != value)
                {
                    Modify();
                    _fPackitemno = value;
                }
            }
        }

        private int? _fPalpanrecno;
        public int? Palpanrecno
        {
            get { return _fPalpanrecno; }
            set
            {
                if (_fPalpanrecno != value)
                {
                    Modify();
                    _fPalpanrecno = value;
                }
            }
        }

        private int? _fPanrecnoinnertype;
        public int? Panrecnoinnertype
        {
            get { return _fPanrecnoinnertype; }
            set
            {
                if (_fPanrecnoinnertype != value)
                {
                    Modify();
                    _fPanrecnoinnertype = value;
                }
            }
        }

        private string _fPrcbaseprice;
        public string Prcbaseprice
        {
            get { return _fPrcbaseprice; }
            set
            {
                if (_fPrcbaseprice != value)
                {
                    Modify();
                    _fPrcbaseprice = value;
                }
            }
        }

        private int _fPrcboxqty;
        public int Prcboxqty
        {
            get { return _fPrcboxqty; }
            set
            {
                if (_fPrcboxqty != value)
                {
                    Modify();
                    _fPrcboxqty = value;
                }
            }
        }

        private decimal _fPrcchgmult;
        public decimal Prcchgmult
        {
            get { return _fPrcchgmult; }
            set
            {
                if (_fPrcchgmult != value)
                {
                    Modify();
                    _fPrcchgmult = value;
                }
            }
        }

        private short? _fPrcdescchg;
        public short? Prcdescchg
        {
            get { return _fPrcdescchg; }
            set
            {
                if (_fPrcdescchg != value)
                {
                    Modify();
                    _fPrcdescchg = value;
                }
            }
        }

        private string _fPrcdescription;
        public string Prcdescription
        {
            get { return _fPrcdescription; }
            set
            {
                if (_fPrcdescription != value)
                {
                    Modify();
                    _fPrcdescription = value;
                }
            }
        }

        private int _fPrcglbrecno;
        public int Prcglbrecno
        {
            get { return _fPrcglbrecno; }
            set
            {
                if (_fPrcglbrecno != value)
                {
                    Modify();
                    _fPrcglbrecno = value;
                }
            }
        }

        private decimal? _fPrcgrsweight;
        public decimal? Prcgrsweight
        {
            get { return _fPrcgrsweight; }
            set
            {
                if (_fPrcgrsweight != value)
                {
                    Modify();
                    _fPrcgrsweight = value;
                }
            }
        }

        private string _fPrcintracode;
        public string Prcintracode
        {
            get { return _fPrcintracode; }
            set
            {
                if (_fPrcintracode != value)
                {
                    Modify();
                    _fPrcintracode = value;
                }
            }
        }

        private string _fPrcmaxprofit;
        public string Prcmaxprofit
        {
            get { return _fPrcmaxprofit; }
            set
            {
                if (_fPrcmaxprofit != value)
                {
                    Modify();
                    _fPrcmaxprofit = value;
                }
            }
        }

        private string _fPrcminprofit;
        public string Prcminprofit
        {
            get { return _fPrcminprofit; }
            set
            {
                if (_fPrcminprofit != value)
                {
                    Modify();
                    _fPrcminprofit = value;
                }
            }
        }

        private decimal? _fPrcnominalvalue;
        public decimal? Prcnominalvalue
        {
            get { return _fPrcnominalvalue; }
            set
            {
                if (_fPrcnominalvalue != value)
                {
                    Modify();
                    _fPrcnominalvalue = value;
                }
            }
        }

        private int _fPrcpacpal;
        public int Prcpacpal
        {
            get { return _fPrcpacpal; }
            set
            {
                if (_fPrcpacpal != value)
                {
                    Modify();
                    _fPrcpacpal = value;
                }
            }
        }

        private string _fPrcprdref;
        public string Prcprdref
        {
            get { return _fPrcprdref; }
            set
            {
                if (_fPrcprdref != value)
                {
                    Modify();
                    _fPrcprdref = value;
                }
            }
        }

        private short _fPrcpurbywgt;
        public short Prcpurbywgt
        {
            get { return _fPrcpurbywgt; }
            set
            {
                if (_fPrcpurbywgt != value)
                {
                    Modify();
                    _fPrcpurbywgt = value;
                }
            }
        }

        private int? _fPrcref1;
        public int? Prcref1
        {
            get { return _fPrcref1; }
            set
            {
                if (_fPrcref1 != value)
                {
                    Modify();
                    _fPrcref1 = value;
                }
            }
        }

        private int? _fPrcref2;
        public int? Prcref2
        {
            get { return _fPrcref2; }
            set
            {
                if (_fPrcref2 != value)
                {
                    Modify();
                    _fPrcref2 = value;
                }
            }
        }

        private int? _fPrcref3;
        public int? Prcref3
        {
            get { return _fPrcref3; }
            set
            {
                if (_fPrcref3 != value)
                {
                    Modify();
                    _fPrcref3 = value;
                }
            }
        }

        private int? _fPrcref4;
        public int? Prcref4
        {
            get { return _fPrcref4; }
            set
            {
                if (_fPrcref4 != value)
                {
                    Modify();
                    _fPrcref4 = value;
                }
            }
        }

        private int? _fPrcref5;
        public int? Prcref5
        {
            get { return _fPrcref5; }
            set
            {
                if (_fPrcref5 != value)
                {
                    Modify();
                    _fPrcref5 = value;
                }
            }
        }

        private int? _fPrcref6;
        public int? Prcref6
        {
            get { return _fPrcref6; }
            set
            {
                if (_fPrcref6 != value)
                {
                    Modify();
                    _fPrcref6 = value;
                }
            }
        }

        private short? _fPrcsalbybox;
        public short? Prcsalbybox
        {
            get { return _fPrcsalbybox; }
            set
            {
                if (_fPrcsalbybox != value)
                {
                    Modify();
                    _fPrcsalbybox = value;
                }
            }
        }

        private short? _fPrcsalbyeach;
        public short? Prcsalbyeach
        {
            get { return _fPrcsalbyeach; }
            set
            {
                if (_fPrcsalbyeach != value)
                {
                    Modify();
                    _fPrcsalbyeach = value;
                }
            }
        }

        private short? _fPrcsalbyinner;
        public short? Prcsalbyinner
        {
            get { return _fPrcsalbyinner; }
            set
            {
                if (_fPrcsalbyinner != value)
                {
                    Modify();
                    _fPrcsalbyinner = value;
                }
            }
        }

        private short _fPrcsalbywgt;
        public short Prcsalbywgt
        {
            get { return _fPrcsalbywgt; }
            set
            {
                if (_fPrcsalbywgt != value)
                {
                    Modify();
                    _fPrcsalbywgt = value;
                }
            }
        }

        private int _fPrcsampqty;
        public int Prcsampqty
        {
            get { return _fPrcsampqty; }
            set
            {
                if (_fPrcsampqty != value)
                {
                    Modify();
                    _fPrcsampqty = value;
                }
            }
        }

        private string _fPrcshortdesc;
        public string Prcshortdesc
        {
            get { return _fPrcshortdesc; }
            set
            {
                if (_fPrcshortdesc != value)
                {
                    Modify();
                    _fPrcshortdesc = value;
                }
            }
        }

        private short _fPrcstkbywgt;
        public short Prcstkbywgt
        {
            get { return _fPrcstkbywgt; }
            set
            {
                if (_fPrcstkbywgt != value)
                {
                    Modify();
                    _fPrcstkbywgt = value;
                }
            }
        }

        private string _fPrcstreetprice;
        public string Prcstreetprice
        {
            get { return _fPrcstreetprice; }
            set
            {
                if (_fPrcstreetprice != value)
                {
                    Modify();
                    _fPrcstreetprice = value;
                }
            }
        }

        private int? _fPrctemperature;
        public int? Prctemperature
        {
            get { return _fPrctemperature; }
            set
            {
                if (_fPrctemperature != value)
                {
                    Modify();
                    _fPrctemperature = value;
                }
            }
        }

        private int? _fPrcvatcode;
        public int? Prcvatcode
        {
            get { return _fPrcvatcode; }
            set
            {
                if (_fPrcvatcode != value)
                {
                    Modify();
                    _fPrcvatcode = value;
                }
            }
        }

        private decimal _fPrcweight;
        public decimal Prcweight
        {
            get { return _fPrcweight; }
            set
            {
                if (_fPrcweight != value)
                {
                    Modify();
                    _fPrcweight = value;
                }
            }
        }

        private short? _fPrdtype;
        public short? Prdtype
        {
            get { return _fPrdtype; }
            set
            {
                if (_fPrdtype != value)
                {
                    Modify();
                    _fPrdtype = value;
                }
            }
        }

        private int? _fPreusagebydecimal;
        public int? Preusagebydecimal
        {
            get { return _fPreusagebydecimal; }
            set
            {
                if (_fPreusagebydecimal != value)
                {
                    Modify();
                    _fPreusagebydecimal = value;
                }
            }
        }

        private int? _fProdtype;
        public int? Prodtype
        {
            get { return _fProdtype; }
            set
            {
                if (_fProdtype != value)
                {
                    Modify();
                    _fProdtype = value;
                }
            }
        }

        private decimal? _fRetailunit;
        public decimal? Retailunit
        {
            get { return _fRetailunit; }
            set
            {
                if (_fRetailunit != value)
                {
                    Modify();
                    _fRetailunit = value;
                }
            }
        }

        public override int Key
        {
            get { return Prcprdno; }
            set { Prcprdno = value; }
        }

        public override string KeyAsString { get { return Key.ToString(CultureInfo.InvariantCulture); } }


        public override Prdrec Clone()
        {
            var obj = new Prdrec
                {
                    Prcprdno = Prcprdno,
                    Active = Active,
                    Defaultprd = Defaultprd,
                    Gtin = Gtin,
                    Gtinchecksum = Gtinchecksum,
                    Innerqty = Innerqty,
                    Innertype = Innertype,
                    Ismiscprod = Ismiscprod,
                    Istradesalesprd = Istradesalesprd,
                    Maxprcpacpal = Maxprcpacpal,
                    Maxprcweight = Maxprcweight,
                    Orderupliftperc = Orderupliftperc,
                    Packitemno = Packitemno,
                    Palpanrecno = Palpanrecno,
                    Panrecnoinnertype = Panrecnoinnertype,
                    Prcbaseprice = Prcbaseprice,
                    Prcboxqty = Prcboxqty,
                    Prcchgmult = Prcchgmult,
                    Prcdescchg = Prcdescchg,
                    Prcdescription = Prcdescription,
                    Prcglbrecno = Prcglbrecno,
                    Prcgrsweight = Prcgrsweight,
                    Prcintracode = Prcintracode,
                    Prcmaxprofit = Prcmaxprofit,
                    Prcminprofit = Prcminprofit,
                    Prcnominalvalue = Prcnominalvalue,
                    Prcpacpal = Prcpacpal,
                    Prcprdref = Prcprdref,
                    Prcpurbywgt = Prcpurbywgt,
                    Prcref1 = Prcref1,
                    Prcref2 = Prcref2,
                    Prcref3 = Prcref3,
                    Prcref4 = Prcref4,
                    Prcref5 = Prcref5,
                    Prcref6 = Prcref6,
                    Prcsalbybox = Prcsalbybox,
                    Prcsalbyeach = Prcsalbyeach,
                    Prcsalbyinner = Prcsalbyinner,
                    Prcsalbywgt = Prcsalbywgt,
                    Prcsampqty = Prcsampqty,
                    Prcshortdesc = Prcshortdesc,
                    Prcstkbywgt = Prcstkbywgt,
                    Prcstreetprice = Prcstreetprice,
                    Prctemperature = Prctemperature,
                    Prcvatcode = Prcvatcode,
                    Prcweight = Prcweight,
                    Prdtype = Prdtype,
                    Preusagebydecimal = Preusagebydecimal,
                    Prodtype = Prodtype,
                    Retailunit = Retailunit,
                };

            return obj;
        }

        public static class FieldNames
        {
// ReSharper disable InconsistentNaming
            public const string  PRCPRDNO = "PRCPRDNO";
            public const string  ACTIVE = "ACTIVE";
            public const string  DEFAULTPRD = "DEFAULTPRD";
            public const string  GTIN = "GTIN";
            public const string  GTINCHECKSUM = "GTINCHECKSUM";
            public const string  INNERQTY = "INNERQTY";
            public const string  INNERTYPE = "INNERTYPE";
            public const string  ISMISCPROD = "ISMISCPROD";
            public const string  ISTRADESALESPRD = "ISTRADESALESPRD";
            public const string  MAXPRCPACPAL = "MAXPRCPACPAL";
            public const string  MAXPRCWEIGHT = "MAXPRCWEIGHT";
            public const string  ORDERUPLIFTPERC = "ORDERUPLIFTPERC";
            public const string  PACKITEMNO = "PACKITEMNO";
            public const string  PALPANRECNO = "PALPANRECNO";
            public const string  PANRECNOINNERTYPE = "PANRECNOINNERTYPE";
            public const string  PRCBASEPRICE = "PRCBASEPRICE";
            public const string  PRCBOXQTY = "PRCBOXQTY";
            public const string  PRCCHGMULT = "PRCCHGMULT";
            public const string  PRCDESCCHG = "PRCDESCCHG";
            public const string  PRCDESCRIPTION = "PRCDESCRIPTION";
            public const string  PRCGLBRECNO = "PRCGLBRECNO";
            public const string  PRCGRSWEIGHT = "PRCGRSWEIGHT";
            public const string  PRCINTRACODE = "PRCINTRACODE";
            public const string  PRCMAXPROFIT = "PRCMAXPROFIT";
            public const string  PRCMINPROFIT = "PRCMINPROFIT";
            public const string  PRCNOMINALVALUE = "PRCNOMINALVALUE";
            public const string  PRCPACPAL = "PRCPACPAL";
            public const string  PRCPRDREF = "PRCPRDREF";
            public const string  PRCPURBYWGT = "PRCPURBYWGT";
            public const string  PRCREF1 = "PRCREF1";
            public const string  PRCREF2 = "PRCREF2";
            public const string  PRCREF3 = "PRCREF3";
            public const string  PRCREF4 = "PRCREF4";
            public const string  PRCREF5 = "PRCREF5";
            public const string  PRCREF6 = "PRCREF6";
            public const string  PRCSALBYBOX = "PRCSALBYBOX";
            public const string  PRCSALBYEACH = "PRCSALBYEACH";
            public const string  PRCSALBYINNER = "PRCSALBYINNER";
            public const string  PRCSALBYWGT = "PRCSALBYWGT";
            public const string  PRCSAMPQTY = "PRCSAMPQTY";
            public const string  PRCSHORTDESC = "PRCSHORTDESC";
            public const string  PRCSTKBYWGT = "PRCSTKBYWGT";
            public const string  PRCSTREETPRICE = "PRCSTREETPRICE";
            public const string  PRCTEMPERATURE = "PRCTEMPERATURE";
            public const string  PRCVATCODE = "PRCVATCODE";
            public const string  PRCWEIGHT = "PRCWEIGHT";
            public const string  PRDTYPE = "PRDTYPE";
            public const string  PREUSAGEBYDECIMAL = "PREUSAGEBYDECIMAL";
            public const string  PRODTYPE = "PRODTYPE";
            public const string  RETAILUNIT = "RETAILUNIT";
 // ReSharper restore InconsistentNaming
        }


    }

}
