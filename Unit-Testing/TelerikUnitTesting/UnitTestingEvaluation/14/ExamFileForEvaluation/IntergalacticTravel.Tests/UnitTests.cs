using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace IntergalacticTravel.Tests
{
    [TestFixture]
    public class UnitTests
    {
        [Test]
        public void Pay_ShouldThrowNullReferenceException_WhenTheObjectPassedIsNull()
        {
            var unit = new Procyon(1, "Pesho");

            Assert.Throws<NullReferenceException>(() => unit.Pay(null));
        }

        [Test]
        public void Pay_ShouldDecreaseOwnerResources_WhenPayIsCalled()
        {
            var unit = new Procyon(1, "Pesho");
            unit.Resources.BronzeCoins = 15;
            unit.Resources.SilverCoins = 20;
            unit.Resources.GoldCoins = 25;
            var oldResources = unit.Resources.Clone();

            var cost = new Resources();
            cost.BronzeCoins = 15;
            cost.SilverCoins = 20;
            cost.GoldCoins = 25;

            unit.Pay(cost);

            Assert.AreEqual(unit.Resources.GoldCoins + cost.GoldCoins,
                oldResources.GoldCoins);
            Assert.AreEqual(unit.Resources.SilverCoins + cost.SilverCoins,
                oldResources.SilverCoins);
            Assert.AreEqual(unit.Resources.BronzeCoins + cost.BronzeCoins,
                oldResources.BronzeCoins);
        }

        [Test]
        public void Pay_ShouldReturnNewResourcesObject_WhenPayIsCalled()
        {
            var unit = new Procyon(1, "Pesho");
            unit.Resources.BronzeCoins = 15;
            unit.Resources.SilverCoins = 20;
            unit.Resources.GoldCoins = 25;

            var cost = new Resources();
            cost.BronzeCoins = 15;
            cost.SilverCoins = 20;
            cost.GoldCoins = 25;

            var resourcesCost = unit.Pay(cost);

            Assert.AreEqual(resourcesCost.BronzeCoins, 15);
            Assert.AreEqual(resourcesCost.SilverCoins, 20);
            Assert.AreEqual(resourcesCost.GoldCoins, 25);
        }
    }
}
