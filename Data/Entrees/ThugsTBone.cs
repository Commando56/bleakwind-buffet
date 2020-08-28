/*
 * Author: Cole Kaster
 * Class name: ThugsTBone.cs
 * Purpose: Holds information about a Thugs T-Bone
 */

using System.Collections.Generic;

namespace BleakwindBuffet.Data.Entrees
{
    /// <summary>
    /// Represents an order of Thugs T-Bone
    /// </summary>
    public class ThugsTBone
    {
        /// <summary>
        /// Gets the price of the T-Bone
        /// </summary>
        public double Price
        {
            get => 6.44;
        }

        /// <summary>
        /// Gets the calories of the T-Bone
        /// </summary>
        public uint Calories
        {
            get => 982;
        }

        /// <summary>
        /// Represents a list on which ingredients to hold
        /// </summary>
        public List<string> SpecialInstructions
        {
            get => new List<string>();
        }

        /// <summary>
        /// Overrides the ToString method
        /// </summary>
        /// <returns>The name of the item</returns>
        public override string ToString()
        {
            return "Thugs T-Bone";
        }
    }
}
