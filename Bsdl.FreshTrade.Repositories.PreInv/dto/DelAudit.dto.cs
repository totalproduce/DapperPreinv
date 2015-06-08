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
    /// Entity for the DELAUDIT table
    /// </summary>
    [DataContract]
    public class DelAudit 
    {
      
        [DataMember]            
        public int Delaudrecno {get; set;}
    
       [DataMember]              
        public DateTime? Delauddate {get;set;}

    
       [DataMember]              
        public int? Delauddelrecno {get;set;}

    
       [DataMember]              
        public string Delaudfrom {get;set;}

    
       [DataMember]              
        public int? Delaudgrpno {get;set;}

    
       [DataMember]              
        public string Delaudtime {get;set;}

    
       [DataMember]              
        public string Delaudto {get;set;}

    
       [DataMember]              
        public int? Delaudtyp {get;set;}

    
       [DataMember]              
        public int? Dprrecno {get;set;}

    
       [DataMember]              
        public int? Dprtoaction {get;set;}

        /// <summary>
        /// This field can be used to indicate the actual form that called a library. This way one can determine the user process that triggered the audit, regardless of what library the code resides in. NOTE: the formname will not match the formnumber (DelAudit.formno);  The formno is the actual writer of the audit and will always be populated, the formname is the form that called the library - this will be blank by default;  the developer must pass this information through; [Pass an audit type of -99;  the data is the Alpha formname]
        /// </summary>
    
       [DataMember]              
        public string Formname {get;set;}

    
       [DataMember]              
        public int? Formno {get;set;}

    
       [DataMember]              
        public int? Logonno {get;set;}

    }

/*
result.Delaudrecno = item.Delaudrecno;
  result.Delauddate = item.Delauddate;
  result.Delauddelrecno = item.Delauddelrecno;
  result.Delaudfrom = item.Delaudfrom;
  result.Delaudgrpno = item.Delaudgrpno;
  result.Delaudtime = item.Delaudtime;
  result.Delaudto = item.Delaudto;
  result.Delaudtyp = item.Delaudtyp;
  result.Dprrecno = item.Dprrecno;
  result.Dprtoaction = item.Dprtoaction;
  result.Formname = item.Formname;
  result.Formno = item.Formno;
  result.Logonno = item.Logonno;


            
*/  

/*
Delaudrecno = item.Delaudrecno,
Delauddate = item.Delauddate,
Delauddelrecno = item.Delauddelrecno,
Delaudfrom = item.Delaudfrom,
Delaudgrpno = item.Delaudgrpno,
Delaudtime = item.Delaudtime,
Delaudto = item.Delaudto,
Delaudtyp = item.Delaudtyp,
Dprrecno = item.Dprrecno,
Dprtoaction = item.Dprtoaction,
Formname = item.Formname,
Formno = item.Formno,
Logonno = item.Logonno,


            
*/  

    }

}
