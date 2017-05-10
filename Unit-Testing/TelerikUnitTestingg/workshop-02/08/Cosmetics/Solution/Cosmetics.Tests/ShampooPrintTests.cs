using System;
using NUnit.Framework;

using Cosmetics.Common;
using Cosmetics.Products;
using System.Text;

namespace Cosmetics.Tests
{
    [TestFixture]
    public class ShampooPrintTests
    {
        [Test]
        public void ShampooPrint_WhenInvoked_ShouldReturnStringWithShampooDetailsInCorrectFormat()
        {
            // Arrange
            var shampooTest = new Shampoo("GoodName", "Nivea", 10.2M, GenderType.Men, 300, UsageType.EveryDay);

            var expectedResult = new StringBuilder();   // гледаме си ги от аутпута тия неща или от самия принт метод в самия обект !!!
            expectedResult.AppendLine("- Nivea - GoodName:");
            expectedResult.AppendLine("  * Price: $3060.0");
            expectedResult.AppendLine("  * For gender: Men");
            expectedResult.AppendLine("  * Quantity: 300 ml");
            expectedResult.Append("  * Usage: EveryDay");

            // Act
            var executionResultShampoo = shampooTest.Print();

            // Assert
            Assert.AreEqual(expectedResult.ToString(), executionResultShampoo);
           
        }
    }
}
