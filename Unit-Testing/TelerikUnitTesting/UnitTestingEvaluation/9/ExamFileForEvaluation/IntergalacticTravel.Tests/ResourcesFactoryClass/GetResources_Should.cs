namespace IntergalacticTravel.Tests.ResourcesFactoryClass
{
    using System;
    using IntergalacticTravel;
    using NUnit.Framework;

    [TestFixture]
    public class GetResources_Should
    {
        /*
         * GetResources should return a newly created Resources object with correctly set up properties
         * (Gold, Bronze and Silver coins), no matter what the order of the parameters is, 
         * when the input string is in the correct format. (Check with all possible cases):
         * 
        Example: The following lines should all create a new Resources object with 40 Bronze Coins, 30 Silver Coins and 20 Gold Coins.
        create resources gold(20) silver(30) bronze(40)
        create resources gold(20) bronze(40) silver(30)
        create resources silver(30) bronze(40) gold(20)
        create resources silver(30) gold(20) bronze(40)
        create resources bronze(40) gold(20) silver(30)
        create resources bronze(40) silver(30) gold(20)
        */

        [TestCase("create resources gold(20) silver(30) bronze(40)", typeof(Resources))]
        [TestCase("create resources gold(20) bronze(40) silver(30)", typeof(Resources))]
        [TestCase("create resources silver(30) bronze(40) gold(20)", typeof(Resources))]
        [TestCase("create resources gold(20) silver(30) bronze(40)", typeof(Resources))]
        [TestCase("create resources bronze(40) gold(20) silver(30)", typeof(Resources))]
        [TestCase("create resources bronze(40) silver(30) gold(20)", typeof(Resources))]
        public void ReturnNewResource_WhenAllObjectsAreParsedSuccessfullyNoMattherTheOrder(string command, Type expectedType)
        {   
            // Arrange
            var resourceFactory = new ResourcesFactory();

            // Act
            var actual = resourceFactory.GetResources(command);

            // Assert
            Assert.IsInstanceOf(expectedType, actual);

        }

        /*GetResources should throw InvalidOperationException, which contains the string "command",
         * when the input string represents an invalid command. (Check with at least 2 different cases).
         */
        [TestCase("create resources x y z")]
        [TestCase("tansta resources a bcreate resources silver(30) gold(20) bronze(40)")]
        [TestCase(null)]
        [TestCase("")]
        public void ThrowInvalidOperationExceptionWithStringCommand_WhenTheInputStringInsInvalidCommand(string command)
        {
            // Arrange
            var resourceFactory = new ResourcesFactory();

            // Act && Assert
            Assert.Throws<InvalidOperationException>(() => resourceFactory.GetResources(command));
        }

        /*
         * GetResources should throw OverflowException,
         * when the input string command is in the correct format,
         * but any of the values that represent the resource amount is larger than uint.MaxValue.
         * (Check with at least 2 different cases)
         */
        [TestCase("create resources silver(10) gold(97853252356623523532) bronze(20)")]
        [TestCase("create resources silver(555555555555555555555555555555555) gold(97853252356623523532999999999) bronze(20)")]
        [TestCase("create resources silver(10) gold(20) bronze(4444444444444444444444444444444444444)")]
        public void ThrowOverflowException_WhenTheInputStringIsCorrect_ButTheValuesOfTheResourceAmountIsLargerThanUintMaxValue(string command)
        {
            // Arrange
            var resourceFactory = new ResourcesFactory();

            // Act && Assert
            Assert.Throws<OverflowException>(() => resourceFactory.GetResources(command));
        }
    }
}