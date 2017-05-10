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
    public class ListUsersTests
    {
        [Test]
        public void ListUsers_ShouldReturnAListOfStudentsAndTrainers()
        {
            // Arrange
            var season = new Season(2016, 2017, Initiative.CoderDojo);
            var student = new Student("GEshooo", Track.Dev);
            var trainer = new Trainer("Tesheff", new string[] { "C#","JS" });
            season.Students.Add(student);
            season.Trainers.Add(trainer);
            // Act 
            var result = season.ListUsers();

            // Assert
            StringAssert.Contains("GEshooo", result);
            StringAssert.Contains("Tesheff", result);
        }

        [Test]
        public void ListUsers_ShouldReturnMessageSayingThatThereAreNoUsersInThisSeason()
        {
            // Arrange
            var season = new Season(2016, 2017, Initiative.CoderDojo);

            // Act 
            var result = season.ListUsers();

            // Assert
            StringAssert.Contains("no users in this season", result);
        }
    }
}
