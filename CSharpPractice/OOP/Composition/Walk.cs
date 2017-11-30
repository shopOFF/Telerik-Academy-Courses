using OOP.Composition.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Composition
{
    public class Walk : IWalk
    {
        public string Walking()
        {
            return $"I can Walk!";
        }
    }
}
