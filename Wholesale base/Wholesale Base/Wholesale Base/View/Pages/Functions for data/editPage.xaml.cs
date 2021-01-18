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

namespace Wholesale_Base.View.Pages.Functions_for_data
{
    /// <summary>
    /// Логика взаимодействия для editPage.xaml
    /// </summary>
    public partial class editPage : Page
    {
        private Provider selectedItem; 
        public editPage(Provider selectedItem)
        {
            InitializeComponent();
            this.selectedItem = selectedItem;

            productNameTxb.Text = selectedItem.Product.ProducrName;
            quanlnStockTxb.Text = Convert.ToString(selectedItem.Product.QuanInStock);
            prodUnitTxb.Text = selectedItem.Product.Unit;
            priceOfUnit.Text = Convert.ToString(selectedItem.Product.PriceOfUnit);
            descriptionTxb.Text = selectedItem.Product.ProductDescription.Title;
            surnameTxb.Text = selectedItem.Surname;
            nameTxb.Text = selectedItem.Name;
            patronymicTxb.Text = selectedItem.Patronymic;
            phoneTxb.Text = selectedItem.Phone;
            addressTxb.Text = selectedItem.Address;
            deliveryTxb.Text = Convert.ToString(selectedItem.DeliveryTime);
            numberOfGoodsTxb.Text = Convert.ToString(selectedItem.NumberOfGoods);
            accountNumber.Text = Convert.ToString(selectedItem.AccountNumber);
        }

        private void backBtn_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }

        private void editBtn_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Provider newProvider = new Provider();

                newProvider.Product.ProducrName = productNameTxb.Text;
                newProvider.Product.QuanInStock = Convert.ToInt32(quanlnStockTxb.Text);
                newProvider.Product.Unit = prodUnitTxb.Text;
                newProvider.Product.PriceOfUnit = Convert.ToInt32(priceOfUnit.Text);
                newProvider.Product.ProductDescription.Title = descriptionTxb.Text;
                newProvider.Surname = surnameTxb.Text;
                newProvider.Name = nameTxb.Text;
                newProvider.Patronymic = patronymicTxb.Text;
                newProvider.Phone = phoneTxb.Text;
                newProvider.Address = addressTxb.Text;
                newProvider.DeliveryTime = Convert.ToDateTime(deliveryTxb.Text);
                newProvider.NumberOfGoods = Convert.ToInt32(numberOfGoodsTxb.Text);
                newProvider.AccountNumber = Convert.ToInt64(accountNumber.Text);

                connectClass.db.SaveChanges();
                MessageBox.Show("Данные успешно изменены!");

                NavigationService.GoBack();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void editBtn_Click_1(object sender, RoutedEventArgs e)
        {

        }
    }
}
