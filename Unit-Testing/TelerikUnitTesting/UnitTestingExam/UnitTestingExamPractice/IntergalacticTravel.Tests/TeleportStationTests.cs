using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using IntergalacticTravel.Exceptions;
using IntergalacticTravel.Contracts;
using Moq;
using IntergalacticTravel.Tests.Mocks;

namespace IntergalacticTravel.Tests
{
    [TestFixture]
    public class TeleportStationTests
    {
        [Test]
        public void Constructor_WhenTelerportStationIsCreatedWithValidParameters_ShouldSetUpCorrectlyAllTheProvidedFields()
        {
            // Arrange
            var mockedBusinessOwner = new Mock<IBusinessOwner>();
            mockedBusinessOwner.Setup(x => x.IdentificationNumber).Returns(1);
            mockedBusinessOwner.Setup(x => x.NickName).Returns("Pesho");

            var mockedGalacticMap = new Mock<IPath>();
            mockedGalacticMap.Setup(x => x.TargetLocation).Returns(It.IsAny<ILocation>);

            var mockedSecondGalacticMap = new Mock<IPath>();
            mockedSecondGalacticMap.Setup(x => x.TargetLocation).Returns(It.IsAny<ILocation>);

            var mockedLocation = new Mock<ILocation>();
            mockedLocation.Setup(x => x.Planet.Name).Returns("Mars");

            var pathList = new List<IPath>();
            pathList.Add(mockedGalacticMap.Object);
            pathList.Add(mockedSecondGalacticMap.Object);

            var resources = new Resources() { BronzeCoins = 130, SilverCoins = 120, GoldCoins = 110 };

            // Act
            var mockedTeleportStation = new MockedTeleportStation(mockedBusinessOwner.Object, pathList, mockedLocation.Object, resources);

            // Assert
            // или пак и 3 те наведнъж да асъртнем със стринг
            Assert.AreEqual("Pesho", mockedTeleportStation.Owner.NickName);
            Assert.AreEqual(2, mockedTeleportStation.GalacticMap.Count());
            Assert.AreEqual("Mars", mockedTeleportStation.Location.Planet.Name);
        }

        [Test]
        public void TeleportUnit_WhenIUnitUnitToTeleportIsNull_ShouldThrowArgumentNullExceptionWithMessage()
        {
            // Arrange
            var mockedBusinessOwner = new Mock<IBusinessOwner>();
            var mockedGalacticMap = new Mock<IPath>();
            var mockedLocation = new Mock<ILocation>();
            var pathList = new List<IPath>();
            pathList.Add(mockedGalacticMap.Object);
            var teleportStation = new TeleportStation(mockedBusinessOwner.Object, pathList, mockedLocation.Object);

            // Act & Assert
            Assert.That(() => teleportStation.TeleportUnit(null, mockedLocation.Object), Throws.TypeOf<ArgumentNullException>().With.Message.Contains("unitToTeleport"));
        }

        [Test]
        public void TeleportUnit_WhenILocationDestinationIsNull_ShouldThrowArgumentNullExceptionWithMessage()
        {
            // Arrange
            var mockedBusinessOwner = new Mock<IBusinessOwner>();
            var mockedGalacticMap = new Mock<IPath>();
            var mockedLocation = new Mock<ILocation>();
            var pathList = new List<IPath>();
            pathList.Add(mockedGalacticMap.Object);
            var unit = new Unit(1, "GEsho");
            var teleportStation = new TeleportStation(mockedBusinessOwner.Object, pathList, mockedLocation.Object);

            // Act & Assert
            Assert.That(() => teleportStation.TeleportUnit(unit, null), Throws.TypeOf<ArgumentNullException>().With.Message.Contains("destination"));
        }

        [Test]
        public void TeleportUnit_WhenAUnitIsUsingTheTeleportStationFromAnotherPlanet_ShouldThrowTeleportOutOfRangeExceptionWithMessage()
        {
            // Arrange
            var mockedBusinessOwner = new Mock<IBusinessOwner>();
            var mockedGalacticMap = new Mock<IPath>();
            var mockedTargetLocation = new Mock<ILocation>();
            mockedTargetLocation.Setup(x => x.Coordinates.Latitude).Returns(5.1);
            mockedTargetLocation.Setup(x => x.Planet.Name).Returns("Mars");
            mockedTargetLocation.Setup(x => x.Planet.Galaxy.Name).Returns("MArsss");

            var pathList = new List<IPath>();
            pathList.Add(mockedGalacticMap.Object);

            var mockedUnit = new Mock<IUnit>();
            mockedUnit.Setup(x => x.CurrentLocation.Planet.Name).Returns("Fake Planet");
            mockedUnit.Setup(x => x.CurrentLocation.Planet.Galaxy.Name).Returns("FaKe Galaxy");
            mockedUnit.Setup(x => x.CurrentLocation.Coordinates.Latitude).Returns(2.2);


            var teleportStation = new TeleportStation(mockedBusinessOwner.Object, pathList, mockedTargetLocation.Object);

            // Act & Assert
            Assert.That(() => teleportStation.TeleportUnit(mockedUnit.Object, mockedTargetLocation.Object), Throws.TypeOf<TeleportOutOfRangeException>().With.Message.Contains("unitToTeleport.CurrentLocation"));
        }

        [Test]
        public void TeleportUnit_WhenTryingToTeleportUnitToALocationWichIsAlreadyTakenByAnotherUnit_ShouldThrowInvalidTeleportationLocationExceptionWithMessage()
        {
            // Arrange
            var unit = new Mock<IUnit>();
            unit.Setup(x => x.NickName).Returns("Gesho");
            unit.Setup(x => x.CurrentLocation.Coordinates.Latitude).Returns(5.1);
            unit.Setup(x => x.CurrentLocation.Planet.Name).Returns("Mars");
            unit.Setup(x => x.CurrentLocation.Planet.Galaxy.Name).Returns("Marsss");

            var arr = new List<IUnit>() { unit.Object };

            var mockedBusinessOwner = new Mock<IBusinessOwner>();
            var mockedGalacticMap = new Mock<IPath>();
            mockedGalacticMap.Setup(x => x.TargetLocation.Planet.Name).Returns("Mars");
            mockedGalacticMap.Setup(x => x.TargetLocation.Planet.Units).Returns(arr);
            mockedGalacticMap.Setup(x => x.TargetLocation.Planet.Galaxy.Name).Returns("Marsss");
            mockedGalacticMap.Setup(x => x.TargetLocation.Coordinates.Latitude).Returns(5.1);

            var mockedTargetLocation = new Mock<ILocation>();
            mockedTargetLocation.Setup(x => x.Coordinates.Latitude).Returns(5.1);
            mockedTargetLocation.Setup(x => x.Planet.Name).Returns("Mars");
            mockedTargetLocation.Setup(x => x.Planet.Units).Returns(arr);
            mockedTargetLocation.Setup(x => x.Planet.Galaxy.Name).Returns("Marsss");

            var pathList = new List<IPath>();
            pathList.Add(mockedGalacticMap.Object);

            var mockedUnit = new Mock<IUnit>();
            mockedUnit.Setup(x => x.CurrentLocation.Planet.Name).Returns("Mars");
            mockedUnit.Setup(x => x.CurrentLocation.Planet.Galaxy.Name).Returns("Marsss");
            mockedUnit.Setup(x => x.CurrentLocation.Coordinates.Latitude).Returns(5.1);


            var teleportStation = new TeleportStation(mockedBusinessOwner.Object, pathList, mockedTargetLocation.Object);

            // Act & Assert
            Assert.That(() => teleportStation.TeleportUnit(mockedUnit.Object, mockedTargetLocation.Object), Throws.TypeOf<InvalidTeleportationLocationException>().With.Message.Contains("units will overlap"));
        }

        [Test]
        public void TeleportUnit_WhenTryingToTeleportUnitToAGalaxyWhichIsNotFoundInTheLocationsListOfTheTeleportStation_ShouldThrowLocationNotFoundExceptionWithMessage()
        {
            // Arrange
            var unit = new Mock<IUnit>();
            unit.Setup(x => x.NickName).Returns("Gesho");

            var arr = new List<IUnit>() { unit.Object };

            var mockedBusinessOwner = new Mock<IBusinessOwner>();
            var mockedGalacticMap = new Mock<IPath>();
            mockedGalacticMap.Setup(x => x.TargetLocation.Planet.Name).Returns("Mars");
            mockedGalacticMap.Setup(x => x.TargetLocation.Planet.Units).Returns(arr);
            mockedGalacticMap.Setup(x => x.TargetLocation.Planet.Galaxy.Name).Returns("GAlax");
            mockedGalacticMap.Setup(x => x.TargetLocation.Coordinates.Latitude).Returns(5.1);

            var mockedTargetLocation = new Mock<ILocation>();
            mockedTargetLocation.Setup(x => x.Coordinates.Latitude).Returns(5.1);
            mockedTargetLocation.Setup(x => x.Planet.Name).Returns("Mars");
            mockedTargetLocation.Setup(x => x.Planet.Units).Returns(arr);
            mockedTargetLocation.Setup(x => x.Planet.Galaxy.Name).Returns("Marsss");

            var pathList = new List<IPath>();
            pathList.Add(mockedGalacticMap.Object);

            var mockedUnit = new Mock<IUnit>();
            mockedUnit.Setup(x => x.CurrentLocation.Planet.Name).Returns("Mars");
            mockedUnit.Setup(x => x.CurrentLocation.Planet.Galaxy.Name).Returns("Marsss");
            mockedUnit.Setup(x => x.CurrentLocation.Coordinates.Latitude).Returns(5.1);


            var teleportStation = new TeleportStation(mockedBusinessOwner.Object, pathList, mockedTargetLocation.Object);

            // Act & Assert
            Assert.That(() => teleportStation.TeleportUnit(mockedUnit.Object, mockedTargetLocation.Object), Throws.TypeOf<LocationNotFoundException>().With.Message.Contains("Galaxy"));
        }

        [Test]
        public void TeleportUnit_WhenTryingToTeleportUnitToAPlanetWhichIsNotFoundInTheLocationsListOfTheTeleportStation_ShouldThrowLocationNotFoundExceptionWithMessage()
        {
            // Arrange
            var unit = new Mock<IUnit>();
            unit.Setup(x => x.NickName).Returns("Gesho");

            var arr = new List<IUnit>() { unit.Object };

            var mockedBusinessOwner = new Mock<IBusinessOwner>();
            var mockedGalacticMap = new Mock<IPath>();
            mockedGalacticMap.Setup(x => x.TargetLocation.Planet.Name).Returns("Planet");
            mockedGalacticMap.Setup(x => x.TargetLocation.Planet.Units).Returns(arr);
            mockedGalacticMap.Setup(x => x.TargetLocation.Planet.Galaxy.Name).Returns("Marsss");
            mockedGalacticMap.Setup(x => x.TargetLocation.Coordinates.Latitude).Returns(5.1);

            var mockedTargetLocation = new Mock<ILocation>();
            mockedTargetLocation.Setup(x => x.Coordinates.Latitude).Returns(5.1);
            mockedTargetLocation.Setup(x => x.Planet.Name).Returns("Mars");
            mockedTargetLocation.Setup(x => x.Planet.Units).Returns(arr);
            mockedTargetLocation.Setup(x => x.Planet.Galaxy.Name).Returns("Marsss");

            var pathList = new List<IPath>();
            pathList.Add(mockedGalacticMap.Object);

            var mockedUnit = new Mock<IUnit>();
            mockedUnit.Setup(x => x.CurrentLocation.Planet.Name).Returns("Mars");
            mockedUnit.Setup(x => x.CurrentLocation.Planet.Galaxy.Name).Returns("Marsss");
            mockedUnit.Setup(x => x.CurrentLocation.Coordinates.Latitude).Returns(5.1);


            var teleportStation = new TeleportStation(mockedBusinessOwner.Object, pathList, mockedTargetLocation.Object);

            // Act & Assert
            Assert.That(() => teleportStation.TeleportUnit(mockedUnit.Object, mockedTargetLocation.Object), Throws.TypeOf<LocationNotFoundException>().With.Message.Contains("Planet"));
        }

        [Test]
        public void TeleportUnit_WhenTryingToTeleportUnitToALocationButServiceCostsAreMoreThanTheUnitsCurrentAvailableResorces_ShouldThrowInsufficientResourcesExceptionWithMessage()
        {
            // Arrange
            var unit = new Mock<IUnit>();
            unit.Setup(x => x.NickName).Returns("Gesho");
            unit.Setup(x => x.CurrentLocation.Coordinates.Latitude).Returns(15.1);
            unit.Setup(x => x.CurrentLocation.Planet.Name).Returns("Mars");
            unit.Setup(x => x.CurrentLocation.Planet.Galaxy.Name).Returns("Marsss");

            var arr = new List<IUnit>() { unit.Object };

            var mockedBusinessOwner = new Mock<IBusinessOwner>();
            var mockedGalacticMap = new Mock<IPath>();
            mockedGalacticMap.Setup(x => x.TargetLocation.Planet.Name).Returns("Mars");
            mockedGalacticMap.Setup(x => x.TargetLocation.Planet.Units).Returns(arr);
            mockedGalacticMap.Setup(x => x.TargetLocation.Planet.Galaxy.Name).Returns("Marsss");
            mockedGalacticMap.Setup(x => x.TargetLocation.Coordinates.Latitude).Returns(5.1);

            var mockedTargetLocation = new Mock<ILocation>();
            mockedTargetLocation.Setup(x => x.Coordinates.Latitude).Returns(5.1);
            mockedTargetLocation.Setup(x => x.Planet.Name).Returns("Mars");
            mockedTargetLocation.Setup(x => x.Planet.Units).Returns(arr);
            mockedTargetLocation.Setup(x => x.Planet.Galaxy.Name).Returns("Marsss");

            var pathList = new List<IPath>();
            pathList.Add(mockedGalacticMap.Object);

            var mockedUnit = new Mock<IUnit>();
            mockedUnit.Setup(x => x.CurrentLocation.Planet.Name).Returns("Mars");
            mockedUnit.Setup(x => x.CurrentLocation.Planet.Galaxy.Name).Returns("Marsss");
            mockedUnit.Setup(x => x.CurrentLocation.Coordinates.Latitude).Returns(5.1);


            var teleportStation = new TeleportStation(mockedBusinessOwner.Object, pathList, mockedTargetLocation.Object);

            // Act & Assert
            Assert.That(() => teleportStation.TeleportUnit(mockedUnit.Object, mockedTargetLocation.Object), Throws.TypeOf<InsufficientResourcesException>().With.Message.Contains("FREE LUNCH"));
        }

        [Test]
        public void TeleportUnit_WhenAllTheValidationsPassSuccessfully_ShouldRequirePpaymentFromTheUnitToTeleport()
        {
            // Arrange
            var resources = new Resources() { BronzeCoins = 50, SilverCoins = 30, GoldCoins = 20 };
            IPath pathToTheTargetPlanet;

            var unit = new Mock<IUnit>();
            unit.Setup(x => x.NickName).Returns("Gesho");
            unit.Setup(x => x.CurrentLocation.Coordinates.Latitude).Returns(15.1);
            unit.Setup(x => x.CurrentLocation.Planet.Name).Returns("Mars");
            unit.Setup(x => x.CurrentLocation.Planet.Galaxy.Name).Returns("Marsss");
            unit.Setup(x => x.Resources.BronzeCoins).Returns(1300);
            unit.Setup(x => x.Resources.SilverCoins).Returns(1200);
            unit.Setup(x => x.Resources.GoldCoins).Returns(1100);
            unit.Setup(x => x.CanPay(It.IsAny<IResources>()));
            var arrOfUnits = new List<IUnit>() { unit.Object };

            var mockedCurrentLocation = new Mock<ILocation>();
            mockedCurrentLocation.Setup(x => x.Coordinates.Latitude).Returns(15.1);
            mockedCurrentLocation.Setup(x => x.Planet.Name).Returns("Mars");
            mockedCurrentLocation.Setup(x => x.Planet.Galaxy.Name).Returns("Marsss");
            var unitPesho = new Unit(1, "PEsho");
            unitPesho.CurrentLocation = mockedCurrentLocation.Object;
            unitPesho.Resources.BronzeCoins = 1300;
            unitPesho.Resources.SilverCoins = 1200;
            unitPesho.Resources.GoldCoins = 1100;

            var mockedBusinessOwner = new Mock<IBusinessOwner>();
            var mockedGalacticMap = new Mock<IPath>();
            mockedGalacticMap.Setup(x => x.TargetLocation.Planet.Name).Returns("Mars");
            mockedGalacticMap.Setup(x => x.TargetLocation.Planet.Units).Returns(arrOfUnits);
            mockedGalacticMap.Setup(x => x.TargetLocation.Planet.Galaxy.Name).Returns("Marsss");
            mockedGalacticMap.Setup(x => x.TargetLocation.Coordinates.Latitude).Returns(5.1);

            var mockedTargetLocation = new Mock<ILocation>();
            mockedTargetLocation.Setup(x => x.Coordinates.Latitude).Returns(5.1);
            mockedTargetLocation.Setup(x => x.Planet.Name).Returns("Mars");
            mockedTargetLocation.Setup(x => x.Planet.Units).Returns(arrOfUnits);
            mockedTargetLocation.Setup(x => x.Planet.Galaxy.Name).Returns("Marsss");
            mockedGalacticMap.Setup(x => x.Cost.BronzeCoins).Returns(50);
            mockedGalacticMap.Setup(x => x.Cost.SilverCoins).Returns(30);
            mockedGalacticMap.Setup(x => x.Cost.GoldCoins).Returns(20);


            var pathList = new List<IPath>();
            pathList.Add(mockedGalacticMap.Object);

            var mockedUnit = new Mock<IUnit>();
            mockedUnit.Setup(x => x.CurrentLocation.Planet.Name).Returns("Mars");
            mockedUnit.Setup(x => x.CurrentLocation.Planet.Galaxy.Name).Returns("Marsss");
            mockedUnit.Setup(x => x.CurrentLocation.Coordinates.Latitude).Returns(5.1);

            var teleportStation = new MockedTeleportStation(mockedBusinessOwner.Object, pathList, mockedTargetLocation.Object, resources);
           
            // Act & Assert
            Assert.DoesNotThrow(() => teleportStation.ValidateThatTeleportationServiceIsApplicable(unitPesho, mockedTargetLocation.Object, out pathToTheTargetPlanet));
        }

        [Test]
        public void TeleportUnit_WhenAllTheValidationsPassSuccessfully_ShouldObtainPaymentFromUnitToTeleportForTheServiceAndTeleportStationResourcesMustIncreaseByTheAmountOfThePayment()
        {
            // Arrange
            var initialTeleportResources = new Resources() { BronzeCoins = 0, SilverCoins = 0, GoldCoins = 0 };

            var unit = new Mock<IUnit>();
            unit.Setup(x => x.NickName).Returns("Gesho");
            unit.Setup(x => x.CurrentLocation.Coordinates.Latitude).Returns(15.1);
            unit.Setup(x => x.CurrentLocation.Planet.Name).Returns("Mars");
            unit.Setup(x => x.CurrentLocation.Planet.Galaxy.Name).Returns("Marsss");
            unit.Setup(x => x.Resources.BronzeCoins).Returns(1300);
            unit.Setup(x => x.Resources.SilverCoins).Returns(1200);
            unit.Setup(x => x.Resources.GoldCoins).Returns(1100);
            unit.Setup(x => x.CanPay(It.IsAny<IResources>()));
            var arrOfUnits = new List<IUnit>() { unit.Object };

            var mockedCurrentLocation = new Mock<ILocation>();
            mockedCurrentLocation.Setup(x => x.Coordinates.Latitude).Returns(15.1);
            mockedCurrentLocation.Setup(x => x.Planet.Name).Returns("Mars");
            mockedCurrentLocation.Setup(x => x.Planet.Units).Returns(arrOfUnits);
            mockedCurrentLocation.Setup(x => x.Planet.Galaxy.Name).Returns("Marsss");
            var unitPesho = new Unit(1, "PEsho");
            unitPesho.CurrentLocation = mockedCurrentLocation.Object;
            unitPesho.Resources.BronzeCoins = 1300;
            unitPesho.Resources.SilverCoins = 1200;
            unitPesho.Resources.GoldCoins = 1100;

            var mockedBusinessOwner = new Mock<IBusinessOwner>();
            var mockedGalacticMap = new Mock<IPath>();
            mockedGalacticMap.Setup(x => x.TargetLocation.Planet.Name).Returns("Mars");
            mockedGalacticMap.Setup(x => x.TargetLocation.Planet.Units).Returns(arrOfUnits);
            mockedGalacticMap.Setup(x => x.TargetLocation.Planet.Galaxy.Name).Returns("Marsss");
            mockedGalacticMap.Setup(x => x.TargetLocation.Coordinates.Latitude).Returns(5.1);

            var mockedTargetLocation = new Mock<ILocation>();
            mockedTargetLocation.Setup(x => x.Coordinates.Latitude).Returns(5.1);
            mockedTargetLocation.Setup(x => x.Planet.Name).Returns("Mars");
            mockedTargetLocation.Setup(x => x.Planet.Units).Returns(arrOfUnits);
            mockedTargetLocation.Setup(x => x.Planet.Galaxy.Name).Returns("Marsss");
            mockedGalacticMap.Setup(x => x.Cost.BronzeCoins).Returns(50);
            mockedGalacticMap.Setup(x => x.Cost.SilverCoins).Returns(30);
            mockedGalacticMap.Setup(x => x.Cost.GoldCoins).Returns(20);

            var pathList = new List<IPath>();
            pathList.Add(mockedGalacticMap.Object);

            var mockedUnit = new Mock<IUnit>();
            mockedUnit.Setup(x => x.CurrentLocation.Planet.Name).Returns("Mars");
            mockedUnit.Setup(x => x.CurrentLocation.Planet.Galaxy.Name).Returns("Marsss");
            mockedUnit.Setup(x => x.CurrentLocation.Coordinates.Latitude).Returns(5.1);

            var teleportStation = new MockedTeleportStation(mockedBusinessOwner.Object, pathList, mockedTargetLocation.Object, initialTeleportResources);
            var expectedTeleportResources = "Bronze=50, Silver=30, Gold=20";

            // Act
            teleportStation.TeleportUnit(unitPesho, mockedTargetLocation.Object);

            // Assert
            var actualTeleportResources = $"Bronze={teleportStation.Resources.BronzeCoins}, Silver={teleportStation.Resources.SilverCoins}, Gold={teleportStation.Resources.GoldCoins}";
            Assert.AreEqual(expectedTeleportResources, actualTeleportResources);
        }

        [Test]
        public void TeleportUnit_WhenAllTheValidationsPassSuccessfullyAndTheUnitIsTeleported_ShouldSetTheUnitToTeleportPreviousLocationToUnitToTeleportCurrentLocation()
        {
            // Arrange
            var initialTeleportResources = new Resources() { BronzeCoins = 0, SilverCoins = 0, GoldCoins = 0 };

            var unit = new Mock<IUnit>();
            unit.Setup(x => x.NickName).Returns("Gesho");
            unit.Setup(x => x.CurrentLocation.Coordinates.Latitude).Returns(15.1);
            unit.Setup(x => x.CurrentLocation.Planet.Name).Returns("Mars");
            unit.Setup(x => x.CurrentLocation.Planet.Galaxy.Name).Returns("Marsss");
            unit.Setup(x => x.Resources.BronzeCoins).Returns(1300);
            unit.Setup(x => x.Resources.SilverCoins).Returns(1200);
            unit.Setup(x => x.Resources.GoldCoins).Returns(1100);
            unit.Setup(x => x.CanPay(It.IsAny<IResources>()));
            var arrOfUnits = new List<IUnit>() { unit.Object };

            var mockedCurrentLocation = new Mock<ILocation>();
            mockedCurrentLocation.Setup(x => x.Coordinates.Latitude).Returns(26.6);
            mockedCurrentLocation.Setup(x => x.Planet.Name).Returns("Fars");
            mockedCurrentLocation.Setup(x => x.Planet.Units).Returns(arrOfUnits);
            mockedCurrentLocation.Setup(x => x.Planet.Galaxy.Name).Returns("Marsss");
            var unitPesho = new Unit(1, "PEsho");
            unitPesho.CurrentLocation = mockedCurrentLocation.Object;
            unitPesho.Resources.BronzeCoins = 1300;
            unitPesho.Resources.SilverCoins = 1200;
            unitPesho.Resources.GoldCoins = 1100;

            var mockedBusinessOwner = new Mock<IBusinessOwner>();
            var mockedGalacticMap = new Mock<IPath>();
            mockedGalacticMap.Setup(x => x.TargetLocation.Planet.Name).Returns("Fars");
            mockedGalacticMap.Setup(x => x.TargetLocation.Planet.Units).Returns(arrOfUnits);
            mockedGalacticMap.Setup(x => x.TargetLocation.Planet.Galaxy.Name).Returns("Marsss");
            mockedGalacticMap.Setup(x => x.TargetLocation.Coordinates.Latitude).Returns(5.1);

            var mockedTargetLocation = new Mock<ILocation>();
            mockedTargetLocation.Setup(x => x.Coordinates.Latitude).Returns(5.1);
            mockedTargetLocation.Setup(x => x.Planet.Name).Returns("Fars");
            mockedTargetLocation.Setup(x => x.Planet.Units).Returns(arrOfUnits);
            mockedTargetLocation.Setup(x => x.Planet.Galaxy.Name).Returns("Marsss");
            mockedGalacticMap.Setup(x => x.Cost.BronzeCoins).Returns(50);
            mockedGalacticMap.Setup(x => x.Cost.SilverCoins).Returns(30);
            mockedGalacticMap.Setup(x => x.Cost.GoldCoins).Returns(20);

            var pathList = new List<IPath>();
            pathList.Add(mockedGalacticMap.Object);

            var mockedUnit = new Mock<IUnit>();
            mockedUnit.Setup(x => x.CurrentLocation.Planet.Name).Returns("Mars");
            mockedUnit.Setup(x => x.CurrentLocation.Planet.Galaxy.Name).Returns("Marsss");
            mockedUnit.Setup(x => x.CurrentLocation.Coordinates.Latitude).Returns(5.1);

            var teleportStation = new MockedTeleportStation(mockedBusinessOwner.Object, pathList, mockedTargetLocation.Object, initialTeleportResources);
            

            // Act
            teleportStation.TeleportUnit(unitPesho, mockedTargetLocation.Object);

            // Assert
            var expectedTeleportedUnitCurrentCordinates = "Cordinates: Current Latitude=5.1, Previous Latitude=26.6";
            var actualTeleportedUnitCurrentCordinates = $"Cordinates: Current Latitude={unitPesho.CurrentLocation.Coordinates.Latitude}, Previous Latitude={unitPesho.PreviousLocation.Coordinates.Latitude}";
            Assert.AreEqual(expectedTeleportedUnitCurrentCordinates,actualTeleportedUnitCurrentCordinates);
        }



        [Test]
        public void PayProfits_WheneArgumentPassedRepresentsTheActualOwnerOfTheTeleportStation_ShouldReturnTheTotalAmountOfResourcesGeneratedUsingTheTeleleportStation()
        {
            // Arrange
            var mockedBusinessOwner = new Mock<IBusinessOwner>();
            mockedBusinessOwner.Setup(x => x.IdentificationNumber).Returns(1);
            mockedBusinessOwner.Setup(x => x.NickName).Returns("Peshev");

            var mockedGalacticMap = new Mock<IPath>();

            var mockedLocation = new Mock<ILocation>();

            var pathList = new List<IPath>();
            pathList.Add(mockedGalacticMap.Object);

            var resources = new Resources() { BronzeCoins = 50, SilverCoins = 40, GoldCoins = 30 };

            var mockedTeleportStation = new MockedTeleportStation(mockedBusinessOwner.Object, pathList, mockedLocation.Object, resources);

            // Act
            var actualTeleportGeneratedResources = mockedTeleportStation.PayProfits(mockedBusinessOwner.Object);

            // Assert
            Assert.AreEqual(50, actualTeleportGeneratedResources.BronzeCoins);
            Assert.AreEqual(40, actualTeleportGeneratedResources.SilverCoins);
            Assert.AreEqual(30, actualTeleportGeneratedResources.GoldCoins);
        }
    }
}
