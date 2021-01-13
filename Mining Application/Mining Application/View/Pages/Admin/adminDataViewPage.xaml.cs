using Mining_Application.Classes;
using Mining_Application.DB;
using Mining_Application.View.Pages.Admin.Functions_for_data;
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

namespace Mining_Application.View.Pages.Admin
{
    /// <summary>
    /// Логика взаимодействия для adminDataViewPage.xaml
    /// </summary>
    public partial class adminDataViewPage : Page
    {
        public adminDataViewPage()
        {
            InitializeComponent();
            importDataForComboBox.LoadType(selectTypeCmb);
            importDataForComboBox.LoadField(fieldCmb);
        }

        private void backBtn_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }

        private void deleteBtn_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                PickupPoint deleteMineral = (PickupPoint)dataView.SelectedItem;
                if(MessageBox.Show("Вы действительно хотите удалить выбранный элемент? Данные будут удалены навсегда!", "Вы уверены?", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
                {
                    if (deleteMineral != null)
                    {
                        connectClass.db.PickupPoint.Remove(deleteMineral);
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
                MessageBox.Show(ex.Source, ex.Message, MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void editBtn_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                PickupPoint editMineral = (PickupPoint)dataView.SelectedItem;
                if (editMineral != null)
                {
                    NavigationService.Navigate(new editPage(editMineral));
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

        private void addBtn_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new addPage());
        }

        private void infoBtn_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                PickupPoint infoMineral = (PickupPoint)dataView.SelectedItem;
                if(infoMineral != null)
                {
                    NavigationService.Navigate(new infoPage(infoMineral));
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

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            dataView.ItemsSource = connectClass.db.PickupPoint.ToList();

        }

        private void searchTxb_TextChanged(object sender, TextChangedEventArgs e)
        {
            dataView.ItemsSource = connectClass.db.PickupPoint.Where(item => item.Field.Mineral.MineralName.Contains(searchTxb.Text)).ToList();
        }

        private void selectTypeCmb_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            dataView.ItemsSource = connectClass.db.PickupPoint.Where(item => item.Field.Mineral.MineralType.Type == selectTypeCmb.SelectedItem.ToString()).ToList();
        }

        private void fieldCmb_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            dataView.ItemsSource = connectClass.db.PickupPoint.Where(item => item.Field.FieldName == fieldCmb.SelectedItem.ToString()).ToList();
        }
    }
}
