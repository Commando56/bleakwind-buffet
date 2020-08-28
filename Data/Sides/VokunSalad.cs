/*
 * Author: Cole Kaster
 * Class name: VokunSalad.cs
 * Purpose: Holds information about a Vokun Salad
 */

using BleakwindBuffet.Data.Enums;

namespace BleakwindBuffet.Data.Sides
{
    /// <summary>
    /// Represents an order of Vokun Salad
    /// </summary>
    public class VokunSalad
    {
        /// <summary>
        /// Gets the price of the salad
        /// </summary>
        public double Price
        {
            get
            {
                if (Size == Size.Small) return 0.93;
                else if (Size == Size.Medium) return 1.28;
                else return 1.82;
            }
        }

        /// <summary>
        /// Gets the calories of the salad
        /// </summary>
        public uint Calories
        {
            get
            {
                if (Size == Size.Small) return 41;
                else if (Size == Size.Medium) return 52;
                else return 73;
            }
        }

        private Size size = Size.Small;
        /// <summary>
        /// Gets and sets the size of the salad
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
            return $"{Size} Vokun Salad";
        }
    }
}
