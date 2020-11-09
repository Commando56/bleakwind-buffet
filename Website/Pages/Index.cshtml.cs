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
        public bool Entrees { get; set; }

        /// <summary>
        /// If sides should be searched
        /// </summary>
        [BindProperty]
        public bool Sides { get; set; }

        /// <summary>
        /// If drinks should be searched
        /// </summary>
        [BindProperty]
        public bool Drinks { get; set; } 

        /// <summary>
        /// The minimum calories searched
        /// </summary>
        [BindProperty]
        public int CaloriesMin { get; set; }

        /// <summary>
        /// The maximum calories searched
        /// </summary>
        [BindProperty]
        public int CaloriesMax { get; set; }

        /// <summary>
        /// The minimum price searched
        /// </summary>
        [BindProperty]
        public double PriceMin { get; set; }

        /// <summary>
        /// The maximum price searched
        /// </summary>
        [BindProperty]
        public double PriceMax { get; set; }

        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet(string SearchTerms, bool Entree, bool Side, bool Drink, int CaloriesMin, int CaloriesMax, double PriceMin, double PriceMax)
        {
            MenuItems = Menu.Search(MenuItems, SearchTerms);
            MenuItems = Menu.FilterByType(MenuItems, Entree, Side, Drink);
            MenuItems = Menu.FilterByCalories(MenuItems, CaloriesMin, CaloriesMax);
            MenuItems = Menu.FilterByPrice(MenuItems, PriceMin, PriceMax);
        }
    }
}
