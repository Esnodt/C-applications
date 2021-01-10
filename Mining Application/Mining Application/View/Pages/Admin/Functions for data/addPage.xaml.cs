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
    /// Логика взаимодействия для addPage.xaml
    /// </summary>
    public partial class addPage : Page
    {
        public addPage()
        {
            InitializeComponent();
            importDataForComboBox.LoadType(typeCmb);
        }

        private void backBtn_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }

        private void addBtn_Click(object sender, RoutedEventArgs e)
        {   
            /* Initialization tables */
            PickupPoint newPickup = new PickupPoint();
            Field newField = new Field();
            Mineral newMineral = new Mineral();
            MineralType newMinType = new MineralType();
            MineralUnit newMinUnit = new MineralUnit();

            newMinUnit.Unit = minUnitTxb.Text;
            newMinType.Type = typeCmb.Text;

            newMineral.MineralName = mineralNameTxb.Text;
            newMineral.MinUnitID = newMinUnit.ID;
            newMineral.AnnualOfYear = annualOfYearTxb.Text;
            newMineral.PriceForUnit = priceForUnitTxb.Text;
            newMineral.TypeID = newMinType.ID;

            newField.FieldName = fieldNameTxb.Text;
            newField.Stocks = stocksTxb.Text;
            newField.DevMethod = devMethodTxb.Text;
            newField.AnnualProd = annualProdTxb.Text;
            newField.CostForUnit = costForUnitTxb.Text;
            newField.MineralID = newMineral.ID;

            newPickup.PointName = pointNameTxb.Text;
            newPickup.Capacity = capacityTxb.Text;
            newPickup.FieldID = newField.ID;

            /* Adding data in tables */
            connectClass.db.MineralType.Add(newMinType);
            connectClass.db.MineralUnit.Add(newMinUnit);
            connectClass.db.Mineral.Add(newMineral);
            connectClass.db.Field.Add(newField);
            connectClass.db.PickupPoint.Add(newPickup);

            connectClass.db.SaveChanges();
            MessageBox.Show("Данные успешно внесены!");

            NavigationService.GoBack();
            
        }
    }
}
