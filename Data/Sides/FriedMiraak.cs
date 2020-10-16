/*
 * Author: Cole Kaster
 * Class name: FriedMiraak.cs
 * Purpose: Holds information about a Fried Miraak
 */

using BleakwindBuffet.Data.Enums;
using System.Collections.Generic;
using System.ComponentModel;

namespace BleakwindBuffet.Data.Sides
{
    /// <summary>
    /// Represents an order of Fried Miraak
    /// </summary>
    public class FriedMiraak : Side, IOrderItem
    {
        private double price = 1.78;
        /// <summary>
        /// Gets the price of the pancakes
        /// </summary>
        public override double Price
        {
            get
            {
                if (Size == Size.Small) price = 1.78;
                else if (Size == Size.Medium) price = 2.01;
                else price = 2.88;
                return price;
            }
        }

        private uint calories = 151;
        /// <summary>
        /// Gets the calories of the pancakes
        /// </summary>
        public override uint Calories
        {
            get
            {
                if (Size == Size.Small) calories = 151;
                else if (Size == Size.Medium) calories = 236;
                else calories = 306;
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
            return $"{Size} Fried Miraak";
        }
    }
}
