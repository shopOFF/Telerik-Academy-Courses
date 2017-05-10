using System;
using NUnit.Framework;
using Moq;

using Cosmetics.Products;
using System.Text;
using System.Collections.Generic;
using Cosmetics.Contracts;

namespace Cosmetics.Tests
{
    [TestFixture]
    public class ShoppingCartTests
    {
        [Test]
        public void AddProduct_WhenProductParamAreValid_ShouldAddProductToList()  // ето така нз дали е достатъчно адекватен тоя тест, но работи!!!
        {
            var mockedProduct = new Mock<IProduct>();
            var shoppingCart = new ShoppingCart();

            shoppingCart.AddProduct(mockedProduct.Object);

            Assert.IsTrue(shoppingCart.ContainsProduct(mockedProduct.Object));

            // един вариант за тестване без МокЮ
            //var product = new Shampoo("some", "other", 10M, GenderType.Women, 100, UsageType.EveryDay);
            //var shoppingCart = new ShoppingCart();

            //shoppingCart.AddProduct(product);

            //Assert.IsTrue(shoppingCart.ContainsProduct(product));
        }

        [Test]
        public void RemoveProduct_WhenProductIsContainedInTheCart_ShouldRemoveProductFromList()  // ето така нз дали е достатъчно адекватен тоя тест, но работи!!!
        {
            // Arrange
            var firstMockedProduct = new Mock<IProduct>();
            var secondMockedProduct = new Mock<IProduct>();
            var thirdMockedProduct = new Mock<IProduct>();

            var shoppingCart = new ShoppingCart();

            shoppingCart.AddProduct(firstMockedProduct.Object);
            shoppingCart.AddProduct(secondMockedProduct.Object);
            shoppingCart.AddProduct(thirdMockedProduct.Object);

            shoppingCart.RemoveProduct(firstMockedProduct.Object);
                                                                 
            // Act & Assert
            Assert.IsFalse(shoppingCart.ContainsProduct(firstMockedProduct.Object));
            // Assert.IsTrue(shoppingCart.ContainsProduct(thirdMockedProduct.Object));
        }

        [Test]
        public void ContainsProduct_WhenProductIsContainedInTheCart_ShouldReturnTrue()  // ето така нз дали е достатъчно адекватен тоя тест, но работи!!!
        {
            // Arrange
            var firstMockedProduct = new Mock<IProduct>();
            var secondMockedProduct = new Mock<IProduct>();

            var shoppingCart = new ShoppingCart();
            
            shoppingCart.AddProduct(firstMockedProduct.Object);
            shoppingCart.AddProduct(secondMockedProduct.Object);

            // Act & Assert
            Assert.IsTrue(shoppingCart.ContainsProduct(firstMockedProduct.Object));

            // МОЖЕМ ДА СИ НАПРАВИМ Act & Assert -А  И ЕТО ТАКА !!!! СЪС Assert.AreEqual И ТН... И ДА СИ ГИ РАЗДЕЛИМ, МАЛКО ПО-ЧЕТИМО СТАВА !!!

            // Act
            //var executionResult = shoppingCart.ContainsProduct(mockedProduct.Object);

            // Assert
            //Assert.AreEqual(true, executionResult);
        }

        [Test]
        public void TotalPrice_WhenProductsAreContainedInTheCart_ShouldReturnTotalSumOfTheirPrices()  // ето така нз дали е достатъчно адекватен тоя тест, но работи!!!
        {
            // Arrange
            var firstMockedProduct = new Mock<IProduct>();
            var secondMockedProduct = new Mock<IProduct>();

            var shoppingCart = new ShoppingCart();

            firstMockedProduct.Setup(p => p.Price).Returns(10M);  // и тука слагаме М за всеки случай, работи и без М отзад въпреки, че е децимал!
            secondMockedProduct.Setup(p => p.Price).Returns(20M);

            shoppingCart.AddProduct(firstMockedProduct.Object);
            shoppingCart.AddProduct(secondMockedProduct.Object);

            // Act
            var executionResult = shoppingCart.TotalPrice();  // може директно да си го сложим това в Асърта, ако искаме

            // Assert
            Assert.AreEqual(30, executionResult);  // тука може да се наложи да е 30M стойността защото е decimal тази която ще ни върне, но в случая минава и само с 30 
        }

        [Test]
        public void TotalPrice_WhenThereAreNoProductsInTheCart_ShouldReturn0()  // ето така нз дали е достатъчно адекватен тоя тест, но работи!!!
        {
            // Arrange
            var shoppingCart = new ShoppingCart();

            // Act & Assert
            Assert.AreEqual(0M, shoppingCart.TotalPrice());  
        }
    }
}
