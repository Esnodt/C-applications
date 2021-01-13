using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Car_Shop.Classes
{
    public static class importDataOnComboBox
    {
        public static void LoadCoountry(ComboBox comboBox)
        {
            var queryCountry = connectClass.db.CountryManufacture.Select(item => new
            {
                manufactureCountry = item.Country
            });
            var collectionType = from selectedItem in queryCountry select selectedItem.manufactureCountry;
            comboBox.ItemsSource = collectionType.ToList();
        }
    }
}
