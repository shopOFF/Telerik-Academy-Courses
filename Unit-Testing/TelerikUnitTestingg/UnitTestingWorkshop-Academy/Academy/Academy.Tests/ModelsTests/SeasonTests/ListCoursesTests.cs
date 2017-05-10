using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Academy.Models;
using Academy.Models.Enums;

namespace Academy.Tests.ModelsTests.SeasonTests
{
    [TestFixture]
    public class ListCoursesTests
    {
        [Test]
        public void ListCourses_ShouldReturnAListOfCourses()
        {
            // Arrange
            var season = new Season(2016, 2017, Initiative.CoderDojo);

            var startDate = new DateTime(2017, 7, 7);
            var endDate = new DateTime(2017, 7, 27);
            var numberOfLectures = 3;
            var courseCSharpName = "C# Advanced";
            var courseCSharp = new Course(courseCSharpName, numberOfLectures, startDate, endDate);

            var courseJSName = "JavaScript";
            var courseJS = new Course(courseJSName, numberOfLectures, startDate, endDate);

            season.Courses.Add(courseCSharp);
            season.Courses.Add(courseJS);

            // Act 
            var result = season.ListCourses();

            // Assert
            StringAssert.Contains(courseCSharpName, result);
            StringAssert.Contains(courseJSName, result);
        }

        [Test]
        public void ListCourses_ShouldReturnMessageSayingThatThereAreNoCoursesInThisSeason()
        {
            // Arrange
            var season = new Season(2016, 2017, Initiative.CoderDojo);

            // Act 
            var result = season.ListCourses();

            // Assert
            StringAssert.Contains("no courses in this season", result);
        }
    }
}
