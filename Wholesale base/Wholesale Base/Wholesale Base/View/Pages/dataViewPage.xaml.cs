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
using Wholesale_Base.View.Pages.Functions_for_data;

namespace Wholesale_Base.View.Pages
{
    /// <summary>
    /// Логика взаимодействия для dataViewPage.xaml
    /// </summary>
    public partial class dataViewPage : Page
    {
        public dataViewPage()
        {
            InitializeComponent();
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            dataView.ItemsSource = connectClass.db.Provider.ToList();
        }

        private void exitBtn_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void addBtn_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new addPage());
        }

        private void editBtn_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Provider editProvider = (Provider)dataView.SelectedItem;
                if(editProvider != null)
                {
                    NavigationService.Navigate(new editPage(editProvider));
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
                Provider deleteProvider = (Provider)dataView.SelectedItem;
                if(MessageBox.Show("Вы точно хотите удалить элемент? Данные будут удалены навсегда!", "Вы уверены?", MessageBoxButton.YesNo, MessageBoxImage.Question ) == MessageBoxResult.Yes)
                {
                    if(deleteProvider != null)
                    {
                        connectClass.db.Provider.Remove(deleteProvider);
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

        private void infoBtn_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Provider infoProvider = (Provider)dataView.SelectedItem;
                if (infoProvider != null)
                {
                    NavigationService.Navigate(new infoPage(infoProvider));
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

        private void searchTxb_TextChanged(object sender, TextChangedEventArgs e)
        {
            dataView.ItemsSource = connectClass.db.Provider.Where(item => item.Product.ProducrName.Contains(searchTxb.Text)).ToList();
        }
    }
}
