using System;
using System.Collections.Generic;
using System.Text;
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
using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data.Sides;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for ComboSelection.xaml
    /// </summary>
    public partial class ComboSelection : UserControl
    {
        private Combo combo;
        private MainWindow main;

        /// <summary>
        /// Configures the binding of the menu
        /// </summary>
        public ComboSelection(MainWindow main, Combo combo)
        {
            InitializeComponent();
            this.combo = combo;
            this.DataContext = combo;
            this.main = main;

            Binding entreeBinding = new Binding("Entree");
            entreeBinding.Source = combo;
            entreeBinding.Mode = BindingMode.OneWay;
            entreeBinding.UpdateSourceTrigger = UpdateSourceTrigger.PropertyChanged;
            BindingOperations.SetBinding(entree, TextBlock.TextProperty, entreeBinding);
            Binding sideBinding = new Binding("Side");
            sideBinding.Source = combo;
            sideBinding.Mode = BindingMode.OneWay;
            sideBinding.UpdateSourceTrigger = UpdateSourceTrigger.PropertyChanged;
            BindingOperations.SetBinding(side, TextBlock.TextProperty, sideBinding);
            Binding drinkBinding = new Binding("Drink");
            drinkBinding.Source = combo;
            drinkBinding.Mode = BindingMode.OneWay;
            drinkBinding.UpdateSourceTrigger = UpdateSourceTrigger.PropertyChanged;
            BindingOperations.SetBinding(drink, TextBlock.TextProperty, drinkBinding);
        }

        private void OpenBriarheartBurger(object sender, RoutedEventArgs e)
        {
            combo.Entree = new BriarheartBurger();
            main.CustomizeItem(combo.Entree as IOrderItem, combo);
        }

        private void OpenDoubleDraugr(object sender, RoutedEventArgs e)
        {
            combo.Entree = new DoubleDraugr();
            main.CustomizeItem(combo.Entree as IOrderItem, combo);
        }

        private void OpenThalmorTriple(object sender, RoutedEventArgs e)
        {
            combo.Entree = new ThalmorTriple();
            main.CustomizeItem(combo.Entree as IOrderItem, combo);
        }

        private void OpenSmokehouseSkeleton(object sender, RoutedEventArgs e)
        {
            combo.Entree = new SmokehouseSkeleton();
            main.CustomizeItem(combo.Entree as IOrderItem, combo);
        }

        private void OpenGardenOrcOmelette(object sender, RoutedEventArgs e)
        {
            combo.Entree = new GardenOrcOmelette();
            main.CustomizeItem(combo.Entree as IOrderItem, combo);
        }

        private void OpenPhillyPoacher(object sender, RoutedEventArgs e)
        {
            combo.Entree = new PhillyPoacher();
            main.CustomizeItem(combo.Entree as IOrderItem, combo);
        }

        private void OpenThugsTBone(object sender, RoutedEventArgs e)
        {
            combo.Entree = new ThugsTBone();
        }

        private void OpenSailorSoda(object sender, RoutedEventArgs e)
        {
            combo.Drink = new SailorSoda();
            main.CustomizeItem(combo.Drink as IOrderItem, combo);
        }

        private void OpenMarkarthMilk(object sender, RoutedEventArgs e)
        {
            combo.Drink = new MarkarthMilk();
            main.CustomizeItem(combo.Drink as IOrderItem, combo);
        }

        private void OpenAretinoAppleJuice(object sender, RoutedEventArgs e)
        {
            combo.Drink = new AretinoAppleJuice();
            main.CustomizeItem(combo.Drink as IOrderItem, combo);
        }

        private void OpenCandlehearthCoffee(object sender, RoutedEventArgs e)
        {
            combo.Drink = new CandlehearthCoffee();
            main.CustomizeItem(combo.Drink as IOrderItem, combo);
        }

        private void OpenWarriorWater(object sender, RoutedEventArgs e)
        {
            combo.Drink = new WarriorWater();
            main.CustomizeItem(combo.Drink as IOrderItem, combo);
        }

        private void OpenVokunSalad(object sender, RoutedEventArgs e)
        {
            combo.Side = new VokunSalad();
            main.CustomizeItem(combo.Side as IOrderItem, combo);
        }

        private void OpenFriedMiraak(object sender, RoutedEventArgs e)
        {
            combo.Side = new FriedMiraak();
            main.CustomizeItem(combo.Side as IOrderItem, combo);
        }

        private void OpenMadOtarGrits(object sender, RoutedEventArgs e)
        {
            combo.Side = new MadOtarGrits();
            main.CustomizeItem(combo.Side as IOrderItem, combo);
        }

        private void OpenDragonbornWaffleFries(object sender, RoutedEventArgs e)
        {
            combo.Side = new DragonbornWaffleFries();
            main.CustomizeItem(combo.Side as IOrderItem, combo);
        }

        private void CancelCombo(object sender, RoutedEventArgs e)
        {
            main.OpenMainMenu();
        }

        private void CreateCombo(object sender, RoutedEventArgs e)
        {
            if(combo.Entree != null && combo.Side != null && combo.Drink != null)
            {
                main.AddItemToOrder(combo);
            }
        }

        private void ModifyEntree(object sender, RoutedEventArgs e)
        {
            if (combo.Entree is ThugsTBone)
            {
                
            }
            else
            {
                main.OpenModifyItem(combo.Entree as IOrderItem, combo);
            }
        }

        private void ModifySide(object sender, RoutedEventArgs e)
        {
            main.OpenModifyItem(combo.Side as IOrderItem, combo);
        }

        private void ModifyDrink(object sender, RoutedEventArgs e)
        {
            main.OpenModifyItem(combo.Drink as IOrderItem, combo);
        }
    }
}
