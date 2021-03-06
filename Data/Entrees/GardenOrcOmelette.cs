﻿/*
 * Author: Cole Kaster
 * Class name: GardenOrcOmelette.cs
 * Purpose: Holds information about a Garden Orc Omelette
 */

using System.Collections.Generic;
using System.ComponentModel;

namespace BleakwindBuffet.Data.Entrees
{
    /// <summary>
    /// Represents an order of Garden Orc Omelette
    /// </summary>
    public class GardenOrcOmelette : Entree, IOrderItem, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Gets the description of the omelette
        /// </summary>
        public string Description
        {
            get => "Vegetarian. Two egg omelette packed with a mix of broccoli, mushrooms, and tomatoes. Topped with cheddar cheese.";
        }

        /// <summary>
        /// Gets the price of the omelette
        /// </summary>
        public override double Price
        {
            get => 4.57;
        }

        /// <summary>
        /// Gets the calories of the omelette
        /// </summary>
        public override uint Calories
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
            set
            {
                if (broccoli != value)
                {
                    broccoli = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Broccoli"));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
                }
            }
        }

        private bool mushrooms = true;
        /// <summary>
        /// Gets and sets whether to have mushrooms
        /// </summary>
        public bool Mushrooms
        {
            get => mushrooms;
            set
            {
                if (mushrooms != value)
                {
                    mushrooms = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Mushrooms"));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
                }
            }

        }

        private bool tomato = true;
        /// <summary>
        /// Gets and sets whether to have tomato
        /// </summary>
        public bool Tomato
        {
            get => tomato;
            set
            {
                if (tomato != value)
                {
                    tomato = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Tomato"));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
                }
            }
        }

        private bool cheddar = true;
        /// <summary>
        /// Gets and sets whether to have cheddar
        /// </summary>
        public bool Cheddar
        {
            get => cheddar;
            set
            {
                if (cheddar != value)
                {
                    cheddar = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Cheddar"));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
                }
            }
        }

        /// <summary>
        /// Represents a list on which ingredients to hold
        /// </summary>
        public override List<string> SpecialInstructions
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
