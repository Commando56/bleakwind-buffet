/*
 * Author: Cole Kaster
 * Class name: CustomizeItem.xaml.cs
 * Purpose: Represents the customization menu for every IOrderItem
 */

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data.Sides;
using BleakwindBuffet.Data.Drinks;
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
using BleakwindBuffet.Data.Enums;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for CustomizeItem.xaml
    /// </summary>
    public partial class CustomizeItem : UserControl
    {
        private MainWindow main;
        private string type;
        private IOrderItem thisItem;
        private bool modify = false;

        /// <summary>
        /// Instantiates a CustomizeItem
        /// </summary>
        /// <param name="main">The main window</param>
        public CustomizeItem(MainWindow main)
        {
            InitializeComponent();
            this.main = main;
        }

        private void GoBack(object sender, RoutedEventArgs e)
        {
            if (type.Equals("Entree")) main.OpenEntrees();
            else if (type.Equals("Drink")) main.OpenDrinks();
            else main.OpenSides();
            stack.Children.Clear();
            sizeBox.Visibility = Visibility.Collapsed;
            flavorBox.Visibility = Visibility.Collapsed;
            this.DataContext = null;
        }

        private void AddToOrder(object sender, RoutedEventArgs e)
        {
            if (!modify)
            {
                main.AddItemToOrder(thisItem);
            }

            if (type.Equals("Entree")) main.OpenEntrees();
            else if (type.Equals("Drink")) main.OpenDrinks();
            else main.OpenSides();
            stack.Children.Clear();
            sizeBox.Visibility = Visibility.Collapsed;
            flavorBox.Visibility = Visibility.Collapsed;
            this.DataContext = null;
        }

        /// <summary>
        /// Generates the window elements based on the provided IOrderItem
        /// </summary>
        /// <param name="item">The item of which to customize</param>
        public void GenerateCustomizationOptions(IOrderItem item)
        {
            modify = false;
            topText.FontSize = 20;
            if(item.ToString().Equals("Briarheart Burger"))
            {
                BriarheartBurger bb = new BriarheartBurger();
                this.DataContext = bb;
                topText.Text = "Customize Briarheart Burger";
                CheckBox bunBox = new CheckBox();
                bunBox.IsChecked = true;
                bunBox.Content = "Bun";
                bunBox.FontSize = 16;
                Binding bunBinding = new Binding("Bun");
                bunBinding.Source = bb;
                bunBinding.Mode = BindingMode.TwoWay;
                bunBinding.UpdateSourceTrigger = UpdateSourceTrigger.PropertyChanged;
                BindingOperations.SetBinding(bunBox, CheckBox.IsCheckedProperty, bunBinding);
                stack.Children.Add(bunBox);
                CheckBox ketchupBox = new CheckBox();
                ketchupBox.IsChecked = true;
                ketchupBox.Content = "Ketchup";
                ketchupBox.FontSize = 16;
                Binding ketchupBinding = new Binding("Ketchup");
                ketchupBinding.Source = bb;
                ketchupBinding.Mode = BindingMode.TwoWay;
                ketchupBinding.UpdateSourceTrigger = UpdateSourceTrigger.PropertyChanged;
                BindingOperations.SetBinding(ketchupBox, CheckBox.IsCheckedProperty, ketchupBinding);
                stack.Children.Add(ketchupBox);
                CheckBox mustardBox = new CheckBox();
                mustardBox.IsChecked = true;
                mustardBox.Content = "Mustard";
                mustardBox.FontSize = 16;
                Binding mustardBinding = new Binding("Mustard");
                mustardBinding.Source = bb;
                mustardBinding.Mode = BindingMode.TwoWay;
                mustardBinding.UpdateSourceTrigger = UpdateSourceTrigger.PropertyChanged;
                BindingOperations.SetBinding(mustardBox, CheckBox.IsCheckedProperty, mustardBinding);
                stack.Children.Add(mustardBox);
                CheckBox pickleBox = new CheckBox();
                pickleBox.IsChecked = true;
                pickleBox.Content = "Pickle";
                pickleBox.FontSize = 16;
                Binding pickleBinding = new Binding("Pickle");
                pickleBinding.Source = bb;
                pickleBinding.Mode = BindingMode.TwoWay;
                pickleBinding.UpdateSourceTrigger = UpdateSourceTrigger.PropertyChanged;
                BindingOperations.SetBinding(pickleBox, CheckBox.IsCheckedProperty, pickleBinding);
                stack.Children.Add(pickleBox);
                CheckBox cheeseBox = new CheckBox();
                cheeseBox.IsChecked = true;
                cheeseBox.Content = "Cheese";
                cheeseBox.FontSize = 16;
                Binding cheeseBinding = new Binding("Cheese");
                cheeseBinding.Source = bb;
                cheeseBinding.Mode = BindingMode.TwoWay;
                cheeseBinding.UpdateSourceTrigger = UpdateSourceTrigger.PropertyChanged;
                BindingOperations.SetBinding(cheeseBox, CheckBox.IsCheckedProperty, cheeseBinding);
                stack.Children.Add(cheeseBox);
                type = "Entree";
                thisItem = bb;
            }
            else if(item.ToString().Equals("Double Draugr"))
            {
                DoubleDraugr dd = new DoubleDraugr();
                this.DataContext = dd;
                topText.Text = "Customize Double Draugr";
                CheckBox bunBox = new CheckBox();
                bunBox.IsChecked = true;
                bunBox.Content = "Bun";
                bunBox.FontSize = 16;
                Binding bunBinding = new Binding("Bun");
                bunBinding.Source = dd;
                bunBinding.Mode = BindingMode.TwoWay;
                bunBinding.UpdateSourceTrigger = UpdateSourceTrigger.PropertyChanged;
                BindingOperations.SetBinding(bunBox, CheckBox.IsCheckedProperty, bunBinding);
                stack.Children.Add(bunBox);
                CheckBox ketchupBox = new CheckBox();
                ketchupBox.IsChecked = true;
                ketchupBox.Content = "Ketchup";
                ketchupBox.FontSize = 16;
                Binding ketchupBinding = new Binding("Ketchup");
                ketchupBinding.Source = dd;
                ketchupBinding.Mode = BindingMode.TwoWay;
                ketchupBinding.UpdateSourceTrigger = UpdateSourceTrigger.PropertyChanged;
                BindingOperations.SetBinding(ketchupBox, CheckBox.IsCheckedProperty, ketchupBinding);
                stack.Children.Add(ketchupBox);
                CheckBox mustardBox = new CheckBox();
                mustardBox.IsChecked = true;
                mustardBox.Content = "Mustard";
                mustardBox.FontSize = 16;
                Binding mustardBinding = new Binding("Mustard");
                mustardBinding.Source = dd;
                mustardBinding.Mode = BindingMode.TwoWay;
                mustardBinding.UpdateSourceTrigger = UpdateSourceTrigger.PropertyChanged;
                BindingOperations.SetBinding(mustardBox, CheckBox.IsCheckedProperty, mustardBinding);
                stack.Children.Add(mustardBox);
                CheckBox pickleBox = new CheckBox();
                pickleBox.IsChecked = true;
                pickleBox.Content = "Pickle";
                pickleBox.FontSize = 16;
                Binding pickleBinding = new Binding("Pickle");
                pickleBinding.Source = dd;
                pickleBinding.Mode = BindingMode.TwoWay;
                pickleBinding.UpdateSourceTrigger = UpdateSourceTrigger.PropertyChanged;
                BindingOperations.SetBinding(pickleBox, CheckBox.IsCheckedProperty, pickleBinding);
                stack.Children.Add(pickleBox);
                CheckBox cheeseBox = new CheckBox();
                cheeseBox.IsChecked = true;
                cheeseBox.Content = "Cheese";
                cheeseBox.FontSize = 16;
                Binding cheeseBinding = new Binding("Cheese");
                cheeseBinding.Source = dd;
                cheeseBinding.Mode = BindingMode.TwoWay;
                cheeseBinding.UpdateSourceTrigger = UpdateSourceTrigger.PropertyChanged;
                BindingOperations.SetBinding(cheeseBox, CheckBox.IsCheckedProperty, cheeseBinding);
                stack.Children.Add(cheeseBox);
                CheckBox tomatoBox = new CheckBox();
                tomatoBox.IsChecked = true;
                tomatoBox.Content = "Tomato";
                tomatoBox.FontSize = 16;
                Binding tomatoBinding = new Binding("Tomato");
                tomatoBinding.Source = dd;
                tomatoBinding.Mode = BindingMode.TwoWay;
                tomatoBinding.UpdateSourceTrigger = UpdateSourceTrigger.PropertyChanged;
                BindingOperations.SetBinding(tomatoBox, CheckBox.IsCheckedProperty, tomatoBinding);
                stack.Children.Add(tomatoBox);
                CheckBox lettuceBox = new CheckBox();
                lettuceBox.IsChecked = true;
                lettuceBox.Content = "Lettuce";
                lettuceBox.FontSize = 16;
                Binding lettuceBinding = new Binding("Lettuce");
                lettuceBinding.Source = dd;
                lettuceBinding.Mode = BindingMode.TwoWay;
                lettuceBinding.UpdateSourceTrigger = UpdateSourceTrigger.PropertyChanged;
                BindingOperations.SetBinding(lettuceBox, CheckBox.IsCheckedProperty, lettuceBinding);
                stack.Children.Add(lettuceBox);
                CheckBox mayoBox = new CheckBox();
                mayoBox.IsChecked = true;
                mayoBox.Content = "Mayo";
                mayoBox.FontSize = 16;
                Binding mayoBinding = new Binding("Mayo");
                mayoBinding.Source = dd;
                mayoBinding.Mode = BindingMode.TwoWay;
                mayoBinding.UpdateSourceTrigger = UpdateSourceTrigger.PropertyChanged;
                BindingOperations.SetBinding(mayoBox, CheckBox.IsCheckedProperty, mayoBinding);
                stack.Children.Add(mayoBox);
                type = "Entree";
                thisItem = dd;
            }
            else if (item.ToString().Equals("Thalmor Triple"))
            {
                ThalmorTriple tt = new ThalmorTriple();
                this.DataContext = tt;
                topText.Text = "Customize Thalmor Triple";
                CheckBox bunBox = new CheckBox();
                bunBox.IsChecked = true;
                bunBox.Content = "Bun";
                bunBox.FontSize = 16;
                Binding bunBinding = new Binding("Bun");
                bunBinding.Source = tt;
                bunBinding.Mode = BindingMode.TwoWay;
                bunBinding.UpdateSourceTrigger = UpdateSourceTrigger.PropertyChanged;
                BindingOperations.SetBinding(bunBox, CheckBox.IsCheckedProperty, bunBinding);
                stack.Children.Add(bunBox);
                CheckBox ketchupBox = new CheckBox();
                ketchupBox.IsChecked = true;
                ketchupBox.Content = "Ketchup";
                ketchupBox.FontSize = 16;
                Binding ketchupBinding = new Binding("Ketchup");
                ketchupBinding.Source = tt;
                ketchupBinding.Mode = BindingMode.TwoWay;
                ketchupBinding.UpdateSourceTrigger = UpdateSourceTrigger.PropertyChanged;
                BindingOperations.SetBinding(ketchupBox, CheckBox.IsCheckedProperty, ketchupBinding);
                stack.Children.Add(ketchupBox);
                CheckBox mustardBox = new CheckBox();
                mustardBox.IsChecked = true;
                mustardBox.Content = "Mustard";
                mustardBox.FontSize = 16;
                Binding mustardBinding = new Binding("Mustard");
                mustardBinding.Source = tt;
                mustardBinding.Mode = BindingMode.TwoWay;
                mustardBinding.UpdateSourceTrigger = UpdateSourceTrigger.PropertyChanged;
                BindingOperations.SetBinding(mustardBox, CheckBox.IsCheckedProperty, mustardBinding);
                stack.Children.Add(mustardBox);
                CheckBox pickleBox = new CheckBox();
                pickleBox.IsChecked = true;
                pickleBox.Content = "Pickle";
                pickleBox.FontSize = 16;
                Binding pickleBinding = new Binding("Pickle");
                pickleBinding.Source = tt;
                pickleBinding.Mode = BindingMode.TwoWay;
                pickleBinding.UpdateSourceTrigger = UpdateSourceTrigger.PropertyChanged;
                BindingOperations.SetBinding(pickleBox, CheckBox.IsCheckedProperty, pickleBinding);
                stack.Children.Add(pickleBox);
                CheckBox cheeseBox = new CheckBox();
                cheeseBox.IsChecked = true;
                cheeseBox.Content = "Cheese";
                cheeseBox.FontSize = 16;
                Binding cheeseBinding = new Binding("Cheese");
                cheeseBinding.Source = tt;
                cheeseBinding.Mode = BindingMode.TwoWay;
                cheeseBinding.UpdateSourceTrigger = UpdateSourceTrigger.PropertyChanged;
                BindingOperations.SetBinding(cheeseBox, CheckBox.IsCheckedProperty, cheeseBinding);
                stack.Children.Add(cheeseBox);
                CheckBox tomatoBox = new CheckBox();
                tomatoBox.IsChecked = true;
                tomatoBox.Content = "Tomato";
                tomatoBox.FontSize = 16;
                Binding tomatoBinding = new Binding("Tomato");
                tomatoBinding.Source = tt;
                tomatoBinding.Mode = BindingMode.TwoWay;
                tomatoBinding.UpdateSourceTrigger = UpdateSourceTrigger.PropertyChanged;
                BindingOperations.SetBinding(tomatoBox, CheckBox.IsCheckedProperty, tomatoBinding);
                stack.Children.Add(tomatoBox);
                CheckBox lettuceBox = new CheckBox();
                lettuceBox.IsChecked = true;
                lettuceBox.Content = "Lettuce";
                lettuceBox.FontSize = 16;
                Binding lettuceBinding = new Binding("Lettuce");
                lettuceBinding.Source = tt;
                lettuceBinding.Mode = BindingMode.TwoWay;
                lettuceBinding.UpdateSourceTrigger = UpdateSourceTrigger.PropertyChanged;
                BindingOperations.SetBinding(lettuceBox, CheckBox.IsCheckedProperty, lettuceBinding);
                stack.Children.Add(lettuceBox);
                CheckBox mayoBox = new CheckBox();
                mayoBox.IsChecked = true;
                mayoBox.Content = "Mayo";
                mayoBox.FontSize = 16;
                Binding mayoBinding = new Binding("Mayo");
                mayoBinding.Source = tt;
                mayoBinding.Mode = BindingMode.TwoWay;
                mayoBinding.UpdateSourceTrigger = UpdateSourceTrigger.PropertyChanged;
                BindingOperations.SetBinding(mayoBox, CheckBox.IsCheckedProperty, mayoBinding);
                stack.Children.Add(mayoBox);
                CheckBox baconBox = new CheckBox();
                baconBox.IsChecked = true;
                baconBox.Content = "Bacon";
                baconBox.FontSize = 16;
                Binding baconBinding = new Binding("Bacon");
                baconBinding.Source = tt;
                baconBinding.Mode = BindingMode.TwoWay;
                baconBinding.UpdateSourceTrigger = UpdateSourceTrigger.PropertyChanged;
                BindingOperations.SetBinding(baconBox, CheckBox.IsCheckedProperty, baconBinding);
                stack.Children.Add(baconBox);
                CheckBox eggBox = new CheckBox();
                eggBox.IsChecked = true;
                eggBox.Content = "Egg";
                eggBox.FontSize = 16;
                Binding eggBinding = new Binding("Egg");
                eggBinding.Source = tt;
                eggBinding.Mode = BindingMode.TwoWay;
                eggBinding.UpdateSourceTrigger = UpdateSourceTrigger.PropertyChanged;
                BindingOperations.SetBinding(eggBox, CheckBox.IsCheckedProperty, eggBinding);
                stack.Children.Add(eggBox);
                type = "Entree";
                thisItem = tt;
            }
            else if (item.ToString().Equals("Smokehouse Skeleton"))
            {
                SmokehouseSkeleton ss = new SmokehouseSkeleton();
                this.DataContext = ss;
                topText.Text = "Customize Smokehouse Skeleton";
                CheckBox sausageBox = new CheckBox();
                sausageBox.IsChecked = true;
                sausageBox.Content = "Sausage";
                sausageBox.FontSize = 16;
                Binding sausageBinding = new Binding("Sausage");
                sausageBinding.Source = ss;
                sausageBinding.Mode = BindingMode.TwoWay;
                sausageBinding.UpdateSourceTrigger = UpdateSourceTrigger.PropertyChanged;
                BindingOperations.SetBinding(sausageBox, CheckBox.IsCheckedProperty, sausageBinding);
                stack.Children.Add(sausageBox);
                CheckBox eggBox = new CheckBox();
                eggBox.IsChecked = true;
                eggBox.Content = "Egg";
                eggBox.FontSize = 16;
                Binding eggBinding = new Binding("Egg");
                eggBinding.Source = ss;
                eggBinding.Mode = BindingMode.TwoWay;
                eggBinding.UpdateSourceTrigger = UpdateSourceTrigger.PropertyChanged;
                BindingOperations.SetBinding(eggBox, CheckBox.IsCheckedProperty, eggBinding);
                stack.Children.Add(eggBox);
                CheckBox hashBox = new CheckBox();
                hashBox.IsChecked = true;
                hashBox.Content = "Hashbrowns";
                hashBox.FontSize = 16;
                Binding hashBinding = new Binding("HashBrowns");
                hashBinding.Source = ss;
                hashBinding.Mode = BindingMode.TwoWay;
                hashBinding.UpdateSourceTrigger = UpdateSourceTrigger.PropertyChanged;
                BindingOperations.SetBinding(hashBox, CheckBox.IsCheckedProperty, hashBinding);
                stack.Children.Add(hashBox);
                CheckBox pancakeBox = new CheckBox();
                pancakeBox.IsChecked = true;
                pancakeBox.Content = "Pancakes";
                pancakeBox.FontSize = 16;
                Binding pancakeBinding = new Binding("Pancake");
                pancakeBinding.Source = ss;
                pancakeBinding.Mode = BindingMode.TwoWay;
                pancakeBinding.UpdateSourceTrigger = UpdateSourceTrigger.PropertyChanged;
                BindingOperations.SetBinding(pancakeBox, CheckBox.IsCheckedProperty, pancakeBinding);
                stack.Children.Add(pancakeBox);
                type = "Entree";
                thisItem = ss;
            }
            else if (item.ToString().Equals("Garden Orc Omelette"))
            {
                GardenOrcOmelette goo = new GardenOrcOmelette();
                this.DataContext = goo;
                topText.Text = "Customize Garden Orc Omelette";
                CheckBox broccoliBox = new CheckBox();
                broccoliBox.IsChecked = true;
                broccoliBox.Content = "Broccoli";
                broccoliBox.FontSize = 16;
                Binding broccoliBinding = new Binding("Broccoli");
                broccoliBinding.Source = goo;
                broccoliBinding.Mode = BindingMode.TwoWay;
                broccoliBinding.UpdateSourceTrigger = UpdateSourceTrigger.PropertyChanged;
                BindingOperations.SetBinding(broccoliBox, CheckBox.IsCheckedProperty, broccoliBinding);
                stack.Children.Add(broccoliBox);
                CheckBox mushroomBox = new CheckBox();
                mushroomBox.IsChecked = true;
                mushroomBox.Content = "Mushrooms";
                mushroomBox.FontSize = 16;
                Binding mushroomBinding = new Binding("Mushrooms");
                mushroomBinding.Source = goo;
                mushroomBinding.Mode = BindingMode.TwoWay;
                mushroomBinding.UpdateSourceTrigger = UpdateSourceTrigger.PropertyChanged;
                BindingOperations.SetBinding(mushroomBox, CheckBox.IsCheckedProperty, mushroomBinding);
                stack.Children.Add(mushroomBox);
                CheckBox tomatoBox = new CheckBox();
                tomatoBox.IsChecked = true;
                tomatoBox.Content = "Tomato";
                tomatoBox.FontSize = 16;
                Binding tomatoBinding = new Binding("Tomato");
                tomatoBinding.Source = goo;
                tomatoBinding.Mode = BindingMode.TwoWay;
                tomatoBinding.UpdateSourceTrigger = UpdateSourceTrigger.PropertyChanged;
                BindingOperations.SetBinding(tomatoBox, CheckBox.IsCheckedProperty, tomatoBinding);
                stack.Children.Add(tomatoBox);
                CheckBox cheddarBox = new CheckBox();
                cheddarBox.IsChecked = true;
                cheddarBox.Content = "Cheddar";
                cheddarBox.FontSize = 16;
                Binding cheddarBinding = new Binding("Cheddar");
                cheddarBinding.Source = goo;
                cheddarBinding.Mode = BindingMode.TwoWay;
                cheddarBinding.UpdateSourceTrigger = UpdateSourceTrigger.PropertyChanged;
                BindingOperations.SetBinding(cheddarBox, CheckBox.IsCheckedProperty, cheddarBinding);
                stack.Children.Add(cheddarBox);
                type = "Entree";
                thisItem = goo;
            }
            else if (item.ToString().Equals("Philly Poacher"))
            {
                PhillyPoacher pp = new PhillyPoacher();
                this.DataContext = pp;
                topText.Text = "Customize Philly Poacher";
                CheckBox sirloinBox = new CheckBox();
                sirloinBox.IsChecked = true;
                sirloinBox.Content = "Sirloin";
                sirloinBox.FontSize = 16;
                Binding sirloinBinding = new Binding("Sirloin");
                sirloinBinding.Source = pp;
                sirloinBinding.Mode = BindingMode.TwoWay;
                sirloinBinding.UpdateSourceTrigger = UpdateSourceTrigger.PropertyChanged;
                BindingOperations.SetBinding(sirloinBox, CheckBox.IsCheckedProperty, sirloinBinding);
                stack.Children.Add(sirloinBox);
                CheckBox onionBox = new CheckBox();
                onionBox.IsChecked = true;
                onionBox.Content = "Onion";
                onionBox.FontSize = 16;
                Binding onionBinding = new Binding("Onion");
                onionBinding.Source = pp;
                onionBinding.Mode = BindingMode.TwoWay;
                onionBinding.UpdateSourceTrigger = UpdateSourceTrigger.PropertyChanged;
                BindingOperations.SetBinding(onionBox, CheckBox.IsCheckedProperty, onionBinding);
                stack.Children.Add(onionBox);
                CheckBox rollBox = new CheckBox();
                rollBox.IsChecked = true;
                rollBox.Content = "Roll";
                rollBox.FontSize = 16;
                Binding rollBinding = new Binding("Roll");
                rollBinding.Source = pp;
                rollBinding.Mode = BindingMode.TwoWay;
                rollBinding.UpdateSourceTrigger = UpdateSourceTrigger.PropertyChanged;
                BindingOperations.SetBinding(rollBox, CheckBox.IsCheckedProperty, rollBinding);
                type = "Entree";
                stack.Children.Add(rollBox);
                thisItem = pp;
            }
            else if (item.ToString().Contains("Vokun Salad"))
            {
                VokunSalad vs = new VokunSalad();
                this.DataContext = vs;
                topText.Text = "Customize Vokun Salad";
                sizeBox.Visibility = Visibility.Visible;

                Binding sizeBinding = new Binding("Size");
                sizeBinding.Source = vs;
                sizeBinding.Mode = BindingMode.TwoWay;
                sizeBinding.UpdateSourceTrigger = UpdateSourceTrigger.PropertyChanged;
                BindingOperations.SetBinding(sizeBox, ComboBox.SelectedValueProperty, sizeBinding);
                
                type = "Side";
                thisItem = vs;
            }
            else if(item.ToString().Contains("Fried Miraak"))
            {
                FriedMiraak fm = new FriedMiraak();
                this.DataContext = fm;
                topText.Text = "Customize Fried Miraak";
                sizeBox.Visibility = Visibility.Visible;
                Binding sizeBinding = new Binding("Size");
                sizeBinding.Source = fm;
                sizeBinding.Mode = BindingMode.TwoWay;
                sizeBinding.UpdateSourceTrigger = UpdateSourceTrigger.PropertyChanged;
                BindingOperations.SetBinding(sizeBox, ComboBox.SelectedValueProperty, sizeBinding);
                type = "Side";
                thisItem = fm;
            }
            else if(item.ToString().Contains("Mad Otar Grits"))
            {
                MadOtarGrits mog = new MadOtarGrits();
                this.DataContext = mog;
                topText.Text = "Customize Mad Otar Grits";
                sizeBox.Visibility = Visibility.Visible;
                Binding sizeBinding = new Binding("Size");
                sizeBinding.Source = mog;
                sizeBinding.Mode = BindingMode.TwoWay;
                sizeBinding.UpdateSourceTrigger = UpdateSourceTrigger.PropertyChanged;
                BindingOperations.SetBinding(sizeBox, ComboBox.SelectedValueProperty, sizeBinding);
                type = "Side";
                thisItem = mog;
            }
            else if(item.ToString().Contains("Dragonborn Waffle Fries"))
            {
                DragonbornWaffleFries dwf = new DragonbornWaffleFries();
                this.DataContext = dwf;
                topText.Text = "Customize Dragonborn Waffle Fries";
                sizeBox.Visibility = Visibility.Visible;
                Binding sizeBinding = new Binding("Size");
                sizeBinding.Source = dwf;
                sizeBinding.Mode = BindingMode.TwoWay;
                sizeBinding.UpdateSourceTrigger = UpdateSourceTrigger.PropertyChanged;
                BindingOperations.SetBinding(sizeBox, ComboBox.SelectedValueProperty, sizeBinding);
                type = "Side";
                thisItem = dwf;
            }
            else if (item.ToString().Contains("Sailor Soda"))
            {
                SailorSoda ss = new SailorSoda();
                this.DataContext = ss;
                topText.Text = "Customize Sailor Soda";
                sizeBox.Visibility = Visibility.Visible;
                Binding sizeBinding = new Binding("Size");
                sizeBinding.Source = ss;
                sizeBinding.Mode = BindingMode.TwoWay;
                sizeBinding.UpdateSourceTrigger = UpdateSourceTrigger.PropertyChanged;
                BindingOperations.SetBinding(sizeBox, ComboBox.SelectedValueProperty, sizeBinding);
                flavorBox.Visibility = Visibility.Visible;
                Binding flavorBinding = new Binding("Flavor");
                flavorBinding.Source = ss;
                flavorBinding.Mode = BindingMode.TwoWay;
                flavorBinding.UpdateSourceTrigger = UpdateSourceTrigger.PropertyChanged;
                BindingOperations.SetBinding(flavorBox, ComboBox.SelectedValueProperty, flavorBinding);
                CheckBox iceBox = new CheckBox();
                iceBox.IsChecked = true;
                iceBox.Content = "Ice";
                iceBox.FontSize = 20;
                Binding iceBinding = new Binding("Ice");
                iceBinding.Source = ss;
                iceBinding.Mode = BindingMode.TwoWay;
                iceBinding.UpdateSourceTrigger = UpdateSourceTrigger.PropertyChanged;
                BindingOperations.SetBinding(iceBox, CheckBox.IsCheckedProperty, iceBinding);
                stack.Children.Add(iceBox);
                type = "Drink";
                thisItem = ss;
            }
            else if (item.ToString().Contains("Markarth Milk"))
            {
                MarkarthMilk mm = new MarkarthMilk();
                this.DataContext = mm;
                topText.Text = "Customize Markarth Milk";
                sizeBox.Visibility = Visibility.Visible;
                Binding sizeBinding = new Binding("Size");
                sizeBinding.Source = mm;
                sizeBinding.Mode = BindingMode.TwoWay;
                sizeBinding.UpdateSourceTrigger = UpdateSourceTrigger.PropertyChanged;
                BindingOperations.SetBinding(sizeBox, ComboBox.SelectedValueProperty, sizeBinding);
                CheckBox iceBox = new CheckBox();
                iceBox.IsChecked = false;
                iceBox.Content = "Ice";
                iceBox.FontSize = 20;
                Binding iceBinding = new Binding("Ice");
                iceBinding.Source = mm;
                iceBinding.Mode = BindingMode.TwoWay;
                iceBinding.UpdateSourceTrigger = UpdateSourceTrigger.PropertyChanged;
                BindingOperations.SetBinding(iceBox, CheckBox.IsCheckedProperty, iceBinding);
                stack.Children.Add(iceBox);
                type = "Drink";
                thisItem = mm;
            }
            else if (item.ToString().Contains("Aretino Apple Juice"))
            {
                AretinoAppleJuice aj = new AretinoAppleJuice();
                this.DataContext = aj;
                topText.Text = "Customize Aretino Apple Juice";
                sizeBox.Visibility = Visibility.Visible;
                Binding sizeBinding = new Binding("Size");
                sizeBinding.Source = aj;
                sizeBinding.Mode = BindingMode.TwoWay;
                sizeBinding.UpdateSourceTrigger = UpdateSourceTrigger.PropertyChanged;
                BindingOperations.SetBinding(sizeBox, ComboBox.SelectedValueProperty, sizeBinding);
                CheckBox iceBox = new CheckBox();
                iceBox.IsChecked = false;
                iceBox.Content = "Ice";
                iceBox.FontSize = 20;
                Binding iceBinding = new Binding("Ice");
                iceBinding.Source = aj;
                iceBinding.Mode = BindingMode.TwoWay;
                iceBinding.UpdateSourceTrigger = UpdateSourceTrigger.PropertyChanged;
                BindingOperations.SetBinding(iceBox, CheckBox.IsCheckedProperty, iceBinding);
                stack.Children.Add(iceBox);
                type = "Drink";
                thisItem = aj;
            }
            else if (item.ToString().Contains("Candlehearth Coffee"))
            {
                CandlehearthCoffee cc = new CandlehearthCoffee();
                this.DataContext = cc;
                topText.Text = "Customize Candlehearth Coffee";
                sizeBox.Visibility = Visibility.Visible;
                Binding sizeBinding = new Binding("Size");
                sizeBinding.Source = cc;
                sizeBinding.Mode = BindingMode.TwoWay;
                sizeBinding.UpdateSourceTrigger = UpdateSourceTrigger.PropertyChanged;
                BindingOperations.SetBinding(sizeBox, ComboBox.SelectedValueProperty, sizeBinding);
                CheckBox iceBox = new CheckBox();
                iceBox.IsChecked = false;
                iceBox.Content = "Ice";
                iceBox.FontSize = 20;
                Binding iceBinding = new Binding("Ice");
                iceBinding.Source = cc;
                iceBinding.Mode = BindingMode.TwoWay;
                iceBinding.UpdateSourceTrigger = UpdateSourceTrigger.PropertyChanged;
                BindingOperations.SetBinding(iceBox, CheckBox.IsCheckedProperty, iceBinding);
                stack.Children.Add(iceBox);
                CheckBox creamBox = new CheckBox();
                creamBox.IsChecked = false;
                creamBox.Content = "Cream";
                creamBox.FontSize = 20;
                Binding creamBinding = new Binding("Room For Cream");
                creamBinding.Source = cc;
                creamBinding.Mode = BindingMode.TwoWay;
                creamBinding.UpdateSourceTrigger = UpdateSourceTrigger.PropertyChanged;
                BindingOperations.SetBinding(creamBox, CheckBox.IsCheckedProperty, creamBinding);
                stack.Children.Add(creamBox);
                CheckBox decafBox = new CheckBox();
                decafBox.IsChecked = false;
                decafBox.Content = "Decaf";
                decafBox.FontSize = 20;
                Binding decafBinding = new Binding("Decaf");
                decafBinding.Source = cc;
                decafBinding.Mode = BindingMode.TwoWay;
                decafBinding.UpdateSourceTrigger = UpdateSourceTrigger.PropertyChanged;
                BindingOperations.SetBinding(decafBox, CheckBox.IsCheckedProperty, decafBinding);
                stack.Children.Add(decafBox);
                type = "Drink";
                thisItem = cc;
            }
            else if (item.ToString().Contains("Warrior Water"))
            {
                WarriorWater ww = new WarriorWater();
                this.DataContext = ww;
                topText.Text = "Customize Warrior Water";
                sizeBox.Visibility = Visibility.Visible;
                Binding sizeBinding = new Binding("Size");
                sizeBinding.Source = ww;
                sizeBinding.Mode = BindingMode.TwoWay;
                sizeBinding.UpdateSourceTrigger = UpdateSourceTrigger.PropertyChanged;
                BindingOperations.SetBinding(sizeBox, ComboBox.SelectedValueProperty, sizeBinding);
                CheckBox iceBox = new CheckBox();
                iceBox.IsChecked = true;
                iceBox.Content = "Ice";
                iceBox.FontSize = 20;
                Binding iceBinding = new Binding("Ice");
                iceBinding.Source = ww;
                iceBinding.Mode = BindingMode.TwoWay;
                iceBinding.UpdateSourceTrigger = UpdateSourceTrigger.PropertyChanged;
                BindingOperations.SetBinding(iceBox, CheckBox.IsCheckedProperty, iceBinding);
                stack.Children.Add(iceBox);
                CheckBox lemonBox = new CheckBox();
                lemonBox.IsChecked = false;
                lemonBox.Content = "Lemon";
                lemonBox.FontSize = 20;
                Binding lemonBinding = new Binding("Lemon");
                lemonBinding.Source = ww;
                lemonBinding.Mode = BindingMode.TwoWay;
                lemonBinding.UpdateSourceTrigger = UpdateSourceTrigger.PropertyChanged;
                BindingOperations.SetBinding(lemonBox, CheckBox.IsCheckedProperty, lemonBinding);
                stack.Children.Add(lemonBox);
                type = "Drink";
                thisItem = ww;
            }
        }

        /// <summary>
        /// Opens the menu with an already existing IOrderItem
        /// </summary>
        /// <param name="item">The item being modified</param>
        public void ModifyItem(IOrderItem item)
        {
            modify = true;
            topText.FontSize = 20;
            if (item.ToString().Equals("Briarheart Burger"))
            {
                BriarheartBurger bb = item as BriarheartBurger;
                this.DataContext = bb;
                topText.Text = "Customize Briarheart Burger";
                CheckBox bunBox = new CheckBox();
                bunBox.IsChecked = true;
                bunBox.Content = "Bun";
                bunBox.FontSize = 16;
                Binding bunBinding = new Binding("Bun");
                bunBinding.Source = bb;
                bunBinding.Mode = BindingMode.TwoWay;
                bunBinding.UpdateSourceTrigger = UpdateSourceTrigger.PropertyChanged;
                BindingOperations.SetBinding(bunBox, CheckBox.IsCheckedProperty, bunBinding);
                stack.Children.Add(bunBox);
                CheckBox ketchupBox = new CheckBox();
                ketchupBox.IsChecked = true;
                ketchupBox.Content = "Ketchup";
                ketchupBox.FontSize = 16;
                Binding ketchupBinding = new Binding("Ketchup");
                ketchupBinding.Source = bb;
                ketchupBinding.Mode = BindingMode.TwoWay;
                ketchupBinding.UpdateSourceTrigger = UpdateSourceTrigger.PropertyChanged;
                BindingOperations.SetBinding(ketchupBox, CheckBox.IsCheckedProperty, ketchupBinding);
                stack.Children.Add(ketchupBox);
                CheckBox mustardBox = new CheckBox();
                mustardBox.IsChecked = true;
                mustardBox.Content = "Mustard";
                mustardBox.FontSize = 16;
                Binding mustardBinding = new Binding("Mustard");
                mustardBinding.Source = bb;
                mustardBinding.Mode = BindingMode.TwoWay;
                mustardBinding.UpdateSourceTrigger = UpdateSourceTrigger.PropertyChanged;
                BindingOperations.SetBinding(mustardBox, CheckBox.IsCheckedProperty, mustardBinding);
                stack.Children.Add(mustardBox);
                CheckBox pickleBox = new CheckBox();
                pickleBox.IsChecked = true;
                pickleBox.Content = "Pickle";
                pickleBox.FontSize = 16;
                Binding pickleBinding = new Binding("Pickle");
                pickleBinding.Source = bb;
                pickleBinding.Mode = BindingMode.TwoWay;
                pickleBinding.UpdateSourceTrigger = UpdateSourceTrigger.PropertyChanged;
                BindingOperations.SetBinding(pickleBox, CheckBox.IsCheckedProperty, pickleBinding);
                stack.Children.Add(pickleBox);
                CheckBox cheeseBox = new CheckBox();
                cheeseBox.IsChecked = true;
                cheeseBox.Content = "Cheese";
                cheeseBox.FontSize = 16;
                Binding cheeseBinding = new Binding("Cheese");
                cheeseBinding.Source = bb;
                cheeseBinding.Mode = BindingMode.TwoWay;
                cheeseBinding.UpdateSourceTrigger = UpdateSourceTrigger.PropertyChanged;
                BindingOperations.SetBinding(cheeseBox, CheckBox.IsCheckedProperty, cheeseBinding);
                stack.Children.Add(cheeseBox);
                type = "Entree";
                thisItem = bb;
            }
            else if (item.ToString().Equals("Double Draugr"))
            {
                DoubleDraugr dd = item as DoubleDraugr;
                this.DataContext = dd;
                topText.Text = "Customize Double Draugr";
                CheckBox bunBox = new CheckBox();
                bunBox.IsChecked = true;
                bunBox.Content = "Bun";
                bunBox.FontSize = 16;
                Binding bunBinding = new Binding("Bun");
                bunBinding.Source = dd;
                bunBinding.Mode = BindingMode.TwoWay;
                bunBinding.UpdateSourceTrigger = UpdateSourceTrigger.PropertyChanged;
                BindingOperations.SetBinding(bunBox, CheckBox.IsCheckedProperty, bunBinding);
                stack.Children.Add(bunBox);
                CheckBox ketchupBox = new CheckBox();
                ketchupBox.IsChecked = true;
                ketchupBox.Content = "Ketchup";
                ketchupBox.FontSize = 16;
                Binding ketchupBinding = new Binding("Ketchup");
                ketchupBinding.Source = dd;
                ketchupBinding.Mode = BindingMode.TwoWay;
                ketchupBinding.UpdateSourceTrigger = UpdateSourceTrigger.PropertyChanged;
                BindingOperations.SetBinding(ketchupBox, CheckBox.IsCheckedProperty, ketchupBinding);
                stack.Children.Add(ketchupBox);
                CheckBox mustardBox = new CheckBox();
                mustardBox.IsChecked = true;
                mustardBox.Content = "Mustard";
                mustardBox.FontSize = 16;
                Binding mustardBinding = new Binding("Mustard");
                mustardBinding.Source = dd;
                mustardBinding.Mode = BindingMode.TwoWay;
                mustardBinding.UpdateSourceTrigger = UpdateSourceTrigger.PropertyChanged;
                BindingOperations.SetBinding(mustardBox, CheckBox.IsCheckedProperty, mustardBinding);
                stack.Children.Add(mustardBox);
                CheckBox pickleBox = new CheckBox();
                pickleBox.IsChecked = true;
                pickleBox.Content = "Pickle";
                pickleBox.FontSize = 16;
                Binding pickleBinding = new Binding("Pickle");
                pickleBinding.Source = dd;
                pickleBinding.Mode = BindingMode.TwoWay;
                pickleBinding.UpdateSourceTrigger = UpdateSourceTrigger.PropertyChanged;
                BindingOperations.SetBinding(pickleBox, CheckBox.IsCheckedProperty, pickleBinding);
                stack.Children.Add(pickleBox);
                CheckBox cheeseBox = new CheckBox();
                cheeseBox.IsChecked = true;
                cheeseBox.Content = "Cheese";
                cheeseBox.FontSize = 16;
                Binding cheeseBinding = new Binding("Cheese");
                cheeseBinding.Source = dd;
                cheeseBinding.Mode = BindingMode.TwoWay;
                cheeseBinding.UpdateSourceTrigger = UpdateSourceTrigger.PropertyChanged;
                BindingOperations.SetBinding(cheeseBox, CheckBox.IsCheckedProperty, cheeseBinding);
                stack.Children.Add(cheeseBox);
                CheckBox tomatoBox = new CheckBox();
                tomatoBox.IsChecked = true;
                tomatoBox.Content = "Tomato";
                tomatoBox.FontSize = 16;
                Binding tomatoBinding = new Binding("Tomato");
                tomatoBinding.Source = dd;
                tomatoBinding.Mode = BindingMode.TwoWay;
                tomatoBinding.UpdateSourceTrigger = UpdateSourceTrigger.PropertyChanged;
                BindingOperations.SetBinding(tomatoBox, CheckBox.IsCheckedProperty, tomatoBinding);
                stack.Children.Add(tomatoBox);
                CheckBox lettuceBox = new CheckBox();
                lettuceBox.IsChecked = true;
                lettuceBox.Content = "Lettuce";
                lettuceBox.FontSize = 16;
                Binding lettuceBinding = new Binding("Lettuce");
                lettuceBinding.Source = dd;
                lettuceBinding.Mode = BindingMode.TwoWay;
                lettuceBinding.UpdateSourceTrigger = UpdateSourceTrigger.PropertyChanged;
                BindingOperations.SetBinding(lettuceBox, CheckBox.IsCheckedProperty, lettuceBinding);
                stack.Children.Add(lettuceBox);
                CheckBox mayoBox = new CheckBox();
                mayoBox.IsChecked = true;
                mayoBox.Content = "Mayo";
                mayoBox.FontSize = 16;
                Binding mayoBinding = new Binding("Mayo");
                mayoBinding.Source = dd;
                mayoBinding.Mode = BindingMode.TwoWay;
                mayoBinding.UpdateSourceTrigger = UpdateSourceTrigger.PropertyChanged;
                BindingOperations.SetBinding(mayoBox, CheckBox.IsCheckedProperty, mayoBinding);
                stack.Children.Add(mayoBox);
                type = "Entree";
                thisItem = dd;
            }
            else if (item.ToString().Equals("Thalmor Triple"))
            {
                ThalmorTriple tt = item as ThalmorTriple;
                this.DataContext = tt;
                topText.Text = "Customize Thalmor Triple";
                CheckBox bunBox = new CheckBox();
                bunBox.IsChecked = true;
                bunBox.Content = "Bun";
                bunBox.FontSize = 16;
                Binding bunBinding = new Binding("Bun");
                bunBinding.Source = tt;
                bunBinding.Mode = BindingMode.TwoWay;
                bunBinding.UpdateSourceTrigger = UpdateSourceTrigger.PropertyChanged;
                BindingOperations.SetBinding(bunBox, CheckBox.IsCheckedProperty, bunBinding);
                stack.Children.Add(bunBox);
                CheckBox ketchupBox = new CheckBox();
                ketchupBox.IsChecked = true;
                ketchupBox.Content = "Ketchup";
                ketchupBox.FontSize = 16;
                Binding ketchupBinding = new Binding("Ketchup");
                ketchupBinding.Source = tt;
                ketchupBinding.Mode = BindingMode.TwoWay;
                ketchupBinding.UpdateSourceTrigger = UpdateSourceTrigger.PropertyChanged;
                BindingOperations.SetBinding(ketchupBox, CheckBox.IsCheckedProperty, ketchupBinding);
                stack.Children.Add(ketchupBox);
                CheckBox mustardBox = new CheckBox();
                mustardBox.IsChecked = true;
                mustardBox.Content = "Mustard";
                mustardBox.FontSize = 16;
                Binding mustardBinding = new Binding("Mustard");
                mustardBinding.Source = tt;
                mustardBinding.Mode = BindingMode.TwoWay;
                mustardBinding.UpdateSourceTrigger = UpdateSourceTrigger.PropertyChanged;
                BindingOperations.SetBinding(mustardBox, CheckBox.IsCheckedProperty, mustardBinding);
                stack.Children.Add(mustardBox);
                CheckBox pickleBox = new CheckBox();
                pickleBox.IsChecked = true;
                pickleBox.Content = "Pickle";
                pickleBox.FontSize = 16;
                Binding pickleBinding = new Binding("Pickle");
                pickleBinding.Source = tt;
                pickleBinding.Mode = BindingMode.TwoWay;
                pickleBinding.UpdateSourceTrigger = UpdateSourceTrigger.PropertyChanged;
                BindingOperations.SetBinding(pickleBox, CheckBox.IsCheckedProperty, pickleBinding);
                stack.Children.Add(pickleBox);
                CheckBox cheeseBox = new CheckBox();
                cheeseBox.IsChecked = true;
                cheeseBox.Content = "Cheese";
                cheeseBox.FontSize = 16;
                Binding cheeseBinding = new Binding("Cheese");
                cheeseBinding.Source = tt;
                cheeseBinding.Mode = BindingMode.TwoWay;
                cheeseBinding.UpdateSourceTrigger = UpdateSourceTrigger.PropertyChanged;
                BindingOperations.SetBinding(cheeseBox, CheckBox.IsCheckedProperty, cheeseBinding);
                stack.Children.Add(cheeseBox);
                CheckBox tomatoBox = new CheckBox();
                tomatoBox.IsChecked = true;
                tomatoBox.Content = "Tomato";
                tomatoBox.FontSize = 16;
                Binding tomatoBinding = new Binding("Tomato");
                tomatoBinding.Source = tt;
                tomatoBinding.Mode = BindingMode.TwoWay;
                tomatoBinding.UpdateSourceTrigger = UpdateSourceTrigger.PropertyChanged;
                BindingOperations.SetBinding(tomatoBox, CheckBox.IsCheckedProperty, tomatoBinding);
                stack.Children.Add(tomatoBox);
                CheckBox lettuceBox = new CheckBox();
                lettuceBox.IsChecked = true;
                lettuceBox.Content = "Lettuce";
                lettuceBox.FontSize = 16;
                Binding lettuceBinding = new Binding("Lettuce");
                lettuceBinding.Source = tt;
                lettuceBinding.Mode = BindingMode.TwoWay;
                lettuceBinding.UpdateSourceTrigger = UpdateSourceTrigger.PropertyChanged;
                BindingOperations.SetBinding(lettuceBox, CheckBox.IsCheckedProperty, lettuceBinding);
                stack.Children.Add(lettuceBox);
                CheckBox mayoBox = new CheckBox();
                mayoBox.IsChecked = true;
                mayoBox.Content = "Mayo";
                mayoBox.FontSize = 16;
                Binding mayoBinding = new Binding("Mayo");
                mayoBinding.Source = tt;
                mayoBinding.Mode = BindingMode.TwoWay;
                mayoBinding.UpdateSourceTrigger = UpdateSourceTrigger.PropertyChanged;
                BindingOperations.SetBinding(mayoBox, CheckBox.IsCheckedProperty, mayoBinding);
                stack.Children.Add(mayoBox);
                CheckBox baconBox = new CheckBox();
                baconBox.IsChecked = true;
                baconBox.Content = "Bacon";
                baconBox.FontSize = 16;
                Binding baconBinding = new Binding("Bacon");
                baconBinding.Source = tt;
                baconBinding.Mode = BindingMode.TwoWay;
                baconBinding.UpdateSourceTrigger = UpdateSourceTrigger.PropertyChanged;
                BindingOperations.SetBinding(baconBox, CheckBox.IsCheckedProperty, baconBinding);
                stack.Children.Add(baconBox);
                CheckBox eggBox = new CheckBox();
                eggBox.IsChecked = true;
                eggBox.Content = "Egg";
                eggBox.FontSize = 16;
                Binding eggBinding = new Binding("Egg");
                eggBinding.Source = tt;
                eggBinding.Mode = BindingMode.TwoWay;
                eggBinding.UpdateSourceTrigger = UpdateSourceTrigger.PropertyChanged;
                BindingOperations.SetBinding(eggBox, CheckBox.IsCheckedProperty, eggBinding);
                stack.Children.Add(eggBox);
                type = "Entree";
                thisItem = tt;
            }
            else if (item.ToString().Equals("Smokehouse Skeleton"))
            {
                SmokehouseSkeleton ss = item as SmokehouseSkeleton;
                this.DataContext = ss;
                topText.Text = "Customize Smokehouse Skeleton";
                CheckBox sausageBox = new CheckBox();
                sausageBox.IsChecked = true;
                sausageBox.Content = "Sausage";
                sausageBox.FontSize = 16;
                Binding sausageBinding = new Binding("Sausage");
                sausageBinding.Source = ss;
                sausageBinding.Mode = BindingMode.TwoWay;
                sausageBinding.UpdateSourceTrigger = UpdateSourceTrigger.PropertyChanged;
                BindingOperations.SetBinding(sausageBox, CheckBox.IsCheckedProperty, sausageBinding);
                stack.Children.Add(sausageBox);
                CheckBox eggBox = new CheckBox();
                eggBox.IsChecked = true;
                eggBox.Content = "Egg";
                eggBox.FontSize = 16;
                Binding eggBinding = new Binding("Egg");
                eggBinding.Source = ss;
                eggBinding.Mode = BindingMode.TwoWay;
                eggBinding.UpdateSourceTrigger = UpdateSourceTrigger.PropertyChanged;
                BindingOperations.SetBinding(eggBox, CheckBox.IsCheckedProperty, eggBinding);
                stack.Children.Add(eggBox);
                CheckBox hashBox = new CheckBox();
                hashBox.IsChecked = true;
                hashBox.Content = "Hashbrowns";
                hashBox.FontSize = 16;
                Binding hashBinding = new Binding("HashBrowns");
                hashBinding.Source = ss;
                hashBinding.Mode = BindingMode.TwoWay;
                hashBinding.UpdateSourceTrigger = UpdateSourceTrigger.PropertyChanged;
                BindingOperations.SetBinding(hashBox, CheckBox.IsCheckedProperty, hashBinding);
                stack.Children.Add(hashBox);
                CheckBox pancakeBox = new CheckBox();
                pancakeBox.IsChecked = true;
                pancakeBox.Content = "Pancakes";
                pancakeBox.FontSize = 16;
                Binding pancakeBinding = new Binding("Pancake");
                pancakeBinding.Source = ss;
                pancakeBinding.Mode = BindingMode.TwoWay;
                pancakeBinding.UpdateSourceTrigger = UpdateSourceTrigger.PropertyChanged;
                BindingOperations.SetBinding(pancakeBox, CheckBox.IsCheckedProperty, pancakeBinding);
                stack.Children.Add(pancakeBox);
                type = "Entree";
                thisItem = ss;
            }
            else if (item.ToString().Equals("Garden Orc Omelette"))
            {
                GardenOrcOmelette goo = item as GardenOrcOmelette;
                this.DataContext = goo;
                topText.Text = "Customize Garden Orc Omelette";
                CheckBox broccoliBox = new CheckBox();
                broccoliBox.IsChecked = true;
                broccoliBox.Content = "Broccoli";
                broccoliBox.FontSize = 16;
                Binding broccoliBinding = new Binding("Broccoli");
                broccoliBinding.Source = goo;
                broccoliBinding.Mode = BindingMode.TwoWay;
                broccoliBinding.UpdateSourceTrigger = UpdateSourceTrigger.PropertyChanged;
                BindingOperations.SetBinding(broccoliBox, CheckBox.IsCheckedProperty, broccoliBinding);
                stack.Children.Add(broccoliBox);
                CheckBox mushroomBox = new CheckBox();
                mushroomBox.IsChecked = true;
                mushroomBox.Content = "Mushrooms";
                mushroomBox.FontSize = 16;
                Binding mushroomBinding = new Binding("Mushrooms");
                mushroomBinding.Source = goo;
                mushroomBinding.Mode = BindingMode.TwoWay;
                mushroomBinding.UpdateSourceTrigger = UpdateSourceTrigger.PropertyChanged;
                BindingOperations.SetBinding(mushroomBox, CheckBox.IsCheckedProperty, mushroomBinding);
                stack.Children.Add(mushroomBox);
                CheckBox tomatoBox = new CheckBox();
                tomatoBox.IsChecked = true;
                tomatoBox.Content = "Tomato";
                tomatoBox.FontSize = 16;
                Binding tomatoBinding = new Binding("Tomato");
                tomatoBinding.Source = goo;
                tomatoBinding.Mode = BindingMode.TwoWay;
                tomatoBinding.UpdateSourceTrigger = UpdateSourceTrigger.PropertyChanged;
                BindingOperations.SetBinding(tomatoBox, CheckBox.IsCheckedProperty, tomatoBinding);
                stack.Children.Add(tomatoBox);
                CheckBox cheddarBox = new CheckBox();
                cheddarBox.IsChecked = true;
                cheddarBox.Content = "Cheddar";
                cheddarBox.FontSize = 16;
                Binding cheddarBinding = new Binding("Cheddar");
                cheddarBinding.Source = goo;
                cheddarBinding.Mode = BindingMode.TwoWay;
                cheddarBinding.UpdateSourceTrigger = UpdateSourceTrigger.PropertyChanged;
                BindingOperations.SetBinding(cheddarBox, CheckBox.IsCheckedProperty, cheddarBinding);
                stack.Children.Add(cheddarBox);
                type = "Entree";
                thisItem = goo;
            }
            else if (item.ToString().Equals("Philly Poacher"))
            {
                PhillyPoacher pp = item as PhillyPoacher;
                this.DataContext = pp;
                topText.Text = "Customize Philly Poacher";
                CheckBox sirloinBox = new CheckBox();
                sirloinBox.IsChecked = true;
                sirloinBox.Content = "Sirloin";
                sirloinBox.FontSize = 16;
                Binding sirloinBinding = new Binding("Sirloin");
                sirloinBinding.Source = pp;
                sirloinBinding.Mode = BindingMode.TwoWay;
                sirloinBinding.UpdateSourceTrigger = UpdateSourceTrigger.PropertyChanged;
                BindingOperations.SetBinding(sirloinBox, CheckBox.IsCheckedProperty, sirloinBinding);
                stack.Children.Add(sirloinBox);
                CheckBox onionBox = new CheckBox();
                onionBox.IsChecked = true;
                onionBox.Content = "Onion";
                onionBox.FontSize = 16;
                Binding onionBinding = new Binding("Onion");
                onionBinding.Source = pp;
                onionBinding.Mode = BindingMode.TwoWay;
                onionBinding.UpdateSourceTrigger = UpdateSourceTrigger.PropertyChanged;
                BindingOperations.SetBinding(onionBox, CheckBox.IsCheckedProperty, onionBinding);
                stack.Children.Add(onionBox);
                CheckBox rollBox = new CheckBox();
                rollBox.IsChecked = true;
                rollBox.Content = "Roll";
                rollBox.FontSize = 16;
                Binding rollBinding = new Binding("Roll");
                rollBinding.Source = pp;
                rollBinding.Mode = BindingMode.TwoWay;
                rollBinding.UpdateSourceTrigger = UpdateSourceTrigger.PropertyChanged;
                BindingOperations.SetBinding(rollBox, CheckBox.IsCheckedProperty, rollBinding);
                type = "Entree";
                stack.Children.Add(rollBox);
                thisItem = pp;
            }
            else if (item.ToString().Contains("Vokun Salad"))
            {
                VokunSalad vs = item as VokunSalad;
                this.DataContext = vs;
                topText.Text = "Customize Vokun Salad";
                sizeBox.Visibility = Visibility.Visible;

                Binding sizeBinding = new Binding("Size");
                sizeBinding.Source = vs;
                sizeBinding.Mode = BindingMode.TwoWay;
                sizeBinding.UpdateSourceTrigger = UpdateSourceTrigger.PropertyChanged;
                BindingOperations.SetBinding(sizeBox, ComboBox.SelectedValueProperty, sizeBinding);

                type = "Side";
                thisItem = vs;
            }
            else if (item.ToString().Contains("Fried Miraak"))
            {
                FriedMiraak fm = item as FriedMiraak;
                this.DataContext = fm;
                topText.Text = "Customize Fried Miraak";
                sizeBox.Visibility = Visibility.Visible;
                Binding sizeBinding = new Binding("Size");
                sizeBinding.Source = fm;
                sizeBinding.Mode = BindingMode.TwoWay;
                sizeBinding.UpdateSourceTrigger = UpdateSourceTrigger.PropertyChanged;
                BindingOperations.SetBinding(sizeBox, ComboBox.SelectedValueProperty, sizeBinding);
                type = "Side";
                thisItem = fm;
            }
            else if (item.ToString().Contains("Mad Otar Grits"))
            {
                MadOtarGrits mog = item as MadOtarGrits;
                this.DataContext = mog;
                topText.Text = "Customize Mad Otar Grits";
                sizeBox.Visibility = Visibility.Visible;
                Binding sizeBinding = new Binding("Size");
                sizeBinding.Source = mog;
                sizeBinding.Mode = BindingMode.TwoWay;
                sizeBinding.UpdateSourceTrigger = UpdateSourceTrigger.PropertyChanged;
                BindingOperations.SetBinding(sizeBox, ComboBox.SelectedValueProperty, sizeBinding);
                type = "Side";
                thisItem = mog;
            }
            else if (item.ToString().Contains("Dragonborn Waffle Fries"))
            {
                DragonbornWaffleFries dwf = item as DragonbornWaffleFries;
                this.DataContext = dwf;
                topText.Text = "Customize Dragonborn Waffle Fries";
                sizeBox.Visibility = Visibility.Visible;
                Binding sizeBinding = new Binding("Size");
                sizeBinding.Source = dwf;
                sizeBinding.Mode = BindingMode.TwoWay;
                sizeBinding.UpdateSourceTrigger = UpdateSourceTrigger.PropertyChanged;
                BindingOperations.SetBinding(sizeBox, ComboBox.SelectedValueProperty, sizeBinding);
                type = "Side";
                thisItem = dwf;
            }
            else if (item.ToString().Contains("Sailor Soda"))
            {
                SailorSoda ss = item as SailorSoda;
                this.DataContext = ss;
                topText.Text = "Customize Sailor Soda";
                sizeBox.Visibility = Visibility.Visible;
                Binding sizeBinding = new Binding("Size");
                sizeBinding.Source = ss;
                sizeBinding.Mode = BindingMode.TwoWay;
                sizeBinding.UpdateSourceTrigger = UpdateSourceTrigger.PropertyChanged;
                BindingOperations.SetBinding(sizeBox, ComboBox.SelectedValueProperty, sizeBinding);
                flavorBox.Visibility = Visibility.Visible;
                Binding flavorBinding = new Binding("Flavor");
                flavorBinding.Source = ss;
                flavorBinding.Mode = BindingMode.TwoWay;
                flavorBinding.UpdateSourceTrigger = UpdateSourceTrigger.PropertyChanged;
                BindingOperations.SetBinding(flavorBox, ComboBox.SelectedValueProperty, flavorBinding);
                CheckBox iceBox = new CheckBox();
                iceBox.IsChecked = true;
                iceBox.Content = "Ice";
                iceBox.FontSize = 20;
                Binding iceBinding = new Binding("Ice");
                iceBinding.Source = ss;
                iceBinding.Mode = BindingMode.TwoWay;
                iceBinding.UpdateSourceTrigger = UpdateSourceTrigger.PropertyChanged;
                BindingOperations.SetBinding(iceBox, CheckBox.IsCheckedProperty, iceBinding);
                stack.Children.Add(iceBox);
                type = "Drink";
                thisItem = ss;
            }
            else if (item.ToString().Contains("Markarth Milk"))
            {
                MarkarthMilk mm = item as MarkarthMilk;
                this.DataContext = mm;
                topText.Text = "Customize Markarth Milk";
                sizeBox.Visibility = Visibility.Visible;
                Binding sizeBinding = new Binding("Size");
                sizeBinding.Source = mm;
                sizeBinding.Mode = BindingMode.TwoWay;
                sizeBinding.UpdateSourceTrigger = UpdateSourceTrigger.PropertyChanged;
                BindingOperations.SetBinding(sizeBox, ComboBox.SelectedValueProperty, sizeBinding);
                CheckBox iceBox = new CheckBox();
                iceBox.IsChecked = false;
                iceBox.Content = "Ice";
                iceBox.FontSize = 20;
                Binding iceBinding = new Binding("Ice");
                iceBinding.Source = mm;
                iceBinding.Mode = BindingMode.TwoWay;
                iceBinding.UpdateSourceTrigger = UpdateSourceTrigger.PropertyChanged;
                BindingOperations.SetBinding(iceBox, CheckBox.IsCheckedProperty, iceBinding);
                stack.Children.Add(iceBox);
                type = "Drink";
                thisItem = mm;
            }
            else if (item.ToString().Contains("Aretino Apple Juice"))
            {
                AretinoAppleJuice aj = item as AretinoAppleJuice;
                this.DataContext = aj;
                topText.Text = "Customize Aretino Apple Juice";
                sizeBox.Visibility = Visibility.Visible;
                Binding sizeBinding = new Binding("Size");
                sizeBinding.Source = aj;
                sizeBinding.Mode = BindingMode.TwoWay;
                sizeBinding.UpdateSourceTrigger = UpdateSourceTrigger.PropertyChanged;
                BindingOperations.SetBinding(sizeBox, ComboBox.SelectedValueProperty, sizeBinding);
                CheckBox iceBox = new CheckBox();
                iceBox.IsChecked = false;
                iceBox.Content = "Ice";
                iceBox.FontSize = 20;
                Binding iceBinding = new Binding("Ice");
                iceBinding.Source = aj;
                iceBinding.Mode = BindingMode.TwoWay;
                iceBinding.UpdateSourceTrigger = UpdateSourceTrigger.PropertyChanged;
                BindingOperations.SetBinding(iceBox, CheckBox.IsCheckedProperty, iceBinding);
                stack.Children.Add(iceBox);
                type = "Drink";
                thisItem = aj;
            }
            else if (item.ToString().Contains("Candlehearth Coffee"))
            {
                CandlehearthCoffee cc = item as CandlehearthCoffee;
                this.DataContext = cc;
                topText.Text = "Customize Candlehearth Coffee";
                sizeBox.Visibility = Visibility.Visible;
                Binding sizeBinding = new Binding("Size");
                sizeBinding.Source = cc;
                sizeBinding.Mode = BindingMode.TwoWay;
                sizeBinding.UpdateSourceTrigger = UpdateSourceTrigger.PropertyChanged;
                BindingOperations.SetBinding(sizeBox, ComboBox.SelectedValueProperty, sizeBinding);
                CheckBox iceBox = new CheckBox();
                iceBox.IsChecked = false;
                iceBox.Content = "Ice";
                iceBox.FontSize = 20;
                Binding iceBinding = new Binding("Ice");
                iceBinding.Source = cc;
                iceBinding.Mode = BindingMode.TwoWay;
                iceBinding.UpdateSourceTrigger = UpdateSourceTrigger.PropertyChanged;
                BindingOperations.SetBinding(iceBox, CheckBox.IsCheckedProperty, iceBinding);
                stack.Children.Add(iceBox);
                CheckBox creamBox = new CheckBox();
                creamBox.IsChecked = false;
                creamBox.Content = "Cream";
                creamBox.FontSize = 20;
                Binding creamBinding = new Binding("Room For Cream");
                creamBinding.Source = cc;
                creamBinding.Mode = BindingMode.TwoWay;
                creamBinding.UpdateSourceTrigger = UpdateSourceTrigger.PropertyChanged;
                BindingOperations.SetBinding(creamBox, CheckBox.IsCheckedProperty, creamBinding);
                stack.Children.Add(creamBox);
                CheckBox decafBox = new CheckBox();
                decafBox.IsChecked = false;
                decafBox.Content = "Decaf";
                decafBox.FontSize = 20;
                Binding decafBinding = new Binding("Decaf");
                decafBinding.Source = cc;
                decafBinding.Mode = BindingMode.TwoWay;
                decafBinding.UpdateSourceTrigger = UpdateSourceTrigger.PropertyChanged;
                BindingOperations.SetBinding(decafBox, CheckBox.IsCheckedProperty, decafBinding);
                stack.Children.Add(decafBox);
                type = "Drink";
                thisItem = cc;
            }
            else if (item.ToString().Contains("Warrior Water"))
            {
                WarriorWater ww = item as WarriorWater;
                this.DataContext = ww;
                topText.Text = "Customize Warrior Water";
                sizeBox.Visibility = Visibility.Visible;
                Binding sizeBinding = new Binding("Size");
                sizeBinding.Source = ww;
                sizeBinding.Mode = BindingMode.TwoWay;
                sizeBinding.UpdateSourceTrigger = UpdateSourceTrigger.PropertyChanged;
                BindingOperations.SetBinding(sizeBox, ComboBox.SelectedValueProperty, sizeBinding);
                CheckBox iceBox = new CheckBox();
                iceBox.IsChecked = true;
                iceBox.Content = "Ice";
                iceBox.FontSize = 20;
                Binding iceBinding = new Binding("Ice");
                iceBinding.Source = ww;
                iceBinding.Mode = BindingMode.TwoWay;
                iceBinding.UpdateSourceTrigger = UpdateSourceTrigger.PropertyChanged;
                BindingOperations.SetBinding(iceBox, CheckBox.IsCheckedProperty, iceBinding);
                stack.Children.Add(iceBox);
                CheckBox lemonBox = new CheckBox();
                lemonBox.IsChecked = false;
                lemonBox.Content = "Lemon";
                lemonBox.FontSize = 20;
                Binding lemonBinding = new Binding("Lemon");
                lemonBinding.Source = ww;
                lemonBinding.Mode = BindingMode.TwoWay;
                lemonBinding.UpdateSourceTrigger = UpdateSourceTrigger.PropertyChanged;
                BindingOperations.SetBinding(lemonBox, CheckBox.IsCheckedProperty, lemonBinding);
                stack.Children.Add(lemonBox);
                type = "Drink";
                thisItem = ww;
            }
            else
            {
                main.OpenEntrees();
            }
        }
    }
}
