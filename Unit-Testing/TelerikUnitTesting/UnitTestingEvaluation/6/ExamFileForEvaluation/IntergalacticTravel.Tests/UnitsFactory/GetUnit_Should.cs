using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using IntergalacticTravel.Contracts;
using IntergalacticTravel.Exceptions;

namespace IntergalacticTravel.Tests
{
    [TestClass]
    public class GetUnit_Should
    {
        // 1. GetUnit should return new Procyon unit, 
        // when a valid corresponding command is passed
        // (i.e. "create unit Procyon Gosho 1");
        [TestMethod]
        public void ReturnNewProcyon_WhenValidCorrespondingCommandIsPassed()
        {
            // Arrange
            var factory = new IntergalacticTravel.UnitsFactory();

            // Act
            var unit = factory.GetUnit("create unit Procyon Gosho 1");

            // Assert
            Assert.IsInstanceOfType(unit, typeof(IUnit));
        }

        // - GetUnit should return new Luyten unit, 
        // when a valid corresponding command is passed
        // (i.e. "create unit Luyten Pesho 2")
        [TestMethod]
        public void ReturnNewLuyten_WhenValidCorrespondingCommandIsPassed()
        {
            // Arrange
            var factory = new IntergalacticTravel.UnitsFactory();

            // Act
            var luytenPesho2 = factory.GetUnit("create unit Luyten Pesho 2");

            // Assert
            Assert.IsInstanceOfType(luytenPesho2, typeof(IUnit));
        }

        [TestMethod]
        // - GetUnit should return new Lacaille unit, 
        // when a valid corresponding command is passed(
        // i.e. "create unit Lacaille Tosho 3");
        public void ReturnNewLacaille_WhenValidCorrespondingCommandIsPassed()
        {
            // Arrange
            var factory = new IntergalacticTravel.UnitsFactory();

            // Act
            var lacaillePesho2 = factory.GetUnit("create unit Luyten Pesho 2");

            // Assert
            Assert.IsInstanceOfType(lacaillePesho2, typeof(IUnit));
        }

        // - GetUnit should throw InvalidUnitCreationCommandException, 
        // when the command passed is not in the valid format described above. 
        // (Check for at least 2 different cases)

        // TODO With invalid command parameter

        // TODO With invalid unit parameter

        // With invalid unit type parameter
        [TestMethod]
        public void ThrowInvalidUnitCreationCommandException_WhenCommandPassedContainsNoValidUnitType()
        {
            // create unit Luyten Pesho 2
            // Arrange
            UnitsFactory factory = new UnitsFactory();
            string invalidCommand = "create unit Luyten______ Pesho 2";

            Action actFactoryGetUnit =
                () => factory.GetUnit(invalidCommand);

            // Act and Assert
            Assert.ThrowsException<InvalidUnitCreationCommandException>(actFactoryGetUnit);
        }

        // TODO With invalid Name

        // TODO With invalid Index parameter
        [TestMethod]
        public void ThrowInvalidUnitCreationCommandException_WhenCommandPassedContainsNegativeIndexParameter()
        {
            // create unit Luyten Pesho 2
            // Arrange
            UnitsFactory factory = new UnitsFactory();
            string invalidCommand = "create unit Luyten Pesho -2";

            Action actFactoryGetUnit =
                () => factory.GetUnit(invalidCommand);

            // Act and Assert
            Assert.ThrowsException<InvalidUnitCreationCommandException>(actFactoryGetUnit);
        }

        // With Four parameters
        [TestMethod]
        public void ThrowInvalidUnitCreationCommandException_WhenCommandPassedContainsOnlyFourParameters()
        {
            // create unit Luyten Pesho 2
            // Arrange
            UnitsFactory factory = new UnitsFactory();
            string invalidCommand = "unit Luyten Pesho 2";

            Action actFactoryGetUnit =
                () => factory.GetUnit(invalidCommand);

            // Act and Assert
            Assert.ThrowsException<InvalidUnitCreationCommandException>(actFactoryGetUnit);
        }

        // TODO With five valid parameters but mixed order
    }
}
