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
    /// Entity for the LOGTOSALOFF table
    /// </summary>
    public partial class LogToSalOff : BaseDbModel<LogToSalOff, LogToSalOffKey>
    {
#region tableDefs

       public static List<EntityPropDef> GetPropDefs() {
         var result = new List<EntityPropDef>();

//EntityPropDef(string propName, string columnName, bool isKey, bool isNullable, string refEntityName, PropertyInfo keyPropInfo,
//            int size, int? prec, int? scale)



         result.Add(new EntityPropDef(
         PropertyHelper <LogToSalOff>.GetProperty(x => x.Logonno),
         "LOGONNO", // columnName
         true,                    //isKey
         false, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  5, // int? prec
                           0  // int? Scale
         ,
         typeof(LogToSalOff)
       ));

         result.Add(new EntityPropDef(
         PropertyHelper <LogToSalOff>.GetProperty(x => x.Saloffno),
         "SALOFFNO", // columnName
         true,                    //isKey
         false, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  5, // int? prec
                           0  // int? Scale
         ,
         typeof(LogToSalOff)
       ));


         result.Add(new EntityPropDef(
         PropertyHelper <LogToSalOff>.GetProperty(x => x.Logcanaccts),
         "LOGCANACCTS", // columnName
         false,                    //isKey
         false, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  1, // int? prec
                           0  // int? Scale
         ,
         typeof(LogToSalOff)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <LogToSalOff>.GetProperty(x => x.Logcanchngstc),
         "LOGCANCHNGSTC", // columnName
         false,                    //isKey
         false, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  1, // int? prec
                           0  // int? Scale
         ,
         typeof(LogToSalOff)
         ));

         result.Add(new EntityPropDef(
         PropertyHelper <LogToSalOff>.GetProperty(x => x.Logcansell),
         "LOGCANSELL", // columnName
         false,                    //isKey
         false, //isNullable
         "",                       //refEntityName
         null,                     //PropertyInfo keyPropInfo
         0,       // int size   
                  1, // int? prec
                           0  // int? Scale
         ,
         typeof(LogToSalOff)
         ));
         return result; 
       }

#endregion     
        private int _fLogonno;
        public int Logonno
        {
            get { return _fLogonno; }
            set
            {
                var oldKey = Key;
                if (_fLogonno != value)
                {
                    Modify();
                    _fLogonno = value;
                    KeyChanged(oldKey);
                }
            }
        }

        private int _fSaloffno;
        public int Saloffno
        {
            get { return _fSaloffno; }
            set
            {
                var oldKey = Key;
                if (_fSaloffno != value)
                {
                    Modify();
                    _fSaloffno = value;
                    KeyChanged(oldKey);
                }
            }
        }

        private short _fLogcanaccts;
        public short Logcanaccts
        {
            get { return _fLogcanaccts; }
            set
            {
                if (_fLogcanaccts != value)
                {
                    Modify();
                    _fLogcanaccts = value;
                }
            }
        }

        private short _fLogcanchngstc;
        public short Logcanchngstc
        {
            get { return _fLogcanchngstc; }
            set
            {
                if (_fLogcanchngstc != value)
                {
                    Modify();
                    _fLogcanchngstc = value;
                }
            }
        }

        private short _fLogcansell;
        public short Logcansell
        {
            get { return _fLogcansell; }
            set
            {
                if (_fLogcansell != value)
                {
                    Modify();
                    _fLogcansell = value;
                }
            }
        }

        public override LogToSalOffKey Key
        {
            get
            {
                return new LogToSalOffKey { Logonno = Logonno, Saloffno = Saloffno };
            }
            set
            {
                if (value == null)
                    throw new ArgumentNullException("value", "Entity key can not be null.");
                Logonno = value.Logonno;
                Saloffno = value.Saloffno;
            }
        }

        public override string KeyAsString { get { return Key.AsString; } }


        public override LogToSalOff Clone()
        {
            var obj = new LogToSalOff
                {
                    Logonno = Logonno,
                    Saloffno = Saloffno,
                    Logcanaccts = Logcanaccts,
                    Logcanchngstc = Logcanchngstc,
                    Logcansell = Logcansell,
                };

            return obj;
        }

        public static class FieldNames
        {
// ReSharper disable InconsistentNaming
            public const string  LOGONNO = "LOGONNO";
            public const string  SALOFFNO = "SALOFFNO";
            public const string  LOGCANACCTS = "LOGCANACCTS";
            public const string  LOGCANCHNGSTC = "LOGCANCHNGSTC";
            public const string  LOGCANSELL = "LOGCANSELL";
 // ReSharper restore InconsistentNaming
        }


    }

    /// <summary>
    /// Define type of the primary key property of the LOGTOSALOFF entity.
    /// </summary>
    public class LogToSalOffKey : ICompositeKey
    {
        public int Logonno { get; set; }
        public int Saloffno { get; set; }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != GetType()) return false;
            return Equals((LogToSalOffKey)obj);
        }

        protected bool Equals(LogToSalOffKey other)
        {
            return Logonno == other.Logonno && Saloffno == other.Saloffno;
        }

        public override int GetHashCode()
        {
            unchecked
            {
                int hashCode = 0;
                hashCode = (hashCode * 397) ^ (Logonno).GetHashCode();
                hashCode = (hashCode * 397) ^ (Saloffno).GetHashCode();
                return hashCode;
            }
        }

        public static LogToSalOffKey Parse(string key)
        {
            var parts = key.Split('|');
            return new LogToSalOffKey
            {
                Logonno = int.Parse(parts[0]),
                Saloffno = int.Parse(parts[1]),
            };
        }

        public string AsString
        {
            get { return Logonno.ToString() + "|" + Saloffno.ToString(); }
        }

        public override string ToString()
        {
            return AsString;
        }

    }

}
