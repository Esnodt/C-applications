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
    /// Логика взаимодействия для editPage.xaml
    /// </summary>
    public partial class editPage : Page
    {
        private Game selectedItem;
        public editPage(Game selectedItem)
        {
            InitializeComponent();
            this.selectedItem = selectedItem;
            
            if (selectedItem.GameImg != null)
            {
                BitmapImage bitmap = new BitmapImage();
                using (MemoryStream stream = new MemoryStream(selectedItem.GameImg))
                {
                    bitmap.BeginInit();
                    bitmap.CacheOption = BitmapCacheOption.OnLoad;
                    bitmap.StreamSource = stream;
                    bitmap.EndInit();
                }
                imgLoad.Source = bitmap;
            }

            gameNameTxb.Text = selectedItem.GameName;
            priceTxb.Text = Convert.ToString(selectedItem.Price);
            yearOfProdTxb.DisplayDate = selectedItem.AddParameters.YearOfProd;
            categoryTxb.ItemsSource = connectClass.db.Category.Select(item => item.Title).ToList();

            cpuTxb.Text = selectedItem.Specifications.CPU;
            videoTxb.Text = selectedItem.Specifications.VideoCard;
            ramTxb.Text = Convert.ToString(selectedItem.Specifications.RAM);
            osTxb.Text = selectedItem.Specifications.OS;

        }

        private void backBtn_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }

        private void edirtBtn_Click(object sender, RoutedEventArgs e)
        {
            Game editGame = connectClass.db.Game.FirstOrDefault(item => item.ID == selectedItem.ID);
            editGame.GameName = gameNameTxb.Text;
            editGame.Price = Convert.ToInt32(priceTxb.Text);
            editGame.AddParameters.YearOfProd = yearOfProdTxb.DisplayDate;
            var edCategory = connectClass.db.Category.FirstOrDefault(item => item.Title == categoryTxb.Text);
            
            editGame.Specifications.CPU = cpuTxb.Text;
            editGame.Specifications.VideoCard = videoTxb.Text;
            editGame.Specifications.RAM = Convert.ToInt32(ramTxb.Text);
            editGame.Specifications.OS = osTxb.Text;

            MemoryStream stream = new MemoryStream();
            JpegBitmapEncoder encorder = new JpegBitmapEncoder();
            encorder.Frames.Add(BitmapFrame.Create((BitmapImage)imgLoad.Source));
            encorder.Save(stream);
            editGame.GameImg = stream.ToArray();

            connectClass.db.SaveChanges();
            MessageBox.Show("Данные успешно изменены!", "Уведомление", MessageBoxButton.OK, MessageBoxImage.Information);

            NavigationService.GoBack();
        }

        private void openImgBtn_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog fileImg = new OpenFileDialog();
            fileImg.Filter = "Image (*.png; *.jpg; *.jpeg;) | *.png; *.jpg; *.jpeg;";
            if (fileImg.ShowDialog() == true)
            {
                BitmapImage imgBitmap = new BitmapImage(new Uri(fileImg.FileName));
                imgLoad.Source = imgBitmap;
            }
        }
    }
}
