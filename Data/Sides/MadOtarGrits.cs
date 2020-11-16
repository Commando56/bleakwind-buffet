/*
 * Author: Cole Kaster
 * Class name: MadOtarGrits.cs
 * Purpose: Holds information about Mad Otar Grits
 */

using BleakwindBuffet.Data.Enums;
using System.Collections.Generic;
using System.ComponentModel;

namespace BleakwindBuffet.Data.Sides
{
    /// <summary>
    /// Represents an order of Mad Otar Grits
    /// </summary>
    public class MadOtarGrits : Side, IOrderItem
    {
        /// <summary>
        /// Gets the description of the grits
        /// </summary>
        public string Description
        {
            get => "Cheesey Grits.";
        }

        private double price = 1.22;
        /// <summary>
        /// Gets the price of the grits
        /// </summary>
        public override double Price
        {
            get
            {
                if (Size == Size.Small) price = 1.22;
                else if (Size == Size.Medium) price = 1.58;
                else price = 1.93;
                return price;
            }
        }

        private uint calories = 105;
        /// <summary>
        /// Gets the calories of the grits
        /// </summary>
        public override uint Calories
        {
            get
            {
                if (Size == Size.Small) calories = 105;
                else if (Size == Size.Medium) calories = 142;
                else calories = 179;
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
            return $"{Size} Mad Otar Grits";
        }
    }
}
