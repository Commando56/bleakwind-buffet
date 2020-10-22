/*
 * Author: Cole Kaster
 * Class name: MainWindow.xaml.cs
 * Purpose: Represents the main window of the application
 */

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
        private PaymentOptions paymentOptions;
        private RegisterDisplay registerDisplay;
        private ComboSelection comboSelection;

        /// <summary>
        /// Instantiates the MainWindow
        /// </summary>
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

        /// <summary>
        /// Opens the cash register menu
        /// </summary>
        /// <param name="order">The current order</param>
        public void OpenRegister(Order order)
        {
            registerDisplay = new RegisterDisplay(order, this);
            windowControl.Content = registerDisplay;
        }

        /// <summary>
        /// Opens a combo menu
        /// </summary>
        public void OpenCombo(Combo combo)
        {
            comboSelection = new ComboSelection(this, combo);
            windowControl.Content = comboSelection;
        }

        /// <summary>
        /// Displays the payment options
        /// </summary>
        /// <param name="order">The current order</param>
        public void OpenPaymentOptions(Order order)
        {
            paymentOptions = new PaymentOptions(order, this);
            windowControl.Content = paymentOptions;
        }

        /// <summary>
        /// Calls the OrderControl's add item
        /// </summary>
        /// <param name="item"></param>
        public void AddItemToOrder(IOrderItem item)
        {
            orderControl.AddItem(item);
        }

        /// <summary>
        /// Creates a new order
        /// </summary>
        public void NewOrder()
        {
            orderControl.NewOrder();
        }

        /// <summary>
        /// Opens a modify menu
        /// </summary>
        /// <param name="orderItem"></param>
        public void OpenModifyItem(IOrderItem orderItem, Combo combo)
        {
            customizeMenu.ModifyItem(orderItem, combo);
            windowControl.Content = customizeMenu;
        }

        /// <summary>
        /// Sets the window control to display the selection menu
        /// </summary>
        public void OpenMainMenu()
        {
            windowControl.Content = selectionMenu;
        }

        /// <summary>
        /// Sets the window control to display the entree menu
        /// </summary>
        public void OpenEntrees()
        {
            windowControl.Content = entreeSelection;
        }

        /// <summary>
        /// Sets the window control to display the side menu
        /// </summary>
        public void OpenSides()
        {
            windowControl.Content = sideSelection;
        }

        /// <summary>
        /// Sets the window control to display the drink menu
        /// </summary>
        public void OpenDrinks()
        {
            windowControl.Content = drinkSelection;
        }

        /// <summary>
        /// Sets the window control to display the customization of an item
        /// </summary>
        /// <param name="orderItem">Determines how to display the customization menu</param>
        public void CustomizeItem(IOrderItem orderItem, Combo combo)
        {
            customizeMenu.GenerateCustomizationOptions(orderItem, combo);
            windowControl.Content = customizeMenu;
        }
    }
}
