/*
 * Author: Cole Kaster
 * Class name: DragonbornWaffleFries.cs
 * Purpose: Holds information about Dragonborn Waffle Fries
 */

using BleakwindBuffet.Data.Enums;
using System.Collections.Generic;

namespace BleakwindBuffet.Data.Sides
{
    /// <summary>
    /// Represents an order of Dragonborn Waffle Fries
    /// </summary>
    public class DragonbornWaffleFries : Side, IOrderItem
    {
        /// <summary>
        /// Gets the price of the fries
        /// </summary>
        public override double Price
        {
            get
            {
                if (Size == Size.Small) return 0.42;
                else if (Size == Size.Medium) return 0.76;
                else return 0.96;
            }
        }

        /// <summary>
        /// Gets the calories of the fries
        /// </summary>
        public override uint Calories
        {
            get
            {
                if (Size == Size.Small) return 77;
                else if (Size == Size.Medium) return 89;
                else return 100;
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
            return $"{Size} Dragonborn Waffle Fries";
        }
    }
}
