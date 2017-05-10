using System;
using NUnit.Framework;
using Cosmetics.Common;
using Moq;

namespace Cosmetics.Tests
{
    [TestFixture]
    public class ValidatorTests
    {
        [Test]
        public void CheckIfNullMethod_ShouldThrowNullReferenceException_WhenObjectIsNull()
        {
            //object objectToTest = null;
                                                                        //objectToTest  - ето така и му подаваме тука... или направо, като доло му бухаме null и готово
            Assert.Throws<NullReferenceException>(() => Validator.CheckIfNull(null));
        }

        [Test]
        public void CheckIfNullMethod_ShouldNotThrowNullReferenceException_WhenObjectIsNotNull()
        {
            // Arrange
            var checkIfNotNullTest = new Object();

            // Act && Assert
            Assert.DoesNotThrow(() => Validator.CheckIfNull(checkIfNotNullTest));
        }

        [Test]
        public void CheckIfStringIsNullOrEmptyMethod_ShouldThrowNullReferenceException_WhenTextIsNullOrEmpty()
        {
            Assert.Throws<NullReferenceException>(() => Validator.CheckIfStringIsNullOrEmpty(null));
        }

        [Test]
        public void CheckIfStringIsNullOrEmpty_ShouldNotThrowException_WhenTextIsNotNullOrEmpty()
        {
            // Arrange
            var textToTest = "Testing the method";

            // Act && Assert
            Assert.DoesNotThrow(() => Validator.CheckIfStringIsNullOrEmpty(textToTest));
        }

        [Test]
        public void CheckIfStringLengthIsValidMethod_ShouldThrowIndexOutOfRangeException_WhenTextLengthIsNotInTheValidRange()
        {
            // Arrange
            var textToTest = "Te";
            var minTextLength = 3;
            var maxTextLength = 10;

            // Act && Assert
            Assert.Throws<IndexOutOfRangeException>(() => Validator.CheckIfStringLengthIsValid(textToTest, maxTextLength, minTextLength));
        }

        [TestCase(4, 25,"This is some text to test")]
        [TestCase(4, 27,"Some other text to test")]
        [TestCase(4, 20, "Other text to test")]
        [TestCase(3, 18,"nee")]

        public void CheckIfStringLengthIsValidMethod_ShouldNotThrowIndexOutOfRangeException_WhenTextLengthIsInTheValidRange(int minTextLength,int maxTextLength, string textToTest)
        {
            Assert.DoesNotThrow(() => Validator.CheckIfStringLengthIsValid(textToTest, maxTextLength, minTextLength));
        }


    }
}
