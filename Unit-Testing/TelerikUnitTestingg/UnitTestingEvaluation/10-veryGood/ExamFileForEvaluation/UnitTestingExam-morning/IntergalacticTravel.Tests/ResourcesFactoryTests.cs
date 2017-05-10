using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
namespace IntergalacticTravel.Tests
{   [TestFixture]
   public class ResourcesFactoryTests
    {  [Test]
        public void GetResources_WhenParamCommandIsValid_ShouldReturnInstanceOfResources()
        {    //Arrange
            var ResourceFactoryTest = new ResourcesFactory();
            //Act
            var TestResource = ResourceFactoryTest.GetResources("create resources gold(20) silver(30) bronze(40)");
            //Assert
            Assert.IsInstanceOf<Resources>(TestResource);
        }
        [TestCase("create resources gold(20) silver(30) bronze(40)",(uint)20)]
        [TestCase("create resources gold(20) bronze(40) silver(30)", (uint)20)]
        [TestCase("create resources silver(30) bronze(40) gold(20)", (uint)20)]
        [TestCase("create resources silver(30) gold(20) bronze(40)", (uint)20)]
        [TestCase("create resources bronze(40) gold(20) silver(30)", (uint)20)]
        [TestCase("create resources bronze(40) silver(30) gold(20)", (uint)20)]
        public void GetResources_WhenParamCommandIsValid_ShouldReturnInstanceOfResourcesWithCorrectlySetPropertiesOfGold(string command,uint gold)
        {    //Arrange
            var ResourceFactoryTest = new ResourcesFactory();
            //Act
            var TestResource = ResourceFactoryTest.GetResources(command);
            //Assert
            Assert.AreEqual(gold, TestResource.GoldCoins);
            
        }
        [TestCase("create resources gold(20) silver(30) bronze(40)", (uint)30)]
        [TestCase("create resources gold(20) bronze(40) silver(30)", (uint)30)]
        [TestCase("create resources silver(30) bronze(40) gold(20)", (uint)30)]
        [TestCase("create resources silver(30) gold(20) bronze(40)", (uint)30)]
        [TestCase("create resources bronze(40) gold(20) silver(30)", (uint)30)]
        [TestCase("create resources bronze(40) silver(30) gold(20)", (uint)30)]
        public void GetResources_WhenParamCommandIsValid_ShouldReturnInstanceOfResourcesWithCorrectlySetPropertiesOfSilver(string command,uint silver)
        {    //Arrange
            var ResourceFactoryTest = new ResourcesFactory();
            //Act
            var TestResource = ResourceFactoryTest.GetResources(command);
            //Assert
            
            Assert.AreEqual(silver, TestResource.SilverCoins);
          
        }
        [TestCase("create resources gold(20) silver(30) bronze(40)",  (uint)40)]
        [TestCase("create resources gold(20) bronze(40) silver(30)",  (uint)40)]
        [TestCase("create resources silver(30) bronze(40) gold(20)", (uint)40)]
        [TestCase("create resources silver(30) gold(20) bronze(40)",  (uint)40)]
        [TestCase("create resources bronze(40) gold(20) silver(30)",  (uint)40)]
        [TestCase("create resources bronze(40) silver(30) gold(20)",  (uint)40)]
        public void GetResources_WhenParamCommandIsValid_ShouldReturnInstanceOfResourcesWithCorrectlySetPropertiesOfBronze(string command, uint bronze)
        {    //Arrange
            var ResourceFactoryTest = new ResourcesFactory();
            //Act
            var TestResource = ResourceFactoryTest.GetResources(command);
            //Assert
           
            Assert.AreEqual(bronze, TestResource.BronzeCoins);
        }
        [TestCase("create resources x y z")]
        [TestCase("tansta resources a b")]
        [TestCase("absolutelyRandomStringThatMustNotBeAValidCommand ")]
        public void GetResources_WhenParamCommandIsInvalid_ShouldThrowInvalidOperationException(string command)
        {    //Arrange
            var ResourceFactoryTest = new ResourcesFactory();


            //Act & Assert
            Assert.Throws<InvalidOperationException>(() => ResourceFactoryTest.GetResources(command));
        }
        [TestCase("create resources silver(10) gold(97853252356623523532) bronze(20)")]
        [TestCase("create resources silver(555555555555555555555555555555555) gold(97853252356623523532999999999) bronze(20)")]
        [TestCase("create resources silver(10) gold(20) bronze(4444444444444444444444444444444444444) ")]
        public void GetResources_WhenParamCommandIsInvalidLenght_ShouldThrowInvalidOperationException(string command)
        {    //Arrange
            var ResourceFactoryTest = new ResourcesFactory();


            //Act & Assert
            Assert.Throws<OverflowException>(() => ResourceFactoryTest.GetResources(command));
        }

    }
}
