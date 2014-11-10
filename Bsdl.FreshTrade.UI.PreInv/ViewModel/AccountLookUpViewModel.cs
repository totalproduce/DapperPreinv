using System.Collections.Generic;
using System.Linq;
using Bsdl.FreshTrade.Domain.Account.Entities;
using Bsdl.FreshTrade.Domain.Account.Enums;
using Bsdl.FreshTrade.Domain.Account.Interfaces;
using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;
using Bsdl.FreshTrade.Domain.Basic.Exceptions;
using Bsdl.FreshTrade.Domain.PreInv.WideObjects;
using Bsdl.FreshTrade.UI.PreInv.Annotations;

namespace Bsdl.FreshTrade.UI.PreInv.ViewModel
{
    public class AccountLookUpViewModel : INotifyPropertyChanged
    {
        #region Variables

        private readonly List<WideAccountInfo> _selectedAccountList = new List<WideAccountInfo>();

        private WideAccountInfo[] _fullAccountList;

        private Visibility _visibility;

        //DataGridSelectionMode dataGridSelectionMode = new DataGridSelectionMode();

        private DataGridSelectionMode _dataGridSelectionMode;

        #endregion

        #region Properties

        public DataGridSelectionMode DataGridSelectionMode
        {
            get
            {
                return _dataGridSelectionMode;
            }
            set
            {
                _dataGridSelectionMode = value;
                OnPropertyChanged("DataGridSelectionMode");
            }
        }

        public DataGrid DataGrid { get; set; }

        public Visibility Visibility
        {
            get
            {
                return _visibility;
            }
            set
            {
                _visibility = value;
                OnPropertyChanged("Visibility");                
            }
        }

        public WideAccountInfo[] DisplayAccountList
        {
            get
            {
                return _displayAccountList;
            }
            set
            {
                _displayAccountList = value;
                OnPropertyChanged("DisplayAccountList");
            }
        }

        private WideAccountInfo[] _displayAccountList;
        
        #endregion

        #region Methods

        public void InitialiseAccountService(DTOAccountType? requiredAccountType, int salesOfficeNo)
        {
            using (var accountServiceClient = new AccountService.AccountsServiceClient())
            {
                _fullAccountList = accountServiceClient.GetAccountsBySalesOffice(salesOfficeNo, requiredAccountType);
                accountServiceClient.Close();
            }
        }

        public void SetGridDefaultSelectionMode()
        {
            _dataGridSelectionMode = DataGridSelectionMode.Extended;
        }

        public void SetDisplayAccounts()
        {
            DisplayAccountList = _fullAccountList;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        public List<WideAccountInfo> GetOneAccountOnly()
        {
            var filter = "TO1";
            if ((_fullAccountList == null) || (_fullAccountList.Length == 0))
            {
                var ex = new FreshTradeException("No Accounts Available");
                //AppError.SetError(ex, ex.StackTrace, ErrorType.Warning);
                throw ex;
            }

            if (string.IsNullOrEmpty(filter))
            {
                var ex = new FreshTradeException("Invalid Code Passed");
                //AppError.SetError(ex, ex.StackTrace, ErrorType.UserInputError);
                throw ex;
            }


            var likeAccountList = new List<WideAccountInfo>();

            likeAccountList.AddRange(
                (from item in _fullAccountList
                where item.LocalAccountCode.Trim().Contains(filter.Trim())
                select item)
                );
                    ;
 
            if (likeAccountList.Count() == 1)
            {
                //foreach (IAccount account in result)
                //    likeAccountList.Accounts.Add(account);
                return likeAccountList;
            }
            var e = new FreshTradeException("No valid Accounts");
            //AppError.SetError(ex, ex.StackTrace, ErrorType.UserInputError);
            throw e;
        }

        public List<WideAccountInfo> ReturnSelectedAccountList(DataGrid passDisplayDataGrid)
        {
            _selectedAccountList.Clear();

            foreach (WideAccountInfo account in passDisplayDataGrid.SelectedItems)
            {
                if (account != null)
                {
                    _selectedAccountList.Add(account);
                }
            }

            return _selectedAccountList;
        }

        public void InitialiseAccountList(WideAccountInfo[] passInAccountList)
        {
            _fullAccountList = passInAccountList;
        }

        #endregion
    }
}
