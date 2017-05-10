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
    class UnitsFactoryTests
    {
        [Test]
        public void GetUnitShouldReturnNewProcyonUnitWhenAValidCorrespondingCommandIsPassed()
        {
            var factory = new IntergalacticTravel.UnitsFactory();

            var unit = factory.GetUnit("create unit Procyon Gosho 1");

            Assert.IsInstanceOf<Procyon>(unit);
        }
        [Test]
        public void GetUnitShouldReturnNewLuytenUnitWhenAValidCorrespondingCommandIsPassed()
        {
            var factory = new IntergalacticTravel.UnitsFactory();

            var unit = factory.GetUnit("create unit Luyten Pesho 2");

            Assert.IsInstanceOf<Luyten>(unit);
        }
        [Test]
        public void GetUnitShouldReturnNewLacailleUnitWhenAValidCorrespondingCommandIsPassed()
        {
            var factory = new IntergalacticTravel.UnitsFactory();

            var unit = factory.GetUnit("create unit Lacaille Tosho 3");

            Assert.IsInstanceOf<Lacaille>(unit);
        }
        [TestCase("create unit Procyon Gosho1")]
        [TestCase("create Luyten Pesho 2")]
        [TestCase("create Lacaille Tosho 3")]
        [TestCase("create Gosho" )]
        public void GetUnitShouldThrowInvalidUnitCreationCommandExceptionWhenTheCommandPassedIsNotInTheValidFormatDescribedAbov(string InvalidCommand)
        {
            var factory = new IntergalacticTravel.UnitsFactory();
            Assert.Throws<InvalidUnitCreationCommandException>(() => factory.GetUnit(InvalidCommand));
        }
    }
}
