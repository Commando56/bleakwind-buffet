/*
 * Author: Cole Kaster
 * Class name: ThalmorTriple.cs
 * Purpose: Holds information about a Thalmor Triple
 */

using System.Collections.Generic;

namespace BleakwindBuffet.Data.Entrees
{
    /// <summary>
    /// Represents an order of Thalmor Triple
    /// </summary>
    public class ThalmorTriple : Entree, IOrderItem
    {
        /// <summary>
        /// Gets the price of the burger
        /// </summary>
        public override double Price
        {
            get => 8.32;
        }

        /// <summary>
        /// Gets the calories of the burger
        /// </summary>
        public override uint Calories
        {
            get => 943;
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

        private bool tomato = true;
        /// <summary>
        /// Gets and sets whether to have tomato
        /// </summary>
        public bool Tomato
        {
            get => tomato;
            set => tomato = value;
        }

        private bool lettuce = true;
        /// <summary>
        /// Gets and sets whether to have lettuce
        /// </summary>
        public bool Lettuce
        {
            get => lettuce;
            set => lettuce = value;
        }

        private bool mayo = true;
        /// <summary>
        /// Gets and sets whether to have mayo
        /// </summary>
        public bool Mayo
        {
            get => mayo;
            set => mayo = value;
        }

        private bool bacon = true;
        /// <summary>
        /// Gets and sets whether to have bacon
        /// </summary>
        public bool Bacon
        {
            get => bacon;
            set => bacon = value;
        }

        private bool egg = true;
        /// <summary>
        /// Gets and sets whether to have egg
        /// </summary>
        public bool Egg
        {
            get => egg;
            set => egg = value;
        }

        /// <summary>
        /// Represents a list on which ingredients to hold
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();
                if (!Bun) instructions.Add("Hold bun");
                if (!Ketchup) instructions.Add("Hold ketchup");
                if (!Mustard) instructions.Add("Hold mustard");
                if (!Pickle) instructions.Add("Hold pickle");
                if (!Cheese) instructions.Add("Hold cheese");
                if (!Tomato) instructions.Add("Hold tomato");
                if (!Lettuce) instructions.Add("Hold lettuce");
                if (!Mayo) instructions.Add("Hold mayo");
                if (!Bacon) instructions.Add("Hold bacon");
                if (!Egg) instructions.Add("Hold egg");
                return instructions;
            }
        }

        /// <summary>
        /// Overrides the ToString method
        /// </summary>
        /// <returns>The name of the item</returns>
        public override string ToString()
        {
            return "Thalmor Triple";
        }
    }
}
