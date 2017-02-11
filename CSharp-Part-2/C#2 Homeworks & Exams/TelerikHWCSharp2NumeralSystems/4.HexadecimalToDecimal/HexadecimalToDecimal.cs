using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class HexadecimalToDecimal
{
    static ulong ConvertHexToDec(string n)
    {
        ulong hexToDec = Convert.ToUInt64(n, 16);
        return hexToDec;
    }
    static void Main()
    {
        string n = Console.ReadLine();
        Console.WriteLine(ConvertHexToDec(n));
    }
}
// dr na4in
//static void Main(string[] args)
//{
//    Console.WriteLine(Convert.ToInt64(Console.ReadLine(),16));
//}

// o6te 2 drugi na4inia
//using System;

//class HexToDecimal
//{
//    static void Main()
//    {
//        string hexNum = Console.ReadLine();
//        long decNum = 0;
//        long power = 1;
//        for (int i = hexNum.Length - 1; i >= 0; i--)
//        {
//            int num;
//            switch (hexNum[i])
//            {
//                case 'A': num = 10; break;
//                case 'B': num = 11; break;
//                case 'C': num = 12; break;
//                case 'D': num = 13; break;
//                case 'E': num = 14; break;
//                case 'F': num = 15; break;
//                default: num = (int)hexNum[i] - 48; break;
//            }
//            decNum += num * power;
//            power *= 16;
//        }
//        Console.WriteLine(decNum);
//    }
//}

// Vtori na4in:
        //using System;
        //using System.Globalization;
        //string hexNum = Console.ReadLine();

        //long decNum = long.Parse(hexNum, NumberStyles.HexNumber);

        //Console.WriteLine(decNum);