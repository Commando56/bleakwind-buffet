/*
 * Author: Cole Kaster
 * Class name: SailorSoda.cs
 * Purpose: Holds information about a Sailor Soda
 */

using BleakwindBuffet.Data.Enums;
using System.Collections.Generic;

namespace BleakwindBuffet.Data.Drinks
{
    /// <summary>
    /// Represents an order of Sailor Soda
    /// </summary>
    public class SailorSoda
    {
        /// <summary>
        /// Gets the price of the soda
        /// </summary>
        public double Price
        {
            get
            {
                if (Size == Size.Small) return 1.42;
                else if (Size == Size.Medium) return 1.74;
                else return 2.07;
            }
        }

        /// <summary>
        /// Gets the calories of the soda
        /// </summary>
        public uint Calories
        {
            get
            {
                if (Size == Size.Small) return 117;
                else if (Size == Size.Medium) return 153;
                else return 205;
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

        private SodaFlavor sodaFlavor = SodaFlavor.Cherry;
        /// <summary>
        /// Gets and sets the soda flavor
        /// </summary>
        public SodaFlavor SodaFlavor
        {
            get => sodaFlavor;
            set => sodaFlavor = value;
        }

        private bool ice = true;
        /// <summary>
        /// Gets and sets whether it has ice
        /// </summary>
        public bool Ice
        {
            get => ice;
            set => ice = value;
        }
        
        /// <summary>
        /// Represents a list on which ingredients to hold
        /// </summary>
        public List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();
                if (!Ice) instructions.Add("Hold ice");
                return instructions;
            }
        }

        /// <summary>
        /// Overrides the ToString method
        /// </summary>
        /// <returns>The name of the item</returns>
        public override string ToString()
        {
            return $"{Size} {SodaFlavor} Sailor Soda";
        }
    }
}
