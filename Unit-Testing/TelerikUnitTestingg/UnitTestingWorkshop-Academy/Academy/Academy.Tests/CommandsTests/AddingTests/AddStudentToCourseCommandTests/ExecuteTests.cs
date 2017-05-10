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
using Academy.Commands.Adding;
using Moq;
using Academy.Core.Contracts;
using Academy.Models.Contracts;

namespace Academy.Tests.CommandsTests.AddingTests.AddStudentToCourseCommandTests
{
    [TestFixture]
    public class ExecuteTests
    {
        [Test]
        public void Execute_WhenPassedStudentIsAlreadyAPartOfThatSeason_ShouldThrowArgumentException()
        {
            // Arrange 
            var student = new Student("pesho", Track.Dev);
            var course = new Course("Math", 3, new DateTime(2017, 7, 7), new DateTime(2017, 7, 27));
            var season = new Season(2016, 2017, Initiative.CoderDojo);
            season.Students.Add(student);
            season.Courses.Add(course);

            var listOfStudents = new List<IStudent>() { student };
            var lisOfSeasons = new List<ISeason>() { season };
            var lisOfCourses = new List<ICourse>() { course };

            var fakeEngine = new Mock<IEngine>();
            fakeEngine.Setup(x => x.Students).Returns(listOfStudents);
            fakeEngine.Setup(x => x.Seasons).Returns(lisOfSeasons);
            fakeEngine.Setup(x => x.Seasons[0].Courses).Returns(lisOfCourses);

            var fakeAcademyFactory = new Mock<IAcademyFactory>();

            var command = new AddStudentToCourseCommand(fakeAcademyFactory.Object, fakeEngine.Object);

            var seasonId = "0";
            var courseId = "0";
            var parametersStudentUsernameSeasonId = new List<string>() { "pesho", seasonId, courseId, "invalidForm" };

            // Act & Assert
            Assert.Throws<ArgumentException>(() => command.Execute(parametersStudentUsernameSeasonId));
        }

        [Test]
        public void Execute_WhenPassedValuesAreValid_ShouldCorrectlyAddFoundStudentInToTheCourseInTheCorrespondingAttendanceForm()
        {
            // Arrange 
            var student = new Student("pesho", Track.Dev);
            var course = new Course("Math", 3, new DateTime(2017, 7, 7), new DateTime(2017, 7, 27));
            var season = new Season(2016, 2017, Initiative.CoderDojo);
            season.Students.Add(student);
            season.Courses.Add(course);

            var listOfStudents = new List<IStudent>() { student };
            var lisOfSeasons = new List<ISeason>() { season };
            var lisOfCourses = new List<ICourse>() { course };

            var fakeEngine = new Mock<IEngine>();
            fakeEngine.Setup(x => x.Students).Returns(listOfStudents);
            fakeEngine.Setup(x => x.Seasons).Returns(lisOfSeasons);
            fakeEngine.Setup(x => x.Seasons[0].Courses).Returns(lisOfCourses);

            var fakeAcademyFactory = new Mock<IAcademyFactory>();

            var command = new AddStudentToCourseCommand(fakeAcademyFactory.Object, fakeEngine.Object);

            var seasonId = "0";
            var courseId = "0";
            var parametersStudentUsernameSeasonId = new List<string>() { "pesho", seasonId, courseId, "onsite" };

            // Act 
            command.Execute(parametersStudentUsernameSeasonId);

            // Assert
            Assert.IsTrue(course.OnsiteStudents.Contains(student));
        }

        [Test]
        public void Execute_WhenPassedValuesAreValid_ShouldReturnSuccessMessageWithTheStudentsUsernameAndSeasonID()
        {
            // Arrange 
            var student = new Student("pesho", Track.Dev);
            var course = new Course("Math", 3, new DateTime(2017, 7, 7), new DateTime(2017, 7, 27));
            var season = new Season(2016, 2017, Initiative.CoderDojo);
            season.Students.Add(student);
            season.Courses.Add(course);

            var listOfStudents = new List<IStudent>() { student };
            var lisOfSeasons = new List<ISeason>() { season };
            var lisOfCourses = new List<ICourse>() { course };

            var fakeEngine = new Mock<IEngine>();
            fakeEngine.Setup(x => x.Students).Returns(listOfStudents);
            fakeEngine.Setup(x => x.Seasons).Returns(lisOfSeasons);
            fakeEngine.Setup(x => x.Seasons[0].Courses).Returns(lisOfCourses);

            var fakeAcademyFactory = new Mock<IAcademyFactory>();

            var command = new AddStudentToCourseCommand(fakeAcademyFactory.Object, fakeEngine.Object);

            var seasonId = "0";
            var courseId = "0";
            var parametersStudentUsernameSeasonId = new List<string>() { "pesho", seasonId, courseId, "onsite" };

            // Act 
            var expectedResult = command.Execute(parametersStudentUsernameSeasonId);

            // Assert
            Assert.IsTrue(course.OnsiteStudents.Contains(student));
            StringAssert.Contains(student.Username, expectedResult);
            StringAssert.Contains(seasonId, expectedResult);
            // или директно цялото съобщение
            //StringAssert.Contains($"Student {student.Username} was added to Course {seasonId}.{course.Name}.", expectedResult);
        }
    }
}
