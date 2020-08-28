/*
 * Author: Cole Kaster
 * Class name: MarkarthMilk.cs
 * Purpose: Holds information about a Markarth Milk
 */

using BleakwindBuffet.Data.Enums;
using System.Collections.Generic;

namespace BleakwindBuffet.Data.Drinks
{
    /// <summary>
    /// Represents an order of Markarth Milk
    /// </summary>
    public class MarkarthMilk
    {
        /// <summary>
        /// Gets the price of the milk
        /// </summary>
        public double Price
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
        public uint Calories
        {
            get
            {
                if (Size == Size.Small) return 56;
                else if (Size == Size.Medium) return 72;
                else return 93;
            }
        }

        private Size size = Size.Small;
        /// <summary>
        /// Gets and sets the size of the drink
        /// </summary>
        public Size Size
        {
            get => size;
            set => size = value;
        }

        private bool ice = false;
        /// <summary>
        /// Gets and sets whether it has ice
        /// </summary>
        public bool Ice
        {
            get => ice;
            set => ice = value;
        }

        /// <summary>
        /// Represents a list on which ingredients to add
        /// </summary>
        public List<string> SpecialInstructions
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
