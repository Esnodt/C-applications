using Airport_application.Classes;
using Airport_application.DB;
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

namespace Airport_application.VIew.Pages.Admin.Functions_for_a_data
{
    /// <summary>
    /// Логика взаимодействия для infoPage.xaml
    /// </summary>
    public partial class infoPage : Page
    {
        private Route selectedItem;
        public infoPage(Route selectedItem)
        {
            InitializeComponent();
            this.selectedItem = selectedItem;
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            dataView.ItemsSource = connectClass.db.Route.Where(item => item.PlaneID == selectedItem.Plane.ID && item.Plane.PassengersID == selectedItem.Plane.Passengers.ID).ToList();
        }

        private void backBtn_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }
    }
}
