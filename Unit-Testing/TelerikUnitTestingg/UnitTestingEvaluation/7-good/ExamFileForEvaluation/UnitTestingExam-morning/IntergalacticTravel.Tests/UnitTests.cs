using System;
using NUnit.Framework;
using IntergalacticTravel.Contracts;

namespace IntergalacticTravel.Tests
{
    [TestFixture]
    public class UnitTests
    {
        [Test]
        public void Pay_ShouldThrowNullReferenceException_IfPassedObjectIsNull()
        {
            var unit = new Unit(123, "testName");
            
            Assert.Throws<NullReferenceException>(() => unit.Pay(null));
        }

        [Test]
        public void Pay_ShouldDecreaseOwnersResourcesByTheAmountOfTheCost()
        {
            var unit = new Unit(123, "testName");
            var resourcesToAdd = new Resources(100, 100, 100);
            var resourcesToPay = new Resources(30, 15, 20);
            var expectedResources = new Resources(70, 85, 80);
            bool expectedResult = false;
            unit.Resources.Add(resourcesToAdd);

            unit.Pay(resourcesToPay);
            if (expectedResources.BronzeCoins == unit.Resources.BronzeCoins &&
                expectedResources.SilverCoins == unit.Resources.SilverCoins &&
                expectedResources.GoldCoins == unit.Resources.GoldCoins)
            {
                expectedResult = true;
            }

            Assert.IsTrue(expectedResult);
        }

        [Test]
        public void Pay_ShouldReturnResourceObjectWithAmountOfResourcesInCostObject()
        {
            var unit = new Unit(123, "testName");
            var resourcesToPay = new Resources(30, 15, 20);

            Assert.IsInstanceOf<IResources>(unit.Pay(resourcesToPay));
        }
    }
}
