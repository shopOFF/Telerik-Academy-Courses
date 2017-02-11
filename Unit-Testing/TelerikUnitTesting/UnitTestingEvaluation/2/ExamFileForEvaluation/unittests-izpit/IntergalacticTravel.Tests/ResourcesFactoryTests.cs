using IntergalacticTravel.Exceptions;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntergalacticTravel.Tests
{
    [TestFixture]
    class ResourcesFactoryTests
    {
        //[TestCase("create resources gold(20) silver(30) bronze(40)")]
        //[TestCase("create resources gold(20) bronze(40) silver(30)")]
        //[TestCase("create resources silver(30) bronze(40) gold(20)")]
        //[TestCase("create resources silver(30) gold(20) bronze(40)")]
        //[TestCase("create resources bronze(40) gold(20) silver(30)")]
        //[TestCase("create resources bronze(40) silver(30) gold(20)")]
        [Test]
        public void GetResourcesShouldReturnANewlyCreatedResourcesObjectWithCorrectlySetUpProperties()
        {
            var resources = new IntergalacticTravel.ResourcesFactory();
            var unit = resources.GetResources("create resources bronze(40) silver(30) gold(20)");
            Assert.IsInstanceOf<Resources>(resources);
        }

        [TestCase("create resources x y z")]
        [TestCase("tansta resources a b")]
        [TestCase("resources")]
        public void GetResourcesShouldThrowInvalidOperationExceptionWhichContainsTheStringCommandWhenTheInputStringRepresentsAnInvalidCommand(string InvalidCommand)
        {
            var resources = new IntergalacticTravel.ResourcesFactory();
            Assert.Throws<InvalidOperationException>(() => resources.GetResources(InvalidCommand));
        }

        [TestCase("create resources silver(10) gold(97853252356623523532) bronze(20)")]
        [TestCase("create resources silver(555555555555555555555555555555555) gold(97853252356623523532999999999) bronze(20)")]
        [TestCase("create resources silver(10) gold(20) bronze(4444444444444444444444444444444444444)")]
        public void GetResourcesShouldThrowOverflowExceptionWhentheInputStringCommandIsInTheCorrectFormatButAnyOfTheValuesThatRepresentTheResourceAmountIsLargerThanUintMaxValue(string overflow)
        {
            var resources = new IntergalacticTravel.ResourcesFactory();
            Assert.Throws<OverflowException>(() => resources.GetResources(overflow));
        }
    }
}
