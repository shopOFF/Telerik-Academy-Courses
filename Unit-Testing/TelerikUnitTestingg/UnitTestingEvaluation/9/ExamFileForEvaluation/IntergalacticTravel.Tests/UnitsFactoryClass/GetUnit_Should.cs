namespace IntergalacticTravel.Tests.UnitsFactoryClass
{
    using System;
    using IntergalacticTravel;
    using IntergalacticTravel.Exceptions;
    using NUnit.Framework;

    [TestFixture]
    public class GetUnit_Should
    {
        // GetUnit should return new Procyon unit,
        //when a valid corresponding command is passed (i.e. "create unit Procyon Gosho 1");
        // GetUnit should return new Luyten unit,
        // when a valid corresponding command is passed (i.e. "create unit Luyten Pesho 2");
        // GetUnit should return new Lacaille unit,
        // when a valid corresponding command is passed (i.e. "create unit Lacaille Tosho 3");
        [TestCase("create unit Luyten Pesho 2", typeof(Luyten))]
        [TestCase("create unit Procyon Gosho 1", typeof(Procyon))]
        [TestCase("create unit Lacaille Tosho 3", typeof(Lacaille))]
        public void ReturnNewLuytenUnit_WhenAValidCommandIsPassed(string input, Type expectedType)
        {
            // Arrange
            var unitsFactory = new UnitsFactory();

            // Act
            var actual = unitsFactory.GetUnit(input);

            // Assert
            Assert.IsInstanceOf(expectedType, actual);
        }

        /*GetUnit should throw InvalidUnitCreationCommandException,
         * when the command passed is not in the valid format described above.
         * (Check for at least 2 different cases)
         */
        [TestCase("create unit Unicorn Pesho 1")]
        [TestCase("")]
        [TestCase(null)]
        [TestCase("   create    unit    Unicorn    Pesho    1")]
        public void ThrowInvalidUnitCreationCommandExpection_WhenTheCommandPassedIsNotInTheValidFormat(string command)
        {
            // Arrange
            var unitsFactory = new UnitsFactory();

            //Act && Assert
            Assert.Throws<InvalidUnitCreationCommandException>(() => unitsFactory.GetUnit(command));
        }
    }
}