using System;
using NUnit.Framework;

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
        public void GetResources_ShouldReturnNewlyCreatedResourcesObject_WhenCommandParamIsValid(string command)
        {
            var expectedResources = new Resources(40, 30, 20);
            var resourcesFactory = new ResourcesFactory();
            bool expectedResult = false;

            var actualResources = resourcesFactory.GetResources(command);
            if (expectedResources.BronzeCoins == actualResources.BronzeCoins &&
                expectedResources.SilverCoins == actualResources.SilverCoins &&
                expectedResources.GoldCoins == actualResources.GoldCoins)
            {
                expectedResult = true;
            }

            Assert.IsTrue(expectedResult);
        }

        [TestCase("create resources x y z")]
        [TestCase("tansta resources a b")]
        [TestCase("absolutelyRandomStringThatMustNotBeAValidCommand")]
        public void GetResources_ShouldThrowInvalidOperationExceptionWithCorrectMessage_WhenCommandParamIsInvalid(string command)
        {
            var resourceFactory = new ResourcesFactory();
            
            Assert.That(() => resourceFactory.GetResources(command), Throws.InvalidOperationException.With.Message.Contains("command"));
        }

        [TestCase("create resources silver(10) gold(97853252356623523532) bronze(20)")]
        [TestCase("create resources silver(555555555555555555555555555555555) gold(97853252356623523532999999999) bronze(20)")]
        [TestCase("create resources silver(10) gold(20) bronze(4444444444444444444444444444444444444)")]
        public void GetResources_ShouldThrowOverflowException_WhenCommandParamIsValidButValuesAreOutOfRange(string command)
        {
            var resourceFactory = new ResourcesFactory();

            Assert.Throws<OverflowException>(() => resourceFactory.GetResources(command));
        }

    }
}
