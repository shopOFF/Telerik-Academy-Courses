namespace IntergalacticTravel.Tests
{
    using System;
    using NUnit.Framework;
    using IntergalacticTravel.Contracts;
    using Moq;
    using IntergalacticTravel.Tests.Mocks;

    [TestFixture]
    public class UnitTests
    {
        [Test]
        public void Pay_ShouldThrowNullReferenceException_WhenObjectPassedIsNull()
        {
            //Assert
            var identificationNumber = 1;
            var nickName = "nickName";
            var unit = new Unit(identificationNumber, nickName);

            //Act && Assert
            Assert.Throws<NullReferenceException>(() => unit.Pay(null));
        }

        //[Test]
        //public void Pay_ShouldThrowReduceResourcesCorrectly()
        //{
        //    //Assert
        //    var initialResources = new Mock<IResources>();
        //    initialResources.SetupGet(r => r.BronzeCoins).Returns((uint)20);
        //    initialResources.SetupGet(r => r.SilverCoins).Returns((uint)20);
        //    initialResources.SetupGet(r => r.GoldCoins).Returns((uint)20);

        //    var identificationNumber = 1;
        //    var nickName = "nickName";
        //    var unit = new Unit(identificationNumber, nickName);
        //    unit.Resources

        //    //Act && Assert
        //    //Assert.Throws<NullReferenceException>(() => unit.Pay(null));
        //}

        [Test]
        public void Pay_ShouldReturnResourceObject_WhenCostObjIsValid()
        {
            //Assert

            var costObject = new MockedResources((uint)20, (uint)20, (uint)20);

            var identificationNumber = 1;
            var nickName = "nickName";
            var unit = new Unit(identificationNumber, nickName);

            //Act 
            var result = unit.Pay(costObject);

            //Assert
            Assert.IsInstanceOf<IResources>(result);
        }

        [Test]
        public void Pay_ShouldReturnResourceObjectWithCorrectValues_WhenCostObjIsValid()
        {
            //Assert

            var costObject = new MockedResources((uint)20, (uint)20, (uint)20);

            var identificationNumber = 1;
            var nickName = "nickName";
            var unit = new Unit(identificationNumber, nickName);

            //Act 
            var result = unit.Pay(costObject);

            //Assert
            Assert.AreEqual(costObject.BronzeCoins, result.BronzeCoins);
            Assert.AreEqual(costObject.SilverCoins, result.SilverCoins);
            Assert.AreEqual(costObject.GoldCoins, result.GoldCoins);
        
        }

    }
}
