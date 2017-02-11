using System;
using NUnit.Framework;

using IntergalacticTravel.Exceptions;

namespace IntergalacticTravel.Tests
{
    [TestFixture]
    public class UnitsFactoryTests
    {
        [Test]
        public void GetUnit_WhenValidCorrespondingCommandIsPassed_ShouldReturnNewProcyonUnit()
        {
            // Arrange
            var unitsFactoryTest = new UnitsFactory();

            // Act 
            var executionResult = unitsFactoryTest.GetUnit("create unit Procyon Gosho 1");

            // Assert
            Assert.IsInstanceOf<Procyon>(executionResult); 
        }

        [Test]
        public void GetUnit_WhenValidCorrespondingCommandIsPassed_ShouldReturnNewLuytenUnit()
        {
            // Arrange
            var unitsFactoryTest = new UnitsFactory();

            // Act 
            var executionResult = unitsFactoryTest.GetUnit("create unit Luyten Pesho 2");

            // Assert
            Assert.IsInstanceOf<Luyten>(executionResult); 
        }

        [Test]
        public void GetUnit_WhenValidCorrespondingCommandIsPassed_ShouldReturnNewLacailleUnit()
        {
            // Arrange
            var unitsFactoryTest = new UnitsFactory();

            // Act 
            var executionResult = unitsFactoryTest.GetUnit("create unit Lacaille Tosho 3");

            // Assert
            Assert.IsInstanceOf<Lacaille>(executionResult); 
        }

        [TestCase("create unit Invalid Tosho 3")]
        [TestCase("create unit Tosho 3")]
        [TestCase("create")]
        [TestCase(null)]
        [TestCase("")]
        [TestCase("5")]
        public void GetUnit_WhenNotValidCommandIsPassed_ShouldThrowInvalidUnitCreationCommandException(string invalidCommand)
        {
            // Arrange
            var unitsFactoryTest = new UnitsFactory();

            // Act & Assert
            Assert.Throws<InvalidUnitCreationCommandException>(() => unitsFactoryTest.GetUnit(invalidCommand));
        }
    }
}
