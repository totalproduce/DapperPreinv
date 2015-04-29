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
    /// Entity for the DELDET table
    /// </summary>
    [DataContract]
    public class DELDET 
    {
      
        [DataMember]            
        public int Delrecno {get; set;}
    
       [DataMember]              
        public string Delcltprdno {get;set;}

    
       [DataMember]              
        public int? Delcomno {get;set;}

    
       [DataMember]              
        public int? Deldlvordno {get;set;}

    
       [DataMember]              
        public decimal? Delnettweight {get;set;}

    
       [DataMember]              
        public short? Delprcbywgt {get;set;}

    
       [DataMember]              
        public int? Delprcprdno {get;set;}

    
       [DataMember]              
        public int? Delpriceper {get;set;}

    
       [DataMember]              
        public int? Delqty {get;set;}

    
       [DataMember]              
        public int? Delqtyper {get;set;}

    
       [DataMember]              
        public int? Delsmnno {get;set;}

    
       [DataMember]              
        public string Delstatus {get;set;}

    
       [DataMember]              
        public int? Delstkstatus {get;set;}

    
       [DataMember]              
        public int? Delsupclarecno {get;set;}

    
       [DataMember]              
        public decimal? Deltareweight {get;set;}

    
       [DataMember]              
        public int? Delupdpikqty {get;set;}

    
       [DataMember]              
        public decimal? Delweight {get;set;}

    
       [DataMember]              
        public decimal? Detsyscalcpals {get;set;}

    
       [DataMember]              
        public int? Dlvprtstat {get;set;}

    
       [DataMember]              
        public int? Edilineno {get;set;}

        /// <summary>
        /// LINK TO THE PRCCSTINFO TABLE TO GIVE THE CLIENT PRODUCT DETAILS
        /// </summary>
    
       [DataMember]              
        public int? Ppccltrecno {get;set;}

        /// <summary>
        /// LINK TO THE PRCNEWLIST TABLE TO GIVE THE PRICE LIST RECORD
        /// </summary>
    
       [DataMember]              
        public int? Prllineno {get;set;}

    
       [DataMember]              
        public int? Prllinno {get;set;}

        /// <summary>
        /// LINK TO THE PRICELISTPROFILEHEAD TABLE TO GIVE THE PROFILE PRICE
        /// </summary>
    
       [DataMember]              
        public int? Profileheadrecno {get;set;}

    
       [DataMember]              
        public int? Prtstat {get;set;}

    
       [DataMember]              
        public int? Qtyper {get;set;}

    
       [DataMember]              
        public decimal? Rndapportpals {get;set;}

    
       [DataMember]              
        public decimal? Userdetinppals {get;set;}

    }

/*
result.Delrecno = item.Delrecno;
  result.Delcltprdno = item.Delcltprdno;
  result.Delcomno = item.Delcomno;
  result.Deldlvordno = item.Deldlvordno;
  result.Delnettweight = item.Delnettweight;
  result.Delprcbywgt = item.Delprcbywgt;
  result.Delprcprdno = item.Delprcprdno;
  result.Delpriceper = item.Delpriceper;
  result.Delqty = item.Delqty;
  result.Delqtyper = item.Delqtyper;
  result.Delsmnno = item.Delsmnno;
  result.Delstatus = item.Delstatus;
  result.Delstkstatus = item.Delstkstatus;
  result.Delsupclarecno = item.Delsupclarecno;
  result.Deltareweight = item.Deltareweight;
  result.Delupdpikqty = item.Delupdpikqty;
  result.Delweight = item.Delweight;
  result.Detsyscalcpals = item.Detsyscalcpals;
  result.Dlvprtstat = item.Dlvprtstat;
  result.Edilineno = item.Edilineno;
  result.Ppccltrecno = item.Ppccltrecno;
  result.Prllineno = item.Prllineno;
  result.Prllinno = item.Prllinno;
  result.Profileheadrecno = item.Profileheadrecno;
  result.Prtstat = item.Prtstat;
  result.Qtyper = item.Qtyper;
  result.Rndapportpals = item.Rndapportpals;
  result.Userdetinppals = item.Userdetinppals;


            
*/  

/*
Delrecno = item.Delrecno,
Delcltprdno = item.Delcltprdno,
Delcomno = item.Delcomno,
Deldlvordno = item.Deldlvordno,
Delnettweight = item.Delnettweight,
Delprcbywgt = item.Delprcbywgt,
Delprcprdno = item.Delprcprdno,
Delpriceper = item.Delpriceper,
Delqty = item.Delqty,
Delqtyper = item.Delqtyper,
Delsmnno = item.Delsmnno,
Delstatus = item.Delstatus,
Delstkstatus = item.Delstkstatus,
Delsupclarecno = item.Delsupclarecno,
Deltareweight = item.Deltareweight,
Delupdpikqty = item.Delupdpikqty,
Delweight = item.Delweight,
Detsyscalcpals = item.Detsyscalcpals,
Dlvprtstat = item.Dlvprtstat,
Edilineno = item.Edilineno,
Ppccltrecno = item.Ppccltrecno,
Prllineno = item.Prllineno,
Prllinno = item.Prllinno,
Profileheadrecno = item.Profileheadrecno,
Prtstat = item.Prtstat,
Qtyper = item.Qtyper,
Rndapportpals = item.Rndapportpals,
Userdetinppals = item.Userdetinppals,


            
*/  

    }

}
