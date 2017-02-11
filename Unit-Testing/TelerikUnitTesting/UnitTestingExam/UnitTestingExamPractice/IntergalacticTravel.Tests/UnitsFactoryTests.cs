using System;
using NUnit.Framework;
using IntergalacticTravel.Exceptions;

namespace IntergalacticTravel.Tests
{
    [TestFixture]
    public class UnitsFactoryTests
    {
        [Test]
        public void GetUnit_WhenValidCommandIsPassed_ShouldReturnNewProcyonUnit()
        {
            // Arange
            var unitsFactory = new UnitsFactory();
            var validCommand = "create unit Procyon Gosho 1";

            // Act & Assert
            Assert.IsInstanceOf<Procyon>(unitsFactory.GetUnit(validCommand));
        }

        [Test]
        public void GetUnit_WhenValidCommandIsPassed_ShouldReturnNewLuytenUnit()
        {
            // Arrange
            var unitsFactory = new UnitsFactory();
            var validCommand = "create unit Luyten Pesho 2";

            // Act & Assert
            Assert.IsInstanceOf<Luyten>(unitsFactory.GetUnit(validCommand));
        }

        [Test]
        public void GetUnit_WhenValidCommandIsPassed_ShouldReturnNewLacailleUnit()
        {
            // Arrange
            var unitsFactory = new UnitsFactory();
            var validCommand = "create unit Lacaille Tosho 3";

            // Act & Assert
            Assert.IsInstanceOf<Lacaille>(unitsFactory.GetUnit(validCommand));
        }

        [TestCase("")]
        [TestCase("invalid command Toshe e, should throw InvalidUnitCreationCommandException")]
        [TestCase("this string command is also invalid")]
        [TestCase(null)]
        public void GetUnit_WhenCommandIsNotInTheValidFormatPassed_ShouldThrowInvalidUnitCreationCommandException(string invalidCommand)
        {
            // Arrange
            var unitsFactory = new UnitsFactory();

            // Act & Assert
            Assert.Throws<InvalidUnitCreationCommandException>(() => unitsFactory.GetUnit(invalidCommand));
        }


        // ЕДИН С ПАРАМЕТРИ МОЖЕ ДА СЕ НАПРАВИ ЗА ПЪРВИТЕ 3 ТЕСТА ВМЕСТО ДА СА ПО ОТДЕЛНО(НО НЯМА ДА Е ТОЛКОВА ОПИСАТЕЛЕН И ЩЕ Е ПО ТРУДЕН ЗА ЧЕТЕНЕ)!!!

        [TestCase("create unit Procyon Gosho 1", typeof(Procyon))]
        [TestCase("create unit Luyten Pesho 2", typeof(Luyten))]
        [TestCase("create unit Lacaille Tosho 3", typeof(Lacaille))]
        public void GetUnit_WhenValidCommandIsPassed_ShouldReturnNewUnit(string validCommand, Type expectedTypeOfUnit)
        {
            // Arrange
            var unitsFactory = new UnitsFactory();

            // Act & Assert
            Assert.IsInstanceOf(expectedTypeOfUnit, unitsFactory.GetUnit(validCommand));
        }
    }
}
