using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Dealership.Contracts;
using Dealership.Common;

namespace Dealership.Models
{
    public class Truck : Vehicle, IVehicle, ITruck
    {
        private int weightCapacity;

        public Truck(string make, string model, decimal price,int weightCapacity) 
            : base(make, model, price)
        {
            this.WeightCapacity = weightCapacity;
        }

        public int WeightCapacity
        {
            get { return this.weightCapacity; }
            set
            {
                //Validator.ValidateIntRange(value, Constants.MinCapacity, Constants.MaxCapacity, Constants.NumberMustBeBetweenMinAndMax);

                this.weightCapacity = value;
            }
        }
    }
}
