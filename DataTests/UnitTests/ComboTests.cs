/*
 * Author: Cole Kaster
 * Class: ComboTests.cs
 * Purpose: Tests the Combo.cs class in the Data library
 */

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data.Sides;
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using Xunit;

namespace BleakwindBuffet.DataTests.UnitTests
{
    /// <summary>
    /// Tests the Combo.cs class
    /// </summary>
    public class ComboTests
    {
        [Fact]
        public void ShouldAddEntree()
        {
            Combo combo = new Combo(new DoubleDraugr(), new VokunSalad(), new SailorSoda());
            BriarheartBurger bb = new BriarheartBurger();
            combo.Entree = bb;
            Assert.Equal(bb, combo.Entree);
        }

        [Fact]
        public void ShouldAddSide()
        {
            Combo combo = new Combo(new DoubleDraugr(), new DragonbornWaffleFries(), new SailorSoda());
            VokunSalad vs = new VokunSalad();
            combo.Side = vs;
            Assert.Equal(vs, combo.Side);
        }

        [Fact]
        public void ShouldAddDrink()
        {
            Combo combo = new Combo(new DoubleDraugr(), new DragonbornWaffleFries(), new SailorSoda());
            MarkarthMilk mm = new MarkarthMilk();
            combo.Drink = mm;
            Assert.Equal(mm, combo.Drink);
        }

        [Fact]
        public void ShouldGetCorrectPrice()
        {
            Combo combo = new Combo(new BriarheartBurger(), new VokunSalad(), new MarkarthMilk());
            Assert.Equal(7.30, combo.Price);
        }

        [Fact]
        public void ShouldGetCorrectCalories()
        {
            Combo combo = new Combo(new BriarheartBurger(), new VokunSalad(), new MarkarthMilk());
            uint calories = 840;
            Assert.Equal(calories, combo.Calories);
        }

        [Fact]
        public void ShouldGetCorrectSpecialInstructions()
        {
            Combo combo = new Combo(new BriarheartBurger(), new VokunSalad(), new MarkarthMilk());
            List<string> instructions = new List<string>();
            instructions.Add("Briarheart Burger");
            instructions.Add("Small Vokun Salad");
            instructions.Add("Small Markarth Milk");
            Assert.Equal(instructions, combo.SpecialInstructions);
        }

        [Fact]
        public void ImplementsNotifyPropertyInterface()
        {
            Combo combo = new Combo(new BriarheartBurger(), new VokunSalad(), new MarkarthMilk());
            Assert.IsAssignableFrom<INotifyPropertyChanged>(combo);
        }

        [Fact]
        public void ImplementsIOrderItemInterface()
        {
            Combo combo = new Combo(new BriarheartBurger(), new VokunSalad(), new MarkarthMilk());
            Assert.IsAssignableFrom<IOrderItem>(combo);
        }

        [Fact]
        public void ChangingEntreeNotifiesEntreeProperty()
        {
            Combo combo = new Combo(new BriarheartBurger(), new VokunSalad(), new MarkarthMilk());

            Assert.PropertyChanged(combo, "Entree", () =>
            {
                combo.Entree = new BriarheartBurger();
            });

            Assert.PropertyChanged(combo, "Entree", () =>
            {
                combo.Entree = new DoubleDraugr();
            });
        }

        [Fact]
        public void ChangingEntreeNotifiesPriceProperty()
        {
            Combo combo = new Combo(new BriarheartBurger(), new VokunSalad(), new MarkarthMilk());

            Assert.PropertyChanged(combo, "Price", () =>
            {
                combo.Entree = new BriarheartBurger();
            });

            Assert.PropertyChanged(combo, "Price", () =>
            {
                combo.Entree = new DoubleDraugr();
            });
        }

        [Fact]
        public void ChangingEntreeNotifiesCaloriesProperty()
        {
            Combo combo = new Combo(new BriarheartBurger(), new VokunSalad(), new MarkarthMilk());

            Assert.PropertyChanged(combo, "Calories", () =>
            {
                combo.Entree = new BriarheartBurger();
            });

            Assert.PropertyChanged(combo, "Calories", () =>
            {
                combo.Entree = new DoubleDraugr();
            });
        }

        [Fact]
        public void ChangingEntreeNotifiesSpecialInstructionsProperty()
        {
            Combo combo = new Combo(new BriarheartBurger(), new VokunSalad(), new MarkarthMilk());

            Assert.PropertyChanged(combo, "SpecialInstructions", () =>
            {
                combo.Entree = new BriarheartBurger();
            });

            Assert.PropertyChanged(combo, "SpecialInstructions", () =>
            {
                combo.Entree = new DoubleDraugr();
            });
        }

        [Fact]
        public void ChangingSideNotifiesSideProperty()
        {
            Combo combo = new Combo(new BriarheartBurger(), new VokunSalad(), new MarkarthMilk());

            Assert.PropertyChanged(combo, "Side", () =>
            {
                combo.Side = new VokunSalad();
            });

            Assert.PropertyChanged(combo, "Side", () =>
            {
                combo.Side = new DragonbornWaffleFries();
            });
        }

        [Fact]
        public void ChangingSideNotifiesPriceProperty()
        {
            Combo combo = new Combo(new BriarheartBurger(), new VokunSalad(), new MarkarthMilk());

            Assert.PropertyChanged(combo, "Price", () =>
            {
                combo.Side = new VokunSalad();
            });

            Assert.PropertyChanged(combo, "Price", () =>
            {
                combo.Side = new DragonbornWaffleFries();
            });
        }

        [Fact]
        public void ChangingSideNotifiesCaloriesProperty()
        {
            Combo combo = new Combo(new BriarheartBurger(), new VokunSalad(), new MarkarthMilk());

            Assert.PropertyChanged(combo, "Calories", () =>
            {
                combo.Side = new VokunSalad();
            });

            Assert.PropertyChanged(combo, "Calories", () =>
            {
                combo.Side = new DragonbornWaffleFries();
            });
        }

        [Fact]
        public void ChangingSideNotifiesSpecialInstructionsProperty()
        {
            Combo combo = new Combo(new BriarheartBurger(), new VokunSalad(), new MarkarthMilk());

            Assert.PropertyChanged(combo, "SpecialInstructions", () =>
            {
                combo.Side = new VokunSalad();
            });

            Assert.PropertyChanged(combo, "SpecialInstructions", () =>
            {
                combo.Side = new DragonbornWaffleFries();
            });
        }

        [Fact]
        public void ChangingDrinkNotifiesDrinkProperty()
        {
            Combo combo = new Combo(new BriarheartBurger(), new VokunSalad(), new MarkarthMilk());

            Assert.PropertyChanged(combo, "Drink", () =>
            {
                combo.Drink = new MarkarthMilk();
            });

            Assert.PropertyChanged(combo, "Drink", () =>
            {
                combo.Drink = new SailorSoda();
            });
        }

        [Fact]
        public void ChangingDrinkNotifiesPriceProperty()
        {
            Combo combo = new Combo(new BriarheartBurger(), new VokunSalad(), new MarkarthMilk());

            Assert.PropertyChanged(combo, "Price", () =>
            {
                combo.Drink = new MarkarthMilk();
            });

            Assert.PropertyChanged(combo, "Price", () =>
            {
                combo.Drink = new SailorSoda();
            });
        }

        [Fact]
        public void ChangingDrinkNotifiesCaloriesProperty()
        {
            Combo combo = new Combo(new BriarheartBurger(), new VokunSalad(), new MarkarthMilk());

            Assert.PropertyChanged(combo, "Calories", () =>
            {
                combo.Drink = new MarkarthMilk();
            });

            Assert.PropertyChanged(combo, "Calories", () =>
            {
                combo.Drink = new SailorSoda();
            });
        }

        [Fact]
        public void ChangingDrinkNotifiesSpecialInstructionsProperty()
        {
            Combo combo = new Combo(new BriarheartBurger(), new VokunSalad(), new MarkarthMilk());

            Assert.PropertyChanged(combo, "SpecialInstructions", () =>
            {
                combo.Drink = new MarkarthMilk();
            });

            Assert.PropertyChanged(combo, "SpecialInstructions", () =>
            {
                combo.Drink = new SailorSoda();
            });
        }

        [Fact]
        public void ChangingSidePriceNotifiesPriceProperty()
        {
            Combo combo = new Combo(new BriarheartBurger(), new VokunSalad(), new MarkarthMilk());
            VokunSalad vs = new VokunSalad();
            combo.Side = vs;

            Assert.PropertyChanged(combo, "Price", () =>
            {
                vs.Size = Data.Enums.Size.Medium;
            });
        }

        [Fact]
        public void ChangingDrinkPriceNotifiesPriceProperty()
        {
            Combo combo = new Combo(new BriarheartBurger(), new VokunSalad(), new MarkarthMilk());
            MarkarthMilk mm = new MarkarthMilk();
            combo.Drink = mm;

            Assert.PropertyChanged(combo, "Price", () =>
            {
                mm.Size = Data.Enums.Size.Medium;
            });
        }

        [Fact]
        public void ChangingEntreeSpecialInstructionsNotifiesSpecialInstructionsProperty()
        {
            Combo combo = new Combo(new BriarheartBurger(), new VokunSalad(), new MarkarthMilk());
            BriarheartBurger bb = new BriarheartBurger();
            combo.Entree = bb;

            Assert.PropertyChanged(combo, "SpecialInstructions", () =>
            {
                bb.Bun = false;
            });
        }

        [Fact]
        public void ChangingSideSpecialInstructionsNotifiesSpecialInstructionsProperty()
        {
            Combo combo = new Combo(new BriarheartBurger(), new VokunSalad(), new MarkarthMilk());
            VokunSalad vs = new VokunSalad();
            combo.Side = vs;

            Assert.PropertyChanged(combo, "SpecialInstructions", () =>
            {
                vs.Size = Data.Enums.Size.Medium;
            });
        }

        [Fact]
        public void ChangingDrinkSpecialInstructionsNotifiesSpecialInstructionsProperty()
        {
            Combo combo = new Combo(new BriarheartBurger(), new VokunSalad(), new MarkarthMilk());
            MarkarthMilk mm = new MarkarthMilk();
            combo.Drink = mm;

            Assert.PropertyChanged(combo, "SpecialInstructions", () =>
            {
                mm.Size = Data.Enums.Size.Medium;
            });
        }
    }
}
