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
        /// <summary>
        /// Gets the price of the soda
        /// </summary>
        public override double Price
        {
            get
            {
                if (Size == Size.Small) return 1.42;
                else if (Size == Size.Medium) return 1.74;
                else return 2.07;
            }
        }

        /// <summary>
        /// Gets the calories of the soda
        /// </summary>
        public override uint Calories
        {
            get
            {
                if (Size == Size.Small) return 117;
                else if (Size == Size.Medium) return 153;
                else return 205;
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
                    OnPropertiesChanged(new PropertyChangedEventArgs("Flavor"));
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
                    OnPropertiesChanged(new PropertyChangedEventArgs("Ice"));
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
