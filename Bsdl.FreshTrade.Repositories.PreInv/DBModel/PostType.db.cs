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
    /// Entity for the POSTTYPE table
    /// </summary>
    public partial class PostType : BaseDbModel<PostType, int>
    {
#region tableDefs

       public static List<EntityPropDef> GetPropDefs() {
         var result = new List<EntityPropDef>();

//EntityPropDef(string propName, string columnName, bool isKey, bool isNullable, string refEntityName, PropertyInfo keyPropInfo,
//            int size, int? prec, int? scale)



         result.Add(new EntityPropDef(
         PropertyHelper <PostType>.GetProperty(x => x.Pstrecno),
         "PSTRECNO", // columnName
         true,                    //isKey
         false, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  5, // int? prec
                           0  // int? Scale
         ,
         typeof(PostType)
       ));


         result.Add(new EntityPropDef(
         PropertyHelper <PostType>.GetProperty(x => x.Dbtcdtno),
         "DBTCDTNO", // columnName
         false,                    //isKey
         false, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  5, // int? prec
                           0  // int? Scale
         ,
         typeof(PostType)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <PostType>.GetProperty(x => x.Instatementtypes),
         "INSTATEMENTTYPES", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  5, // int? prec
                           0  // int? Scale
         ,
         typeof(PostType)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <PostType>.GetProperty(x => x.Pstdesc),
         "PSTDESC", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         15,       // int size   
                  null, // int? prec
                   
         null // int? Scale
         ,
         typeof(PostType)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <PostType>.GetProperty(x => x.Pstledger),
         "PSTLEDGER", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         15,       // int size   
                  null, // int? prec
                   
         null // int? Scale
         ,
         typeof(PostType)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <PostType>.GetProperty(x => x.Psttype),
         "PSTTYPE", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         3,       // int size   
                  null, // int? prec
                   
         null // int? Scale
         ,
         typeof(PostType)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <PostType>.GetProperty(x => x.Purpayind),
         "PURPAYIND", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  1, // int? prec
                           0  // int? Scale
         ,
         typeof(PostType)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <PostType>.GetProperty(x => x.Restrictind),
         "RESTRICTIND", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  1, // int? prec
                           0  // int? Scale
         ,
         typeof(PostType)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <PostType>.GetProperty(x => x.Turnoverind),
         "TURNOVERIND", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  1, // int? prec
                           0  // int? Scale
         ,
         typeof(PostType)
         ));
         return result; 
       }

#endregion     
        private int _fPstrecno;
        public int Pstrecno
        {
            get { return _fPstrecno; }
            set
            {
                var oldKey = Key;
                if (_fPstrecno != value)
                {
                    Modify();
                    _fPstrecno = value;
                    KeyChanged(oldKey);
                }
            }
        }

        private int _fDbtcdtno;
        public int Dbtcdtno
        {
            get { return _fDbtcdtno; }
            set
            {
                if (_fDbtcdtno != value)
                {
                    Modify();
                    _fDbtcdtno = value;
                }
            }
        }

        private int? _fInstatementtypes;
        public int? Instatementtypes
        {
            get { return _fInstatementtypes; }
            set
            {
                if (_fInstatementtypes != value)
                {
                    Modify();
                    _fInstatementtypes = value;
                }
            }
        }

        private string _fPstdesc;
        public string Pstdesc
        {
            get { return _fPstdesc; }
            set
            {
                if (_fPstdesc != value)
                {
                    Modify();
                    _fPstdesc = value;
                }
            }
        }

        private string _fPstledger;
        public string Pstledger
        {
            get { return _fPstledger; }
            set
            {
                if (_fPstledger != value)
                {
                    Modify();
                    _fPstledger = value;
                }
            }
        }

        private string _fPsttype;
        public string Psttype
        {
            get { return _fPsttype; }
            set
            {
                if (_fPsttype != value)
                {
                    Modify();
                    _fPsttype = value;
                }
            }
        }

        private short? _fPurpayind;
        public short? Purpayind
        {
            get { return _fPurpayind; }
            set
            {
                if (_fPurpayind != value)
                {
                    Modify();
                    _fPurpayind = value;
                }
            }
        }

        private short? _fRestrictind;
        public short? Restrictind
        {
            get { return _fRestrictind; }
            set
            {
                if (_fRestrictind != value)
                {
                    Modify();
                    _fRestrictind = value;
                }
            }
        }

        private short? _fTurnoverind;
        public short? Turnoverind
        {
            get { return _fTurnoverind; }
            set
            {
                if (_fTurnoverind != value)
                {
                    Modify();
                    _fTurnoverind = value;
                }
            }
        }

        public override int Key
        {
            get { return Pstrecno; }
            set { Pstrecno = value; }
        }

        public override string KeyAsString { get { return Key.ToString(CultureInfo.InvariantCulture); } }


        public override PostType Clone()
        {
            var obj = new PostType
                {
                    Pstrecno = Pstrecno,
                    Dbtcdtno = Dbtcdtno,
                    Instatementtypes = Instatementtypes,
                    Pstdesc = Pstdesc,
                    Pstledger = Pstledger,
                    Psttype = Psttype,
                    Purpayind = Purpayind,
                    Restrictind = Restrictind,
                    Turnoverind = Turnoverind,
                };

            return obj;
        }

        public static class FieldNames
        {
// ReSharper disable InconsistentNaming
            public const string  PSTRECNO = "PSTRECNO";
            public const string  DBTCDTNO = "DBTCDTNO";
            public const string  INSTATEMENTTYPES = "INSTATEMENTTYPES";
            public const string  PSTDESC = "PSTDESC";
            public const string  PSTLEDGER = "PSTLEDGER";
            public const string  PSTTYPE = "PSTTYPE";
            public const string  PURPAYIND = "PURPAYIND";
            public const string  RESTRICTIND = "RESTRICTIND";
            public const string  TURNOVERIND = "TURNOVERIND";
 // ReSharper restore InconsistentNaming
        }


    }

}
