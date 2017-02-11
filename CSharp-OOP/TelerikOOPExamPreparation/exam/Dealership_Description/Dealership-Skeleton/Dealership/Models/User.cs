using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Dealership.Contracts;
using Dealership.Common;
using Dealership.Common.Enums;

namespace Dealership.Models
{
    public class User : IUser
    {
        private string username;
        private string firstName;
        private string lastName;
        public string password;
        private IList<IVehicle> vehicles;

        public User(string username, string fistName, string lastName, string password, Role role)
        {
            this.Username = username;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Password = password;
            this.Role = role;
            this.Vehicles = new List<IVehicle>();
        }

        public string Username
        {
            get { return this.username; }
            set {
                {
                    Validator.ValidateIntRange(
                         value.Length,
                        Constants.MinNameLength,
                         Constants.MaxNameLength,
                         String.Format(Constants.StringMustBeBetweenMinAndMax,
                         this.GetType().FullName + "name", Constants.MinNameLength, Constants.MaxNameLength));

                    this.username = value;
                }
            }
        }

        public string FirstName
        {
            get { return this.firstName; }
            set
            {

                //Validator.ValidateIntRange(
                //     value.Length,
                //    Constants.MinNameLength,
                //     Constants.MaxNameLength,
                //     String.Format(Constants.StringMustBeBetweenMinAndMax,
                //     this.GetType().Name + "First name", Constants.MinNameLength, Constants.MaxNameLength));

                //Validator.ValidateIntRange(value.Length, Constants.MinNameLength, Constants.MaxNameLength, Constants.StringMustBeBetweenMinAndMax);

                this.firstName = value;
            }
        }

        public string LastName
        {
            get { return this.lastName; }
            set
            {
                //Validator.ValidateIntRange(value.Length, Constants.MinNameLength, Constants.MaxNameLength, Constants.StringMustBeBetweenMinAndMax);

                this.lastName = value;
            }
        }

        public string Password
        {
            get { return this.password; }
            set
            {
                //Validator.ValidateIntRange(
                //     value.Length,
                //    Constants.MinPasswordLength,
                //     Constants.MaxPasswordLength,
                //     String.Format(Constants.StringMustBeBetweenMinAndMax,
                //     Password + "password", Constants.MinPasswordLength, Constants.MaxPasswordLength));

                //Validator.ValidateIntRange(value.Length, Constants.MinPasswordLength, Constants.MaxPasswordLength, Constants.StringMustBeBetweenMinAndMax);

                this.password = value;
            }

        }
        public Role Role { get; set; }

        public IList<IVehicle> Vehicles
        {
            get { return this.vehicles; }
            private set
            {
                //Validator.ValidateNull(value, Constants.VehicleCannotBeNull);

                this.vehicles = value;
            }
        }

        public void AddVehicle(IVehicle Vehicle)
        {
            this.Vehicles.Add(Vehicle);
        }

        public void RemoveVehicle(IVehicle Vehicle)
        {
            this.Vehicles.Remove(Vehicle);
        }

        public void AddComment(IComment commentToAdd, IVehicle vehicleToAddComment)
        {
        }

        public void RemoveComment(IComment commentToRemove, IVehicle vehicleToRemoveComment)
        {
            
        }

        public string PrintVehicles()
        {
            var result = new StringBuilder();
            result.AppendLine(string.Format("Username: {0}, FullName: {1} {2}, Role: {3}", this.Username, this.FirstName, this.LastName, this.Role));
            foreach (var vehicle in Vehicles)
            {
                result.AppendLine(vehicle.ToString());
            }
            // Username: { Username}, FullName: { FirstName}
            // { LastName}, Role: { Role}
            return result.ToString();
        }

    }
}
