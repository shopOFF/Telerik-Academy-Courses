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
    public class BusinessOwnerTests
    {
        [Test]
        public void CollectProfits_ShouldIncreaseOwnerResourcesByTheTotalAmountOfResourcesGeneratedFromTeleportStationsInHisPossession()
        {
            // Arrange
            var mockedBusinessOwner = new Mock<IBusinessOwner>();
            mockedBusinessOwner.Setup(x => x.IdentificationNumber).Returns(1);
            var mockedGalacticMap = new Mock<IPath>();
            mockedGalacticMap.Setup(x => x.Cost).Returns(It.IsAny<IResources>);
            var mockedLocation = new Mock<ILocation>();
            var pathList = new List<IPath>();
            pathList.Add(mockedGalacticMap.Object);
            var resourcesForTeleportStation = new Resources()
            {
                BronzeCoins = 130,
                SilverCoins = 120,
                GoldCoins = 110
            };

            var teleportStationsList = new List<ITeleportStation>()
            {
                new MockedTeleportStation(mockedBusinessOwner.Object, pathList, mockedLocation.Object, resourcesForTeleportStation)
            };
            var businessOwner = new BusinessOwner(1, "Gosho", teleportStationsList);
            var expectedOwnerResources = "Bronz=130, Silver=120, Gold=110";

            // Act
            businessOwner.CollectProfits();

            // Assert
            var actualOwnerResources = $"Bronz={businessOwner.Resources.BronzeCoins}, Silver={businessOwner.Resources.SilverCoins}, Gold={businessOwner.Resources.GoldCoins}";
            Assert.AreEqual(expectedOwnerResources, actualOwnerResources);
        }
    }
}
