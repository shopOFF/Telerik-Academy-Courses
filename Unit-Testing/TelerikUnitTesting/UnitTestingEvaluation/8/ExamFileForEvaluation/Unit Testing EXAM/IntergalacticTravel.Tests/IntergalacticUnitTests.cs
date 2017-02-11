namespace IntergalacticTravel.Tests
{
    using System;
    using Contracts;
    using Moq;
    using NUnit.Framework;

    [TestFixture]
    public class IntergalacticUnitTests
    {
        public IUnit Unit { get; set; }

        [SetUp]
        public void BeforeEach()
        {
            this.Unit = new Unit(5, "Pesho");
            var unitResourcesMock = new Mock<IResources>();

            this.Unit.Resources.BronzeCoins = 100;
            this.Unit.Resources.SilverCoins = 100;
            this.Unit.Resources.GoldCoins = 100;
        }

        [Test]
        public void Pay_ShouldThrow_IfPassed_Null()
        {
            Assert.Throws<NullReferenceException>(
                () => this.Unit.Pay(null));
        }

        [Test]
        public void Pay_ShouldDecreaseResources_ByTheCorrectAmount()
        {
            var resourceMock = new Mock<IResources>();
            resourceMock.Setup(r => r.BronzeCoins).Returns(10);
            resourceMock.Setup(r => r.SilverCoins).Returns(11); resourceMock.Setup(r => r.GoldCoins).Returns(12);

            this.Unit.Pay(resourceMock.Object);

            // Units starts with 100 of each
            Assert.AreEqual(100 - 10, this.Unit.Resources.BronzeCoins);
            Assert.AreEqual(100 - 11, this.Unit.Resources.SilverCoins);
            Assert.AreEqual(100 - 12, this.Unit.Resources.GoldCoins);
        }

        [Test]
        public void Pay_ShouldReturn_ResourceObjectEqualTo_TheCost()
        {
            var resourceMock = new Mock<IResources>();
            resourceMock.Setup(r => r.BronzeCoins).Returns(10);
            resourceMock.Setup(r => r.SilverCoins).Returns(11); resourceMock.Setup(r => r.GoldCoins).Returns(12);

            var result = this.Unit.Pay(resourceMock.Object);

            Assert.AreEqual(10, result.BronzeCoins);
            Assert.AreEqual(11, result.SilverCoins);
            Assert.AreEqual(12, result.GoldCoins);
        }
    }
}