using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Wholesale_Base.Classes;
using Wholesale_Base.DB;

namespace Wholesale_Base.View.Pages.Functions_for_data
{
    /// <summary>
    /// Логика взаимодействия для infoPage.xaml
    /// </summary>
    public partial class infoPage : Page
    {
        private Provider selectedItem;
        public infoPage(Provider selectedItem)
        {
            InitializeComponent();
            this.selectedItem = selectedItem;
        }

        private void backBtn_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            infoDataView.ItemsSource = connectClass.db.Provider.Where(item => item.ProductID == selectedItem.ID).ToList();
        }
    }
}
