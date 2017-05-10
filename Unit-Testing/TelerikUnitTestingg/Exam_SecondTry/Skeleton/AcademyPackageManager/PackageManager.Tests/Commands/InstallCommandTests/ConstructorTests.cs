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

namespace PackageManager.Tests.Commands.InstallCommandTests
{
    [TestFixture]
    public class ConstructorTests
    {
        [Test]
        public void Constructor_WhenPassedValuesAreValid_ShouldSetCorrectlyThePassedvalues()
        {
            // Arrange
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

       
            var name = "Valid name";
            var location = "Valid location";
            var collectionOfPackages = new List<IPackage>() { packageMock.Object };
            var logger = new ConsoleLogger();

            var repository = new PackageRepository(logger, collectionOfPackages);

            var project = new Project(name, location, repository);
            var packInstaller = new PackageInstaller(downloader, project);

            // Act
            var installCommand = new FakeInstallCommand(packInstaller, packageMock.Object);

            // Assert
            Assert.AreEqual(packInstaller, installCommand.Installer);
        }
    }
}
