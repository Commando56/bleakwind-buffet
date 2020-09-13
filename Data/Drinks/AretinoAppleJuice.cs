/*
 * Author: Cole Kaster
 * Class name: AretinoAppleJuice.cs
 * Purpose: Holds information about a Aretino Apple Juice
 */

using BleakwindBuffet.Data.Enums;
using System.Collections.Generic;

namespace BleakwindBuffet.Data.Drinks
{
    /// <summary>
    /// Represents an order of Aretino Apple Juice
    /// </summary>
    public class AretinoAppleJuice : Drink, IOrderItem
    {
        /// <summary>
        /// Gets the price of the juice
        /// </summary>
        public override double Price
        {
            get
            {
                if (Size == Size.Small) return 0.62;
                else if (Size == Size.Medium) return 0.87;
                else return 1.01;
            }
        }

        /// <summary>
        /// Gets the calories of the juice
        /// </summary>
        public override uint Calories
        {
            get
            {
                if (Size == Size.Small) return 44;
                else if (Size == Size.Medium) return 88;
                else return 132;
            }
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
