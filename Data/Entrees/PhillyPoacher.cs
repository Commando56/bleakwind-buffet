/*
 * Author: Cole Kaster
 * Class name: PhillyPoacher.cs
 * Purpose: Holds information about a Philly Poacher
 */

using System.Collections.Generic;

namespace BleakwindBuffet.Data.Entrees
{
    /// <summary>
    /// Represents an order of Philly Poacher
    /// </summary>
    public class PhillyPoacher
    {
        /// <summary>
        /// Gets the price of the sandwich
        /// </summary>
        public double Price
        {
            get => 7.23;
        }

        /// <summary>
        /// Gets the calories of the sandwich
        /// </summary>
        public uint Calories
        {
            get => 784;
        }

        private bool sirloin = true;
        /// <summary>
        /// Gets and sets whether to have sirloin
        /// </summary>
        public bool Sirloin
        {
            get => sirloin;
            set => sirloin = value;
        }

        private bool onion = true;
        /// <summary>
        /// Gets and sets whether to have onion
        /// </summary>
        public bool Onion
        {
            get => onion;
            set => onion = value;

        }

        private bool roll = true;
        /// <summary>
        /// Gets and sets whether to have a roll
        /// </summary>
        public bool Roll
        {
            get => roll;
            set => roll = value;
        }

        /// <summary>
        /// Represents a list on which ingredients to hold
        /// </summary>
        public List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();
                if (!Sirloin) instructions.Add("Hold sirloin");
                if (!Onion) instructions.Add("Hold onions");
                if (!Roll) instructions.Add("Hold roll");
                return instructions;
            }
        }

        /// <summary>
        /// Overrides the ToString method
        /// </summary>
        /// <returns>The name of the item</returns>
        public override string ToString()
        {
            return "Philly Poacher";
        }
    }
}
