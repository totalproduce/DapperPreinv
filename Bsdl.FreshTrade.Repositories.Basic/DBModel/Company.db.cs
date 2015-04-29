// <summary>
// This file is generated automatically. Any changes will be lost.
// </summary>

using System;
using System.Collections.Generic;
using System.Globalization;
using Bsdl.FreshTrade.Repositories.Basic.DBModel;
using Bsdl.FreshTrade.Repositories.Basic.Persistance;

namespace Bsdl.FreshTrade.Repositories.Basic.DBModel
{
    /// <summary>
    /// Entity for the COMPANY table
    /// </summary>
    public partial class Company : BaseDbModel<Company, int>
    {
#region tableDefs

       public static List<EntityPropDef> GetPropDefs() {
         var result = new List<EntityPropDef>();

//EntityPropDef(string propName, string columnName, bool isKey, bool isNullable, string refEntityName, PropertyInfo keyPropInfo,
//            int size, int? prec, int? scale)



         result.Add(new EntityPropDef(
         PropertyHelper <Company>.GetProperty(x => x.Compglbrecno),
         "COMPGLBRECNO", // columnName
         true,                    //isKey
         false, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  5, // int? prec
                           0  // int? Scale
         ,
         typeof(Company)
       ));


         result.Add(new EntityPropDef(
         PropertyHelper <Company>.GetProperty(x => x.AgressoBranchid),
         "AGRESSO_BRANCHID", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         4,       // int size   
                  null, // int? prec
                   
         null // int? Scale
         ,
         typeof(Company)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <Company>.GetProperty(x => x.Compadd1),
         "COMPADD1", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         40,       // int size   
                  null, // int? prec
                   
         null // int? Scale
         ,
         typeof(Company)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <Company>.GetProperty(x => x.Compadd2),
         "COMPADD2", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         40,       // int size   
                  null, // int? prec
                   
         null // int? Scale
         ,
         typeof(Company)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <Company>.GetProperty(x => x.Compadd3),
         "COMPADD3", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         40,       // int size   
                  null, // int? prec
                   
         null // int? Scale
         ,
         typeof(Company)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <Company>.GetProperty(x => x.Compadd4),
         "COMPADD4", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         40,       // int size   
                  null, // int? prec
                   
         null // int? Scale
         ,
         typeof(Company)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <Company>.GetProperty(x => x.Companano),
         "COMPANANO", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         13,       // int size   
                  null, // int? prec
                   
         null // int? Scale
         ,
         typeof(Company)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <Company>.GetProperty(x => x.Companyname),
         "COMPANYNAME", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         40,       // int size   
                  null, // int? prec
                   
         null // int? Scale
         ,
         typeof(Company)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <Company>.GetProperty(x => x.Compcountryno),
         "COMPCOUNTRYNO", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  5, // int? prec
                           0  // int? Scale
         ,
         typeof(Company)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <Company>.GetProperty(x => x.Compemail),
         "COMPEMAIL", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         30,       // int size   
                  null, // int? prec
                   
         null // int? Scale
         ,
         typeof(Company)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <Company>.GetProperty(x => x.Compfax),
         "COMPFAX", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         15,       // int size   
                  null, // int? prec
                   
         null // int? Scale
         ,
         typeof(Company)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <Company>.GetProperty(x => x.Compphone),
         "COMPPHONE", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         15,       // int size   
                  null, // int? prec
                   
         null // int? Scale
         ,
         typeof(Company)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <Company>.GetProperty(x => x.Comppostcode),
         "COMPPOSTCODE", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         9,       // int size   
                  null, // int? prec
                   
         null // int? Scale
         ,
         typeof(Company)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <Company>.GetProperty(x => x.Compshortcode),
         "COMPSHORTCODE", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         20,       // int size   
                  null, // int? prec
                   
         null // int? Scale
         ,
         typeof(Company)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <Company>.GetProperty(x => x.Compvatno),
         "COMPVATNO", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         15,       // int size   
                  null, // int? prec
                   
         null // int? Scale
         ,
         typeof(Company)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <Company>.GetProperty(x => x.Intrataxidentifier),
         "INTRATAXIDENTIFIER", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         20,       // int size   
                  null, // int? prec
                   
         null // int? Scale
         ,
         typeof(Company)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <Company>.GetProperty(x => x.Intratraderbranchid),
         "INTRATRADERBRANCHID", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         3,       // int size   
                  null, // int? prec
                   
         null // int? Scale
         ,
         typeof(Company)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <Company>.GetProperty(x => x.Intratradername),
         "INTRATRADERNAME", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         30,       // int size   
                  null, // int? prec
                   
         null // int? Scale
         ,
         typeof(Company)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <Company>.GetProperty(x => x.Packhousecode),
         "PACKHOUSECODE", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         2,       // int size   
                  null, // int? prec
                   
         null // int? Scale
         ,
         typeof(Company)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <Company>.GetProperty(x => x.Prophetediextract),
         "PROPHETEDIEXTRACT", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  10, // int? prec
                           0  // int? Scale
         ,
         typeof(Company)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <Company>.GetProperty(x => x.Saloffno),
         "SALOFFNO", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  5, // int? prec
                           0  // int? Scale
         ,
         typeof(Company)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <Company>.GetProperty(x => x.Ssccanano),
         "SSCCANANO", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         10,       // int size   
                  null, // int? prec
                   
         null // int? Scale
         ,
         typeof(Company)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <Company>.GetProperty(x => x.Tradacomidentity),
         "TRADACOMIDENTITY", // columnName
         false,                    //isKey
         true, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         20,       // int size   
                  null, // int? prec
                   
         null // int? Scale
         ,
         typeof(Company)
         ));
         return result; 
       }

#endregion     
        private int _fCompglbrecno;
        public int Compglbrecno
        {
            get { return _fCompglbrecno; }
            set
            {
                var oldKey = Key;
                if (_fCompglbrecno != value)
                {
                    Modify();
                    _fCompglbrecno = value;
                    KeyChanged(oldKey);
                }
            }
        }

        private string _fAgressoBranchid;
        public string AgressoBranchid
        {
            get { return _fAgressoBranchid; }
            set
            {
                if (_fAgressoBranchid != value)
                {
                    Modify();
                    _fAgressoBranchid = value;
                }
            }
        }

        private string _fCompadd1;
        public string Compadd1
        {
            get { return _fCompadd1; }
            set
            {
                if (_fCompadd1 != value)
                {
                    Modify();
                    _fCompadd1 = value;
                }
            }
        }

        private string _fCompadd2;
        public string Compadd2
        {
            get { return _fCompadd2; }
            set
            {
                if (_fCompadd2 != value)
                {
                    Modify();
                    _fCompadd2 = value;
                }
            }
        }

        private string _fCompadd3;
        public string Compadd3
        {
            get { return _fCompadd3; }
            set
            {
                if (_fCompadd3 != value)
                {
                    Modify();
                    _fCompadd3 = value;
                }
            }
        }

        private string _fCompadd4;
        public string Compadd4
        {
            get { return _fCompadd4; }
            set
            {
                if (_fCompadd4 != value)
                {
                    Modify();
                    _fCompadd4 = value;
                }
            }
        }

        private string _fCompanano;
        public string Companano
        {
            get { return _fCompanano; }
            set
            {
                if (_fCompanano != value)
                {
                    Modify();
                    _fCompanano = value;
                }
            }
        }

        private string _fCompanyname;
        public string Companyname
        {
            get { return _fCompanyname; }
            set
            {
                if (_fCompanyname != value)
                {
                    Modify();
                    _fCompanyname = value;
                }
            }
        }

        private int? _fCompcountryno;
        public int? Compcountryno
        {
            get { return _fCompcountryno; }
            set
            {
                if (_fCompcountryno != value)
                {
                    Modify();
                    _fCompcountryno = value;
                }
            }
        }

        private string _fCompemail;
        public string Compemail
        {
            get { return _fCompemail; }
            set
            {
                if (_fCompemail != value)
                {
                    Modify();
                    _fCompemail = value;
                }
            }
        }

        private string _fCompfax;
        public string Compfax
        {
            get { return _fCompfax; }
            set
            {
                if (_fCompfax != value)
                {
                    Modify();
                    _fCompfax = value;
                }
            }
        }

        private string _fCompphone;
        public string Compphone
        {
            get { return _fCompphone; }
            set
            {
                if (_fCompphone != value)
                {
                    Modify();
                    _fCompphone = value;
                }
            }
        }

        private string _fComppostcode;
        public string Comppostcode
        {
            get { return _fComppostcode; }
            set
            {
                if (_fComppostcode != value)
                {
                    Modify();
                    _fComppostcode = value;
                }
            }
        }

        private string _fCompshortcode;
        public string Compshortcode
        {
            get { return _fCompshortcode; }
            set
            {
                if (_fCompshortcode != value)
                {
                    Modify();
                    _fCompshortcode = value;
                }
            }
        }

        private string _fCompvatno;
        public string Compvatno
        {
            get { return _fCompvatno; }
            set
            {
                if (_fCompvatno != value)
                {
                    Modify();
                    _fCompvatno = value;
                }
            }
        }

        private string _fIntrataxidentifier;
        public string Intrataxidentifier
        {
            get { return _fIntrataxidentifier; }
            set
            {
                if (_fIntrataxidentifier != value)
                {
                    Modify();
                    _fIntrataxidentifier = value;
                }
            }
        }

        private string _fIntratraderbranchid;
        public string Intratraderbranchid
        {
            get { return _fIntratraderbranchid; }
            set
            {
                if (_fIntratraderbranchid != value)
                {
                    Modify();
                    _fIntratraderbranchid = value;
                }
            }
        }

        private string _fIntratradername;
        public string Intratradername
        {
            get { return _fIntratradername; }
            set
            {
                if (_fIntratradername != value)
                {
                    Modify();
                    _fIntratradername = value;
                }
            }
        }

        private string _fPackhousecode;
        public string Packhousecode
        {
            get { return _fPackhousecode; }
            set
            {
                if (_fPackhousecode != value)
                {
                    Modify();
                    _fPackhousecode = value;
                }
            }
        }

        private int? _fProphetediextract;
        public int? Prophetediextract
        {
            get { return _fProphetediextract; }
            set
            {
                if (_fProphetediextract != value)
                {
                    Modify();
                    _fProphetediextract = value;
                }
            }
        }

        private int? _fSaloffno;
        public int? Saloffno
        {
            get { return _fSaloffno; }
            set
            {
                if (_fSaloffno != value)
                {
                    Modify();
                    _fSaloffno = value;
                }
            }
        }

        private string _fSsccanano;
        public string Ssccanano
        {
            get { return _fSsccanano; }
            set
            {
                if (_fSsccanano != value)
                {
                    Modify();
                    _fSsccanano = value;
                }
            }
        }

        private string _fTradacomidentity;
        public string Tradacomidentity
        {
            get { return _fTradacomidentity; }
            set
            {
                if (_fTradacomidentity != value)
                {
                    Modify();
                    _fTradacomidentity = value;
                }
            }
        }

        public override int Key
        {
            get { return Compglbrecno; }
            set { Compglbrecno = value; }
        }

        public override string KeyAsString { get { return Key.ToString(CultureInfo.InvariantCulture); } }


        public override Company Clone()
        {
            var obj = new Company
                {
                    Compglbrecno = Compglbrecno,
                    AgressoBranchid = AgressoBranchid,
                    Compadd1 = Compadd1,
                    Compadd2 = Compadd2,
                    Compadd3 = Compadd3,
                    Compadd4 = Compadd4,
                    Companano = Companano,
                    Companyname = Companyname,
                    Compcountryno = Compcountryno,
                    Compemail = Compemail,
                    Compfax = Compfax,
                    Compphone = Compphone,
                    Comppostcode = Comppostcode,
                    Compshortcode = Compshortcode,
                    Compvatno = Compvatno,
                    Intrataxidentifier = Intrataxidentifier,
                    Intratraderbranchid = Intratraderbranchid,
                    Intratradername = Intratradername,
                    Packhousecode = Packhousecode,
                    Prophetediextract = Prophetediextract,
                    Saloffno = Saloffno,
                    Ssccanano = Ssccanano,
                    Tradacomidentity = Tradacomidentity,
                };

            return obj;
        }

        public static class FieldNames
        {
// ReSharper disable InconsistentNaming
            public const string  COMPGLBRECNO = "COMPGLBRECNO";
            public const string  AGRESSO_BRANCHID = "AGRESSO_BRANCHID";
            public const string  COMPADD1 = "COMPADD1";
            public const string  COMPADD2 = "COMPADD2";
            public const string  COMPADD3 = "COMPADD3";
            public const string  COMPADD4 = "COMPADD4";
            public const string  COMPANANO = "COMPANANO";
            public const string  COMPANYNAME = "COMPANYNAME";
            public const string  COMPCOUNTRYNO = "COMPCOUNTRYNO";
            public const string  COMPEMAIL = "COMPEMAIL";
            public const string  COMPFAX = "COMPFAX";
            public const string  COMPPHONE = "COMPPHONE";
            public const string  COMPPOSTCODE = "COMPPOSTCODE";
            public const string  COMPSHORTCODE = "COMPSHORTCODE";
            public const string  COMPVATNO = "COMPVATNO";
            public const string  INTRATAXIDENTIFIER = "INTRATAXIDENTIFIER";
            public const string  INTRATRADERBRANCHID = "INTRATRADERBRANCHID";
            public const string  INTRATRADERNAME = "INTRATRADERNAME";
            public const string  PACKHOUSECODE = "PACKHOUSECODE";
            public const string  PROPHETEDIEXTRACT = "PROPHETEDIEXTRACT";
            public const string  SALOFFNO = "SALOFFNO";
            public const string  SSCCANANO = "SSCCANANO";
            public const string  TRADACOMIDENTITY = "TRADACOMIDENTITY";
 // ReSharper restore InconsistentNaming
        }


    }

}
