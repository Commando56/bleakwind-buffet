/*
 * Author: Cole Kaster
 * Class name: Menu.cs
 * Purpose: Represents the full menu at Bleakwind Buffet
 */

using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data.Enums;
using BleakwindBuffet.Data.Sides;
using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data
{
    /// <summary>
    /// A class holding IEnumerables of all the menu items
    /// </summary>
    public static class Menu
    {
        /// <summary>
        /// Holds all of the entree options
        /// </summary>
        /// <returns>
        /// An IEnumerable of IOrderItem
        /// </returns>
        public static IEnumerable<IOrderItem> Entrees()
        {
            List<IOrderItem> entrees = new List<IOrderItem>();
            entrees.Add(new BriarheartBurger());
            entrees.Add(new DoubleDraugr());
            entrees.Add(new GardenOrcOmelette());
            entrees.Add(new PhillyPoacher());
            entrees.Add(new SmokehouseSkeleton());
            entrees.Add(new ThalmorTriple());
            entrees.Add(new ThugsTBone());
            return entrees;
        }

        /// <summary>
        /// Holds all of the side options
        /// </summary>
        /// <returns>
        /// An IEnumerable of IOrderItem
        /// </returns>
        public static IEnumerable<IOrderItem> Sides()
        {
            List<IOrderItem> sides = new List<IOrderItem>();
            sides.Add(new DragonbornWaffleFries());
            DragonbornWaffleFries mediumFries = new DragonbornWaffleFries();
            mediumFries.Size = Size.Medium;
            sides.Add(mediumFries);
            DragonbornWaffleFries largeFries = new DragonbornWaffleFries();
            largeFries.Size = Size.Large;
            sides.Add(largeFries);
            sides.Add(new FriedMiraak());
            FriedMiraak mediumMiraak = new FriedMiraak();
            mediumMiraak.Size = Size.Medium;
            sides.Add(mediumMiraak);
            FriedMiraak largeMiraak = new FriedMiraak();
            largeMiraak.Size = Size.Large;
            sides.Add(largeMiraak);
            sides.Add(new MadOtarGrits());
            MadOtarGrits mediumGrits = new MadOtarGrits();
            mediumGrits.Size = Size.Medium;
            sides.Add(mediumGrits);
            MadOtarGrits largeGrits = new MadOtarGrits();
            largeGrits.Size = Size.Large;
            sides.Add(largeGrits);
            sides.Add(new VokunSalad());
            VokunSalad mediumSalad = new VokunSalad();
            mediumSalad.Size = Size.Medium;
            sides.Add(mediumSalad);
            VokunSalad largeSalad = new VokunSalad();
            largeSalad.Size = Size.Large;
            sides.Add(largeSalad);
            return sides;
        }

        /// <summary>
        /// Holds all of the drink options
        /// </summary>
        /// <returns>
        /// An IEnumerable of IOrderItem
        /// </returns>
        public static IEnumerable<IOrderItem> Drinks()
        {
            List<IOrderItem> drinks = new List<IOrderItem>();
            drinks.Add(new AretinoAppleJuice());
            AretinoAppleJuice mediumJuice = new AretinoAppleJuice();
            mediumJuice.Size = Size.Medium;
            drinks.Add(mediumJuice);
            AretinoAppleJuice largeJuice = new AretinoAppleJuice();
            largeJuice.Size = Size.Large;
            drinks.Add(largeJuice);
            drinks.Add(new CandlehearthCoffee());
            CandlehearthCoffee mediumCoffee = new CandlehearthCoffee();
            mediumCoffee.Size = Size.Medium;
            drinks.Add(mediumCoffee);
            CandlehearthCoffee largeCoffee = new CandlehearthCoffee();
            largeCoffee.Size = Size.Large;
            drinks.Add(largeCoffee);
            CandlehearthCoffee smallDecafCoffee = new CandlehearthCoffee();
            smallDecafCoffee.Decaf = true;
            drinks.Add(smallDecafCoffee);
            CandlehearthCoffee mediumDecafCoffee = new CandlehearthCoffee();
            mediumDecafCoffee.Size = Size.Medium;
            mediumDecafCoffee.Decaf = true;
            drinks.Add(mediumDecafCoffee);
            CandlehearthCoffee largeDecafCoffee = new CandlehearthCoffee();
            largeDecafCoffee.Size = Size.Large;
            largeDecafCoffee.Decaf = true;
            drinks.Add(largeDecafCoffee);
            drinks.Add(new MarkarthMilk());
            MarkarthMilk mediumMilk = new MarkarthMilk();
            mediumMilk.Size = Size.Medium;
            drinks.Add(mediumMilk);
            MarkarthMilk largeMilk = new MarkarthMilk();
            largeMilk.Size = Size.Large;
            drinks.Add(largeMilk);
            drinks.Add(new SailorSoda());
            SailorSoda mediumCherrySoda = new SailorSoda();
            mediumCherrySoda.Size = Size.Medium;
            drinks.Add(mediumCherrySoda);
            SailorSoda largeCherrySoda = new SailorSoda();
            largeCherrySoda.Size = Size.Large;
            drinks.Add(largeCherrySoda);
            SailorSoda smallBerrySoda = new SailorSoda();
            smallBerrySoda.Flavor = SodaFlavor.Blackberry;
            drinks.Add(smallBerrySoda);
            SailorSoda mediumBerrySoda = new SailorSoda();
            mediumBerrySoda.Size = Size.Medium;
            mediumBerrySoda.Flavor = SodaFlavor.Blackberry;
            drinks.Add(mediumBerrySoda);
            SailorSoda largeBerrySoda = new SailorSoda();
            largeBerrySoda.Size = Size.Large;
            largeBerrySoda.Flavor = SodaFlavor.Blackberry;
            drinks.Add(largeBerrySoda);
            SailorSoda smallFruitSoda = new SailorSoda();
            smallFruitSoda.Flavor = SodaFlavor.Grapefruit;
            drinks.Add(smallFruitSoda);
            SailorSoda mediumFruitSoda = new SailorSoda();
            mediumFruitSoda.Size = Size.Medium;
            mediumFruitSoda.Flavor = SodaFlavor.Grapefruit;
            drinks.Add(mediumFruitSoda);
            SailorSoda largeFruitSoda = new SailorSoda();
            largeFruitSoda.Size = Size.Large;
            largeFruitSoda.Flavor = SodaFlavor.Grapefruit;
            drinks.Add(largeFruitSoda);
            SailorSoda smallLemonSoda = new SailorSoda();
            smallLemonSoda.Flavor = SodaFlavor.Lemon;
            drinks.Add(smallLemonSoda);
            SailorSoda mediumLemonSoda = new SailorSoda();
            mediumLemonSoda.Size = Size.Medium;
            mediumLemonSoda.Flavor = SodaFlavor.Lemon;
            drinks.Add(mediumLemonSoda);
            SailorSoda largeLemonSoda = new SailorSoda();
            largeLemonSoda.Size = Size.Large;
            largeLemonSoda.Flavor = SodaFlavor.Lemon;
            drinks.Add(largeLemonSoda);
            SailorSoda smallPeachSoda = new SailorSoda();
            smallPeachSoda.Flavor = SodaFlavor.Peach;
            drinks.Add(smallPeachSoda);
            SailorSoda mediumPeachSoda = new SailorSoda();
            mediumPeachSoda.Size = Size.Medium;
            mediumPeachSoda.Flavor = SodaFlavor.Peach;
            drinks.Add(mediumPeachSoda);
            SailorSoda largePeachSoda = new SailorSoda();
            largePeachSoda.Size = Size.Large;
            largePeachSoda.Flavor = SodaFlavor.Peach;
            drinks.Add(largePeachSoda);
            SailorSoda smallMelonSoda = new SailorSoda();
            smallMelonSoda.Flavor = SodaFlavor.Watermelon;
            drinks.Add(smallMelonSoda);
            SailorSoda mediumMelonSoda = new SailorSoda();
            mediumMelonSoda.Size = Size.Medium;
            mediumMelonSoda.Flavor = SodaFlavor.Watermelon;
            drinks.Add(mediumMelonSoda);
            SailorSoda largeMelonSoda = new SailorSoda();
            largeMelonSoda.Size = Size.Large;
            largeMelonSoda.Flavor = SodaFlavor.Watermelon;
            drinks.Add(largeMelonSoda);
            drinks.Add(new WarriorWater());
            WarriorWater mediumWater = new WarriorWater();
            mediumWater.Size = Size.Medium;
            drinks.Add(mediumWater);
            WarriorWater largeWater = new WarriorWater();
            largeWater.Size = Size.Large;
            drinks.Add(largeWater);
            return drinks;
        }

        /// <summary>
        /// Holds all possible order options on the menu
        /// </summary>
        /// <returns>
        /// An IEnumerable of IOrderItem
        /// </returns>
        public static IEnumerable<IOrderItem> FullMenu()
        {
            List<IOrderItem> menu = new List<IOrderItem>();
            menu.Add(new BriarheartBurger());
            menu.Add(new DoubleDraugr());
            menu.Add(new GardenOrcOmelette());
            menu.Add(new PhillyPoacher());
            menu.Add(new SmokehouseSkeleton());
            menu.Add(new ThalmorTriple());
            menu.Add(new ThugsTBone());
            menu.Add(new DragonbornWaffleFries());
            DragonbornWaffleFries mediumFries = new DragonbornWaffleFries();
            mediumFries.Size = Size.Medium;
            menu.Add(mediumFries);
            DragonbornWaffleFries largeFries = new DragonbornWaffleFries();
            largeFries.Size = Size.Large;
            menu.Add(largeFries);
            menu.Add(new FriedMiraak());
            FriedMiraak mediumMiraak = new FriedMiraak();
            mediumMiraak.Size = Size.Medium;
            menu.Add(mediumMiraak);
            FriedMiraak largeMiraak = new FriedMiraak();
            largeMiraak.Size = Size.Large;
            menu.Add(largeMiraak);
            menu.Add(new MadOtarGrits());
            MadOtarGrits mediumGrits = new MadOtarGrits();
            mediumGrits.Size = Size.Medium;
            menu.Add(mediumGrits);
            MadOtarGrits largeGrits = new MadOtarGrits();
            largeGrits.Size = Size.Large;
            menu.Add(largeGrits);
            menu.Add(new VokunSalad());
            VokunSalad mediumSalad = new VokunSalad();
            mediumSalad.Size = Size.Medium;
            menu.Add(mediumSalad);
            VokunSalad largeSalad = new VokunSalad();
            largeSalad.Size = Size.Large;
            menu.Add(largeSalad);
            menu.Add(new AretinoAppleJuice());
            AretinoAppleJuice mediumJuice = new AretinoAppleJuice();
            mediumJuice.Size = Size.Medium;
            menu.Add(mediumJuice);
            AretinoAppleJuice largeJuice = new AretinoAppleJuice();
            largeJuice.Size = Size.Large;
            menu.Add(largeJuice);
            menu.Add(new CandlehearthCoffee());
            CandlehearthCoffee mediumCoffee = new CandlehearthCoffee();
            mediumCoffee.Size = Size.Medium;
            menu.Add(mediumCoffee);
            CandlehearthCoffee largeCoffee = new CandlehearthCoffee();
            largeCoffee.Size = Size.Large;
            menu.Add(largeCoffee);
            CandlehearthCoffee smallDecafCoffee = new CandlehearthCoffee();
            smallDecafCoffee.Decaf = true;
            menu.Add(smallDecafCoffee);
            CandlehearthCoffee mediumDecafCoffee = new CandlehearthCoffee();
            mediumDecafCoffee.Size = Size.Medium;
            mediumDecafCoffee.Decaf = true;
            menu.Add(mediumDecafCoffee);
            CandlehearthCoffee largeDecafCoffee = new CandlehearthCoffee();
            largeDecafCoffee.Size = Size.Large;
            largeDecafCoffee.Decaf = true;
            menu.Add(largeDecafCoffee);
            menu.Add(new MarkarthMilk());
            MarkarthMilk mediumMilk = new MarkarthMilk();
            mediumMilk.Size = Size.Medium;
            menu.Add(mediumMilk);
            MarkarthMilk largeMilk = new MarkarthMilk();
            largeMilk.Size = Size.Large;
            menu.Add(largeMilk);
            menu.Add(new SailorSoda());
            SailorSoda mediumCherrySoda = new SailorSoda();
            mediumCherrySoda.Size = Size.Medium;
            menu.Add(mediumCherrySoda);
            SailorSoda largeCherrySoda = new SailorSoda();
            largeCherrySoda.Size = Size.Large;
            menu.Add(largeCherrySoda);
            SailorSoda smallBerrySoda = new SailorSoda();
            smallBerrySoda.Flavor = SodaFlavor.Blackberry;
            menu.Add(smallBerrySoda);
            SailorSoda mediumBerrySoda = new SailorSoda();
            mediumBerrySoda.Size = Size.Medium;
            mediumBerrySoda.Flavor = SodaFlavor.Blackberry;
            menu.Add(mediumBerrySoda);
            SailorSoda largeBerrySoda = new SailorSoda();
            largeBerrySoda.Size = Size.Large;
            largeBerrySoda.Flavor = SodaFlavor.Blackberry;
            menu.Add(largeBerrySoda);
            SailorSoda smallFruitSoda = new SailorSoda();
            smallFruitSoda.Flavor = SodaFlavor.Grapefruit;
            menu.Add(smallFruitSoda);
            SailorSoda mediumFruitSoda = new SailorSoda();
            mediumFruitSoda.Size = Size.Medium;
            mediumFruitSoda.Flavor = SodaFlavor.Grapefruit;
            menu.Add(mediumFruitSoda);
            SailorSoda largeFruitSoda = new SailorSoda();
            largeFruitSoda.Size = Size.Large;
            largeFruitSoda.Flavor = SodaFlavor.Grapefruit;
            menu.Add(largeFruitSoda);
            SailorSoda smallLemonSoda = new SailorSoda();
            smallLemonSoda.Flavor = SodaFlavor.Lemon;
            menu.Add(smallLemonSoda);
            SailorSoda mediumLemonSoda = new SailorSoda();
            mediumLemonSoda.Size = Size.Medium;
            mediumLemonSoda.Flavor = SodaFlavor.Lemon;
            menu.Add(mediumLemonSoda);
            SailorSoda largeLemonSoda = new SailorSoda();
            largeLemonSoda.Size = Size.Large;
            largeLemonSoda.Flavor = SodaFlavor.Lemon;
            menu.Add(largeLemonSoda);
            SailorSoda smallPeachSoda = new SailorSoda();
            smallPeachSoda.Flavor = SodaFlavor.Peach;
            menu.Add(smallPeachSoda);
            SailorSoda mediumPeachSoda = new SailorSoda();
            mediumPeachSoda.Size = Size.Medium;
            mediumPeachSoda.Flavor = SodaFlavor.Peach;
            menu.Add(mediumPeachSoda);
            SailorSoda largePeachSoda = new SailorSoda();
            largePeachSoda.Size = Size.Large;
            largePeachSoda.Flavor = SodaFlavor.Peach;
            menu.Add(largePeachSoda);
            SailorSoda smallMelonSoda = new SailorSoda();
            smallMelonSoda.Flavor = SodaFlavor.Watermelon;
            menu.Add(smallMelonSoda);
            SailorSoda mediumMelonSoda = new SailorSoda();
            mediumMelonSoda.Size = Size.Medium;
            mediumMelonSoda.Flavor = SodaFlavor.Watermelon;
            menu.Add(mediumMelonSoda);
            SailorSoda largeMelonSoda = new SailorSoda();
            largeMelonSoda.Size = Size.Large;
            largeMelonSoda.Flavor = SodaFlavor.Watermelon;
            menu.Add(largeMelonSoda);
            menu.Add(new WarriorWater());
            WarriorWater mediumWater = new WarriorWater();
            mediumWater.Size = Size.Medium;
            menu.Add(mediumWater);
            WarriorWater largeWater = new WarriorWater();
            largeWater.Size = Size.Large;
            menu.Add(largeWater);
            return menu;
        }
    }
}
