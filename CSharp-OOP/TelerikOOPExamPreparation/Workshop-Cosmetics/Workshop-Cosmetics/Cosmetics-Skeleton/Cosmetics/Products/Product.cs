namespace Cosmetics.Products
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using Contracts;
    using Common;
    public abstract class Product : IProduct
    {
        private decimal price;
        private string name;
        private string brand;


        public Product(string name, string brand, decimal price, GenderType gender)
        {
            this.Name = name;
            this.Brand = brand;
            this.Price = price;
            this.Gender = gender;
        }

        public GenderType Gender { get; set; }
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

        public string Brand
        {
            get
            {
                return this.brand;
            }
            protected set
            {

                this.brand = value;
            }
        }

        public decimal Price
        {
            get
            {
                return this.price;
            }
            protected set
            {

                this.price = value;
            }
        }

        public virtual string Print()
        {
            //          - {product brand} – { product name}:
            //          *Price: ${ product price}
            //          *For gender: Men / Women / Unisex
            StringBuilder result = new StringBuilder();
            result.AppendLine(String.Format("- {0} - {1}:", this.Brand,this.Name));
            result.AppendLine(String.Format("  * Price: ${0}", this.Price));
            result.AppendLine(String.Format("  * For gender: {0}",this.Gender));

            return result.ToString();
        }
    }
}
