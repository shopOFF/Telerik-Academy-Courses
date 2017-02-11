using IntergalacticTravel.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntergalacticTravel.Extensions
{
    public class GPSCoordinates : IGPSCoordinates
    {
        private double latitude;
        private double longtitude;

        public GPSCoordinates(double latitude, double longtitude)
        {
            this.Latitude = latitude;
            this.Longtitude = longtitude;
        }

        public double Latitude
        {
            get
            {
                return this.latitude;
            }
            set
            {
                this.latitude = value;
            }
        }

        public double Longtitude
        {
            get
            {
                return this.longtitude;
            }
            set
            {
                this.longtitude = value;
            }
        }
    }
}
