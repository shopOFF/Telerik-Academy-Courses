using System;
using NUnit.Framework;

using Moq;
using IntergalacticTravel.Constants;
using IntergalacticTravel.Contracts;
using IntergalacticTravel.Exceptions;
using IntergalacticTravel.Extensions;
using System.Collections.Generic;

namespace IntergalacticTravel.Tests
{
    [TestFixture]
    public class TeleportStationTests
    {
        [Test]
        public void Constructor_WhenTeleportStationWithPassedValidParamsToTheConstructor_ShouldSetAllFieldsCorrectly()
        {
            var mockedOwner = new Mock<IBusinessOwner>();
            var mockedGalacticMap = new Mock<IPath>();
            var mockedLocation = new Mock<ILocation>();

            var mockedCordinates = new Mock<IGPSCoordinates>();
            mockedCordinates.Setup(c => c.Latitude).Returns(13.13);
            mockedCordinates.Setup(c => c.Longtitude).Returns(10.10);

            mockedOwner.Setup(o => o.NickName).Returns("SomeNickName");

            mockedLocation.Setup(l => l.Coordinates).Returns(mockedCordinates.Object);
            mockedGalacticMap.Setup(p => p.TargetLocation).Returns(mockedLocation.Object);

           // var teleportStationTest = new TeleportStation(mockedOwner.Object,new List<IPath>() { mockedGalacticMap } ,mockedLocation);

            // TODO: 
        }


    }
}
