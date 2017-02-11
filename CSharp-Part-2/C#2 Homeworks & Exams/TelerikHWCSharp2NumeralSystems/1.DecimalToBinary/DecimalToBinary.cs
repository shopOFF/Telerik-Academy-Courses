using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

class DecimalToBinary
{
    static string ConvertDecimalToBinary(BigInteger n)
    {
        string revDecimalToBinary = "";
        string decimalToBinary = "";

        while (n > 0)  // konvertira ni 4isloto v 2dvoi4na no,v na obarnato(parvo sa poslednite ), sled tova trqbva da go obarnem 
        {
            revDecimalToBinary += n % 2;
            n = n / 2;
        }
        for (int i = revDecimalToBinary.Length - 1; i >= 0; i--) // obra6tame polu4enoto 4islo s toci cikal moje i po vtoriq na4in da gi obarnem s char[] i Reverse()..tn... 
        {
            decimalToBinary += revDecimalToBinary[i];
        }
        return decimalToBinary;

        //char[] charArrayBinary = revDecimalToBinary.ToCharArray();
        //Array.Reverse(charArrayBinary);
        //return new string(charArrayBinary);
    }
    static void Main()
    {
        BigInteger n = BigInteger.Parse(Console.ReadLine());
        Console.WriteLine(ConvertDecimalToBinary(n));
    }
}

// vtori variant na cqlata zada4a sa6to mnogo dobar i mnogo barz, direktno 4ete convertira i printi

//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace _01.DecimalToBinary
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine(Convert.ToString(Int64.Parse(Console.ReadLine()),2));
//        }
//    }
//}