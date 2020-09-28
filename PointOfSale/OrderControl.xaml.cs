using BleakwindBuffet.Data;
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
    /// Interaction logic for OrderControl.xaml
    /// </summary>
    public partial class OrderControl : UserControl
    {
        //private List<IOrderItem> orderItems = new List<IOrderItem>();

        public OrderControl()
        {
            InitializeComponent();
        }

        /*public void AddOrderItem(IOrderItem item)
        {
            orderItems.Add(item);
        }

        public void ClearOrder()
        {
            orderItems.Clear();
        }*/
    }
}
