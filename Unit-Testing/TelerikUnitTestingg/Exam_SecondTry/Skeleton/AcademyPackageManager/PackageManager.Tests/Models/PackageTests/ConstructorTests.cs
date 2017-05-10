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

namespace PackageManager.Tests.Models.PackageTests
{
    [TestFixture]
    public class ConstructorTests
    {
        [Test]
        public void Constructor_WhenValidOptionalParametersArePassedToDependencies_ShouldSetCorrectlyDependencies()
        {
            // Arrange
            var packageName = "Valid Name";
            var versionMock = new Mock<IVersion>();

            var packageMock = new Mock<IPackage>();
            var collectionOfPackages = new List<IPackage>() { packageMock.Object };

            // Act
            var package = new Package(packageName, versionMock.Object, collectionOfPackages);

            // Assert
            Assert.IsNotNull(package.Dependencies);
        }

        [Test]
        public void Constructor_WhenValidParametersArePassedToDependencies_ShouldSetCorrectlyDependencies()
        {
            // Arrange
            var packageName = "Valid Name";
            var versionMock = new Mock<IVersion>();

            var packageMock = new Mock<IPackage>();
            var collectionOfPackages = new List<IPackage>() { packageMock.Object };

            // Act
            var package = new Package(packageName, versionMock.Object, collectionOfPackages);

            // Assert
            Assert.IsTrue(package.Dependencies.Contains(packageMock.Object));
        }
    }
}
