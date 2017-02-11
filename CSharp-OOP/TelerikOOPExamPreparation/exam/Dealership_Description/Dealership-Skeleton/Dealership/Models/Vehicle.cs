using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Dealership.Common.Enums;
using Dealership.Contracts;
using Dealership.Common;

namespace Dealership.Models
{
    public abstract class Vehicle : IVehicle
    {
        private string make;
        private string model;
        private decimal price;
        private int wheels;
        private VehicleType type;
        private IList<IComment> comments;


        public Vehicle(string make, string model, decimal price)
        {
            this.Make = make;
            this.Model = model;
            this.Wheels = (int)Type;
            this.Price = price;
            this.Comments = new List<IComment>();
        }

        public string Make
        {
            get { return this.make; }
            private set
            {
                //Validator.ValidateIntRange(value.Length, Constants.MinMakeLength, Constants.MaxMakeLength, Constants.StringMustBeBetweenMinAndMax);

                this.make = value;
            }
        }

        public string Model
        {
            get { return this.model; }
            private set
            {
                //Validator.ValidateIntRange(value.Length, Constants.MinModelLength, Constants.MaxModelLength, Constants.StringMustBeBetweenMinAndMax);

                this.model = value;
            }

        }

        public decimal Price
        {
            get { return this.price; }
            private set
            {
                //Validator.ValidateDecimalRange(value, Constants.MinPrice, Constants.MaxPrice, Constants.NumberMustBeBetweenMinAndMax);

                this.price = value;
            }

        }

        public int Wheels
        {
            get { return this.wheels; }
            private set
            {
                //Validator.ValidateIntRange(value, Constants.MinWheels, Constants.MaxWheels, Constants.NumberMustBeBetweenMinAndMax);

                this.wheels = value;
            }
        }

        public VehicleType Type
        {
            get { return this.type; }
            private set
            {
                //Validator.ValidateNull(value, Constants.VehicleCannotBeNull);

                this.type = value;
            }

        }

        public IList<IComment> Comments
        {
            get { return this.comments; }
            private set
            {
                //Validator.ValidateIntRange(value.Count, Constants.MinCommentLength, Constants.MaxCommentLength, Constants.StringMustBeBetweenMinAndMax);

                this.comments = value;
            }

        }

    }
}
