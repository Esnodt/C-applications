using Games_application.Classes;
using Games_application.View.Pages.Admin;
using Games_application.View.Pages.User;
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

namespace Games_application.View.Pages
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
                var currentUser = connectClass.db.SignIn.FirstOrDefault(item => item.UserName == loginTxb.Text && item.Password == passTxb.Password);

                if(currentUser != null)
                {
                    switch (currentUser.RoleID)
                    {
                        case "A":
                            NavigationService.Navigate(new adminManePage());
                            break;
                        case "U":
                            NavigationService.Navigate(new userManePage());
                            break;
                    }
                }
                else
                {
                    MessageBox.Show("Пользователь не найден!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.Source + " выдал исключение", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void exitBtn_MouseEnter(object sender, MouseEventArgs e)
        {
            exitBtn.Background = Brushes.Gray;
        }

        private void exitBtn_MouseLeave(object sender, MouseEventArgs e)
        {
            exitBtn.Background = Brushes.Black;
        }
    }
}
