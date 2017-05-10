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
    class UpdateTests
    {
        [Test]
        public void Update_WhenValuePAckageIsInValid_ShouldThrowArgumentNullExceptionWithMessage()
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
            Assert.That(() => packageRepo.Delete(null), Throws.TypeOf<ArgumentNullException>().With.Message.Contains("Package cannot be null"));
        }
    }
}
