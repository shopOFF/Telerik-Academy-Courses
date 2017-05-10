using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using IntergalacticTravel.Contracts;

namespace IntergalacticTravel.Tests.RFactory
{
    [TestClass]
    public class Constructors_Should
    {
        // 1. GetResources should return a newly created Resources object 
        // with correctly set up properties(Gold, Bronze and Silver coins), 
        // no matter what the order of the parameters is, 
        // when the input string is in the correct format. 
        // (Check with all possible cases): 
         
        [TestMethod]
        public void CreateNewResourceObject_WhenCalldWithAllValidAtributes()
        {
            // Arrange
            var resourcesFactory = new ResourcesFactory();

            // Act and Assert
            Assert.IsInstanceOfType(resourcesFactory, typeof(IResourcesFactory));
        }
    }
}
