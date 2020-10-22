/*
 * Author: Cole Kaster
 * Class name: RegisterDisplay.xaml.cs
 * Purpose: Provides display and interactions with cash register
 */

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

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for RegisterDisplay.xaml
    /// </summary>
    public partial class RegisterDisplay : UserControl
    {
        private MainWindow mainWindow;
        private RegisterUtility register;

        /// <summary>
        /// Sets up the register's display
        /// </summary>
        public RegisterDisplay(Order order, MainWindow mainWindow)
        {
            InitializeComponent();
            this.mainWindow = mainWindow;
            register = new RegisterUtility(order);
            this.DataContext = register;

            orderTotal.Text = "$" + order.Total.ToString();
            SetBindings();           
        }

        private void SetBindings()
        {
            CurrencyControl custHundredControl = new CurrencyControl() { Label = "$100", CustomerQuantity = register.CustomerHundreds, ChangeQuantity = register.ChangeHundreds };
            Binding custHundredBinding = new Binding("CustomerHundreds");
            custHundredBinding.Source = register;
            custHundredBinding.Mode = BindingMode.TwoWay;
            custHundredBinding.UpdateSourceTrigger = UpdateSourceTrigger.PropertyChanged;
            BindingOperations.SetBinding(custHundredControl, CurrencyControl.CustomerQuantityProperty, custHundredBinding);
            Binding chanHundredBinding = new Binding("ChangeHundreds");
            chanHundredBinding.Source = register;
            chanHundredBinding.Mode = BindingMode.OneWay;
            chanHundredBinding.UpdateSourceTrigger = UpdateSourceTrigger.PropertyChanged;
            BindingOperations.SetBinding(custHundredControl, CurrencyControl.ChangeQuantityProperty, chanHundredBinding);
            dollarControls.Children.Add(custHundredControl);

            CurrencyControl custFiftyControl = new CurrencyControl() { Label = "$50", CustomerQuantity = register.CustomerFifties, ChangeQuantity = register.ChangeFifties };
            Binding custFiftyBinding = new Binding("CustomerFifties");
            custFiftyBinding.Source = register;
            custFiftyBinding.Mode = BindingMode.TwoWay;
            custFiftyBinding.UpdateSourceTrigger = UpdateSourceTrigger.PropertyChanged;
            BindingOperations.SetBinding(custFiftyControl, CurrencyControl.CustomerQuantityProperty, custFiftyBinding);
            Binding chanFiftyBinding = new Binding("ChangeFifties");
            chanFiftyBinding.Source = register;
            chanFiftyBinding.Mode = BindingMode.OneWay;
            chanFiftyBinding.UpdateSourceTrigger = UpdateSourceTrigger.PropertyChanged;
            BindingOperations.SetBinding(custFiftyControl, CurrencyControl.ChangeQuantityProperty, chanFiftyBinding);
            dollarControls.Children.Add(custFiftyControl);

            CurrencyControl custTwentyControl = new CurrencyControl() { Label = "$20", CustomerQuantity = register.CustomerTwenties, ChangeQuantity = register.ChangeTwenties };
            Binding custTwentyBinding = new Binding("CustomerTwenties");
            custTwentyBinding.Source = register;
            custTwentyBinding.Mode = BindingMode.TwoWay;
            custTwentyBinding.UpdateSourceTrigger = UpdateSourceTrigger.PropertyChanged;
            BindingOperations.SetBinding(custTwentyControl, CurrencyControl.CustomerQuantityProperty, custTwentyBinding);
            Binding chanTwentyBinding = new Binding("ChangeTwenties");
            chanTwentyBinding.Source = register;
            chanTwentyBinding.Mode = BindingMode.OneWay;
            chanTwentyBinding.UpdateSourceTrigger = UpdateSourceTrigger.PropertyChanged;
            BindingOperations.SetBinding(custTwentyControl, CurrencyControl.ChangeQuantityProperty, chanTwentyBinding);
            dollarControls.Children.Add(custTwentyControl);

            CurrencyControl custTenControl = new CurrencyControl() { Label = "$10", CustomerQuantity = register.CustomerTens, ChangeQuantity = register.ChangeTens };
            Binding custTenBinding = new Binding("CustomerTens");
            custTenBinding.Source = register;
            custTenBinding.Mode = BindingMode.TwoWay;
            custTenBinding.UpdateSourceTrigger = UpdateSourceTrigger.PropertyChanged;
            BindingOperations.SetBinding(custTenControl, CurrencyControl.CustomerQuantityProperty, custTenBinding);
            Binding chanTenBinding = new Binding("ChangeTens");
            chanTenBinding.Source = register;
            chanTenBinding.Mode = BindingMode.OneWay;
            chanTenBinding.UpdateSourceTrigger = UpdateSourceTrigger.PropertyChanged;
            BindingOperations.SetBinding(custTenControl, CurrencyControl.ChangeQuantityProperty, chanTenBinding);
            dollarControls.Children.Add(custTenControl);

            CurrencyControl custFiveControl = new CurrencyControl() { Label = "$5", CustomerQuantity = register.CustomerFives, ChangeQuantity = register.ChangeFives };
            Binding custFiveBinding = new Binding("CustomerFives");
            custFiveBinding.Source = register;
            custFiveBinding.Mode = BindingMode.TwoWay;
            custFiveBinding.UpdateSourceTrigger = UpdateSourceTrigger.PropertyChanged;
            BindingOperations.SetBinding(custFiveControl, CurrencyControl.CustomerQuantityProperty, custFiveBinding);
            Binding chanFiveBinding = new Binding("ChangeFives");
            chanFiveBinding.Source = register;
            chanFiveBinding.Mode = BindingMode.OneWay;
            chanFiveBinding.UpdateSourceTrigger = UpdateSourceTrigger.PropertyChanged;
            BindingOperations.SetBinding(custFiveControl, CurrencyControl.ChangeQuantityProperty, chanFiveBinding);
            dollarControls.Children.Add(custFiveControl);

            CurrencyControl custTwoControl = new CurrencyControl() { Label = "$2", CustomerQuantity = register.CustomerTwos, ChangeQuantity = register.ChangeTwos };
            Binding custTwoBinding = new Binding("CustomerTwos");
            custTwoBinding.Source = register;
            custTwoBinding.Mode = BindingMode.TwoWay;
            custTwoBinding.UpdateSourceTrigger = UpdateSourceTrigger.PropertyChanged;
            BindingOperations.SetBinding(custTwoControl, CurrencyControl.CustomerQuantityProperty, custTwoBinding);
            Binding chanTwoBinding = new Binding("ChangeTwos");
            chanTwoBinding.Source = register;
            chanTwoBinding.Mode = BindingMode.OneWay;
            chanTwoBinding.UpdateSourceTrigger = UpdateSourceTrigger.PropertyChanged;
            BindingOperations.SetBinding(custTwoControl, CurrencyControl.ChangeQuantityProperty, chanTwoBinding);
            dollarControls.Children.Add(custTwoControl);

            CurrencyControl custOneControl = new CurrencyControl() { Label = "$1", CustomerQuantity = register.CustomerOnes, ChangeQuantity = register.ChangeOnes };
            Binding custOneBinding = new Binding("CustomerOnes");
            custOneBinding.Source = register;
            custOneBinding.Mode = BindingMode.TwoWay;
            custOneBinding.UpdateSourceTrigger = UpdateSourceTrigger.PropertyChanged;
            BindingOperations.SetBinding(custOneControl, CurrencyControl.CustomerQuantityProperty, custOneBinding);
            Binding chanOneBinding = new Binding("ChangeOnes");
            chanOneBinding.Source = register;
            chanOneBinding.Mode = BindingMode.OneWay;
            chanOneBinding.UpdateSourceTrigger = UpdateSourceTrigger.PropertyChanged;
            BindingOperations.SetBinding(custOneControl, CurrencyControl.ChangeQuantityProperty, chanOneBinding);
            dollarControls.Children.Add(custOneControl);

            CurrencyControl custDollarControl = new CurrencyControl() { Label = "$1", CustomerQuantity = register.CustomerDollars, ChangeQuantity = register.ChangeDollars };
            Binding custDollarBinding = new Binding("CustomerDollars");
            custDollarBinding.Source = register;
            custDollarBinding.Mode = BindingMode.TwoWay;
            custDollarBinding.UpdateSourceTrigger = UpdateSourceTrigger.PropertyChanged;
            BindingOperations.SetBinding(custDollarControl, CurrencyControl.CustomerQuantityProperty, custDollarBinding);
            Binding chanDollarBinding = new Binding("ChangeDollars");
            chanDollarBinding.Source = register;
            chanDollarBinding.Mode = BindingMode.OneWay;
            chanDollarBinding.UpdateSourceTrigger = UpdateSourceTrigger.PropertyChanged;
            BindingOperations.SetBinding(custDollarControl, CurrencyControl.ChangeQuantityProperty, chanDollarBinding);
            coinControls.Children.Add(custDollarControl);

            CurrencyControl custHalfDollarControl = new CurrencyControl() { Label = "50¢", CustomerQuantity = register.CustomerHalfDollars, ChangeQuantity = register.ChangeHalfDollars };
            Binding custHalfDollarBinding = new Binding("CustomerHalfDollars");
            custHalfDollarBinding.Source = register;
            custHalfDollarBinding.Mode = BindingMode.TwoWay;
            custHalfDollarBinding.UpdateSourceTrigger = UpdateSourceTrigger.PropertyChanged;
            BindingOperations.SetBinding(custHalfDollarControl, CurrencyControl.CustomerQuantityProperty, custHalfDollarBinding);
            Binding chanHalfDollarBinding = new Binding("ChangeHalfDollars");
            chanHalfDollarBinding.Source = register;
            chanHalfDollarBinding.Mode = BindingMode.OneWay;
            chanHalfDollarBinding.UpdateSourceTrigger = UpdateSourceTrigger.PropertyChanged;
            BindingOperations.SetBinding(custHalfDollarControl, CurrencyControl.ChangeQuantityProperty, chanHalfDollarBinding);
            coinControls.Children.Add(custHalfDollarControl);

            CurrencyControl custQuarterControl = new CurrencyControl() { Label = "25¢", CustomerQuantity = register.CustomerQuarters, ChangeQuantity = register.ChangeQuarters };
            Binding custQuarterBinding = new Binding("CustomerQuarters");
            custQuarterBinding.Source = register;
            custQuarterBinding.Mode = BindingMode.TwoWay;
            custQuarterBinding.UpdateSourceTrigger = UpdateSourceTrigger.PropertyChanged;
            BindingOperations.SetBinding(custQuarterControl, CurrencyControl.CustomerQuantityProperty, custQuarterBinding);
            Binding chanQuarterBinding = new Binding("ChangeQuarters");
            chanQuarterBinding.Source = register;
            chanQuarterBinding.Mode = BindingMode.OneWay;
            chanQuarterBinding.UpdateSourceTrigger = UpdateSourceTrigger.PropertyChanged;
            BindingOperations.SetBinding(custQuarterControl, CurrencyControl.ChangeQuantityProperty, chanQuarterBinding);
            coinControls.Children.Add(custQuarterControl);

            CurrencyControl custDimeControl = new CurrencyControl() { Label = "10¢", CustomerQuantity = register.CustomerDimes, ChangeQuantity = register.ChangeDimes };
            Binding custDimeBinding = new Binding("CustomerDimes");
            custDimeBinding.Source = register;
            custDimeBinding.Mode = BindingMode.TwoWay;
            custDimeBinding.UpdateSourceTrigger = UpdateSourceTrigger.PropertyChanged;
            BindingOperations.SetBinding(custDimeControl, CurrencyControl.CustomerQuantityProperty, custDimeBinding);
            Binding chanDimeBinding = new Binding("ChangeDimes");
            chanDimeBinding.Source = register;
            chanDimeBinding.Mode = BindingMode.OneWay;
            chanDimeBinding.UpdateSourceTrigger = UpdateSourceTrigger.PropertyChanged;
            BindingOperations.SetBinding(custDimeControl, CurrencyControl.ChangeQuantityProperty, chanDimeBinding);
            coinControls.Children.Add(custDimeControl);

            CurrencyControl custNickelControl = new CurrencyControl() { Label = "5¢", CustomerQuantity = register.CustomerNickels, ChangeQuantity = register.ChangeNickels };
            Binding custNickelBinding = new Binding("CustomerNickels");
            custNickelBinding.Source = register;
            custNickelBinding.Mode = BindingMode.TwoWay;
            custNickelBinding.UpdateSourceTrigger = UpdateSourceTrigger.PropertyChanged;
            BindingOperations.SetBinding(custNickelControl, CurrencyControl.CustomerQuantityProperty, custNickelBinding);
            Binding chanNickelBinding = new Binding("ChangeNickels");
            chanNickelBinding.Source = register;
            chanNickelBinding.Mode = BindingMode.OneWay;
            chanNickelBinding.UpdateSourceTrigger = UpdateSourceTrigger.PropertyChanged;
            BindingOperations.SetBinding(custNickelControl, CurrencyControl.ChangeQuantityProperty, chanNickelBinding);
            coinControls.Children.Add(custNickelControl);

            CurrencyControl custPennyControl = new CurrencyControl() { Label = "1¢", CustomerQuantity = register.CustomerPennies, ChangeQuantity = register.ChangePennies };
            Binding custPennyBinding = new Binding("CustomerPennies");
            custPennyBinding.Source = register;
            custPennyBinding.Mode = BindingMode.TwoWay;
            custPennyBinding.UpdateSourceTrigger = UpdateSourceTrigger.PropertyChanged;
            BindingOperations.SetBinding(custPennyControl, CurrencyControl.CustomerQuantityProperty, custPennyBinding);
            Binding chanPennyBinding = new Binding("ChangePennies");
            chanPennyBinding.Source = register;
            chanPennyBinding.Mode = BindingMode.OneWay;
            chanPennyBinding.UpdateSourceTrigger = UpdateSourceTrigger.PropertyChanged;
            BindingOperations.SetBinding(custPennyControl, CurrencyControl.ChangeQuantityProperty, chanPennyBinding);
            coinControls.Children.Add(custPennyControl);
        }


        private void ReturnToOrder(object sender, RoutedEventArgs e)
        {
            mainWindow.OpenMainMenu();
        }

        private void FinalizeSale(object sender, RoutedEventArgs e)
        {
            register.CompleteTransaction();
            mainWindow.NewOrder();
            mainWindow.OpenMainMenu();
        }
    }
}
