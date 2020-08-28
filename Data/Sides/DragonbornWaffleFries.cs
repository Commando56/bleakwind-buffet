/*
 * Author: Cole Kaster
 * Class name: DragonbornWaffleFries.cs
 * Purpose: Holds information about Dragonborn Waffle Fries
 */

using BleakwindBuffet.Data.Enums;

namespace BleakwindBuffet.Data.Sides
{
    /// <summary>
    /// Represents an order of Dragonborn Waffle Fries
    /// </summary>
    public class DragonbornWaffleFries
    {
        /// <summary>
        /// Gets the price of the fries
        /// </summary>
        public double Price
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
        public uint Calories
        {
            get
            {
                if (Size == Size.Small) return 77;
                else if (Size == Size.Medium) return 89;
                else return 100;
            }
        }

        private Size size = Size.Small;
        /// <summary>
        /// Gets and sets the size of the fries
        /// </summary>
        public Size Size
        {
            get => size;
            set => size = value;
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
