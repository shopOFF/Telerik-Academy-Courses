using Moq;
using NUnit.Framework;
using PackageManager.Commands;
using PackageManager.Core;
using PackageManager.Core.Contracts;
using PackageManager.Enums;
using PackageManager.Info;
using PackageManager.Models;
using PackageManager.Models.Contracts;
using PackageManager.Repositories;
using PackageManager.Repositories.Contracts;
using PackageManager.Tests.Commands.Fakes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PackageManager.Tests.Core.PackageInstallerTests
{
    [TestFixture]
    public class ConstructorTests
    {
        [Test]
        public void Constructor_WhenThereAreDependenciesInThePRoject_ShouldRestorePackages()
        {
            var manegerMock = new Mock<IManager>();
            var downloader = new PackageDownloader(manegerMock.Object);

            var versionMock = new Mock<IVersion>();
            versionMock.Setup(x => x.Major).Returns(13);
            versionMock.Setup(x => x.Minor).Returns(5);
            versionMock.Setup(x => x.Patch).Returns(3);
            versionMock.Setup(x => x.VersionType).Returns(VersionType.final);
            var projectMock = new Mock<IProject>();
            var packageMock = new Mock<IPackage>();
            packageMock.SetupGet(x => x.Name).Returns("Valid Name");
            packageMock.SetupGet(x => x.Version).Returns(versionMock.Object);

            var otherPackageMock = new Mock<IPackage>();
            otherPackageMock.SetupGet(x => x.Name).Returns("Another Valid Name");
            otherPackageMock.SetupGet(x => x.Version).Returns(versionMock.Object);

            var collectionOfPackages = new List<IPackage>() { packageMock.Object, otherPackageMock.Object };
            packageMock.SetupGet(x => x.Dependencies).Returns(collectionOfPackages);
            otherPackageMock.SetupGet(x => x.Dependencies).Returns(collectionOfPackages);
           
            var logger = new ConsoleLogger();
            var repository = new PackageRepository(logger, collectionOfPackages);

            var name = "Valid name";
            var location = "Valid location";

            var project = new Project(name, location, repository);
            var packInstaller = new PackageInstaller(downloader, project);

            // Arrange

            // Act
            var packIntsaller = new PackageInstaller(downloader, projectMock.Object);

            // Assert


        }
    }
}
