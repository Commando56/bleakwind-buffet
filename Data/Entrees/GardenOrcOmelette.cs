/*
 * Author: Cole Kaster
 * Class name: GardenOrcOmelette.cs
 * Purpose: Holds information about a Garden Orc Omelette
 */

using System.Collections.Generic;

namespace BleakwindBuffet.Data.Entrees
{
    /// <summary>
    /// Represents an order of Garden Orc Omelette
    /// </summary>
    public class GardenOrcOmelette
    {
        /// <summary>
        /// Gets the price of the omelette
        /// </summary>
        public double Price
        {
            get => 4.57;
        }

        /// <summary>
        /// Gets the calories of the omelette
        /// </summary>
        public uint Calories
        {
            get => 404;
        }

        private bool broccoli = true;
        /// <summary>
        /// Gets and sets whether to have broccoli
        /// </summary>
        public bool Broccoli
        {
            get => broccoli;
            set => broccoli = value;
        }

        private bool mushrooms = true;
        /// <summary>
        /// Gets and sets whether to have mushrooms
        /// </summary>
        public bool Mushrooms
        {
            get => mushrooms;
            set => mushrooms = value;

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

        private bool cheddar = true;
        /// <summary>
        /// Gets and sets whether to have cheddar
        /// </summary>
        public bool Cheddar
        {
            get => cheddar;
            set => cheddar = value;
        }

        /// <summary>
        /// Represents a list on which ingredients to hold
        /// </summary>
        public List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();
                if (!Broccoli) instructions.Add("Hold broccoli");
                if (!Mushrooms) instructions.Add("Hold mushrooms");
                if (!Tomato) instructions.Add("Hold tomato");
                if (!Cheddar) instructions.Add("Hold cheddar");
                return instructions;
            }
        }

        /// <summary>
        /// Overrides the ToString method
        /// </summary>
        /// <returns>The name of the item</returns>
        public override string ToString()
        {
            return "Garden Orc Omelette";
        }
    }
}
