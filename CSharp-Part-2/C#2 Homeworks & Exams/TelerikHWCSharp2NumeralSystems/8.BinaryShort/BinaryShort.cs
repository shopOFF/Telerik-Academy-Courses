using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class BinaryShort
{
    static string ConvertToBinary(short n)
    {
        string decToBin = Convert.ToString(n, 2).PadLeft(16, '0');
        return decToBin;
    }
    static void Main()
    {
        short n = short.Parse(Console.ReadLine());
        Console.WriteLine(ConvertToBinary(n));
    }
}
// vtori na4in
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace _08.BinaryShort
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine(Convert.ToString(short.Parse(Console.ReadLine()),2).PadLeft(16,'0'));
//        }
//    }
//}