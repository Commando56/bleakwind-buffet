/*
 * Author: Cole Kaster
 * Class name: FriedMiraak.cs
 * Purpose: Holds information about a Fried Miraak
 */

using BleakwindBuffet.Data.Enums;

namespace BleakwindBuffet.Data.Sides
{
    /// <summary>
    /// Represents an order of Fried Miraak
    /// </summary>
    public class FriedMiraak
    {
        /// <summary>
        /// Gets the price of the pancakes
        /// </summary>
        public double Price
        {
            get
            {
                if (Size == Size.Small) return 1.78;
                else if (Size == Size.Medium) return 2.01;
                else return 2.88;
            }
        }

        /// <summary>
        /// Gets the calories of the pancakes
        /// </summary>
        public uint Calories
        {
            get
            {
                if (Size == Size.Small) return 151;
                else if (Size == Size.Medium) return 236;
                else return 306;
            }
        }

        private Size size = Size.Small;
        /// <summary>
        /// Gets and sets the size of the pancakes
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
            return $"{Size} Fried Miraak";
        }
    }
}
