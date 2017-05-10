using NUnit.Framework;
using PackageManager.Enums;
using PackageManager.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PackageManager.Tests.Models.PackageVersionTest
{
    [TestFixture]
    public class PropertiesTests
    {
        [Test]
        public void PropertieMajor_WhenPassedValueIsValid_ShouldSetCorrectly()
        {
            // Arrange
            var major = 6;
            var minor = 3;
            var patch = 5;
            var version = VersionType.alpha;

            // Act
            var packageVersion = new PackageVersion(major, minor, patch, version);

            // Assert
            Assert.AreEqual(major, packageVersion.Major);
        }

        [Test]
        public void PropertieMajor_WhenPassedValueIsInvalid_ShouldThrowArgumentException()
        {
            // Arrange
            var invalidMajor = -6;
            var minor = 3;
            var patch = 5;
            var version = VersionType.alpha;

            // Act & Assert
            Assert.Throws<ArgumentException>(() => new PackageVersion(invalidMajor, minor, patch, version));
        }

        [Test]
        public void PropertieMinor_WhenPassedValueIsValid_ShouldSetCorrectly()
        {
            // Arrange
            var major = 6;
            var minor = 3;
            var patch = 5;
            var version = VersionType.alpha;

            // Act
            var packageVersion = new PackageVersion(major, minor, patch, version);

            // Assert
            Assert.AreEqual(minor, packageVersion.Minor);
        }

        [Test]
        public void PropertieMinor_WhenPassedValueIsInvalid_ShouldThrowArgumentException()
        {
            // Arrange
            var major = 6;
            var invalidMinor = -33;
            var patch = 5;
            var version = VersionType.alpha;

            // Act & Assert
            Assert.Throws<ArgumentException>(() => new PackageVersion(major, invalidMinor, patch, version));
        }

        [Test]
        public void PropertiePatch_WhenPassedValueIsValid_ShouldSetCorrectly()
        {
            // Arrange
            var major = 6;
            var minor = 3;
            var patch = 5;
            var version = VersionType.alpha;

            // Act
            var packageVersion = new PackageVersion(major, minor, patch, version);

            // Assert
            Assert.AreEqual(patch, packageVersion.Patch);
        }

        [Test]
        public void PropertiePatch_WhenPassedValueIsInvalid_ShouldThrowArgumentException()
        {
            // Arrange
            var major = 6;
            var minor = 3;
            var InvalidPatch = -55;
            var version = VersionType.alpha;

            // Act & Assert
            Assert.Throws<ArgumentException>(() => new PackageVersion(major, minor, InvalidPatch, version));
        }

        [Test]
        public void PropertieVersionType_WhenPassedValueIsValid_ShouldSetCorrectly()
        {
            // Arrange
            var major = 6;
            var minor = 3;
            var patch = 5;
            var version = VersionType.alpha;

            // Act
            var packageVersion = new PackageVersion(major, minor, patch, version);

            // Assert
            Assert.AreEqual(version, packageVersion.VersionType);
        }

        [Test]
        public void PropertieVersionType_WhenPassedValueIsInvalid_ShouldThrowArgumentException()
        {
            // Arrange
            var major = 6;
            var minor = 3;
            var patch = 5;

            // Act & Assert
            Assert.Throws<ArgumentException>(() => new PackageVersion(major, minor, patch, (VersionType)Enum.Parse(typeof(VersionType), "Invalid VErsion")));
        }
    }
}
