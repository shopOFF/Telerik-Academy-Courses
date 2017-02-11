using System;
using NUnit.Framework;

using Cosmetics.Common;
using Cosmetics.Products;
using System.Text;
using System.Collections.Generic;

namespace Cosmetics.Tests
{
    [TestFixture]
    public class ToothpastePrintTests
    {
        [Test]
        public void ToothpastePrint_WhenInvoked_ShouldReturnStringWithToothpasteDetailsInCorrectFormat()
        {
            // Arrange
            var toothpasteTest = new Toothpaste("GoodName", "Nivea", 10.2M, GenderType.Men, new List<string>() { "Sodium", "OtherIng"});

            var expectedResult = new StringBuilder();   // гледаме си ги от аутпута тия неща или от самия принт метод в самия обект !!!
            expectedResult.AppendLine("- Nivea - GoodName:");
            expectedResult.AppendLine("  * Price: $10.2");
            expectedResult.AppendLine("  * For gender: Men");
            expectedResult.Append("  * Ingredients: Sodium, OtherIng");

            // Act
            var executionResultToothpaste = toothpasteTest.Print();

            // Assert
            Assert.AreEqual(expectedResult.ToString(), executionResultToothpaste);
        }
    }
}
