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
    public class NameTests
    {
        [TestCase(null)]
        [TestCase("")]
        [TestCase("      ")]
        [TestCase("thisinputiswaytolong,soitisinvalidandshouldThrowanexceptionisinputiswaytolong,soitisinvalidandshoul")]
        [TestCase("n")]
        public void Name_WhenPassedValueIsInvalid_ShouldThrowArgumentException(string invalidCourseName)
        {
            // Arrange
            var startDate = new DateTime(2017, 7, 7);
            var endDate = new DateTime(2017, 7, 27);
            // или директно си ассъртваме при създаването на Course понеже, пак минава през сетъра на 
            // пропъртито и го тества ....
            var course = new Course("Math", 3, startDate, endDate);

            //  Act & Assert
            Assert.Throws<ArgumentException>(() => course.Name = invalidCourseName);
        }

        [TestCase("Math", "Programming")]
        [TestCase("Biology", "Chemistry")]
        public void Name_WhenPassedValueIsValid_ShouldNotThrowException(string initialCourseName, string afterCourseName)
        {
            // Arrange
            var startDate = new DateTime(2017, 7, 7);
            var endDate = new DateTime(2017, 7, 27);
            var course = new Course(initialCourseName, 3, startDate, endDate);

            // Act & Assert  тестваме точно на пропъртито сетъра
            Assert.DoesNotThrow(() => course.Name = afterCourseName);
        }

        // ето така тестваме пропъртито дали сетва правилно
        [Test]
        public void Name_WhenPassedValueIsValid_ShouldCorrectlyAssignPassedValue()
        {
            // Arrange
            var startDate = new DateTime(2017, 7, 7);
            var endDate = new DateTime(2017, 7, 27);
            var course = new Course("Math", 3, startDate, endDate);

            var courseNameChange = "Biology";
            // Act 
            course.Name = courseNameChange;

            // Assert
            Assert.AreEqual(courseNameChange, course.Name);
        }
    }
}
