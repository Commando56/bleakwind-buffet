/*
 * Author: Cole Kaster
 * Class name: VokunSalad.cs
 * Purpose: Holds information about a Vokun Salad
 */

using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace BleakwindBuffet.Data.Sides
{
    /// <summary>
    /// Represents an order of Vokun Salad
    /// </summary>
    public class VokunSalad : Side, IOrderItem
    {
        /// <summary>
        /// Gets the description of the salad
        /// </summary>
        public string Description
        {
            get => "A seasonal fruit salad of mellons, berries, mango, grape, apple, and oranges.";
        }

        private double price = 0.93;
        /// <summary>
        /// Gets the price of the salad
        /// </summary>
        public override double Price
        {
            get
            {
                if (Size == Size.Small) price = 0.93;
                else if (Size == Size.Medium) price = 1.28;
                else price = 1.82;
                return price;
            }
        }

        private uint calories = 41;
        /// <summary>
        /// Gets the calories of the salad
        /// </summary>
        public override uint Calories
        {
            get
            {
                if (Size == Size.Small) calories = 41;
                else if (Size == Size.Medium) calories = 52;
                else calories = 73;
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
            return $"{Size} Vokun Salad";
        }
    }
}
