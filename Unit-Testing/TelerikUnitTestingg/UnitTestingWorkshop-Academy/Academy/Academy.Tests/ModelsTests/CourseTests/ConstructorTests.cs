using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Academy.Models;
using Academy.Core.Providers;

namespace Academy.Tests.ModelsTests
{
    [TestFixture]
    public class ConstructorTests
    {
        [Test]
        public void Constructor_ShouldCorrectlyAssignPassedValueToName()
        {
            // Arrange
            var startDate = new DateTime(2017, 7, 7);
            var endDate = new DateTime(2017, 7, 27);

            // Act 
            var course = new Course("Math", 3, startDate, endDate);

            // Assert
            Assert.AreEqual("Math", course.Name);
        }

        [Test]
        public void Constructor_ShouldCorrectlyAssignPassedValueToLecturesPerWeek()
        {
            // Arrange
            var startDate = new DateTime(2017, 7, 7);
            var endDate = new DateTime(2017, 7, 27);

            // Act 
            var course = new Course("Math", 3, startDate, endDate);

            // Assert
            Assert.AreEqual(3, course.LecturesPerWeek);
        }

        [Test]
        public void Constructor_ShouldCorrectlyAssignPassedValueToStartDate()
        {
            // Arrange
            var startDate = new DateTime(2017, 7, 7);
            var endDate = new DateTime(2017, 7, 27);

            // Act 
            var course = new Course("Math", 3, startDate, endDate);

            // Assert
            Assert.AreEqual(startDate, course.StartingDate);
        }

        [Test]
        public void Constructor_ShouldCorrectlyAssignPassedValueToEndDate()
        {
            // Arrange
            var startDate = new DateTime(2017, 7, 7);
            var endDate = new DateTime(2017, 7, 27);

            // Act 
            var course = new Course("Math", 3, startDate, endDate);

            // Assert
            Assert.AreEqual(endDate, course.EndingDate);
        }

        // ТОЯ ТЕСТ СИ ГО РАЗЦЕПВАМЕ НА 3-ТЕ ТЕСТА ОТ ДОЛО... ЗАЩОТО МНОГО ПО-ЛЕСНО ЩЕ НАМЕРИМ, АКО ИМАМЕ ГРЕШКА НЯКЪДЕ, В КОЯ
        // КОЛЕЦИЯ Е ТЯ И ТН... СЕГА С 3-ТЕ АССЪРТА НЕ СЕ ЗНАЕ КЪДЕ ЩЕ Е АКО НЕЩО ФЕЙЛНЕ ... 
        //[Test] 
        //public void Constructor_ShouldCorrectlyInitializeTheCollections()
        //{
        //    // Arrange
        //    var startDate = new DateTime(2017, 7, 7);
        //    var endDate = new DateTime(2017, 7, 27);

        //    // Act 
        //    var course = new Course("Math", 3, startDate, endDate);

        //    // Assert
        //    Assert.IsNotNull(course.OnlineStudents);
        //    Assert.IsNotNull(course.OnsiteStudents);
        //    Assert.IsNotNull(course.Lectures);
        //}

        [Test]
        public void Constructor_ShouldCorrectlyInitializeTheOnlineStudentsCollection()
        {
            // Arrange
            var startDate = new DateTime(2017, 7, 7);
            var endDate = new DateTime(2017, 7, 27);

            // Act 
            var course = new Course("Math", 3, startDate, endDate);

            // Assert
            Assert.IsNotNull(course.OnlineStudents);
        }

        [Test]
        public void Constructor_ShouldCorrectlyInitializeTheOnsiteStudentsCollection()
        {
            // Arrange
            var startDate = new DateTime(2017, 7, 7);
            var endDate = new DateTime(2017, 7, 27);

            // Act 
            var course = new Course("Math", 3, startDate, endDate);

            // Assert
            Assert.IsNotNull(course.OnsiteStudents);
        }

        [Test]
        public void Constructor_ShouldCorrectlyInitializeLecturesCollection()
        {
            // Arrange
            var startDate = new DateTime(2017, 7, 7);
            var endDate = new DateTime(2017, 7, 27);

            // Act 
            var course = new Course("Math", 3, startDate, endDate);

            // Assert
            Assert.IsNotNull(course.Lectures);
        }
    }
}
