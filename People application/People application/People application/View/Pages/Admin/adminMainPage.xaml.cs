using People_application.Classes;
using People_application.DB;
using People_application.View.Pages.Admin.Functions_for_a_data;
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

namespace People_application.View.Pages.Admin
{
    /// <summary>
    /// Логика взаимодействия для adminMainPage.xaml
    /// </summary>
    public partial class adminMainPage : Page
    {
        public adminMainPage()
        {
            InitializeComponent();
        }

        private void listDataView_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            Human editHuman = (Human)listDataView.SelectedItem;
            if(editHuman != null)
            {
                NavigationService.Navigate(new editPage(editHuman));
            }
            else
            {
                MessageBox.Show("Выберите элемент!");
            }
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            listDataView.ItemsSource = connectClass.db.Human.ToList();
        }

        private void addBtn_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new addPage());
        }

        private void removeBtn_Click(object sender, RoutedEventArgs e)
        {
            Human removeHuman = (Human)listDataView.SelectedItem;
            if(removeHuman != null)
            {
                connectClass.db.Human.Remove(removeHuman);
                connectClass.db.SaveChanges();
                Page_Loaded(null, null);
            }
            else
            {
                MessageBox.Show("Выберите элемент!");
            }
        }
    }
}
