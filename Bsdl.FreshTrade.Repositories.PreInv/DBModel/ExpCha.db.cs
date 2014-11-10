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
    /// Entity for the EXPCHA table
    /// </summary>
    public partial class ExpCha : BaseDbModel<ExpCha, int>
    {
#region tableDefs

       public static List<EntityPropDef> GetPropDefs() {
         var result = new List<EntityPropDef>();

//EntityPropDef(string propName, string columnName, bool isKey, bool isNullable, string refEntityName, PropertyInfo keyPropInfo,
//            int size, int? prec, int? scale)



         result.Add(new EntityPropDef(
         PropertyHelper <ExpCha>.GetProperty(x => x.Exccharec),
         "EXCCHAREC", // columnName
         true,                    //isKey
         false, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  10, // int? prec
                           0  // int? Scale
         ,
         typeof(ExpCha)
       ));


         result.Add(new EntityPropDef(
         PropertyHelper <ExpCha>.GetProperty(x => x.Closedisputecode),
         "CLOSEDISPUTECODE", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         10,       // int size   
                  null, // int? prec
                   
         null // int? Scale
         ,
         typeof(ExpCha)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <ExpCha>.GetProperty(x => x.Disputecode),
         "DISPUTECODE", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         10,       // int size   
                  null, // int? prec
                   
         null // int? Scale
         ,
         typeof(ExpCha)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <ExpCha>.GetProperty(x => x.Disputestatus),
         "DISPUTESTATUS", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  5, // int? prec
                           0  // int? Scale
         ,
         typeof(ExpCha)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <ExpCha>.GetProperty(x => x.Dlvdtpdxli),
         "DLVDTPDXLI", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  10, // int? prec
                           0  // int? Scale
         ,
         typeof(ExpCha)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <ExpCha>.GetProperty(x => x.Excapptype),
         "EXCAPPTYPE", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  5, // int? prec
                           0  // int? Scale
         ,
         typeof(ExpCha)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <ExpCha>.GetProperty(x => x.Excatrrecno),
         "EXCATRRECNO", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  10, // int? prec
                           0  // int? Scale
         ,
         typeof(ExpCha)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <ExpCha>.GetProperty(x => x.Excauthconamm),
         "EXCAUTHCONAMM", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  126, // int? prec
                   
         null // int? Scale
         ,
         typeof(ExpCha)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <ExpCha>.GetProperty(x => x.Excautheuroamm),
         "EXCAUTHEUROAMM", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  126, // int? prec
                   
         null // int? Scale
         ,
         typeof(ExpCha)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <ExpCha>.GetProperty(x => x.Excauthrawamm),
         "EXCAUTHRAWAMM", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  126, // int? prec
                   
         null // int? Scale
         ,
         typeof(ExpCha)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <ExpCha>.GetProperty(x => x.Excauthtobaserate),
         "EXCAUTHTOBASERATE", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  126, // int? prec
                   
         null // int? Scale
         ,
         typeof(ExpCha)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <ExpCha>.GetProperty(x => x.Excauthtoeuroamm),
         "EXCAUTHTOEUROAMM", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  126, // int? prec
                   
         null // int? Scale
         ,
         typeof(ExpCha)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <ExpCha>.GetProperty(x => x.Excchaperrate),
         "EXCCHAPERRATE", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  126, // int? prec
                   
         null // int? Scale
         ,
         typeof(ExpCha)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <ExpCha>.GetProperty(x => x.Excchgcalc),
         "EXCCHGCALC", // columnName
         false,                    //isKey
         false, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  5, // int? prec
                           0  // int? Scale
         ,
         typeof(ExpCha)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <ExpCha>.GetProperty(x => x.Excclaimonhold),
         "EXCCLAIMONHOLD", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  1, // int? prec
                           0  // int? Scale
         ,
         typeof(ExpCha)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <ExpCha>.GetProperty(x => x.Excclrdate),
         "EXCCLRDATE", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  null, // int? prec
                   
         null // int? Scale
         ,
         typeof(ExpCha)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <ExpCha>.GetProperty(x => x.Excconamm),
         "EXCCONAMM", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  126, // int? prec
                   
         null // int? Scale
         ,
         typeof(ExpCha)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <ExpCha>.GetProperty(x => x.Excctyno),
         "EXCCTYNO", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  5, // int? prec
                           0  // int? Scale
         ,
         typeof(ExpCha)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <ExpCha>.GetProperty(x => x.Exccurrblkpurch),
         "EXCCURRBLKPURCH", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  1, // int? prec
                           0  // int? Scale
         ,
         typeof(ExpCha)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <ExpCha>.GetProperty(x => x.Exccurrno),
         "EXCCURRNO", // columnName
         false,                    //isKey
         false, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  5, // int? prec
                           0  // int? Scale
         ,
         typeof(ExpCha)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <ExpCha>.GetProperty(x => x.Excdlvordno),
         "EXCDLVORDNO", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  10, // int? prec
                           0  // int? Scale
         ,
         typeof(ExpCha)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <ExpCha>.GetProperty(x => x.Excdutyref),
         "EXCDUTYREF", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         10,       // int size   
                  null, // int? prec
                   
         null // int? Scale
         ,
         typeof(ExpCha)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <ExpCha>.GetProperty(x => x.Exceuroamm),
         "EXCEUROAMM", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  126, // int? prec
                   
         null // int? Scale
         ,
         typeof(ExpCha)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <ExpCha>.GetProperty(x => x.Excfullyauth),
         "EXCFULLYAUTH", // columnName
         false,                    //isKey
         false, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  5, // int? prec
                           0  // int? Scale
         ,
         typeof(ExpCha)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <ExpCha>.GetProperty(x => x.Exclherecno),
         "EXCLHERECNO", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  10, // int? prec
                           0  // int? Scale
         ,
         typeof(ExpCha)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <ExpCha>.GetProperty(x => x.Excpackmporrecno),
         "EXCPACKMPORRECNO", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  10, // int? prec
                           0  // int? Scale
         ,
         typeof(ExpCha)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <ExpCha>.GetProperty(x => x.Excporrecno),
         "EXCPORRECNO", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  10, // int? prec
                           0  // int? Scale
         ,
         typeof(ExpCha)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <ExpCha>.GetProperty(x => x.Excratefixed),
         "EXCRATEFIXED", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  1, // int? prec
                           0  // int? Scale
         ,
         typeof(ExpCha)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <ExpCha>.GetProperty(x => x.Excrawamm),
         "EXCRAWAMM", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  126, // int? prec
                   
         null // int? Scale
         ,
         typeof(ExpCha)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <ExpCha>.GetProperty(x => x.Excrecovfrompl),
         "EXCRECOVFROMPL", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  10, // int? prec
                           0  // int? Scale
         ,
         typeof(ExpCha)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <ExpCha>.GetProperty(x => x.Excretno),
         "EXCRETNO", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  10, // int? prec
                           0  // int? Scale
         ,
         typeof(ExpCha)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <ExpCha>.GetProperty(x => x.Excrounddif),
         "EXCROUNDDIF", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  126, // int? prec
                   
         null // int? Scale
         ,
         typeof(ExpCha)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <ExpCha>.GetProperty(x => x.Excrthno),
         "EXCRTHNO", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  10, // int? prec
                           0  // int? Scale
         ,
         typeof(ExpCha)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <ExpCha>.GetProperty(x => x.Excrthpono),
         "EXCRTHPONO", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  10, // int? prec
                           0  // int? Scale
         ,
         typeof(ExpCha)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <ExpCha>.GetProperty(x => x.Excsaloff),
         "EXCSALOFF", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  5, // int? prec
                           0  // int? Scale
         ,
         typeof(ExpCha)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <ExpCha>.GetProperty(x => x.Excsencode),
         "EXCSENCODE", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  10, // int? prec
                           0  // int? Scale
         ,
         typeof(ExpCha)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <ExpCha>.GetProperty(x => x.Excsenref),
         "EXCSENREF", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         15,       // int size   
                  null, // int? prec
                   
         null // int? Scale
         ,
         typeof(ExpCha)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <ExpCha>.GetProperty(x => x.Excspeto),
         "EXCSPETO", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         1,       // int size   
                  null, // int? prec
                   
         null // int? Scale
         ,
         typeof(ExpCha)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <ExpCha>.GetProperty(x => x.Exctobaserate),
         "EXCTOBASERATE", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  126, // int? prec
                   
         null // int? Scale
         ,
         typeof(ExpCha)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <ExpCha>.GetProperty(x => x.Exctoeuroexcrate),
         "EXCTOEUROEXCRATE", // columnName
         false,                    //isKey
         false, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  126, // int? prec
                   
         null // int? Scale
         ,
         typeof(ExpCha)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <ExpCha>.GetProperty(x => x.Invexchrate),
         "INVEXCHRATE", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  126, // int? prec
                   
         null // int? Scale
         ,
         typeof(ExpCha)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <ExpCha>.GetProperty(x => x.Openchargeid),
         "OPENCHARGEID", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  10, // int? prec
                           0  // int? Scale
         ,
         typeof(ExpCha)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <ExpCha>.GetProperty(x => x.Triangulated),
         "TRIANGULATED", // columnName
         false,                    //isKey
         false, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  1, // int? prec
                           0  // int? Scale
         ,
         typeof(ExpCha)
         ));
         return result; 
       }

#endregion     
        private int _fExccharec;
        public int Exccharec
        {
            get { return _fExccharec; }
            set
            {
                var oldKey = Key;
                if (_fExccharec != value)
                {
                    Modify();
                    _fExccharec = value;
                    KeyChanged(oldKey);
                }
            }
        }

        private string _fClosedisputecode;
        public string Closedisputecode
        {
            get { return _fClosedisputecode; }
            set
            {
                if (_fClosedisputecode != value)
                {
                    Modify();
                    _fClosedisputecode = value;
                }
            }
        }

        private string _fDisputecode;
        public string Disputecode
        {
            get { return _fDisputecode; }
            set
            {
                if (_fDisputecode != value)
                {
                    Modify();
                    _fDisputecode = value;
                }
            }
        }

        private int? _fDisputestatus;
        public int? Disputestatus
        {
            get { return _fDisputestatus; }
            set
            {
                if (_fDisputestatus != value)
                {
                    Modify();
                    _fDisputestatus = value;
                }
            }
        }

        private int? _fDlvdtpdxli;
        public int? Dlvdtpdxli
        {
            get { return _fDlvdtpdxli; }
            set
            {
                if (_fDlvdtpdxli != value)
                {
                    Modify();
                    _fDlvdtpdxli = value;
                }
            }
        }

        private int? _fExcapptype;
        public int? Excapptype
        {
            get { return _fExcapptype; }
            set
            {
                if (_fExcapptype != value)
                {
                    Modify();
                    _fExcapptype = value;
                }
            }
        }

        private int? _fExcatrrecno;
        public int? Excatrrecno
        {
            get { return _fExcatrrecno; }
            set
            {
                if (_fExcatrrecno != value)
                {
                    Modify();
                    _fExcatrrecno = value;
                }
            }
        }

        private decimal? _fExcauthconamm;
        public decimal? Excauthconamm
        {
            get { return _fExcauthconamm; }
            set
            {
                if (_fExcauthconamm != value)
                {
                    Modify();
                    _fExcauthconamm = value;
                }
            }
        }

        private decimal? _fExcautheuroamm;
        public decimal? Excautheuroamm
        {
            get { return _fExcautheuroamm; }
            set
            {
                if (_fExcautheuroamm != value)
                {
                    Modify();
                    _fExcautheuroamm = value;
                }
            }
        }

        private decimal? _fExcauthrawamm;
        public decimal? Excauthrawamm
        {
            get { return _fExcauthrawamm; }
            set
            {
                if (_fExcauthrawamm != value)
                {
                    Modify();
                    _fExcauthrawamm = value;
                }
            }
        }

        private decimal? _fExcauthtobaserate;
        public decimal? Excauthtobaserate
        {
            get { return _fExcauthtobaserate; }
            set
            {
                if (_fExcauthtobaserate != value)
                {
                    Modify();
                    _fExcauthtobaserate = value;
                }
            }
        }

        private decimal? _fExcauthtoeuroamm;
        public decimal? Excauthtoeuroamm
        {
            get { return _fExcauthtoeuroamm; }
            set
            {
                if (_fExcauthtoeuroamm != value)
                {
                    Modify();
                    _fExcauthtoeuroamm = value;
                }
            }
        }

        private decimal? _fExcchaperrate;
        public decimal? Excchaperrate
        {
            get { return _fExcchaperrate; }
            set
            {
                if (_fExcchaperrate != value)
                {
                    Modify();
                    _fExcchaperrate = value;
                }
            }
        }

        private int _fExcchgcalc;
        public int Excchgcalc
        {
            get { return _fExcchgcalc; }
            set
            {
                if (_fExcchgcalc != value)
                {
                    Modify();
                    _fExcchgcalc = value;
                }
            }
        }

        private short? _fExcclaimonhold;
        public short? Excclaimonhold
        {
            get { return _fExcclaimonhold; }
            set
            {
                if (_fExcclaimonhold != value)
                {
                    Modify();
                    _fExcclaimonhold = value;
                }
            }
        }

        private DateTime? _fExcclrdate;
        public DateTime? Excclrdate
        {
            get { return _fExcclrdate; }
            set
            {
                if (_fExcclrdate != value)
                {
                    Modify();
                    _fExcclrdate = value;
                }
            }
        }

        private decimal? _fExcconamm;
        public decimal? Excconamm
        {
            get { return _fExcconamm; }
            set
            {
                if (_fExcconamm != value)
                {
                    Modify();
                    _fExcconamm = value;
                }
            }
        }

        private int? _fExcctyno;
        public int? Excctyno
        {
            get { return _fExcctyno; }
            set
            {
                if (_fExcctyno != value)
                {
                    Modify();
                    _fExcctyno = value;
                }
            }
        }

        private short? _fExccurrblkpurch;
        public short? Exccurrblkpurch
        {
            get { return _fExccurrblkpurch; }
            set
            {
                if (_fExccurrblkpurch != value)
                {
                    Modify();
                    _fExccurrblkpurch = value;
                }
            }
        }

        private int _fExccurrno;
        public int Exccurrno
        {
            get { return _fExccurrno; }
            set
            {
                if (_fExccurrno != value)
                {
                    Modify();
                    _fExccurrno = value;
                }
            }
        }

        private int? _fExcdlvordno;
        public int? Excdlvordno
        {
            get { return _fExcdlvordno; }
            set
            {
                if (_fExcdlvordno != value)
                {
                    Modify();
                    _fExcdlvordno = value;
                }
            }
        }

        private string _fExcdutyref;
        public string Excdutyref
        {
            get { return _fExcdutyref; }
            set
            {
                if (_fExcdutyref != value)
                {
                    Modify();
                    _fExcdutyref = value;
                }
            }
        }

        private decimal? _fExceuroamm;
        public decimal? Exceuroamm
        {
            get { return _fExceuroamm; }
            set
            {
                if (_fExceuroamm != value)
                {
                    Modify();
                    _fExceuroamm = value;
                }
            }
        }

        private int _fExcfullyauth;
        public int Excfullyauth
        {
            get { return _fExcfullyauth; }
            set
            {
                if (_fExcfullyauth != value)
                {
                    Modify();
                    _fExcfullyauth = value;
                }
            }
        }

        private int? _fExclherecno;
        public int? Exclherecno
        {
            get { return _fExclherecno; }
            set
            {
                if (_fExclherecno != value)
                {
                    Modify();
                    _fExclherecno = value;
                }
            }
        }

        private int? _fExcpackmporrecno;
        public int? Excpackmporrecno
        {
            get { return _fExcpackmporrecno; }
            set
            {
                if (_fExcpackmporrecno != value)
                {
                    Modify();
                    _fExcpackmporrecno = value;
                }
            }
        }

        private int? _fExcporrecno;
        public int? Excporrecno
        {
            get { return _fExcporrecno; }
            set
            {
                if (_fExcporrecno != value)
                {
                    Modify();
                    _fExcporrecno = value;
                }
            }
        }

        private short? _fExcratefixed;
        public short? Excratefixed
        {
            get { return _fExcratefixed; }
            set
            {
                if (_fExcratefixed != value)
                {
                    Modify();
                    _fExcratefixed = value;
                }
            }
        }

        private decimal? _fExcrawamm;
        public decimal? Excrawamm
        {
            get { return _fExcrawamm; }
            set
            {
                if (_fExcrawamm != value)
                {
                    Modify();
                    _fExcrawamm = value;
                }
            }
        }

        private int? _fExcrecovfrompl;
        public int? Excrecovfrompl
        {
            get { return _fExcrecovfrompl; }
            set
            {
                if (_fExcrecovfrompl != value)
                {
                    Modify();
                    _fExcrecovfrompl = value;
                }
            }
        }

        private int? _fExcretno;
        public int? Excretno
        {
            get { return _fExcretno; }
            set
            {
                if (_fExcretno != value)
                {
                    Modify();
                    _fExcretno = value;
                }
            }
        }

        private decimal? _fExcrounddif;
        public decimal? Excrounddif
        {
            get { return _fExcrounddif; }
            set
            {
                if (_fExcrounddif != value)
                {
                    Modify();
                    _fExcrounddif = value;
                }
            }
        }

        private int? _fExcrthno;
        public int? Excrthno
        {
            get { return _fExcrthno; }
            set
            {
                if (_fExcrthno != value)
                {
                    Modify();
                    _fExcrthno = value;
                }
            }
        }

        private int? _fExcrthpono;
        public int? Excrthpono
        {
            get { return _fExcrthpono; }
            set
            {
                if (_fExcrthpono != value)
                {
                    Modify();
                    _fExcrthpono = value;
                }
            }
        }

        private int? _fExcsaloff;
        public int? Excsaloff
        {
            get { return _fExcsaloff; }
            set
            {
                if (_fExcsaloff != value)
                {
                    Modify();
                    _fExcsaloff = value;
                }
            }
        }

        private int? _fExcsencode;
        public int? Excsencode
        {
            get { return _fExcsencode; }
            set
            {
                if (_fExcsencode != value)
                {
                    Modify();
                    _fExcsencode = value;
                }
            }
        }

        private string _fExcsenref;
        public string Excsenref
        {
            get { return _fExcsenref; }
            set
            {
                if (_fExcsenref != value)
                {
                    Modify();
                    _fExcsenref = value;
                }
            }
        }

        private string _fExcspeto;
        public string Excspeto
        {
            get { return _fExcspeto; }
            set
            {
                if (_fExcspeto != value)
                {
                    Modify();
                    _fExcspeto = value;
                }
            }
        }

        private decimal? _fExctobaserate;
        public decimal? Exctobaserate
        {
            get { return _fExctobaserate; }
            set
            {
                if (_fExctobaserate != value)
                {
                    Modify();
                    _fExctobaserate = value;
                }
            }
        }

        private decimal _fExctoeuroexcrate;
        public decimal Exctoeuroexcrate
        {
            get { return _fExctoeuroexcrate; }
            set
            {
                if (_fExctoeuroexcrate != value)
                {
                    Modify();
                    _fExctoeuroexcrate = value;
                }
            }
        }

        private decimal? _fInvexchrate;
        public decimal? Invexchrate
        {
            get { return _fInvexchrate; }
            set
            {
                if (_fInvexchrate != value)
                {
                    Modify();
                    _fInvexchrate = value;
                }
            }
        }

        private int? _fOpenchargeid;
        public int? Openchargeid
        {
            get { return _fOpenchargeid; }
            set
            {
                if (_fOpenchargeid != value)
                {
                    Modify();
                    _fOpenchargeid = value;
                }
            }
        }

        private short _fTriangulated;
        public short Triangulated
        {
            get { return _fTriangulated; }
            set
            {
                if (_fTriangulated != value)
                {
                    Modify();
                    _fTriangulated = value;
                }
            }
        }

        public override int Key
        {
            get { return Exccharec; }
            set { Exccharec = value; }
        }

        public override string KeyAsString { get { return Key.ToString(CultureInfo.InvariantCulture); } }


        public override ExpCha Clone()
        {
            var obj = new ExpCha
                {
                    Exccharec = Exccharec,
                    Closedisputecode = Closedisputecode,
                    Disputecode = Disputecode,
                    Disputestatus = Disputestatus,
                    Dlvdtpdxli = Dlvdtpdxli,
                    Excapptype = Excapptype,
                    Excatrrecno = Excatrrecno,
                    Excauthconamm = Excauthconamm,
                    Excautheuroamm = Excautheuroamm,
                    Excauthrawamm = Excauthrawamm,
                    Excauthtobaserate = Excauthtobaserate,
                    Excauthtoeuroamm = Excauthtoeuroamm,
                    Excchaperrate = Excchaperrate,
                    Excchgcalc = Excchgcalc,
                    Excclaimonhold = Excclaimonhold,
                    Excclrdate = Excclrdate,
                    Excconamm = Excconamm,
                    Excctyno = Excctyno,
                    Exccurrblkpurch = Exccurrblkpurch,
                    Exccurrno = Exccurrno,
                    Excdlvordno = Excdlvordno,
                    Excdutyref = Excdutyref,
                    Exceuroamm = Exceuroamm,
                    Excfullyauth = Excfullyauth,
                    Exclherecno = Exclherecno,
                    Excpackmporrecno = Excpackmporrecno,
                    Excporrecno = Excporrecno,
                    Excratefixed = Excratefixed,
                    Excrawamm = Excrawamm,
                    Excrecovfrompl = Excrecovfrompl,
                    Excretno = Excretno,
                    Excrounddif = Excrounddif,
                    Excrthno = Excrthno,
                    Excrthpono = Excrthpono,
                    Excsaloff = Excsaloff,
                    Excsencode = Excsencode,
                    Excsenref = Excsenref,
                    Excspeto = Excspeto,
                    Exctobaserate = Exctobaserate,
                    Exctoeuroexcrate = Exctoeuroexcrate,
                    Invexchrate = Invexchrate,
                    Openchargeid = Openchargeid,
                    Triangulated = Triangulated,
                };

            return obj;
        }

        public static class FieldNames
        {
// ReSharper disable InconsistentNaming
            public const string  EXCCHAREC = "EXCCHAREC";
            public const string  CLOSEDISPUTECODE = "CLOSEDISPUTECODE";
            public const string  DISPUTECODE = "DISPUTECODE";
            public const string  DISPUTESTATUS = "DISPUTESTATUS";
            public const string  DLVDTPDXLI = "DLVDTPDXLI";
            public const string  EXCAPPTYPE = "EXCAPPTYPE";
            public const string  EXCATRRECNO = "EXCATRRECNO";
            public const string  EXCAUTHCONAMM = "EXCAUTHCONAMM";
            public const string  EXCAUTHEUROAMM = "EXCAUTHEUROAMM";
            public const string  EXCAUTHRAWAMM = "EXCAUTHRAWAMM";
            public const string  EXCAUTHTOBASERATE = "EXCAUTHTOBASERATE";
            public const string  EXCAUTHTOEUROAMM = "EXCAUTHTOEUROAMM";
            public const string  EXCCHAPERRATE = "EXCCHAPERRATE";
            public const string  EXCCHGCALC = "EXCCHGCALC";
            public const string  EXCCLAIMONHOLD = "EXCCLAIMONHOLD";
            public const string  EXCCLRDATE = "EXCCLRDATE";
            public const string  EXCCONAMM = "EXCCONAMM";
            public const string  EXCCTYNO = "EXCCTYNO";
            public const string  EXCCURRBLKPURCH = "EXCCURRBLKPURCH";
            public const string  EXCCURRNO = "EXCCURRNO";
            public const string  EXCDLVORDNO = "EXCDLVORDNO";
            public const string  EXCDUTYREF = "EXCDUTYREF";
            public const string  EXCEUROAMM = "EXCEUROAMM";
            public const string  EXCFULLYAUTH = "EXCFULLYAUTH";
            public const string  EXCLHERECNO = "EXCLHERECNO";
            public const string  EXCPACKMPORRECNO = "EXCPACKMPORRECNO";
            public const string  EXCPORRECNO = "EXCPORRECNO";
            public const string  EXCRATEFIXED = "EXCRATEFIXED";
            public const string  EXCRAWAMM = "EXCRAWAMM";
            public const string  EXCRECOVFROMPL = "EXCRECOVFROMPL";
            public const string  EXCRETNO = "EXCRETNO";
            public const string  EXCROUNDDIF = "EXCROUNDDIF";
            public const string  EXCRTHNO = "EXCRTHNO";
            public const string  EXCRTHPONO = "EXCRTHPONO";
            public const string  EXCSALOFF = "EXCSALOFF";
            public const string  EXCSENCODE = "EXCSENCODE";
            public const string  EXCSENREF = "EXCSENREF";
            public const string  EXCSPETO = "EXCSPETO";
            public const string  EXCTOBASERATE = "EXCTOBASERATE";
            public const string  EXCTOEUROEXCRATE = "EXCTOEUROEXCRATE";
            public const string  INVEXCHRATE = "INVEXCHRATE";
            public const string  OPENCHARGEID = "OPENCHARGEID";
            public const string  TRIANGULATED = "TRIANGULATED";
 // ReSharper restore InconsistentNaming
        }


    }

}
