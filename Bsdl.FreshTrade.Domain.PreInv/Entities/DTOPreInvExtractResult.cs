using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using Bsdl.FreshTrade.Domain.PreInv.Enums;

namespace Bsdl.FreshTrade.Domain.PreInv.Entities
{
    [DataContract]
    public class DTOPreInvExtractResult
    {
        [DataMember]
        public PreInvExtractStatusType Status { get; set; }

        [DataMember]
        public List<DTOPreInvExtractionErrorsItem> Errors { get; set; }

        [DataMember]
        public List<DTOInvTot> InvoiceTotalItems { get; set; }

        [DataMember]
        public List<DTOInvPrt> InvoicePartItems { get; set; }

        [DataMember]
        public List<DTOInvPrt2> InvoicePart2Items { get; set; }

        [DataMember]
        public List<DTOInvDiscTyp> InvoiceDiscTypItems { get; set; }

    }
}
