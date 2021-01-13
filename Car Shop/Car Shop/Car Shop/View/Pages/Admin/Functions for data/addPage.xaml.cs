using Car_Shop.Classes;
using Car_Shop.DB;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
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

namespace Car_Shop.View.Pages.Admin.Functions_for_data
{
    /// <summary>
    /// Логика взаимодействия для addPage.xaml
    /// </summary>
    public partial class addPage : Page
    {
        public addPage()
        {
            InitializeComponent();
            importDataOnComboBox.LoadCoountry(countryManTxb);
        }

        private void backBtn_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }

        private void addBtn_Click(object sender, RoutedEventArgs e)
        {
            /* Intialization tables */
            Car newCar = new Car();
            CountryManufacture newCountry = new CountryManufacture();
            Specifications newSpecifications = new Specifications();
            DB.Size newSize = new DB.Size();

            newCountry.Country = countryManTxb.Text;

            newSize.Width = widthTxb.Text;
            newSize.Length = lengthTxb.Text;
            newSize.Height = heightTxb.Text;

            newSpecifications.Engine = engineTxb.Text;
            newSpecifications.DriveUnit = driveUnitTxb.Text;
            newSpecifications.Fuel = fuelTxb.Text;
            newSpecifications.SizeID = newSize.ID;

            MemoryStream stream = new MemoryStream();
            JpegBitmapEncoder encorder = new JpegBitmapEncoder();
            encorder.Frames.Add(BitmapFrame.Create((BitmapImage)imgLoad.Source));
            encorder.Save(stream);
            newCar.CarImg = stream.ToArray();

            newCar.CarName = carNameTxb.Text;
            newCar.Model = carModelTxb.Text;
            newCar.Class = carClassTxb.Text;
            newCar.CarBody = carBodyTxb.Text;
            newCar.YearOfProd = yearOfProdTxb.DisplayDate;
            newCar.Price = Convert.ToDecimal(priceTxb.Text);
            newCar.CountryID = newCountry.ID;
            newCar.SpecID = newSpecifications.ID;

            connectClass.db.CountryManufacture.Add(newCountry);
            connectClass.db.Size.Add(newSize);
            connectClass.db.Specifications.Add(newSpecifications);
            connectClass.db.Car.Add(newCar);

            connectClass.db.SaveChanges();
            MessageBox.Show("Данные успешно добавлены");
            NavigationService.GoBack();
        }

        private void imageBtn_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                OpenFileDialog imgFile = new OpenFileDialog();
                imgFile.Filter = "Image (*.jpg; *.png;) | *.jpg; *.png;";
                if(imgFile.ShowDialog() == true)
                {
                    BitmapImage imgBitmap = new BitmapImage(new Uri(imgFile.FileName));
                    imgLoad.Source = imgBitmap;
                }    
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
