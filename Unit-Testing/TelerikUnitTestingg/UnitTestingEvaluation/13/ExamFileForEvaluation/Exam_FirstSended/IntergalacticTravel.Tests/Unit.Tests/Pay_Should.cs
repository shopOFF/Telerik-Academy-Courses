namespace IntergalacticTravel.Tests.Unit.Tests
{
    using System;
    using IntergalacticTravel;
    using NUnit.Framework;

    [TestFixture]
    public class Pay_Should
    {
        //1
        [Test]
        public void ThrowNullReferenceException_IfTheObjectPassedIsNull()
        {
           //Arrange
            Resources resources = null;
            Unit unit = new Unit(12345, "unitName");
            
            //Act and Assert
            Assert.Throws<NullReferenceException>(() => unit.Pay(resources));
        }

        //2
        [Test]
        public void DecreaseTheOwnersAmountOfResourcesByTheAmountOfTheCost()
        {
            //Arrange
            
            //Act and Assert
            
        }
    }
}
