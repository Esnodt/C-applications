using Mining_Application.Classes;
using Mining_Application.DB;
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

namespace Mining_Application.View.Pages.Admin.Functions_for_data
{
    /// <summary>
    /// Логика взаимодействия для infoPage.xaml
    /// </summary>
    public partial class infoPage : Page
    {
        private PickupPoint selectedItem;
       
        public infoPage(PickupPoint selectedItem)
        {
            InitializeComponent();
            this.selectedItem = selectedItem;
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            infoDataView.ItemsSource = connectClass.db.PickupPoint.Where(item => item.FieldID == selectedItem.Field.ID && item.ID == selectedItem.ID).ToList();
        }

        private void backBtn_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }
    }
}
