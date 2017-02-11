using IntergalacticTravel.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntergalacticTravel.Extensions
{
    public class Galaxy : IGalaxy
    {
        private string name;
        private ICollection<IPlanet> planets;

        public Galaxy(string name)
        {
            this.Name = name;
            this.planets = new List<IPlanet>();
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

        public ICollection<IPlanet> Planets
        {
            get
            {
                return this.planets;
            }
        }
    }
}
