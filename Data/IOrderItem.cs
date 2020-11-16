/*
 * Author: Cole Kaster
 * Class name: IOrderItem.cs
 * Purpose: Holds information about any orderable item
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data
{
    /// <summary>
    /// Sets what data every orderable item should hold
    /// </summary>
    public interface IOrderItem
    {
        /// <summary>
        /// The description of the item
        /// </summary>
        string Description { get; }

        /// <summary>
        /// The price of the item
        /// </summary>
        /// <value>
        /// In US dollars
        /// </value>
        double Price { get; }

        /// <summary>
        /// The calories of the item
        /// </summary>
        uint Calories { get; }

        /// <summary>
        /// The instructions on how to make the item
        /// </summary>
        List<string> SpecialInstructions { get; }       
    }
}
