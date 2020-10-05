/*
 * Author: Cole Kaster
 * Class name: Drink.cs
 * Purpose: Holds information about a drink
 */

using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace BleakwindBuffet.Data.Drinks
{
    /// <summary>
    /// A base class representing the common properties of drinks
    /// </summary>
    public abstract class Drink : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Used to invoke the PropertyChanged event handler
        /// </summary>
        /// <param name="e">The event arguments</param>
        public void OnPropertiesChanged(PropertyChangedEventArgs e)
        {
            PropertyChanged?.Invoke(this, e);
        }

        private Size size;
        /// <summary>
        /// The size of the drink
        /// </summary>
        public virtual Size Size 
        {
            get => size;
            set
            {
                if(size != value)
                {
                    size = value;
                    OnPropertiesChanged(new PropertyChangedEventArgs("Size"));
                }
            }
        }

        /// <summary>
        /// The price of the drink
        /// </summary>
        /// <value>
        /// In US dollars
        /// </value>
        public abstract double Price { get; }
        
        /// <summary>
        /// The calories of the drink
        /// </summary>
        public abstract uint Calories { get; }

        /// <summary>
        /// Special instructions to prepare the drink
        /// </summary>
        public abstract List<string> SpecialInstructions { get; }
    }
}
