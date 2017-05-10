using IntergalacticTravel.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntergalacticTravel.Extensions
{
    public class Location : ILocation
    {
        private IGPSCoordinates coordinates;
        private IPlanet planet;

        public Location(IPlanet planet, IGPSCoordinates coordinates)
        {
            this.Planet = planet;
            this.Coordinates = coordinates;
        }

        public IGPSCoordinates Coordinates
        {
            get
            {
                return this.coordinates;
            }
            set
            {
                this.coordinates = value;
            }
        }

        public IPlanet Planet
        {
            get
            {
                return this.planet;
            }
            set
            {
                this.planet = value;
            }
        }
    }
}
