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
    /// Entity for the PREINVTEMP_INVERR table
    /// </summary>
    [DataContract]
    public class INVERR 
    {
    
       [DataMember]              
        public int? Dlvordno {get;set;}

    
       [DataMember]              
        public int Errno {get;set;}

    
       [DataMember]              
        public int Extractsessionid {get;set;}

    
       [DataMember]              
        public int Logrecno {get;set;}

    
       [DataMember]              
        public string Ordcstcode {get;set;}

    
       [DataMember]              
        public string Ordcustordno {get;set;}

    }

/*
  result.Dlvordno = item.Dlvordno;
  result.Errno = item.Errno;
  result.Extractsessionid = item.Extractsessionid;
  result.Logrecno = item.Logrecno;
  result.Ordcstcode = item.Ordcstcode;
  result.Ordcustordno = item.Ordcustordno;


            
*/  

/*
Dlvordno = item.Dlvordno,
Errno = item.Errno,
Extractsessionid = item.Extractsessionid,
Logrecno = item.Logrecno,
Ordcstcode = item.Ordcstcode,
Ordcustordno = item.Ordcustordno,


            
*/  

    }

}
