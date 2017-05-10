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

namespace Academy.Tests.CommandsTests.AddingTests.AddStudentToSeasonCommandTests
{
    [TestFixture]
    public class ExecuteTests
    {
        [Test]
        public void Execute_WhenPassedStudentIsAlreadyAPartOfThatSeason_ShouldThrowArgumentException()
        {
            // ТОЯ ТЕСТ Е С МОКНАТИ СТУДЕНТ И СЕЗОН, ДОЛНИТЕ ПОД ТОЯ ТЕСТ СА БЕЗ ДА СА МОКНАТИ...
            // ВСЕ ТАЯ В СЛУЧАЯ ПРАВЯТ ЕДНО И СЪЩО И НЯМА МН ЗНАЧЕНИЕ, ПРОСТО Е ВЪЗМОЖНО И ДА ГИ МОКНЕМ ТИЯ ДЕПЕНДАСИТА!!!
            // Arrange 
            var student = new Mock<IStudent>();
            student.Setup(x => x.Username).Returns("pesho");
            student.Setup(x => x.Track).Returns(Track.Dev);

            var season = new Mock<ISeason>();
            season.SetupGet(x => x.StartingYear).Returns(2016);
            season.Setup(x => x.EndingYear).Returns(2017);
            season.Setup(x => x.Initiative).Returns(Initiative.CoderDojo);
            season.Setup(x => x.Students).Returns(new List<IStudent>() { student.Object});

            var listOfStudents = new List<IStudent>() { student.Object };
            var lisOfSeasons = new List<ISeason>() { season.Object };

            var fakeEngine = new Mock<IEngine>();
            fakeEngine.Setup(x => x.Students).Returns(listOfStudents);
            fakeEngine.Setup(x => x.Seasons).Returns(lisOfSeasons);

            var fakeAcademyFactory = new Mock<IAcademyFactory>();

            var command = new AddStudentToSeasonCommand(fakeAcademyFactory.Object, fakeEngine.Object);

            var seasonId = "0";
            var parametersStudentUsernameAndSeasonId = new List<string>() { "pesho", seasonId };

            // Act & Assert
            Assert.Throws<ArgumentException>(() => command.Execute(parametersStudentUsernameAndSeasonId));
        }

        [Test]
        public void Execute_WhenPassedValuesAreValid_ShouldCorrectlyAddFoundStudentInToTheSeason()
        {
            // Arrange 
            var student = new Student("pesho", Track.Dev);
            var season = new Season(2016, 2017, Initiative.CoderDojo);

            var listOfStudents = new List<IStudent>() { student };
            var lisOfSeasons = new List<ISeason>() { season };

            var fakeEngine = new Mock<IEngine>();
            fakeEngine.Setup(x => x.Students).Returns(listOfStudents);
            fakeEngine.Setup(x => x.Seasons).Returns(lisOfSeasons);

            var fakeAcademyFactory = new Mock<IAcademyFactory>();

            var command = new AddStudentToSeasonCommand(fakeAcademyFactory.Object, fakeEngine.Object);

            var seasonId = "0";
            var parametersStudentUsernameAndSeasonId = new List<string>() { "pesho", seasonId };

            // Act
            command.Execute(parametersStudentUsernameAndSeasonId);

            //  Assert
            Assert.IsTrue(season.Students.Contains(student));
        }

        [Test]
        public void Execute_WhenPassedValuesAreValid_ShouldReturnSuccessMessage()
        {
            // Arrange 
            var student = new Student("Pesho", Track.Dev);
            var season = new Season(2016, 2017, Initiative.CoderDojo);

            var listOfStudents = new List<IStudent>() { student };
            var lisOfSeasons = new List<ISeason>() { season };

            var fakeEngine = new Mock<IEngine>();
            fakeEngine.Setup(x => x.Students).Returns(listOfStudents);
            fakeEngine.Setup(x => x.Seasons).Returns(lisOfSeasons);

            var fakeAcademyFactory = new Mock<IAcademyFactory>();

            var command = new AddStudentToSeasonCommand(fakeAcademyFactory.Object, fakeEngine.Object);

            var seasonId = "0";
            var parametersStudentUsernameAndSeasonId = new List<string>() { "Pesho", seasonId };

            // Act
            var expectedResult = command.Execute(parametersStudentUsernameAndSeasonId);

            //  Assert
            StringAssert.Contains(student.Username, expectedResult);
            StringAssert.Contains("0", expectedResult);
            // или директно цялото съобщение
            // StringAssert.Contains($"Student {student.Username} was added to Season {0}.", expectedResult);
        }
    }
}

