namespace IntergalacticTravel.Tests.ResourcesFactory.Tests
{
    using Contracts;
    using Moq;
    using NUnit.Framework;
    using IntergalacticTravel;

    [TestFixture]
    public class GetResources_Should
    {
        [TestCase("gold(20) silver(30) bronze(40)")]
        [TestCase("gold(20) bronze(40) silver(30)")]
        [TestCase("silver(30) bronze(40) gold(20)")]
        [TestCase("silver(30) gold(20) bronze(40)")]
        [TestCase("bronze(40) gold(20) silver(30)")]
        [TestCase("bronze(40) silver(30) gold(20)")]
        public void ReturnNewlyCreatedResourcesObject_WithCorrectlySetUpProperties(string command)
        {
        }

        [TestCase("create resources x y z")]
        [TestCase("tansta resources a b")]
        public void ThrowInvalidOperationException_WhichContainsTheStringComman_WhenTheInputIsInvalid(string command)
        {
            var resourceFactory = new ResourcesFactory();

           Assert.That(() => resourceFactory.GetResources(command), Throws.InvalidOperationException.With.Message.Contains("command"));
        }



    }
}

