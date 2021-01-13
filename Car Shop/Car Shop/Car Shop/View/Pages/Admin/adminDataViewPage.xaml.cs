using Car_Shop.Classes;
using Car_Shop.DB;
using Car_Shop.View.Pages.Admin.Functions_for_data;
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

namespace Car_Shop.View.Pages.Admin
{
    /// <summary>
    /// Логика взаимодействия для adminDataViewPage.xaml
    /// </summary>
    public partial class adminDataViewPage : Page
    {
        public adminDataViewPage()
        {
            InitializeComponent();
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            dataaView.ItemsSource = connectClass.db.Car.ToList();
        }

        private void backBtn_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }

        private void addBtn_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new addPage());
        }

        private void deletVBtn_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Car deleteCar = (Car)dataaView.SelectedItem;
                if(MessageBox.Show("Вы действительно хотите удалить элемент? Данные будут удалены навсегда!", "Вы уверены?", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
                {
                    if(deleteCar != null)
                    {
                        connectClass.db.Car.Remove(deleteCar);
                        connectClass.db.SaveChanges();
                        Page_Loaded(null, null);
                    }
                    else
                    {
                        throw new Exception("Для удаления выберите элемент!");
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
                Car editCar = (Car)dataaView.SelectedItem;
                if(editCar != null)
                {
                    NavigationService.Navigate(new editPage());
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

        private void infoBtn_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Car infoCar = (Car)dataaView.SelectedItem;
                if (infoCar != null)
                {
                    NavigationService.Navigate(new infoPage(infoCar));
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
