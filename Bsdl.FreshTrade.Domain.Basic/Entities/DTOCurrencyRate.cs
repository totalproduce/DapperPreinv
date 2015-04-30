using System.Runtime.Serialization;

namespace Bsdl.FreshTrade.Domain.Basic.Entities
{
    /// <summary>
    /// Entity for the ACCCURRRATE table
    /// </summary>
    [DataContract]
    public class DTOCurrencyRate 
    {
        public const int SalesRateUseForCode = 3;

        [DataMember]
        public int CurNo { get; set; }
      
        [DataMember]
        public int UseFor { get; set; }
    
        [DataMember]
        public decimal RateFromBase { get; set; }

    
        [DataMember]
        public decimal RateFromEuro { get; set; }

    
        [DataMember]
        public decimal RateToBase { get; set; }

    
        [DataMember]
        public decimal RateToEuro { get; set; }
    }

/*
result.Ratcurno = item.Ratcurno;
result.Ratusefor = item.Ratusefor;
  result.Ratratefrombase = item.Ratratefrombase;
  result.Ratratefromeuro = item.Ratratefromeuro;
  result.Ratratetobase = item.Ratratetobase;
  result.Ratratetoeuro = item.Ratratetoeuro;


            
*/  

/*
Ratcurno = item.Ratcurno,
Ratusefor = item.Ratusefor,
Ratratefrombase = item.Ratratefrombase,
Ratratefromeuro = item.Ratratefromeuro,
Ratratetobase = item.Ratratetobase,
Ratratetoeuro = item.Ratratetoeuro,


            
*/  

}
