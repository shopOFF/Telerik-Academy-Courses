using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using Moq;
using IntergalacticTravel.Contracts;


namespace IntergalacticTravel.Tests.TStation
{
    [TestClass]
    public class Constructors_Should
    {
        // 1. Constructor should set up all of the provided fields (owner, galacticMap & location), 
        // when a new TeleportStation is created with valid parameters passed to the constructor.  

        [TestMethod]
        public void CreateValidObjectOfTypeTeleportStation_WhenCreatedWithValidParameters()
        {
            // Arrange
            //var teleportStation = new Mock<ITeleportStation>();
            var mockedOwner = new Mock<IBusinessOwner>(); //IBusinessOwner owner;
            var mockedLocation = new Mock<ILocation>(); // location;
            var mockedGalacticMap = new Mock<IEnumerable<IPath>>(); //IEnumerable<IPath> galacticMap;

            var fakeTeleportStation = new FakeTeleportStation(mockedOwner.Object, mockedGalacticMap.Object, mockedLocation.Object);
            
            // Act and Assert
            Assert.IsInstanceOfType(fakeTeleportStation, typeof(TeleportStation));
        }

        // TODO
        [TestMethod]
        public void SetUpAllFieldsProperly_WhenCreatedWithValidParameters()
        {
            // Arrange
            var mockedOwner = new Mock<IBusinessOwner>(); //IBusinessOwner owner;
            var mockedLocation = new Mock<ILocation>(); // location;
            var mockedGalacticMap = new Mock<IEnumerable<IPath>>(); //IEnumerable<IPath> galacticMap;

            var mockedTeleportStation = new TeleportStation(mockedOwner.Object, mockedGalacticMap.Object, mockedLocation.Object);


            // Act and Assert
            // Assert.IsInstanceOfType(mockedTeleportStation, typeof(TeleportStation));
            Assert.IsTrue(false);
        }

    }
}
