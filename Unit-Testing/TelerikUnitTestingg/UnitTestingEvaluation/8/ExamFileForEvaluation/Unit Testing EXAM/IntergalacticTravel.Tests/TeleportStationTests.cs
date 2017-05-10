namespace IntergalacticTravel.Tests
{
    using System;
    using System.Collections.Generic;
    using Contracts;
    using Exceptions;
    using Mocks;
    using Moq;
    using NUnit.Framework;
    using NUnit.Framework.Internal;

    [TestFixture]
    public class TeleportStationTests
    {
        public Mock<IBusinessOwner> OwnerMock { get; private set; }

        public Mock<IUnit> UnitMock { get; private set; }

        public Mock<ILocation> LocationMock { get; private set; }

        public IFakePathFactory PathFactory { get; private set; }

        public ITeleportStation TeleportStation { get; private set; }

        [SetUp]
        public void BeforeEach()
        {
            this.OwnerMock = new Mock<IBusinessOwner>();
            this.UnitMock = new Mock<IUnit>();
            this.LocationMock = new Mock<ILocation>();

            this.PathFactory = new FakePathFactory();

            // System under test
            this.TeleportStation = new TeleportStation(
                this.OwnerMock.Object, this.PathFactory.GetMap(), this.PathFactory.GetLocation());
        }

        // Using a fake implementation that inherits the TeleportStation
        // and only exposes the protected properties of interest
        [Test]
        public void Construction_ShouldSet_AllProvidedFields_WhenCalled_WithValidParameters()
        {
            IBusinessOwner owner = this.OwnerMock.Object;
            IEnumerable<IPath> map = this.PathFactory.GetMap();
            ILocation location = this.PathFactory.GetLocation();

            var teleport = new FakeStation(owner, map, location);

            Assert.AreSame(owner, teleport.Owner);
            Assert.AreSame(map, teleport.Map);
            Assert.AreSame(location, teleport.Location);
        }

        [Test]
        public void TeleportUnit_ShouldThrow_WithMessage_WhenUnit_IsNull()
        {
            IUnit unit = null;
            ILocation location = this.PathFactory.GetLocation();

            Assert.That(
                () => this.TeleportStation.TeleportUnit(unit, location), Throws.TypeOf<ArgumentNullException>()
                    .With.Message.Contain("unitToTeleport"));
        }

        [Test]
        public void TeleportUnit_ShouldThrow_WithMessage_WhenLocation_IsNull()
        {
            IUnit unit = this.UnitMock.Object;
            ILocation location = null;

            Assert.That(
                () => this.TeleportStation.TeleportUnit(unit, location), Throws.TypeOf<ArgumentNullException>()
                    .With.Message.Contain("destination"));
        }

        [Test]
        public void TeleportUnit_ShouldThrow_WithMessage_WhenLocation_IsDistantLocation()
        {
            this.UnitMock.Setup(unit => unit.CurrentLocation.Planet.Galaxy.Name).Returns("other galaxy");
            this.UnitMock.Setup(unit => unit.CurrentLocation.Planet.Name).Returns("Planet");

            this.LocationMock.Setup(location => location.Planet.Galaxy.Name).Returns("distant galaxy");

            this.LocationMock.Setup(location => location.Planet.Name).Returns("Planet2");

            var testUnit = this.UnitMock.Object;
            var testLocation = this.LocationMock.Object;

            Assert.That(
                () => this.TeleportStation.TeleportUnit(testUnit, testLocation), Throws.TypeOf<TeleportOutOfRangeException>()
                    .With.Message.Contain("unitToTeleport.CurrentLocation"));
        }

        [Test]
        public void TeleportUnit_ShouldThrow_WithMessage_WhenLocation_IsAlreadyOccupied()
        {
            this.UnitMock.Setup(unit => unit.CurrentLocation).Returns(this.PathFactory.GetLocation());

            // Location in same galaxy
            this.LocationMock.Setup(location => location.Planet.Galaxy.Name).Returns(this.PathFactory.GetLocation().Planet.Galaxy.Name);

            this.LocationMock.Setup(location => location.Planet.Name).Returns("Planet5");

            var unitsOnPlanet = new List<IUnit>()
            {
                new Mock<IUnit>().Object
            };

            this.LocationMock.Setup(location => location.Planet.Units).Returns(unitsOnPlanet);

            var testUnit = this.UnitMock.Object;

            var testLocation = this.LocationMock.Object;

            Assert.That(
                () => this.TeleportStation.TeleportUnit(testUnit, testLocation), Throws.TypeOf<InvalidTeleportationLocationException>()
                    .With.Message.Contain("units will overlap"));
        }

    }
}