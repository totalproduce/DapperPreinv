using System.Collections.Generic;
using System.ComponentModel;
using Bsdl.FreshTrade.Domain.Account.Entities;
using Bsdl.FreshTrade.Domain.Account.Enums;
using Bsdl.FreshTrade.Domain.Account.Interfaces;
using Bsdl.FreshTrade.Domain.Basic.Exceptions;
using Bsdl.FreshTrade.Domain.Basic.Utilities.DataTypeHandling;
using Bsdl.FreshTrade.Domain.PreInv.WideObjects;
using Bsdl.FreshTrade.UI.PreInv.ViewModel;
using System;
using System.Reflection;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace Bsdl.FreshTrade.UI.PreInv
{
    /// <summary>
    /// Interaction logic for AccountLookUp.xaml
    /// </summary>
    public partial class AccountLookUp : Window
    {
        #region Fields

        public AccountLookUpViewModel _accountLookUpViewModel = new AccountLookUpViewModel();

        public string DisplayName = "ACCOUNTLOOKUP";

        private bool _selectAndClose = false;

        #endregion

        #region Constructors

        public AccountLookUp()
        {
            InitializeComponent();
        }

        #endregion

        #region Properties

        public bool IsBusy
        {
            get { return (bool)GetValue(IsBusyProperty); }
            set { SetValue(IsBusyProperty, value); }
        }

        public static readonly DependencyProperty IsBusyProperty =
            DependencyProperty.Register("IsBusy", typeof(bool), typeof(AccountLookUp), new UIPropertyMetadata(false, OnIsBusyChanged));

        private DTOAccountType? _requiredAccountType = null;
        public DTOAccountType? RequiredAccountType
        {
            get { return _requiredAccountType; }
            set { _requiredAccountType = value; }
        }

        public int SalesOfficeNo { get; set; }

        //public static readonly DependencyProperty RequiredAccountTypeProperty =
        //    DependencyProperty.Register("RequiredAccountType", typeof(DTOAccountType?), typeof(AccountLookUp), new UIPropertyMetadata(false));

        #endregion

        #region Methods

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

            DataContext = _accountLookUpViewModel;
            _accountLookUpViewModel.SetGridDefaultSelectionMode();
            Mouse.OverrideCursor = null;
            Refresh();
        }

        public void InitialiseFromOtherWindow()
        {
            _accountLookUpViewModel.InitialiseAccountService(RequiredAccountType, SalesOfficeNo);
            AccountsResultsGrid.Items.Filter = FilterData;
        }

        public bool FilterData(object o)
        {
            IDTOAccount data = o as WideAccountInfo;

            bool idFilter = FilterItemOfData(data, "LocalAccountCode", AccountCodeFilterFld.Text);

            if (idFilter)
            {
                idFilter = FilterItemOfData(data, "Name", AccountNameFilterFld.Text);
            }

            if (idFilter)
            {
                idFilter = FilterItemOfData(data, "Telephone", AccountPhoneNoFilterFld.Text);
            }

            return idFilter;
        }

        public bool FilterItemOfData(IDTOAccount data, string propertyName, string itemText)
        {
            if (itemText == string.Empty)
            {
                return true;
            }

            PropertyInfo info = data.GetType().GetProperty(propertyName);

            if (info.GetValue(data, null) == null)
            {
                return false;
            }

            var genericFilter = new GenericFilter();
            return genericFilter.filterString(info.GetValue(data, null).ToString(), itemText);
        }

        private void DataGridPreviewKeyDown(object sender, KeyEventArgs e)
        {
            var grid = sender as DataGrid;
            if (grid == null)
            {
                return;
            }

            switch (e.Key)
            {
                case Key.Up:
                    int currentRowIndex = grid.Items.IndexOf(grid.CurrentItem);
                    if (currentRowIndex == 0)
                    {
                        e.Handled = true;
                        PutFocusOnFirstInput(grid, null);
                    }
                    break;
            }
        }

        private void RefreshButtonClick(object sender, RoutedEventArgs e)
        {            
            //try
            //{
            Refresh();
            //}
            //catch (FreshTradeException ex)
            //{
            //    //new ErrorWindow().ShowDialog();
            //    throw;
            //}
            //catch (Exception exception)
            //{
            //    //AppError.SetError(exception, exception.StackTrace, ErrorType.Fatal);
            //    //new ErrorWindow().ShowDialog();
            //    throw;
            //}
        }

        private void Refresh()
        {
            BackgroundWorker worker = new BackgroundWorker();
            worker.DoWork += RefreshDoWork;
            worker.RunWorkerCompleted += RefreshCompleted;
            worker.RunWorkerAsync();

            IsBusy = true;
        }

        private void RefreshDoWork(object sender, DoWorkEventArgs e)
        {
            _accountLookUpViewModel.InitialiseAccountService(RequiredAccountType, SalesOfficeNo);
        }

        private void RefreshCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if(sender is BackgroundWorker)
            {
                BackgroundWorker worker = sender as BackgroundWorker;
                worker.DoWork -= RefreshDoWork;
                worker.RunWorkerCompleted -= RefreshCompleted;
            }
            _accountLookUpViewModel.SetDisplayAccounts();

            IsBusy = false;
        }

        public List<WideAccountInfo> GetSelected()
        {
            return _accountLookUpViewModel.ReturnSelectedAccountList(AccountsResultsGrid);
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (!_selectAndClose)
            {
                AccountsResultsGrid.SelectedItem = null;
                _selectAndClose = false;
            }
        }

        private void SelectAndClose(object sender, ExecutedRoutedEventArgs e)
        {
            _selectAndClose = true;
            this.Close();
        }

        private void FormClose(object sender, ExecutedRoutedEventArgs e)
        {
            Close();
        }

        private void GoToGrid(object sender, ExecutedRoutedEventArgs e)
        {
            var grid = AccountsResultsGrid;
            if (grid.HasItems)
            {
                Bsdl.FreshTrade.UI.Basic.Utilities.WpfControls.DataGridHelper.FocusOnCell(grid, 0, 0);
            }
        }

        private void PutFocusOnFirstInput(object sender, ExecutedRoutedEventArgs e)
        {
            AccountCodeFilterFld.Focus();
        }

        private void KeyTextBoxTextChanged(object sender, TextChangedEventArgs e)
        {
            this.AccountsResultsGrid.Items.Filter = this.FilterData;
        }

        private void AccountCodeFilterFld_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            Key thiskey = e.Key;
        }

        private static void OnIsBusyChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if(d is AccountLookUp)
            {
                AccountLookUp window = d as AccountLookUp;
                if( window.IsBusy )
                {
                    window.SetBusy();
                }
                else
                {
                    window.ClearBusy();
                }
            }
        }

        private void SetBusy()
        {
            Cursor = Cursors.Wait;
        }

        private void ClearBusy()
        {
            Cursor = Cursors.Arrow;
        }

        #endregion
    }
}
