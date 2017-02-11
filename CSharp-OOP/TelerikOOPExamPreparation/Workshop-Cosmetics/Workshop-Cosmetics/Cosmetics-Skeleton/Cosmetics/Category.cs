namespace Cosmetics
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using Contracts;
    using Common;
    public class Category : ICategory
    {
        private const int CategoryMaxLength = 2;
        private const int CategoryMinLength = 2;
        private string name;
        private ICollection<IProduct> productList;

        public Category(string name)
        {
            this.Name = name;
            this.productList = new List<IProduct>();
        }

        public ICollection<IProduct> ProductList
        {
            get
            {
                return this.productList;
            }
            private set
            {
                this.productList = value;
            }
        }
        public string Name
        {
            get { return this.name; }
            private set
            {
                Validator.CheckIfStringLengthIsValid(
                    value,
                    CategoryMaxLength,
                    CategoryMinLength,
                    String.Format(GlobalErrorMessages.InvalidStringLength,
                    this.GetType().Name + " name", CategoryMinLength, CategoryMaxLength));
                this.name = value;
            }
        }

        public void AddCosmetics(IProduct cosmetics)
        {
            productList.Add(cosmetics);
        }

        public void RemoveCosmetics(IProduct cosmetics)
        {
            productList.Remove(cosmetics);
        }

        public string Print()
        {
            // {category name} category – {number of products} products/product in total
            StringBuilder result = new StringBuilder();
            result.AppendLine(String.Format("{0} category - {1} {2} in total", this.Name, ProductList.Count, ProductList.Count == 1 ? "product" : "products"));
            foreach (var product in this.ProductList)
            {
                result.AppendLine(product.ToString());
            }
            return result.ToString();
        }
    }
}
