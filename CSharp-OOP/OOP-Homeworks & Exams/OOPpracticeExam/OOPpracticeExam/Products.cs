namespace OOPpracticeExam
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using ProductTypes;
    public abstract class Products
    {
        private string name;

        private string brand;

        private decimal price;


        public GendeType Gender { get; private set; }

        public string Name
        {
            get { return this.name; }
            private set
            {
                if (value == string.Empty)
                {
                    throw new ArgumentException("Name can not be empty!");
                }
                this.name = value;
            }
        }
        public string Brand
        {
            get { return this.brand; }
            private set
            {
                if (value == string.Empty)
                {
                    throw new ArgumentException("Brand can not be empty!");
                }
                this.brand = value;
            }
        }
        public decimal Price
        {
            get { return this.price; }
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException("");
                }
                this.price = value;
            }
        }

    }
}
