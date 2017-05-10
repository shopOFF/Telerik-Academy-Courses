using System;
using NUnit.Framework;
using IntergalacticTravel;
using IntergalacticTravel.Contracts;
using Moq;
using IntergalacticTravel.Exceptions;

namespace IntergalacticTravel.Tests
{
    [TestFixture]
    public class UnitsFactoryTests
    {
        [TestCase("create unit Procyon Gosho 1", typeof(Procyon))]
        [TestCase("create unit Luyten Pesho 2", typeof(Luyten))]
        [TestCase("create unit Lacaille Tosho 3", typeof(Lacaille))]
        public void CreaturesFactory_WhenValidNameIsPassed_ShouldReturnExpectedType(string command, Type expectedResult)
        {
            var factory = new UnitsFactory();
            
            var actualResult = factory.GetUnit(command);
            
            Assert.IsInstanceOf(expectedResult.GetType(), actualResult.GetType());
        }

        [TestCase("")]
        [TestCase(null)]
        public void GetUnit_ShouldThrowInvalidUnitCreationCommandException_WhenCommandParamIsInvalid(string command)
        {
            var factory = new UnitsFactory();

            Assert.Throws<InvalidUnitCreationCommandException>(() => factory.GetUnit(command));
        }
    }
}
