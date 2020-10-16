/*
 * Author: Cole Kaster
 * Class: OrderTests.cs
 * Purpose: Tests the Order.cs class in the Data library
 */

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data.Sides;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Text;
using Xunit;

namespace BleakwindBuffet.DataTests.UnitTests
{
    public class OrderTests
    {
        [Fact]
        public void ShouldStartEmpty()
        {
            Order order = new Order();
            Assert.Empty(order);
        }

        [Fact]
        public void ShouldAddItem()
        {
            Order order = new Order();
            Assert.Empty(order);
            order.Add(new BriarheartBurger());
            Assert.NotEmpty(order);
        }

        [Fact]
        public void ShouldRemoveItem()
        {
            Order order = new Order();
            BriarheartBurger bb = new BriarheartBurger();
            order.Add(bb);
            Assert.NotEmpty(order);
            order.Remove(bb);
            Assert.Empty(order);
        }

        [Fact]
        public void ShouldImplementICollection()
        {
            Order order = new Order();
            Assert.IsAssignableFrom<ICollection<IOrderItem>>(order);
        }

        [Fact]
        public void ShouldImplementINotifyCollectionChanged()
        {
            Order order = new Order();
            Assert.IsAssignableFrom<INotifyCollectionChanged>(order);
        }

        [Fact]
        public void ShouldImplementINotifyPropertyChanged()
        {
            Order order = new Order();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(order);
        }

        [Fact]
        public void ShouldGetCorrectCalories()
        {
            Order order = new Order();
            uint calories = 56;
            order.Add(new MarkarthMilk());
            Assert.Equal(calories, order.Calories);
            order.Add(new VokunSalad());
            calories += 41;
            Assert.Equal(calories, order.Calories);
            order.Add(new BriarheartBurger());
            calories += 743;
            Assert.Equal(calories, order.Calories);
        }

        [Fact]
        public void ShouldGetSalesTaxRate()
        {
            Order order = new Order();
            Assert.Equal(0.12, order.SalesTaxRate);
            order.SalesTaxRate = 0.15;
            Assert.Equal(0.15, order.SalesTaxRate);
        }

        [Fact]
        public void ShouldGetCorrectSubtotal()
        {
            Order order = new Order();
            Assert.Equal(0.00, order.Subtotal);
            order.Add(new BriarheartBurger());
            Assert.Equal(6.32, order.Subtotal);
            order.Add(new VokunSalad());
            Assert.Equal(7.25, order.Subtotal);
            order.Add(new MarkarthMilk());
            Assert.Equal(8.30, order.Subtotal);
        }

        [Fact]
        public void ShouldGetCorrectTax()
        {
            Order order = new Order();
            Assert.Equal(0.00, order.Tax);
            order.Add(new BriarheartBurger());
            double tax = 0.12 * 6.32;
            tax = Math.Round(tax, 2);
            Assert.Equal(tax, order.Tax);
            order.Add(new VokunSalad());
            tax = 0.12 * 7.25;
            tax = Math.Round(tax, 2);
            Assert.Equal(tax, order.Tax);
            order.Add(new MarkarthMilk());
            tax = 0.12 * 8.30;
            tax = Math.Round(tax, 2);
            Assert.Equal(tax, order.Tax);
        }

        [Fact]
        public void ShouldGetCorrectTotal()
        {
            Order order = new Order();
            double total = 0.00;
            order.Add(new BriarheartBurger());
            total += 6.32;
            total += 0.12 * total;
            total = Math.Round(total, 2);
            Assert.Equal(total, order.Total);
            order.Add(new VokunSalad());
            Assert.Equal(8.12, order.Total);
        }

        [Fact]
        public void ShouldGetCorrectNumber()
        {
            Order order = new Order();
            uint number = 1;
            Assert.Equal(number, order.Number);
            Order order2 = new Order();
            number = 2;
            Assert.Equal(number, order2.Number);
        }

        [Fact]
        public void ShouldClearOrder()
        {
            Order order = new Order();
            order.Add(new BriarheartBurger());
            order.Clear();
            Assert.Empty(order);
        }

        [Fact]
        public void ShouldGetCorrectContains()
        {
            Order order = new Order();
            BriarheartBurger bb = new BriarheartBurger();
            order.Add(bb);
            Assert.Contains(bb, order);
        }

        [Fact]
        public void ShouldGetCorrectCount()
        {
            Order order = new Order();
            Assert.Empty(order);
            order.Add(new BriarheartBurger());
            Assert.Single(order);
            order.Add(new VokunSalad());
            Assert.Equal(2, order.Count);
        }

        [Fact]
        public void ShouldBeReadOnly()
        {
            Order order = new Order();
            Assert.False(order.IsReadOnly);
        }

        [Fact]
        public void AddingItemShouldChangeProperties()
        {
            Order order = new Order();
            Assert.PropertyChanged(order, "Subtotal", () =>
            {
                order.Add(new BriarheartBurger());
            });
            Assert.PropertyChanged(order, "Tax", () =>
            {
                order.Add(new BriarheartBurger());
            });
            Assert.PropertyChanged(order, "Total", () =>
            {
                order.Add(new BriarheartBurger());
            });
            Assert.PropertyChanged(order, "Calories", () =>
            {
                order.Add(new BriarheartBurger());
            });
        }

        [Fact]
        public void RemovingItemShouldChangeProperties()
        {
            Order order = new Order();
            BriarheartBurger bb = new BriarheartBurger();
            order.Add(bb);
            Assert.PropertyChanged(order, "Subtotal", () =>
            {
                order.Remove(bb);
            });
            order.Add(bb);
            Assert.PropertyChanged(order, "Tax", () =>
            {
                order.Remove(bb);
            });
            order.Add(bb);
            Assert.PropertyChanged(order, "Total", () =>
            {
                order.Remove(bb);
            });
            order.Add(bb);
            Assert.PropertyChanged(order, "Calories", () =>
            {
                order.Remove(bb);
            });
        }
    }
}
