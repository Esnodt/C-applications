﻿using Car_Shop.Classes;
using Car_Shop.View.Pages.Admin;
using Car_Shop.View.Pages.User;
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

namespace Car_Shop.View.Pages
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
                var currentUser = connectClass.db.SignIn.FirstOrDefault(item => item.UserName == loginTxb.Text && item.Password == passwordTxb.Password);
                if(currentUser != null)
                {
                    switch (currentUser.RoleID)
                    {
                        case "A":
                            NavigationService.Navigate(new adminDataViewPage());
                            break;
                        case "U":
                            NavigationService.Navigate(new userDataViewPage());
                            break;
                    }
                }
                else
                {
                    MessageBox.Show("Введите данные!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.Source + " выдал исключение", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
