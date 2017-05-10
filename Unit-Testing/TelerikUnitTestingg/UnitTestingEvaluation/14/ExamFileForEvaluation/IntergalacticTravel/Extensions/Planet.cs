using IntergalacticTravel.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntergalacticTravel.Extensions
{
    public class Planet : IPlanet
    {
        private IGalaxy galaxy;
        private string name;
        private ICollection<IUnit> units;

        public Planet(string name, IGalaxy galaxy)
        {
            this.Name = name;
            this.Galaxy = galaxy;
            this.Units = new List<IUnit>();
        }

        public IGalaxy Galaxy
        {
            get
            {
                return this.galaxy;
            }
            set
            {
                this.galaxy = value;
            }
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                this.name = value;
            }
        }

        public ICollection<IUnit> Units
        {
            get
            {
                return this.units;
            }
            set
            {
                this.units = value;
            }
        }
    }
}
