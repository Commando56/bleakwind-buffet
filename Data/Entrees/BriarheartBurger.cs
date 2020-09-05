/*
 * Author: Cole Kaster
 * Class name: BriarheartBurger.cs
 * Purpose: Holds information about a Briarheart Burger
 */

using System.Collections.Generic;

namespace BleakwindBuffet.Data.Entrees
{
    /// <summary>
    /// Represents an order of Briarheart Burger
    /// </summary>
    public class BriarheartBurger
    {
        /// <summary>
        /// Gets the price of the burger
        /// </summary>
        public double Price
        {
            get => 6.32;
        }

        /// <summary>
        /// Gets the calories of the burger
        /// </summary>
        public uint Calories
        {
            get => 743;
        }

        private bool bun = true;
        /// <summary>
        /// Gets and sets whether to have a bun
        /// </summary>
        public bool Bun
        {
            get => bun;
            set => bun = value;
        }

        private bool ketchup = true;
        /// <summary>
        /// Gets and sets whether to have ketchup
        /// </summary>
        public bool Ketchup
        {
            get => ketchup;
            set => ketchup = value;

        }

        private bool mustard = true;
        /// <summary>
        /// Gets and sets whether to have mustard
        /// </summary>
        public bool Mustard
        {
            get => mustard;
            set => mustard = value;
        }

        private bool pickle = true;
        /// <summary>
        /// Gets and sets whether to have pickle
        /// </summary>
        public bool Pickle
        {
            get => pickle;
            set => pickle = value;
        }

        private bool cheese = true;
        /// <summary>
        /// Gets and sets whether to have cheese
        /// </summary>
        public bool Cheese
        {
            get => cheese;
            set => cheese = value;
        }

        /// <summary>
        /// Represents a list on which ingredients to hold
        /// </summary>
        public List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();
                if (!Bun) instructions.Add("Hold bun");
                if (!Ketchup) instructions.Add("Hold ketchup");
                if (!Mustard) instructions.Add("Hold mustard");
                if (!Pickle) instructions.Add("Hold pickle");
                if (!Cheese) instructions.Add("Hold cheese");
                return instructions;
            }
        }

        /// <summary>
        /// Overrides the ToString method
        /// </summary>
        /// <returns>The name of the item</returns>
        public override string ToString()
        {
            return "Briarheart Burger";
        }
    }
}
