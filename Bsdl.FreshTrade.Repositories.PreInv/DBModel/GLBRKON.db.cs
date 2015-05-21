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
    /// Entity for the GLBRKON table
    /// </summary>
    public partial class GLBRKON : BaseDbModel<GLBRKON, int>
    {
#region tableDefs

       public static List<EntityPropDef> GetPropDefs() {
         var result = new List<EntityPropDef>();

//EntityPropDef(string propName, string columnName, bool isKey, bool isNullable, string refEntityName, PropertyInfo keyPropInfo,
//            int size, int? prec, int? scale)



         result.Add(new EntityPropDef(
         PropertyHelper <GLBRKON>.GetProperty(x => x.Glbrecno),
         "GLBRECNO", // columnName
         true,                    //isKey
         false, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  5, // int? prec
                           0  // int? Scale
         ,
         typeof(GLBRKON)
       ));


         result.Add(new EntityPropDef(
         PropertyHelper <GLBRKON>.GetProperty(x => x.Glbaccindno),
         "GLBACCINDNO", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  5, // int? prec
                           0  // int? Scale
         ,
         typeof(GLBRKON)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <GLBRKON>.GetProperty(x => x.Glbancchgtype),
         "GLBANCCHGTYPE", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  5, // int? prec
                           0  // int? Scale
         ,
         typeof(GLBRKON)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <GLBRKON>.GetProperty(x => x.Glbanctype),
         "GLBANCTYPE", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  5, // int? prec
                           0  // int? Scale
         ,
         typeof(GLBRKON)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <GLBRKON>.GetProperty(x => x.Glbbankno),
         "GLBBANKNO", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  5, // int? prec
                           0  // int? Scale
         ,
         typeof(GLBRKON)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <GLBRKON>.GetProperty(x => x.Glbcatchalldesc),
         "GLBCATCHALLDESC", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         50,       // int size   
                  null, // int? prec
                   
         null // int? Scale
         ,
         typeof(GLBRKON)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <GLBRKON>.GetProperty(x => x.Glbcatchallrec),
         "GLBCATCHALLREC", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  1, // int? prec
                           0  // int? Scale
         ,
         typeof(GLBRKON)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <GLBRKON>.GetProperty(x => x.Glbchgtypno),
         "GLBCHGTYPNO", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  5, // int? prec
                           0  // int? Scale
         ,
         typeof(GLBRKON)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <GLBRKON>.GetProperty(x => x.Glbcomptypeno),
         "GLBCOMPTYPENO", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  5, // int? prec
                           0  // int? Scale
         ,
         typeof(GLBRKON)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <GLBRKON>.GetProperty(x => x.Glbcountry),
         "GLBCOUNTRY", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  5, // int? prec
                           0  // int? Scale
         ,
         typeof(GLBRKON)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <GLBRKON>.GetProperty(x => x.Glbcurno),
         "GLBCURNO", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  5, // int? prec
                           0  // int? Scale
         ,
         typeof(GLBRKON)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <GLBRKON>.GetProperty(x => x.Glbdisglrecno),
         "GLBDISGLRECNO", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  5, // int? prec
                           0  // int? Scale
         ,
         typeof(GLBRKON)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <GLBRKON>.GetProperty(x => x.Glbexpcat),
         "GLBEXPCAT", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  10, // int? prec
                           0  // int? Scale
         ,
         typeof(GLBRKON)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <GLBRKON>.GetProperty(x => x.Glbganrec),
         "GLBGANREC", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  10, // int? prec
                           0  // int? Scale
         ,
         typeof(GLBRKON)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <GLBRKON>.GetProperty(x => x.Glbglxrcode),
         "GLBGLXRCODE", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         20,       // int size   
                  null, // int? prec
                   
         null // int? Scale
         ,
         typeof(GLBRKON)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <GLBRKON>.GetProperty(x => x.Glblogisticsaloffno),
         "GLBLOGISTICSALOFFNO", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  5, // int? prec
                           0  // int? Scale
         ,
         typeof(GLBRKON)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <GLBRKON>.GetProperty(x => x.Glbpoglgrprecno),
         "GLBPOGLGRPRECNO", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  5, // int? prec
                           0  // int? Scale
         ,
         typeof(GLBRKON)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <GLBRKON>.GetProperty(x => x.Glbprdlnkno),
         "GLBPRDLNKNO", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  5, // int? prec
                           0  // int? Scale
         ,
         typeof(GLBRKON)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <GLBRKON>.GetProperty(x => x.Glbpreancgrp),
         "GLBPREANCGRP", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  5, // int? prec
                           0  // int? Scale
         ,
         typeof(GLBRKON)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <GLBRKON>.GetProperty(x => x.Glbprechggrpno),
         "GLBPRECHGGRPNO", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  5, // int? prec
                           0  // int? Scale
         ,
         typeof(GLBRKON)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <GLBRKON>.GetProperty(x => x.Glbpreresgrp),
         "GLBPRERESGRP", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  5, // int? prec
                           0  // int? Scale
         ,
         typeof(GLBRKON)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <GLBRKON>.GetProperty(x => x.Glbrecipetyp),
         "GLBRECIPETYP", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  5, // int? prec
                           0  // int? Scale
         ,
         typeof(GLBRKON)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <GLBRKON>.GetProperty(x => x.Glbsaloffno),
         "GLBSALOFFNO", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  5, // int? prec
                           0  // int? Scale
         ,
         typeof(GLBRKON)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <GLBRKON>.GetProperty(x => x.Glbstoclocno),
         "GLBSTOCLOCNO", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  5, // int? prec
                           0  // int? Scale
         ,
         typeof(GLBRKON)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <GLBRKON>.GetProperty(x => x.Glbtranfromsaloff),
         "GLBTRANFROMSALOFF", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  5, // int? prec
                           0  // int? Scale
         ,
         typeof(GLBRKON)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <GLBRKON>.GetProperty(x => x.Glbtrantosaloff),
         "GLBTRANTOSALOFF", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  5, // int? prec
                           0  // int? Scale
         ,
         typeof(GLBRKON)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <GLBRKON>.GetProperty(x => x.Glbvatrecno),
         "GLBVATRECNO", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  5, // int? prec
                           0  // int? Scale
         ,
         typeof(GLBRKON)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <GLBRKON>.GetProperty(x => x.Glbvattypeno),
         "GLBVATTYPENO", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  5, // int? prec
                           0  // int? Scale
         ,
         typeof(GLBRKON)
         ));
         return result; 
       }

#endregion     
        private int _fGlbrecno;
        public int Glbrecno
        {
            get { return _fGlbrecno; }
            set
            {
                var oldKey = Key;
                if (_fGlbrecno != value)
                {
                    Modify();
                    _fGlbrecno = value;
                    KeyChanged(oldKey);
                }
            }
        }

        private int? _fGlbaccindno;
        public int? Glbaccindno
        {
            get { return _fGlbaccindno; }
            set
            {
                if (_fGlbaccindno != value)
                {
                    Modify();
                    _fGlbaccindno = value;
                }
            }
        }

        private int? _fGlbancchgtype;
        public int? Glbancchgtype
        {
            get { return _fGlbancchgtype; }
            set
            {
                if (_fGlbancchgtype != value)
                {
                    Modify();
                    _fGlbancchgtype = value;
                }
            }
        }

        private int? _fGlbanctype;
        public int? Glbanctype
        {
            get { return _fGlbanctype; }
            set
            {
                if (_fGlbanctype != value)
                {
                    Modify();
                    _fGlbanctype = value;
                }
            }
        }

        private int? _fGlbbankno;
        public int? Glbbankno
        {
            get { return _fGlbbankno; }
            set
            {
                if (_fGlbbankno != value)
                {
                    Modify();
                    _fGlbbankno = value;
                }
            }
        }

        private string _fGlbcatchalldesc;
        public string Glbcatchalldesc
        {
            get { return _fGlbcatchalldesc; }
            set
            {
                if (_fGlbcatchalldesc != value)
                {
                    Modify();
                    _fGlbcatchalldesc = value;
                }
            }
        }

        private short? _fGlbcatchallrec;
        public short? Glbcatchallrec
        {
            get { return _fGlbcatchallrec; }
            set
            {
                if (_fGlbcatchallrec != value)
                {
                    Modify();
                    _fGlbcatchallrec = value;
                }
            }
        }

        private int? _fGlbchgtypno;
        public int? Glbchgtypno
        {
            get { return _fGlbchgtypno; }
            set
            {
                if (_fGlbchgtypno != value)
                {
                    Modify();
                    _fGlbchgtypno = value;
                }
            }
        }

        private int? _fGlbcomptypeno;
        public int? Glbcomptypeno
        {
            get { return _fGlbcomptypeno; }
            set
            {
                if (_fGlbcomptypeno != value)
                {
                    Modify();
                    _fGlbcomptypeno = value;
                }
            }
        }

        private int? _fGlbcountry;
        public int? Glbcountry
        {
            get { return _fGlbcountry; }
            set
            {
                if (_fGlbcountry != value)
                {
                    Modify();
                    _fGlbcountry = value;
                }
            }
        }

        private int? _fGlbcurno;
        public int? Glbcurno
        {
            get { return _fGlbcurno; }
            set
            {
                if (_fGlbcurno != value)
                {
                    Modify();
                    _fGlbcurno = value;
                }
            }
        }

        private int? _fGlbdisglrecno;
        public int? Glbdisglrecno
        {
            get { return _fGlbdisglrecno; }
            set
            {
                if (_fGlbdisglrecno != value)
                {
                    Modify();
                    _fGlbdisglrecno = value;
                }
            }
        }

        private int? _fGlbexpcat;
        public int? Glbexpcat
        {
            get { return _fGlbexpcat; }
            set
            {
                if (_fGlbexpcat != value)
                {
                    Modify();
                    _fGlbexpcat = value;
                }
            }
        }

        private int? _fGlbganrec;
        public int? Glbganrec
        {
            get { return _fGlbganrec; }
            set
            {
                if (_fGlbganrec != value)
                {
                    Modify();
                    _fGlbganrec = value;
                }
            }
        }

        private string _fGlbglxrcode;
        public string Glbglxrcode
        {
            get { return _fGlbglxrcode; }
            set
            {
                if (_fGlbglxrcode != value)
                {
                    Modify();
                    _fGlbglxrcode = value;
                }
            }
        }

        private int? _fGlblogisticsaloffno;
        public int? Glblogisticsaloffno
        {
            get { return _fGlblogisticsaloffno; }
            set
            {
                if (_fGlblogisticsaloffno != value)
                {
                    Modify();
                    _fGlblogisticsaloffno = value;
                }
            }
        }

        private int? _fGlbpoglgrprecno;
        public int? Glbpoglgrprecno
        {
            get { return _fGlbpoglgrprecno; }
            set
            {
                if (_fGlbpoglgrprecno != value)
                {
                    Modify();
                    _fGlbpoglgrprecno = value;
                }
            }
        }

        private int? _fGlbprdlnkno;
        public int? Glbprdlnkno
        {
            get { return _fGlbprdlnkno; }
            set
            {
                if (_fGlbprdlnkno != value)
                {
                    Modify();
                    _fGlbprdlnkno = value;
                }
            }
        }

        private int? _fGlbpreancgrp;
        public int? Glbpreancgrp
        {
            get { return _fGlbpreancgrp; }
            set
            {
                if (_fGlbpreancgrp != value)
                {
                    Modify();
                    _fGlbpreancgrp = value;
                }
            }
        }

        private int? _fGlbprechggrpno;
        public int? Glbprechggrpno
        {
            get { return _fGlbprechggrpno; }
            set
            {
                if (_fGlbprechggrpno != value)
                {
                    Modify();
                    _fGlbprechggrpno = value;
                }
            }
        }

        private int? _fGlbpreresgrp;
        public int? Glbpreresgrp
        {
            get { return _fGlbpreresgrp; }
            set
            {
                if (_fGlbpreresgrp != value)
                {
                    Modify();
                    _fGlbpreresgrp = value;
                }
            }
        }

        private int? _fGlbrecipetyp;
        public int? Glbrecipetyp
        {
            get { return _fGlbrecipetyp; }
            set
            {
                if (_fGlbrecipetyp != value)
                {
                    Modify();
                    _fGlbrecipetyp = value;
                }
            }
        }

        private int? _fGlbsaloffno;
        public int? Glbsaloffno
        {
            get { return _fGlbsaloffno; }
            set
            {
                if (_fGlbsaloffno != value)
                {
                    Modify();
                    _fGlbsaloffno = value;
                }
            }
        }

        private int? _fGlbstoclocno;
        public int? Glbstoclocno
        {
            get { return _fGlbstoclocno; }
            set
            {
                if (_fGlbstoclocno != value)
                {
                    Modify();
                    _fGlbstoclocno = value;
                }
            }
        }

        private int? _fGlbtranfromsaloff;
        public int? Glbtranfromsaloff
        {
            get { return _fGlbtranfromsaloff; }
            set
            {
                if (_fGlbtranfromsaloff != value)
                {
                    Modify();
                    _fGlbtranfromsaloff = value;
                }
            }
        }

        private int? _fGlbtrantosaloff;
        public int? Glbtrantosaloff
        {
            get { return _fGlbtrantosaloff; }
            set
            {
                if (_fGlbtrantosaloff != value)
                {
                    Modify();
                    _fGlbtrantosaloff = value;
                }
            }
        }

        private int? _fGlbvatrecno;
        public int? Glbvatrecno
        {
            get { return _fGlbvatrecno; }
            set
            {
                if (_fGlbvatrecno != value)
                {
                    Modify();
                    _fGlbvatrecno = value;
                }
            }
        }

        private int? _fGlbvattypeno;
        public int? Glbvattypeno
        {
            get { return _fGlbvattypeno; }
            set
            {
                if (_fGlbvattypeno != value)
                {
                    Modify();
                    _fGlbvattypeno = value;
                }
            }
        }

        public override int Key
        {
            get { return Glbrecno; }
            set { Glbrecno = value; }
        }

        public override string KeyAsString { get { return Key.ToString(CultureInfo.InvariantCulture); } }


        public override GLBRKON Clone()
        {
            var obj = new GLBRKON
                {
                    Glbrecno = Glbrecno,
                    Glbaccindno = Glbaccindno,
                    Glbancchgtype = Glbancchgtype,
                    Glbanctype = Glbanctype,
                    Glbbankno = Glbbankno,
                    Glbcatchalldesc = Glbcatchalldesc,
                    Glbcatchallrec = Glbcatchallrec,
                    Glbchgtypno = Glbchgtypno,
                    Glbcomptypeno = Glbcomptypeno,
                    Glbcountry = Glbcountry,
                    Glbcurno = Glbcurno,
                    Glbdisglrecno = Glbdisglrecno,
                    Glbexpcat = Glbexpcat,
                    Glbganrec = Glbganrec,
                    Glbglxrcode = Glbglxrcode,
                    Glblogisticsaloffno = Glblogisticsaloffno,
                    Glbpoglgrprecno = Glbpoglgrprecno,
                    Glbprdlnkno = Glbprdlnkno,
                    Glbpreancgrp = Glbpreancgrp,
                    Glbprechggrpno = Glbprechggrpno,
                    Glbpreresgrp = Glbpreresgrp,
                    Glbrecipetyp = Glbrecipetyp,
                    Glbsaloffno = Glbsaloffno,
                    Glbstoclocno = Glbstoclocno,
                    Glbtranfromsaloff = Glbtranfromsaloff,
                    Glbtrantosaloff = Glbtrantosaloff,
                    Glbvatrecno = Glbvatrecno,
                    Glbvattypeno = Glbvattypeno,
                };

            return obj;
        }

        public static class FieldNames
        {
// ReSharper disable InconsistentNaming
            public const string  GLBRECNO = "GLBRECNO";
            public const string  GLBACCINDNO = "GLBACCINDNO";
            public const string  GLBANCCHGTYPE = "GLBANCCHGTYPE";
            public const string  GLBANCTYPE = "GLBANCTYPE";
            public const string  GLBBANKNO = "GLBBANKNO";
            public const string  GLBCATCHALLDESC = "GLBCATCHALLDESC";
            public const string  GLBCATCHALLREC = "GLBCATCHALLREC";
            public const string  GLBCHGTYPNO = "GLBCHGTYPNO";
            public const string  GLBCOMPTYPENO = "GLBCOMPTYPENO";
            public const string  GLBCOUNTRY = "GLBCOUNTRY";
            public const string  GLBCURNO = "GLBCURNO";
            public const string  GLBDISGLRECNO = "GLBDISGLRECNO";
            public const string  GLBEXPCAT = "GLBEXPCAT";
            public const string  GLBGANREC = "GLBGANREC";
            public const string  GLBGLXRCODE = "GLBGLXRCODE";
            public const string  GLBLOGISTICSALOFFNO = "GLBLOGISTICSALOFFNO";
            public const string  GLBPOGLGRPRECNO = "GLBPOGLGRPRECNO";
            public const string  GLBPRDLNKNO = "GLBPRDLNKNO";
            public const string  GLBPREANCGRP = "GLBPREANCGRP";
            public const string  GLBPRECHGGRPNO = "GLBPRECHGGRPNO";
            public const string  GLBPRERESGRP = "GLBPRERESGRP";
            public const string  GLBRECIPETYP = "GLBRECIPETYP";
            public const string  GLBSALOFFNO = "GLBSALOFFNO";
            public const string  GLBSTOCLOCNO = "GLBSTOCLOCNO";
            public const string  GLBTRANFROMSALOFF = "GLBTRANFROMSALOFF";
            public const string  GLBTRANTOSALOFF = "GLBTRANTOSALOFF";
            public const string  GLBVATRECNO = "GLBVATRECNO";
            public const string  GLBVATTYPENO = "GLBVATTYPENO";
 // ReSharper restore InconsistentNaming
        }


    }

}
