using System;
using NUnit.Framework;
using System.Collections.Generic;
using IntergalacticTravel.Contracts;
using Moq;
using IntergalacticTravel.Tests.Mocks;
using IntergalacticTravel.Exceptions;

namespace IntergalacticTravel.Tests
{
    [TestFixture]
    public class TeleportStationTests
    {
        [Test]
        public void Constructor_ShouldSetUpAllProvidedFields_WhenNewTeleportStationIsCreatedWithValidParams()
        {
            var mockedOwner = new Mock<IBusinessOwner>();
            var mockedPath = new Mock<IEnumerable<IPath>>();
            var mockedLocation = new Mock<ILocation>();

            var mockedStation = new MockedTeleportStation(mockedOwner.Object, mockedPath.Object, mockedLocation.Object);

            Assert.IsInstanceOf<ITeleportStation>(mockedStation);
        }

        [Test]
        public void TeleportUnit_ShouldThrowArgumentNullExceptionWithCorrectMessage_WhenUnitToTeleportIsNull()
        {
            var mockedOwner = new Mock<IBusinessOwner>();
            var mockedPath = new Mock<IEnumerable<IPath>>();
            var mockedLocation = new Mock<ILocation>();

            var mockedStation = new MockedTeleportStation(mockedOwner.Object, mockedPath.Object, mockedLocation.Object);

            Assert.That(() => mockedStation.TeleportUnit(null, mockedLocation.Object), Throws.ArgumentNullException.With.Message.Contains("unitToTeleport"));
        }

        [Test]
        public void TeleportUnit_ShouldThrowArgumentNullExceptionWithCorrectMessage_WhenLocationIsNull()
        {
            var mockedOwner = new Mock<IBusinessOwner>();
            var mockedPath = new Mock<IEnumerable<IPath>>();
            var mockedLocation = new Mock<ILocation>();
            var mockedUnit = new Mock<IUnit>();

            var mockedStation = new MockedTeleportStation(mockedOwner.Object, mockedPath.Object, mockedLocation.Object);

            Assert.That(() => mockedStation.TeleportUnit(mockedUnit.Object, null), Throws.ArgumentNullException.With.Message.Contains("destination"));
        }
    }
}
