using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using Bsdl.FreshTrade.Domain.PreInv.Entities;

namespace Bsdl.FreshTrade.UI.PreInv.Model
{
    public class PreInvPrtModel : DTOInvPrt, INotifyPropertyChanged
    {

        public void SetCancelledDlv(bool value)
        {
            base.CancelledDlv = value;
            OnPropertyChanged("CancelledDlv");

            foreach (var child in Children)
            {
                child.SetCancelledLine(value);
            }
        }
        
        public new bool CancelledDlv
        {
            get { return base.CancelledDlv; }
            set
            {
                SetCancelledDlv(value);
                
                Parent.RecalculateCancel(Children.First().AllowOneLineCancel, value);

            }
        }
        
        public PreInvTotModel Parent { get; set; }

        public List<PreInvPrt2Model> Children { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;

        public void RecalculateCancel(bool allowOneLineCancel, bool setValue)
        {
            if (allowOneLineCancel)
            {
                var oneChecked = !Children.Exists(c => !c.CancelledLine);
                base.CancelledDlv = oneChecked;
            }
            else
            {
                base.CancelledDlv = setValue;
            }
            

            if (Parent != null)
            {
                Parent.RecalculateCancel(allowOneLineCancel, setValue);
            }
            OnPropertyChanged("CancelledDlv");
        }

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null) handler(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}