using System;
using System.Collections.Generic;
using System.ComponentModel;

using Bsdl.FreshTrade.Domain.PreInv.Entities;
using Bsdl.FreshTrade.Domain.PreInv.Interfaces;


namespace Bsdl.FreshTrade.UI.PreInv.Model
{
    public class PreInvTotModel : DTOInvTot, INotifyPropertyChanged
    {

        public PreInvTotModel()
        {
            
        }

        public PreInvTotModel(IDTOInvTot b)
            : this()
        {
            //MemStorageKey = b.MemStorageKey;
            ExtractSessionID = b.ExtractSessionID;
            AccGlAnl = b.AccGlAnl;
            AccntSalOffNo = b.AccntSalOffNo;
            BaseGdsTotal = b.BaseGdsTotal;
            Basehandcommamt = b.Basehandcommamt;
            BaseOffInvOnPay = b.BaseOffInvOnPay;
            BaseOffInvRbt = b.BaseOffInvRbt;
            BaseOnInvDscnt = b.BaseOnInvDscnt;
            BaseRate = b.BaseRate;
            BaseVat1Total = b.BaseVat1Total;
            BaseVat2Total = b.BaseVat2Total;
            BaseVatOnChgs = b.BaseVatOnChgs;
            BaseVatTotal = b.BaseVatTotal;
            CancelledInv = b.CancelledInv;
            CompanyName = b.CompanyName;
            CompoundVatCust = b.CompoundVatCust;
            CurDesc = b.CurDesc;
            CurNo = b.CurNo;
            EIInvoiceId = b.EIInvoiceId;
            EuroGdsTotal = b.EuroGdsTotal;
            Eurohandcommamt = b.Eurohandcommamt;
            EuroOffInvOnPay = b.EuroOffInvOnPay;
            EuroOffInvRbt = b.EuroOffInvRbt;
            EuroOnInvDscnt = b.EuroOnInvDscnt;
            EuroRate = b.EuroRate;
            EuroVat1Total = b.EuroVat1Total;
            EuroVat2Total = b.EuroVat2Total;
            EuroVatOnChgs = b.EuroVatOnChgs;
            EuroVatTotal = b.EuroVatTotal;
            Finfiscrep1 = b.Finfiscrep1;
            Finvatdesc1 = b.Finvatdesc1;
            Finvatnumber1 = b.Finvatnumber1;
            GoodsTotal = b.GoodsTotal;
            HofClaRecNo = b.HofClaRecNo;
            HofCstCode = b.HofCstCode;
            InvDate = b.InvDate;
            InvoiceNo = b.InvoiceNo;
            InvoiceTotal = b.InvoiceTotal;
            InvRecNo = b.InvRecNo;
            IsEdiCst = b.IsEdiCst;
            IsInterDept = b.IsInterDept;
            IsSeqInvNo = b.IsSeqInvNo;
            OffInvOnPay = b.OffInvOnPay;
            OffInvRbt = b.OffInvRbt;
            OnInvDscnt = b.OnInvDscnt;
            PrcGlbRecNo = b.PrcGlbRecNo;
            QtyTotal = b.QtyTotal;
            Rawhandcommamt = b.Rawhandcommamt;
            RawVatOnChgs = b.RawVatOnChgs;
            Sort1 = b.Sort1;
            Sort2 = b.Sort2;
            Sort3 = b.Sort3;
            StInvTotal = b.StInvTotal;
            TriangReq = b.TriangReq;
            TwoVatRatesCust = b.TwoVatRatesCust;
            Vat1Total = b.Vat1Total;
            Vat2Total = b.Vat2Total;
            VatCodeChgs = b.VatCodeChgs;
            VatRateChgs = b.VatRateChgs;
            VatTotal = b.VatTotal;
            WriteAccReChg = b.WriteAccReChg;
            Cancel = b.Cancel;
            VatInfo = b.VatInfo;
        }

        public Action RecalcSum { get; set; }

        public new bool CancelledInv
        {
            get
            {
                return base.CancelledInv;
            }
            set
            {
                base.CancelledInv = value;
                if (Children != null)
                {
                    foreach (var child in Children)
                    {
                        child.SetCancelledDlv(value);
                    }
                }

                RecalculateSum();

                OnPropertyChanged("CancelledInv");
            }
        }

        public List<PreInvPrtModel> Children { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;

        public void RecalculateCancel(bool allowOneLineCancel, bool setValue)
        {
/*            if (allowOneLineCancel)
            {*/
                var oneChecked = !Children.Exists(c => !c.CancelledDlv);
                base.CancelledInv = oneChecked;
/*            }
            else
            {
                base.CancelledInv = setValue;

                foreach (var child in Children)
                {
                    child.SetCancelledDlv(CancelledInv);
                }
            }*/

            RecalculateSum();
        }

        private void RecalculateSum()
        {
            if (RecalcSum != null)
            {
                RecalcSum();
                OnPropertyChanged("QtyTotal");
                OnPropertyChanged("GoodsTotal");
                OnPropertyChanged("VatTotal");
                OnPropertyChanged("InvoiceTotal");
            }

            OnPropertyChanged("CancelledInv");
        }

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}