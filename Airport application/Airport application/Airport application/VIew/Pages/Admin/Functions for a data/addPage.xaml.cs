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
    /// Логика взаимодействия для addPage.xaml
    /// </summary>
    public partial class addPage : Page
    {
        public addPage()
        {
            InitializeComponent();
        }

        private void addBtn_Click(object sender, RoutedEventArgs e)
        {
            Route newRoute = new Route();
            PlaneParameters newParameters = new PlaneParameters();
            Plane newPlane = new Plane();
            Passengers newPassengers = new Passengers();

            newParameters.DepDateTime = depDateTimeTxb.DisplayDate;
            newParameters.ArrDateTime = arrDateTimeTxb.DisplayDate;
            newParameters.Tickets = Convert.ToInt32(ticketsTxb.Text);

            newPassengers.PassNumber = Convert.ToInt32(passNumberTxb.Text);

            newPlane.PlaneNumber = planeNumberTxb.Text;
            newPlane.Type = typeTxb.Text;
            newPlane.NumberOfPlace = Convert.ToInt32(numberOfPlaceTxb.Text);
            newPlane.PlaneSpeed = Convert.ToInt32(planeSpeedTxb.Text);
            newPlane.PassengersID = newPassengers.ID;

            newRoute.RouteNumber = routeNumberTxb.Text;
            newRoute.Distance = distanceTxb.Text;
            newRoute.DepPoint = deepPointTxb.Text;
            newRoute.ArrPoint = arrPointTxb.Text;
            newRoute.PlaneID = newPlane.ID;
            newRoute.ParamID = newParameters.ID;

            connectClass.db.Passengers.Add(newPassengers);
            connectClass.db.PlaneParameters.Add(newParameters);
            connectClass.db.Plane.Add(newPlane);
            connectClass.db.Route.Add(newRoute);

            connectClass.db.SaveChanges();

            MessageBox.Show("Данные успешно добавлены!");
            NavigationService.GoBack();               
        }

        private void backBtn_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }
    }
}
