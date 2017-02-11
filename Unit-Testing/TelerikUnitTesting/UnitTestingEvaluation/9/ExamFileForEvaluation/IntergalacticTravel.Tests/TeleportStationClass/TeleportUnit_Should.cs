namespace IntergalacticTravel.Tests.TeleportStationClass
{
    using System;
    using IntergalacticTravel;
    using IntergalacticTravel.Contracts;
    using Moq;
    using NUnit.Framework;
    using System.Collections.Generic;
    using Exceptions;

    [TestFixture]
    public class TeleportUnit_Should
    {
        /*TeleportUnit should throw ArgumentNullException, with a message that contains the string "unitToTeleport",
                 * when IUnit unitToTeleport is null.
                 */
        [Test]
        public void ThrowArgumentNullExceptionWithAMessageUnitToTeleport_WhenTheIUnitUnitToTeleportIsNull()
        {
            // Arrange
            var mockedOwner = new Mock<IBusinessOwner>();
            var mockedIPath = new Mock<IPath>();
            var galacticMap = new[] { mockedIPath.Object };
            var mockedLocation = new Mock<ILocation>();
            var mockedTargetLocation = new Mock<ILocation>();

            IUnit unitToTeleport = null;

            var teleportStation = new TeleportStation(mockedOwner.Object, galacticMap, mockedLocation.Object);
            var expectedMessage = "unitToTeleport";

            // Act
            var actual = Assert.Throws<ArgumentNullException>(() => teleportStation.TeleportUnit(unitToTeleport, mockedTargetLocation.Object));

            // Assert
            StringAssert.Contains(expectedMessage, actual.Message);

        }

        /*TeleportUnit should throw ArgumentNullException, with a message that contains the string "destination",
         * when ILocation destination is null.
         */
        [Test]
        public void ThrowArgumentNullExceptionWithAMessageDestination_WhenTheILocationDestinationIsNull()
        {
            // Arrange
            var mockedOwner = new Mock<IBusinessOwner>();
            var mockedIPath = new Mock<IPath>();
            var galacticMap = new[] { mockedIPath.Object };
            var mockedLocation = new Mock<ILocation>();
            var mockedUnitToTeleport = new Mock<IUnit>();

            ILocation targetLocation = null;

            var teleportStation = new TeleportStation(mockedOwner.Object, galacticMap, mockedLocation.Object);
            var expectedMessage = "destination";

            // Act
            var actual = Assert.Throws<ArgumentNullException>(() => teleportStation.TeleportUnit(mockedUnitToTeleport.Object, targetLocation));

            // Assert
            StringAssert.Contains(expectedMessage, actual.Message);
        }

        /*TeleportUnit should throw TeleportOutOfRangeException,
         * with a message that contains the string "unitToTeleport.CurrentLocation",
         * when а unit is trying to use the TeleportStation from a distant location (another planet for example).
         */
        [Test]
        public void ThrowTeleportOutOfRangeException_WithAMessageUnitToTeleportCurrentLocation_WhenAUnitIsTryingToUseTeleportStationFromADistantLocation()
        {
            // Arrange
            var mockedOwner = new Mock<IBusinessOwner>();
            var mockedIPath = new Mock<IPath>();
            var galacticMap = new[] { mockedIPath.Object };
            var mockedLocation = new Mock<ILocation>();

            mockedLocation.SetupGet(x => x.Planet.Galaxy.Name).Returns("First Galaxy");
            mockedLocation.SetupGet(x => x.Planet.Name).Returns("First Planet");

            var teleportStation = new TeleportStation(mockedOwner.Object, galacticMap, mockedLocation.Object);

            var mockedUnitToTeleport = new Mock<IUnit>();
            var mockedLocationToTravelTo = new Mock<ILocation>();

            mockedUnitToTeleport.SetupGet(x => x.CurrentLocation.Planet.Name).Returns("Second Planet");
            mockedUnitToTeleport.SetupGet(x => x.CurrentLocation.Planet.Galaxy.Name).Returns("Second Galaxy");

            mockedLocationToTravelTo.SetupGet(x => x.Planet.Name).Returns("Second Planet");
            mockedLocationToTravelTo.SetupGet(x => x.Planet.Galaxy.Name).Returns("Second Galaxy");

            // Act
            var actual = Assert.Throws<TeleportOutOfRangeException>(() => teleportStation.TeleportUnit(mockedUnitToTeleport.Object, mockedLocationToTravelTo.Object));

            // Assert
            StringAssert.Contains("unitToTeleport.CurrentLocation", actual.Message);
        }
    }
}