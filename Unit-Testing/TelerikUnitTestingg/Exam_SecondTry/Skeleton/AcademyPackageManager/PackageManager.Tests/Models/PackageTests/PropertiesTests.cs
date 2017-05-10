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
    public class PropertiesTests
    {
        [Test]
        public void PropertieName_WhenCorrectValueIsPassed_ShouldSetCorrectly()
        {
            // Arrange
            var packageName = "Valid Name";
            var versionMock = new Mock<IVersion>();

            var packageMock = new Mock<IPackage>();
            var collectionOfPackages = new List<IPackage>() { packageMock.Object };

            // Act
            var package = new Package(packageName, versionMock.Object, collectionOfPackages);

            // Assert
            Assert.AreEqual(packageName, package.Name);
        }

        [Test]
        public void PropertieVersion_WhenCorrectValueIsPassed_ShouldSetCorrectly()
        {
            // Arrange
            var packageName = "Valid Name";
            var versionMock = new Mock<IVersion>();

            var packageMock = new Mock<IPackage>();
            var collectionOfPackages = new List<IPackage>() { packageMock.Object };

            // Act
            var package = new Package(packageName, versionMock.Object, collectionOfPackages);

            // Assert
            Assert.AreEqual(versionMock.Object, package.Version);
        }

        [Test]
        public void PropertieUrl_WhenCorrectValueIsPassed_ShouldSetCorrectly()
        {
            // Arrange
            var packageName = "Valid Name";

            var versionMock = new Mock<IVersion>();
            versionMock.Setup(x => x.Major).Returns(13);
            versionMock.Setup(x => x.Minor).Returns(5);
            versionMock.Setup(x => x.Patch).Returns(3);
            versionMock.Setup(x => x.VersionType).Returns(VersionType.final);

            var packageMock = new Mock<IPackage>();
            var collectionOfPackages = new List<IPackage>() { packageMock.Object };

            var expectedResult = $"{13}.{5}.{3}-{VersionType.final}";

            // Act
            var package = new Package(packageName, versionMock.Object, collectionOfPackages);

            // Assert
            Assert.AreEqual(expectedResult, package.Url);
        }
    }
}
