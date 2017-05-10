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
    public class ConstructorTests
    {
        [Test]
        public void Constructor_WhenPassedProviderIsNull_ShouldThrowArgumentNullException()
        {
            // Arrange, Act & Assert
            Assert.Throws<ArgumentNullException>(() => new AddStudentToCourseCommand(null, null));
        }

        [Test]
        public void Constructor_WhenPassedValuesAreValid_ShouldAssingCorrectlyPassedValues()
        {
            // Arrange
            var fakeAcademyFactory = new Mock<IAcademyFactory>();
            fakeAcademyFactory.Setup(x => x.CreateStudent("Pesho", "JS"));
            var fakeEngine = new Mock<IEngine>();
            fakeEngine.Setup(x => x.Writer.Write("Just for the test setup"));

            // Act
            var command = new AddStudentToCourseCommandFake(fakeAcademyFactory.Object, fakeEngine.Object);

            // Assert
            Assert.AreEqual(fakeAcademyFactory.Object, command.Factory);
            Assert.AreEqual(fakeEngine.Object, command.Engine);
        }
    }
}
