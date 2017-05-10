using System;
using NUnit.Framework;
using Moq;
using Cosmetics.Engine;
using System.Collections.Generic;

namespace Cosmetics.Tests
{
    [TestFixture]
    public class CommandTests
    {
        [Test]
        public void Parse_WhenTheInputIsValid_ShouldReturnNewCommand()
        {
            // Arrange
            var validInput = "AddToCategory ForMale Cool";

            // Act
            var executionResult = Command.Parse(validInput);

            // Assert
            Assert.IsInstanceOf<Command>(executionResult);
        }

        [Test]
        public void Parse_WhenTheInputIsValid_ShouldSetCorrectValueToNamePropertie()
        {
            // Arrange
            var validInput = "AddToCategory ForMale Cool";
            var expectedNamePropertieValue = "AddToCategory";

            // Act

            var executionResult = Command.Parse(validInput);

            // Assert
            Assert.AreEqual(expectedNamePropertieValue, executionResult.Name);
        }

        [Test]
        public void Parse_WhenTheInputIsNotValid_ShouldThrowNullReferenceException()
        {
            Assert.Throws<NullReferenceException>(() => Command.Parse(null));
        }


        [Test]
        public void Parse_WhenTheInputIsValid_ShouldSetCorrectValueToParametersPropertie()
        {
            // Arrange
            var validInput = "AddToCategory ForMale Cool";
            var expectedNamePropertieValue = new List<string>() { "ForMale", "Cool" };

            // Act

            var executionResult = Command.Parse(validInput);

            // Assert
            Assert.AreEqual(expectedNamePropertieValue, executionResult.Parameters);
        }

        [Test]
        public void Parse_WhenTheInputNameValueIsNotValid_ShouldThrowArgumentNullException()
        {
            // Arrange
            var invalidInput = " ForMale Cool";

            // Act && Assert
            Assert.That(() => Command.Parse(invalidInput), Throws.ArgumentNullException.With.Message.Contains("Name"));
        }

        [Test]
        public void Parse_WhenTheInputParametersValueIsNotValid_ShouldThrowArgumentNullException()
        {
            // Arrange
            var invalidInput = "AddToCategory ";

            // Act && Assert
            Assert.That(() => Command.Parse(invalidInput), Throws.ArgumentNullException.With.Message.Contains("List"));
        }

    }
}
