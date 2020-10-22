/*
 * Author: Cole Kaster
 * Class name: OrderControl.xaml.cs
 * Purpose: Represents an order
 */

using BleakwindBuffet.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Runtime.CompilerServices;
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
    /// Interaction logic for OrderControl.xaml
    /// </summary>
    public partial class OrderControl : UserControl
    {
        private MainWindow main;
        private Order order;

        /// <summary>
        /// Instantiates an OrderControl
        /// </summary>
        public OrderControl()
        {
            InitializeComponent();
            order = new Order();
            this.DataContext = order;
            main = Application.Current.Windows[0] as MainWindow;
        }

        private void CancelOrder(object sender, RoutedEventArgs e)
        {
            order = new Order();
            this.DataContext = order;
        }

        private void CompleteOrder(object sender, RoutedEventArgs e)
        {
            main.OpenPaymentOptions(order);
        }

        private void RemoveItem(object sender, RoutedEventArgs e)
        {
            order.Remove((IOrderItem)ordersListBox.SelectedItem);
        }

        private void ModifyItem(object sender, RoutedEventArgs e)
        {
            main.OpenModifyItem((IOrderItem)ordersListBox.SelectedItem, null);
        }

        /// <summary>
        /// Adds an item to the order
        /// </summary>
        /// <param name="item"></param>
        public void AddItem(IOrderItem item)
        {
            order.Add(item);
        }

        /// <summary>
        /// Creates a new order
        /// </summary>
        public void NewOrder()
        {
            order = new Order();
            this.DataContext = order;
        }
    }
}
