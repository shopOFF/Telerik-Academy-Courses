using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Academy.Models;
using Academy.Models.Enums;
using Academy.Models.Abstractions;
using Academy.Tests.Fakes;
using Academy.Core.Factories;
using Academy.Models.Utils.LectureResources;

namespace Academy.Tests.CoreTests.FactoriesTests.AcademyFactoryTests
{
    [TestFixture]
    public class CreateLectureResourceTests
    {
        [TestCase(null)]
        [TestCase("")]
        [TestCase("1")]
        [TestCase("thisiswaytolongsoitsinvalid!!!!!!!!!!!")]
        [TestCase("              ")]
        public void CreateLectureResource_WhenPassedTypeIsInvalid_ShouldThrowArgumentException(string invalidInput)
        {
            // Arrange
            var academyFactory = AcademyFactory.Instance;

            // Act & Assert
            Assert.Throws<ArgumentException>(() => academyFactory.CreateLectureResource(invalidInput, "SomeName", "someURL"));
        }

        [Test]
        public void CreateLectureResource_WhenPassedParametersAreCorrect_ShouldReturnCorrectInstanceWithCorrectlyAssignedData()
        {
            // Arrange
            var academyFactory = AcademyFactory.Instance;
            var resourceType = "video";
            var resourceName = "SomeVideoName";
            var resourceUrl = "someURL";

            // Act  
            var factoryResult = academyFactory.CreateLectureResource(resourceType, resourceName, resourceUrl);

            // Assert
            Assert.IsInstanceOf<VideoResource>(factoryResult);
            // това е по скоро за още един тест само да проверява параметрите...
            Assert.AreEqual(resourceName, factoryResult.Name);
            Assert.AreEqual(resourceUrl, factoryResult.Url);
        }
    }
}
