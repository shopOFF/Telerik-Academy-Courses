using IntergalacticTravel.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntergalacticTravel.Tests.Mocks
{
    internal class MockedTeleportStation : TeleportStation
    {
        private new IResources resources;

        public MockedTeleportStation(IBusinessOwner owner, IEnumerable<IPath> galacticMap, ILocation location) : base(owner, galacticMap, location)
        {
            this.Resources = resources;
        }

        public IResources Resources
        {
            get
            {
                return this.resources;
            }
            set
            {
                this.resources = value;
            }
        } 
    }
}
