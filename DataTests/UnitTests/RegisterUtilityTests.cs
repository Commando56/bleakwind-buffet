using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using PointOfSale;
using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Entrees;
using System.Net.Http.Headers;

namespace BleakwindBuffet.DataTests.UnitTests
{
    public class RegisterUtilityTests
    {
        [Fact]
        public void ChangingCustomerHundredsPropertyShouldInvokeChange()
        {
            RegisterUtility registerUtility = new RegisterUtility(new Order());
            Assert.PropertyChanged(registerUtility, "AmountDue", () =>
            {
                registerUtility.CustomerHundreds = 1;
            });
            Assert.PropertyChanged(registerUtility, "CustomerHundreds", () =>
            {
                registerUtility.CustomerHundreds = 0;
            });
        }

        [Fact]
        public void ChangingCustomerFiftiesPropertyShouldInvokeChange()
        {
            RegisterUtility registerUtility = new RegisterUtility(new Order());
            Assert.PropertyChanged(registerUtility, "AmountDue", () =>
            {
                registerUtility.CustomerFifties = 1;
            });
            Assert.PropertyChanged(registerUtility, "CustomerFifties", () =>
            {
                registerUtility.CustomerFifties = 0;
            });
        }

        [Fact]
        public void ChangingCustomerTwentiesPropertyShouldInvokeChange()
        {
            RegisterUtility registerUtility = new RegisterUtility(new Order());
            Assert.PropertyChanged(registerUtility, "AmountDue", () =>
            {
                registerUtility.CustomerTwenties = 1;
            });
            Assert.PropertyChanged(registerUtility, "CustomerTwenties", () =>
            {
                registerUtility.CustomerTwenties = 0;
            });
        }

        [Fact]
        public void ChangingCustomerTensPropertyShouldInvokeChange()
        {
            RegisterUtility registerUtility = new RegisterUtility(new Order());
            Assert.PropertyChanged(registerUtility, "AmountDue", () =>
            {
                registerUtility.CustomerTens = 1;
            });
            Assert.PropertyChanged(registerUtility, "CustomerTens", () =>
            {
                registerUtility.CustomerTens = 0;
            });
        }

        [Fact]
        public void ChangingCustomerFivesPropertyShouldInvokeChange()
        {
            RegisterUtility registerUtility = new RegisterUtility(new Order());
            Assert.PropertyChanged(registerUtility, "AmountDue", () =>
            {
                registerUtility.CustomerFives = 1;
            });
            Assert.PropertyChanged(registerUtility, "CustomerFives", () =>
            {
                registerUtility.CustomerFives = 0;
            });
        }

        [Fact]
        public void ChangingCustomerTwosPropertyShouldInvokeChange()
        {
            RegisterUtility registerUtility = new RegisterUtility(new Order());
            Assert.PropertyChanged(registerUtility, "AmountDue", () =>
            {
                registerUtility.CustomerTwos = 1;
            });
            Assert.PropertyChanged(registerUtility, "CustomerTwos", () =>
            {
                registerUtility.CustomerTwos = 0;
            });
        }

        [Fact]
        public void ChangingCustomerOnesPropertyShouldInvokeChange()
        {
            RegisterUtility registerUtility = new RegisterUtility(new Order());
            Assert.PropertyChanged(registerUtility, "AmountDue", () =>
            {
                registerUtility.CustomerOnes = 1;
            });
            Assert.PropertyChanged(registerUtility, "CustomerOnes", () =>
            {
                registerUtility.CustomerOnes = 0;
            });
        }

        [Fact]
        public void ChangingCustomerDollarsPropertyShouldInvokeChange()
        {
            RegisterUtility registerUtility = new RegisterUtility(new Order());
            Assert.PropertyChanged(registerUtility, "AmountDue", () =>
            {
                registerUtility.CustomerDollars = 1;
            });
            Assert.PropertyChanged(registerUtility, "CustomerDollars", () =>
            {
                registerUtility.CustomerDollars = 0;
            });
        }

        [Fact]
        public void ChangingCustomerHalfDollarsPropertyShouldInvokeChange()
        {
            RegisterUtility registerUtility = new RegisterUtility(new Order());
            Assert.PropertyChanged(registerUtility, "AmountDue", () =>
            {
                registerUtility.CustomerHalfDollars = 1;
            });
            Assert.PropertyChanged(registerUtility, "CustomerHalfDollars", () =>
            {
                registerUtility.CustomerHalfDollars = 0;
            });
        }

        [Fact]
        public void ChangingCustomerQuartersPropertyShouldInvokeChange()
        {
            RegisterUtility registerUtility = new RegisterUtility(new Order());
            Assert.PropertyChanged(registerUtility, "AmountDue", () =>
            {
                registerUtility.CustomerQuarters = 1;
            });
            Assert.PropertyChanged(registerUtility, "CustomerQuarters", () =>
            {
                registerUtility.CustomerQuarters = 0;
            });
        }

        [Fact]
        public void ChangingCustomerDimesPropertyShouldInvokeChange()
        {
            RegisterUtility registerUtility = new RegisterUtility(new Order());
            Assert.PropertyChanged(registerUtility, "AmountDue", () =>
            {
                registerUtility.CustomerDimes = 1;
            });
            Assert.PropertyChanged(registerUtility, "CustomerDimes", () =>
            {
                registerUtility.CustomerDimes = 0;
            });
        }

        [Fact]
        public void ChangingCustomerNickelsPropertyShouldInvokeChange()
        {
            RegisterUtility registerUtility = new RegisterUtility(new Order());
            Assert.PropertyChanged(registerUtility, "AmountDue", () =>
            {
                registerUtility.CustomerNickels = 1;
            });
            Assert.PropertyChanged(registerUtility, "CustomerNickels", () =>
            {
                registerUtility.CustomerNickels = 0;
            });
        }

        [Fact]
        public void ChangingCustomerPenniesPropertyShouldInvokeChange()
        {
            RegisterUtility registerUtility = new RegisterUtility(new Order());
            Assert.PropertyChanged(registerUtility, "AmountDue", () =>
            {
                registerUtility.CustomerPennies = 1;
            });
            Assert.PropertyChanged(registerUtility, "CustomerPennies", () =>
            {
                registerUtility.CustomerPennies = 0;
            });
        }

        [Fact]
        public void ShouldGetCorrectAmountDue()
        {
            Order order = new Order();
            order.Add(new BriarheartBurger());
            RegisterUtility registerUtility = new RegisterUtility(order);
            Assert.Equal("$7.08", registerUtility.AmountDue);
        }

        [Fact]
        public void ShouldGetCorrectChangeHundreds()
        {
            Order order = new Order();
            order.Add(new BriarheartBurger());
            RegisterUtility registerUtility = new RegisterUtility(order);
            Assert.Equal(0, registerUtility.ChangeHundreds);
            registerUtility.CustomerHundreds = 1;
            Assert.Equal("$92.92", registerUtility.ChangeOwed);
            Assert.Equal(0, registerUtility.ChangeHundreds);
            registerUtility.CustomerHundreds = 2;
            Assert.Equal("$192.92", registerUtility.ChangeOwed);
            Assert.Equal(1, registerUtility.ChangeHundreds);
        }

        [Fact]
        public void ShouldGetCorrectChangeFifties()
        {
            Order order = new Order();
            order.Add(new BriarheartBurger());
            RegisterUtility registerUtility = new RegisterUtility(order);
            Assert.Equal(0, registerUtility.ChangeFifties);
            registerUtility.CustomerFifties = 1;
            Assert.Equal("$42.92", registerUtility.ChangeOwed);
            Assert.Equal(0, registerUtility.ChangeFifties);
            registerUtility.CustomerFifties = 2;
            Assert.Equal("$92.92", registerUtility.ChangeOwed);
            Assert.Equal(1, registerUtility.ChangeFifties);
        }

        [Fact]
        public void ShouldGetCorrectChangeTwenties()
        {
            Order order = new Order();
            order.Add(new BriarheartBurger());
            RegisterUtility registerUtility = new RegisterUtility(order);
            Assert.Equal(0, registerUtility.ChangeTwenties);
            registerUtility.CustomerTwenties = 1;
            Assert.Equal("$12.92", registerUtility.ChangeOwed);
            Assert.Equal(0, registerUtility.ChangeTwenties);
            registerUtility.CustomerTwenties = 2;
            Assert.Equal("$32.92", registerUtility.ChangeOwed);
            Assert.Equal(1, registerUtility.ChangeTwenties);
        }

        [Fact]
        public void ShouldGetCorrectChangeTens()
        {
            Order order = new Order();
            order.Add(new BriarheartBurger());
            RegisterUtility registerUtility = new RegisterUtility(order);
            Assert.Equal(0, registerUtility.ChangeTens);
            registerUtility.CustomerTens = 1;
            Assert.Equal("$2.92", registerUtility.ChangeOwed);
            Assert.Equal(0, registerUtility.ChangeTens);
            registerUtility.CustomerTens = 2;
            Assert.Equal("$12.92", registerUtility.ChangeOwed);
            Assert.Equal(1, registerUtility.ChangeTens);
        }

        [Fact]
        public void ShouldGetCorrectChangeFives()
        {
            Order order = new Order();
            order.Add(new BriarheartBurger());
            RegisterUtility registerUtility = new RegisterUtility(order);
            Assert.Equal(0, registerUtility.ChangeFives);
            registerUtility.CustomerFives = 1;
            Assert.Equal("$0.00", registerUtility.ChangeOwed);
            Assert.Equal(0, registerUtility.ChangeFives);
            registerUtility.CustomerFives = 3;
            Assert.Equal("$7.92", registerUtility.ChangeOwed);
            Assert.Equal(1, registerUtility.ChangeFives);
        }

        [Fact]
        public void ShouldGetCorrectChangeTwos()
        {
            Order order = new Order();
            order.Add(new BriarheartBurger());
            RegisterUtility registerUtility = new RegisterUtility(order);
            Assert.Equal(0, registerUtility.ChangeTwos);
            registerUtility.CustomerTwos = 3;
            Assert.Equal("$0.00", registerUtility.ChangeOwed);
            Assert.Equal(0, registerUtility.ChangeTwos);
            registerUtility.CustomerTwos = 5;
            Assert.Equal("$2.92", registerUtility.ChangeOwed);
            Assert.Equal(1, registerUtility.ChangeTwos);
        }

        [Fact]
        public void ShouldGetCorrectChangeOnes()
        {
            Order order = new Order();
            order.Add(new BriarheartBurger());
            RegisterUtility registerUtility = new RegisterUtility(order);
            Assert.Equal(0, registerUtility.ChangeOnes);
            registerUtility.CustomerOnes = 7;
            Assert.Equal("$0.00", registerUtility.ChangeOwed);
            Assert.Equal(0, registerUtility.ChangeOnes);
            registerUtility.CustomerOnes = 9;
            Assert.Equal("$1.92", registerUtility.ChangeOwed);
            Assert.Equal(1, registerUtility.ChangeOnes);
        }

        [Fact]
        public void ShouldGetCorrectChangeHalfDollars()
        {
            Order order = new Order();
            order.Add(new BriarheartBurger());
            RegisterUtility registerUtility = new RegisterUtility(order);
            Assert.Equal(0, registerUtility.ChangeHalfDollars);
            registerUtility.CustomerHalfDollars = 14;
            Assert.Equal("$0.00", registerUtility.ChangeOwed);
            Assert.Equal(0, registerUtility.ChangeHalfDollars);
            registerUtility.CustomerHalfDollars = 16;
            Assert.Equal("$0.92", registerUtility.ChangeOwed);
            Assert.Equal(1, registerUtility.ChangeHalfDollars);
        }

        [Fact]
        public void ShouldGetCorrectChangeQuarters()
        {
            Order order = new Order();
            order.Add(new BriarheartBurger());
            RegisterUtility registerUtility = new RegisterUtility(order);
            Assert.Equal(0, registerUtility.ChangeQuarters);
            registerUtility.CustomerQuarters = 28;
            Assert.Equal("$0.00", registerUtility.ChangeOwed);
            Assert.Equal(0, registerUtility.ChangeQuarters);
            registerUtility.CustomerQuarters = 30;
            Assert.Equal("$0.42", registerUtility.ChangeOwed);
            Assert.Equal(1, registerUtility.ChangeQuarters);
        }

        [Fact]
        public void ShouldGetCorrectChangeDimes()
        {
            Order order = new Order();
            order.Add(new BriarheartBurger());
            RegisterUtility registerUtility = new RegisterUtility(order);
            Assert.Equal(0, registerUtility.ChangeDimes);
            registerUtility.CustomerDimes = 70;
            Assert.Equal("$0.00", registerUtility.ChangeOwed);
            Assert.Equal(0, registerUtility.ChangeDimes);
            registerUtility.CustomerDimes = 72;
            Assert.Equal("$0.12", registerUtility.ChangeOwed);
            Assert.Equal(1, registerUtility.ChangeDimes);
        }

        [Fact]
        public void ShouldGetCorrectChangeNickels()
        {
            Order order = new Order();
            order.Add(new BriarheartBurger());
            RegisterUtility registerUtility = new RegisterUtility(order);
            Assert.Equal(0, registerUtility.ChangeNickels);
            registerUtility.CustomerNickels = 140;
            Assert.Equal("$0.00", registerUtility.ChangeOwed);
            Assert.Equal(0, registerUtility.ChangeNickels);
            registerUtility.CustomerNickels = 143;
            Assert.Equal("$0.07", registerUtility.ChangeOwed);
            Assert.Equal(1, registerUtility.ChangeNickels);
        }

        [Fact]
        public void ShouldGetCorrectChangePennies()
        {
            Order order = new Order();
            order.Add(new BriarheartBurger());
            RegisterUtility registerUtility = new RegisterUtility(order);
            Assert.Equal(0, registerUtility.ChangePennies);
            registerUtility.CustomerPennies = 708;
            Assert.Equal("$0", registerUtility.ChangeOwed);
            Assert.Equal(0, registerUtility.ChangePennies);
            registerUtility.CustomerPennies = 709;
            Assert.Equal("$0.01", registerUtility.ChangeOwed);
            Assert.Equal(1, registerUtility.ChangePennies);
        }
    }
}
