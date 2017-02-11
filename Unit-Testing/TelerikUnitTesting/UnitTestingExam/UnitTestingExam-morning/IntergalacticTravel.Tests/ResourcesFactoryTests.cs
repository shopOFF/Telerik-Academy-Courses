using System;
using NUnit.Framework;

using IntergalacticTravel.Constants;
using IntergalacticTravel.Contracts;
using IntergalacticTravel.Exceptions;
using IntergalacticTravel.Extensions;
using System.Text;

namespace IntergalacticTravel.Tests
{
    [TestFixture]
    public class ResourcesFactoryTests
    {
        [TestCase("create resources gold(20) silver(30) bronze(40)")]
        [TestCase("create resources gold(20) bronze(40) silver(30)")]
        [TestCase("create resources silver(30) bronze(40) gold(20)")]
        [TestCase("create resources silver(30) gold(20) bronze(40)")]
        [TestCase("create resources bronze(40) gold(20) silver(30)")]
        [TestCase("create resources bronze(40) silver(30) gold(20)")]
        public void GetResources_WhenTheInputStringIsValid_ShouldReturnNewResourcesObjectWithCorrectlySetProps(string validInput)
        {
            // Arrange
            var resourcesFactoryTest = new ResourcesFactory();

            var expectedResult = "40 Bronze Coins, 30 Silver Coins and 20 Gold Coins.";

            // Act
            var executionResult = resourcesFactoryTest.GetResources(validInput);
            var expectedResultInStringFormat = string.Format("{0} Bronze Coins, {1} Silver Coins and {2} Gold Coins.",
                executionResult.BronzeCoins, executionResult.SilverCoins, executionResult.GoldCoins);

            // Assert
            Assert.AreEqual(expectedResult, expectedResultInStringFormat);
        }


        [TestCase("create resources x y z")]
        [TestCase("tansta resources a b")]
        [TestCase("absolutelyRandomStringThatMustNotBeAValidCommand")]
        [TestCase("silver30 gold20 coal30")]
        [TestCase(null)]
        [TestCase("")]
        public void GetResources_WhenTheInputStringIsInvalid_ShouldThrowInvalidOperationException(string invalidInput)
        {
            // Arrange
            var resourcesFactoryTest = new ResourcesFactory();

            // Act & Assert
            Assert.That(() => resourcesFactoryTest.GetResources(invalidInput), Throws.TypeOf<InvalidOperationException>().With.Message.Contains("Invalid command"));
        }


        [TestCase("create resources silver(10) gold(97853252356623523532) bronze(20)")]
        [TestCase("create resources silver(555555555555555555555555555555555) gold(97853252356623523532999999999) bronze(20)")]
        [TestCase("create resources silver(10) gold(20) bronze(4444444444444444444444444444444444444)")]
        public void GetResources_WhenTheInputStringIsValidButResourcesValuesAreLargerThanUintMaxValue_ShouldThrowOverflowException(string invalidInput)
        {
            // Arrange
            var resourcesFactoryTest = new ResourcesFactory();

            // Act & Assert
            Assert.Throws<OverflowException>(() => resourcesFactoryTest.GetResources(invalidInput));
        }
    }
}
