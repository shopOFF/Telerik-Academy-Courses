using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Moq;
using NUnit.Framework;
namespace IntergalacticTravel.Tests
{   [TestFixture]
  public  class UnitTest
    {
        [Test]
        public void Pay_WhenPassedParameterIsNull_ShouldThrowNullReferenceException()
        {
            var TestUnit = new Unit(12, "Goshko");

            Assert.Throws<NullReferenceException>(() => TestUnit.Pay(null));
        }
        [Test]
        public void Pay_WhenPassedCorectParameter_ShouldDecreaseOwnersAmountOfResources()
        {
            var TestUnit = new Unit(12, "Goshko");
            var Resource = new Resources(0, 0, 0);
            TestUnit.Pay(Resource);

            Assert.AreEqual(0, TestUnit.Resources.BronzeCoins);

        }
        [Test]
        public void Pay_WhenPassedCorectParameter_ShouldReturnInstanceOfResources()
        {
            var TestUnit = new Unit(12, "Goshko");
            var Resource = new Resources(0, 0, 0);
           var result = TestUnit.Pay(Resource);

            Assert.IsInstanceOf<Resources>(result);

        }
    }
}
