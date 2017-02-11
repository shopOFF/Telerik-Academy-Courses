using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using IntergalacticTravel.Exceptions;
using IntergalacticTravel.Contracts;
using Moq;
using IntergalacticTravel.Tests.Mocks;

namespace IntergalacticTravel.Tests
{
    [TestFixture]
    public class UnitTests
    {
        [Test]
        public void Pay_WhenObjectPastIsNull_ShouldThrowNullReferenceException()
        {
            // Arrange
            var unit = new Unit(1, "Pesho");

            // Act & Assert
            Assert.Throws<NullReferenceException>(() => unit.Pay(null));
        }

        [Test]
        public void Pay_ShouldDecreaseOwnerResourcesByTheAmountOfTheCost()
        {
            // Arrange
            var unit = new Unit(1, "Pesho");
            var resourcesForOwner = new Resources()
            {
                BronzeCoins = 150,
                SilverCoins = 120,
                GoldCoins = 110
            };
            var resourcesForCost = new Resources()
            {
                BronzeCoins = 50,
                SilverCoins = 70,
                GoldCoins = 30
            };

            unit.Resources.Add(resourcesForOwner);

            // Act 
            unit.Pay(resourcesForCost);

            // Assert
            var expectedOwnerResourcesAfterPayingCosts = "Bronz=100, Silver=50, Gold=80";
            var actualOwnerResourcesAfterPayingCosts = $"Bronz={unit.Resources.BronzeCoins}, Silver={unit.Resources.SilverCoins}, Gold={unit.Resources.GoldCoins}";
            Assert.AreEqual(expectedOwnerResourcesAfterPayingCosts, actualOwnerResourcesAfterPayingCosts);
        }

        [Test]
        public void Pay_ShouldReturnResourceObjectWithTheAmountOfResourcesInTheCostObject()
        {
            // Arrange
            var unit = new Unit(1, "Pesho");
            var resourcesForCost = new Resources()
            {
                BronzeCoins = 150,
                SilverCoins = 120,
                GoldCoins = 110
            };

            // Act
            IResources payMethodResult = unit.Pay(resourcesForCost);

            // Assert
            // тука може  да разделим асъртите в различни Юнит тестове, което е по-добрият вариант и
            // тия с жълтиците може да си ги направим, като горните с един ассърт и стрингове или като тука...
            // без стрингове, но пък ни трябват 3 ассърта... както преценим
            Assert.IsInstanceOf<Resources>(payMethodResult);
            Assert.AreEqual(150, payMethodResult.BronzeCoins);
            Assert.AreEqual(120, payMethodResult.SilverCoins);
            Assert.AreEqual(110, payMethodResult.GoldCoins);
        }
    }
}
