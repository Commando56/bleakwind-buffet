/*
 * Author: Cole Kaster
 * Class name: SideSelection.xaml.cs
 * Purpose: Allows the user to select a side
 */

using BleakwindBuffet.Data.Sides;
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
    /// Interaction logic for SideSelection.xaml
    /// </summary>
    public partial class SideSelection : UserControl
    {
        private MainWindow main;

        /// <summary>
        /// Instantiates a SideSelection
        /// </summary>
        /// <param name="main">The main window</param>
        public SideSelection(MainWindow main)
        {
            InitializeComponent();
            this.main = main;
        }

        private void GoBack(object sender, RoutedEventArgs e)
        {
            main.OpenMainMenu();
        }

        private void OpenVokunSalad(object sender, RoutedEventArgs e)
        {
            main.CustomizeItem(new VokunSalad(), null);
        }

        private void OpenFriedMiraak(object sender, RoutedEventArgs e)
        {
            main.CustomizeItem(new FriedMiraak(), null);
        }

        private void OpenMadOtarGrits(object sender, RoutedEventArgs e)
        {
            main.CustomizeItem(new MadOtarGrits(), null);
        }

        private void OpenDragonbornWaffleFries(object sender, RoutedEventArgs e)
        {
            main.CustomizeItem(new DragonbornWaffleFries(), null);
        }
    }
}
