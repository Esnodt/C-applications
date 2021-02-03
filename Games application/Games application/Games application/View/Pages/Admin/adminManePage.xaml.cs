using Games_application.Classes;
using Games_application.DB;
using Games_application.View.Pages.Admin.Functions_for_a_data;
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

namespace Games_application.View.Pages.Admin
{
    /// <summary>
    /// Логика взаимодействия для adminManePage.xaml
    /// </summary>
    public partial class adminManePage : Page
    {
        public adminManePage()
        {
            InitializeComponent();
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            listDataView.ItemsSource = connectClass.db.Game.ToList();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new addPage());
        }

        private void listDataView_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            try
            {
                Game infoGame = (Game)listDataView.SelectedItem;
                if (infoGame != null)
                {
                    NavigationService.Navigate(new infoPage(infoGame));
                }
                else
                {
                    throw new Exception("Выберите элемент!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButton.OK, MessageBoxImage.Error);
            }
         }

        private void deleteBtn_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Game deleteGame = (Game)listDataView.SelectedItem;
                if (MessageBox.Show("Вы точно хоите удалить элемент?, Данные будут удалены навсегда!", "Вы уверены?", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
                {
                    if(deleteGame != null)
                    {
                        connectClass.db.Game.Remove(deleteGame);
                        connectClass.db.SaveChanges();
                        Page_Loaded(null, null);
                    }
                    else
                    {
                        throw new Exception("Выберите элемент!");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void editBtn_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Game editGame = (Game)listDataView.SelectedItem;
                if (editGame != null)
                {
                    NavigationService.Navigate(new editPage(editGame));
                }
                else
                {
                    throw new Exception("Выберите элемент!");
                }
            }
            catch (Exception ex)
            {
               MessageBox.Show(ex.Message, ex.Source, MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
