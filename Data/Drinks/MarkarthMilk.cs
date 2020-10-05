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
        /// <summary>
        /// Gets the price of the milk
        /// </summary>
        public override double Price
        {
            get
            {
                if (Size == Size.Small) return 1.05;
                else if (Size == Size.Medium) return 1.11;
                else return 1.22;
            }
        }

        /// <summary>
        /// Gets the calories of the milk
        /// </summary>
        public override uint Calories
        {
            get
            {
                if (Size == Size.Small) return 56;
                else if (Size == Size.Medium) return 72;
                else return 93;
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
                    OnPropertiesChanged(new PropertyChangedEventArgs("Ice"));
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
