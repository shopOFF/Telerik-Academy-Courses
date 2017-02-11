using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Moq;
using IntergalacticTravel.Contracts;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using IntergalacticTravel.Extensions;
using IntergalacticTravel.Exceptions;

namespace IntergalacticTravel.Tests
{
    [TestFixture]
    public class TeleportStationTests
    {
        [Test]
        public void TeleportStation_ShouldSetUpProvidedFields_WhenTeleportStationIsCreated()
        {
            var mockedOwner = new Mock<IBusinessOwner>();
            //no idea if this is the right way to get an IEnumerable of a mocked object
            var mockFirstPoint = new Mock<IPath>();
            var mockSecondPoint = new Mock<IPath>();
            var mockedMap = new[] { mockFirstPoint.Object, mockSecondPoint.Object }; 
            var mockedLocation = new Mock<ILocation>();

            var teleportStation = new TeleportStation(mockedOwner.Object,
                mockedMap,
                mockedLocation.Object);

            var wrappedStation = new PrivateObject(teleportStation);

            NUnit.Framework
                .Assert.AreSame(mockedLocation.Object, wrappedStation.GetField("location"));

            NUnit.Framework
                .Assert.AreSame(mockedOwner.Object, wrappedStation.GetField("owner"));

            NUnit.Framework
                .Assert.AreSame(mockedMap, wrappedStation.GetField("galacticMap"));
        }

        [Test]
        public void TeleportUnit_ShouldThrowArgumentNullException_WhenUnitToTeleportIsNull()
        {
            var mockedOwner = new Mock<IBusinessOwner>();
            var mockFirstPoint = new Mock<IPath>();
            var mockSecondPoint = new Mock<IPath>();
            var mockedMap = new[] { mockFirstPoint.Object, mockSecondPoint.Object };
            var mockedLocation = new Mock<ILocation>();

            var teleportStation = new TeleportStation(mockedOwner.Object,
                mockedMap,
                mockedLocation.Object);

            NUnit.Framework.Assert.Throws(Is.TypeOf<ArgumentNullException>()
                 .And.Message.Contains("unitToTeleport"),
                 () => teleportStation.TeleportUnit(null, mockedLocation.Object));
        }

        [Test]
        public void TeleportUnit_ShouldThrowArgumentNullException_WhenLocationIsNull()
        {
            var mockedOwner = new Mock<IBusinessOwner>();
            var mockFirstPoint = new Mock<IPath>();
            var mockSecondPoint = new Mock<IPath>();
            var mockedMap = new[] { mockFirstPoint.Object, mockSecondPoint.Object };
            var mockedLocation = new Mock<ILocation>();

            var teleportStation = new TeleportStation(mockedOwner.Object,
                mockedMap,
                mockedLocation.Object);

            NUnit.Framework.Assert.Throws(Is.TypeOf<ArgumentNullException>()
                 .And.Message.Contains("destination"),
                 () => teleportStation.TeleportUnit(new Mock<IUnit>().Object, null));
        }
    }
}
