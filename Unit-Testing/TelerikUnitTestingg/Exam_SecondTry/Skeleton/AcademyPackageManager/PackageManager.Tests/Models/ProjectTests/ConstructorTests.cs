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
    public class ConstructorTests
    {
        [Test]
        public void Constructor_WhenPassedValuesAreValidAndOptionalParameterPackageRepositoryIsSetCorrectly_ShouldSetCorrectlyOptionalParameterPackages()
        {
            // Arrange
            var name = "Valid name";
            var location = "Valid location";
            var packageMock = new Mock<IPackage>();
            packageMock.Setup(x => x.Name).Returns("ValidNAmePack");
            var collectionOfPackages = new List<IPackage>() { packageMock.Object };
            var logger = new ConsoleLogger();

            var repository= new PackageRepository(logger, collectionOfPackages);
            // Act

            var project = new Project(name, location, repository);

            // Assert
            Assert.IsNotNull(project.PackageRepository);
        }

        [Test]
        public void Constructor_WhenPassedValuesAreValidAndPassedParameterPackageRepositoryIsSetCorrectly_ShouldSetCorrectlyPassedParameterPackages()
        {
            // Arrange
            var name = "Valid name";
            var location = "Valid location";
            var packageMock = new Mock<IPackage>();
            packageMock.Setup(x => x.Name).Returns("ValidNAmePack");
            var collectionOfPackages = new List<IPackage>() { packageMock.Object };
            var logger = new ConsoleLogger();

            var repository = new PackageRepository(logger, collectionOfPackages);
            // Act

            var project = new Project(name, location, repository);

            // Assert
            Assert.IsInstanceOf<PackageRepository>(repository);
        }

        [Test]
        public void Constructor_WhenPassedValuesAreValidAndOptionalParameterPackageRepositoryIsSetCorrectly_ShouldCreateNewInstanceOfProject()
        {
            // Arrange
            var name = "Valid name";
            var location = "Valid location";
            var repositoryMock = new Mock<IRepository<IPackage>>();

            // Act
            var project = new Project(name, location, repositoryMock.Object);

            // Assert
            Assert.IsInstanceOf<Project>(project);
        }
    }
}
