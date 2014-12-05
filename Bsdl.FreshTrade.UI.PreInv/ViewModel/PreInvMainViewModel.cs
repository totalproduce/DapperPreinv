using Bsdl.FreshTrade.Domain.Account.Entities;
using Bsdl.FreshTrade.Domain.Account.Enums;
using Bsdl.FreshTrade.Domain.Basic.Entities;
using Bsdl.FreshTrade.Domain.Basic.Exceptions;
using Bsdl.FreshTrade.Domain.PreInv.Entities;
using Bsdl.FreshTrade.Domain.PreInv.Enums;
using Bsdl.FreshTrade.Domain.PreInv.Utilities;
using Bsdl.FreshTrade.Domain.PreInv.WideObjects;
using Bsdl.FreshTrade.UI.Basic.Utilities.WpfControls;
using Bsdl.FreshTrade.UI.PreInv.AccountService;
using Bsdl.FreshTrade.UI.PreInv.Helpers;
using Bsdl.FreshTrade.UI.PreInv.Model;
using Bsdl.FreshTrade.UI.PreInv.PreInvReportService;
using Bsdl.FreshTrade.UI.PreInv.PreInvService;
using Bsdl.FreshTrade.UI.PreInv.SalesOfficeService;
using Bsdl.FreshTrade.UI.PreInv.View;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Forms;
using System.Windows.Forms.Integration;
using System.Windows.Input;
using MessageBox = System.Windows.MessageBox;

namespace Bsdl.FreshTrade.UI.PreInv.ViewModel
{
    public class PreInvMainViewModel : ViewModelBase
    {
        #region Fields with Default values

        private const string _repNameError = "ErrorReport";
        private const string _repNameSummary = "SummaryReport";
        private const string _repNameDetail = "DetailReport";

        private readonly Dictionary<string, string> _reportPath = new Dictionary<string, string>()
                                                                      {
                                                                          {_repNameError, @"/Reports/ErrorReport.rdl"},
                                                                          {_repNameSummary, @"/Reports/PreInvSummary.rdl"},
                                                                          {_repNameDetail, @"/Reports/PreInvDetail.rdl"},
                                                                      };
        private bool _filterAllCustomers = true;
        private bool _filterByCustomer;
        private bool _filterByCategory;
        private bool _invTypeInvoice = true;
        private DateTime _taxDate = DateTime.Now.Date;
        private DateTime _cutOffDate = DateTime.Now.Date;
        private WideAccountInfo _filterCustomerDTOAccount;
        private List<DTOCustomerCategory> _filterCustomerCategories;
        private DTOCompany _accountCompany;
        private DTOCurrency _currency;

        private int _activeTabItemIndex = 0;
        private List<DTOPreInvExtractionErrorsItem> _extractErrorList;
        private List<PreInvPrtModel> _extractInvoicePartList;
        private List<PreInvPrt2Model> _extractInvoicePart2List;
        private List<PreInvTotModel> _extractInvoiceTotalList;

        private AsyncExtractor<PreInvServiceClient, DTOPreInvExtractResult> _mAsyncExtractor;
        private AsyncExtractor<PreInvServiceClient, bool> _mAsyncUpdater;

        private readonly DTOSalesOffice[] _salesOfficeList;
        private DTOSalesOffice _selectedSalesOffice;
        private DTOInvTot _selectedExtractInvoiceTotal;
        private DTOInvPrt _selectedExtractInvoicePart;
        private bool _requestWasSent = false;

        private bool? _checkAllCheckBoxes = null;
        private bool _periodDaily;
        private bool _periodWeekly;
        private bool _invKindPerOrder;
        private bool _invKindPerDelivery;
        private bool _invKindPerCustomer;
        private bool _invTypeCreditNote;
        private bool _invTypeDebitNote;

        private bool _preinvIsMergeLikePrices = true;
        private bool _preinvIsSummaryPrint = true;
        private bool _preinvIsDetailPrint = false;
        private bool _printToPrinter = false;
        private bool _printToScreen = false;
        private bool _printToFile = true;

        #endregion Fields

        #region Properties

        public bool IsExtractEnabled { get; set; }

        public bool IsChanged { get; set; }


        public bool FilterAllCustomers
        {
            get { return _filterAllCustomers; }
            set
            {
                _filterAllCustomers = value;
                RaisePropertyChanged("FilterAllCustomers");
                ValidateExtractData();
            }
        }

        public bool FilterByCategory
        {
            get
            {
                return _filterByCategory;
            }
            set
            {
                _filterByCategory = value;
                RaisePropertyChanged("FilterByCategory");
                ValidateExtractData();
            }
        }

        public bool FilterByCustomer
        {
            get
            {
                return _filterByCustomer;
            }
            set
            {
                _filterByCustomer = value;
                RaisePropertyChanged("FilterByCustomer");
                ValidateExtractData();
            }
        }

        public WideAccountInfo FilterCustomer
        {
            get { return _filterCustomerDTOAccount; }
            set
            {
                _filterCustomerDTOAccount = value;
                RaisePropertyChanged("FilterCustomer");
                RaisePropertyChanged("FilterCustomerAccountName");
                ValidateExtractData();
            }
        }

        private List<WideAccountInfo> _customers;

        public IEnumerable<WideAccountInfo> Customers
        {
            get
            {
                if (_customers == null)
                {
                    if (_selectedSalesOffice != null && FilterByCustomer)
                    {
                        using (var accountService = new AccountsServiceClient())
                        {
                            _customers = accountService.GetAccountsBySalesOffice(_selectedSalesOffice.SalesOfficeNumber,
                                DTOAccountType.Customer).ToList();
                        }
                    }
                }

                return _customers;
            }
        }

        public string FilterCustomerAccountCode
        {
            get
            {
                return _filterCustomerDTOAccount == null ? string.Empty : _filterCustomerDTOAccount.LocalAccountCode;
            }
        }

        public string FilterCustomerAccountName
        {
            get
            {
                return _filterCustomerDTOAccount == null ? string.Empty : _filterCustomerDTOAccount.Name;
            }
        }

        private string _customerCodeText;

        public string CustomerCodeText
        {
            get { return _customerCodeText; }
            set
            {
                _customerCodeText = value.ToUpper();
                RaisePropertyChanged("CustomerCodeText");

                //Loading new list of customers for specific sales office
                if (_customers == null)
                    RaisePropertyChanged("Customers");
            }
        }

        public List<DTOCustomerCategory> FilterCustomerCategories
        {
            get { return _filterCustomerCategories; }
        }

        public bool InterCompanyTransfer { get; set; }

        public DTOCompany AccountCompany
        {
            get
            {
                return _accountCompany;
            }
            set
            {
                _accountCompany = value;
                RaisePropertyChanged("AccountCompany");
            }
        }

        public DTOCurrency Currency
        {
            get
            {
                return _currency;
            }
            set
            {
                _currency = value;
                RaisePropertyChanged("Currency");
            }
        }

        public DateTime CutOffDate
        {
            get { return _cutOffDate; }
            set
            {
                _cutOffDate = value;
                RaisePropertyChanged("CutOffDate");
            }
        }

        public DateTime TaxDate
        {
            get { return _taxDate; }
            set
            {
                _taxDate = value;
                RaisePropertyChanged("TaxDate");
            }
        }

        public bool? CheckAllCheckBoxes
        {
            get { return _checkAllCheckBoxes; }
            set
            {
                if (_checkAllCheckBoxes.HasValue && _checkAllCheckBoxes == true && !value.HasValue) //Skiping Intermediate status after "true"
                {
                    _checkAllCheckBoxes = false;
                }
                else
                {
                    _checkAllCheckBoxes = value;
                }

                if (_checkAllCheckBoxes.HasValue)
                {
                    //_periodDaily = _checkAllCheckBoxes.Value;
                    //_periodWeekly = _checkAllCheckBoxes.Value;
                    _invKindPerCustomer = _checkAllCheckBoxes.Value;
                    _invKindPerDelivery = _checkAllCheckBoxes.Value;
                    _invKindPerOrder = _checkAllCheckBoxes.Value;
                    _invTypeDebitNote = _checkAllCheckBoxes.Value;
                    _invTypeCreditNote = _checkAllCheckBoxes.Value;
                    _invTypeInvoice = _checkAllCheckBoxes.Value;

                    //RaisePropertyChanged("PeriodDaily");
                    //RaisePropertyChanged("PeriodWeekly");
                    RaisePropertyChanged("InvKindPerCustomer");
                    RaisePropertyChanged("InvKindPerDelivery");
                    RaisePropertyChanged("InvKindPerOrder");
                    RaisePropertyChanged("InvTypeInvoice");
                    RaisePropertyChanged("InvTypeDebitNote");
                    RaisePropertyChanged("InvTypeCreditNote");

                    ValidateExtractData();
                }
            }
        }

        public bool PeriodDaily
        {
            get { return _periodDaily; }
            set
            {
                _periodDaily = value;
                RaisePropertyChanged("PeriodDaily");
                UpdateCheckAllCheckBox();
                ValidateExtractData();
            }
        }

        public bool PeriodWeekly
        {
            get { return _periodWeekly; }
            set
            {
                _periodWeekly = value;
                RaisePropertyChanged("PeriodWeekly");
                UpdateCheckAllCheckBox();
                ValidateExtractData();
            }
        }

        public bool InvKindPerDelivery
        {
            get { return _invKindPerDelivery; }
            set
            {
                _invKindPerDelivery = value;
                RaisePropertyChanged("InvKindPerDelivery");
                UpdateCheckAllCheckBox();
                ValidateExtractData();
            }
        }

        public bool InvKindPerOrder
        {
            get { return _invKindPerOrder; }
            set
            {
                _invKindPerOrder = value;
                RaisePropertyChanged("InvKindPerOrder");
                UpdateCheckAllCheckBox();
                ValidateExtractData();
            }
        }

        public bool InvKindPerCustomer
        {
            get { return _invKindPerCustomer; }
            set
            {
                _invKindPerCustomer = value;
                RaisePropertyChanged("InvKindPerCustomer");
                UpdateCheckAllCheckBox();
                ValidateExtractData();
            }
        }

        public bool InvTypeInvoice
        {
            get { return _invTypeInvoice; }
            set
            {
                _invTypeInvoice = value;
                RaisePropertyChanged("InvTypeInvoice");
                UpdateCheckAllCheckBox();
                ValidateExtractData();
            }
        }

        public bool InvTypeCreditNote
        {
            get { return _invTypeCreditNote; }
            set
            {
                _invTypeCreditNote = value;
                RaisePropertyChanged("InvTypeCreditNote");
                UpdateCheckAllCheckBox();
                ValidateExtractData();
            }
        }

        public bool InvTypeDebitNote
        {
            get { return _invTypeDebitNote; }
            set
            {
                _invTypeDebitNote = value;
                RaisePropertyChanged("InvTypeDebitNote");
                UpdateCheckAllCheckBox();
                ValidateExtractData();
            }
        }

        public List<DTOPreInvExtractionErrorsItem> ExtractErrorList
        {
            get
            {
                return _extractErrorList;
            }
            set
            {
                _extractErrorList = value;
                RaisePropertyChanged("ExtractErrorList");
            }
        }

        public List<PreInvPrtModel> ExtractInvoicePartList
        {
            get
            {
                return _extractInvoicePartList;
            }
            set
            {
                _extractInvoicePartList = value;
                RaisePropertyChanged("ExtractInvoicePartList");
            }
        }

        public List<PreInvPrt2Model> ExtractInvoicePart2List
        {
            get
            {
                return _extractInvoicePart2List;
            }
            set
            {
                _extractInvoicePart2List = value;
                RaisePropertyChanged("ExtractInvoicePart2List");
            }
        }

        public List<PreInvTotModel> ExtractInvoiceTotalList
        {
            get
            {
                return _extractInvoiceTotalList;
            }
            set
            {
                _extractInvoiceTotalList = value;
                RaisePropertyChanged("ExtractInvoiceTotalList");
            }
        }

        public DTOInvTot SelectedExtractInvoiceTotal
        {
            get
            {
                return _selectedExtractInvoiceTotal;
            }
            set
            {
                _selectedExtractInvoiceTotal = value;
                RaisePropertyChanged("SelectedExtractInvoiceTotal");
            }
        }

        public DTOInvPrt SelectedExtractInvoicePart
        {
            get
            {
                return _selectedExtractInvoicePart;
            }
            set
            {
                _selectedExtractInvoicePart = value;
                RaisePropertyChanged("SelectedExtractInvoicePart");
            }
        }

        public DTOSalesOffice SelectedSalesOffice
        {
            get
            {
                return _selectedSalesOffice;
            }
            set
            {
                _selectedSalesOffice = value;
                _customers = null; //Cleanup
                //RaisePropertyChanged("Customers");
                FilterCustomer = null;

                RaisePropertyChanged("SelectedSalesOffice");
            }
        }

        public DTOSalesOffice[] SalesOfficeList
        {
            get
            {
                return _salesOfficeList;
            }
        }

        public bool PreinvIsMergeLikePrices
        {
            get
            {
                return _preinvIsMergeLikePrices;
            }
            set
            {
                _preinvIsMergeLikePrices = value;

                RaisePropertyChanged("PreinvIsMergeLikePrices");
            }
        }


        public bool PreinvIsSummaryPrint
        {
            get
            {
                return _preinvIsSummaryPrint;
            }
            set
            {
                _preinvIsSummaryPrint = value;

                if (PreinvIsDetailPrint == value)
                {
                    PreinvIsDetailPrint = !value;
                }

                RaisePropertyChanged("PreinvIsSummaryPrint");
            }
        }

        public bool PreinvIsDetailPrint
        {
            get
            {
                return _preinvIsDetailPrint;
            }
            set
            {
                _preinvIsDetailPrint = value;

                if (PreinvIsSummaryPrint == value)
                {
                    PreinvIsSummaryPrint = !value;
                }

                RaisePropertyChanged("PreinvIsDetailPrint");
            }
        }

        public bool PrintToPrinter
        {
            get
            {
                return _printToPrinter;
            }
            set
            {
                _printToPrinter = value;

                RaisePropertyChanged("PrintToPrinter");
            }
        }

        public bool PrintToScreen
        {
            get
            {
                return _printToScreen;
            }
            set
            {
                _printToScreen = value;

                RaisePropertyChanged("PrintToScreen");
            }
        }

        public bool PrintToFile
        {
            get
            {
                return _printToFile;
            }
            set
            {
                _printToFile = value;

                RaisePropertyChanged("PrintToScreen");
            }
        }

        #endregion Properties

        #region UI related Fields

        private bool _tabEnabledError = false;
        private bool _tabEnabledSave = false;
        private bool _extractionInProgress;
        private bool _updateInProgress;
        private int m_CurrentProgress;
        #endregion

        #region UI related Properties
        /// <summary>
        /// 0 - Extract Tab
        /// 1 - Errors Tab
        /// 2 - Update Tab
        /// </summary>
        public int ActiveTabItemIndex
        {
            get
            {
                return _activeTabItemIndex;
            }
            set
            {
                _activeTabItemIndex = value;
                OnPropertyChanged(() => ActiveTabItemIndex);
            }
        }

        public bool ExtractionInProgress
        {
            get
            {
                return _extractionInProgress;
            }
            set
            {
                _extractionInProgress = value;
                OnPropertyChanged(() => ExtractionInProgress);
            }
        }

        public bool UpdateInProgress
        {
            get
            {
                return _updateInProgress;
            }
            set
            {
                _updateInProgress = value;
                OnPropertyChanged(() => UpdateInProgress);
            }
        }        

        public int CurrentProgress
        {
            get { return m_CurrentProgress; }
            set
            {
                if (m_CurrentProgress != value)
                {
                    m_CurrentProgress = value;
                    OnPropertyChanged(() => CurrentProgress);
                }
            }
        }

        public bool TabEnabledError
        {
            get
            {
                return _tabEnabledError;
            }
            set
            {
                _tabEnabledError = value;
                RaisePropertyChanged("TabEnabledError");
            }
        }

        public bool TabEnabledSave
        {
            get
            {
                return _tabEnabledSave;
            }
            set
            {
                _tabEnabledSave = value;
                RaisePropertyChanged("TabEnabledSave");
            }
        }

        #endregion

        #region Initialization

        public PreInvMainViewModel()
        {
            using (var salesOfficeServiceClient = new SalesOfficesServiceClient())
            {
                _salesOfficeList = salesOfficeServiceClient.GetSalesOffices();
            }
            if (_salesOfficeList.Length > 0)
            {
                SelectedSalesOffice = _salesOfficeList[0];
            }

            using (var dictionaryServiceClient = new Basic.DictionaryServiceReference.DictionaryServiceClient())
            {
                _currencyList = dictionaryServiceClient.GetCurrencyData();
                _companyList = dictionaryServiceClient.GetCompanyData();
                dictionaryServiceClient.Close();
            }

            if (_currencyList.Length > 0)
            {
                Currency = _currencyList[0];
            }

            if (_companyList.Length > 0)
            {
                AccountCompany = _companyList[0];
            }

            //hardcode!!!
            PeriodDaily = true;
            PeriodWeekly = false;
            InvKindPerDelivery = true;
            InvKindPerOrder = true;
            InvKindPerCustomer = true;
            InvTypeInvoice = true;
            InvTypeCreditNote = true;
            InvTypeDebitNote = true;
            _checkAllCheckBoxes = true;
            IsChanged = true;
        }

        #endregion Initialization

        #region Data Mining Sources
        private readonly DTOCurrency[] _currencyList;
        private readonly DTOCompany[] _companyList;

        public DTOCurrency[] CurrencyList
        {
            get
            {
                return _currencyList;
            }
        }

        public DTOCompany[] CompanyList
        {
            get
            {
                return _companyList;
            }
        }
        #endregion Data Mining Sources

        #region Command Members

        private ICommand _extractDataCommand;
        public ICommand ExtractDataCommand
        {
            get
            {
                if (_extractDataCommand == null)
                {
                    _extractDataCommand = new RelayCommand(ExtractDataExecute, ExtractDataCanExecute);
                }
                return _extractDataCommand;
            }
        }

        private ICommand _abortExtractionCommand;
        public ICommand AbortExtractionCommand
        {
            get
            {
                if (_abortExtractionCommand == null)
                {
                    _abortExtractionCommand = new RelayCommand(AbortExtractionExecute);
                }
                return _abortExtractionCommand;
            }
        }

        private ICommand _updateDataCommand;
        public ICommand UpdateDataCommand
        {
            get
            {
                if (_updateDataCommand == null)
                {
                    _updateDataCommand = new RelayCommand(UpdateDataExecute, UpdateDataCanExecute);
                }
                return _updateDataCommand;
            }
        }

        private ICommand _printDataCommand;
        public ICommand PrintDataCommand
        {
            get
            {
                if (_printDataCommand == null)
                {
                    _printDataCommand = new RelayCommand(PrintDataExecute);
                }
                return _printDataCommand;
            }
        }

        private ICommand _selectCustomerAccount;
        public ICommand SelectCustomerAccount
        {
            get
            {
                if (_selectCustomerAccount == null)
                {
                    _selectCustomerAccount = new RelayCommand(SelectCustomerAccountExecute);
                }
                return _selectCustomerAccount;
            }
        }

        private ICommand _selectCustomerCats;
        public ICommand SelectCustomerCats
        {
            get
            {
                if (_selectCustomerCats == null)
                {
                    _selectCustomerCats = new RelayCommand(SelectCustomerCatsExecute);
                }
                return _selectCustomerCats;
            }
        }

        private ICommand _cancelExtractInvoiceTotal;
        public ICommand CancelExtractInvoiceTotal
        {
            get
            {
                if (_cancelExtractInvoiceTotal == null)
                {
                    _cancelExtractInvoiceTotal = new RelayCommand(CaancelExtractInvoiceTotalExecute);
                }
                return _cancelExtractInvoiceTotal;
            }
        }

        private ICommand _printErrors;
        public ICommand PrintErrors
        {
            get
            {
                if (_printErrors == null)
                {
                    _printErrors = new RelayCommand(PrintErrorsExecute);
                }
                return _printErrors;
            }
        }

        //        private ICommand _

        #endregion Command Members

        #region Events Implementation

        private void SelectCustomerAccountExecute(object param)
        {
            Mouse.OverrideCursor = System.Windows.Input.Cursors.Wait;
            AccountLookUp accountLookUp;
            try
            {
                accountLookUp = new AccountLookUp
                {
                    RequiredAccountType = DTOAccountType.Customer,
                    SalesOfficeNo = _selectedSalesOffice.SalesOfficeNumber
                };
                accountLookUp.ShowDialog();
            }
            finally
            {
                Mouse.OverrideCursor = null;
            }
            var selAccounts = accountLookUp.GetSelected();
            if (selAccounts.Count > 0)
            {
                _filterCustomerDTOAccount = selAccounts[0];
                RaisePropertyChanged("FilterCustomer");
                RaisePropertyChanged("FilterCustomerAccountCode");
                RaisePropertyChanged("FilterCustomerAccountName");
            }

            ValidateExtractData();
        }

        private void SelectCustomerCatsExecute(object param)
        {
            // Show Category Selection Form
            var custCatSelect = new CustomerCategorySelect();
            if (_filterCustomerCategories != null)
            {
                custCatSelect.SelectedCategories = _filterCustomerCategories;
            }
            custCatSelect.ShowDialog();
            _filterCustomerCategories = custCatSelect.SelectedCategories;
            RaisePropertyChanged("FilterCustomerCategories");

            ValidateExtractData();
        }

        private void CaancelExtractInvoiceTotalExecute(object param)
        {
            MessageBox.Show(SelectedExtractInvoiceTotal.CompanyName);
            //RaisePropertyChanged("FilterCustomerCategories");
        }

        private void PrintErrorsExecute(object param)
        {
            if (ExtractErrorList.Count == 0)
            {
                throw new FreshTradeException("There are no errors to print");
            }
            PrintReport(_repNameError);
        }
        private Stream GetReportDefinition(string reportName, string baseUrl)
        {
            var url = baseUrl + _reportPath[reportName];
            byte[] data;
            using (var client = new WebClient())
            {
                data = client.DownloadData(url);
            }
            return new MemoryStream(data);
        }

        private void PrintReport(string reportName, bool showPreview = false)
        {
            DataTable[] data;
            Uri serviceUrl;
            using (var preInvReportService = new PreInvReportServiceClient())
            {
                serviceUrl = preInvReportService.Endpoint.Address.Uri;
                data = preInvReportService.GenerateReport(reportName, null);
            }

            var viewer = new ReportViewer();
            viewer.ProcessingMode = ProcessingMode.Local;
            var localReport  = viewer.LocalReport;            
            var baseUrl = serviceUrl.AbsoluteUri.Replace(serviceUrl.AbsolutePath, string.Empty);
            localReport.LoadReportDefinition(GetReportDefinition(reportName, baseUrl));
            foreach(var table in data)
            {
                var dataSource = new ReportDataSource(table.TableName, table);
                localReport.DataSources.Add(dataSource);
            }
            viewer.ShowParameterPrompts = false;
            viewer.RefreshReport();

            if (!showPreview)
            {
                viewer.RenderingComplete += (sender, args) => InvokeInUiThread(() => viewer.PrintDialog());
            }
            else
            {
                InvokeInUiThread(() =>
                {
                    viewer.Dock = DockStyle.Fill;
                    var host = new WindowsFormsHost { Child = viewer };
                    var lwindow = new Window { Title = "Report View", Content = host, WindowState = WindowState.Maximized };

                    lwindow.ShowDialog();
                }
                    );
            }
        }

        private bool ExtractDataCanExecute()
        {
            return !ExtractionInProgress && IsExtractEnabled;
        }

        private void ExtractDataExecute(object param)
        {
            _requestWasSent = true;
            IsChanged = true;

            SetInitialState();
            ExtractionInProgress = true;

            _mAsyncExtractor = new AsyncExtractor<PreInvServiceClient, DTOPreInvExtractResult>(
                DoExecuteExtractData, HandleExtractResult, CanContinueProgress, AbortExtraction);

            _mAsyncExtractor.BeginExecute();
        }

        private void AbortExtractionExecute(object param)
        {
            _mAsyncExtractor.Abort();
        }

        private void SetInitialState()
        {
            ActiveTabItemIndex = 0;
            TabEnabledSave = false;
            TabEnabledError = false;
            CurrentProgress = 0;
        }

        private void UpdateCheckAllCheckBox()
        {
            if (_invKindPerCustomer && _invKindPerDelivery && _invKindPerOrder && _invTypeInvoice && _invTypeCreditNote && _invTypeDebitNote)
            {
                _checkAllCheckBoxes = true;
            }
            else if (!_invKindPerCustomer && !_invKindPerDelivery && !_invKindPerOrder && !_invTypeInvoice && !_invTypeCreditNote && !_invTypeDebitNote)
            {
                _checkAllCheckBoxes = false;
            }
            else
            {
                _checkAllCheckBoxes = null;
            }

            RaisePropertyChanged("CheckAllCheckBoxes");
        }

        private DateTime GetAsNotLocalDate(DateTime datetime)
        {
            return DateTime.SpecifyKind(datetime.Date, DateTimeKind.Unspecified);
        }

        private DTOPreInvExtractParams InitializeExtractionParams()
        {
            var lParams = new DTOPreInvExtractParams
            {
                AccountParams = new DTOPreInvExtractAccountParams()
                {
                    FilterType = ReadFilterType()
                }
            };

            if (lParams.AccountParams.FilterType == PreInvExtractAccountFilterType.ByCustomer)
            {
                if (_filterCustomerDTOAccount != null)
                    lParams.AccountParams.AccountClassId = _filterCustomerDTOAccount.Id;
                else
                    lParams.AccountParams.AccountClassId = null;
            }
            if (lParams.AccountParams.FilterType == PreInvExtractAccountFilterType.ByCategory)
            {
                if (_filterCustomerCategories != null)
                    lParams.AccountParams.Categories = _filterCustomerCategories.Select(i => i.Id).ToList();
                else
                    lParams.AccountParams.Categories = null;
            }

            lParams.IsInterCompanyTransfer = InterCompanyTransfer;

            lParams.CompanyNo = (AccountCompany != null) ? AccountCompany.No : 0;
            lParams.CurrencyNo = (Currency != null) ? Currency.No : 0;

            lParams.TaxPointDate = GetAsNotLocalDate(TaxDate);
            lParams.CutOffDeliveryDate = GetAsNotLocalDate(CutOffDate);

            lParams.InvoicePeriodType = ReadPeriodType();
            lParams.BatchType = ReadBatchType();
            lParams.InvoiceType = ReadInvoiceType();

            lParams.SalesOfficeNo = SelectedSalesOffice.SalesOfficeNumber;

            return lParams;
        }

        private DTOPreInvExtractResult DoExecuteExtractData(PreInvServiceClient serviceClient)
        {
            DTOPreInvExtractResult extractResult = null;
            try
            {
                bool ok = true;
                var lParams = InitializeExtractionParams();
                if (lParams.AccountParams.FilterType == PreInvExtractAccountFilterType.ByCategory &&
                    lParams.AccountParams.Categories == null)
                {
                    MessageBox.Show("Choose categories.", "Error", MessageBoxButton.OK, MessageBoxImage.Warning);
                    ok = false;
                }

                if (lParams.AccountParams.FilterType == PreInvExtractAccountFilterType.ByCustomer &&
                    lParams.AccountParams.AccountClassId == null)
                {
                    MessageBox.Show("Choose customer.", "Error", MessageBoxButton.OK, MessageBoxImage.Warning);
                    ok = false;
                }

                if (ok)
                    extractResult = serviceClient.Extract(lParams);
            }
            catch (Exception e)
            {
                InvokeInUiThread(() => MessageBox.Show(e.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error));
            }
            finally
            {
                InvokeInUiThread(() => ExtractionInProgress = false);
                serviceClient.Close();
                // close session to avoid issues if user input needed (message box shown)
            }

            return extractResult;
        }

        public DTOSalesOffice GetCurrentSalesOffice()
        {
            return SelectedSalesOffice;
        }

        private bool CanContinueProgress(PreInvServiceClient serviceClient)
        {
            bool canContinue = false;
            try
            {
                var progress = serviceClient.GetProgress();
                if (progress.HasValue)
                {
                    BeginInvokeInUiThread(() => CurrentProgress = progress.Value);
                    canContinue = progress.Value < 100;
                }
            }
            catch (Exception)
            {

            }

            return canContinue;
        }

        private void AbortExtraction(PreInvServiceClient serviceClient)
        {
            serviceClient.Abort();
            InvokeInUiThread(() => CurrentProgress = 0);
        }

        private void HandleExtractResult(DTOPreInvExtractResult extractResult)
        {
            if (extractResult != null)
            {
                DoHandleExtractResult(extractResult);
            }

            InvokeInUiThread(() => ExtractionInProgress = false);
        }

        private void DoHandleExtractResult(DTOPreInvExtractResult extractResult)
        {
            switch (extractResult.Status)
            {
                case PreInvExtractStatusType.OK:
                    SetInvoicesAndOrders(extractResult);
                    InvokeInUiThread(() =>
                    {
                        TabEnabledSave = true;
                        ActiveTabItemIndex = 2; //Swiching to Confirmation screen
                    });
                    break;
                case PreInvExtractStatusType.Failed:
                    SetInvoicesAndOrders(extractResult);
                    InvokeInUiThread(() =>
                    {
                        ExtractErrorList = extractResult.Errors.ToList();
                        TabEnabledError = true;
                        TabEnabledSave = true;
                        ActiveTabItemIndex = 1; //Swiching to Errors Screen
                    });
                    break;
                case PreInvExtractStatusType.NothingToExtract:
                    InvokeInUiThread(() =>
                    {
                        MessageBox.Show("No Invoices extracted.", "Sorry", MessageBoxButton.OK, MessageBoxImage.Error);
                    });
                    break;
            }
        }

        //private void SetInvoicesAndOrders(DTOPreInvExtractResult extractResult)
        //{
        //    List<DTOInvTot> resultItems;

        //    var extractedItems = extractResult.InvoiceTotalItems;
        //    resultItems = extractedItems
        //            .OrderBy(x => x.Sort1)
        //            .ThenBy(x => x.Sort2)
        //            .ThenBy(x => x.InvoiceNo)
        //            .ToList();

        //    BeginInvokeInUiThread(() => ExtractInvoiceTotalList = resultItems);
        //}

        private void SetInvoicesAndOrders(DTOPreInvExtractResult extractResult)
        {

            List<PreInvTotModel> resultItemsTot;
            List<PreInvPrtModel> resultItemsPrt;
            List<PreInvPrt2Model> resultItemsPrt2;

            resultItemsPrt2 = extractResult.InvoicePart2Items
                .OrderBy(x => int.Parse(x.InvoiceNo.Remove(0, 1)))
                .ThenBy(x => x.DlvOrdNo)
                .Select(
                    x =>
                        new PreInvPrt2Model(x))
                .ToList();

            resultItemsPrt = extractResult.InvoicePartItems
                .OrderBy(p => int.Parse(p.DlvInvoiceNo.Remove(0, 1)))
                .ThenBy(p => p.OrdCustOrdNo) // feedback from client 
                //.OrderBy(x => x.Sort1)
                //.ThenBy(x => x.Sort2)
                //.ThenBy(x => x.DlvOrdNo)
                .Select(
                    x =>
                        new PreInvPrtModel()
                        {
                            DlvDelDate = x.DlvDelDate,
                            DlvInvoiceNo = x.DlvInvoiceNo,
                            DlvOrdNo = x.DlvOrdNo,
                            DlvPODNo = x.DlvPODNo,
                            OrdCstCode = x.OrdCstCode,
                            OrdCustOrdNo = x.OrdCustOrdNo,
                            Children = resultItemsPrt2.Where(c => c.InvoiceNo == x.DlvInvoiceNo && c.DlvOrdNo == x.DlvOrdNo).ToList()
                        })
                .ToList();

            resultItemsTot = extractResult.InvoiceTotalItems
                .OrderBy(x => x.Sort1)
                .ThenBy(x => x.Sort2)
                .ThenBy(x => x.InvoiceNo)
                .Select(
                    x =>
                        new PreInvTotModel(x)
                        {
                            Children = resultItemsPrt.Where(c => c.DlvInvoiceNo == x.InvoiceNo).ToList(),
                            RecalcSum = () =>
                            {
                                PreInvTotalCalculator.CalcTotals
                                    (
                                        ExtractInvoiceTotalList,
                                        ExtractInvoicePart2List.Where(t => !t.CancelledLine).ToList(),
                                        false
                                    );
                            }
                        })
                .ToList();


            foreach (var prt2Model in resultItemsPrt2)
            {
                prt2Model.Parent =
                    resultItemsPrt.FirstOrDefault(x => x.DlvOrdNo == prt2Model.DlvOrdNo && x.DlvInvoiceNo == prt2Model.InvoiceNo);
            }

            foreach (var prtModel in resultItemsPrt)
            {
                prtModel.Parent = resultItemsTot.FirstOrDefault(x => x.InvoiceNo == prtModel.DlvInvoiceNo);
            }

            BeginInvokeInUiThread(() => ExtractInvoiceTotalList = resultItemsTot);
            BeginInvokeInUiThread(() => ExtractInvoicePartList = resultItemsPrt);
            BeginInvokeInUiThread(() => ExtractInvoicePart2List = resultItemsPrt2);

        }

        private void UpdateDataExecute(object param)
        {
            UpdateInProgress = true;
            CurrentProgress = 0;

            _mAsyncUpdater = new AsyncExtractor<PreInvServiceClient, bool>
                (DoExecuteUpdateData, HandleUpdateResult, CanContinueProgress, AbortUpdate);
            _mAsyncUpdater.BeginExecute();
        }

        private void AbortUpdate(PreInvServiceClient obj)
        {
            _mAsyncUpdater.Abort();
        }

        private void HandleUpdateResult(bool success)
        {
            InvokeInUiThread(() =>
            {
                UpdateInProgress = false;
            });

            if (!success) return;
            InvokeInUiThread(() =>
            {
                MessageBoxResult result = MessageBox.Show("Update is succesfully completed", "Update Finished", MessageBoxButton.OK, MessageBoxImage.Information);
                if (result == MessageBoxResult.OK || result == MessageBoxResult.None)
                {
                    SetInitialState();
                }
            });
        }

        private bool DoExecuteUpdateData(PreInvServiceClient serviceClient)
        {
            var lres = true;
            try
            {
                serviceClient.Update(
                new DTOPreInvUpdateParams
                {
                    SelectedPreInvTot = ExtractInvoiceTotalList.Where(t => !t.CancelledInv).Select(i => i.InvoiceNo).ToList(),
                    SelectedPreInvPrt = ExtractInvoicePartList.Where(t => !t.CancelledDlv && t.DlvOrdNo.HasValue).Select(i => i.DlvOrdNo.Value).ToList(),
                    SelectedPreInvPrt2 = ExtractInvoicePart2List.Where(t => !t.CancelledLine && t.DelRecNo.HasValue).Select(i => i.DelRecNo.Value).ToList(),
                    MergeLikePrices = PreinvIsMergeLikePrices
                }
                );
            }
            catch (Exception e)
            {
                InvokeInUiThread(() => MessageBox.Show(e.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error));
                lres = false;
            }
            finally
            {
                InvokeInUiThread(() => UpdateInProgress = false);
                serviceClient.Close();
                // close session to avoid issues if user input needed (message box shown)
            }

            return lres;
        }

        private bool UpdateDataCanExecute()
        {
            return !UpdateInProgress && !IsChanged;
        }

        private void PrintDataExecute(object obj)
        {
            if ((PreinvIsSummaryPrint && PreinvIsDetailPrint) ||
                (PreinvIsSummaryPrint && PreinvIsDetailPrint))
            {
                throw new FreshTradeException("Please select Report format - Summary or Detailed");
            }

            var repPreinvUrl = PreinvIsSummaryPrint ? _repNameSummary : _repNameDetail;


            var selectedPreInvTot =
                ExtractInvoiceTotalList.Where(t => !t.CancelledInv).Select(i => i.InvoiceNo).ToList();
            var selectedPreInvPrt =
                ExtractInvoicePartList.Where(t => !t.CancelledDlv && t.DlvOrdNo.HasValue)
                    .Select(i => i.DlvOrdNo.Value)
                    .ToList();
            var selectedPreInvPrt2 =
                ExtractInvoicePart2List.Where(t => !t.CancelledLine && t.DelRecNo.HasValue)
                    .Select(i => i.DelRecNo.Value)
                    .ToList();

            if (
                selectedPreInvTot.Count == 0 ||
                selectedPreInvPrt.Count == 0 ||
                selectedPreInvPrt2.Count == 0
                )
            {
                throw new FreshTradeException("There is no data selected for printing.");
            }

            using (var preInvService = new PreInvServiceClient())
            {
                preInvService.PrepareForPrint(
                    new DTOPreInvUpdateParams
                    {
                        SelectedPreInvTot = selectedPreInvTot,
                        SelectedPreInvPrt = selectedPreInvPrt,
                        SelectedPreInvPrt2 = selectedPreInvPrt2,
                    }
                );

                if (PrintToFile)
                {
                    var csvData = preInvService.GetExportData(
                            new DTOPreInvUpdateParams
                            {
                                SelectedPreInvTot = selectedPreInvTot,
                                SelectedPreInvPrt = selectedPreInvPrt,
                                SelectedPreInvPrt2 = selectedPreInvPrt2,
                            }
                        );

                    InvokeInUiThread
                        (() =>
                        {
                            var saveDialog = new SaveFileDialog()
                            {
                                Filter = @"Comma separated list (*.csv)|*.csv|All files (*.*)|*.*",
                                OverwritePrompt = true,
                                Title = @"Please select file to save the export data",
                                CreatePrompt = false
                            };

                            if (saveDialog.ShowDialog() == DialogResult.OK)
                            {
                                var filePath = saveDialog.FileName;

                                TextWriter tw = new StreamWriter(filePath, false);
                                try
                                {
                                    tw.WriteLine(csvData);
                                    MessageBox.Show("Data successfully exported." + Environment.NewLine + saveDialog.FileName);
                                }
                                finally
                                {
                                    tw.Close();
                                }
                            }
                        });
                }
            }

            if (!PrintToFile)
            {

                PrintReport(repPreinvUrl, PrintToScreen);
            }

            IsChanged = false;

        }

        public void OnWindowClosing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            //if (sender is Window)
            //{
            //    (sender as Window).Closing -= OnWindowClosing;
            //} //It's requirement?

            if (MessageBox.Show("Would you like to close Pre-Invoicing?", "Close?", MessageBoxButton.YesNo, MessageBoxImage.Question) ==
                MessageBoxResult.Yes)
            {
                if (_requestWasSent)
                {
                    using (var preInvService = new PreInvServiceClient())
                    {
                        try
                        {
                            preInvService.CleanUp();
                        }
                        catch (Exception) { }
                    }
                }
            }
            else
            {
                e.Cancel = true;
            }
        }

        #endregion Events Implementation

        #region Helpers

        private PreInvExtractAccountFilterType ReadFilterType()
        {

            if (FilterAllCustomers)
            {
                return PreInvExtractAccountFilterType.All;
            }
            if (FilterByCategory)
            {
                return PreInvExtractAccountFilterType.ByCategory;
            }
            if (FilterByCustomer)
            {
                return PreInvExtractAccountFilterType.ByCustomer;
            }
            throw new FreshTradeException("Filtering parameter not specified");
        }

        private PreInvInvoiceType ReadInvoiceType()
        {
            var lRes = new PreInvInvoiceType();

            if (InvTypeInvoice)
            {
                lRes |= PreInvInvoiceType.Invoice;
            }
            if (InvTypeCreditNote)
            {
                lRes |= PreInvInvoiceType.CreditNote;
            }
            if (InvTypeDebitNote)
            {
                lRes |= PreInvInvoiceType.DebitNote;
            }

            if (lRes == 0)
            {
                throw new FreshTradeException("Invoice Type not specified");
            }

            return lRes;
        }

        private PreInvBatchType ReadBatchType()
        {
            PreInvBatchType res = new PreInvBatchType();

            if (InvKindPerDelivery)
            {
                res |= PreInvBatchType.PerDelivery;
            }
            if (InvKindPerOrder)
            {
                res |= PreInvBatchType.PerOrder;
            }
            if (InvKindPerCustomer)
            {
                res |= PreInvBatchType.PerCustomer;
            }

            if (res == 0)
                throw new FreshTradeException("Batch Type parameter not specified");

            return res;
        }

        private PreInvInvoicePeriodType ReadPeriodType()
        {
            return PeriodDaily ? PreInvInvoicePeriodType.DailyOnly : PreInvInvoicePeriodType.DailyAndWeekly;
        }

        private void ValidateExtractData()
        {
            IsExtractEnabled =
                (PeriodDaily || PeriodWeekly) &&
                (InvKindPerCustomer || InvKindPerDelivery || InvKindPerOrder) &&
                (InvTypeDebitNote || InvTypeCreditNote || InvTypeInvoice) &&
                (FilterAllCustomers ||
                 FilterByCategory && FilterCustomerCategories != null && FilterCustomerCategories.Count > 0 ||
                 FilterByCustomer && !string.IsNullOrEmpty(FilterCustomerAccountCode));
        }

        #endregion Helpers
    }
}
