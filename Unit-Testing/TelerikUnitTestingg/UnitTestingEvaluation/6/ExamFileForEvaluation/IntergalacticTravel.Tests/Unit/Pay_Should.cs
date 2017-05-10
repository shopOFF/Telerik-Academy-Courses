using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace IntergalacticTravel.Tests.Unit
{
    [TestClass]
    public class Pay_Should
    {
        // 1. Pay should throw NullReferenceException if the object passed is null.
        [TestMethod]
        public void ThrowNullReferenceException_WhenPassedArgumentIsNull()
        {
            // Arrange
            var factory = new IntergalacticTravel.UnitsFactory();

            // Act
            var unit = factory.GetUnit("create unit Procyon Gosho 1");
            
            // Act and Assert
            Assert.ThrowsException<NullReferenceException>(() => unit.Pay(null));
        }

        // 2. Pay should decrease the owner's amount of Resources by the amount of the cost.
        [TestMethod]
        public void DecreaseTheOwnersAmouthOfResoircesByTheAmouthOfCostArgumetresources()
        {
            // Arrange
            var cost = new Resources(10, 0, 0);
            var factory = new IntergalacticTravel.UnitsFactory();
            uint one = 1;
            // Act
            var unit = factory.GetUnit("create unit Procyon Gosho 1");
            unit.Resources.BronzeCoins = 11;
            unit.Resources.SilverCoins = 11;
            unit.Resources.GoldCoins = 11;
            unit.Pay(cost);

            // Act and Assert
            Assert.AreEqual(one, unit.Resources.BronzeCoins);
        }

        // 3. Pay should return Resource object with the amount of resources in the cost object.
        [TestMethod]
        public void ReturnObjectOfTypeResourcesWithTheAmouthOfResourcesInTheCostObject()
        {
            // Arrange
            var cost = new Resources(10, 10, 10);
            var factory = new IntergalacticTravel.UnitsFactory();
            uint then = 10;
            // Act
            var unit = factory.GetUnit("create unit Procyon Gosho 1");
            unit.Resources.BronzeCoins = 11;
            unit.Resources.SilverCoins = 11;
            unit.Resources.GoldCoins = 11;
            var returnedCosts = unit.Pay(cost);

            // Act and Assert
            Assert.AreEqual(then, returnedCosts.BronzeCoins);
            Assert.AreEqual(then, returnedCosts.SilverCoins);
            Assert.AreEqual(then, returnedCosts.GoldCoins);
        }

    }
}
