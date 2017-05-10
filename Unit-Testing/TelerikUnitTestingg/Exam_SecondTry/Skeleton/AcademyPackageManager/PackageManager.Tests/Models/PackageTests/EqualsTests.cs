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
    public class EqualsTests
    {
        [Test]
        public void WhenPackagesNamesAndVersionsAreNotTheSame_ShouldReturnFalse()
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

            var package = new Package(packageName, versionMock.Object, collectionOfPackages);
            // Act & Assert
            Assert.IsFalse(package.Equals(packageMock.Object));
        }

        [Test]
        public void WhenPackagesNamesAndVersionsAreTheSame_ShouldReturnTrue()
        {
            // Arrange
            var packageName = "Valid Name";
            var versionMock = new Mock<IVersion>();
            versionMock.Setup(x => x.Major).Returns(13);
            versionMock.Setup(x => x.Minor).Returns(5);
            versionMock.Setup(x => x.Patch).Returns(3);
            versionMock.Setup(x => x.VersionType).Returns(VersionType.final);

            var packageMock = new Mock<IPackage>();
            packageMock.SetupGet(x => x.Name).Returns("Valid Name");
            packageMock.SetupGet(x => x.Version).Returns(versionMock.Object);

            var collectionOfPackages = new List<IPackage>() { packageMock.Object };

            var package = new Package(packageName, versionMock.Object, collectionOfPackages);

            // Act & Assert

            Assert.IsTrue(package.Equals(packageMock.Object));
        }

        [Test]
        public void WhenPassedObjectIsNull_ShouldThrowArgumentNullException()
        {
            // Arrange
            var packageName = "Valid Name";
            var versionMock = new Mock<IVersion>();

            var packageMock = new Mock<IPackage>();

            var collectionOfPackages = new List<IPackage>() { packageMock.Object };

            var package = new Package(packageName, versionMock.Object, collectionOfPackages);

            // Act & Assert

            Assert.Throws<ArgumentNullException>(() => package.Equals(null));
        }

        [Test]
        public void WhenPassedObjectIsNotIPackageType_ShouldThrowArgumentExceptionWithMessage()
        {
            // Arrange
            var packageName = "Valid Name";
            var versionMock = new Mock<IVersion>();

            var packageMock = new Mock<IPackage>();

            var collectionOfPackages = new List<IPackage>() { packageMock.Object };

            var package = new Package(packageName, versionMock.Object, collectionOfPackages);

            var objectJusForTestNotIPackage = versionMock.Object;

            // Act & Assert

            Assert.That(() => package.Equals(objectJusForTestNotIPackage), Throws.TypeOf<ArgumentException>().With.Message.Contains("The object must be IPackage"));
        }

        [Test]
        public void WhenPassedObjectIsIPackageType_ShouldNotThrowException()
        {
            // Arrange
            var packageName = "Valid Name";
            var versionMock = new Mock<IVersion>();

            var packageMock = new Mock<IPackage>();

            var collectionOfPackages = new List<IPackage>() { packageMock.Object };

            var package = new Package(packageName, versionMock.Object, collectionOfPackages);

            // Act & Assert
            Assert.DoesNotThrow(() => package.Equals(packageMock.Object));
        }


        [Test]
        public void WhenPassedPackagesIsEqualToThePackage_ShouldReturnTrue()
        {
            // Arrange
            var packageName = "Valid Name";
            var versionMock = new Mock<IVersion>();
            versionMock.Setup(x => x.Major).Returns(13);
            versionMock.Setup(x => x.Minor).Returns(5);
            versionMock.Setup(x => x.Patch).Returns(3);
            versionMock.Setup(x => x.VersionType).Returns(VersionType.final);

            var packageMock = new Mock<IPackage>();
            packageMock.SetupGet(x => x.Name).Returns("Valid Name");
            packageMock.SetupGet(x => x.Version).Returns(versionMock.Object);

            var collectionOfPackages = new List<IPackage>() { packageMock.Object };

            var package = new Package(packageName, versionMock.Object, collectionOfPackages);

            // Act & Assert

            Assert.IsTrue(package.Equals(packageMock.Object));
        }
    }
}
