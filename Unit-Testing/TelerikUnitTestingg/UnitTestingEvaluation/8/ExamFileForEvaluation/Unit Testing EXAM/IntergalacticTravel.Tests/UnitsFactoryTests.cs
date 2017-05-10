namespace IntergalacticTravel.Tests
{
    using System;
    using Contracts;
    using Exceptions;
    using NUnit.Framework;

    [TestFixture]
    public class UnitsFactoryTests
    {
        public UnitsFactory Factory { get; private set; }

        [SetUp]
        public void BeforeEach()
        {
            this.Factory = new UnitsFactory();
        }

        [Test]
        [TestCase(typeof(Procyon), "Procyon", "Gosho", 1)]
        [TestCase(typeof(Luyten), "Luyten", "Pesho", 2)]
        [TestCase(typeof(Lacaille), "Lacaille", "Tosho", 3)]
        public void GetUnit_ShouldReturnValidInstance_WithValidParameters(Type expectedType, string unitType, string name, int id)
        {
            string command = string.Format("create unit {0} {1} {2}", unitType, name, id);

            IUnit instance = this.Factory.GetUnit(command);

            Assert.IsInstanceOf(expectedType, instance);
        }

        [Test]
        [TestCase("Gosho", "1", "Procyon")]
        [TestCase("1", "Gosho", "Procyon")]
        [TestCase("Procyon", "1", "Gsoho")]
        public void GetUnit_ShouldThrow_WhenParametersOrderIsInvalid(string param1, string param2, string param3)
        {
            string command = string.Format("create unit {0} {1} {2}", param1, param2, param3);

            // Act & Assert
            Assert.Throws<InvalidUnitCreationCommandException>(() => this.Factory.GetUnit(command));
        }

        [Test]
        [TestCase("create Procyon Gosho 1")]
        [TestCase("create unit  Procyon  Gosho 1")]
        [TestCase("create unit   ")]
        [TestCase("")]
        [TestCase(null)]
        public void GetUnit_ShouldThrow_WhenCommandFormatIsInvalid(string invalidCommand)
        {
            Assert.Throws<InvalidUnitCreationCommandException>(() => this.Factory.GetUnit(invalidCommand));
        }
    }
}