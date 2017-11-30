using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Composition
{
    public class AnimalComposition
    {
        public string Name { get; set; }

        public int Age { get; set; }


        public override string ToString()
        {
            return $"I am an animal of type: {this.GetType().Name} {this.Name}---{this.Age}";
        }
    }
}
