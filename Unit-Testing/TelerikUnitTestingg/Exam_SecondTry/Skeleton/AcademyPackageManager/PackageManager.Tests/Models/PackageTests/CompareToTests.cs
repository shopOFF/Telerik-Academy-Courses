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
    public class CompareToTests
    {
        [Test]
        public void Other_WhenCorrectValueIsPassed_ShouldSetCorrectly()
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

            var otherPackVersionMock = new Mock<IVersion>();
            otherPackVersionMock.Setup(x => x.Major).Returns(13);
            otherPackVersionMock.Setup(x => x.Minor).Returns(5);
            otherPackVersionMock.Setup(x => x.Patch).Returns(3);
            otherPackVersionMock.Setup(x => x.VersionType).Returns(VersionType.final);
            var otherPackage = new Mock<IPackage>();
            otherPackage.SetupGet(x => x.Name).Returns("Valid Name");
            otherPackage.SetupGet(x => x.Version).Returns(otherPackVersionMock.Object);

            var package = new Package(packageName, versionMock.Object, collectionOfPackages);

            // Act & Assert
            Assert.DoesNotThrow(() => package.CompareTo(otherPackage.Object));
        }

        [Test]
        public void Other_WhenInvalidValueIsPassed_ShouldThrowArgumentNullExceptionWithMessage()
        {
            // Arrange
            var packageName = "Valid Name";
            var versionMock = new Mock<IVersion>();
            var packageMock = new Mock<IPackage>();

            var collectionOfPackages = new List<IPackage>() { packageMock.Object };

            var otherPackVersionMock = new Mock<IVersion>();

            var package = new Package(packageName, versionMock.Object, collectionOfPackages);

            // Act & Assert
            Assert.That(() => package.CompareTo(null), Throws.TypeOf<ArgumentNullException>().With.Message.Contains("The object cannot be null"));
        }

        [Test]
        public void CompareTo_WhenPassedPackageNameIsNotTheSameAsTheOtherPackageName_ShouldThrowArgumentException()
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

            var otherPackVersionMock = new Mock<IVersion>();
            otherPackVersionMock.Setup(x => x.Major).Returns(13);
            otherPackVersionMock.Setup(x => x.Minor).Returns(5);
            otherPackVersionMock.Setup(x => x.Patch).Returns(3);
            otherPackVersionMock.Setup(x => x.VersionType).Returns(VersionType.final);
            var otherPackage = new Mock<IPackage>();
            otherPackage.SetupGet(x => x.Name).Returns("InValid dif Name");
            otherPackage.SetupGet(x => x.Version).Returns(otherPackVersionMock.Object);

            var package = new Package(packageName, versionMock.Object, collectionOfPackages);

            // Act & Assert
            Assert.Throws<ArgumentException>(() => package.CompareTo(otherPackage.Object));
        }

        [Test]
        public void WhenPassedPackageNameIsTheSameAsTheOtherPackageName_ShouldNotThrowExceptionAndReturnZero()
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

            var otherPackVersionMock = new Mock<IVersion>();
            otherPackVersionMock.Setup(x => x.Major).Returns(13);
            otherPackVersionMock.Setup(x => x.Minor).Returns(5);
            otherPackVersionMock.Setup(x => x.Patch).Returns(3);
            otherPackVersionMock.Setup(x => x.VersionType).Returns(VersionType.final);
            var otherPackage = new Mock<IPackage>();
            otherPackage.SetupGet(x => x.Name).Returns("Valid Name");
            otherPackage.SetupGet(x => x.Version).Returns(otherPackVersionMock.Object);

            var package = new Package(packageName, versionMock.Object, collectionOfPackages);
            var expectedResult = 0;

            // Act
            var actualResult = package.CompareTo(otherPackage.Object);
            
            // Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void WhenPassedPackageIsHigherVersion_ShouldReturnMinus1()
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

            var otherPackVersionMock = new Mock<IVersion>();
            otherPackVersionMock.Setup(x => x.Major).Returns(23);
            otherPackVersionMock.Setup(x => x.Minor).Returns(15);
            otherPackVersionMock.Setup(x => x.Patch).Returns(13);
            otherPackVersionMock.Setup(x => x.VersionType).Returns(VersionType.final);
            var otherPackage = new Mock<IPackage>();
            otherPackage.SetupGet(x => x.Name).Returns("Valid Name");
            otherPackage.SetupGet(x => x.Version).Returns(otherPackVersionMock.Object);

            var package = new Package(packageName, versionMock.Object, collectionOfPackages);
            var expectedResultWhenOtherPacksVersionIsHigher = -1;

            // Act
            var actualResult = package.CompareTo(otherPackage.Object);

            // Assert
            Assert.AreEqual(expectedResultWhenOtherPacksVersionIsHigher, actualResult);
        }

        [Test]
        public void WhenPassedPackageIsLowerVersion_ShouldReturn1()
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

            var otherPackVersionMock = new Mock<IVersion>();
            otherPackVersionMock.Setup(x => x.Major).Returns(3);
            otherPackVersionMock.Setup(x => x.Minor).Returns(3);
            otherPackVersionMock.Setup(x => x.Patch).Returns(2);
            otherPackVersionMock.Setup(x => x.VersionType).Returns(VersionType.final);
            var otherPackage = new Mock<IPackage>();
            otherPackage.SetupGet(x => x.Name).Returns("Valid Name");
            otherPackage.SetupGet(x => x.Version).Returns(otherPackVersionMock.Object);

            var package = new Package(packageName, versionMock.Object, collectionOfPackages);
            var expectedResultWhenOtherPacksVersionIsLower = 1;

            // Act
            var actualResult = package.CompareTo(otherPackage.Object);

            // Assert
            Assert.AreEqual(expectedResultWhenOtherPacksVersionIsLower, actualResult);
        }

        [Test]
        public void WhenPassedPackageVersionIsTheSame_ShouldReturnZero()
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

            var otherPackVersionMock = new Mock<IVersion>();
            otherPackVersionMock.Setup(x => x.Major).Returns(13);
            otherPackVersionMock.Setup(x => x.Minor).Returns(5);
            otherPackVersionMock.Setup(x => x.Patch).Returns(3);
            otherPackVersionMock.Setup(x => x.VersionType).Returns(VersionType.final);
            var otherPackage = new Mock<IPackage>();
            otherPackage.SetupGet(x => x.Name).Returns("Valid Name");
            otherPackage.SetupGet(x => x.Version).Returns(otherPackVersionMock.Object);

            var package = new Package(packageName, versionMock.Object, collectionOfPackages);
            var expectedResultWhenSameVersions = 0;

            // Act
            var actualResult = package.CompareTo(otherPackage.Object);

            // Assert
            Assert.AreEqual(expectedResultWhenSameVersions, actualResult);
        }
    }
}
