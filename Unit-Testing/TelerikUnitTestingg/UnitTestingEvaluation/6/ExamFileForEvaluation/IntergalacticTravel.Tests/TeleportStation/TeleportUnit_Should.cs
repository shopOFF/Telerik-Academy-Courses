using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

using IntergalacticTravel.Contracts;
using IntergalacticTravel.Exceptions;

namespace IntergalacticTravel.Tests.TStation
{
    [TestClass]
    public class TeleportUnit_Should
    {
        //- TeleportUnit should throw ArgumentNullException, 
        // with a message that contains the string "unitToTeleport", 
        // when IUnit unitToTeleport is null.  
        [TestMethod]
        public void ThrowArgumentNullException_WhenCalledWithNullableUnitToTeleportParameter()
        {
            // Arrange
            var mockedOwner = new Mock<IBusinessOwner>(); //IBusinessOwner owner;
            var mockedLocation = new Mock<ILocation>(); // location;
            var mockedGalacticMap = new Mock<IEnumerable<IPath>>(); //IEnumerable<IPath> galacticMap;

            var mockedTeleportStation = new TeleportStation(mockedOwner.Object, mockedGalacticMap.Object, mockedLocation.Object);

            Action actTeleportUnit = 
                () => mockedTeleportStation.TeleportUnit(null, mockedLocation.Object);

            // Act and Assert
            Assert.ThrowsException<ArgumentNullException>(actTeleportUnit);

        }

        // - TeleportUnit should throw ArgumentNullException, 
        // with a message that contains the string "destination", 
        // when ILocation destination is null.
        [TestMethod]
        public void ThrowArgumentNullException_WhenCalledWithNullableTargetLocationParameter()
        {
            // Arrange
            var mockedUnitToUnit = new Mock<IUnit>();
            var mockedOwner = new Mock<IBusinessOwner>(); 
            var mockedLocation = new Mock<ILocation>();
            var mockedGalacticMap = new Mock<IEnumerable<IPath>>(); 

            var mockedTeleportStation = new TeleportStation(mockedOwner.Object, mockedGalacticMap.Object, mockedLocation.Object);

            Action actTeleportUnit =
                () => mockedTeleportStation.TeleportUnit(mockedUnitToUnit.Object, null);

            // Act and Assert
            Assert.ThrowsException<ArgumentNullException>(actTeleportUnit);

        }

        // - TeleportUnit should throw TeleportOutOfRangeException, 
        // with a message that contains the string "unitToTeleport.CurrentLocation", 
        // when а unit is trying to use the TeleportStation from a distant location(another planet for example).
        [TestMethod]
        public void ThrowTeleportOutOfRangeException_WhenUnitIsTryingToUseTeleportStationFromDistantLocation()
        {
            // Arrange
            var mockedUnitProcyonOnEarth = new Mock<IUnit>();
            var mockedOwner = new Mock<IBusinessOwner>();
            var mockedLocation = new Mock<ILocation>();
            var mockedGalacticMap = new Mock<IEnumerable<IPath>>();

            var mockedTeleportStation = new TeleportStation(mockedOwner.Object, mockedGalacticMap.Object, mockedLocation.Object);

            Action actTeleportUnit =
                () => mockedTeleportStation.TeleportUnit(mockedUnitProcyonOnEarth.Object, mockedLocation.Object);

            // Act
            mockedUnitProcyonOnEarth.Setup(x => x.CurrentLocation.Planet.Galaxy.Name).Returns("GalaxyS6");
            mockedUnitProcyonOnEarth.Setup(x => x.CurrentLocation.Planet.Name).Returns("Earth");
            mockedLocation.Setup(y => y.Planet.Name).Returns("Mars");
            mockedLocation.Setup(y => y.Planet.Galaxy.Name).Returns("GalaxyS6");

            // Act and Assert
            Assert.ThrowsException<TeleportOutOfRangeException>(actTeleportUnit);

        }


    }
}
