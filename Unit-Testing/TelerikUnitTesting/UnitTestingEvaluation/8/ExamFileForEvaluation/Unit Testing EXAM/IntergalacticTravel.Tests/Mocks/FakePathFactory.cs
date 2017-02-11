namespace IntergalacticTravel.Tests.Mocks
{
    using System.Collections.Generic;
    using Contracts;
    using Moq;

    public class FakePathFactory : IFakePathFactory
    {
        public const string DefaultGalaxy = "some galaxy";
        public const string DefaultPlanet = "some planet";

        public ILocation GetLocation()
        {
            return this.GetLocation(DefaultGalaxy, DefaultPlanet);
        }

        public ILocation GetLocation(string galaxy, string planet)
        {
            var mock = this.GetLocationMock(galaxy, planet);

            return mock.Object;
        }

        public IPath GetPath(string planet = DefaultPlanet)
        {
            var mock = new Mock<IPath>();
            mock.Setup(p => p.Cost).Returns(new Resources(20, 30, 40));
            mock.Setup(p => p.TargetLocation).Returns(this.GetLocation());
            mock.Setup(p => p.TargetLocation).Returns(this.GetLocationMock(DefaultGalaxy, planet).Object);

            return mock.Object;
        }

        public IEnumerable<IPath> GetMap()
        {
            var list = new List<IPath>()
            {
                this.GetPath(DefaultPlanet + 1),
                this.GetPath(DefaultPlanet + 2),
                this.GetPath(DefaultPlanet + 3)
            };

            return list;
        }

        private Mock<ILocation> GetLocationMock(string galaxy, string planet)
        {
            var mock = new Mock<ILocation>();

            mock.Setup(location => location.Planet.Galaxy.Name).Returns(galaxy);

            mock.Setup(location => location.Planet.Name).Returns(planet);

            return mock;
        }
    }
}
