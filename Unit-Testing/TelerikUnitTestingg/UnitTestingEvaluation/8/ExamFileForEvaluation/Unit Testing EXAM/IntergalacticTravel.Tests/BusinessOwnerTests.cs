namespace IntergalacticTravel.Tests
{
    using System.Collections.Generic;
    using Contracts;
    using Moq;
    using NUnit.Framework;

    [TestFixture]
    public class BusinessOwnerTests
    {
        [Test]
        public void CollectProfits_ShouldIncreaseResources_ByTotalAmount_OfGeneratedResources_InStations()
        {
            var stations = new List<ITeleportStation>()
            {
                this.GetFakeStation(),
                this.GetFakeStation(),
                this.GetFakeStation()
            };

            var onwer = new BusinessOwner(5, "Pesho", stations);

            // Owner starts with 0 and collects 3 station
            onwer.CollectProfits();

            Assert.AreEqual(30, onwer.Resources.BronzeCoins);
            Assert.AreEqual(30, onwer.Resources.SilverCoins);
            Assert.AreEqual(30, onwer.Resources.GoldCoins);
        }

        private ITeleportStation GetFakeStation()
        {
            var stationMock = new Mock<ITeleportStation>();
            var resourceMock = new Mock<IResources>();
            resourceMock.Setup(r => r.BronzeCoins).Returns(10);
            resourceMock.Setup(r => r.SilverCoins).Returns(10); resourceMock.Setup(r => r.GoldCoins).Returns(10);

            stationMock.Setup(s => s.PayProfits(It.IsAny<IBusinessOwner>()))
                .Returns(resourceMock.Object);

            return stationMock.Object;
        }
    }
}