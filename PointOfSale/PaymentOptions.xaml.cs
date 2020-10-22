/*
 * Author: Cole Kaster
 * Class name: PaymentOptions.xaml.cs
 * Purpose: Allows user to select a payment option
 */

using RoundRegister;
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
using BleakwindBuffet.Data;
using System.Runtime.CompilerServices;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for PaymentOptions.xaml
    /// </summary>
    public partial class PaymentOptions : UserControl
    {
        private Order order;
        private MainWindow main;

        /// <summary>
        /// Initializes the payment options control
        /// </summary>
        /// <param name="order">The current order</param>
        /// <param name="main">The main window</param>
        public PaymentOptions(Order order, MainWindow main)
        {
            InitializeComponent();
            this.order = order;
            this.main = main;
        }

        private void SelectCreditDebit(object sender, RoutedEventArgs e)
        {
            CardTransactionResult result = CardReader.RunCard(order.Total);
            switch(result)
            {
                case CardTransactionResult.Approved:
                    CompleteOrder();
                    main.NewOrder();
                    main.OpenMainMenu();
                    break;
                case CardTransactionResult.Declined:
                    break;
                case CardTransactionResult.ReadError:
                    break;
                case CardTransactionResult.InsufficientFunds:
                    break;
                case CardTransactionResult.IncorrectPin:
                    break;
            }
        }

        private void SelectCash(object sender, RoutedEventArgs e)
        {
            main.OpenRegister(order);
        }

        private void GoBack(object sender, RoutedEventArgs e)
        {
            main.OpenMainMenu();
        }

        private void CompleteOrder()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Order Number: " + order.Number + " | ");
            sb.Append(DateTime.Today.Month + "/" + DateTime.Today.Day + "/" + DateTime.Today.Year + " | ");
            IEnumerator<IOrderItem> en = order.GetEnumerator();
            while (en.Current != null)
            {
                List<string> instructions = en.Current.SpecialInstructions;
                sb.Append(en.Current.ToString() + " " + en.Current.Price + " ");
                foreach (string s in instructions)
                {
                    sb.Append(s + " ");
                }
                sb.Append("| ");
            }
            sb.Append(order.Subtotal + " | ");
            sb.Append(order.Tax + " | ");
            sb.Append(order.Total + " | ");
            sb.Append("Paid by card | ");
            sb.Append("No change owed |");
            int length = Convert.ToInt32(Math.Ceiling(Convert.ToDouble(sb.Length) / 40.0));
            string reciept = sb.ToString();
            for (int i = 0; i < length - 1; i++)
            {
                int start = i == 0 ? 0 : (i * 40) - 1;
                RecieptPrinter.PrintLine(reciept.Substring(start, 40));
            }
            RecieptPrinter.PrintLine(reciept.Substring(((length - 1) * 40) - 1));
            RecieptPrinter.CutTape();
        }
    }
}
