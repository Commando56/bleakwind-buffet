/*
 * Author: Cole Kaster
 * Class name: WarriorWater.cs
 * Purpose: Holds information about a Warrior Water
 */

using BleakwindBuffet.Data.Enums;
using System.Collections.Generic;

namespace BleakwindBuffet.Data.Drinks
{
    /// <summary>
    /// Represents an order of Warrior Water
    /// </summary>
    public class WarriorWater
    {
        /// <summary>
        /// Gets the price of the water
        /// </summary>
        public double Price
        {
            get => 0.00;
        }

        /// <summary>
        /// Gets the calories of the water
        /// </summary>
        public uint Calories
        {
            get => 0;
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

        private bool ice = true;
        /// <summary>
        /// Gets and sets whether it has ice
        /// </summary>
        public bool Ice
        {
            get => ice;
            set => ice = value;
        }

        private bool lemon = false;
        /// <summary>
        /// Gets and sets whether it has a lemon
        /// </summary>
        public bool Lemon
        {
            get => lemon;
            set => lemon = value;
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
                if (Lemon) instructions.Add("Add lemon");
                return instructions;
            }
        }

        /// <summary>
        /// Overrides the ToString method
        /// </summary>
        /// <returns>The name of the item</returns>
        public override string ToString()
        {
            return $"{Size} Warrior Water";
        }
    }
}
