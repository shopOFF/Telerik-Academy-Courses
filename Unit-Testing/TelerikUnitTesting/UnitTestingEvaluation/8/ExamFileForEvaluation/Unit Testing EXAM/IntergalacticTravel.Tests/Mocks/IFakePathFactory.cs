using System.Collections.Generic;
using IntergalacticTravel.Contracts;

namespace IntergalacticTravel.Tests.Mocks
{
    public interface IFakePathFactory
    {
        ILocation GetLocation();
        ILocation GetLocation(string galaxy, string location);
        IEnumerable<IPath> GetMap();
        IPath GetPath(string planet);
    }
}