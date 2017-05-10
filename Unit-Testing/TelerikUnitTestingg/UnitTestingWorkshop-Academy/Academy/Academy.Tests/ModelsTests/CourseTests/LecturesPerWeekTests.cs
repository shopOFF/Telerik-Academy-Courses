using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Academy.Models;
using Academy.Core.Providers;

namespace Academy.Tests.ModelsTests.CourseTests
{
    [TestFixture]
    public class LecturesPerWeekTests
    {
        [TestCase(0)]
        [TestCase(19)]
        public void LecturesPerWeek_WhenPassedValueIsInvalid_ShouldThrowArgumentException(int invalidNumberOfLectures)
        {
            // Arrange
            var startDate = new DateTime(2017, 7, 7);
            var endDate = new DateTime(2017, 7, 27);
            var courseName = "Math";

            // Act & Assert
            Assert.Throws<ArgumentException>(() => new Course(courseName, invalidNumberOfLectures, startDate, endDate));
        }

        [TestCase(1)]
        [TestCase(6)]
        public void LecturesPerWeek_WhenPassedValueIsValid_ShouldNotThrowException(int validNumberOfLectures)
        {
            // Arrange
            var startDate = new DateTime(2017, 7, 7);
            var endDate = new DateTime(2017, 7, 27);
            var courseName = "Math";

            // Act & Assert
            Assert.DoesNotThrow(() => new Course(courseName, validNumberOfLectures, startDate, endDate));
        }

        [Test]
        public void LecturesPerWeek_WhenPassedValueIsValid_ShouldCorrectlyAssignPassedValue()
        {
            // Arrange
            var startDate = new DateTime(2017, 7, 7);
            var endDate = new DateTime(2017, 7, 27);
            var courseName = "Math";
            var courseNumberOfLectures = 6;

            // Act
            var course = new Course(courseName, courseNumberOfLectures, startDate, endDate);

            // Act & Assert
            Assert.AreEqual(courseNumberOfLectures, course.LecturesPerWeek);
        }
    }
}
