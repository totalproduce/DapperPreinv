using System.ComponentModel;
using Bsdl.FreshTrade.Domain.Basic.Enums;

namespace Bsdl.FreshTrade.Domain.PreInv.Enums
{
    public enum PreInvGLLookupType
    {
        [EnumTitle(Code = "Debtors")]
        Debtors = 1,

        [EnumTitle(Code = "RebBal")]
        RebateBalance = 2,

        [EnumTitle(Code = "RebP&L")]
        RebateProfitAndLoss = 3,

        [EnumTitle(Code = "Discount")]
        Discount = 4,

        [EnumTitle(Code = "Sales")]
        Sales = 5,

        [EnumTitle(Code = "VAT")]
        VAT = 6,

        [EnumTitle(Code = "ChComm")]
        ChComm = 7,

        [EnumTitle(Code = "ChHand")]
        ChHand = 8,

        [EnumTitle(Code = "INTERDEPT")]
        InterDepartment = 9
    }
}
