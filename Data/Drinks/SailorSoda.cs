/*
 * Author: Cole Kaster
 * Class name: SailorSoda.cs
 * Purpose: Holds information about a Sailor Soda
 */

using BleakwindBuffet.Data.Enums;
using System.Collections.Generic;
using System.ComponentModel;

namespace BleakwindBuffet.Data.Drinks
{
    /// <summary>
    /// Represents an order of Sailor Soda
    /// </summary>
    public class SailorSoda : Drink, IOrderItem
    {
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Gets the description of the soda
        /// </summary>
        public string Description
        {
            get => "An old-fashioned jerked soda, carbonated water and flavored syrup poured over a bed of crushed ice.";
        }

        private double price = 1.42;
        /// <summary>
        /// Gets the price of the soda
        /// </summary>
        public override double Price
        {
            get
            {
                if (Size == Size.Small) price = 1.42;
                else if (Size == Size.Medium) price = 1.74;
                else price = 2.07;
                return price;
            }
        }

        private uint calories = 117;
        /// <summary>
        /// Gets the calories of the soda
        /// </summary>
        public override uint Calories
        {
            get
            {
                if (Size == Size.Small) calories = 117;
                else if (Size == Size.Medium) calories = 153;
                else calories = 205;
                return calories;
            }
        }

        private SodaFlavor flavor = SodaFlavor.Cherry;
        /// <summary>
        /// Gets and sets the soda's flavor
        /// </summary>
        public SodaFlavor Flavor
        {
            get => flavor;
            set
            {
                if (flavor != value)
                {
                    flavor = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Flavor"));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ToString"));
                }
            }
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

        /// <summary>
        /// Represents a list on which ingredients to hold
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();
                if (!Ice) instructions.Add("Hold ice");
                return instructions;
            }
        }

        /// <summary>
        /// Overrides the ToString method
        /// </summary>
        /// <returns>The name of the item</returns>
        public override string ToString()
        {
            return $"{Size} {Flavor} Sailor Soda";
        }
    }
}
