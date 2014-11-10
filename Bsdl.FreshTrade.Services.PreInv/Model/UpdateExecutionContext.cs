using System;
using System.Collections.Generic;
using Bsdl.FreshTrade.Domain.Account.Entities;
using Bsdl.FreshTrade.Domain.Basic.Utilities.DataTypeHandling;
using Bsdl.FreshTrade.Domain.PreInv.Entities;
using Bsdl.FreshTrade.Domain.PreInv.Enums;

namespace Bsdl.FreshTrade.Services.PreInv.Model
{
    public class UpdateExecutionContext
    {
        public DTOSalesOffice SalesOffice { get; set; }
        public List<DTOInvDiscTyp> InvDiscTypRecords { get; set; }
        public List<DTOInvTot> InvTotRecords { get; set; }
        public List<DTOInvPrt2> InvPrt2Records { get; set; }

        public DTOInvTot InvTotRecord { get; set; }
        public DTOInvPrt2 InvPrt2Record { get; set; }
        public DTOInvPrt InvPrtRecord { get; set;}
        public DTOInvDiscTyp InvDiscTypRecord { get; set; }

        public EnumPostType siPstRecNo { get; set; }
        public decimal InvBaseDscTot { get; set; }
        public decimal InvBaseOnPTot { get; set; }
        public decimal InvBaseRbtTot { get; set; }

        public DTOAccTrnFil AccTrnFil { get; set; }

        public Dictionary<int, int> dyPstDrCr { get; set; }
        public Dictionary<int, int> EHHeaderAr { get; set; }

        public List<int> EIInvoiceIDs {get;set;}
        public List<DTOEdiLogHeaderWide> EdiLogRecords {get; set;}
        public List<Tuple<string, int>> EDIFilesDyAr { get; set; }

        public int? LastDscExpRec { get; set; } //so called DscExpRec
        public int? LastRbtExpRec { get; set; } //so called RbtExpRec


        public DTOInvExtractHead InvExtractHead { get; set; }

        //public PreInvBatchType BatchTypeForAccount {get;set;}

        public bool ExpChaKeysReserved { get; set; }
    }
}
