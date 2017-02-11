using System;
using NUnit.Framework;

using Moq;
using IntergalacticTravel.Constants;
using IntergalacticTravel.Contracts;
using IntergalacticTravel.Exceptions;
using IntergalacticTravel.Extensions;
using System.Collections.Generic;

namespace IntergalacticTravel.Tests
{
    [TestFixture]
    public class BusinessOwnerTests
    {
        [Test]
        public void CollectProfits_WhenValid_ShouldIncreaseTheOwnerResources()
        {
            var mockedTeleportStation = new Mock<ITeleportStation>();
            
            var businessOwnerTest = new BusinessOwner(1313, "NickName",new List<ITeleportStation> { mockedTeleportStation.Object });

            // TODO:
        }
    }
}
