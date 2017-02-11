using System;
using NUnit.Framework;

using Moq;
using IntergalacticTravel.Constants;
using IntergalacticTravel.Contracts;
using IntergalacticTravel.Exceptions;
using IntergalacticTravel.Extensions;
using System.Collections.Generic;

namespace IntergalacticTravel.Tests
{
    [TestFixture]
    public class UnitTests
    {
        [Test]
        public void Pay_WhenPassedObjectIsNull_ShouldThrowNullReferenceException()
        {
            // Arrange
            var unitTest = new Unit(1313, "someNickName");

            // Act & Assert
            Assert.Throws<NullReferenceException>(() => unitTest.Pay(null));
        }


        // TODO:
        [Test]
        public void Pay_WhenPassedValuesAreValid_ShouldDecreaseTheOwnersResourcesByTheAmountOfTheCost()
        {
            // Arrange
            var unitTest = new Unit(1313, "someNickName");

            var mockedIResourcesCost = new Mock<IResources>();
            mockedIResourcesCost.Setup(c => c.GoldCoins).Returns(10);
            mockedIResourcesCost.Setup(c => c.SilverCoins).Returns(20);
            mockedIResourcesCost.Setup(c => c.BronzeCoins).Returns(5);
            unitTest.Resources.Add(mockedIResourcesCost.Object);
            var expectedResult = 0;
            // Act
            unitTest.Pay(mockedIResourcesCost.Object);

            Assert.AreEqual(0,unitTest.Resources.GoldCoins);
            // Assert
         // TODO:
        }
    }
}
