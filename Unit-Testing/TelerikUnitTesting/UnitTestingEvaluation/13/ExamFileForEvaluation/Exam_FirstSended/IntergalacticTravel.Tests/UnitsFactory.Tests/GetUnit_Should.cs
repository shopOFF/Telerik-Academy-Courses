namespace IntergalacticTravel.Tests.UnitsFactory.Tests
{
    using Exceptions;
    using NUnit.Framework;
    using IntergalacticTravel;

    [TestFixture]
    public class GetUnit_Should
    {
        [Test]
        public void ReturnNewProcyonUnit_WhenValidCommandIsPassed()
        {
            //Arrange
            string command = "create unit Procyon Gosho 1";

            var unitFactory = new UnitsFactory();

            //Act
            var actualUnit = unitFactory.GetUnit(command);

            //Assert
            Assert.IsInstanceOf(typeof(Procyon), actualUnit);
        }

        [Test]
        public void ReturnNewLuytenUnit_WhenValidCommandIsPassed()
        {
            //Arrange
            string command = "create unit Luyten Pesho 2";

            var unitFactory = new UnitsFactory();

            //Act
            var actualUnit = unitFactory.GetUnit(command);

            //Assert
            Assert.IsInstanceOf(typeof(Luyten), actualUnit);
        }

        [Test]
        public void ReturnNewLacailleUnit_WhenValidCommandIsPassed()
        {
            //Arrange
            string command = "create unit Lacaille Tosho 3";

            var unitFactory = new UnitsFactory();

            //Act
            var actualUnit = unitFactory.GetUnit(command);

            //Assert
            Assert.IsInstanceOf(typeof(Lacaille), actualUnit);
        }

        [TestCase("CreateMOreUnitsSunitLacailleToshohodwini 3")]
        [TestCase("MoveToTheDark uniteeeeLacailleTosho4543")]

        public void ThrowInvalidUnitCreationCommandException_WhenTheCommandPassedIsNotInTheValidFormat(string command)
        {
            //Arrange
            var unitFactory = new UnitsFactory();

            //Act and Assert
            Assert.Throws<InvalidUnitCreationCommandException>(() => unitFactory.GetUnit(command));
        }
    }
}
