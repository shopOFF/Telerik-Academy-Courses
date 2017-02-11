using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using IntergalacticTravel.Exceptions;

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
        public void GetResources_WhenInputStringIsInTheCorrectFormat_ShouldReturnNewResourcesObject(string validCommand)
        {
            // Arrange
            var resourceFactory = new ResourcesFactory();
            var expectedBronzSilverGoldCoins = "Bronz=40, Silver=30, Gold=20";
            // или може и с числа да асъртваме, но ще е по сложно, може да се наложи и 3 асърта да има, както преценим

            // Act
            var resourceObject = resourceFactory.GetResources(validCommand);

            // Assert
            var actualBronzSilverGoldCoins = $"Bronz={resourceObject.BronzeCoins}, Silver={resourceObject.SilverCoins}, Gold={resourceObject.GoldCoins}";
            //var actualBronzSilverGoldCoins = string.Format("Bronz={0}, Silver={1}, Gold={2}",resourceObject.BronzeCoins,resourceObject.SilverCoins,resourceObject.GoldCoins);
            Assert.AreEqual(expectedBronzSilverGoldCoins, actualBronzSilverGoldCoins);
        }

        [TestCase("create resources x y z")]
        [TestCase("tansta resources a b")]
        [TestCase("absolutelyRandomStringThatMustNotBeAValidCommand")]
        [TestCase("")]
        [TestCase(null)]
        public void GetResources_WhenCommandIsInvalid_ShouldThrowInvalidOperationException(string invalidCommand)
        {
            // Arrange
            var resourceFactory = new ResourcesFactory();

            // Act & Assert
            Assert.That(() => resourceFactory.GetResources(invalidCommand), Throws.TypeOf<InvalidOperationException>().With.Message.Contains("Invalid command"));
            // Assert.Throws<InvalidOperationException>(() => resourceFactory.GetResources(invalidCommand));  // ако искаме да е без съобщението
        }

        [TestCase("create resources silver(10) gold(97853252356623523532) bronze(20)")]
        [TestCase("create resources silver(555555555555555555555555555555555) gold(97853252356623523532999999999) bronze(20)")]
        [TestCase("create resources silver(10) gold(20) bronze(4444444444444444444444444444444444444)")]
        public void GetResources_WhenCommandIsInvalidButValuesAreLargerThanUintMaxValue_ShouldThrowInvalidOverflowException(string invalidCommand)
        {
            // Arrange
            var resourceFactory = new ResourcesFactory();

            // Act & Assert
            Assert.Throws<OverflowException>(() => resourceFactory.GetResources(invalidCommand));
        }
    }
}
