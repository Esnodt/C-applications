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
    /// Логика взаимодействия для editPage.xaml
    /// </summary>
    public partial class editPage : Page
    {
        private Human selectedItem;
        public editPage(Human selectedItem)
        {
            InitializeComponent();
            this.selectedItem = selectedItem;

            if (selectedItem.HumanImg != null)
            {
                BitmapImage bitmap = new BitmapImage();
                using (MemoryStream stream = new MemoryStream(selectedItem.HumanImg))
                {
                    bitmap.BeginInit();
                    bitmap.CacheOption = BitmapCacheOption.OnLoad;
                    bitmap.StreamSource = stream;
                    bitmap.EndInit();
                }
                addImg.Source = bitmap;
            }

            bankCmb.ItemsSource = connectClass.db.BankNames.Select(item => item.Name).ToList();

            surnameTxb.Text = selectedItem.Surname;
            nameTxb.Text = selectedItem.Name;
            patronymicTxb.Text = selectedItem.Patronymic;
            ageTxb.Text = Convert.ToString(selectedItem.Age);
            passportSeriesTxb.Text = Convert.ToString(selectedItem.Passport.Series);
            passportnumberTxb.Text = Convert.ToString(selectedItem.Passport.Number);
            balanceTxb.Text = selectedItem.Passport.Bank.Balance;
            bankCmb.Text = selectedItem.Passport.Bank.BankNames.Name;

            if(selectedItem.HumanImg != null)
            {
                BitmapImage bitmap = new BitmapImage();
                using (MemoryStream stream = new MemoryStream(selectedItem.HumanImg))
                {
                    bitmap.BeginInit();
                    bitmap.CacheOption = BitmapCacheOption.OnLoad;
                    bitmap.StreamSource = stream;
                    bitmap.EndInit();
                }
                addImg.Source = bitmap;
            }
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

        private void backBtn_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }

        private void addBtn_Click(object sender, RoutedEventArgs e)
        {
            Human editHuman = connectClass.db.Human.FirstOrDefault(item => item.ID == selectedItem.ID);
            editHuman.Surname = surnameTxb.Text;
            editHuman.Name = nameTxb.Text;
            editHuman.Patronymic = patronymicTxb.Text;
            editHuman.Age = Convert.ToInt32(ageTxb.Text);

            var currentNameBank = connectClass.db.BankNames.FirstOrDefault(item => item.Name == bankCmb.Text);
            editHuman.Passport.Bank.BankNameID = currentNameBank.ID;

            editHuman.Passport.Bank.Balance = balanceTxb.Text;

            editHuman.Passport.Series = Convert.ToInt32(passportSeriesTxb.Text);
            editHuman.Passport.Number = Convert.ToInt32(passportnumberTxb.Text);



            connectClass.db.SaveChanges();
            MessageBox.Show("Данные успешно изменены!");

            NavigationService.GoBack();
        }
    }
}
