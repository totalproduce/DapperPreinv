using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Bsdl.FreshTrade.Domain.Account.Entities;
using Bsdl.FreshTrade.Domain.Basic.Utilities;

namespace Bsdl.FreshTrade.Domain.PreInv.Entities
{
    public class DTOUpdateInfo
    {
        public List<DTOAccAlloc> AccAlloc { get; set; }
        public List<DTOAccTrnFil> AccTrnFilAdditions { get; set; }
        public List<DTOAccite> AcciteAdditions { get; set; }
        public List<DTOAccReChg> AccReChgAdditions { get; set; }
        public List<DTOAccVAT> AccVatAdditions { get; set; }
        public List<DTOBatch> BatchAdditions { get; set; }
        public List<DTOBatchDet> BatchDetAdditions { get; set; }
        public List<DTOAccAllVal> AccAllValAdditions { get; set; }
        public List<DTOExpCha> ExpChaAdditions { get; set; }
        public List<DTOIchDiscTyp> IchDiscTypAdditions { get; set; }
        public List<DTOIteChg> IteChgAdditions { get; set; }

        public List<DTODelAuditRecord> DelAuditRecordAdditions { get; set; }
        public List<DTOAuditRecord> AuditRecordAdditions { get; set; }

        public List<UpdatePair<DTODeliveryPrice>> DeliveryPriceUpdates { get; set; }
        public List<UpdatePair<DTODeliveryHead>> DeliveryHeadUpdates { get; set; }
        public List<UpdatePair<DTODeliveryDetail>> DeliveryDetailUpdates { get; set; }
        public List<UpdatePair<DTOAccTrnFil>> AccTrnFilUpdates { get; set; }
        public DTOSalesOffice SalesOfficeUpdate { get; set; }

        public List<DTOIteChg> IteChgDeletions { get; set; }

        public List<DTOOrder> OrderCleanAccountClassID { get; set; }

    }
}