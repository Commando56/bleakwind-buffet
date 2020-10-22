/*
 * Author: Cole Kaster
 * Class name: RegisterUtility.cs
 * Purpose: Provides the logic for the cash register
 */

using RoundRegister;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using BleakwindBuffet.Data;

namespace PointOfSale
{
    /// <summary>
    /// The view model for the register display
    /// </summary>
    public class RegisterUtility : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private Order order;

        private int hundreds = CashDrawer.Hundreds;
        /// <summary>
        /// Gets the hundreds
        /// </summary>
        public int Hundreds
        {
            get => hundreds;
        }

        private int fifties = CashDrawer.Fifties;
        /// <summary>
        /// Gets the fifties
        /// </summary>
        public int Fifties
        {
            get => fifties;
        }

        private int twenties = CashDrawer.Twenties;
        /// <summary>
        /// Gets the twenties
        /// </summary>
        public int Twenties
        {
            get => twenties;
        }

        private int tens = CashDrawer.Tens;
        /// <summary>
        /// Gets the tens
        /// </summary>
        public int Tens
        {
            get => tens;
        }

        private int fives = CashDrawer.Fives;
        /// <summary>
        /// Gets the fives
        /// </summary>
        public int Fives
        {
            get => fives;
        }

        private int twos = CashDrawer.Twos;
        /// <summary>
        /// Gets the twos
        /// </summary>
        public int Twos
        {
            get => twos;
        }

        private int ones = CashDrawer.Ones;
        /// <summary>
        /// Gets the ones
        /// </summary>
        public int Ones
        {
            get => ones;
        }

        private int dollars = CashDrawer.Dollars;
        /// <summary>
        /// Gets the dollars
        /// </summary>
        public int Dollars
        {
            get => dollars;
        }

        private int halfDollars = CashDrawer.HalfDollars;
        /// <summary>
        /// Gets the half dollars
        /// </summary>
        public int HalfDollars
        {
            get => halfDollars;
        }

        private int quarters = CashDrawer.Quarters;
        /// <summary>
        /// Gets the quarters
        /// </summary>
        public int Quarters
        {
            get => quarters;
        }

        private int dimes = CashDrawer.Dimes;
        /// <summary>
        /// Gets the dimes
        /// </summary>
        public int Dimes
        {
            get => dimes;
        }

        private int nickels = CashDrawer.Nickels;
        /// <summary>
        /// Gets the nickels
        /// </summary>
        public int Nickels
        {
            get => nickels;
        }

        private int pennies = CashDrawer.Pennies;
        /// <summary>
        /// Gets the pennies
        /// </summary>
        public int Pennies
        {
            get => pennies;
        }

        private int customerHundreds = 0;
        /// <summary>
        /// Gets and sets the customers hundreds
        /// </summary>
        public int CustomerHundreds
        {
            get => customerHundreds;
            set
            {
                customerHundreds = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("CustomerHundreds"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("AmountDue"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ChangeOwed"));
                UpdateChangeProperties();
            }
        }

        private int customerFifties = 0;
        /// <summary>
        /// Gets and sets the customers fifties
        /// </summary>
        public int CustomerFifties
        {
            get => customerFifties;
            set
            {
                customerFifties = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("CustomerFifties"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("AmountDue"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ChangeOwed"));
                UpdateChangeProperties();
            }
        }

        private int customerTwenties = 0;
        /// <summary>
        /// Gets and sets the customers twenties
        /// </summary>
        public int CustomerTwenties
        {
            get => customerTwenties;
            set
            {
                customerTwenties = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("CustomerTwenties"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("AmountDue"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ChangeOwed"));
                UpdateChangeProperties();
            }
        }

        private int customerTens = 0;
        /// <summary>
        /// Gets and sets the customers tens
        /// </summary>
        public int CustomerTens
        {
            get => customerTens;
            set
            {
                customerTens = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("CustomerTens"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("AmountDue"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ChangeOwed"));
                UpdateChangeProperties();
            }
        }

        private int customerFives = 0;
        /// <summary>
        /// Gets and sets the customers fives
        /// </summary>
        public int CustomerFives
        {
            get => customerFives;
            set
            {
                customerFives = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("CustomerFives"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("AmountDue"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ChangeOwed"));
                UpdateChangeProperties();
            }
        }

        private int customerTwos = 0;
        /// <summary>
        /// Gets and sets the customers twos
        /// </summary>
        public int CustomerTwos
        {
            get => customerTwos;
            set
            {
                customerTwos = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("CustomerTwos"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("AmountDue"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ChangeOwed"));
                UpdateChangeProperties();
            }
        }

        private int customerOnes = 0;
        /// <summary>
        /// Gets and sets the customers ones
        /// </summary>
        public int CustomerOnes
        {
            get => customerOnes;
            set
            {
                customerOnes = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("CustomerOnes"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("AmountDue"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ChangeOwed"));
                UpdateChangeProperties();
            }
        }

        private int customerDollars = 0;
        /// <summary>
        /// Gets and sets the customers dollars
        /// </summary>
        public int CustomerDollars
        {
            get => customerDollars;
            set
            {
                customerDollars = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("CustomerDollars"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("AmountDue"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ChangeOwed"));
                UpdateChangeProperties();
            }
        }

        private int customerHalfDollars = 0;
        /// <summary>
        /// Gets and sets the customers half dollars
        /// </summary>
        public int CustomerHalfDollars
        {
            get => customerHalfDollars;
            set
            {
                customerHalfDollars = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("CustomerHalfDollars"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("AmountDue"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ChangeOwed"));
                UpdateChangeProperties();
            }
        }

        private int customerQuarters = 0;
        /// <summary>
        /// Gets and sets the customers quarters
        /// </summary>
        public int CustomerQuarters
        {
            get => customerQuarters;
            set
            {
                customerQuarters = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("CustomerQuarters"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("AmountDue"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ChangeOwed"));
                UpdateChangeProperties();
            }
        }

        private int customerDimes = 0;
        /// <summary>
        /// Gets and sets the customers dimes
        /// </summary>
        public int CustomerDimes
        {
            get => customerDimes;
            set
            {
                customerDimes = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("CustomerDimes"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("AmountDue"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ChangeOwed"));
                UpdateChangeProperties();
            }
        }

        private int customerNickels = 0;
        /// <summary>
        /// Gets and sets the customers nickels
        /// </summary>
        public int CustomerNickels
        {
            get => customerNickels;
            set
            {
                customerNickels = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("CustomerNickels"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("AmountDue"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ChangeOwed"));
                UpdateChangeProperties();
            }
        }

        private int customerPennies = 0;
        /// <summary>
        /// Gets and sets the customers pennies
        /// </summary>
        public int CustomerPennies
        {
            get => customerPennies;
            set
            {
                customerPennies = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("CustomerPennies"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("AmountDue"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ChangeOwed"));
                UpdateChangeProperties();
            }
        }

        private int changeHundreds = 0;
        /// <summary>
        /// Gets the change hundreds
        /// </summary>
        public int ChangeHundreds
        {
            get
            {
                double changeOwed = Convert.ToDouble(ChangeOwed.Substring(1));
                changeHundreds = Convert.ToInt32(Math.Floor(changeOwed / 100.00));
                return changeHundreds;
            }
        }

        private int changeFifties = 0;
        /// <summary>
        /// Gets the change fifties
        /// </summary>
        public int ChangeFifties
        {
            get
            {
                double changeOwed = Convert.ToDouble(ChangeOwed.Substring(1));
                if(changeOwed > 100)
                {
                    changeOwed = changeOwed % 100;
                }
                changeFifties = Convert.ToInt32(Math.Floor(changeOwed / 50.00));
                return changeFifties;
            }
        }

        private int changeTwenties = 0;
        /// <summary>
        /// Gets the change twenties
        /// </summary>
        public int ChangeTwenties
        {
            get
            {
                double changeOwed = Convert.ToDouble(ChangeOwed.Substring(1));
                if (changeOwed > 100)
                {
                    changeOwed = changeOwed % 100;
                }
                if (changeOwed > 50)
                {
                    changeOwed = changeOwed % 50;
                }
                changeTwenties = Convert.ToInt32(Math.Floor(changeOwed / 20.00));
                return changeTwenties;
            }
        }

        private int changeTens = 0;
        /// <summary>
        /// Gets the change tens
        /// </summary>
        public int ChangeTens
        {
            get
            {
                double changeOwed = Convert.ToDouble(ChangeOwed.Substring(1));
                if (changeOwed > 100)
                {
                    changeOwed = changeOwed % 100;
                }
                if (changeOwed > 50)
                {
                    changeOwed = changeOwed % 50;
                }
                if(changeOwed > 20)
                {
                    changeOwed = changeOwed % 20;
                }    
                changeTens = Convert.ToInt32(Math.Floor(changeOwed / 10.00));
                return changeTens;
            }
        }

        private int changeFives = 0;
        /// <summary>
        /// Gets the change fives
        /// </summary>
        public int ChangeFives
        {
            get
            {
                double changeOwed = Convert.ToDouble(ChangeOwed.Substring(1));
                if (changeOwed > 100)
                {
                    changeOwed = changeOwed % 100;
                }
                if (changeOwed > 50)
                {
                    changeOwed = changeOwed % 50;
                }
                if (changeOwed > 20)
                {
                    changeOwed = changeOwed % 20;
                }
                if(changeOwed > 10)
                {
                    changeOwed = changeOwed % 10;
                }
                changeFives = Convert.ToInt32(Math.Floor(changeOwed / 5.00));
                return changeFives;
            }
        }

        private int changeTwos = 0;
        /// <summary>
        /// Gets the change twos
        /// </summary>
        public int ChangeTwos
        {
            get
            {
                double changeOwed = Convert.ToDouble(ChangeOwed.Substring(1));
                if (changeOwed > 100)
                {
                    changeOwed = changeOwed % 100;
                }
                if (changeOwed > 50)
                {
                    changeOwed = changeOwed % 50;
                }
                if (changeOwed > 20)
                {
                    changeOwed = changeOwed % 20;
                }
                if (changeOwed > 10)
                {
                    changeOwed = changeOwed % 10;
                }
                if(changeOwed > 5)
                {
                    changeOwed = changeOwed % 5;
                }
                changeTwos = Convert.ToInt32(Math.Floor(changeOwed / 2.00));
                return changeTwos;
            }
        }

        private int changeOnes = 0;
        /// <summary>
        /// Gets the change ones
        /// </summary>
        public int ChangeOnes
        {
            get
            {
                double changeOwed = Convert.ToDouble(ChangeOwed.Substring(1));
                if (changeOwed > 100)
                {
                    changeOwed = changeOwed % 100;
                }
                if (changeOwed > 50)
                {
                    changeOwed = changeOwed % 50;
                }
                if (changeOwed > 20)
                {
                    changeOwed = changeOwed % 20;
                }
                if (changeOwed > 10)
                {
                    changeOwed = changeOwed % 10;
                }
                if (changeOwed > 5)
                {
                    changeOwed = changeOwed % 5;
                }
                if(changeOwed > 2)
                {
                    changeOwed = changeOwed % 2;
                }
                changeOnes = Convert.ToInt32(Math.Floor(changeOwed / 1.00));
                return changeOnes;
            }
        }

        private int changeDollars = 0;
        /// <summary>
        /// Gets the change dollars
        /// </summary>
        public int ChangeDollars
        {
            get
            {
                return changeDollars;
            }
        }

        private int changeHalfDollars = 0;
        /// <summary>
        /// Gets the change half dollars
        /// </summary>
        public int ChangeHalfDollars
        {
            get
            {
                double changeOwed = Convert.ToDouble(ChangeOwed.Substring(1));
                if (changeOwed > 100)
                {
                    changeOwed = changeOwed % 100;
                }
                if (changeOwed > 50)
                {
                    changeOwed = changeOwed % 50;
                }
                if (changeOwed > 20)
                {
                    changeOwed = changeOwed % 20;
                }
                if (changeOwed > 10)
                {
                    changeOwed = changeOwed % 10;
                }
                if (changeOwed > 5)
                {
                    changeOwed = changeOwed % 5;
                }
                if (changeOwed > 2)
                {
                    changeOwed = changeOwed % 2;
                }
                if(changeOwed > 1)
                {
                    changeOwed = changeOwed % 1;
                }
                changeHalfDollars = Convert.ToInt32(Math.Floor(changeOwed / 0.50));
                return changeHalfDollars;
            }
        }

        private int changeQuarters = 0;
        /// <summary>
        /// Gets the change quarters
        /// </summary>
        public int ChangeQuarters
        {
            get
            {
                double changeOwed = Convert.ToDouble(ChangeOwed.Substring(1));
                if (changeOwed > 100)
                {
                    changeOwed = changeOwed % 100;
                }
                if (changeOwed > 50)
                {
                    changeOwed = changeOwed % 50;
                }
                if (changeOwed > 20)
                {
                    changeOwed = changeOwed % 20;
                }
                if (changeOwed > 10)
                {
                    changeOwed = changeOwed % 10;
                }
                if (changeOwed > 5)
                {
                    changeOwed = changeOwed % 5;
                }
                if (changeOwed > 2)
                {
                    changeOwed = changeOwed % 2;
                }
                if (changeOwed > 1)
                {
                    changeOwed = changeOwed % 1;
                }
                if (changeOwed > 0.50)
                {
                    changeOwed = changeOwed % 0.50;
                }
                changeQuarters = Convert.ToInt32(Math.Floor(changeOwed / 0.25));
                return changeQuarters;
            }
        }

        private int changeDimes = 0;
        /// <summary>
        /// Gets the change dimes
        /// </summary>
        public int ChangeDimes
        {
            get
            {
                double changeOwed = Convert.ToDouble(ChangeOwed.Substring(1));
                if (changeOwed > 100)
                {
                    changeOwed = changeOwed % 100;
                }
                if (changeOwed > 50)
                {
                    changeOwed = changeOwed % 50;
                }
                if (changeOwed > 20)
                {
                    changeOwed = changeOwed % 20;
                }
                if (changeOwed > 10)
                {
                    changeOwed = changeOwed % 10;
                }
                if (changeOwed > 5)
                {
                    changeOwed = changeOwed % 5;
                }
                if (changeOwed > 2)
                {
                    changeOwed = changeOwed % 2;
                }
                if (changeOwed > 1)
                {
                    changeOwed = changeOwed % 1;
                }
                if (changeOwed > 0.50)
                {
                    changeOwed = changeOwed % 0.50;
                }
                if (changeOwed > 0.25)
                {
                    changeOwed = changeOwed % 0.25;
                }
                changeDimes = Convert.ToInt32(Math.Floor(changeOwed / 0.10));
                return changeDimes;
            }
        }

        private int changeNickels = 0;
        /// <summary>
        /// Gets the change nickels
        /// </summary>
        public int ChangeNickels
        {
            get
            {
                double changeOwed = Convert.ToDouble(ChangeOwed.Substring(1));
                if (changeOwed > 100)
                {
                    changeOwed = changeOwed % 100;
                }
                if (changeOwed > 50)
                {
                    changeOwed = changeOwed % 50;
                }
                if (changeOwed > 20)
                {
                    changeOwed = changeOwed % 20;
                }
                if (changeOwed > 10)
                {
                    changeOwed = changeOwed % 10;
                }
                if (changeOwed > 5)
                {
                    changeOwed = changeOwed % 5;
                }
                if (changeOwed > 2)
                {
                    changeOwed = changeOwed % 2;
                }
                if (changeOwed > 1)
                {
                    changeOwed = changeOwed % 1;
                }
                if (changeOwed > 0.50)
                {
                    changeOwed = changeOwed % 0.50;
                }
                if (changeOwed > 0.25)
                {
                    changeOwed = changeOwed % 0.25;
                }
                if(changeOwed > 0.10)
                {
                    changeOwed = changeOwed % 0.10;
                }
                changeNickels = Convert.ToInt32(Math.Floor(changeOwed / 0.05));
                return changeNickels;
            }
        }

        private int changePennies = 0;
        /// <summary>
        /// Gets the change pennies
        /// </summary>
        public int ChangePennies
        {
            get
            {
                double changeOwed = Convert.ToDouble(ChangeOwed.Substring(1));
                if (changeOwed > 100)
                {
                    changeOwed = changeOwed % 100;
                }
                if (changeOwed > 50)
                {
                    changeOwed = changeOwed % 50;
                }
                if (changeOwed > 20)
                {
                    changeOwed = changeOwed % 20;
                }
                if (changeOwed > 10)
                {
                    changeOwed = changeOwed % 10;
                }
                if (changeOwed > 5)
                {
                    changeOwed = changeOwed % 5;
                }
                if (changeOwed > 2)
                {
                    changeOwed = changeOwed % 2;
                }
                if (changeOwed > 1)
                {
                    changeOwed = changeOwed % 1;
                }
                if (changeOwed > 0.50)
                {
                    changeOwed = changeOwed % 0.50;
                }
                if (changeOwed > 0.25)
                {
                    changeOwed = changeOwed % 0.25;
                }
                if (changeOwed > 0.10)
                {
                    changeOwed = changeOwed % 0.10;
                }
                if(changeOwed > 0.05)
                {
                    changeOwed = changeOwed % 0.05;
                }    
                changePennies = Convert.ToInt32(changeOwed / 0.01);
                return changePennies;
            }
        }

        /// <summary>
        /// Gets the amount of money due
        /// </summary>
        public string AmountDue
        {
            get
            {
                double amountDue = order.Total - ((CustomerHundreds * 100.00) + (CustomerFifties * 50.00) + (CustomerTwenties * 20.00)
                    + (CustomerTens * 10.00) + (CustomerFives * 5.00) + (CustomerTwos * 2.00)
                    + (CustomerOnes * 1.00) + (CustomerDollars * 1.00) + (CustomerHalfDollars * 0.50)
                    + (CustomerQuarters * 0.25) + (CustomerDimes * 0.10) + (CustomerNickels * 0.05)
                    + (CustomerPennies * 0.01));
                if (Math.Round(amountDue, 2) < 0) return "$0.00";
                else return "$" + Math.Round(amountDue, 2).ToString();
            }
        }

        /// <summary>
        /// Gets the change owed back
        /// </summary>
        public string ChangeOwed
        {
            get
            {
                if (Convert.ToDouble(AmountDue.Substring(1)) > 0.00) return "$0.00";
                else
                {
                    double owed = ((CustomerHundreds * 100.00) + (CustomerFifties * 50.00) + (CustomerTwenties * 20.00)
                    + (CustomerTens * 10.00) + (CustomerFives * 5.00) + (CustomerTwos * 2.00)
                    + (CustomerOnes * 1.00) + (CustomerDollars * 1.00) + (CustomerHalfDollars * 0.50)
                    + (CustomerQuarters * 0.25) + (CustomerDimes * 0.10) + (CustomerNickels * 0.05)
                    + (CustomerPennies * 0.01)) - order.Total;
                    return "$" + Math.Round(owed, 2).ToString();
                }
            }
        }

        /// <summary>
        /// Gets the order
        /// </summary>
        /// <param name="order"></param>
        public RegisterUtility(Order order)
        {
            this.order = order;
        }

        private void UpdateChangeProperties()
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ChangeHundreds"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ChangeFifties"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ChangeTwenties"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ChangeTens"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ChangeFives"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ChangeTwos"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ChangeOnes"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ChangeDollars"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ChangeHalfDollars"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ChangeQuarters"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ChangeDimes"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ChangeNickels"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ChangePennies"));
        }

        /// <summary>
        /// Completes the transaction
        /// </summary>
        public void CompleteTransaction()
        {
            if (AmountDue == "$0.00")
            {
                CashDrawer.OpenDrawer();
                StringBuilder sb = new StringBuilder();
                sb.Append("Order Number: " + order.Number + " | ");
                sb.Append(DateTime.Today.Month + "/" + DateTime.Today.Day + "/" + DateTime.Today.Year + " | ");
                IEnumerator<IOrderItem> en = order.GetEnumerator();
                while(en.Current != null)
                {
                    List<string> instructions = en.Current.SpecialInstructions;
                    sb.Append(en.Current.ToString() + " " + en.Current.Price + " ");
                    foreach(string s in instructions)
                    {
                        sb.Append(s + " ");
                    }
                    sb.Append("| ");
                }
                sb.Append(order.Subtotal + " | ");
                sb.Append(order.Tax + " | ");
                sb.Append(order.Total + " | ");
                sb.Append("Paid in cash | ");
                sb.Append("Change owed: " + ChangeOwed);
                int length = Convert.ToInt32(Math.Ceiling(Convert.ToDouble(sb.Length) / 40.0));
                string reciept = sb.ToString();
                for(int i = 0; i < length - 1; i++)
                {
                    int start = i == 0 ? 0 : (i * 40) - 1;
                    RecieptPrinter.PrintLine(reciept.Substring(start, 40));
                }
                RecieptPrinter.PrintLine(reciept.Substring(((length - 1) * 40) - 1));
                RecieptPrinter.CutTape();
            }
        }
    }
}
