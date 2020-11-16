using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data.Sides;
using BleakwindBuffet.Data.Drinks;


namespace Website.Pages
{
    public class IndexModel : PageModel
    {
        /// <summary>
        /// The menu items to be displayed
        /// </summary>
        public IEnumerable<IOrderItem> MenuItems { get; set; }

        /// <summary>
        /// The terms being searched
        /// </summary>
        [BindProperty]
        public string SearchTerms { get; set; }

        /// <summary>
        /// If entrees should be searched
        /// </summary>
        [BindProperty]
        public bool Entrees { get; set; } = false;

        /// <summary>
        /// If sides should be searched
        /// </summary>
        [BindProperty]
        public bool Sides { get; set; } = false;

        /// <summary>
        /// If drinks should be searched
        /// </summary>
        [BindProperty]
        public bool Drinks { get; set; } = false;

        /// <summary>
        /// The minimum calories searched
        /// </summary>
        [BindProperty]
        public int? CaloriesMin { get; set; }

        /// <summary>
        /// The maximum calories searched
        /// </summary>
        [BindProperty]
        public int? CaloriesMax { get; set; }

        /// <summary>
        /// The minimum price searched
        /// </summary>
        [BindProperty]
        public double? PriceMin { get; set; }

        /// <summary>
        /// The maximum price searched
        /// </summary>
        [BindProperty]
        public double? PriceMax { get; set; }

        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet(string SearchTerms, bool Entree, bool Side, bool Drink, int? CaloriesMin, int? CaloriesMax, double? PriceMin, double? PriceMax)
        {
            MenuItems = GetAllMenuItems();
            
            //Search for terms in name and description of items
            if (SearchTerms != null)
            {
                List<string> searchTerms = new List<string>();
                foreach (string word in SearchTerms.Split(" ")) searchTerms.Add(word);
                List<IOrderItem> searchedItems = new List<IOrderItem>();
                foreach(string term in searchTerms)
                {
                    searchedItems.AddRange(MenuItems.Where(item => item.ToString().Contains(term, StringComparison.InvariantCultureIgnoreCase) && !searchedItems.Contains(item)));
                    searchedItems.AddRange(MenuItems.Where(item => item.Description.Contains(term, StringComparison.InvariantCultureIgnoreCase) && !searchedItems.Contains(item)));             
                }
                MenuItems = searchedItems;
            }
            
            //Filters by type
            if(Entree == true || Side == true || Drink == true)
            {
                List<IOrderItem> itemsByType = new List<IOrderItem>();
                if (Entree) 
                {
                    itemsByType.AddRange(MenuItems.Where(item => item is Entree));
                }
                if (Side)
                {
                    itemsByType.AddRange(MenuItems.Where(item => item is Side));
                }
                if (Drink)
                {
                    itemsByType.AddRange(MenuItems.Where(item => item is Drink));
                }
                MenuItems = itemsByType;
            }
            
            //Filters by calories
            if(CaloriesMin != null || CaloriesMax != null)
            {
                if (CaloriesMin == null)
                {
                    MenuItems = MenuItems.Where(item => item.Calories <= CaloriesMax);
                }
                else if (CaloriesMax == null)
                {
                    MenuItems = MenuItems.Where(item => item.Calories >= CaloriesMin);
                }
                else {
                    MenuItems = MenuItems.Where(item => item.Calories <= CaloriesMax && item.Calories >= CaloriesMin);
                }
            }
            
            //Filters by price
            if(PriceMin != null || PriceMax != null)
            {
                if(PriceMin == null)
                {
                    MenuItems = MenuItems.Where(item => item.Price <= PriceMax);
                }
                else if(PriceMax == null)
                {
                    MenuItems = MenuItems.Where(item => item.Price >= PriceMin);
                }
                else
                {
                    MenuItems = MenuItems.Where(item => item.Price <= PriceMax && item.Price >= PriceMin);
                }
            }
        }

        private IEnumerable<IOrderItem> GetAllMenuItems()
        {
            List<IOrderItem> items = new List<IOrderItem>();
            foreach (IOrderItem item in Menu.Entrees())
            {
                items.Add(item);
            }
            items.Add(new DragonbornWaffleFries());
            items.Add(new FriedMiraak());
            items.Add(new MadOtarGrits());
            items.Add(new VokunSalad());
            items.Add(new AretinoAppleJuice());
            items.Add(new CandlehearthCoffee());
            items.Add(new MarkarthMilk());
            items.Add(new SailorSoda());
            items.Add(new WarriorWater());
            return items;
        }
    }
}
