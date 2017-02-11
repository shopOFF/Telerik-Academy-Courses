namespace IntergalacticTravel.Tests.TeleportStationClass
{
    using System;
    using IntergalacticTravel;
    using IntergalacticTravel.Contracts;
    using Moq;
    using NUnit.Framework;
    using System.Collections.Generic;
    using Exceptions;

    [TestFixture]
    public class Constructor_Should
    {
        /*
         * Constructor should set up all of the provided fields (owner, galacticMap & location),
         * when a new TeleportStation is created with valid parameters passed to the constructor.
        */
        [Test]
        public void CreateNewTeleportStation_WhenNewTeleportStationIsCreatedWithValidParameters()
        {
            // Arrange
            var mockedOwner = new Mock<IBusinessOwner>();
            var mockedIPath = new Mock<IPath>();
            var galacticMap = new[] { mockedIPath.Object };
            var mockedLocation = new Mock<ILocation>();

            // Act && Assert
            Assert.DoesNotThrow(() => new TeleportStation(mockedOwner.Object, galacticMap, mockedLocation.Object));
        } 
    }
}