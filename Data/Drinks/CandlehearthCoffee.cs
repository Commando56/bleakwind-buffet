/*
 * Author: Cole Kaster
 * Class name: CandlehearthCoffee.cs
 * Purpose: Holds information about a Candlehearth Coffee
 */

using BleakwindBuffet.Data.Enums;
using System.Collections.Generic;
using System.ComponentModel;

namespace BleakwindBuffet.Data.Drinks
{
    /// <summary>
    /// Represents an order of Candlehearth Coffee
    /// </summary>
    public class CandlehearthCoffee : Drink, IOrderItem, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Gets the description of the coffee
        /// </summary>
        public string Description
        {
            get => "Fair trade, fresh ground dark roast coffee.";
        }

        private double price = 0.75;
        /// <summary>
        /// Gets the price of the coffee
        /// </summary>
        public override double Price
        {
            get
            {
                if (Size == Size.Small) price =  0.75;
                else if (Size == Size.Medium) price =  1.25;
                else price = 1.75;
                return price;
            }
        }

        private uint calories = 7;
        /// <summary>
        /// Gets the calories of the coffee
        /// </summary>
        public override uint Calories
        {
            get
            {
                if (Size == Size.Small) calories = 7;
                else if (Size == Size.Medium) calories = 10;
                else calories = 20;
                return calories;
            }
        }

        private bool ice = false;
        /// <summary>
        /// Gets and sets whether it has ice
        /// </summary>
        public bool Ice
        {
            get => ice;
            set
            {
                if (ice != value)
                {
                    ice = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Ice"));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
                }
            }
        }

        private bool roomForCream = false;
        /// <summary>
        /// Gets and sets whether it has room for cream
        /// </summary>
        public bool RoomForCream
        {
            get => roomForCream;
            set
            {
                if (roomForCream != value)
                {
                    roomForCream = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("RoomForCream"));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
                }
            }
        }

        private bool decaf = false;
        /// <summary>
        /// Gets and sets whether it is decaf
        /// </summary>
        public bool Decaf
        {
            get => decaf;
            set
            {
                if (decaf != value)
                {
                    decaf = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Decaf"));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ToString"));
                }
            }
        }

        /// <summary>
        /// Represents a list on which ingredients to add
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();
                if (Ice) instructions.Add("Add ice");
                if (RoomForCream) instructions.Add("Add cream");
                return instructions;
            }
        }

        /// <summary>
        /// Overrides the ToString method
        /// </summary>
        /// <returns>The name of the item</returns>
        public override string ToString()
        {
            if (!Decaf) return $"{Size} Candlehearth Coffee";
            else return $"{Size} Decaf Candlehearth Coffee";
        }
    }
}
