using Games_application.Classes;
using Games_application.DB;
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

namespace Games_application.View.Pages.Admin.Functions_for_a_data
{
    /// <summary>
    /// Логика взаимодействия для addPage.xaml
    /// </summary>
    public partial class addPage : Page
    {
        public addPage()
        {
            InitializeComponent();
            categoryTxb.ItemsSource = connectClass.db.Category.Select(item => item.Title).ToList();
        }

        private void backBtn_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }

        private void addBtn_Click(object sender, RoutedEventArgs e)
        {
            Game newGame = new Game();
            Specifications newSpec = new Specifications();
            AddParameters newAddParam = new AddParameters();

            var categoryName = connectClass.db.Category.FirstOrDefault(item => item.Title == categoryTxb.Text);
            newAddParam.CategoryID = categoryName.ID;
            newAddParam.YearOfProd = yearOfProdTxb.DisplayDate;

            newSpec.CPU = cpuTxb.Text;
            newSpec.VideoCard = videoTxb.Text;
            newSpec.RAM = Convert.ToInt32(ramTxb.Text);
            newSpec.OS = osTxb.Text;

            newGame.GameName = gameNameTxb.Text;
            newGame.Price = Convert.ToInt32(priceTxb.Text);
            newGame.AddParamID = newAddParam.ID;
            newGame.SpecificID = newSpec.ID;

            MemoryStream stream = new MemoryStream();
            JpegBitmapEncoder encorder = new JpegBitmapEncoder();
            encorder.Frames.Add(BitmapFrame.Create((BitmapImage)imgLoad.Source));
            encorder.Save(stream);
            newGame.GameImg = stream.ToArray();

            connectClass.db.AddParameters.Add(newAddParam);
            connectClass.db.Specifications.Add(newSpec);
            connectClass.db.Game.Add(newGame);

            connectClass.db.SaveChanges();
            MessageBox.Show("Данные успешно добавлены!");

            NavigationService.GoBack();
        }

        private void openImgBtn_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                OpenFileDialog imgFile = new OpenFileDialog();
                imgFile.Filter = "Image (*.png; *.jpg; *.jpeg;) | *.png; *.jpg; *.jpeg;";
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
