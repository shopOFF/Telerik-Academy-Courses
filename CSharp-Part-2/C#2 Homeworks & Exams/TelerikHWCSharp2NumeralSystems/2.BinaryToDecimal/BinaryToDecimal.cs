using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

class BinaryToDecimal
{
    static ulong ConvertBinaryToDecimal(string n)
    {
        ulong binaryToDecimal = Convert.ToUInt64(n, 2);  // moje da se naloji i BigInteger da se sloji pri po golemi 4isla
        return binaryToDecimal;

        //re6enie sas sobstven metod:
        //char[] charArrayBinToDec = n.ToCharArray();
        //ulong result = 0;
        //for (int i = 0; i < charArrayBinToDec.Length; i++)
        //{
        //    result = (result * 2) + charArrayBinToDec[i]-'0';
        //}
        //return result;
    }
    static void Main()
    {
        string n = Console.ReadLine();
        Console.WriteLine(ConvertBinaryToDecimal(n));
    }
}

// vtori na4in mnogo dobar sa6to 
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace _02.BinaryToDecimal
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine(Convert.ToUInt64(Console.ReadLine(), 2).ToString());
//        }
//    }
//}