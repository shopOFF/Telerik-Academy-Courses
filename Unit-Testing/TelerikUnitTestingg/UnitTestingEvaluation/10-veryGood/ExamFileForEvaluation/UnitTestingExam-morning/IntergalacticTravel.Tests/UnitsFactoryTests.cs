using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Moq;
using IntergalacticTravel.Exceptions;

namespace IntergalacticTravel.Tests
{      [TestFixture]
  public   class UnitsFactoryTests
    {     [Test]
        public void GetUnit_WhenValidCommandIsPassed_ShouldReturnNewProcyonUnit()
        {  //Arrange
            var UnitFactoryTest = new UnitsFactory();
            //Act
            var ActualResult = UnitFactoryTest.GetUnit("create unit Procyon Gosho 1");
            //Assert
            Assert.IsInstanceOf<Procyon>(ActualResult);
        }
        [Test]
        public void GetUnit_WhenValidCommandIsPassed_ShouldReturnNewLuytenUnit()
        {    //Arrange
            var UnitFactoryTest = new UnitsFactory();
            //Act
            var ActualResult = UnitFactoryTest.GetUnit("create unit Luyten Pesho 2");
            //Assert
            Assert.IsInstanceOf<Luyten>(ActualResult);
        }
        [Test]
        public void GetUnit_WhenValidCommandIsPassed_ShouldReturnNewLacailleUnit()
        {    //Arrange
            var UnitFactoryTest = new UnitsFactory();
            //Act
            var ActualResult = UnitFactoryTest.GetUnit("create unit Lacaille Tosho 3");
            //Assert
            Assert.IsInstanceOf<Lacaille>(ActualResult);
        }
        [TestCase("")]
        [TestCase(null)]
        [TestCase("Create unit luyten pesho 3201")]
        [TestCase("Create  unit Lacaille Tosho 3")]
        [TestCase("create  Unit Lacaille Tosho 3")]
        [TestCase("create  unit lacaille Tosho 3")]
        [TestCase("RandomString Random String")]
        [TestCase("unit Lacaille create Tosho 3")]
        public void GetUnit_WhenInvalidCommandIsPassed_ShouldThrownvalidUnitCreationCommandException(string command)
        {    //Arrange
            var UnitFactoryTest = new UnitsFactory();
            //Act

            //Assert
            Assert.Throws<InvalidUnitCreationCommandException>(() => UnitFactoryTest.GetUnit(command));
        }
    }
}
