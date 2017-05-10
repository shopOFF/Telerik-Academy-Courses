namespace IntergalacticTravel.Tests.TeleportStationClass.Fake
{
    using Contracts;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Location : ILocation
    {
        public IGPSCoordinates Coordinates
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public IPlanet Planet
        {
            get
            {
                throw new NotImplementedException();
            }
        }
    }
}
