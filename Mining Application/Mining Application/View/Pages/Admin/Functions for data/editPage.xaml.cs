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
    /// Логика взаимодействия для editPage.xaml
    /// </summary>
    public partial class editPage : Page
    {
        private PickupPoint selectedItem;
        public editPage()
        {
            InitializeComponent();
        }
        public editPage(PickupPoint selectedItem)
        {
            InitializeComponent();
            this.selectedItem = selectedItem;
            mineralNameTxb.Text = selectedItem.Field.Mineral.MineralName;
            minUnitTxb.Text = selectedItem.Field.Mineral.MineralUnit.Unit;
            annualOfYearTxb.Text = selectedItem.Field.Mineral.AnnualOfYear;
            priceForUnitTxb.Text = selectedItem.Field.Mineral.PriceForUnit;
            SecTypeCmb.Text = selectedItem.Field.Mineral.MineralType.Type;
            fieldNameTxb.Text = selectedItem.Field.FieldName;
            stocksTxb.Text = selectedItem.Field.Stocks;
            devMethodTxb.Text = selectedItem.Field.DevMethod;
            annualProdTxb.Text = selectedItem.Field.AnnualProd;
            costForUnitTxb.Text = selectedItem.Field.CostForUnit;
            pointNameTxb.Text = selectedItem.PointName;
            capacityTxb.Text = selectedItem.Capacity;
        }

        private void editBtn_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                PickupPoint saveMineral = connectClass.db.PickupPoint.FirstOrDefault(item => item.Field.Mineral.ID == selectedItem.Field.Mineral.ID);
                saveMineral.Field.Mineral.MineralName = mineralNameTxb.Text;
                saveMineral.Field.Mineral.MineralUnit.Unit = minUnitTxb.Text;
                saveMineral.Field.Mineral.AnnualOfYear = annualOfYearTxb.Text;
                saveMineral.Field.Mineral.PriceForUnit = priceForUnitTxb.Text;
                saveMineral.Field.Mineral.MineralType.Type = SecTypeCmb.Text;
                saveMineral.Field.FieldName = fieldNameTxb.Text;
                saveMineral.Field.Stocks = stocksTxb.Text;
                saveMineral.Field.DevMethod = devMethodTxb.Text;
                saveMineral.Field.AnnualProd = annualProdTxb.Text;
                saveMineral.Field.CostForUnit = costForUnitTxb.Text;
                saveMineral.PointName = pointNameTxb.Text;
                saveMineral.Capacity = capacityTxb.Text;

                connectClass.db.SaveChanges();
                MessageBox.Show("Данные успешно изменены!");
                NavigationService.GoBack();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void backBtn_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            importDataForComboBox.LoadType(SecTypeCmb);
        }
    }
}
