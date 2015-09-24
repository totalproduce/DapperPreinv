using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using Bsdl.FreshTrade.Domain.PreInv.Enums;
using Bsdl.FreshTrade.Domain.PreInv.Interfaces;

namespace Bsdl.FreshTrade.Domain.PreInv.Entities
{
    [DataContract]
    public class DTOInvPrt2 : IDTOInvPrt2
    {
        public DTOInvPrt2()
        {

        }

        public DTOInvPrt2(IDTOInvPrt2 b)
        {
            AllocToInvRecNo = b.AllocToInvRecNo;
            AllowOneLineCancel = b.AllowOneLineCancel;
            Basecommamt = b.Basecommamt;
            BaseGds = b.BaseGds;
            Basehandamt = b.Basehandamt;
            BaseOffInvRbt = b.BaseOffInvRbt;
            BaseOffOnPay = b.BaseOffOnPay;
            BaseOnInvDscnt = b.BaseOnInvDscnt;
            BaseVat = b.BaseVat;
            BaseVat1Total = b.BaseVat1Total;
            BaseVat2Total = b.BaseVat2Total;
            Basevatonchgs = b.Basevatonchgs;
            Cancel = b.Cancel;
            CancelledLine = b.CancelledLine;
            Commperc = b.Commperc;
            DelCdsRefNo = b.DelCdsRefNo;
            DelCltPrdNo = b.DelCltPrdNo;
            DelInvStatus = b.DelInvStatus;
            DelPrcByWgt = b.DelPrcByWgt;
            DelPrcPrdNo = b.DelPrcPrdNo;
            DelPrice = b.DelPrice;
            DelQty = b.DelQty;
            DelRecNo = b.DelRecNo;
            DelWeight = b.DelWeight;
            DetAllocNo = b.DetAllocNo;
            DiscToQty = b.DiscToQty;
            Dispcnt = b.Dispcnt;
            DlvOrdNo = b.DlvOrdNo;
            DprRecNo = b.DprRecNo;
            Eurocommamt = b.Eurocommamt;
            EuroGds = b.EuroGds;
            Eurohandamt = b.Eurohandamt;
            EuroOffInvRbt = b.EuroOffInvRbt;
            EuroOffOnPay = b.EuroOffOnPay;
            EuroOnInvDscnt = b.EuroOnInvDscnt;
            EuroVat = b.EuroVat;
            EuroVat1Total = b.EuroVat1Total;
            EuroVat2Total = b.EuroVat2Total;
            Eurovatonchgs = b.Eurovatonchgs;
            Ext = b.Ext;
            ExtractSessionID = b.ExtractSessionID;
            Goods = b.Goods;
            GrossWgt = b.GrossWgt;
            Handrate = b.Handrate;
            InvoiceNo = b.InvoiceNo;
            NettWgt = b.NettWgt;
            OffInvOnPay = b.OffInvOnPay;
            OffInvRbt = b.OffInvRbt;
            OnInvDisPcnt = b.OnInvDisPcnt;
            OnInvDscnt = b.OnInvDscnt;
            PpcNo = b.PpcNo;
            PrcPrdRef = b.PrcPrdRef;
            PrdDesc = b.PrdDesc;
            PrdGlAnl = b.PrdGlAnl;
            PrdRecDesc = b.PrdRecDesc;
            PrgRefNo = b.PrgRefNo;
            PrtQty = b.PrtQty;
            Rawcommamt = b.Rawcommamt;
            Rawhandamt = b.Rawhandamt;
            Rawvatonchgs = b.Rawvatonchgs;
            Recno = b.Recno;
            TareWgt = b.TareWgt;
            TradedUnit = b.TradedUnit;
            UnitCount = b.UnitCount;
            UnitMeasure = b.UnitMeasure;
            Vat = b.Vat;
            Vat1Total = b.Vat1Total;
            Vat2Total = b.Vat2Total;
            Vatcodechgs = b.Vatcodechgs;
            VatLnkRecNo = b.VatLnkRecNo;
            Vatratechgs = b.Vatratechgs;
            VatRecNo = b.VatRecNo;
            VatVatRate = b.VatVatRate;
            VatVatRate2 = b.VatVatRate2;
            VatVeaRecNo = b.VatVeaRecNo;
        }
        
        [DataMember]
        public int ExtractSessionID { get; set; }


        [DataMember]
        public int? AllocToInvRecNo { get; set; }


        [DataMember]
        public bool AllowOneLineCancel { get; set; }


        [DataMember]
        public decimal Basecommamt { get; set; }


        [DataMember]
        public decimal BaseGds { get; set; }


        [DataMember]
        public decimal Basehandamt { get; set; }


        [DataMember]
        public decimal BaseOffInvRbt { get; set; }


        [DataMember]
        public decimal BaseOffOnPay { get; set; }


        [DataMember]
        public decimal BaseOnInvDscnt { get; set; }


        [DataMember]
        public decimal BaseVat { get; set; }


        [DataMember]
        public decimal BaseVat1Total { get; set; }


        [DataMember]
        public decimal BaseVat2Total { get; set; }


        [DataMember]
        public int? Basevatonchgs { get; set; }


        [DataMember]
        public bool CancelledLine { get; set; }


        [DataMember]
        public decimal Commperc { get; set; }


        [DataMember]
        public int? DelCdsRefNo { get; set; }


        [DataMember]
        public string DelCltPrdNo { get; set; }


        [DataMember]
        public DTODeliveryPriceStatus? DelInvStatus { get; set; }


        [DataMember]
        public bool DelPrcByWgt { get; set; }


        [DataMember]
        public int? DelPrcPrdNo { get; set; }


        [DataMember]
        public decimal DelPrice { get; set; }


        [DataMember]
        public int? DelQty { get; set; }


        [DataMember]
        public int? DelRecNo { get; set; }


        [DataMember]
        public decimal DelWeight { get; set; }


        [DataMember]
        public string DetAllocNo { get; set; }


        [DataMember]
        public int? DiscToQty { get; set; }


        [DataMember]
        public string Dispcnt { get; set; }


        [DataMember]
        public string InvoiceNo { get; set; }


        [DataMember]
        public int? DlvOrdNo { get; set; }


        [DataMember]
        public int? DprRecNo { get; set; }


        [DataMember]
        public decimal Eurocommamt { get; set; }


        [DataMember]
        public decimal EuroGds { get; set; }


        [DataMember]
        public decimal Eurohandamt { get; set; }


        [DataMember]
        public decimal EuroOffInvRbt { get; set; }


        [DataMember]
        public decimal EuroOffOnPay { get; set; }


        [DataMember]
        public decimal EuroOnInvDscnt { get; set; }


        [DataMember]
        public decimal EuroVat { get; set; }


        [DataMember]
        public decimal EuroVat1Total { get; set; }


        [DataMember]
        public decimal EuroVat2Total { get; set; }


        [DataMember]
        public decimal Eurovatonchgs { get; set; }


        [DataMember]
        public decimal Ext { get; set; }


        [DataMember]
        public decimal Goods { get; set; }


        [DataMember]
        public decimal GrossWgt { get; set; }


        [DataMember]
        public decimal Handrate { get; set; }


        [DataMember]
        public decimal NettWgt { get; set; }


        [DataMember]
        public decimal OffInvOnPay { get; set; }


        [DataMember]
        public decimal OffInvRbt { get; set; }


        [DataMember]
        public decimal OnInvDisPcnt { get; set; }


        [DataMember]
        public decimal OnInvDscnt { get; set; }


        [DataMember]
        public int? PpcNo { get; set; }


        [DataMember]
        public string PrcPrdRef { get; set; }


        [DataMember]
        public string PrdDesc { get; set; }


        [DataMember]
        public int? PrdGlAnl { get; set; }


        [DataMember]
        public string PrdRecDesc { get; set; }


        [DataMember]
        public int? PrgRefNo { get; set; }


        [DataMember]
        public decimal PrtQty { get; set; }


        [DataMember]
        public decimal Rawcommamt { get; set; }


        [DataMember]
        public decimal Rawhandamt { get; set; }


        [DataMember]
        public decimal Rawvatonchgs { get; set; }


        [DataMember]
        public int? Recno { get; set; }


        [DataMember]
        public decimal TareWgt { get; set; }


        [DataMember]
        public string TradedUnit { get; set; }


        [DataMember]
        public int? UnitCount { get; set; }


        [DataMember]
        public string UnitMeasure { get; set; }


        [DataMember]
        public decimal Vat { get; set; }


        [DataMember]
        public decimal Vat1Total { get; set; }


        [DataMember]
        public decimal Vat2Total { get; set; }


        [DataMember]
        public decimal Vatcodechgs { get; set; }


        [DataMember]
        public int? VatLnkRecNo { get; set; }


        [DataMember]
        public decimal Vatratechgs { get; set; }


        [DataMember]
        public int? VatRecNo { get; set; }


        [DataMember]
        public decimal VatVatRate { get; set; }


        [DataMember]
        public decimal VatVatRate2 { get; set; }


        [DataMember]
        public int? VatVeaRecNo { get; set; }
        
        [DataMember]
        public bool Cancel { get; set; }
    }


    public class DTOSalesGanTot {
        [DataMember]
        public decimal Goods { get; set; }

        [DataMember]
        public decimal Eurogds { get; set; }

        [DataMember]
        public decimal Basegds { get; set; }
    
    }

    public class DTOAutoAlloc
    {
        public decimal AutoAllocAmt { get; set; }
        public decimal AutoAllocEuroAmt { get; set; }
        public decimal AutoAllocBaseAmt { get; set; }
    }

    public class DTOVatGanTot
    {
        public decimal Vat { get; set; }
        public decimal EuroVat { get; set; }
        public decimal BaseVat { get; set; }
    }


}
