namespace IntergalacticTravel.Tests.Mocks
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class MockedResources : Resources
    {
        public MockedResources(uint bronzeCoins, uint silverCoins, uint goldCoins)
            : base(bronzeCoins, silverCoins, goldCoins)
        {

        }
    }
}
