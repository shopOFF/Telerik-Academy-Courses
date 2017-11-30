using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Inheritance
{
    public class Dog : Animal
    {
        public override string SaySomething()
        {
            return $"Bau Baiu - {base.SaySomething()}";
        }
    }
}
