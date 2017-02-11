namespace IntergalacticTravel.Tests
{
    using System;
    using NUnit.Framework;
    using Moq;
    using IntergalacticTravel.Contracts;

    [TestFixture]
    public class ResourcesFactoryTests
    {
        [Test]
        public void GetResources_ShouldReturnResourcesObject_WhenInputStringIsCorrect()
        {
            // Arrange
            var validInput = "create resources gold(20) silver(30) bronze(40)";
            ResourcesFactory resourcesFactory = new ResourcesFactory();

            // Act
            var executionResult = resourcesFactory.GetResources(validInput);

            // Assert
            Assert.IsInstanceOf<Resources>(executionResult);
        }

        [TestCase("create resources gold(20) silver(30) bronze(40)")]
        [TestCase("create resources gold(20) bronze(40) silver(30)")]
        [TestCase("create resources silver(30) bronze(40) gold(20)")]
        [TestCase("create resources silver(30) gold(20) bronze(40)")]
        [TestCase("create resources bronze(40) gold(20) silver(30)")]
        [TestCase("create resources bronze(40) silver(30) gold(20)")]
        public void GetResources_ShouldReturnResourcesObjectWithCorrectPropertyValues_WhenInputStringIsValid(string validInput)
        {
            // Arrange
            var expectedResourceObj = new Mock<IResources>();
            expectedResourceObj.SetupGet(r => r.BronzeCoins).Returns((uint)40);
            expectedResourceObj.SetupGet(r => r.SilverCoins).Returns((uint)30);
            expectedResourceObj.SetupGet(r => r.GoldCoins).Returns((uint)20);

            ResourcesFactory resourcesFactory = new ResourcesFactory();

            // Act
            var executionResult = resourcesFactory.GetResources(validInput);

            // Assert
            Assert.AreEqual(expectedResourceObj.Object.BronzeCoins, executionResult.BronzeCoins);
            Assert.AreEqual(expectedResourceObj.Object.SilverCoins, executionResult.SilverCoins);
            Assert.AreEqual(expectedResourceObj.Object.GoldCoins, executionResult.GoldCoins);
        }

        [TestCase("create resources x y z")]
        [TestCase("")]
        [TestCase("Zele s Luk")]
        [TestCase("krem zdrave")]
        public void GetResources_ShouldThrowInvalidOperationException_WhenInputStringIsInvalid(string invalidInput)
        {
            //Arrange
            ResourcesFactory resourcesFactory = new ResourcesFactory();

            //Act && Assert
            Assert.That(() => resourcesFactory.GetResources(invalidInput), Throws.InvalidOperationException.With.Message.Contains("command"));
        }

        [TestCase("create resources silver(10) gold(97853252356623523532) bronze(20)")]
        [TestCase("create resources silver(555555555555555555555555555555555) gold(97853252356623523532999999999) bronze(20)")]
        [TestCase("create resources silver(10) gold(20) bronze(4444444444444444444444444444444444444)")]
        [TestCase("create resources silver(4294967296) gold(4294967296) bronze(4294967296)")]
        public void GetResources_ShouldThrowOverflowException_WhenInputStringInValidFormatButWithBigValues(string invalidInput)
        {
            //Arrange
            ResourcesFactory resourcesFactory = new ResourcesFactory();

            //Act && Assert
            Assert.Throws<OverflowException>(() => resourcesFactory.GetResources(invalidInput));
        }


    }
}
