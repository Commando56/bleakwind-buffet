/*
 * Author: Cole Kaster
 * Class name: AretinoAppleJuice.cs
 * Purpose: Holds information about a Aretino Apple Juice
 */

using BleakwindBuffet.Data.Enums;
using System.Collections.Generic;
using System.ComponentModel;

namespace BleakwindBuffet.Data.Drinks
{
    /// <summary>
    /// Represents an order of Aretino Apple Juice
    /// </summary>
    public class AretinoAppleJuice : Drink, IOrderItem, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private double price = 0.62;
        /// <summary>
        /// Gets the price of the juice
        /// </summary>
        public override double Price
        {
            get
            {
                if (Size == Size.Small) price = 0.62;
                else if (Size == Size.Medium) price = 0.87;
                else price = 1.01;
                return price;
            }
        }

        private uint calories = 44;
        /// <summary>
        /// Gets the calories of the juice
        /// </summary>
        public override uint Calories
        {
            get
            {
                if (Size == Size.Small) calories = 44;
                else if (Size == Size.Medium) calories = 88;
                else calories = 132;
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

        /// <summary>
        /// Represents a list on which ingredients to add
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();
                if (Ice) instructions.Add("Add ice");
                return instructions;
            }
        }

        /// <summary>
        /// Overrides the ToString method
        /// </summary>
        /// <returns>The name of the item</returns>
        public override string ToString()
        {
            return $"{Size} Aretino Apple Juice";
        }
    }
}
