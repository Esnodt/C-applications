using Airport_application.Classes;
using Airport_application.DB;
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

namespace Airport_application.VIew.Pages.Admin.Functions_for_a_data
{
    /// <summary>
    /// Логика взаимодействия для editPage.xaml
    /// </summary>
    public partial class editPage : Page
    {
        private Route selectedItem;
        public editPage(Route selectedItem)
        {
            InitializeComponent();
            this.selectedItem = selectedItem;

            routeNumberTxb.Text = selectedItem.RouteNumber;
            distanceTxb.Text = selectedItem.Distance;
            deepPointTxb.Text = selectedItem.DepPoint;
            arrPointTxb.Text = selectedItem.ArrPoint;

            planeNumberTxb.Text = selectedItem.Plane.PlaneNumber;
            typeTxb.Text = Convert.ToString(selectedItem.Plane.Type);
            numberOfPlaceTxb.Text = Convert.ToString(selectedItem.Plane.NumberOfPlace);
            planeSpeedTxb.Text = Convert.ToString(selectedItem.Plane.PlaneSpeed);

            depDateTimeTxb.DisplayDate = selectedItem.PlaneParameters.DepDateTime;
            arrDateTimeTxb.DisplayDate = selectedItem.PlaneParameters.ArrDateTime;
            ticketsTxb.Text = Convert.ToString(selectedItem.PlaneParameters.Tickets);

            passNumberTxb.Text = Convert.ToString(selectedItem.Plane.Passengers.PassNumber);
        }

        private void editBtn_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Route editSave = connectClass.db.Route.FirstOrDefault(item => item.ID == selectedItem.ID);
                editSave.RouteNumber = routeNumberTxb.Text;
                editSave.Distance = distanceTxb.Text;
                editSave.DepPoint = deepPointTxb.Text;
                editSave.ArrPoint = arrPointTxb.Text;
                editSave.Plane.PlaneNumber = planeNumberTxb.Text;
                editSave.Plane.Type = typeTxb.Text;
                editSave.Plane.NumberOfPlace = Convert.ToInt32(numberOfPlaceTxb.Text);
                editSave.Plane.PlaneSpeed = Convert.ToInt32(planeSpeedTxb.Text);
                editSave.PlaneParameters.DepDateTime = depDateTimeTxb.DisplayDate;
                editSave.PlaneParameters.ArrDateTime = arrDateTimeTxb.DisplayDate;
                editSave.Plane.Passengers.PassNumber = Convert.ToInt32(passNumberTxb.Text);

                connectClass.db.SaveChanges();
                MessageBox.Show("Данные успешно изменены!");
                NavigationService.GoBack();
            }
            catch (Exception ex)
            {
               MessageBox.Show(ex.Message, ex.Source, MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void backBtn_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }
    }
}
