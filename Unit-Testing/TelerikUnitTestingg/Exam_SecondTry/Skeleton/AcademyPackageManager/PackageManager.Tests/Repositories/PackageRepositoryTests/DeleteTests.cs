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
    public class DeleteTests
    {
        [Test] // тоя не минаваше на изпита, трябваше да се сетъпне и otherPackageMock dependencitata и да го набутаме в 
                // колекцията от пакети....
        public void Delete_WhenValuePAckageIsValid_ShouldAddedPackageSuccessfuly()
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

            var otherPackageMock = new Mock<IPackage>();
            otherPackageMock.SetupGet(x => x.Name).Returns("Another Valid Name");
            otherPackageMock.SetupGet(x => x.Version).Returns(versionMock.Object);

            var collectionOfPackages = new List<IPackage>() { packageMock.Object,otherPackageMock.Object };
            packageMock.SetupGet(x => x.Dependencies).Returns(collectionOfPackages);
            otherPackageMock.SetupGet(x => x.Dependencies).Returns(collectionOfPackages);

            var packageRepo = new FakePackageRepository(loggerMock.Object, collectionOfPackages);

            packageRepo.Add(otherPackageMock.Object);

            // Act
            packageRepo.Delete(otherPackageMock.Object);

            // Assert
            Assert.IsFalse(packageRepo.Packages.Contains(otherPackageMock.Object));
            Assert.AreEqual(1, packageRepo.Packages.Count);
        }

        [Test]
        public void Delete_WhenValuePAckageIsInValid_ShouldThrowArgumentNullExceptionWithMessage()
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
            Assert.That(() => packageRepo.Update(null), Throws.TypeOf<ArgumentNullException>().With.Message.Contains("The package cannot be null"));
        }
    }
}
