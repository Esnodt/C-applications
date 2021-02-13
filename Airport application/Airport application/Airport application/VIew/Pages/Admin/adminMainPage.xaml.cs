using Airport_application.Classes;
using Airport_application.DB;
using Airport_application.VIew.Pages.Admin.Functions_for_a_data;
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

namespace Airport_application.VIew.Pages.Admin
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

        private void backBtn_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            datavIew.ItemsSource = connectClass.db.Route.ToList();
        }

        // Кнопка изменения
        private void editBtn_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Route editRoute = (Route)datavIew.SelectedItem;
                if(editRoute != null)
                {
                    NavigationService.Navigate(new editPage(editRoute));
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

        // Поисковая строка
        private void searchTxb_TextChanged(object sender, TextChangedEventArgs e)
        {
            datavIew.ItemsSource = connectClass.db.Route.Where(item => item.DepPoint.Contains(searchTxb.Text) || item.ArrPoint.Contains(searchTxb.Text)).ToList();
        }

        //Btn for reading additional data
        private void infoBtn_Click(object sender, RoutedEventArgs e)
        {

            try
            {
                Route infoRoute = (Route)datavIew.SelectedItem;
                if(infoRoute != null)
                {
                    NavigationService.Navigate(new infoPage(infoRoute));
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

        //Btn for deleting data
        private void deleteBtn_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Route deleteRoute = new Route();
                if(MessageBox.Show("Вы действительно хотите удалить элемент? Данные будут удалены навсегда!", "Вы уверены?", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
                {
                    if(deleteRoute != null)
                    {
                        connectClass.db.Route.Remove(deleteRoute);
                        connectClass.db.SaveChanges();
                        Page_Loaded(null ,null);
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

        private void addBtn_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new addPage());
        }

        //Export to PDF
        private void pdfBtn_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                this.IsEnabled = false;
                PrintDialog printDialog = new PrintDialog();
                if(printDialog.ShowDialog() == true)
                {
                    printDialog.PrintVisual(datavIew, "invoice");
                }
            }
            finally
            {
                this.IsEnabled = true;
            }
        }
    }
}
