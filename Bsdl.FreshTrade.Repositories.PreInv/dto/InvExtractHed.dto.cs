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
    /// Entity for the PREINVTEMP_INVEXTRACTHED table
    /// </summary>
    [DataContract]
    public class InvExtractHed 
    {
      
        [DataMember]            
        public int Extractsessionid {get; set;}
    
       [DataMember]              
        public int Companyno {get;set;}

    
       [DataMember]              
        public DateTime Createddate {get;set;}

    
       [DataMember]              
        public string Invoiceordertype {get;set;}

    
       [DataMember]              
        public int Invoiceperiod {get;set;}

    
       [DataMember]              
        public string Invoiceperiodasstr {get;set;}

    
       [DataMember]              
        public int Invoicetype {get;set;}

    
       [DataMember]              
        public string Invoicetypename {get;set;}

    
       [DataMember]              
        public short Isintercompanytransfer {get;set;}

    
       [DataMember]              
        public int Lastinvoiceno {get;set;}

    
       [DataMember]              
        public int Logonno {get;set;}

    
       [DataMember]              
        public DateTime Reqdate {get;set;}

    
       [DataMember]              
        public string Salesofficename {get;set;}

    
       [DataMember]              
        public int Salesofficeno {get;set;}

    
       [DataMember]              
        public DateTime Taxdate {get;set;}

    }

/*
result.Extractsessionid = item.Extractsessionid;
  result.Companyno = item.Companyno;
  result.Createddate = item.Createddate;
  result.Invoiceordertype = item.Invoiceordertype;
  result.Invoiceperiod = item.Invoiceperiod;
  result.Invoiceperiodasstr = item.Invoiceperiodasstr;
  result.Invoicetype = item.Invoicetype;
  result.Invoicetypename = item.Invoicetypename;
  result.Isintercompanytransfer = item.Isintercompanytransfer;
  result.Lastinvoiceno = item.Lastinvoiceno;
  result.Logonno = item.Logonno;
  result.Reqdate = item.Reqdate;
  result.Salesofficename = item.Salesofficename;
  result.Salesofficeno = item.Salesofficeno;
  result.Taxdate = item.Taxdate;


            
*/  

/*
Extractsessionid = item.Extractsessionid,
Companyno = item.Companyno,
Createddate = item.Createddate,
Invoiceordertype = item.Invoiceordertype,
Invoiceperiod = item.Invoiceperiod,
Invoiceperiodasstr = item.Invoiceperiodasstr,
Invoicetype = item.Invoicetype,
Invoicetypename = item.Invoicetypename,
Isintercompanytransfer = item.Isintercompanytransfer,
Lastinvoiceno = item.Lastinvoiceno,
Logonno = item.Logonno,
Reqdate = item.Reqdate,
Salesofficename = item.Salesofficename,
Salesofficeno = item.Salesofficeno,
Taxdate = item.Taxdate,


            
*/  

    }

}
