using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
        public void GetResources_ShouldReturnResourceObjectsWithValidProperties_WhenValidCommandIsPassed(string command)
        {
            var resourcesFactory = new ResourcesFactory();

            var resourcesObject = resourcesFactory.GetResources(command);

            Assert.AreEqual(resourcesObject.BronzeCoins, 40);
            Assert.AreEqual(resourcesObject.GoldCoins, 20);
            Assert.AreEqual(resourcesObject.SilverCoins, 30);
        }

        [TestCase("create resources x y z")]
        [TestCase("tansta resources a b")]
        [TestCase("absolutelyRandomStringThatMustNotBeAValidCommand")]
        public void GetResources_ShouldThrowInvalidOperationException_WhenInvalidCommandIsPassed(string command)
        {
            var resourcesFactory = new ResourcesFactory();

            Assert.Throws<InvalidOperationException>(() => resourcesFactory.GetResources(command));
        }

        [TestCase("create resources silver(10) gold(97853252356623523532) bronze(20)")]
        [TestCase("create resources silver(555555555555555555555555555555555) gold(97853252356623523532999999999) bronze(20)")]
        [TestCase("create resources silver(10) gold(20) bronze(4444444444444444444444444444444444444)")]
        public void GetResources_ShouldThrowOverflowException_WhenIntegerPassedIsGreaterThanUIntMaxValue(string command)
        {
            var resourcesFactory = new ResourcesFactory();

            Assert.Throws<OverflowException>(() => resourcesFactory.GetResources(command));
        }
    }
}
