using System;
using NUnit.Framework;
using System.Collections.Generic;
using IntergalacticTravel.Contracts;
using Moq;
using IntergalacticTravel.Tests.Mocks;

namespace IntergalacticTravel.Tests
{
    [TestFixture]
    public class BusinessOwnerTests
    {
        [Test]
        public void CollectProfits_ShouldIncreaseOwnerResourcesByTotalAmountGeneratedFromTeleportStationsInHisPossesion()
        {
            var mockedOwner = new Mock<IBusinessOwner>();
            var mockedPath = new Mock<IEnumerable<IPath>>();
            var mockedLocation = new Mock<ILocation>();

            var owner = new BusinessOwner(123, "testName", new List<ITeleportStation>());

            var mockedStation1 = new MockedTeleportStation(owner, mockedPath.Object, mockedLocation.Object);
            var mockedStation2 = new MockedTeleportStation(owner, mockedPath.Object, mockedLocation.Object);

            mockedStation1.Resources = new Resources(20, 20, 20);
            mockedStation2.Resources = new Resources(30, 30, 30);

            owner.TeleportStations.Add(mockedStation1);
            owner.TeleportStations.Add(mockedStation2);

            bool expectedResult = false;

            owner.CollectProfits();
            if (owner.Resources.BronzeCoins == (mockedStation1.Resources.BronzeCoins + mockedStation2.Resources.BronzeCoins) &&
                owner.Resources.SilverCoins == (mockedStation1.Resources.SilverCoins + mockedStation2.Resources.SilverCoins) &&
                owner.Resources.GoldCoins == (mockedStation1.Resources.GoldCoins + mockedStation2.Resources.GoldCoins))
            {
                expectedResult = true;
            }

            Assert.IsTrue(expectedResult);
        }
    }
}
