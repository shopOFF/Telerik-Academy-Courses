namespace Cosmetics.Products
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using Contracts;
    using Common;
    public class Toothpaste : Product, IToothpaste
    {

        public Toothpaste(string name, string brand, decimal price, GenderType gender, string ingredients)
            : base(name, brand, price, gender)
        {
            this.Name = name;
            this.Brand = brand;
            this.Price = price;
            this.Gender = gender;
            this.Ingredients = ingredients;
        }

        public string Ingredients { get; set; }

        public override string Print()
        {
            StringBuilder result = new StringBuilder();
            result.AppendLine(base.Print());
            result.AppendLine(String.Format("  * Ingredients: {0}", this.Ingredients));
            return result.ToString();
        }
    }
}
