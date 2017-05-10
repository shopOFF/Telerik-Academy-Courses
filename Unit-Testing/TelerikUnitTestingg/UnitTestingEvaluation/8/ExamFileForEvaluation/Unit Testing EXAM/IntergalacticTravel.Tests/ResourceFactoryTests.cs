namespace IntergalacticTravel.Tests
{
    using System;
    using System.Linq;
    using IntergalacticTravel.Contracts;
    using NUnit.Framework;

    [TestFixture]
    public class ResourceFactoryTests
    {
        public IResourcesFactory Factory { get; private set; }

        public string ValidCommandFormat { get; private set; }

        [SetUp]
        public void BeforeEach()
        {
            this.Factory = new ResourcesFactory();
            this.ValidCommandFormat = "create resources {0} {1} {2}";
        }

        [Test]
        public void GetResources_ShouldCreateNewResource_WithCorrectParameters_ResourceOrderShouldNotMatter()
        {
            // Arrange
            IResources expected = new Resources(40, 30, 20);

            string[] args =
            {
                "gold(20)",
                "silver(30)",
                "bronze(40)"
            };

            var argsPermutations = Helpers.GetPermutations(args, args.Length);

            // Act (Acts on all possible variations/permutations)
            foreach (var permutation in argsPermutations)
            {
                string[] p = permutation.ToArray();

                string command = string.Format(this.ValidCommandFormat, p[0], p[1], p[2]);

                IResources current = this.Factory.GetResources(command);

                // Assert
                Assert.IsTrue(expected.IsEqualTo(current));
            }
        }

        [Test]
        [TestCase("create resources gold(20) gold(30) gold(40)")]
        [TestCase("create resources gold(20.4) silver(30) bronze(40.05)")]
        [TestCase("create resources 1 2 3")]
        [TestCase("create coins(3) mercury(10) minerals(2)")]
        [TestCase("")]
        [TestCase(null)]
        public void GetResources_ShouldThrow_WithMessage_WhenTheInputFormatIsInvalid(string invalidCommand)
        {
            Assert.That(
                () => this.Factory.GetResources(invalidCommand), Throws.TypeOf<InvalidOperationException>()
                    .With.Message.Contain("command"));
        }

        [Test]
        [TestCase(((double)uint.MaxValue) + 1, 10, 10)]
        [TestCase(10, ((double)uint.MaxValue + 1), 10)]
        [TestCase(10, 10, ((double)uint.MaxValue) + 1)]
        public void GetResources_ShouldThrow_WhenInputHasValue_OutOfAllowedUpperBounds(double gold, double silver, double bronze)
        {
            // Arrange
            string goldString = string.Format("gold({0})", gold);
            string silverString = string.Format("silver({0})", silver);
            string bronzeString = string.Format("bronze({0})", bronze);

            string command = string.Format(
                this.ValidCommandFormat, bronzeString, silverString, goldString);

            // Act & Assert
            Assert.Throws<OverflowException>(() => this.Factory.GetResources(command));
        }
    }
}