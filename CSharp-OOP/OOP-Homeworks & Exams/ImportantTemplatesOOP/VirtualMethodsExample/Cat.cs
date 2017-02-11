namespace VirtualMethodsExample
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    public class Cat : Animal            // презаписваме си греет и за котката 
    {
        public override string Greet() 
        {
            return "Mqu!";
        }

        public void Sleep()
        {
            Console.WriteLine("murrr");
        }
    }
}
