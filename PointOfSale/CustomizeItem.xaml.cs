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

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for CustomizeItem.xaml
    /// </summary>
    public partial class CustomizeItem : UserControl
    {
        private MainWindow main;
        private string type;

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
        }

        public void GenerateCustomizationOptions(IOrderItem item)
        {
            if(item.ToString().Equals("Briarheart Burger"))
            {
                topText.Text = "Customize Briarheart Burger";
                CheckBox bunBox = new CheckBox();
                bunBox.IsChecked = true;
                bunBox.Content = "Bun";
                stack.Children.Add(bunBox);
                CheckBox ketchupBox = new CheckBox();
                ketchupBox.IsChecked = true;
                ketchupBox.Content = "Ketchup";
                stack.Children.Add(ketchupBox);
                CheckBox mustardBox = new CheckBox();
                mustardBox.IsChecked = true;
                mustardBox.Content = "Mustard";
                stack.Children.Add(mustardBox);
                CheckBox pickleBox = new CheckBox();
                pickleBox.IsChecked = true;
                pickleBox.Content = "Pickle";
                stack.Children.Add(pickleBox);
                CheckBox cheeseBox = new CheckBox();
                cheeseBox.IsChecked = true;
                cheeseBox.Content = "Cheese";
                stack.Children.Add(cheeseBox);
                type = "Entree";
            }
            else if(item.ToString().Equals("Double Draugr"))
            {
                topText.Text = "Customize Double Draugr";
                CheckBox bunBox = new CheckBox();
                bunBox.IsChecked = true;
                bunBox.Content = "Bun";
                stack.Children.Add(bunBox);
                CheckBox ketchupBox = new CheckBox();
                ketchupBox.IsChecked = true;
                ketchupBox.Content = "Ketchup";
                stack.Children.Add(ketchupBox);
                CheckBox mustardBox = new CheckBox();
                mustardBox.IsChecked = true;
                mustardBox.Content = "Mustard";
                stack.Children.Add(mustardBox);
                CheckBox pickleBox = new CheckBox();
                pickleBox.IsChecked = true;
                pickleBox.Content = "Pickle";
                stack.Children.Add(pickleBox);
                CheckBox cheeseBox = new CheckBox();
                cheeseBox.IsChecked = true;
                cheeseBox.Content = "Cheese";
                stack.Children.Add(cheeseBox);
                CheckBox tomatoBox = new CheckBox();
                tomatoBox.IsChecked = true;
                cheeseBox.Content = "Tomato";
                stack.Children.Add(tomatoBox);
                CheckBox lettuceBox = new CheckBox();
                lettuceBox.IsChecked = true;
                lettuceBox.Content = "Lettuce";
                stack.Children.Add(lettuceBox);
                CheckBox mayoBox = new CheckBox();
                mayoBox.IsChecked = true;
                mayoBox.Content = "Mayo";
                stack.Children.Add(mayoBox);
                type = "Entree";
            }
            else if (item.ToString().Equals("Thalmor Triple"))
            {
                topText.Text = "Customize Thalmor Triple";
                CheckBox bunBox = new CheckBox();
                bunBox.IsChecked = true;
                bunBox.Content = "Bun";
                stack.Children.Add(bunBox);
                CheckBox ketchupBox = new CheckBox();
                ketchupBox.IsChecked = true;
                ketchupBox.Content = "Ketchup";
                stack.Children.Add(ketchupBox);
                CheckBox mustardBox = new CheckBox();
                mustardBox.IsChecked = true;
                mustardBox.Content = "Mustard";
                stack.Children.Add(mustardBox);
                CheckBox pickleBox = new CheckBox();
                pickleBox.IsChecked = true;
                pickleBox.Content = "Pickle";
                stack.Children.Add(pickleBox);
                CheckBox cheeseBox = new CheckBox();
                cheeseBox.IsChecked = true;
                cheeseBox.Content = "Cheese";
                stack.Children.Add(cheeseBox);
                CheckBox tomatoBox = new CheckBox();
                tomatoBox.IsChecked = true;
                cheeseBox.Content = "Tomato";
                stack.Children.Add(tomatoBox);
                CheckBox lettuceBox = new CheckBox();
                lettuceBox.IsChecked = true;
                lettuceBox.Content = "Lettuce";
                stack.Children.Add(lettuceBox);
                CheckBox mayoBox = new CheckBox();
                mayoBox.IsChecked = true;
                mayoBox.Content = "Mayo";
                stack.Children.Add(mayoBox);
                CheckBox baconBox = new CheckBox();
                baconBox.IsChecked = true;
                baconBox.Content = "Bacon";
                stack.Children.Add(baconBox);
                CheckBox eggBox = new CheckBox();
                eggBox.IsChecked = true;
                eggBox.Content = "Egg";
                stack.Children.Add(eggBox);
                type = "Entree";
            }
            else if (item.ToString().Equals("Smokehouse Skeleton"))
            {
                topText.Text = "Customize Smokehouse Skeleton";
                CheckBox sausageBox = new CheckBox();
                sausageBox.IsChecked = true;
                sausageBox.Content = "Sausage";
                stack.Children.Add(sausageBox);
                CheckBox eggBox = new CheckBox();
                eggBox.IsChecked = true;
                eggBox.Content = "Egg";
                stack.Children.Add(eggBox);
                CheckBox hashBox = new CheckBox();
                hashBox.IsChecked = true;
                hashBox.Content = "Hashbrowns";
                stack.Children.Add(hashBox);
                CheckBox pancakeBox = new CheckBox();
                pancakeBox.IsChecked = true;
                pancakeBox.Content = "Pancakes";
                stack.Children.Add(pancakeBox);
                type = "Entree";
            }
            else if (item.ToString().Equals("Garden Orc Omelette"))
            {
                topText.Text = "Customize Garden Orc Omelette";
                CheckBox broccoliBox = new CheckBox();
                broccoliBox.IsChecked = true;
                broccoliBox.Content = "Broccoli";
                stack.Children.Add(broccoliBox);
                CheckBox mushroomBox = new CheckBox();
                mushroomBox.IsChecked = true;
                mushroomBox.Content = "Mushrooms";
                stack.Children.Add(mushroomBox);
                CheckBox tomatoBox = new CheckBox();
                tomatoBox.IsChecked = true;
                tomatoBox.Content = "Tomato";
                stack.Children.Add(tomatoBox);
                CheckBox cheddarBox = new CheckBox();
                cheddarBox.IsChecked = true;
                cheddarBox.Content = "Cheddar";
                stack.Children.Add(cheddarBox);
                type = "Entree";
            }
            else if (item.ToString().Equals("Philly Poacher"))
            {
                topText.Text = "Customize Philly Poacher";
                CheckBox sirloinBox = new CheckBox();
                sirloinBox.IsChecked = true;
                sirloinBox.Content = "Sirloin";
                stack.Children.Add(sirloinBox);
                CheckBox onionBox = new CheckBox();
                onionBox.IsChecked = true;
                onionBox.Content = "Onion";
                stack.Children.Add(onionBox);
                CheckBox rollBox = new CheckBox();
                rollBox.IsChecked = true;
                rollBox.Content = "Roll";
                type = "Entree";
                stack.Children.Add(rollBox);
            }
            else if (item.ToString().Contains("Vokun Salad"))
            {
                topText.Text = "Customize Vokun Salad";
                ComboBox sizes = new ComboBox();
                sizes.ItemsSource = new List<string> { "Small", "Medium", "Large" };
                sizes.SelectedIndex = 0;
                stack.Children.Add(sizes);
                type = "Side";
            }
            else if(item.ToString().Contains("Fried Miraak"))
            {
                topText.Text = "Customize Fried Miraak";
                ComboBox sizes = new ComboBox();
                sizes.ItemsSource = new List<string> { "Small", "Medium", "Large" };
                sizes.SelectedIndex = 0;
                stack.Children.Add(sizes);
                type = "Side";
            }
            else if(item.ToString().Contains("Mad Otar Grits"))
            {
                topText.Text = "Customize Mad Otar Grits";
                ComboBox sizes = new ComboBox();
                sizes.ItemsSource = new List<string> { "Small", "Medium", "Large" };
                sizes.SelectedIndex = 0;
                stack.Children.Add(sizes);
                type = "Side";
            }
            else if(item.ToString().Contains("Dragonborn Waffle Fries"))
            {
                topText.Text = "Customize Dragonborn Waffle Fries";
                ComboBox sizes = new ComboBox();
                sizes.ItemsSource = new List<string> { "Small", "Medium", "Large" };
                sizes.SelectedIndex = 0;
                stack.Children.Add(sizes);
                type = "Side";
            }
            else if (item.ToString().Contains("Sailor Soda"))
            {
                topText.Text = "Customize Sailor Soda";
                ComboBox sizes = new ComboBox();
                sizes.ItemsSource = new List<string> { "Small", "Medium", "Large" };
                sizes.SelectedIndex = 0;
                stack.Children.Add(sizes);
                ComboBox flavors = new ComboBox();
                flavors.ItemsSource = new List<string> { "Cherry", "Blackberry", "Lemon", "Grapefruit", "Peach", "Watermelon" };
                flavors.SelectedIndex = 0;
                stack.Children.Add(flavors);
                CheckBox iceBox = new CheckBox();
                iceBox.IsChecked = true;
                iceBox.Content = "Ice";
                stack.Children.Add(iceBox);
                type = "Drink";
            }
            else if (item.ToString().Contains("Markarth Milk"))
            {
                topText.Text = "Customize Markarth Milk";
                ComboBox sizes = new ComboBox();
                sizes.ItemsSource = new List<string> { "Small", "Medium", "Large" };
                sizes.SelectedIndex = 0;
                stack.Children.Add(sizes);
                CheckBox iceBox = new CheckBox();
                iceBox.IsChecked = false;
                iceBox.Content = "Ice";
                stack.Children.Add(iceBox);
                type = "Drink";
            }
            else if (item.ToString().Contains("Aretino Apple Juice"))
            {
                topText.Text = "Customize Aretino Apple Juice";
                ComboBox sizes = new ComboBox();
                sizes.ItemsSource = new List<string> { "Small", "Medium", "Large" };
                sizes.SelectedIndex = 0;
                stack.Children.Add(sizes);
                CheckBox iceBox = new CheckBox();
                iceBox.IsChecked = false;
                iceBox.Content = "Ice";
                stack.Children.Add(iceBox);
                type = "Drink";
            }
            else if (item.ToString().Contains("Candlehearth Coffee"))
            {
                topText.Text = "Customize Candlehearth Coffee";
                ComboBox sizes = new ComboBox();
                sizes.ItemsSource = new List<string> { "Small", "Medium", "Large" };
                sizes.SelectedIndex = 0;
                stack.Children.Add(sizes);
                CheckBox iceBox = new CheckBox();
                iceBox.IsChecked = false;
                iceBox.Content = "Ice";
                stack.Children.Add(iceBox);
                CheckBox creamBox = new CheckBox();
                creamBox.IsChecked = false;
                creamBox.Content = "Cream";
                stack.Children.Add(creamBox);
                CheckBox decafBox = new CheckBox();
                decafBox.IsChecked = false;
                decafBox.Content = "Decaf";
                stack.Children.Add(decafBox);
                type = "Drink";
            }
            else if (item.ToString().Contains("Warrior Water"))
            {
                topText.Text = "Customize Warrior Water";
                ComboBox sizes = new ComboBox();
                sizes.ItemsSource = new List<string> { "Small", "Medium", "Large" };
                sizes.SelectedIndex = 0;
                stack.Children.Add(sizes);
                CheckBox iceBox = new CheckBox();
                iceBox.IsChecked = true;
                iceBox.Content = "Ice";
                stack.Children.Add(iceBox);
                CheckBox lemonBox = new CheckBox();
                lemonBox.IsChecked = false;
                lemonBox.Content = "Lemon";
                stack.Children.Add(lemonBox);
                type = "Drink";
            }
        }
    }
}
