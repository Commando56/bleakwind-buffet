/*
 * Author: Cole Kaster
 * Class: MenuTests.cs
 * Purpose: Test the Menu.cs class in the Data library
 */
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data.Enums;
using BleakwindBuffet.Data.Sides;
using Xunit;

namespace BleakwindBuffet.DataTests.UnitTests
{
    /// <summary>
    /// Tests the methods in Menu.cs
    /// </summary>
    public class MenuTests
    {
        [Fact]
        public void ShouldGetCorrectSearch()
        {
            IEnumerable<IOrderItem> items = new List<IOrderItem>();
            items = Menu.Search(items, null);
            Assert.Collection(items,
                item => Assert.IsType<BriarheartBurger>(item),
                item => Assert.IsType<DoubleDraugr>(item),
                item => Assert.IsType<GardenOrcOmelette>(item),
                item => Assert.IsType<PhillyPoacher>(item),
                item => Assert.IsType<SmokehouseSkeleton>(item),
                item => Assert.IsType<ThalmorTriple>(item),
                item => Assert.IsType<ThugsTBone>(item),
                item => Assert.IsType<DragonbornWaffleFries>(item),
                item => Assert.IsType<FriedMiraak>(item),
                item => Assert.IsType<MadOtarGrits>(item),
                item => Assert.IsType<VokunSalad>(item),
                item => Assert.IsType<AretinoAppleJuice>(item),
                item => Assert.IsType<CandlehearthCoffee>(item),
                item => Assert.IsType<MarkarthMilk>(item),
                item => Assert.IsType<SailorSoda>(item),
                item => Assert.IsType<WarriorWater>(item)
                );
            items = Menu.Search(items, "Frie");
            Assert.NotEmpty(items);
            Assert.Collection(items,
                item => Assert.IsType<DragonbornWaffleFries>(item),
                item => Assert.IsType<FriedMiraak>(item)
                );
            items = Menu.Search(items, "Soda");
            Assert.Collection(items,
                item => Assert.IsType<SailorSoda>(item));
            items = Menu.Search(items, "Burger");
            Assert.Collection(items,
                item => Assert.IsType<BriarheartBurger>(item));
        }

        [Fact]
        public void ShouldFilterCorrectTypes()
        {
            IEnumerable<IOrderItem> items = new List<IOrderItem>();
            items = Menu.Search(items, null);
            items = Menu.FilterByType(items, false, false, false);
            Assert.Collection(items,
                item => Assert.IsType<BriarheartBurger>(item),
                item => Assert.IsType<DoubleDraugr>(item),
                item => Assert.IsType<GardenOrcOmelette>(item),
                item => Assert.IsType<PhillyPoacher>(item),
                item => Assert.IsType<SmokehouseSkeleton>(item),
                item => Assert.IsType<ThalmorTriple>(item),
                item => Assert.IsType<ThugsTBone>(item),
                item => Assert.IsType<DragonbornWaffleFries>(item),
                item => Assert.IsType<FriedMiraak>(item),
                item => Assert.IsType<MadOtarGrits>(item),
                item => Assert.IsType<VokunSalad>(item),
                item => Assert.IsType<AretinoAppleJuice>(item),
                item => Assert.IsType<CandlehearthCoffee>(item),
                item => Assert.IsType<MarkarthMilk>(item),
                item => Assert.IsType<SailorSoda>(item),
                item => Assert.IsType<WarriorWater>(item)
                );
            items = Menu.Search(items, "er");
            items = Menu.FilterByType(items, true, false, true);
            Assert.NotEmpty(items);
            Assert.Collection(items,
                item => Assert.IsType<BriarheartBurger>(item),
                item => Assert.IsType<PhillyPoacher>(item),
                item => Assert.IsType<SailorSoda>(item),
                item => Assert.IsType<WarriorWater>(item)
                );
        }

        [Fact]
        public void ShouldFilterCorrectCalories()
        {
            IEnumerable<IOrderItem> items = new List<IOrderItem>();
            items = Menu.Search(items, null);
            items = Menu.FilterByCalories(items, null, null);
            Assert.Collection(items,
                item => Assert.IsType<BriarheartBurger>(item),
                item => Assert.IsType<DoubleDraugr>(item),
                item => Assert.IsType<GardenOrcOmelette>(item),
                item => Assert.IsType<PhillyPoacher>(item),
                item => Assert.IsType<SmokehouseSkeleton>(item),
                item => Assert.IsType<ThalmorTriple>(item),
                item => Assert.IsType<ThugsTBone>(item),
                item => Assert.IsType<DragonbornWaffleFries>(item),
                item => Assert.IsType<FriedMiraak>(item),
                item => Assert.IsType<MadOtarGrits>(item),
                item => Assert.IsType<VokunSalad>(item),
                item => Assert.IsType<AretinoAppleJuice>(item),
                item => Assert.IsType<CandlehearthCoffee>(item),
                item => Assert.IsType<MarkarthMilk>(item),
                item => Assert.IsType<SailorSoda>(item),
                item => Assert.IsType<WarriorWater>(item)
                );
            items = Menu.Search(items, "Water");
            items = Menu.FilterByCalories(items, 0, 100);
            Assert.Collection(items,
                item => Assert.IsType<WarriorWater>(item)
                );
            items = Menu.Search(items, "Burger");
            items = Menu.FilterByCalories(items, 700, 800);
            Assert.Collection(items,
                item => Assert.IsType<BriarheartBurger>(item)
                );
            items = Menu.FilterByCalories(items, 0, 100);
            Assert.Empty(items);
        }

        [Fact]
        public void ShouldFilterCorrectPrice()
        {
            IEnumerable<IOrderItem> items = new List<IOrderItem>();
            items = Menu.Search(items, null);
            items = Menu.FilterByPrice(items, null, null);
            Assert.Collection(items,
                item => Assert.IsType<BriarheartBurger>(item),
                item => Assert.IsType<DoubleDraugr>(item),
                item => Assert.IsType<GardenOrcOmelette>(item),
                item => Assert.IsType<PhillyPoacher>(item),
                item => Assert.IsType<SmokehouseSkeleton>(item),
                item => Assert.IsType<ThalmorTriple>(item),
                item => Assert.IsType<ThugsTBone>(item),
                item => Assert.IsType<DragonbornWaffleFries>(item),
                item => Assert.IsType<FriedMiraak>(item),
                item => Assert.IsType<MadOtarGrits>(item),
                item => Assert.IsType<VokunSalad>(item),
                item => Assert.IsType<AretinoAppleJuice>(item),
                item => Assert.IsType<CandlehearthCoffee>(item),
                item => Assert.IsType<MarkarthMilk>(item),
                item => Assert.IsType<SailorSoda>(item),
                item => Assert.IsType<WarriorWater>(item)
                );
            items = Menu.Search(items, "Burger");
            items = Menu.FilterByPrice(items, 0.00, 8.00);
            Assert.Collection(items,
                item => Assert.IsType<BriarheartBurger>(item)
                );
            items = Menu.FilterByPrice(items, 0.00, 1.00);
            Assert.Empty(items);
        }

        [Fact]
        public void ShouldGetAllEntrees()
        {
            BriarheartBurger bb = new BriarheartBurger();
            DoubleDraugr dd = new DoubleDraugr();
            GardenOrcOmelette goo = new GardenOrcOmelette();
            PhillyPoacher pp = new PhillyPoacher();
            SmokehouseSkeleton ss = new SmokehouseSkeleton();
            ThalmorTriple tt = new ThalmorTriple();
            ThugsTBone ttb = new ThugsTBone();
            Assert.Collection<IOrderItem>(Menu.Entrees(),
                item => Assert.Equal(item.ToString(), bb.ToString()),
                item => Assert.Equal(item.ToString(), dd.ToString()),
                item => Assert.Equal(item.ToString(), goo.ToString()),
                item => Assert.Equal(item.ToString(), pp.ToString()),
                item => Assert.Equal(item.ToString(), ss.ToString()),
                item => Assert.Equal(item.ToString(), tt.ToString()),
                item => Assert.Equal(item.ToString(), ttb.ToString()));   
        }

        [Fact]
        public void ShouldGetAllSides()
        {
            DragonbornWaffleFries smallFries = new DragonbornWaffleFries();
            DragonbornWaffleFries mediumFries = new DragonbornWaffleFries();
            mediumFries.Size = Size.Medium;
            DragonbornWaffleFries largeFries = new DragonbornWaffleFries();
            largeFries.Size = Size.Large;
            FriedMiraak smallMiraak = new FriedMiraak();
            FriedMiraak mediumMiraak = new FriedMiraak();
            mediumMiraak.Size = Size.Medium;
            FriedMiraak largeMiraak = new FriedMiraak();
            largeMiraak.Size = Size.Large;
            MadOtarGrits smallGrits = new MadOtarGrits();
            MadOtarGrits mediumGrits = new MadOtarGrits();
            mediumGrits.Size = Size.Medium;
            MadOtarGrits largeGrits = new MadOtarGrits();
            largeGrits.Size = Size.Large;
            VokunSalad smallSalad = new VokunSalad();
            VokunSalad mediumSalad = new VokunSalad();
            mediumSalad.Size = Size.Medium;
            VokunSalad largeSalad = new VokunSalad();
            largeSalad.Size = Size.Large;
            Assert.Collection<IOrderItem>(Menu.Sides(),
                item => Assert.Equal(item.ToString(), smallFries.ToString()),
                item => Assert.Equal(item.ToString(), mediumFries.ToString()),
                item => Assert.Equal(item.ToString(), largeFries.ToString()),
                item => Assert.Equal(item.ToString(), smallMiraak.ToString()),
                item => Assert.Equal(item.ToString(), mediumMiraak.ToString()),
                item => Assert.Equal(item.ToString(), largeMiraak.ToString()),
                item => Assert.Equal(item.ToString(), smallGrits.ToString()),
                item => Assert.Equal(item.ToString(), mediumGrits.ToString()),
                item => Assert.Equal(item.ToString(), largeGrits.ToString()),
                item => Assert.Equal(item.ToString(), smallSalad.ToString()),
                item => Assert.Equal(item.ToString(), mediumSalad.ToString()),
                item => Assert.Equal(item.ToString(), largeSalad.ToString()));
        }

        [Fact]
        public void ShouldGetAllDrinks()
        {
            AretinoAppleJuice smallJuice = new AretinoAppleJuice();
            AretinoAppleJuice mediumJuice = new AretinoAppleJuice();
            mediumJuice.Size = Size.Medium;
            AretinoAppleJuice largeJuice = new AretinoAppleJuice();
            largeJuice.Size = Size.Large;
            CandlehearthCoffee smallCoffee = new CandlehearthCoffee();
            CandlehearthCoffee mediumCoffee = new CandlehearthCoffee();
            mediumCoffee.Size = Size.Medium;
            CandlehearthCoffee largeCoffee = new CandlehearthCoffee();
            largeCoffee.Size = Size.Large;
            CandlehearthCoffee smallDecafCoffee = new CandlehearthCoffee();
            smallDecafCoffee.Decaf = true;
            CandlehearthCoffee mediumDecafCoffee = new CandlehearthCoffee();
            mediumDecafCoffee.Size = Size.Medium;
            mediumDecafCoffee.Decaf = true;
            CandlehearthCoffee largeDecafCoffee = new CandlehearthCoffee();
            largeDecafCoffee.Size = Size.Large;
            largeDecafCoffee.Decaf = true;
            MarkarthMilk smallMilk = new MarkarthMilk();
            MarkarthMilk mediumMilk = new MarkarthMilk();
            mediumMilk.Size = Size.Medium;
            MarkarthMilk largeMilk = new MarkarthMilk();
            largeMilk.Size = Size.Large;
            SailorSoda smallCherrySoda = new SailorSoda();
            SailorSoda mediumCherrySoda = new SailorSoda();
            mediumCherrySoda.Size = Size.Medium;
            SailorSoda largeCherrySoda = new SailorSoda();
            largeCherrySoda.Size = Size.Large;
            SailorSoda smallBerrySoda = new SailorSoda();
            smallBerrySoda.Flavor = SodaFlavor.Blackberry;
            SailorSoda mediumBerrySoda = new SailorSoda();
            mediumBerrySoda.Size = Size.Medium;
            mediumBerrySoda.Flavor = SodaFlavor.Blackberry;
            SailorSoda largeBerrySoda = new SailorSoda();
            largeBerrySoda.Size = Size.Large;
            largeBerrySoda.Flavor = SodaFlavor.Blackberry;
            SailorSoda smallFruitSoda = new SailorSoda();
            smallFruitSoda.Flavor = SodaFlavor.Grapefruit;
            SailorSoda mediumFruitSoda = new SailorSoda();
            mediumFruitSoda.Size = Size.Medium;
            mediumFruitSoda.Flavor = SodaFlavor.Grapefruit;
            SailorSoda largeFruitSoda = new SailorSoda();
            largeFruitSoda.Size = Size.Large;
            largeFruitSoda.Flavor = SodaFlavor.Grapefruit;
            SailorSoda smallLemonSoda = new SailorSoda();
            smallLemonSoda.Flavor = SodaFlavor.Lemon;
            SailorSoda mediumLemonSoda = new SailorSoda();
            mediumLemonSoda.Size = Size.Medium;
            mediumLemonSoda.Flavor = SodaFlavor.Lemon;
            SailorSoda largeLemonSoda = new SailorSoda();
            largeLemonSoda.Size = Size.Large;
            largeLemonSoda.Flavor = SodaFlavor.Lemon;
            SailorSoda smallPeachSoda = new SailorSoda();
            smallPeachSoda.Flavor = SodaFlavor.Peach;
            SailorSoda mediumPeachSoda = new SailorSoda();
            mediumPeachSoda.Size = Size.Medium;
            mediumPeachSoda.Flavor = SodaFlavor.Peach;
            SailorSoda largePeachSoda = new SailorSoda();
            largePeachSoda.Size = Size.Large;
            largePeachSoda.Flavor = SodaFlavor.Peach;
            SailorSoda smallMelonSoda = new SailorSoda();
            smallMelonSoda.Flavor = SodaFlavor.Watermelon;
            SailorSoda mediumMelonSoda = new SailorSoda();
            mediumMelonSoda.Size = Size.Medium;
            mediumMelonSoda.Flavor = SodaFlavor.Watermelon;
            SailorSoda largeMelonSoda = new SailorSoda();
            largeMelonSoda.Size = Size.Large;
            largeMelonSoda.Flavor = SodaFlavor.Watermelon;
            WarriorWater smallWater = new WarriorWater();
            WarriorWater mediumWater = new WarriorWater();
            mediumWater.Size = Size.Medium;
            WarriorWater largeWater = new WarriorWater();
            largeWater.Size = Size.Large;
            Assert.Collection<IOrderItem>(Menu.Drinks(),
                item => Assert.Equal(item.ToString(), smallJuice.ToString()),
                item => Assert.Equal(item.ToString(), mediumJuice.ToString()),
                item => Assert.Equal(item.ToString(), largeJuice.ToString()),
                item => Assert.Equal(item.ToString(), smallCoffee.ToString()),
                item => Assert.Equal(item.ToString(), mediumCoffee.ToString()),
                item => Assert.Equal(item.ToString(), largeCoffee.ToString()),
                item => Assert.Equal(item.ToString(), smallDecafCoffee.ToString()),
                item => Assert.Equal(item.ToString(), mediumDecafCoffee.ToString()),
                item => Assert.Equal(item.ToString(), largeDecafCoffee.ToString()),
                item => Assert.Equal(item.ToString(), smallMilk.ToString()),
                item => Assert.Equal(item.ToString(), mediumMilk.ToString()),
                item => Assert.Equal(item.ToString(), largeMilk.ToString()),
                item => Assert.Equal(item.ToString(), smallCherrySoda.ToString()),
                item => Assert.Equal(item.ToString(), mediumCherrySoda.ToString()),
                item => Assert.Equal(item.ToString(), largeCherrySoda.ToString()),
                item => Assert.Equal(item.ToString(), smallBerrySoda.ToString()),
                item => Assert.Equal(item.ToString(), mediumBerrySoda.ToString()),
                item => Assert.Equal(item.ToString(), largeBerrySoda.ToString()),
                item => Assert.Equal(item.ToString(), smallFruitSoda.ToString()),
                item => Assert.Equal(item.ToString(), mediumFruitSoda.ToString()),
                item => Assert.Equal(item.ToString(), largeFruitSoda.ToString()),
                item => Assert.Equal(item.ToString(), smallLemonSoda.ToString()),
                item => Assert.Equal(item.ToString(), mediumLemonSoda.ToString()),
                item => Assert.Equal(item.ToString(), largeLemonSoda.ToString()),
                item => Assert.Equal(item.ToString(), smallPeachSoda.ToString()),
                item => Assert.Equal(item.ToString(), mediumPeachSoda.ToString()),
                item => Assert.Equal(item.ToString(), largePeachSoda.ToString()),
                item => Assert.Equal(item.ToString(), smallMelonSoda.ToString()),
                item => Assert.Equal(item.ToString(), mediumMelonSoda.ToString()),
                item => Assert.Equal(item.ToString(), largeMelonSoda.ToString()),
                item => Assert.Equal(item.ToString(), smallWater.ToString()),
                item => Assert.Equal(item.ToString(), mediumWater.ToString()),
                item => Assert.Equal(item.ToString(), largeWater.ToString()));
        }

        [Fact]
        public void ShouldGetFullMenu()
        {
            BriarheartBurger bb = new BriarheartBurger();
            DoubleDraugr dd = new DoubleDraugr();
            GardenOrcOmelette goo = new GardenOrcOmelette();
            PhillyPoacher pp = new PhillyPoacher();
            SmokehouseSkeleton ss = new SmokehouseSkeleton();
            ThalmorTriple tt = new ThalmorTriple();
            ThugsTBone ttb = new ThugsTBone();
            DragonbornWaffleFries smallFries = new DragonbornWaffleFries();
            DragonbornWaffleFries mediumFries = new DragonbornWaffleFries();
            mediumFries.Size = Size.Medium;
            DragonbornWaffleFries largeFries = new DragonbornWaffleFries();
            largeFries.Size = Size.Large;
            FriedMiraak smallMiraak = new FriedMiraak();
            FriedMiraak mediumMiraak = new FriedMiraak();
            mediumMiraak.Size = Size.Medium;
            FriedMiraak largeMiraak = new FriedMiraak();
            largeMiraak.Size = Size.Large;
            MadOtarGrits smallGrits = new MadOtarGrits();
            MadOtarGrits mediumGrits = new MadOtarGrits();
            mediumGrits.Size = Size.Medium;
            MadOtarGrits largeGrits = new MadOtarGrits();
            largeGrits.Size = Size.Large;
            VokunSalad smallSalad = new VokunSalad();
            VokunSalad mediumSalad = new VokunSalad();
            mediumSalad.Size = Size.Medium;
            VokunSalad largeSalad = new VokunSalad();
            largeSalad.Size = Size.Large;
            AretinoAppleJuice smallJuice = new AretinoAppleJuice();
            AretinoAppleJuice mediumJuice = new AretinoAppleJuice();
            mediumJuice.Size = Size.Medium;
            AretinoAppleJuice largeJuice = new AretinoAppleJuice();
            largeJuice.Size = Size.Large;
            CandlehearthCoffee smallCoffee = new CandlehearthCoffee();
            CandlehearthCoffee mediumCoffee = new CandlehearthCoffee();
            mediumCoffee.Size = Size.Medium;
            CandlehearthCoffee largeCoffee = new CandlehearthCoffee();
            largeCoffee.Size = Size.Large;
            CandlehearthCoffee smallDecafCoffee = new CandlehearthCoffee();
            smallDecafCoffee.Decaf = true;
            CandlehearthCoffee mediumDecafCoffee = new CandlehearthCoffee();
            mediumDecafCoffee.Size = Size.Medium;
            mediumDecafCoffee.Decaf = true;
            CandlehearthCoffee largeDecafCoffee = new CandlehearthCoffee();
            largeDecafCoffee.Size = Size.Large;
            largeDecafCoffee.Decaf = true;
            MarkarthMilk smallMilk = new MarkarthMilk();
            MarkarthMilk mediumMilk = new MarkarthMilk();
            mediumMilk.Size = Size.Medium;
            MarkarthMilk largeMilk = new MarkarthMilk();
            largeMilk.Size = Size.Large;
            SailorSoda smallCherrySoda = new SailorSoda();
            SailorSoda mediumCherrySoda = new SailorSoda();
            mediumCherrySoda.Size = Size.Medium;
            SailorSoda largeCherrySoda = new SailorSoda();
            largeCherrySoda.Size = Size.Large;
            SailorSoda smallBerrySoda = new SailorSoda();
            smallBerrySoda.Flavor = SodaFlavor.Blackberry;
            SailorSoda mediumBerrySoda = new SailorSoda();
            mediumBerrySoda.Size = Size.Medium;
            mediumBerrySoda.Flavor = SodaFlavor.Blackberry;
            SailorSoda largeBerrySoda = new SailorSoda();
            largeBerrySoda.Size = Size.Large;
            largeBerrySoda.Flavor = SodaFlavor.Blackberry;
            SailorSoda smallFruitSoda = new SailorSoda();
            smallFruitSoda.Flavor = SodaFlavor.Grapefruit;
            SailorSoda mediumFruitSoda = new SailorSoda();
            mediumFruitSoda.Size = Size.Medium;
            mediumFruitSoda.Flavor = SodaFlavor.Grapefruit;
            SailorSoda largeFruitSoda = new SailorSoda();
            largeFruitSoda.Size = Size.Large;
            largeFruitSoda.Flavor = SodaFlavor.Grapefruit;
            SailorSoda smallLemonSoda = new SailorSoda();
            smallLemonSoda.Flavor = SodaFlavor.Lemon;
            SailorSoda mediumLemonSoda = new SailorSoda();
            mediumLemonSoda.Size = Size.Medium;
            mediumLemonSoda.Flavor = SodaFlavor.Lemon;
            SailorSoda largeLemonSoda = new SailorSoda();
            largeLemonSoda.Size = Size.Large;
            largeLemonSoda.Flavor = SodaFlavor.Lemon;
            SailorSoda smallPeachSoda = new SailorSoda();
            smallPeachSoda.Flavor = SodaFlavor.Peach;
            SailorSoda mediumPeachSoda = new SailorSoda();
            mediumPeachSoda.Size = Size.Medium;
            mediumPeachSoda.Flavor = SodaFlavor.Peach;
            SailorSoda largePeachSoda = new SailorSoda();
            largePeachSoda.Size = Size.Large;
            largePeachSoda.Flavor = SodaFlavor.Peach;
            SailorSoda smallMelonSoda = new SailorSoda();
            smallMelonSoda.Flavor = SodaFlavor.Watermelon;
            SailorSoda mediumMelonSoda = new SailorSoda();
            mediumMelonSoda.Size = Size.Medium;
            mediumMelonSoda.Flavor = SodaFlavor.Watermelon;
            SailorSoda largeMelonSoda = new SailorSoda();
            largeMelonSoda.Size = Size.Large;
            largeMelonSoda.Flavor = SodaFlavor.Watermelon;
            WarriorWater smallWater = new WarriorWater();
            WarriorWater mediumWater = new WarriorWater();
            mediumWater.Size = Size.Medium;
            WarriorWater largeWater = new WarriorWater();
            largeWater.Size = Size.Large;
            Assert.Collection<IOrderItem>(Menu.FullMenu(),
                item => Assert.Equal(item.ToString(), bb.ToString()),
                item => Assert.Equal(item.ToString(), dd.ToString()),
                item => Assert.Equal(item.ToString(), goo.ToString()),
                item => Assert.Equal(item.ToString(), pp.ToString()),
                item => Assert.Equal(item.ToString(), ss.ToString()),
                item => Assert.Equal(item.ToString(), tt.ToString()),
                item => Assert.Equal(item.ToString(), ttb.ToString()),
                item => Assert.Equal(item.ToString(), smallFries.ToString()),
                item => Assert.Equal(item.ToString(), mediumFries.ToString()),
                item => Assert.Equal(item.ToString(), largeFries.ToString()),
                item => Assert.Equal(item.ToString(), smallMiraak.ToString()),
                item => Assert.Equal(item.ToString(), mediumMiraak.ToString()),
                item => Assert.Equal(item.ToString(), largeMiraak.ToString()),
                item => Assert.Equal(item.ToString(), smallGrits.ToString()),
                item => Assert.Equal(item.ToString(), mediumGrits.ToString()),
                item => Assert.Equal(item.ToString(), largeGrits.ToString()),
                item => Assert.Equal(item.ToString(), smallSalad.ToString()),
                item => Assert.Equal(item.ToString(), mediumSalad.ToString()),
                item => Assert.Equal(item.ToString(), largeSalad.ToString()),
                item => Assert.Equal(item.ToString(), smallJuice.ToString()),
                item => Assert.Equal(item.ToString(), mediumJuice.ToString()),
                item => Assert.Equal(item.ToString(), largeJuice.ToString()),
                item => Assert.Equal(item.ToString(), smallCoffee.ToString()),
                item => Assert.Equal(item.ToString(), mediumCoffee.ToString()),
                item => Assert.Equal(item.ToString(), largeCoffee.ToString()),
                item => Assert.Equal(item.ToString(), smallDecafCoffee.ToString()),
                item => Assert.Equal(item.ToString(), mediumDecafCoffee.ToString()),
                item => Assert.Equal(item.ToString(), largeDecafCoffee.ToString()),
                item => Assert.Equal(item.ToString(), smallMilk.ToString()),
                item => Assert.Equal(item.ToString(), mediumMilk.ToString()),
                item => Assert.Equal(item.ToString(), largeMilk.ToString()),
                item => Assert.Equal(item.ToString(), smallCherrySoda.ToString()),
                item => Assert.Equal(item.ToString(), mediumCherrySoda.ToString()),
                item => Assert.Equal(item.ToString(), largeCherrySoda.ToString()),
                item => Assert.Equal(item.ToString(), smallBerrySoda.ToString()),
                item => Assert.Equal(item.ToString(), mediumBerrySoda.ToString()),
                item => Assert.Equal(item.ToString(), largeBerrySoda.ToString()),
                item => Assert.Equal(item.ToString(), smallFruitSoda.ToString()),
                item => Assert.Equal(item.ToString(), mediumFruitSoda.ToString()),
                item => Assert.Equal(item.ToString(), largeFruitSoda.ToString()),
                item => Assert.Equal(item.ToString(), smallLemonSoda.ToString()),
                item => Assert.Equal(item.ToString(), mediumLemonSoda.ToString()),
                item => Assert.Equal(item.ToString(), largeLemonSoda.ToString()),
                item => Assert.Equal(item.ToString(), smallPeachSoda.ToString()),
                item => Assert.Equal(item.ToString(), mediumPeachSoda.ToString()),
                item => Assert.Equal(item.ToString(), largePeachSoda.ToString()),
                item => Assert.Equal(item.ToString(), smallMelonSoda.ToString()),
                item => Assert.Equal(item.ToString(), mediumMelonSoda.ToString()),
                item => Assert.Equal(item.ToString(), largeMelonSoda.ToString()),
                item => Assert.Equal(item.ToString(), smallWater.ToString()),
                item => Assert.Equal(item.ToString(), mediumWater.ToString()),
                item => Assert.Equal(item.ToString(), largeWater.ToString()));
        }
    }
}
