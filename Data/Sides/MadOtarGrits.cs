/*
 * Author: Cole Kaster
 * Class name: MadOtarGrits.cs
 * Purpose: Holds information about Mad Otar Grits
 */

using BleakwindBuffet.Data.Enums;

namespace BleakwindBuffet.Data.Sides
{
    /// <summary>
    /// Represents an order of Mad Otar Grits
    /// </summary>
    public class MadOtarGrits
    {
        /// <summary>
        /// Gets the price of the grits
        /// </summary>
        public double Price
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
        public uint Calories
        {
            get
            {
                if (Size == Size.Small) return 105;
                else if (Size == Size.Medium) return 142;
                else return 179;
            }
        }

        private Size size = Size.Small;
        /// <summary>
        /// Gets and sets the size of the grits
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
            return $"{Size} Mad Otar Grits";
        }
    }
}
