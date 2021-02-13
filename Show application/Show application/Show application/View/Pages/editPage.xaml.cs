using Microsoft.Win32;
using Show_application.Classes;
using Show_application.DB;
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

namespace Show_application.View.Pages
{
    /// <summary>
    /// Логика взаимодействия для editPage.xaml
    /// </summary>
    public partial class editPage : Page
    {
        private Room selectedItem;
        public editPage(Room selectedItem)
        {
            InitializeComponent();
            this.selectedItem = selectedItem;

            if (selectedItem.ImageRoom != null)
            {
                BitmapImage bitmap = new BitmapImage();
                using (MemoryStream stream = new MemoryStream(selectedItem.ImageRoom))
                {
                    bitmap.BeginInit();
                    bitmap.CacheOption = BitmapCacheOption.OnLoad;
                    bitmap.StreamSource = stream;
                    bitmap.EndInit();
                }
                imgLoad.Source = bitmap;
            }

            roomNameTxb.Text = selectedItem.NameOfRoom;
            pkNumberTxb.Text = Convert.ToString(selectedItem.NumberOfPK);
            motherBoardTxb.Text = selectedItem.Specifications.MotherBoard;
            CPUTxb.Text = selectedItem.Specifications.CPU;
            videoCardTxb.Text = selectedItem.Specifications.VideoCard;
            RAMTxb.Text = Convert.ToString(selectedItem.Specifications.RAM);
            powerSupplyTxb.Text = Convert.ToString(selectedItem.Specifications.PowerSupply);
        }

        private void backBtn_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }

        private void editBtn_Click(object sender, RoutedEventArgs e)
        {
            Room editRoom = connectClass.db.Room.FirstOrDefault(item => item.ID == selectedItem.ID);
            editRoom.NameOfRoom = roomNameTxb.Text;
            editRoom.NumberOfPK = Convert.ToInt32(pkNumberTxb.Text);
            editRoom.Specifications.MotherBoard = motherBoardTxb.Text;
            editRoom.Specifications.CPU = CPUTxb.Text;
            editRoom.Specifications.VideoCard = videoCardTxb.Text;
            editRoom.Specifications.RAM = Convert.ToInt32(RAMTxb.Text);
            editRoom.Specifications.PowerSupply = Convert.ToInt32(powerSupplyTxb.Text);

            MemoryStream stream = new MemoryStream();
            JpegBitmapEncoder encoder = new JpegBitmapEncoder();
            encoder.Frames.Add(BitmapFrame.Create((BitmapImage)imgLoad.Source));
            encoder.Save(stream);
            editRoom.ImageRoom = stream.ToArray();

            connectClass.db.SaveChanges();
            MessageBox.Show("Данные успешно изменены!");

            NavigationService.GoBack();
        }

        private void imgBtn_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog imgFile = new OpenFileDialog();
            imgFile.Filter = "Image (*.png; *.jpg; *.jpeg;) | *.png; *.jpg; *.jpeg;";
            if(imgFile.ShowDialog() == true)
            {
                BitmapImage imgBitmap = new BitmapImage(new Uri(imgFile.FileName));
                imgLoad.Source = imgBitmap;
            }
        }
    }
}
