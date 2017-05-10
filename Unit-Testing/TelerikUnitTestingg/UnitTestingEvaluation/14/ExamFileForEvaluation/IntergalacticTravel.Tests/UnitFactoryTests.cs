using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IntergalacticTravel;
using IntergalacticTravel.Contracts;
using IntergalacticTravel.Exceptions;

namespace IntergalacticTravel.Tests
{
    [TestFixture]
    public class UnitFactoryTests
    {
        [Test]
        public void GetUnit_ShouldReturnProcyop_WhenValidCommandIsPassed()
        {
            var factory = new UnitsFactory();

            var procyon = factory.GetUnit("create unit Procyon Gosho 1");

            Assert.IsInstanceOf(typeof(Procyon), procyon);
        }

        [Test]
        public void GetUnit_ShouldReturnLuyten_WhenValidCommandIsPassed()
        {
            var factory = new UnitsFactory();

            var luyten = factory.GetUnit("create unit Luyten Pesho 2");

            Assert.IsInstanceOf(typeof(Luyten), luyten);
        }

        [Test]
        public void GetUnit_ShouldReturnLacaille_WhenValidCommandIsPassed()
        {
            var factory = new UnitsFactory();

            var lacaille = factory.GetUnit("create unit Lacaille Tosho 3");

            Assert.IsInstanceOf(typeof(Lacaille), lacaille);
        }

        [TestCase("create unit Lacaille Tosho3")]
        [TestCase("create unit Gyrmej Pesho 5")]
        [TestCase("create unit Procyom Gosho 1")]
        public void GetUnit_ShouldThrow_WhenInvalidCommandIsPassed(string command)
        {
            var factory = new UnitsFactory();

            Assert.Throws<InvalidUnitCreationCommandException>(() => factory.GetUnit(command));
        }
    }
}
