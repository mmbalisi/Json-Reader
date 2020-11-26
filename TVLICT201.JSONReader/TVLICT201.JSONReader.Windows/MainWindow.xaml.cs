﻿using System;
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

namespace TVLICT201.JSONReader.Windows
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnEmployee_Click(object sender, RoutedEventArgs e)
        {
            Employee.EmployeeWindow employeeWindow = new Employee.EmployeeWindow();
            employeeWindow.Show();
        }

        private void btnShip_Click(object sender, RoutedEventArgs e)
        {
            Ship.ShipWindow shipWindow = new Ship.ShipWindow();
            shipWindow.Show();
        }
    }
}
