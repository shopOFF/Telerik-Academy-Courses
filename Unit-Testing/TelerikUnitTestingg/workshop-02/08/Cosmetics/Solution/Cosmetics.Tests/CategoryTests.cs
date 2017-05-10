using System;
using NUnit.Framework;

using Cosmetics.Contracts;
using Cosmetics.Products;
using System.Text;
using Moq;
using System.Collections.Generic;

namespace Cosmetics.Tests
{
    [TestFixture]
    public class CategoryTests
    {
        [Test]
        public void CategoryPrint_WhenInvoked_ShouldReturnStringWithCategoryDetailsInCorrectFormat()
        {
            // Arrange
            var categoryTest = new Category("SomeName");

            var expectedResult = new StringBuilder();   // гледаме си ги от аутпута тия неща или от самия принт метод в самия обект !!!
            expectedResult.Append("SomeName category - 0 products in total");

            var executionResultCategory = categoryTest.Print();

            // Assert
            Assert.AreEqual(expectedResult.ToString(), executionResultCategory);

        }

        [Test]
        public void AddCosmetics_WhenPassedCosmeticsAreValid_ShouldAddProductToList()
        {
            // Arrange
            var categoryTest = new Category("Pesho");

            var firstMockedProduct = new Mock<IProduct>();
            var secondMockedProduct = new Mock<IProduct>();

            categoryTest.AddCosmetics(firstMockedProduct.Object);
            categoryTest.AddCosmetics(secondMockedProduct.Object);

            var expectedResult = new StringBuilder();
            expectedResult.Append("Pesho category - 2 products in total");

            var executionResultCategory = categoryTest.Print();

            // Assert
            Assert.AreEqual(expectedResult.ToString(), executionResultCategory);
        }

        [Test]
        public void RemoveCosmetics_WhenCategoryHasValidCosmetics_ShouldRemoveProductFromList()
        {
            // Arrange
            var categoryTest = new Category("Pesho");

            var firstMockedProduct = new Mock<IProduct>();
            var secondMockedProduct = new Mock<IProduct>();
            var thirdMockedProduct = new Mock<IProduct>();
            var fourthMockedProduct = new Mock<IProduct>();

            categoryTest.AddCosmetics(firstMockedProduct.Object);
            categoryTest.AddCosmetics(secondMockedProduct.Object);
            categoryTest.AddCosmetics(thirdMockedProduct.Object);
            categoryTest.AddCosmetics(fourthMockedProduct.Object);

            categoryTest.RemoveCosmetics(secondMockedProduct.Object);

            var expectedResult = new StringBuilder();
            expectedResult.Append("Pesho category - 3 products in total");

            var executionResultCategory = categoryTest.Print();

            // Assert
            Assert.AreEqual(expectedResult.ToString(), executionResultCategory);
        }
    }
}
