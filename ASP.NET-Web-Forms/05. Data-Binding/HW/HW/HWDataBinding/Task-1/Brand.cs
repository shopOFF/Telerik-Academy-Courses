using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HWDataBinding.Task_1
{
    public class Brand
    {
        private string name;

        public Brand(string name)
        {
            this.Name = name;
            this.CollectionOfModels = new List<string>();
        }

        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        public IEnumerable<string> CollectionOfModels { get; set; }
    }
}