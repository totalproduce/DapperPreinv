using System.Collections.Generic;
using System.Runtime.Serialization;
using Bsdl.FreshTrade.Domain.Basic.Interfaces;

namespace Bsdl.FreshTrade.Domain.Basic.Entities
{
    /* Currency Dictionary*/
    [DataContract]
    public class DTOCurrency : IDTOCurrency
    {
        public const int BaseCurrencyNo = 1;
        public const int EuroCurrencyNo = 2;

        [DataMember]
        public int No
        {
            get; set;
        }

        [DataMember]
        public string Description
        {
            get; set;
        }

        [DataMember]
        public bool IsTriangulate { get; set; }

        [DataMember]
        public int? DecimalPlaces { get; set; }

        [DataMember]
        public string CurCode { get; set; }

        [DataMember]
        public string CurDecimalPoint { get; set; }

        [DataMember]
        public int? CurDefBanRecNo { get; set; }

        [DataMember]
        public string CurExtnNumPicture { get; set; }

        [DataMember]
        public string CurSymbol { get; set; }

        [DataMember]
        public bool CurSymbolAtFront { get; set; }

        [DataMember]
        public string CurThousandSeparator { get; set; }

    }
}
