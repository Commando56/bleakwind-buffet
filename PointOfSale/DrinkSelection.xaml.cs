/*
 * Author: Cole Kaster
 * Class name: DrinkSelection.xaml.cs
 * Purpose: Allows the user to select a drink
 */

using BleakwindBuffet.Data.Drinks;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for DrinkSelection.xaml
    /// </summary>
    public partial class DrinkSelection : UserControl
    {
        private MainWindow main;

        /// <summary>
        /// Instantiates a DrinkSelection
        /// </summary>
        /// <param name="main">The main window</param>
        public DrinkSelection(MainWindow main)
        {
            InitializeComponent();
            this.main = main;
        }

        private void GoBack(object sender, RoutedEventArgs e)
        {
            main.OpenMainMenu();
        }

        private void OpenSailorSoda(object sender, RoutedEventArgs e)
        {
            main.CustomizeItem(new SailorSoda());
        }

        private void OpenMarkarthMilk(object sender, RoutedEventArgs e)
        {
            main.CustomizeItem(new MarkarthMilk());
        }

        private void OpenAretinoAppleJuice(object sender, RoutedEventArgs e)
        {
            main.CustomizeItem(new AretinoAppleJuice());
        }

        private void OpenCandlehearthCoffee(object sender, RoutedEventArgs e)
        {
            main.CustomizeItem(new CandlehearthCoffee());
        }

        private void OpenWarriorWater(object sender, RoutedEventArgs e)
        {
            main.CustomizeItem(new WarriorWater());
        }
    }
}
