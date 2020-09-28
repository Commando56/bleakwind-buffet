using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using BleakwindBuffet.Data;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private SelectionMenu selectionMenu;
        private EntreeSelection entreeSelection;
        private SideSelection sideSelection;
        private DrinkSelection drinkSelection;
        private CustomizeItem customizeMenu;

        public MainWindow()
        {
            InitializeComponent();

            selectionMenu = new SelectionMenu(this);
            entreeSelection = new EntreeSelection(this);
            sideSelection = new SideSelection(this);
            drinkSelection = new DrinkSelection(this);
            customizeMenu = new CustomizeItem(this);

            windowControl.Content = selectionMenu;
        }

        public void OpenMainMenu()
        {
            windowControl.Content = selectionMenu;
        }

        public void OpenEntrees()
        {
            windowControl.Content = entreeSelection;
        }

        public void OpenSides()
        {
            windowControl.Content = sideSelection;
        }

        public void OpenDrinks()
        {
            windowControl.Content = drinkSelection;
        }

        public void CustomizeItem(IOrderItem orderItem)
        {
            customizeMenu.GenerateCustomizationOptions(orderItem);
            windowControl.Content = customizeMenu;
        }


    }
}
