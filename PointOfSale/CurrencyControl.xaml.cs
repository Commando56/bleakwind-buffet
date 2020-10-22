/*
 * Author: Cole Kaster
 * Class name: CurrencyControl.xaml.cs
 * Purpose: Provides the control for a certain currency
 */

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
    /// Interaction logic for CurrencyControl.xaml
    /// </summary>
    public partial class CurrencyControl : UserControl
    {

        public static DependencyProperty LabelProperty = DependencyProperty.Register("Label", typeof(string), typeof(CurrencyControl));
        public static DependencyProperty CustomerQuantityProperty = DependencyProperty.Register("CustomerQuantity", typeof(int), typeof(CurrencyControl));
        public static DependencyProperty ChangeQuantityProperty = DependencyProperty.Register("ChangeQuantity", typeof(int), typeof(CurrencyControl));

        /// <summary>
        /// The label for the currency amount
        /// </summary>
        public string Label
        {
            get
            {
                return (string)GetValue(LabelProperty);
            }
            set
            {
                SetValue(LabelProperty, value);
            }
        }

        /// <summary>
        /// The provided customer quantity
        /// </summary>
        public int CustomerQuantity
        {
            get
            {
                return (int)GetValue(CustomerQuantityProperty);
            }
            set
            {
                SetValue(CustomerQuantityProperty, value);
            }
        }

        /// <summary>
        /// The change that should be provided
        /// </summary>
        public int ChangeQuantity
        {
            get
            {
                return (int)GetValue(ChangeQuantityProperty);
            }
            set
            {
                SetValue(ChangeQuantityProperty, value);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public CurrencyControl()
        {
            InitializeComponent();
        }

        private void IncreaseAmount(object sender, RoutedEventArgs e)
        {
            CustomerQuantity += 1;
        }

        private void DecreaseAmount(object sender, RoutedEventArgs e)
        {
            if(CustomerQuantity > 0) CustomerQuantity -= 1;
        }
    }
}
