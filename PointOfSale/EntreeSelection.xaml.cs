﻿using BleakwindBuffet.Data.Entrees;
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
    /// Interaction logic for EntreeSelection.xaml
    /// </summary>
    public partial class EntreeSelection : UserControl
    {
        private MainWindow main;

        public EntreeSelection(MainWindow main)
        {
            InitializeComponent();
            this.main = main;
        }

        private void GoBack(object sender, RoutedEventArgs e)
        {
            main.OpenMainMenu();
        }

        private void OpenBriarheartBurger(object sender, RoutedEventArgs e)
        {
            main.CustomizeItem(new BriarheartBurger());
        }

        private void OpenDoubleDraugr(object sender, RoutedEventArgs e)
        {
            main.CustomizeItem(new DoubleDraugr());
        }

        private void OpenThalmorTriple(object sender, RoutedEventArgs e)
        {
            main.CustomizeItem(new ThalmorTriple());
        }

        private void OpenSmokehouseSkeleton(object sender, RoutedEventArgs e)
        {
            main.CustomizeItem(new SmokehouseSkeleton());
        }

        private void OpenGardenOrcOmelette(object sender, RoutedEventArgs e)
        {
            main.CustomizeItem(new GardenOrcOmelette());
        }

        private void OpenPhillyPoacher(object sender, RoutedEventArgs e)
        {
            main.CustomizeItem(new PhillyPoacher());
        }

        private void OpenThugsTBone(object sender, RoutedEventArgs e)
        {
            //Add To Order
        }
    }
}