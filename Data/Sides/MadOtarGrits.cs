/*
 * Author: Cole Kaster
 * Class name: MadOtarGrits.cs
 * Purpose: Holds information about Mad Otar Grits
 */

using BleakwindBuffet.Data.Enums;
using System.Collections.Generic;

namespace BleakwindBuffet.Data.Sides
{
    /// <summary>
    /// Represents an order of Mad Otar Grits
    /// </summary>
    public class MadOtarGrits : Side, IOrderItem
    {
        /// <summary>
        /// Gets the price of the grits
        /// </summary>
        public override double Price
        {
            get
            {
                if (Size == Size.Small) return 1.22;
                else if (Size == Size.Medium) return 1.58;
                else return 1.93;
            }
        }

        /// <summary>
        /// Gets the calories of the grits
        /// </summary>
        public override uint Calories
        {
            get
            {
                if (Size == Size.Small) return 105;
                else if (Size == Size.Medium) return 142;
                else return 179;
            }
        }

        /// <summary>
        /// Represents a list on which ingredients to hold
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get => new List<string>();
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
