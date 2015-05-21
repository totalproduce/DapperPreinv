using System;
using System.Runtime.Serialization;

namespace Bsdl.FreshTrade.Domain.PreInv.Enums
{
    [DataContract]
    public enum EnumPostType
    {       
        [EnumMember]
        SALESALLPSTRECNO  = 20,  // Sales ALL rec no. on POSTTYPE.DB

        [EnumMember]
        SALESINVPSTRECNO  = 21,  // Sales Invoice rec no. on POSTTYPE.DB

        [EnumMember]
        SALESDNTPSTRECNO  = 22,  // Sales Debit Note rec no. on POSTTYPE.DB

        [EnumMember]
        SALESMINVPSTRECNO = 23,  // Sales Manual Invoice rec no. on POSTTYPE.DB

        [EnumMember]
        SALESDJNLPSTRECNO = 25,  //Sales Debit Journal rec no. on POSTTYPE.DB

        [EnumMember]
        SALESCASHPSTRECNO = 27,  // Sales Cash Receipts rec no. on POSTTYPE.DB

        [EnumMember]
        SALESCJNLPSTRECNO = 29,  //Sales Credit Journal rec no. on POSTTYPE.DB

        [EnumMember]
        SALESMCDTPSTRECNO = 31,  //Sales Manual Credit Note rec no. on POSTTYPE.DB

        [EnumMember]
        SALESCNTPSTRECNO  = 33,  // Sales Credit Note rec no. on POSTTYPE.DB

        [EnumMember]
        GLDEBTORSPSTRECNO = 41,  // G/L Debtors rec no. on POSTTYPE.DB

        [EnumMember]
        GLSALESPSTRECNO   = 42,  // G/L Sales rec no. on POSTTYPE.DB

        [EnumMember]
        GLHAUBALPSTRECNO  = 43,  // G/L Haulage Balance Sheet rec no. on POSTTYPE.DB

        [EnumMember]
        GLHAUPROPSTRECNO  = 44,  // G/L Haulage P&L rec no. on POSTTYPE.DB

        [EnumMember]
        GLREBBALPSTRECNO  = 45,  // G/L not On Payment Rebate Balance Sheet rec no. on POSTTYPE.DB

        [EnumMember]
        GLREBPROPSTRECNO  = 46,  // G/L not On Payment Rebate Profit & Loss rec no. on POSTTYPE.DB

        [EnumMember]
        GLREBPBALPSTRECNO = 47,  // G/L On Payment Rebate Balance Sheet rec no. on POSTTYPE.DB

        [EnumMember]
        GLREBPPROPSTRECNO = 48,  // G/L On Payment Rebate Profit & Loss rec no. on POSTTYPE.DB

        [EnumMember]
        GLBANKPSTRECNO    = 49,  // G/L Bank rec no. on POSTTYPE.DB

        [EnumMember]
        GLVATPSTRECNO     = 50  // G/L VAT rec no. on POSTTYPE.DB

    }
}
