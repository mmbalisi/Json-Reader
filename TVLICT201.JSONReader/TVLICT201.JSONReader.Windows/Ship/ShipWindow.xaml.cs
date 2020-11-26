using Newtonsoft.Json;
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
using System.Windows.Shapes;

namespace TVLICT201.JSONReader.Windows.Ship
{
    /// <summary>
    /// Interaction logic for ShipWindow.xaml
    /// </summary>
    public partial class ShipWindow : Window
    {
        public ShipWindow()
        {
            InitializeComponent();

            Ship ship = new Ship();

            using (StreamReader r = new StreamReader("data\\ship.json"))
            {
                string json = r.ReadToEnd();
                ship = JsonConvert.DeserializeObject<Ship>(json);
            }
           
         
            lblShipId.Content = "Id : " + ship.Id;
            lblShipRegistry.Content = "Registry : " + ship.Registry;
            lblShipName.Content = "Name : " + ship.Name;
            lblShipClass.Content = "Class : " + ship.Class;
            lblShipService.Content = "Service : " + ship.Service;
        }
    }
}
