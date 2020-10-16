/*
 * Author: Cole Kaster
 * Class name: Combo.cs
 * Purpose: Holds information about a Combo
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data.Sides;
using BleakwindBuffet.Data.Drinks;
using System.Collections.Specialized;

namespace BleakwindBuffet.Data
{
    /// <summary>
    /// Represents a combo containing an entree, side, and drink
    /// </summary>
    public class Combo : IOrderItem, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private Entree entree;
        /// <summary>
        /// The combo's entree
        /// </summary>
        public Entree Entree
        {
            get => entree;
            set
            {
                entree = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Entree"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Price"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Calories"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }
        }

        private Side side = null;
        /// <summary>
        /// The combo's side
        /// </summary>
        public Side Side
        {
            get => side;
            set 
            {
                side = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Side"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Price"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Calories"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }
        }

        private Drink drink = null;
        /// <summary>
        /// The combo's drink
        /// </summary>
        public Drink Drink
        {
            get => drink;
            set
            {
                drink = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Drink"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Price"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Calories"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }
        }

        /// <summary>
        /// Creates a combo class with the provided entree, side and drink
        /// </summary>
        /// <param name="entree"></param>
        /// <param name="side"></param>
        /// <param name="drink"></param>
        public Combo(Entree entree, Side side, Drink drink)
        {
            Entree = entree;
            Side = side;
            Drink = drink;
        }

        private double price = 0;
        /// <summary>
        /// The price of the combo
        /// </summary>
        public virtual double Price
        {
            get
            {
                price = (Entree.Price + Side.Price + Drink.Price) - 1.00;
                price = Math.Round(price, 2);
                return price;  
            }
        }

        private uint calories = 0;
        /// <summary>
        /// The calories of all the items in the combo
        /// </summary>
        public virtual uint Calories
        {
            get
            {
                calories = Entree.Calories + Side.Calories + Drink.Calories;
                return calories;
            }
        }

        private List<string> specialInstructions = new List<string>();
        /// <summary>
        /// The list of special instructions of the combo
        /// </summary>
        public virtual List<string> SpecialInstructions
        {
            get
            {
                specialInstructions.Clear();
                specialInstructions.Add(Entree.ToString());
                foreach(string s in Entree.SpecialInstructions)
                {
                    specialInstructions.Add(s);
                }
                specialInstructions.Add(Side.ToString());
                foreach(string s in Side.SpecialInstructions)
                {
                    specialInstructions.Add(s);
                }
                specialInstructions.Add(Drink.ToString());
                foreach(string s in Drink.SpecialInstructions)
                {
                    specialInstructions.Add(s);
                }
                return specialInstructions;
            }
        }
    }
}
