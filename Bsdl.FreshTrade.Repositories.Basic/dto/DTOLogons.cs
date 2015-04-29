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
result.Logonname = item.Logonname;
  result.Active = item.Active;
  result.Authno = item.Authno;
  result.Availtomkthandheld = item.Availtomkthandheld;
  result.Canseeallsups = item.Canseeallsups;
  result.Companyno = item.Companyno;
  result.Dept = item.Dept;
  result.Emailaddress = item.Emailaddress;
  result.Fax = item.Fax;
  result.HandheldmenusMenuid = item.HandheldmenusMenuid;
  result.Handheldpassword = item.Handheldpassword;
  result.Langno = item.Langno;
  result.Loggrpno = item.Loggrpno;
  result.Logonno = item.Logonno;
  result.Phone = item.Phone;
  result.Usergroupno = item.Usergroupno;
  result.Username = item.Username;


            
*/  

/*
Logonname = item.Logonname,
Active = item.Active,
Authno = item.Authno,
Availtomkthandheld = item.Availtomkthandheld,
Canseeallsups = item.Canseeallsups,
Companyno = item.Companyno,
Dept = item.Dept,
Emailaddress = item.Emailaddress,
Fax = item.Fax,
HandheldmenusMenuid = item.HandheldmenusMenuid,
Handheldpassword = item.Handheldpassword,
Langno = item.Langno,
Loggrpno = item.Loggrpno,
Logonno = item.Logonno,
Phone = item.Phone,
Usergroupno = item.Usergroupno,
Username = item.Username,


            
*/  

    }

}
