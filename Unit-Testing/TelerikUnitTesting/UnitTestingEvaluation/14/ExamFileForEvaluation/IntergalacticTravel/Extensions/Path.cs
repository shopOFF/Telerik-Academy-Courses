using IntergalacticTravel.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntergalacticTravel.Extensions
{
    public class Path : IPath
    {
        private IResources cost;
        private ILocation targetLocation;

        public Path(IResources cost, ILocation targetLocation)
        {
            this.Cost = cost;
            this.TargetLocation = targetLocation;
        }

        public IResources Cost
        {
            get
            {
                return this.cost;
            }
            set
            {
                this.cost = value;
            }
        }

        public ILocation TargetLocation
        {
            get
            {
                return this.targetLocation;
            }
            set
            {
                this.targetLocation = value;
            }
        }
    }
}
