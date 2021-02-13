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
    /// Логика взаимодействия для addPage.xaml
    /// </summary>
    public partial class addPage : Page
    {
        public addPage()
        {
            InitializeComponent();
        }

        //Кнопка возвращения к предыдущей странице
        private void backBtn_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }

        //Кнопка открытия изображения
        private void imgBtn_Click(object sender, RoutedEventArgs e)
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

        //Кнопка добавления данных
        private void addBtn_Click(object sender, RoutedEventArgs e)
        {
            //Инициализация сущностей
            Room newRoom = new Room();
            Specifications newSpec = new Specifications();

            //Присваивание атрибутов сущностей к TextBox-элементам программы
            newRoom.NameOfRoom = roomNameTxb.Text;
            newRoom.NumberOfPK = Convert.ToInt32(pkNumberTxb.Text);

            newSpec.MotherBoard = motherBoardTxb.Text;
            newSpec.CPU = CPUTxb.Text;
            newSpec.VideoCard = videoCardTxb.Text;
            newSpec.RAM = Convert.ToInt32(RAMTxb.Text);
            newSpec.PowerSupply = Convert.ToInt32(powerSupplyTxb.Text);

            //Присваивание вторичного ключа
            newRoom.SpecificationsID = newSpec.ID;

            //Добавление изображения
            MemoryStream stream = new MemoryStream();
            JpegBitmapEncoder encoder = new JpegBitmapEncoder();
            encoder.Frames.Add(BitmapFrame.Create((BitmapImage)imgLoad.Source));
            encoder.Save(stream);
            newRoom.ImageRoom = stream.ToArray();
            
            //Добавление данных путем 'зависимая сущность -> главная'
            connectClass.db.Specifications.Add(newSpec);
            connectClass.db.Room.Add(newRoom);

            //Сохранение данных 
            connectClass.db.SaveChanges();

            MessageBox.Show("Данные успешно добавлены!");
            NavigationService.GoBack();
        }
    }
}
