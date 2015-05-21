using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using Bsdl.FreshTrade.Domain.Account.Entities;
using Bsdl.FreshTrade.UI.PreInv.ViewModel;
using System.Windows;

namespace Bsdl.FreshTrade.UI.PreInv.View
{
    /// <summary>
    /// Interaction logic for CustomerCategorySelect.xaml
    /// </summary>
    public partial class CustomerCategorySelect : Window
    {
        public CustomerCategorySelect()
        {
            InitializeComponent();
            DataContext = new CustomerCategoryViewModel(); 
        }

        public List<DTOCustomerCategory> SelectedCategories
        {
            get
            {
                return ((CustomerCategoryViewModel) DataContext).SelectedCustGroupCats.ToList();
            }
            set
            {
                ((CustomerCategoryViewModel) DataContext).SelectedCustGroupCats = new ObservableCollection<DTOCustomerCategory>(value);
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
