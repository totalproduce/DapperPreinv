using System;
using System.ComponentModel;
using Bsdl.FreshTrade.Domain.PreInv.Entities;
using Bsdl.FreshTrade.Domain.PreInv.Interfaces;


namespace Bsdl.FreshTrade.UI.PreInv.Model
{
    public class PreInvPrt2Model : DTOInvPrt2, INotifyPropertyChanged
    {

        public PreInvPrt2Model(IDTOInvPrt2 b)
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

        public void SetCancelledLine(bool value)
        {
            base.CancelledLine = value;
            OnPropertyChanged("CancelledLine");
        }
        
        public new bool CancelledLine
        {
            get { return base.CancelledLine; }
            set
            {
                SetCancelledLine(value);

                if (Parent != null)
                    Parent.RecalculateCancel(AllowOneLineCancel, value);

            }
        }

        public PreInvPrtModel Parent { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null) handler(this, new PropertyChangedEventArgs(propertyName));
        }
        
    }
}