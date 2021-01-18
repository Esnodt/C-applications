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
    /// Логика взаимодействия для addPage.xaml
    /// </summary>
    public partial class addPage : Page
    {
        public addPage()
        {
            InitializeComponent();
        }

        private void backBtn_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }

        private void addBtn_Click(object sender, RoutedEventArgs e)
        {
            Provider newProvider = new Provider();
            Product newProduct = new Product();
            ProductDescription newDecript = new ProductDescription();

            newDecript.Title = descriptionTxb.Text;

            newProduct.ProducrName = productNameTxb.Text;
            newProduct.QuanInStock = Convert.ToInt32(quanlnStockTxb.Text);
            newProduct.Unit = prodUnitTxb.Text;
            newProduct.PriceOfUnit = Convert.ToDecimal(priceOfUnit.Text);
            newProduct.ProdDescriptionID = newDecript.ID;

            newProvider.Surname = surnameTxb.Text;
            newProvider.Name = nameTxb.Text;
            newProvider.Patronymic = patronymicTxb.Text;
            newProvider.Phone = phoneTxb.Text;
            newProvider.Address = addressTxb.Text;
            newProvider.DeliveryTime = Convert.ToDateTime(deliveryTxb.Text);
            newProvider.NumberOfGoods = Convert.ToInt32(numberOfGoodsTxb.Text);
            newProvider.AccountNumber = Convert.ToInt64(accountNumber.Text);

            connectClass.db.ProductDescription.Add(newDecript);
            connectClass.db.Product.Add(newProduct);
            connectClass.db.Provider.Add(newProvider);

            connectClass.db.SaveChanges();
            MessageBox.Show("Данные успешно внесены!");

            NavigationService.GoBack();
        }
    }
}
