using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Dealership.Contracts;
using Dealership.Common;

namespace Dealership.Models
{
    public class Motorcycle : Vehicle, IVehicle, IMotorcycle
    {
        private string category;

        public Motorcycle(string make, string model, decimal price, string category)
            : base(make, model, price)
        {
            this.Category = category;
        }

        public string Category
        {
            get { return this.category; }
            private set
            {

                //Validator.ValidateIntRange(value.Length, Constants.MinCategoryLength, Constants.MaxCategoryLength, Constants.NumberMustBeBetweenMinAndMax);
                this.category = value;
            }
        }
    }
}
