using OOP.Inheritance.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Inheritance
{
    public class Animal : IAnimal
    {
        public string Name { get; set; }

        public int Age { get; set; }

        public virtual string SaySomething()
        {
            return $"I am an animal of type: {this.GetType().Name} - {this.Name}---{this.Age}";
        }
    }
}
