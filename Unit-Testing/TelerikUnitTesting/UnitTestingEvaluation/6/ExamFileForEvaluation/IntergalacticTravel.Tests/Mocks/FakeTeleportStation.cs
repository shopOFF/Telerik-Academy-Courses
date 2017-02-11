using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using IntergalacticTravel.Contracts;

namespace IntergalacticTravel.Tests
{
    public class FakeTeleportStation : TeleportStation, ITeleportStation
    {
        //public readonly IResources resources;
        //public readonly IBusinessOwner owner;
        //public readonly ILocation location;
        //public readonly IEnumerable<IPath> galacticMap;

        public FakeTeleportStation(IBusinessOwner owner, IEnumerable<IPath> galacticMap, ILocation location) 
            : base(owner, galacticMap, location)
        {  
        }

        public IResources PayProfits(IBusinessOwner owner)
        {
            throw new NotImplementedException();
        }

        public void TeleportUnit(IUnit unitToTeleport, ILocation targetLocation)
        {
            throw new NotImplementedException();
        }
    }
}
