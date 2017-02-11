using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Dealership.Contracts;
using Dealership.Common;

namespace Dealership.Models
{
    public class Car : Vehicle, IVehicle, ICar
    {

        private int seats;

        public Car(string make, string model, decimal price, int seats)
            : base(make, model, price)
        {
            this.Seats = seats;
        }

        public int Seats
        {
            get { return this.seats; }
            private set
            {
                //Validator.ValidateIntRange(value, Constants.MinSeats, Constants.MaxSeats, Constants.NumberMustBeBetweenMinAndMax);

                this.seats = value;
            }
        }
    }
}
