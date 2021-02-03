using Microsoft.Win32;
using People_application.Classes;
using People_application.DB;
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

namespace People_application.View.Pages.Admin.Functions_for_a_data
{
    /// <summary>
    /// Логика взаимодействия для addPage.xaml
    /// </summary>
    public partial class addPage : Page
    {
        public addPage()
        {
            InitializeComponent();
            bankCmb.ItemsSource = connectClass.db.BankNames.Select(item => item.Name).ToList();
        }

        private void backBtn_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }

        private void addBtn_Click(object sender, RoutedEventArgs e)
        {
            Human newHuman = new Human();
            Passport newPassport = new Passport();
            Bank newBank = new Bank();
            
            var bankName = connectClass.db.BankNames.FirstOrDefault(item => item.Name == bankCmb.Text);
            newBank.BankNameID = bankName.ID;
                        
            newBank.Balance = balanceTxb.Text;

            newPassport.Series = Convert.ToInt32(passportSeriesTxb.Text);
            newPassport.Number = Convert.ToInt32(passportnumberTxb.Text);
            newPassport.BankID = newBank.ID;

            newHuman.Surname = surnameTxb.Text;
            newHuman.Name = nameTxb.Text;
            newHuman.Patronymic = patronymicTxb.Text;
            newHuman.Age = Convert.ToInt32(ageTxb.Text);

            MemoryStream stream = new MemoryStream();
            JpegBitmapEncoder encoder = new JpegBitmapEncoder();
            encoder.Frames.Add(BitmapFrame.Create((BitmapImage)addImg.Source));
            encoder.Save(stream);
            newHuman.HumanImg = stream.ToArray();

            connectClass.db.Bank.Add(newBank);
            connectClass.db.Passport.Add(newPassport);
            connectClass.db.Human.Add(newHuman);

            connectClass.db.SaveChanges();
            MessageBox.Show("Данные успешно добавлены!");

            NavigationService.GoBack();
        }

        private void openBtn_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();
            file.Filter = "Image (*.png; *.jpg; *.jpeg;)| *.png; *.jpg; *.jpeg;";
            if(file.ShowDialog() == true)
            {
                BitmapImage image = new BitmapImage(new Uri(file.FileName));
                addImg.Source = image;
            }
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            
        }

        private void passportnumberTxb_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            e.Handled = "0123456789 ,".IndexOf(e.Text) < 0;
        }
    }
}
