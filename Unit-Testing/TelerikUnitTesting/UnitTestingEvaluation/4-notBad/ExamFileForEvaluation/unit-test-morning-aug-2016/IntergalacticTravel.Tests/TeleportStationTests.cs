namespace IntergalacticTravel.Tests
{
    using System;
    using NUnit.Framework;
    using Moq;
    using IntergalacticTravel.Contracts;
    using System.Collections.Generic;
    using IntergalacticTravel.Tests.Mocks;
    using IntergalacticTravel.Exceptions;

    [TestFixture]
    public class TeleportStationTests
    {
        [Test]
        public void Constructor_ShouldSetAllProvidedFieldsCorrectly_WhenValidParametersArePassed()
        {
            //Arrange
            var mockedOwner = new Mock<IBusinessOwner>();
            var mockedGalacticMap = new Mock<IEnumerable<IPath>>();
            var mockedLocation = new Mock<ILocation>();

            //Act
            var teleportStation = new MockedTeleportStation(mockedOwner.Object, mockedGalacticMap.Object, mockedLocation.Object);

            //Assert
            Assert.AreSame(mockedOwner.Object, teleportStation.Owner);
            Assert.AreSame(mockedGalacticMap.Object, teleportStation.GalacticMap);
            Assert.AreSame(mockedLocation.Object, teleportStation.Location);
        }

        [Test]
        public void TeleportUnit_ShouldThrowArgumentNullExceptionWithProperMessage_WhenUnitToTeleportIsNull()
        {
            //Arrange
            var mockedTargetLocation = new Mock<ILocation>();
            var mockedOwner = new Mock<IBusinessOwner>();
            var mockedGalacticMap = new Mock<IEnumerable<IPath>>();
            var mockedStationLocation = new Mock<ILocation>();
            var teleportStation = new MockedTeleportStation(mockedOwner.Object, mockedGalacticMap.Object, mockedStationLocation.Object);

            //Act && Assert
            Assert.That(() => teleportStation.TeleportUnit(null, mockedTargetLocation.Object),
                Throws.ArgumentNullException.With.Message.Contains("unitToTeleport"));
        }

        [Test]
        public void TeleportUnit_ShouldThrowArgumentNullExceptionWithProperMessage_WhenDestinationIsNull()
        {
            //Arrange
            var mockedUnit = new Mock<IUnit>();
            var mockedOwner = new Mock<IBusinessOwner>();
            var mockedGalacticMap = new Mock<IEnumerable<IPath>>();
            var mockedStationLocation = new Mock<ILocation>();
            var teleportStation = new MockedTeleportStation(mockedOwner.Object, mockedGalacticMap.Object, mockedStationLocation.Object);

            //Act && Assert
            Assert.That(() => teleportStation.TeleportUnit(mockedUnit.Object, null),
                Throws.ArgumentNullException.With.Message.Contains("destination"));
        }

        //[Test]
        //public void TeleportUnit_ShouldThrowTeleportOutOfRangeExceptionWithProperMessage_WhenUnitIsUsingFromDistantLocation()
        //{
        //    //Arrange
        //    var mockedUnit = new Mock<IUnit>();
        //    var mockedOwner = new Mock<IBusinessOwner>();
        //    var mockedGalacticMap = new Mock<IEnumerable<IPath>>();
        //    var mockedTargetLocation = new Mock<ILocation>();

        //    mockedUnit.Setup(u => u.CurrentLocation.Coordinates.Latitude).Returns(12.3);
        //    mockedUnit.Setup(u => u.CurrentLocation.Coordinates.Longtitude).Returns(12.3);

        //    mockedTargetLocation.Setup(l => l.Coordinates.Latitude).Returns(111.3);
        //    mockedTargetLocation.Setup(l => l.Coordinates.Latitude).Returns(111.3);
        //    var teleportStation = new MockedTeleportStation(mockedOwner.Object, mockedGalacticMap.Object, mockedTargetLocation.Object);

        //    //Act && Assert
        //    //Assert.That(() => teleportStation.TeleportUnit(mockedUnit.Object, mockedTargetLocation.Object),
        //    //    Throws.TeleportOutOfRangeException.With.Message.Contains("destination"));

        //    Assert.Throws<TeleportOutOfRangeException>(() => teleportStation.TeleportUnit(mockedUnit.Object, mockedTargetLocation.Object));
        //}


    }
}
