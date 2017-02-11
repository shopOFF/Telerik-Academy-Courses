namespace IntergalacticTravel.Tests.ResourcesFactoryClass.Mock
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using IntergalacticTravel;

    public class MockedResourcesFactory : ResourcesFactory
    {
        private readonly IDictionary<char, uint> resourcesParameters;

        public IDictionary<char, uint> ResourcesParameters
        {
            get
            {
                return resourcesParameters;
            }
        }
    }
}
