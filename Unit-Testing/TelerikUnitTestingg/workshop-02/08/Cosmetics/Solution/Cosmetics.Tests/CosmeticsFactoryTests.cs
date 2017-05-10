using System;
using NUnit.Framework;
using System.Collections.Generic;

using Cosmetics.Common;
using Cosmetics.Contracts;
using Cosmetics.Products;
using Cosmetics.Engine;
using System.Linq;

namespace Cosmetics.Tests
{
    [TestFixture]
    public class CosmeticsFactoryTests
    {
        [TestCase("")]
        [TestCase(null)]
        public void CreateShampoo_WhenNameIsNullOrEmpty_ShouldThrowNullReferenceException(string invalidNameParam)
        {
            var cosmeticsFactoryTest = new CosmeticsFactory();

            Assert.Throws<NullReferenceException>(() => cosmeticsFactoryTest.CreateShampoo(invalidNameParam, "Nivea", 10.2M, GenderType.Men, 300, UsageType.EveryDay));
        }

        [TestCase("This shampoo name is to long, so it's invalid")]
        [TestCase("No")]
        public void CreateShampoo_WhenNameParametersLengthIsOutOfRange_ShouldThrowIndexOutOfRangeException(string invalidNameParam)
        {
            var cosmeticsFactoryTest = new CosmeticsFactory();

            Assert.Throws<IndexOutOfRangeException>(() => cosmeticsFactoryTest.CreateShampoo(invalidNameParam, "Nivea", 10.2M, GenderType.Men, 300, UsageType.EveryDay));
        }

        [TestCase("")]
        [TestCase(null)]
        public void CreateShampoo_WhenBrandIsNullOrEmpty_ShouldThrowNullReferenceException(string invalidBrandParam)
        {
            var cosmeticsFactoryTest = new CosmeticsFactory();

            Assert.Throws<NullReferenceException>(() => cosmeticsFactoryTest.CreateShampoo("GreatName", invalidBrandParam, 10.2M, GenderType.Men, 300, UsageType.EveryDay));
        }

        [TestCase("n")]
        [TestCase("This shampoo brand is to long, so it's invalid")]
        public void CreateShampoo_WhenBrandParametersLengthIsOutOfRange_ShouldThrowIndexOutOfRangeException(string invalidBrandParam)
        {
            var cosmeticsFactoryTest = new CosmeticsFactory();

            Assert.Throws<IndexOutOfRangeException>(() => cosmeticsFactoryTest.CreateShampoo("GreatName", invalidBrandParam, 10.2M, GenderType.Men, 300, UsageType.EveryDay));
        }


        [Test]
        public void CreatShampoo_WhenAllParametersAreValid_ShouldReturnNewShampoo()
        {
            // Arrange
            var cosmeticsFactoryTest = new CosmeticsFactory();

            // Act
            var executionResultShampoo = cosmeticsFactoryTest.CreateShampoo("GreatName", "GoodBrand", 8.20M, GenderType.Unisex, 350, UsageType.Medical);

            // Assert                                                                                   // с айшампуу за по голяма гъвкавост
            Assert.IsInstanceOf<Shampoo>(executionResultShampoo); // може и така Assert.IsInstanceOf<IShampoo>(executionResultShampoo);
                                                                  //може и с този синтаксис     Assert.IsInstanceOf(typeof(Shampoo), executionResultShampoo);
        }

        [TestCase("")]
        [TestCase(null)]

        public void CreateCategory_WhenNameParameterIsNullOrEmpty_ShouldThrowNullReferenceException(string invalidNameParam)
        {
            var cosmeticsFactoryTest = new CosmeticsFactory();

            Assert.Throws<NullReferenceException>(() => cosmeticsFactoryTest.CreateCategory(invalidNameParam));
        }

        [TestCase("This category name is to long, so it's invalid")]
        [TestCase("N")]
        public void CreateCategory_WhenNameParametersLengthIsOutOfRange_ShouldThrowIndexOutOfRangeException(string invalidNameParam)
        {
            var cosmeticsFactoryTest = new CosmeticsFactory();

            Assert.Throws<IndexOutOfRangeException>(() => cosmeticsFactoryTest.CreateCategory(invalidNameParam));
        }

        [Test]

        public void CreatCategory_WhenAllParametersAreValid_ShouldReturnNewCategory()
        {
            // Arrange
            var cosmeticsFactoryTest = new CosmeticsFactory();
            var categoryNameTest = "GoodName";

            //Act
            var executionResultCategory = cosmeticsFactoryTest.CreateCategory(categoryNameTest);

            // Assert
            Assert.IsInstanceOf<Category>(executionResultCategory);
            // може и Assert.IsInstanceOf<ICategory>(executionResultCategory);  // даже може и по- добре да е
        }

        [TestCase("")]
        [TestCase(null)]
        public void CreateToothpaste_WhenNameIsNullOrEmpty_ShouldThrowNullReferenceException(string invalidNameParam)
        {
            var cosmeticsFactoryTest = new CosmeticsFactory();
            var ingredients = new List<string>() { "Sodium", "OtherIng", "Herbs", "Ing1", "Ing2" }; // това може да си го попълним и директно доло 

            Assert.Throws<NullReferenceException>(() => cosmeticsFactoryTest.CreateToothpaste(invalidNameParam, "Nivea", 10.2M, GenderType.Men, ingredients));
            // може и директно тука да си попълним ето така -
            //Assert.Throws<NullReferenceException>(() => cosmeticsFactoryTest.CreateToothpaste(invalidNameParam, "Nivea", 10.2M, GenderType.Men, new List<string>() { "Sodium", "OtherIng", "Herbs", "Ing1", "Ing2"  }));
        }

        [TestCase("This toothpaste name is to long, so it's invalid")]
        [TestCase("N")]
        public void CreateToothpaste_WhenNameParametersLengthIsOutOfRange_ShouldThrowIndexOutOfRangeException(string invalidNameParam)
        {
            var cosmeticsFactoryTest = new CosmeticsFactory();

            Assert.Throws<IndexOutOfRangeException>(() => cosmeticsFactoryTest.CreateToothpaste(invalidNameParam, "Nivea", 10.2M, GenderType.Men, new List<string>() { "Sodium", "OtherIng", "Herbs", "Ing1", "Ing2" }));
        }

        [TestCase("")]
        [TestCase(null)]
        public void CreateToothpaste_WhenBrandIsNullOrEmpty_ShouldThrowNullReferenceException(string invalidBrandParam)
        {
            var cosmeticsFactoryTest = new CosmeticsFactory();

            Assert.Throws<NullReferenceException>(() => cosmeticsFactoryTest.CreateToothpaste("GreatName", invalidBrandParam, 10.2M, GenderType.Men, new List<string>() { "Sodium", "OtherIng", "Herbs", "Ing1", "Ing2" }));
        }

        [TestCase("This category name is to long, so it's invalid")]
        [TestCase("N")]
        public void CreateToothpaste_WhenBrandParametersLengthIsOutOfRange_ShouldThrowIndexOutOfRangeException(string invalidBrandParam)
        {
            var cosmeticsFactoryTest = new CosmeticsFactory();

            Assert.Throws<IndexOutOfRangeException>(() => cosmeticsFactoryTest.CreateToothpaste("GreatName", invalidBrandParam, 10.2M, GenderType.Men, new List<string>() { "Sodium", "OtherIng", "Herbs", "Ing1", "Ing2" }));
        }

        [Test]
        public void CreatToothpaste_WhenAllParametersAreValid_ShouldReturnNewToothpaste()
        {
            // Arrange
            var cosmeticsFactoryTest = new CosmeticsFactory();

            // Act
            var executionResultToothpaste = cosmeticsFactoryTest.CreateToothpaste("GreatName", "GoodBrand", 8.20M, GenderType.Unisex, new List<string>() { "Sodium", "OtherIng", "Herbs", "Ing1", "Ing2" });

            // Assert                                             
            Assert.IsInstanceOf<Toothpaste>(executionResultToothpaste);  // Assert.IsInstanceOf<IToothpaste>(executionResultToothpaste);

        }


        [TestCase("Luk", "Chesun")]
        [TestCase("ZelenchukovaSupa", "Chesun")]
        [TestCase("Chesun", "Luk")]
        [TestCase("Chesun", "ZelenchukovaSupa")]
        public void CreateToothpaste_WhenIngredientsHaveInvalidLenght_ShouldThrowIndexOutOfRangeException(params string[] ingredients)
        {
            // Arrange
            var cosmeticFactory = new CosmeticsFactory();

            // Act && Assert
            Assert.Throws<IndexOutOfRangeException>(() => cosmeticFactory.CreateToothpaste("Gosho", "example", 10M, GenderType.Unisex, ingredients.ToList()));
        }

        [Test]
        public void CreatShoppingCart_WhenInvoked_ShouldReturnNewShoppingCart()
        {
            // Arrange
            var cosmeticsFactoryTest = new CosmeticsFactory();

            // Act
            var executionResultShoppingCart = cosmeticsFactoryTest.CreateShoppingCart();

            // Assert                                             
            Assert.IsInstanceOf<ShoppingCart>(executionResultShoppingCart);  // Assert.IsInstanceOf<IShoppingCart>(executionResultShoppingCart);

        }
    }
}
