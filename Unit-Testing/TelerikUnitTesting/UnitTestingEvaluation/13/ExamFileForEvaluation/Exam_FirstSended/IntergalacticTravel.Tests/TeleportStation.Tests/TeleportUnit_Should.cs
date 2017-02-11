namespace IntergalacticTravel.Tests.TeleportStation.Tests
{
    using System.Collections.Generic;
    using Contracts;
    using NUnit.Framework;
    using IntergalacticTravel;
    using Moq;

    [TestFixture]
    public class TeleportUnit_Should
    {
        //1


        //2
        [Test]
        public void ThrowArgumentNullException_WithMessageThatContainsTheStringUnitToTeleport_WhenIUnitUnitToTeleportIsNull()
        {
            var mockedOwner = new Mock<IBusinessOwner>();
            var mockedGalacticMap = new Mock<IEnumerable<IPath>>();
            var mockedLocation = new Mock<ILocation>();
            
            var mockedTeleportStation = new TeleportStation(mockedOwner.Object, mockedGalacticMap.Object, mockedLocation.Object);

             Assert.That(() => mockedTeleportStation.TeleportUnit(null, mockedLocation.Object), Throws.ArgumentNullException.With.Message.Contains("unitToTeleport"));
        }

        //3
        [Test]
        public void ThrowArgumentNullException_WithMessageThatContainsTheStringDestination_WhenILocationdestinationIsNull()
        {
            var mockedOwner = new Mock<IBusinessOwner>();
            var mockedGalacticMap = new Mock<IEnumerable<IPath>>();
            var mockedLocation = new Mock<ILocation>();
            var mockedUnit= new Mock<IUnit>();

            var mockedTeleportStation = new TeleportStation(mockedOwner.Object, mockedGalacticMap.Object, mockedLocation.Object);

            Assert.That(() => mockedTeleportStation.TeleportUnit(mockedUnit.Object, null), Throws.ArgumentNullException.With.Message.Contains("destination"));
        }

        //4
//        [Test]
//        public void ThrowTeleportOutOfRangeException_WithMessageThatContainsTheStringunitToTeleportCurrentLocation_WhenAUnitIsTryingToUseTheTeleportStationFfromADistantLocation()
//        {
//            var mockedOwner = new Mock<IBusinessOwner>();
//            var mockedGalacticMap = new Mock<IEnumerable<IPath>>();
//            var mockedLocation = new Mock<ILocation>();
//            var mockedUnit = new Mock<IUnit>();
//
//            mockedLocation.SetupGet(l => l.Planet).Returns()
//
//            var mockedTeleportStation = new TeleportStation(mockedOwner.Object, mockedGalacticMap.Object, mockedLocation.Object);
//
//            Assert.That(() => mockedTeleportStation.TeleportUnit(mockedUnit.Object, null), Throws.ArgumentNullException.With.Message.Contains("destination"));
//        }

    }
}
