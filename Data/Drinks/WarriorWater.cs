﻿/*
 * Author: Cole Kaster
 * Class name: WarriorWater.cs
 * Purpose: Holds information about a Warrior Water
 */

using BleakwindBuffet.Data.Enums;
using System.Collections.Generic;
using System.ComponentModel;

namespace BleakwindBuffet.Data.Drinks
{
    /// <summary>
    /// Represents an order of Warrior Water
    /// </summary>
    public class WarriorWater : Drink, IOrderItem
    {
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Gets the description of the water
        /// </summary>
        public string Description
        {
            get => "It’s water. Just water.";
        }

        /// <summary>
        /// Gets the price of the water
        /// </summary>
        public override double Price
        {
            get => 0.00;
        }

        /// <summary>
        /// Gets the calories of the water
        /// </summary>
        public override uint Calories
        {
            get => 0;
        }

        private bool ice = true;
        /// <summary>
        /// Gets and sets whether it has ice
        /// </summary>
        public bool Ice
        {
            get => ice;
            set
            {
                if (ice != value)
                {
                    ice = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Ice"));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
                }
            }
        }

        private bool lemon = false;
        /// <summary>
        /// Gets and sets whether it has a lemon
        /// </summary>
        public bool Lemon
        {
            get => lemon;
            set
            {
                if (lemon != value)
                {
                    lemon = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Lemon"));
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
