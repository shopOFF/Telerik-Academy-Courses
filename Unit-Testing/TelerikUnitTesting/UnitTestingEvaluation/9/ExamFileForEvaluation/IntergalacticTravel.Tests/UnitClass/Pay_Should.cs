namespace IntergalacticTravel.Tests.UnitClass
{
    using System;
    using IntergalacticTravel;
    using Moq;
    using NUnit.Framework;
    using Contracts;

    [TestFixture]
    public class Pay_Should
    {
        /*
         * Pay should throw NullReferenceException if the object passed is null
         */
        [Test]
        public void ThrowNullReferenceException_WhenTheObjectPassedIsNull()
        {
            // Arrange
            var unit = new Unit(1, "nickName");

            // Act && Assert
            Assert.Throws<NullReferenceException>(() => unit.Pay(null));
        }

        /*
         * Pay should decrease the owner's amount of Resources by the amount of the cost.
         */
        [Test]
        public void DecreaseTheOwnersAmountOfResource_WithTheAmountOfTheCost()
        {
            // Arrange
            uint availableCoins = 10;
            uint coinsToAdd = 5;
            var unit = new Unit(1, "nickName");
            var mockedCost = new Mock<IResources>();
            var mockedResource = new Mock<IResources>();

            unit.Resources.BronzeCoins = availableCoins + coinsToAdd;
            unit.Resources.SilverCoins = availableCoins + coinsToAdd;
            unit.Resources.GoldCoins = availableCoins + coinsToAdd;

            mockedCost.SetupGet(X => X.BronzeCoins).Returns(availableCoins);
            mockedCost.SetupGet(X => X.SilverCoins).Returns(availableCoins);
            mockedCost.SetupGet(X => X.GoldCoins).Returns(availableCoins);

            var expected = coinsToAdd;

            // Act
            unit.Pay(mockedCost.Object);
            var actualBronze = unit.Resources.BronzeCoins;
            var actualSilver = unit.Resources.BronzeCoins;
            var actualGold = unit.Resources.BronzeCoins;


            // Arrange
            Assert.AreEqual(expected, actualBronze);
            Assert.AreEqual(expected, actualSilver);
            Assert.AreEqual(expected, actualGold);
        }

        /*
         * Pay should return Resource object with the amount of resources in the cost object.
         */
        [Test]
        public void ReturnResourceObject_WithTheAmoutOfTheResource()
        {
            // Arrange
            uint availableCoins = 10;
            uint coinsToAdd = 5;
            var unit = new Unit(1, "nickName");
            var mockedCost = new Mock<IResources>();
            var mockedResource = new Mock<IResources>();

            unit.Resources.BronzeCoins = availableCoins + coinsToAdd;
            unit.Resources.SilverCoins = availableCoins + coinsToAdd;
            unit.Resources.GoldCoins = availableCoins + coinsToAdd;

            mockedCost.SetupGet(X => X.BronzeCoins).Returns(availableCoins);
            mockedCost.SetupGet(X => X.SilverCoins).Returns(availableCoins);
            mockedCost.SetupGet(X => X.GoldCoins).Returns(availableCoins);

            var expected = mockedCost.Object;

            // Act && Arrange
            Assert.IsInstanceOf<Resources>(unit.Pay(mockedCost.Object));
        }

    }
}