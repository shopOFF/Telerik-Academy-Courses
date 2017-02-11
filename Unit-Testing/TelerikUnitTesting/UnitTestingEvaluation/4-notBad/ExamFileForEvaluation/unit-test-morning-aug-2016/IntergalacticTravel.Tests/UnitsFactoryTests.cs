namespace IntergalacticTravel.Tests
{
    using System;
    using NUnit.Framework;
    using IntergalacticTravel;
    using IntergalacticTravel.Exceptions;

    [TestFixture]
    public class UnitsFactoryTests
    {
        [Test]
        public void GetUnit_ShouldReturnNewProcyon_WhenValidCommandIsPassed()
        {
            // Arrange
            var validCommand = "create unit Procyon Gosho 1";
            UnitsFactory unitsFactory = new UnitsFactory();

            // Act
            var executionResult = unitsFactory.GetUnit(validCommand);

            // Assert
            Assert.IsInstanceOf<Procyon>(executionResult);
        }

        [Test]
        public void GetUnit_ShouldReturnNewLuyten_WhenValidCommandIsPassed()
        {
            // Arrange
            var validCommand = "create unit Luyten Pesho 2";
            UnitsFactory unitsFactory = new UnitsFactory();

            // Act
            var executionResult = unitsFactory.GetUnit(validCommand);

            // Assert
            Assert.IsInstanceOf<Luyten>(executionResult);
        }

        [Test]
        public void GetUnit_ShouldReturnNewLacaille_WhenValidCommandIsPassed()
        {
            // Arrange
            var validCommand = "create unit Lacaille Tosho 3";
            UnitsFactory unitsFactory = new UnitsFactory();

            // Act
            var executionResult = unitsFactory.GetUnit(validCommand);

            // Assert
            Assert.IsInstanceOf<Lacaille>(executionResult);
        }

        [TestCase(null)]
        [TestCase("")]
        [TestCase("create unit NoSuchUnit Tosho 3")]
        [TestCase("NoSuchUnit create unit Tosho 3")]
        public void GetUnit_ShouldThrowInvalidUnitCreationCommandException_WhenInvalidCommandIsPassed(string command)
        {
            // Arrange
            UnitsFactory unitsFactory = new UnitsFactory();

            // Act && Assert
            Assert.Throws<InvalidUnitCreationCommandException>(() => unitsFactory.GetUnit(command));
        }
    }
}
