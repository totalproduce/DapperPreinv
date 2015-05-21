// <summary>
// This file is generated automatically. Any changes will be lost.
// </summary>

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Runtime.Serialization;

namespace Bsdl.FreshTrade.Repositories.PreInv.dto
{
    /// <summary>
    /// Entity for the PREINVTEMP_INVEDI table
    /// </summary>
    [DataContract]
    public class INVEDI 
    {
    
       [DataMember]              
        public string Companyname {get;set;}

    
       [DataMember]              
        public string Edifile {get;set;}

    
       [DataMember]              
        public int? Ehheadid {get;set;}

    
       [DataMember]              
        public int Extractsessionid {get;set;}

    
       [DataMember]              
        public int? Fileno {get;set;}

    
       [DataMember]              
        public int? Hofclarecno {get;set;}

    
       [DataMember]              
        public string Hofcstcode {get;set;}

    
       [DataMember]              
        public string Hofcstname {get;set;}

    
       [DataMember]              
        public short? Newfile {get;set;}

    
       [DataMember]              
        public short? Newtransref {get;set;}

    
       [DataMember]              
        public int? Prcglbrecno {get;set;}

    }

/*
  result.Companyname = item.Companyname;
  result.Edifile = item.Edifile;
  result.Ehheadid = item.Ehheadid;
  result.Extractsessionid = item.Extractsessionid;
  result.Fileno = item.Fileno;
  result.Hofclarecno = item.Hofclarecno;
  result.Hofcstcode = item.Hofcstcode;
  result.Hofcstname = item.Hofcstname;
  result.Newfile = item.Newfile;
  result.Newtransref = item.Newtransref;
  result.Prcglbrecno = item.Prcglbrecno;


            
*/  

/*
Companyname = item.Companyname,
Edifile = item.Edifile,
Ehheadid = item.Ehheadid,
Extractsessionid = item.Extractsessionid,
Fileno = item.Fileno,
Hofclarecno = item.Hofclarecno,
Hofcstcode = item.Hofcstcode,
Hofcstname = item.Hofcstname,
Newfile = item.Newfile,
Newtransref = item.Newtransref,
Prcglbrecno = item.Prcglbrecno,


            
*/  

    }

}
