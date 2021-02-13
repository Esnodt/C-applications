using Show_application.Classes;
using Show_application.DB;
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

namespace Show_application.View.Pages
{
    /// <summary>
    /// Логика взаимодействия для MainPage.xaml
    /// </summary>
    public partial class MainPage : Page
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void listDataView_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            try
            {
                Room infoCopp = (Room)listDataView.SelectedItem;
                if(infoCopp != null)
                {
                    NavigationService.Navigate(new infoPage(infoCopp));
                }
                else
                {
                    throw new Exception("Выберите элемент");
                }
            }
            catch (Exception ex)
            {
               MessageBox.Show(ex.Message, ex.Source, MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            listDataView.ItemsSource = connectClass.db.Room.ToList();
        }

        private void addBtn_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new addPage());
        }

        private void editBtn_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Room editRoom = (Room)listDataView.SelectedItem;
                if(editRoom != null)
                {
                    NavigationService.Navigate(new editPage(editRoom));
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
                Room deleteRoom = (Room)listDataView.SelectedItem;
                if(MessageBox.Show("Вы уверены? Данные будут удалены навсегда!", "Вы точно хотите удалить данные?", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
                {
                    if(deleteRoom != null)
                    {
                        connectClass.db.Room.Remove(deleteRoom);
                        connectClass.db.SaveChanges();
                        Page_Loaded(null, null);
                    }
                    else
                    {
                        throw new Exception("Выберите элеменет!");
                    }
                } 
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void pdfBtn_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                this.IsEnabled = false;
                PrintDialog printDialog = new PrintDialog();
                if(printDialog.ShowDialog() == true)
                {
                    printDialog.PrintVisual(listDataView, "invoice");
                }
            }
            finally
            {
                this.IsEnabled = true;
            }
        }

        private void searchTxb_TextChanged(object sender, TextChangedEventArgs e)
        {
            listDataView.ItemsSource = connectClass.db.Room.Where(item => item.NameOfRoom.Contains(searchTxb.Text)).ToList();
        }
    }
}
