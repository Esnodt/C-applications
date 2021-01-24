using Airport_application.Classes;
using Airport_application.VIew.Pages.Admin;
using Airport_application.VIew.Pages.User;
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

namespace Airport_application.VIew.Pages
{
    /// <summary>
    /// Логика взаимодействия для autorizationPage.xaml
    /// </summary>
    public partial class autorizationPage : Page
    {
        public autorizationPage()
        {
            InitializeComponent();
        }

        private void exitBtn_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void comeBtn_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var currentUser = connectClass.db.SignIn.FirstOrDefault(item => item.UserName == userNameTxb.Text && item.Password == passwordPb.Password);
                if(currentUser != null)
                {
                    switch (currentUser.RoleID)
                    {
                        case "A":
                            NavigationService.Navigate(new adminMainPage());
                            break;
                        case "U":
                            NavigationService.Navigate(new userMainPage());
                            break;
                    }
                }
                else
                {
                    MessageBox.Show("Пользователь не найден");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.Source + " выдал исключение", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
