using Moq;
using NUnit.Framework;
using PackageManager.Enums;
using PackageManager.Info;
using PackageManager.Models;
using PackageManager.Models.Contracts;
using PackageManager.Repositories;
using PackageManager.Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PackageManager.Tests.Models.ProjectTests
{
    [TestFixture]
   public  class PropertiesTests
    {
        [Test]
        public void PropertieName_WhenPassedValuesAreValid_ShouldSetCorrectly()
        {
            // Arrange
            var name = "Valid name";
            var location = "Valid location";

            var packageMock = new Mock<IPackage>();
            var collectionOfPackages = new List<IPackage>() { packageMock.Object };

            var logger = new ConsoleLogger();
            var repository = new PackageRepository(logger, collectionOfPackages);

            // Act
            var project = new Project(name, location, repository);

            // Assert
            Assert.AreEqual(name, project.Name);
        }

        [Test]
        public void PropertieLocation_WhenPassedValuesAreValid_ShouldSetCorrectly()
        {
            // Arrange
            var name = "Valid name";
            var location = "Valid location";

            var packageMock = new Mock<IPackage>();
            var collectionOfPackages = new List<IPackage>() { packageMock.Object };

            var logger = new ConsoleLogger();
            var repository = new PackageRepository(logger, collectionOfPackages);

            // Act
            var project = new Project(name, location, repository);

            // Assert
            Assert.AreEqual(location, project.Location);
        }

    }
}
