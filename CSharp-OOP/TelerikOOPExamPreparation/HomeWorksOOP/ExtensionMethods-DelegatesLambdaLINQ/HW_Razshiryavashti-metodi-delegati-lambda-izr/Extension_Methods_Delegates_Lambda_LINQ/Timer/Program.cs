using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Timer
{
    class Program
    {
        static void Main(string[] args)
        {
            Timer timer = new Timer(1);
            timer.InvokeDelegate();
        }
    }
}
