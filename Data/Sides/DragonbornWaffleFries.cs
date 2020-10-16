/*
 * Author: Cole Kaster
 * Class name: DragonbornWaffleFries.cs
 * Purpose: Holds information about Dragonborn Waffle Fries
 */

using BleakwindBuffet.Data.Enums;
using System.Collections.Generic;
using System.ComponentModel;

namespace BleakwindBuffet.Data.Sides
{
    /// <summary>
    /// Represents an order of Dragonborn Waffle Fries
    /// </summary>
    public class DragonbornWaffleFries : Side, IOrderItem
    {
        private double price = 0.42;
        /// <summary>
        /// Gets the price of the fries
        /// </summary>
        public override double Price
        {
            get
            {
                if (Size == Size.Small) price = 0.42;
                else if (Size == Size.Medium) price = 0.76;
                else price = 0.96;
                return price;
            }
        }

        private uint calories = 77;
        /// <summary>
        /// Gets the calories of the fries
        /// </summary>
        public override uint Calories
        {
            get
            {
                if (Size == Size.Small) calories = 77;
                else if (Size == Size.Medium) calories = 89;
                else calories = 100;
                return calories;
            }
        }

        private List<string> specialInstructions = new List<string>();
        /// <summary>
        /// Represents a list on which ingredients to hold
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get => specialInstructions;
        }

        /// <summary>
        /// Overrides the ToString method
        /// </summary>
        /// <returns>The name of the item</returns>
        public override string ToString()
        {
            return $"{Size} Dragonborn Waffle Fries";
        }
    }
}
