﻿using System;
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
    /// Interaction logic for SelectionMenu.xaml
    /// </summary>
    public partial class SelectionMenu : UserControl
    {
        private MainWindow main;

        public SelectionMenu(MainWindow main)
        {
            InitializeComponent();
            this.main = main;
        }

        private void OpenEntree(object sender, RoutedEventArgs e)
        {
            main.OpenEntrees();            
        }

        private void OpenSide(object sender, RoutedEventArgs e)
        {
            main.OpenSides();
        }

        private void OpenDrink(object sender, RoutedEventArgs e)
        {
            main.OpenDrinks();
        }

    }
}