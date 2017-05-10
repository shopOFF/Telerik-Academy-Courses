using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using IntergalacticTravel.Contracts;

namespace IntergalacticTravel.Tests
{
    [TestClass]
    public class GetResources_Should
    {
        /*
         * Could be a new cs file GetResources_Should
         */
        // 1. GetResources should return a newly created Resources object 
        // with correctly set up properties(Gold, Bronze and Silver coins), 
        // no matter what the order of the parameters is, 
        // when the input string is in the correct format. 
        // (Check with all possible cases): 

        //create resources gold(20) silver(30) bronze(40)
        [TestMethod]
        public void ReturnResourceObjectWithAllPropertiesCorrectlySet_WhenCommandAtribiteIsInCorrectFormat()
        {
            // Arrange
            string command = "create resources gold(20) silver(30) bronze(40)";
            uint bronzeCoins = 40;
            uint silverCoins =30;
            uint goldCoins = 20;

            var resourcesFactory = new ResourcesFactory();
            var expectedReseouces = new Resources(bronzeCoins, silverCoins, goldCoins);

            // Act
            IResources resources = resourcesFactory.GetResources(command);

            // Act and Assert
            Assert.IsTrue(expectedReseouces.IsEqualTo(resources));
        }

        // TODO create resources gold(20) bronze(40) silver(30)
        [TestMethod]
        public void ReturnResourceObjectWithAllPropertiesCorrectlySet_WhenCommandAtribiteIsInCorrectFormatGBS()
        {
            // Arrange
            string command = "create resources gold(20) bronze(40) silver(30)";
            uint bronzeCoins = 40;
            uint silverCoins = 30;
            uint goldCoins = 20;

            var resourcesFactory = new ResourcesFactory();
            var expectedReseouces = new Resources(bronzeCoins, silverCoins, goldCoins);

            // Act
            IResources resources = resourcesFactory.GetResources(command);

            // Act and Assert
            Assert.IsTrue(expectedReseouces.IsEqualTo(resources));
        }

        // TODO create resources silver(30) bronze(40) gold(20)
        [TestMethod]
        public void ReturnResourceObjectWithAllPropertiesCorrectlySet_WhenCommandAtribiteIsInCorrectFormatSBG()
        {
            // Arrange
            string command = "create resources silver(30) bronze(40) gold(20)";
            uint bronzeCoins = 40;
            uint silverCoins = 30;
            uint goldCoins = 20;

            var resourcesFactory = new ResourcesFactory();
            var expectedReseouces = new Resources(bronzeCoins, silverCoins, goldCoins);

            // Act
            IResources resources = resourcesFactory.GetResources(command);

            // Act and Assert
            Assert.IsTrue(expectedReseouces.IsEqualTo(resources));
        }

        // TODO create resources silver(30) gold(20) bronze(40)
        [TestMethod]
        public void ReturnResourceObjectWithAllPropertiesCorrectlySet_WhenCommandAtribiteIsInCorrectFormatSGB()
        {
            // Arrange
            string command = "create resources silver(30) gold(20) bronze(40)";
            uint bronzeCoins = 40;
            uint silverCoins = 30;
            uint goldCoins = 20;

            var resourcesFactory = new ResourcesFactory();
            var expectedReseouces = new Resources(bronzeCoins, silverCoins, goldCoins);

            // Act
            IResources resources = resourcesFactory.GetResources(command);

            // Act and Assert
            Assert.IsTrue(expectedReseouces.IsEqualTo(resources));
        }

        // TODO create resources bronze(40) gold(20) silver(30)
        [TestMethod]
        public void ReturnResourceObjectWithAllPropertiesCorrectlySet_WhenCommandAtribiteIsInCorrectFormatBGS()
        {
            // Arrange
            string command = "create resources bronze(40) gold(20) silver(30)";
            uint bronzeCoins = 40;
            uint silverCoins = 30;
            uint goldCoins = 20;

            var resourcesFactory = new ResourcesFactory();
            var expectedReseouces = new Resources(bronzeCoins, silverCoins, goldCoins);

            // Act
            IResources resources = resourcesFactory.GetResources(command);

            // Act and Assert
            Assert.IsTrue(expectedReseouces.IsEqualTo(resources));
        }
        
        // TODO create resources bronze(40) silver(30) gold(20)
        [TestMethod]
        public void ReturnResourceObjectWithAllPropertiesCorrectlySet_WhenCommandAtribiteIsInCorrectFormatBSG()
        {
            // Arrange
            string command = "create resources bronze(40) silver(30) gold(20)";
            uint bronzeCoins = 40;
            uint silverCoins = 30;
            uint goldCoins = 20;

            var resourcesFactory = new ResourcesFactory();
            var expectedReseouces = new Resources(bronzeCoins, silverCoins, goldCoins);

            // Act
            IResources resources = resourcesFactory.GetResources(command);

            // Act and Assert
            Assert.IsTrue(expectedReseouces.IsEqualTo(resources));
        }


        /*
         * Could be a new cs file GetResources_ShouldThrow_InvalidOperationException.cs
         */
        // - GetResources should throw InvalidOperationException, 
        // which contains the string "command", when the input string represents an invalid command. 
        // (Check with at least 2 different cases).   

        // TODO create resources x y z
        [TestMethod]
        public void ThrowInvalidOperationException_WhenCreadedWithTheInvalidCommandAtributeXYZ()
        {
            // Arrange
            string invalidCommand = "create resources x y z"; 
            var resourcesFactory = new ResourcesFactory();

            // Act
            //IResources resources = resourcesFactory.GetResources(invalidCommand);

            // Act and Assert
            Assert.ThrowsException<InvalidOperationException>(() => resourcesFactory.GetResources(invalidCommand));
        }
        // TODO tansta resources a b
        // TODO absolutelyRandomStringThatMustNotBeAValidCommand

        /*
         * Could be a new cs file GetResources_ShouldThrow_OverflowException.cs
         */
        // - GetResources should throw OverflowException, 
        // when the input string command is in the correct format, 
        // but any of the values that represent the resource amount is 
        // larger than uint.MaxValue. (Check with at least 2 different cases)  

        // Create resources silver(10) gold(97853252356623523532) bronze(20)
        [TestMethod]
        public void ThrowOverflowException_WhenCreadedWithTheOverflowGoldValue()
        {
            // Arrange
            string overflowCommand = "create resources silver(10) gold(97853252356623523532) bronze(20)";
            var resourcesFactory = new ResourcesFactory();

            // Act and Assert
            Assert.ThrowsException<OverflowException>(() => resourcesFactory.GetResources(overflowCommand));
        }

        // Create resources silver(555555555555555555555555555555555) gold(40) bronze(20)
        [TestMethod]
        public void ThrowOverflowException_WhenCreadedWithTheOverflowSilverValue()
        {
            // Arrange
            string overflowCommand = "create resources silver(555555555555555555555555555555555) gold(97853252356623523532999999999) bronze(20)";
            var resourcesFactory = new ResourcesFactory();

            // Act and Assert
            Assert.ThrowsException<OverflowException>(() => resourcesFactory.GetResources(overflowCommand));
        }

        // TODO create resources silver(10) gold(20) bronze(4444444444444444444444444444444444444)
        [TestMethod]
        public void ThrowOverflowException_WhenCreadedWithTheOverflowBronzeValue()
        {
            // Arrange
            string overflowCommand = "create resources silver(10) gold(20) bronze(4444444444444444444444444444444444444)";
            var resourcesFactory = new ResourcesFactory();

            // Act and Assert
            Assert.ThrowsException<OverflowException>(() => resourcesFactory.GetResources(overflowCommand));
        }
    }
}
