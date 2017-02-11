using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class DecimalToHexadecimal
{
    static string ConvertDecimalToHex(ulong n)
    {
        string decToHex = n.ToString("X");
        return decToHex;
    }
    static void Main()
    {
        ulong n = ulong.Parse(Console.ReadLine());
        Console.WriteLine(ConvertDecimalToHex(n));
    }
}
// 2-ri na4in sa6to mnogo dobar, stava i za drugi broini sistemi prosto vmesto 16 slagame dr 4islo i e ok !!!!!!!!
//  static void Main(string[] args)
//  {
//      Console.WriteLine(Convert.ToString(Int64.Parse(Console.ReadLine()),16).ToString().ToUpper());   //stava i za drugi broini sistemi pod 9 prosto vmesto 16 slagame dr 4islo(bazata na broinata sistema) i
//  }                                                                                                   // (drugite parametri razbira se kato Int64 i dr)e ok mnogo dobro !!!!!!!!
// 

// o6te 2 drugi na4ina :
//using System;

//class DecimalToHex
//{
//    static void Main()
//    {
//        long decNum = long.Parse(Console.ReadLine());
//        string hexNum = "";

//        if (decNum == 0)
//        {
//            hexNum = "0";
//        }
//        else
//        {
//            while (decNum > 0)
//            {
//                long remain = decNum % 16;
//                decNum /= 16;
//                switch (remain)
//                {
//                    case 10: hexNum = "A" + hexNum; break;
//                    case 11: hexNum = "B" + hexNum; break;
//                    case 12: hexNum = "C" + hexNum; break;
//                    case 13: hexNum = "D" + hexNum; break;
//                    case 14: hexNum = "E" + hexNum; break;
//                    case 15: hexNum = "F" + hexNum; break;
//                    default: hexNum = remain + hexNum; break;
//                }
//            }
//        }
//        Console.WriteLine(hexNum);
//    }
//}
//vtori na4in
//using System;
//using System.Globalization;

//class DecimalToHexadecimal
//{
//    static void Main()
//    {
//        Console.Write("Enter your decimal number: ");
//        long dec = long.Parse(Console.ReadLine());

//        string hexaStr = dec.ToString("X");

//        long hexa = long.Parse(hexaStr, NumberStyles.HexNumber);

//        Console.WriteLine(hexaStr);
//    }
//}
 