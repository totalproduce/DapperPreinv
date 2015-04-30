
// <summary>
// This file is generated automatically. Any changes will be lost.
// </summary>

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Runtime.Serialization;

namespace Bsdl.FreshTrade.Repositories.Basic.dto
{
    /// <summary>
    /// Entity for the LOGONS table
    /// </summary>
    [DataContract]
    public class Logons 
    {
      
        [DataMember]            
        public string Logonname {get; set;}
    
       [DataMember]              
        public short? Active {get;set;}

    
       [DataMember]              
        public int? Authno {get;set;}

        /// <summary>
        /// Can log onto Handheld
        /// </summary>
    
       [DataMember]              
        public short? Availtomkthandheld {get;set;}

    
       [DataMember]              
        public short? Canseeallsups {get;set;}

    
       [DataMember]              
        public int? Companyno {get;set;}

    
       [DataMember]              
        public string Dept {get;set;}

    
       [DataMember]              
        public string Emailaddress {get;set;}

    
       [DataMember]              
        public string Fax {get;set;}

    
       [DataMember]              
        public int? HandheldmenusMenuid {get;set;}

        /// <summary>
        /// MD5 Encrypted password for handheld
        /// </summary>
    
       [DataMember]              
        public string Handheldpassword {get;set;}

    
       [DataMember]              
        public int? Langno {get;set;}

    
       [DataMember]              
        public int? Loggrpno {get;set;}

    
       [DataMember]              
        public int? Logonno {get;set;}

    
       [DataMember]              
        public string Phone {get;set;}

    
       [DataMember]              
        public int? Usergroupno {get;set;}

    
       [DataMember]              
        public string Username {get;set;}

    }

/*
result.Logonname = item.result.Logonname;
  result.Active = item.result.Active;
  result.Authno = item.result.Authno;
  result.Availtomkthandheld = item.result.Availtomkthandheld;
  result.Canseeallsups = item.result.Canseeallsups;
  result.Companyno = item.result.Companyno;
  result.Dept = item.result.Dept;
  result.Emailaddress = item.result.Emailaddress;
  result.Fax = item.result.Fax;
  result.HandheldmenusMenuid = item.result.HandheldmenusMenuid;
  result.Handheldpassword = item.result.Handheldpassword;
  result.Langno = item.result.Langno;
  result.Loggrpno = item.result.Loggrpno;
  result.Logonno = item.result.Logonno;
  result.Phone = item.result.Phone;
  result.Usergroupno = item.result.Usergroupno;
  result.Username = item.result.Username;


            
*/  

    }

}
