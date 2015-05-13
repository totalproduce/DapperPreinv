using System.Collections;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows.Input;
using Bsdl.FreshTrade.Domain.Account.Entities;
using Bsdl.FreshTrade.UI.Basic.Utilities.WpfControls;
using System.Collections.Generic;

namespace Bsdl.FreshTrade.UI.PreInv.ViewModel
{
    public class CustomerCategoryViewModel : ViewModelBase
    {
        enum AccountKindType
        {
            akCustomer,
            akSupplier
        }
        #region Fields
        private AccountKindType _accountKind = AccountKindType.akCustomer;
        private int accountCount = 0;
        private List<DTOCustomerGroup> _custGroups;
        private List<DTOCustomerCategory> _custGroupCats;
        private ObservableCollection<DTOCustomerCategory> _selectedCustGroupCats = new ObservableCollection<DTOCustomerCategory>();
        #endregion

        #region Initialization
        public CustomerCategoryViewModel()
        {
            RefreshCustomerGroups();
        }
        #endregion

        #region helpers
        private void RefreshCustomerGroups()
        {
            using (var custServiceClient = new CustomerService.CustomerServiceClient())
            {
                _custGroups = custServiceClient.GetCustomerGroups(IsCustomer);
            }
            RaisePropertyChanged("CustomerGroups");

            AccountCount = _custGroups.Sum(g => g.AccountCount);

        }

        private void RefreshCustomerGroupCategories(int? custGroupId)
        {
            if (custGroupId.HasValue)
            {

                using (var custServiceClient = new CustomerService.CustomerServiceClient())
                {
                    _custGroupCats = custServiceClient.GetCustomerCategoriesByGroup(custGroupId.Value);
                }
            }
            else
            { //empty the storage
                _custGroupCats = new List<DTOCustomerCategory>();
            }

            RaisePropertyChanged("CustomerGroupCats");
        }

        #endregion

        #region Properties
        public bool IsCustomer
        {
            get
            {
                return _accountKind == AccountKindType.akCustomer;
            }
            set
            {
                _accountKind = value ? AccountKindType.akCustomer : AccountKindType.akSupplier;
                RaisePropertyChanged("IsCustomer");
                RefreshCustomerGroups();
            }
        }
        public bool IsSupplier
        {
            get
            {
                return _accountKind == AccountKindType.akSupplier;
            }
            set
            {
                _accountKind = value ? AccountKindType.akSupplier : AccountKindType.akCustomer;
                RaisePropertyChanged("IsSupplier");
                RefreshCustomerGroups();

            }
        }

        public List<DTOCustomerGroup> CustomerGroups
        {
            get { return _custGroups; }
        }

        public List<DTOCustomerCategory> CustomerGroupCats
        {
            get { return _custGroupCats; }
        }

        public ObservableCollection<DTOCustomerCategory> SelectedCustGroupCats
        {
            get { return _selectedCustGroupCats; }
            set { _selectedCustGroupCats = value; }
        }

        public int AccountCount
        {
            get { return accountCount; }
            set
            {
                accountCount = value;
                RaisePropertyChanged("AccountCount");
            }
        }


        //private AccountKindType AccountKind
        //{
        //    get
        //    {
        //        return _accountKind;
        //    }
        //    set
        //    {
        //        _accountKind = value;
        //        RaisePropertyChanged("IsCustomer");
        //        RaisePropertyChanged("IsSupplier");
        //    }
        //}
        #endregion

        #region Commands

        private ICommand _groupItemSelect;
        public ICommand GroupItemSelect
        {
            get
            {
                if (_groupItemSelect == null)
                {
                    _groupItemSelect = new RelayCommand(GroupItemSelectExecute);
                }
                return _groupItemSelect;
            }
        }

        private ICommand _categoryAdd;
        public ICommand CategoryAdd
        {
            get
            {
                if (_categoryAdd == null)
                {
                    _categoryAdd = new RelayCommand(CategoryAddExecute);
                }
                return _categoryAdd;
            }
        }


        private ICommand _categoryRemove;
        public ICommand CategoryRemove
        {
            get
            {
                if (_categoryRemove == null)
                {
                    _categoryRemove = new RelayCommand(CategoryRemoveExecute);
                }
                return _categoryRemove;
            }
        }

        #endregion

        #region Actions
        private void GroupItemSelectExecute(object parameter)
        {
            var lGroupId = (parameter as DTOCustomerGroup) == null ? (int?)null : (parameter as DTOCustomerGroup).Id;
            RefreshCustomerGroupCategories(lGroupId);
        }

        private void CategoryAddExecute(object param)
        {
            if (param is IList)
            {
                var list = ((IList)param).Cast<DTOCustomerCategory>();
                foreach (var selectCategory in list)
                {
                    if (!_selectedCustGroupCats.Contains(selectCategory))
                    {
                        _selectedCustGroupCats.Add(selectCategory);
                    }

                }
            }
            RaisePropertyChanged("SelectedCustGroupCats");
        }

        private void CategoryRemoveExecute(object param)
        {
            if (param is IList)
            {
                var list = ((IList)param).Cast<DTOCustomerCategory>();
                //add temp array because we remove collection items which come in as params from the same collection
                var catToRemove =
                    list.Select(selectedCategory => _selectedCustGroupCats.IndexOf(selectedCategory)).ToArray();
                for (int i = 0; i < catToRemove.Count(); i++)
                {
                    _selectedCustGroupCats.RemoveAt(i);
                }
            }
            RaisePropertyChanged("SelectedCustGroupCats");
        }

        #endregion
    }
}
