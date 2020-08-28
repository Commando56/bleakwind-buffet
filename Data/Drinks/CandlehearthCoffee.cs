/*
 * Author: Cole Kaster
 * Class name: CandlehearthCoffee.cs
 * Purpose: Holds information about a Candlehearth Coffee
 */

using BleakwindBuffet.Data.Enums;
using System.Collections.Generic;

namespace BleakwindBuffet.Data.Drinks
{
    /// <summary>
    /// Represents an order of Candlehearth Coffee
    /// </summary>
    public class CandlehearthCoffee
    {
        /// <summary>
        /// Gets the price of the coffee
        /// </summary>
        public double Price
        {
            get
            {
                if (Size == Size.Small) return 0.75;
                else if (Size == Size.Medium) return 1.25;
                else return 1.75;
            }
        }

        /// <summary>
        /// Gets the calories of the coffee
        /// </summary>
        public uint Calories
        {
            get
            {
                if (Size == Size.Small) return 7;
                else if (Size == Size.Medium) return 10;
                else return 20;
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

        private bool roomForCream = false;
        /// <summary>
        /// Gets and sets whether it has room for cream
        /// </summary>
        public bool RoomForCream
        {
            get => roomForCream;
            set => roomForCream = value;
        }

        private bool decaf = false;
        /// <summary>
        /// Gets and sets whether it is decaf
        /// </summary>
        public bool Decaf
        {
            get => decaf;
            set => decaf = value;
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
                if (RoomForCream) instructions.Add("Add cream");
                return instructions;
            }
        }

        /// <summary>
        /// Overrides the ToString method
        /// </summary>
        /// <returns>The name of the item</returns>
        public override string ToString()
        {
            if (!Decaf) return $"{Size} Candlehearth Coffee";
            else return $"{Size} Decaf Candlehearth Coffee";
        }
    }
}
