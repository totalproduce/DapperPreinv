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
    /// Entity for the ACCITE table
    /// </summary>
    public partial class Accite : BaseDbModel<Accite, int>
    {
#region tableDefs

       public static List<EntityPropDef> GetPropDefs() {
         var result = new List<EntityPropDef>();

//EntityPropDef(string propName, string columnName, bool isKey, bool isNullable, string refEntityName, PropertyInfo keyPropInfo,
//            int size, int? prec, int? scale)



         result.Add(new EntityPropDef(
         PropertyHelper <Accite>.GetProperty(x => x.Aitrecno),
         "AITRECNO", // columnName
         true,                    //isKey
         false, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  10, // int? prec
                           0  // int? Scale
         ,
         typeof(Accite)
       ));


         result.Add(new EntityPropDef(
         PropertyHelper <Accite>.GetProperty(x => x.Aitamount),
         "AITAMOUNT", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  126, // int? prec
                   
         null // int? Scale
         ,
         typeof(Accite)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <Accite>.GetProperty(x => x.Aitatrrecno),
         "AITATRRECNO", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  10, // int? prec
                           0  // int? Scale
         ,
         typeof(Accite)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <Accite>.GetProperty(x => x.Aitautlogno),
         "AITAUTLOGNO", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  5, // int? prec
                           0  // int? Scale
         ,
         typeof(Accite)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <Accite>.GetProperty(x => x.Aitbaseamount),
         "AITBASEAMOUNT", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  126, // int? prec
                   
         null // int? Scale
         ,
         typeof(Accite)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <Accite>.GetProperty(x => x.Aitdrcr),
         "AITDRCR", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         1,       // int size   
                  null, // int? prec
                   
         null // int? Scale
         ,
         typeof(Accite)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <Accite>.GetProperty(x => x.Aiteuroamount),
         "AITEUROAMOUNT", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  126, // int? prec
                   
         null // int? Scale
         ,
         typeof(Accite)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <Accite>.GetProperty(x => x.Aitganrecno),
         "AITGANRECNO", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  10, // int? prec
                           0  // int? Scale
         ,
         typeof(Accite)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <Accite>.GetProperty(x => x.Aitgltrecno),
         "AITGLTRECNO", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  10, // int? prec
                           0  // int? Scale
         ,
         typeof(Accite)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <Accite>.GetProperty(x => x.Aititerecno),
         "AITITERECNO", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  10, // int? prec
                           0  // int? Scale
         ,
         typeof(Accite)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <Accite>.GetProperty(x => x.Aititerevno),
         "AITITEREVNO", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  10, // int? prec
                           0  // int? Scale
         ,
         typeof(Accite)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <Accite>.GetProperty(x => x.Aitpstrecno),
         "AITPSTRECNO", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  5, // int? prec
                           0  // int? Scale
         ,
         typeof(Accite)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <Accite>.GetProperty(x => x.Aitsaloffno),
         "AITSALOFFNO", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  5, // int? prec
                           0  // int? Scale
         ,
         typeof(Accite)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <Accite>.GetProperty(x => x.Bankstmtdetrecno),
         "BANKSTMTDETRECNO", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  10, // int? prec
                           0  // int? Scale
         ,
         typeof(Accite)
         ));
         return result; 
       }

#endregion     
        private int _fAitrecno;
        public int Aitrecno
        {
            get { return _fAitrecno; }
            set
            {
                var oldKey = Key;
                if (_fAitrecno != value)
                {
                    Modify();
                    _fAitrecno = value;
                    KeyChanged(oldKey);
                }
            }
        }

        private decimal? _fAitamount;
        public decimal? Aitamount
        {
            get { return _fAitamount; }
            set
            {
                if (_fAitamount != value)
                {
                    Modify();
                    _fAitamount = value;
                }
            }
        }

        private int? _fAitatrrecno;
        public int? Aitatrrecno
        {
            get { return _fAitatrrecno; }
            set
            {
                if (_fAitatrrecno != value)
                {
                    Modify();
                    _fAitatrrecno = value;
                }
            }
        }

        private int? _fAitautlogno;
        public int? Aitautlogno
        {
            get { return _fAitautlogno; }
            set
            {
                if (_fAitautlogno != value)
                {
                    Modify();
                    _fAitautlogno = value;
                }
            }
        }

        private decimal? _fAitbaseamount;
        public decimal? Aitbaseamount
        {
            get { return _fAitbaseamount; }
            set
            {
                if (_fAitbaseamount != value)
                {
                    Modify();
                    _fAitbaseamount = value;
                }
            }
        }

        private string _fAitdrcr;
        public string Aitdrcr
        {
            get { return _fAitdrcr; }
            set
            {
                if (_fAitdrcr != value)
                {
                    Modify();
                    _fAitdrcr = value;
                }
            }
        }

        private decimal? _fAiteuroamount;
        public decimal? Aiteuroamount
        {
            get { return _fAiteuroamount; }
            set
            {
                if (_fAiteuroamount != value)
                {
                    Modify();
                    _fAiteuroamount = value;
                }
            }
        }

        private int? _fAitganrecno;
        public int? Aitganrecno
        {
            get { return _fAitganrecno; }
            set
            {
                if (_fAitganrecno != value)
                {
                    Modify();
                    _fAitganrecno = value;
                }
            }
        }

        private int? _fAitgltrecno;
        public int? Aitgltrecno
        {
            get { return _fAitgltrecno; }
            set
            {
                if (_fAitgltrecno != value)
                {
                    Modify();
                    _fAitgltrecno = value;
                }
            }
        }

        private int? _fAititerecno;
        public int? Aititerecno
        {
            get { return _fAititerecno; }
            set
            {
                if (_fAititerecno != value)
                {
                    Modify();
                    _fAititerecno = value;
                }
            }
        }

        private int? _fAititerevno;
        public int? Aititerevno
        {
            get { return _fAititerevno; }
            set
            {
                if (_fAititerevno != value)
                {
                    Modify();
                    _fAititerevno = value;
                }
            }
        }

        private int? _fAitpstrecno;
        public int? Aitpstrecno
        {
            get { return _fAitpstrecno; }
            set
            {
                if (_fAitpstrecno != value)
                {
                    Modify();
                    _fAitpstrecno = value;
                }
            }
        }

        private int? _fAitsaloffno;
        public int? Aitsaloffno
        {
            get { return _fAitsaloffno; }
            set
            {
                if (_fAitsaloffno != value)
                {
                    Modify();
                    _fAitsaloffno = value;
                }
            }
        }

        private int? _fBankstmtdetrecno;
        public int? Bankstmtdetrecno
        {
            get { return _fBankstmtdetrecno; }
            set
            {
                if (_fBankstmtdetrecno != value)
                {
                    Modify();
                    _fBankstmtdetrecno = value;
                }
            }
        }

        public override int Key
        {
            get { return Aitrecno; }
            set { Aitrecno = value; }
        }

        public override string KeyAsString { get { return Key.ToString(CultureInfo.InvariantCulture); } }


        public override Accite Clone()
        {
            var obj = new Accite
                {
                    Aitrecno = Aitrecno,
                    Aitamount = Aitamount,
                    Aitatrrecno = Aitatrrecno,
                    Aitautlogno = Aitautlogno,
                    Aitbaseamount = Aitbaseamount,
                    Aitdrcr = Aitdrcr,
                    Aiteuroamount = Aiteuroamount,
                    Aitganrecno = Aitganrecno,
                    Aitgltrecno = Aitgltrecno,
                    Aititerecno = Aititerecno,
                    Aititerevno = Aititerevno,
                    Aitpstrecno = Aitpstrecno,
                    Aitsaloffno = Aitsaloffno,
                    Bankstmtdetrecno = Bankstmtdetrecno,
                };

            return obj;
        }

        public static class FieldNames
        {
// ReSharper disable InconsistentNaming
            public const string  AITRECNO = "AITRECNO";
            public const string  AITAMOUNT = "AITAMOUNT";
            public const string  AITATRRECNO = "AITATRRECNO";
            public const string  AITAUTLOGNO = "AITAUTLOGNO";
            public const string  AITBASEAMOUNT = "AITBASEAMOUNT";
            public const string  AITDRCR = "AITDRCR";
            public const string  AITEUROAMOUNT = "AITEUROAMOUNT";
            public const string  AITGANRECNO = "AITGANRECNO";
            public const string  AITGLTRECNO = "AITGLTRECNO";
            public const string  AITITERECNO = "AITITERECNO";
            public const string  AITITEREVNO = "AITITEREVNO";
            public const string  AITPSTRECNO = "AITPSTRECNO";
            public const string  AITSALOFFNO = "AITSALOFFNO";
            public const string  BANKSTMTDETRECNO = "BANKSTMTDETRECNO";
 // ReSharper restore InconsistentNaming
        }


    }

}
