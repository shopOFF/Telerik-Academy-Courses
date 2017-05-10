using Moq;
using NUnit.Framework;
using PackageManager.Commands;
using PackageManager.Core;
using PackageManager.Core.Contracts;
using PackageManager.Enums;
using PackageManager.Info;
using PackageManager.Info.Contracts;
using PackageManager.Models;
using PackageManager.Models.Contracts;
using PackageManager.Repositories;
using PackageManager.Repositories.Contracts;
using PackageManager.Tests.Commands.Fakes;
using PackageManager.Tests.Repositories.Fakes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PackageManager.Tests.Repositories.PackageRepositoryTests
{
    [TestFixture]
    public class AddTests
    {
        [Test]
        public void Add_WhenValuePAckageIsValid_ShouldAddedPackageSuccessfuly()
        {
            // Arrange
            var loggerMock = new Mock<ILogger>();

            var versionMock = new Mock<IVersion>();
            versionMock.Setup(x => x.Major).Returns(13);
            versionMock.Setup(x => x.Minor).Returns(5);
            versionMock.Setup(x => x.Patch).Returns(3);
            versionMock.Setup(x => x.VersionType).Returns(VersionType.final);
            var packageMock = new Mock<IPackage>();
            packageMock.SetupGet(x => x.Name).Returns("Valid Name");
            packageMock.SetupGet(x => x.Version).Returns(versionMock.Object);

            var collectionOfPackages = new List<IPackage>() { packageMock.Object };

            var otherPackageMock = new Mock<IPackage>();
            otherPackageMock.SetupGet(x => x.Name).Returns("Another Valid Name");
            var packageRepo = new FakePackageRepository(loggerMock.Object, collectionOfPackages);

            // Act
            packageRepo.Add(otherPackageMock.Object);

            // Assert
            Assert.IsTrue(packageRepo.Packages.Contains(otherPackageMock.Object));
            Assert.AreEqual(2, packageRepo.Packages.Count);
        }

        [Test]
        public void Add_WhenValuePAckageIsInValid_ShouldThrowArgumentNullExceptionWithMessage()
        {
            // Arrange
            var loggerMock = new Mock<ILogger>();

            var versionMock = new Mock<IVersion>();
            versionMock.Setup(x => x.Major).Returns(13);
            versionMock.Setup(x => x.Minor).Returns(5);
            versionMock.Setup(x => x.Patch).Returns(3);
            versionMock.Setup(x => x.VersionType).Returns(VersionType.final);
            var packageMock = new Mock<IPackage>();
            packageMock.SetupGet(x => x.Name).Returns("Valid Name");
            packageMock.SetupGet(x => x.Version).Returns(versionMock.Object);

            var collectionOfPackages = new List<IPackage>() { packageMock.Object };

            var packageRepo = new FakePackageRepository(loggerMock.Object, collectionOfPackages);

            // Act & Assert
            Assert.That(() => packageRepo.Add(null), Throws.TypeOf<ArgumentNullException>().With.Message.Contains("The package cannot be null"));
        }

        [Test]
        public void Add_WhenPackageDoesNotExist_ShouldAddedPackageSuccessfulyToPackagesCollection()
        {
            // Arrange
            var loggerMock = new Mock<ILogger>();

            var versionMock = new Mock<IVersion>();
            versionMock.Setup(x => x.Major).Returns(13);
            versionMock.Setup(x => x.Minor).Returns(5);
            versionMock.Setup(x => x.Patch).Returns(3);
            versionMock.Setup(x => x.VersionType).Returns(VersionType.final);
            var packageMock = new Mock<IPackage>();
            packageMock.SetupGet(x => x.Name).Returns("Valid Name");
            packageMock.SetupGet(x => x.Version).Returns(versionMock.Object);

            var collectionOfPackages = new List<IPackage>() { packageMock.Object };

            var otherPackageMock = new Mock<IPackage>();
            otherPackageMock.SetupGet(x => x.Name).Returns("Another Valid Name");
            var packageRepo = new FakePackageRepository(loggerMock.Object, collectionOfPackages);

            // Act
            packageRepo.Add(otherPackageMock.Object);

            // Assert
            Assert.IsTrue(packageRepo.Packages.Contains(otherPackageMock.Object));
            Assert.AreEqual(2, packageRepo.Packages.Count);
        }

        [Test]
        public void Add_WhenPackageAlreadyExist_ShouldNotAddToPackagesCollection()
        {
            // Arrange
            var loggerMock = new Mock<ILogger>();

            var versionMock = new Mock<IVersion>();
            versionMock.Setup(x => x.Major).Returns(13);
            versionMock.Setup(x => x.Minor).Returns(5);
            versionMock.Setup(x => x.Patch).Returns(3);
            versionMock.Setup(x => x.VersionType).Returns(VersionType.final);
            var packageMock = new Mock<IPackage>();
            packageMock.SetupGet(x => x.Name).Returns("Valid Name");
            packageMock.SetupGet(x => x.Version).Returns(versionMock.Object);
            var collectionOfPackages = new List<IPackage>() { packageMock.Object };

            var otherPackageMock = new Mock<IPackage>();
            otherPackageMock.SetupGet(x => x.Name).Returns("Another Valid Name");
            var collectionOfMorePackages = new List<IPackage>() { otherPackageMock.Object };
            packageMock.SetupGet(x => x.Dependencies).Returns(collectionOfMorePackages);
            packageMock.SetupGet(x => x.Url).Returns("valid");
            var packageRepo = new FakePackageRepository(loggerMock.Object, collectionOfPackages);

            // Act
            packageRepo.Add(packageMock.Object);

            // Assert
            Assert.IsFalse(packageRepo.Packages.Contains(packageMock.Object));
            Assert.AreEqual(1, packageRepo.Packages.Count);
        }
    }
}
