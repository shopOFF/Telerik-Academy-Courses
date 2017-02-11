using Cosmetics.Common;
using Cosmetics.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cosmetics.Products
{
    public class Shampoo : Product, IShampoo
    {

        public Shampoo(string name, string brand, decimal price, GenderType gender, uint milliliters, UsageType usage)
            : base(name, brand, price, gender)
        {
            this.Name = name;
            this.Brand = brand;
            this.Price = price;
            this.Gender = gender;
            this.Milliliters = milliliters;
            this.Usage = usage;

        }

        public uint Milliliters { get; set; }

        public UsageType Usage { get; set; }

        public override string Print()
        {
            StringBuilder result = new StringBuilder();
            result.AppendLine(base.Print());
            result.AppendLine(String.Format("  * Quantity: {0} ml", this.Milliliters));
            result.AppendLine(String.Format("  * Usage: {0}", this.Usage));

            return result.ToString();
        }
    }
}
