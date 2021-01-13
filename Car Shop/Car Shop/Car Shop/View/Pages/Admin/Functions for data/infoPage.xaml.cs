using Car_Shop.Classes;
using Car_Shop.DB;
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

namespace Car_Shop.View.Pages.Admin.Functions_for_data
{
    /// <summary>
    /// Логика взаимодействия для infoPage.xaml
    /// </summary>
    public partial class infoPage : Page
    {
        private Car selectedItem;
        public infoPage(Car selectedItem)
        {
            InitializeComponent();
            this.selectedItem = selectedItem;
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            listData.ItemsSource = connectClass.db.Car.Where(item => item.ID == selectedItem.ID && item.CountryID == selectedItem.CountryManufacture.ID && item.SpecID == selectedItem.Specifications.ID && item.Specifications.SizeID == selectedItem.Specifications.Size.ID).ToList();

        }

        private void backBtn_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }
    }
}
