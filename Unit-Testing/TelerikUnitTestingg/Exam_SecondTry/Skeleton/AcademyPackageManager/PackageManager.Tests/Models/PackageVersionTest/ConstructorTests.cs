using NUnit.Framework;
using PackageManager.Enums;
using PackageManager.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PackageManager.Tests.Models.PackageVersionTests
{
    [TestFixture]
    public class ConstructorTests
    {
        [Test]
        public void Constructor_WhenPassedValuesAreValid_ShouldSetCorrectly()
        {
            // Arrange
            var major = 6;
            var minor = 3;
            var patch = 5;
            var version = VersionType.alpha;

            // Act
            var packageVersion = new PackageVersion(major, minor, patch, version);

            // Assert
            Assert.IsTrue(packageVersion.Major == major &&
                          packageVersion.Minor == minor &&
                          packageVersion.Patch == patch &&
                          packageVersion.VersionType == version);
        }
    }
}
