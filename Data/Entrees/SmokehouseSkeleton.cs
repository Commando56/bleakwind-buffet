/*
 * Author: Cole Kaster
 * Class name: SmokehouseSkeleton.cs
 * Purpose: Holds information about a Smokehouse Skeleton
 */

using System.Collections.Generic;

namespace BleakwindBuffet.Data.Entrees
{
    /// <summary>
    /// Represents an order of Smokehouse Skeleton
    /// </summary>
    public class SmokehouseSkeleton
    {
        /// <summary>
        /// Gets the price of the combo
        /// </summary>
        public double Price
        {
            get => 5.62;
        }

        /// <summary>
        /// Gets the calories of the combo
        /// </summary>
        public uint Calories
        {
            get => 602;
        }

        private bool sausageLink = true;
        /// <summary>
        /// Gets and sets whether to have a sausage link
        /// </summary>
        public bool SausageLink
        {
            get => sausageLink;
            set => sausageLink = value;
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

        private bool hashBrowns = true;
        /// <summary>
        /// Gets and sets whether to have hash browns
        /// </summary>
        public bool HashBrowns
        {
            get => hashBrowns;
            set => hashBrowns = value;
        }

        private bool pancake = true;
        /// <summary>
        /// Gets and sets whether to have pancake
        /// </summary>
        public bool Pancake
        {
            get => pancake;
            set => pancake = value;
        }

        /// <summary>
        /// Represents a list on which ingredients to hold
        /// </summary>
        public List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();
                if (!SausageLink) instructions.Add("Hold sausage");
                if (!Egg) instructions.Add("Hold eggs");
                if (!HashBrowns) instructions.Add("Hold hash browns");
                if (!Pancake) instructions.Add("Hold pancakes");
                return instructions;
            }
        }

        /// <summary>
        /// Overrides the ToString method
        /// </summary>
        /// <returns>The name of the item</returns>
        public override string ToString()
        {
            return "Smokehouse Skeleton";
        }
    }
}
