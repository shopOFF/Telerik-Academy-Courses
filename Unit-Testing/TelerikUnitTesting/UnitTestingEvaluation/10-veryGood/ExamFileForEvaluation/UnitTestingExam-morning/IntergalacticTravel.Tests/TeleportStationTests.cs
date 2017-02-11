using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Moq;
using NUnit.Framework;
using IntergalacticTravel.Contracts;
using IntergalacticTravel.Tests.Mocks;
using IntergalacticTravel.Exceptions;

namespace IntergalacticTravel.Tests
{   [TestFixture]
   public class TeleportStationTests
    {   [Test]
        public void Constructor_WhenNewTeleportStationIsCreatedWithValidPassedParameters_ShouldSetUpOwnerFieldCorrectly()
        {
            var McBusinessOwner = new Mock<IBusinessOwner>();
            var McPath = new Mock<IPath>();
            var GalaticMap = new List<IPath> { McPath.Object };
            var McLocation = new Mock<ILocation>();
            var TeleportStationtest = new MockedTeleportStation(McBusinessOwner.Object,GalaticMap,McLocation.Object);

            Assert.AreEqual(McBusinessOwner.Object, TeleportStationtest.Owner);

        }
        [Test]
        public void Constructor_WhenNewTeleportStationIsCreatedWithValidPassedParameters_ShouldSetUpLocationFieldCorrectly()
        {
            var McBusinessOwner = new Mock<IBusinessOwner>();
            var McPath = new Mock<IPath>();
            var GalaticMap = new List<IPath> { McPath.Object };
            var McLocation = new Mock<ILocation>();
            var TeleportStationtest = new MockedTeleportStation(McBusinessOwner.Object, GalaticMap, McLocation.Object);

            Assert.AreEqual(McLocation.Object, TeleportStationtest.Location);

        }
        [Test]
        public void Constructor_WhenNewTeleportStationIsCreatedWithValidPassedParameters_ShouldSetUpGalaticMapFieldCorrectly()
        {
            var McBusinessOwner = new Mock<IBusinessOwner>();
            var McPath = new Mock<IPath>();
            var GalaticMap = new List<IPath> { McPath.Object };
            var McLocation = new Mock<ILocation>();
            var TeleportStationtest = new MockedTeleportStation(McBusinessOwner.Object, GalaticMap, McLocation.Object);

            CollectionAssert.AreEqual(GalaticMap, TeleportStationtest.GalacticMap);
            
        }
        [Test]
        public void TeleportUnit_WhenUniteToTeleportParameterIsNull_ShouldThrowArgumentNullExceptionWithMessageThatContainsunitToTeleport()
        {  //Arrange
            var DoesItContainRightMessage = false;
            var McBusinessOwner = new Mock<IBusinessOwner>();
            var McPath = new Mock<IPath>();
            var GalaticMap = new List<IPath> { McPath.Object };
            var McLocation = new Mock<ILocation>();
            var TeleportStationtest = new MockedTeleportStation(McBusinessOwner.Object, GalaticMap, McLocation.Object);
            //Act
            try
            {
                TeleportStationtest.TeleportUnit(null, McLocation.Object);
            }
            catch (ArgumentNullException ex)
            {

                DoesItContainRightMessage = ex.Message.Contains("unitToTeleport");
            }
            //Assert
            Assert.IsTrue(DoesItContainRightMessage);
           

        }
        [Test]
        public void TeleportUnit_WhenLocationParameterIsNull_ShouldThrowArgumentNullExceptionWithMessageThatContainsDestination()
        {  //Arrange
            var DoesItContainRightMessage = false;
            var McBusinessOwner = new Mock<IBusinessOwner>();
            var McPath = new Mock<IPath>();
            var GalaticMap = new List<IPath> { McPath.Object };
            var McLocation = new Mock<ILocation>();
            var TeleportStationtest = new MockedTeleportStation(McBusinessOwner.Object, GalaticMap, McLocation.Object);
            var McUnit = new Mock<IUnit>();
            //Act
            try
            {
                TeleportStationtest.TeleportUnit(McUnit.Object,null);
            }
            catch (ArgumentNullException ex)
            {

                DoesItContainRightMessage = ex.Message.Contains("destination");
            }
            //Assert
            Assert.IsTrue(DoesItContainRightMessage);


        }
        [Test]
        public void TeleportUnit_WhenUnitsLocationIsDifferentTahnTeleportStation_ShouldThrowTeleportOutOfRangeExceptionWithMessageThatContainsDestinationUnitLocation()
        {  //Arrange
            var DoesItContainRightMessage = false;
            var McBusinessOwner = new Mock<IBusinessOwner>();
            var McPath = new Mock<IPath>();
            var GalaticMap = new List<IPath> { McPath.Object };
            var McLocation = new Mock<ILocation>();
            var McUnitLocation = new Mock<ILocation>();
            McUnitLocation.SetupGet(x => x.Planet.Name).Returns("pesho");
            McLocation.SetupGet(x => x.Planet.Name).Returns("Gosho");
            McLocation.SetupGet(x => x.Planet.Galaxy.Name).Returns("Gosho");
            McUnitLocation.SetupGet(x => x.Planet.Galaxy.Name).Returns("Gosho2");
            var TeleportStationtest = new MockedTeleportStation(McBusinessOwner.Object, GalaticMap, McLocation.Object);
            var McUnit = new Mock<IUnit>();
            McUnit.SetupGet(x => x.CurrentLocation).Returns(McUnitLocation.Object);
            //Act
            try
            {
                TeleportStationtest.TeleportUnit(McUnit.Object,McLocation.Object);
            }
            catch (TeleportOutOfRangeException ex)
            {

                DoesItContainRightMessage = ex.Message.Contains("unitToTeleport.CurrentLocation");
            }
            //Assert
            Assert.IsTrue(DoesItContainRightMessage);


        }
        [Test]
        public void TeleportUnit_WhenOnTheWantedLocationThereIsAnotherUnit_ShouldThrowInvalidTeleportationLocationExceptionWithMessageThatContainsUnitsWillOverlap()
        {
            var DoesItContainRightMessage = false;
            var McBusinessOwner = new Mock<IBusinessOwner>();
            var McPath = new Mock<IPath>();
            var GalaticMap = new List<IPath> { McPath.Object };
            var McLocation = new Mock<ILocation>();
            McPath.SetupGet(p => p.TargetLocation.Planet.Galaxy.Name).Returns("Krio");
            McPath.SetupGet(p => p.TargetLocation.Planet.Name).Returns("Peter");
            var mcUninInCurentLocation = new Mock<Unit>();
            var McUnitinCurLocation = new Mock<ILocation>();
            McUnitinCurLocation.SetupGet(x => x.Coordinates.Longtitude).Returns(2.00);
            McUnitinCurLocation.SetupGet(x => x.Coordinates.Latitude).Returns(2.00);
            mcUninInCurentLocation.SetupGet(x => x.CurrentLocation).Returns(McUnitinCurLocation.Object);
            mcUninInCurentLocation.SetupGet(x => x.CurrentLocation.Coordinates.Latitude).Returns(2);
            mcUninInCurentLocation.SetupGet(x => x.CurrentLocation.Coordinates.Longtitude).Returns(2);
            McPath.SetupGet(p => p.TargetLocation.Planet.Units).Returns(new List<IUnit> { mcUninInCurentLocation.Object });
            var McUnitLocation = new Mock<ILocation>();
            var McUnit = new Mock<IUnit>();
            var McLocationToGo = new Mock<ILocation>();
            McUnitLocation.SetupGet(x => x.Planet.Name).Returns("Gosho");
            McLocation.SetupGet(x => x.Planet.Name).Returns("Gosho");
            McLocation.SetupGet(x => x.Planet.Galaxy.Name).Returns("Gosho");
            McUnitLocation.SetupGet(x => x.Planet.Galaxy.Name).Returns("Gosho");
            McLocationToGo.SetupGet(x => x.Planet.Galaxy.Name).Returns("Krio");
            McLocationToGo.SetupGet(x => x.Planet.Name).Returns("Peter");
            McLocationToGo.SetupGet(x => x.Coordinates.Latitude).Returns(2.00);
            McLocationToGo.SetupGet(x => x.Coordinates.Longtitude).Returns(2.00);

            var TPStation = new TeleportStation(McBusinessOwner.Object, GalaticMap, McLocation.Object);
           McUnit.SetupGet(x => x.CurrentLocation).Returns(McUnitLocation.Object);
            try
            {
                TPStation.TeleportUnit(McUnit.Object, McLocationToGo.Object);
            }
            catch (InvalidTeleportationLocationException ex)
            {

                DoesItContainRightMessage = ex.Message.Contains("units will overlap");
            }
            //Assert
            Assert.IsTrue(DoesItContainRightMessage);


        }
        [Test]
        public void TeleportUnit_WhenTryingToTeleportToAGalaxyThereIsNoWhereToBeFountInTheList_ShouldThrowLocationNotFoundExceptionWithMessageThatContainsGalaxy()
        {  //Arrange
            var DoesItContainRightMessage = false;
            var McBusinessOwner = new Mock<IBusinessOwner>();
            var McPath = new Mock<IPath>();
            var GalaticMap = new List<IPath> { McPath.Object };
            var McLocation = new Mock<ILocation>();
            McPath.SetupGet(p => p.TargetLocation.Planet.Galaxy.Name).Returns("Upiter");
            var McUnitLocation = new Mock<ILocation>();
            var McUnit = new Mock<IUnit>();
            var McLocationToGo = new Mock<ILocation>();
            McUnitLocation.SetupGet(x => x.Planet.Name).Returns("Gosho");
            McLocation.SetupGet(x => x.Planet.Name).Returns("Gosho");
            McLocation.SetupGet(x => x.Planet.Galaxy.Name).Returns("Gosho");
            McUnitLocation.SetupGet(x => x.Planet.Galaxy.Name).Returns("Gosho");
            McLocationToGo.SetupGet(x => x.Planet.Galaxy.Name).Returns("Krio");
            var TPStation = new TeleportStation(McBusinessOwner.Object, GalaticMap, McLocation.Object);
            McUnit.SetupGet(x => x.CurrentLocation).Returns(McUnitLocation.Object);
            try
            {
                TPStation.TeleportUnit(McUnit.Object, McLocationToGo.Object);
            }
            catch (LocationNotFoundException ex)
            {

                DoesItContainRightMessage = ex.Message.Contains("Galaxy");
            }
            //Assert
            Assert.IsTrue(DoesItContainRightMessage);

        }
        [Test]
        public void TeleportUnit_WhenTryingToTeleportToAPlanetThereIsNoWhereToBeFountInTheList_ShouldThrowLocationNotFoundExceptionWithMessageThatContainsPlanet()
        {  //Arrange
            var DoesItContainRightMessage = false;
            var McBusinessOwner = new Mock<IBusinessOwner>();
            var McPath = new Mock<IPath>();
            var GalaticMap = new List<IPath> { McPath.Object };
            var McLocation = new Mock<ILocation>();
            McPath.SetupGet(p => p.TargetLocation.Planet.Galaxy.Name).Returns("Krio");
            McPath.SetupGet(p => p.TargetLocation.Planet.Name).Returns("Peter");
            var McUnitLocation = new Mock<ILocation>();
            var McUnit = new Mock<IUnit>();
            var McLocationToGo = new Mock<ILocation>();
            McUnitLocation.SetupGet(x => x.Planet.Name).Returns("Gosho");
            McLocation.SetupGet(x => x.Planet.Name).Returns("Gosho");
            McLocation.SetupGet(x => x.Planet.Galaxy.Name).Returns("Gosho");
            McUnitLocation.SetupGet(x => x.Planet.Galaxy.Name).Returns("Gosho");
            McLocationToGo.SetupGet(x => x.Planet.Galaxy.Name).Returns("Krio");
            McLocationToGo.SetupGet(x => x.Planet.Name).Returns("Boje Kade sum");
            var TPStation = new TeleportStation(McBusinessOwner.Object, GalaticMap, McLocation.Object);
            McUnit.SetupGet(x => x.CurrentLocation).Returns(McUnitLocation.Object);
            try
            {
                TPStation.TeleportUnit(McUnit.Object, McLocationToGo.Object);
            }
            catch (LocationNotFoundException ex)
            {

                DoesItContainRightMessage = ex.Message.Contains("Planet");
            }
            //Assert
            Assert.IsTrue(DoesItContainRightMessage);

        }
    }
}
