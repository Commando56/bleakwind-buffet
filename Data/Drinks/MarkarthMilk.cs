/*
 * Author: Cole Kaster
 * Class name: MarkarthMilk.cs
 * Purpose: Holds information about a Markarth Milk
 */

using BleakwindBuffet.Data.Enums;
using System.Collections.Generic;
using System.ComponentModel;

namespace BleakwindBuffet.Data.Drinks
{
    /// <summary>
    /// Represents an order of Markarth Milk
    /// </summary>
    public class MarkarthMilk : Drink, IOrderItem
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private double price = 1.05;
        /// <summary>
        /// Gets the price of the milk
        /// </summary>
        public override double Price
        {
            get
            {
                if (Size == Size.Small) price = 1.05;
                else if (Size == Size.Medium) price = 1.11;
                else price = 1.22;
                return price;
            }
        }

        private uint calories = 56;
        /// <summary>
        /// Gets the calories of the milk
        /// </summary>
        public override uint Calories
        {
            get
            {
                if (Size == Size.Small) calories = 56;
                else if (Size == Size.Medium) calories = 72;
                else calories = 93;
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
            return $"{Size} Markarth Milk";
        }
    }
}
