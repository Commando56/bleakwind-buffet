/*
 * Author: Cole Kaster
 * Class name: Order.cs
 * Purpose: Holds information about an order
 */

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Text;
using System.ComponentModel;
using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data.Sides;
using BleakwindBuffet.Data.Drinks;
using System.Collections.ObjectModel;

namespace BleakwindBuffet.Data
{
    /// <summary>
    /// Represents an order
    /// </summary>
    public class Order : ObservableCollection<IOrderItem>
    {
        private static uint nextOrderNumber = 1;

        /// <summary>
        /// Represents the calories of all the items in the order
        /// </summary>
        public uint Calories
        {
            get
            {
                uint calories = 0;
                foreach(IOrderItem item in this)
                {
                    if (item is Entree entree) calories += entree.Calories;
                    else if (item is Side side) calories += side.Calories;
                    else if (item is Drink drink) calories += drink.Calories;
                }
                return calories;
            }
        }

        private double salesTaxRate = 0.12;
        /// <summary>
        /// The sales tax rate of the order
        /// </summary>
        public double SalesTaxRate
        {
            get => salesTaxRate;
            set
            {
                if(salesTaxRate != value)
                {
                    salesTaxRate = value;
                }
            }
        }

        /// <summary>
        /// The subtotal of the items in the order
        /// </summary>
        public double Subtotal
        {
            get
            {
                double subtotal = 0;
                foreach(IOrderItem item in this)
                {
                    subtotal += item.Price;
                    subtotal = Math.Round(subtotal, 2);
                }
                return subtotal;
            }
        }

        /// <summary>
        /// The tax of the order
        /// </summary>
        public double Tax
        {
            get
            {
                double tax = SalesTaxRate * Subtotal;
                tax = Math.Round(tax, 2);
                return tax;
            }
        }

        /// <summary>
        /// The total cost of the order
        /// </summary>
        public double Total
        {
            get
            {
                double total = Subtotal + Tax;
                total = Math.Round(total, 2);
                return total;
            }
        }

        /// <summary>
        /// The order's number
        /// </summary>
        public uint Number
        {
            get;
            private set;
        }

        /// <summary>
        /// Initializes the order's items and sets the order number
        /// </summary>
        public Order()
        {
            Number = nextOrderNumber;
            nextOrderNumber += 1;
            CollectionChanged += CollectionChangedListener;
        }

        private void CollectionChangedListener(object sender, NotifyCollectionChangedEventArgs e)
        {
            switch (e.Action)
            {
                case NotifyCollectionChangedAction.Add:
                    foreach (IOrderItem item in e.NewItems)
                    {
                        if (item is Entree entree) entree.PropertyChanged += this.CollectionItemChangedListener;
                        else if (item is Side side) side.PropertyChanged += this.CollectionItemChangedListener;
                        else if (item is Drink drink) drink.PropertyChanged += this.CollectionItemChangedListener;             
                    }
                    break;
                case NotifyCollectionChangedAction.Remove:
                    foreach (IOrderItem item in e.OldItems)
                    {
                        if (item is Entree entree) entree.PropertyChanged -= this.CollectionItemChangedListener;
                        else if (item is Side side) side.PropertyChanged -= this.CollectionItemChangedListener;
                        else if (item is Drink drink) drink.PropertyChanged -= this.CollectionItemChangedListener;
                    }
                    break;
                case NotifyCollectionChangedAction.Reset:
                    break;
            }
        }

        private void CollectionItemChangedListener(object sender, PropertyChangedEventArgs e)
        {
            OnPropertyChanged(new PropertyChangedEventArgs("Subtotal"));
            OnPropertyChanged(new PropertyChangedEventArgs("Tax"));
            OnPropertyChanged(new PropertyChangedEventArgs("Total"));
            OnPropertyChanged(new PropertyChangedEventArgs("Calories"));
        }

        /// <summary>
        /// Returns false
        /// </summary>
        public bool IsReadOnly
        {
            get { return false; }
        }
    }
}
